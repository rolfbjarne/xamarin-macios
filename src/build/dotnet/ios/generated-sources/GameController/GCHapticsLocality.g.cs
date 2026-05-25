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
namespace GameController {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class GCHapticsLocality  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _All;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityAll'.</summary>
		[Field ("GCHapticsLocalityAll",  "GameController")]
		public static NSString All {
			get {
				if (_All is null)
					_All = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityAll")!;
				return _All;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Default;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityDefault'.</summary>
		[Field ("GCHapticsLocalityDefault",  "GameController")]
		public static NSString Default {
			get {
				if (_Default is null)
					_Default = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityDefault")!;
				return _Default;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Handles;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityHandles'.</summary>
		[Field ("GCHapticsLocalityHandles",  "GameController")]
		public static NSString Handles {
			get {
				if (_Handles is null)
					_Handles = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityHandles")!;
				return _Handles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftHandle;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityLeftHandle'.</summary>
		[Field ("GCHapticsLocalityLeftHandle",  "GameController")]
		public static NSString LeftHandle {
			get {
				if (_LeftHandle is null)
					_LeftHandle = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityLeftHandle")!;
				return _LeftHandle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftTrigger;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityLeftTrigger'.</summary>
		[Field ("GCHapticsLocalityLeftTrigger",  "GameController")]
		public static NSString LeftTrigger {
			get {
				if (_LeftTrigger is null)
					_LeftTrigger = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityLeftTrigger")!;
				return _LeftTrigger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightHandle;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityRightHandle'.</summary>
		[Field ("GCHapticsLocalityRightHandle",  "GameController")]
		public static NSString RightHandle {
			get {
				if (_RightHandle is null)
					_RightHandle = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityRightHandle")!;
				return _RightHandle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightTrigger;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityRightTrigger'.</summary>
		[Field ("GCHapticsLocalityRightTrigger",  "GameController")]
		public static NSString RightTrigger {
			get {
				if (_RightTrigger is null)
					_RightTrigger = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityRightTrigger")!;
				return _RightTrigger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Triggers;
		/// <summary>Represents the value associated with the constant 'GCHapticsLocalityTriggers'.</summary>
		[Field ("GCHapticsLocalityTriggers",  "GameController")]
		public static NSString Triggers {
			get {
				if (_Triggers is null)
					_Triggers = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCHapticsLocalityTriggers")!;
				return _Triggers;
			}
		}
	} /* class GCHapticsLocality */
}
