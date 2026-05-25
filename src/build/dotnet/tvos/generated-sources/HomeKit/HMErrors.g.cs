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
namespace HomeKit {
	/// <summary>Holds the constant <see cref="P:HomeKit.HMErrors.HMErrorDomain" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class HMErrors  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HMErrorDomain;
		/// <summary>Represents the value associated with the constant HMErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("HMErrorDomain",  "HomeKit")]
		public static NSString HMErrorDomain {
			get {
				if (_HMErrorDomain is null)
					_HMErrorDomain = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMErrorDomain")!;
				return _HMErrorDomain;
			}
		}
	} /* class HMErrors */
}
