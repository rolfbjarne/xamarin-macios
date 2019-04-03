using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

string DownloadWithGithubAuth (string uri)
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

string manifest_url = null;
string GetManifestUrl (string hash)
{
	if (manifest_url == null) {
		var url = $"https://api.github.com/repos/xamarin/xamarin-macios/statuses/{hash}";
		var json = JToken.Parse (DownloadWithGithubAuth (url));
		var value = (JValue) ((JArray) json).Where ((v) => v ["context"].ToString () == "manifest").Select ((v) => v ["target_url"]).FirstOrDefault ();
		manifest_url = (string) value?.Value;
		if (manifest_url == null)
			throw new Exception ($"Could not find the manifest for {hash}. Is the commit already built by CI?");
	}
	return manifest_url;
}

string[] manifest = null;
string[] GetManifest (string hash)
{
	if (manifest == null)
		manifest = ReadAllText (GetManifestUrl (hash)).Split ('\n');
	return manifest;
}

// Looks for a variable either in the environment, or in current repo's Make.config.
// Returns null if the variable couldn't be found.
IEnumerable<string> make_config = null;
string FindConfigurationVariable (string variable, string hash = "HEAD")
{
	var value = Environment.GetEnvironmentVariable (variable);
	if (!string.IsNullOrEmpty (value))
		return value;

	if (make_config == null)
		make_config = Exec ("git", "show", $"{hash}:Make.config");
	foreach (var line in make_config) {
		if (line.StartsWith (variable + "=", StringComparison.Ordinal))
			return line.Substring (variable.Length + 1);
	}

	return null;
}

void InstallPackage (string name, string url)
{
	Console.WriteLine ($"Installing {name} from {url}");
	var version = Regex.Match (url, "[0-9]+[.][0-9]+[.][0-9]+([.][0-9]+)?").Value;
	Item (name, version).Source (url);
}
