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
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTPropertyOptions" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTPropertyKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyDocumentationKey",  "VideoToolbox")]
		public static NSString DocumentationKey {
			get {
				if (_DocumentationKey is null)
					_DocumentationKey = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyDocumentationKey")!;
				return _DocumentationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReadWriteStatus;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyReadWriteStatusKey",  "VideoToolbox")]
		public static NSString ReadWriteStatus {
			get {
				if (_ReadWriteStatus is null)
					_ReadWriteStatus = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatusKey")!;
				return _ReadWriteStatus;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldBeSerialized;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyShouldBeSerializedKey",  "VideoToolbox")]
		public static NSString ShouldBeSerialized {
			get {
				if (_ShouldBeSerialized is null)
					_ShouldBeSerialized = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyShouldBeSerializedKey")!;
				return _ShouldBeSerialized;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedValueListKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertySupportedValueListKey",  "VideoToolbox")]
		public static NSString SupportedValueListKey {
			get {
				if (_SupportedValueListKey is null)
					_SupportedValueListKey = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueListKey")!;
				return _SupportedValueListKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedValueMaximumKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertySupportedValueMaximumKey",  "VideoToolbox")]
		public static NSString SupportedValueMaximumKey {
			get {
				if (_SupportedValueMaximumKey is null)
					_SupportedValueMaximumKey = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueMaximumKey")!;
				return _SupportedValueMaximumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedValueMinimumKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertySupportedValueMinimumKey",  "VideoToolbox")]
		public static NSString SupportedValueMinimumKey {
			get {
				if (_SupportedValueMinimumKey is null)
					_SupportedValueMinimumKey = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueMinimumKey")!;
				return _SupportedValueMinimumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPropertyTypeKey",  "VideoToolbox")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPropertyTypeKey")!;
				return _Type;
			}
		}
	} /* class VTPropertyKeys */
}
