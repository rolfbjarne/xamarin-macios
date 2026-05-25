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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace StoreKit {
	/// <summary>Encapsulates the iTunes identifier for the item that the store should display when the application is displaying a <see cref="T:StoreKit.SKStoreProductViewController" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SKStoreProductParameterKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkAttributionSignature;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdNetworkAttributionSignature.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdNetworkAttributionSignature",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdNetworkAttributionSignature {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdNetworkAttributionSignature is null)
					_AdNetworkAttributionSignature = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkAttributionSignature")!;
				return _AdNetworkAttributionSignature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkCampaignIdentifier;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdNetworkCampaignIdentifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdNetworkCampaignIdentifier",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdNetworkCampaignIdentifier {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdNetworkCampaignIdentifier is null)
					_AdNetworkCampaignIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkCampaignIdentifier")!;
				return _AdNetworkCampaignIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkIdentifier;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdNetworkIdentifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdNetworkIdentifier",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdNetworkIdentifier {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdNetworkIdentifier is null)
					_AdNetworkIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkIdentifier")!;
				return _AdNetworkIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkNonce;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdNetworkNonce.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdNetworkNonce",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdNetworkNonce {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdNetworkNonce is null)
					_AdNetworkNonce = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkNonce")!;
				return _AdNetworkNonce;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkSourceAppStoreIdentifier;
		/// <summary>Represents the value associated with the constant 'SKStoreProductParameterAdNetworkSourceAppStoreIdentifier'.</summary>
		[Field ("SKStoreProductParameterAdNetworkSourceAppStoreIdentifier",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString AdNetworkSourceAppStoreIdentifier {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_AdNetworkSourceAppStoreIdentifier is null)
					_AdNetworkSourceAppStoreIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkSourceAppStoreIdentifier")!;
				return _AdNetworkSourceAppStoreIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkSourceIdentifier;
		/// <summary>Represents the value associated with the constant 'SKStoreProductParameterAdNetworkSourceIdentifier'.</summary>
		[Field ("SKStoreProductParameterAdNetworkSourceIdentifier",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[SupportedOSPlatform ("tvos16.1")]
		public static NSString AdNetworkSourceIdentifier {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios16.1")]
			[SupportedOSPlatform ("maccatalyst16.1")]
			[SupportedOSPlatform ("tvos16.1")]
			get {
				if (_AdNetworkSourceIdentifier is null)
					_AdNetworkSourceIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkSourceIdentifier")!;
				return _AdNetworkSourceIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkTimestamp;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdNetworkTimestamp.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdNetworkTimestamp",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdNetworkTimestamp {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdNetworkTimestamp is null)
					_AdNetworkTimestamp = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkTimestamp")!;
				return _AdNetworkTimestamp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdNetworkVersion;
		/// <summary>Represents the value associated with the constant 'SKStoreProductParameterAdNetworkVersion'.</summary>
		[Field ("SKStoreProductParameterAdNetworkVersion",  "StoreKit")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString AdNetworkVersion {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_AdNetworkVersion is null)
					_AdNetworkVersion = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdNetworkVersion")!;
				return _AdNetworkVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdvertisingPartnerToken;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAdvertisingPartnerToken.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAdvertisingPartnerToken",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AdvertisingPartnerToken {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AdvertisingPartnerToken is null)
					_AdvertisingPartnerToken = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAdvertisingPartnerToken")!;
				return _AdvertisingPartnerToken;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AffiliateToken;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterAffiliateToken</summary><value></value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterAffiliateToken",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AffiliateToken {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AffiliateToken is null)
					_AffiliateToken = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterAffiliateToken")!;
				return _AffiliateToken;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CampaignToken;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterCampaignToken</summary><value></value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterCampaignToken",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CampaignToken {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CampaignToken is null)
					_CampaignToken = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterCampaignToken")!;
				return _CampaignToken;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CustomProductPageIdentifier;
		/// <summary>Represents the value associated with the constant 'SKStoreProductParameterCustomProductPageIdentifier'.</summary>
		[Field ("SKStoreProductParameterCustomProductPageIdentifier",  "StoreKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CustomProductPageIdentifier {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CustomProductPageIdentifier is null)
					_CustomProductPageIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterCustomProductPageIdentifier")!;
				return _CustomProductPageIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ITunesItemIdentifier;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterITunesItemIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterITunesItemIdentifier",  "StoreKit")]
		public static NSString ITunesItemIdentifier {
			get {
				if (_ITunesItemIdentifier is null)
					_ITunesItemIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterITunesItemIdentifier")!;
				return _ITunesItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProductIdentifier;
		/// <summary>Represents the value associated with the constant SKStoreProductParameterProductIdentifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterProductIdentifier",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProductIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProductIdentifier is null)
					_ProductIdentifier = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterProductIdentifier")!;
				return _ProductIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProviderToken;
		/// <summary>TRepresents the value associated with the constant SKStoreProductParameterProviderToken.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SKStoreProductParameterProviderToken",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProviderToken {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProviderToken is null)
					_ProviderToken = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKStoreProductParameterProviderToken")!;
				return _ProviderToken;
			}
		}
	} /* class SKStoreProductParameterKey */
}
