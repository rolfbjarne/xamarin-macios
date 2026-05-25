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
	/// <summary>Enumerates the types of <see cref="T:HealthKit.HKQuantityType" />.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKQuantityTypeIdentifier : int {
		/// <summary>Indicates a body mass index.</summary>
		BodyMassIndex = 0,
		/// <summary>Indicates a body fat percentage measurement.</summary>
		BodyFatPercentage = 1,
		/// <summary>Indicates a height measurement.</summary>
		Height = 2,
		/// <summary>Indicates a body mass measurement.</summary>
		BodyMass = 3,
		/// <summary>Indicates a lean body mass measurement.</summary>
		LeanBodyMass = 4,
		/// <summary>Indicates a heart rate measurement.</summary>
		HeartRate = 5,
		/// <summary>Indicates a user's step count.</summary>
		StepCount = 6,
		/// <summary>Indicates the distance over which the user ran or walked.</summary>
		DistanceWalkingRunning = 7,
		/// <summary>Indicates the distance for which a user rode a bicycle.</summary>
		DistanceCycling = 8,
		/// <summary>Indicates the energy consumed in the resting state.</summary>
		BasalEnergyBurned = 9,
		/// <summary>Indicates the energy that is consumed due to activity, above the resting state.</summary>
		ActiveEnergyBurned = 10,
		/// <summary>Indicates the number of flights of stairs that a user climbed.</summary>
		FlightsClimbed = 11,
		/// <summary>Indicates the number of Nike Fuel points the user has earned.</summary>
		NikeFuel = 12,
		/// <summary>Indicates an oxygen saturation measurement.</summary>
		OxygenSaturation = 13,
		/// <summary>Indicates a blood glucose measurement.</summary>
		BloodGlucose = 14,
		/// <summary>Indicates a systolic blood pressure measurement.</summary>
		BloodPressureSystolic = 15,
		/// <summary>Indicates a diastolic blood pressure measurement.</summary>
		BloodPressureDiastolic = 16,
		/// <summary>Indicates a blood alcohol measurement.</summary>
		BloodAlcoholContent = 17,
		/// <summary>Indicates a measurement of the peripheal perfusion index.</summary>
		PeripheralPerfusionIndex = 18,
		/// <summary>Indicates a forced vital capacity measurement.</summary>
		ForcedVitalCapacity = 19,
		/// <summary>Indicates a forced epiratory volume measurement.</summary>
		ForcedExpiratoryVolume1 = 20,
		/// <summary>Indicates a peak expiratory flow rate.</summary>
		PeakExpiratoryFlowRate = 21,
		/// <summary>Indicates the number of times the user fell.</summary>
		NumberOfTimesFallen = 22,
		/// <summary>Indicates an inhaler usage measurement.</summary>
		InhalerUsage = 23,
		/// <summary>Indicates a respiratory rate measurement.</summary>
		RespiratoryRate = 24,
		/// <summary>Indicates a body temperature measurement.</summary>
		BodyTemperature = 25,
		/// <summary>Indicates the user's total dietary fat intake.</summary>
		DietaryFatTotal = 26,
		/// <summary>Indicates the user's dietary polyunsaturated fat intake.</summary>
		DietaryFatPolyunsaturated = 27,
		/// <summary>Indicates the user's dietary monounsaturated fat intake.</summary>
		DietaryFatMonounsaturated = 28,
		/// <summary>Indicates the user's dietary saturated fat intake.</summary>
		DietaryFatSaturated = 29,
		/// <summary>Indicates the user's dietary cholesterol intake..</summary>
		DietaryCholesterol = 30,
		/// <summary>Indicates the user's dietary sodium intake.</summary>
		DietarySodium = 31,
		/// <summary>Indicates the user's dietary carbohydrate intake.</summary>
		DietaryCarbohydrates = 32,
		/// <summary>Indicates the user's dietary fiber intake.</summary>
		DietaryFiber = 33,
		/// <summary>Indicates the user's dietary sugar intake.</summary>
		DietarySugar = 34,
		/// <summary>Indicates the user's total dietary energy intake.</summary>
		DietaryEnergyConsumed = 35,
		/// <summary>Indicates the user's dietary protein intake.</summary>
		DietaryProtein = 36,
		/// <summary>Indicates the user's dietary vitamin A intake.</summary>
		DietaryVitaminA = 37,
		/// <summary>Indicates the user's dietary vitamin B6 intake.</summary>
		DietaryVitaminB6 = 38,
		/// <summary>Indicates the user's dietary vitamin B12 intake.</summary>
		DietaryVitaminB12 = 39,
		/// <summary>Indicates the user's dietary vitamin C intake.</summary>
		DietaryVitaminC = 40,
		/// <summary>Indicates the user's dietary vitamin D intake.</summary>
		DietaryVitaminD = 41,
		/// <summary>Indicates the user's dietary vitamin E intake.</summary>
		DietaryVitaminE = 42,
		/// <summary>Indicates the user's dietary vitamin K intake.</summary>
		DietaryVitaminK = 43,
		/// <summary>Indicates the user's dietary calcium intake.</summary>
		DietaryCalcium = 44,
		/// <summary>Indicates the user's dietary iron intake.</summary>
		DietaryIron = 45,
		/// <summary>Indicates the user's dietary thiamin intake.</summary>
		DietaryThiamin = 46,
		/// <summary>Indicates the user's dietary riboflavin intake.</summary>
		DietaryRiboflavin = 47,
		/// <summary>Indicates the user's dietary niacin intake.</summary>
		DietaryNiacin = 48,
		/// <summary>Indicates the user's dietary folate intake.</summary>
		DietaryFolate = 49,
		/// <summary>Indicates the user's dietary biotin intake.</summary>
		DietaryBiotin = 50,
		/// <summary>Indicates the user's dietary pantothenic acid intake.</summary>
		DietaryPantothenicAcid = 51,
		/// <summary>Indicates the user's dietary phosphorus intake.</summary>
		DietaryPhosphorus = 52,
		/// <summary>Indicates the user's dietary iodine intake.</summary>
		DietaryIodine = 53,
		/// <summary>Indicates the user's dietary magnesium intake.</summary>
		DietaryMagnesium = 54,
		/// <summary>Indicates the user's dietary zinc intake.</summary>
		DietaryZinc = 55,
		/// <summary>Indicates the user's dietary selenium intake.</summary>
		DietarySelenium = 56,
		/// <summary>Indicates the user's dietary copper intake.</summary>
		DietaryCopper = 57,
		/// <summary>Indicates the user's dietary manganese intake.</summary>
		DietaryManganese = 58,
		/// <summary>Indicates the user's dietary chromium intake.</summary>
		DietaryChromium = 59,
		/// <summary>Indicates the user's dietary molybdenum intake.</summary>
		DietaryMolybdenum = 60,
		/// <summary>Indicates the user's dietary chloride intake..</summary>
		DietaryChloride = 61,
		/// <summary>Indicates the user's dietary potassium intake.</summary>
		DietaryPotassium = 62,
		/// <summary>Indicates the user's dietary caffeine intake.</summary>
		DietaryCaffeine = 63,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		BasalBodyTemperature = 64,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DietaryWater = 65,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		UVExposure = 66,
		/// <summary>To be added.</summary>
		ElectrodermalActivity = 67,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		AppleExerciseTime = 68,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DistanceWheelchair = 69,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		PushCount = 70,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DistanceSwimming = 71,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		SwimmingStrokeCount = 72,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		WaistCircumference = 73,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		VO2Max = 74,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DistanceDownhillSnowSports = 75,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		InsulinDelivery = 76,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		RestingHeartRate = 77,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		WalkingHeartRateAverage = 78,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		HeartRateVariabilitySdnn = 79,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AppleStandTime = 80,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		EnvironmentalAudioExposure = 81,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		HeadphoneAudioExposure = 82,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SixMinuteWalkTestDistance = 83,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		StairAscentSpeed = 84,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		StairDescentSpeed = 85,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		WalkingAsymmetryPercentage = 86,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		WalkingDoubleSupportPercentage = 87,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		WalkingSpeed = 88,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		WalkingStepLength = 89,
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AppleMoveTime = 90,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AppleWalkingSteadiness = 91,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		NumberOfAlcoholicBeverages = 92,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		HeartRateRecoveryOneMinute = 93,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		RunningGroundContactTime = 94,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		RunningStrideLength = 95,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		RunningVerticalOscillation = 96,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		RunningPower = 97,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		RunningSpeed = 98,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		AtrialFibrillationBurden = 99,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		AppleSleepingWristTemperature = 100,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		UnderwaterDepth = 101,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		WaterTemperature = 102,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		CyclingCadence = 103,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		CyclingFunctionalThresholdPower = 104,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		CyclingPower = 105,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		CyclingSpeed = 106,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		EnvironmentalSoundReduction = 107,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		PhysicalEffort = 108,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		TimeInDaylight = 109,
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WorkoutEffortScore = 110,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		CrossCountrySkiingSpeed = 111,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		DistanceCrossCountrySkiing = 112,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		DistancePaddleSports = 113,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		DistanceRowing = 114,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		DistanceSkatingSports = 115,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		EstimatedWorkoutEffortScore = 116,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		PaddleSportsSpeed = 117,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		RowingSpeed = 118,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		AppleSleepingBreathingDisturbances = 119,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKQuantityTypeIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKQuantityTypeIdentifierExtensions {
		static IntPtr[] values = new IntPtr [120];
		[Field ("HKQuantityTypeIdentifierBodyMassIndex", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBodyMassIndex {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBodyMassIndex", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBodyFatPercentage", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBodyFatPercentage {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBodyFatPercentage", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierHeight", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierHeight {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierHeight", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBodyMass", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBodyMass {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBodyMass", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierLeanBodyMass", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierLeanBodyMass {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierLeanBodyMass", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierHeartRate", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierHeartRate {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierHeartRate", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierStepCount", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierStepCount {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierStepCount", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDistanceWalkingRunning", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceWalkingRunning {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceWalkingRunning", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDistanceCycling", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceCycling {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceCycling", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBasalEnergyBurned", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBasalEnergyBurned {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBasalEnergyBurned", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierActiveEnergyBurned", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierActiveEnergyBurned {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierActiveEnergyBurned", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierFlightsClimbed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierFlightsClimbed {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierFlightsClimbed", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierNikeFuel", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierNikeFuel {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierNikeFuel", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierOxygenSaturation", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierOxygenSaturation {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierOxygenSaturation", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBloodGlucose", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBloodGlucose {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBloodGlucose", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBloodPressureSystolic", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBloodPressureSystolic {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBloodPressureSystolic", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBloodPressureDiastolic", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBloodPressureDiastolic {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBloodPressureDiastolic", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBloodAlcoholContent", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBloodAlcoholContent {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBloodAlcoholContent", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierPeripheralPerfusionIndex", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierPeripheralPerfusionIndex {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierPeripheralPerfusionIndex", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierForcedVitalCapacity", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierForcedVitalCapacity {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierForcedVitalCapacity", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierForcedExpiratoryVolume1", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierForcedExpiratoryVolume1 {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierForcedExpiratoryVolume1", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierPeakExpiratoryFlowRate", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierPeakExpiratoryFlowRate {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierPeakExpiratoryFlowRate", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierNumberOfTimesFallen", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierNumberOfTimesFallen {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierNumberOfTimesFallen", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierInhalerUsage", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierInhalerUsage {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierInhalerUsage", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierRespiratoryRate", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRespiratoryRate {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRespiratoryRate", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierBodyTemperature", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBodyTemperature {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBodyTemperature", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFatTotal", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFatTotal {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFatTotal", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFatPolyunsaturated", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFatPolyunsaturated {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFatPolyunsaturated", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFatMonounsaturated", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFatMonounsaturated {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFatMonounsaturated", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFatSaturated", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFatSaturated {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFatSaturated", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryCholesterol", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryCholesterol {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryCholesterol", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietarySodium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietarySodium {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietarySodium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryCarbohydrates", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryCarbohydrates {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryCarbohydrates", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFiber", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFiber {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFiber", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietarySugar", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietarySugar {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietarySugar", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryEnergyConsumed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryEnergyConsumed {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryEnergyConsumed", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryProtein", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryProtein {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryProtein", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminA", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminA {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminA", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminB6", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminB6 {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminB6", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminB12", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminB12 {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminB12", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminC", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminC {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminC", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminD", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminD {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminD", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminE", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminE {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminE", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryVitaminK", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryVitaminK {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryVitaminK", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryCalcium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryCalcium {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryCalcium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryIron", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryIron {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryIron", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryThiamin", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryThiamin {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryThiamin", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryRiboflavin", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryRiboflavin {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryRiboflavin", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryNiacin", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryNiacin {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryNiacin", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryFolate", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryFolate {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryFolate", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryBiotin", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryBiotin {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryBiotin", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryPantothenicAcid", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryPantothenicAcid {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryPantothenicAcid", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryPhosphorus", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryPhosphorus {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryPhosphorus", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryIodine", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryIodine {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryIodine", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryMagnesium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryMagnesium {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryMagnesium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryZinc", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryZinc {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryZinc", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietarySelenium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietarySelenium {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietarySelenium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryCopper", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryCopper {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryCopper", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryManganese", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryManganese {
			get {
				fixed (IntPtr *storage = &values [58])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryManganese", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryChromium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryChromium {
			get {
				fixed (IntPtr *storage = &values [59])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryChromium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryMolybdenum", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryMolybdenum {
			get {
				fixed (IntPtr *storage = &values [60])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryMolybdenum", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryChloride", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryChloride {
			get {
				fixed (IntPtr *storage = &values [61])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryChloride", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryPotassium", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryPotassium {
			get {
				fixed (IntPtr *storage = &values [62])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryPotassium", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierDietaryCaffeine", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryCaffeine {
			get {
				fixed (IntPtr *storage = &values [63])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryCaffeine", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierBasalBodyTemperature", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierBasalBodyTemperature {
			get {
				fixed (IntPtr *storage = &values [64])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierBasalBodyTemperature", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierDietaryWater", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDietaryWater {
			get {
				fixed (IntPtr *storage = &values [65])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDietaryWater", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierUVExposure", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierUVExposure {
			get {
				fixed (IntPtr *storage = &values [66])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierUVExposure", storage);
			}
		}
		[Field ("HKQuantityTypeIdentifierElectrodermalActivity", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierElectrodermalActivity {
			get {
				fixed (IntPtr *storage = &values [67])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierElectrodermalActivity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierAppleExerciseTime", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleExerciseTime {
			get {
				fixed (IntPtr *storage = &values [68])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleExerciseTime", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierDistanceWheelchair", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceWheelchair {
			get {
				fixed (IntPtr *storage = &values [69])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceWheelchair", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierPushCount", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierPushCount {
			get {
				fixed (IntPtr *storage = &values [70])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierPushCount", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierDistanceSwimming", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceSwimming {
			get {
				fixed (IntPtr *storage = &values [71])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceSwimming", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierSwimmingStrokeCount", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierSwimmingStrokeCount {
			get {
				fixed (IntPtr *storage = &values [72])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierSwimmingStrokeCount", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWaistCircumference", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWaistCircumference {
			get {
				fixed (IntPtr *storage = &values [73])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWaistCircumference", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierVO2Max", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierVO2Max {
			get {
				fixed (IntPtr *storage = &values [74])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierVO2Max", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierDistanceDownhillSnowSports", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceDownhillSnowSports {
			get {
				fixed (IntPtr *storage = &values [75])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceDownhillSnowSports", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierInsulinDelivery", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierInsulinDelivery {
			get {
				fixed (IntPtr *storage = &values [76])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierInsulinDelivery", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierRestingHeartRate", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRestingHeartRate {
			get {
				fixed (IntPtr *storage = &values [77])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRestingHeartRate", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWalkingHeartRateAverage", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWalkingHeartRateAverage {
			get {
				fixed (IntPtr *storage = &values [78])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWalkingHeartRateAverage", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierHeartRateVariabilitySDNN", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierHeartRateVariabilitySDNN {
			get {
				fixed (IntPtr *storage = &values [79])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierHeartRateVariabilitySDNN", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierAppleStandTime", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleStandTime {
			get {
				fixed (IntPtr *storage = &values [80])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleStandTime", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierEnvironmentalAudioExposure", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierEnvironmentalAudioExposure {
			get {
				fixed (IntPtr *storage = &values [81])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierEnvironmentalAudioExposure", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierHeadphoneAudioExposure", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierHeadphoneAudioExposure {
			get {
				fixed (IntPtr *storage = &values [82])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierHeadphoneAudioExposure", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierSixMinuteWalkTestDistance", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierSixMinuteWalkTestDistance {
			get {
				fixed (IntPtr *storage = &values [83])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierSixMinuteWalkTestDistance", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierStairAscentSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierStairAscentSpeed {
			get {
				fixed (IntPtr *storage = &values [84])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierStairAscentSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierStairDescentSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierStairDescentSpeed {
			get {
				fixed (IntPtr *storage = &values [85])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierStairDescentSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWalkingAsymmetryPercentage", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWalkingAsymmetryPercentage {
			get {
				fixed (IntPtr *storage = &values [86])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWalkingAsymmetryPercentage", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWalkingDoubleSupportPercentage", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWalkingDoubleSupportPercentage {
			get {
				fixed (IntPtr *storage = &values [87])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWalkingDoubleSupportPercentage", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWalkingSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWalkingSpeed {
			get {
				fixed (IntPtr *storage = &values [88])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWalkingSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierWalkingStepLength", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWalkingStepLength {
			get {
				fixed (IntPtr *storage = &values [89])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWalkingStepLength", storage);
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierAppleMoveTime", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleMoveTime {
			get {
				fixed (IntPtr *storage = &values [90])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleMoveTime", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierAppleWalkingSteadiness", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleWalkingSteadiness {
			get {
				fixed (IntPtr *storage = &values [91])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleWalkingSteadiness", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKQuantityTypeIdentifierNumberOfAlcoholicBeverages", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierNumberOfAlcoholicBeverages {
			get {
				fixed (IntPtr *storage = &values [92])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierNumberOfAlcoholicBeverages", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierHeartRateRecoveryOneMinute", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierHeartRateRecoveryOneMinute {
			get {
				fixed (IntPtr *storage = &values [93])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierHeartRateRecoveryOneMinute", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierRunningGroundContactTime", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRunningGroundContactTime {
			get {
				fixed (IntPtr *storage = &values [94])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRunningGroundContactTime", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierRunningStrideLength", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRunningStrideLength {
			get {
				fixed (IntPtr *storage = &values [95])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRunningStrideLength", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierRunningVerticalOscillation", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRunningVerticalOscillation {
			get {
				fixed (IntPtr *storage = &values [96])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRunningVerticalOscillation", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierRunningPower", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRunningPower {
			get {
				fixed (IntPtr *storage = &values [97])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRunningPower", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierRunningSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRunningSpeed {
			get {
				fixed (IntPtr *storage = &values [98])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRunningSpeed", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("HKQuantityTypeIdentifierAtrialFibrillationBurden", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAtrialFibrillationBurden {
			get {
				fixed (IntPtr *storage = &values [99])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAtrialFibrillationBurden", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKQuantityTypeIdentifierAppleSleepingWristTemperature", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleSleepingWristTemperature {
			get {
				fixed (IntPtr *storage = &values [100])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleSleepingWristTemperature", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKQuantityTypeIdentifierUnderwaterDepth", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierUnderwaterDepth {
			get {
				fixed (IntPtr *storage = &values [101])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierUnderwaterDepth", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKQuantityTypeIdentifierWaterTemperature", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWaterTemperature {
			get {
				fixed (IntPtr *storage = &values [102])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWaterTemperature", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierCyclingCadence", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierCyclingCadence {
			get {
				fixed (IntPtr *storage = &values [103])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierCyclingCadence", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierCyclingFunctionalThresholdPower", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierCyclingFunctionalThresholdPower {
			get {
				fixed (IntPtr *storage = &values [104])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierCyclingFunctionalThresholdPower", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierCyclingPower", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierCyclingPower {
			get {
				fixed (IntPtr *storage = &values [105])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierCyclingPower", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierCyclingSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierCyclingSpeed {
			get {
				fixed (IntPtr *storage = &values [106])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierCyclingSpeed", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKQuantityTypeIdentifierEnvironmentalSoundReduction", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierEnvironmentalSoundReduction {
			get {
				fixed (IntPtr *storage = &values [107])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierEnvironmentalSoundReduction", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierPhysicalEffort", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierPhysicalEffort {
			get {
				fixed (IntPtr *storage = &values [108])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierPhysicalEffort", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("HKQuantityTypeIdentifierTimeInDaylight", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierTimeInDaylight {
			get {
				fixed (IntPtr *storage = &values [109])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierTimeInDaylight", storage);
			}
		}
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HKQuantityTypeIdentifierWorkoutEffortScore", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierWorkoutEffortScore {
			get {
				fixed (IntPtr *storage = &values [110])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierWorkoutEffortScore", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierCrossCountrySkiingSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierCrossCountrySkiingSpeed {
			get {
				fixed (IntPtr *storage = &values [111])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierCrossCountrySkiingSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierDistanceCrossCountrySkiing", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceCrossCountrySkiing {
			get {
				fixed (IntPtr *storage = &values [112])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceCrossCountrySkiing", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierDistancePaddleSports", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistancePaddleSports {
			get {
				fixed (IntPtr *storage = &values [113])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistancePaddleSports", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierDistanceRowing", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceRowing {
			get {
				fixed (IntPtr *storage = &values [114])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceRowing", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierDistanceSkatingSports", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierDistanceSkatingSports {
			get {
				fixed (IntPtr *storage = &values [115])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierDistanceSkatingSports", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierEstimatedWorkoutEffortScore", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierEstimatedWorkoutEffortScore {
			get {
				fixed (IntPtr *storage = &values [116])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierEstimatedWorkoutEffortScore", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierPaddleSportsSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierPaddleSportsSpeed {
			get {
				fixed (IntPtr *storage = &values [117])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierPaddleSportsSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierRowingSpeed", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierRowingSpeed {
			get {
				fixed (IntPtr *storage = &values [118])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierRowingSpeed", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKQuantityTypeIdentifierAppleSleepingBreathingDisturbances", "HealthKit")]
		internal unsafe static IntPtr HKQuantityTypeIdentifierAppleSleepingBreathingDisturbances {
			get {
				fixed (IntPtr *storage = &values [119])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKQuantityTypeIdentifierAppleSleepingBreathingDisturbances", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKQuantityTypeIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKQuantityTypeIdentifier.BodyMassIndex
				ptr = HKQuantityTypeIdentifierBodyMassIndex;
				break;
			case 1: // HKQuantityTypeIdentifier.BodyFatPercentage
				ptr = HKQuantityTypeIdentifierBodyFatPercentage;
				break;
			case 2: // HKQuantityTypeIdentifier.Height
				ptr = HKQuantityTypeIdentifierHeight;
				break;
			case 3: // HKQuantityTypeIdentifier.BodyMass
				ptr = HKQuantityTypeIdentifierBodyMass;
				break;
			case 4: // HKQuantityTypeIdentifier.LeanBodyMass
				ptr = HKQuantityTypeIdentifierLeanBodyMass;
				break;
			case 5: // HKQuantityTypeIdentifier.HeartRate
				ptr = HKQuantityTypeIdentifierHeartRate;
				break;
			case 6: // HKQuantityTypeIdentifier.StepCount
				ptr = HKQuantityTypeIdentifierStepCount;
				break;
			case 7: // HKQuantityTypeIdentifier.DistanceWalkingRunning
				ptr = HKQuantityTypeIdentifierDistanceWalkingRunning;
				break;
			case 8: // HKQuantityTypeIdentifier.DistanceCycling
				ptr = HKQuantityTypeIdentifierDistanceCycling;
				break;
			case 9: // HKQuantityTypeIdentifier.BasalEnergyBurned
				ptr = HKQuantityTypeIdentifierBasalEnergyBurned;
				break;
			case 10: // HKQuantityTypeIdentifier.ActiveEnergyBurned
				ptr = HKQuantityTypeIdentifierActiveEnergyBurned;
				break;
			case 11: // HKQuantityTypeIdentifier.FlightsClimbed
				ptr = HKQuantityTypeIdentifierFlightsClimbed;
				break;
			case 12: // HKQuantityTypeIdentifier.NikeFuel
				ptr = HKQuantityTypeIdentifierNikeFuel;
				break;
			case 13: // HKQuantityTypeIdentifier.OxygenSaturation
				ptr = HKQuantityTypeIdentifierOxygenSaturation;
				break;
			case 14: // HKQuantityTypeIdentifier.BloodGlucose
				ptr = HKQuantityTypeIdentifierBloodGlucose;
				break;
			case 15: // HKQuantityTypeIdentifier.BloodPressureSystolic
				ptr = HKQuantityTypeIdentifierBloodPressureSystolic;
				break;
			case 16: // HKQuantityTypeIdentifier.BloodPressureDiastolic
				ptr = HKQuantityTypeIdentifierBloodPressureDiastolic;
				break;
			case 17: // HKQuantityTypeIdentifier.BloodAlcoholContent
				ptr = HKQuantityTypeIdentifierBloodAlcoholContent;
				break;
			case 18: // HKQuantityTypeIdentifier.PeripheralPerfusionIndex
				ptr = HKQuantityTypeIdentifierPeripheralPerfusionIndex;
				break;
			case 19: // HKQuantityTypeIdentifier.ForcedVitalCapacity
				ptr = HKQuantityTypeIdentifierForcedVitalCapacity;
				break;
			case 20: // HKQuantityTypeIdentifier.ForcedExpiratoryVolume1
				ptr = HKQuantityTypeIdentifierForcedExpiratoryVolume1;
				break;
			case 21: // HKQuantityTypeIdentifier.PeakExpiratoryFlowRate
				ptr = HKQuantityTypeIdentifierPeakExpiratoryFlowRate;
				break;
			case 22: // HKQuantityTypeIdentifier.NumberOfTimesFallen
				ptr = HKQuantityTypeIdentifierNumberOfTimesFallen;
				break;
			case 23: // HKQuantityTypeIdentifier.InhalerUsage
				ptr = HKQuantityTypeIdentifierInhalerUsage;
				break;
			case 24: // HKQuantityTypeIdentifier.RespiratoryRate
				ptr = HKQuantityTypeIdentifierRespiratoryRate;
				break;
			case 25: // HKQuantityTypeIdentifier.BodyTemperature
				ptr = HKQuantityTypeIdentifierBodyTemperature;
				break;
			case 26: // HKQuantityTypeIdentifier.DietaryFatTotal
				ptr = HKQuantityTypeIdentifierDietaryFatTotal;
				break;
			case 27: // HKQuantityTypeIdentifier.DietaryFatPolyunsaturated
				ptr = HKQuantityTypeIdentifierDietaryFatPolyunsaturated;
				break;
			case 28: // HKQuantityTypeIdentifier.DietaryFatMonounsaturated
				ptr = HKQuantityTypeIdentifierDietaryFatMonounsaturated;
				break;
			case 29: // HKQuantityTypeIdentifier.DietaryFatSaturated
				ptr = HKQuantityTypeIdentifierDietaryFatSaturated;
				break;
			case 30: // HKQuantityTypeIdentifier.DietaryCholesterol
				ptr = HKQuantityTypeIdentifierDietaryCholesterol;
				break;
			case 31: // HKQuantityTypeIdentifier.DietarySodium
				ptr = HKQuantityTypeIdentifierDietarySodium;
				break;
			case 32: // HKQuantityTypeIdentifier.DietaryCarbohydrates
				ptr = HKQuantityTypeIdentifierDietaryCarbohydrates;
				break;
			case 33: // HKQuantityTypeIdentifier.DietaryFiber
				ptr = HKQuantityTypeIdentifierDietaryFiber;
				break;
			case 34: // HKQuantityTypeIdentifier.DietarySugar
				ptr = HKQuantityTypeIdentifierDietarySugar;
				break;
			case 35: // HKQuantityTypeIdentifier.DietaryEnergyConsumed
				ptr = HKQuantityTypeIdentifierDietaryEnergyConsumed;
				break;
			case 36: // HKQuantityTypeIdentifier.DietaryProtein
				ptr = HKQuantityTypeIdentifierDietaryProtein;
				break;
			case 37: // HKQuantityTypeIdentifier.DietaryVitaminA
				ptr = HKQuantityTypeIdentifierDietaryVitaminA;
				break;
			case 38: // HKQuantityTypeIdentifier.DietaryVitaminB6
				ptr = HKQuantityTypeIdentifierDietaryVitaminB6;
				break;
			case 39: // HKQuantityTypeIdentifier.DietaryVitaminB12
				ptr = HKQuantityTypeIdentifierDietaryVitaminB12;
				break;
			case 40: // HKQuantityTypeIdentifier.DietaryVitaminC
				ptr = HKQuantityTypeIdentifierDietaryVitaminC;
				break;
			case 41: // HKQuantityTypeIdentifier.DietaryVitaminD
				ptr = HKQuantityTypeIdentifierDietaryVitaminD;
				break;
			case 42: // HKQuantityTypeIdentifier.DietaryVitaminE
				ptr = HKQuantityTypeIdentifierDietaryVitaminE;
				break;
			case 43: // HKQuantityTypeIdentifier.DietaryVitaminK
				ptr = HKQuantityTypeIdentifierDietaryVitaminK;
				break;
			case 44: // HKQuantityTypeIdentifier.DietaryCalcium
				ptr = HKQuantityTypeIdentifierDietaryCalcium;
				break;
			case 45: // HKQuantityTypeIdentifier.DietaryIron
				ptr = HKQuantityTypeIdentifierDietaryIron;
				break;
			case 46: // HKQuantityTypeIdentifier.DietaryThiamin
				ptr = HKQuantityTypeIdentifierDietaryThiamin;
				break;
			case 47: // HKQuantityTypeIdentifier.DietaryRiboflavin
				ptr = HKQuantityTypeIdentifierDietaryRiboflavin;
				break;
			case 48: // HKQuantityTypeIdentifier.DietaryNiacin
				ptr = HKQuantityTypeIdentifierDietaryNiacin;
				break;
			case 49: // HKQuantityTypeIdentifier.DietaryFolate
				ptr = HKQuantityTypeIdentifierDietaryFolate;
				break;
			case 50: // HKQuantityTypeIdentifier.DietaryBiotin
				ptr = HKQuantityTypeIdentifierDietaryBiotin;
				break;
			case 51: // HKQuantityTypeIdentifier.DietaryPantothenicAcid
				ptr = HKQuantityTypeIdentifierDietaryPantothenicAcid;
				break;
			case 52: // HKQuantityTypeIdentifier.DietaryPhosphorus
				ptr = HKQuantityTypeIdentifierDietaryPhosphorus;
				break;
			case 53: // HKQuantityTypeIdentifier.DietaryIodine
				ptr = HKQuantityTypeIdentifierDietaryIodine;
				break;
			case 54: // HKQuantityTypeIdentifier.DietaryMagnesium
				ptr = HKQuantityTypeIdentifierDietaryMagnesium;
				break;
			case 55: // HKQuantityTypeIdentifier.DietaryZinc
				ptr = HKQuantityTypeIdentifierDietaryZinc;
				break;
			case 56: // HKQuantityTypeIdentifier.DietarySelenium
				ptr = HKQuantityTypeIdentifierDietarySelenium;
				break;
			case 57: // HKQuantityTypeIdentifier.DietaryCopper
				ptr = HKQuantityTypeIdentifierDietaryCopper;
				break;
			case 58: // HKQuantityTypeIdentifier.DietaryManganese
				ptr = HKQuantityTypeIdentifierDietaryManganese;
				break;
			case 59: // HKQuantityTypeIdentifier.DietaryChromium
				ptr = HKQuantityTypeIdentifierDietaryChromium;
				break;
			case 60: // HKQuantityTypeIdentifier.DietaryMolybdenum
				ptr = HKQuantityTypeIdentifierDietaryMolybdenum;
				break;
			case 61: // HKQuantityTypeIdentifier.DietaryChloride
				ptr = HKQuantityTypeIdentifierDietaryChloride;
				break;
			case 62: // HKQuantityTypeIdentifier.DietaryPotassium
				ptr = HKQuantityTypeIdentifierDietaryPotassium;
				break;
			case 63: // HKQuantityTypeIdentifier.DietaryCaffeine
				ptr = HKQuantityTypeIdentifierDietaryCaffeine;
				break;
			case 64: // HKQuantityTypeIdentifier.BasalBodyTemperature
				ptr = HKQuantityTypeIdentifierBasalBodyTemperature;
				break;
			case 65: // HKQuantityTypeIdentifier.DietaryWater
				ptr = HKQuantityTypeIdentifierDietaryWater;
				break;
			case 66: // HKQuantityTypeIdentifier.UVExposure
				ptr = HKQuantityTypeIdentifierUVExposure;
				break;
			case 67: // HKQuantityTypeIdentifier.ElectrodermalActivity
				ptr = HKQuantityTypeIdentifierElectrodermalActivity;
				break;
			case 68: // HKQuantityTypeIdentifier.AppleExerciseTime
				ptr = HKQuantityTypeIdentifierAppleExerciseTime;
				break;
			case 69: // HKQuantityTypeIdentifier.DistanceWheelchair
				ptr = HKQuantityTypeIdentifierDistanceWheelchair;
				break;
			case 70: // HKQuantityTypeIdentifier.PushCount
				ptr = HKQuantityTypeIdentifierPushCount;
				break;
			case 71: // HKQuantityTypeIdentifier.DistanceSwimming
				ptr = HKQuantityTypeIdentifierDistanceSwimming;
				break;
			case 72: // HKQuantityTypeIdentifier.SwimmingStrokeCount
				ptr = HKQuantityTypeIdentifierSwimmingStrokeCount;
				break;
			case 73: // HKQuantityTypeIdentifier.WaistCircumference
				ptr = HKQuantityTypeIdentifierWaistCircumference;
				break;
			case 74: // HKQuantityTypeIdentifier.VO2Max
				ptr = HKQuantityTypeIdentifierVO2Max;
				break;
			case 75: // HKQuantityTypeIdentifier.DistanceDownhillSnowSports
				ptr = HKQuantityTypeIdentifierDistanceDownhillSnowSports;
				break;
			case 76: // HKQuantityTypeIdentifier.InsulinDelivery
				ptr = HKQuantityTypeIdentifierInsulinDelivery;
				break;
			case 77: // HKQuantityTypeIdentifier.RestingHeartRate
				ptr = HKQuantityTypeIdentifierRestingHeartRate;
				break;
			case 78: // HKQuantityTypeIdentifier.WalkingHeartRateAverage
				ptr = HKQuantityTypeIdentifierWalkingHeartRateAverage;
				break;
			case 79: // HKQuantityTypeIdentifier.HeartRateVariabilitySdnn
				ptr = HKQuantityTypeIdentifierHeartRateVariabilitySDNN;
				break;
			case 80: // HKQuantityTypeIdentifier.AppleStandTime
				ptr = HKQuantityTypeIdentifierAppleStandTime;
				break;
			case 81: // HKQuantityTypeIdentifier.EnvironmentalAudioExposure
				ptr = HKQuantityTypeIdentifierEnvironmentalAudioExposure;
				break;
			case 82: // HKQuantityTypeIdentifier.HeadphoneAudioExposure
				ptr = HKQuantityTypeIdentifierHeadphoneAudioExposure;
				break;
			case 83: // HKQuantityTypeIdentifier.SixMinuteWalkTestDistance
				ptr = HKQuantityTypeIdentifierSixMinuteWalkTestDistance;
				break;
			case 84: // HKQuantityTypeIdentifier.StairAscentSpeed
				ptr = HKQuantityTypeIdentifierStairAscentSpeed;
				break;
			case 85: // HKQuantityTypeIdentifier.StairDescentSpeed
				ptr = HKQuantityTypeIdentifierStairDescentSpeed;
				break;
			case 86: // HKQuantityTypeIdentifier.WalkingAsymmetryPercentage
				ptr = HKQuantityTypeIdentifierWalkingAsymmetryPercentage;
				break;
			case 87: // HKQuantityTypeIdentifier.WalkingDoubleSupportPercentage
				ptr = HKQuantityTypeIdentifierWalkingDoubleSupportPercentage;
				break;
			case 88: // HKQuantityTypeIdentifier.WalkingSpeed
				ptr = HKQuantityTypeIdentifierWalkingSpeed;
				break;
			case 89: // HKQuantityTypeIdentifier.WalkingStepLength
				ptr = HKQuantityTypeIdentifierWalkingStepLength;
				break;
			case 90: // HKQuantityTypeIdentifier.AppleMoveTime
				ptr = HKQuantityTypeIdentifierAppleMoveTime;
				break;
			case 91: // HKQuantityTypeIdentifier.AppleWalkingSteadiness
				ptr = HKQuantityTypeIdentifierAppleWalkingSteadiness;
				break;
			case 92: // HKQuantityTypeIdentifier.NumberOfAlcoholicBeverages
				ptr = HKQuantityTypeIdentifierNumberOfAlcoholicBeverages;
				break;
			case 93: // HKQuantityTypeIdentifier.HeartRateRecoveryOneMinute
				ptr = HKQuantityTypeIdentifierHeartRateRecoveryOneMinute;
				break;
			case 94: // HKQuantityTypeIdentifier.RunningGroundContactTime
				ptr = HKQuantityTypeIdentifierRunningGroundContactTime;
				break;
			case 95: // HKQuantityTypeIdentifier.RunningStrideLength
				ptr = HKQuantityTypeIdentifierRunningStrideLength;
				break;
			case 96: // HKQuantityTypeIdentifier.RunningVerticalOscillation
				ptr = HKQuantityTypeIdentifierRunningVerticalOscillation;
				break;
			case 97: // HKQuantityTypeIdentifier.RunningPower
				ptr = HKQuantityTypeIdentifierRunningPower;
				break;
			case 98: // HKQuantityTypeIdentifier.RunningSpeed
				ptr = HKQuantityTypeIdentifierRunningSpeed;
				break;
			case 99: // HKQuantityTypeIdentifier.AtrialFibrillationBurden
				ptr = HKQuantityTypeIdentifierAtrialFibrillationBurden;
				break;
			case 100: // HKQuantityTypeIdentifier.AppleSleepingWristTemperature
				ptr = HKQuantityTypeIdentifierAppleSleepingWristTemperature;
				break;
			case 101: // HKQuantityTypeIdentifier.UnderwaterDepth
				ptr = HKQuantityTypeIdentifierUnderwaterDepth;
				break;
			case 102: // HKQuantityTypeIdentifier.WaterTemperature
				ptr = HKQuantityTypeIdentifierWaterTemperature;
				break;
			case 103: // HKQuantityTypeIdentifier.CyclingCadence
				ptr = HKQuantityTypeIdentifierCyclingCadence;
				break;
			case 104: // HKQuantityTypeIdentifier.CyclingFunctionalThresholdPower
				ptr = HKQuantityTypeIdentifierCyclingFunctionalThresholdPower;
				break;
			case 105: // HKQuantityTypeIdentifier.CyclingPower
				ptr = HKQuantityTypeIdentifierCyclingPower;
				break;
			case 106: // HKQuantityTypeIdentifier.CyclingSpeed
				ptr = HKQuantityTypeIdentifierCyclingSpeed;
				break;
			case 107: // HKQuantityTypeIdentifier.EnvironmentalSoundReduction
				ptr = HKQuantityTypeIdentifierEnvironmentalSoundReduction;
				break;
			case 108: // HKQuantityTypeIdentifier.PhysicalEffort
				ptr = HKQuantityTypeIdentifierPhysicalEffort;
				break;
			case 109: // HKQuantityTypeIdentifier.TimeInDaylight
				ptr = HKQuantityTypeIdentifierTimeInDaylight;
				break;
			case 110: // HKQuantityTypeIdentifier.WorkoutEffortScore
				ptr = HKQuantityTypeIdentifierWorkoutEffortScore;
				break;
			case 111: // HKQuantityTypeIdentifier.CrossCountrySkiingSpeed
				ptr = HKQuantityTypeIdentifierCrossCountrySkiingSpeed;
				break;
			case 112: // HKQuantityTypeIdentifier.DistanceCrossCountrySkiing
				ptr = HKQuantityTypeIdentifierDistanceCrossCountrySkiing;
				break;
			case 113: // HKQuantityTypeIdentifier.DistancePaddleSports
				ptr = HKQuantityTypeIdentifierDistancePaddleSports;
				break;
			case 114: // HKQuantityTypeIdentifier.DistanceRowing
				ptr = HKQuantityTypeIdentifierDistanceRowing;
				break;
			case 115: // HKQuantityTypeIdentifier.DistanceSkatingSports
				ptr = HKQuantityTypeIdentifierDistanceSkatingSports;
				break;
			case 116: // HKQuantityTypeIdentifier.EstimatedWorkoutEffortScore
				ptr = HKQuantityTypeIdentifierEstimatedWorkoutEffortScore;
				break;
			case 117: // HKQuantityTypeIdentifier.PaddleSportsSpeed
				ptr = HKQuantityTypeIdentifierPaddleSportsSpeed;
				break;
			case 118: // HKQuantityTypeIdentifier.RowingSpeed
				ptr = HKQuantityTypeIdentifierRowingSpeed;
				break;
			case 119: // HKQuantityTypeIdentifier.AppleSleepingBreathingDisturbances
				ptr = HKQuantityTypeIdentifierAppleSleepingBreathingDisturbances;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKQuantityTypeIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKQuantityTypeIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBodyMassIndex))
				return HKQuantityTypeIdentifier.BodyMassIndex;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBodyFatPercentage))
				return HKQuantityTypeIdentifier.BodyFatPercentage;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierHeight))
				return HKQuantityTypeIdentifier.Height;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBodyMass))
				return HKQuantityTypeIdentifier.BodyMass;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierLeanBodyMass))
				return HKQuantityTypeIdentifier.LeanBodyMass;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierHeartRate))
				return HKQuantityTypeIdentifier.HeartRate;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierStepCount))
				return HKQuantityTypeIdentifier.StepCount;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceWalkingRunning))
				return HKQuantityTypeIdentifier.DistanceWalkingRunning;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceCycling))
				return HKQuantityTypeIdentifier.DistanceCycling;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBasalEnergyBurned))
				return HKQuantityTypeIdentifier.BasalEnergyBurned;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierActiveEnergyBurned))
				return HKQuantityTypeIdentifier.ActiveEnergyBurned;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierFlightsClimbed))
				return HKQuantityTypeIdentifier.FlightsClimbed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierNikeFuel))
				return HKQuantityTypeIdentifier.NikeFuel;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierOxygenSaturation))
				return HKQuantityTypeIdentifier.OxygenSaturation;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBloodGlucose))
				return HKQuantityTypeIdentifier.BloodGlucose;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBloodPressureSystolic))
				return HKQuantityTypeIdentifier.BloodPressureSystolic;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBloodPressureDiastolic))
				return HKQuantityTypeIdentifier.BloodPressureDiastolic;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBloodAlcoholContent))
				return HKQuantityTypeIdentifier.BloodAlcoholContent;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierPeripheralPerfusionIndex))
				return HKQuantityTypeIdentifier.PeripheralPerfusionIndex;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierForcedVitalCapacity))
				return HKQuantityTypeIdentifier.ForcedVitalCapacity;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierForcedExpiratoryVolume1))
				return HKQuantityTypeIdentifier.ForcedExpiratoryVolume1;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierPeakExpiratoryFlowRate))
				return HKQuantityTypeIdentifier.PeakExpiratoryFlowRate;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierNumberOfTimesFallen))
				return HKQuantityTypeIdentifier.NumberOfTimesFallen;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierInhalerUsage))
				return HKQuantityTypeIdentifier.InhalerUsage;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRespiratoryRate))
				return HKQuantityTypeIdentifier.RespiratoryRate;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBodyTemperature))
				return HKQuantityTypeIdentifier.BodyTemperature;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFatTotal))
				return HKQuantityTypeIdentifier.DietaryFatTotal;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFatPolyunsaturated))
				return HKQuantityTypeIdentifier.DietaryFatPolyunsaturated;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFatMonounsaturated))
				return HKQuantityTypeIdentifier.DietaryFatMonounsaturated;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFatSaturated))
				return HKQuantityTypeIdentifier.DietaryFatSaturated;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryCholesterol))
				return HKQuantityTypeIdentifier.DietaryCholesterol;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietarySodium))
				return HKQuantityTypeIdentifier.DietarySodium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryCarbohydrates))
				return HKQuantityTypeIdentifier.DietaryCarbohydrates;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFiber))
				return HKQuantityTypeIdentifier.DietaryFiber;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietarySugar))
				return HKQuantityTypeIdentifier.DietarySugar;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryEnergyConsumed))
				return HKQuantityTypeIdentifier.DietaryEnergyConsumed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryProtein))
				return HKQuantityTypeIdentifier.DietaryProtein;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminA))
				return HKQuantityTypeIdentifier.DietaryVitaminA;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminB6))
				return HKQuantityTypeIdentifier.DietaryVitaminB6;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminB12))
				return HKQuantityTypeIdentifier.DietaryVitaminB12;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminC))
				return HKQuantityTypeIdentifier.DietaryVitaminC;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminD))
				return HKQuantityTypeIdentifier.DietaryVitaminD;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminE))
				return HKQuantityTypeIdentifier.DietaryVitaminE;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryVitaminK))
				return HKQuantityTypeIdentifier.DietaryVitaminK;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryCalcium))
				return HKQuantityTypeIdentifier.DietaryCalcium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryIron))
				return HKQuantityTypeIdentifier.DietaryIron;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryThiamin))
				return HKQuantityTypeIdentifier.DietaryThiamin;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryRiboflavin))
				return HKQuantityTypeIdentifier.DietaryRiboflavin;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryNiacin))
				return HKQuantityTypeIdentifier.DietaryNiacin;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryFolate))
				return HKQuantityTypeIdentifier.DietaryFolate;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryBiotin))
				return HKQuantityTypeIdentifier.DietaryBiotin;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryPantothenicAcid))
				return HKQuantityTypeIdentifier.DietaryPantothenicAcid;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryPhosphorus))
				return HKQuantityTypeIdentifier.DietaryPhosphorus;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryIodine))
				return HKQuantityTypeIdentifier.DietaryIodine;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryMagnesium))
				return HKQuantityTypeIdentifier.DietaryMagnesium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryZinc))
				return HKQuantityTypeIdentifier.DietaryZinc;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietarySelenium))
				return HKQuantityTypeIdentifier.DietarySelenium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryCopper))
				return HKQuantityTypeIdentifier.DietaryCopper;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryManganese))
				return HKQuantityTypeIdentifier.DietaryManganese;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryChromium))
				return HKQuantityTypeIdentifier.DietaryChromium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryMolybdenum))
				return HKQuantityTypeIdentifier.DietaryMolybdenum;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryChloride))
				return HKQuantityTypeIdentifier.DietaryChloride;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryPotassium))
				return HKQuantityTypeIdentifier.DietaryPotassium;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryCaffeine))
				return HKQuantityTypeIdentifier.DietaryCaffeine;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierBasalBodyTemperature))
				return HKQuantityTypeIdentifier.BasalBodyTemperature;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDietaryWater))
				return HKQuantityTypeIdentifier.DietaryWater;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierUVExposure))
				return HKQuantityTypeIdentifier.UVExposure;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierElectrodermalActivity))
				return HKQuantityTypeIdentifier.ElectrodermalActivity;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleExerciseTime))
				return HKQuantityTypeIdentifier.AppleExerciseTime;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceWheelchair))
				return HKQuantityTypeIdentifier.DistanceWheelchair;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierPushCount))
				return HKQuantityTypeIdentifier.PushCount;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceSwimming))
				return HKQuantityTypeIdentifier.DistanceSwimming;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierSwimmingStrokeCount))
				return HKQuantityTypeIdentifier.SwimmingStrokeCount;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWaistCircumference))
				return HKQuantityTypeIdentifier.WaistCircumference;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierVO2Max))
				return HKQuantityTypeIdentifier.VO2Max;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceDownhillSnowSports))
				return HKQuantityTypeIdentifier.DistanceDownhillSnowSports;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierInsulinDelivery))
				return HKQuantityTypeIdentifier.InsulinDelivery;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRestingHeartRate))
				return HKQuantityTypeIdentifier.RestingHeartRate;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWalkingHeartRateAverage))
				return HKQuantityTypeIdentifier.WalkingHeartRateAverage;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierHeartRateVariabilitySDNN))
				return HKQuantityTypeIdentifier.HeartRateVariabilitySdnn;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleStandTime))
				return HKQuantityTypeIdentifier.AppleStandTime;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierEnvironmentalAudioExposure))
				return HKQuantityTypeIdentifier.EnvironmentalAudioExposure;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierHeadphoneAudioExposure))
				return HKQuantityTypeIdentifier.HeadphoneAudioExposure;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierSixMinuteWalkTestDistance))
				return HKQuantityTypeIdentifier.SixMinuteWalkTestDistance;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierStairAscentSpeed))
				return HKQuantityTypeIdentifier.StairAscentSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierStairDescentSpeed))
				return HKQuantityTypeIdentifier.StairDescentSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWalkingAsymmetryPercentage))
				return HKQuantityTypeIdentifier.WalkingAsymmetryPercentage;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWalkingDoubleSupportPercentage))
				return HKQuantityTypeIdentifier.WalkingDoubleSupportPercentage;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWalkingSpeed))
				return HKQuantityTypeIdentifier.WalkingSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWalkingStepLength))
				return HKQuantityTypeIdentifier.WalkingStepLength;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleMoveTime))
				return HKQuantityTypeIdentifier.AppleMoveTime;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleWalkingSteadiness))
				return HKQuantityTypeIdentifier.AppleWalkingSteadiness;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierNumberOfAlcoholicBeverages))
				return HKQuantityTypeIdentifier.NumberOfAlcoholicBeverages;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierHeartRateRecoveryOneMinute))
				return HKQuantityTypeIdentifier.HeartRateRecoveryOneMinute;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRunningGroundContactTime))
				return HKQuantityTypeIdentifier.RunningGroundContactTime;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRunningStrideLength))
				return HKQuantityTypeIdentifier.RunningStrideLength;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRunningVerticalOscillation))
				return HKQuantityTypeIdentifier.RunningVerticalOscillation;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRunningPower))
				return HKQuantityTypeIdentifier.RunningPower;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRunningSpeed))
				return HKQuantityTypeIdentifier.RunningSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAtrialFibrillationBurden))
				return HKQuantityTypeIdentifier.AtrialFibrillationBurden;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleSleepingWristTemperature))
				return HKQuantityTypeIdentifier.AppleSleepingWristTemperature;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierUnderwaterDepth))
				return HKQuantityTypeIdentifier.UnderwaterDepth;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWaterTemperature))
				return HKQuantityTypeIdentifier.WaterTemperature;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierCyclingCadence))
				return HKQuantityTypeIdentifier.CyclingCadence;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierCyclingFunctionalThresholdPower))
				return HKQuantityTypeIdentifier.CyclingFunctionalThresholdPower;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierCyclingPower))
				return HKQuantityTypeIdentifier.CyclingPower;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierCyclingSpeed))
				return HKQuantityTypeIdentifier.CyclingSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierEnvironmentalSoundReduction))
				return HKQuantityTypeIdentifier.EnvironmentalSoundReduction;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierPhysicalEffort))
				return HKQuantityTypeIdentifier.PhysicalEffort;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierTimeInDaylight))
				return HKQuantityTypeIdentifier.TimeInDaylight;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierWorkoutEffortScore))
				return HKQuantityTypeIdentifier.WorkoutEffortScore;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierCrossCountrySkiingSpeed))
				return HKQuantityTypeIdentifier.CrossCountrySkiingSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceCrossCountrySkiing))
				return HKQuantityTypeIdentifier.DistanceCrossCountrySkiing;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistancePaddleSports))
				return HKQuantityTypeIdentifier.DistancePaddleSports;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceRowing))
				return HKQuantityTypeIdentifier.DistanceRowing;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierDistanceSkatingSports))
				return HKQuantityTypeIdentifier.DistanceSkatingSports;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierEstimatedWorkoutEffortScore))
				return HKQuantityTypeIdentifier.EstimatedWorkoutEffortScore;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierPaddleSportsSpeed))
				return HKQuantityTypeIdentifier.PaddleSportsSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierRowingSpeed))
				return HKQuantityTypeIdentifier.RowingSpeed;
			if (constant.IsEqualTo (HKQuantityTypeIdentifierAppleSleepingBreathingDisturbances))
				return HKQuantityTypeIdentifier.AppleSleepingBreathingDisturbances;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKQuantityTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKQuantityTypeIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKQuantityTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKQuantityTypeIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKQuantityTypeIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKQuantityTypeIdentifier[]? values)
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
		internal static HKQuantityTypeIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKQuantityTypeIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
