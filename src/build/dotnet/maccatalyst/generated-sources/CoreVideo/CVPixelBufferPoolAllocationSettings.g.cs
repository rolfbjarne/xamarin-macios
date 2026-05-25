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
