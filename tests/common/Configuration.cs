using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Xamarin.Utils;

namespace Xamarin.Tests
{
	static partial class Configuration
	{
		public const string XI_ProductName = "MonoTouch";
		public const string XM_ProductName = "Xamarin.Mac";

		const string XS_PATH = "/Applications/Visual Studio.app/Contents/Resources";

		static string mt_root;
		static string ios_destdir;
		static string mac_destdir;
		public static string mt_src_root;
		public static string sdk_version;
		public static string watchos_sdk_version;
		public static string tvos_sdk_version;
		public static string macos_sdk_version;
		public static string xcode_root;
		public static string XcodeVersionString;
		public static string xcode83_root;
		public static string xcode94_root;
#if MONOMAC
		public static string mac_xcode_root;
#endif
		public static Dictionary<string, string> make_config = new Dictionary<string, string> ();

		public static bool include_ios;
		public static bool include_mac;
		public static bool include_tvos;
		public static bool include_watchos;
		public static bool include_device;

		static Version xcode_version;
		public static Version XcodeVersion {
			get {
				if (xcode_version == null)
					xcode_version = Version.Parse (XcodeVersionString);
				return xcode_version;
			}
		}

		static bool? use_system; // if the system-installed XI/XM should be used instead of the local one.
		public static bool UseSystem {
			get {
				if (!use_system.HasValue)
					use_system = !string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("TESTS_USE_SYSTEM"));
				return use_system.Value;
			}
			set {
				use_system = value;
			}
		}

		public static string XcodeLocation {
			get {
				return xcode_root;
			}
		}

		public static string IOS_DESTDIR {
			get { return ios_destdir;  }
		}

		public static string MAC_DESTDIR {
			get { return mac_destdir; }
		}

		// This is the location of an Xcode which is older than the recommended one.
		public static string GetOldXcodeRoot (Version min_version = null)
		{
			var xcodes = Directory.GetDirectories ("/Applications", "Xcode*.app", SearchOption.TopDirectoryOnly);
			var with_versions = new List<Tuple<Version, string>> ();

			var max_version = Version.Parse (XcodeVersionString);
			foreach (var xcode in xcodes) {
				var path = Path.Combine (xcode, "Contents", "Developer");
				var xcode_version = GetXcodeVersion (path);
				if (xcode_version == null)
					continue;
				var version = Version.Parse (xcode_version);
				if (version >= max_version)
					continue;
				if (version.Major == max_version.Major)
					continue;
				if (min_version != null && version < min_version)
					continue;
				with_versions.Add (new Tuple<Version, string> (version, path));
			}

			if (with_versions.Count == 0)
				return null;

			with_versions.Sort ((x, y) =>
			{
				if (x.Item1 > y.Item1)
					return -1;
				else if (x.Item1 < y.Item1)
					return 1;
				else
					return 0;
			});

			return with_versions [0].Item2; // return the most recent Xcode older than the recommended one.
		}

		// This is /Library/Frameworks/Xamarin.iOS.framework/Versions/Current if running
		// against a system XI, otherwise it's the <git checkout>/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current directory.
		public static string MonoTouchRootDirectory {
			get {
				return mt_root;
			}
		}

		static IEnumerable<string> FindConfigFiles (string name)
		{
			var dir = TestAssemblyDirectory;
			while (dir != "/") {
				var file = Path.Combine (dir, name);
				if (File.Exists (file))
					yield return file;
				file = Path.Combine (dir, "tests", name); // when running the msbuild tests.
				if (File.Exists (file))
					yield return file;
				dir = Path.GetDirectoryName (dir);
			}
		}

		static void ParseConfigFiles ()
		{
			var test_config = FindConfigFiles (UseSystem ? "test-system.config" : "test.config");
			if (!test_config.Any ()) {
				// Run 'make test.config' in the tests/ directory
				// First find the tests/ directory
				var dir = TestAssemblyDirectory;
				string tests_dir = null;
				while (dir.Length > 1) {
					var file = Path.Combine (dir, "tests");
					if (Directory.Exists (file)) {
						tests_dir = file;
						break;
					}
					dir = Path.GetDirectoryName (dir);
				}
				if (tests_dir == null)
					throw new Exception ($"Could not find the directory 'tests'. Please run 'make' in the tests/ directory.");
				// Run make
				ExecutionHelper.Execute ("make", new string [] { "-C", tests_dir, "test.config" });
				test_config = FindConfigFiles ("test.config");
			}
			ParseConfigFiles (test_config);
			ParseConfigFiles (FindConfigFiles ("Make.config.local"));
			ParseConfigFiles (FindConfigFiles ("Make.config"));
		}

