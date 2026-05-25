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
namespace CoreMedia {
	public enum CMFormatDescriptionChromaLocation : int {
		Left = 0,
		Center = 1,
		TopLeft = 2,
		Top = 3,
		BottomLeft = 4,
		Bottom = 5,
		DV420 = 6,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionChromaLocation" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionChromaLocationExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("kCMFormatDescriptionChromaLocation_Left", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_Left {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_Left", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_Center", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_Center {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_Center", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_TopLeft", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_TopLeft {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_TopLeft", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_Top", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_Top {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_Top", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_BottomLeft", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_BottomLeft {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_BottomLeft", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_Bottom", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_Bottom {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_Bottom", storage);
			}
		}
		[Field ("kCMFormatDescriptionChromaLocation_DV420", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionChromaLocation_DV420 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionChromaLocation_DV420", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionChromaLocation self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionChromaLocation.Left
				ptr = kCMFormatDescriptionChromaLocation_Left;
				break;
			case 1: // CMFormatDescriptionChromaLocation.Center
				ptr = kCMFormatDescriptionChromaLocation_Center;
				break;
			case 2: // CMFormatDescriptionChromaLocation.TopLeft
				ptr = kCMFormatDescriptionChromaLocation_TopLeft;
				break;
			case 3: // CMFormatDescriptionChromaLocation.Top
				ptr = kCMFormatDescriptionChromaLocation_Top;
				break;
			case 4: // CMFormatDescriptionChromaLocation.BottomLeft
				ptr = kCMFormatDescriptionChromaLocation_BottomLeft;
				break;
			case 5: // CMFormatDescriptionChromaLocation.Bottom
				ptr = kCMFormatDescriptionChromaLocation_Bottom;
				break;
			case 6: // CMFormatDescriptionChromaLocation.DV420
				ptr = kCMFormatDescriptionChromaLocation_DV420;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionChromaLocation" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionChromaLocation GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_Left))
				return CMFormatDescriptionChromaLocation.Left;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_Center))
				return CMFormatDescriptionChromaLocation.Center;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_TopLeft))
				return CMFormatDescriptionChromaLocation.TopLeft;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_Top))
				return CMFormatDescriptionChromaLocation.Top;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_BottomLeft))
				return CMFormatDescriptionChromaLocation.BottomLeft;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_Bottom))
				return CMFormatDescriptionChromaLocation.Bottom;
			if (constant.IsEqualTo (kCMFormatDescriptionChromaLocation_DV420))
				return CMFormatDescriptionChromaLocation.DV420;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionChromaLocation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionChromaLocation GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionChromaLocation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionChromaLocation? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionChromaLocation" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionChromaLocation[]? values)
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
		internal static CMFormatDescriptionChromaLocation[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionChromaLocation> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
