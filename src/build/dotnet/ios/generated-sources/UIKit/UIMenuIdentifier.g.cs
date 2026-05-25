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
namespace UIKit {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIMenuIdentifier : int {
		None = 0,
		Application = 1,
		File = 2,
		Edit = 3,
		View = 4,
		Window = 5,
		Help = 6,
		About = 7,
		Preferences = 8,
		Services = 9,
		Hide = 10,
		Quit = 11,
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIMenuNewItem' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIMenuNewItem' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIMenuNewItem' instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		NewScene = 12,
		Close = 13,
		Print = 14,
		UndoRedo = 15,
		StandardEdit = 16,
		Find = 17,
		Replace = 18,
		Share = 19,
		TextStyle = 20,
		Spelling = 21,
		SpellingPanel = 22,
		SpellingOptions = 23,
		Substitutions = 24,
		SubstitutionsPanel = 25,
		SubstitutionOptions = 26,
		Transformations = 27,
		Speech = 28,
		Lookup = 29,
		Learn = 30,
		Format = 31,
		Font = 32,
		TextSize = 33,
		TextColor = 34,
		TextStylePasteboard = 35,
		Text = 36,
		WritingDirection = 37,
		Alignment = 38,
		Toolbar = 39,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		Sidebar = 40,
		Fullscreen = 41,
		MinimizeAndZoom = 42,
		BringAllToFront = 43,
		Root = 44,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		OpenRecent = 45,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		Document = 46,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		AutoFill = 47,
		[SupportedOSPlatform ("tvos18.1")]
		[SupportedOSPlatform ("ios18.1")]
		[SupportedOSPlatform ("maccatalyst18.1")]
		Open = 48,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		FindPanel = 49,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		NewItem = 50,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIMenuIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIMenuIdentifierExtensions {
		static IntPtr[] values = new IntPtr [50];
		[Field ("UIMenuApplication", "UIKit")]
		internal unsafe static IntPtr UIMenuApplication {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuApplication", storage);
			}
		}
		[Field ("UIMenuFile", "UIKit")]
		internal unsafe static IntPtr UIMenuFile {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFile", storage);
			}
		}
		[Field ("UIMenuEdit", "UIKit")]
		internal unsafe static IntPtr UIMenuEdit {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuEdit", storage);
			}
		}
		[Field ("UIMenuView", "UIKit")]
		internal unsafe static IntPtr UIMenuView {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuView", storage);
			}
		}
		[Field ("UIMenuWindow", "UIKit")]
		internal unsafe static IntPtr UIMenuWindow {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuWindow", storage);
			}
		}
		[Field ("UIMenuHelp", "UIKit")]
		internal unsafe static IntPtr UIMenuHelp {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuHelp", storage);
			}
		}
		[Field ("UIMenuAbout", "UIKit")]
		internal unsafe static IntPtr UIMenuAbout {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuAbout", storage);
			}
		}
		[Field ("UIMenuPreferences", "UIKit")]
		internal unsafe static IntPtr UIMenuPreferences {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuPreferences", storage);
			}
		}
		[Field ("UIMenuServices", "UIKit")]
		internal unsafe static IntPtr UIMenuServices {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuServices", storage);
			}
		}
		[Field ("UIMenuHide", "UIKit")]
		internal unsafe static IntPtr UIMenuHide {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuHide", storage);
			}
		}
		[Field ("UIMenuQuit", "UIKit")]
		internal unsafe static IntPtr UIMenuQuit {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuQuit", storage);
			}
		}
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIMenuNewItem' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIMenuNewItem' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIMenuNewItem' instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("UIMenuNewScene", "UIKit")]
		internal unsafe static IntPtr UIMenuNewScene {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuNewScene", storage);
			}
		}
		[Field ("UIMenuClose", "UIKit")]
		internal unsafe static IntPtr UIMenuClose {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuClose", storage);
			}
		}
		[Field ("UIMenuPrint", "UIKit")]
		internal unsafe static IntPtr UIMenuPrint {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuPrint", storage);
			}
		}
		[Field ("UIMenuUndoRedo", "UIKit")]
		internal unsafe static IntPtr UIMenuUndoRedo {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuUndoRedo", storage);
			}
		}
		[Field ("UIMenuStandardEdit", "UIKit")]
		internal unsafe static IntPtr UIMenuStandardEdit {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuStandardEdit", storage);
			}
		}
		[Field ("UIMenuFind", "UIKit")]
		internal unsafe static IntPtr UIMenuFind {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFind", storage);
			}
		}
		[Field ("UIMenuReplace", "UIKit")]
		internal unsafe static IntPtr UIMenuReplace {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuReplace", storage);
			}
		}
		[Field ("UIMenuShare", "UIKit")]
		internal unsafe static IntPtr UIMenuShare {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuShare", storage);
			}
		}
		[Field ("UIMenuTextStyle", "UIKit")]
		internal unsafe static IntPtr UIMenuTextStyle {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuTextStyle", storage);
			}
		}
		[Field ("UIMenuSpelling", "UIKit")]
		internal unsafe static IntPtr UIMenuSpelling {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSpelling", storage);
			}
		}
		[Field ("UIMenuSpellingPanel", "UIKit")]
		internal unsafe static IntPtr UIMenuSpellingPanel {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSpellingPanel", storage);
			}
		}
		[Field ("UIMenuSpellingOptions", "UIKit")]
		internal unsafe static IntPtr UIMenuSpellingOptions {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSpellingOptions", storage);
			}
		}
		[Field ("UIMenuSubstitutions", "UIKit")]
		internal unsafe static IntPtr UIMenuSubstitutions {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSubstitutions", storage);
			}
		}
		[Field ("UIMenuSubstitutionsPanel", "UIKit")]
		internal unsafe static IntPtr UIMenuSubstitutionsPanel {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSubstitutionsPanel", storage);
			}
		}
		[Field ("UIMenuSubstitutionOptions", "UIKit")]
		internal unsafe static IntPtr UIMenuSubstitutionOptions {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSubstitutionOptions", storage);
			}
		}
		[Field ("UIMenuTransformations", "UIKit")]
		internal unsafe static IntPtr UIMenuTransformations {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuTransformations", storage);
			}
		}
		[Field ("UIMenuSpeech", "UIKit")]
		internal unsafe static IntPtr UIMenuSpeech {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSpeech", storage);
			}
		}
		[Field ("UIMenuLookup", "UIKit")]
		internal unsafe static IntPtr UIMenuLookup {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuLookup", storage);
			}
		}
		[Field ("UIMenuLearn", "UIKit")]
		internal unsafe static IntPtr UIMenuLearn {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuLearn", storage);
			}
		}
		[Field ("UIMenuFormat", "UIKit")]
		internal unsafe static IntPtr UIMenuFormat {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFormat", storage);
			}
		}
		[Field ("UIMenuFont", "UIKit")]
		internal unsafe static IntPtr UIMenuFont {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFont", storage);
			}
		}
		[Field ("UIMenuTextSize", "UIKit")]
		internal unsafe static IntPtr UIMenuTextSize {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuTextSize", storage);
			}
		}
		[Field ("UIMenuTextColor", "UIKit")]
		internal unsafe static IntPtr UIMenuTextColor {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuTextColor", storage);
			}
		}
		[Field ("UIMenuTextStylePasteboard", "UIKit")]
		internal unsafe static IntPtr UIMenuTextStylePasteboard {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuTextStylePasteboard", storage);
			}
		}
		[Field ("UIMenuText", "UIKit")]
		internal unsafe static IntPtr UIMenuText {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuText", storage);
			}
		}
		[Field ("UIMenuWritingDirection", "UIKit")]
		internal unsafe static IntPtr UIMenuWritingDirection {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuWritingDirection", storage);
			}
		}
		[Field ("UIMenuAlignment", "UIKit")]
		internal unsafe static IntPtr UIMenuAlignment {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuAlignment", storage);
			}
		}
		[Field ("UIMenuToolbar", "UIKit")]
		internal unsafe static IntPtr UIMenuToolbar {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuToolbar", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("UIMenuSidebar", "UIKit")]
		internal unsafe static IntPtr UIMenuSidebar {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuSidebar", storage);
			}
		}
		[Field ("UIMenuFullscreen", "UIKit")]
		internal unsafe static IntPtr UIMenuFullscreen {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFullscreen", storage);
			}
		}
		[Field ("UIMenuMinimizeAndZoom", "UIKit")]
		internal unsafe static IntPtr UIMenuMinimizeAndZoom {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuMinimizeAndZoom", storage);
			}
		}
		[Field ("UIMenuBringAllToFront", "UIKit")]
		internal unsafe static IntPtr UIMenuBringAllToFront {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuBringAllToFront", storage);
			}
		}
		[Field ("UIMenuRoot", "UIKit")]
		internal unsafe static IntPtr UIMenuRoot {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuRoot", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("UIMenuOpenRecent", "UIKit")]
		internal unsafe static IntPtr UIMenuOpenRecent {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuOpenRecent", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("UIMenuDocument", "UIKit")]
		internal unsafe static IntPtr UIMenuDocument {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuDocument", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("UIMenuAutoFill", "UIKit")]
		internal unsafe static IntPtr UIMenuAutoFill {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuAutoFill", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.1")]
		[SupportedOSPlatform ("ios18.1")]
		[SupportedOSPlatform ("maccatalyst18.1")]
		[Field ("UIMenuOpen", "UIKit")]
		internal unsafe static IntPtr UIMenuOpen {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuOpen", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("UIMenuFindPanel", "UIKit")]
		internal unsafe static IntPtr UIMenuFindPanel {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuFindPanel", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("UIMenuNewItem", "UIKit")]
		internal unsafe static IntPtr UIMenuNewItem {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIMenuNewItem", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIMenuIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // UIMenuIdentifier.Application
				ptr = UIMenuApplication;
				break;
			case 2: // UIMenuIdentifier.File
				ptr = UIMenuFile;
				break;
			case 3: // UIMenuIdentifier.Edit
				ptr = UIMenuEdit;
				break;
			case 4: // UIMenuIdentifier.View
				ptr = UIMenuView;
				break;
			case 5: // UIMenuIdentifier.Window
				ptr = UIMenuWindow;
				break;
			case 6: // UIMenuIdentifier.Help
				ptr = UIMenuHelp;
				break;
			case 7: // UIMenuIdentifier.About
				ptr = UIMenuAbout;
				break;
			case 8: // UIMenuIdentifier.Preferences
				ptr = UIMenuPreferences;
				break;
			case 9: // UIMenuIdentifier.Services
				ptr = UIMenuServices;
				break;
			case 10: // UIMenuIdentifier.Hide
				ptr = UIMenuHide;
				break;
			case 11: // UIMenuIdentifier.Quit
				ptr = UIMenuQuit;
				break;
			case 12: // UIMenuIdentifier.NewScene
				ptr = UIMenuNewScene;
				break;
			case 13: // UIMenuIdentifier.Close
				ptr = UIMenuClose;
				break;
			case 14: // UIMenuIdentifier.Print
				ptr = UIMenuPrint;
				break;
			case 15: // UIMenuIdentifier.UndoRedo
				ptr = UIMenuUndoRedo;
				break;
			case 16: // UIMenuIdentifier.StandardEdit
				ptr = UIMenuStandardEdit;
				break;
			case 17: // UIMenuIdentifier.Find
				ptr = UIMenuFind;
				break;
			case 18: // UIMenuIdentifier.Replace
				ptr = UIMenuReplace;
				break;
			case 19: // UIMenuIdentifier.Share
				ptr = UIMenuShare;
				break;
			case 20: // UIMenuIdentifier.TextStyle
				ptr = UIMenuTextStyle;
				break;
			case 21: // UIMenuIdentifier.Spelling
				ptr = UIMenuSpelling;
				break;
			case 22: // UIMenuIdentifier.SpellingPanel
				ptr = UIMenuSpellingPanel;
				break;
			case 23: // UIMenuIdentifier.SpellingOptions
				ptr = UIMenuSpellingOptions;
				break;
			case 24: // UIMenuIdentifier.Substitutions
				ptr = UIMenuSubstitutions;
				break;
			case 25: // UIMenuIdentifier.SubstitutionsPanel
				ptr = UIMenuSubstitutionsPanel;
				break;
			case 26: // UIMenuIdentifier.SubstitutionOptions
				ptr = UIMenuSubstitutionOptions;
				break;
			case 27: // UIMenuIdentifier.Transformations
				ptr = UIMenuTransformations;
				break;
			case 28: // UIMenuIdentifier.Speech
				ptr = UIMenuSpeech;
				break;
			case 29: // UIMenuIdentifier.Lookup
				ptr = UIMenuLookup;
				break;
			case 30: // UIMenuIdentifier.Learn
				ptr = UIMenuLearn;
				break;
			case 31: // UIMenuIdentifier.Format
				ptr = UIMenuFormat;
				break;
			case 32: // UIMenuIdentifier.Font
				ptr = UIMenuFont;
				break;
			case 33: // UIMenuIdentifier.TextSize
				ptr = UIMenuTextSize;
				break;
			case 34: // UIMenuIdentifier.TextColor
				ptr = UIMenuTextColor;
				break;
			case 35: // UIMenuIdentifier.TextStylePasteboard
				ptr = UIMenuTextStylePasteboard;
				break;
			case 36: // UIMenuIdentifier.Text
				ptr = UIMenuText;
				break;
			case 37: // UIMenuIdentifier.WritingDirection
				ptr = UIMenuWritingDirection;
				break;
			case 38: // UIMenuIdentifier.Alignment
				ptr = UIMenuAlignment;
				break;
			case 39: // UIMenuIdentifier.Toolbar
				ptr = UIMenuToolbar;
				break;
			case 40: // UIMenuIdentifier.Sidebar
				ptr = UIMenuSidebar;
				break;
			case 41: // UIMenuIdentifier.Fullscreen
				ptr = UIMenuFullscreen;
				break;
			case 42: // UIMenuIdentifier.MinimizeAndZoom
				ptr = UIMenuMinimizeAndZoom;
				break;
			case 43: // UIMenuIdentifier.BringAllToFront
				ptr = UIMenuBringAllToFront;
				break;
			case 44: // UIMenuIdentifier.Root
				ptr = UIMenuRoot;
				break;
			case 45: // UIMenuIdentifier.OpenRecent
				ptr = UIMenuOpenRecent;
				break;
			case 46: // UIMenuIdentifier.Document
				ptr = UIMenuDocument;
				break;
			case 47: // UIMenuIdentifier.AutoFill
				ptr = UIMenuAutoFill;
				break;
			case 48: // UIMenuIdentifier.Open
				ptr = UIMenuOpen;
				break;
			case 49: // UIMenuIdentifier.FindPanel
				ptr = UIMenuFindPanel;
				break;
			case 50: // UIMenuIdentifier.NewItem
				ptr = UIMenuNewItem;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIMenuIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIMenuIdentifier GetValue (NSString? constant)
		{
			if (constant is null)
				return UIMenuIdentifier.None;
			if (constant.IsEqualTo (UIMenuApplication))
				return UIMenuIdentifier.Application;
			if (constant.IsEqualTo (UIMenuFile))
				return UIMenuIdentifier.File;
			if (constant.IsEqualTo (UIMenuEdit))
				return UIMenuIdentifier.Edit;
			if (constant.IsEqualTo (UIMenuView))
				return UIMenuIdentifier.View;
			if (constant.IsEqualTo (UIMenuWindow))
				return UIMenuIdentifier.Window;
			if (constant.IsEqualTo (UIMenuHelp))
				return UIMenuIdentifier.Help;
			if (constant.IsEqualTo (UIMenuAbout))
				return UIMenuIdentifier.About;
			if (constant.IsEqualTo (UIMenuPreferences))
				return UIMenuIdentifier.Preferences;
			if (constant.IsEqualTo (UIMenuServices))
				return UIMenuIdentifier.Services;
			if (constant.IsEqualTo (UIMenuHide))
				return UIMenuIdentifier.Hide;
			if (constant.IsEqualTo (UIMenuQuit))
				return UIMenuIdentifier.Quit;
			if (constant.IsEqualTo (UIMenuNewScene))
				return UIMenuIdentifier.NewScene;
			if (constant.IsEqualTo (UIMenuClose))
				return UIMenuIdentifier.Close;
			if (constant.IsEqualTo (UIMenuPrint))
				return UIMenuIdentifier.Print;
			if (constant.IsEqualTo (UIMenuUndoRedo))
				return UIMenuIdentifier.UndoRedo;
			if (constant.IsEqualTo (UIMenuStandardEdit))
				return UIMenuIdentifier.StandardEdit;
			if (constant.IsEqualTo (UIMenuFind))
				return UIMenuIdentifier.Find;
			if (constant.IsEqualTo (UIMenuReplace))
				return UIMenuIdentifier.Replace;
			if (constant.IsEqualTo (UIMenuShare))
				return UIMenuIdentifier.Share;
			if (constant.IsEqualTo (UIMenuTextStyle))
				return UIMenuIdentifier.TextStyle;
			if (constant.IsEqualTo (UIMenuSpelling))
				return UIMenuIdentifier.Spelling;
			if (constant.IsEqualTo (UIMenuSpellingPanel))
				return UIMenuIdentifier.SpellingPanel;
			if (constant.IsEqualTo (UIMenuSpellingOptions))
				return UIMenuIdentifier.SpellingOptions;
			if (constant.IsEqualTo (UIMenuSubstitutions))
				return UIMenuIdentifier.Substitutions;
			if (constant.IsEqualTo (UIMenuSubstitutionsPanel))
				return UIMenuIdentifier.SubstitutionsPanel;
			if (constant.IsEqualTo (UIMenuSubstitutionOptions))
				return UIMenuIdentifier.SubstitutionOptions;
			if (constant.IsEqualTo (UIMenuTransformations))
				return UIMenuIdentifier.Transformations;
			if (constant.IsEqualTo (UIMenuSpeech))
				return UIMenuIdentifier.Speech;
			if (constant.IsEqualTo (UIMenuLookup))
				return UIMenuIdentifier.Lookup;
			if (constant.IsEqualTo (UIMenuLearn))
				return UIMenuIdentifier.Learn;
			if (constant.IsEqualTo (UIMenuFormat))
				return UIMenuIdentifier.Format;
			if (constant.IsEqualTo (UIMenuFont))
				return UIMenuIdentifier.Font;
			if (constant.IsEqualTo (UIMenuTextSize))
				return UIMenuIdentifier.TextSize;
			if (constant.IsEqualTo (UIMenuTextColor))
				return UIMenuIdentifier.TextColor;
			if (constant.IsEqualTo (UIMenuTextStylePasteboard))
				return UIMenuIdentifier.TextStylePasteboard;
			if (constant.IsEqualTo (UIMenuText))
				return UIMenuIdentifier.Text;
			if (constant.IsEqualTo (UIMenuWritingDirection))
				return UIMenuIdentifier.WritingDirection;
			if (constant.IsEqualTo (UIMenuAlignment))
				return UIMenuIdentifier.Alignment;
			if (constant.IsEqualTo (UIMenuToolbar))
				return UIMenuIdentifier.Toolbar;
			if (constant.IsEqualTo (UIMenuSidebar))
				return UIMenuIdentifier.Sidebar;
			if (constant.IsEqualTo (UIMenuFullscreen))
				return UIMenuIdentifier.Fullscreen;
			if (constant.IsEqualTo (UIMenuMinimizeAndZoom))
				return UIMenuIdentifier.MinimizeAndZoom;
			if (constant.IsEqualTo (UIMenuBringAllToFront))
				return UIMenuIdentifier.BringAllToFront;
			if (constant.IsEqualTo (UIMenuRoot))
				return UIMenuIdentifier.Root;
			if (constant.IsEqualTo (UIMenuOpenRecent))
				return UIMenuIdentifier.OpenRecent;
			if (constant.IsEqualTo (UIMenuDocument))
				return UIMenuIdentifier.Document;
			if (constant.IsEqualTo (UIMenuAutoFill))
				return UIMenuIdentifier.AutoFill;
			if (constant.IsEqualTo (UIMenuOpen))
				return UIMenuIdentifier.Open;
			if (constant.IsEqualTo (UIMenuFindPanel))
				return UIMenuIdentifier.FindPanel;
			if (constant.IsEqualTo (UIMenuNewItem))
				return UIMenuIdentifier.NewItem;
			return UIMenuIdentifier.None;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIMenuIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIMenuIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIMenuIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIMenuIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIMenuIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIMenuIdentifier[]? values)
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
		internal static UIMenuIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIMenuIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
