// This is copied from https://github.com/mono/linker/blob/fa9ccbdaf6907c69ef1bb117906f8f012218d57f/src/tuner/Mono.Tuner/ApplyPreserveAttributeBase.cs
// and modified to work without a Profile class.

using Mono.Linker;
using Mono.Linker.Steps;

using Mono.Cecil;
using Mono.Tuner;

#nullable enable

namespace Xamarin.Linker.Steps {

	public partial class ApplyPreserveAttribute : ConfigurationAwareSubStep, IApplyPreserveAttribute {
		ApplyPreserveAttributeImpl impl;

		protected override string Name { get => "Apply Preserve Attribute"; }

		protected override int ErrorCode { get => 2450; }

		public override SubStepTargets Targets => SubStepTargets.Assembly;

		public ApplyPreserveAttribute ()
		{
			impl = new ApplyPreserveAttributeImpl (this);
		}

		public override bool IsActiveFor (AssemblyDefinition assembly)
		{
			// It's either this step, or ApplyPreserveAttributeStep. If ApplyPreserveAttributeStep already ran, then we shouldn't run this step.
			if (Configuration.DerivedLinkContext.DidRunApplyPreserveAttributeStep)
				return false;

			return Annotations.GetAction (assembly) == AssemblyAction.Link;
		}

		protected override void Process (AssemblyDefinition assembly)
		{
			impl.Process (assembly);
		}

		bool IApplyPreserveAttribute.PreserveUnconditional (IMetadataTokenProvider provider)
		{
			if (provider is MethodDefinition method)
				Annotations.SetAction (method, MethodAction.Parse);
			Annotations.Mark (provider);
			return true;
		}

		bool IApplyPreserveAttribute.PreserveType (TypeDefinition type, bool allMembers)
		{
			Annotations.Mark (type);
			if (allMembers)
				Annotations.SetPreserve (type, TypePreserve.All);
			return true;
		}

		bool IApplyPreserveAttribute.PreserveConditional (TypeDefinition onType, MethodDefinition forMethod)
		{
			Annotations.SetAction (forMethod, MethodAction.Parse);
			Annotations.AddPreservedMethod (onType, forMethod);
			return true;
		}
	}

	public interface IApplyPreserveAttribute {
		bool PreserveType (TypeDefinition type, bool allMembers);
		bool PreserveUnconditional (IMetadataTokenProvider provider);
		bool PreserveConditional (TypeDefinition onType, MethodDefinition forMethod);
	}

	public class ApplyPreserveAttributeImpl {
		IApplyPreserveAttribute applyPreserveAttribute;

		public ApplyPreserveAttributeImpl (IApplyPreserveAttribute applyPreserveAttribute)
		{
			this.applyPreserveAttribute = applyPreserveAttribute;
		}

		bool IsPreservedAttribute (ICustomAttributeProvider provider, CustomAttribute attribute, out bool removeAttribute)
		{
			removeAttribute = false;
			TypeReference type = attribute.Constructor.DeclaringType;

			if (type.Name == "PreserveAttribute") {
				// there's no need to keep the [Preserve] attribute in the assembly once it was processed
				removeAttribute = true;
				return true;
			}
			return false;
		}

		public bool Process (AssemblyDefinition assembly)
		{
			var modified = false;
			modified |= BrowseTypes (assembly.MainModule.Types);
			modified |= ProcessAssemblyAttributes (assembly);
			return modified;
		}

		bool ProcessAssemblyAttributes (AssemblyDefinition assembly)
		{
			if (!assembly.HasCustomAttributes)
				return false;

			var modified = false;
			foreach (var attribute in assembly.CustomAttributes) {
				if (!attribute.Constructor.DeclaringType.Is (Namespaces.Foundation, "PreserveAttribute"))
					continue;

				if (!attribute.HasConstructorArguments)
					continue;
				var tr = (attribute.ConstructorArguments [0].Value as TypeReference);
				if (tr is null)
					continue;

				// we do not call `this.ProcessType` since
				// (a) we're potentially processing a different assembly and `is_active` represent the current one
				// (b) it will try to fetch the [Preserve] attribute on the type (and it's not there) as `base` would
				var type = tr.Resolve ();

				modified |= PreserveType (type, attribute);
			}
			return modified;
		}

