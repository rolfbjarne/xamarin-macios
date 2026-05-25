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
namespace CoreFoundation {
	/// <summary>A class that allows for explicit allocation and de-allocation of memory.</summary>
	public unsafe partial class CFAllocator  {
		/// <summary>Represents the value associated with the constant 'kCFAllocatorDefault'.</summary>
		[Field ("kCFAllocatorDefault",  "CoreFoundation")]
		internal static nint default_ptr {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreFoundation.Handle, "kCFAllocatorDefault");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFAllocatorMalloc'.</summary>
		[Field ("kCFAllocatorMalloc",  "CoreFoundation")]
		internal static nint malloc_ptr {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreFoundation.Handle, "kCFAllocatorMalloc");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFAllocatorMallocZone'.</summary>
		[Field ("kCFAllocatorMallocZone",  "CoreFoundation")]
		internal static nint malloc_zone_ptr {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreFoundation.Handle, "kCFAllocatorMallocZone");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFAllocatorNull'.</summary>
		[Field ("kCFAllocatorNull",  "CoreFoundation")]
		internal static nint null_ptr {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreFoundation.Handle, "kCFAllocatorNull");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFAllocatorSystemDefault'.</summary>
		[Field ("kCFAllocatorSystemDefault",  "CoreFoundation")]
		internal static nint system_default_ptr {
			get {
				return Dlfcn.GetIntPtr (Libraries.CoreFoundation.Handle, "kCFAllocatorSystemDefault");
			}
		}
	} /* class CFAllocator */
}
