using System.IO;
using System.Linq;

using Xamarin.Bundler;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;

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

		AssemblyDefinition CreateTypeMapRootAssembly (ModuleParameters moduleParameters, IEnumerable<AssemblyDefinition> assemblies)
		{
			AssemblyDefinition rootTypeMapAssembly;

			// .NET 10 doesn't support a separate root type map assembly, so we have to add these attributes to the entry assembly instead.
			var useEntryAssemblyAsRootTypeMapAssembly = Driver.TargetFramework.Version.Major <= 10;

			if (useEntryAssemblyAsRootTypeMapAssembly) {
				rootTypeMapAssembly = Configuration.EntryAssembly;
			} else {
				var rootTypeMapAssemblyName = new AssemblyNameDefinition (App.TypeMapAssemblyName, new Version (1, 0, 0, 0));
				rootTypeMapAssembly = AssemblyDefinition.CreateAssembly (rootTypeMapAssemblyName, rootTypeMapAssemblyName.Name, moduleParameters);
			}

			abr.SetCurrentAssembly (rootTypeMapAssembly);

			foreach (var assembly in assemblies) {
				/*
				 * [assembly: TypeMapAssemblyTarget<NSObject> ("...")]
				 */
				var attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAssemblyTargetAttribute_1_Constructor_String_Type_Type, abr.Foundation_NSObject));
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, "_" + assembly.Name.Name + ".TypeMap"));
				rootTypeMapAssembly.CustomAttributes.Add (attribute);

				/*
				 * [assembly: TypeMapAssemblyTarget<ProtocolAttribute> ("...")]
				 */
				attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAssemblyTargetAttribute_1_Constructor_String_Type_Type, abr.Foundation_ProtocolAttribute));
				attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, "_" + assembly.Name.Name + ".TypeMap"));
				rootTypeMapAssembly.CustomAttributes.Add (attribute);
			}
			abr.SaveCurrentAssembly ();
			abr.ClearCurrentAssembly ();

			// We write the assembly here even if it hasn't changed, because otherwise we'll just end up re-creating
			// it again during the next incremental build.
			if (!useEntryAssemblyAsRootTypeMapAssembly) {
				rootTypeMapAssembly.Write (Path.Combine (App.TypeMapOutputDirectory, rootTypeMapAssembly.Name.Name + ".dll"));
			}
			return rootTypeMapAssembly;
		}

		MethodReference CreateMethodReference (MethodReference methodReference, params TypeReference [] declaringTypeGenericArguments)
		{
			var methodDeclaringType = methodReference.DeclaringType;
			if (methodDeclaringType.HasGenericParameters) {
				if (declaringTypeGenericArguments.Length != methodDeclaringType.GenericParameters.Count)
					throw new ArgumentException ($"The number of generic arguments provided ({declaringTypeGenericArguments.Length}) does not match the number of generic parameters of the method's declaring type ({methodDeclaringType.GenericParameters.Count}).", nameof(declaringTypeGenericArguments));

				methodDeclaringType = methodDeclaringType.MakeGenericInstanceType (declaringTypeGenericArguments);
			}

			var method = new MethodReference (methodReference.Name, methodReference.ReturnType, methodDeclaringType) {
				HasThis = methodReference.HasThis,
				ExplicitThis = methodReference.ExplicitThis,
				CallingConvention = methodReference.CallingConvention,
			};

			foreach (var parameter in methodReference.Parameters)
				method.Parameters.Add (new ParameterDefinition (parameter.ParameterType));

			return abr.CurrentAssembly.MainModule.ImportReference (method);
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

			var createdAssemblies = new List<AssemblyDefinition> ();

			var typesByAssembly = App.StaticRegistrar.Types.GroupBy (v => v.Key.Module.Assembly);
			var skippedTypesByAssembly = App.StaticRegistrar.SkippedTypes.GroupBy (v => v.Skipped.Module.Assembly).ToDictionary (v => v.Key, v => v.ToList ());

			var copyAssemblyParametersFrom = abr.PlatformAssembly.MainModule;
			var assemblyParameters = new ModuleParameters {
				Kind = copyAssemblyParametersFrom.Kind,
				Runtime = copyAssemblyParametersFrom.Runtime,
				Architecture = copyAssemblyParametersFrom.Architecture,
				AssemblyResolver = copyAssemblyParametersFrom.AssemblyResolver,
				MetadataResolver = copyAssemblyParametersFrom.MetadataResolver,
			};

			var rootTypeMapAssembly = CreateTypeMapRootAssembly (assemblyParameters, typesByAssembly.Select (v => v.Key));
			createdAssemblies.Add (rootTypeMapAssembly);

			foreach (var typesInAssembly in typesByAssembly) {
				var assembly = typesInAssembly.Key;
				var types = typesInAssembly.ToList ();

				var typeMapAssemblyName = new AssemblyNameDefinition ("_" + assembly.Name.Name + ".TypeMap", new Version (1, 0, 0, 0));
				var typeMapAssembly = AssemblyDefinition.CreateAssembly (typeMapAssemblyName, typeMapAssemblyName.Name, assemblyParameters);
				createdAssemblies.Add (typeMapAssembly);

				abr.SetCurrentAssembly (typeMapAssembly);

				/*
				 * [assembly: IgnoresAccessChecksTo ("...")]
				 */
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
					var trImported = typeMapAssembly.MainModule.ImportReference (tr);
					var td = tr.Resolve ();
					var objcType = kvp.Value;
					var objcClassName = objcType.Name;
					var isCustomType = App.StaticRegistrar.IsCustomType (objcType);

					/*
					 * [assembly: TypeMap<NSObject> ("Objective-C class name", typeof (...), typeof (...))]
					 */
					var attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAttribute_1_Constructor_String_Type_Type, abr.Foundation_NSObject));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_String, objcClassName));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, trImported));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, trImported));
					typeMapAssembly.CustomAttributes.Add (attribute);

					/*
					 * [..._Proxy]
					 * sealed class ..._Proxy : NSObjectProxy {
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
					 *     return new ... (handle);
					 * }	
					 */
					var createObjectMethod = new MethodDefinition ("CreateObject", MethodAttributes.Public | MethodAttributes.Virtual, abr.Foundation_NSObject);
					createObjectMethod.AddParameter ("handle", abr.System_IntPtr);
					il = createObjectMethod.Body.GetILProcessor ();
					var createObjectCtor = td.Methods.SingleOrDefault (v => v.IsInstanceConstructor () && v.HasParameters && v.Parameters.Count == 1 && v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle"));
					if (createObjectCtor is null) {
						// TODO: AddException (new ProductException (Errors.MX_TypeMapTypeMissingIntPtrCtor, tr.FullName));
						Console.WriteLine ($"Warning: Type '{tr.FullName}' does not have a constructor that takes a single IntPtr parameter. The generated CreateObject method will throw a NotSupportedException if called.");
						il.Append (il.Create (OpCodes.Ldnull)); // TODO: create proper exception
						il.Append (il.Create (OpCodes.Throw));
						// TODO: find intptr ctor too
					} else {
						il.Append (il.Create (OpCodes.Ldarg_1));
						il.Append (il.Create (OpCodes.Newobj, abr.CurrentAssembly.MainModule.ImportReference (createObjectCtor)));
						il.Append (il.Create (OpCodes.Ret));
						proxyType.Methods.Add (createObjectMethod);
					}
					/*
					 * public virtual IntPtr GetClassHandle (out bool is_custom_type)
					 * {
					 * 	   is_custom_type = ...;
					 * 	   return Class.GetHandle ("...");
					 * * }
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

					/*
					 * Add the [TypeMapAssociation] attribute for this type and its proxy
					 *
					 * [assembly: TypeMapAssociation<NSObject> (typeof (...), typeof (...))]
					 */
					attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAssociationAttribute_1_Constructor_Type_Type, abr.Foundation_NSObject));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, trImported));
					attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, proxyType));
					typeMapAssembly.CustomAttributes.Add (attribute);

					if (objcType.IsProtocol && objcType.ProtocolWrapperType is not null) {
						var wrapperType = objcType.ProtocolWrapperType;

						/*
						 * Add the [TypeMapAssociation] attribute for the protocol wrapper type as well
						 *
						 * [assembly: TypeMapAssociation<ProtocolAttribute> (typeof (...), typeof (...))]
						 */
						// TODO: Add custom proxy type that can create instances of the wrapper type
						attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAssociationAttribute_1_Constructor_Type_Type, abr.Foundation_ProtocolAttribute));
						attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, trImported));
						attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, wrapperType));
						typeMapAssembly.CustomAttributes.Add (attribute);
					}
				}

				if (skippedTypesByAssembly.Remove (assembly, out var skippedTypes)) {
					foreach (var skipped in skippedTypes) {
						/*
						 * [assembly: TypeMapAssociation<SkippedObjectiveCTypeUniverse> (typeof (...), typeof (...))]
						 */
						var attribute = new CustomAttribute (CreateMethodReference (abr.TypeMapAssociationAttribute_1_Constructor_Type_Type, abr.ObjCRuntime_SkippedObjectiveCTypeUniverse));
						attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, typeMapAssembly.MainModule.ImportReference (skipped.Skipped)));
						attribute.ConstructorArguments.Add (new CustomAttributeArgument (abr.System_Type, typeMapAssembly.MainModule.ImportReference (skipped.Actual.Type)));
						typeMapAssembly.CustomAttributes.Add (attribute);
					}
				}

				abr.ClearCurrentAssembly ();

				// We write the assembly here even if it hasn't changed, because otherwise we'll just end up re-creating
				// it again during the next incremental build.
				typeMapAssembly.Write (Path.Combine (App.TypeMapOutputDirectory, typeMapAssembly.Name.Name + ".dll"));
			}

			if (skippedTypesByAssembly.Count > 0) {
				// TODO: show error, we shouldn't have skipped types in assemblies that don't have any other registered types
			}

			var resolver = abr.PlatformAssembly.MainModule.AssemblyResolver;
			var getAssembly = resolver.GetType ().GetMethod ("GetAssembly", new Type [] { typeof (string) })!;
			foreach (var asm in createdAssemblies) {
				var fn = Path.Combine (App.TypeMapOutputDirectory, asm.Name.Name + ".dll");
				if (!File.Exists (fn))
					continue;
				var asmDef = getAssembly.Invoke (resolver, new object [] { fn }) as AssemblyDefinition;
				Console.WriteLine ($"Loaded assembly: {asmDef?.FullName ?? "null!"} at {fn}");
			}

			// Report back any exceptions that occurred during the processing.
			exceptions = this.exceptions;
		}
	}
}
