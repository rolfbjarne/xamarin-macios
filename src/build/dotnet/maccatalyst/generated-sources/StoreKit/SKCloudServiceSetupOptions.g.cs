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
	/// <summary>Contains cloud service setup options.</summary>
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("macos15.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public partial class SKCloudServiceSetupOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SKCloudServiceSetupOptions" /> with default (empty) values.</summary>
		public SKCloudServiceSetupOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SKCloudServiceSetupOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SKCloudServiceSetupOptions (NSDictionary? dictionary) : base (dictionary) {}
		internal NSString? _Action {
			get {
				return GetNSStringValue (SKCloudServiceSetupOptionsKeys.ActionKey!);
			}
			set {
				SetStringValue (SKCloudServiceSetupOptionsKeys.ActionKey!, value);
			}
		}
		/// <summary>Gets or sets the identifier for the item for which access is being requested.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? ITunesItemIdentifier {
			get {
				return  GetNIntValue (SKCloudServiceSetupOptionsKeys.ITunesItemIdentifierKey!);
			}
			set {
				SetNumberValue (SKCloudServiceSetupOptionsKeys.ITunesItemIdentifierKey!, value);
			}
		}
		/// <summary>Gets or sets the affiliate token.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public string? AffiliateToken {
			get {
				return GetStringValue (SKCloudServiceSetupOptionsKeys.AffiliateTokenKey!);
			}
			set {
				SetStringValue (SKCloudServiceSetupOptionsKeys.AffiliateTokenKey!, value);
			}
		}
		/// <summary>Gets or sets the campaign token.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public string? CampaignToken {
			get {
				return GetStringValue (SKCloudServiceSetupOptionsKeys.CampaignTokenKey!);
			}
			set {
				SetStringValue (SKCloudServiceSetupOptionsKeys.CampaignTokenKey!, value);
			}
		}
		/// <summary>Gets or sets the setup message identifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public string? MessageIdentifier {
			get {
				return GetStringValue (SKCloudServiceSetupOptionsKeys.MessageIdentifierKey!);
			}
			set {
				SetStringValue (SKCloudServiceSetupOptionsKeys.MessageIdentifierKey!, value);
			}
		}
#endif
	}
}
