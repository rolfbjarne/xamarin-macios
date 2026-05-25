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
	/// <summary>An enumeration whose values specify various errors relating to StoreKit.</summary>
	[Native ("SKErrorCode")]
	public enum SKError : long {
		/// <summary>Indicates an unknown error.</summary>
		Unknown = 0,
		/// <summary>Indicates that the client may not perform the operation.</summary>
		ClientInvalid = 1,
		/// <summary>Indicates that a payment was cancelled.</summary>
		PaymentCancelled = 2,
		/// <summary>Indicates that a payment was invalid.</summary>
		PaymentInvalid = 3,
		/// <summary>Indicates that a payment was not allowed.</summary>
		PaymentNotAllowed = 4,
		/// <summary>Indicates that a product was unavailable.</summary>
		ProductNotAvailable = 5,
		/// <summary>Indicates that the cloud service denied permission for the operation.</summary>
		CloudServicePermissionDenied = 6,
		/// <summary>Indicates that the cloud service network connection failed.</summary>
		CloudServiceNetworkConnectionFailed = 7,
		/// <summary>To be added.</summary>
		CloudServiceRevoked = 8,
		/// <summary>To be added.</summary>
		PrivacyAcknowledgementRequired = 9,
		/// <summary>To be added.</summary>
		UnauthorizedRequestData = 10,
		/// <summary>To be added.</summary>
		InvalidOfferIdentifier = 11,
		/// <summary>To be added.</summary>
		InvalidSignature = 12,
		/// <summary>To be added.</summary>
		MissingOfferParams = 13,
		/// <summary>To be added.</summary>
		InvalidOfferPrice = 14,
		OverlayCancelled = 15,
		OverlayInvalidConfiguration = 16,
		OverlayTimeout = 17,
		IneligibleForOffer = 18,
		UnsupportedPlatform = 19,
		OverlayPresentedInBackgroundScene = 20,
		/// <summary>Indicates that the payment method binding configuration is required.</summary>
		PaymentMethodBindingConfigurationRequired = 21,
	}
	/// <summary>Extension methods for the <see cref="global::StoreKit.SKError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::StoreKit.SKError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SKErrorExtensions {
		[Field ("SKErrorDomain", "StoreKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the StoreKit.SKError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SKError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKErrorDomain");
			return _domain;
		}
	}
}
