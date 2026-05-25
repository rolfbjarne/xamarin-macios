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
namespace AVKit {
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVKitMetadataIdentifier  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApproximateEndDate;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierApproximateEndDate'.</summary>
		[Field ("AVKitMetadataIdentifierApproximateEndDate",  "AVKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ApproximateEndDate {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ApproximateEndDate is null)
					_ApproximateEndDate = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierApproximateEndDate")!;
				return _ApproximateEndDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApproximateStartDate;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierApproximateStartDate'.</summary>
		[Field ("AVKitMetadataIdentifierApproximateStartDate",  "AVKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ApproximateStartDate {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ApproximateStartDate is null)
					_ApproximateStartDate = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierApproximateStartDate")!;
				return _ApproximateStartDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExactEndDate;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierExactEndDate'.</summary>
		[Field ("AVKitMetadataIdentifierExactEndDate",  "AVKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExactEndDate {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExactEndDate is null)
					_ExactEndDate = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierExactEndDate")!;
				return _ExactEndDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExactStartDate;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierExactStartDate'.</summary>
		[Field ("AVKitMetadataIdentifierExactStartDate",  "AVKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExactStartDate {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExactStartDate is null)
					_ExactStartDate = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierExactStartDate")!;
				return _ExactStartDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExternalContentIdentifier;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierExternalContentIdentifier'.</summary>
		[Field ("AVKitMetadataIdentifierExternalContentIdentifier",  "AVKit")]
		public static NSString ExternalContentIdentifier {
			get {
				if (_ExternalContentIdentifier is null)
					_ExternalContentIdentifier = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierExternalContentIdentifier")!;
				return _ExternalContentIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExternalUserProfileIdentifier;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierExternalUserProfileIdentifier'.</summary>
		[Field ("AVKitMetadataIdentifierExternalUserProfileIdentifier",  "AVKit")]
		public static NSString ExternalUserProfileIdentifier {
			get {
				if (_ExternalUserProfileIdentifier is null)
					_ExternalUserProfileIdentifier = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierExternalUserProfileIdentifier")!;
				return _ExternalUserProfileIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaybackProgress;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierPlaybackProgress'.</summary>
		[Field ("AVKitMetadataIdentifierPlaybackProgress",  "AVKit")]
		public static NSString PlaybackProgress {
			get {
				if (_PlaybackProgress is null)
					_PlaybackProgress = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierPlaybackProgress")!;
				return _PlaybackProgress;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServiceIdentifier;
		/// <summary>Represents the value associated with the constant 'AVKitMetadataIdentifierServiceIdentifier'.</summary>
		[Field ("AVKitMetadataIdentifierServiceIdentifier",  "AVKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ServiceIdentifier {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ServiceIdentifier is null)
					_ServiceIdentifier = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitMetadataIdentifierServiceIdentifier")!;
				return _ServiceIdentifier;
			}
		}
	} /* class AVKitMetadataIdentifier */
}
