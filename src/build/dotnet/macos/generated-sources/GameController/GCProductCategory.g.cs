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
namespace GameController {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class GCProductCategory  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArcadeStick;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryArcadeStick'.</summary>
		[Field ("GCProductCategoryArcadeStick",  "GameController")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString ArcadeStick {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_ArcadeStick is null)
					_ArcadeStick = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryArcadeStick")!;
				return _ArcadeStick;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoalescedRemote;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryCoalescedRemote'.</summary>
		[Field ("GCProductCategoryCoalescedRemote",  "GameController")]
		public static NSString CoalescedRemote {
			get {
				if (_CoalescedRemote is null)
					_CoalescedRemote = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryCoalescedRemote")!;
				return _CoalescedRemote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ControlCenterRemote;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryControlCenterRemote'.</summary>
		[Field ("GCProductCategoryControlCenterRemote",  "GameController")]
		public static NSString ControlCenterRemote {
			get {
				if (_ControlCenterRemote is null)
					_ControlCenterRemote = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryControlCenterRemote")!;
				return _ControlCenterRemote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DualSense;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryDualSense'.</summary>
		[Field ("GCProductCategoryDualSense",  "GameController")]
		public static NSString DualSense {
			get {
				if (_DualSense is null)
					_DualSense = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryDualSense")!;
				return _DualSense;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DualShock4;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryDualShock4'.</summary>
		[Field ("GCProductCategoryDualShock4",  "GameController")]
		public static NSString DualShock4 {
			get {
				if (_DualShock4 is null)
					_DualShock4 = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryDualShock4")!;
				return _DualShock4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GCProductCategoryHid;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryHID'.</summary>
		[Obsolete ("Use 'Hid' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("GCProductCategoryHID",  "GameController")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString GCProductCategoryHid {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_GCProductCategoryHid is null)
					_GCProductCategoryHid = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryHID")!;
				return _GCProductCategoryHid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hid;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryHID'.</summary>
		[Field ("GCProductCategoryHID",  "GameController")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString Hid {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_Hid is null)
					_Hid = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryHID")!;
				return _Hid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Keyboard;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryKeyboard'.</summary>
		[Field ("GCProductCategoryKeyboard",  "GameController")]
		public static NSString Keyboard {
			get {
				if (_Keyboard is null)
					_Keyboard = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryKeyboard")!;
				return _Keyboard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MFi;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryMFi'.</summary>
		[Field ("GCProductCategoryMFi",  "GameController")]
		public static NSString MFi {
			get {
				if (_MFi is null)
					_MFi = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryMFi")!;
				return _MFi;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mouse;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryMouse'.</summary>
		[Field ("GCProductCategoryMouse",  "GameController")]
		public static NSString Mouse {
			get {
				if (_Mouse is null)
					_Mouse = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryMouse")!;
				return _Mouse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SiriRemote1stGen;
		/// <summary>Represents the value associated with the constant 'GCProductCategorySiriRemote1stGen'.</summary>
		[Field ("GCProductCategorySiriRemote1stGen",  "GameController")]
		public static NSString SiriRemote1stGen {
			get {
				if (_SiriRemote1stGen is null)
					_SiriRemote1stGen = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategorySiriRemote1stGen")!;
				return _SiriRemote1stGen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SiriRemote2ndGen;
		/// <summary>Represents the value associated with the constant 'GCProductCategorySiriRemote2ndGen'.</summary>
		[Field ("GCProductCategorySiriRemote2ndGen",  "GameController")]
		public static NSString SiriRemote2ndGen {
			get {
				if (_SiriRemote2ndGen is null)
					_SiriRemote2ndGen = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategorySiriRemote2ndGen")!;
				return _SiriRemote2ndGen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpatialController;
		/// <summary>Represents the value associated with the constant 'GCProductCategorySpatialController'.</summary>
		[Field ("GCProductCategorySpatialController",  "GameController")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString SpatialController {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_SpatialController is null)
					_SpatialController = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategorySpatialController")!;
				return _SpatialController;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UniversalElectronicsRemote;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryUniversalElectronicsRemote'.</summary>
		[Field ("GCProductCategoryUniversalElectronicsRemote",  "GameController")]
		public static NSString UniversalElectronicsRemote {
			get {
				if (_UniversalElectronicsRemote is null)
					_UniversalElectronicsRemote = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryUniversalElectronicsRemote")!;
				return _UniversalElectronicsRemote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XboxOne;
		/// <summary>Represents the value associated with the constant 'GCProductCategoryXboxOne'.</summary>
		[Field ("GCProductCategoryXboxOne",  "GameController")]
		public static NSString XboxOne {
			get {
				if (_XboxOne is null)
					_XboxOne = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCProductCategoryXboxOne")!;
				return _XboxOne;
			}
		}
	} /* class GCProductCategory */
}
