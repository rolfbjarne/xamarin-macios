using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

using NUnit.Framework;

[TestFixture]
public class MonoTouchBindingTester
{
	public string Repository { get; private set; } = "monotouch-bindings";

	Dictionary<string, string> ignored_bindings;
	Dictionary<string, string> GetIgnoredBindings ()
	{
		if (ignored_bindings == null)
			ignored_bindings = GetIgnoredBindingsImpl ();
		return ignored_bindings;
	}

	[Test]
	public void BuildBinding ([ValueSource ("GetBindings")] string binding)
	{
		string ignored_message = "Ignored";
		if (GetIgnoredBindings ()?.TryGetValue (binding, out ignored_message) == true)
			Assert.Ignore (ignored_message);

		GitHub.CloneRepository ("xamarin", "monotouch-bindings-externals");
		var binding_dir = Path.Combine (GitHub.CloneRepository ("mono", Repository), binding);

		ProcessHelper.BuildMakefile (Path.Combine (binding_dir, "Makefile"));
	}

	static string [] GetBindings ()
	{
		return GitHub.GetDirectories ("mono", "monotouch-bindings", false);
	}

	Dictionary<string, string> GetIgnoredBindingsImpl ()
	{
		return new Dictionary<string, string> {
			{ "AdJitsu", "?" },  // Not included in the top-level makefile
			{ "CardIO", "?" },  // Not included in the top-level makefile
			{ "CDCircleSharp", "?" },  // Not included in the top-level makefile
			{ "FlurryAppCircle", "?" },  // Not included in the top-level makefile
			{ "GabePrinter", "?" },  // Not included in the top-level makefile
			{ "GPUImage", "?" },  // Not included in the top-level makefile
			{ "HockeyApp", "?" },  // Not included in the top-level makefile
			{ "Lookback", "?" },  // Not included in the top-level makefile
			{ "Pinterest", "?" },  // Not included in the top-level makefile
			{ "Tapit", "?" },  // Not included in the top-level makefile
			{ "Tapku", "?" },  // Not included in the top-level makefile
			{ "Three20", "?" },  // Not included in the top-level makefile
			{ "UIImageViewAlignedSharp", "?" },  // Not included in the top-level makefile
			{ "facebookios", "?" },  // Not included in the top-level makefile
			{ "flite", "?" },  // Not included in the top-level makefile
			{ "AmazonLogin", "?" },
			{ "ATMHud", "?" },
			{ "BeeblexSDK", "?" },
			{ "BPStatusBar", "?" },
			{ "chipmunk", "?" },
			{ "cocos2d", "?" },
			{ "cocosDenshion", "?" },
			{ "CorePlot", "?" },
			{ "Couchbase", "?" },
			{ "Crittercism", "?" },
			{ "Datatrans", "?" },
			{ "DropboxChooser", "?" },
			{ "DropBoxSync", "?" },
			{ "Estimote", "?" },
			{ "facebook", "?" },
			{ "FlurryAnalytics", "?" },
			{ "GCDiscreetNotification", "?" },
			{ "GoogleAdMobAds", "?" },
			{ "GoogleAnalytics", "?" },
			{ "GoogleCast", "?" },
			{ "GoogleMaps", "?" },
			{ "GooglePlusAndPlayGameServices", "?" },
			{ "iCarousel", "?" },
			{ "InMobi", "?" },
			{ "iRate", "?" },
			{ "KGStatusBar", "?" },
			{ "Kiip", "?" },
			{ "MagTek.iDynamo", "?" },
			{ "MBAlertView", "?" },
			{ "MBProgressHUD", "?" },
			{ "MGSplitViewController", "?" },
			{ "Mobclix", "?" },
			{ "OpenTok", "?" },
			{ "Parse", "?" },
			{ "PHFComposeBarView", "?" },
			{ "RedLaser", "?" },
			{ "Redpark", "?" },
			{ "Route-Me", "?" },
			{ "SDSegmentedControl", "?" },
			{ "SDWebImage", "?" },
			{ "SMCalloutView", "?" },
			{ "SparkInspector", "?" },
			{ "TapJoyConnect", "?" },
			{ "Taplytics", "?" },
			{ "TestFairy", "?" },
			{ "TestFlight", "?" },
			{ "TimesSquare", "?" },
			{ "TSMiniWebBrowser", "?" },
			{ "UrbanAirShip", "?" },
			{ "VENCalculatorInputView", "?" },
			{ "WEPopover", "?" },
			{ "ZipArchive", "?" },
		};
	}
}
