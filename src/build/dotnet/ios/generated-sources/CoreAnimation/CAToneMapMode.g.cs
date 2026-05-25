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
namespace CoreAnimation {
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum CAToneMapMode : int {
		Automatic = 0,
		Never = 1,
		IfSupported = 2,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CAToneMapMode" /> enumeration.</summary>
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CAToneMapModeExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("CAToneMapModeAutomatic", "CoreAnimation")]
		internal unsafe static IntPtr CAToneMapModeAutomatic {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CAToneMapModeAutomatic", storage);
			}
		}
		[Field ("CAToneMapModeNever", "CoreAnimation")]
		internal unsafe static IntPtr CAToneMapModeNever {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CAToneMapModeNever", storage);
			}
		}
		[Field ("CAToneMapModeIfSupported", "CoreAnimation")]
		internal unsafe static IntPtr CAToneMapModeIfSupported {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CAToneMapModeIfSupported", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CAToneMapMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CAToneMapMode.Automatic
			default:
				ptr = CAToneMapModeAutomatic;
				break;
			case 1: // CAToneMapMode.Never
				ptr = CAToneMapModeNever;
				break;
			case 2: // CAToneMapMode.IfSupported
				ptr = CAToneMapModeIfSupported;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAToneMapMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CAToneMapMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CAToneMapModeAutomatic))
				return CAToneMapMode.Automatic;
			if (constant.IsEqualTo (CAToneMapModeNever))
				return CAToneMapMode.Never;
			if (constant.IsEqualTo (CAToneMapModeIfSupported))
				return CAToneMapMode.IfSupported;
			return CAToneMapMode.Automatic;
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAToneMapMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAToneMapMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAToneMapMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAToneMapMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CAToneMapMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CAToneMapMode[]? values)
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
		internal static CAToneMapMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CAToneMapMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
