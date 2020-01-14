using System;
using System.IO;
using System.Linq;

using NUnit.Framework;

namespace Xamarin.iOS.Tasks {

	[TestFixture ("iPhone")]
	[TestFixture ("iPhoneSimulator")]
	public class DotnetTest : ProjectTest {
		public DotnetTest (string platform)
			: base (platform)
		{
		}

		[TestCase ("AppWithExtraArgumentThatOverrides")]
		public void CompareBuilds (string project)
		{
			var net461 = GetTestDirectory ("net461");
			var dotnet = GetTestDirectory ("dotnet");
			FixupTestFiles (dotnet, "dotnet5");

			BuildProject (project, "iPhone", "Debug", projectBaseDir: net461, use_dotnet: false);
			var net461_bundle = AppBundlePath;
			BuildProject (project, "iPhone", "Debug", projectBaseDir: dotnet, use_dotnet: true);
			var dotnet_bundle = AppBundlePath;

			var net461_files = Directory.GetFiles (net461_bundle, "*.*", SearchOption.AllDirectories).Select ((v) => v.Substring (net461_bundle.Length + 1));
			var dotnet_files = Directory.GetFiles (dotnet_bundle, "*.*", SearchOption.AllDirectories).Select ((v) => v.Substring (dotnet_bundle.Length + 1));

			var extra_net461_files = net461_files.Except (dotnet_files);
			var extra_dotnet_files = dotnet_files.Except (net461_files);

			Assert.That (extra_dotnet_files, Is.Empty, "Extra dotnet files");
			Assert.That (extra_net461_files, Is.Empty, "Extra net461 files");

			Console.WriteLine ("Size comparison");
			var total_diff = 0l;
			foreach (var file in dotnet_files) {
				var dotnet_size = new FileInfo (Path.Combine (dotnet_bundle, file)).Length;
				var net461_size = new FileInfo (Path.Combine (net461_bundle, file)).Length;
				if (dotnet_size == net461_size)
					continue;
				var diff = dotnet_size - net461_size;
				Console.WriteLine ($"{file}: {net461_size} bytes -> {dotnet_size} bytes. Diff: {diff}");
				total_diff += diff;
			}  
			Console.WriteLine ($"Size comparison complete. Size diff: {total_diff}");
		}
	}
}
