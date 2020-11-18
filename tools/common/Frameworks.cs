using System;
using System.Collections.Generic;

#if MTOUCH || MMP || BUNDLER
using Mono.Cecil;

using Xamarin.Bundler;
using Registrar;
#endif

using Xamarin.Utils;

public class Framework
{
	public string Namespace;
	public string Name;
	public Version Version;
	public Version VersionAvailableInSimulator;
	public bool AlwaysWeakLinked;
	public bool Unavailable;

#if MTOUCH || MMP || BUNDLER
	public bool IsFrameworkAvailableInSimulator (Application app)
	{
		if (VersionAvailableInSimulator == null)
			return false;

		if (VersionAvailableInSimulator > app.SdkVersion)
			return false;

		return true;
	}
#endif
}

public class Frameworks : Dictionary <string, Framework>
{
	public void Add (string @namespace, int major_version)
	{
		Add (@namespace, @namespace, new Version (major_version, 0));
	}

	public void Add (string @namespace, string framework, int major_version)
	{
		Add (@namespace, framework, new Version (major_version, 0));
	}

	public void Add (string @namespace, int major_version, int minor_version)
	{
		Add (@namespace, @namespace, new Version (major_version, minor_version));
	}

	public void Add (string @namespace, string framework, int major_version, bool alwaysWeakLink)
	{
		Add (@namespace, framework, new Version (major_version, 0), null, alwaysWeakLink);
	}

	public void Add (string @namespace, string framework, int major_version, int minor_version)
	{
		Add (@namespace, framework, new Version (major_version, minor_version));
	}

	public void Add (string @namespace, string framework, int major_version, int minor_version, int build_version)
	{
		Add (@namespace, framework, new Version (major_version, minor_version, build_version));
	}

	public void Add (string @namespace, string framework, Version version, Version version_available_in_simulator = null, bool alwaysWeakLink = false)
	{
		var fr = new Framework () {
			Namespace = @namespace,
			Name = framework,
			Version = version,
			VersionAvailableInSimulator = version_available_in_simulator ?? version,
			AlwaysWeakLinked = alwaysWeakLink,
		};
		base.Add (fr.Namespace, fr);
	}

	public Framework Find (string framework)
	{
		foreach (var kvp in this)
			if (kvp.Value.Name == framework)
				return kvp.Value;
		return null;
	}

	static Version NotAvailableInSimulator = new Version (int.MaxValue, int.MaxValue);

