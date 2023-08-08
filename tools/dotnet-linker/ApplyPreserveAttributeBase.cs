// This is copied from https://github.com/mono/linker/blob/fa9ccbdaf6907c69ef1bb117906f8f012218d57f/src/tuner/Mono.Tuner/ApplyPreserveAttributeBase.cs
// and modified to work without a Profile class.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

using Mono.Linker;
using Mono.Linker.Steps;

using Mono.Cecil;
using Mono.Cecil.Cil;

using Xamarin.Bundler;
using Xamarin.Linker;

#nullable enable

namespace Mono.Tuner {

	public abstract class ApplyPreserveAttributeBase : ConfigurationAwareSubStep {

		AppBundleRewriter? abr;

		protected override string Name { get => "ApplyPreserveAttribute"; }

		protected override int ErrorCode { get => 2450; }

		AppBundleRewriter Rewriter {
			get => abr!;
		}

		// set 'removeAttribute' to true if you want the preserved attribute to be removed from the final assembly
		protected abstract bool IsPreservedAttribute (ICustomAttributeProvider provider, CustomAttribute attribute, out bool removeAttribute);

		public override SubStepTargets Targets {
			get {
				return SubStepTargets.Type
					| SubStepTargets.Field
					| SubStepTargets.Method
					| SubStepTargets.Property
					| SubStepTargets.Event
					| SubStepTargets.Assembly;
			}
		}

		public override void Initialize (LinkContext context)
		{
			base.Initialize (context);
			abr = new AppBundleRewriter (Configuration);
		}

		public override bool IsActiveFor (AssemblyDefinition assembly)
		{
			return Annotations.GetAction (assembly) == AssemblyAction.Link;
		}

		protected override void Process (AssemblyDefinition assembly)
		{
			Console.WriteLine ($"ProcessAssembly: {assembly}");
		}

		protected override void Process (TypeDefinition type)
		{
			TryApplyPreserveAttribute (type);
		}

		protected override void Process (FieldDefinition field)
		{
			foreach (var attribute in GetPreserveAttributes (field))
				Mark (field, attribute);
		}

		protected override void Process (MethodDefinition method)
		{
			MarkMethodIfPreserved (method);
		}

		protected override void Process (PropertyDefinition property)
		{
			foreach (var attribute in GetPreserveAttributes (property)) {
				MarkMethod (property.GetMethod, attribute);
				MarkMethod (property.SetMethod, attribute);
			}
		}

		protected override void Process (EventDefinition @event)
		{
			foreach (var attribute in GetPreserveAttributes (@event)) {
				MarkMethod (@event.AddMethod, attribute);
				MarkMethod (@event.InvokeMethod, attribute);
				MarkMethod (@event.RemoveMethod, attribute);
			}
		}

		void MarkMethodIfPreserved (MethodDefinition method)
		{
			foreach (var attribute in GetPreserveAttributes (method))
				MarkMethod (method, attribute);
		}

		void MarkMethod (MethodDefinition? method, CustomAttribute? preserve_attribute)
		{
			if (method is null)
				return;

			Mark (method, preserve_attribute);
			Annotations.SetAction (method, MethodAction.Parse);
		}

		void Mark (IMetadataTokenProvider provider, CustomAttribute? preserve_attribute)
		{
			if (IsConditionalAttribute (preserve_attribute)) {
				PreserveConditional (provider);
				return;
			}

			PreserveUnconditional (provider);
		}

		void PreserveConditional (IMetadataTokenProvider provider)
		{
			var method = provider as MethodDefinition;
			if (method is null) {
				// workaround to support (uncommon but valid) conditional fields form [Preserve]
				PreserveUnconditional (provider);
				return;
			}

			Annotations.AddPreservedMethod (method.DeclaringType, method);
			AddDynamicDependencyAttribute (method.DeclaringType, method);
		}

		static bool IsConditionalAttribute (CustomAttribute? attribute)
		{
			if (attribute is null)
				return false;

			foreach (var named_argument in attribute.Fields)
				if (named_argument.Name == "Conditional")
					return (bool) named_argument.Argument.Value;

			return false;
		}

		void PreserveUnconditional (IMetadataTokenProvider provider)
		{
			Annotations.Mark (provider);
			AddDynamicDependencyAttribute (provider);

			var member = provider as IMemberDefinition;
			if (member is null || member.DeclaringType is null)
				return;

			Mark (member.DeclaringType, null);
		}

		void TryApplyPreserveAttribute (TypeDefinition type)
		{
			foreach (var attribute in GetPreserveAttributes (type)) {
				PreserveType (type, attribute);
			}
		}

		List<CustomAttribute> GetPreserveAttributes (ICustomAttributeProvider provider)
		{
			List<CustomAttribute> attrs = new List<CustomAttribute> ();

			if (!provider.HasCustomAttributes)
				return attrs;

			var attributes = provider.CustomAttributes;

			for (int i = attributes.Count - 1; i >= 0; i--) {
				var attribute = attributes [i];

				bool remote_attribute;
				if (!IsPreservedAttribute (provider, attribute, out remote_attribute))
					continue;

				attrs.Add (attribute);
				if (remote_attribute)
					attributes.RemoveAt (i);
			}

			return attrs;
		}

