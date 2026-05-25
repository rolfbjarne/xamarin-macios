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
	public unsafe partial class DispatchData  {
		/// <summary>Represents the value associated with the constant '_dispatch_data_destructor_free'.</summary>
		[Field ("_dispatch_data_destructor_free",  "/usr/lib/system/libdispatch.dylib")]
		internal static nint free {
			get {
				return Dlfcn.GetIntPtr (Libraries.libdispatch.Handle, "_dispatch_data_destructor_free");
			}
		}
	} /* class DispatchData */
}
