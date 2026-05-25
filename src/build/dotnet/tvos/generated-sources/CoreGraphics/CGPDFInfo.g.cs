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
	/// <summary>Auxiliary parameters for constructing a <see cref="CoreGraphics.CGContextPDF" />.</summary>
	public unsafe partial class CGPDFInfo  {
		/// <summary>Represents the value associated with the constant 'kCGPDFContextAccessPermissions'.</summary>
		[Field ("kCGPDFContextAccessPermissions",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static nint kCGPDFContextAccessPermissions {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextAccessPermissions");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextAllowsCopying'.</summary>
		[Field ("kCGPDFContextAllowsCopying",  "CoreGraphics")]
		internal static nint kCGPDFContextAllowsCopying {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextAllowsCopying");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextAllowsPrinting'.</summary>
		[Field ("kCGPDFContextAllowsPrinting",  "CoreGraphics")]
		internal static nint kCGPDFContextAllowsPrinting {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextAllowsPrinting");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextAuthor'.</summary>
		[Field ("kCGPDFContextAuthor",  "CoreGraphics")]
		internal static nint kCGPDFContextAuthor {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextAuthor");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextCreateLinearizedPDF'.</summary>
		[Field ("kCGPDFContextCreateLinearizedPDF",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal static nint kCGPDFContextCreateLinearizedPDF {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextCreateLinearizedPDF");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextCreatePDFA'.</summary>
		[Field ("kCGPDFContextCreatePDFA",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal static nint kCGPDFContextCreatePDFA {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextCreatePDFA");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextCreator'.</summary>
		[Field ("kCGPDFContextCreator",  "CoreGraphics")]
		internal static nint kCGPDFContextCreator {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextCreator");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextEncryptionKeyLength'.</summary>
		[Field ("kCGPDFContextEncryptionKeyLength",  "CoreGraphics")]
		internal static nint kCGPDFContextEncryptionKeyLength {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextEncryptionKeyLength");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextKeywords'.</summary>
		[Field ("kCGPDFContextKeywords",  "CoreGraphics")]
		internal static nint kCGPDFContextKeywords {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextKeywords");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextOwnerPassword'.</summary>
		[Field ("kCGPDFContextOwnerPassword",  "CoreGraphics")]
		internal static nint kCGPDFContextOwnerPassword {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextOwnerPassword");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextSubject'.</summary>
		[Field ("kCGPDFContextSubject",  "CoreGraphics")]
		internal static nint kCGPDFContextSubject {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextSubject");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextTitle'.</summary>
		[Field ("kCGPDFContextTitle",  "CoreGraphics")]
		internal static nint kCGPDFContextTitle {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextTitle");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGPDFContextUserPassword'.</summary>
		[Field ("kCGPDFContextUserPassword",  "CoreGraphics")]
		internal static nint kCGPDFContextUserPassword {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreGraphics.Handle, "kCGPDFContextUserPassword");
			}
		}
	} /* class CGPDFInfo */
}
