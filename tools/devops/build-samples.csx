using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using Xamarin.Provisioning;
using Xamarin.Provisioning.Model;

// Provision Mono, XI and XM.
// We get Mono from the current commit's MIN_MONO_URL value in Make.config
// We get XI and XM from the current commit's manifest from GitHub's statuses
//
// Overrides:
// * Each download URL can be overriden by setting an environment variable (MIN_MONO_URL, XI_PACKAGE and/or XM_PACKAGE).
// * The current commit can be overridden by setting the PROVISION_FROM_COMMIT variable. This is usually easier than overriding each url.

var commit = Environment.GetEnvironmentVariable ("BUILD_SOURCEVERSION");
var provision_from_commit = Environment.GetEnvironmentVariable ("PROVISION_FROM_COMMIT") ?? commit;
var statuses = string.Empty;
string manifest_url = null;
string[] manifest = null;
IEnumerable<string> make_config = null;

public static string DownloadWithGithubAuth (string uri)
{
	var downloader = new Downloader ();
	var path = Path.GetTempFileName ();
	var headers = new List<(string, string)> ();
	var authToken = AuthToken ("github.com");
	if (!string.IsNullOrEmpty (authToken))
		headers.Add (("Authorization", $"token {authToken}"));
	path = downloader
		.DownloadItemAsync (
			uri,
			headers.ToArray (),
			Path.GetDirectoryName (path),
			Path.GetFileName (path),
			options: Downloader.Options.Default.WithUseCache (false))
		.GetAwaiter ()
		.GetResult ();
	try {
		return File.ReadAllText (path);
	} finally {
		File.Delete (path);
	}
}

string GetManifestUrl ()
{
	if (manifest_url == null) {
		var url = $"https://api.github.com/repos/xamarin/xamarin-macios/statuses/{provision_from_commit}";
		var json = JToken.Parse (DownloadWithGithubAuth (url));
		var value = (JValue) ((JArray) json).Where ((v) => v ["context"].ToString () == "manifest").Select ((v) => v ["target_url"]).FirstOrDefault ();
		manifest_url = (string) value?.Value;
		if (manifest_url == null)
			throw new Exception ($"Could not find the manifest for {provision_from_commit}. Is the commit already built by CI?");
	}
	return manifest_url;
}

string[] GetManifest ()
{
	if (manifest == null)
		manifest = ReadAllText (GetManifestUrl ()).Split ('\n');
	return manifest;
}

string FindVariable (string variable)
{
	var value = Environment.GetEnvironmentVariable (variable);
	if (!string.IsNullOrEmpty (value))
		return value;

	if (make_config == null)
		make_config = Exec ("git", "show", $"{provision_from_commit}:Make.config");
	foreach (var line in make_config) {
		if (line.StartsWith (variable + "=", StringComparison.Ordinal))
			return line.Substring (variable.Length + 1);
	}

	switch (variable) {
	case "XI_PACKAGE":
		value = GetManifest ().Where ((v) => v.Contains ("xamarin.ios-") && v.EndsWith (".pkg", StringComparison.Ordinal)).FirstOrDefault ();
		break;
	case "XM_PACKAGE":
		value = GetManifest ().Where ((v) => v.Contains ("xamarin.mac-") && v.EndsWith (".pkg", StringComparison.Ordinal)).FirstOrDefault ();
		break;
	}

	if (!string.IsNullOrEmpty (value))
		return value;

	throw new Exception ($"Could not find {variable} in environment nor in the commit's ({commit}) manifest.");
}

string GetVersion (string url)
{
	return Regex.Match (mono_package, "[0-9]*[.][0-9]*[.][0-9]*[.][0-9]*").Value;
}

if (string.IsNullOrEmpty (provision_from_commit)) {
	Console.Error.WriteLine ($"Either BUILD_SOURCEVERSION or PROVISION_FROM_COMMIT must be set.");
	Environment.Exit (1);
	return 1;
}
Console.WriteLine ($"Provisioning from {provision_from_commit}...");

var mono_package = FindVariable ("MIN_MONO_URL");
var xi_package = FindVariable ("XI_PACKAGE");
var xm_package = FindVariable ("XM_PACKAGE");

Console.WriteLine ($"Mono: {mono_package}");
Console.WriteLine ($"Xamarin.iOS: {xi_package}");
Console.WriteLine ($"Xamarin.Mac: {xm_package}");

Item ("Mono", GetVersion (mono_package))
  .Source (mono => mono_package);

Item ("Xamarin.iOS", GetVersion (xi_package))
  .Source (xi => xi_package);

Item ("Xamarin.Mac", GetVersion (xm_package))
  .Source (xm => xm_package);
