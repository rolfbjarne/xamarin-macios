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
namespace BrowserEngineKit {
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public enum BEAccessibilityNotification : long {
		SelectionChanged = 0,
		Changed = 1,
	}
	/// <summary>Extension methods for the <see cref="global::BrowserEngineKit.BEAccessibilityNotification" /> enumeration.</summary>
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class BEAccessibilityNotificationExtensions {
		static uint?[] values = new uint? [2];
		[Field ("BEAccessibilitySelectionChangedNotification", "BrowserEngineKit")]
		internal unsafe static uint BEAccessibilitySelectionChangedNotification {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<UInt32> (Libraries.BrowserEngineKit.Handle, "BEAccessibilitySelectionChangedNotification");
				return values [0]!.Value;
			}
		}
		[Field ("BEAccessibilityValueChangedNotification", "BrowserEngineKit")]
		internal unsafe static uint BEAccessibilityValueChangedNotification {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<UInt32> (Libraries.BrowserEngineKit.Handle, "BEAccessibilityValueChangedNotification");
				return values [1]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.UInt32" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe uint? GetConstant (this BEAccessibilityNotification self)
		{
			switch ((long) self) {
			case 0: // BEAccessibilityNotification.SelectionChanged
				return BEAccessibilitySelectionChangedNotification;
			case 1: // BEAccessibilityNotification.Changed
				return BEAccessibilityValueChangedNotification;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::BrowserEngineKit.BEAccessibilityNotification" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe BEAccessibilityNotification GetValue (uint constant)
		{
			if (constant == BEAccessibilitySelectionChangedNotification)
				return BEAccessibilityNotification.SelectionChanged;
			if (constant == BEAccessibilityValueChangedNotification)
				return BEAccessibilityNotification.Changed;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::BrowserEngineKit.BEAccessibilityNotification" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static uint?[]? ToConstantArray (this BEAccessibilityNotification[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<uint?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="uint" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="uint" /> values to convert.</param>
		internal static BEAccessibilityNotification[]? ToEnumArray (this uint[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<BEAccessibilityNotification> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
