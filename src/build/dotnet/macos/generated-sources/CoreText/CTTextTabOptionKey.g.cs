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
namespace CoreText {
	/// <summary>A class whose static properties can be used as keys for the <see cref="T:Foundation.NSDictionary" /> used by <see cref="CoreText.CTTextTabOptions" />.</summary>
	public unsafe static partial class CTTextTabOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnTerminators;
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Field ("kCTTabColumnTerminatorsAttributeName",  "CoreText")]
		public static NSString ColumnTerminators {
			get {
				if (_ColumnTerminators is null)
					_ColumnTerminators = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTTabColumnTerminatorsAttributeName")!;
				return _ColumnTerminators;
			}
		}
	} /* class CTTextTabOptionKey */
}
