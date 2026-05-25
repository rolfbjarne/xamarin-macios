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
namespace BrowserEngineKit {
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public enum BEAccessibilityTrait : long {
		MenuItem = 0,
		PopUpButton = 1,
		RadioButton = 2,
		ReadOnly = 3,
		Visited = 4,
	}
	/// <summary>Extension methods for the <see cref="global::BrowserEngineKit.BEAccessibilityTrait" /> enumeration.</summary>
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class BEAccessibilityTraitExtensions {
		static ulong?[] values = new ulong? [5];
		[Field ("BEAccessibilityTraitMenuItem", "BrowserEngineKit")]
		internal unsafe static ulong BEAccessibilityTraitMenuItem {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<UInt64> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityTraitMenuItem");
				return values [0]!.Value;
			}
		}
		[Field ("BEAccessibilityTraitPopUpButton", "BrowserEngineKit")]
		internal unsafe static ulong BEAccessibilityTraitPopUpButton {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<UInt64> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityTraitPopUpButton");
				return values [1]!.Value;
			}
		}
		[Field ("BEAccessibilityTraitRadioButton", "BrowserEngineKit")]
		internal unsafe static ulong BEAccessibilityTraitRadioButton {
			get {
				if (!values [2].HasValue)
					values [2] = Dlfcn.GetStruct<UInt64> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityTraitRadioButton");
				return values [2]!.Value;
			}
		}
		[Field ("BEAccessibilityTraitReadOnly", "BrowserEngineKit")]
		internal unsafe static ulong BEAccessibilityTraitReadOnly {
			get {
				if (!values [3].HasValue)
					values [3] = Dlfcn.GetStruct<UInt64> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityTraitReadOnly");
				return values [3]!.Value;
			}
		}
		[Field ("BEAccessibilityTraitVisited", "BrowserEngineKit")]
		internal unsafe static ulong BEAccessibilityTraitVisited {
			get {
				if (!values [4].HasValue)
					values [4] = Dlfcn.GetStruct<UInt64> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityTraitVisited");
				return values [4]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.UInt64" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe ulong? GetConstant (this BEAccessibilityTrait self)
		{
			switch ((long) self) {
			case 0: // BEAccessibilityTrait.MenuItem
				return BEAccessibilityTraitMenuItem;
			case 1: // BEAccessibilityTrait.PopUpButton
				return BEAccessibilityTraitPopUpButton;
			case 2: // BEAccessibilityTrait.RadioButton
				return BEAccessibilityTraitRadioButton;
			case 3: // BEAccessibilityTrait.ReadOnly
				return BEAccessibilityTraitReadOnly;
			case 4: // BEAccessibilityTrait.Visited
				return BEAccessibilityTraitVisited;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::BrowserEngineKit.BEAccessibilityTrait" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe BEAccessibilityTrait GetValue (ulong constant)
		{
			if (constant == BEAccessibilityTraitMenuItem)
				return BEAccessibilityTrait.MenuItem;
			if (constant == BEAccessibilityTraitPopUpButton)
				return BEAccessibilityTrait.PopUpButton;
			if (constant == BEAccessibilityTraitRadioButton)
				return BEAccessibilityTrait.RadioButton;
			if (constant == BEAccessibilityTraitReadOnly)
				return BEAccessibilityTrait.ReadOnly;
			if (constant == BEAccessibilityTraitVisited)
				return BEAccessibilityTrait.Visited;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::BrowserEngineKit.BEAccessibilityTrait" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static ulong?[]? ToConstantArray (this BEAccessibilityTrait[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ulong?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="ulong" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="ulong" /> values to convert.</param>
		internal static BEAccessibilityTrait[]? ToEnumArray (this ulong[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<BEAccessibilityTrait> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
