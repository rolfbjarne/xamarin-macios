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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum PdfAnnotationKey : int {
		/// <summary>To be added.</summary>
		AppearanceDictionary = 0,
		/// <summary>To be added.</summary>
		AppearanceState = 1,
		/// <summary>To be added.</summary>
		Border = 2,
		/// <summary>To be added.</summary>
		Color = 3,
		/// <summary>To be added.</summary>
		Contents = 4,
		/// <summary>To be added.</summary>
		Flags = 5,
		/// <summary>To be added.</summary>
		Date = 6,
		/// <summary>To be added.</summary>
		Name = 7,
		/// <summary>To be added.</summary>
		Page = 8,
		/// <summary>To be added.</summary>
		Rect = 9,
		/// <summary>To be added.</summary>
		Subtype = 10,
		/// <summary>To be added.</summary>
		Action = 11,
		/// <summary>To be added.</summary>
		AdditionalActions = 12,
		/// <summary>To be added.</summary>
		BorderStyle = 13,
		/// <summary>To be added.</summary>
		DefaultAppearance = 14,
		/// <summary>To be added.</summary>
		Destination = 15,
		/// <summary>To be added.</summary>
		HighlightingMode = 16,
		/// <summary>To be added.</summary>
		Inklist = 17,
		/// <summary>To be added.</summary>
		InteriorColor = 18,
		/// <summary>To be added.</summary>
		LinePoints = 19,
		/// <summary>To be added.</summary>
		LineEndingStyles = 20,
		/// <summary>To be added.</summary>
		IconName = 21,
		/// <summary>To be added.</summary>
		Open = 22,
		/// <summary>To be added.</summary>
		Parent = 23,
		/// <summary>To be added.</summary>
		Popup = 24,
		/// <summary>To be added.</summary>
		Quadding = 25,
		/// <summary>To be added.</summary>
		QuadPoints = 26,
		/// <summary>To be added.</summary>
		TextLabel = 27,
		/// <summary>To be added.</summary>
		WidgetDownCaption = 28,
		/// <summary>To be added.</summary>
		WidgetBorderColor = 29,
		/// <summary>To be added.</summary>
		WidgetBackgroundColor = 30,
		/// <summary>To be added.</summary>
		WidgetCaption = 31,
		/// <summary>To be added.</summary>
		WidgetDefaultValue = 32,
		/// <summary>To be added.</summary>
		WidgetFieldFlags = 33,
		/// <summary>To be added.</summary>
		WidgetFieldType = 34,
		/// <summary>To be added.</summary>
		WidgetAppearanceDictionary = 35,
		/// <summary>To be added.</summary>
		WidgetMaxLen = 36,
		/// <summary>To be added.</summary>
		WidgetOptions = 37,
		/// <summary>To be added.</summary>
		WidgetRotation = 38,
		/// <summary>To be added.</summary>
		WidgetRolloverCaption = 39,
		/// <summary>To be added.</summary>
		WidgetTextLabelUI = 40,
		/// <summary>To be added.</summary>
		WidgetValue = 41,
	}
	/// <summary>Extension methods for the <see cref="global::PdfKit.PdfAnnotationKey" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PdfAnnotationKeyExtensions {
		static IntPtr[] values = new IntPtr [42];
		[Field ("PDFAnnotationKeyAppearanceDictionary", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyAppearanceDictionary {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyAppearanceDictionary", storage);
			}
		}
		[Field ("PDFAnnotationKeyAppearanceState", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyAppearanceState {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyAppearanceState", storage);
			}
		}
		[Field ("PDFAnnotationKeyBorder", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyBorder {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyBorder", storage);
			}
		}
		[Field ("PDFAnnotationKeyColor", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyColor {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyColor", storage);
			}
		}
		[Field ("PDFAnnotationKeyContents", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyContents {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyContents", storage);
			}
		}
		[Field ("PDFAnnotationKeyFlags", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyFlags {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyFlags", storage);
			}
		}
		[Field ("PDFAnnotationKeyDate", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyDate {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyDate", storage);
			}
		}
		[Field ("PDFAnnotationKeyName", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyName {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyName", storage);
			}
		}
		[Field ("PDFAnnotationKeyPage", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyPage {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyPage", storage);
			}
		}
		[Field ("PDFAnnotationKeyRect", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyRect {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyRect", storage);
			}
		}
		[Field ("PDFAnnotationKeySubtype", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeySubtype {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeySubtype", storage);
			}
		}
		[Field ("PDFAnnotationKeyAction", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyAction {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyAction", storage);
			}
		}
		[Field ("PDFAnnotationKeyAdditionalActions", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyAdditionalActions {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyAdditionalActions", storage);
			}
		}
		[Field ("PDFAnnotationKeyBorderStyle", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyBorderStyle {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyBorderStyle", storage);
			}
		}
		[Field ("PDFAnnotationKeyDefaultAppearance", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyDefaultAppearance {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyDefaultAppearance", storage);
			}
		}
		[Field ("PDFAnnotationKeyDestination", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyDestination {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyDestination", storage);
			}
		}
		[Field ("PDFAnnotationKeyHighlightingMode", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyHighlightingMode {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyHighlightingMode", storage);
			}
		}
		[Field ("PDFAnnotationKeyInklist", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyInklist {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyInklist", storage);
			}
		}
		[Field ("PDFAnnotationKeyInteriorColor", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyInteriorColor {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyInteriorColor", storage);
			}
		}
		[Field ("PDFAnnotationKeyLinePoints", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyLinePoints {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyLinePoints", storage);
			}
		}
		[Field ("PDFAnnotationKeyLineEndingStyles", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyLineEndingStyles {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyLineEndingStyles", storage);
			}
		}
		[Field ("PDFAnnotationKeyIconName", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyIconName {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyIconName", storage);
			}
		}
		[Field ("PDFAnnotationKeyOpen", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyOpen {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyOpen", storage);
			}
		}
		[Field ("PDFAnnotationKeyParent", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyParent {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyParent", storage);
			}
		}
		[Field ("PDFAnnotationKeyPopup", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyPopup {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyPopup", storage);
			}
		}
		[Field ("PDFAnnotationKeyQuadding", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyQuadding {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyQuadding", storage);
			}
		}
		[Field ("PDFAnnotationKeyQuadPoints", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyQuadPoints {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyQuadPoints", storage);
			}
		}
		[Field ("PDFAnnotationKeyTextLabel", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyTextLabel {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyTextLabel", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetDownCaption", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetDownCaption {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetDownCaption", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetBorderColor", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetBorderColor {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetBorderColor", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetBackgroundColor", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetBackgroundColor {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetBackgroundColor", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetCaption", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetCaption {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetCaption", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetDefaultValue", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetDefaultValue {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetDefaultValue", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetFieldFlags", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetFieldFlags {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetFieldFlags", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetFieldType", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetFieldType {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetFieldType", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetAppearanceDictionary", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetAppearanceDictionary {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetAppearanceDictionary", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetMaxLen", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetMaxLen {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetMaxLen", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetOptions", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetOptions {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetOptions", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetRotation", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetRotation {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetRotation", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetRolloverCaption", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetRolloverCaption {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetRolloverCaption", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetTextLabelUI", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetTextLabelUI {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetTextLabelUI", storage);
			}
		}
		[Field ("PDFAnnotationKeyWidgetValue", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationKeyWidgetValue {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetValue", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PdfAnnotationKey self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PdfAnnotationKey.AppearanceDictionary
				ptr = PDFAnnotationKeyAppearanceDictionary;
				break;
			case 1: // PdfAnnotationKey.AppearanceState
				ptr = PDFAnnotationKeyAppearanceState;
				break;
			case 2: // PdfAnnotationKey.Border
				ptr = PDFAnnotationKeyBorder;
				break;
			case 3: // PdfAnnotationKey.Color
				ptr = PDFAnnotationKeyColor;
				break;
			case 4: // PdfAnnotationKey.Contents
				ptr = PDFAnnotationKeyContents;
				break;
			case 5: // PdfAnnotationKey.Flags
				ptr = PDFAnnotationKeyFlags;
				break;
			case 6: // PdfAnnotationKey.Date
				ptr = PDFAnnotationKeyDate;
				break;
			case 7: // PdfAnnotationKey.Name
				ptr = PDFAnnotationKeyName;
				break;
			case 8: // PdfAnnotationKey.Page
				ptr = PDFAnnotationKeyPage;
				break;
			case 9: // PdfAnnotationKey.Rect
				ptr = PDFAnnotationKeyRect;
				break;
			case 10: // PdfAnnotationKey.Subtype
				ptr = PDFAnnotationKeySubtype;
				break;
			case 11: // PdfAnnotationKey.Action
				ptr = PDFAnnotationKeyAction;
				break;
			case 12: // PdfAnnotationKey.AdditionalActions
				ptr = PDFAnnotationKeyAdditionalActions;
				break;
			case 13: // PdfAnnotationKey.BorderStyle
				ptr = PDFAnnotationKeyBorderStyle;
				break;
			case 14: // PdfAnnotationKey.DefaultAppearance
				ptr = PDFAnnotationKeyDefaultAppearance;
				break;
			case 15: // PdfAnnotationKey.Destination
				ptr = PDFAnnotationKeyDestination;
				break;
			case 16: // PdfAnnotationKey.HighlightingMode
				ptr = PDFAnnotationKeyHighlightingMode;
				break;
			case 17: // PdfAnnotationKey.Inklist
				ptr = PDFAnnotationKeyInklist;
				break;
			case 18: // PdfAnnotationKey.InteriorColor
				ptr = PDFAnnotationKeyInteriorColor;
				break;
			case 19: // PdfAnnotationKey.LinePoints
				ptr = PDFAnnotationKeyLinePoints;
				break;
			case 20: // PdfAnnotationKey.LineEndingStyles
				ptr = PDFAnnotationKeyLineEndingStyles;
				break;
			case 21: // PdfAnnotationKey.IconName
				ptr = PDFAnnotationKeyIconName;
				break;
			case 22: // PdfAnnotationKey.Open
				ptr = PDFAnnotationKeyOpen;
				break;
			case 23: // PdfAnnotationKey.Parent
				ptr = PDFAnnotationKeyParent;
				break;
			case 24: // PdfAnnotationKey.Popup
				ptr = PDFAnnotationKeyPopup;
				break;
			case 25: // PdfAnnotationKey.Quadding
				ptr = PDFAnnotationKeyQuadding;
				break;
			case 26: // PdfAnnotationKey.QuadPoints
				ptr = PDFAnnotationKeyQuadPoints;
				break;
			case 27: // PdfAnnotationKey.TextLabel
				ptr = PDFAnnotationKeyTextLabel;
				break;
			case 28: // PdfAnnotationKey.WidgetDownCaption
				ptr = PDFAnnotationKeyWidgetDownCaption;
				break;
			case 29: // PdfAnnotationKey.WidgetBorderColor
				ptr = PDFAnnotationKeyWidgetBorderColor;
				break;
			case 30: // PdfAnnotationKey.WidgetBackgroundColor
				ptr = PDFAnnotationKeyWidgetBackgroundColor;
				break;
			case 31: // PdfAnnotationKey.WidgetCaption
				ptr = PDFAnnotationKeyWidgetCaption;
				break;
			case 32: // PdfAnnotationKey.WidgetDefaultValue
				ptr = PDFAnnotationKeyWidgetDefaultValue;
				break;
			case 33: // PdfAnnotationKey.WidgetFieldFlags
				ptr = PDFAnnotationKeyWidgetFieldFlags;
				break;
			case 34: // PdfAnnotationKey.WidgetFieldType
				ptr = PDFAnnotationKeyWidgetFieldType;
				break;
			case 35: // PdfAnnotationKey.WidgetAppearanceDictionary
				ptr = PDFAnnotationKeyWidgetAppearanceDictionary;
				break;
			case 36: // PdfAnnotationKey.WidgetMaxLen
				ptr = PDFAnnotationKeyWidgetMaxLen;
				break;
			case 37: // PdfAnnotationKey.WidgetOptions
				ptr = PDFAnnotationKeyWidgetOptions;
				break;
			case 38: // PdfAnnotationKey.WidgetRotation
				ptr = PDFAnnotationKeyWidgetRotation;
				break;
			case 39: // PdfAnnotationKey.WidgetRolloverCaption
				ptr = PDFAnnotationKeyWidgetRolloverCaption;
				break;
			case 40: // PdfAnnotationKey.WidgetTextLabelUI
				ptr = PDFAnnotationKeyWidgetTextLabelUI;
				break;
			case 41: // PdfAnnotationKey.WidgetValue
				ptr = PDFAnnotationKeyWidgetValue;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationKey" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PdfAnnotationKey GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PDFAnnotationKeyAppearanceDictionary))
				return PdfAnnotationKey.AppearanceDictionary;
			if (constant.IsEqualTo (PDFAnnotationKeyAppearanceState))
				return PdfAnnotationKey.AppearanceState;
			if (constant.IsEqualTo (PDFAnnotationKeyBorder))
				return PdfAnnotationKey.Border;
			if (constant.IsEqualTo (PDFAnnotationKeyColor))
				return PdfAnnotationKey.Color;
			if (constant.IsEqualTo (PDFAnnotationKeyContents))
				return PdfAnnotationKey.Contents;
			if (constant.IsEqualTo (PDFAnnotationKeyFlags))
				return PdfAnnotationKey.Flags;
			if (constant.IsEqualTo (PDFAnnotationKeyDate))
				return PdfAnnotationKey.Date;
			if (constant.IsEqualTo (PDFAnnotationKeyName))
				return PdfAnnotationKey.Name;
			if (constant.IsEqualTo (PDFAnnotationKeyPage))
				return PdfAnnotationKey.Page;
			if (constant.IsEqualTo (PDFAnnotationKeyRect))
				return PdfAnnotationKey.Rect;
			if (constant.IsEqualTo (PDFAnnotationKeySubtype))
				return PdfAnnotationKey.Subtype;
			if (constant.IsEqualTo (PDFAnnotationKeyAction))
				return PdfAnnotationKey.Action;
			if (constant.IsEqualTo (PDFAnnotationKeyAdditionalActions))
				return PdfAnnotationKey.AdditionalActions;
			if (constant.IsEqualTo (PDFAnnotationKeyBorderStyle))
				return PdfAnnotationKey.BorderStyle;
			if (constant.IsEqualTo (PDFAnnotationKeyDefaultAppearance))
				return PdfAnnotationKey.DefaultAppearance;
			if (constant.IsEqualTo (PDFAnnotationKeyDestination))
				return PdfAnnotationKey.Destination;
			if (constant.IsEqualTo (PDFAnnotationKeyHighlightingMode))
				return PdfAnnotationKey.HighlightingMode;
			if (constant.IsEqualTo (PDFAnnotationKeyInklist))
				return PdfAnnotationKey.Inklist;
			if (constant.IsEqualTo (PDFAnnotationKeyInteriorColor))
				return PdfAnnotationKey.InteriorColor;
			if (constant.IsEqualTo (PDFAnnotationKeyLinePoints))
				return PdfAnnotationKey.LinePoints;
			if (constant.IsEqualTo (PDFAnnotationKeyLineEndingStyles))
				return PdfAnnotationKey.LineEndingStyles;
			if (constant.IsEqualTo (PDFAnnotationKeyIconName))
				return PdfAnnotationKey.IconName;
			if (constant.IsEqualTo (PDFAnnotationKeyOpen))
				return PdfAnnotationKey.Open;
			if (constant.IsEqualTo (PDFAnnotationKeyParent))
				return PdfAnnotationKey.Parent;
			if (constant.IsEqualTo (PDFAnnotationKeyPopup))
				return PdfAnnotationKey.Popup;
			if (constant.IsEqualTo (PDFAnnotationKeyQuadding))
				return PdfAnnotationKey.Quadding;
			if (constant.IsEqualTo (PDFAnnotationKeyQuadPoints))
				return PdfAnnotationKey.QuadPoints;
			if (constant.IsEqualTo (PDFAnnotationKeyTextLabel))
				return PdfAnnotationKey.TextLabel;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetDownCaption))
				return PdfAnnotationKey.WidgetDownCaption;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetBorderColor))
				return PdfAnnotationKey.WidgetBorderColor;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetBackgroundColor))
				return PdfAnnotationKey.WidgetBackgroundColor;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetCaption))
				return PdfAnnotationKey.WidgetCaption;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetDefaultValue))
				return PdfAnnotationKey.WidgetDefaultValue;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetFieldFlags))
				return PdfAnnotationKey.WidgetFieldFlags;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetFieldType))
				return PdfAnnotationKey.WidgetFieldType;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetAppearanceDictionary))
				return PdfAnnotationKey.WidgetAppearanceDictionary;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetMaxLen))
				return PdfAnnotationKey.WidgetMaxLen;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetOptions))
				return PdfAnnotationKey.WidgetOptions;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetRotation))
				return PdfAnnotationKey.WidgetRotation;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetRolloverCaption))
				return PdfAnnotationKey.WidgetRolloverCaption;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetTextLabelUI))
				return PdfAnnotationKey.WidgetTextLabelUI;
			if (constant.IsEqualTo (PDFAnnotationKeyWidgetValue))
				return PdfAnnotationKey.WidgetValue;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationKey GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationKey? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PdfKit.PdfAnnotationKey" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PdfAnnotationKey[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static PdfAnnotationKey[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PdfAnnotationKey> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
