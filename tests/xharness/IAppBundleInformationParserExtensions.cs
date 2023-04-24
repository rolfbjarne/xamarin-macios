using System;
using Microsoft.DotNet.XHarness.iOS.Shared;
using System.Threading.Tasks;
using Microsoft.DotNet.XHarness.iOS.Shared.Utilities;
using System.IO;
using System.Xml;

using Xharness.Targets;

#nullable enable

namespace Xharness
{
	public static class IAppBundleInformationParserExtensions
	{
		public async static Task<AppBundleInformation> ParseFromProject2 (this IAppBundleInformationParser @this, IAppBundleLocator? _appBundleLocator, string projectFilePath, TestTarget target, string buildConfiguration)
		{
			var csproj = new XmlDocument ();
			csproj.LoadWithoutNetworkAccess (projectFilePath);

			string projectDirectory = Path.GetDirectoryName (projectFilePath) ?? throw new DirectoryNotFoundException ($"Cannot find directory of project '{projectFilePath}'");

			string appName = csproj.GetAssemblyName ();
			string infoPlistPath = csproj.GetInfoPListInclude () ?? throw new InvalidOperationException ("Couldn't locate PList include tag");

			var infoPlist = new XmlDocument ();
			string plistPath = Path.Combine (projectDirectory, infoPlistPath.Replace ('\\', Path.DirectorySeparatorChar).Replace ("$(RootTestsDirectory)", Path.GetFullPath (HarnessConfiguration.RootDirectory)));
			infoPlist.LoadWithoutNetworkAccess (plistPath);

			string bundleIdentifier = infoPlist.GetCFBundleIdentifier ();
			string bundleExecutable = infoPlist.GetCFBundleExecutable ();

			Extension? extension = null;
			string extensionPointIdentifier = infoPlist.GetNSExtensionPointIdentifier ();
			if (!string.IsNullOrEmpty (extensionPointIdentifier)) {
				extension = extensionPointIdentifier.ParseFromNSExtensionPointIdentifier ();
			}

			var platform = target.IsSimulator () ? "iPhoneSimulator" : "iPhone";

			string? appPath = null;
			if (_appBundleLocator != null) {
				appPath = await _appBundleLocator.LocateAppBundle (csproj, projectFilePath, target, buildConfiguration);
			}

			appPath ??= csproj.GetOutputPath (platform, buildConfiguration)?.Replace ('\\', Path.DirectorySeparatorChar);

			appPath = Path.Combine (
				projectDirectory,
				appPath ?? string.Empty,
				appName + (extension != null ? ".appex" : ".app"));

			string? arch = csproj.GetMtouchArch (platform, buildConfiguration);

			bool supports32 = arch != null && (Contains (arch, "ARMv7") || Contains (arch, "i386"));

			if (!Directory.Exists (appPath)) {
				throw new DirectoryNotFoundException ($"The app bundle directory `{appPath}` does not exist");
			}

			string launchAppPath = target.ToRunMode () == RunMode.WatchOS
				? Directory.GetDirectories (Path.Combine (appPath, "Watch"), "*.app") [0]
				: appPath;

			return new AppBundleInformation (
				appName,
				bundleIdentifier,
				appPath,
				launchAppPath,
				supports32,
				extension,
				bundleExecutable);
		}

		// This method was added because .NET Standard 2.0 doesn't have case ignorant Contains() for String.
		static bool Contains (string haystack, string needle)
		{
			return haystack.IndexOf (needle, StringComparison.InvariantCultureIgnoreCase) > -1;
		}
	}
}