	static Frameworks mac_frameworks;
	public static Frameworks MacFrameworks {
		get {
			if (mac_frameworks == null) {
				mac_frameworks = new Frameworks () {
					{ "Accelerate", 10, 0 },
					{ "AppKit", 10, 0 },
					{ "CoreFoundation", "CoreFoundation", 10, 0 },
					{ "CoreGraphics", "QuartzCore", 10, 0 },
					{ "CoreImage", "QuartzCore", 10, 0 },
					{ "Foundation", 10, 0 },
					{ "ImageKit", "Quartz", 10, 0 },
					{ "PdfKit", "Quartz", 10, 0 },
					{ "Security", 10, 0 },

					{ "GSS", "GSS", 10, 1 },

					{ "AudioUnit", 10, 2 },
					{ "CoreMidi", "CoreMIDI", 10, 2 },
					{ "WebKit", 10, 2},

					{ "AudioToolbox", 10, 3 },
					{ "CoreServices", 10, 3 },
					{ "CoreVideo", 10, 3 },
					{ "MobileCoreServices", "CoreServices", 10, 3 },
					{ "OpenGL", 10, 3 },
					{ "SearchKit", "CoreServices", 10,3 },
					{ "SystemConfiguration", 10, 3 },

					{ "CoreData", 10, 4 },
					{ "ImageIO", 10, 4 },
					{ "OpenAL", 10, 4 },

					{ "CoreAnimation", "QuartzCore", 10, 5 },
					{ "CoreText", 10, 5 },
					{ "PrintCore", "CoreServices", 10,5 },
					{ "ScriptingBridge", 10, 5 },
					{ "QuickLook", 10, 5 },
					{ "QuartzComposer", "Quartz", 10, 5 },
					{ "ImageCaptureCore", "ImageCaptureCore", 10,5 },

					{ "QTKit", 10, 6 },
					{ "QuickLookUI", "Quartz", 10, 6 },

					{ "MediaToolbox", 10, 9 },
					{ "AVFoundation", 10, 7 },
					{ "CoreBluetooth", "IOBluetooth", 10, 7 },
					{ "CoreLocation", 10, 7 },
					{ "CoreMedia", 10, 7 },
					{ "CoreWlan", "CoreWLAN", 10, 7 },
					{ "StoreKit", 10, 7 },

					{ "Accounts", 10, 8 },
					{ "AudioVideoBridging", 10, 8 },
					{ "CFNetwork", 10, 8 },
					{ "EventKit", 10, 8 },
					{ "GameKit", 10, 8 },
					{ "GLKit", 10, 8 },
					{ "SceneKit", 10, 8 },
					{ "Social", 10, 8 },
					{ "VideoToolbox", 10, 8 },

					{ "AVKit", 10, 9 },
					{ "GameController", 10, 9 },
					{ "MapKit", 10, 9 },
					{ "MediaAccessibility", 10, 9 },
					{ "MediaLibrary", 10, 9 },
					{ "SpriteKit", 10, 9 },
					{ "JavaScriptCore", "JavaScriptCore", 10, 9 },

					{ "CloudKit", 10, 10 },
					{ "CryptoTokenKit", 10, 10 },
					{ "FinderSync", 10, 10 },
					{ "Hypervisor", 10, 10 },
					{ "LocalAuthentication", 10, 10 },
					{ "MultipeerConnectivity", 10, 10 },
					{ "NetworkExtension", 10, 10 },
					{ "NotificationCenter", 10, 10 },

					{ "Contacts", 10, 11 },
					{ "ContactsUI", 10, 11 },
					{ "CoreAudioKit", 10,11 },
					{ "GameplayKit", 10, 11 },
					{ "Metal", 10, 11 },
					{ "MetalKit", 10, 11 },
					{ "ModelIO", 10, 11 },

					{ "Intents", 10, 12 },
					{ "IOSurface", "IOSurface", 10, 12 },
					{ "Photos", "Photos", 10,12 },
					{ "PhotosUI", "PhotosUI", 10,12 },
					{ "SafariServices", "SafariServices", 10, 12 },
					{ "MediaPlayer", "MediaPlayer", 10, 12, 1 },

					{ "CoreML", "CoreML", 10, 13 },
					{ "CoreSpotlight", "CoreSpotlight", 10,13 },
					{ "ExternalAccessory", "ExternalAccessory", 10, 13 },
					{ "MetalPerformanceShaders", "MetalPerformanceShaders", 10, 13 },
					{ "Vision", "Vision", 10, 13 },

					{ "BusinessChat", "BusinessChat", 10, 13, 4 },

					{ "AdSupport", "AdSupport", 10,14 },
					{ "NaturalLanguage", "NaturalLanguage", 10,14 },
					{ "Network", "Network", 10, 14 },
					{ "VideoSubscriberAccount", "VideoSubscriberAccount", 10,14 },
					{ "UserNotifications", "UserNotifications", 10,14 },
					{ "iTunesLibrary", "iTunesLibrary", 10,14 },

					{ "AuthenticationServices", "AuthenticationServices", 10,15 },
					{ "CoreMotion", "CoreMotion", 10,15 },
					{ "DeviceCheck", "DeviceCheck", 10,15 },
					{ "ExecutionPolicy", "ExecutionPolicy", 10,15 },
					{ "FileProvider", "FileProvider", 10,15 },
					{ "FileProviderUI", "FileProviderUI", 10,15 },
					{ "PushKit", "PushKit", 10,15 },
					{ "QuickLookThumbnailing", "QuickLookThumbnailing", 10,15 },
					{ "SoundAnalysis", "SoundAnalysis", 10,15 },
					{ "PencilKit", "PencilKit", 10,15 },
					{ "Speech", "Speech", 10,15 },
					{ "LinkPresentation", "LinkPresentation", 10,15 },
					// not sure if the API is available, issue: https://github.com/xamarin/maccore/issues/1951
					//{ "CoreHaptics", "CoreHaptics", 10,15 },

					{ "AutomaticAssessmentConfiguration", "AutomaticAssessmentConfiguration", 10,15,4 },

					{ "Accessibility", "Accessibility", 11,0 },
					{ "AppTrackingTransparency", "AppTrackingTransparency", 11,0 },
					{ "CallKit", "CallKit", 11,0 },
					{ "ClassKit", "ClassKit", 11,0 },
					{ "MLCompute", "MLCompute", 11,0 },
					{ "PassKit", "PassKit", 11,0 },
					{ "ReplayKit", "ReplayKit", 11,0 },
					{ "ScreenTime", "ScreenTime", 11,0 },
					{ "UniformTypeIdentifiers", "UniformTypeIdentifiers", 11,0 },
					{ "UserNotificationsUI", "UserNotificationsUI", 11,0 },
				};
			}
			return mac_frameworks;
		}
	}

