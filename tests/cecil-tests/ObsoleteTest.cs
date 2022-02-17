using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using Mono.Cecil;

#nullable enable

namespace Cecil.Tests {

	[TestFixture]
	public class ObsoleteTest {

		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformImplementationAssemblies))] // call this method with every .net6 library
		public void GetAllObsoletedThings (string assemblyPath)
		{
			var assembly = Helper.GetAssembly (assemblyPath, readSymbols: true)!;
			Assert.That (assembly, Is.Not.Null, "Must find the assembly");

			// Make a list of Obsolete things
			HashSet<string> found = new HashSet<string> ();

			foreach (var prop in Helper.FilterProperties (assembly, a => FilterMember (a))) {
				if (Skip (prop))
					continue;
				Console.WriteLine ($"{GetLocation (prop.GetMethod ?? prop.SetMethod)} {prop.FullName}");
				found.Add (prop.FullName);
			}

			foreach (var meth in Helper.FilterMethods (assembly, a => FilterMember (a))) {
				if (Skip (meth))
					continue;
				Console.WriteLine ($"{GetLocation (meth)} {meth.FullName}");
				found.Add (meth.FullName);
			}

			foreach (var type in Helper.FilterTypes (assembly, a => FilterMember (a))) {
				if (Skip (type))
					continue;
				var meth = type.Methods.FirstOrDefault ();
				if (meth is not null)
					Console.WriteLine ($"{GetLocation (meth)} {type.FullName}");
				else
					Console.WriteLine ($"<no location> {type.FullName}");
				found.Add (type.FullName);
			}

			// TODO: Events?
			Console.WriteLine (found.Count);
			Assert.That (found, Is.Empty, "Obsolete API");
		}

		bool FilterMember (ICustomAttributeProvider provider)
		{
			if (!HasObsoleteAttribute (provider))
				return false;

			if (HasUnsupportedOSPlatformAttribute (provider))
				return false;

			if (HasEditorBrowseableAttribute (provider))
				return false;

			return true;
		}

		bool HasObsoleteAttribute (ICustomAttributeProvider provider) => HasObsoleteAttribute (provider.CustomAttributes);

		bool HasObsoleteAttribute (IEnumerable<CustomAttribute> attributes) => attributes.Any (a => IsObsoleteAttribute (a));

		bool IsObsoleteAttribute (CustomAttribute attribute) => attribute.AttributeType.Name == "Obsolete" || (attribute.AttributeType.Name == "ObsoleteAttribute");

		bool HasUnsupportedOSPlatformAttribute (ICustomAttributeProvider provider)
		{
			return provider?.CustomAttributes?.Any (v => v.AttributeType.Name == "UnsupportedOSPlatformAttribute") == true;
		}

		bool HasEditorBrowseableAttribute (ICustomAttributeProvider provider)
		{
			return provider?.CustomAttributes?.Any (v => v.AttributeType.Name == "EditorBrowsableAttribute") == true;
		}

		bool Skip (MemberReference member)
		{
			var ns = member.FullName.Split ('.') [0];

			switch (ns) {
			default:
				return false;
			}
		}

		static string GetLocation (MethodDefinition method)
		{
			if (method.DebugInformation.HasSequencePoints) {
				var seq = method.DebugInformation.SequencePoints [0];
				return seq.Document.Url + ":" + seq.StartLine + " ";
			}
			return string.Empty;
		}
	}
}
