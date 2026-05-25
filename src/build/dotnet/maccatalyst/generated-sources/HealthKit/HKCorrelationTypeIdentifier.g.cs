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
namespace HealthKit {
	/// <summary>Contains constants that identify HealthKit correlation types.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKCorrelationTypeIdentifier : int {
		/// <summary>The correlation contains diastolic and systolic blood pressure readings.</summary>
		BloodPressure = 0,
		/// <summary>The correlation contains data about food items.</summary>
		Food = 1,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKCorrelationTypeIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKCorrelationTypeIdentifierExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("HKCorrelationTypeIdentifierBloodPressure", "HealthKit")]
		internal unsafe static IntPtr HKCorrelationTypeIdentifierBloodPressure {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCorrelationTypeIdentifierBloodPressure", storage);
			}
		}
		[Field ("HKCorrelationTypeIdentifierFood", "HealthKit")]
		internal unsafe static IntPtr HKCorrelationTypeIdentifierFood {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCorrelationTypeIdentifierFood", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKCorrelationTypeIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKCorrelationTypeIdentifier.BloodPressure
				ptr = HKCorrelationTypeIdentifierBloodPressure;
				break;
			case 1: // HKCorrelationTypeIdentifier.Food
				ptr = HKCorrelationTypeIdentifierFood;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCorrelationTypeIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKCorrelationTypeIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKCorrelationTypeIdentifierBloodPressure))
				return HKCorrelationTypeIdentifier.BloodPressure;
			if (constant.IsEqualTo (HKCorrelationTypeIdentifierFood))
				return HKCorrelationTypeIdentifier.Food;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCorrelationTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCorrelationTypeIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCorrelationTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCorrelationTypeIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKCorrelationTypeIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKCorrelationTypeIdentifier[]? values)
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
		internal static HKCorrelationTypeIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKCorrelationTypeIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