	static Frameworks ios_frameworks;
	public static Frameworks GetiOSFrameworks (bool is_simulator_build)
	{
		if (ios_frameworks == null)
			ios_frameworks = CreateiOSFrameworks (is_simulator_build);
		return ios_frameworks;
	}

	public static Frameworks CreateiOSFrameworks (bool is_simulator_build)
	{
		return new Frameworks () {
				{ "AddressBook",  "AddressBook", 3 },
				{ "Security", "Security", 3 },
				{ "AudioUnit", "AudioToolbox", 3 },
				{ "AddressBookUI", "AddressBookUI", 3 },
				{ "AudioToolbox", "AudioToolbox", 3 },
				{ "AVFoundation", "AVFoundation", 3 },
				{ "CFNetwork", "CFNetwork", 3 },
				{ "CoreAnimation", "QuartzCore", 3 },
				{ "CoreData", "CoreData", 3 },
				{ "CoreFoundation", "CoreFoundation", 3 },
				{ "CoreGraphics", "CoreGraphics", 3 },
				{ "CoreLocation", "CoreLocation", 3 },
				{ "ExternalAccessory", "ExternalAccessory", 3 },
				{ "Foundation", "Foundation", 3 },
				{ "GameKit", "GameKit", 3 },
				{ "MapKit", "MapKit", 3 },
				{ "MediaPlayer", "MediaPlayer", 3 },
				{ "MessageUI", "MessageUI", 3 },
				{ "MobileCoreServices", "MobileCoreServices", 3 },
				{ "StoreKit", "StoreKit", 3 },
				{ "SystemConfiguration", "SystemConfiguration", 3 },
				{ "OpenGLES", "OpenGLES", 3 },
				{ "UIKit", "UIKit", 3 },

				{ "Accelerate", "Accelerate", 4 },
				{ "EventKit", "EventKit", 4 },
				{ "EventKitUI", "EventKitUI", 4 },
				{ "CoreMotion", "CoreMotion", 4 },
				{ "CoreMedia", "CoreMedia", 4 },
				{ "CoreVideo", "CoreVideo", 4 },
				{ "CoreTelephony", "CoreTelephony", 4 },
				{ "iAd", "iAd", 4 },
				{ "QuickLook", "QuickLook", 4 },
				{ "ImageIO", "ImageIO", 4 },
				{ "AssetsLibrary", "AssetsLibrary", 4 },
				{ "CoreText", "CoreText", 4 },
				{ "CoreMidi", "CoreMIDI", 4 },

				{ "Accounts", "Accounts", 5 },
				{ "GLKit", "GLKit", 5 },
				{ "NewsstandKit", "NewsstandKit", 5 },
				{ "CoreImage", "CoreImage", 5 },
				{ "CoreBluetooth", "CoreBluetooth", 5 },
				{ "Twitter", "Twitter", 5 },
				{ "GSS", "GSS", 5 },

				{ "MediaToolbox", "MediaToolbox", 6 },
				{ "PassKit", "PassKit", 6 },
				{ "Social", "Social", 6 },
				{ "AdSupport", "AdSupport", 6 },

				{ "GameController", "GameController", 7 },
				{ "JavaScriptCore", "JavaScriptCore", 7 },
				{ "MediaAccessibility", "MediaAccessibility", 7 },
				{ "MultipeerConnectivity", "MultipeerConnectivity", 7 },
				{ "SafariServices", "SafariServices", 7 },
				{ "SpriteKit", "SpriteKit", 7 },

				{ "HealthKit", "HealthKit", 8 },
				{ "HomeKit", "HomeKit", 8 },
				{ "LocalAuthentication", "LocalAuthentication", 8 },
				{ "NotificationCenter", "NotificationCenter", 8 },
				{ "PushKit", "PushKit", 8 },
				{ "Photos", "Photos", 8 },
				{ "PhotosUI", "PhotosUI", 8 },
				{ "SceneKit", "SceneKit", 8 },
				{ "CloudKit", "CloudKit", 8 },
				{ "AVKit", "AVKit", 8 },
				{ "CoreAudioKit", "CoreAudioKit", is_simulator_build ? 9 : 8 },
				{ "Metal", "Metal", new Version (8, 0), new Version (9, 0) },
				{ "WebKit", "WebKit", 8 },
				{ "NetworkExtension", "NetworkExtension", 8 },
				{ "VideoToolbox", "VideoToolbox", 8 },
				// { "WatchKit", "WatchKit", 8,2 }, // Removed in Xcode 11

				{ "ReplayKit", "ReplayKit", 9 },
				{ "Contacts", "Contacts", 9 },
				{ "ContactsUI", "ContactsUI", 9 },
				{ "CoreSpotlight", "CoreSpotlight", 9 },
				{ "WatchConnectivity", "WatchConnectivity", 9 },
				{ "ModelIO", "ModelIO", 9 },
				{ "MetalKit", "MetalKit", 9 },
				{ "MetalPerformanceShaders", "MetalPerformanceShaders", new Version (9, 0), new Version (11, 0) /* MPS got simulator headers in Xcode 9 */ },
				{ "GameplayKit", "GameplayKit", 9 },
				{ "HealthKitUI", "HealthKitUI", 9,3 },

				{ "CallKit", "CallKit", 10 },
				{ "Messages", "Messages", 10 },
				{ "Speech", "Speech", 10 },
				{ "VideoSubscriberAccount", "VideoSubscriberAccount", 10 },
				{ "UserNotifications", "UserNotifications", 10 },
				{ "UserNotificationsUI", "UserNotificationsUI", 10 },
				{ "Intents", "Intents", 10 },
				{ "IntentsUI", "IntentsUI", 10 },

				{ "ARKit", "ARKit", 11 },
				{ "CoreNFC", "CoreNFC", new Version (11, 0), NotAvailableInSimulator, true }, /* not always present, e.g. iPad w/iOS 12, so must be weak linked; doesn't work in the simulator in Xcode 12 (https://stackoverflow.com/q/63915728/183422) */
				{ "DeviceCheck", "DeviceCheck", new Version (11, 0), new Version (13, 0) },
				{ "IdentityLookup", "IdentityLookup", 11 },
				{ "IOSurface", "IOSurface", new Version (11, 0), NotAvailableInSimulator /* Not available in the simulator (the header is there, but broken) */  },
				{ "CoreML", "CoreML", 11 },
				{ "Vision", "Vision", 11 },
				{ "FileProvider", "FileProvider", 11 },
				{ "FileProviderUI", "FileProviderUI", 11 },
				{ "PdfKit", "PDFKit", 11 },

				{ "BusinessChat", "BusinessChat", 11, 3 },

				{ "ClassKit", "ClassKit", 11,4 },

				{ "AuthenticationServices", "AuthenticationServices", 12,0 },
				{ "CarPlay", "CarPlay", 12,0 },
				{ "IdentityLookupUI", "IdentityLookupUI", 12,0 },
				{ "NaturalLanguage", "NaturalLanguage", 12,0 },
				{ "Network", "Network", 12, 0 },

				{ "BackgroundTasks", "BackgroundTasks", 13, 0 },
				{ "CoreHaptics", "CoreHaptics", 13, 0 },
				{ "LinkPresentation", "LinkPresentation", 13, 0 },
				{ "MetricKit", "MetricKit", 13, 0 },
				{ "PencilKit", "PencilKit", 13, 0 },
				{ "QuickLookThumbnailing", "QuickLookThumbnailing", 13,0 },
				{ "SoundAnalysis", "SoundAnalysis", 13, 0 },
				{ "VisionKit", "VisionKit", 13, 0 },

				{ "AutomaticAssessmentConfiguration", "AutomaticAssessmentConfiguration", 13, 4 },

				{ "Accessibility", "Accessibility", 14,0 },
				{ "AppClip", "AppClip", 14,0 },
				{ "AppTrackingTransparency", "AppTrackingTransparency", 14,0 },
				{ "MediaSetup", "MediaSetup", new Version (14, 0), NotAvailableInSimulator /* no headers in beta 3 */ },
				{ "MLCompute", "MLCompute", new Version (14,0), NotAvailableInSimulator },
				{ "NearbyInteraction", "NearbyInteraction", 14,0 },
				{ "ScreenTime", "ScreenTime", 14,0 },
				{ "SensorKit", "SensorKit", 14,0 },
				{ "UniformTypeIdentifiers", "UniformTypeIdentifiers", 14,0 },

				// the above MUST be kept in sync with simlauncher
				// see tools/mtouch/Makefile
				// please also keep it sorted to ease comparison
				// 
				// The following tests also need to be updated:
				// 
				// * RegistrarTest.MT4134
			};
	}

