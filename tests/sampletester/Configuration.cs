using System;
using System.IO;
using System.Reflection;

public static class Configuration
{
	public static string RootDirectory {
		get {
			var rv = Path.Combine (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location), "repositories");
			var nuget_conf = Path.Combine (rv, "NuGet.config");
			Directory.CreateDirectory (rv);
			if (!File.Exists (nuget_conf)) {
				File.WriteAllText (nuget_conf,
@"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
</configuration>
");
			}
			return rv;
			//// I'd like to clone the samples into a subdirectory that will be cleaned on the bots,
			//// but using a subdirectory in xamarin-macios makes nuget-depending projects pick
			//// up xamarin-macios' Nuget.Config, which sets the repository path, and the nugets are
			//// restored to location the projects don't expect.
			//// So instead clone the sample repositories into /tmp
			//return Path.Combine ("/private/tmp/xamarin-macios-sample-builder/repositories");
		}
	}

	static string xcode_location;
	public static string XcodeLocation {
		get {
			if (xcode_location != null)
				return xcode_location;

			var assembly_location = Assembly.GetExecutingAssembly ().Location;
			var dir = Path.GetDirectoryName (assembly_location);
			while (dir.Length > 3) {
				var fn = Path.Combine (dir, "Make.config");
				if (File.Exists (fn)) {
					var lines = File.ReadAllLines (fn);
					foreach (var line in lines) {
						if (line.StartsWith ("XCODE_DEVELOPER_ROOT=", StringComparison.Ordinal))
							return xcode_location = line.Substring ("XCODE_DEVELOPER_ROOT=".Length);
					}
				}
				dir = Path.GetDirectoryName (dir);
			}

			throw new Exception ($"Could not find Make.config starting from {assembly_location}.");
		}
	}
}
