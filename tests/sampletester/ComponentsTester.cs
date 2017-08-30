using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

using NUnit.Framework;

[TestFixture]
public abstract class ComponentsTester
{
	public string Repository { get; private set; }

	List<BuildInfo> components;
	List<BuildInfo> Components {
		get {
			if (components == null)
				components = GetComponentsList (Repository);
			return components;
		}
	}

	Dictionary<string, string> ignored_components;
	Dictionary<string, string> GetIgnoredComponents ()
	{
		if (ignored_components == null)
			ignored_components = GetIgnoredComponentsImpl ();
		return ignored_components;
	}

	protected virtual Dictionary<string, string> GetIgnoredComponentsImpl ()
	{
		return new Dictionary<string, string> ();
	}

	protected ComponentsTester (string repo)
	{
		Repository = repo;
	}

	void BuildComponentImpl (string component)
	{
		string ignored_message = "Ignored";
		if (GetIgnoredComponents ()?.TryGetValue (component, out ignored_message) == true) {
			Console.WriteLine ($"Ignored: {ignored_message}");
			Assert.Ignore (ignored_message);
		}

		var repo_path = GitHub.CloneRepository ("xamarin", Repository);
		var info = Components.Single ((v) => v.Name == component);
		try {
			ProcessHelper.AssertRunProcess ("sh", $"{Path.Combine (repo_path, "build.sh")} -t samples", TimeSpan.FromMinutes (15), Path.GetDirectoryName (Path.Combine (repo_path, info.BuildScript)), "build");
		} finally {
			GitHub.CleanRepository (Path.Combine (repo_path, info.BuildScript), false);
		}
	}

	[Test]
	public void BuildComponent ([ValueSource ("GetComponents")] string component)
	{
		BuildComponentImpl (component);
	}

	protected static string RootDirectory {
		get {
			return Configuration.RootDirectory;
		}
	}

	class BuildInfo
	{
		public string Name { get; set; }
		public string BuildScript { get; set; }
		public string [] TriggerPaths { get; set; }
		public string [] MacBuildTargets { get; set; }
	}

	static List<BuildInfo> GetComponentsList (string repo)
	{
		var manifest = GitHub.GetFileContents ("xamarin", repo, "manifest.yaml");
		var ds_builder = new YamlDotNet.Serialization.DeserializerBuilder ();
		ds_builder.IgnoreUnmatchedProperties ();
		var ds = ds_builder.Build ();
		return ds.Deserialize<List<BuildInfo>> (manifest);
	}

	protected static string [] GetComponentsImpl (string repo)
	{
		try {
			return GetComponentsList (repo).Select ((v) => v.Name).ToArray ();
		} catch (Exception e) {
			return new string [] { e.Message };
		}
	}
}

public class XamarinComponentsTester : ComponentsTester
{
	const string REPO = "XamarinComponents";
	public XamarinComponentsTester ()
		: base (REPO)
	{
	}

	static string [] GetComponents ()
	{
		return GetComponentsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredComponentsImpl ()
	{
		return new Dictionary<string, string> {
			//{ "AndroidEasingFunctions", "Android component" },
			//{ "AndroidSwipeLayout", "Android component" },
			//{ "AndroidThings", "Android component" },
			//{ "AndroidViewAnimations", "Android component" },
			//{ "AnimatedCircleLoadingView", "Android component" },
			//{ "AutoFitTextView", "Android component" },
			//{ "BetterPickers", "Android component" },
			//{ "BlurBehind", "Android component" },
			//{ "Blurring", "Android component" },
			//{ "Bolts", "Android component" },
			//{ "DeviceYearClass", "Android component" },
			//{ "ElasticProgressBar", "Android component" },
			//{ "Timber", "Android component" },
			//{ "Explosions", "Android component" },
			//{ "FloatingSearchView", "Android component" },
			//{ "GoogleGson", "Android component" },
			//{ "JacksonCore", "Android component" },
			//{ "JazzyViewPager", "Android component" },
			//{ "KenBurnsView", "Android component" },
			//{ "MinimalJson", "Android component" },
			//{ "NineOldAndroids", "Android component" },
			//{ "NumberProgressBar", "Android component" },
			//{ "PhotoView", "Android component" },
			//{ "RecyclerViewAnimators", "Android component" },
			//{ "RoundedImageView", "Android component" },
			//{ "Scissors", "Android component" },
			//{ "Screenshooter", "Android component" },
			//{ "SortableTableView", "Android component" },
			//{ "StickyHeader", "Android component" },
			//{ "StickyListHeaders", "Android component" },
			//{ "UniversalImageLoader", "Android component" },
			//{ "UrlImageViewHelper", "Android component" },
			//{ "VectorCompat", "Android component" },

			//{ "DropboxCoreApiAndroid", "Requires Android (xplat)" },
			//{ "DropboxCoreApiiOS", "Requires Android (xplat)" },
			//{ "GoogleVRAndroid", "Requires Android (xplat)" },
			//{ "GoogleVRiOS", "Requires Android (xplat)" },
			//{ "OpenId", "Requires Android (xplat)" },
			//{ "AzureMessaging", "Requires Android (xplat)" },
			//{ "CardIOAndroid", "Requires Android (xplat)" },
			//{ "CardIOiOS", "Requires Android (xplat)" },
			//{ "LoginScreen", "Requires Android (xplat)" },
			//{ "Mapbox", "Requires Android (xplat)" },
			//{ "Gigya", "Requires Android (xplat)" },
			//{ "EstimoteAndroid", "Requires Android (xplat)" },
			//{ "EstimoteiOS", "Requires Android (xplat)" },
			//{ "ShopifyAndroid", "Requires Android (xplat)" },
			//{ "ShopifyiOS", "Requires Android (xplat)" },

			//{ "Xamarin.Build.Download", "Not an iOS project" },
		};
	}
}

public class FacebookComponentsTester : ComponentsTester
{
	const string REPO = "FacebookComponents";
	public FacebookComponentsTester ()
		: base (REPO)
	{
	}

	static string [] GetComponents ()
	{
		return GetComponentsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredComponentsImpl ()
	{
		return new Dictionary<string, string>
		{
			{ "FacebookAndroid", "Android component" },
		};
	}
}

public class GoogleApisForiOSComponentsTester : ComponentsTester
{
	const string REPO = "GoogleApisForiOSComponents";
	public GoogleApisForiOSComponentsTester ()
		: base (REPO)
	{
	}

	static string [] GetComponents ()
	{
		return GetComponentsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredComponentsImpl ()
	{
		return new Dictionary<string, string>
		{
		};
	}
}