	static Frameworks watch_frameworks;
	public static Frameworks GetwatchOSFrameworks (bool is_simulator_build)
	{
		if (watch_frameworks == null) {
			watch_frameworks = new Frameworks {
				{ "Accelerate", "Accelerate", 2 },
				// The CFNetwork framework is in the SDK, but there are no headers inside the framework, so don't enable yet.
				// { "CFNetwork", "CFNetwork", 2 },
				{ "ClockKit", "ClockKit", 2 },
				{ "Contacts", "Contacts", 2 },
				{ "CoreData", "CoreData", 2 },
				{ "CoreFoundation", "CoreFoundation", 2 },
				{ "CoreGraphics", "CoreGraphics", 2 },
				{ "CoreLocation", "CoreLocation", 2 },
				{ "CoreMotion", "CoreMotion", 2 },
				{ "EventKit", "EventKit", 2 },
				{ "Foundation", "Foundation", 2 },
				{ "HealthKit", "HealthKit", 2 },
				{ "HomeKit", "HomeKit", 2 },
				{ "ImageIO", "ImageIO", 2 },
				{ "MapKit", "MapKit", 2 },
				{ "MobileCoreServices", "MobileCoreServices", 2 },
				{ "PassKit", "PassKit", 2 },
				{ "Security", "Security", 2 },
				{ "UIKit", "UIKit", 2 },
				{ "WatchConnectivity", "WatchConnectivity", 2 },
				{ "WatchKit", "WatchKit", 2 },

				{ "CoreText", "CoreText", 2,2 },

				// AVFoundation was introduced in 3.0, but the simulator SDK was broken until 3.2.
				{ "AVFoundation", "AVFoundation", 3, is_simulator_build ? 2 : 0 },
				{ "CloudKit", "CloudKit", 3 },
				{ "GameKit", "GameKit", new Version (3, 0), new Version (3, 2) /* No headers provided for watchOS/simulator until watchOS 3.2. */ },
				{ "SceneKit", "SceneKit", 3 },
				{ "SpriteKit", "SpriteKit", 3 },
				{ "UserNotifications", "UserNotifications", 3 },
				{ "Intents", "Intents", 3,2 },

				{ "CoreBluetooth", "CoreBluetooth", 4 },
				{ "CoreML", "CoreML", 4 },
				{ "CoreVideo", "CoreVideo", 4 },

				{ "NaturalLanguage", "NaturalLanguage", 5 },
				{ "MediaPlayer", "MediaPlayer", 5 },

				{ "AuthenticationServices", "AuthenticationServices", 6 },
				{ "Network", "Network", 6 },
				{ "PushKit", "PushKit", 6 },
				{ "SoundAnalysis", "SoundAnalysis", 6 },
				{ "CoreMedia", "CoreMedia", 6 },
				{ "StoreKit", "StoreKit", 6,2 },

				{ "Accessibility", "Accessibility", 7,0 },
				{ "UniformTypeIdentifiers", "UniformTypeIdentifiers", 7,0 },
			};
		}
		return watch_frameworks;
	}