		static void ParseConfigFiles (IEnumerable<string> files)
		{
			foreach (var file in files)
				ParseConfigFile (file);
		}

		static void ParseConfigFile (string file)
		{
			if (string.IsNullOrEmpty (file))
				return;

			foreach (var line in File.ReadAllLines (file)) {
				var eq = line.IndexOf ('=');
				if (eq == -1)
					continue;
				var key = line.Substring (0, eq);
				if (!make_config.ContainsKey (key))
					make_config [key] = line.Substring (eq + 1);
			}
		}

		static string GetVariable (string variable, string @default)
		{
			var result = Environment.GetEnvironmentVariable (variable);
			if (string.IsNullOrEmpty (result))
				make_config.TryGetValue (variable, out result);
			if (string.IsNullOrEmpty (result))
				result = @default;
			return result;
		}

		static string GetXcodeVersion (string xcode_path)
		{
			var version_plist = Path.Combine (xcode_path, "..", "version.plist");
			if (!File.Exists (version_plist))
				return null;

			return GetPListStringValue (version_plist, "CFBundleShortVersionString");
		}

		public static string GetPListStringValue (string plist, string key)
		{
			var settings = new System.Xml.XmlReaderSettings ();
			settings.DtdProcessing = System.Xml.DtdProcessing.Ignore;
			var doc = new System.Xml.XmlDocument ();
			using (var fs = new StringReader (ReadPListAsXml (plist))) {
				using (var reader = System.Xml.XmlReader.Create (fs, settings)) {
					doc.Load (reader);
					return doc.DocumentElement.SelectSingleNode ($"//dict/key[text()='{key}']/following-sibling::string[1]/text()").Value;
				}
			}
		}

		public static string ReadPListAsXml (string path)
		{
			string tmpfile = null;
			try {
				tmpfile = Path.GetTempFileName ();
				File.Copy (path, tmpfile, true);
				using (var process = new System.Diagnostics.Process ()) {
					process.StartInfo.FileName = "plutil";
					process.StartInfo.Arguments = StringUtils.FormatArguments ("-convert", "xml1", tmpfile);
					process.Start ();
					process.WaitForExit ();
					return File.ReadAllText (tmpfile);
				}
			} finally {
				if (tmpfile != null)
					File.Delete (tmpfile);
			}
		}

		static Configuration ()
		{
			ParseConfigFiles ();

			mt_root = GetVariable ("MONOTOUCH_PREFIX", "/Library/Frameworks/Xamarin.iOS.framework/Versions/Current");
			ios_destdir = GetVariable ("IOS_DESTDIR", null);
			mac_destdir = GetVariable ("MAC_DESTDIR", null);
			sdk_version = GetVariable ("IOS_SDK_VERSION", "8.0");
			watchos_sdk_version = GetVariable ("WATCH_SDK_VERSION", "2.0");
			tvos_sdk_version = GetVariable ("TVOS_SDK_VERSION", "9.0");
			macos_sdk_version = GetVariable ("OSX_SDK_VERSION", "10.12");
			xcode_root = GetVariable ("XCODE_DEVELOPER_ROOT", "/Applications/Xcode.app/Contents/Developer");
			xcode83_root = GetVariable ("XCODE83_DEVELOPER_ROOT", "/Applications/Xcode83.app/Contents/Developer");
			xcode94_root = GetVariable ("XCODE94_DEVELOPER_ROOT", "/Applications/Xcode94.app/Contents/Developer");
			include_ios = !string.IsNullOrEmpty (GetVariable ("INCLUDE_IOS", ""));
			include_mac = !string.IsNullOrEmpty (GetVariable ("INCLUDE_MAC", ""));
			include_tvos = !string.IsNullOrEmpty (GetVariable ("INCLUDE_TVOS", ""));
			include_watchos = !string.IsNullOrEmpty (GetVariable ("INCLUDE_WATCH", ""));
			include_device = !string.IsNullOrEmpty (GetVariable ("INCLUDE_DEVICE", ""));

			XcodeVersionString = GetXcodeVersion (xcode_root);
#if MONOMAC
			mac_xcode_root = xcode_root;
#endif

			if (Directory.Exists (Path.Combine (mt_root, "usr")))
				mt_root = Path.Combine (mt_root, "usr");

			if (!string.IsNullOrEmpty (ios_destdir))
				mt_root = Path.Combine (ios_destdir, mt_root.Substring (1));

			Console.WriteLine ("Test configuration:");
			Console.WriteLine ("  MONOTOUCH_PREFIX={0}", mt_root);
			Console.WriteLine ("  IOS_DESTDIR={0}", ios_destdir);
			Console.WriteLine ("  MAC_DESTDIR={0}", mac_destdir);
			Console.WriteLine ("  SDK_VERSION={0}", sdk_version);
			Console.WriteLine ("  XCODE_ROOT={0}", xcode_root);
#if MONOMAC
			Console.WriteLine ("  MAC_XCODE_ROOT={0}", mac_xcode_root);
#endif
			Console.WriteLine ("  INCLUDE_IOS={0}", include_ios);
			Console.WriteLine ("  INCLUDE_MAC={0}", include_mac);
			Console.WriteLine ("  INCLUDE_TVOS={0}", include_tvos);
			Console.WriteLine ("  INCLUDE_WATCHOS={0}", include_watchos);
		}

