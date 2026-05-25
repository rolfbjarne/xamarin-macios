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
namespace CallKit {
	[SupportedOSPlatform ("ios14.5")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum CXErrorCodeNotificationServiceExtensionError : long {
		Unknown = 0,
		InvalidClientProcess = 1,
		MissingNotificationFilteringEntitlement = 2,
	}
	/// <summary>Extension methods for the <see cref="global::CallKit.CXErrorCodeNotificationServiceExtensionError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CallKit.CXErrorCodeNotificationServiceExtensionError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.5")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CXErrorCodeNotificationServiceExtensionErrorExtensions {
		[Field ("CXErrorDomainNotificationServiceExtension", "CallKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CallKit.CXErrorCodeNotificationServiceExtensionError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CXErrorCodeNotificationServiceExtensionError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CallKit.Handle, "CXErrorDomainNotificationServiceExtension");
			return _domain;
		}
	}
}
