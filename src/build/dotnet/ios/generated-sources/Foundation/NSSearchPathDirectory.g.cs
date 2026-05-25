//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>An enumeration of special directories for use with <see cref="M:Foundation.NSFileManager.GetUrls(Foundation.NSSearchPathDirectory,Foundation.NSSearchPathDomain)" />.</summary><remarks>Some of these constants when used can return more than one value (for example AllApplicationsDirectory).</remarks>
	[Native]
	public enum NSSearchPathDirectory : ulong {
		/// <summary>Applications directory (/Applications).</summary>
		ApplicationDirectory = 1,
		/// <summary>Demo applications directory</summary>
		DemoApplicationDirectory = 2,
		/// <summary>Deprecated, used to be /Developer/Applications.</summary>
		DeveloperApplicationDirectory = 3,
		/// <summary>Directory for admin applications (Application/Utilities)</summary>
		AdminApplicationDirectory = 4,
		/// <summary>Library directory contains documentation, configuration files and support files (Library)</summary>
		LibraryDirectory = 5,
		/// <summary>Deprecated, used to be /Developer</summary>
		DeveloperDirectory = 6,
		/// <summary>User directory (for all users, not the currently logged in user, /Users, /Network/Users for example)</summary>
		UserDirectory = 7,
		/// <summary>Documentation directory</summary>
		DocumentationDirectory = 8,
		/// <summary>Document directory (this is where an application can store its documents)</summary>
		DocumentDirectory = 9,
		/// <summary>Directory for CoreServices (System/Library/CoreServices)</summary>
		CoreServiceDirectory = 10,
		/// <summary>User autosave directory (Library/Autosave Information)</summary>
		AutosavedInformationDirectory = 11,
		/// <summary>The user’s desktop directory.</summary>
		DesktopDirectory = 12,
		/// <summary>Cache directory (Library/Caches)</summary>
		CachesDirectory = 13,
		/// <summary>Application support directory (Library/Application Support)</summary>
		ApplicationSupportDirectory = 14,
		/// <summary>Downloads directory (only available when the domain specified includes the User value)</summary>
		DownloadsDirectory = 15,
		/// <summary>Input methods directory (Library/Input Methods)</summary>
		InputMethodsDirectory = 16,
		/// <summary>User’s movies directory (~/Movies)</summary>
		MoviesDirectory = 17,
		/// <summary>User’s music directory (~/Music)</summary>
		MusicDirectory = 18,
		/// <summary>User’s picture directory (~/Pictures)</summary>
		PicturesDirectory = 19,
		/// <summary>Printer descriptions directory, the directory that contains Postcript Printer Description files (Library/Printers/PPDS)</summary>
		PrinterDescriptionDirectory = 20,
		/// <summary>Shared public directory, when enabled (~/Public)</summary>
		SharedPublicDirectory = 21,
		/// <summary>Preference Panes directory, the directory that contains the *.prefPane bundles, (Library/PreferencePanes)</summary>
		PreferencePanesDirectory = 22,
		/// <summary>User scripts directory (Library/Application Scripts/app)</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ApplicationScriptsDirectory = 23,
		/// <summary>Item replacement directory, used for implementing safe-save features.</summary>
		ItemReplacementDirectory = 99,
		/// <summary>Combined directories where applications can appear.</summary>
		AllApplicationsDirectory = 100,
		/// <summary>Combined directories where resources can be appear.</summary>
		AllLibrariesDirectory = 101,
		/// <summary>Trash directory</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		TrashDirectory = 102,
	}
}
