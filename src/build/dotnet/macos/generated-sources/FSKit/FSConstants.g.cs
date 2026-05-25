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
namespace FSKit {
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	public unsafe partial class FSConstants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string FSKitVersionString {
			get {
				return Marshal.PtrToStringUTF8 (_FSKitVersionString)!;
			}
		}
		/// <summary>Represents the value associated with the constant 'FSDirectoryCookieInitial'.</summary>
		[Field ("FSDirectoryCookieInitial",  "FSKit")]
		public static nuint FSDirectoryCookieInitial {
			get {
				return Dlfcn.GetUIntPtr (Libraries.FSKit.Handle, "FSDirectoryCookieInitial");
			}
		}
		/// <summary>Represents the value associated with the constant 'FSDirectoryVerifierInitial'.</summary>
		[Field ("FSDirectoryVerifierInitial",  "FSKit")]
		public static nuint FSDirectoryVerifierInitial {
			get {
				return Dlfcn.GetUIntPtr (Libraries.FSKit.Handle, "FSDirectoryVerifierInitial");
			}
		}
		/// <summary>Represents the value associated with the constant 'FSKitVersionNumber'.</summary>
		[Field ("FSKitVersionNumber",  "FSKit")]
		public static double FSKitVersionNumber {
			get {
				return Dlfcn.GetDouble (Libraries.FSKit.Handle, "FSKitVersionNumber");
			}
		}
		/// <summary>Represents the value associated with the constant 'FSOperationIDUnspecified'.</summary>
		[Field ("FSOperationIDUnspecified",  "FSKit")]
		public static nuint FSOperationIdUnspecified {
			get {
				return Dlfcn.GetUIntPtr (Libraries.FSKit.Handle, "FSOperationIDUnspecified");
			}
		}
		/// <summary>Represents the value associated with the constant 'FSKitVersionString'.</summary>
		[Field ("FSKitVersionString",  "FSKit")]
		internal static nint _FSKitVersionString {
			get {
				return Dlfcn.GetIntPtr (Libraries.FSKit.Handle, "FSKitVersionString");
			}
		}
	} /* class FSConstants */
}
