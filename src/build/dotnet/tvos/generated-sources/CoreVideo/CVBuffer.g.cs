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
namespace CoreVideo {
	/// <summary>A Core Video data buffer, containing video, audio, or other type of data.</summary>
	public unsafe partial class CVBuffer  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MovieTimeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferMovieTimeKey",  "CoreVideo")]
		public static NSString MovieTimeKey {
			get {
				if (_MovieTimeKey is null)
					_MovieTimeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferMovieTimeKey")!;
				return _MovieTimeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NonPropagatedAttachmentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferNonPropagatedAttachmentsKey",  "CoreVideo")]
		public static NSString NonPropagatedAttachmentsKey {
			get {
				if (_NonPropagatedAttachmentsKey is null)
					_NonPropagatedAttachmentsKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferNonPropagatedAttachmentsKey")!;
				return _NonPropagatedAttachmentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropagatedAttachmentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferPropagatedAttachmentsKey",  "CoreVideo")]
		public static NSString PropagatedAttachmentsKey {
			get {
				if (_PropagatedAttachmentsKey is null)
					_PropagatedAttachmentsKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferPropagatedAttachmentsKey")!;
				return _PropagatedAttachmentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeScaleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferTimeScaleKey",  "CoreVideo")]
		public static NSString TimeScaleKey {
			get {
				if (_TimeScaleKey is null)
					_TimeScaleKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferTimeScaleKey")!;
				return _TimeScaleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeValueKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferTimeValueKey",  "CoreVideo")]
		public static NSString TimeValueKey {
			get {
				if (_TimeValueKey is null)
					_TimeValueKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferTimeValueKey")!;
				return _TimeValueKey;
			}
		}
	} /* class CVBuffer */
}
