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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	public enum UIAccessibilityTraits : long {
		None = 0,
		Button = 1,
		Link = 2,
		Header = 3,
		SearchField = 4,
		Image = 5,
		Selected = 6,
		PlaysSound = 7,
		KeyboardKey = 8,
		StaticText = 9,
		SummaryElement = 10,
		NotEnabled = 11,
		UpdatesFrequently = 12,
		StartsMediaSession = 13,
		Adjustable = 14,
		AllowsDirectInteraction = 15,
		CausesPageTurn = 16,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TabBar = 17,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		SupportsZoom = 18,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		ToggleButton = 19,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIAccessibilityTraits" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIAccessibilityTraitsExtensions {
		static ulong?[] values = new ulong? [20];
		[Field ("UIAccessibilityTraitNone", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitNone {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitNone");
				return values [0]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitButton", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitButton {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitButton");
				return values [1]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitLink", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitLink {
			get {
				if (!values [2].HasValue)
					values [2] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitLink");
				return values [2]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitHeader", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitHeader {
			get {
				if (!values [3].HasValue)
					values [3] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitHeader");
				return values [3]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitSearchField", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitSearchField {
			get {
				if (!values [4].HasValue)
					values [4] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitSearchField");
				return values [4]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitImage", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitImage {
			get {
				if (!values [5].HasValue)
					values [5] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitImage");
				return values [5]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitSelected", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitSelected {
			get {
				if (!values [6].HasValue)
					values [6] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitSelected");
				return values [6]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitPlaysSound", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitPlaysSound {
			get {
				if (!values [7].HasValue)
					values [7] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitPlaysSound");
				return values [7]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitKeyboardKey", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitKeyboardKey {
			get {
				if (!values [8].HasValue)
					values [8] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitKeyboardKey");
				return values [8]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitStaticText", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitStaticText {
			get {
				if (!values [9].HasValue)
					values [9] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitStaticText");
				return values [9]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitSummaryElement", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitSummaryElement {
			get {
				if (!values [10].HasValue)
					values [10] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitSummaryElement");
				return values [10]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitNotEnabled", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitNotEnabled {
			get {
				if (!values [11].HasValue)
					values [11] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitNotEnabled");
				return values [11]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitUpdatesFrequently", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitUpdatesFrequently {
			get {
				if (!values [12].HasValue)
					values [12] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitUpdatesFrequently");
				return values [12]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitStartsMediaSession", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitStartsMediaSession {
			get {
				if (!values [13].HasValue)
					values [13] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitStartsMediaSession");
				return values [13]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitAdjustable", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitAdjustable {
			get {
				if (!values [14].HasValue)
					values [14] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitAdjustable");
				return values [14]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitAllowsDirectInteraction", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitAllowsDirectInteraction {
			get {
				if (!values [15].HasValue)
					values [15] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitAllowsDirectInteraction");
				return values [15]!.Value;
			}
		}
		[Field ("UIAccessibilityTraitCausesPageTurn", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitCausesPageTurn {
			get {
				if (!values [16].HasValue)
					values [16] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitCausesPageTurn");
				return values [16]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIAccessibilityTraitTabBar", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitTabBar {
			get {
				if (!values [17].HasValue)
					values [17] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitTabBar");
				return values [17]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("UIAccessibilityTraitSupportsZoom", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitSupportsZoom {
			get {
				if (!values [18].HasValue)
					values [18] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitSupportsZoom");
				return values [18]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("UIAccessibilityTraitToggleButton", "UIKit")]
		internal unsafe static ulong UIAccessibilityTraitToggleButton {
			get {
				if (!values [19].HasValue)
					values [19] = Dlfcn.GetStruct<UInt64> (Libraries.UIKit.Handle, "UIAccessibilityTraitToggleButton");
				return values [19]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.UInt64" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe ulong? GetConstantValue (this UIAccessibilityTraits self)
		{
			switch ((long) self) {
			case 0: // UIAccessibilityTraits.None
				return UIAccessibilityTraitNone;
			case 1: // UIAccessibilityTraits.Button
				return UIAccessibilityTraitButton;
			case 2: // UIAccessibilityTraits.Link
				return UIAccessibilityTraitLink;
			case 3: // UIAccessibilityTraits.Header
				return UIAccessibilityTraitHeader;
			case 4: // UIAccessibilityTraits.SearchField
				return UIAccessibilityTraitSearchField;
			case 5: // UIAccessibilityTraits.Image
				return UIAccessibilityTraitImage;
			case 6: // UIAccessibilityTraits.Selected
				return UIAccessibilityTraitSelected;
			case 7: // UIAccessibilityTraits.PlaysSound
				return UIAccessibilityTraitPlaysSound;
			case 8: // UIAccessibilityTraits.KeyboardKey
				return UIAccessibilityTraitKeyboardKey;
			case 9: // UIAccessibilityTraits.StaticText
				return UIAccessibilityTraitStaticText;
			case 10: // UIAccessibilityTraits.SummaryElement
				return UIAccessibilityTraitSummaryElement;
			case 11: // UIAccessibilityTraits.NotEnabled
				return UIAccessibilityTraitNotEnabled;
			case 12: // UIAccessibilityTraits.UpdatesFrequently
				return UIAccessibilityTraitUpdatesFrequently;
			case 13: // UIAccessibilityTraits.StartsMediaSession
				return UIAccessibilityTraitStartsMediaSession;
			case 14: // UIAccessibilityTraits.Adjustable
				return UIAccessibilityTraitAdjustable;
			case 15: // UIAccessibilityTraits.AllowsDirectInteraction
				return UIAccessibilityTraitAllowsDirectInteraction;
			case 16: // UIAccessibilityTraits.CausesPageTurn
				return UIAccessibilityTraitCausesPageTurn;
			case 17: // UIAccessibilityTraits.TabBar
				return UIAccessibilityTraitTabBar;
			case 18: // UIAccessibilityTraits.SupportsZoom
				return UIAccessibilityTraitSupportsZoom;
			case 19: // UIAccessibilityTraits.ToggleButton
				return UIAccessibilityTraitToggleButton;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIAccessibilityTraits" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe UIAccessibilityTraits GetValue (ulong constant)
		{
			if (constant == UIAccessibilityTraitNone)
				return UIAccessibilityTraits.None;
			if (constant == UIAccessibilityTraitButton)
				return UIAccessibilityTraits.Button;
			if (constant == UIAccessibilityTraitLink)
				return UIAccessibilityTraits.Link;
			if (constant == UIAccessibilityTraitHeader)
				return UIAccessibilityTraits.Header;
			if (constant == UIAccessibilityTraitSearchField)
				return UIAccessibilityTraits.SearchField;
			if (constant == UIAccessibilityTraitImage)
				return UIAccessibilityTraits.Image;
			if (constant == UIAccessibilityTraitSelected)
				return UIAccessibilityTraits.Selected;
			if (constant == UIAccessibilityTraitPlaysSound)
				return UIAccessibilityTraits.PlaysSound;
			if (constant == UIAccessibilityTraitKeyboardKey)
				return UIAccessibilityTraits.KeyboardKey;
			if (constant == UIAccessibilityTraitStaticText)
				return UIAccessibilityTraits.StaticText;
			if (constant == UIAccessibilityTraitSummaryElement)
				return UIAccessibilityTraits.SummaryElement;
			if (constant == UIAccessibilityTraitNotEnabled)
				return UIAccessibilityTraits.NotEnabled;
			if (constant == UIAccessibilityTraitUpdatesFrequently)
				return UIAccessibilityTraits.UpdatesFrequently;
			if (constant == UIAccessibilityTraitStartsMediaSession)
				return UIAccessibilityTraits.StartsMediaSession;
			if (constant == UIAccessibilityTraitAdjustable)
				return UIAccessibilityTraits.Adjustable;
			if (constant == UIAccessibilityTraitAllowsDirectInteraction)
				return UIAccessibilityTraits.AllowsDirectInteraction;
			if (constant == UIAccessibilityTraitCausesPageTurn)
				return UIAccessibilityTraits.CausesPageTurn;
			if (constant == UIAccessibilityTraitTabBar)
				return UIAccessibilityTraits.TabBar;
			if (constant == UIAccessibilityTraitSupportsZoom)
				return UIAccessibilityTraits.SupportsZoom;
			if (constant == UIAccessibilityTraitToggleButton)
				return UIAccessibilityTraits.ToggleButton;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIAccessibilityTraits" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static ulong?[]? ToConstantArray (this UIAccessibilityTraits[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ulong?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstantValue ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="ulong" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="ulong" /> values to convert.</param>
		internal static UIAccessibilityTraits[]? ToEnumArray (this ulong[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIAccessibilityTraits> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
