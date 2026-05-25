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
	public unsafe static partial class NSAccessibilityRoles  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityApplicationRole",  "AppKit")]
		public static NSString ApplicationRole {
			get {
				if (_ApplicationRole is null)
					_ApplicationRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityApplicationRole")!;
				return _ApplicationRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrowserRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityBrowserRole",  "AppKit")]
		public static NSString BrowserRole {
			get {
				if (_BrowserRole is null)
					_BrowserRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBrowserRole")!;
				return _BrowserRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BusyIndicatorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityBusyIndicatorRole",  "AppKit")]
		public static NSString BusyIndicatorRole {
			get {
				if (_BusyIndicatorRole is null)
					_BusyIndicatorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBusyIndicatorRole")!;
				return _BusyIndicatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityButtonRole",  "AppKit")]
		public static NSString ButtonRole {
			get {
				if (_ButtonRole is null)
					_ButtonRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityButtonRole")!;
				return _ButtonRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCellRole",  "AppKit")]
		public static NSString CellRole {
			get {
				if (_CellRole is null)
					_CellRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCellRole")!;
				return _CellRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CheckBoxRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCheckBoxRole",  "AppKit")]
		public static NSString CheckBoxRole {
			get {
				if (_CheckBoxRole is null)
					_CheckBoxRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCheckBoxRole")!;
				return _CheckBoxRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorWellRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColorWellRole",  "AppKit")]
		public static NSString ColorWellRole {
			get {
				if (_ColorWellRole is null)
					_ColorWellRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColorWellRole")!;
				return _ColorWellRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnRole",  "AppKit")]
		public static NSString ColumnRole {
			get {
				if (_ColumnRole is null)
					_ColumnRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnRole")!;
				return _ColumnRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComboBoxRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityComboBoxRole",  "AppKit")]
		public static NSString ComboBoxRole {
			get {
				if (_ComboBoxRole is null)
					_ComboBoxRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityComboBoxRole")!;
				return _ComboBoxRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateTimeAreaRole;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityDateTimeAreaRole'.</summary>
		[Field ("NSAccessibilityDateTimeAreaRole",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString DateTimeAreaRole {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_DateTimeAreaRole is null)
					_DateTimeAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDateTimeAreaRole")!;
				return _DateTimeAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisclosureTriangleRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDisclosureTriangleRole",  "AppKit")]
		public static NSString DisclosureTriangleRole {
			get {
				if (_DisclosureTriangleRole is null)
					_DisclosureTriangleRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDisclosureTriangleRole")!;
				return _DisclosureTriangleRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DrawerRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDrawerRole",  "AppKit")]
		public static NSString DrawerRole {
			get {
				if (_DrawerRole is null)
					_DrawerRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDrawerRole")!;
				return _DrawerRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GridRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityGridRole",  "AppKit")]
		public static NSString GridRole {
			get {
				if (_GridRole is null)
					_GridRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityGridRole")!;
				return _GridRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityGroupRole",  "AppKit")]
		public static NSString GroupRole {
			get {
				if (_GroupRole is null)
					_GroupRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityGroupRole")!;
				return _GroupRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrowAreaRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityGrowAreaRole",  "AppKit")]
		public static NSString GrowAreaRole {
			get {
				if (_GrowAreaRole is null)
					_GrowAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityGrowAreaRole")!;
				return _GrowAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HandleRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHandleRole",  "AppKit")]
		public static NSString HandleRole {
			get {
				if (_HandleRole is null)
					_HandleRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHandleRole")!;
				return _HandleRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingRole;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingRole'.</summary>
		[Field ("NSAccessibilityHeadingRole",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString HeadingRole {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_HeadingRole is null)
					_HeadingRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingRole")!;
				return _HeadingRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HelpTagRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHelpTagRole",  "AppKit")]
		public static NSString HelpTagRole {
			get {
				if (_HelpTagRole is null)
					_HelpTagRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHelpTagRole")!;
				return _HelpTagRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityImageRole",  "AppKit")]
		public static NSString ImageRole {
			get {
				if (_ImageRole is null)
					_ImageRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityImageRole")!;
				return _ImageRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IncrementorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityIncrementorRole",  "AppKit")]
		public static NSString IncrementorRole {
			get {
				if (_IncrementorRole is null)
					_IncrementorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIncrementorRole")!;
				return _IncrementorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayoutAreaRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLayoutAreaRole",  "AppKit")]
		public static NSString LayoutAreaRole {
			get {
				if (_LayoutAreaRole is null)
					_LayoutAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLayoutAreaRole")!;
				return _LayoutAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayoutItemRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLayoutItemRole",  "AppKit")]
		public static NSString LayoutItemRole {
			get {
				if (_LayoutItemRole is null)
					_LayoutItemRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLayoutItemRole")!;
				return _LayoutItemRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LevelIndicatorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLevelIndicatorRole",  "AppKit")]
		public static NSString LevelIndicatorRole {
			get {
				if (_LevelIndicatorRole is null)
					_LevelIndicatorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLevelIndicatorRole")!;
				return _LevelIndicatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLinkRole",  "AppKit")]
		public static NSString LinkRole {
			get {
				if (_LinkRole is null)
					_LinkRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLinkRole")!;
				return _LinkRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListMarkerRole;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityListMarkerRole'.</summary>
		[Field ("NSAccessibilityListMarkerRole",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString ListMarkerRole {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_ListMarkerRole is null)
					_ListMarkerRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListMarkerRole")!;
				return _ListMarkerRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityListRole",  "AppKit")]
		public static NSString ListRole {
			get {
				if (_ListRole is null)
					_ListRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListRole")!;
				return _ListRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatteRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMatteRole",  "AppKit")]
		public static NSString MatteRole {
			get {
				if (_MatteRole is null)
					_MatteRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMatteRole")!;
				return _MatteRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenuBarItemRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMenuBarItemRole",  "AppKit")]
		public static NSString MenuBarItemRole {
			get {
				if (_MenuBarItemRole is null)
					_MenuBarItemRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMenuBarItemRole")!;
				return _MenuBarItemRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenuButtonRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMenuButtonRole",  "AppKit")]
		public static NSString MenuButtonRole {
			get {
				if (_MenuButtonRole is null)
					_MenuButtonRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMenuButtonRole")!;
				return _MenuButtonRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenuItemRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMenuItemRole",  "AppKit")]
		public static NSString MenuItemRole {
			get {
				if (_MenuItemRole is null)
					_MenuItemRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMenuItemRole")!;
				return _MenuItemRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenuRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMenuBarRole",  "AppKit")]
		public static NSString MenuRole {
			get {
				if (_MenuRole is null)
					_MenuRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMenuBarRole")!;
				return _MenuRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutlineRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityOutlineRole",  "AppKit")]
		public static NSString OutlineRole {
			get {
				if (_OutlineRole is null)
					_OutlineRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityOutlineRole")!;
				return _OutlineRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPageRole",  "AppKit")]
		public static NSString PageRole {
			get {
				if (_PageRole is null)
					_PageRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPageRole")!;
				return _PageRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PopUpButtonRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPopUpButtonRole",  "AppKit")]
		public static NSString PopUpButtonRole {
			get {
				if (_PopUpButtonRole is null)
					_PopUpButtonRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPopUpButtonRole")!;
				return _PopUpButtonRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PopoverRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPopoverRole",  "AppKit")]
		public static NSString PopoverRole {
			get {
				if (_PopoverRole is null)
					_PopoverRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPopoverRole")!;
				return _PopoverRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProgressIndicatorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityProgressIndicatorRole",  "AppKit")]
		public static NSString ProgressIndicatorRole {
			get {
				if (_ProgressIndicatorRole is null)
					_ProgressIndicatorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityProgressIndicatorRole")!;
				return _ProgressIndicatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RadioButtonRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRadioButtonRole",  "AppKit")]
		public static NSString RadioButtonRole {
			get {
				if (_RadioButtonRole is null)
					_RadioButtonRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRadioButtonRole")!;
				return _RadioButtonRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RadioGroupRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRadioGroupRole",  "AppKit")]
		public static NSString RadioGroupRole {
			get {
				if (_RadioGroupRole is null)
					_RadioGroupRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRadioGroupRole")!;
				return _RadioGroupRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RelevanceIndicatorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRelevanceIndicatorRole",  "AppKit")]
		public static NSString RelevanceIndicatorRole {
			get {
				if (_RelevanceIndicatorRole is null)
					_RelevanceIndicatorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRelevanceIndicatorRole")!;
				return _RelevanceIndicatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRowRole",  "AppKit")]
		public static NSString RowRole {
			get {
				if (_RowRole is null)
					_RowRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowRole")!;
				return _RowRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RulerMarkerRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRulerMarkerRole",  "AppKit")]
		public static NSString RulerMarkerRole {
			get {
				if (_RulerMarkerRole is null)
					_RulerMarkerRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRulerMarkerRole")!;
				return _RulerMarkerRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RulerRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRulerRole",  "AppKit")]
		public static NSString RulerRole {
			get {
				if (_RulerRole is null)
					_RulerRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRulerRole")!;
				return _RulerRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScrollAreaRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityScrollAreaRole",  "AppKit")]
		public static NSString ScrollAreaRole {
			get {
				if (_ScrollAreaRole is null)
					_ScrollAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityScrollAreaRole")!;
				return _ScrollAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScrollBarRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityScrollBarRole",  "AppKit")]
		public static NSString ScrollBarRole {
			get {
				if (_ScrollBarRole is null)
					_ScrollBarRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityScrollBarRole")!;
				return _ScrollBarRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SheetRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySheetRole",  "AppKit")]
		public static NSString SheetRole {
			get {
				if (_SheetRole is null)
					_SheetRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySheetRole")!;
				return _SheetRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SliderRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySliderRole",  "AppKit")]
		public static NSString SliderRole {
			get {
				if (_SliderRole is null)
					_SliderRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySliderRole")!;
				return _SliderRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SplitGroupRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySplitGroupRole",  "AppKit")]
		public static NSString SplitGroupRole {
			get {
				if (_SplitGroupRole is null)
					_SplitGroupRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySplitGroupRole")!;
				return _SplitGroupRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SplitterRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySplitterRole",  "AppKit")]
		public static NSString SplitterRole {
			get {
				if (_SplitterRole is null)
					_SplitterRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySplitterRole")!;
				return _SplitterRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StaticTextRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityStaticTextRole",  "AppKit")]
		public static NSString StaticTextRole {
			get {
				if (_StaticTextRole is null)
					_StaticTextRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStaticTextRole")!;
				return _StaticTextRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemWideRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySystemWideRole",  "AppKit")]
		public static NSString SystemWideRole {
			get {
				if (_SystemWideRole is null)
					_SystemWideRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySystemWideRole")!;
				return _SystemWideRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TabGroupRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTabGroupRole",  "AppKit")]
		public static NSString TabGroupRole {
			get {
				if (_TabGroupRole is null)
					_TabGroupRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTabGroupRole")!;
				return _TabGroupRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TableRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTableRole",  "AppKit")]
		public static NSString TableRole {
			get {
				if (_TableRole is null)
					_TableRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTableRole")!;
				return _TableRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAreaRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTextAreaRole",  "AppKit")]
		public static NSString TextAreaRole {
			get {
				if (_TextAreaRole is null)
					_TextAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextAreaRole")!;
				return _TextAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextFieldRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTextFieldRole",  "AppKit")]
		public static NSString TextFieldRole {
			get {
				if (_TextFieldRole is null)
					_TextFieldRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextFieldRole")!;
				return _TextFieldRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToolbarRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityToolbarRole",  "AppKit")]
		public static NSString ToolbarRole {
			get {
				if (_ToolbarRole is null)
					_ToolbarRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityToolbarRole")!;
				return _ToolbarRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnknownRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUnknownRole",  "AppKit")]
		public static NSString UnknownRole {
			get {
				if (_UnknownRole is null)
					_UnknownRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnknownRole")!;
				return _UnknownRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueIndicatorRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityValueIndicatorRole",  "AppKit")]
		public static NSString ValueIndicatorRole {
			get {
				if (_ValueIndicatorRole is null)
					_ValueIndicatorRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityValueIndicatorRole")!;
				return _ValueIndicatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebAreaRole;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityWebAreaRole'.</summary>
		[Field ("NSAccessibilityWebAreaRole",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString WebAreaRole {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_WebAreaRole is null)
					_WebAreaRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWebAreaRole")!;
				return _WebAreaRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowRole;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityWindowRole",  "AppKit")]
		public static NSString WindowRole {
			get {
				if (_WindowRole is null)
					_WindowRole = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowRole")!;
				return _WindowRole;
			}
		}
	} /* class NSAccessibilityRoles */
}
