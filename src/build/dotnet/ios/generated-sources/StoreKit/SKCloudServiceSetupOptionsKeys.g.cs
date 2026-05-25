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
namespace StoreKit {
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	internal unsafe static partial class SKCloudServiceSetupOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActionKey;
		/// <summary>Represents the value associated with the constant 'SKCloudServiceSetupOptionsActionKey'.</summary>
		[Field ("SKCloudServiceSetupOptionsActionKey",  "StoreKit")]
		public static NSString ActionKey {
			get {
				if (_ActionKey is null)
					_ActionKey = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKCloudServiceSetupOptionsActionKey")!;
				return _ActionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AffiliateTokenKey;
		/// <summary>Represents the value associated with the constant 'SKCloudServiceSetupOptionsAffiliateTokenKey'.</summary>
		[Field ("SKCloudServiceSetupOptionsAffiliateTokenKey",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString AffiliateTokenKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_AffiliateTokenKey is null)
					_AffiliateTokenKey = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKCloudServiceSetupOptionsAffiliateTokenKey")!;
				return _AffiliateTokenKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CampaignTokenKey;
		/// <summary>Represents the value associated with the constant 'SKCloudServiceSetupOptionsCampaignTokenKey'.</summary>
		[Field ("SKCloudServiceSetupOptionsCampaignTokenKey",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString CampaignTokenKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_CampaignTokenKey is null)
					_CampaignTokenKey = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKCloudServiceSetupOptionsCampaignTokenKey")!;
				return _CampaignTokenKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ITunesItemIdentifierKey;
		/// <summary>Represents the value associated with the constant 'SKCloudServiceSetupOptionsITunesItemIdentifierKey'.</summary>
		[Field ("SKCloudServiceSetupOptionsITunesItemIdentifierKey",  "StoreKit")]
		public static NSString ITunesItemIdentifierKey {
			get {
				if (_ITunesItemIdentifierKey is null)
					_ITunesItemIdentifierKey = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKCloudServiceSetupOptionsITunesItemIdentifierKey")!;
				return _ITunesItemIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MessageIdentifierKey;
		/// <summary>Represents the value associated with the constant 'SKCloudServiceSetupOptionsMessageIdentifierKey'.</summary>
		[Field ("SKCloudServiceSetupOptionsMessageIdentifierKey",  "StoreKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString MessageIdentifierKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_MessageIdentifierKey is null)
					_MessageIdentifierKey = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKCloudServiceSetupOptionsMessageIdentifierKey")!;
				return _MessageIdentifierKey;
			}
		}
	} /* class SKCloudServiceSetupOptionsKeys */
}
