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
namespace VideoToolbox {
	public unsafe static partial class VTSampleAttachmentKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QualityMetrics;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentKey_QualityMetrics'.</summary>
		[Field ("kVTSampleAttachmentKey_QualityMetrics",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString QualityMetrics {
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			get {
				if (_QualityMetrics is null)
					_QualityMetrics = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentKey_QualityMetrics")!;
				return _QualityMetrics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequireLtrAcknowledgementToken;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentKey_RequireLTRAcknowledgementToken'.</summary>
		[Field ("kVTSampleAttachmentKey_RequireLTRAcknowledgementToken",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString RequireLtrAcknowledgementToken {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_RequireLtrAcknowledgementToken is null)
					_RequireLtrAcknowledgementToken = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentKey_RequireLTRAcknowledgementToken")!;
				return _RequireLtrAcknowledgementToken;
			}
		}
	} /* class VTSampleAttachmentKey */
}