		public static string RootPath {
			get {
				var dir = TestAssemblyDirectory;
				var path = Path.Combine (dir, ".git");
				while (!Directory.Exists (path) && path.Length > 3) {
					dir = Path.GetDirectoryName (dir);
					path = Path.Combine (dir, ".git");
				}
				path = Path.GetDirectoryName (path);
				if (!Directory.Exists (path))
					throw new Exception ("Could not find the xamarin-macios repo");
				return path;
			}
		}
			
		static string TestAssemblyDirectory {
			get {
				return TestContext.CurrentContext.TestDirectory;
			}
		}

		public static string SourceRoot {
			get {
				if (mt_src_root == null)
					mt_src_root = RootPath;
				return mt_src_root;
			}
		}

		public static string XamarinIOSDll {
			get {
				return Path.Combine (mt_root, "lib", "mono", "Xamarin.iOS", "Xamarin.iOS.dll");
			}
		}

		public static string XamarinWatchOSDll {
			get {
				return Path.Combine (mt_root, "lib", "mono", "Xamarin.WatchOS", "Xamarin.WatchOS.dll");
			}
		}

		public static string XamarinTVOSDll {
			get {
				return Path.Combine (mt_root, "lib", "mono", "Xamarin.TVOS", "Xamarin.TVOS.dll");
			}
		}

		public static string XamarinMacMobileDll {
			get {
				return Path.Combine (SdkRootXM, "lib", "mono", "Xamarin.Mac", "Xamarin.Mac.dll");
			}
		}

		public static string XamarinMacFullDll {
			get {
				return Path.Combine (SdkRootXM, "lib", "mono", "4.5", "Xamarin.Mac.dll");
			}
		}

		public static string SdkBinDir {
			get {
#if MONOMAC
				return BinDirXM;
#else
				return BinDirXI;
#endif
			}
		}

		public static string TargetDirectoryXI {
			get {
				return make_config ["IOS_DESTDIR"];
			}
		}

		public static string TargetDirectoryXM {
			get {
				return make_config ["MAC_DESTDIR"];
			}
		}

		public static string SdkRoot {
			get {
#if MONOMAC
				return SdkRootXM;
#else
				return SdkRootXI;
#endif
			}
		}

		public static string SdkRootXI {
			get {
				return Path.Combine (TargetDirectoryXI, "Library", "Frameworks", "Xamarin.iOS.framework", "Versions", "Current");
			}
		}

		public static string SdkRootXM {
			get {
				return Path.Combine (TargetDirectoryXM, "Library", "Frameworks", "Xamarin.Mac.framework", "Versions", "Current");
			}
		}

		public static string BinDirXI {
			get {
				return Path.Combine (SdkRootXI, "bin");
			}
		}

		public static string BinDirXM {
			get {
				return Path.Combine (SdkRootXM, "bin");
			}
		}

		static string XSIphoneDir {
			get {
				return Path.Combine (XS_PATH, "lib", "monodevelop", "AddIns", "MonoDevelop.IPhone");
			}
		}

