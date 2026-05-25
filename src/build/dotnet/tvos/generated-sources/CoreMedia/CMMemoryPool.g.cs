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
namespace CoreMedia {
	/// <summary>Class that manages the repetitive allocation and deallocation of large blocks of memory.</summary><!-- TODO: No Apple documentation on this as of 2013-05-01 -->
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CMMemoryPool  {
		/// <summary>Represents the value associated with the constant 'kCMMemoryPoolOption_AgeOutPeriod'.</summary>
		[Field ("kCMMemoryPoolOption_AgeOutPeriod",  "CoreMedia")]
		internal static nint AgeOutPeriodSelector {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreMedia.Handle, "kCMMemoryPoolOption_AgeOutPeriod");
			}
		}
	} /* class CMMemoryPool */
}
