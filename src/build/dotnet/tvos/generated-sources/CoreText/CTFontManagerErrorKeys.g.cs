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
namespace CoreText {
	public unsafe static partial class CTFontManagerErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontUrlsKey;
		/// <summary>Represents the value associated with the constant 'kCTFontManagerErrorFontURLsKey'.</summary>
		[Field ("kCTFontManagerErrorFontURLsKey",  "CoreText")]
		public static NSString FontUrlsKey {
			get {
				if (_FontUrlsKey is null)
					_FontUrlsKey = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManagerErrorFontURLsKey")!;
				return _FontUrlsKey;
			}
		}
	} /* class CTFontManagerErrorKeys */
}
