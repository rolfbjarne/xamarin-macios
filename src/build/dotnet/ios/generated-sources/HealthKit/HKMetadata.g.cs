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
	/// <summary>A key-value store for various types of health-related metadata.</summary>
	public partial class HKMetadata : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="HKMetadata" /> with default (empty) values.</summary>
		public HKMetadata () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="HKMetadata" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public HKMetadata (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the food type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? FoodType {
			get {
				return GetStringValue (HKMetadataKey.FoodType!);
			}
			set {
				SetStringValue (HKMetadataKey.FoodType!, value);
			}
		}
		/// <summary>Gets or set the UDI unique device identifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? UdiDeviceIdentifier {
			get {
				return GetStringValue (HKMetadataKey.UdiDeviceIdentifier!);
			}
			set {
				SetStringValue (HKMetadataKey.UdiDeviceIdentifier!, value);
			}
		}
		/// <summary>Gets or sets the UDI production identifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? UdiProductionIdentifier {
			get {
				return GetStringValue (HKMetadataKey.UdiProductionIdentifier!);
			}
			set {
				SetStringValue (HKMetadataKey.UdiProductionIdentifier!, value);
			}
		}
		/// <summary>Gets or sets the digital signature.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DigitalSignature {
			get {
				return GetStringValue (HKMetadataKey.DigitalSignature!);
			}
			set {
				SetStringValue (HKMetadataKey.DigitalSignature!, value);
			}
		}
		/// <summary>Gets or sets the external UUID.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? ExternalUuid {
			get {
				return GetStringValue (HKMetadataKey.ExternalUuid!);
			}
			set {
				SetStringValue (HKMetadataKey.ExternalUuid!, value);
			}
		}
		/// <summary>Gets or sets the device serial number.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DeviceSerialNumber {
			get {
				return GetStringValue (HKMetadataKey.DeviceSerialNumber!);
			}
			set {
				SetStringValue (HKMetadataKey.DeviceSerialNumber!, value);
			}
		}
		/// <summary>Gets or sets the body temperature sensor location.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public HKBodyTemperatureSensorLocation? BodyTemperatureSensorLocation {
			get {
				return (HKBodyTemperatureSensorLocation?) (long?) GetNIntValue (HKMetadataKey.BodyTemperatureSensorLocation!);
			}
			set {
				SetNumberValue (HKMetadataKey.BodyTemperatureSensorLocation!, (System.Int64?)value);
			}
		}
		/// <summary>Gets or sets the heart rate sensor location.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public HKHeartRateSensorLocation? HeartRateSensorLocation {
			get {
				return (HKHeartRateSensorLocation?) (long?) GetNIntValue (HKMetadataKey.HeartRateSensorLocation!);
			}
			set {
				SetNumberValue (HKMetadataKey.HeartRateSensorLocation!, (System.Int64?)value);
			}
		}
		/// <summary>Gets or sets the time zone.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSTimeZone? TimeZone {
			get {
				return Dictionary [HKMetadataKey.TimeZone!] as Foundation.NSTimeZone;
			}
			set {
				SetNativeValue (HKMetadataKey.TimeZone!, value);
			}
		}
		/// <summary>Gets or sets the device name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DeviceName {
			get {
				return GetStringValue (HKMetadataKey.DeviceName!);
			}
			set {
				SetStringValue (HKMetadataKey.DeviceName!, value);
			}
		}
		/// <summary>Gets or sets the device manufacturer name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DeviceManufacturerName {
			get {
				return GetStringValue (HKMetadataKey.DeviceManufacturerName!);
			}
			set {
				SetStringValue (HKMetadataKey.DeviceManufacturerName!, value);
			}
		}
		/// <summary>Gets or sets a value that indicates whether a measurement was taken in a lab.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? WasTakenInLab {
			get {
				return  GetBoolValue (HKMetadataKey.WasTakenInLab!);
			}
			set {
				SetBooleanValue (HKMetadataKey.WasTakenInLab!, value);
			}
		}
		/// <summary>Gets or sets the lower limit of the reference range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? ReferenceRangeLowerLimit {
			get {
				return Dictionary [HKMetadataKey.ReferenceRangeLowerLimit!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (HKMetadataKey.ReferenceRangeLowerLimit!, value);
			}
		}
		/// <summary>Gets or sets the upper limit of the reference range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? ReferenceRangeUpperLimit {
			get {
				return Dictionary [HKMetadataKey.ReferenceRangeUpperLimit!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (HKMetadataKey.ReferenceRangeUpperLimit!, value);
			}
		}
		/// <summary>Gets or sets a value that indicates whether a measurement was entered by the user.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? WasUserEntered {
			get {
				return  GetBoolValue (HKMetadataKey.WasUserEntered!);
			}
			set {
				SetBooleanValue (HKMetadataKey.WasUserEntered!, value);
			}
		}
		/// <summary>Gets or sets the brand name of the workout.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? WorkoutBrandName {
			get {
				return GetStringValue (HKMetadataKey.WorkoutBrandName!);
			}
			set {
				SetStringValue (HKMetadataKey.WorkoutBrandName!, value);
			}
		}
		/// <summary>Gets or sets a value that indicates whether the activity was a group fitness activity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? GroupFitness {
			get {
				return  GetBoolValue (HKMetadataKey.GroupFitness!);
			}
			set {
				SetBooleanValue (HKMetadataKey.GroupFitness!, value);
			}
		}
		/// <summary>Gets or sets a value that indicates whether the workout takes place indoors.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? IndoorWorkout {
			get {
				return  GetBoolValue (HKMetadataKey.IndoorWorkout!);
			}
			set {
				SetBooleanValue (HKMetadataKey.IndoorWorkout!, value);
			}
		}
		/// <summary>Gets or sets a value that indicates whether the workout was coached.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? CoachedWorkout {
			get {
				return  GetBoolValue (HKMetadataKey.CoachedWorkout!);
			}
			set {
				SetBooleanValue (HKMetadataKey.CoachedWorkout!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public bool? SexualActivityProtectionUsed {
			get {
				return  GetBoolValue (HKMetadataKey.SexualActivityProtectionUsed!);
			}
			set {
				SetBooleanValue (HKMetadataKey.SexualActivityProtectionUsed!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public bool? MenstrualCycleStart {
			get {
				return  GetBoolValue (HKMetadataKey.MenstrualCycleStart!);
			}
			set {
				SetBooleanValue (HKMetadataKey.MenstrualCycleStart!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKWeatherCondition? WeatherCondition {
			get {
				return (HKWeatherCondition?) (long?) GetNIntValue (HKMetadataKey.WeatherCondition!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? WeatherTemperature {
			get {
				return Dictionary [HKMetadataKey.WeatherTemperature!] as HealthKit.HKQuantity;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? WeatherHumidity {
			get {
				return Dictionary [HKMetadataKey.WeatherHumidity!] as HealthKit.HKQuantity;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public NSString? LapLength {
			get {
				return GetNSStringValue (HKMetadataKey.LapLength!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public NSString? SwimmingLocationType {
			get {
				return GetNSStringValue (HKMetadataKey.SwimmingLocationType!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public NSString? SwimmingStrokeStyle {
			get {
				return GetNSStringValue (HKMetadataKey.SwimmingStrokeStyle!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public string? SyncIdentifier {
			get {
				return GetStringValue (HKMetadataKey.SyncIdentifier!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public int? SyncVersion {
			get {
				return  GetInt32Value (HKMetadataKey.SyncVersion!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKInsulinDeliveryReason? InsulinDeliveryReason {
			get {
				return (HKInsulinDeliveryReason?) (long?) GetNIntValue (HKMetadataKey.InsulinDeliveryReason!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKBloodGlucoseMealTime? BloodGlucoseMealTime {
			get {
				return (HKBloodGlucoseMealTime?) (long?) GetNIntValue (HKMetadataKey.BloodGlucoseMealTime!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKVO2MaxTestType? VO2MaxTestType {
			get {
				return (HKVO2MaxTestType?) (long?) GetNIntValue (HKMetadataKey.VO2MaxTestType!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKHeartRateMotionContext? HeartRateMotionContext {
			get {
				return (HKHeartRateMotionContext?) (long?) GetNIntValue (HKMetadataKey.HeartRateMotionContext!);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? AverageSpeed {
			get {
				return Dictionary [HKMetadataKey.AverageSpeed!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.AverageSpeed!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? MaximumSpeed {
			get {
				return Dictionary [HKMetadataKey.MaximumSpeed!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.MaximumSpeed!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? AlpineSlopeGrade {
			get {
				return Dictionary [HKMetadataKey.AlpineSlopeGrade!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.AlpineSlopeGrade!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? ElevationAscended {
			get {
				return Dictionary [HKMetadataKey.ElevationAscended!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.ElevationAscended!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? ElevationDescended {
			get {
				return Dictionary [HKMetadataKey.ElevationDescended!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.ElevationDescended!, value);
			}
		}
		/// <summary>Gets or sets the length of time spent on a fitness machine.</summary><value>The length of time spent on a fitness machine.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? FitnessMachineDuration {
			get {
				return Dictionary [HKMetadataKey.FitnessMachineDuration!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.FitnessMachineDuration!, value);
			}
		}
		/// <summary>Gets or sets the distance traveled on an indoor bike.</summary><value>The distance traveled on an indoor bike.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? IndoorBikeDistance {
			get {
				return Dictionary [HKMetadataKey.IndoorBikeDistance!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.IndoorBikeDistance!, value);
			}
		}
		/// <summary>Gets or sets the distance traveled on a cross trainer.</summary><value>The distance traveled on a cross trainer.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? CrossTrainerDistance {
			get {
				return Dictionary [HKMetadataKey.CrossTrainerDistance!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.CrossTrainerDistance!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public HKQuantity? HeartRateEventThreshold {
			get {
				return Dictionary [HKMetadataKey.HeartRateEventThreshold!] as HealthKit.HKQuantity;
			}
			set {
				SetNativeValue (HKMetadataKey.HeartRateEventThreshold!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		public string? AppleFitnessPlusCatalogIdentifier {
			get {
				return GetStringValue (HKMetadataKey.AppleFitnessPlusCatalogIdentifier!);
			}
			set {
				SetStringValue (HKMetadataKey.AppleFitnessPlusCatalogIdentifier!, value);
			}
		}
#endif
	}
}
