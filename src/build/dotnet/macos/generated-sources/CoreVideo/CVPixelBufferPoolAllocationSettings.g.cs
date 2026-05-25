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
namespace CoreVideo {
	/// <summary>Manages pixel buffer pool allocation settings.</summary>
	public unsafe partial class CVPixelBufferPoolAllocationSettings  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThresholdKey;
		/// <summary>Represents the value associated with the constant 'kCVPixelBufferPoolAllocationThresholdKey'.</summary>
		[Field ("kCVPixelBufferPoolAllocationThresholdKey",  "CoreVideo")]
		internal static NSString ThresholdKey {
			get {
				if (_ThresholdKey is null)
					_ThresholdKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferPoolAllocationThresholdKey")!;
				return _ThresholdKey;
			}
		}
	} /* class CVPixelBufferPoolAllocationSettings */
}
