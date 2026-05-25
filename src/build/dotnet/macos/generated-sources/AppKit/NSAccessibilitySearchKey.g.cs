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
	[SupportedOSPlatform ("macos26.0")]
	public unsafe static partial class NSAccessibilitySearchKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnyType;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityAnyTypeSearchKey'.</summary>
		[Field ("NSAccessibilityAnyTypeSearchKey",  "AppKit")]
		public static NSString AnyType {
			get {
				if (_AnyType is null)
					_AnyType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnyTypeSearchKey")!;
				return _AnyType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Article;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityArticleSearchKey'.</summary>
		[Field ("NSAccessibilityArticleSearchKey",  "AppKit")]
		public static NSString Article {
			get {
				if (_Article is null)
					_Article = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityArticleSearchKey")!;
				return _Article;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Blockquote;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityBlockquoteSearchKey'.</summary>
		[Field ("NSAccessibilityBlockquoteSearchKey",  "AppKit")]
		public static NSString Blockquote {
			get {
				if (_Blockquote is null)
					_Blockquote = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBlockquoteSearchKey")!;
				return _Blockquote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockquoteSameLevel;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityBlockquoteSameLevelSearchKey'.</summary>
		[Field ("NSAccessibilityBlockquoteSameLevelSearchKey",  "AppKit")]
		public static NSString BlockquoteSameLevel {
			get {
				if (_BlockquoteSameLevel is null)
					_BlockquoteSameLevel = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBlockquoteSameLevelSearchKey")!;
				return _BlockquoteSameLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoldFont;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityBoldFontSearchKey'.</summary>
		[Field ("NSAccessibilityBoldFontSearchKey",  "AppKit")]
		public static NSString BoldFont {
			get {
				if (_BoldFont is null)
					_BoldFont = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityBoldFontSearchKey")!;
				return _BoldFont;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Button;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityButtonSearchKey'.</summary>
		[Field ("NSAccessibilityButtonSearchKey",  "AppKit")]
		public static NSString Button {
			get {
				if (_Button is null)
					_Button = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityButtonSearchKey")!;
				return _Button;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CheckBox;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityCheckBoxSearchKey'.</summary>
		[Field ("NSAccessibilityCheckBoxSearchKey",  "AppKit")]
		public static NSString CheckBox {
			get {
				if (_CheckBox is null)
					_CheckBox = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCheckBoxSearchKey")!;
				return _CheckBox;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Control;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityControlSearchKey'.</summary>
		[Field ("NSAccessibilityControlSearchKey",  "AppKit")]
		public static NSString Control {
			get {
				if (_Control is null)
					_Control = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityControlSearchKey")!;
				return _Control;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DifferentType;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityDifferentTypeSearchKey'.</summary>
		[Field ("NSAccessibilityDifferentTypeSearchKey",  "AppKit")]
		public static NSString DifferentType {
			get {
				if (_DifferentType is null)
					_DifferentType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDifferentTypeSearchKey")!;
				return _DifferentType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontChange;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityFontChangeSearchKey'.</summary>
		[Field ("NSAccessibilityFontChangeSearchKey",  "AppKit")]
		public static NSString FontChange {
			get {
				if (_FontChange is null)
					_FontChange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontChangeSearchKey")!;
				return _FontChange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontColorChange;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityFontColorChangeSearchKey'.</summary>
		[Field ("NSAccessibilityFontColorChangeSearchKey",  "AppKit")]
		public static NSString FontColorChange {
			get {
				if (_FontColorChange is null)
					_FontColorChange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontColorChangeSearchKey")!;
				return _FontColorChange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Frame;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityFrameSearchKey'.</summary>
		[Field ("NSAccessibilityFrameSearchKey",  "AppKit")]
		public static NSString Frame {
			get {
				if (_Frame is null)
					_Frame = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFrameSearchKey")!;
				return _Frame;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Graphic;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityGraphicSearchKey'.</summary>
		[Field ("NSAccessibilityGraphicSearchKey",  "AppKit")]
		public static NSString Graphic {
			get {
				if (_Graphic is null)
					_Graphic = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityGraphicSearchKey")!;
				return _Graphic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Heading;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingSearchKey'.</summary>
		[Field ("NSAccessibilityHeadingSearchKey",  "AppKit")]
		public static NSString Heading {
			get {
				if (_Heading is null)
					_Heading = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingSearchKey")!;
				return _Heading;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel1;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel1SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel1SearchKey",  "AppKit")]
		public static NSString HeadingLevel1 {
			get {
				if (_HeadingLevel1 is null)
					_HeadingLevel1 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel1SearchKey")!;
				return _HeadingLevel1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel2;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel2SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel2SearchKey",  "AppKit")]
		public static NSString HeadingLevel2 {
			get {
				if (_HeadingLevel2 is null)
					_HeadingLevel2 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel2SearchKey")!;
				return _HeadingLevel2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel3;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel3SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel3SearchKey",  "AppKit")]
		public static NSString HeadingLevel3 {
			get {
				if (_HeadingLevel3 is null)
					_HeadingLevel3 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel3SearchKey")!;
				return _HeadingLevel3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel4;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel4SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel4SearchKey",  "AppKit")]
		public static NSString HeadingLevel4 {
			get {
				if (_HeadingLevel4 is null)
					_HeadingLevel4 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel4SearchKey")!;
				return _HeadingLevel4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel5;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel5SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel5SearchKey",  "AppKit")]
		public static NSString HeadingLevel5 {
			get {
				if (_HeadingLevel5 is null)
					_HeadingLevel5 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel5SearchKey")!;
				return _HeadingLevel5;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingLevel6;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingLevel6SearchKey'.</summary>
		[Field ("NSAccessibilityHeadingLevel6SearchKey",  "AppKit")]
		public static NSString HeadingLevel6 {
			get {
				if (_HeadingLevel6 is null)
					_HeadingLevel6 = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingLevel6SearchKey")!;
				return _HeadingLevel6;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadingSameLevel;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityHeadingSameLevelSearchKey'.</summary>
		[Field ("NSAccessibilityHeadingSameLevelSearchKey",  "AppKit")]
		public static NSString HeadingSameLevel {
			get {
				if (_HeadingSameLevel is null)
					_HeadingSameLevel = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHeadingSameLevelSearchKey")!;
				return _HeadingSameLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItalicFont;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityItalicFontSearchKey'.</summary>
		[Field ("NSAccessibilityItalicFontSearchKey",  "AppKit")]
		public static NSString ItalicFont {
			get {
				if (_ItalicFont is null)
					_ItalicFont = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityItalicFontSearchKey")!;
				return _ItalicFont;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyboardFocusable;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityKeyboardFocusableSearchKey'.</summary>
		[Field ("NSAccessibilityKeyboardFocusableSearchKey",  "AppKit")]
		public static NSString KeyboardFocusable {
			get {
				if (_KeyboardFocusable is null)
					_KeyboardFocusable = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityKeyboardFocusableSearchKey")!;
				return _KeyboardFocusable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Landmark;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityLandmarkSearchKey'.</summary>
		[Field ("NSAccessibilityLandmarkSearchKey",  "AppKit")]
		public static NSString Landmark {
			get {
				if (_Landmark is null)
					_Landmark = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLandmarkSearchKey")!;
				return _Landmark;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Link;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityLinkSearchKey'.</summary>
		[Field ("NSAccessibilityLinkSearchKey",  "AppKit")]
		public static NSString Link {
			get {
				if (_Link is null)
					_Link = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLinkSearchKey")!;
				return _Link;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _List;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityListSearchKey'.</summary>
		[Field ("NSAccessibilityListSearchKey",  "AppKit")]
		public static NSString List {
			get {
				if (_List is null)
					_List = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityListSearchKey")!;
				return _List;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LiveRegion;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityLiveRegionSearchKey'.</summary>
		[Field ("NSAccessibilityLiveRegionSearchKey",  "AppKit")]
		public static NSString LiveRegion {
			get {
				if (_LiveRegion is null)
					_LiveRegion = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLiveRegionSearchKey")!;
				return _LiveRegion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MisspelledWord;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityMisspelledWordSearchKey'.</summary>
		[Field ("NSAccessibilityMisspelledWordSearchKey",  "AppKit")]
		public static NSString MisspelledWord {
			get {
				if (_MisspelledWord is null)
					_MisspelledWord = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMisspelledWordSearchKey")!;
				return _MisspelledWord;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Outline;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityOutlineSearchKey'.</summary>
		[Field ("NSAccessibilityOutlineSearchKey",  "AppKit")]
		public static NSString Outline {
			get {
				if (_Outline is null)
					_Outline = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityOutlineSearchKey")!;
				return _Outline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlainText;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityPlainTextSearchKey'.</summary>
		[Field ("NSAccessibilityPlainTextSearchKey",  "AppKit")]
		public static NSString PlainText {
			get {
				if (_PlainText is null)
					_PlainText = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityPlainTextSearchKey")!;
				return _PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RadioGroup;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityRadioGroupSearchKey'.</summary>
		[Field ("NSAccessibilityRadioGroupSearchKey",  "AppKit")]
		public static NSString RadioGroup {
			get {
				if (_RadioGroup is null)
					_RadioGroup = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRadioGroupSearchKey")!;
				return _RadioGroup;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SameType;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySameTypeSearchKey'.</summary>
		[Field ("NSAccessibilitySameTypeSearchKey",  "AppKit")]
		public static NSString SameType {
			get {
				if (_SameType is null)
					_SameType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySameTypeSearchKey")!;
				return _SameType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StaticText;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityStaticTextSearchKey'.</summary>
		[Field ("NSAccessibilityStaticTextSearchKey",  "AppKit")]
		public static NSString StaticText {
			get {
				if (_StaticText is null)
					_StaticText = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStaticTextSearchKey")!;
				return _StaticText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StyleChange;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityStyleChangeSearchKey'.</summary>
		[Field ("NSAccessibilityStyleChangeSearchKey",  "AppKit")]
		public static NSString StyleChange {
			get {
				if (_StyleChange is null)
					_StyleChange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityStyleChangeSearchKey")!;
				return _StyleChange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Table;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTableSearchKey'.</summary>
		[Field ("NSAccessibilityTableSearchKey",  "AppKit")]
		public static NSString Table {
			get {
				if (_Table is null)
					_Table = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTableSearchKey")!;
				return _Table;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TableSameLevel;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTableSameLevelSearchKey'.</summary>
		[Field ("NSAccessibilityTableSameLevelSearchKey",  "AppKit")]
		public static NSString TableSameLevel {
			get {
				if (_TableSameLevel is null)
					_TableSameLevel = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTableSameLevelSearchKey")!;
				return _TableSameLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextField;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTextFieldSearchKey'.</summary>
		[Field ("NSAccessibilityTextFieldSearchKey",  "AppKit")]
		public static NSString TextField {
			get {
				if (_TextField is null)
					_TextField = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextFieldSearchKey")!;
				return _TextField;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextSta;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTextStateSyncKey'.</summary>
		[Field ("NSAccessibilityTextStateSyncKey",  "AppKit")]
		public static NSString TextSta {
			get {
				if (_TextSta is null)
					_TextSta = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextStateSyncKey")!;
				return _TextSta;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextStateChan;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityTextStateChangeTypeKey'.</summary>
		[Field ("NSAccessibilityTextStateChangeTypeKey",  "AppKit")]
		public static NSString TextStateChan {
			get {
				if (_TextStateChan is null)
					_TextStateChan = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextStateChangeTypeKey")!;
				return _TextStateChan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Underline;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityUnderlineSearchKey'.</summary>
		[Field ("NSAccessibilityUnderlineSearchKey",  "AppKit")]
		public static NSString Underline {
			get {
				if (_Underline is null)
					_Underline = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnderlineSearchKey")!;
				return _Underline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnvisitedLink;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityUnvisitedLinkSearchKey'.</summary>
		[Field ("NSAccessibilityUnvisitedLinkSearchKey",  "AppKit")]
		public static NSString UnvisitedLink {
			get {
				if (_UnvisitedLink is null)
					_UnvisitedLink = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnvisitedLinkSearchKey")!;
				return _UnvisitedLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisitedLink;
		/// <summary>Represents the value associated with the constant 'NSAccessibilityVisitedLinkSearchKey'.</summary>
		[Field ("NSAccessibilityVisitedLinkSearchKey",  "AppKit")]
		public static NSString VisitedLink {
			get {
				if (_VisitedLink is null)
					_VisitedLink = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisitedLinkSearchKey")!;
				return _VisitedLink;
			}
		}
	} /* class NSAccessibilitySearchKey */
}
