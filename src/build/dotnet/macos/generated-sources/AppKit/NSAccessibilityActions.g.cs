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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSAccessibilityActions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CancelAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCancelAction",  "AppKit")]
		public static NSString CancelAction {
			get {
				if (_CancelAction is null)
					_CancelAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCancelAction")!;
				return _CancelAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConfirmAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityConfirmAction",  "AppKit")]
		public static NSString ConfirmAction {
			get {
				if (_ConfirmAction is null)
					_ConfirmAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityConfirmAction")!;
				return _ConfirmAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DecrementAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDecrementAction",  "AppKit")]
		public static NSString DecrementAction {
			get {
				if (_DecrementAction is null)
					_DecrementAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDecrementAction")!;
				return _DecrementAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeleteAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDeleteAction",  "AppKit")]
		public static NSString DeleteAction {
			get {
				if (_DeleteAction is null)
					_DeleteAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDeleteAction")!;
				return _DeleteAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IncrementAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityIncrementAction",  "AppKit")]
		public static NSString IncrementAction {
			get {
				if (_IncrementAction is null)
					_IncrementAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIncrementAction")!;
				return _IncrementAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PickAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPickAction",  "AppKit")]
		public static NSString PickAction {
			get {
				if (_PickAction is null)
					_PickAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPickAction")!;
				return _PickAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PressAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPressAction",  "AppKit")]
		public static NSString PressAction {
			get {
				if (_PressAction is null)
					_PressAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPressAction")!;
				return _PressAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RaiseAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRaiseAction",  "AppKit")]
		public static NSString RaiseAction {
			get {
				if (_RaiseAction is null)
					_RaiseAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRaiseAction")!;
				return _RaiseAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScrollToVisibleAction;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityScrollToVisibleAction'.</summary>
		[Field ("NSAccessibilityScrollToVisibleAction",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString ScrollToVisibleAction {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_ScrollToVisibleAction is null)
					_ScrollToVisibleAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityScrollToVisibleAction")!;
				return _ScrollToVisibleAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowAlternateUIAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityShowAlternateUIAction",  "AppKit")]
		public static NSString ShowAlternateUIAction {
			get {
				if (_ShowAlternateUIAction is null)
					_ShowAlternateUIAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityShowAlternateUIAction")!;
				return _ShowAlternateUIAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowDefaultUIAction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityShowDefaultUIAction",  "AppKit")]
		public static NSString ShowDefaultUIAction {
			get {
				if (_ShowDefaultUIAction is null)
					_ShowDefaultUIAction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityShowDefaultUIAction")!;
				return _ShowDefaultUIAction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowMenu;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityShowMenuAction",  "AppKit")]
		public static NSString ShowMenu {
			get {
				if (_ShowMenu is null)
					_ShowMenu = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityShowMenuAction")!;
				return _ShowMenu;
			}
		}
	} /* class NSAccessibilityActions */
}
