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
	[SupportedOSPlatform ("macos")]
	public enum NSRulerViewUnits : int {
		/// <summary>To be added.</summary>
		Inches = 0,
		/// <summary>To be added.</summary>
		Centimeters = 1,
		/// <summary>To be added.</summary>
		Points = 2,
		/// <summary>To be added.</summary>
		Picas = 3,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSRulerViewUnits" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSRulerViewUnitsExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("NSRulerViewUnitInches", "AppKit")]
		internal unsafe static IntPtr NSRulerViewUnitInches {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSRulerViewUnitInches", storage);
			}
		}
		[Field ("NSRulerViewUnitCentimeters", "AppKit")]
		internal unsafe static IntPtr NSRulerViewUnitCentimeters {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSRulerViewUnitCentimeters", storage);
			}
		}
		[Field ("NSRulerViewUnitPoints", "AppKit")]
		internal unsafe static IntPtr NSRulerViewUnitPoints {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSRulerViewUnitPoints", storage);
			}
		}
		[Field ("NSRulerViewUnitPicas", "AppKit")]
		internal unsafe static IntPtr NSRulerViewUnitPicas {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSRulerViewUnitPicas", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSRulerViewUnits self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSRulerViewUnits.Inches
				ptr = NSRulerViewUnitInches;
				break;
			case 1: // NSRulerViewUnits.Centimeters
				ptr = NSRulerViewUnitCentimeters;
				break;
			case 2: // NSRulerViewUnits.Points
				ptr = NSRulerViewUnitPoints;
				break;
			case 3: // NSRulerViewUnits.Picas
				ptr = NSRulerViewUnitPicas;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSRulerViewUnits" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSRulerViewUnits GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSRulerViewUnitInches))
				return NSRulerViewUnits.Inches;
			if (constant.IsEqualTo (NSRulerViewUnitCentimeters))
				return NSRulerViewUnits.Centimeters;
			if (constant.IsEqualTo (NSRulerViewUnitPoints))
				return NSRulerViewUnits.Points;
			if (constant.IsEqualTo (NSRulerViewUnitPicas))
				return NSRulerViewUnits.Picas;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSRulerViewUnits" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSRulerViewUnits GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSRulerViewUnits" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSRulerViewUnits? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSRulerViewUnits" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSRulerViewUnits[]? values)
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
		internal static NSRulerViewUnits[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSRulerViewUnits> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
