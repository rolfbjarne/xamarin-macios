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
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTPropertyType" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTPropertyTypeKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Boolean;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyType_Boolean",  "VideoToolbox")]
		public static NSString Boolean {
			get {
				if (_Boolean is null)
					_Boolean = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyType_Boolean")!;
				return _Boolean;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Enumeration;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyType_Enumeration",  "VideoToolbox")]
		public static NSString Enumeration {
			get {
				if (_Enumeration is null)
					_Enumeration = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyType_Enumeration")!;
				return _Enumeration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Number;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyType_Number",  "VideoToolbox")]
		public static NSString Number {
			get {
				if (_Number is null)
					_Number = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyType_Number")!;
				return _Number;
			}
		}
	} /* class VTPropertyTypeKeys */
}
