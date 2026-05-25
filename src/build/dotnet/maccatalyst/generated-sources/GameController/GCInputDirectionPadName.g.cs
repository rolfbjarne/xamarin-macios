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
namespace GameController {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum GCInputDirectionPadName : int {
		DirectionPad = 0,
		LeftThumbstick = 1,
		RightThumbstick = 2,
		DualShockTouchpadOne = 3,
		DualShockTouchpadTwo = 4,
	}
	/// <summary>Extension methods for the <see cref="global::GameController.GCInputDirectionPadName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GCInputDirectionPadNameExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("GCInputDirectionPad", "GameController")]
		internal unsafe static IntPtr GCInputDirectionPad {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDirectionPad", storage);
			}
		}
		[Field ("GCInputLeftThumbstick", "GameController")]
		internal unsafe static IntPtr GCInputLeftThumbstick {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftThumbstick", storage);
			}
		}
		[Field ("GCInputRightThumbstick", "GameController")]
		internal unsafe static IntPtr GCInputRightThumbstick {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightThumbstick", storage);
			}
		}
		[Field ("GCInputDualShockTouchpadOne", "GameController")]
		internal unsafe static IntPtr GCInputDualShockTouchpadOne {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDualShockTouchpadOne", storage);
			}
		}
		[Field ("GCInputDualShockTouchpadTwo", "GameController")]
		internal unsafe static IntPtr GCInputDualShockTouchpadTwo {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDualShockTouchpadTwo", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this GCInputDirectionPadName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // GCInputDirectionPadName.DirectionPad
				ptr = GCInputDirectionPad;
				break;
			case 1: // GCInputDirectionPadName.LeftThumbstick
				ptr = GCInputLeftThumbstick;
				break;
			case 2: // GCInputDirectionPadName.RightThumbstick
				ptr = GCInputRightThumbstick;
				break;
			case 3: // GCInputDirectionPadName.DualShockTouchpadOne
				ptr = GCInputDualShockTouchpadOne;
				break;
			case 4: // GCInputDirectionPadName.DualShockTouchpadTwo
				ptr = GCInputDualShockTouchpadTwo;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectionPadName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static GCInputDirectionPadName GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (GCInputDirectionPad))
				return GCInputDirectionPadName.DirectionPad;
			if (constant.IsEqualTo (GCInputLeftThumbstick))
				return GCInputDirectionPadName.LeftThumbstick;
			if (constant.IsEqualTo (GCInputRightThumbstick))
				return GCInputDirectionPadName.RightThumbstick;
			if (constant.IsEqualTo (GCInputDualShockTouchpadOne))
				return GCInputDirectionPadName.DualShockTouchpadOne;
			if (constant.IsEqualTo (GCInputDualShockTouchpadTwo))
				return GCInputDirectionPadName.DualShockTouchpadTwo;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectionPadName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputDirectionPadName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectionPadName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputDirectionPadName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::GameController.GCInputDirectionPadName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this GCInputDirectionPadName[]? values)
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
		internal static GCInputDirectionPadName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<GCInputDirectionPadName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
