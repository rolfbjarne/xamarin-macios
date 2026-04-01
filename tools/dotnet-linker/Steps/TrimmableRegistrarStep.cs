using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;

using ObjCRuntime;
using Registrar;
using System.Globalization;
using Mono.Cecil.Rocks;

#nullable enable

namespace Xamarin.Linker {
	public class TrimmableRegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "TrimmableRegistrar";
		protected override int ErrorCode { get; } = 2430;

		AppBundleRewriter abr { get { return Configuration.AppBundleRewriter; } }
		List<Exception> exceptions = new List<Exception> ();

		void AddException (Exception exception)
		{
			if (exceptions is null)
				exceptions = new List<Exception> ();
			exceptions.Add (exception);
		}

		protected override void TryProcess ()
		{
			base.TryProcess ();

			if (App.Registrar != RegistrarMode.TrimmableStatic)
				return;

			Configuration.Application.StaticRegistrar.Register (Configuration.GetNonDeletedAssemblies (this));
		}

		void CreateTypeMapRootAssembly (ModuleParameters moduleParameters, IEnumerable<AssemblyDefinition> assemblies)
		{
			var rootTypeMapAssemblyName = new AssemblyNameDefinition (App.TypeMapAssemblyName, new Version (1, 0, 0, 0));
			var rootTypeMapAssembly = AssemblyDefinition.CreateAssembly (rootTypeMapAssemblyName, rootTypeMapAssemblyName.Name, moduleParameters);

			abr.SetCurrentAssembly (rootTypeMapAssembly);

			foreach (var assembly in assemblies) {
				var attribute = new CustomAttribute (abr.TypeMapAssemblyTargetAttribute_1_Constructor_String_Type_Type);
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, assembly.Name.Name));
				rootTypeMapAssembly.CustomAttributes.Add (attribute);
			}

			abr.ClearCurrentAssembly ();
			// TODO: check if modified before writing (or write to temporary file and move if modified, to avoid unnecessary writes)
			rootTypeMapAssembly.Write (Path.Combine (App.TypeMapOutputDirectory, rootTypeMapAssembly.Name.Name + ".dll"));
		}

		protected override void TryEndProcess (out List<Exception>? exceptions)
		{
			ILProcessor il;

			base.TryEndProcess ();

			if (App.Registrar != RegistrarMode.TrimmableStatic) {
				exceptions = null;
				return;
			}

			Directory.CreateDirectory (App.TypeMapOutputDirectory);

			var typesByAssembly = this.App.StaticRegistrar.Types.GroupBy (v => v.Key.Module.Assembly);

			var copyAssemblyParametersFrom = abr.PlatformAssembly.MainModule;
			var assemblyParameters = new ModuleParameters {
				Kind = copyAssemblyParametersFrom.Kind,
				Runtime = copyAssemblyParametersFrom.Runtime,
				Architecture = copyAssemblyParametersFrom.Architecture,
				AssemblyResolver = copyAssemblyParametersFrom.AssemblyResolver,
				MetadataResolver = copyAssemblyParametersFrom.MetadataResolver,
			};

			CreateTypeMapRootAssembly (assemblyParameters, typesByAssembly.Select (v => v.Key));

			foreach (var typesInAssembly in typesByAssembly) {
				var assembly = typesInAssembly.Key;
				var types = typesInAssembly.ToList ();

				var typeMapAssemblyName = new AssemblyNameDefinition ("_" + assembly.Name + ".TypeMap", new Version (1, 0, 0, 0));
				var typeMapAssembly = AssemblyDefinition.CreateAssembly (typeMapAssemblyName, typeMapAssemblyName.Name, assemblyParameters);

				abr.SetCurrentAssembly (typeMapAssembly);

				var ignoredAccessChecks = new TypeDefinition ("System.Runtime.CompilerServices", "IgnoresAccessChecksToAttribute", TypeAttributes.NotPublic  | TypeAttributes.Sealed | TypeAttributes.BeforeFieldInit, abr.System_Attribute);
				var ignoredAccessChecksCtor = new MethodDefinition (".ctor", MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, abr.System_Void);
				ignoredAccessChecksCtor.AddParameter ("assemblyName", abr.System_String);
				il = ignoredAccessChecksCtor.Body.GetILProcessor ();
				il.Append (il.Create (OpCodes.Ldarg_0));
				il.Append (il.Create (OpCodes.Call, abr.System_Attribute__ctor));
				il.Append (il.Create (OpCodes.Ret));
				ignoredAccessChecks.Methods.Add (ignoredAccessChecksCtor);
				typeMapAssembly.MainModule.Types.Add (ignoredAccessChecks);

				foreach (var kvp in typesInAssembly) {
					var tr = kvp.Key;
					var objcType = kvp.Value;
					var objcClassName = objcType.Name;
					var isCustomType = App.StaticRegistrar.IsCustomType (objcType);
					var attribute = new CustomAttribute (abr.TypeMapAttribute_1_Constructor_String_Type_Type); // TODO: resolve generics
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, objcClassName));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, tr));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, tr));
					typeMapAssembly.CustomAttributes.Add (attribute);

					/*
					* [..._Proxy]
					* sealedclass ..._Proxy : NSObjectProxy {
					* }
					*/
					var proxyType = new TypeDefinition (tr.Namespace, tr.Name + "_Proxy", TypeAttributes.NotPublic | TypeAttributes.Sealed, abr.ObjCRuntime_NSObjectProxyAttribute);
					typeMapAssembly.MainModule.Types.Add (proxyType);

					/* default ctor */
					var ctor = new MethodDefinition (".ctor", MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, abr.System_Void);
					il = ctor.Body.GetILProcessor ();
					il.Append (il.Create (OpCodes.Ldarg_0));
					il.Append (il.Create (OpCodes.Call, abr.ObjCRuntime_NSObjectProxy__ctor));
					il.Append (il.Create (OpCodes.Ret));
					proxyType.Methods.Add (ctor);

					/*
					* public virtual NSObject? CreateObject (IntPtr handle)
					* {
					*     return Runtime.GetNSObject (handle, false);
					* }	
					*/
					var createObjectMethod = new MethodDefinition ("CreateObject", MethodAttributes.Public | MethodAttributes.Virtual, abr.Foundation_NSObject);
					createObjectMethod.AddParameter ("handle", abr.System_IntPtr);
					il = createObjectMethod.Body.GetILProcessor ();
					il.Append (il.Create (OpCodes.Ldarg_1));
					// TODO: Fix to call the actual ctor, not Runtime.GetNSObject, because that will become recursive.
					//il.Append (il.Create (OpCodes.Ldc_I4_0));
					il.Append (il.Create (OpCodes.Call, abr.Runtime_GetNSObject__System_IntPtr));
					il.Append (il.Create (OpCodes.Ret));
					proxyType.Methods.Add (createObjectMethod);
					/*
					* public virtual IntPtr GetClassHandle (out bool is_custom_type)
					* {
					* 	   is_custom_type = ...;
					* 	   return Class.GetHandle ("...");
					* }
					*/
					var getClassHandleMethod = new MethodDefinition ("GetClassHandle", MethodAttributes.Public | MethodAttributes.Virtual, abr.System_IntPtr);
					getClassHandleMethod.AddParameter ("is_custom_type", abr.System_Boolean.MakeByReferenceType ());
					il = getClassHandleMethod.Body.GetILProcessor ();
					il.Append (il.Create (OpCodes.Ldarg_1));
					il.Append (il.Create (isCustomType ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0));
					il.Append (il.Create (OpCodes.Stind_I1));
					il.Append (il.Create (OpCodes.Ldstr, objcClassName));
					il.Append (il.Create (OpCodes.Call, abr.Class_GetHandle__System_String));
					il.Append (il.Create (OpCodes.Ret));
					proxyType.Methods.Add (getClassHandleMethod);

					// We add the proxy type as an attribute to itself
					attribute = new CustomAttribute (ctor);
					proxyType.CustomAttributes.Add (attribute);

					// add the [assembly: TypeMapAssociation] attribute for this type and its proxy
					attribute = new CustomAttribute (abr.TypeMapAssociationAttribute_1_Constructor_Type_Type); // TODO: resolve generics
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, tr));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, proxyType));
					typeMapAssembly.CustomAttributes.Add (attribute);
				}

				abr.ClearCurrentAssembly ();
				// TODO: check if modified before writing (or write to temporary file and move if modified, to avoid unnecessary writes)
				typeMapAssembly.Write (Path.Combine (App.TypeMapOutputDirectory, typeMapAssembly.Name.Name + ".dll"));
			}

			// Report back any exceptions that occurred during the processing.
			exceptions = this.exceptions;
		}
	}
}
