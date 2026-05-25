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
namespace SystemConfiguration {
	/// <summary>An enumeration whose values specify various statuses relating to network reachability.</summary>
	public enum StatusCode : int {
		/// <summary>The call succeeded.</summary>
		OK = 0,
		/// <summary>General error.</summary>
		Failed = 1001,
		/// <summary>A bad argument was passed.</summary>
		InvalidArgument = 1002,
		/// <summary>Permission was denied.</summary>
		AccessError = 1003,
		/// <summary>The key does not exist.</summary>
		NoKey = 1004,
		/// <summary>The key is already defined.</summary>
		KeyExists = 1005,
		/// <summary>A lock is already defined.</summary>
		Locked = 1006,
		/// <summary>The operation requires a lock.</summary>
		NeedLock = 1007,
		/// <summary>The configuration daemon session is not active.</summary>
		NoStoreSession = 2001,
		/// <summary>The configuration daemon is not available.</summary>
		NoStoreServer = 2002,
		/// <summary>Notifier is active.</summary>
		NotifierActive = 2003,
		/// <summary>The preferences session is not active.</summary>
		NoPrefsSession = 3001,
		/// <summary>A preferences update is currently active.</summary>
		PrefsBusy = 3002,
		/// <summary>The config file cannot be found.</summary>
		NoConfigFile = 3003,
		/// <summary>The link does not exist.</summary>
		NoLink = 3004,
		/// <summary>A write was attempted on a stale version of the object.</summary>
		Stale = 3005,
		/// <summary>The max link count has been exceeded.</summary>
		MaxLink = 3006,
		/// <summary>The reachability of the target cannot be determined.</summary>
		ReachabilityUnknown = 4001,
		/// <summary>Network service for connection is unavailable.</summary>
		ConnectionNoService = 5001,
		/// <summary>To be added.</summary>
		ConnectionIgnore = 5002,
	}
	/// <summary>Extension methods for the <see cref="global::SystemConfiguration.StatusCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::SystemConfiguration.StatusCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class StatusCodeExtensions {
		[Field ("kCFErrorDomainSystemConfiguration", "SystemConfiguration")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the SystemConfiguration.StatusCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this StatusCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.SystemConfiguration.Handle, "kCFErrorDomainSystemConfiguration");
			return _domain;
		}
	}
}
