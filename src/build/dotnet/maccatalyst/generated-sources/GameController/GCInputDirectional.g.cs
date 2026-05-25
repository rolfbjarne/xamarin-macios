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
	[SupportedOSPlatform ("tvos14.5")]
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum GCInputDirectional : int {
		Dpad = 0,
		CardinalDpad = 1,
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		CenterButton = 2,
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TouchSurfaceButton = 3,
	}
	/// <summary>Extension methods for the <see cref="global::GameController.GCInputDirectional" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.5")]
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GCInputDirectionalExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("GCInputDirectionalDpad", "GameController")]
		internal unsafe static IntPtr GCInputDirectionalDpad {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDirectionalDpad", storage);
			}
		}
		[Field ("GCInputDirectionalCardinalDpad", "GameController")]
		internal unsafe static IntPtr GCInputDirectionalCardinalDpad {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDirectionalCardinalDpad", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("GCInputDirectionalCenterButton", "GameController")]
		internal unsafe static IntPtr GCInputDirectionalCenterButton {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDirectionalCenterButton", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("GCInputDirectionalTouchSurfaceButton", "GameController")]
		internal unsafe static IntPtr GCInputDirectionalTouchSurfaceButton {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDirectionalTouchSurfaceButton", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this GCInputDirectional self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // GCInputDirectional.Dpad
				ptr = GCInputDirectionalDpad;
				break;
			case 1: // GCInputDirectional.CardinalDpad
				ptr = GCInputDirectionalCardinalDpad;
				break;
			case 2: // GCInputDirectional.CenterButton
				ptr = GCInputDirectionalCenterButton;
				break;
			case 3: // GCInputDirectional.TouchSurfaceButton
				ptr = GCInputDirectionalTouchSurfaceButton;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectional" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static GCInputDirectional GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (GCInputDirectionalDpad))
				return GCInputDirectional.Dpad;
			if (constant.IsEqualTo (GCInputDirectionalCardinalDpad))
				return GCInputDirectional.CardinalDpad;
			if (constant.IsEqualTo (GCInputDirectionalCenterButton))
				return GCInputDirectional.CenterButton;
			if (constant.IsEqualTo (GCInputDirectionalTouchSurfaceButton))
				return GCInputDirectional.TouchSurfaceButton;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectional" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputDirectional GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputDirectional" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputDirectional? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::GameController.GCInputDirectional" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this GCInputDirectional[]? values)
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
		internal static GCInputDirectional[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<GCInputDirectional> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
