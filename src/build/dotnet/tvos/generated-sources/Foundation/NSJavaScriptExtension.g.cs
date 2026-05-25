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
namespace Foundation {
	/// <summary>Defines the strings associated with the constants <c>NSExtensionJavaScriptFinalizeArgumentKey</c> and <c>NSExtensionJavaScriptPreprocessingResultsKey</c>.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSJavaScriptExtension  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FinalizeArgumentKey;
		/// <summary>A key whose value is an <see cref="T:Foundation.NSDictionary" /> whose contents are the arguments to a JavaScript finalize method.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSExtensionJavaScriptFinalizeArgumentKey",  "Foundation")]
		public static NSString FinalizeArgumentKey {
			get {
				if (_FinalizeArgumentKey is null)
					_FinalizeArgumentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSExtensionJavaScriptFinalizeArgumentKey")!;
				return _FinalizeArgumentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreprocessingResultsKey;
		/// <summary>A key whose value is an <see cref="T:Foundation.NSDictionary" /> whose contents are the argument to a JavaScript completion function.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSExtensionJavaScriptPreprocessingResultsKey",  "Foundation")]
		public static NSString PreprocessingResultsKey {
			get {
				if (_PreprocessingResultsKey is null)
					_PreprocessingResultsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSExtensionJavaScriptPreprocessingResultsKey")!;
				return _PreprocessingResultsKey;
			}
		}
	} /* class NSJavaScriptExtension */
}
