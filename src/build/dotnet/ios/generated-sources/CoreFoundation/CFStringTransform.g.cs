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
namespace CoreFoundation {
	public enum CFStringTransform : int {
		/// <summary>To be added.</summary>
		StripCombiningMarks = 0,
		/// <summary>To be added.</summary>
		ToLatin = 1,
		/// <summary>To be added.</summary>
		FullwidthHalfwidth = 2,
		/// <summary>To be added.</summary>
		LatinKatakana = 3,
		/// <summary>To be added.</summary>
		LatinHiragana = 4,
		/// <summary>To be added.</summary>
		HiraganaKatakana = 5,
		/// <summary>To be added.</summary>
		MandarinLatin = 6,
		/// <summary>To be added.</summary>
		LatinHangul = 7,
		/// <summary>To be added.</summary>
		LatinArabic = 8,
		/// <summary>To be added.</summary>
		LatinHebrew = 9,
		/// <summary>To be added.</summary>
		LatinThai = 10,
		/// <summary>To be added.</summary>
		LatinCyrillic = 11,
		/// <summary>To be added.</summary>
		LatinGreek = 12,
		/// <summary>To be added.</summary>
		ToXmlHex = 13,
		/// <summary>To be added.</summary>
		ToUnicodeName = 14,
		/// <summary>To be added.</summary>
		StripDiacritics = 15,
	}
	/// <summary>Extension methods for the <see cref="global::CoreFoundation.CFStringTransform" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CFStringTransformExtensions {
		static IntPtr[] values = new IntPtr [16];
		[Field ("kCFStringTransformStripCombiningMarks", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformStripCombiningMarks {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformStripCombiningMarks", storage);
			}
		}
		[Field ("kCFStringTransformToLatin", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformToLatin {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformToLatin", storage);
			}
		}
		[Field ("kCFStringTransformFullwidthHalfwidth", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformFullwidthHalfwidth {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformFullwidthHalfwidth", storage);
			}
		}
		[Field ("kCFStringTransformLatinKatakana", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinKatakana {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinKatakana", storage);
			}
		}
		[Field ("kCFStringTransformLatinHiragana", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinHiragana {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHiragana", storage);
			}
		}
		[Field ("kCFStringTransformHiraganaKatakana", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformHiraganaKatakana {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformHiraganaKatakana", storage);
			}
		}
		[Field ("kCFStringTransformMandarinLatin", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformMandarinLatin {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformMandarinLatin", storage);
			}
		}
		[Field ("kCFStringTransformLatinHangul", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinHangul {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHangul", storage);
			}
		}
		[Field ("kCFStringTransformLatinArabic", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinArabic {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinArabic", storage);
			}
		}
		[Field ("kCFStringTransformLatinHebrew", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinHebrew {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHebrew", storage);
			}
		}
		[Field ("kCFStringTransformLatinThai", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinThai {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinThai", storage);
			}
		}
		[Field ("kCFStringTransformLatinCyrillic", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinCyrillic {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinCyrillic", storage);
			}
		}
		[Field ("kCFStringTransformLatinGreek", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformLatinGreek {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformLatinGreek", storage);
			}
		}
		[Field ("kCFStringTransformToXMLHex", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformToXMLHex {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformToXMLHex", storage);
			}
		}
		[Field ("kCFStringTransformToUnicodeName", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformToUnicodeName {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformToUnicodeName", storage);
			}
		}
		[Field ("kCFStringTransformStripDiacritics", "CoreFoundation")]
		internal unsafe static IntPtr kCFStringTransformStripDiacritics {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.CoreFoundation.Handle, "kCFStringTransformStripDiacritics", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CFStringTransform self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CFStringTransform.StripCombiningMarks
				ptr = kCFStringTransformStripCombiningMarks;
				break;
			case 1: // CFStringTransform.ToLatin
				ptr = kCFStringTransformToLatin;
				break;
			case 2: // CFStringTransform.FullwidthHalfwidth
				ptr = kCFStringTransformFullwidthHalfwidth;
				break;
			case 3: // CFStringTransform.LatinKatakana
				ptr = kCFStringTransformLatinKatakana;
				break;
			case 4: // CFStringTransform.LatinHiragana
				ptr = kCFStringTransformLatinHiragana;
				break;
			case 5: // CFStringTransform.HiraganaKatakana
				ptr = kCFStringTransformHiraganaKatakana;
				break;
			case 6: // CFStringTransform.MandarinLatin
				ptr = kCFStringTransformMandarinLatin;
				break;
			case 7: // CFStringTransform.LatinHangul
				ptr = kCFStringTransformLatinHangul;
				break;
			case 8: // CFStringTransform.LatinArabic
				ptr = kCFStringTransformLatinArabic;
				break;
			case 9: // CFStringTransform.LatinHebrew
				ptr = kCFStringTransformLatinHebrew;
				break;
			case 10: // CFStringTransform.LatinThai
				ptr = kCFStringTransformLatinThai;
				break;
			case 11: // CFStringTransform.LatinCyrillic
				ptr = kCFStringTransformLatinCyrillic;
				break;
			case 12: // CFStringTransform.LatinGreek
				ptr = kCFStringTransformLatinGreek;
				break;
			case 13: // CFStringTransform.ToXmlHex
				ptr = kCFStringTransformToXMLHex;
				break;
			case 14: // CFStringTransform.ToUnicodeName
				ptr = kCFStringTransformToUnicodeName;
				break;
			case 15: // CFStringTransform.StripDiacritics
				ptr = kCFStringTransformStripDiacritics;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFStringTransform" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CFStringTransform GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCFStringTransformStripCombiningMarks))
				return CFStringTransform.StripCombiningMarks;
			if (constant.IsEqualTo (kCFStringTransformToLatin))
				return CFStringTransform.ToLatin;
			if (constant.IsEqualTo (kCFStringTransformFullwidthHalfwidth))
				return CFStringTransform.FullwidthHalfwidth;
			if (constant.IsEqualTo (kCFStringTransformLatinKatakana))
				return CFStringTransform.LatinKatakana;
			if (constant.IsEqualTo (kCFStringTransformLatinHiragana))
				return CFStringTransform.LatinHiragana;
			if (constant.IsEqualTo (kCFStringTransformHiraganaKatakana))
				return CFStringTransform.HiraganaKatakana;
			if (constant.IsEqualTo (kCFStringTransformMandarinLatin))
				return CFStringTransform.MandarinLatin;
			if (constant.IsEqualTo (kCFStringTransformLatinHangul))
				return CFStringTransform.LatinHangul;
			if (constant.IsEqualTo (kCFStringTransformLatinArabic))
				return CFStringTransform.LatinArabic;
			if (constant.IsEqualTo (kCFStringTransformLatinHebrew))
				return CFStringTransform.LatinHebrew;
			if (constant.IsEqualTo (kCFStringTransformLatinThai))
				return CFStringTransform.LatinThai;
			if (constant.IsEqualTo (kCFStringTransformLatinCyrillic))
				return CFStringTransform.LatinCyrillic;
			if (constant.IsEqualTo (kCFStringTransformLatinGreek))
				return CFStringTransform.LatinGreek;
			if (constant.IsEqualTo (kCFStringTransformToXMLHex))
				return CFStringTransform.ToXmlHex;
			if (constant.IsEqualTo (kCFStringTransformToUnicodeName))
				return CFStringTransform.ToUnicodeName;
			if (constant.IsEqualTo (kCFStringTransformStripDiacritics))
				return CFStringTransform.StripDiacritics;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFStringTransform" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CFStringTransform GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFStringTransform" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CFStringTransform? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreFoundation.CFStringTransform" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CFStringTransform[]? values)
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
		internal static CFStringTransform[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CFStringTransform> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
