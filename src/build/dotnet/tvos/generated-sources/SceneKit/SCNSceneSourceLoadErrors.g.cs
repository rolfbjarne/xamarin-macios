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
namespace SceneKit {
	/// <summary>Enumerates error types that can occur while loading <see cref="T:SceneKit.SCNSceneSource" />s.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNSceneSourceLoadErrors  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConsistencyElementIDErrorKey;
		/// <summary>Represents the value associated with the constant SCNConsistencyElementIDErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNConsistencyElementIDErrorKey",  "SceneKit")]
		public static NSString ConsistencyElementIDErrorKey {
			get {
				if (_ConsistencyElementIDErrorKey is null)
					_ConsistencyElementIDErrorKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNConsistencyElementIDErrorKey")!;
				return _ConsistencyElementIDErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConsistencyElementTypeErrorKey;
		/// <summary>Represents the value associated with the constant SCNConsistencyElementTypeErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNConsistencyElementTypeErrorKey",  "SceneKit")]
		public static NSString ConsistencyElementTypeErrorKey {
			get {
				if (_ConsistencyElementTypeErrorKey is null)
					_ConsistencyElementTypeErrorKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNConsistencyElementTypeErrorKey")!;
				return _ConsistencyElementTypeErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConsistencyLineNumberErrorKey;
		/// <summary>Represents the value associated with the constant SCNConsistencyLineNumberErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNConsistencyLineNumberErrorKey",  "SceneKit")]
		public static NSString ConsistencyLineNumberErrorKey {
			get {
				if (_ConsistencyLineNumberErrorKey is null)
					_ConsistencyLineNumberErrorKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNConsistencyLineNumberErrorKey")!;
				return _ConsistencyLineNumberErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DetailedErrorsKey;
		/// <summary>Represents the value associated with the constant SCNDetailedErrorsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNDetailedErrorsKey",  "SceneKit")]
		public static NSString DetailedErrorsKey {
			get {
				if (_DetailedErrorsKey is null)
					_DetailedErrorsKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNDetailedErrorsKey")!;
				return _DetailedErrorsKey;
			}
		}
	} /* class SCNSceneSourceLoadErrors */
}
