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
namespace Foundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NSStringTransform : int {
		/// <summary>To be added.</summary>
		LatinToKatakana = 0,
		/// <summary>To be added.</summary>
		LatinToHiragana = 1,
		/// <summary>To be added.</summary>
		LatinToHangul = 2,
		/// <summary>To be added.</summary>
		LatinToArabic = 3,
		/// <summary>To be added.</summary>
		LatinToHebrew = 4,
		/// <summary>To be added.</summary>
		LatinToThai = 5,
		/// <summary>To be added.</summary>
		LatinToCyrillic = 6,
		/// <summary>To be added.</summary>
		LatinToGreek = 7,
		/// <summary>To be added.</summary>
		ToLatin = 8,
		/// <summary>To be added.</summary>
		MandarinToLatin = 9,
		/// <summary>To be added.</summary>
		HiraganaToKatakana = 10,
		/// <summary>To be added.</summary>
		FullwidthToHalfwidth = 11,
		/// <summary>To be added.</summary>
		ToXmlHex = 12,
		/// <summary>To be added.</summary>
		ToUnicodeName = 13,
		/// <summary>To be added.</summary>
		StripCombiningMarks = 14,
		/// <summary>To be added.</summary>
		StripDiacritics = 15,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSStringTransform" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSStringTransformExtensions {
		static IntPtr[] values = new IntPtr [16];
		[Field ("NSStringTransformLatinToKatakana", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToKatakana {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToKatakana", storage);
			}
		}
		[Field ("NSStringTransformLatinToHiragana", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToHiragana {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToHiragana", storage);
			}
		}
		[Field ("NSStringTransformLatinToHangul", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToHangul {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToHangul", storage);
			}
		}
		[Field ("NSStringTransformLatinToArabic", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToArabic {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToArabic", storage);
			}
		}
		[Field ("NSStringTransformLatinToHebrew", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToHebrew {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToHebrew", storage);
			}
		}
		[Field ("NSStringTransformLatinToThai", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToThai {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToThai", storage);
			}
		}
		[Field ("NSStringTransformLatinToCyrillic", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToCyrillic {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToCyrillic", storage);
			}
		}
		[Field ("NSStringTransformLatinToGreek", "Foundation")]
		internal unsafe static IntPtr NSStringTransformLatinToGreek {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformLatinToGreek", storage);
			}
		}
		[Field ("NSStringTransformToLatin", "Foundation")]
		internal unsafe static IntPtr NSStringTransformToLatin {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformToLatin", storage);
			}
		}
		[Field ("NSStringTransformMandarinToLatin", "Foundation")]
		internal unsafe static IntPtr NSStringTransformMandarinToLatin {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformMandarinToLatin", storage);
			}
		}
		[Field ("NSStringTransformHiraganaToKatakana", "Foundation")]
		internal unsafe static IntPtr NSStringTransformHiraganaToKatakana {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformHiraganaToKatakana", storage);
			}
		}
		[Field ("NSStringTransformFullwidthToHalfwidth", "Foundation")]
		internal unsafe static IntPtr NSStringTransformFullwidthToHalfwidth {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformFullwidthToHalfwidth", storage);
			}
		}
		[Field ("NSStringTransformToXMLHex", "Foundation")]
		internal unsafe static IntPtr NSStringTransformToXMLHex {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformToXMLHex", storage);
			}
		}
		[Field ("NSStringTransformToUnicodeName", "Foundation")]
		internal unsafe static IntPtr NSStringTransformToUnicodeName {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformToUnicodeName", storage);
			}
		}
		[Field ("NSStringTransformStripCombiningMarks", "Foundation")]
		internal unsafe static IntPtr NSStringTransformStripCombiningMarks {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformStripCombiningMarks", storage);
			}
		}
		[Field ("NSStringTransformStripDiacritics", "Foundation")]
		internal unsafe static IntPtr NSStringTransformStripDiacritics {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSStringTransformStripDiacritics", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSStringTransform self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSStringTransform.LatinToKatakana
				ptr = NSStringTransformLatinToKatakana;
				break;
			case 1: // NSStringTransform.LatinToHiragana
				ptr = NSStringTransformLatinToHiragana;
				break;
			case 2: // NSStringTransform.LatinToHangul
				ptr = NSStringTransformLatinToHangul;
				break;
			case 3: // NSStringTransform.LatinToArabic
				ptr = NSStringTransformLatinToArabic;
				break;
			case 4: // NSStringTransform.LatinToHebrew
				ptr = NSStringTransformLatinToHebrew;
				break;
			case 5: // NSStringTransform.LatinToThai
				ptr = NSStringTransformLatinToThai;
				break;
			case 6: // NSStringTransform.LatinToCyrillic
				ptr = NSStringTransformLatinToCyrillic;
				break;
			case 7: // NSStringTransform.LatinToGreek
				ptr = NSStringTransformLatinToGreek;
				break;
			case 8: // NSStringTransform.ToLatin
				ptr = NSStringTransformToLatin;
				break;
			case 9: // NSStringTransform.MandarinToLatin
				ptr = NSStringTransformMandarinToLatin;
				break;
			case 10: // NSStringTransform.HiraganaToKatakana
				ptr = NSStringTransformHiraganaToKatakana;
				break;
			case 11: // NSStringTransform.FullwidthToHalfwidth
				ptr = NSStringTransformFullwidthToHalfwidth;
				break;
			case 12: // NSStringTransform.ToXmlHex
				ptr = NSStringTransformToXMLHex;
				break;
			case 13: // NSStringTransform.ToUnicodeName
				ptr = NSStringTransformToUnicodeName;
				break;
			case 14: // NSStringTransform.StripCombiningMarks
				ptr = NSStringTransformStripCombiningMarks;
				break;
			case 15: // NSStringTransform.StripDiacritics
				ptr = NSStringTransformStripDiacritics;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSStringTransform" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSStringTransform GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSStringTransformLatinToKatakana))
				return NSStringTransform.LatinToKatakana;
			if (constant.IsEqualTo (NSStringTransformLatinToHiragana))
				return NSStringTransform.LatinToHiragana;
			if (constant.IsEqualTo (NSStringTransformLatinToHangul))
				return NSStringTransform.LatinToHangul;
			if (constant.IsEqualTo (NSStringTransformLatinToArabic))
				return NSStringTransform.LatinToArabic;
			if (constant.IsEqualTo (NSStringTransformLatinToHebrew))
				return NSStringTransform.LatinToHebrew;
			if (constant.IsEqualTo (NSStringTransformLatinToThai))
				return NSStringTransform.LatinToThai;
			if (constant.IsEqualTo (NSStringTransformLatinToCyrillic))
				return NSStringTransform.LatinToCyrillic;
			if (constant.IsEqualTo (NSStringTransformLatinToGreek))
				return NSStringTransform.LatinToGreek;
			if (constant.IsEqualTo (NSStringTransformToLatin))
				return NSStringTransform.ToLatin;
			if (constant.IsEqualTo (NSStringTransformMandarinToLatin))
				return NSStringTransform.MandarinToLatin;
			if (constant.IsEqualTo (NSStringTransformHiraganaToKatakana))
				return NSStringTransform.HiraganaToKatakana;
			if (constant.IsEqualTo (NSStringTransformFullwidthToHalfwidth))
				return NSStringTransform.FullwidthToHalfwidth;
			if (constant.IsEqualTo (NSStringTransformToXMLHex))
				return NSStringTransform.ToXmlHex;
			if (constant.IsEqualTo (NSStringTransformToUnicodeName))
				return NSStringTransform.ToUnicodeName;
			if (constant.IsEqualTo (NSStringTransformStripCombiningMarks))
				return NSStringTransform.StripCombiningMarks;
			if (constant.IsEqualTo (NSStringTransformStripDiacritics))
				return NSStringTransform.StripDiacritics;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSStringTransform" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSStringTransform GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSStringTransform" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSStringTransform? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSStringTransform" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSStringTransform[]? values)
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
		internal static NSStringTransform[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSStringTransform> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
