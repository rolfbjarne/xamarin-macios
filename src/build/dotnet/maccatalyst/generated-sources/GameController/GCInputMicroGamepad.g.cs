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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum GCInputMicroGamepad : int {
		Dpad = 0,
		ButtonA = 1,
		ButtonX = 2,
		ButtonMenu = 3,
	}
	/// <summary>Extension methods for the <see cref="global::GameController.GCInputMicroGamepad" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GCInputMicroGamepadExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("GCInputMicroGamepadDpad", "GameController")]
		internal unsafe static IntPtr GCInputMicroGamepadDpad {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputMicroGamepadDpad", storage);
			}
		}
		[Field ("GCInputMicroGamepadButtonA", "GameController")]
		internal unsafe static IntPtr GCInputMicroGamepadButtonA {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputMicroGamepadButtonA", storage);
			}
		}
		[Field ("GCInputMicroGamepadButtonX", "GameController")]
		internal unsafe static IntPtr GCInputMicroGamepadButtonX {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputMicroGamepadButtonX", storage);
			}
		}
		[Field ("GCInputMicroGamepadButtonMenu", "GameController")]
		internal unsafe static IntPtr GCInputMicroGamepadButtonMenu {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputMicroGamepadButtonMenu", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this GCInputMicroGamepad self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // GCInputMicroGamepad.Dpad
				ptr = GCInputMicroGamepadDpad;
				break;
			case 1: // GCInputMicroGamepad.ButtonA
				ptr = GCInputMicroGamepadButtonA;
				break;
			case 2: // GCInputMicroGamepad.ButtonX
				ptr = GCInputMicroGamepadButtonX;
				break;
			case 3: // GCInputMicroGamepad.ButtonMenu
				ptr = GCInputMicroGamepadButtonMenu;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputMicroGamepad" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static GCInputMicroGamepad GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (GCInputMicroGamepadDpad))
				return GCInputMicroGamepad.Dpad;
			if (constant.IsEqualTo (GCInputMicroGamepadButtonA))
				return GCInputMicroGamepad.ButtonA;
			if (constant.IsEqualTo (GCInputMicroGamepadButtonX))
				return GCInputMicroGamepad.ButtonX;
			if (constant.IsEqualTo (GCInputMicroGamepadButtonMenu))
				return GCInputMicroGamepad.ButtonMenu;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputMicroGamepad" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputMicroGamepad GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputMicroGamepad" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputMicroGamepad? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::GameController.GCInputMicroGamepad" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this GCInputMicroGamepad[]? values)
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
		internal static GCInputMicroGamepad[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<GCInputMicroGamepad> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
