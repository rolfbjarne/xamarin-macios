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
namespace CoreImage {
	/// <summary>Keys that can be used to get output results out of a CIFilter.</summary><remarks>At this point, this only includes the CIFilterOutputKey</remarks>
	public unsafe static partial class CIFilterOutputKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Image;
		/// <summary>Represents the value associated with the constant kCIOutputImageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIOutputImageKey",  "CoreImage")]
		public static NSString Image {
			get {
				if (_Image is null)
					_Image = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIOutputImageKey")!;
				return _Image;
			}
		}
	} /* class CIFilterOutputKey */
}
