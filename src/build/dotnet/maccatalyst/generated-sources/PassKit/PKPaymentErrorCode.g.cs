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
namespace PassKit {
	/// <summary>Enumerates error conditions for payment operations.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PKPaymentErrorCode : long {
		/// <summary>Indicates that an unknown error occurred.</summary>
		Unknown = -1,
		/// <summary>Indicates that the shipping contact was not valid.</summary>
		ShippingContactInvalid = 1,
		/// <summary>Indicates that the billing contact was not valid.</summary>
		BillingContactInvalid = 2,
		/// <summary>Indicates that the shipping address was not serviceable.</summary>
		ShippingAddressUnserviceable = 3,
		CouponCodeInvalid = 4,
		CouponCodeExpired = 5,
	}
	/// <summary>Extension methods for the <see cref="global::PassKit.PKPaymentErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::PassKit.PKPaymentErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PKPaymentErrorCodeExtensions {
		[Field ("PKPaymentErrorDomain", "PassKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the PassKit.PKPaymentErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this PKPaymentErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentErrorDomain");
			return _domain;
		}
	}
}
