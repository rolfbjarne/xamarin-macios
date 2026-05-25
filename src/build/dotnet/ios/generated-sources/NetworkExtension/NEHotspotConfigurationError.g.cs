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
namespace NetworkExtension {
	/// <summary>Enumerates errors relating to network hostpot configuration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum NEHotspotConfigurationError : long {
		/// <summary>To be added.</summary>
		Invalid = 0,
		/// <summary>To be added.</summary>
		InvalidSsid = 1,
		/// <summary>To be added.</summary>
		InvalidWpaPassphrase = 2,
		/// <summary>To be added.</summary>
		InvalidWepPassphrase = 3,
		/// <summary>To be added.</summary>
		InvalidEapSettings = 4,
		/// <summary>To be added.</summary>
		InvalidHS20Settings = 5,
		/// <summary>To be added.</summary>
		InvalidHS20DomainName = 6,
		/// <summary>To be added.</summary>
		UserDenied = 7,
		/// <summary>To be added.</summary>
		Internal = 8,
		/// <summary>To be added.</summary>
		Pending = 9,
		/// <summary>To be added.</summary>
		SystemConfiguration = 10,
		/// <summary>To be added.</summary>
		Unknown = 11,
		/// <summary>To be added.</summary>
		JoinOnceNotSupported = 12,
		/// <summary>To be added.</summary>
		AlreadyAssociated = 13,
		/// <summary>To be added.</summary>
		ApplicationIsNotInForeground = 14,
		InvalidSsidPrefix = 15,
		UserUnauthorized = 16,
		SystemDenied = 17,
	}
	/// <summary>Extension methods for the <see cref="global::NetworkExtension.NEHotspotConfigurationError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::NetworkExtension.NEHotspotConfigurationError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NEHotspotConfigurationErrorExtensions {
		[Field ("NEHotspotConfigurationErrorDomain", "NetworkExtension")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the NetworkExtension.NEHotspotConfigurationError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NEHotspotConfigurationError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NEHotspotConfigurationErrorDomain");
			return _domain;
		}
	}
}
