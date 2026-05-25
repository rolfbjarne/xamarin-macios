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
namespace Security {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class SecPropertyKey  {
		/// <summary>Represents the value associated with the constant 'kSecPropertyKeyLabel'.</summary>
		[Field ("kSecPropertyKeyLabel",  "Security")]
		public static nint Label {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecPropertyKeyLabel");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecPropertyKeyLocalizedLabel'.</summary>
		[Field ("kSecPropertyKeyLocalizedLabel",  "Security")]
		public static nint LocalizedLabel {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecPropertyKeyLocalizedLabel");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecPropertyKeyType'.</summary>
		[Field ("kSecPropertyKeyType",  "Security")]
		public static nint Type {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecPropertyKeyType");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecPropertyKeyValue'.</summary>
		[Field ("kSecPropertyKeyValue",  "Security")]
		public static nint Value {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecPropertyKeyValue");
			}
		}
	} /* class SecPropertyKey */
}
