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
