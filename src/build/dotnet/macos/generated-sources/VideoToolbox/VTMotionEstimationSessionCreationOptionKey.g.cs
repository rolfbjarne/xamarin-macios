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
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe static partial class VTMotionEstimationSessionCreationOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Label;
		/// <summary>Represents the value associated with the constant 'kVTMotionEstimationSessionCreationOption_Label'.</summary>
		[Field ("kVTMotionEstimationSessionCreationOption_Label",  "VideoToolbox")]
		public static NSString Label {
			get {
				if (_Label is null)
					_Label = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTMotionEstimationSessionCreationOption_Label")!;
				return _Label;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MotionVectorSize;
		/// <summary>Represents the value associated with the constant 'kVTMotionEstimationSessionCreationOption_MotionVectorSize'.</summary>
		[Field ("kVTMotionEstimationSessionCreationOption_MotionVectorSize",  "VideoToolbox")]
		public static NSString MotionVectorSize {
			get {
				if (_MotionVectorSize is null)
					_MotionVectorSize = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTMotionEstimationSessionCreationOption_MotionVectorSize")!;
				return _MotionVectorSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseMultiPassSearch;
		/// <summary>Represents the value associated with the constant 'kVTMotionEstimationSessionCreationOption_UseMultiPassSearch'.</summary>
		[Field ("kVTMotionEstimationSessionCreationOption_UseMultiPassSearch",  "VideoToolbox")]
		public static NSString UseMultiPassSearch {
			get {
				if (_UseMultiPassSearch is null)
					_UseMultiPassSearch = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTMotionEstimationSessionCreationOption_UseMultiPassSearch")!;
				return _UseMultiPassSearch;
			}
		}
	} /* class VTMotionEstimationSessionCreationOptionKey */
}
