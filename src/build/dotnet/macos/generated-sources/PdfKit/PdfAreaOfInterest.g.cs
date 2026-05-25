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
namespace PdfKit {
	/// <summary>Orable flags that describe areas of interest for a touch position.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Flags]
	[Native]
	public enum PdfAreaOfInterest : long {
		/// <summary>Indicates that the touch position is over an ordinary area.</summary>
		NoArea = 0,
		/// <summary>Indicates that the touch position is over a page.</summary>
		PageArea = 1,
		/// <summary>Indicates that the touch position is over a text area.</summary>
		TextArea = 2,
		/// <summary>Indicates that the touch position is over an annotation.</summary>
		AnnotationArea = 4,
		/// <summary>Indicates that the touch position is over a link.</summary>
		LinkArea = 8,
		/// <summary>Indicates that the touch position is over a control.</summary>
		ControlArea = 16,
		/// <summary>Indicates that the touch position is over a text field.</summary>
		TextFieldArea = 32,
		/// <summary>Indicates that the touch position is over an icon.</summary>
		IconArea = 64,
		/// <summary>Indicates that the touch position is over a popup.</summary>
		PopupArea = 128,
		/// <summary>Indicates that the touch position is over an image.</summary>
		ImageArea = 256,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		AnyArea = 9223372036854775807,
	}
}
