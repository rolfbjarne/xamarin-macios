using System.IO;

string FindVariable (string variable)
{
	var value = Environment.GetEnvironmentVariable (variable);
	if (!string.IsNullOrEmpty (value))
		return value;

	var config = File.ReadAllLines ("../Make.config");
	foreach (var line in config) {
		if (line.StartsWith (variable + "=", StringComparison.Ordinal))
			return line.Substring (variable.Length + 1);
	}
	throw new Exception ($"Could not find {variable} in environment.");
}

var mono_package = FindVariable ("MIN_MONO_URL");
var xi_package = FindVariable ("XI_PACKAGE");
var xm_package = FindVariable ("XM_PACKAGE");

Item ("Mono", "The required version")
  .Source (mono => mono_package);

Item ("Xamarin.iOS", "The required version")
  .Source (xi => xi_package);

Item ("Xamarin.Mac", "The required version")
  .Source (xm => xm_package);
