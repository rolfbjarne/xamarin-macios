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
	/// <summary>Definitions and utility methods for manipulating measurements of mass, length, volume, and energy.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKUnit_Class/index.html">Apple documentation for <c>HKUnit</c></related>
	[Register("HKUnit", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKUnit : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppleEffortScoreUnitX = "appleEffortScoreUnit";
		static readonly NativeHandle selAppleEffortScoreUnitXHandle = Selector.GetHandle ("appleEffortScoreUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAtmosphereUnitX = "atmosphereUnit";
		static readonly NativeHandle selAtmosphereUnitXHandle = Selector.GetHandle ("atmosphereUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalorieUnitX = "calorieUnit";
		static readonly NativeHandle selCalorieUnitXHandle = Selector.GetHandle ("calorieUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCentimeterOfWaterUnitX = "centimeterOfWaterUnit";
		static readonly NativeHandle selCentimeterOfWaterUnitXHandle = Selector.GetHandle ("centimeterOfWaterUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountUnitX = "countUnit";
		static readonly NativeHandle selCountUnitXHandle = Selector.GetHandle ("countUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCupImperialUnitX = "cupImperialUnit";
		static readonly NativeHandle selCupImperialUnitXHandle = Selector.GetHandle ("cupImperialUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCupUSUnitX = "cupUSUnit";
		static readonly NativeHandle selCupUSUnitXHandle = Selector.GetHandle ("cupUSUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDayUnitX = "dayUnit";
		static readonly NativeHandle selDayUnitXHandle = Selector.GetHandle ("dayUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecibelAWeightedSoundPressureLevelUnitX = "decibelAWeightedSoundPressureLevelUnit";
		static readonly NativeHandle selDecibelAWeightedSoundPressureLevelUnitXHandle = Selector.GetHandle ("decibelAWeightedSoundPressureLevelUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecibelHearingLevelUnitX = "decibelHearingLevelUnit";
		static readonly NativeHandle selDecibelHearingLevelUnitXHandle = Selector.GetHandle ("decibelHearingLevelUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDegreeAngleUnitX = "degreeAngleUnit";
		static readonly NativeHandle selDegreeAngleUnitXHandle = Selector.GetHandle ("degreeAngleUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDegreeCelsiusUnitX = "degreeCelsiusUnit";
		static readonly NativeHandle selDegreeCelsiusUnitXHandle = Selector.GetHandle ("degreeCelsiusUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDegreeFahrenheitUnitX = "degreeFahrenheitUnit";
		static readonly NativeHandle selDegreeFahrenheitUnitXHandle = Selector.GetHandle ("degreeFahrenheitUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiopterUnitX = "diopterUnit";
		static readonly NativeHandle selDiopterUnitXHandle = Selector.GetHandle ("diopterUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnergyFormatterUnitFromUnit_X = "energyFormatterUnitFromUnit:";
		static readonly NativeHandle selEnergyFormatterUnitFromUnit_XHandle = Selector.GetHandle ("energyFormatterUnitFromUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFluidOunceImperialUnitX = "fluidOunceImperialUnit";
		static readonly NativeHandle selFluidOunceImperialUnitXHandle = Selector.GetHandle ("fluidOunceImperialUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFluidOunceUSUnitX = "fluidOunceUSUnit";
		static readonly NativeHandle selFluidOunceUSUnitXHandle = Selector.GetHandle ("fluidOunceUSUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFootUnitX = "footUnit";
		static readonly NativeHandle selFootUnitXHandle = Selector.GetHandle ("footUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGramUnitX = "gramUnit";
		static readonly NativeHandle selGramUnitXHandle = Selector.GetHandle ("gramUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGramUnitWithMetricPrefix_X = "gramUnitWithMetricPrefix:";
		static readonly NativeHandle selGramUnitWithMetricPrefix_XHandle = Selector.GetHandle ("gramUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHertzUnitX = "hertzUnit";
		static readonly NativeHandle selHertzUnitXHandle = Selector.GetHandle ("hertzUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHertzUnitWithMetricPrefix_X = "hertzUnitWithMetricPrefix:";
		static readonly NativeHandle selHertzUnitWithMetricPrefix_XHandle = Selector.GetHandle ("hertzUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHourUnitX = "hourUnit";
		static readonly NativeHandle selHourUnitXHandle = Selector.GetHandle ("hourUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInchUnitX = "inchUnit";
		static readonly NativeHandle selInchUnitXHandle = Selector.GetHandle ("inchUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInchesOfMercuryUnitX = "inchesOfMercuryUnit";
		static readonly NativeHandle selInchesOfMercuryUnitXHandle = Selector.GetHandle ("inchesOfMercuryUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInternationalUnitX = "internationalUnit";
		static readonly NativeHandle selInternationalUnitXHandle = Selector.GetHandle ("internationalUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNullX = "isNull";
		static readonly NativeHandle selIsNullXHandle = Selector.GetHandle ("isNull");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJouleUnitX = "jouleUnit";
		static readonly NativeHandle selJouleUnitXHandle = Selector.GetHandle ("jouleUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJouleUnitWithMetricPrefix_X = "jouleUnitWithMetricPrefix:";
		static readonly NativeHandle selJouleUnitWithMetricPrefix_XHandle = Selector.GetHandle ("jouleUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKelvinUnitX = "kelvinUnit";
		static readonly NativeHandle selKelvinUnitXHandle = Selector.GetHandle ("kelvinUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKilocalorieUnitX = "kilocalorieUnit";
		static readonly NativeHandle selKilocalorieUnitXHandle = Selector.GetHandle ("kilocalorieUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLargeCalorieUnitX = "largeCalorieUnit";
		static readonly NativeHandle selLargeCalorieUnitXHandle = Selector.GetHandle ("largeCalorieUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLengthFormatterUnitFromUnit_X = "lengthFormatterUnitFromUnit:";
		static readonly NativeHandle selLengthFormatterUnitFromUnit_XHandle = Selector.GetHandle ("lengthFormatterUnitFromUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLiterUnitX = "literUnit";
		static readonly NativeHandle selLiterUnitXHandle = Selector.GetHandle ("literUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLiterUnitWithMetricPrefix_X = "literUnitWithMetricPrefix:";
		static readonly NativeHandle selLiterUnitWithMetricPrefix_XHandle = Selector.GetHandle ("literUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLuxUnitX = "luxUnit";
		static readonly NativeHandle selLuxUnitXHandle = Selector.GetHandle ("luxUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLuxUnitWithMetricPrefix_X = "luxUnitWithMetricPrefix:";
		static readonly NativeHandle selLuxUnitWithMetricPrefix_XHandle = Selector.GetHandle ("luxUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMassFormatterUnitFromUnit_X = "massFormatterUnitFromUnit:";
		static readonly NativeHandle selMassFormatterUnitFromUnit_XHandle = Selector.GetHandle ("massFormatterUnitFromUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeterUnitX = "meterUnit";
		static readonly NativeHandle selMeterUnitXHandle = Selector.GetHandle ("meterUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeterUnitWithMetricPrefix_X = "meterUnitWithMetricPrefix:";
		static readonly NativeHandle selMeterUnitWithMetricPrefix_XHandle = Selector.GetHandle ("meterUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMileUnitX = "mileUnit";
		static readonly NativeHandle selMileUnitXHandle = Selector.GetHandle ("mileUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMillimeterOfMercuryUnitX = "millimeterOfMercuryUnit";
		static readonly NativeHandle selMillimeterOfMercuryUnitXHandle = Selector.GetHandle ("millimeterOfMercuryUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinuteUnitX = "minuteUnit";
		static readonly NativeHandle selMinuteUnitXHandle = Selector.GetHandle ("minuteUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoleUnitWithMetricPrefix_MolarMass_X = "moleUnitWithMetricPrefix:molarMass:";
		static readonly NativeHandle selMoleUnitWithMetricPrefix_MolarMass_XHandle = Selector.GetHandle ("moleUnitWithMetricPrefix:molarMass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoleUnitWithMolarMass_X = "moleUnitWithMolarMass:";
		static readonly NativeHandle selMoleUnitWithMolarMass_XHandle = Selector.GetHandle ("moleUnitWithMolarMass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOunceUnitX = "ounceUnit";
		static readonly NativeHandle selOunceUnitXHandle = Selector.GetHandle ("ounceUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPascalUnitX = "pascalUnit";
		static readonly NativeHandle selPascalUnitXHandle = Selector.GetHandle ("pascalUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPascalUnitWithMetricPrefix_X = "pascalUnitWithMetricPrefix:";
		static readonly NativeHandle selPascalUnitWithMetricPrefix_XHandle = Selector.GetHandle ("pascalUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPercentUnitX = "percentUnit";
		static readonly NativeHandle selPercentUnitXHandle = Selector.GetHandle ("percentUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPintImperialUnitX = "pintImperialUnit";
		static readonly NativeHandle selPintImperialUnitXHandle = Selector.GetHandle ("pintImperialUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPintUSUnitX = "pintUSUnit";
		static readonly NativeHandle selPintUSUnitXHandle = Selector.GetHandle ("pintUSUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPoundUnitX = "poundUnit";
		static readonly NativeHandle selPoundUnitXHandle = Selector.GetHandle ("poundUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrismDiopterUnitX = "prismDiopterUnit";
		static readonly NativeHandle selPrismDiopterUnitXHandle = Selector.GetHandle ("prismDiopterUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRadianAngleUnitX = "radianAngleUnit";
		static readonly NativeHandle selRadianAngleUnitXHandle = Selector.GetHandle ("radianAngleUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRadianAngleUnitWithMetricPrefix_X = "radianAngleUnitWithMetricPrefix:";
		static readonly NativeHandle selRadianAngleUnitWithMetricPrefix_XHandle = Selector.GetHandle ("radianAngleUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReciprocalUnitX = "reciprocalUnit";
		static readonly NativeHandle selReciprocalUnitXHandle = Selector.GetHandle ("reciprocalUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondUnitX = "secondUnit";
		static readonly NativeHandle selSecondUnitXHandle = Selector.GetHandle ("secondUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondUnitWithMetricPrefix_X = "secondUnitWithMetricPrefix:";
		static readonly NativeHandle selSecondUnitWithMetricPrefix_XHandle = Selector.GetHandle ("secondUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSiemenUnitX = "siemenUnit";
		static readonly NativeHandle selSiemenUnitXHandle = Selector.GetHandle ("siemenUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSiemenUnitWithMetricPrefix_X = "siemenUnitWithMetricPrefix:";
		static readonly NativeHandle selSiemenUnitWithMetricPrefix_XHandle = Selector.GetHandle ("siemenUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmallCalorieUnitX = "smallCalorieUnit";
		static readonly NativeHandle selSmallCalorieUnitXHandle = Selector.GetHandle ("smallCalorieUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoneUnitX = "stoneUnit";
		static readonly NativeHandle selStoneUnitXHandle = Selector.GetHandle ("stoneUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitDividedByUnit_X = "unitDividedByUnit:";
		static readonly NativeHandle selUnitDividedByUnit_XHandle = Selector.GetHandle ("unitDividedByUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitFromEnergyFormatterUnit_X = "unitFromEnergyFormatterUnit:";
		static readonly NativeHandle selUnitFromEnergyFormatterUnit_XHandle = Selector.GetHandle ("unitFromEnergyFormatterUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitFromLengthFormatterUnit_X = "unitFromLengthFormatterUnit:";
		static readonly NativeHandle selUnitFromLengthFormatterUnit_XHandle = Selector.GetHandle ("unitFromLengthFormatterUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitFromMassFormatterUnit_X = "unitFromMassFormatterUnit:";
		static readonly NativeHandle selUnitFromMassFormatterUnit_XHandle = Selector.GetHandle ("unitFromMassFormatterUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitFromString_X = "unitFromString:";
		static readonly NativeHandle selUnitFromString_XHandle = Selector.GetHandle ("unitFromString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitMultipliedByUnit_X = "unitMultipliedByUnit:";
		static readonly NativeHandle selUnitMultipliedByUnit_XHandle = Selector.GetHandle ("unitMultipliedByUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitRaisedToPower_X = "unitRaisedToPower:";
		static readonly NativeHandle selUnitRaisedToPower_XHandle = Selector.GetHandle ("unitRaisedToPower:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitStringX = "unitString";
		static readonly NativeHandle selUnitStringXHandle = Selector.GetHandle ("unitString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoltUnitX = "voltUnit";
		static readonly NativeHandle selVoltUnitXHandle = Selector.GetHandle ("voltUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoltUnitWithMetricPrefix_X = "voltUnitWithMetricPrefix:";
		static readonly NativeHandle selVoltUnitWithMetricPrefix_XHandle = Selector.GetHandle ("voltUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWattUnitX = "wattUnit";
		static readonly NativeHandle selWattUnitXHandle = Selector.GetHandle ("wattUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWattUnitWithMetricPrefix_X = "wattUnitWithMetricPrefix:";
		static readonly NativeHandle selWattUnitWithMetricPrefix_XHandle = Selector.GetHandle ("wattUnitWithMetricPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYardUnitX = "yardUnit";
		static readonly NativeHandle selYardUnitXHandle = Selector.GetHandle ("yardUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKUnit");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public HKUnit (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected HKUnit (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal HKUnit (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("jouleUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateJouleUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selJouleUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("literUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateLiterUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selLiterUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("luxUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateLux (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selLuxUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("meterUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMeterUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selMeterUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("moleUnitWithMetricPrefix:molarMass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMoleUnit (HKMetricPrefix prefix, double gramsPerMole)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_Double (class_ptr, selMoleUnitWithMetricPrefix_MolarMass_XHandle, (IntPtr) (long) prefix, gramsPerMole), false)!;
			return ret;
		}
		[Export ("moleUnitWithMolarMass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMoleUnit (double gramsPerMole)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selMoleUnitWithMolarMass_XHandle, gramsPerMole), false)!;
			return ret;
		}
		[Export ("pascalUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreatePascalUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPascalUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("radianAngleUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateRadianAngle (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selRadianAngleUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("secondUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateSecondUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selSecondUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("siemenUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateSiemenUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selSiemenUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("wattUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateWatt (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selWattUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("unitFromEnergyFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromEnergyFormatterUnit (NSEnergyFormatterUnit energyFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selUnitFromEnergyFormatterUnit_XHandle, (IntPtr) (long) energyFormatterUnit), false)!;
			return ret;
		}
		[Export ("gramUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromGramUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selGramUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("unitFromLengthFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromLengthFormatterUnit (NSLengthFormatterUnit lengthFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selUnitFromLengthFormatterUnit_XHandle, (IntPtr) (long) lengthFormatterUnit), false)!;
			return ret;
		}
		[Export ("unitFromMassFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromMassFormatterUnit (NSMassFormatterUnit massFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selUnitFromMassFormatterUnit_XHandle, (IntPtr) (long) massFormatterUnit), false)!;
			return ret;
		}
		[Export ("unitFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromString (string aString)
		{
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			HKUnit? ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selUnitFromString_XHandle, nsaString), false)!;
			CFString.ReleaseNative (nsaString);
			return ret!;
		}
		[Export ("energyFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEnergyFormatterUnit GetEnergyFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSEnergyFormatterUnit ret;
			ret = (NSEnergyFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, selEnergyFormatterUnitFromUnit_XHandle, unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("hertzUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit GetHertzUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selHertzUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("lengthFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLengthFormatterUnit GetLengthFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSLengthFormatterUnit ret;
			ret = (NSLengthFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, selLengthFormatterUnitFromUnit_XHandle, unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("massFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMassFormatterUnit GetMassFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSMassFormatterUnit ret;
			ret = (NSMassFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, selMassFormatterUnitFromUnit_XHandle, unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("voltUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit GetVolt (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selVoltUnitWithMetricPrefix_XHandle, (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("reciprocalUnit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit ReciprocalUnit ()
		{
			HKUnit ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReciprocalUnitXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReciprocalUnitXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("unitDividedByUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitDividedBy (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			HKUnit? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUnitDividedByUnit_XHandle, unit__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnitDividedByUnit_XHandle, unit__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("unitMultipliedByUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitMultipliedBy (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			HKUnit? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUnitMultipliedByUnit_XHandle, unit__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnitMultipliedByUnit_XHandle, unit__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unit);
			return ret!;
		}
		/// <param name="power">To be added.</param><summary>Returns a unit that is the result of raising <see langword="this" /> unit by <paramref name="power" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unitRaisedToPower:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitRaisedToPower (nint power)
		{
			HKUnit ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selUnitRaisedToPower_XHandle, power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selUnitRaisedToPower_XHandle, power), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit AppleEffortScoreUnit {
			[Export ("appleEffortScoreUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAppleEffortScoreUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Atmosphere {
			[Export ("atmosphereUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAtmosphereUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SmallCalorie' or 'LargeCalorie' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SmallCalorie' or 'LargeCalorie' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static HKUnit Calorie {
			[Export ("calorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCalorieUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CentimeterOfWater {
			[Export ("centimeterOfWaterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCentimeterOfWaterUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Count {
			[Export ("countUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCountUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit CupImperialUnit {
			[Export ("cupImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCupImperialUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit CupUSUnit {
			[Export ("cupUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCupUSUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Day {
			[Export ("dayUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDayUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit DecibelAWeightedSoundPressureLevelUnit {
			[Export ("decibelAWeightedSoundPressureLevelUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecibelAWeightedSoundPressureLevelUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit DecibelHearingLevelUnit {
			[Export ("decibelHearingLevelUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecibelHearingLevelUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit DegreeAngle {
			[Export ("degreeAngleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDegreeAngleUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit DegreeCelsius {
			[Export ("degreeCelsiusUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDegreeCelsiusUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit DegreeFahrenheit {
			[Export ("degreeFahrenheitUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDegreeFahrenheitUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Diopter {
			[Export ("diopterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDiopterUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FluidOunceImperialUnit {
			[Export ("fluidOunceImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFluidOunceImperialUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FluidOunceUSUnit {
			[Export ("fluidOunceUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFluidOunceUSUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Foot {
			[Export ("footUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFootUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Gram {
			[Export ("gramUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGramUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit HertzUnit {
			[Export ("hertzUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHertzUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Hour {
			[Export ("hourUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHourUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Inch {
			[Export ("inchUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInchUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit InchesOfMercury {
			[Export ("inchesOfMercuryUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInchesOfMercuryUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit InternationalUnit {
			[Export ("internationalUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInternationalUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNull {
			[Export ("isNull")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNullXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsNullXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Joule {
			[Export ("jouleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selJouleUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Kelvin {
			[Export ("kelvinUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKelvinUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Kilocalorie {
			[Export ("kilocalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKilocalorieUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit LargeCalorie {
			[Export ("largeCalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLargeCalorieUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Liter {
			[Export ("literUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLiterUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Lux {
			[Export ("luxUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLuxUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Meter {
			[Export ("meterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMeterUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Mile {
			[Export ("mileUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMileUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit MillimeterOfMercury {
			[Export ("millimeterOfMercuryUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMillimeterOfMercuryUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Minute {
			[Export ("minuteUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMinuteUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Ounce {
			[Export ("ounceUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOunceUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Pascal {
			[Export ("pascalUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPascalUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Percent {
			[Export ("percentUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPercentUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit PintImperialUnit {
			[Export ("pintImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPintImperialUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit PintUSUnit {
			[Export ("pintUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPintUSUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Pound {
			[Export ("poundUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPoundUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit PrismDiopter {
			[Export ("prismDiopterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPrismDiopterUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit RadianAngle {
			[Export ("radianAngleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRadianAngleUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Second {
			[Export ("secondUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSecondUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Siemen {
			[Export ("siemenUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSiemenUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit SmallCalorie {
			[Export ("smallCalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSmallCalorieUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Stone {
			[Export ("stoneUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selStoneUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UnitString {
			[Export ("unitString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUnitStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUnitStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit Volt {
			[Export ("voltUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selVoltUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Watt {
			[Export ("wattUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWattUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit Yard {
			[Export ("yardUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYardUnitXHandle), false)!;
				return ret!;
			}
		}
	} /* class HKUnit */
}
