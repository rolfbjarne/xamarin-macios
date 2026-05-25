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
	public unsafe static partial class GCInput  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonA;
		/// <summary>Represents the value associated with the constant 'GCInputButtonA'.</summary>
		[Field ("GCInputButtonA",  "GameController")]
		public static NSString ButtonA {
			get {
				if (_ButtonA is null)
					_ButtonA = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonA")!;
				return _ButtonA;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonB;
		/// <summary>Represents the value associated with the constant 'GCInputButtonB'.</summary>
		[Field ("GCInputButtonB",  "GameController")]
		public static NSString ButtonB {
			get {
				if (_ButtonB is null)
					_ButtonB = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonB")!;
				return _ButtonB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonHome;
		/// <summary>Represents the value associated with the constant 'GCInputButtonHome'.</summary>
		[Field ("GCInputButtonHome",  "GameController")]
		public static NSString ButtonHome {
			get {
				if (_ButtonHome is null)
					_ButtonHome = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonHome")!;
				return _ButtonHome;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonMenu;
		/// <summary>Represents the value associated with the constant 'GCInputButtonMenu'.</summary>
		[Field ("GCInputButtonMenu",  "GameController")]
		public static NSString ButtonMenu {
			get {
				if (_ButtonMenu is null)
					_ButtonMenu = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonMenu")!;
				return _ButtonMenu;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonOptions;
		/// <summary>Represents the value associated with the constant 'GCInputButtonOptions'.</summary>
		[Field ("GCInputButtonOptions",  "GameController")]
		public static NSString ButtonOptions {
			get {
				if (_ButtonOptions is null)
					_ButtonOptions = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonOptions")!;
				return _ButtonOptions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonShare;
		/// <summary>Represents the value associated with the constant 'GCInputButtonShare'.</summary>
		[Field ("GCInputButtonShare",  "GameController")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ButtonShare {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ButtonShare is null)
					_ButtonShare = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonShare")!;
				return _ButtonShare;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonX;
		/// <summary>Represents the value associated with the constant 'GCInputButtonX'.</summary>
		[Field ("GCInputButtonX",  "GameController")]
		public static NSString ButtonX {
			get {
				if (_ButtonX is null)
					_ButtonX = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonX")!;
				return _ButtonX;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonY;
		/// <summary>Represents the value associated with the constant 'GCInputButtonY'.</summary>
		[Field ("GCInputButtonY",  "GameController")]
		public static NSString ButtonY {
			get {
				if (_ButtonY is null)
					_ButtonY = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputButtonY")!;
				return _ButtonY;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirectionPad;
		/// <summary>Represents the value associated with the constant 'GCInputDirectionPad'.</summary>
		[Field ("GCInputDirectionPad",  "GameController")]
		public static NSString DirectionPad {
			get {
				if (_DirectionPad is null)
					_DirectionPad = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputDirectionPad")!;
				return _DirectionPad;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DualShockTouchpadButton;
		/// <summary>Represents the value associated with the constant 'GCInputDualShockTouchpadButton'.</summary>
		[Field ("GCInputDualShockTouchpadButton",  "GameController")]
		public static NSString DualShockTouchpadButton {
			get {
				if (_DualShockTouchpadButton is null)
					_DualShockTouchpadButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputDualShockTouchpadButton")!;
				return _DualShockTouchpadButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DualShockTouchpadOne;
		/// <summary>Represents the value associated with the constant 'GCInputDualShockTouchpadOne'.</summary>
		[Field ("GCInputDualShockTouchpadOne",  "GameController")]
		public static NSString DualShockTouchpadOne {
			get {
				if (_DualShockTouchpadOne is null)
					_DualShockTouchpadOne = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputDualShockTouchpadOne")!;
				return _DualShockTouchpadOne;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DualShockTouchpadTwo;
		/// <summary>Represents the value associated with the constant 'GCInputDualShockTouchpadTwo'.</summary>
		[Field ("GCInputDualShockTouchpadTwo",  "GameController")]
		public static NSString DualShockTouchpadTwo {
			get {
				if (_DualShockTouchpadTwo is null)
					_DualShockTouchpadTwo = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputDualShockTouchpadTwo")!;
				return _DualShockTouchpadTwo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GripButton;
		/// <summary>Represents the value associated with the constant 'GCInputGripButton'.</summary>
		[Field ("GCInputGripButton",  "GameController")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString GripButton {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_GripButton is null)
					_GripButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputGripButton")!;
				return _GripButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftBumper;
		/// <summary>Represents the value associated with the constant 'GCInputLeftBumper'.</summary>
		[Field ("GCInputLeftBumper",  "GameController")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString LeftBumper {
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			get {
				if (_LeftBumper is null)
					_LeftBumper = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftBumper")!;
				return _LeftBumper;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftShoulder;
		/// <summary>Represents the value associated with the constant 'GCInputLeftShoulder'.</summary>
		[Field ("GCInputLeftShoulder",  "GameController")]
		public static NSString LeftShoulder {
			get {
				if (_LeftShoulder is null)
					_LeftShoulder = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftShoulder")!;
				return _LeftShoulder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftSideButton;
		/// <summary>Represents the value associated with the constant 'GCInputLeftSideButton'.</summary>
		[Field ("GCInputLeftSideButton",  "GameController")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public static NSString LeftSideButton {
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("macos26.4")]
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			get {
				if (_LeftSideButton is null)
					_LeftSideButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftSideButton")!;
				return _LeftSideButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftThumbstick;
		/// <summary>Represents the value associated with the constant 'GCInputLeftThumbstick'.</summary>
		[Field ("GCInputLeftThumbstick",  "GameController")]
		public static NSString LeftThumbstick {
			get {
				if (_LeftThumbstick is null)
					_LeftThumbstick = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftThumbstick")!;
				return _LeftThumbstick;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftThumbstickButton;
		/// <summary>Represents the value associated with the constant 'GCInputLeftThumbstickButton'.</summary>
		[Field ("GCInputLeftThumbstickButton",  "GameController")]
		public static NSString LeftThumbstickButton {
			get {
				if (_LeftThumbstickButton is null)
					_LeftThumbstickButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftThumbstickButton")!;
				return _LeftThumbstickButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftTrigger;
		/// <summary>Represents the value associated with the constant 'GCInputLeftTrigger'.</summary>
		[Field ("GCInputLeftTrigger",  "GameController")]
		public static NSString LeftTrigger {
			get {
				if (_LeftTrigger is null)
					_LeftTrigger = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputLeftTrigger")!;
				return _LeftTrigger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightBumper;
		/// <summary>Represents the value associated with the constant 'GCInputRightBumper'.</summary>
		[Field ("GCInputRightBumper",  "GameController")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString RightBumper {
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			get {
				if (_RightBumper is null)
					_RightBumper = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightBumper")!;
				return _RightBumper;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightShoulder;
		/// <summary>Represents the value associated with the constant 'GCInputRightShoulder'.</summary>
		[Field ("GCInputRightShoulder",  "GameController")]
		public static NSString RightShoulder {
			get {
				if (_RightShoulder is null)
					_RightShoulder = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightShoulder")!;
				return _RightShoulder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightSideButton;
		/// <summary>Represents the value associated with the constant 'GCInputRightSideButton'.</summary>
		[Field ("GCInputRightSideButton",  "GameController")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public static NSString RightSideButton {
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("macos26.4")]
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			get {
				if (_RightSideButton is null)
					_RightSideButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightSideButton")!;
				return _RightSideButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightThumbstick;
		/// <summary>Represents the value associated with the constant 'GCInputRightThumbstick'.</summary>
		[Field ("GCInputRightThumbstick",  "GameController")]
		public static NSString RightThumbstick {
			get {
				if (_RightThumbstick is null)
					_RightThumbstick = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightThumbstick")!;
				return _RightThumbstick;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightThumbstickButton;
		/// <summary>Represents the value associated with the constant 'GCInputRightThumbstickButton'.</summary>
		[Field ("GCInputRightThumbstickButton",  "GameController")]
		public static NSString RightThumbstickButton {
			get {
				if (_RightThumbstickButton is null)
					_RightThumbstickButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightThumbstickButton")!;
				return _RightThumbstickButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightTrigger;
		/// <summary>Represents the value associated with the constant 'GCInputRightTrigger'.</summary>
		[Field ("GCInputRightTrigger",  "GameController")]
		public static NSString RightTrigger {
			get {
				if (_RightTrigger is null)
					_RightTrigger = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputRightTrigger")!;
				return _RightTrigger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Thumbstick;
		/// <summary>Represents the value associated with the constant 'GCInputThumbstick'.</summary>
		[Field ("GCInputThumbstick",  "GameController")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString Thumbstick {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_Thumbstick is null)
					_Thumbstick = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputThumbstick")!;
				return _Thumbstick;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbstickButton;
		/// <summary>Represents the value associated with the constant 'GCInputThumbstickButton'.</summary>
		[Field ("GCInputThumbstickButton",  "GameController")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString ThumbstickButton {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_ThumbstickButton is null)
					_ThumbstickButton = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputThumbstickButton")!;
				return _ThumbstickButton;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Trigger;
		/// <summary>Represents the value associated with the constant 'GCInputTrigger'.</summary>
		[Field ("GCInputTrigger",  "GameController")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString Trigger {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_Trigger is null)
					_Trigger = Dlfcn.GetStringConstant (Libraries.GameController.Handle, "GCInputTrigger")!;
				return _Trigger;
			}
		}
	} /* class GCInput */
}
