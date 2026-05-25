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
namespace CoreGraphics {
	/// <summary>Specifies various boxes for the <see cref="CoreGraphics.CGContextPDF.BeginPage(CoreGraphics.CGPDFPageInfo)" /> method.</summary>
	public unsafe partial class CGPDFPageInfo  {
		/// <summary>Represents the value associated with the constant 'kCGPDFContextArtBox'.</summary>
		[Field ("kCGPDFContextArtBox",  "CoreGraphics")]
		internal static nint kCGPDFContextArtBox {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextArtBox");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextBleedBox'.</summary>
		[Field ("kCGPDFContextBleedBox",  "CoreGraphics")]
		internal static nint kCGPDFContextBleedBox {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextBleedBox");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextCropBox'.</summary>
		[Field ("kCGPDFContextCropBox",  "CoreGraphics")]
		internal static nint kCGPDFContextCropBox {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextCropBox");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextMediaBox'.</summary>
		[Field ("kCGPDFContextMediaBox",  "CoreGraphics")]
		internal static nint kCGPDFContextMediaBox {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextMediaBox");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextTrimBox'.</summary>
		[Field ("kCGPDFContextTrimBox",  "CoreGraphics")]
		internal static nint kCGPDFContextTrimBox {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextTrimBox");
			}
		}
	} /* class CGPDFPageInfo */
}
