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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class NWContentContextConstants  {
		/// <summary>Represents the value associated with the constant '_nw_content_context_default_message'.</summary>
		[Field ("_nw_content_context_default_message",  "Network")]
		public static nint _DefaultMessage {
			get {
				return Dlfcn.GetIntPtr (Libraries.Network.Handle, "_nw_content_context_default_message");
			}
		}
		/// <summary>Represents the value associated with the constant '_nw_content_context_default_stream'.</summary>
		[Field ("_nw_content_context_default_stream",  "Network")]
		public static nint _DefaultStream {
			get {
				return Dlfcn.GetIntPtr (Libraries.Network.Handle, "_nw_content_context_default_stream");
			}
		}
		/// <summary>Represents the value associated with the constant '_nw_content_context_final_send'.</summary>
		[Field ("_nw_content_context_final_send",  "Network")]
		public static nint _FinalSend {
			get {
				return Dlfcn.GetIntPtr (Libraries.Network.Handle, "_nw_content_context_final_send");
			}
		}
	} /* class NWContentContextConstants */
}
