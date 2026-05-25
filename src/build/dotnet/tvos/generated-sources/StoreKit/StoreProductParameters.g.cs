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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class StoreProductParameters : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="StoreProductParameters" /> with default (empty) values.</summary>
		public StoreProductParameters () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="StoreProductParameters" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public StoreProductParameters (NSDictionary? dictionary) : base (dictionary) {}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public string? ProductIdentifier {
			get {
				return GetStringValue (SKStoreProductParameterKey.ProductIdentifier!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.ProductIdentifier!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public string? ProviderToken {
			get {
				return GetStringValue (SKStoreProductParameterKey.ProviderToken!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.ProviderToken!, value);
			}
		}
		/// <summary>Gets or sets the ad network's cryptographic signature. Used for attribution.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public string? AdNetworkAttributionSignature {
			get {
				return GetStringValue (SKStoreProductParameterKey.AdNetworkAttributionSignature!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.AdNetworkAttributionSignature!, value);
			}
		}
		/// <summary>Gets or sets the ad network campaign.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public uint? AdNetworkCampaignIdentifier {
			get {
				return  GetUInt32Value (SKStoreProductParameterKey.AdNetworkCampaignIdentifier!);
			}
			set {
				SetNumberValue (SKStoreProductParameterKey.AdNetworkCampaignIdentifier!, value);
			}
		}
		/// <summary>Gets or sets the ad network's unique ID.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public string? AdNetworkIdentifier {
			get {
				return GetStringValue (SKStoreProductParameterKey.AdNetworkIdentifier!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.AdNetworkIdentifier!, value);
			}
		}
		/// <summary>Gets or sets a cryptographic nonce value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public NSUuid? AdNetworkNonce {
			get {
				return Dictionary [SKStoreProductParameterKey.AdNetworkNonce!] as Foundation.NSUuid;
			}
			set {
				SetNativeValue (SKStoreProductParameterKey.AdNetworkNonce!, value);
			}
		}
		/// <summary>Gets or sets a key for the time of the ad impression.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public uint? AdNetworkTimestamp {
			get {
				return  GetUInt32Value (SKStoreProductParameterKey.AdNetworkTimestamp!);
			}
			set {
				SetNumberValue (SKStoreProductParameterKey.AdNetworkTimestamp!, value);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string? AdNetworkSourceAppStoreIdentifier {
			get {
				return GetStringValue (SKStoreProductParameterKey.AdNetworkSourceAppStoreIdentifier!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.AdNetworkSourceAppStoreIdentifier!, value);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string? AdNetworkVersion {
			get {
				return GetStringValue (SKStoreProductParameterKey.AdNetworkVersion!);
			}
			set {
				SetStringValue (SKStoreProductParameterKey.AdNetworkVersion!, value);
			}
		}
#endif
	}
}
