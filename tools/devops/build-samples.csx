using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using Xamarin.Provisioning;
using Xamarin.Provisioning.Model;

// Provision Mono, XI, XM, Mono, Objective-Sharpie, Xcode, provisioning profiles.
//
// We get Mono from the current commit's MIN_MONO_URL value in Make.config
// We get XI and XM from the current commit's manifest from GitHub's statuses
//
// Overrides:
// * Each download URL can be overriden by setting an environment variable (MIN_MONO_URL, XI_PACKAGE and/or XM_PACKAGE).
// * The current commit can be overridden by setting the PROVISION_FROM_COMMIT variable. This is usually easier than overriding each url.

var commit = Environment.GetEnvironmentVariable ("BUILD_SOURCEVERSION");
var provision_from_commit = Environment.GetEnvironmentVariable ("PROVISION_FROM_COMMIT") ?? commit;

string FindVariable (string variable)
{
	var value = FindConfigurationVariable (variable, provision_from_commit);
	if (!string.IsNullOrEmpty (value))
		return value;

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
	return Regex.Match (mono_package, "[0-9]+[.][0-9]+[.][0-9]+([.][0-9]+)?").Value;
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
var sharpie_package = FindVariable ("MIN_SHARPIE_URL");

Console.WriteLine ($"Mono: {mono_package}");
Console.WriteLine ($"Xamarin.iOS: {xi_package}");
Console.WriteLine ($"Xamarin.Mac: {xm_package}");
Console.WriteLine ($"Objective-Sharpie: {sharpie_package}");

Item ("Mono", GetVersion (mono_package))
  .Source (mono => mono_package);

Item ("Xamarin.iOS", GetVersion (xi_package))
  .Source (xi => xi_package);

Item ("Xamarin.Mac", GetVersion (xm_package))
  .Source (xm => xm_package);

Item ("Objective-Sharpie", GetVersion (sharpie_package))
  .Source (sharpie => sharpie_package);

// Xcode
#load "../../../maccore/tools/devops/external-deps.csx"
var xcode_path = Path.GetDirectoryName (Path.GetDirectoryName (FindVariable ("XCODE_DEVELOPER_ROOT")));
Exec ($"ln -Fhs {xcode_path} /Applications/Xcode.app");

// Provisioning profiles
Exec ($"../../../maccore/tools/install-qa-provisioning-profiles.sh");