		public static string BtouchPath {
			get {
				return Path.Combine (SdkBinDir, "btouch-native");
			}
		}

		public static string BGenPath {
			get {
				return Path.Combine (SdkBinDir, "bgen");
			}
		}

		public static string BGenClassicPath {
			get {
				return Path.Combine (BinDirXM, "bgen-classic");
			}
		}

		public static string MmpPath {
			get {
				return Path.Combine (BinDirXM, "mmp");
			}
		}

		public static string MtouchPath {
			get {
				return Path.Combine (BinDirXI, "mtouch");
			}
		}

		public static string MlaunchPath {
			get {
				var env = Environment.GetEnvironmentVariable ("MLAUNCH_PATH");
				if (!string.IsNullOrEmpty (env))
					return env;
				return Path.Combine (BinDirXI, "mlaunch");
			}
		}

#if !XAMMAC_TESTS
		public static string GetBaseLibrary (Profile profile)
		{
			switch (profile) {
			case Profile.iOS:
				return XamarinIOSDll;
			case Profile.tvOS:
				return XamarinTVOSDll;
			case Profile.watchOS:
				return XamarinWatchOSDll;
			case Profile.macOSMobile:
				return XamarinMacMobileDll;
			case Profile.macOSFull:
				return XamarinMacFullDll;
			default:
				throw new NotImplementedException ();
			}
		}

		public static string GetTargetFramework (Profile profile)
		{
			switch (profile) {
			case Profile.iOS:
				return "Xamarin.iOS,v1.0";
			case Profile.tvOS:
				return "Xamarin.TVOS,v1.0";
			case Profile.watchOS:
				return "Xamarin.WatchOS,v1.0";
			case Profile.macOSMobile:
				return "Xamarin.Mac,Version=v2.0,Profile=Mobile";
			case Profile.macOSFull:
				return "Xamarin.Mac,Version=v4.5,Profile=Full";
			case Profile.macOSSystem:
				return "Xamarin.Mac,Version=v4.5,Profile=System";
			default:
				throw new NotImplementedException ();
			}
		}

		public static string GetSdkVersion (Profile profile)
		{
			switch (profile) {
			case Profile.iOS:
				return Configuration.sdk_version;
			case Profile.tvOS:
				return Configuration.tvos_sdk_version;
			case Profile.watchOS:
				return Configuration.watchos_sdk_version;
			case Profile.macOSFull:
			case Profile.macOSMobile:
			case Profile.macOSSystem:
				return Configuration.macos_sdk_version;
			default:
				throw new NotImplementedException ();
			}
		}

		public static string GetSdkPath (Profile profile, bool is_device)
		{
			switch (profile) {
			case Profile.iOS:
				return Path.Combine (MonoTouchRootDirectory, "SDKs", "MonoTouch." + (is_device ? "iphoneos" : "iphonesimulator") + ".sdk");
			case Profile.tvOS:
				return Path.Combine (MonoTouchRootDirectory, "SDKs", "Xamarin.AppleTV" + (is_device ? "OS" : "Simulator") + ".sdk");
			case Profile.watchOS:
				return Path.Combine (MonoTouchRootDirectory, "SDKs", "Xamarin.Watch" + (is_device ? "OS" : "Simulator") + ".sdk");
			case Profile.macOSFull:
			case Profile.macOSMobile:
			case Profile.macOSSystem:
				return Path.Combine (SdkRootXM, "lib");
			default:
				throw new NotImplementedException (profile.ToString ());
			}
		}

		public static string GetCompiler (Profile profile, IList<string> args, bool use_csc = true)
		{
			args.Add ($"-lib:{Path.GetDirectoryName (GetBaseLibrary (profile))}");
			if (use_csc) {
				return "/Library/Frameworks/Mono.framework/Commands/csc";
			} else {
				return "/Library/Frameworks/Mono.framework/Commands/mcs";
			}
		}
#endif // !XAMMAC_TESTS
		
		public static string NuGetPackagesDirectory {
			get {
				return Path.Combine (RootPath, "packages");
			}
		}

		public static string XIBuildPath {
			get { return Path.GetFullPath (Path.Combine (RootPath, "tools", "xibuild", "xibuild")); }
		}

		public static void AssertDeviceAvailable ()
		{
			if (include_device)
				return;
			Assert.Ignore ("This build does not include device support.");
		}
	}
}
