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
	/// <summary>Contains constants that represent keys that identify predicate key paths for selecting HealthKit values.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class HKPredicateKeyPath  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Average;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathAverage'.</summary>
		[Field ("HKPredicateKeyPathAverage",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString Average {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_Average is null)
					_Average = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathAverage")!;
				return _Average;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageHeartRate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathAverageHeartRate'.</summary>
		[Field ("HKPredicateKeyPathAverageHeartRate",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AverageHeartRate {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AverageHeartRate is null)
					_AverageHeartRate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathAverageHeartRate")!;
				return _AverageHeartRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CategoryValue;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCategoryValue</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCategoryValue",  "HealthKit")]
		public static NSString CategoryValue {
			get {
				if (_CategoryValue is null)
					_CategoryValue = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCategoryValue")!;
				return _CategoryValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CdaAuthorName;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCDAAuthorName.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCDAAuthorName",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString CdaAuthorName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_CdaAuthorName is null)
					_CdaAuthorName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCDAAuthorName")!;
				return _CdaAuthorName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CdaCustodianName;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCDACustodianName.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCDACustodianName",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString CdaCustodianName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_CdaCustodianName is null)
					_CdaCustodianName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCDACustodianName")!;
				return _CdaCustodianName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CdaPatientName;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCDAPatientName.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCDAPatientName",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString CdaPatientName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_CdaPatientName is null)
					_CdaPatientName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCDAPatientName")!;
				return _CdaPatientName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CdaTitle;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCDATitle.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCDATitle",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString CdaTitle {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_CdaTitle is null)
					_CdaTitle = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCDATitle")!;
				return _CdaTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClinicalRecordFhirResourceIdentifier;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathClinicalRecordFHIRResourceIdentifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathClinicalRecordFHIRResourceIdentifier",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString ClinicalRecordFhirResourceIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_ClinicalRecordFhirResourceIdentifier is null)
					_ClinicalRecordFhirResourceIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathClinicalRecordFHIRResourceIdentifier")!;
				return _ClinicalRecordFhirResourceIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClinicalRecordFhirResourceType;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathClinicalRecordFHIRResourceType.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathClinicalRecordFHIRResourceType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString ClinicalRecordFhirResourceType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_ClinicalRecordFhirResourceType is null)
					_ClinicalRecordFhirResourceType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathClinicalRecordFHIRResourceType")!;
				return _ClinicalRecordFhirResourceType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Correlation;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathCorrelation</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathCorrelation",  "HealthKit")]
		public static NSString Correlation {
			get {
				if (_Correlation is null)
					_Correlation = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCorrelation")!;
				return _Correlation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateComponents;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathDateComponents.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathDateComponents",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString DateComponents {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_DateComponents is null)
					_DateComponents = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathDateComponents")!;
				return _DateComponents;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Device;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathDevice.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathDevice",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString Device {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_Device is null)
					_Device = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathDevice")!;
				return _Device;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EcgClassification;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathECGClassification'.</summary>
		[Field ("HKPredicateKeyPathECGClassification",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString EcgClassification {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_EcgClassification is null)
					_EcgClassification = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathECGClassification")!;
				return _EcgClassification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EcgSymptomsStatus;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathECGSymptomsStatus'.</summary>
		[Field ("HKPredicateKeyPathECGSymptomsStatus",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString EcgSymptomsStatus {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_EcgSymptomsStatus is null)
					_EcgSymptomsStatus = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathECGSymptomsStatus")!;
				return _EcgSymptomsStatus;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EndDate;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathEndDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathEndDate",  "HealthKit")]
		public static NSString EndDate {
			get {
				if (_EndDate is null)
					_EndDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathEndDate")!;
				return _EndDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LogOrigin;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathLogOrigin'.</summary>
		[Field ("HKPredicateKeyPathLogOrigin",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString LogOrigin {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_LogOrigin is null)
					_LogOrigin = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathLogOrigin")!;
				return _LogOrigin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Max;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMax'.</summary>
		[Field ("HKPredicateKeyPathMax",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString Max {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_Max is null)
					_Max = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMax")!;
				return _Max;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MedicationConceptIdentifier;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMedicationConceptIdentifier'.</summary>
		[Field ("HKPredicateKeyPathMedicationConceptIdentifier",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString MedicationConceptIdentifier {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_MedicationConceptIdentifier is null)
					_MedicationConceptIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMedicationConceptIdentifier")!;
				return _MedicationConceptIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Metadata;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathMetadata</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathMetadata",  "HealthKit")]
		public static NSString Metadata {
			get {
				if (_Metadata is null)
					_Metadata = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMetadata")!;
				return _Metadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Min;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMin'.</summary>
		[Field ("HKPredicateKeyPathMin",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString Min {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_Min is null)
					_Min = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMin")!;
				return _Min;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MostRecent;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMostRecent'.</summary>
		[Field ("HKPredicateKeyPathMostRecent",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MostRecent {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MostRecent is null)
					_MostRecent = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMostRecent")!;
				return _MostRecent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MostRecentDuration;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMostRecentDuration'.</summary>
		[Field ("HKPredicateKeyPathMostRecentDuration",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MostRecentDuration {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MostRecentDuration is null)
					_MostRecentDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMostRecentDuration")!;
				return _MostRecentDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MostRecentEndDate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMostRecentEndDate'.</summary>
		[Field ("HKPredicateKeyPathMostRecentEndDate",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MostRecentEndDate {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MostRecentEndDate is null)
					_MostRecentEndDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMostRecentEndDate")!;
				return _MostRecentEndDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MostRecentStartDate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathMostRecentStartDate'.</summary>
		[Field ("HKPredicateKeyPathMostRecentStartDate",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MostRecentStartDate {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MostRecentStartDate is null)
					_MostRecentStartDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathMostRecentStartDate")!;
				return _MostRecentStartDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathCount;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathCount'.</summary>
		[Field ("HKPredicateKeyPathCount",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString PathCount {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_PathCount is null)
					_PathCount = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathCount")!;
				return _PathCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathSum;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathSum.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathSum",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString PathSum {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_PathSum is null)
					_PathSum = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathSum")!;
				return _PathSum;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Quantity;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathQuantity</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathQuantity",  "HealthKit")]
		public static NSString Quantity {
			get {
				if (_Quantity is null)
					_Quantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathQuantity")!;
				return _Quantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScheduledDate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathScheduledDate'.</summary>
		[Field ("HKPredicateKeyPathScheduledDate",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString ScheduledDate {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_ScheduledDate is null)
					_ScheduledDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathScheduledDate")!;
				return _ScheduledDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Source;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathSource",  "HealthKit")]
		public static NSString Source {
			get {
				if (_Source is null)
					_Source = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathSource")!;
				return _Source;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceRevision;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathSourceRevision.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathSourceRevision",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SourceRevision {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SourceRevision is null)
					_SourceRevision = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathSourceRevision")!;
				return _SourceRevision;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StartDate;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathStartDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathStartDate",  "HealthKit")]
		public static NSString StartDate {
			get {
				if (_StartDate is null)
					_StartDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathStartDate")!;
				return _StartDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Status;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathStatus'.</summary>
		[Field ("HKPredicateKeyPathStatus",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString Status {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_Status is null)
					_Status = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathStatus")!;
				return _Status;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TotalFlightsClimbed;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutTotalFlightsClimbed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutTotalFlightsClimbed",  "HealthKit")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString TotalFlightsClimbed {
			[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
			[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
			[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.FlightsClimbed.")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_TotalFlightsClimbed is null)
					_TotalFlightsClimbed = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutTotalFlightsClimbed")!;
				return _TotalFlightsClimbed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Uuid;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathUUID</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathUUID",  "HealthKit")]
		public static NSString Uuid {
			get {
				if (_Uuid is null)
					_Uuid = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathUUID")!;
				return _Uuid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Workout;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkout</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkout",  "HealthKit")]
		public static NSString Workout {
			get {
				if (_Workout is null)
					_Workout = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkout")!;
				return _Workout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivity is null)
					_WorkoutActivity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivity")!;
				return _WorkoutActivity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityAverageQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityAverageQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityAverageQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityAverageQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityAverageQuantity is null)
					_WorkoutActivityAverageQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityAverageQuantity")!;
				return _WorkoutActivityAverageQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityDuration;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityDuration'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityDuration",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityDuration {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityDuration is null)
					_WorkoutActivityDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityDuration")!;
				return _WorkoutActivityDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityEndDate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityEndDate'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityEndDate",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityEndDate {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityEndDate is null)
					_WorkoutActivityEndDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityEndDate")!;
				return _WorkoutActivityEndDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityMaximumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityMaximumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityMaximumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityMaximumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityMaximumQuantity is null)
					_WorkoutActivityMaximumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityMaximumQuantity")!;
				return _WorkoutActivityMaximumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityMinimumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityMinimumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityMinimumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityMinimumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityMinimumQuantity is null)
					_WorkoutActivityMinimumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityMinimumQuantity")!;
				return _WorkoutActivityMinimumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityStartDate;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityStartDate'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityStartDate",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityStartDate {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityStartDate is null)
					_WorkoutActivityStartDate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityStartDate")!;
				return _WorkoutActivityStartDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivitySumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivitySumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivitySumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivitySumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivitySumQuantity is null)
					_WorkoutActivitySumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivitySumQuantity")!;
				return _WorkoutActivitySumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutActivityType;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutActivityType'.</summary>
		[Field ("HKPredicateKeyPathWorkoutActivityType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutActivityType {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutActivityType is null)
					_WorkoutActivityType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutActivityType")!;
				return _WorkoutActivityType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutAverageQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutAverageQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutAverageQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutAverageQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutAverageQuantity is null)
					_WorkoutAverageQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutAverageQuantity")!;
				return _WorkoutAverageQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutDuration;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutDuration</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutDuration",  "HealthKit")]
		public static NSString WorkoutDuration {
			get {
				if (_WorkoutDuration is null)
					_WorkoutDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutDuration")!;
				return _WorkoutDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutEffortRelationship;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutEffortRelationship'.</summary>
		[Field ("HKPredicateKeyPathWorkoutEffortRelationship",  "HealthKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutEffortRelationship {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutEffortRelationship is null)
					_WorkoutEffortRelationship = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutEffortRelationship")!;
				return _WorkoutEffortRelationship;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutMaximumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutMaximumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutMaximumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutMaximumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutMaximumQuantity is null)
					_WorkoutMaximumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutMaximumQuantity")!;
				return _WorkoutMaximumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutMinimumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutMinimumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutMinimumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutMinimumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutMinimumQuantity is null)
					_WorkoutMinimumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutMinimumQuantity")!;
				return _WorkoutMinimumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutSumQuantity;
		/// <summary>Represents the value associated with the constant 'HKPredicateKeyPathWorkoutSumQuantity'.</summary>
		[Field ("HKPredicateKeyPathWorkoutSumQuantity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutSumQuantity {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutSumQuantity is null)
					_WorkoutSumQuantity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutSumQuantity")!;
				return _WorkoutSumQuantity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutTotalDistance;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutTotalDistance</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutTotalDistance",  "HealthKit")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutTotalDistance {
			[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
			[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
			[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for the desired distance type.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutTotalDistance is null)
					_WorkoutTotalDistance = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutTotalDistance")!;
				return _WorkoutTotalDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutTotalEnergyBurned;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutTotalEnergyBurned</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutTotalEnergyBurned",  "HealthKit")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutTotalEnergyBurned {
			[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
			[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
			[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.ActiveEnergyBurned.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutTotalEnergyBurned is null)
					_WorkoutTotalEnergyBurned = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutTotalEnergyBurned")!;
				return _WorkoutTotalEnergyBurned;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutTotalSwimmingStrokeCount;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutTotalSwimmingStrokeCount.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutTotalSwimmingStrokeCount",  "HealthKit")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString WorkoutTotalSwimmingStrokeCount {
			[ObsoletedOSPlatform ("ios18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
			[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
			[ObsoletedOSPlatform ("macos15.0", "Use 'HKQuery.GetSumQuantityPredicateForWorkoutActivities' instead, passing the HKQuantityType for HKQuantityTypeIdentifier.SwimmingStrokeCount.")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_WorkoutTotalSwimmingStrokeCount is null)
					_WorkoutTotalSwimmingStrokeCount = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutTotalSwimmingStrokeCount")!;
				return _WorkoutTotalSwimmingStrokeCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutType;
		/// <summary>Represents the value associated with the constant HKPredicateKeyPathWorkoutType</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKPredicateKeyPathWorkoutType",  "HealthKit")]
		public static NSString WorkoutType {
			get {
				if (_WorkoutType is null)
					_WorkoutType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKPredicateKeyPathWorkoutType")!;
				return _WorkoutType;
			}
		}
	} /* class HKPredicateKeyPath */
}
