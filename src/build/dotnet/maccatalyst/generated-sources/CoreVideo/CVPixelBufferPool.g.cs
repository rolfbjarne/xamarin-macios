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
	/// <summary>A reusable set of <see cref="T:CoreVideo.CVPixelBuffer" />s.</summary>
	public unsafe partial class CVPixelBufferPool  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumBufferAgeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferPoolMaximumBufferAgeKey",  "CoreVideo")]
		public static NSString MaximumBufferAgeKey {
			get {
				if (_MaximumBufferAgeKey is null)
					_MaximumBufferAgeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferPoolMaximumBufferAgeKey")!;
				return _MaximumBufferAgeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumBufferCountKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferPoolMinimumBufferCountKey",  "CoreVideo")]
		public static NSString MinimumBufferCountKey {
			get {
				if (_MinimumBufferCountKey is null)
					_MinimumBufferCountKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferPoolMinimumBufferCountKey")!;
				return _MinimumBufferCountKey;
			}
		}
	} /* class CVPixelBufferPool */
}
