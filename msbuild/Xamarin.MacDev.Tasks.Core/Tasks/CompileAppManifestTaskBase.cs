using System;
using System.IO;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks
{
	public abstract class CompileAppManifestTaskBase : XamarinTask
	{
		#region Inputs

		// Single-project property that maps to CFBundleIdentifier for Apple platforms
		public string ApplicationId { get; set; }

		// Single-project property that maps to CFBundleShortVersionString for Apple platforms
		public string AppleShortVersion { get; set; }

		// Single-project property that maps to CFBundleDisplayName for Apple platforms
		public string ApplicationTitle { get; set; }

		// Single-project property that maps to CFBundleVersion for Apple platforms
		public string ApplicationVersion { get; set; }

		[Required]
		public string AppBundleName { get; set; }

		public string AppManifest { get; set; }

		[Required]
		public string AssemblyName { get; set; }

		[Required]
		public string CompiledAppManifest { get; set; }

		[Required]
		public bool Debug { get; set; }

		public string DebugIPAddresses { get; set; }

		[Required]
		public string DefaultSdkVersion { get; set; }

		// Single-project property that determines whether other single-project properties should have any effect
		public bool GenerateApplicationManifest { get; set; }

		// If we should write out the app manifest
		[Required]
		public bool WriteAppManifest { get; set; }

		[Required]
		public bool IsAppExtension { get; set; }

		public bool IsXPCService { get; set; }

		public bool IsWatchApp { get; set; }

		public bool IsWatchExtension { get; set; }

		public ITaskItem[] PartialAppManifests { get; set; }

		public string ResourceRules { get; set; }

		[Required]
		public string SdkPlatform { get; set; }

		[Required]
		public bool SdkIsSimulator { get; set; }

		[Required]
		public string SdkVersion { get; set; }

		public string TargetArchitectures { get; set; }
		#endregion

		#region Outputs
		[Output]
		public string BundleIdentifier { get; set; }

		[Output]
		public string ExecutableName { get; set; }

		[Output]
		public string MinimumOSVersion { get; set; }
		#endregion

		protected TargetArchitecture architectures;

		public override bool Execute ()
		{
			PDictionary plist = null;

			if (File.Exists (AppManifest)) {
				try {
					plist = PDictionary.FromFile (AppManifest);
				} catch (Exception ex) {
					LogAppManifestError (MSBStrings.E0010, AppManifest, ex.Message);
					return false;
				}
			} else {
				plist = new PDictionary ();
			}

			if (!string.IsNullOrEmpty (TargetArchitectures) && !Enum.TryParse (TargetArchitectures, out architectures)) {
				LogAppManifestError (MSBStrings.E0012, TargetArchitectures);
				return false;
			}

			if (GenerateApplicationManifest && !string.IsNullOrEmpty (ApplicationId))
				plist.SetIfNotPresent (ManifestKeys.CFBundleIdentifier, ApplicationId);
			plist.SetIfNotPresent (ManifestKeys.CFBundleInfoDictionaryVersion, "6.0");
			plist.SetIfNotPresent (ManifestKeys.CFBundlePackageType, IsAppExtension ? "XPC!" : "APPL");
			plist.SetIfNotPresent (ManifestKeys.CFBundleSignature, "????");
			plist.SetIfNotPresent (ManifestKeys.CFBundleExecutable, AssemblyName);
			plist.SetIfNotPresent (ManifestKeys.CFBundleName, AppBundleName);

			if (GenerateApplicationManifest && !string.IsNullOrEmpty (ApplicationTitle))
				plist.SetIfNotPresent (ManifestKeys.CFBundleDisplayName, ApplicationTitle);

			string defaultBundleVersion = "1.0";
			if (GenerateApplicationManifest && !string.IsNullOrEmpty (ApplicationVersion))
				defaultBundleVersion = ApplicationVersion;
			plist.SetIfNotPresent (ManifestKeys.CFBundleVersion, defaultBundleVersion);

			string defaultBundleShortVersion = null;
			if (GenerateApplicationManifest) {
				if (!string.IsNullOrEmpty (AppleShortVersion))
					defaultBundleShortVersion = AppleShortVersion;
				else if (!string.IsNullOrEmpty (ApplicationVersion))
					defaultBundleShortVersion = ApplicationVersion;
			}
			if (string.IsNullOrEmpty (defaultBundleShortVersion))
				defaultBundleShortVersion = plist.GetCFBundleVersion ();
			plist.SetIfNotPresent (ManifestKeys.CFBundleShortVersionString, defaultBundleShortVersion);

			if (!SetMinimumOSVersion (plist))
				return false;

			if (!Compile (plist))
				return false;

			// Merge with any partial plists...
			MergePartialPlistTemplates (plist);

			// Output return values
			BundleIdentifier = plist.GetCFBundleIdentifier ();
			ExecutableName = plist.GetCFBundleExecutable ();
			MinimumOSVersion = plist.Get<PString> (PlatformFrameworkHelper.GetMinimumOSVersionKey (Platform)).Value;

			// write the resulting app manifest if requested to do so
			if (WriteAppManifest) {
				var tmpFile = Path.GetTempFileName ();
				try {
					plist.Save (tmpFile, true, true);
					if (File.Exists (CompiledAppManifest) && FileUtils.CompareFiles (tmpFile, CompiledAppManifest)) {
						Log.LogMessage (MessageImportance.Low, "The app manifest '{0}' is up-to-date.", CompiledAppManifest);
					} else {
						Directory.CreateDirectory (Path.GetDirectoryName (CompiledAppManifest));
						File.Copy (tmpFile, CompiledAppManifest, true);
					}
				} finally {
					File.Delete (tmpFile);
				}
			}

			return !Log.HasLoggedErrors;
		}

		bool SetMinimumOSVersion (PDictionary plist)
		{
			var minimumOSVersionInManifest = plist?.Get<PString> (PlatformFrameworkHelper.GetMinimumOSVersionKey (Platform))?.Value;
			if (string.IsNullOrEmpty (minimumOSVersionInManifest)) {
				MinimumOSVersion = SdkVersion;
			} else if (!IAppleSdkVersion_Extensions.TryParse (minimumOSVersionInManifest, out var _)) {
				Log.LogError (null, null, null, AppManifest, 0, 0, 0, 0, MSBStrings.E0011, minimumOSVersionInManifest);
				return false;
			} else {
				MinimumOSVersion = minimumOSVersionInManifest;
			}

			if (Platform == ApplePlatform.MacCatalyst) {
				// Convert the min macOS version to the min iOS version, which the rest of our tooling expects.
				if (!MacCatalystSupport.TryGetiOSVersion (Sdks.GetAppleSdk (Platform).GetSdkPath (SdkVersion, false), MinimumOSVersion, out var convertedVersion))
					Log.LogError (MSBStrings.E0187, MinimumOSVersion);
				MinimumOSVersion = convertedVersion;
			}

			// Write out our value
			plist [PlatformFrameworkHelper.GetMinimumOSVersionKey (Platform)] = MinimumOSVersion;

			return true;
		}

		protected abstract bool Compile (PDictionary plist);

		protected void LogAppManifestError (string format, params object[] args)
		{
			// Log an error linking to the Info.plist file
			Log.LogError (null, null, null, AppManifest, 0, 0, 0, 0, format, args);
		}

		protected void LogAppManifestWarning (string format, params object[] args)
		{
			// Log a warning linking to the Info.plist file
			Log.LogWarning (null, null, null, AppManifest, 0, 0, 0, 0, format, args);
		}

		protected void SetValue (PDictionary dict, string key, string value)
		{
			if (dict.ContainsKey (key))
				return;

			if (string.IsNullOrEmpty (value))
				LogAppManifestWarning (MSBStrings.W0106, key);
			else
				dict[key] = value;
		}

		protected void MergePartialPlistDictionary (PDictionary plist, PDictionary partial)
		{
			foreach (var property in partial) {
				if (plist.ContainsKey (property.Key)) {
					var value = plist[property.Key];

					if (value is PDictionary && property.Value is PDictionary) {
						MergePartialPlistDictionary ((PDictionary) value, (PDictionary) property.Value);
					} else {
						plist[property.Key] = property.Value.Clone ();
					}
				} else {
					plist[property.Key] = property.Value.Clone ();
				}
			}
		}

		protected void MergePartialPlistTemplates (PDictionary plist)
		{
			if (PartialAppManifests == null)
				return;

			foreach (var template in PartialAppManifests) {
				PDictionary partial;

				try {
					partial = PDictionary.FromFile (template.ItemSpec);
				} catch (Exception ex) {
					Log.LogError (MSBStrings.E0107, template.ItemSpec, ex.Message);
					continue;
				}

				MergePartialPlistDictionary (plist, partial);
			}
		}
	}
}