		bool BrowseTypes (IEnumerable<TypeDefinition> types)
		{
			var modified = false;
			foreach (TypeDefinition type in types) {
				modified |= ProcessType (type);

				if (type.HasFields) {
					foreach (FieldDefinition field in type.Fields)
						modified |= ProcessField (field);
				}

				if (type.HasMethods) {
					foreach (MethodDefinition method in type.Methods)
						modified |= ProcessMethod (method);
				}

				if (type.HasProperties) {
					foreach (PropertyDefinition property in type.Properties)
						modified |= ProcessProperty (property);
				}

				if (type.HasEvents) {
					foreach (EventDefinition @event in type.Events)
						modified |= ProcessEvent (@event);
				}

				if (type.HasNestedTypes) {
					modified |= BrowseTypes (type.NestedTypes);
				}
			}
			return modified;
		}

		bool ProcessType (TypeDefinition type)
		{
			return TryApplyPreserveAttribute (type);
		}

		bool ProcessField (FieldDefinition field)
		{
			var modified = false;
			foreach (var attribute in GetPreserveAttributes (field))
				modified |= Mark (field, attribute);
			return modified;
		}

		bool ProcessMethod (MethodDefinition method)
		{
			return MarkMethodIfPreserved (method);
		}

		bool ProcessProperty (PropertyDefinition property)
		{
			var modified = false;
			foreach (var attribute in GetPreserveAttributes (property)) {
				modified |= MarkMethod (property.GetMethod, attribute);
				modified |= MarkMethod (property.SetMethod, attribute);
			}
			return modified;
		}

		bool ProcessEvent (EventDefinition @event)
		{
			var modified = false;
			foreach (var attribute in GetPreserveAttributes (@event)) {
				modified |= MarkMethod (@event.AddMethod, attribute);
				modified |= MarkMethod (@event.InvokeMethod, attribute);
				modified |= MarkMethod (@event.RemoveMethod, attribute);
			}
			return modified;
		}

		bool MarkMethodIfPreserved (MethodDefinition method)
		{
			var modified = false;
			foreach (var attribute in GetPreserveAttributes (method))
				modified |= MarkMethod (method, attribute);
			return modified;
		}

		bool MarkMethod (MethodDefinition? method, CustomAttribute? preserve_attribute)
		{
			if (method is null)
				return false;

			return Mark (method, preserve_attribute);
		}

		bool Mark (IMetadataTokenProvider provider, CustomAttribute? preserve_attribute)
		{
			if (IsConditionalAttribute (preserve_attribute))
				return PreserveConditional (provider);

			return PreserveUnconditional (provider);
		}

		bool PreserveConditional (IMetadataTokenProvider provider)
		{
			var method = provider as MethodDefinition;
			if (method is null) {
				// workaround to support (uncommon but valid) conditional fields form [Preserve]
				return PreserveUnconditional (provider);
			}

			return applyPreserveAttribute.PreserveConditional (method.DeclaringType, method);
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

		bool PreserveUnconditional (IMetadataTokenProvider provider)
		{
			var modified = false;

			modified |= applyPreserveAttribute.PreserveUnconditional (provider);

			var member = provider as IMemberDefinition;
			if (member is null || member.DeclaringType is null)
				return modified;

			modified |= Mark (member.DeclaringType, null);

			return modified;
		}

		bool TryApplyPreserveAttribute (TypeDefinition type)
		{
			var modified = false;
			foreach (var attribute in GetPreserveAttributes (type)) {
				modified |= PreserveType (type, attribute);
			}
			return modified;
		}

		List<CustomAttribute> GetPreserveAttributes (ICustomAttributeProvider provider)
		{
			var attrs = new List<CustomAttribute> ();

			if (!provider.HasCustomAttributes)
				return attrs;

			var attributes = provider.CustomAttributes;

			for (int i = attributes.Count - 1; i >= 0; i--) {
				var attribute = attributes [i];

				if (!IsPreservedAttribute (provider, attribute, out var remove_attribute))
					continue;

				attrs.Add (attribute);
				if (remove_attribute)
					attributes.RemoveAt (i);
			}

			return attrs;
		}

		protected bool PreserveType (TypeDefinition type, CustomAttribute preserveAttribute)
		{
			var allMembers = false;
			if (preserveAttribute.HasFields) {
				foreach (var named_argument in preserveAttribute.Fields)
					if (named_argument.Name == "AllMembers" && (bool) named_argument.Argument.Value)
						allMembers = true;
			}

			return PreserveType (type, allMembers);
		}

		bool PreserveType (TypeDefinition type, bool allMembers)
		{
			return applyPreserveAttribute.PreserveType (type, allMembers);
		}
	}
}
