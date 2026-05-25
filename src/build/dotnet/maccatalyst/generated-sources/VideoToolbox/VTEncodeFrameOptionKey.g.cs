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
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTEncodeFrameOptions" /></summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTEncodeFrameOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AcknowledgedLtrTokens;
		/// <summary>Represents the value associated with the constant 'kVTEncodeFrameOptionKey_AcknowledgedLTRTokens'.</summary>
		[Field ("kVTEncodeFrameOptionKey_AcknowledgedLTRTokens",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AcknowledgedLtrTokens {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AcknowledgedLtrTokens is null)
					_AcknowledgedLtrTokens = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTEncodeFrameOptionKey_AcknowledgedLTRTokens")!;
				return _AcknowledgedLtrTokens;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseFrameQP;
		/// <summary>Represents the value associated with the constant 'kVTEncodeFrameOptionKey_BaseFrameQP'.</summary>
		[Field ("kVTEncodeFrameOptionKey_BaseFrameQP",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BaseFrameQP {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BaseFrameQP is null)
					_BaseFrameQP = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTEncodeFrameOptionKey_BaseFrameQP")!;
				return _BaseFrameQP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForceKeyFrame;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTEncodeFrameOptionKey_ForceKeyFrame",  "VideoToolbox")]
		public static NSString ForceKeyFrame {
			get {
				if (_ForceKeyFrame is null)
					_ForceKeyFrame = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTEncodeFrameOptionKey_ForceKeyFrame")!;
				return _ForceKeyFrame;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForceLtrRefresh;
		/// <summary>Represents the value associated with the constant 'kVTEncodeFrameOptionKey_ForceLTRRefresh'.</summary>
		[Field ("kVTEncodeFrameOptionKey_ForceLTRRefresh",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ForceLtrRefresh {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ForceLtrRefresh is null)
					_ForceLtrRefresh = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTEncodeFrameOptionKey_ForceLTRRefresh")!;
				return _ForceLtrRefresh;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequireLtrAcknowledgementToken;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentKey_RequireLTRAcknowledgementToken'.</summary>
		[Field ("kVTSampleAttachmentKey_RequireLTRAcknowledgementToken",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RequireLtrAcknowledgementToken {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RequireLtrAcknowledgementToken is null)
					_RequireLtrAcknowledgementToken = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentKey_RequireLTRAcknowledgementToken")!;
				return _RequireLtrAcknowledgementToken;
			}
		}
	} /* class VTEncodeFrameOptionKey */
}
