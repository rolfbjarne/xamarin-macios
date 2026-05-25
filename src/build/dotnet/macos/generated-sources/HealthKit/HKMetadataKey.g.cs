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
	/// <summary>Defines the keys in the <see cref="T:HealthKit.HKMetadata" /> key-value dictionary.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class HKMetadataKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlgorithmVersion;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAlgorithmVersion'.</summary>
		[Field ("HKMetadataKeyAlgorithmVersion",  "HealthKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AlgorithmVersion {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AlgorithmVersion is null)
					_AlgorithmVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAlgorithmVersion")!;
				return _AlgorithmVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlpineSlopeGrade;
		/// <summary>Represents the value associated with the constant HKMetadataKeyAlpineSlopeGrade.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyAlpineSlopeGrade",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AlpineSlopeGrade {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AlpineSlopeGrade is null)
					_AlpineSlopeGrade = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAlpineSlopeGrade")!;
				return _AlpineSlopeGrade;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleDeviceCalibrated;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAppleDeviceCalibrated'.</summary>
		[Field ("HKMetadataKeyAppleDeviceCalibrated",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AppleDeviceCalibrated {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AppleDeviceCalibrated is null)
					_AppleDeviceCalibrated = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAppleDeviceCalibrated")!;
				return _AppleDeviceCalibrated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleEcgAlgorithmVersion;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAppleECGAlgorithmVersion'.</summary>
		[Field ("HKMetadataKeyAppleECGAlgorithmVersion",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AppleEcgAlgorithmVersion {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AppleEcgAlgorithmVersion is null)
					_AppleEcgAlgorithmVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAppleECGAlgorithmVersion")!;
				return _AppleEcgAlgorithmVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleFitnessPlusCatalogIdentifier;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAppleFitnessPlusCatalogIdentifier'.</summary>
		[Field ("HKMetadataKeyAppleFitnessPlusCatalogIdentifier",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		public static NSString AppleFitnessPlusCatalogIdentifier {
			[SupportedOSPlatform ("maccatalyst18.2")]
			[SupportedOSPlatform ("macos15.2")]
			[SupportedOSPlatform ("ios18.2")]
			get {
				if (_AppleFitnessPlusCatalogIdentifier is null)
					_AppleFitnessPlusCatalogIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAppleFitnessPlusCatalogIdentifier")!;
				return _AppleFitnessPlusCatalogIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleFitnessPlusSession;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAppleFitnessPlusSession'.</summary>
		[Field ("HKMetadataKeyAppleFitnessPlusSession",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString AppleFitnessPlusSession {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_AppleFitnessPlusSession is null)
					_AppleFitnessPlusSession = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAppleFitnessPlusSession")!;
				return _AppleFitnessPlusSession;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioExposureDuration;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAudioExposureDuration'.</summary>
		[Field ("HKMetadataKeyAudioExposureDuration",  "HealthKit")]
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AudioExposureDuration {
			[SupportedOSPlatform ("ios14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AudioExposureDuration is null)
					_AudioExposureDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAudioExposureDuration")!;
				return _AudioExposureDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioExposureLevel;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAudioExposureLevel'.</summary>
		[Field ("HKMetadataKeyAudioExposureLevel",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AudioExposureLevel {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AudioExposureLevel is null)
					_AudioExposureLevel = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAudioExposureLevel")!;
				return _AudioExposureLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageMets;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyAverageMETs'.</summary>
		[Field ("HKMetadataKeyAverageMETs",  "HealthKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AverageMets {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AverageMets is null)
					_AverageMets = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAverageMETs")!;
				return _AverageMets;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageSpeed;
		/// <summary>Represents the value associated with the constant HKMetadataKeyAverageSpeed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyAverageSpeed",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString AverageSpeed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_AverageSpeed is null)
					_AverageSpeed = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyAverageSpeed")!;
				return _AverageSpeed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BarometricPressure;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyBarometricPressure'.</summary>
		[Field ("HKMetadataKeyBarometricPressure",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString BarometricPressure {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_BarometricPressure is null)
					_BarometricPressure = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyBarometricPressure")!;
				return _BarometricPressure;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BloodGlucoseMealTime;
		/// <summary>Represents the value associated with the constant HKMetadataKeyBloodGlucoseMealTime.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyBloodGlucoseMealTime",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString BloodGlucoseMealTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_BloodGlucoseMealTime is null)
					_BloodGlucoseMealTime = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyBloodGlucoseMealTime")!;
				return _BloodGlucoseMealTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BodyTemperatureSensorLocation;
		/// <summary>Represents the value associated with the constant HKMetadataKeyBodyTemperatureSensorLocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyBodyTemperatureSensorLocation",  "HealthKit")]
		public static NSString BodyTemperatureSensorLocation {
			get {
				if (_BodyTemperatureSensorLocation is null)
					_BodyTemperatureSensorLocation = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyBodyTemperatureSensorLocation")!;
				return _BodyTemperatureSensorLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoachedWorkout;
		/// <summary>Represents the value associated with the constant HKMetadataKeyCoachedWorkout</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyCoachedWorkout",  "HealthKit")]
		public static NSString CoachedWorkout {
			get {
				if (_CoachedWorkout is null)
					_CoachedWorkout = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyCoachedWorkout")!;
				return _CoachedWorkout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CrossTrainerDistance;
		/// <summary>Represents the value associated with the constant HKMetadataKeyCrossTrainerDistance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyCrossTrainerDistance",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString CrossTrainerDistance {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_CrossTrainerDistance is null)
					_CrossTrainerDistance = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyCrossTrainerDistance")!;
				return _CrossTrainerDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CyclingFunctionalThresholdPowerTestType;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyCyclingFunctionalThresholdPowerTestType'.</summary>
		[Field ("HKMetadataKeyCyclingFunctionalThresholdPowerTestType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString CyclingFunctionalThresholdPowerTestType {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_CyclingFunctionalThresholdPowerTestType is null)
					_CyclingFunctionalThresholdPowerTestType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyCyclingFunctionalThresholdPowerTestType")!;
				return _CyclingFunctionalThresholdPowerTestType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateOfEarliestDataUsedForEstimate;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyDateOfEarliestDataUsedForEstimate'.</summary>
		[Field ("HKMetadataKeyDateOfEarliestDataUsedForEstimate",  "HealthKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString DateOfEarliestDataUsedForEstimate {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_DateOfEarliestDataUsedForEstimate is null)
					_DateOfEarliestDataUsedForEstimate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDateOfEarliestDataUsedForEstimate")!;
				return _DateOfEarliestDataUsedForEstimate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceManufacturerName;
		/// <summary>Represents the value associated with the constant HKMetadataKeyDeviceManufacturerName</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyDeviceManufacturerName",  "HealthKit")]
		public static NSString DeviceManufacturerName {
			get {
				if (_DeviceManufacturerName is null)
					_DeviceManufacturerName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDeviceManufacturerName")!;
				return _DeviceManufacturerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceName;
		/// <summary>Represents the value associated with the constant HKMetadataKeyDeviceName</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyDeviceName",  "HealthKit")]
		public static NSString DeviceName {
			get {
				if (_DeviceName is null)
					_DeviceName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDeviceName")!;
				return _DeviceName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DevicePlacementSide;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyDevicePlacementSide'.</summary>
		[Field ("HKMetadataKeyDevicePlacementSide",  "HealthKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString DevicePlacementSide {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_DevicePlacementSide is null)
					_DevicePlacementSide = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDevicePlacementSide")!;
				return _DevicePlacementSide;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceSerialNumber;
		/// <summary>Represents the value associated with the constant HKMetadataKeyDeviceSerialNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyDeviceSerialNumber",  "HealthKit")]
		public static NSString DeviceSerialNumber {
			get {
				if (_DeviceSerialNumber is null)
					_DeviceSerialNumber = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDeviceSerialNumber")!;
				return _DeviceSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DigitalSignature;
		/// <summary>Represents the value associated with the constant HKMetadataKeyDigitalSignature</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyDigitalSignature",  "HealthKit")]
		public static NSString DigitalSignature {
			get {
				if (_DigitalSignature is null)
					_DigitalSignature = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyDigitalSignature")!;
				return _DigitalSignature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElevationAscended;
		/// <summary>Represents the value associated with the constant HKMetadataKeyElevationAscended.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyElevationAscended",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString ElevationAscended {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_ElevationAscended is null)
					_ElevationAscended = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyElevationAscended")!;
				return _ElevationAscended;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElevationDescended;
		/// <summary>Represents the value associated with the constant HKMetadataKeyElevationDescended.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyElevationDescended",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString ElevationDescended {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_ElevationDescended is null)
					_ElevationDescended = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyElevationDescended")!;
				return _ElevationDescended;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExternalUuid;
		/// <summary>Represents the value associated with the constant HKMetadataKeyExternalUUID</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyExternalUUID",  "HealthKit")]
		public static NSString ExternalUuid {
			get {
				if (_ExternalUuid is null)
					_ExternalUuid = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyExternalUUID")!;
				return _ExternalUuid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FitnessMachineDuration;
		/// <summary>Represents the value associated with the constant HKMetadataKeyFitnessMachineDuration.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyFitnessMachineDuration",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString FitnessMachineDuration {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_FitnessMachineDuration is null)
					_FitnessMachineDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyFitnessMachineDuration")!;
				return _FitnessMachineDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FoodType;
		/// <summary>Represents the value associated with the constant HKMetadataKeyFoodType</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyFoodType",  "HealthKit")]
		public static NSString FoodType {
			get {
				if (_FoodType is null)
					_FoodType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyFoodType")!;
				return _FoodType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GlassesPrescriptionDescription;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyGlassesPrescriptionDescription'.</summary>
		[Field ("HKMetadataKeyGlassesPrescriptionDescription",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString GlassesPrescriptionDescription {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_GlassesPrescriptionDescription is null)
					_GlassesPrescriptionDescription = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyGlassesPrescriptionDescription")!;
				return _GlassesPrescriptionDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupFitness;
		/// <summary>Represents the value associated with the constant HKMetadataKeyGroupFitness</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyGroupFitness",  "HealthKit")]
		public static NSString GroupFitness {
			get {
				if (_GroupFitness is null)
					_GroupFitness = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyGroupFitness")!;
				return _GroupFitness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadphoneGain;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyHeadphoneGain'.</summary>
		[Field ("HKMetadataKeyHeadphoneGain",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		public static NSString HeadphoneGain {
			[SupportedOSPlatform ("maccatalyst16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			get {
				if (_HeadphoneGain is null)
					_HeadphoneGain = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeadphoneGain")!;
				return _HeadphoneGain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateEventThreshold;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyHeartRateEventThreshold",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString HeartRateEventThreshold {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_HeartRateEventThreshold is null)
					_HeartRateEventThreshold = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateEventThreshold")!;
				return _HeartRateEventThreshold;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateMotionContext;
		/// <summary>Represents the value associated with the constant HKMetadataKeyHeartRateMotionContext.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyHeartRateMotionContext",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString HeartRateMotionContext {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_HeartRateMotionContext is null)
					_HeartRateMotionContext = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateMotionContext")!;
				return _HeartRateMotionContext;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateRecoveryActivityDuration;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyHeartRateRecoveryActivityDuration'.</summary>
		[Field ("HKMetadataKeyHeartRateRecoveryActivityDuration",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString HeartRateRecoveryActivityDuration {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_HeartRateRecoveryActivityDuration is null)
					_HeartRateRecoveryActivityDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateRecoveryActivityDuration")!;
				return _HeartRateRecoveryActivityDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateRecoveryActivityType;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyHeartRateRecoveryActivityType'.</summary>
		[Field ("HKMetadataKeyHeartRateRecoveryActivityType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString HeartRateRecoveryActivityType {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_HeartRateRecoveryActivityType is null)
					_HeartRateRecoveryActivityType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateRecoveryActivityType")!;
				return _HeartRateRecoveryActivityType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateRecoveryMaxObservedRecoveryHeartRate;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyHeartRateRecoveryMaxObservedRecoveryHeartRate'.</summary>
		[Field ("HKMetadataKeyHeartRateRecoveryMaxObservedRecoveryHeartRate",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString HeartRateRecoveryMaxObservedRecoveryHeartRate {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_HeartRateRecoveryMaxObservedRecoveryHeartRate is null)
					_HeartRateRecoveryMaxObservedRecoveryHeartRate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateRecoveryMaxObservedRecoveryHeartRate")!;
				return _HeartRateRecoveryMaxObservedRecoveryHeartRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateRecoveryTestType;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyHeartRateRecoveryTestType'.</summary>
		[Field ("HKMetadataKeyHeartRateRecoveryTestType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString HeartRateRecoveryTestType {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_HeartRateRecoveryTestType is null)
					_HeartRateRecoveryTestType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateRecoveryTestType")!;
				return _HeartRateRecoveryTestType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeartRateSensorLocation;
		/// <summary>Represents the value associated with the constant HKMetadataKeyHeartRateSensorLocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyHeartRateSensorLocation",  "HealthKit")]
		public static NSString HeartRateSensorLocation {
			get {
				if (_HeartRateSensorLocation is null)
					_HeartRateSensorLocation = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyHeartRateSensorLocation")!;
				return _HeartRateSensorLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndoorBikeDistance;
		/// <summary>Represents the value associated with the constant HKMetadataKeyIndoorBikeDistance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyIndoorBikeDistance",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString IndoorBikeDistance {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_IndoorBikeDistance is null)
					_IndoorBikeDistance = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyIndoorBikeDistance")!;
				return _IndoorBikeDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndoorWorkout;
		/// <summary>Represents the value associated with the constant HKMetadataKeyIndoorWorkout</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyIndoorWorkout",  "HealthKit")]
		public static NSString IndoorWorkout {
			get {
				if (_IndoorWorkout is null)
					_IndoorWorkout = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyIndoorWorkout")!;
				return _IndoorWorkout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InsulinDeliveryReason;
		/// <summary>Represents the value associated with the constant HKMetadataKeyInsulinDeliveryReason.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyInsulinDeliveryReason",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString InsulinDeliveryReason {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_InsulinDeliveryReason is null)
					_InsulinDeliveryReason = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyInsulinDeliveryReason")!;
				return _InsulinDeliveryReason;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyActivityType;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyActivityType'.</summary>
		[Field ("HKMetadataKeyActivityType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString KeyActivityType {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_KeyActivityType is null)
					_KeyActivityType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyActivityType")!;
				return _KeyActivityType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LapLength;
		/// <summary>Represents the value associated with the constant HKMetadataKeyLapLength.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyLapLength",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString LapLength {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_LapLength is null)
					_LapLength = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyLapLength")!;
				return _LapLength;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LowCardioFitnessEventThreshold;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyLowCardioFitnessEventThreshold'.</summary>
		[Field ("HKMetadataKeyLowCardioFitnessEventThreshold",  "HealthKit")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString LowCardioFitnessEventThreshold {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_LowCardioFitnessEventThreshold is null)
					_LowCardioFitnessEventThreshold = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyLowCardioFitnessEventThreshold")!;
				return _LowCardioFitnessEventThreshold;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumLightIntensity;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyMaximumLightIntensity'.</summary>
		[Field ("HKMetadataKeyMaximumLightIntensity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString MaximumLightIntensity {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_MaximumLightIntensity is null)
					_MaximumLightIntensity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyMaximumLightIntensity")!;
				return _MaximumLightIntensity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumSpeed;
		/// <summary>Represents the value associated with the constant HKMetadataKeyMaximumSpeed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyMaximumSpeed",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MaximumSpeed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MaximumSpeed is null)
					_MaximumSpeed = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyMaximumSpeed")!;
				return _MaximumSpeed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MenstrualCycleStart;
		/// <summary>Represents the value associated with the constant HKMetadataKeyMenstrualCycleStart.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyMenstrualCycleStart",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString MenstrualCycleStart {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_MenstrualCycleStart is null)
					_MenstrualCycleStart = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyMenstrualCycleStart")!;
				return _MenstrualCycleStart;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhysicalEffortEstimationType;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyPhysicalEffortEstimationType'.</summary>
		[Field ("HKMetadataKeyPhysicalEffortEstimationType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString PhysicalEffortEstimationType {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_PhysicalEffortEstimationType is null)
					_PhysicalEffortEstimationType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyPhysicalEffortEstimationType")!;
				return _PhysicalEffortEstimationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuantityClampedToLowerBound;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyQuantityClampedToLowerBound'.</summary>
		[Field ("HKMetadataKeyQuantityClampedToLowerBound",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString QuantityClampedToLowerBound {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_QuantityClampedToLowerBound is null)
					_QuantityClampedToLowerBound = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyQuantityClampedToLowerBound")!;
				return _QuantityClampedToLowerBound;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuantityClampedToUpperBound;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyQuantityClampedToUpperBound'.</summary>
		[Field ("HKMetadataKeyQuantityClampedToUpperBound",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString QuantityClampedToUpperBound {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_QuantityClampedToUpperBound is null)
					_QuantityClampedToUpperBound = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyQuantityClampedToUpperBound")!;
				return _QuantityClampedToUpperBound;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceRangeLowerLimit;
		/// <summary>Represents the value associated with the constant HKMetadataKeyReferenceRangeLowerLimit</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyReferenceRangeLowerLimit",  "HealthKit")]
		public static NSString ReferenceRangeLowerLimit {
			get {
				if (_ReferenceRangeLowerLimit is null)
					_ReferenceRangeLowerLimit = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyReferenceRangeLowerLimit")!;
				return _ReferenceRangeLowerLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceRangeUpperLimit;
		/// <summary>Represents the value associated with the constant HKMetadataKeyReferenceRangeUpperLimit</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyReferenceRangeUpperLimit",  "HealthKit")]
		public static NSString ReferenceRangeUpperLimit {
			get {
				if (_ReferenceRangeUpperLimit is null)
					_ReferenceRangeUpperLimit = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyReferenceRangeUpperLimit")!;
				return _ReferenceRangeUpperLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SessionEstimate;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeySessionEstimate'.</summary>
		[Field ("HKMetadataKeySessionEstimate",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString SessionEstimate {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_SessionEstimate is null)
					_SessionEstimate = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySessionEstimate")!;
				return _SessionEstimate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SexualActivityProtectionUsed;
		/// <summary>Represents the value associated with the constant HKMetadataKeySexualActivityProtectionUsed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeySexualActivityProtectionUsed",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SexualActivityProtectionUsed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SexualActivityProtectionUsed is null)
					_SexualActivityProtectionUsed = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySexualActivityProtectionUsed")!;
				return _SexualActivityProtectionUsed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SwimmingLocationType;
		/// <summary>Represents the value associated with the constant HKMetadataKeySwimmingLocationType.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeySwimmingLocationType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SwimmingLocationType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SwimmingLocationType is null)
					_SwimmingLocationType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySwimmingLocationType")!;
				return _SwimmingLocationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SwimmingStrokeStyle;
		/// <summary>Represents the value associated with the constant HKMetadataKeySwimmingStrokeStyle.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeySwimmingStrokeStyle",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SwimmingStrokeStyle {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SwimmingStrokeStyle is null)
					_SwimmingStrokeStyle = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySwimmingStrokeStyle")!;
				return _SwimmingStrokeStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SwolfScore;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeySWOLFScore'.</summary>
		[Field ("HKMetadataKeySWOLFScore",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString SwolfScore {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_SwolfScore is null)
					_SwolfScore = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySWOLFScore")!;
				return _SwolfScore;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SyncIdentifier;
		/// <summary>Represents the value associated with the constant HKMetadataKeySyncIdentifier.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeySyncIdentifier",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SyncIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SyncIdentifier is null)
					_SyncIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySyncIdentifier")!;
				return _SyncIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SyncVersion;
		/// <summary>Represents the value associated with the constant HKMetadataKeySyncVersion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeySyncVersion",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SyncVersion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SyncVersion is null)
					_SyncVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeySyncVersion")!;
				return _SyncVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeZone;
		/// <summary>Represents the value associated with the constant HKMetadataKeyTimeZone</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyTimeZone",  "HealthKit")]
		public static NSString TimeZone {
			get {
				if (_TimeZone is null)
					_TimeZone = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyTimeZone")!;
				return _TimeZone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UdiDeviceIdentifier;
		/// <summary>Represents the value associated with the constant HKMetadataKeyUDIDeviceIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyUDIDeviceIdentifier",  "HealthKit")]
		public static NSString UdiDeviceIdentifier {
			get {
				if (_UdiDeviceIdentifier is null)
					_UdiDeviceIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyUDIDeviceIdentifier")!;
				return _UdiDeviceIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UdiProductionIdentifier;
		/// <summary>Represents the value associated with the constant HKMetadataKeyUDIProductionIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyUDIProductionIdentifier",  "HealthKit")]
		public static NSString UdiProductionIdentifier {
			get {
				if (_UdiProductionIdentifier is null)
					_UdiProductionIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyUDIProductionIdentifier")!;
				return _UdiProductionIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserMotionContext;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyUserMotionContext'.</summary>
		[Field ("HKMetadataKeyUserMotionContext",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString UserMotionContext {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_UserMotionContext is null)
					_UserMotionContext = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyUserMotionContext")!;
				return _UserMotionContext;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VO2MaxTestType;
		/// <summary>Represents the value associated with the constant HKMetadataKeyVO2MaxTestType.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyVO2MaxTestType",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString VO2MaxTestType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_VO2MaxTestType is null)
					_VO2MaxTestType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyVO2MaxTestType")!;
				return _VO2MaxTestType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VO2MaxValue;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyVO2MaxValue'.</summary>
		[Field ("HKMetadataKeyVO2MaxValue",  "HealthKit")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString VO2MaxValue {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_VO2MaxValue is null)
					_VO2MaxValue = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyVO2MaxValue")!;
				return _VO2MaxValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasTakenInLab;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWasTakenInLab</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWasTakenInLab",  "HealthKit")]
		public static NSString WasTakenInLab {
			get {
				if (_WasTakenInLab is null)
					_WasTakenInLab = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWasTakenInLab")!;
				return _WasTakenInLab;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasUserEntered;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWasUserEntered</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWasUserEntered",  "HealthKit")]
		public static NSString WasUserEntered {
			get {
				if (_WasUserEntered is null)
					_WasUserEntered = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWasUserEntered")!;
				return _WasUserEntered;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WaterSalinity;
		/// <summary>Represents the value associated with the constant 'HKMetadataKeyWaterSalinity'.</summary>
		[Field ("HKMetadataKeyWaterSalinity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString WaterSalinity {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_WaterSalinity is null)
					_WaterSalinity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWaterSalinity")!;
				return _WaterSalinity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeatherCondition;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWeatherCondition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWeatherCondition",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString WeatherCondition {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_WeatherCondition is null)
					_WeatherCondition = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWeatherCondition")!;
				return _WeatherCondition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeatherHumidity;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWeatherHumidity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWeatherHumidity",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString WeatherHumidity {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_WeatherHumidity is null)
					_WeatherHumidity = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWeatherHumidity")!;
				return _WeatherHumidity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeatherTemperature;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWeatherTemperature.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWeatherTemperature",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString WeatherTemperature {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_WeatherTemperature is null)
					_WeatherTemperature = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWeatherTemperature")!;
				return _WeatherTemperature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkoutBrandName;
		/// <summary>Represents the value associated with the constant HKMetadataKeyWorkoutBrandName</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKMetadataKeyWorkoutBrandName",  "HealthKit")]
		public static NSString WorkoutBrandName {
			get {
				if (_WorkoutBrandName is null)
					_WorkoutBrandName = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKMetadataKeyWorkoutBrandName")!;
				return _WorkoutBrandName;
			}
		}
	} /* class HKMetadataKey */
}
