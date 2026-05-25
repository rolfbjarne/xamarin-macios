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
namespace CoreSpotlight {
	public unsafe partial class CoreSpotlightConstants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CoreSpotlightVersionString {
			get {
				return Marshal.PtrToStringUTF8 (_CoreSpotlightVersionString)!;
			}
		}
		/// <summary>Represents the value associated with the constant 'CoreSpotlightVersionNumber'.</summary>
		[Field ("CoreSpotlightVersionNumber",  "CoreSpotlight")]
		public static double CoreSpotlightVersionNumber {
			get {
				return Dlfcn.GetDouble (Libraries.CoreSpotlight.Handle, "CoreSpotlightVersionNumber");
			}
		}
		/// <summary>Represents the value associated with the constant 'CoreSpotlightVersionString'.</summary>
		[Field ("CoreSpotlightVersionString",  "CoreSpotlight")]
		internal static nint _CoreSpotlightVersionString {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreSpotlight.Handle, "CoreSpotlightVersionString");
			}
		}
	} /* class CoreSpotlightConstants */
}