	static Frameworks tvos_frameworks;
	public static Frameworks TVOSFrameworks {
		get {
			if (tvos_frameworks == null) {
				tvos_frameworks = new Frameworks () {
					{ "AVFoundation", "AVFoundation", 9 },
					{ "AVKit", "AVKit", 9 },
					{ "Accelerate", "Accelerate", 9 },
					{ "AdSupport", "AdSupport", 9 },
					{ "AudioToolbox", "AudioToolbox", 9 },
					{ "AudioUnit", "AudioToolbox", 9 },
					{ "CFNetwork", "CFNetwork", 9 },
					{ "CloudKit", "CloudKit", 9 },
					{ "CoreAnimation", "QuartzCore", 9 },
					{ "CoreAudio", "CoreAudio", 9 },
					{ "CoreBluetooth", "CoreBluetooth", 9 },
					{ "CoreData", "CoreData", 9 },
					{ "CoreFoundation", "CoreFoundation", 9 },
					{ "CoreGraphics", "CoreGraphics", 9 },
					{ "CoreImage", "CoreImage", 9 },
					{ "CoreLocation", "CoreLocation", 9 },
					{ "CoreMedia", "CoreMedia", 9 },
					{ "CoreText", "CoreText", 9 },
					{ "CoreVideo", "CoreVideo", 9 },
					{ "Foundation", "Foundation", 9 },
					{ "GLKit", "GLKit", 9 },
					{ "GameController", "GameController", 9 },
					{ "GameKit", "GameKit", 9 },
					{ "GameplayKit", "GameplayKit", 9 },
					{ "ImageIO", "ImageIO", 9 },
					{ "JavaScriptCore", "JavaScriptCore", 9 },
					{ "MediaAccessibility", "MediaAccessibility", 9 },
					{ "MediaPlayer", "MediaPlayer", 9 },
					{ "MediaToolbox", "MediaToolbox", 9 },
					{ "Metal", "Metal", 9 },
					{ "MetalKit", "MetalKit", new Version (9, 0), new Version (10, 0) },
					{ "MetalPerformanceShaders", "MetalPerformanceShaders", new Version (9, 0), NotAvailableInSimulator /* not available in the simulator */ },
					{ "CoreServices", "CFNetwork", 9 },
					{ "MobileCoreServices", "MobileCoreServices", 9 },
					{ "ModelIO", "ModelIO", 9 },
					{ "OpenGLES", "OpenGLES", 9 },
					{ "SceneKit", "SceneKit", 9 },
					{ "Security", "Security", 9 },
					{ "SpriteKit", "SpriteKit", 9 },
					{ "StoreKit", "StoreKit", 9 },
					{ "SystemConfiguration", "SystemConfiguration", 9 },
					{ "TVMLKit", "TVMLKit", 9 },
					{ "TVServices", "TVServices", 9 },
					{ "UIKit", "UIKit", 9 },

					{ "MapKit", "MapKit", 9, 2 },

					{ "ExternalAccessory", "ExternalAccessory", 10 },
					{ "HomeKit", "HomeKit", 10 },
					{ "MultipeerConnectivity", 10 },
					{ "Photos", "Photos", 10 },
					{ "PhotosUI", "PhotosUI", 10 },
					{ "ReplayKit", "ReplayKit", 10 },
					{ "UserNotifications", "UserNotifications", 10 },
					{ "VideoSubscriberAccount", "VideoSubscriberAccount", 10 },
					{ "VideoToolbox", "VideoToolbox", 10,2 },

					{ "DeviceCheck", "DeviceCheck", new Version (11, 0), new Version (13, 0) },
					{ "CoreML", "CoreML", 11 },
					{ "IOSurface", "IOSurface", new Version (11, 0), NotAvailableInSimulator /* Not available in the simulator (the header is there, but broken) */  },
					{ "Vision", "Vision", 11 },

					{ "NaturalLanguage", "NaturalLanguage", 12,0 },
					{ "Network", "Network", 12, 0 } ,
					{ "TVUIKit", "TVUIKit", 12,0 },

					{ "AuthenticationServices", "AuthenticationServices", 13,0 },
					{ "SoundAnalysis", "SoundAnalysis", 13,0 },
					{ "BackgroundTasks", "BackgroundTasks", 13, 0 },

					{ "Accessibility", "Accessibility", 14,0 },
					{ "AppTrackingTransparency", "AppTrackingTransparency", 14,0 },
					{ "CoreHaptics", "CoreHaptics", 14, 0 },
					{ "LinkPresentation", "LinkPresentation", 14,0 },
					{ "MLCompute", "MLCompute", new Version (14,0), NotAvailableInSimulator },
					{ "UniformTypeIdentifiers", "UniformTypeIdentifiers", 14,0 },
					{ "Intents", "Intents", 14,0 },
				};
			}
			return tvos_frameworks;
		}
	}

