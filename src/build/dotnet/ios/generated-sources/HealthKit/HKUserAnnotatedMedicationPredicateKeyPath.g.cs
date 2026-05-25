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
namespace HealthKit {
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum HKUserAnnotatedMedicationPredicateKeyPath : int {
		IsArchived = 0,
		HasSchedule = 1,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKUserAnnotatedMedicationPredicateKeyPath" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKUserAnnotatedMedicationPredicateKeyPathExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("HKUserAnnotatedMedicationPredicateKeyPathIsArchived", "HealthKit")]
		internal unsafe static IntPtr HKUserAnnotatedMedicationPredicateKeyPathIsArchived {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKUserAnnotatedMedicationPredicateKeyPathIsArchived", storage);
			}
		}
		[Field ("HKUserAnnotatedMedicationPredicateKeyPathHasSchedule", "HealthKit")]
		internal unsafe static IntPtr HKUserAnnotatedMedicationPredicateKeyPathHasSchedule {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKUserAnnotatedMedicationPredicateKeyPathHasSchedule", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKUserAnnotatedMedicationPredicateKeyPath self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKUserAnnotatedMedicationPredicateKeyPath.IsArchived
				ptr = HKUserAnnotatedMedicationPredicateKeyPathIsArchived;
				break;
			case 1: // HKUserAnnotatedMedicationPredicateKeyPath.HasSchedule
				ptr = HKUserAnnotatedMedicationPredicateKeyPathHasSchedule;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKUserAnnotatedMedicationPredicateKeyPath" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKUserAnnotatedMedicationPredicateKeyPath GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKUserAnnotatedMedicationPredicateKeyPathIsArchived))
				return HKUserAnnotatedMedicationPredicateKeyPath.IsArchived;
			if (constant.IsEqualTo (HKUserAnnotatedMedicationPredicateKeyPathHasSchedule))
				return HKUserAnnotatedMedicationPredicateKeyPath.HasSchedule;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKUserAnnotatedMedicationPredicateKeyPath" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKUserAnnotatedMedicationPredicateKeyPath GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKUserAnnotatedMedicationPredicateKeyPath" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKUserAnnotatedMedicationPredicateKeyPath? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKUserAnnotatedMedicationPredicateKeyPath" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKUserAnnotatedMedicationPredicateKeyPath[]? values)
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
		internal static HKUserAnnotatedMedicationPredicateKeyPath[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKUserAnnotatedMedicationPredicateKeyPath> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
