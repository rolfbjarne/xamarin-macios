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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
	/// <summary>Enumerates Fast Healthcare Interoperability Resources (FHIR) types.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKFhirResourceType : int {
		/// <summary>Indicates allergy or intolerance information.</summary>
		AllergyIntolerance = 0,
		/// <summary>Indicates medical condition information.</summary>
		Condition = 1,
		/// <summary>Indicates immunization information.</summary>
		Immunization = 2,
		/// <summary>Indicates information about dispensed or delivered medications.</summary>
		MedicationDispense = 3,
		/// <summary>Indicates information about ordered medications</summary>
		MedicationOrder = 4,
		/// <summary>Indicates information about patient statements of medication taken.</summary>
		MedicationStatement = 5,
		/// <summary>Indicates information about a medical observation.</summary>
		Observation = 6,
		/// <summary>Indicates information about a procedure performed.</summary>
		Procedure = 7,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		MedicationRequest = 8,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Coverage = 9,
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		DiagnosticReport = 10,
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		DocumentReference = 11,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKFhirResourceType" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKFhirResourceTypeExtensions {
		static IntPtr[] values = new IntPtr [12];
		[Field ("HKFHIRResourceTypeAllergyIntolerance", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeAllergyIntolerance {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeAllergyIntolerance", storage);
			}
		}
		[Field ("HKFHIRResourceTypeCondition", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeCondition {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeCondition", storage);
			}
		}
		[Field ("HKFHIRResourceTypeImmunization", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeImmunization {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeImmunization", storage);
			}
		}
		[Field ("HKFHIRResourceTypeMedicationDispense", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeMedicationDispense {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeMedicationDispense", storage);
			}
		}
		[Field ("HKFHIRResourceTypeMedicationOrder", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeMedicationOrder {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeMedicationOrder", storage);
			}
		}
		[Field ("HKFHIRResourceTypeMedicationStatement", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeMedicationStatement {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeMedicationStatement", storage);
			}
		}
		[Field ("HKFHIRResourceTypeObservation", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeObservation {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeObservation", storage);
			}
		}
		[Field ("HKFHIRResourceTypeProcedure", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeProcedure {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeProcedure", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKFHIRResourceTypeMedicationRequest", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeMedicationRequest {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeMedicationRequest", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKFHIRResourceTypeCoverage", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeCoverage {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeCoverage", storage);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[Field ("HKFHIRResourceTypeDiagnosticReport", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeDiagnosticReport {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeDiagnosticReport", storage);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[Field ("HKFHIRResourceTypeDocumentReference", "HealthKit")]
		internal unsafe static IntPtr HKFHIRResourceTypeDocumentReference {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKFHIRResourceTypeDocumentReference", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKFhirResourceType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKFhirResourceType.AllergyIntolerance
				ptr = HKFHIRResourceTypeAllergyIntolerance;
				break;
			case 1: // HKFhirResourceType.Condition
				ptr = HKFHIRResourceTypeCondition;
				break;
			case 2: // HKFhirResourceType.Immunization
				ptr = HKFHIRResourceTypeImmunization;
				break;
			case 3: // HKFhirResourceType.MedicationDispense
				ptr = HKFHIRResourceTypeMedicationDispense;
				break;
			case 4: // HKFhirResourceType.MedicationOrder
				ptr = HKFHIRResourceTypeMedicationOrder;
				break;
			case 5: // HKFhirResourceType.MedicationStatement
				ptr = HKFHIRResourceTypeMedicationStatement;
				break;
			case 6: // HKFhirResourceType.Observation
				ptr = HKFHIRResourceTypeObservation;
				break;
			case 7: // HKFhirResourceType.Procedure
				ptr = HKFHIRResourceTypeProcedure;
				break;
			case 8: // HKFhirResourceType.MedicationRequest
				ptr = HKFHIRResourceTypeMedicationRequest;
				break;
			case 9: // HKFhirResourceType.Coverage
				ptr = HKFHIRResourceTypeCoverage;
				break;
			case 10: // HKFhirResourceType.DiagnosticReport
				ptr = HKFHIRResourceTypeDiagnosticReport;
				break;
			case 11: // HKFhirResourceType.DocumentReference
				ptr = HKFHIRResourceTypeDocumentReference;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKFhirResourceType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKFhirResourceType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKFHIRResourceTypeAllergyIntolerance))
				return HKFhirResourceType.AllergyIntolerance;
			if (constant.IsEqualTo (HKFHIRResourceTypeCondition))
				return HKFhirResourceType.Condition;
			if (constant.IsEqualTo (HKFHIRResourceTypeImmunization))
				return HKFhirResourceType.Immunization;
			if (constant.IsEqualTo (HKFHIRResourceTypeMedicationDispense))
				return HKFhirResourceType.MedicationDispense;
			if (constant.IsEqualTo (HKFHIRResourceTypeMedicationOrder))
				return HKFhirResourceType.MedicationOrder;
			if (constant.IsEqualTo (HKFHIRResourceTypeMedicationStatement))
				return HKFhirResourceType.MedicationStatement;
			if (constant.IsEqualTo (HKFHIRResourceTypeObservation))
				return HKFhirResourceType.Observation;
			if (constant.IsEqualTo (HKFHIRResourceTypeProcedure))
				return HKFhirResourceType.Procedure;
			if (constant.IsEqualTo (HKFHIRResourceTypeMedicationRequest))
				return HKFhirResourceType.MedicationRequest;
			if (constant.IsEqualTo (HKFHIRResourceTypeCoverage))
				return HKFhirResourceType.Coverage;
			if (constant.IsEqualTo (HKFHIRResourceTypeDiagnosticReport))
				return HKFhirResourceType.DiagnosticReport;
			if (constant.IsEqualTo (HKFHIRResourceTypeDocumentReference))
				return HKFhirResourceType.DocumentReference;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKFhirResourceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKFhirResourceType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKFhirResourceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKFhirResourceType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKFhirResourceType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKFhirResourceType[]? values)
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
		internal static HKFhirResourceType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKFhirResourceType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
