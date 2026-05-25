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
	/// <summary>Enumerates the types of <see cref="T:HealthKit.HKCategoryType" />s.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKCategoryTypeIdentifier : int {
		/// <summary>The sleep analysis category.</summary>
		SleepAnalysis = 0,
		/// <summary>Indicates a category whose value indicates whether the user stood for one minute in an hour.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		AppleStandHour = 1,
		/// <summary>Indicates a category whose value indicates the user's cervical mucous quality.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		CervicalMucusQuality = 2,
		/// <summary>Indicates a category whose value indicates the user's ovulation test result.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		OvulationTestResult = 3,
		/// <summary>Indicates a category whose value indicates the user's menstrual flow.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		MenstrualFlow = 4,
		/// <summary>Indicates a category whose value indicates whether the user experienced intermenstrual bleeding.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		IntermenstrualBleeding = 5,
		/// <summary>Indicates a category whose value indicates the user's sexual activity.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		SexualActivity = 6,
		/// <summary>Indicates a category whose value indicates the user's mindfulness session.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		MindfulSession = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		HighHeartRateEvent = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		LowHeartRateEvent = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		IrregularHeartRhythmEvent = 10,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AudioExposureEvent = 11,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		ToothbrushingEvent = 12,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AbdominalCramps = 13,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Acne = 14,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AppetiteChanges = 15,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		GeneralizedBodyAche = 16,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Bloating = 17,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		BreastPain = 18,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		ChestTightnessOrPain = 19,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Chills = 20,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Constipation = 21,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Coughing = 22,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Diarrhea = 23,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Dizziness = 24,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Fainting = 25,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Fatigue = 26,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Fever = 27,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Headache = 28,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Heartburn = 29,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		HotFlashes = 30,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		LowerBackPain = 31,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		LossOfSmell = 32,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		LossOfTaste = 33,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		MoodChanges = 34,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Nausea = 35,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		PelvicPain = 36,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		RapidPoundingOrFlutteringHeartbeat = 37,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		RunnyNose = 38,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		ShortnessOfBreath = 39,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SinusCongestion = 40,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SkippedHeartbeat = 41,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SleepChanges = 42,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SoreThroat = 43,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Vomiting = 44,
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Wheezing = 45,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		BladderIncontinence = 46,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		DrySkin = 47,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		HairLoss = 48,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		VaginalDryness = 49,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		MemoryLapse = 50,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		NightSweats = 51,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		EnvironmentalAudioExposureEvent = 52,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		HandwashingEvent = 53,
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		HeadphoneAudioExposureEvent = 54,
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Pregnancy = 55,
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Lactation = 56,
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Contraceptive = 57,
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		LowCardioFitnessEvent = 58,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		AppleWalkingSteadinessEvent = 59,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		PregnancyTestResult = 60,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		ProgesteroneTestResult = 61,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		InfrequentMenstrualCycles = 62,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		IrregularMenstrualCycles = 63,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		PersistentIntermenstrualBleeding = 64,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		ProlongedMenstrualPeriods = 65,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		BleedingAfterPregnancy = 66,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		BleedingDuringPregnancy = 67,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		SleepApneaEvent = 68,
		[SupportedOSPlatform ("maccatalyst26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		HypertensionEvent = 69,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKCategoryTypeIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKCategoryTypeIdentifierExtensions {
		static IntPtr[] values = new IntPtr [70];
		[Field ("HKCategoryTypeIdentifierSleepAnalysis", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSleepAnalysis {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSleepAnalysis", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAppleStandHour", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAppleStandHour {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAppleStandHour", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierCervicalMucusQuality", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierCervicalMucusQuality {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierCervicalMucusQuality", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierOvulationTestResult", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierOvulationTestResult {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierOvulationTestResult", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierMenstrualFlow", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierMenstrualFlow {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierMenstrualFlow", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierIntermenstrualBleeding", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierIntermenstrualBleeding {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierIntermenstrualBleeding", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierSexualActivity", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSexualActivity {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSexualActivity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierMindfulSession", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierMindfulSession {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierMindfulSession", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHighHeartRateEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHighHeartRateEvent {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHighHeartRateEvent", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLowHeartRateEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLowHeartRateEvent {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLowHeartRateEvent", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierIrregularHeartRhythmEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierIrregularHeartRhythmEvent {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierIrregularHeartRhythmEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAudioExposureEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAudioExposureEvent {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAudioExposureEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierToothbrushingEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierToothbrushingEvent {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierToothbrushingEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAbdominalCramps", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAbdominalCramps {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAbdominalCramps", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAcne", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAcne {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAcne", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAppetiteChanges", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAppetiteChanges {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAppetiteChanges", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierGeneralizedBodyAche", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierGeneralizedBodyAche {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierGeneralizedBodyAche", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierBloating", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierBloating {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierBloating", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierBreastPain", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierBreastPain {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierBreastPain", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierChestTightnessOrPain", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierChestTightnessOrPain {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierChestTightnessOrPain", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierChills", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierChills {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierChills", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierConstipation", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierConstipation {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierConstipation", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierCoughing", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierCoughing {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierCoughing", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierDiarrhea", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierDiarrhea {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierDiarrhea", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierDizziness", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierDizziness {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierDizziness", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierFainting", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierFainting {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierFainting", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierFatigue", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierFatigue {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierFatigue", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierFever", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierFever {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierFever", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHeadache", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHeadache {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHeadache", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHeartburn", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHeartburn {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHeartburn", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHotFlashes", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHotFlashes {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHotFlashes", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLowerBackPain", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLowerBackPain {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLowerBackPain", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLossOfSmell", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLossOfSmell {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLossOfSmell", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLossOfTaste", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLossOfTaste {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLossOfTaste", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierMoodChanges", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierMoodChanges {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierMoodChanges", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierNausea", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierNausea {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierNausea", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierPelvicPain", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierPelvicPain {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierPelvicPain", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierRapidPoundingOrFlutteringHeartbeat", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierRapidPoundingOrFlutteringHeartbeat {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierRapidPoundingOrFlutteringHeartbeat", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierRunnyNose", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierRunnyNose {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierRunnyNose", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierShortnessOfBreath", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierShortnessOfBreath {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierShortnessOfBreath", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierSinusCongestion", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSinusCongestion {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSinusCongestion", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierSkippedHeartbeat", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSkippedHeartbeat {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSkippedHeartbeat", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierSleepChanges", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSleepChanges {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSleepChanges", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierSoreThroat", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSoreThroat {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSoreThroat", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierVomiting", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierVomiting {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierVomiting", storage);
			}
		}
		[SupportedOSPlatform ("ios13.6")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierWheezing", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierWheezing {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierWheezing", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierBladderIncontinence", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierBladderIncontinence {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierBladderIncontinence", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierDrySkin", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierDrySkin {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierDrySkin", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHairLoss", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHairLoss {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHairLoss", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierVaginalDryness", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierVaginalDryness {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierVaginalDryness", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierMemoryLapse", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierMemoryLapse {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierMemoryLapse", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierNightSweats", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierNightSweats {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierNightSweats", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierEnvironmentalAudioExposureEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierEnvironmentalAudioExposureEvent {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierEnvironmentalAudioExposureEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHandwashingEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHandwashingEvent {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHandwashingEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierHeadphoneAudioExposureEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHeadphoneAudioExposureEvent {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHeadphoneAudioExposureEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierPregnancy", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierPregnancy {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierPregnancy", storage);
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLactation", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLactation {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLactation", storage);
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierContraceptive", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierContraceptive {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierContraceptive", storage);
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierLowCardioFitnessEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierLowCardioFitnessEvent {
			get {
				fixed (IntPtr *storage = &values [58])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierLowCardioFitnessEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierAppleWalkingSteadinessEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierAppleWalkingSteadinessEvent {
			get {
				fixed (IntPtr *storage = &values [59])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierAppleWalkingSteadinessEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierPregnancyTestResult", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierPregnancyTestResult {
			get {
				fixed (IntPtr *storage = &values [60])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierPregnancyTestResult", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCategoryTypeIdentifierProgesteroneTestResult", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierProgesteroneTestResult {
			get {
				fixed (IntPtr *storage = &values [61])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierProgesteroneTestResult", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKCategoryTypeIdentifierInfrequentMenstrualCycles", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierInfrequentMenstrualCycles {
			get {
				fixed (IntPtr *storage = &values [62])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierInfrequentMenstrualCycles", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKCategoryTypeIdentifierIrregularMenstrualCycles", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierIrregularMenstrualCycles {
			get {
				fixed (IntPtr *storage = &values [63])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierIrregularMenstrualCycles", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKCategoryTypeIdentifierPersistentIntermenstrualBleeding", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierPersistentIntermenstrualBleeding {
			get {
				fixed (IntPtr *storage = &values [64])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierPersistentIntermenstrualBleeding", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[Field ("HKCategoryTypeIdentifierProlongedMenstrualPeriods", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierProlongedMenstrualPeriods {
			get {
				fixed (IntPtr *storage = &values [65])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierProlongedMenstrualPeriods", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKCategoryTypeIdentifierBleedingAfterPregnancy", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierBleedingAfterPregnancy {
			get {
				fixed (IntPtr *storage = &values [66])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierBleedingAfterPregnancy", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKCategoryTypeIdentifierBleedingDuringPregnancy", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierBleedingDuringPregnancy {
			get {
				fixed (IntPtr *storage = &values [67])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierBleedingDuringPregnancy", storage);
			}
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Field ("HKCategoryTypeIdentifierSleepApneaEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierSleepApneaEvent {
			get {
				fixed (IntPtr *storage = &values [68])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierSleepApneaEvent", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		[Field ("HKCategoryTypeIdentifierHypertensionEvent", "HealthKit")]
		internal unsafe static IntPtr HKCategoryTypeIdentifierHypertensionEvent {
			get {
				fixed (IntPtr *storage = &values [69])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCategoryTypeIdentifierHypertensionEvent", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKCategoryTypeIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKCategoryTypeIdentifier.SleepAnalysis
				ptr = HKCategoryTypeIdentifierSleepAnalysis;
				break;
			case 1: // HKCategoryTypeIdentifier.AppleStandHour
				ptr = HKCategoryTypeIdentifierAppleStandHour;
				break;
			case 2: // HKCategoryTypeIdentifier.CervicalMucusQuality
				ptr = HKCategoryTypeIdentifierCervicalMucusQuality;
				break;
			case 3: // HKCategoryTypeIdentifier.OvulationTestResult
				ptr = HKCategoryTypeIdentifierOvulationTestResult;
				break;
			case 4: // HKCategoryTypeIdentifier.MenstrualFlow
				ptr = HKCategoryTypeIdentifierMenstrualFlow;
				break;
			case 5: // HKCategoryTypeIdentifier.IntermenstrualBleeding
				ptr = HKCategoryTypeIdentifierIntermenstrualBleeding;
				break;
			case 6: // HKCategoryTypeIdentifier.SexualActivity
				ptr = HKCategoryTypeIdentifierSexualActivity;
				break;
			case 7: // HKCategoryTypeIdentifier.MindfulSession
				ptr = HKCategoryTypeIdentifierMindfulSession;
				break;
			case 8: // HKCategoryTypeIdentifier.HighHeartRateEvent
				ptr = HKCategoryTypeIdentifierHighHeartRateEvent;
				break;
			case 9: // HKCategoryTypeIdentifier.LowHeartRateEvent
				ptr = HKCategoryTypeIdentifierLowHeartRateEvent;
				break;
			case 10: // HKCategoryTypeIdentifier.IrregularHeartRhythmEvent
				ptr = HKCategoryTypeIdentifierIrregularHeartRhythmEvent;
				break;
			case 11: // HKCategoryTypeIdentifier.AudioExposureEvent
				ptr = HKCategoryTypeIdentifierAudioExposureEvent;
				break;
			case 12: // HKCategoryTypeIdentifier.ToothbrushingEvent
				ptr = HKCategoryTypeIdentifierToothbrushingEvent;
				break;
			case 13: // HKCategoryTypeIdentifier.AbdominalCramps
				ptr = HKCategoryTypeIdentifierAbdominalCramps;
				break;
			case 14: // HKCategoryTypeIdentifier.Acne
				ptr = HKCategoryTypeIdentifierAcne;
				break;
			case 15: // HKCategoryTypeIdentifier.AppetiteChanges
				ptr = HKCategoryTypeIdentifierAppetiteChanges;
				break;
			case 16: // HKCategoryTypeIdentifier.GeneralizedBodyAche
				ptr = HKCategoryTypeIdentifierGeneralizedBodyAche;
				break;
			case 17: // HKCategoryTypeIdentifier.Bloating
				ptr = HKCategoryTypeIdentifierBloating;
				break;
			case 18: // HKCategoryTypeIdentifier.BreastPain
				ptr = HKCategoryTypeIdentifierBreastPain;
				break;
			case 19: // HKCategoryTypeIdentifier.ChestTightnessOrPain
				ptr = HKCategoryTypeIdentifierChestTightnessOrPain;
				break;
			case 20: // HKCategoryTypeIdentifier.Chills
				ptr = HKCategoryTypeIdentifierChills;
				break;
			case 21: // HKCategoryTypeIdentifier.Constipation
				ptr = HKCategoryTypeIdentifierConstipation;
				break;
			case 22: // HKCategoryTypeIdentifier.Coughing
				ptr = HKCategoryTypeIdentifierCoughing;
				break;
			case 23: // HKCategoryTypeIdentifier.Diarrhea
				ptr = HKCategoryTypeIdentifierDiarrhea;
				break;
			case 24: // HKCategoryTypeIdentifier.Dizziness
				ptr = HKCategoryTypeIdentifierDizziness;
				break;
			case 25: // HKCategoryTypeIdentifier.Fainting
				ptr = HKCategoryTypeIdentifierFainting;
				break;
			case 26: // HKCategoryTypeIdentifier.Fatigue
				ptr = HKCategoryTypeIdentifierFatigue;
				break;
			case 27: // HKCategoryTypeIdentifier.Fever
				ptr = HKCategoryTypeIdentifierFever;
				break;
			case 28: // HKCategoryTypeIdentifier.Headache
				ptr = HKCategoryTypeIdentifierHeadache;
				break;
			case 29: // HKCategoryTypeIdentifier.Heartburn
				ptr = HKCategoryTypeIdentifierHeartburn;
				break;
			case 30: // HKCategoryTypeIdentifier.HotFlashes
				ptr = HKCategoryTypeIdentifierHotFlashes;
				break;
			case 31: // HKCategoryTypeIdentifier.LowerBackPain
				ptr = HKCategoryTypeIdentifierLowerBackPain;
				break;
			case 32: // HKCategoryTypeIdentifier.LossOfSmell
				ptr = HKCategoryTypeIdentifierLossOfSmell;
				break;
			case 33: // HKCategoryTypeIdentifier.LossOfTaste
				ptr = HKCategoryTypeIdentifierLossOfTaste;
				break;
			case 34: // HKCategoryTypeIdentifier.MoodChanges
				ptr = HKCategoryTypeIdentifierMoodChanges;
				break;
			case 35: // HKCategoryTypeIdentifier.Nausea
				ptr = HKCategoryTypeIdentifierNausea;
				break;
			case 36: // HKCategoryTypeIdentifier.PelvicPain
				ptr = HKCategoryTypeIdentifierPelvicPain;
				break;
			case 37: // HKCategoryTypeIdentifier.RapidPoundingOrFlutteringHeartbeat
				ptr = HKCategoryTypeIdentifierRapidPoundingOrFlutteringHeartbeat;
				break;
			case 38: // HKCategoryTypeIdentifier.RunnyNose
				ptr = HKCategoryTypeIdentifierRunnyNose;
				break;
			case 39: // HKCategoryTypeIdentifier.ShortnessOfBreath
				ptr = HKCategoryTypeIdentifierShortnessOfBreath;
				break;
			case 40: // HKCategoryTypeIdentifier.SinusCongestion
				ptr = HKCategoryTypeIdentifierSinusCongestion;
				break;
			case 41: // HKCategoryTypeIdentifier.SkippedHeartbeat
				ptr = HKCategoryTypeIdentifierSkippedHeartbeat;
				break;
			case 42: // HKCategoryTypeIdentifier.SleepChanges
				ptr = HKCategoryTypeIdentifierSleepChanges;
				break;
			case 43: // HKCategoryTypeIdentifier.SoreThroat
				ptr = HKCategoryTypeIdentifierSoreThroat;
				break;
			case 44: // HKCategoryTypeIdentifier.Vomiting
				ptr = HKCategoryTypeIdentifierVomiting;
				break;
			case 45: // HKCategoryTypeIdentifier.Wheezing
				ptr = HKCategoryTypeIdentifierWheezing;
				break;
			case 46: // HKCategoryTypeIdentifier.BladderIncontinence
				ptr = HKCategoryTypeIdentifierBladderIncontinence;
				break;
			case 47: // HKCategoryTypeIdentifier.DrySkin
				ptr = HKCategoryTypeIdentifierDrySkin;
				break;
			case 48: // HKCategoryTypeIdentifier.HairLoss
				ptr = HKCategoryTypeIdentifierHairLoss;
				break;
			case 49: // HKCategoryTypeIdentifier.VaginalDryness
				ptr = HKCategoryTypeIdentifierVaginalDryness;
				break;
			case 50: // HKCategoryTypeIdentifier.MemoryLapse
				ptr = HKCategoryTypeIdentifierMemoryLapse;
				break;
			case 51: // HKCategoryTypeIdentifier.NightSweats
				ptr = HKCategoryTypeIdentifierNightSweats;
				break;
			case 52: // HKCategoryTypeIdentifier.EnvironmentalAudioExposureEvent
				ptr = HKCategoryTypeIdentifierEnvironmentalAudioExposureEvent;
				break;
			case 53: // HKCategoryTypeIdentifier.HandwashingEvent
				ptr = HKCategoryTypeIdentifierHandwashingEvent;
				break;
			case 54: // HKCategoryTypeIdentifier.HeadphoneAudioExposureEvent
				ptr = HKCategoryTypeIdentifierHeadphoneAudioExposureEvent;
				break;
			case 55: // HKCategoryTypeIdentifier.Pregnancy
				ptr = HKCategoryTypeIdentifierPregnancy;
				break;
			case 56: // HKCategoryTypeIdentifier.Lactation
				ptr = HKCategoryTypeIdentifierLactation;
				break;
			case 57: // HKCategoryTypeIdentifier.Contraceptive
				ptr = HKCategoryTypeIdentifierContraceptive;
				break;
			case 58: // HKCategoryTypeIdentifier.LowCardioFitnessEvent
				ptr = HKCategoryTypeIdentifierLowCardioFitnessEvent;
				break;
			case 59: // HKCategoryTypeIdentifier.AppleWalkingSteadinessEvent
				ptr = HKCategoryTypeIdentifierAppleWalkingSteadinessEvent;
				break;
			case 60: // HKCategoryTypeIdentifier.PregnancyTestResult
				ptr = HKCategoryTypeIdentifierPregnancyTestResult;
				break;
			case 61: // HKCategoryTypeIdentifier.ProgesteroneTestResult
				ptr = HKCategoryTypeIdentifierProgesteroneTestResult;
				break;
			case 62: // HKCategoryTypeIdentifier.InfrequentMenstrualCycles
				ptr = HKCategoryTypeIdentifierInfrequentMenstrualCycles;
				break;
			case 63: // HKCategoryTypeIdentifier.IrregularMenstrualCycles
				ptr = HKCategoryTypeIdentifierIrregularMenstrualCycles;
				break;
			case 64: // HKCategoryTypeIdentifier.PersistentIntermenstrualBleeding
				ptr = HKCategoryTypeIdentifierPersistentIntermenstrualBleeding;
				break;
			case 65: // HKCategoryTypeIdentifier.ProlongedMenstrualPeriods
				ptr = HKCategoryTypeIdentifierProlongedMenstrualPeriods;
				break;
			case 66: // HKCategoryTypeIdentifier.BleedingAfterPregnancy
				ptr = HKCategoryTypeIdentifierBleedingAfterPregnancy;
				break;
			case 67: // HKCategoryTypeIdentifier.BleedingDuringPregnancy
				ptr = HKCategoryTypeIdentifierBleedingDuringPregnancy;
				break;
			case 68: // HKCategoryTypeIdentifier.SleepApneaEvent
				ptr = HKCategoryTypeIdentifierSleepApneaEvent;
				break;
			case 69: // HKCategoryTypeIdentifier.HypertensionEvent
				ptr = HKCategoryTypeIdentifierHypertensionEvent;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCategoryTypeIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKCategoryTypeIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSleepAnalysis))
				return HKCategoryTypeIdentifier.SleepAnalysis;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAppleStandHour))
				return HKCategoryTypeIdentifier.AppleStandHour;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierCervicalMucusQuality))
				return HKCategoryTypeIdentifier.CervicalMucusQuality;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierOvulationTestResult))
				return HKCategoryTypeIdentifier.OvulationTestResult;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierMenstrualFlow))
				return HKCategoryTypeIdentifier.MenstrualFlow;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierIntermenstrualBleeding))
				return HKCategoryTypeIdentifier.IntermenstrualBleeding;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSexualActivity))
				return HKCategoryTypeIdentifier.SexualActivity;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierMindfulSession))
				return HKCategoryTypeIdentifier.MindfulSession;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHighHeartRateEvent))
				return HKCategoryTypeIdentifier.HighHeartRateEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLowHeartRateEvent))
				return HKCategoryTypeIdentifier.LowHeartRateEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierIrregularHeartRhythmEvent))
				return HKCategoryTypeIdentifier.IrregularHeartRhythmEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAudioExposureEvent))
				return HKCategoryTypeIdentifier.AudioExposureEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierToothbrushingEvent))
				return HKCategoryTypeIdentifier.ToothbrushingEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAbdominalCramps))
				return HKCategoryTypeIdentifier.AbdominalCramps;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAcne))
				return HKCategoryTypeIdentifier.Acne;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAppetiteChanges))
				return HKCategoryTypeIdentifier.AppetiteChanges;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierGeneralizedBodyAche))
				return HKCategoryTypeIdentifier.GeneralizedBodyAche;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierBloating))
				return HKCategoryTypeIdentifier.Bloating;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierBreastPain))
				return HKCategoryTypeIdentifier.BreastPain;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierChestTightnessOrPain))
				return HKCategoryTypeIdentifier.ChestTightnessOrPain;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierChills))
				return HKCategoryTypeIdentifier.Chills;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierConstipation))
				return HKCategoryTypeIdentifier.Constipation;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierCoughing))
				return HKCategoryTypeIdentifier.Coughing;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierDiarrhea))
				return HKCategoryTypeIdentifier.Diarrhea;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierDizziness))
				return HKCategoryTypeIdentifier.Dizziness;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierFainting))
				return HKCategoryTypeIdentifier.Fainting;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierFatigue))
				return HKCategoryTypeIdentifier.Fatigue;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierFever))
				return HKCategoryTypeIdentifier.Fever;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHeadache))
				return HKCategoryTypeIdentifier.Headache;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHeartburn))
				return HKCategoryTypeIdentifier.Heartburn;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHotFlashes))
				return HKCategoryTypeIdentifier.HotFlashes;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLowerBackPain))
				return HKCategoryTypeIdentifier.LowerBackPain;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLossOfSmell))
				return HKCategoryTypeIdentifier.LossOfSmell;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLossOfTaste))
				return HKCategoryTypeIdentifier.LossOfTaste;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierMoodChanges))
				return HKCategoryTypeIdentifier.MoodChanges;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierNausea))
				return HKCategoryTypeIdentifier.Nausea;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierPelvicPain))
				return HKCategoryTypeIdentifier.PelvicPain;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierRapidPoundingOrFlutteringHeartbeat))
				return HKCategoryTypeIdentifier.RapidPoundingOrFlutteringHeartbeat;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierRunnyNose))
				return HKCategoryTypeIdentifier.RunnyNose;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierShortnessOfBreath))
				return HKCategoryTypeIdentifier.ShortnessOfBreath;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSinusCongestion))
				return HKCategoryTypeIdentifier.SinusCongestion;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSkippedHeartbeat))
				return HKCategoryTypeIdentifier.SkippedHeartbeat;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSleepChanges))
				return HKCategoryTypeIdentifier.SleepChanges;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSoreThroat))
				return HKCategoryTypeIdentifier.SoreThroat;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierVomiting))
				return HKCategoryTypeIdentifier.Vomiting;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierWheezing))
				return HKCategoryTypeIdentifier.Wheezing;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierBladderIncontinence))
				return HKCategoryTypeIdentifier.BladderIncontinence;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierDrySkin))
				return HKCategoryTypeIdentifier.DrySkin;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHairLoss))
				return HKCategoryTypeIdentifier.HairLoss;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierVaginalDryness))
				return HKCategoryTypeIdentifier.VaginalDryness;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierMemoryLapse))
				return HKCategoryTypeIdentifier.MemoryLapse;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierNightSweats))
				return HKCategoryTypeIdentifier.NightSweats;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierEnvironmentalAudioExposureEvent))
				return HKCategoryTypeIdentifier.EnvironmentalAudioExposureEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHandwashingEvent))
				return HKCategoryTypeIdentifier.HandwashingEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHeadphoneAudioExposureEvent))
				return HKCategoryTypeIdentifier.HeadphoneAudioExposureEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierPregnancy))
				return HKCategoryTypeIdentifier.Pregnancy;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLactation))
				return HKCategoryTypeIdentifier.Lactation;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierContraceptive))
				return HKCategoryTypeIdentifier.Contraceptive;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierLowCardioFitnessEvent))
				return HKCategoryTypeIdentifier.LowCardioFitnessEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierAppleWalkingSteadinessEvent))
				return HKCategoryTypeIdentifier.AppleWalkingSteadinessEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierPregnancyTestResult))
				return HKCategoryTypeIdentifier.PregnancyTestResult;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierProgesteroneTestResult))
				return HKCategoryTypeIdentifier.ProgesteroneTestResult;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierInfrequentMenstrualCycles))
				return HKCategoryTypeIdentifier.InfrequentMenstrualCycles;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierIrregularMenstrualCycles))
				return HKCategoryTypeIdentifier.IrregularMenstrualCycles;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierPersistentIntermenstrualBleeding))
				return HKCategoryTypeIdentifier.PersistentIntermenstrualBleeding;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierProlongedMenstrualPeriods))
				return HKCategoryTypeIdentifier.ProlongedMenstrualPeriods;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierBleedingAfterPregnancy))
				return HKCategoryTypeIdentifier.BleedingAfterPregnancy;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierBleedingDuringPregnancy))
				return HKCategoryTypeIdentifier.BleedingDuringPregnancy;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierSleepApneaEvent))
				return HKCategoryTypeIdentifier.SleepApneaEvent;
			if (constant.IsEqualTo (HKCategoryTypeIdentifierHypertensionEvent))
				return HKCategoryTypeIdentifier.HypertensionEvent;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCategoryTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCategoryTypeIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCategoryTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCategoryTypeIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKCategoryTypeIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKCategoryTypeIdentifier[]? values)
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
		internal static HKCategoryTypeIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKCategoryTypeIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
