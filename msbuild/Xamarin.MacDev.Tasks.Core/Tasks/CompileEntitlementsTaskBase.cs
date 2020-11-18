using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;

namespace Xamarin.MacDev.Tasks
{
	public abstract class CompileEntitlementsTaskBase : XamarinTask
	{
		bool warnedTeamIdentifierPrefix;
		bool warnedAppIdentifierPrefix;

		#region Inputs

		[Required]
		public string AppBundleDir { get; set; }

		[Required]
		public string AppIdentifier { get; set; }

		[Required]
		public string BundleIdentifier { get; set; }

		[Required]
		public ITaskItem CompiledEntitlements { get; set; }

		public bool Debug { get; set; }

		public string Entitlements { get; set; }

		[Required]
		public bool IsAppExtension { get; set; }

		public string ProvisioningProfile { get; set; }

		[Required]
		public string SdkDevPath { get; set; }

		public bool SdkIsSimulator { get; set; }

		[Required]
		public string SdkPlatform { get; set; }

		[Required]
		public string SdkVersion { get; set; }

		[Output]
		public ITaskItem EntitlementsInExecutable { get; set; }

		[Output]
		public ITaskItem EntitlementsInSignature { get; set; }

		#endregion

		protected abstract string ApplicationIdentifierKey { get; }

		protected abstract string DefaultEntitlementsPath { get; }

		protected abstract HashSet<string> AllowedProvisioningKeys { get; }

		protected abstract string EntitlementBundlePath { get; }

		protected virtual bool MergeProfileEntitlements {
			get { return true; }
		}

		PString MergeEntitlementString (PString pstr, MobileProvision profile, bool expandWildcards)
		{
			string TeamIdentifierPrefix;
			string AppIdentifierPrefix;

			if (string.IsNullOrEmpty (pstr.Value))
				return (PString) pstr.Clone ();

			if (profile == null) {
				if (!warnedTeamIdentifierPrefix && pstr.Value.Contains ("$(TeamIdentifierPrefix)")) {
					Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0108);
					warnedTeamIdentifierPrefix = true;
				}
				
				if (!warnedAppIdentifierPrefix && pstr.Value.Contains ("$(AppIdentifierPrefix)")) {
					Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0109);
					warnedAppIdentifierPrefix = true;
				}
			}

			if (profile != null && profile.ApplicationIdentifierPrefix.Count > 0)
				AppIdentifierPrefix = profile.ApplicationIdentifierPrefix[0] + ".";
			else
				AppIdentifierPrefix = string.Empty;

			if (profile != null && profile.TeamIdentifierPrefix.Count > 0)
				TeamIdentifierPrefix = profile.TeamIdentifierPrefix[0] + ".";
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

		PArray MergeEntitlementArray (PArray array, MobileProvision profile)
		{
			var result = new PArray ();

			foreach (var item in array) {
				PObject value;

				if (item is PDictionary)
					value = MergeEntitlementDictionary ((PDictionary) item, profile);
				else if (item is PString)
					value = MergeEntitlementString ((PString) item, profile, false);
				else if (item is PArray)
					value = MergeEntitlementArray ((PArray) item, profile);
				else
					value = item.Clone ();

				if (value != null)
					result.Add (value);
			}

			if (result.Count > 0)
				return result;

			return null;
		}

		PDictionary MergeEntitlementDictionary (PDictionary dict, MobileProvision profile)
		{
			var result = new PDictionary ();

			foreach (var item in dict) {
				PObject value = item.Value;

				if (value is PDictionary)
					value = MergeEntitlementDictionary ((PDictionary) value, profile);
				else if (value is PString)
					value = MergeEntitlementString ((PString) value, profile, false);
				else if (value is PArray)
					value = MergeEntitlementArray ((PArray) value, profile);
				else
					value = value.Clone ();

				if (value != null)
					result.Add (item.Key, value);
			}

			return result;
		}

