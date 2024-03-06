using System;
using System.IO;
using System.Reflection;

using Foundation;

using NUnit.Framework;

namespace MonoTouchFixtures {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public partial class ConfigTest {
		[Test]
		public void Existence ()
		{
#if NATIVEAOT
#if __MACCATALYST__ || __MACOS__
			var config_dir = Path.Combine (Path.GetDirectoryName (AppContext.BaseDirectory.TrimEnd ('/')), "MonoBundle");
#else
			var config_dir = AppContext.BaseDirectory;
#endif
			var config_file = Path.Combine (config_dir, Assembly.GetExecutingAssembly ().GetName ().Name + ".dll.config");
#else
#pragma warning disable IL3000 // 'System.Reflection.Assembly.Location' always returns an empty string for assemblies embedded in a single-file app. If the path to the app directory is needed, consider calling 'System.AppContext.BaseDirectory'.
			var config_file = Assembly.GetExecutingAssembly ().Location + ".config";
#pragma warning restore IL3000
#endif
			Assert.That (config_file, Does.Exist, "existence");
			Assert.That (File.ReadAllText (config_file), Contains.Substring ("<secretMessage>Xamarin rocks</secretMessage>"), "content");
		}
	}
}
