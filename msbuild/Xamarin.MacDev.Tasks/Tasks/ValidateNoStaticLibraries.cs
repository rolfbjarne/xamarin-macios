#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public class ValidateNoStaticLibraries : Task {
		public string SkipStaticLibraryValidation { get; set; } = string.Empty;
		public ITaskItem [] ValidateItems { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			bool onlyWarn = false;
			switch (SkipStaticLibraryValidation.ToLowerInvariant ()) {
			case "true":
			case "disable"
				return true;
			case "":
			case "error":
			case "false":
				onlyWarn = false;
				break;
			case "warn":
				onlyWarn = true;
				break;
			default:
				// TODO: localize
				Log.LogError (7142, null, MSBStrings.MX7142, SkipStaticLibraryValidation); // Unknown value for 'SkipStaticLibraryValidation': {0}
				return false;
			}

			foreach (var item in ValidateItems) {
				var path = item.ItemSpec;
				if (!File.Exists (path)) {
					Log.LogError (158, path, MSBStrings.E0158 /* The file '{0}' does not exist. */, path);
					continue;
				}

				if (MachO.IsDynamicFramework (path))
					continue;

				if (onlyWarn) {
					Log.LogWarning (7141, item.ItemSpec, MSBStrings.MX7141, path); // "The library {0} is a static library, and static libraries are not supported with Hot Restart.
				} else {
					Log.LogError (7141, item.ItemSpec, MSBStrings.MX7141, path); // The library {0} is a static library, and static libraries are not supported with Hot Restart.
				}
			}

			return !Log.HasLoggedErrors;
		}
	}
}
