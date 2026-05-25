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
namespace MapKit {
	/// <summary>An enumeration of travel methods for which directions can be provided.</summary>&gt;
	/// 
	public enum MKDirectionsMode : int {
		/// <summary>Driving directions.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		Driving = 0,
		/// <summary>Walking directions.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		Walking = 1,
		/// <summary>Transit directions.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		Transit = 2,
		/// <summary>Cycling directions.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		Default = 3,
		/// <summary>The user's preferred direction type.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Cycling = 4,
	}
	/// <summary>Extension methods for the <see cref="global::MapKit.MKDirectionsMode" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MKDirectionsModeExtensions {
		static IntPtr[] values = new IntPtr [5];
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("MKLaunchOptionsDirectionsModeDriving", "MapKit")]
		internal unsafe static IntPtr MKLaunchOptionsDirectionsModeDriving {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeDriving", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("MKLaunchOptionsDirectionsModeWalking", "MapKit")]
		internal unsafe static IntPtr MKLaunchOptionsDirectionsModeWalking {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeWalking", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("MKLaunchOptionsDirectionsModeTransit", "MapKit")]
		internal unsafe static IntPtr MKLaunchOptionsDirectionsModeTransit {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeTransit", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("MKLaunchOptionsDirectionsModeDefault", "MapKit")]
		internal unsafe static IntPtr MKLaunchOptionsDirectionsModeDefault {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeDefault", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("MKLaunchOptionsDirectionsModeCycling", "MapKit")]
		internal unsafe static IntPtr MKLaunchOptionsDirectionsModeCycling {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKLaunchOptionsDirectionsModeCycling", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this MKDirectionsMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // MKDirectionsMode.Driving
				ptr = MKLaunchOptionsDirectionsModeDriving;
				break;
			case 1: // MKDirectionsMode.Walking
				ptr = MKLaunchOptionsDirectionsModeWalking;
				break;
			case 2: // MKDirectionsMode.Transit
				ptr = MKLaunchOptionsDirectionsModeTransit;
				break;
			case 3: // MKDirectionsMode.Default
				ptr = MKLaunchOptionsDirectionsModeDefault;
				break;
			case 4: // MKDirectionsMode.Cycling
				ptr = MKLaunchOptionsDirectionsModeCycling;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKDirectionsMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static MKDirectionsMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (MKLaunchOptionsDirectionsModeDriving))
				return MKDirectionsMode.Driving;
			if (constant.IsEqualTo (MKLaunchOptionsDirectionsModeWalking))
				return MKDirectionsMode.Walking;
			if (constant.IsEqualTo (MKLaunchOptionsDirectionsModeTransit))
				return MKDirectionsMode.Transit;
			if (constant.IsEqualTo (MKLaunchOptionsDirectionsModeDefault))
				return MKDirectionsMode.Default;
			if (constant.IsEqualTo (MKLaunchOptionsDirectionsModeCycling))
				return MKDirectionsMode.Cycling;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKDirectionsMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MKDirectionsMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKDirectionsMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MKDirectionsMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::MapKit.MKDirectionsMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this MKDirectionsMode[]? values)
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
		internal static MKDirectionsMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<MKDirectionsMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
