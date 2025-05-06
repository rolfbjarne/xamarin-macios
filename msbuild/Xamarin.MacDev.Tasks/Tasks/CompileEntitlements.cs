using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;
using System.Linq;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	// https://developer.apple.com/documentation/technotes/tn3125-inside-code-signing-provisioning-profiles
	public class CompileEntitlements : XamarinTask, ITaskCallback, ICancelableTask {
		bool warnedTeamIdentifierPrefix;
		bool warnedAppIdentifierPrefix;

		static readonly HashSet<string> macAllowedProvisioningKeys = new HashSet<string> {
			"com.apple.application-identifier",
			"com.apple.developer.aps-environment",
			"com.apple.developer.default-data-protection",
			//"com.apple.developer.icloud-container-development-container-identifiers",
			//"com.apple.developer.icloud-container-identifiers",
			//"com.apple.developer.icloud-container-environment",
			//"com.apple.developer.icloud-services",
			"com.apple.developer.pass-type-identifiers",
			"com.apple.developer.team-identifier",
			//"com.apple.developer.ubiquity-container-identifiers",
			"get-task-allow",
		};

		static readonly HashSet<string> iOSAllowedProvisioningKeys = new HashSet<string> {
			"application-identifier",
			"aps-environment",
			"beta-reports-active",
			"com.apple.developer.default-data-protection",

			"com.apple.developer.icloud-container-environment",
			"com.apple.developer.icloud-container-identifiers",
			"com.apple.developer.pass-type-identifiers",
			"com.apple.developer.team-identifier",
			"com.apple.developer.ubiquity-container-identifiers",
			"get-task-allow"
		};


		#region Inputs

		[Required]
		public string AppBundleDir { get; set; } = string.Empty;

		[Required]
		public string BundleIdentifier { get; set; } = string.Empty;

		[Required]
		[Output] // this is required to create an output file on Windows. Note: this is a relative path.
		public ITaskItem? CompiledEntitlements { get; set; }

		public ITaskItem [] CustomEntitlements { get; set; } = Array.Empty<ITaskItem> ();

		public bool Debug { get; set; }

		public string Entitlements { get; set; } = string.Empty;

		public string ProvisioningProfile { get; set; } = string.Empty;

		public bool SdkIsSimulator { get; set; }

		[Required]
		public string SdkPlatform { get; set; } = string.Empty;

		[Required]
		public string SdkVersion { get; set; } = string.Empty;

		// whether the default platform entitlements (inside the <platform>.sdk directory inside Xcode) is injected into the final entitlements
		public string InjectDefaultPlatformEntitlements { get; set; } = "";

		[Output]
		public ITaskItem? EntitlementsInExecutable { get; set; }

		[Output]
		public ITaskItem? EntitlementsInSignature { get; set; }

		public string ValidateEntitlements { get; set; } = string.Empty;
		#endregion

		protected string ApplicationIdentifierKey {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
					return "application-identifier";
				case ApplePlatform.MacOSX:
				case ApplePlatform.MacCatalyst:
					return "com.apple.application-identifier";
				default:
					throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
				}
			}
		}

		string DefaultEntitlementsPath {
			get {
				if (ShouldExecuteRemotely ()) {
					return "Entitlements.plist";
				}

				return Path.Combine (Sdks.GetAppleSdk (TargetFrameworkMoniker).GetSdkPath (SdkVersion, false), "Entitlements.plist");
			}
		}

		protected HashSet<string> AllowedProvisioningKeys {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
					return iOSAllowedProvisioningKeys;
				case ApplePlatform.MacOSX:
				case ApplePlatform.MacCatalyst:
					return macAllowedProvisioningKeys;
				default:
					throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
				}
			}
		}

		protected string EntitlementBundlePath {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
					return AppBundleDir;
				case ApplePlatform.MacOSX:
				case ApplePlatform.MacCatalyst:
					return Path.Combine (AppBundleDir, "Contents", "Resources");
				default:
					throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
				}
			}
		}

		bool IsDeviceOrDesktop {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
					return !SdkIsSimulator;
				case ApplePlatform.MacOSX:
				case ApplePlatform.MacCatalyst:
					return true;
				default:
					throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
				}
			}
		}

		PString MergeEntitlementString (PString pstr, MobileProvision? profile, bool expandWildcards, string? key)
		{
			string TeamIdentifierPrefix;
			string AppIdentifierPrefix;

			if (string.IsNullOrEmpty (pstr.Value))
				return (PString) pstr.Clone ();

			if (profile is null && IsDeviceOrDesktop) {
				if (!warnedTeamIdentifierPrefix && pstr.Value.Contains ("$(TeamIdentifierPrefix)")) {
					Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0108b /* Cannot expand $(TeamIdentifierPrefix) in Entitlements.plist without a provisioning profile for key '{0}' with value '{1}' */, key, pstr.Value);
					warnedTeamIdentifierPrefix = true;
				}

				if (!warnedAppIdentifierPrefix && pstr.Value.Contains ("$(AppIdentifierPrefix)")) {
					Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0109b /* Cannot expand $(AppIdentifierPrefix) in Entitlements.plist without a provisioning profile for key '{0}' with value '{1}' */, key, pstr.Value);
					warnedAppIdentifierPrefix = true;
				}
			}

			if (profile is not null && profile.ApplicationIdentifierPrefix.Count > 0)
				AppIdentifierPrefix = profile.ApplicationIdentifierPrefix [0] + ".";
			else
				AppIdentifierPrefix = string.Empty;

			if (profile is not null && profile.TeamIdentifierPrefix.Count > 0)
				TeamIdentifierPrefix = profile.TeamIdentifierPrefix [0] + ".";
			else
				TeamIdentifierPrefix = AppIdentifierPrefix;

			var customTags = new Dictionary<string, string> (StringComparer.OrdinalIgnoreCase) {
				{ "TeamIdentifierPrefix", TeamIdentifierPrefix },
				{ "AppIdentifierPrefix",  AppIdentifierPrefix },
				{ "CFBundleIdentifier",   BundleIdentifier },
			};

			var expanded = StringParserService.Parse (pstr.Value, customTags);

			if (expandWildcards && expanded.IndexOf ('*') != -1) {
				int asterisk = expanded.IndexOf ('*');
				string prefix;

				if (expanded.StartsWith (TeamIdentifierPrefix, StringComparison.Ordinal))
					prefix = TeamIdentifierPrefix;
				else if (expanded.StartsWith (AppIdentifierPrefix, StringComparison.Ordinal))
					prefix = AppIdentifierPrefix;
				else
					prefix = string.Empty;

				var baseBundleIdentifier = expanded.Substring (prefix.Length, asterisk - prefix.Length);

				if (!BundleIdentifier.StartsWith (baseBundleIdentifier, StringComparison.Ordinal))
					expanded = expanded.Replace ("*", BundleIdentifier);
				else
					expanded = prefix + BundleIdentifier;
			}

			return new PString (expanded);
		}

		PArray? MergeEntitlementArray (PArray array, MobileProvision? profile, string? key)
		{
			var result = new PArray ();

			foreach (var item in array) {
				PObject? value;

				if (item is PDictionary)
					value = MergeEntitlementDictionary ((PDictionary) item, profile);
				else if (item is PString)
					value = MergeEntitlementString ((PString) item, profile, false, key);
				else if (item is PArray)
					value = MergeEntitlementArray ((PArray) item, profile, key);
				else
					value = item.Clone ();

				if (value is not null)
					result.Add (value);
			}

			if (result.Count > 0)
				return result;

			return null;
		}

		PDictionary MergeEntitlementDictionary (PDictionary dict, MobileProvision? profile)
		{
			var result = new PDictionary ();

			foreach (var item in dict) {
				PObject? value = item.Value;

				if (value is PDictionary)
					value = MergeEntitlementDictionary ((PDictionary) value, profile);
				else if (value is PString)
					value = MergeEntitlementString ((PString) value, profile, false, item.Key);
				else if (value is PArray)
					value = MergeEntitlementArray ((PArray) value, profile, item.Key);
				else
					value = value.Clone ();

				if (value is not null)
					result.Add (item.Key!, value);
			}

			return result;
		}

		void AddCustomEntitlements (PDictionary dict, MobileProvision? profile)
		{
			if (CustomEntitlements is null)
				return;

			// Process any custom entitlements from the 'CustomEntitlements' item group. These are applied last, and will override anything else.
			// Possible values:
			//     <ItemGroup>
			//         <CustomEntitlements Include="name.of.entitlement" Type="Boolean" Value="true" /> <!-- value can be 'false' too (case doesn't matter) -->
			//         <CustomEntitlements Include="name.of.entitlement" Type="String" Value="stringvalue" />
			//         <CustomEntitlements Include="name.of.entitlement" Type="StringArray" Value="a;b" /> <!-- array of strings, separated by semicolon -->
			//         <CustomEntitlements Include="name.of.entitlement" Type="StringArray" Value="a😁b" ArraySeparator="😁" /> <!-- array of strings, separated by 😁 -->
			//         <CustomEntitlements Include="name.of.entitlement" Type="Remove" /> <!-- This will remove the corresponding entitlement  -->
			//     </ItemGroup>

			foreach (var item in CustomEntitlements) {
				var entitlement = item.ItemSpec;
				var type = item.GetMetadata ("Type");
				var value = item.GetMetadata ("Value");
				switch (type.ToLowerInvariant ()) {
				case "remove":
					if (!string.IsNullOrEmpty (value))
						Log.LogError (MSBStrings.E7102, /* Invalid value '{0}' for the entitlement '{1}' of type '{2}' specified in the CustomEntitlements item group. Expected no value at all. */ value, entitlement, type);
					dict.Remove (entitlement);
					break;
				case "boolean":
					bool booleanValue;
					if (string.Equals (value, "true", StringComparison.OrdinalIgnoreCase)) {
						booleanValue = true;
					} else if (string.Equals (value, "false", StringComparison.OrdinalIgnoreCase)) {
						booleanValue = false;
					} else {
						Log.LogError (MSBStrings.E7103, /* "Invalid value '{0}' for the entitlement '{1}' of type '{2}' specified in the CustomEntitlements item group. Expected 'true' or 'false'." */ value, entitlement, type);
						continue;
					}

					dict [entitlement] = new PBoolean (booleanValue);
					break;
				case "string":
					dict [entitlement] = MergeEntitlementString (new PString (value), profile, entitlement == ApplicationIdentifierKey, entitlement);
					break;
				case "stringarray":
					var arraySeparator = item.GetMetadata ("ArraySeparator");
					if (string.IsNullOrEmpty (arraySeparator))
						arraySeparator = ";";
					var arrayContent = value.Split (new string [] { arraySeparator }, StringSplitOptions.None);
					var parray = new PArray ();
					foreach (var element in arrayContent)
						parray.Add (MergeEntitlementString (new PString (element), profile, entitlement == ApplicationIdentifierKey, entitlement));
					dict [entitlement] = parray;
					break;
				default:
					Log.LogError (MSBStrings.E7104, /* "Unknown type '{0}' for the entitlement '{1}' specified in the CustomEntitlements item group. Expected 'Remove', 'Boolean', 'String', or 'StringArray'." */ type, entitlement);
					break;
				}
			}
		}

		static bool AreEqual (byte [] x, byte [] y)
		{
			if (x.Length != y.Length)
				return false;

			for (int i = 0; i < x.Length; i++) {
				if (x [i] != y [i])
					return false;
			}

			return true;
		}

		static void WriteXcent (PObject doc, string path)
		{
			var buf = doc.ToByteArray (false);

			using (var stream = new MemoryStream ()) {
				stream.Write (buf, 0, buf.Length);

				var src = stream.ToArray ();
				bool save;

				// Note: if the destination file already exists, only re-write it if the content will change
				if (File.Exists (path)) {
					var dest = File.ReadAllBytes (path);

					save = !AreEqual (src, dest);
				} else {
					save = true;
				}

				if (save)
					File.WriteAllBytes (path, src);
			}
		}

		protected virtual PDictionary GetCompiledEntitlements (MobileProvision? profile, IEnumerable<PDictionary> templates)
		{
			var entitlements = new PDictionary ();

			if (profile is not null) {
				// start off with the settings from the provisioning profile
				foreach (var item in profile.Entitlements) {
					var key = item.Key!;
					if (!AllowedProvisioningKeys.Contains (key)) {
						Log.LogMessage ($"The provisioning profile '{profile.Name}' contains the entitlement '{key}', but this entitlement is not in the list of allowed entitlements, and it won't be copied into the app's entitlements.");
						continue;
					}

					var value = item.Value;

					if (value is PDictionary)
						value = MergeEntitlementDictionary ((PDictionary) value, profile);
					else if (value is PString)
						value = MergeEntitlementString ((PString) value, profile, item.Key == ApplicationIdentifierKey, key);
					else if (value is PArray)
						value = MergeEntitlementArray ((PArray) value, profile, key);
					else
						value = value.Clone ();

					if (value is not null)
						entitlements.Add (key, value);
				}
			}

			// merge in the user's values
			foreach (var template in templates) {
				foreach (var item in template) {
					var value = item.Value;
					var key = item.Key!;

					if (key == ApplicationIdentifierKey) {
						var str = value as PString;

						// Ignore ONLY if it is empty, otherwise take the user's value
						if (string.IsNullOrEmpty (str?.Value)) {
							Log.LogMessage ($"The entitlement '{key}' is empty in the provided entitlements file (either user-supplied or the default), and will be ignored.");
							continue;
						}
					}

					if (value is PDictionary)
						value = MergeEntitlementDictionary ((PDictionary) value, profile);
					else if (value is PString)
						value = MergeEntitlementString ((PString) value, profile, key == ApplicationIdentifierKey, key);
					else if (value is PArray)
						value = MergeEntitlementArray ((PArray) value, profile, key);
					else
						value = value.Clone ();

					if (value is not null)
						entitlements [key] = value;
				}
			}

			// If we're building for macOS, and we're building for Debug, and the sandbox is enabled,
			// then also enable the "com.apple.security.network.client" entitlement (it's needed for the debugger to work).
			switch (Platform) {
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				if (Debug && entitlements.TryGetValue ("com.apple.security.app-sandbox", out PBoolean? sandbox) && sandbox.Value)
					entitlements ["com.apple.security.network.client"] = new PBoolean (true);
				break;
			}

			AddCustomEntitlements (entitlements, profile);

			return entitlements;
		}

		PDictionary GetArchivedExpandedEntitlements (IEnumerable<PDictionary> templates, PDictionary compiled)
		{
			var allowed = new HashSet<string> ();

			// the template (user-supplied Entitlements.plist file) is used to create a approved list of keys
			allowed.Add ("com.apple.developer.icloud-container-environment");
			foreach (var template in templates) {
				foreach (var item in template)
					allowed.Add (item.Key!);
			}
			// also allow any custom entitlements
			foreach (var item in CustomEntitlements)
				allowed.Add (item.ItemSpec);

			// now we duplicate the allowed keys from the compiled xcent file
			var archived = new PDictionary ();

			foreach (var item in compiled) {
				var key = item.Key!;
				if (allowed.Contains (key))
					archived.Add (key, item.Value.Clone ());
			}

			return archived;
		}

		// this virtual method is required for tests
		protected virtual MobileProvision GetMobileProvision (MobileProvisionPlatform platform, string name)
		{
			return MobileProvisionIndex.GetMobileProvision (platform, name);
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			MobileProvisionPlatform platform;
			MobileProvision? profile;
			var templates = new List<PDictionary> ();
			PDictionary compiled;
			PDictionary? archived = null;

			switch (SdkPlatform) {
			case "AppleTVSimulator":
			case "AppleTVOS":
				platform = MobileProvisionPlatform.tvOS;
				break;
			case "iPhoneSimulator":
			case "iPhoneOS":
				platform = MobileProvisionPlatform.iOS;
				break;
			case "MacOSX":
				platform = MobileProvisionPlatform.MacOS;
				break;
			case "MacCatalyst":
				platform = MobileProvisionPlatform.MacOS;
				break;
			default:
				Log.LogError (MSBStrings.E0048, SdkPlatform);
				return false;
			}

			if (!string.IsNullOrEmpty (ProvisioningProfile)) {
				if ((profile = GetMobileProvision (platform, ProvisioningProfile)) is null) {
					Log.LogError (MSBStrings.E0049, ProvisioningProfile);
					return false;
				}
			} else {
				profile = null;
			}

			bool injectDefaultEntitlements;
			if (!string.IsNullOrEmpty (InjectDefaultPlatformEntitlements)) {
				injectDefaultEntitlements = string.Equals (InjectDefaultPlatformEntitlements, "true", StringComparison.OrdinalIgnoreCase);
			} else {
				injectDefaultEntitlements = string.IsNullOrEmpty (Entitlements);
			}
			if (injectDefaultEntitlements) {
				try {
					var defaultEntitlements = PDictionary.FromFile (DefaultEntitlementsPath)!;
					templates.Add (defaultEntitlements);
				} catch (Exception ex) {
					Log.LogError (MSBStrings.E0113, DefaultEntitlementsPath, ex.Message);
					return false;
				}
			}

			if (!string.IsNullOrEmpty (Entitlements)) {
				try {
					if (!File.Exists (Entitlements)) {
						Log.LogError (MSBStrings.E0112, Entitlements);
						return false;
					}
					var projectEntitlements = PDictionary.FromFile (Entitlements)!;
					templates.Add (projectEntitlements);
				} catch (Exception ex) {
					Log.LogError (MSBStrings.E0113, Entitlements, ex.Message);
					return false;
				}
			}

			compiled = GetCompiledEntitlements (profile, templates);

			/* The path to the entitlements must be resolved to the full path, because we might want to reference it from a containing project that just references this project,
			  * and in that case it becomes a bit complicated to resolve to a full path on disk when building remotely from Windows. Instead just resolve to a full path here,
			  * and use that from now on. This has to be done from a task, so that we get the full path on the mac when executed remotely from Windows. */
			var compiledEntitlementsFullPath = Path.GetFullPath (CompiledEntitlements!.ItemSpec);
			var compiledEntitlementsFullPathItem = new TaskItem (compiledEntitlementsFullPath);

			Directory.CreateDirectory (Path.GetDirectoryName (compiledEntitlementsFullPath));

			if (SdkIsSimulator) {
				// Any entitlements the app desires are stored inside the executable for simulator builds,
				// and then the executable is signed with a placeholder signature ('-') + just a single
				// entitlement (com.apple.security.get-task-allow). One consequence of storing entitlements
				// this way is that no provisioning profile will be needed to sign the executable.
				var simulatedEntitlements = compiled;
				var simulatedXcent = Path.ChangeExtension (compiledEntitlementsFullPath, "").TrimEnd ('.') + "-Simulated.xcent";
				try {
					WriteXcent (simulatedEntitlements, simulatedXcent);
				} catch (Exception ex) {
					Log.LogError (MSBStrings.E0114, simulatedXcent, ex.Message);
					return false;
				}

				EntitlementsInExecutable = new TaskItem (simulatedXcent);

				// No matter what, I've only been able to make Xcode apply a single entitlement to simulator builds: com.apple.security.get-task-allow
				compiled = new PDictionary ();
				compiled.Add ("com.apple.security.get-task-allow", new PBoolean (true));
			} else {
				archived = GetArchivedExpandedEntitlements (templates, compiled);
			}

			ValidateAppEntitlements (profile, compiled);

			try {
				WriteXcent (compiled, compiledEntitlementsFullPath);
			} catch (Exception ex) {
				Log.LogError (MSBStrings.E0114, compiledEntitlementsFullPathItem, ex.Message);
				return false;
			}

			if (archived is not null)
				SaveArchivedExpandedEntitlements (archived);

			EntitlementsInSignature = compiledEntitlementsFullPathItem;

			return !Log.HasLoggedErrors;
		}

		bool SaveArchivedExpandedEntitlements (PDictionary archived)
		{
			if (Platform == Utils.ApplePlatform.MacCatalyst) {
				// I'm not sure if we need this in catalyst or not, but skip it until it's proven we actually need it.
				return true;
			}

			var path = Path.Combine (EntitlementBundlePath, "archived-expanded-entitlements.xcent");

			if (File.Exists (path)) {
				var plist = PDictionary.FromFile (path)!;
				var src = archived.ToXml ();
				var dest = plist.ToXml ();

				if (src == dest)
					return true;
			}

			try {
				archived.Save (path, true);
			} catch (Exception ex) {
				Log.LogError (MSBStrings.E0115, ex.Message);
				return false;
			}

			return true;
		}

		static bool DoesEntitlementRequireProvisioningProfile (ApplePlatform platform, string? entitlement)
		{
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				return false; // all entitlements require a provisioning profile on mobile devices
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				// some entitlements don't require a provisioning profile on macOS
				// https://developer.apple.com/documentation/technotes/tn3125-inside-code-signing-provisioning-profiles#Entitlements-on-macOS
				switch (entitlement) {
				case "com.apple.security.get-task-allow":
				case "com.apple.security.application-groups":
				case "com.apple.security.app-sandbox":
				case "com.apple.security.network.server":
				case "com.apple.security.network.client":
				case "com.apple.security.device.camera":
				case "com.apple.security.device.microphone":
				case "com.apple.security.device.usb":
				case "com.apple.security.print":
				case "com.apple.security.device.bluetooth":
				case "com.apple.security.personal-information.addressbook":
				case "com.apple.security.personal-information.location":
				case "com.apple.security.personal-information.calendars":
				case "com.apple.security.files.user-selected.read-only":
				case "com.apple.security.files.user-selected.read-write":
				case "com.apple.security.files.downloads.read-only":
				case "com.apple.security.files.downloads.read-write":
				case "com.apple.security.assets.pictures.read-only":
				case "com.apple.security.assets.pictures.read-write":
				case "com.apple.security.assets.music.read-only":
				case "com.apple.security.assets.music.read-write":
				case "com.apple.security.assets.movies.read-only":
				case "com.apple.security.assets.movies.read-write":
				case "com.apple.security.files.all":
				case "com.apple.security.smartcard":
				case "com.apple.security.cs.allow-jit":
				case "com.apple.security.cs.allow-unsigned-executable-memory":
				case "com.apple.security.cs.allow-dyld-environment-variables":
				case "com.apple.security.cs.disable-library-validation":
				case "com.apple.security.cs.disable-executable-page-protection":
				case "com.apple.security.cs.debugger":
				case "com.apple.security.device.audio-input":
				case "com.apple.security.personal-information.photos-library":
				case "com.apple.security.automation.apple-events":
					return false;
				}
				return true;
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, platform));
			}
		}

		void ValidateAppEntitlements (MobileProvision? profile, PDictionary requestedEntitlements)
		{
			var onlyWarn = false;
			switch (ValidateEntitlements?.ToLowerInvariant ()) {
			case "disable":
				return;
			case "warn":
				onlyWarn = true;
				break;
			case null: // default to 'error'
			case "":
			case "error":
				onlyWarn = false;
				break;
			default:
				Log.LogError (7138, null, MSBStrings.E7138, ValidateEntitlements); // Invalid value '{0}' for the 'ValidateEntitlements' property. Valid values are: 'disable', 'warn' or 'error'.
				return;
			}

			if (requestedEntitlements is null || requestedEntitlements.Count == 0) {
				// Everything is OK if the app doesn't request any entitlements.
				return;
			}

			var provisioningEntitlements = profile?.Entitlements;
			var provisioningProfileName = profile?.Name;
			foreach (var kvp in requestedEntitlements) {
				var key = kvp.Key;
				// https://developer.apple.com/documentation/technotes/tn3125-inside-code-signing-provisioning-profiles#Entitlements-on-macOS
				switch (key) {
				case "aps-environment":
				case "com.apple.developer.icloud-container-environment":
					// entitlement is a string, provisioning profile has the entitlement with either a string or an array of strings of valid values for the entitlement
					var requestedEntitlementString = (kvp.Value as PString)?.Value;
					if (profile is null) {
						LogEntitlementValidationFailure (onlyWarn, 7139, MSBStrings.E7139, key); // "The app requests the entitlement '{0}', but no provisioning profile has been specified. Please specify the name of the provisioning profile to use with the 'CodesignProvision' property in the project file.
					} else if (provisioningEntitlements is null || !provisioningEntitlements.TryGetValue<PObject> (key, out var provisioningEntitlement)) {
						LogEntitlementValidationFailure (onlyWarn, 7140, MSBStrings.E7140, key, provisioningProfileName); // The app requests the entitlement '{0}', but the provisioning profile '{1}' does not contain this entitlement.
					} else if (provisioningEntitlement is PArray provisioningEntitlementArray) {
						var allowedEntitlementStrings = provisioningEntitlementArray.ToStringArray ();
						if (allowedEntitlementStrings.Contains (requestedEntitlementString)) {
							Log.LogMessage (MessageImportance.Low, $"The app requests the entitlement '{key}' with the value '{requestedEntitlementString}, which the provisioning profile '{provisioningProfileName}' grants, because it grants these values for this entitlement: {string.Join (", ", allowedEntitlementStrings)}.");
						} else {
							LogEntitlementValidationFailure (onlyWarn, 7152, MSBStrings.E7152, key, requestedEntitlementString, provisioningProfileName, string.Join (", ", allowedEntitlementStrings.ToArray ())); // The app requests the entitlement '{0}' with the value '{1}', but the provisioning profile '{2}' grants it for the values '{3}'.
						}
					} else if (provisioningEntitlement is PString provisioningEntitlementString) {
						var allowedEntitlementString = provisioningEntitlementString.Value;
						if (requestedEntitlementString != allowedEntitlementString) {
							LogEntitlementValidationFailure (onlyWarn, 7137, MSBStrings.E7137, key, requestedEntitlementString, provisioningProfileName, allowedEntitlementString); // The app requests the entitlement '{0}' with the value '{1}', but the provisioning profile '{2}' grants it for the value '{3}'."
						} else {
							Log.LogMessage (MessageImportance.Low, $"The app requests the entitlement '{key}' with the value '{requestedEntitlementString}', which the provisioning profile '{provisioningProfileName}' grants.");
						}
					} else {
						Log.LogMessage (MessageImportance.Low, $"The app requests the entitlement '{key}', which the provisioning profile '{provisioningProfileName}' contains, but with unknown values. Assuming this is OK.");
					}
					break;
				case "com.apple.security.personal-information.calendars":
				case "com.apple.security.personal-information.location":
					// desktop only entitlements
					switch (Platform) {
					case ApplePlatform.iOS:
					case ApplePlatform.TVOS:
						LogEntitlementValidationFailure (onlyWarn, 7151, MSBStrings.E7151, key, Platform.AsString ()); // The app requests the entitlement '{0}', but this entitlement is not allowed on the current platform ({1}). It's only allowed on macOS and Mac Catalyst.
						break;
					case ApplePlatform.MacOSX:
					case ApplePlatform.MacCatalyst:
						break;
					default:
						throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
					}
					break;
				case "com.apple.developer.ubiquity-container-identifiers":
				case "com.apple.developer.icloud-container-identifiers":
				case "com.apple.developer.icloud-services":
					// Only validate that the provisioning profile contains the entitlement, not any values for the entitlement.
					if (profile is null) {
						LogEntitlementValidationFailure (onlyWarn, 7139, MSBStrings.E7139, key); // "The app requests the entitlement '{0}', but no provisioning profile has been specified. Please specify the name of the provisioning profile to use with the 'CodesignProvision' property in the project file.
					} else if (provisioningEntitlements is null || !provisioningEntitlements.TryGetValue<PObject> (key, out var _)) {
						LogEntitlementValidationFailure (onlyWarn, 7140, MSBStrings.E7140, key, provisioningProfileName); // The app requests the entitlement '{0}', but the provisioning profile '{1}' does not contain this entitlement.
					} else {
						Log.LogMessage (MessageImportance.Low, $"The app requests the entitlement '{key}', which the provisioning profile '{provisioningProfileName}' grants.");
					}
					break;
				case null:
				case "":
					continue;
				default:
					// Do some basic validation, but don't show errors or warnings until this code has had some more testing.
					if (DoesEntitlementRequireProvisioningProfile (Platform, key)) {
						if (profile is null) {
							Log.LogMessage (MessageImportance.Low, $"The app requests the required entitlement '{key}', but no provisioning profile has been specified. This is probably not OK.");
						} else if (provisioningEntitlements is null || !provisioningEntitlements.TryGetValue<PObject> (key, out var _)) {
							Log.LogMessage (MessageImportance.Low, $"The app requests the required entitlement '{key}', but provisioning profile {provisioningProfileName} does not grant this entitlement. This is probably not OK.");
						} else {
							Log.LogMessage (MessageImportance.Low, $"The app requests the required entitlement '{key}', which the provisioning profile '{provisioningProfileName}' grants. This is probably OK.");
						}
					} else {
						Log.LogMessage (MessageImportance.Low, $"The app requests entitlement '{key}', which does not require a provisioning profile. This is probably OK.");
					}
					break;
				}
			}
		}

		void LogEntitlementValidationFailure (bool onlyWarn, int code, string message, params object? [] args)
		{
			if (onlyWarn) {
				Log.LogWarning (code, Entitlements, message, args);
			} else {
				Log.LogError (code, Entitlements, message, args);
			}
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => true;

		public bool ShouldCreateOutputFile (ITaskItem item)
		{
			// EntitlementsInExecutable and EntitlementsInSignature are full paths on macOS,
			// which doesn't work correctly when trying to create such output files on Windows.
			var isFullPath = item == EntitlementsInExecutable || item == EntitlementsInSignature;
			return !isFullPath;
		}

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied ()
		{
			if (!string.IsNullOrEmpty (Entitlements))
				yield return new TaskItem (Entitlements);
			else
				yield return new TaskItem (DefaultEntitlementsPath);
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
