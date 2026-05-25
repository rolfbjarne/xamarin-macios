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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>Defines constants for use with <see cref="P:Foundation.NSUrlSessionTask.Priority" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSUrlSessionTaskPriority  {
		/// <summary>Represents the value associated with the constant NSURLSessionTaskPriorityDefault</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLSessionTaskPriorityDefault",  "Foundation")]
		public static float Default {
			get {
				return Dlfcn.GetFloat (Libraries.Foundation.Handle, "NSURLSessionTaskPriorityDefault");
			}
		}
		/// <summary>Represents the value associated with the constant NSURLSessionTaskPriorityHigh</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLSessionTaskPriorityHigh",  "Foundation")]
		public static float High {
			get {
				return Dlfcn.GetFloat (Libraries.Foundation.Handle, "NSURLSessionTaskPriorityHigh");
			}
		}
		/// <summary>Represents the value associated with the constant NSURLSessionTaskPriorityLow</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLSessionTaskPriorityLow",  "Foundation")]
		public static float Low {
			get {
				return Dlfcn.GetFloat (Libraries.Foundation.Handle, "NSURLSessionTaskPriorityLow");
			}
		}
	} /* class NSUrlSessionTaskPriority */
}
