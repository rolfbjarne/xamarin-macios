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
	/// <summary>A class whose static property can be used as a key for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontCollectionOptions" />.</summary>
	public unsafe static partial class CTFontCollectionOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemoveDuplicates;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTFontCollectionRemoveDuplicatesOption",  "CoreText")]
		public static NSString RemoveDuplicates {
			get {
				if (_RemoveDuplicates is null)
					_RemoveDuplicates = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontCollectionRemoveDuplicatesOption")!;
				return _RemoveDuplicates;
			}
		}
	} /* class CTFontCollectionOptionKey */
}