		static bool AreEqual (byte[] x, byte[] y)
		{
			if (x.Length != y.Length)
				return false;

			for (int i = 0; i < x.Length; i++) {
				if (x[i] != y[i])
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

		protected virtual PDictionary GetCompiledEntitlements (MobileProvision profile, PDictionary template)
		{
			var entitlements = new PDictionary ();

			if (profile != null && MergeProfileEntitlements) {
				// start off with the settings from the provisioning profile
				foreach (var item in profile.Entitlements) {
					if (!AllowedProvisioningKeys.Contains (item.Key))
						continue;

					var value = item.Value;

					if (item.Key == "com.apple.developer.icloud-container-environment")
						value = new PString ("Development");
					else if (value is PDictionary)
						value = MergeEntitlementDictionary ((PDictionary) value, profile);
					else if (value is PString)
						value = MergeEntitlementString ((PString) value, profile, item.Key == ApplicationIdentifierKey);
					else if (value is PArray)
						value = MergeEntitlementArray ((PArray) value, profile);
					else
						value = value.Clone ();

					if (value != null)
						entitlements.Add (item.Key, value);
				}
			}

			// merge in the user's values
			foreach (var item in template) {
				var value = item.Value;

				if (item.Key == "com.apple.developer.ubiquity-container-identifiers" ||
				    item.Key == "com.apple.developer.icloud-container-identifiers" ||
				    item.Key == "com.apple.developer.icloud-container-environment" ||
				    item.Key == "com.apple.developer.icloud-services") {
					if (profile == null)
						Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0110, item.Key);
					else if (!profile.Entitlements.ContainsKey (item.Key))
						Log.LogWarning (null, null, null, Entitlements, 0, 0, 0, 0, MSBStrings.W0111, item.Key);
				} else if (item.Key == ApplicationIdentifierKey) {
					var str = value as PString;

					// Ignore ONLY if it is empty, otherwise take the user's value
					if (str == null || string.IsNullOrEmpty (str.Value))
						continue;
				}

				if (value is PDictionary)
					value = MergeEntitlementDictionary ((PDictionary) value, profile);
				else if (value is PString)
					value = MergeEntitlementString ((PString) value, profile, item.Key == ApplicationIdentifierKey);
				else if (value is PArray)
					value = MergeEntitlementArray ((PArray) value, profile);
				else
					value = value.Clone ();

				if (value != null)
					entitlements[item.Key] = value;
			}

			return entitlements;
		}

		static PDictionary GetArchivedExpandedEntitlements (PDictionary template, PDictionary compiled)
		{
			var allowed = new HashSet<string> ();

			// the template (user-supplied Entitlements.plist file) is used to create a whitelist of keys
			allowed.Add ("com.apple.developer.icloud-container-environment");
			foreach (var item in template)
				allowed.Add (item.Key);

			// now we duplicate the allowed keys from the compiled xcent file
			var archived = new PDictionary ();

			foreach (var item in compiled) {
				if (allowed.Contains (item.Key))
					archived.Add (item.Key, item.Value.Clone ());
			}

			return archived;
		}

		protected virtual MobileProvision GetMobileProvision (MobileProvisionPlatform platform, string name)
		{
			return MobileProvisionIndex.GetMobileProvision (platform, name);
		}

		public override bool Execute ()
		{
			MobileProvisionPlatform platform;
			MobileProvision profile;
			PDictionary template;
			PDictionary compiled;
			PDictionary archived;
			string path;
			bool save;

			switch (SdkPlatform) {
			case "AppleTVSimulator":
			case "AppleTVOS":
				platform = MobileProvisionPlatform.tvOS;
				break;
			case "iPhoneSimulator":
			case "WatchSimulator":
			case "iPhoneOS":
			case "WatchOS":
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
				if ((profile = GetMobileProvision (platform, ProvisioningProfile)) == null) {
					Log.LogError (MSBStrings.E0049, ProvisioningProfile);
					return false;
				}
			} else {
				profile = null;
			}

			if (!string.IsNullOrEmpty (Entitlements)) {
				if (!File.Exists (Entitlements)) {
					Log.LogError (MSBStrings.E0112, Entitlements);
					return false;
				}

				path = Entitlements;
			} else {
				path = DefaultEntitlementsPath;
			}

			try {
				template = PDictionary.FromFile (path);
			} catch (Exception ex) {
				Log.LogError (MSBStrings.E0113, path, ex.Message);
				return false;
			}

			compiled = GetCompiledEntitlements (profile, template);
			archived = GetArchivedExpandedEntitlements (template, compiled);

			try {
				Directory.CreateDirectory (Path.GetDirectoryName (CompiledEntitlements.ItemSpec));
				WriteXcent (compiled, CompiledEntitlements.ItemSpec);
			} catch (Exception ex) {
				Log.LogError (MSBStrings.E0114, CompiledEntitlements, ex.Message);
				return false;
			}

			SaveArchivedExpandedEntitlements (archived);

			if (SdkIsSimulator) {
				if (compiled.Count > 0) {
					EntitlementsInExecutable = CompiledEntitlements;
				}
			} else {
				EntitlementsInSignature = CompiledEntitlements;
			}

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
				var plist = PDictionary.FromFile (path);
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
	}
}
