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
	public unsafe static partial class VTRawProcessingParameterKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_CameraValue'.</summary>
		[Field ("kVTRAWProcessingParameter_CameraValue",  "VideoToolbox")]
		public static NSString CameraValue {
			get {
				if (_CameraValue is null)
					_CameraValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_CameraValue")!;
				return _CameraValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_CurrentValue'.</summary>
		[Field ("kVTRAWProcessingParameter_CurrentValue",  "VideoToolbox")]
		public static NSString CurrentValue {
			get {
				if (_CurrentValue is null)
					_CurrentValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_CurrentValue")!;
				return _CurrentValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Description;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_Description'.</summary>
		[Field ("kVTRAWProcessingParameter_Description",  "VideoToolbox")]
		public static NSString Description {
			get {
				if (_Description is null)
					_Description = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_Description")!;
				return _Description;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Enabled;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_Enabled'.</summary>
		[Field ("kVTRAWProcessingParameter_Enabled",  "VideoToolbox")]
		public static NSString Enabled {
			get {
				if (_Enabled is null)
					_Enabled = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_Enabled")!;
				return _Enabled;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InitialValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_InitialValue'.</summary>
		[Field ("kVTRAWProcessingParameter_InitialValue",  "VideoToolbox")]
		public static NSString InitialValue {
			get {
				if (_InitialValue is null)
					_InitialValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_InitialValue")!;
				return _InitialValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Key;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_Key'.</summary>
		[Field ("kVTRAWProcessingParameter_Key",  "VideoToolbox")]
		public static NSString Key {
			get {
				if (_Key is null)
					_Key = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_Key")!;
				return _Key;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListArray;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_ListArray'.</summary>
		[Field ("kVTRAWProcessingParameter_ListArray",  "VideoToolbox")]
		public static NSString ListArray {
			get {
				if (_ListArray is null)
					_ListArray = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_ListArray")!;
				return _ListArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_MaximumValue'.</summary>
		[Field ("kVTRAWProcessingParameter_MaximumValue",  "VideoToolbox")]
		public static NSString MaximumValue {
			get {
				if (_MaximumValue is null)
					_MaximumValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_MaximumValue")!;
				return _MaximumValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_MinimumValue'.</summary>
		[Field ("kVTRAWProcessingParameter_MinimumValue",  "VideoToolbox")]
		public static NSString MinimumValue {
			get {
				if (_MinimumValue is null)
					_MinimumValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_MinimumValue")!;
				return _MinimumValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_Name'.</summary>
		[Field ("kVTRAWProcessingParameter_Name",  "VideoToolbox")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_Name")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralValue;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_NeutralValue'.</summary>
		[Field ("kVTRAWProcessingParameter_NeutralValue",  "VideoToolbox")]
		public static NSString NeutralValue {
			get {
				if (_NeutralValue is null)
					_NeutralValue = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_NeutralValue")!;
				return _NeutralValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubGroup;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_SubGroup'.</summary>
		[Field ("kVTRAWProcessingParameter_SubGroup",  "VideoToolbox")]
		public static NSString SubGroup {
			get {
				if (_SubGroup is null)
					_SubGroup = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_SubGroup")!;
				return _SubGroup;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueType;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameter_ValueType'.</summary>
		[Field ("kVTRAWProcessingParameter_ValueType",  "VideoToolbox")]
		public static NSString ValueType {
			get {
				if (_ValueType is null)
					_ValueType = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameter_ValueType")!;
				return _ValueType;
			}
		}
	} /* class VTRawProcessingParameterKey */
}
