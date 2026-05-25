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
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public enum NSTextListMarkerFormats : int {
		CustomString = -1,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Box = 0,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Check = 1,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Circle = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Diamond = 3,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Disc = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Hyphen = 5,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Square = 6,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		LowercaseHexadecimal = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		UppercaseHexadecimal = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Octal = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		LowercaseAlpha = 10,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		UppercaseAlpha = 11,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		LowercaseLatin = 12,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		UppercaseLatin = 13,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		LowercaseRoman = 14,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		UppercaseRoman = 15,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		Decimal = 16,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.NSTextListMarkerFormats" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSTextListMarkerFormatsExtensions {
		static IntPtr[] values = new IntPtr [17];
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerBox", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerBox {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerBox", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerCheck", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerCheck {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerCheck", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerCircle", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerCircle {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerCircle", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerDiamond", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerDiamond {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerDiamond", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerDisc", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerDisc {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerDisc", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerHyphen", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerHyphen {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerHyphen", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerSquare", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerSquare {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerSquare", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerLowercaseHexadecimal", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerLowercaseHexadecimal {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerLowercaseHexadecimal", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerUppercaseHexadecimal", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerUppercaseHexadecimal {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerUppercaseHexadecimal", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerOctal", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerOctal {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerOctal", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerLowercaseAlpha", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerLowercaseAlpha {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerLowercaseAlpha", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerUppercaseAlpha", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerUppercaseAlpha {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerUppercaseAlpha", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerLowercaseLatin", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerLowercaseLatin {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerLowercaseLatin", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerUppercaseLatin", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerUppercaseLatin {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerUppercaseLatin", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerLowercaseRoman", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerLowercaseRoman {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerLowercaseRoman", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerUppercaseRoman", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerUppercaseRoman {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerUppercaseRoman", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[Field ("NSTextListMarkerDecimal", "UIKit")]
		internal unsafe static IntPtr NSTextListMarkerDecimal {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextListMarkerDecimal", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSTextListMarkerFormats self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSTextListMarkerFormats.Box
				ptr = NSTextListMarkerBox;
				break;
			case 1: // NSTextListMarkerFormats.Check
				ptr = NSTextListMarkerCheck;
				break;
			case 2: // NSTextListMarkerFormats.Circle
				ptr = NSTextListMarkerCircle;
				break;
			case 3: // NSTextListMarkerFormats.Diamond
				ptr = NSTextListMarkerDiamond;
				break;
			case 4: // NSTextListMarkerFormats.Disc
				ptr = NSTextListMarkerDisc;
				break;
			case 5: // NSTextListMarkerFormats.Hyphen
				ptr = NSTextListMarkerHyphen;
				break;
			case 6: // NSTextListMarkerFormats.Square
				ptr = NSTextListMarkerSquare;
				break;
			case 7: // NSTextListMarkerFormats.LowercaseHexadecimal
				ptr = NSTextListMarkerLowercaseHexadecimal;
				break;
			case 8: // NSTextListMarkerFormats.UppercaseHexadecimal
				ptr = NSTextListMarkerUppercaseHexadecimal;
				break;
			case 9: // NSTextListMarkerFormats.Octal
				ptr = NSTextListMarkerOctal;
				break;
			case 10: // NSTextListMarkerFormats.LowercaseAlpha
				ptr = NSTextListMarkerLowercaseAlpha;
				break;
			case 11: // NSTextListMarkerFormats.UppercaseAlpha
				ptr = NSTextListMarkerUppercaseAlpha;
				break;
			case 12: // NSTextListMarkerFormats.LowercaseLatin
				ptr = NSTextListMarkerLowercaseLatin;
				break;
			case 13: // NSTextListMarkerFormats.UppercaseLatin
				ptr = NSTextListMarkerUppercaseLatin;
				break;
			case 14: // NSTextListMarkerFormats.LowercaseRoman
				ptr = NSTextListMarkerLowercaseRoman;
				break;
			case 15: // NSTextListMarkerFormats.UppercaseRoman
				ptr = NSTextListMarkerUppercaseRoman;
				break;
			case 16: // NSTextListMarkerFormats.Decimal
				ptr = NSTextListMarkerDecimal;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextListMarkerFormats" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSTextListMarkerFormats GetValue (NSString? constant)
		{
			if (constant is null)
				return NSTextListMarkerFormats.CustomString;
			if (constant.IsEqualTo (NSTextListMarkerBox))
				return NSTextListMarkerFormats.Box;
			if (constant.IsEqualTo (NSTextListMarkerCheck))
				return NSTextListMarkerFormats.Check;
			if (constant.IsEqualTo (NSTextListMarkerCircle))
				return NSTextListMarkerFormats.Circle;
			if (constant.IsEqualTo (NSTextListMarkerDiamond))
				return NSTextListMarkerFormats.Diamond;
			if (constant.IsEqualTo (NSTextListMarkerDisc))
				return NSTextListMarkerFormats.Disc;
			if (constant.IsEqualTo (NSTextListMarkerHyphen))
				return NSTextListMarkerFormats.Hyphen;
			if (constant.IsEqualTo (NSTextListMarkerSquare))
				return NSTextListMarkerFormats.Square;
			if (constant.IsEqualTo (NSTextListMarkerLowercaseHexadecimal))
				return NSTextListMarkerFormats.LowercaseHexadecimal;
			if (constant.IsEqualTo (NSTextListMarkerUppercaseHexadecimal))
				return NSTextListMarkerFormats.UppercaseHexadecimal;
			if (constant.IsEqualTo (NSTextListMarkerOctal))
				return NSTextListMarkerFormats.Octal;
			if (constant.IsEqualTo (NSTextListMarkerLowercaseAlpha))
				return NSTextListMarkerFormats.LowercaseAlpha;
			if (constant.IsEqualTo (NSTextListMarkerUppercaseAlpha))
				return NSTextListMarkerFormats.UppercaseAlpha;
			if (constant.IsEqualTo (NSTextListMarkerLowercaseLatin))
				return NSTextListMarkerFormats.LowercaseLatin;
			if (constant.IsEqualTo (NSTextListMarkerUppercaseLatin))
				return NSTextListMarkerFormats.UppercaseLatin;
			if (constant.IsEqualTo (NSTextListMarkerLowercaseRoman))
				return NSTextListMarkerFormats.LowercaseRoman;
			if (constant.IsEqualTo (NSTextListMarkerUppercaseRoman))
				return NSTextListMarkerFormats.UppercaseRoman;
			if (constant.IsEqualTo (NSTextListMarkerDecimal))
				return NSTextListMarkerFormats.Decimal;
			return NSTextListMarkerFormats.CustomString;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextListMarkerFormats" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextListMarkerFormats GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextListMarkerFormats" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextListMarkerFormats? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.NSTextListMarkerFormats" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSTextListMarkerFormats[]? values)
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
		internal static NSTextListMarkerFormats[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSTextListMarkerFormats> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
