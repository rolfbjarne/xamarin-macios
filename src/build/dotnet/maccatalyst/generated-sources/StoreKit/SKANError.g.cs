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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace StoreKit {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Native]
	public enum SKANError : long {
		ImpressionMissingRequiredValue = 0,
		Unsupported = 1,
		AdNetworkIdMissing = 2,
		MismatchedSourceAppId = 3,
		ImpressionNotFound = 4,
		InvalidCampaignId = 5,
		InvalidConversionValue = 6,
		InvalidSourceAppId = 7,
		InvalidAdvertisedAppId = 8,
		InvalidVersion = 9,
		Unknown = 10,
		ImpressionTooShort = 11,
	}
	/// <summary>Extension methods for the <see cref="global::StoreKit.SKANError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::StoreKit.SKANError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SKANErrorExtensions {
		[Field ("SKANErrorDomain", "StoreKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the StoreKit.SKANError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SKANError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKANErrorDomain");
			return _domain;
		}
	}
}
