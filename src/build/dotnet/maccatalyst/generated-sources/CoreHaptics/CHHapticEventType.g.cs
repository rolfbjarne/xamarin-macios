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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CHHapticEventType : int {
		HapticTransient = 0,
		HapticContinuous = 1,
		AudioContinuous = 2,
		AudioCustom = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreHaptics.CHHapticEventType" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CHHapticEventTypeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("CHHapticEventTypeHapticTransient", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventTypeHapticTransient {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventTypeHapticTransient", storage);
			}
		}
		[Field ("CHHapticEventTypeHapticContinuous", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventTypeHapticContinuous {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventTypeHapticContinuous", storage);
			}
		}
		[Field ("CHHapticEventTypeAudioContinuous", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventTypeAudioContinuous {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventTypeAudioContinuous", storage);
			}
		}
		[Field ("CHHapticEventTypeAudioCustom", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventTypeAudioCustom {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventTypeAudioCustom", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CHHapticEventType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CHHapticEventType.HapticTransient
				ptr = CHHapticEventTypeHapticTransient;
				break;
			case 1: // CHHapticEventType.HapticContinuous
				ptr = CHHapticEventTypeHapticContinuous;
				break;
			case 2: // CHHapticEventType.AudioContinuous
				ptr = CHHapticEventTypeAudioContinuous;
				break;
			case 3: // CHHapticEventType.AudioCustom
				ptr = CHHapticEventTypeAudioCustom;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CHHapticEventType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CHHapticEventTypeHapticTransient))
				return CHHapticEventType.HapticTransient;
			if (constant.IsEqualTo (CHHapticEventTypeHapticContinuous))
				return CHHapticEventType.HapticContinuous;
			if (constant.IsEqualTo (CHHapticEventTypeAudioContinuous))
				return CHHapticEventType.AudioContinuous;
			if (constant.IsEqualTo (CHHapticEventTypeAudioCustom))
				return CHHapticEventType.AudioCustom;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticEventType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticEventType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreHaptics.CHHapticEventType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CHHapticEventType[]? values)
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
		internal static CHHapticEventType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CHHapticEventType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
