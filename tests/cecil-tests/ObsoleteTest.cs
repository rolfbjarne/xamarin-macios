using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using NUnit.Framework;

using Mono.Cecil;

#nullable enable

namespace Cecil.Tests {

	[TestFixture]
	public class ObsoleteTest {
		// This test verifies that we don't have any obsolete API in .NET that we don't expect to be there
		// in particular that we don't start out with obsolete APIs from the very beginning (such API should have been removed).
		// Any obsoleted API after the first stable .NET release should likely be skipped (until XAMCORE_5_0)
		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformImplementationAssemblyDefinitions))] // call this method with every .net6 library
		public void GetAllObsoletedThings (AssemblyInfo info)
		{
			var assembly = info.Assembly;
			// Make a list of Obsolete things
			var found = new HashSet<string> ();

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
				Console.WriteLine ($"{GetLocation (type.Methods.FirstOrDefault ())} {type.FullName}");
				found.Add (type.FullName);
			}

			// TODO: Events?
			Assert.That (found, Is.Empty, "Obsolete API: add '[EditorBrowsable (EditorBrowsableState.Never)]' for newly obsoleted API to pass this test.");
		}

		bool FilterMember (ICustomAttributeProvider provider)
		{
			// If an API isn't obsolete, it's not under scrutiny from this test.
			if (!HasObsoleteAttribute (provider))
				return false;

			// If the API has an UnsupportedOSPlatform attribute with a version, it means the API is available
			// on earlier OS versions, which means we can't remove it.
			if (HasVersionedUnsupportedOSPlatformAttribute (provider))
				return false;

#if !XAMCORE_5_0
			// If we've hidden an API from the IDE, assume we've decided to keep the API for binary compatibility
			// At least until the next time we can do breaking changes.
			if (HasEditorBrowseableNeverAttribute (provider))
				return false;
#endif

			// I'm bad!
			return true;
		}

		bool HasObsoleteAttribute (ICustomAttributeProvider provider) => HasObsoleteAttribute (provider.CustomAttributes);

		bool HasObsoleteAttribute (IEnumerable<CustomAttribute> attributes) => attributes.Any (a => IsObsoleteAttribute (a));

		bool IsObsoleteAttribute (CustomAttribute attribute) => attribute.AttributeType.Name == "Obsolete" || (attribute.AttributeType.Name == "ObsoleteAttribute");

		bool HasVersionedUnsupportedOSPlatformAttribute (ICustomAttributeProvider provider)
		{
			if (provider?.HasCustomAttributes != true)
				return false;

			foreach (var attr in provider.CustomAttributes) {
				if (attr.AttributeType.Name != "UnsupportedOSPlatformAttribute")
					continue;
				var platform = (string) attr.ConstructorArguments [0].Value;
				// is this a platform string with a version?
				foreach (var ch in platform) {
					if (ch >= '0' && ch <= '9')
						return true;
				}
			}

			// no UnsupportedOSPlatform attribute with a version here
			return false;
		}

		bool HasEditorBrowseableNeverAttribute (ICustomAttributeProvider provider)
		{
			if (provider?.HasCustomAttributes != true)
				return false;

			foreach (var attr in provider.CustomAttributes) {
				if (attr.AttributeType.Name != "EditorBrowsableAttribute")
					continue;
				var state = (EditorBrowsableState) attr.ConstructorArguments [0].Value;
				if (state == EditorBrowsableState.Never)
					return true;
			}

			return false;
		}

		bool Skip (MemberReference member)
		{
			var fullname = member.FullName;

			switch (fullname) {
#if !XAMCORE_5_0
			case "GameKit.IGKPeerPickerControllerDelegate":
			case "GameKit.GKPeerPickerControllerDelegate_Extensions":
			case "GameKit.GKPeerPickerControllerDelegate":
			case "GameKit.GKPeerPickerController":
				return true;
#endif
			default:
				return false;
			}
		}

		static string GetLocation (MethodDefinition method)
		{
			if (method is null)
				return "<no location> ";

			if (method.DebugInformation.HasSequencePoints) {
				var seq = method.DebugInformation.SequencePoints [0];
				return seq.Document.Url + ":" + seq.StartLine + " ";
			}
			return string.Empty;
		}
	}
}
