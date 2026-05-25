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
	/// <summary>Enumerates clinical record type identifiers.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKClinicalTypeIdentifier : int {
		/// <summary>Indicates an allergy record.</summary>
		AllergyRecord = 0,
		/// <summary>Indicates a record for a medical condition.</summary>
		ConditionRecord = 1,
		/// <summary>Indicates an immunization record.</summary>
		ImmunizationRecord = 2,
		/// <summary>Indicates a lab result record.</summary>
		LabResultRecord = 3,
		/// <summary>Indicates a record of medication</summary>
		MedicationRecord = 4,
		/// <summary>Indicates a record of a procedure.</summary>
		ProcedureRecord = 5,
		/// <summary>Indicates a record of a vital sign.</summary>
		VitalSignRecord = 6,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		CoverageRecord = 7,
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		ClinicalNoteRecord = 8,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKClinicalTypeIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKClinicalTypeIdentifierExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("HKClinicalTypeIdentifierAllergyRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierAllergyRecord {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierAllergyRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierConditionRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierConditionRecord {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierConditionRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierImmunizationRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierImmunizationRecord {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierImmunizationRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierLabResultRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierLabResultRecord {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierLabResultRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierMedicationRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierMedicationRecord {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierMedicationRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierProcedureRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierProcedureRecord {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierProcedureRecord", storage);
			}
		}
		[Field ("HKClinicalTypeIdentifierVitalSignRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierVitalSignRecord {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierVitalSignRecord", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKClinicalTypeIdentifierCoverageRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierCoverageRecord {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierCoverageRecord", storage);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[Field ("HKClinicalTypeIdentifierClinicalNoteRecord", "HealthKit")]
		internal unsafe static IntPtr HKClinicalTypeIdentifierClinicalNoteRecord {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKClinicalTypeIdentifierClinicalNoteRecord", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKClinicalTypeIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKClinicalTypeIdentifier.AllergyRecord
				ptr = HKClinicalTypeIdentifierAllergyRecord;
				break;
			case 1: // HKClinicalTypeIdentifier.ConditionRecord
				ptr = HKClinicalTypeIdentifierConditionRecord;
				break;
			case 2: // HKClinicalTypeIdentifier.ImmunizationRecord
				ptr = HKClinicalTypeIdentifierImmunizationRecord;
				break;
			case 3: // HKClinicalTypeIdentifier.LabResultRecord
				ptr = HKClinicalTypeIdentifierLabResultRecord;
				break;
			case 4: // HKClinicalTypeIdentifier.MedicationRecord
				ptr = HKClinicalTypeIdentifierMedicationRecord;
				break;
			case 5: // HKClinicalTypeIdentifier.ProcedureRecord
				ptr = HKClinicalTypeIdentifierProcedureRecord;
				break;
			case 6: // HKClinicalTypeIdentifier.VitalSignRecord
				ptr = HKClinicalTypeIdentifierVitalSignRecord;
				break;
			case 7: // HKClinicalTypeIdentifier.CoverageRecord
				ptr = HKClinicalTypeIdentifierCoverageRecord;
				break;
			case 8: // HKClinicalTypeIdentifier.ClinicalNoteRecord
				ptr = HKClinicalTypeIdentifierClinicalNoteRecord;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKClinicalTypeIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKClinicalTypeIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKClinicalTypeIdentifierAllergyRecord))
				return HKClinicalTypeIdentifier.AllergyRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierConditionRecord))
				return HKClinicalTypeIdentifier.ConditionRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierImmunizationRecord))
				return HKClinicalTypeIdentifier.ImmunizationRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierLabResultRecord))
				return HKClinicalTypeIdentifier.LabResultRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierMedicationRecord))
				return HKClinicalTypeIdentifier.MedicationRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierProcedureRecord))
				return HKClinicalTypeIdentifier.ProcedureRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierVitalSignRecord))
				return HKClinicalTypeIdentifier.VitalSignRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierCoverageRecord))
				return HKClinicalTypeIdentifier.CoverageRecord;
			if (constant.IsEqualTo (HKClinicalTypeIdentifierClinicalNoteRecord))
				return HKClinicalTypeIdentifier.ClinicalNoteRecord;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKClinicalTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKClinicalTypeIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKClinicalTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKClinicalTypeIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKClinicalTypeIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKClinicalTypeIdentifier[]? values)
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
		internal static HKClinicalTypeIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKClinicalTypeIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
