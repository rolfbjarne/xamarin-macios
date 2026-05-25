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
namespace PhotosUI {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum PHProjectCategory : int {
		/// <summary>To be added.</summary>
		Book = 0,
		/// <summary>To be added.</summary>
		Calendar = 1,
		/// <summary>To be added.</summary>
		Card = 2,
		/// <summary>To be added.</summary>
		Prints = 3,
		/// <summary>To be added.</summary>
		Slideshow = 4,
		/// <summary>To be added.</summary>
		WallDecor = 5,
		/// <summary>To be added.</summary>
		Other = 6,
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		Undefined = 7,
	}
	/// <summary>Extension methods for the <see cref="global::PhotosUI.PHProjectCategory" /> enumeration.</summary>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PHProjectCategoryExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("PHProjectCategoryBook", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryBook {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryBook", storage);
			}
		}
		[Field ("PHProjectCategoryCalendar", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryCalendar {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryCalendar", storage);
			}
		}
		[Field ("PHProjectCategoryCard", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryCard {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryCard", storage);
			}
		}
		[Field ("PHProjectCategoryPrints", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryPrints {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryPrints", storage);
			}
		}
		[Field ("PHProjectCategorySlideshow", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategorySlideshow {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategorySlideshow", storage);
			}
		}
		[Field ("PHProjectCategoryWallDecor", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryWallDecor {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryWallDecor", storage);
			}
		}
		[Field ("PHProjectCategoryOther", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryOther {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryOther", storage);
			}
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[Field ("PHProjectCategoryUndefined", "PhotosUI")]
		internal unsafe static IntPtr PHProjectCategoryUndefined {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.PhotosUI.Handle, "PHProjectCategoryUndefined", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PHProjectCategory self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PHProjectCategory.Book
				ptr = PHProjectCategoryBook;
				break;
			case 1: // PHProjectCategory.Calendar
				ptr = PHProjectCategoryCalendar;
				break;
			case 2: // PHProjectCategory.Card
				ptr = PHProjectCategoryCard;
				break;
			case 3: // PHProjectCategory.Prints
				ptr = PHProjectCategoryPrints;
				break;
			case 4: // PHProjectCategory.Slideshow
				ptr = PHProjectCategorySlideshow;
				break;
			case 5: // PHProjectCategory.WallDecor
				ptr = PHProjectCategoryWallDecor;
				break;
			case 6: // PHProjectCategory.Other
				ptr = PHProjectCategoryOther;
				break;
			case 7: // PHProjectCategory.Undefined
				ptr = PHProjectCategoryUndefined;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PhotosUI.PHProjectCategory" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PHProjectCategory GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PHProjectCategoryBook))
				return PHProjectCategory.Book;
			if (constant.IsEqualTo (PHProjectCategoryCalendar))
				return PHProjectCategory.Calendar;
			if (constant.IsEqualTo (PHProjectCategoryCard))
				return PHProjectCategory.Card;
			if (constant.IsEqualTo (PHProjectCategoryPrints))
				return PHProjectCategory.Prints;
			if (constant.IsEqualTo (PHProjectCategorySlideshow))
				return PHProjectCategory.Slideshow;
			if (constant.IsEqualTo (PHProjectCategoryWallDecor))
				return PHProjectCategory.WallDecor;
			if (constant.IsEqualTo (PHProjectCategoryOther))
				return PHProjectCategory.Other;
			if (constant.IsEqualTo (PHProjectCategoryUndefined))
				return PHProjectCategory.Undefined;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PhotosUI.PHProjectCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PHProjectCategory GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PhotosUI.PHProjectCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PHProjectCategory? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PhotosUI.PHProjectCategory" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PHProjectCategory[]? values)
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
		internal static PHProjectCategory[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PHProjectCategory> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
