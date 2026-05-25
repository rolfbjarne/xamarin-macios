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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
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
