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
namespace Network {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class NWPrivacyContextConstants  {
		/// <summary>Represents the value associated with the constant '_nw_privacy_context_default_context'.</summary>
		[Field ("_nw_privacy_context_default_context",  "Network")]
		public static nint _DefaultContext {
			get {
				return Dlfcn.GetIntPtr (Libraries.Network.Handle, "_nw_privacy_context_default_context");
			}
		}
	} /* class NWPrivacyContextConstants */
}