	static Frameworks catalyst_frameworks;
	public static Frameworks GetMacCatalystFrameworks ()
	{
		if (catalyst_frameworks == null) {
			catalyst_frameworks = CreateiOSFrameworks (false);
			catalyst_frameworks ["OpenGLES"].Unavailable = true;
			catalyst_frameworks ["NewsstandKit"].Unavailable = true;
			catalyst_frameworks ["VisionKit"].Unavailable = true;
			catalyst_frameworks ["MediaSetup"].Unavailable = true;
			catalyst_frameworks ["NotificationCenter"].Unavailable = true;
			catalyst_frameworks ["GLKit"].Unavailable = true;

			catalyst_frameworks ["FileProviderUI"].Unavailable = true; // this exists, but linker fails?

			catalyst_frameworks ["Twitter"].Unavailable = true; // headers are there, but no documentation whatsoever online and linking fails too

			foreach (var fw in new string [] {  "UserNotificationsUI", "Messages", "HomeKit", "ClassKit", "CarPlay", "AssetsLibrary", "ARKit", "AddressBookUI", "AddressBook" }) {
				var f = catalyst_frameworks [fw];
				f.Version = new Version (14, 2);
				f.VersionAvailableInSimulator = new Version (14, 2);
			}

			foreach (var fw in catalyst_frameworks) {
				if (fw.Value.Version == new Version (14, 0)) {
					fw.Value.Version = new Version (14, 2);
					fw.Value.VersionAvailableInSimulator = fw.Value.Version;
				}
			}
		}
		return catalyst_frameworks;
	}

