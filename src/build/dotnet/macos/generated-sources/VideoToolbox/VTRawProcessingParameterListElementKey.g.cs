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
	public unsafe static partial class VTRawProcessingParameterListElementKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Description;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterListElement_Description'.</summary>
		[Field ("kVTRAWProcessingParameterListElement_Description",  "VideoToolbox")]
		public static NSString Description {
			get {
				if (_Description is null)
					_Description = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterListElement_Description")!;
				return _Description;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Label;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterListElement_Label'.</summary>
		[Field ("kVTRAWProcessingParameterListElement_Label",  "VideoToolbox")]
		public static NSString Label {
			get {
				if (_Label is null)
					_Label = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterListElement_Label")!;
				return _Label;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListElementId;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingParameterListElement_ListElementID'.</summary>
		[Field ("kVTRAWProcessingParameterListElement_ListElementID",  "VideoToolbox")]
		public static NSString ListElementId {
			get {
				if (_ListElementId is null)
					_ListElementId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingParameterListElement_ListElementID")!;
				return _ListElementId;
			}
		}
	} /* class VTRawProcessingParameterListElementKey */
}
