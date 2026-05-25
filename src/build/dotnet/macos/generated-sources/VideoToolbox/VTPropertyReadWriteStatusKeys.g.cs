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
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTPropertyOptions.ReadWriteStatus" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTPropertyReadWriteStatusKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReadOnly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyReadWriteStatus_ReadOnly",  "VideoToolbox")]
		public static NSString ReadOnly {
			get {
				if (_ReadOnly is null)
					_ReadOnly = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatus_ReadOnly")!;
				return _ReadOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReadWrite;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyReadWriteStatus_ReadWrite",  "VideoToolbox")]
		public static NSString ReadWrite {
			get {
				if (_ReadWrite is null)
					_ReadWrite = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatus_ReadWrite")!;
				return _ReadWrite;
			}
		}
	} /* class VTPropertyReadWriteStatusKeys */
}