		protected void PreserveType (TypeDefinition type, CustomAttribute preserveAttribute)
		{
			var allMembers = false;
			if (preserveAttribute.HasFields) {
				foreach (var named_argument in preserveAttribute.Fields)
					if (named_argument.Name == "AllMembers" && (bool) named_argument.Argument.Value)
						allMembers = true;
			}

			PreserveType (type, allMembers);
		}

		protected void PreserveType (TypeDefinition type, bool allMembers)
		{
			Annotations.Mark (type);
			AddDynamicDependencyAttribute (type, allMembers);
		}

		MethodDefinition GetModuleConstructor (TypeDefinition type)
		{
			return GetModuleConstructor (type.Module);
		}

		MethodDefinition GetModuleConstructor (IMetadataTokenProvider provider)
		{
			if (provider is TypeDefinition td)
				return GetModuleConstructor (td);
			if (provider is IMemberDefinition md)
				return GetModuleConstructor (md.DeclaringType.Module);
			throw new NotImplementedException ();
		}

		MethodDefinition GetModuleConstructor (ModuleDefinition @module)
		{
			var moduleType = @module.Types.SingleOrDefault (v => v.Name == "<Module>");
			if (moduleType is null)
				throw ErrorHelper.CreateError (99, $"No <Module> type found in {@module.Name}");
			var moduleConstructor = moduleType.GetTypeConstructor ();
			if (moduleConstructor is null) {
				moduleConstructor = moduleType.AddMethod (".cctor", MethodAttributes.Private | MethodAttributes.HideBySig | MethodAttributes.RTSpecialName | MethodAttributes.SpecialName | MethodAttributes.Static, Rewriter.System_Void);
				moduleConstructor.CreateBody (out var il);
				il.Emit (OpCodes.Ret);
			}
			return moduleConstructor;
		}

		void AddDynamicDependencyAttribute (TypeDefinition type, bool allMembers)
		{
			if (abr is null)
				return;

			abr.ClearCurrentAssembly ();
			abr.SetCurrentAssembly (type.Module.Assembly);

			var moduleConstructor = GetModuleConstructor (type);
			var attrib = Rewriter.CreateDynamicDependencyAttribute (allMembers ? DynamicallyAccessedMemberTypes.All : DynamicallyAccessedMemberTypes.None, type);
			moduleConstructor.CustomAttributes.Add (attrib);
			Console.WriteLine ($"Added dynamic dependency attribute to module constructor (allMembers: {allMembers}) for: {type} in {type.Module.Assembly.Name}");

			abr.ClearCurrentAssembly ();
		}

		void AddDynamicDependencyAttribute (TypeDefinition onType, MethodDefinition forMethod)
		{
			var signature = GetSignature (forMethod);
			var attrib = Rewriter.CreateDynamicDependencyAttribute (signature);
			onType.CustomAttributes.Add (attrib);
			Console.WriteLine ($"Added dynamic dependency attribute on {onType} for: {forMethod}");
		}

		void AddDynamicDependencyAttribute (IMetadataTokenProvider member)
		{
			var moduleConstructor = GetModuleConstructor (member);
			var signature = GetSignature (member, true);
			var attrib = Rewriter.CreateDynamicDependencyAttribute (signature);
			moduleConstructor.CustomAttributes.Add (attrib);
			Console.WriteLine ($"Added dynamic dependency attribute to module constructor for: {member}");
		}

		// signature format: https://github.com/dotnet/csharpstandard/blob/standard-v6/standard/documentation-comments.md#d42-id-string-format
		string GetSignature (IMetadataTokenProvider member, bool withType)
		{
			if (member is FieldDefinition fd) {
				var signature = GetSignature (fd);
				if (withType)
					return GetSignature (fd.DeclaringType) + "." + signature;
				return signature;
			}

			if (member is MethodDefinition md) {
				var signature = GetSignature (md);
				if (withType)
					return GetSignature (md.DeclaringType) + "." + signature;
				return signature;
			}

			if (member is TypeDefinition td)
				return GetSignature (td);

			throw new NotImplementedException (member.GetType ().FullName);
		}

		string GetSignature (TypeDefinition type)
		{
			return type.FullName;
		}

		string GetSignature (FieldDefinition field)
		{
			return field.Name.Replace ('.', '#');
		}

		string GetSignature (MethodDefinition method)
		{
			var sb = new StringBuilder ();
			sb.Append (method.Name.Replace ('.', '#'));
			sb.Append ('(');
			for (var i = 0; i < method.Parameters.Count; i++) {
				if (i > 0)
					sb.Append (',');

				var parameterType = method.Parameters [i].ParameterType;
				WriteTypeSignature (sb, parameterType);
			}
			sb.Append (')');

			Console.WriteLine ($"Created signature '{sb}' for {method.FullName}");

			return sb.ToString ();
		}

		void WriteTypeSignature (StringBuilder sb, TypeReference type)
		{
			if (type is ByReferenceType brt) {
				WriteTypeSignature (sb, brt.GetElementType ());
				sb.Append ('@');
				return;
			}

			if (type is ArrayType at) {
				WriteTypeSignature (sb, at.GetElementType ());
				sb.Append ("[]");
				return;
			}

			if (type is PointerType pt) {
				WriteTypeSignature (sb, pt.GetElementType ());
				sb.Append ('*');
				return;
			}

			sb.Append (type.FullName);
		}
	}
}
