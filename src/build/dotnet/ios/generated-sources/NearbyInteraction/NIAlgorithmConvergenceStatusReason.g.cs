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
namespace NearbyInteraction {
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public enum NIAlgorithmConvergenceStatusReason : int {
		InsufficientHorizontalSweep = 0,
		InsufficientVerticalSweep = 1,
		InsufficientMovement = 2,
		InsufficientLighting = 3,
	}
	/// <summary>Extension methods for the <see cref="global::NearbyInteraction.NIAlgorithmConvergenceStatusReason" /> enumeration.</summary>
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NIAlgorithmConvergenceStatusReasonExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("NIAlgorithmConvergenceStatusReasonInsufficientHorizontalSweep", "NearbyInteraction")]
		internal unsafe static IntPtr NIAlgorithmConvergenceStatusReasonInsufficientHorizontalSweep {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.NearbyInteraction.Handle, "NIAlgorithmConvergenceStatusReasonInsufficientHorizontalSweep", storage);
			}
		}
		[Field ("NIAlgorithmConvergenceStatusReasonInsufficientVerticalSweep", "NearbyInteraction")]
		internal unsafe static IntPtr NIAlgorithmConvergenceStatusReasonInsufficientVerticalSweep {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.NearbyInteraction.Handle, "NIAlgorithmConvergenceStatusReasonInsufficientVerticalSweep", storage);
			}
		}
		[Field ("NIAlgorithmConvergenceStatusReasonInsufficientMovement", "NearbyInteraction")]
		internal unsafe static IntPtr NIAlgorithmConvergenceStatusReasonInsufficientMovement {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.NearbyInteraction.Handle, "NIAlgorithmConvergenceStatusReasonInsufficientMovement", storage);
			}
		}
		[Field ("NIAlgorithmConvergenceStatusReasonInsufficientLighting", "NearbyInteraction")]
		internal unsafe static IntPtr NIAlgorithmConvergenceStatusReasonInsufficientLighting {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.NearbyInteraction.Handle, "NIAlgorithmConvergenceStatusReasonInsufficientLighting", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NIAlgorithmConvergenceStatusReason self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NIAlgorithmConvergenceStatusReason.InsufficientHorizontalSweep
				ptr = NIAlgorithmConvergenceStatusReasonInsufficientHorizontalSweep;
				break;
			case 1: // NIAlgorithmConvergenceStatusReason.InsufficientVerticalSweep
				ptr = NIAlgorithmConvergenceStatusReasonInsufficientVerticalSweep;
				break;
			case 2: // NIAlgorithmConvergenceStatusReason.InsufficientMovement
				ptr = NIAlgorithmConvergenceStatusReasonInsufficientMovement;
				break;
			case 3: // NIAlgorithmConvergenceStatusReason.InsufficientLighting
				ptr = NIAlgorithmConvergenceStatusReasonInsufficientLighting;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::NearbyInteraction.NIAlgorithmConvergenceStatusReason" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NIAlgorithmConvergenceStatusReason GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NIAlgorithmConvergenceStatusReasonInsufficientHorizontalSweep))
				return NIAlgorithmConvergenceStatusReason.InsufficientHorizontalSweep;
			if (constant.IsEqualTo (NIAlgorithmConvergenceStatusReasonInsufficientVerticalSweep))
				return NIAlgorithmConvergenceStatusReason.InsufficientVerticalSweep;
			if (constant.IsEqualTo (NIAlgorithmConvergenceStatusReasonInsufficientMovement))
				return NIAlgorithmConvergenceStatusReason.InsufficientMovement;
			if (constant.IsEqualTo (NIAlgorithmConvergenceStatusReasonInsufficientLighting))
				return NIAlgorithmConvergenceStatusReason.InsufficientLighting;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::NearbyInteraction.NIAlgorithmConvergenceStatusReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NIAlgorithmConvergenceStatusReason GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::NearbyInteraction.NIAlgorithmConvergenceStatusReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NIAlgorithmConvergenceStatusReason? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::NearbyInteraction.NIAlgorithmConvergenceStatusReason" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NIAlgorithmConvergenceStatusReason[]? values)
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
		internal static NIAlgorithmConvergenceStatusReason[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NIAlgorithmConvergenceStatusReason> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
