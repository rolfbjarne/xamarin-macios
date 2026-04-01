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

		protected override void TryEndProcess (out List<Exception>? exceptions)
		{
			base.TryEndProcess ();

			if (App.Registrar != RegistrarMode.TrimmableStatic) {
				exceptions = null;
				return;
			}

			var and = new AssemblyNameDefinition ("TrimmableRegistrar", new Version (1, 0, 0, 0));
			var trimmableRegistrarAssembly = AssemblyDefinition.CreateAssembly (and, and.Name, ModuleKind.Dll);

			abr.SetCurrentAssembly (trimmableRegistrarAssembly);
			
			var assembliesWithRegisteredTypes = new List<AssemblyDefinition> ();
			assembliesWithRegisteredTypes.AddRange (ManagedRegistrarStep.AssembliesWithRegisteredTypes); // TODO: fix this to find assemblies elsewhere
			foreach (var asm in assembliesWithRegisteredTypes) {
				var attribute = new CustomAttribute (abr.IgnoresAccessChecksToAttribute_Constructor_String);
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, asm.Name.Name));
				trimmableRegistrarAssembly.CustomAttributes.Add (attribute);
			}	

			var registeredTypes = new List<TypeDefinition> ();
			registeredTypes.AddRange (ManagedRegistrarStep.RegisteredTypes); // TODO: fix this to find it types elsewhere
			foreach (var td in registeredTypes) {
				var objcClassName = td.Name;
				var isCustomType = false;
				var attribute = new CustomAttribute (abr.TypeMapAttribute_1_Constructor_String_Type_Type); // TODO: resolve generics
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, objcClassName));
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, td));
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, td));
				trimmableRegistrarAssembly.CustomAttributes.Add (attribute);

				/*
				 * [..._Proxy]
				 * sealedclass ..._Proxy : NSObjectProxy {
				 * }
				 */
				var proxyType = new TypeDefinition (td.Namespace, td.Name + "_Proxy", TypeAttributes.NotPublic | TypeAttributes.Sealed, abr.ObjCRuntime_NSObjectProxyAttribute);
				trimmableRegistrarAssembly.MainModule.Types.Add (proxyType);

				/* default ctor */
				var ctor = new MethodDefinition (".ctor", MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, abr.System_Void);
				var il = ctor.Body.GetILProcessor ();
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
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, td));
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, proxyType));
				trimmableRegistrarAssembly.CustomAttributes.Add (attribute);
			}

			abr.ClearCurrentAssembly ();

			// Report back any exceptions that occurred during the processing.
			exceptions = this.exceptions;
		}
	}
}
