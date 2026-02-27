// Copyright 2017 Xamarin Inc.

using Mono.Cecil;
using Mono.Linker;
using Mono.Linker.Steps;
using Mono.Tuner;

using Xamarin.Bundler;
using Xamarin.Tuner;

#nullable enable

namespace Xamarin.Linker.Steps {
	public class PreserveSmartEnumConversionsHandler : ExceptionalMarkHandler {
		Dictionary<TypeDefinition, Tuple<MethodDefinition, MethodDefinition>> cache = new ();
		protected override string Name { get; } = "Smart Enum Conversion Preserver";
		protected override int ErrorCode { get; } = 2200;

		public override void Initialize (LinkContext context, MarkContext markContext)
		{
			base.Initialize (context);
			markContext.RegisterMarkMethodAction (ProcessMethod);
		}

		void Preserve (Tuple<MethodDefinition, MethodDefinition> pair, params MethodDefinition? [] conditions)
		{
			var conds = conditions.Where (v => v is not null).Cast<MethodDefinition> ().ToArray ();
			if (conds.Length == 0)
				return;

			abr.SetCurrentAssembly (conds [0].DeclaringType.Module.Assembly);

			foreach (var condition in conds) {
				abr.AddDynamicDependencyAttribute (condition, pair.Item1);
				abr.AddDynamicDependencyAttribute (condition, pair.Item2);
			}

			abr.SaveCurrentAssembly ();
		}

		void ProcessAttributeProvider (ICustomAttributeProvider provider, params MethodDefinition [] conditions)
		{
			if (provider?.HasCustomAttributes != true)
				return;

			foreach (var ca in provider.CustomAttributes) {
				var tr = ca.Constructor.DeclaringType;

				if (!tr.Is ("ObjCRuntime", "BindAsAttribute"))
					continue;

				if (ca.ConstructorArguments.Count != 1) {
					ErrorHelper.Show (ErrorHelper.CreateWarning (LinkContext.App, 4124, provider, Errors.MT4124_E, provider.AsString (), ca.ConstructorArguments.Count));
					continue;
				}

				var managedType = ca.ConstructorArguments [0].Value as TypeReference;
				var managedEnumType = managedType?.GetElementType ()?.Resolve ();
				if (managedEnumType is null) {
					ErrorHelper.Show (ErrorHelper.CreateWarning (LinkContext.App, 4124, provider, Errors.MT4124_H, provider.AsString (), managedType?.FullName ?? "(null)"));
					continue;
				}

				// We only care about enums, BindAs attributes can be used for other types too.
				if (!managedEnumType.IsEnum)
					continue;

				if (cache.TryGetValue (managedEnumType, out var pair)) {
					Preserve (pair, conditions);
					continue;
				}

				// Find the Extension type
				TypeDefinition? extensionType = null;
				var extensionName = managedEnumType.Name + "Extensions";
				foreach (var type in managedEnumType.Module.Types) {
					if (type.Namespace != managedEnumType.Namespace)
						continue;
					if (type.Name != extensionName)
						continue;
					extensionType = type;
					break;
				}
				if (extensionType is null) {
					Configuration.Log (1, $"Could not find a smart extension type for the enum {managedEnumType.FullName} (due to BindAs attribute on {provider.AsString ()}): most likely this is because the enum isn't a smart enum.");
					continue;
				}

				// Find the GetConstant/GetValue methods
				MethodDefinition? getConstant = null;
				MethodDefinition? getValue = null;

				foreach (var method in extensionType.Methods) {
					if (!method.IsStatic)
						continue;
					if (!method.HasParameters || method.Parameters.Count != 1)
						continue;
					if (method.Name == "GetConstant") {
						if (!method.ReturnType.Is ("Foundation", "NSString"))
							continue;
						if (method.Parameters [0].ParameterType != managedEnumType)
							continue;
						getConstant = method;
					} else if (method.Name == "GetValue") {
						if (!method.Parameters [0].ParameterType.Is ("Foundation", "NSString"))
							continue;
						if (method.ReturnType != managedEnumType)
							continue;
						getValue = method;
					}
				}

				if (getConstant is null) {
					Configuration.Log (1, $"Could not find the GetConstant method on the supposedly smart extension type {extensionType.FullName} for the enum {managedEnumType.FullName} (due to BindAs attribute on {provider.AsString ()}): most likely this is because the enum isn't a smart enum.");
					continue;
				}

				if (getValue is null) {
					Configuration.Log (1, $"Could not find the GetValue method on the supposedly smart extension type {extensionType.FullName} for the enum {managedEnumType.FullName} (due to BindAs attribute on {provider.AsString ()}): most likely this is because the enum isn't a smart enum.");
					continue;
				}

				pair = new Tuple<MethodDefinition, MethodDefinition> (getConstant, getValue);
				cache.Add (managedEnumType, pair);
				Preserve (pair, conditions);
			}
		}

		protected override void Process (MethodDefinition method)
		{
			static bool IsPropertyMethod (MethodDefinition method)
			{
				return method.IsGetter || method.IsSetter;
			}

			ProcessAttributeProvider (method, method);
			ProcessAttributeProvider (method.MethodReturnType, method);

			if (method.HasParameters) {
				foreach (var p in method.Parameters)
					ProcessAttributeProvider (p, method);
			}

			if (IsPropertyMethod (method)) {
				foreach (PropertyDefinition property in method.DeclaringType.Properties)
					if (property.GetMethod == method || property.SetMethod == method) {
						ProcessAttributeProvider (property, property.GetMethod, property.SetMethod);
						break;
					}
			}
		}
	}
}
