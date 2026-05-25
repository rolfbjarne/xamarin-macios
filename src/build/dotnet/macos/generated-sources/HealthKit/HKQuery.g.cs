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
	/// <summary>Base class for querying Health Kit databases.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKQuery_Class/index.html">Apple documentation for <c>HKQuery</c></related>
	[Register("HKQuery", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKQuery : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectTypeX = "objectType";
		static readonly NativeHandle selObjectTypeXHandle = Selector.GetHandle ("objectType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateX = "predicate";
		static readonly NativeHandle selPredicateXHandle = Selector.GetHandle ("predicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForActivitySummariesBetweenStartDateComponents_EndDateComponents_X = "predicateForActivitySummariesBetweenStartDateComponents:endDateComponents:";
		static readonly NativeHandle selPredicateForActivitySummariesBetweenStartDateComponents_EndDateComponents_XHandle = Selector.GetHandle ("predicateForActivitySummariesBetweenStartDateComponents:endDateComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForActivitySummaryWithDateComponents_X = "predicateForActivitySummaryWithDateComponents:";
		static readonly NativeHandle selPredicateForActivitySummaryWithDateComponents_XHandle = Selector.GetHandle ("predicateForActivitySummaryWithDateComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForCategorySamplesEqualToValues_X = "predicateForCategorySamplesEqualToValues:";
		static readonly NativeHandle selPredicateForCategorySamplesEqualToValues_XHandle = Selector.GetHandle ("predicateForCategorySamplesEqualToValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForCategorySamplesWithOperatorType_Value_X = "predicateForCategorySamplesWithOperatorType:value:";
		static readonly NativeHandle selPredicateForCategorySamplesWithOperatorType_Value_XHandle = Selector.GetHandle ("predicateForCategorySamplesWithOperatorType:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForClinicalRecordsFromSource_FHIRResourceType_Identifier_X = "predicateForClinicalRecordsFromSource:FHIRResourceType:identifier:";
		static readonly NativeHandle selPredicateForClinicalRecordsFromSource_FHIRResourceType_Identifier_XHandle = Selector.GetHandle ("predicateForClinicalRecordsFromSource:FHIRResourceType:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForClinicalRecordsWithFHIRResourceType_X = "predicateForClinicalRecordsWithFHIRResourceType:";
		static readonly NativeHandle selPredicateForClinicalRecordsWithFHIRResourceType_XHandle = Selector.GetHandle ("predicateForClinicalRecordsWithFHIRResourceType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForElectrocardiogramsWithClassification_X = "predicateForElectrocardiogramsWithClassification:";
		static readonly NativeHandle selPredicateForElectrocardiogramsWithClassification_XHandle = Selector.GetHandle ("predicateForElectrocardiogramsWithClassification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForElectrocardiogramsWithSymptomsStatus_X = "predicateForElectrocardiogramsWithSymptomsStatus:";
		static readonly NativeHandle selPredicateForElectrocardiogramsWithSymptomsStatus_XHandle = Selector.GetHandle ("predicateForElectrocardiogramsWithSymptomsStatus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithMedicationConceptIdentifier_X = "predicateForMedicationDoseEventWithMedicationConceptIdentifier:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithMedicationConceptIdentifier_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithMedicationConceptIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithMedicationConceptIdentifiers_X = "predicateForMedicationDoseEventWithMedicationConceptIdentifiers:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithMedicationConceptIdentifiers_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithMedicationConceptIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithScheduledDate_X = "predicateForMedicationDoseEventWithScheduledDate:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithScheduledDate_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithScheduledDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithScheduledDates_X = "predicateForMedicationDoseEventWithScheduledDates:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithScheduledDates_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithScheduledDates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithScheduledStartDate_EndDate_X = "predicateForMedicationDoseEventWithScheduledStartDate:endDate:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithScheduledStartDate_EndDate_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithScheduledStartDate:endDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithStatus_X = "predicateForMedicationDoseEventWithStatus:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithStatus_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithStatus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForMedicationDoseEventWithStatuses_X = "predicateForMedicationDoseEventWithStatuses:";
		static readonly NativeHandle selPredicateForMedicationDoseEventWithStatuses_XHandle = Selector.GetHandle ("predicateForMedicationDoseEventWithStatuses:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectWithUUID_X = "predicateForObjectWithUUID:";
		static readonly NativeHandle selPredicateForObjectWithUUID_XHandle = Selector.GetHandle ("predicateForObjectWithUUID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsAssociatedWithElectrocardiogram_X = "predicateForObjectsAssociatedWithElectrocardiogram:";
		static readonly NativeHandle selPredicateForObjectsAssociatedWithElectrocardiogram_XHandle = Selector.GetHandle ("predicateForObjectsAssociatedWithElectrocardiogram:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsFromDevices_X = "predicateForObjectsFromDevices:";
		static readonly NativeHandle selPredicateForObjectsFromDevices_XHandle = Selector.GetHandle ("predicateForObjectsFromDevices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsFromSource_X = "predicateForObjectsFromSource:";
		static readonly NativeHandle selPredicateForObjectsFromSource_XHandle = Selector.GetHandle ("predicateForObjectsFromSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsFromSourceRevisions_X = "predicateForObjectsFromSourceRevisions:";
		static readonly NativeHandle selPredicateForObjectsFromSourceRevisions_XHandle = Selector.GetHandle ("predicateForObjectsFromSourceRevisions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsFromSources_X = "predicateForObjectsFromSources:";
		static readonly NativeHandle selPredicateForObjectsFromSources_XHandle = Selector.GetHandle ("predicateForObjectsFromSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsFromWorkout_X = "predicateForObjectsFromWorkout:";
		static readonly NativeHandle selPredicateForObjectsFromWorkout_XHandle = Selector.GetHandle ("predicateForObjectsFromWorkout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithDeviceProperty_AllowedValues_X = "predicateForObjectsWithDeviceProperty:allowedValues:";
		static readonly NativeHandle selPredicateForObjectsWithDeviceProperty_AllowedValues_XHandle = Selector.GetHandle ("predicateForObjectsWithDeviceProperty:allowedValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithMetadataKey_X = "predicateForObjectsWithMetadataKey:";
		static readonly NativeHandle selPredicateForObjectsWithMetadataKey_XHandle = Selector.GetHandle ("predicateForObjectsWithMetadataKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithMetadataKey_AllowedValues_X = "predicateForObjectsWithMetadataKey:allowedValues:";
		static readonly NativeHandle selPredicateForObjectsWithMetadataKey_AllowedValues_XHandle = Selector.GetHandle ("predicateForObjectsWithMetadataKey:allowedValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithMetadataKey_OperatorType_Value_X = "predicateForObjectsWithMetadataKey:operatorType:value:";
		static readonly NativeHandle selPredicateForObjectsWithMetadataKey_OperatorType_Value_XHandle = Selector.GetHandle ("predicateForObjectsWithMetadataKey:operatorType:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithNoCorrelationX = "predicateForObjectsWithNoCorrelation";
		static readonly NativeHandle selPredicateForObjectsWithNoCorrelationXHandle = Selector.GetHandle ("predicateForObjectsWithNoCorrelation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForObjectsWithUUIDs_X = "predicateForObjectsWithUUIDs:";
		static readonly NativeHandle selPredicateForObjectsWithUUIDs_XHandle = Selector.GetHandle ("predicateForObjectsWithUUIDs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForQuantitySamplesWithOperatorType_Quantity_X = "predicateForQuantitySamplesWithOperatorType:quantity:";
		static readonly NativeHandle selPredicateForQuantitySamplesWithOperatorType_Quantity_XHandle = Selector.GetHandle ("predicateForQuantitySamplesWithOperatorType:quantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForSamplesWithStartDate_EndDate_Options_X = "predicateForSamplesWithStartDate:endDate:options:";
		static readonly NativeHandle selPredicateForSamplesWithStartDate_EndDate_Options_XHandle = Selector.GetHandle ("predicateForSamplesWithStartDate:endDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForStatesOfMindWithAssociation_X = "predicateForStatesOfMindWithAssociation:";
		static readonly NativeHandle selPredicateForStatesOfMindWithAssociation_XHandle = Selector.GetHandle ("predicateForStatesOfMindWithAssociation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForStatesOfMindWithKind_X = "predicateForStatesOfMindWithKind:";
		static readonly NativeHandle selPredicateForStatesOfMindWithKind_XHandle = Selector.GetHandle ("predicateForStatesOfMindWithKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForStatesOfMindWithLabel_X = "predicateForStatesOfMindWithLabel:";
		static readonly NativeHandle selPredicateForStatesOfMindWithLabel_XHandle = Selector.GetHandle ("predicateForStatesOfMindWithLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForStatesOfMindWithValence_OperatorType_X = "predicateForStatesOfMindWithValence:operatorType:";
		static readonly NativeHandle selPredicateForStatesOfMindWithValence_OperatorType_XHandle = Selector.GetHandle ("predicateForStatesOfMindWithValence:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForUserAnnotatedMedicationsWithHasSchedule_X = "predicateForUserAnnotatedMedicationsWithHasSchedule:";
		static readonly NativeHandle selPredicateForUserAnnotatedMedicationsWithHasSchedule_XHandle = Selector.GetHandle ("predicateForUserAnnotatedMedicationsWithHasSchedule:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForUserAnnotatedMedicationsWithIsArchived_X = "predicateForUserAnnotatedMedicationsWithIsArchived:";
		static readonly NativeHandle selPredicateForUserAnnotatedMedicationsWithIsArchived_XHandle = Selector.GetHandle ("predicateForUserAnnotatedMedicationsWithIsArchived:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval_X = "predicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval:";
		static readonly NativeHandle selPredicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval_XHandle = Selector.GetHandle ("predicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithOperatorType_Duration_X = "predicateForWorkoutActivitiesWithOperatorType:duration:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithOperatorType_Duration_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithOperatorType:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_AverageQuantity_X = "predicateForWorkoutActivitiesWithOperatorType:quantityType:averageQuantity:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_AverageQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithOperatorType:quantityType:averageQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MaximumQuantity_X = "predicateForWorkoutActivitiesWithOperatorType:quantityType:maximumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MaximumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithOperatorType:quantityType:maximumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MinimumQuantity_X = "predicateForWorkoutActivitiesWithOperatorType:quantityType:minimumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MinimumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithOperatorType:quantityType:minimumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_SumQuantity_X = "predicateForWorkoutActivitiesWithOperatorType:quantityType:sumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_SumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithOperatorType:quantityType:sumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithStartDate_EndDate_Options_X = "predicateForWorkoutActivitiesWithStartDate:endDate:options:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithStartDate_EndDate_Options_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithStartDate:endDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutActivitiesWithWorkoutActivityType_X = "predicateForWorkoutActivitiesWithWorkoutActivityType:";
		static readonly NativeHandle selPredicateForWorkoutActivitiesWithWorkoutActivityType_XHandle = Selector.GetHandle ("predicateForWorkoutActivitiesWithWorkoutActivityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutEffortSamplesRelatedToWorkout_Activity_X = "predicateForWorkoutEffortSamplesRelatedToWorkout:activity:";
		static readonly NativeHandle selPredicateForWorkoutEffortSamplesRelatedToWorkout_Activity_XHandle = Selector.GetHandle ("predicateForWorkoutEffortSamplesRelatedToWorkout:activity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithActivityPredicate_X = "predicateForWorkoutsWithActivityPredicate:";
		static readonly NativeHandle selPredicateForWorkoutsWithActivityPredicate_XHandle = Selector.GetHandle ("predicateForWorkoutsWithActivityPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_Duration_X = "predicateForWorkoutsWithOperatorType:duration:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_Duration_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_QuantityType_AverageQuantity_X = "predicateForWorkoutsWithOperatorType:quantityType:averageQuantity:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_QuantityType_AverageQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:quantityType:averageQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_QuantityType_MaximumQuantity_X = "predicateForWorkoutsWithOperatorType:quantityType:maximumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_QuantityType_MaximumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:quantityType:maximumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_QuantityType_MinimumQuantity_X = "predicateForWorkoutsWithOperatorType:quantityType:minimumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_QuantityType_MinimumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:quantityType:minimumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_QuantityType_SumQuantity_X = "predicateForWorkoutsWithOperatorType:quantityType:sumQuantity:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_QuantityType_SumQuantity_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:quantityType:sumQuantity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_TotalDistance_X = "predicateForWorkoutsWithOperatorType:totalDistance:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_TotalDistance_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:totalDistance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_TotalEnergyBurned_X = "predicateForWorkoutsWithOperatorType:totalEnergyBurned:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_TotalEnergyBurned_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:totalEnergyBurned:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_TotalFlightsClimbed_X = "predicateForWorkoutsWithOperatorType:totalFlightsClimbed:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_TotalFlightsClimbed_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:totalFlightsClimbed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithOperatorType_TotalSwimmingStrokeCount_X = "predicateForWorkoutsWithOperatorType:totalSwimmingStrokeCount:";
		static readonly NativeHandle selPredicateForWorkoutsWithOperatorType_TotalSwimmingStrokeCount_XHandle = Selector.GetHandle ("predicateForWorkoutsWithOperatorType:totalSwimmingStrokeCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForWorkoutsWithWorkoutActivityType_X = "predicateForWorkoutsWithWorkoutActivityType:";
		static readonly NativeHandle selPredicateForWorkoutsWithWorkoutActivityType_XHandle = Selector.GetHandle ("predicateForWorkoutsWithWorkoutActivityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleTypeX = "sampleType";
		static readonly NativeHandle selSampleTypeXHandle = Selector.GetHandle ("sampleType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKQuery");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected HKQuery (NSObjectFlag t) : base (t)
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
		protected internal HKQuery (NativeHandle handle) : base (handle)
		{
		}

		[Export ("predicateForWorkoutActivitiesWithOperatorType:quantityType:averageQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetAverageQuantityPredicateForWorkoutActivities (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity averageQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var averageQuantity__handle__ = averageQuantity!.GetNonNullHandle (nameof (averageQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_AverageQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, averageQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (averageQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:quantityType:averageQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetAverageQuantityPredicateForWorkouts (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity averageQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var averageQuantity__handle__ = averageQuantity!.GetNonNullHandle (nameof (averageQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_QuantityType_AverageQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, averageQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (averageQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutActivitiesWithOperatorType:quantityType:maximumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetMaximumQuantityPredicateForWorkoutActivities (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity maximumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var maximumQuantity__handle__ = maximumQuantity!.GetNonNullHandle (nameof (maximumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MaximumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, maximumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (maximumQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:quantityType:maximumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetMaximumQuantityPredicateForWorkouts (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity maximumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var maximumQuantity__handle__ = maximumQuantity!.GetNonNullHandle (nameof (maximumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_QuantityType_MaximumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, maximumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (maximumQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutActivitiesWithOperatorType:quantityType:minimumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetMinimumQuantityPredicateForWorkoutActivities (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity minimumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var minimumQuantity__handle__ = minimumQuantity!.GetNonNullHandle (nameof (minimumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_MinimumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, minimumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (minimumQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:quantityType:minimumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetMinimumQuantityPredicateForWorkouts (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity minimumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var minimumQuantity__handle__ = minimumQuantity!.GetNonNullHandle (nameof (minimumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_QuantityType_MinimumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, minimumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (minimumQuantity);
			return ret!;
		}
		[Export ("predicateForActivitySummariesBetweenStartDateComponents:endDateComponents:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForActivitySummariesBetween (NSDateComponents startDateComponents, NSDateComponents endDateComponents)
		{
			var startDateComponents__handle__ = startDateComponents!.GetNonNullHandle (nameof (startDateComponents));
			var endDateComponents__handle__ = endDateComponents!.GetNonNullHandle (nameof (endDateComponents));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPredicateForActivitySummariesBetweenStartDateComponents_EndDateComponents_XHandle, startDateComponents__handle__, endDateComponents__handle__), false)!;
			GC.KeepAlive (startDateComponents);
			GC.KeepAlive (endDateComponents);
			return ret!;
		}
		[Export ("predicateForActivitySummaryWithDateComponents:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForActivitySummary (NSDateComponents dateComponents)
		{
			var dateComponents__handle__ = dateComponents!.GetNonNullHandle (nameof (dateComponents));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForActivitySummaryWithDateComponents_XHandle, dateComponents__handle__), false)!;
			GC.KeepAlive (dateComponents);
			return ret!;
		}
		/// <param name="operatorType">To be added.</param><param name="value">To be added.</param><summary> Creates and returns a predicate that can be used to check the value of a category sample.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("predicateForCategorySamplesWithOperatorType:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForCategorySamples (NSPredicateOperatorType operatorType, nint value)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (class_ptr, selPredicateForCategorySamplesWithOperatorType_Value_XHandle, (UIntPtr) (ulong) operatorType, value), false)!;
			return ret;
		}
		[Export ("predicateForCategorySamplesEqualToValues:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForCategorySamples (NSSet<NSNumber> values)
		{
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForCategorySamplesEqualToValues_XHandle, values__handle__), false)!;
			GC.KeepAlive (values);
			return ret!;
		}
		[Export ("predicateForClinicalRecordsWithFHIRResourceType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPredicate GetPredicateForClinicalRecords (NSString resourceType)
		{
			var resourceType__handle__ = resourceType!.GetNonNullHandle (nameof (resourceType));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForClinicalRecordsWithFHIRResourceType_XHandle, resourceType__handle__), false)!;
			GC.KeepAlive (resourceType);
			return ret!;
		}
		/// <param name="resourceType">The resource type for which to generate a query predicate.</param><summary>Creates and returns a predicate for a Fast Healthcare Interoperability Resources record of the specified resource type.</summary><returns>A predicate for a Fast Healthcare Interoperability Resources record of the specified resource type.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForClinicalRecords (HKFhirResourceType resourceType)
		{
			return GetPredicateForClinicalRecords (resourceType.GetConstant ()!);
		}
		[Export ("predicateForClinicalRecordsFromSource:FHIRResourceType:identifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPredicate GetPredicateForClinicalRecords (HKSource source, string resourceType, string identifier)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (resourceType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceType));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsresourceType = CFString.CreateNative (resourceType);
			var nsidentifier = CFString.CreateNative (identifier);
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPredicateForClinicalRecordsFromSource_FHIRResourceType_Identifier_XHandle, source__handle__, nsresourceType, nsidentifier), false)!;
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsresourceType);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="source">The HealthKit source for the predicate.</param><param name="resourceType">The resource type for which to generate a query predicate.</param><param name="identifier">The record identifier.</param><summary>Creates and returns a predicate for a Fast Healthcare Interoperability Resources record for the specified query parameters.</summary><returns>A predicate for a Fast Healthcare Interoperability Resources record oor the specified query parameters.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForClinicalRecords (HKSource source, HKFhirResourceType resourceType, string identifier)
		{
			return GetPredicateForClinicalRecords (source, resourceType.GetConstant ()!, identifier);
		}
		[Export ("predicateForWorkoutsWithOperatorType:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForDuration (NSPredicateOperatorType operatorType, double duration)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_Double (class_ptr, selPredicateForWorkoutsWithOperatorType_Duration_XHandle, (UIntPtr) (ulong) operatorType, duration), false)!;
			return ret;
		}
		[Export ("predicateForElectrocardiogramsWithClassification:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForElectrocardiograms (HKElectrocardiogramClassification classification)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForElectrocardiogramsWithClassification_XHandle, (IntPtr) (long) classification), false)!;
			return ret;
		}
		[Export ("predicateForElectrocardiogramsWithSymptomsStatus:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForElectrocardiograms (HKElectrocardiogramSymptomsStatus symptomsStatus)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForElectrocardiogramsWithSymptomsStatus_XHandle, (IntPtr) (long) symptomsStatus), false)!;
			return ret;
		}
		[Export ("predicateForMedicationDoseEventWithStatus:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (HKMedicationDoseEventLogStatus status)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForMedicationDoseEventWithStatus_XHandle, (IntPtr) (long) status), false)!;
			return ret;
		}
		[Export ("predicateForMedicationDoseEventWithStatuses:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (NSSet<NSNumber> statuses)
		{
			var statuses__handle__ = statuses!.GetNonNullHandle (nameof (statuses));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithStatuses_XHandle, statuses__handle__), false)!;
			GC.KeepAlive (statuses);
			return ret!;
		}
		[Export ("predicateForMedicationDoseEventWithScheduledDate:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (NSDate scheduledDate)
		{
			var scheduledDate__handle__ = scheduledDate!.GetNonNullHandle (nameof (scheduledDate));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithScheduledDate_XHandle, scheduledDate__handle__), false)!;
			GC.KeepAlive (scheduledDate);
			return ret!;
		}
		[Export ("predicateForMedicationDoseEventWithScheduledDates:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (NSSet<NSDate> scheduledDates)
		{
			var scheduledDates__handle__ = scheduledDates!.GetNonNullHandle (nameof (scheduledDates));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithScheduledDates_XHandle, scheduledDates__handle__), false)!;
			GC.KeepAlive (scheduledDates);
			return ret!;
		}
		[Export ("predicateForMedicationDoseEventWithScheduledStartDate:endDate:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (NSDate? startDate, NSDate? endDate)
		{
			var startDate__handle__ = startDate.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithScheduledStartDate_EndDate_XHandle, startDate__handle__, endDate__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForMedicationDoseEventWithMedicationConceptIdentifier:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (HKHealthConceptIdentifier medicationConceptIdentifier)
		{
			var medicationConceptIdentifier__handle__ = medicationConceptIdentifier!.GetNonNullHandle (nameof (medicationConceptIdentifier));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithMedicationConceptIdentifier_XHandle, medicationConceptIdentifier__handle__), false)!;
			GC.KeepAlive (medicationConceptIdentifier);
			return ret!;
		}
		[Export ("predicateForMedicationDoseEventWithMedicationConceptIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMedicationDoseEvent (NSSet<HKHealthConceptIdentifier> medicationConceptIdentifiers)
		{
			var medicationConceptIdentifiers__handle__ = medicationConceptIdentifiers!.GetNonNullHandle (nameof (medicationConceptIdentifiers));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForMedicationDoseEventWithMedicationConceptIdentifiers_XHandle, medicationConceptIdentifiers__handle__), false)!;
			GC.KeepAlive (medicationConceptIdentifiers);
			return ret!;
		}
		[Export ("predicateForObjectsWithMetadataKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMetadataKey (NSString metadataKey)
		{
			var metadataKey__handle__ = metadataKey!.GetNonNullHandle (nameof (metadataKey));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsWithMetadataKey_XHandle, metadataKey__handle__), false)!;
			GC.KeepAlive (metadataKey);
			return ret!;
		}
		[Export ("predicateForObjectsWithMetadataKey:allowedValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMetadataKey (NSString metadataKey, NSObject[] allowedValues)
		{
			var metadataKey__handle__ = metadataKey!.GetNonNullHandle (nameof (metadataKey));
			if (allowedValues is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (allowedValues));
			using var nsa_allowedValues = NSArray.FromNSObjects (allowedValues);
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPredicateForObjectsWithMetadataKey_AllowedValues_XHandle, metadataKey__handle__, nsa_allowedValues.Handle), false)!;
			GC.KeepAlive (metadataKey);
			return ret!;
		}
		[Export ("predicateForObjectsWithMetadataKey:operatorType:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForMetadataKey (NSString metadataKey, NSPredicateOperatorType operatorType, NSObject value)
		{
			var metadataKey__handle__ = metadataKey!.GetNonNullHandle (nameof (metadataKey));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (class_ptr, selPredicateForObjectsWithMetadataKey_OperatorType_Value_XHandle, metadataKey__handle__, (UIntPtr) (ulong) operatorType, value__handle__), false)!;
			GC.KeepAlive (metadataKey);
			GC.KeepAlive (value);
			return ret!;
		}
		[Export ("predicateForObjectWithUUID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObject (NSUuid objectUuid)
		{
			var objectUuid__handle__ = objectUuid!.GetNonNullHandle (nameof (objectUuid));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectWithUUID_XHandle, objectUuid__handle__), false)!;
			GC.KeepAlive (objectUuid);
			return ret!;
		}
		[Export ("predicateForObjectsWithUUIDs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjects (NSSet objectUuids)
		{
			var objectUuids__handle__ = objectUuids!.GetNonNullHandle (nameof (objectUuids));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsWithUUIDs_XHandle, objectUuids__handle__), false)!;
			GC.KeepAlive (objectUuids);
			return ret!;
		}
		[Export ("predicateForObjectsAssociatedWithElectrocardiogram:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjects (HKElectrocardiogram electrocardiogram)
		{
			var electrocardiogram__handle__ = electrocardiogram!.GetNonNullHandle (nameof (electrocardiogram));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsAssociatedWithElectrocardiogram_XHandle, electrocardiogram__handle__), false)!;
			GC.KeepAlive (electrocardiogram);
			return ret!;
		}
		[Export ("predicateForObjectsFromDevices:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsFromDevices (NSSet<HKDevice> devices)
		{
			var devices__handle__ = devices!.GetNonNullHandle (nameof (devices));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsFromDevices_XHandle, devices__handle__), false)!;
			GC.KeepAlive (devices);
			return ret!;
		}
		[Export ("predicateForObjectsFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsFromSource (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsFromSource_XHandle, source__handle__), false)!;
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("predicateForObjectsFromSourceRevisions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsFromSourceRevisions (NSSet<HKSourceRevision> sourceRevisions)
		{
			var sourceRevisions__handle__ = sourceRevisions!.GetNonNullHandle (nameof (sourceRevisions));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsFromSourceRevisions_XHandle, sourceRevisions__handle__), false)!;
			GC.KeepAlive (sourceRevisions);
			return ret!;
		}
		[Export ("predicateForObjectsFromSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsFromSources (NSSet sources)
		{
			var sources__handle__ = sources!.GetNonNullHandle (nameof (sources));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsFromSources_XHandle, sources__handle__), false)!;
			GC.KeepAlive (sources);
			return ret!;
		}
		[Export ("predicateForObjectsFromWorkout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsFromWorkout (HKWorkout workout)
		{
			var workout__handle__ = workout!.GetNonNullHandle (nameof (workout));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForObjectsFromWorkout_XHandle, workout__handle__), false)!;
			GC.KeepAlive (workout);
			return ret!;
		}
		[Export ("predicateForObjectsWithDeviceProperty:allowedValues:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForObjectsWithDeviceProperty (string key, NSSet<NSString> allowedValues)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var allowedValues__handle__ = allowedValues!.GetNonNullHandle (nameof (allowedValues));
			var nskey = CFString.CreateNative (key);
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPredicateForObjectsWithDeviceProperty_AllowedValues_XHandle, nskey, allowedValues__handle__), false)!;
			GC.KeepAlive (allowedValues);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("predicateForQuantitySamplesWithOperatorType:quantity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForQuantitySamples (NSPredicateOperatorType operatorType, HKQuantity quantity)
		{
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, selPredicateForQuantitySamplesWithOperatorType_Quantity_XHandle, (UIntPtr) (ulong) operatorType, quantity__handle__), false)!;
			GC.KeepAlive (quantity);
			return ret!;
		}
		[Export ("predicateForSamplesWithStartDate:endDate:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForSamples (NSDate? startDate, NSDate? endDate, HKQueryOptions options)
		{
			var startDate__handle__ = startDate.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (class_ptr, selPredicateForSamplesWithStartDate_EndDate_Options_XHandle, startDate__handle__, endDate__handle__, (UIntPtr) (ulong) options), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForStatesOfMindWithValence:operatorType:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForStatesOfMind (double valence, NSPredicateOperatorType operatorType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_UIntPtr (class_ptr, selPredicateForStatesOfMindWithValence_OperatorType_XHandle, valence, (UIntPtr) (ulong) operatorType), false)!;
			return ret;
		}
		[Export ("predicateForStatesOfMindWithKind:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForStatesOfMind (HKStateOfMindKind kind)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForStatesOfMindWithKind_XHandle, (IntPtr) (long) kind), false)!;
			return ret;
		}
		[Export ("predicateForStatesOfMindWithLabel:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForStatesOfMind (HKStateOfMindLabel label)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForStatesOfMindWithLabel_XHandle, (IntPtr) (long) label), false)!;
			return ret;
		}
		[Export ("predicateForStatesOfMindWithAssociation:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForStatesOfMind (HKStateOfMindAssociation association)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPredicateForStatesOfMindWithAssociation_XHandle, (IntPtr) (long) association), false)!;
			return ret;
		}
		[Export ("predicateForWorkoutsWithOperatorType:totalDistance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForTotalDistance (NSPredicateOperatorType operatorType, HKQuantity totalDistance)
		{
			var totalDistance__handle__ = totalDistance!.GetNonNullHandle (nameof (totalDistance));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_TotalDistance_XHandle, (UIntPtr) (ulong) operatorType, totalDistance__handle__), false)!;
			GC.KeepAlive (totalDistance);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:totalEnergyBurned:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForTotalEnergyBurned (NSPredicateOperatorType operatorType, HKQuantity totalEnergyBurned)
		{
			var totalEnergyBurned__handle__ = totalEnergyBurned!.GetNonNullHandle (nameof (totalEnergyBurned));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_TotalEnergyBurned_XHandle, (UIntPtr) (ulong) operatorType, totalEnergyBurned__handle__), false)!;
			GC.KeepAlive (totalEnergyBurned);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:totalFlightsClimbed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForTotalFlightsClimbed (NSPredicateOperatorType operatorType, HKQuantity totalFlightsClimbed)
		{
			var totalFlightsClimbed__handle__ = totalFlightsClimbed!.GetNonNullHandle (nameof (totalFlightsClimbed));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_TotalFlightsClimbed_XHandle, (UIntPtr) (ulong) operatorType, totalFlightsClimbed__handle__), false)!;
			GC.KeepAlive (totalFlightsClimbed);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:totalSwimmingStrokeCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForTotalSwimmingStrokeCount (NSPredicateOperatorType operatorType, HKQuantity totalSwimmingStrokeCount)
		{
			var totalSwimmingStrokeCount__handle__ = totalSwimmingStrokeCount!.GetNonNullHandle (nameof (totalSwimmingStrokeCount));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_TotalSwimmingStrokeCount_XHandle, (UIntPtr) (ulong) operatorType, totalSwimmingStrokeCount__handle__), false)!;
			GC.KeepAlive (totalSwimmingStrokeCount);
			return ret!;
		}
		[Export ("predicateForUserAnnotatedMedicationsWithHasSchedule:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForUserAnnotatedMedicationsWithHasSchedule (bool hasSchedule)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selPredicateForUserAnnotatedMedicationsWithHasSchedule_XHandle, hasSchedule ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("predicateForUserAnnotatedMedicationsWithIsArchived:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForUserAnnotatedMedicationsWithIsArchived (bool isArchived)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selPredicateForUserAnnotatedMedicationsWithIsArchived_XHandle, isArchived ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("predicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForVerifiableClinicalRecords (NSDateInterval dateInterval)
		{
			var dateInterval__handle__ = dateInterval!.GetNonNullHandle (nameof (dateInterval));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForVerifiableClinicalRecordsWithRelevantDateWithinDateInterval_XHandle, dateInterval__handle__), false)!;
			GC.KeepAlive (dateInterval);
			return ret!;
		}
		[Export ("predicateForWorkoutActivitiesWithWorkoutActivityType:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkoutActivities (HKWorkoutActivityType workoutActivityType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selPredicateForWorkoutActivitiesWithWorkoutActivityType_XHandle, (UIntPtr) (ulong) workoutActivityType), false)!;
			return ret;
		}
		[Export ("predicateForWorkoutActivitiesWithOperatorType:duration:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkoutActivities (NSPredicateOperatorType operatorType, double duration)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_Double (class_ptr, selPredicateForWorkoutActivitiesWithOperatorType_Duration_XHandle, (UIntPtr) (ulong) operatorType, duration), false)!;
			return ret;
		}
		[Export ("predicateForWorkoutActivitiesWithStartDate:endDate:options:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkoutActivities (NSDate? startDate, NSDate? endDate, HKQueryOptions options)
		{
			var startDate__handle__ = startDate.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (class_ptr, selPredicateForWorkoutActivitiesWithStartDate_EndDate_Options_XHandle, startDate__handle__, endDate__handle__, (UIntPtr) (ulong) options), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForWorkoutEffortSamplesRelatedToWorkout:activity:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkoutEffortSamplesRelatedToWorkout (HKWorkout workout, HKWorkoutActivity? activity)
		{
			var workout__handle__ = workout!.GetNonNullHandle (nameof (workout));
			var activity__handle__ = activity.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutEffortSamplesRelatedToWorkout_Activity_XHandle, workout__handle__, activity__handle__), false)!;
			GC.KeepAlive (workout);
			GC.KeepAlive (activity);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithWorkoutActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkouts (HKWorkoutActivityType workoutActivityType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selPredicateForWorkoutsWithWorkoutActivityType_XHandle, (UIntPtr) (ulong) workoutActivityType), false)!;
			return ret;
		}
		[Export ("predicateForWorkoutsWithActivityPredicate:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForWorkouts (NSPredicate activityPredicate)
		{
			var activityPredicate__handle__ = activityPredicate!.GetNonNullHandle (nameof (activityPredicate));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPredicateForWorkoutsWithActivityPredicate_XHandle, activityPredicate__handle__), false)!;
			GC.KeepAlive (activityPredicate);
			return ret!;
		}
		[Export ("predicateForWorkoutActivitiesWithOperatorType:quantityType:sumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetSumQuantityPredicateForWorkoutActivities (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity sumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var sumQuantity__handle__ = sumQuantity!.GetNonNullHandle (nameof (sumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutActivitiesWithOperatorType_QuantityType_SumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, sumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (sumQuantity);
			return ret!;
		}
		[Export ("predicateForWorkoutsWithOperatorType:quantityType:sumQuantity:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetSumQuantityPredicateForWorkouts (NSPredicateOperatorType operatorType, HKQuantityType quantityType, HKQuantity sumQuantity)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var sumQuantity__handle__ = sumQuantity!.GetNonNullHandle (nameof (sumQuantity));
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selPredicateForWorkoutsWithOperatorType_QuantityType_SumQuantity_XHandle, (UIntPtr) (ulong) operatorType, quantityType__handle__, sumQuantity__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (sumQuantity);
			return ret!;
		}
		[Export ("predicateForObjectsWithNoCorrelation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate PredicateForObjectsWithNoCorrelation ()
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPredicateForObjectsWithNoCorrelationXHandle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual HKObjectType? ObjectType {
			[Export ("objectType", ArgumentSemantic.Retain)]
			get {
				HKObjectType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKObjectType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKObjectType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate? Predicate {
			[Export ("predicate", ArgumentSemantic.Retain)]
			get {
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios9.3", "Use 'ObjectType' property.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ObjectType' property.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual HKSampleType? SampleType {
			[Export ("sampleType", ArgumentSemantic.Retain)]
			get {
				HKSampleType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKSampleType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSampleTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKSampleType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSampleTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class HKQuery */
}
