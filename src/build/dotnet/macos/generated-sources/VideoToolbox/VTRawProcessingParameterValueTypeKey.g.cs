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
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public unsafe static partial class VTRawProcessingParameterValueTypeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Boolean;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterValueType_Boolean'.</summary>
		[Field ("kVTRAWProcessingParameterValueType_Boolean",  "VideoToolbox")]
		public static NSString Boolean {
			get {
				if (_Boolean is null)
					_Boolean = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterValueType_Boolean")!;
				return _Boolean;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Float;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterValueType_Float'.</summary>
		[Field ("kVTRAWProcessingParameterValueType_Float",  "VideoToolbox")]
		public static NSString Float {
			get {
				if (_Float is null)
					_Float = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterValueType_Float")!;
				return _Float;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Integer;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterValueType_Integer'.</summary>
		[Field ("kVTRAWProcessingParameterValueType_Integer",  "VideoToolbox")]
		public static NSString Integer {
			get {
				if (_Integer is null)
					_Integer = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterValueType_Integer")!;
				return _Integer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _List;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterValueType_List'.</summary>
		[Field ("kVTRAWProcessingParameterValueType_List",  "VideoToolbox")]
		public static NSString List {
			get {
				if (_List is null)
					_List = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterValueType_List")!;
				return _List;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubGroup;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterValueType_SubGroup'.</summary>
		[Field ("kVTRAWProcessingParameterValueType_SubGroup",  "VideoToolbox")]
		public static NSString SubGroup {
			get {
				if (_SubGroup is null)
					_SubGroup = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterValueType_SubGroup")!;
				return _SubGroup;
			}
		}
	} /* class VTRawProcessingParameterValueTypeKey */
}