	// returns null if the platform doesn't exist (the ErrorHandler machinery is heavy and this file is included in several projects, which makes throwing an exception complicated)
	public static Frameworks GetFrameworks (ApplePlatform platform, bool is_simulator_build)
	{
		switch (platform) {
		case ApplePlatform.iOS:
			return GetiOSFrameworks (is_simulator_build);
		case ApplePlatform.WatchOS:
			return GetwatchOSFrameworks (is_simulator_build);
		case ApplePlatform.TVOS:
			return TVOSFrameworks;
		case ApplePlatform.MacOSX:
			return MacFrameworks;
		case ApplePlatform.MacCatalyst:
			return GetMacCatalystFrameworks ();
		default:
			return null;
		}
	}

#if MTOUCH || MMP || BUNDLER
	static void Gather (Application app, AssemblyDefinition product_assembly, HashSet<string> frameworks, HashSet<string> weak_frameworks, Func<Framework, bool> include_framework)
	{
		var namespaces = new HashSet<string> ();

		// Collect all the namespaces.
		foreach (ModuleDefinition md in product_assembly.Modules)
			foreach (TypeDefinition td in md.Types)
				namespaces.Add (td.Namespace);

		// Iterate over all the namespaces and check which frameworks we need to link with.
		var all_frameworks = GetFrameworks (app.Platform, app.IsSimulatorBuild);
		foreach (var nspace in namespaces) {
			if (!all_frameworks.TryGetValue (nspace, out var framework))
				continue;

			if (!include_framework (framework))
				continue;

			if (app.SdkVersion < framework.Version) {
				// We're building with an old sdk, and the framework doesn't exist there.
				continue;
			}

			if (app.IsSimulatorBuild && !framework.IsFrameworkAvailableInSimulator (app))
				continue;

			var weak_link = framework.AlwaysWeakLinked || app.DeploymentTarget < framework.Version;
			var add_to = weak_link ? weak_frameworks : frameworks;
			add_to.Add (framework.Name);
		}

		// Make sure there are no duplicates between frameworks and weak frameworks.
		// Keep the weak ones.
		frameworks.ExceptWith (weak_frameworks);
	}

	static bool FilterFrameworks (Application app, Framework framework)
	{
		switch (app.Platform) {
		case ApplePlatform.iOS:
		case ApplePlatform.TVOS:
		case ApplePlatform.WatchOS:
			break; // Include all frameworks by default
		case ApplePlatform.MacOSX:
			switch (framework.Name) {
			case "QTKit":
#if MMP
				if (Driver.LinkProhibitedFrameworks) {
					ErrorHelper.Warning (5221, Errors.MM5221, framework.Name);
				} else {
					ErrorHelper.Warning (5220, Errors.MM5220, framework.Name);
					return false;
				}
#endif
				return true;
			}
			return true;
		default:
			throw ErrorHelper.CreateError (71, Errors.MX0071 /* "Unknown platform: {0}. This usually indicates a bug in {1}; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case." */, app.Platform, app.GetProductName ());
		}
		return true;
	}

	public static void Gather (Application app, AssemblyDefinition product_assembly, HashSet<string> frameworks, HashSet<string> weak_frameworks)
	{
		Gather (app, product_assembly, frameworks, weak_frameworks, (framework) => FilterFrameworks (app, framework));
	}
#endif // MTOUCH || MMP || BUNDLER
}
