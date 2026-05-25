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
namespace ImageCaptureCore {
	public unsafe static partial class ICScannerStatus  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequestsOverviewScan;
		/// <summary>Represents the value associated with the constant 'ICScannerStatusRequestsOverviewScan'.</summary>
		[Field ("ICScannerStatusRequestsOverviewScan",  "ImageCaptureCore")]
		public static NSString RequestsOverviewScan {
			get {
				if (_RequestsOverviewScan is null)
					_RequestsOverviewScan = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICScannerStatusRequestsOverviewScan")!;
				return _RequestsOverviewScan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WarmUpDone;
		/// <summary>Represents the value associated with the constant 'ICScannerStatusWarmUpDone'.</summary>
		[Field ("ICScannerStatusWarmUpDone",  "ImageCaptureCore")]
		public static NSString WarmUpDone {
			get {
				if (_WarmUpDone is null)
					_WarmUpDone = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICScannerStatusWarmUpDone")!;
				return _WarmUpDone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WarmingUp;
		/// <summary>Represents the value associated with the constant 'ICScannerStatusWarmingUp'.</summary>
		[Field ("ICScannerStatusWarmingUp",  "ImageCaptureCore")]
		public static NSString WarmingUp {
			get {
				if (_WarmingUp is null)
					_WarmingUp = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICScannerStatusWarmingUp")!;
				return _WarmingUp;
			}
		}
	} /* class ICScannerStatus */
}
