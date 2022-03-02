using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using NUnit.Framework;

using Xamarin.iOS.Tasks;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	[TestFixture]
	public class ComputeCodesignItemsTaskTests : TestBase {

		[Test]
		[TestCase (ApplePlatform.iOS, true)]
		[TestCase (ApplePlatform.iOS, false)]
		[TestCase (ApplePlatform.TVOS, true)]
		[TestCase (ApplePlatform.TVOS, false)]
		[TestCase (ApplePlatform.WatchOS, false)]
		[TestCase (ApplePlatform.MacOSX, true)]
		[TestCase (ApplePlatform.MacOSX, false)]
		[TestCase (ApplePlatform.MacCatalyst, true)]
		public void Compute (ApplePlatform platform, bool isDotNet)
		{
			var tmpdir = Cache.CreateTemporaryDirectory ();

			var currentDir = Environment.CurrentDirectory;
			try {
				Environment.CurrentDirectory = tmpdir;
				var codesignItems = new List<ITaskItem> ();
				var codesignProperties = new List<ITaskItem> ();
				var generateDSymItems = new List<ITaskItem> ();
				var nativeStripItems = new List<ITaskItem> ();

				var infos = new CodesignInfo [] {
					new CodesignInfo ("a.dylib", P.All),
					new CodesignInfo ("Contents/b.dylib", P.All),
					new CodesignInfo ("Contents/MonoBundle/c.dylib", P.All),
					new CodesignInfo ("Contents/MonoBundle/SubDir/d.dylib", P.All),
					new CodesignInfo ("M1.metallib", P.All),
					new CodesignInfo ("Resources/M2.metallib", P.All),
					new CodesignInfo ("Contents/Resources/M3.metallib", P.All),
					new CodesignInfo ("Contents/Resources/SubDir/M4.metallib", P.All),
					new CodesignInfo ("Bundle", P.All),
					new CodesignInfo ("PlugIns/P1.appex/P1", P.All),
					new CodesignInfo ("PlugIns/P1.appex/P1a.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Contents/P1b.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Contents/MonoBundle/P1c.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Contents/MonoBundle/SubDir/P1d.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/PM1.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Resources/PM2.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Contents/Resources/PM3.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/Contents/Resources/SubDir/PM4.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/P2", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/P2a.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Contents/P2b.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Contents/MonoBundle/P2c.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Contents/MonoBundle/SubDir/P2d.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/P2M1.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Resources/P2M2.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Contents/Resources/P2M3.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/Contents/Resources/SubDir/P2M4.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/P3", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/P3a.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/P3b.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/MonoBundle/P3c.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/MonoBundle/SubDir/P3d.dylib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/P3M1.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Resources/P3M2.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/Resources/P3M3.metallib", P.All),
					new CodesignInfo ("PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/Resources/SubDir/P3M4.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/W1", P.All),
					new CodesignInfo ("Watch/W1.app/Contents/b.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/Contents/MonoBundle/c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/Contents/MonoBundle/SubDir/d.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/W1M1.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/Resources/W1M2.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/Contents/Resources/W1M3.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/Contents/Resources/SubDir/W1M4.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/WP1", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/W1a.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Contents/W1b.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Contents/MonoBundle/W1c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Contents/MonoBundle/SubDir/W1d.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/W1M1.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Resources/W1M2.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Contents/Resources/W1M3.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/Contents/Resources/SubDir/W1M4.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/WP2", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/W2a.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/W2b.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/MonoBundle/W2c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/MonoBundle/SubDir/W2c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/W2M1.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Resources/W2M2.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/Resources/W2M3.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/Resources/SubDir/W2M4.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/WP3", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/W3a.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/W3b.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/MonoBundle/W3c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/MonoBundle/SubDir/W3c.dylib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/W3M1.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Resources/W3M2.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/Resources/W3M3.metallib", P.All),
					new CodesignInfo ("Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/Resources/SubDir/W3M4.metallib", P.All),
				};

				var allFiles = infos.Select (v => Path.Combine ("Bundle.app", v.ItemSpec)).ToArray ();
				Touch (Path.Combine (tmpdir, "Bundle.app"), allFiles);

				var task = CreateTask<ComputeCodesignItems> ();
				task.AppBundleDir = "Bundle.app";
				task.CodesignItems = codesignItems.ToArray ();
				task.CodesignProperties = codesignProperties.ToArray ();
				task.GenerateDSymItem = generateDSymItems.ToArray ();
				task.NativeStripItem = nativeStripItems.ToArray ();
				task.TargetFrameworkMoniker = TargetFramework.GetTargetFramework (platform, isDotNet).ToString ();
				Assert.IsTrue (task.Execute (), "Execute");

				// FIXME: validate
				var outputCodesignItems = (ITaskItem []) task.OutputCodesignItems;
				Assert.That (outputCodesignItems.Select (v => v.ItemSpec), Is.All.Unique, "Uniqueness");

				var failures = new List<string> ();
				foreach (var info in infos) {
					info.CodesignItem = outputCodesignItems.SingleOrDefault (v => v.ItemSpec == Path.Combine ("Bundle.app", info.ItemSpec));
					if (IsPlatform (info.SignedOn, platform)) {
						if (info.CodesignItem is null) {
							failures.Add ($"Expected '{info.ItemSpec}' to be signed.");
						}
					} else {
						if (info.CodesignItem is not null) {
							failures.Add ($"Did not expect '{info.ItemSpec}' to be signed.");
						}
					}
				}
				Assert.That (failures, Is.Empty, "Failures");
			} finally {
				Environment.CurrentDirectory = currentDir;
			}
		}

		bool IsPlatform (P platforms, ApplePlatform platform)
		{
			switch (platform) {
			case ApplePlatform.iOS:
				return (platforms & P.iOS) == P.iOS;
			case ApplePlatform.TVOS:
				return (platforms & P.tvOS) == P.tvOS;
			case ApplePlatform.MacOSX:
				return (platforms & P.macOS) == P.macOS;
			case ApplePlatform.WatchOS:
				return (platforms & P.watchOS) == P.watchOS;
			case ApplePlatform.MacCatalyst:
				return (platforms & P.MacCatalyst) == P.MacCatalyst;
			default: throw new NotImplementedException ();
			}
		}

		void Touch (string root, params string [] files)
		{
			foreach (var f in files) {
				var file = Path.Combine (root, f);
				Directory.CreateDirectory (Path.GetDirectoryName (file));
				File.WriteAllText (file, string.Empty);
			}
		}

		class CodesignInfo {
			public string ItemSpec;
			public P SignedOn;
			public Dictionary<string, string> Metadata;
			public ITaskItem CodesignItem;

			public CodesignInfo (string item, P signedOn)
			{
				ItemSpec = item;
				SignedOn = signedOn;
			}
		}

		[Flags]
		enum P {
			None = 0,
			iOS = 1,
			tvOS = 2,
			watchOS = 4,
			macOS = 8,
			MacCatalyst = 16,
			Mobile = iOS | tvOS | watchOS,
			Desktop = macOS | MacCatalyst,
			All = Mobile | Desktop,
		}
	}
}

