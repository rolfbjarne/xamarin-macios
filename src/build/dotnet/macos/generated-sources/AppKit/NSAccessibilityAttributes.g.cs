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
	public unsafe static partial class NSAccessibilityAttributes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActivationPointAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityActivationPointAttribute",  "AppKit")]
		public static NSString ActivationPointAttribute {
			get {
				if (_ActivationPointAttribute is null)
					_ActivationPointAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityActivationPointAttribute")!;
				return _ActivationPointAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowedValuesAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAllowedValuesAttribute",  "AppKit")]
		public static NSString AllowedValuesAttribute {
			get {
				if (_AllowedValuesAttribute is null)
					_AllowedValuesAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAllowedValuesAttribute")!;
				return _AllowedValuesAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlternateUIVisibleAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAlternateUIVisibleAttribute",  "AppKit")]
		public static NSString AlternateUIVisibleAttribute {
			get {
				if (_AlternateUIVisibleAttribute is null)
					_AlternateUIVisibleAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAlternateUIVisibleAttribute")!;
				return _AlternateUIVisibleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAnnotationTextAttribute",  "AppKit")]
		public static NSString AnnotationTextAttribute {
			get {
				if (_AnnotationTextAttribute is null)
					_AnnotationTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnotationTextAttribute")!;
				return _AnnotationTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttachmentTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAttachmentTextAttribute",  "AppKit")]
		public static NSString AttachmentTextAttribute {
			get {
				if (_AttachmentTextAttribute is null)
					_AttachmentTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAttachmentTextAttribute")!;
				return _AttachmentTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributedStringForRangeParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAttributedStringForRangeParameterizedAttribute",  "AppKit")]
		public static NSString AttributedStringForRangeParameterizedAttribute {
			get {
				if (_AttributedStringForRangeParameterizedAttribute is null)
					_AttributedStringForRangeParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAttributedStringForRangeParameterizedAttribute")!;
				return _AttributedStringForRangeParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoInteractableAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityAutoInteractableAttribute'.</summary>
		[Field ("NSAccessibilityAutoInteractableAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString AutoInteractableAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_AutoInteractableAttribute is null)
					_AutoInteractableAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAutoInteractableAttribute")!;
				return _AutoInteractableAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutocorrectedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityAutocorrectedTextAttribute",  "AppKit")]
		public static NSString AutocorrectedAttribute {
			get {
				if (_AutocorrectedAttribute is null)
					_AutocorrectedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAutocorrectedTextAttribute")!;
				return _AutocorrectedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColorTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityBackgroundColorTextAttribute",  "AppKit")]
		public static NSString BackgroundColorTextAttribute {
			get {
				if (_BackgroundColorTextAttribute is null)
					_BackgroundColorTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBackgroundColorTextAttribute")!;
				return _BackgroundColorTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockQuoteLevelAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityBlockQuoteLevelAttribute'.</summary>
		[Field ("NSAccessibilityBlockQuoteLevelAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString BlockQuoteLevelAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_BlockQuoteLevelAttribute is null)
					_BlockQuoteLevelAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBlockQuoteLevelAttribute")!;
				return _BlockQuoteLevelAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoundsForRangeParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityBoundsForRangeParameterizedAttribute",  "AppKit")]
		public static NSString BoundsForRangeParameterizedAttribute {
			get {
				if (_BoundsForRangeParameterizedAttribute is null)
					_BoundsForRangeParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBoundsForRangeParameterizedAttribute")!;
				return _BoundsForRangeParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CancelButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCancelButtonAttribute",  "AppKit")]
		public static NSString CancelButtonAttribute {
			get {
				if (_CancelButtonAttribute is null)
					_CancelButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCancelButtonAttribute")!;
				return _CancelButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellForColumnAndRowParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCellForColumnAndRowParameterizedAttribute",  "AppKit")]
		public static NSString CellForColumnAndRowParameterizedAttribute {
			get {
				if (_CellForColumnAndRowParameterizedAttribute is null)
					_CellForColumnAndRowParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCellForColumnAndRowParameterizedAttribute")!;
				return _CellForColumnAndRowParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChildrenAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityChildrenAttribute",  "AppKit")]
		public static NSString ChildrenAttribute {
			get {
				if (_ChildrenAttribute is null)
					_ChildrenAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityChildrenAttribute")!;
				return _ChildrenAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChildrenInNavigationOrderAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityChildrenInNavigationOrderAttribute'.</summary>
		[Field ("NSAccessibilityChildrenInNavigationOrderAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString ChildrenInNavigationOrderAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_ChildrenInNavigationOrderAttribute is null)
					_ChildrenInNavigationOrderAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityChildrenInNavigationOrderAttribute")!;
				return _ChildrenInNavigationOrderAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClearButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityClearButtonAttribute",  "AppKit")]
		public static NSString ClearButtonAttribute {
			get {
				if (_ClearButtonAttribute is null)
					_ClearButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityClearButtonAttribute")!;
				return _ClearButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CloseButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCloseButtonAttribute",  "AppKit")]
		public static NSString CloseButtonAttribute {
			get {
				if (_CloseButtonAttribute is null)
					_CloseButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCloseButtonAttribute")!;
				return _CloseButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnCountAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnCountAttribute",  "AppKit")]
		public static NSString ColumnCountAttribute {
			get {
				if (_ColumnCountAttribute is null)
					_ColumnCountAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnCountAttribute")!;
				return _ColumnCountAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnHeaderUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnHeaderUIElementsAttribute",  "AppKit")]
		public static NSString ColumnHeaderUIElementsAttribute {
			get {
				if (_ColumnHeaderUIElementsAttribute is null)
					_ColumnHeaderUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnHeaderUIElementsAttribute")!;
				return _ColumnHeaderUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnIndexRangeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnIndexRangeAttribute",  "AppKit")]
		public static NSString ColumnIndexRangeAttribute {
			get {
				if (_ColumnIndexRangeAttribute is null)
					_ColumnIndexRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnIndexRangeAttribute")!;
				return _ColumnIndexRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnTitlesAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnTitlesAttribute",  "AppKit")]
		public static NSString ColumnTitlesAttribute {
			get {
				if (_ColumnTitlesAttribute is null)
					_ColumnTitlesAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnTitlesAttribute")!;
				return _ColumnTitlesAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityColumnsAttribute",  "AppKit")]
		public static NSString ColumnsAttribute {
			get {
				if (_ColumnsAttribute is null)
					_ColumnsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityColumnsAttribute")!;
				return _ColumnsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsProtectedContentAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityContainsProtectedContentAttribute",  "AppKit")]
		public static NSString ContainsProtectedContentAttribute {
			get {
				if (_ContainsProtectedContentAttribute is null)
					_ContainsProtectedContentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityContainsProtectedContentAttribute")!;
				return _ContainsProtectedContentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityContentsAttribute",  "AppKit")]
		public static NSString ContentsAttribute {
			get {
				if (_ContentsAttribute is null)
					_ContentsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityContentsAttribute")!;
				return _ContentsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CriticalValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCriticalValueAttribute",  "AppKit")]
		public static NSString CriticalValueAttribute {
			get {
				if (_CriticalValueAttribute is null)
					_CriticalValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCriticalValueAttribute")!;
				return _CriticalValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CustomTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityCustomTextAttribute",  "AppKit")]
		public static NSString CustomTextAttribute {
			get {
				if (_CustomTextAttribute is null)
					_CustomTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCustomTextAttribute")!;
				return _CustomTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateTimeComponentsAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityDateTimeComponentsAttribute'.</summary>
		[Field ("NSAccessibilityDateTimeComponentsAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString DateTimeComponentsAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_DateTimeComponentsAttribute is null)
					_DateTimeComponentsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDateTimeComponentsAttribute")!;
				return _DateTimeComponentsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DecrementButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDecrementButtonAttribute",  "AppKit")]
		public static NSString DecrementButtonAttribute {
			get {
				if (_DecrementButtonAttribute is null)
					_DecrementButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDecrementButtonAttribute")!;
				return _DecrementButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDefaultButtonAttribute",  "AppKit")]
		public static NSString DefaultButtonAttribute {
			get {
				if (_DefaultButtonAttribute is null)
					_DefaultButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDefaultButtonAttribute")!;
				return _DefaultButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDescriptionAttribute",  "AppKit")]
		public static NSString DescriptionAttribute {
			get {
				if (_DescriptionAttribute is null)
					_DescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDescriptionAttribute")!;
				return _DescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisclosedByRowAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDisclosedByRowAttribute",  "AppKit")]
		public static NSString DisclosedByRowAttribute {
			get {
				if (_DisclosedByRowAttribute is null)
					_DisclosedByRowAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDisclosedByRowAttribute")!;
				return _DisclosedByRowAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisclosedRowsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDisclosedRowsAttribute",  "AppKit")]
		public static NSString DisclosedRowsAttribute {
			get {
				if (_DisclosedRowsAttribute is null)
					_DisclosedRowsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDisclosedRowsAttribute")!;
				return _DisclosedRowsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisclosingAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDisclosingAttribute",  "AppKit")]
		public static NSString DisclosingAttribute {
			get {
				if (_DisclosingAttribute is null)
					_DisclosingAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDisclosingAttribute")!;
				return _DisclosingAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisclosureLevelAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDisclosureLevelAttribute",  "AppKit")]
		public static NSString DisclosureLevelAttribute {
			get {
				if (_DisclosureLevelAttribute is null)
					_DisclosureLevelAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDisclosureLevelAttribute")!;
				return _DisclosureLevelAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityDocumentAttribute",  "AppKit")]
		public static NSString DocumentAttribute {
			get {
				if (_DocumentAttribute is null)
					_DocumentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDocumentAttribute")!;
				return _DocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EditedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityEditedAttribute",  "AppKit")]
		public static NSString EditedAttribute {
			get {
				if (_EditedAttribute is null)
					_EditedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityEditedAttribute")!;
				return _EditedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmbeddedImageDescriptionAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityEmbeddedImageDescriptionAttribute'.</summary>
		[Field ("NSAccessibilityEmbeddedImageDescriptionAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString EmbeddedImageDescriptionAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_EmbeddedImageDescriptionAttribute is null)
					_EmbeddedImageDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityEmbeddedImageDescriptionAttribute")!;
				return _EmbeddedImageDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnabledAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityEnabledAttribute",  "AppKit")]
		public static NSString EnabledAttribute {
			get {
				if (_EnabledAttribute is null)
					_EnabledAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityEnabledAttribute")!;
				return _EnabledAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpandedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityExpandedAttribute",  "AppKit")]
		public static NSString ExpandedAttribute {
			get {
				if (_ExpandedAttribute is null)
					_ExpandedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityExpandedAttribute")!;
				return _ExpandedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtrasMenuBarAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityExtrasMenuBarAttribute",  "AppKit")]
		public static NSString ExtrasMenuBarAttribute {
			get {
				if (_ExtrasMenuBarAttribute is null)
					_ExtrasMenuBarAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityExtrasMenuBarAttribute")!;
				return _ExtrasMenuBarAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilenameAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFilenameAttribute",  "AppKit")]
		public static NSString FilenameAttribute {
			get {
				if (_FilenameAttribute is null)
					_FilenameAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFilenameAttribute")!;
				return _FilenameAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocusedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFocusedAttribute",  "AppKit")]
		public static NSString FocusedAttribute {
			get {
				if (_FocusedAttribute is null)
					_FocusedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFocusedAttribute")!;
				return _FocusedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocusedUIElementAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFocusedUIElementAttribute",  "AppKit")]
		public static NSString FocusedUIElementAttribute {
			get {
				if (_FocusedUIElementAttribute is null)
					_FocusedUIElementAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementAttribute")!;
				return _FocusedUIElementAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocusedWindowAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFocusedWindowAttribute",  "AppKit")]
		public static NSString FocusedWindowAttribute {
			get {
				if (_FocusedWindowAttribute is null)
					_FocusedWindowAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowAttribute")!;
				return _FocusedWindowAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontBoldAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityFontBoldAttribute'.</summary>
		[Field ("NSAccessibilityFontBoldAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString FontBoldAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_FontBoldAttribute is null)
					_FontBoldAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontBoldAttribute")!;
				return _FontBoldAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontItalicAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityFontItalicAttribute'.</summary>
		[Field ("NSAccessibilityFontItalicAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString FontItalicAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_FontItalicAttribute is null)
					_FontItalicAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontItalicAttribute")!;
				return _FontItalicAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFontTextAttribute",  "AppKit")]
		public static NSString FontTextAttribute {
			get {
				if (_FontTextAttribute is null)
					_FontTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontTextAttribute")!;
				return _FontTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColorTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityForegroundColorTextAttribute",  "AppKit")]
		public static NSString ForegroundColorTextAttribute {
			get {
				if (_ForegroundColorTextAttribute is null)
					_ForegroundColorTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityForegroundColorTextAttribute")!;
				return _ForegroundColorTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FrontmostAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFrontmostAttribute",  "AppKit")]
		public static NSString FrontmostAttribute {
			get {
				if (_FrontmostAttribute is null)
					_FrontmostAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFrontmostAttribute")!;
				return _FrontmostAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FullScreenButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFullScreenButtonAttribute",  "AppKit")]
		public static NSString FullScreenButtonAttribute {
			get {
				if (_FullScreenButtonAttribute is null)
					_FullScreenButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFullScreenButtonAttribute")!;
				return _FullScreenButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrowAreaAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityGrowAreaAttribute",  "AppKit")]
		public static NSString GrowAreaAttribute {
			get {
				if (_GrowAreaAttribute is null)
					_GrowAreaAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityGrowAreaAttribute")!;
				return _GrowAreaAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HandlesAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHandlesAttribute",  "AppKit")]
		public static NSString HandlesAttribute {
			get {
				if (_HandlesAttribute is null)
					_HandlesAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHandlesAttribute")!;
				return _HandlesAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeaderAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHeaderAttribute",  "AppKit")]
		public static NSString HeaderAttribute {
			get {
				if (_HeaderAttribute is null)
					_HeaderAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeaderAttribute")!;
				return _HeaderAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevelAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevelAttribute'.</summary>
		[Field ("NSAccessibilityHeadingLevelAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString HeadingLevelAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_HeadingLevelAttribute is null)
					_HeadingLevelAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevelAttribute")!;
				return _HeadingLevelAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HelpAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHelpAttribute",  "AppKit")]
		public static NSString HelpAttribute {
			get {
				if (_HelpAttribute is null)
					_HelpAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHelpAttribute")!;
				return _HelpAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HiddenAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHiddenAttribute",  "AppKit")]
		public static NSString HiddenAttribute {
			get {
				if (_HiddenAttribute is null)
					_HiddenAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHiddenAttribute")!;
				return _HiddenAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalScrollBarAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHorizontalScrollBarAttribute",  "AppKit")]
		public static NSString HorizontalScrollBarAttribute {
			get {
				if (_HorizontalScrollBarAttribute is null)
					_HorizontalScrollBarAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHorizontalScrollBarAttribute")!;
				return _HorizontalScrollBarAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalUnitDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHorizontalUnitDescriptionAttribute",  "AppKit")]
		public static NSString HorizontalUnitDescriptionAttribute {
			get {
				if (_HorizontalUnitDescriptionAttribute is null)
					_HorizontalUnitDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHorizontalUnitDescriptionAttribute")!;
				return _HorizontalUnitDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalUnitsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityHorizontalUnitsAttribute",  "AppKit")]
		public static NSString HorizontalUnitsAttribute {
			get {
				if (_HorizontalUnitsAttribute is null)
					_HorizontalUnitsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHorizontalUnitsAttribute")!;
				return _HorizontalUnitsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdentifierAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityIdentifierAttribute",  "AppKit")]
		public static NSString IdentifierAttribute {
			get {
				if (_IdentifierAttribute is null)
					_IdentifierAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIdentifierAttribute")!;
				return _IdentifierAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IncrementButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityIncrementButtonAttribute",  "AppKit")]
		public static NSString IncrementButtonAttribute {
			get {
				if (_IncrementButtonAttribute is null)
					_IncrementButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIncrementButtonAttribute")!;
				return _IncrementButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndexAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityIndexAttribute",  "AppKit")]
		public static NSString IndexAttribute {
			get {
				if (_IndexAttribute is null)
					_IndexAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIndexAttribute")!;
				return _IndexAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndexForChildUIElementAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityIndexForChildUIElementAttribute'.</summary>
		[Field ("NSAccessibilityIndexForChildUIElementAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString IndexForChildUIElementAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_IndexForChildUIElementAttribute is null)
					_IndexForChildUIElementAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIndexForChildUIElementAttribute")!;
				return _IndexForChildUIElementAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndexForChildUIElementInNavigationOrderAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityIndexForChildUIElementInNavigationOrderAttribute'.</summary>
		[Field ("NSAccessibilityIndexForChildUIElementInNavigationOrderAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString IndexForChildUIElementInNavigationOrderAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_IndexForChildUIElementInNavigationOrderAttribute is null)
					_IndexForChildUIElementInNavigationOrderAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityIndexForChildUIElementInNavigationOrderAttribute")!;
				return _IndexForChildUIElementInNavigationOrderAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InsertionPointLineNumberAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityInsertionPointLineNumberAttribute",  "AppKit")]
		public static NSString InsertionPointLineNumberAttribute {
			get {
				if (_InsertionPointLineNumberAttribute is null)
					_InsertionPointLineNumberAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityInsertionPointLineNumberAttribute")!;
				return _InsertionPointLineNumberAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LabelUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLabelUIElementsAttribute",  "AppKit")]
		public static NSString LabelUIElementsAttribute {
			get {
				if (_LabelUIElementsAttribute is null)
					_LabelUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLabelUIElementsAttribute")!;
				return _LabelUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LabelValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLabelValueAttribute",  "AppKit")]
		public static NSString LabelValueAttribute {
			get {
				if (_LabelValueAttribute is null)
					_LabelValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLabelValueAttribute")!;
				return _LabelValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LanguageAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityLanguageAttribute'.</summary>
		[Field ("NSAccessibilityLanguageAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString LanguageAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_LanguageAttribute is null)
					_LanguageAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLanguageAttribute")!;
				return _LanguageAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LanguageTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLanguageTextAttribute",  "AppKit")]
		public static NSString LanguageTextAttribute {
			get {
				if (_LanguageTextAttribute is null)
					_LanguageTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLanguageTextAttribute")!;
				return _LanguageTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayoutPointForScreenPointParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLayoutPointForScreenPointParameterizedAttribute",  "AppKit")]
		public static NSString LayoutPointForScreenPointParameterizedAttribute {
			get {
				if (_LayoutPointForScreenPointParameterizedAttribute is null)
					_LayoutPointForScreenPointParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLayoutPointForScreenPointParameterizedAttribute")!;
				return _LayoutPointForScreenPointParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayoutSizeForScreenSizeParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLayoutSizeForScreenSizeParameterizedAttribute",  "AppKit")]
		public static NSString LayoutSizeForScreenSizeParameterizedAttribute {
			get {
				if (_LayoutSizeForScreenSizeParameterizedAttribute is null)
					_LayoutSizeForScreenSizeParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLayoutSizeForScreenSizeParameterizedAttribute")!;
				return _LayoutSizeForScreenSizeParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LineForIndexParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLineForIndexParameterizedAttribute",  "AppKit")]
		public static NSString LineForIndexParameterizedAttribute {
			get {
				if (_LineForIndexParameterizedAttribute is null)
					_LineForIndexParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLineForIndexParameterizedAttribute")!;
				return _LineForIndexParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLinkTextAttribute",  "AppKit")]
		public static NSString LinkTextAttribute {
			get {
				if (_LinkTextAttribute is null)
					_LinkTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLinkTextAttribute")!;
				return _LinkTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkedUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityLinkedUIElementsAttribute",  "AppKit")]
		public static NSString LinkedUIElementsAttribute {
			get {
				if (_LinkedUIElementsAttribute is null)
					_LinkedUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLinkedUIElementsAttribute")!;
				return _LinkedUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListItemIndexTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityListItemIndexTextAttribute",  "AppKit")]
		public static NSString ListItemIndexTextAttribute {
			get {
				if (_ListItemIndexTextAttribute is null)
					_ListItemIndexTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListItemIndexTextAttribute")!;
				return _ListItemIndexTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListItemLevelTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityListItemLevelTextAttribute",  "AppKit")]
		public static NSString ListItemLevelTextAttribute {
			get {
				if (_ListItemLevelTextAttribute is null)
					_ListItemLevelTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListItemLevelTextAttribute")!;
				return _ListItemLevelTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ListItemPrefixTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityListItemPrefixTextAttribute",  "AppKit")]
		public static NSString ListItemPrefixTextAttribute {
			get {
				if (_ListItemPrefixTextAttribute is null)
					_ListItemPrefixTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListItemPrefixTextAttribute")!;
				return _ListItemPrefixTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MainAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMainAttribute",  "AppKit")]
		public static NSString MainAttribute {
			get {
				if (_MainAttribute is null)
					_MainAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMainAttribute")!;
				return _MainAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MainWindowAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMainWindowAttribute",  "AppKit")]
		public static NSString MainWindowAttribute {
			get {
				if (_MainWindowAttribute is null)
					_MainWindowAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMainWindowAttribute")!;
				return _MainWindowAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkedMisspelledTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkedMisspelledTextAttribute",  "AppKit")]
		public static NSString MarkedMisspelledTextAttribute {
			get {
				if (_MarkedMisspelledTextAttribute is null)
					_MarkedMisspelledTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkedMisspelledTextAttribute")!;
				return _MarkedMisspelledTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkerGroupUIElementAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkerGroupUIElementAttribute",  "AppKit")]
		public static NSString MarkerGroupUIElementAttribute {
			get {
				if (_MarkerGroupUIElementAttribute is null)
					_MarkerGroupUIElementAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkerGroupUIElementAttribute")!;
				return _MarkerGroupUIElementAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkerTypeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkerTypeAttribute",  "AppKit")]
		public static NSString MarkerTypeAttribute {
			get {
				if (_MarkerTypeAttribute is null)
					_MarkerTypeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkerTypeAttribute")!;
				return _MarkerTypeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkerTypeDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkerTypeDescriptionAttribute",  "AppKit")]
		public static NSString MarkerTypeDescriptionAttribute {
			get {
				if (_MarkerTypeDescriptionAttribute is null)
					_MarkerTypeDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkerTypeDescriptionAttribute")!;
				return _MarkerTypeDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkerUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkerUIElementsAttribute",  "AppKit")]
		public static NSString MarkerUIElementsAttribute {
			get {
				if (_MarkerUIElementsAttribute is null)
					_MarkerUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkerUIElementsAttribute")!;
				return _MarkerUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkerValuesAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMarkerValuesAttribute",  "AppKit")]
		public static NSString MarkerValuesAttribute {
			get {
				if (_MarkerValuesAttribute is null)
					_MarkerValuesAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMarkerValuesAttribute")!;
				return _MarkerValuesAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatteContentUIElementAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMatteContentUIElementAttribute",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'NSAccessibility' methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MatteContentUIElementAttribute {
			[ObsoletedOSPlatform ("macos10.10", "Use 'NSAccessibility' methods instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MatteContentUIElementAttribute is null)
					_MatteContentUIElementAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMatteContentUIElementAttribute")!;
				return _MatteContentUIElementAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatteHoleAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMatteHoleAttribute",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'NSAccessibility' methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MatteHoleAttribute {
			[ObsoletedOSPlatform ("macos10.10", "Use 'NSAccessibility' methods instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MatteHoleAttribute is null)
					_MatteHoleAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMatteHoleAttribute")!;
				return _MatteHoleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMaxValueAttribute",  "AppKit")]
		public static NSString MaxValueAttribute {
			get {
				if (_MaxValueAttribute is null)
					_MaxValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMaxValueAttribute")!;
				return _MaxValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenuBarAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMenuBarAttribute",  "AppKit")]
		public static NSString MenuBarAttribute {
			get {
				if (_MenuBarAttribute is null)
					_MenuBarAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMenuBarAttribute")!;
				return _MenuBarAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMinValueAttribute",  "AppKit")]
		public static NSString MinValueAttribute {
			get {
				if (_MinValueAttribute is null)
					_MinValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMinValueAttribute")!;
				return _MinValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimizeButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMinimizeButtonAttribute",  "AppKit")]
		public static NSString MinimizeButtonAttribute {
			get {
				if (_MinimizeButtonAttribute is null)
					_MinimizeButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMinimizeButtonAttribute")!;
				return _MinimizeButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMinimizedAttribute",  "AppKit")]
		public static NSString MinimizedAttribute {
			get {
				if (_MinimizedAttribute is null)
					_MinimizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMinimizedAttribute")!;
				return _MinimizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MisspelledTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityMisspelledTextAttribute",  "AppKit")]
		public static NSString MisspelledTextAttribute {
			get {
				if (_MisspelledTextAttribute is null)
					_MisspelledTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMisspelledTextAttribute")!;
				return _MisspelledTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModalAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityModalAttribute",  "AppKit")]
		public static NSString ModalAttribute {
			get {
				if (_ModalAttribute is null)
					_ModalAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityModalAttribute")!;
				return _ModalAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NextContentsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityNextContentsAttribute",  "AppKit")]
		public static NSString NextContentsAttribute {
			get {
				if (_NextContentsAttribute is null)
					_NextContentsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityNextContentsAttribute")!;
				return _NextContentsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NumberOfCharactersAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityNumberOfCharactersAttribute",  "AppKit")]
		public static NSString NumberOfCharactersAttribute {
			get {
				if (_NumberOfCharactersAttribute is null)
					_NumberOfCharactersAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityNumberOfCharactersAttribute")!;
				return _NumberOfCharactersAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrderedByRowAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityOrderedByRowAttribute",  "AppKit")]
		public static NSString OrderedByRowAttribute {
			get {
				if (_OrderedByRowAttribute is null)
					_OrderedByRowAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityOrderedByRowAttribute")!;
				return _OrderedByRowAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OverflowButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityOverflowButtonAttribute",  "AppKit")]
		public static NSString OverflowButtonAttribute {
			get {
				if (_OverflowButtonAttribute is null)
					_OverflowButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityOverflowButtonAttribute")!;
				return _OverflowButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityParentAttribute",  "AppKit")]
		public static NSString ParentAttribute {
			get {
				if (_ParentAttribute is null)
					_ParentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityParentAttribute")!;
				return _ParentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityPathAttribute'.</summary>
		[Field ("NSAccessibilityPathAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString PathAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_PathAttribute is null)
					_PathAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPathAttribute")!;
				return _PathAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaceholderValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPlaceholderValueAttribute",  "AppKit")]
		public static NSString PlaceholderValueAttribute {
			get {
				if (_PlaceholderValueAttribute is null)
					_PlaceholderValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPlaceholderValueAttribute")!;
				return _PlaceholderValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PositionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPositionAttribute",  "AppKit")]
		public static NSString PositionAttribute {
			get {
				if (_PositionAttribute is null)
					_PositionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPositionAttribute")!;
				return _PositionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreviousContentsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityPreviousContentsAttribute",  "AppKit")]
		public static NSString PreviousContentsAttribute {
			get {
				if (_PreviousContentsAttribute is null)
					_PreviousContentsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPreviousContentsAttribute")!;
				return _PreviousContentsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProxyAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityProxyAttribute",  "AppKit")]
		public static NSString ProxyAttribute {
			get {
				if (_ProxyAttribute is null)
					_ProxyAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityProxyAttribute")!;
				return _ProxyAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RTFForRangeParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRTFForRangeParameterizedAttribute",  "AppKit")]
		public static NSString RTFForRangeParameterizedAttribute {
			get {
				if (_RTFForRangeParameterizedAttribute is null)
					_RTFForRangeParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRTFForRangeParameterizedAttribute")!;
				return _RTFForRangeParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RangeForIndexParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRangeForIndexParameterizedAttribute",  "AppKit")]
		public static NSString RangeForIndexParameterizedAttribute {
			get {
				if (_RangeForIndexParameterizedAttribute is null)
					_RangeForIndexParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRangeForIndexParameterizedAttribute")!;
				return _RangeForIndexParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RangeForLineParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRangeForLineParameterizedAttribute",  "AppKit")]
		public static NSString RangeForLineParameterizedAttribute {
			get {
				if (_RangeForLineParameterizedAttribute is null)
					_RangeForLineParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRangeForLineParameterizedAttribute")!;
				return _RangeForLineParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RangeForPositionParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRangeForPositionParameterizedAttribute",  "AppKit")]
		public static NSString RangeForPositionParameterizedAttribute {
			get {
				if (_RangeForPositionParameterizedAttribute is null)
					_RangeForPositionParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRangeForPositionParameterizedAttribute")!;
				return _RangeForPositionParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequiredAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRequiredAttribute",  "AppKit")]
		public static NSString RequiredAttribute {
			get {
				if (_RequiredAttribute is null)
					_RequiredAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRequiredAttribute")!;
				return _RequiredAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultsForSearchPredicateParameterizedAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityResultsForSearchPredicateParameterizedAttribute'.</summary>
		[Field ("NSAccessibilityResultsForSearchPredicateParameterizedAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString ResultsForSearchPredicateParameterizedAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_ResultsForSearchPredicateParameterizedAttribute is null)
					_ResultsForSearchPredicateParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityResultsForSearchPredicateParameterizedAttribute")!;
				return _ResultsForSearchPredicateParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RoleAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRoleAttribute",  "AppKit")]
		public static NSString RoleAttribute {
			get {
				if (_RoleAttribute is null)
					_RoleAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRoleAttribute")!;
				return _RoleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RoleDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRoleDescriptionAttribute",  "AppKit")]
		public static NSString RoleDescriptionAttribute {
			get {
				if (_RoleDescriptionAttribute is null)
					_RoleDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRoleDescriptionAttribute")!;
				return _RoleDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowCountAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRowCountAttribute",  "AppKit")]
		public static NSString RowCountAttribute {
			get {
				if (_RowCountAttribute is null)
					_RowCountAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowCountAttribute")!;
				return _RowCountAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowHeaderUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRowHeaderUIElementsAttribute",  "AppKit")]
		public static NSString RowHeaderUIElementsAttribute {
			get {
				if (_RowHeaderUIElementsAttribute is null)
					_RowHeaderUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowHeaderUIElementsAttribute")!;
				return _RowHeaderUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowIndexRangeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRowIndexRangeAttribute",  "AppKit")]
		public static NSString RowIndexRangeAttribute {
			get {
				if (_RowIndexRangeAttribute is null)
					_RowIndexRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowIndexRangeAttribute")!;
				return _RowIndexRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityRowsAttribute",  "AppKit")]
		public static NSString RowsAttribute {
			get {
				if (_RowsAttribute is null)
					_RowsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowsAttribute")!;
				return _RowsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScreenPointForLayoutPointParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityScreenPointForLayoutPointParameterizedAttribute",  "AppKit")]
		public static NSString ScreenPointForLayoutPointParameterizedAttribute {
			get {
				if (_ScreenPointForLayoutPointParameterizedAttribute is null)
					_ScreenPointForLayoutPointParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityScreenPointForLayoutPointParameterizedAttribute")!;
				return _ScreenPointForLayoutPointParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScreenSizeForLayoutSizeParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityScreenSizeForLayoutSizeParameterizedAttribute",  "AppKit")]
		public static NSString ScreenSizeForLayoutSizeParameterizedAttribute {
			get {
				if (_ScreenSizeForLayoutSizeParameterizedAttribute is null)
					_ScreenSizeForLayoutSizeParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityScreenSizeForLayoutSizeParameterizedAttribute")!;
				return _ScreenSizeForLayoutSizeParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SearchButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySearchButtonAttribute",  "AppKit")]
		public static NSString SearchButtonAttribute {
			get {
				if (_SearchButtonAttribute is null)
					_SearchButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchButtonAttribute")!;
				return _SearchButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SearchMenuAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySearchMenuAttribute",  "AppKit")]
		public static NSString SearchMenuAttribute {
			get {
				if (_SearchMenuAttribute is null)
					_SearchMenuAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchMenuAttribute")!;
				return _SearchMenuAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedAttribute",  "AppKit")]
		public static NSString SelectedAttribute {
			get {
				if (_SelectedAttribute is null)
					_SelectedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedAttribute")!;
				return _SelectedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedCellsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedCellsAttribute",  "AppKit")]
		public static NSString SelectedCellsAttribute {
			get {
				if (_SelectedCellsAttribute is null)
					_SelectedCellsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsAttribute")!;
				return _SelectedCellsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedChildrenAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedChildrenAttribute",  "AppKit")]
		public static NSString SelectedChildrenAttribute {
			get {
				if (_SelectedChildrenAttribute is null)
					_SelectedChildrenAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenAttribute")!;
				return _SelectedChildrenAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedColumnsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedColumnsAttribute",  "AppKit")]
		public static NSString SelectedColumnsAttribute {
			get {
				if (_SelectedColumnsAttribute is null)
					_SelectedColumnsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsAttribute")!;
				return _SelectedColumnsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedRowsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedRowsAttribute",  "AppKit")]
		public static NSString SelectedRowsAttribute {
			get {
				if (_SelectedRowsAttribute is null)
					_SelectedRowsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsAttribute")!;
				return _SelectedRowsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedTextAttribute",  "AppKit")]
		public static NSString SelectedTextAttribute {
			get {
				if (_SelectedTextAttribute is null)
					_SelectedTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedTextAttribute")!;
				return _SelectedTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedTextRangeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedTextRangeAttribute",  "AppKit")]
		public static NSString SelectedTextRangeAttribute {
			get {
				if (_SelectedTextRangeAttribute is null)
					_SelectedTextRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedTextRangeAttribute")!;
				return _SelectedTextRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedTextRangesAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySelectedTextRangesAttribute",  "AppKit")]
		public static NSString SelectedTextRangesAttribute {
			get {
				if (_SelectedTextRangesAttribute is null)
					_SelectedTextRangesAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedTextRangesAttribute")!;
				return _SelectedTextRangesAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServesAsTitleForUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityServesAsTitleForUIElementsAttribute",  "AppKit")]
		public static NSString ServesAsTitleForUIElementsAttribute {
			get {
				if (_ServesAsTitleForUIElementsAttribute is null)
					_ServesAsTitleForUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityServesAsTitleForUIElementsAttribute")!;
				return _ServesAsTitleForUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadowTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityShadowTextAttribute",  "AppKit")]
		public static NSString ShadowTextAttribute {
			get {
				if (_ShadowTextAttribute is null)
					_ShadowTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityShadowTextAttribute")!;
				return _ShadowTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharedCharacterRangeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySharedCharacterRangeAttribute",  "AppKit")]
		public static NSString SharedCharacterRangeAttribute {
			get {
				if (_SharedCharacterRangeAttribute is null)
					_SharedCharacterRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySharedCharacterRangeAttribute")!;
				return _SharedCharacterRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharedFocusElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySharedFocusElementsAttribute",  "AppKit")]
		public static NSString SharedFocusElementsAttribute {
			get {
				if (_SharedFocusElementsAttribute is null)
					_SharedFocusElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySharedFocusElementsAttribute")!;
				return _SharedFocusElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharedTextUIElementsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySharedTextUIElementsAttribute",  "AppKit")]
		public static NSString SharedTextUIElementsAttribute {
			get {
				if (_SharedTextUIElementsAttribute is null)
					_SharedTextUIElementsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySharedTextUIElementsAttribute")!;
				return _SharedTextUIElementsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShownMenuAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityShownMenuAttribute",  "AppKit")]
		public static NSString ShownMenuAttribute {
			get {
				if (_ShownMenuAttribute is null)
					_ShownMenuAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityShownMenuAttribute")!;
				return _ShownMenuAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SizeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySizeAttribute",  "AppKit")]
		public static NSString SizeAttribute {
			get {
				if (_SizeAttribute is null)
					_SizeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySizeAttribute")!;
				return _SizeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortDirectionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySortDirectionAttribute",  "AppKit")]
		public static NSString SortDirectionAttribute {
			get {
				if (_SortDirectionAttribute is null)
					_SortDirectionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySortDirectionAttribute")!;
				return _SortDirectionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SplittersAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySplittersAttribute",  "AppKit")]
		public static NSString SplittersAttribute {
			get {
				if (_SplittersAttribute is null)
					_SplittersAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySplittersAttribute")!;
				return _SplittersAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughColorTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityStrikethroughColorTextAttribute",  "AppKit")]
		public static NSString StrikethroughColorTextAttribute {
			get {
				if (_StrikethroughColorTextAttribute is null)
					_StrikethroughColorTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStrikethroughColorTextAttribute")!;
				return _StrikethroughColorTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrikethroughTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityStrikethroughTextAttribute",  "AppKit")]
		public static NSString StrikethroughTextAttribute {
			get {
				if (_StrikethroughTextAttribute is null)
					_StrikethroughTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStrikethroughTextAttribute")!;
				return _StrikethroughTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StringForRangeParameterizeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityStringForRangeParameterizedAttribute",  "AppKit")]
		public static NSString StringForRangeParameterizeAttribute {
			get {
				if (_StringForRangeParameterizeAttribute is null)
					_StringForRangeParameterizeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStringForRangeParameterizedAttribute")!;
				return _StringForRangeParameterizeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StyleRangeForIndexParameterizedAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityStyleRangeForIndexParameterizedAttribute",  "AppKit")]
		public static NSString StyleRangeForIndexParameterizedAttribute {
			get {
				if (_StyleRangeForIndexParameterizedAttribute is null)
					_StyleRangeForIndexParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStyleRangeForIndexParameterizedAttribute")!;
				return _StyleRangeForIndexParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubroleAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySubroleAttribute",  "AppKit")]
		public static NSString SubroleAttribute {
			get {
				if (_SubroleAttribute is null)
					_SubroleAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySubroleAttribute")!;
				return _SubroleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SuperscriptTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilitySuperscriptTextAttribute",  "AppKit")]
		public static NSString SuperscriptTextAttribute {
			get {
				if (_SuperscriptTextAttribute is null)
					_SuperscriptTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySuperscriptTextAttribute")!;
				return _SuperscriptTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TabsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTabsAttribute",  "AppKit")]
		public static NSString TabsAttribute {
			get {
				if (_TabsAttribute is null)
					_TabsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTabsAttribute")!;
				return _TabsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAlignmentAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTextAlignmentAttribute",  "AppKit")]
		public static NSString TextAlignmentAttribute {
			get {
				if (_TextAlignmentAttribute is null)
					_TextAlignmentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextAlignmentAttribute")!;
				return _TextAlignmentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCompletionAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTextCompletionAttribute'.</summary>
		[Field ("NSAccessibilityTextCompletionAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString TextCompletionAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_TextCompletionAttribute is null)
					_TextCompletionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextCompletionAttribute")!;
				return _TextCompletionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextInputMarkedRangeAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTextInputMarkedRangeAttribute'.</summary>
		[Field ("NSAccessibilityTextInputMarkedRangeAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString TextInputMarkedRangeAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_TextInputMarkedRangeAttribute is null)
					_TextInputMarkedRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextInputMarkedRangeAttribute")!;
				return _TextInputMarkedRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTitleAttribute",  "AppKit")]
		public static NSString TitleAttribute {
			get {
				if (_TitleAttribute is null)
					_TitleAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTitleAttribute")!;
				return _TitleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleUIAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTitleUIElementAttribute",  "AppKit")]
		public static NSString TitleUIAttribute {
			get {
				if (_TitleUIAttribute is null)
					_TitleUIAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTitleUIElementAttribute")!;
				return _TitleUIAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToolbarButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityToolbarButtonAttribute",  "AppKit")]
		public static NSString ToolbarButtonAttribute {
			get {
				if (_ToolbarButtonAttribute is null)
					_ToolbarButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityToolbarButtonAttribute")!;
				return _ToolbarButtonAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TopLevelUIElementAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityTopLevelUIElementAttribute",  "AppKit")]
		public static NSString TopLevelUIElementAttribute {
			get {
				if (_TopLevelUIElementAttribute is null)
					_TopLevelUIElementAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTopLevelUIElementAttribute")!;
				return _TopLevelUIElementAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIElementsForSearchPredicateParameterizedAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityUIElementsForSearchPredicateParameterizedAttribute'.</summary>
		[Field ("NSAccessibilityUIElementsForSearchPredicateParameterizedAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString UIElementsForSearchPredicateParameterizedAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_UIElementsForSearchPredicateParameterizedAttribute is null)
					_UIElementsForSearchPredicateParameterizedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUIElementsForSearchPredicateParameterizedAttribute")!;
				return _UIElementsForSearchPredicateParameterizedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _URLAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityURLAttribute",  "AppKit")]
		public static NSString URLAttribute {
			get {
				if (_URLAttribute is null)
					_URLAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityURLAttribute")!;
				return _URLAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineColorTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUnderlineColorTextAttribute",  "AppKit")]
		public static NSString UnderlineColorTextAttribute {
			get {
				if (_UnderlineColorTextAttribute is null)
					_UnderlineColorTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnderlineColorTextAttribute")!;
				return _UnderlineColorTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineTextAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUnderlineTextAttribute",  "AppKit")]
		public static NSString UnderlineTextAttribute {
			get {
				if (_UnderlineTextAttribute is null)
					_UnderlineTextAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnderlineTextAttribute")!;
				return _UnderlineTextAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnitDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUnitDescriptionAttribute",  "AppKit")]
		public static NSString UnitDescriptionAttribute {
			get {
				if (_UnitDescriptionAttribute is null)
					_UnitDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnitDescriptionAttribute")!;
				return _UnitDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnitsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityUnitsAttribute",  "AppKit")]
		public static NSString UnitsAttribute {
			get {
				if (_UnitsAttribute is null)
					_UnitsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnitsAttribute")!;
				return _UnitsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityValueAttribute",  "AppKit")]
		public static NSString ValueAttribute {
			get {
				if (_ValueAttribute is null)
					_ValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityValueAttribute")!;
				return _ValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityValueDescriptionAttribute",  "AppKit")]
		public static NSString ValueDescriptionAttribute {
			get {
				if (_ValueDescriptionAttribute is null)
					_ValueDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityValueDescriptionAttribute")!;
				return _ValueDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalScrollBarAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVerticalScrollBarAttribute",  "AppKit")]
		public static NSString VerticalScrollBarAttribute {
			get {
				if (_VerticalScrollBarAttribute is null)
					_VerticalScrollBarAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVerticalScrollBarAttribute")!;
				return _VerticalScrollBarAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalUnitDescriptionAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVerticalUnitDescriptionAttribute",  "AppKit")]
		public static NSString VerticalUnitDescriptionAttribute {
			get {
				if (_VerticalUnitDescriptionAttribute is null)
					_VerticalUnitDescriptionAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVerticalUnitDescriptionAttribute")!;
				return _VerticalUnitDescriptionAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalUnitsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVerticalUnitsAttribute",  "AppKit")]
		public static NSString VerticalUnitsAttribute {
			get {
				if (_VerticalUnitsAttribute is null)
					_VerticalUnitsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVerticalUnitsAttribute")!;
				return _VerticalUnitsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleCellsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleCellsAttribute",  "AppKit")]
		public static NSString VisibleCellsAttribute {
			get {
				if (_VisibleCellsAttribute is null)
					_VisibleCellsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleCellsAttribute")!;
				return _VisibleCellsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleCharacterRangeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleCharacterRangeAttribute",  "AppKit")]
		public static NSString VisibleCharacterRangeAttribute {
			get {
				if (_VisibleCharacterRangeAttribute is null)
					_VisibleCharacterRangeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleCharacterRangeAttribute")!;
				return _VisibleCharacterRangeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleChildrenAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleChildrenAttribute",  "AppKit")]
		public static NSString VisibleChildrenAttribute {
			get {
				if (_VisibleChildrenAttribute is null)
					_VisibleChildrenAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleChildrenAttribute")!;
				return _VisibleChildrenAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleColumnsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleColumnsAttribute",  "AppKit")]
		public static NSString VisibleColumnsAttribute {
			get {
				if (_VisibleColumnsAttribute is null)
					_VisibleColumnsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleColumnsAttribute")!;
				return _VisibleColumnsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleRowsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleRowsAttribute",  "AppKit")]
		public static NSString VisibleRowsAttribute {
			get {
				if (_VisibleRowsAttribute is null)
					_VisibleRowsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleRowsAttribute")!;
				return _VisibleRowsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisitedAttribute;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityVisitedAttribute'.</summary>
		[Field ("NSAccessibilityVisitedAttribute",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString VisitedAttribute {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_VisitedAttribute is null)
					_VisitedAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisitedAttribute")!;
				return _VisitedAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WarningValueAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityWarningValueAttribute",  "AppKit")]
		public static NSString WarningValueAttribute {
			get {
				if (_WarningValueAttribute is null)
					_WarningValueAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWarningValueAttribute")!;
				return _WarningValueAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityWindowAttribute",  "AppKit")]
		public static NSString WindowAttribute {
			get {
				if (_WindowAttribute is null)
					_WindowAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowAttribute")!;
				return _WindowAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityWindowsAttribute",  "AppKit")]
		public static NSString WindowsAttribute {
			get {
				if (_WindowsAttribute is null)
					_WindowsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowsAttribute")!;
				return _WindowsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ZoomButtonAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityZoomButtonAttribute",  "AppKit")]
		public static NSString ZoomButtonAttribute {
			get {
				if (_ZoomButtonAttribute is null)
					_ZoomButtonAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityZoomButtonAttribute")!;
				return _ZoomButtonAttribute;
			}
		}
	} /* class NSAccessibilityAttributes */
}
