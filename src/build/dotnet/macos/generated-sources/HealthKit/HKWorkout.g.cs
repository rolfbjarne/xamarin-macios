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
	/// <summary>An <see cref="T:HealthKit.HKSample" /> that represents a physical workout.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKWorkout_Class/index.html">Apple documentation for <c>HKWorkout</c></related>
	[Register("HKWorkout", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKWorkout : HKSample {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllStatisticsX = "allStatistics";
		static readonly NativeHandle selAllStatisticsXHandle = Selector.GetHandle ("allStatistics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatisticsForType_X = "statisticsForType:";
		static readonly NativeHandle selStatisticsForType_XHandle = Selector.GetHandle ("statisticsForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalDistanceX = "totalDistance";
		static readonly NativeHandle selTotalDistanceXHandle = Selector.GetHandle ("totalDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalEnergyBurnedX = "totalEnergyBurned";
		static readonly NativeHandle selTotalEnergyBurnedXHandle = Selector.GetHandle ("totalEnergyBurned");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalFlightsClimbedX = "totalFlightsClimbed";
		static readonly NativeHandle selTotalFlightsClimbedXHandle = Selector.GetHandle ("totalFlightsClimbed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalSwimmingStrokeCountX = "totalSwimmingStrokeCount";
		static readonly NativeHandle selTotalSwimmingStrokeCountXHandle = Selector.GetHandle ("totalSwimmingStrokeCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutActivitiesX = "workoutActivities";
		static readonly NativeHandle selWorkoutActivitiesXHandle = Selector.GetHandle ("workoutActivities");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutActivityTypeX = "workoutActivityType";
		static readonly NativeHandle selWorkoutActivityTypeXHandle = Selector.GetHandle ("workoutActivityType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutEventsX = "workoutEvents";
		static readonly NativeHandle selWorkoutEventsXHandle = Selector.GetHandle ("workoutEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_X = "workoutWithActivityType:startDate:endDate:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Device_Metadata_X = "workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:device:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Device_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Metadata_X = "workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Device_Metadata_X = "workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:device:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Device_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Metadata_X = "workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalFlightsClimbed_Device_Metadata_X = "workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalFlightsClimbed:device:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalFlightsClimbed_Device_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalFlightsClimbed:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalSwimmingStrokeCount_Device_Metadata_X = "workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalSwimmingStrokeCount:device:metadata:";
		static readonly NativeHandle selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalSwimmingStrokeCount_Device_Metadata_XHandle = Selector.GetHandle ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalSwimmingStrokeCount:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKWorkout");
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
		public HKWorkout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKWorkout (NSObjectFlag t) : base (t)
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
		protected internal HKWorkout (NativeHandle handle) : base (handle)
		{
		}

		[Export ("workoutWithActivityType:startDate:endDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:metadata:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[]? workoutEvents, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			using var nsa_workoutEvents = workoutEvents is null ? null : NSArray.FromNSObjects (workoutEvents);
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, nsa_workoutEvents.GetHandle (), totalEnergyBurned__handle__, totalDistance__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="workoutEvents">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="metadata">To be added.</param><summary>Creates an activity that lasts from <paramref name="startDate" /> to <paramref name="endDate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[] workoutEvents, HKQuantity totalEnergyBurned, HKQuantity totalDistance, HKMetadata metadata)
		{
			return Create (workoutActivityType, startDate, endDate, workoutEvents, totalEnergyBurned, totalDistance, metadata.GetDictionary ());
		}
		[Export ("workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:metadata:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, double duration, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, duration, totalEnergyBurned__handle__, totalDistance__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="duration">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="metadata">To be added.</param><summary>Creates an activity that lasts from <paramref name="startDate" /> to <paramref name="endDate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, double duration, HKQuantity totalEnergyBurned, HKQuantity totalDistance, HKMetadata metadata)
		{
			return Create (workoutActivityType, startDate, endDate, duration, totalEnergyBurned, totalDistance, metadata.GetDictionary ());
		}
		[Export ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[]? workoutEvents, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, HKDevice? device, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			using var nsa_workoutEvents = workoutEvents is null ? null : NSArray.FromNSObjects (workoutEvents);
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_Device_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, nsa_workoutEvents.GetHandle (), totalEnergyBurned__handle__, totalDistance__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="workoutEvents">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="device">To be added.</param><param name="metadata">To be added.</param><summary>Creates and returns a new <see cref="T:HealthKit.HKWorkout" /> with the provide values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[] workoutEvents, HKQuantity totalEnergyBurned, HKQuantity totalDistance, HKDevice device, HKMetadata metadata)
		{
			return Create (workoutActivityType, startDate, endDate, workoutEvents, totalEnergyBurned, totalDistance, device, metadata.GetDictionary ());
		}
		[Export ("workoutWithActivityType:startDate:endDate:duration:totalEnergyBurned:totalDistance:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, double duration, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, HKDevice? device, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_Duration_TotalEnergyBurned_TotalDistance_Device_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, duration, totalEnergyBurned__handle__, totalDistance__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="duration">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="device">To be added.</param><param name="metadata">To be added.</param><summary>Creates and returns a new <see cref="T:HealthKit.HKWorkout" /> with the provide values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, double duration, HKQuantity totalEnergyBurned, HKQuantity totalDistance, HKDevice device, HKMetadata metadata)
		{
			return Create (workoutActivityType, startDate, endDate, duration, totalEnergyBurned, totalDistance, device, metadata.GetDictionary ());
		}
		[Export ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalSwimmingStrokeCount:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[]? workoutEvents, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, HKQuantity? totalSwimmingStrokeCount, HKDevice? device, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var totalSwimmingStrokeCount__handle__ = totalSwimmingStrokeCount.GetHandle ();
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			using var nsa_workoutEvents = workoutEvents is null ? null : NSArray.FromNSObjects (workoutEvents);
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalSwimmingStrokeCount_Device_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, nsa_workoutEvents.GetHandle (), totalEnergyBurned__handle__, totalDistance__handle__, totalSwimmingStrokeCount__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (totalSwimmingStrokeCount);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="workoutEvents">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="totalSwimmingStrokeCount">To be added.</param><param name="device">To be added.</param><param name="metadata">To be added.</param><summary>Creates and returns a new <see cref="T:HealthKit.HKWorkout" /> with the provide values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout Create (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[] workoutEvents, HKQuantity totalEnergyBurned, HKQuantity totalDistance, HKQuantity totalSwimmingStrokeCount, HKDevice device, HKMetadata metadata)
		{
			return Create (workoutActivityType, startDate, endDate, workoutEvents, totalEnergyBurned, totalDistance, totalSwimmingStrokeCount, device, metadata.GetDictionary ());
		}
		[Export ("workoutWithActivityType:startDate:endDate:workoutEvents:totalEnergyBurned:totalDistance:totalFlightsClimbed:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout CreateFlightsClimbedWorkout (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[]? workoutEvents, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, HKQuantity? totalFlightsClimbed, HKDevice? device, NSDictionary? metadata)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var totalEnergyBurned__handle__ = totalEnergyBurned.GetHandle ();
			var totalDistance__handle__ = totalDistance.GetHandle ();
			var totalFlightsClimbed__handle__ = totalFlightsClimbed.GetHandle ();
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			using var nsa_workoutEvents = workoutEvents is null ? null : NSArray.FromNSObjects (workoutEvents);
			HKWorkout? ret;
			ret =  Runtime.GetNSObject<HKWorkout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selWorkoutWithActivityType_StartDate_EndDate_WorkoutEvents_TotalEnergyBurned_TotalDistance_TotalFlightsClimbed_Device_Metadata_XHandle, (UIntPtr) (ulong) workoutActivityType, startDate__handle__, endDate__handle__, nsa_workoutEvents.GetHandle (), totalEnergyBurned__handle__, totalDistance__handle__, totalFlightsClimbed__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (totalEnergyBurned);
			GC.KeepAlive (totalDistance);
			GC.KeepAlive (totalFlightsClimbed);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="workoutActivityType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="workoutEvents">To be added.</param><param name="totalEnergyBurned">To be added.</param><param name="totalDistance">To be added.</param><param name="totalFlightsClimbed">To be added.</param><param name="device">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKWorkout CreateFlightsClimbedWorkout (HKWorkoutActivityType workoutActivityType, NSDate startDate, NSDate endDate, HKWorkoutEvent[]? workoutEvents, HKQuantity? totalEnergyBurned, HKQuantity? totalDistance, HKQuantity? totalFlightsClimbed, HKDevice? device, HKMetadata? metadata)
		{
			return CreateFlightsClimbedWorkout (workoutActivityType, startDate, endDate, workoutEvents, totalEnergyBurned, totalDistance, totalFlightsClimbed, device, metadata.GetDictionary ());
		}
		[Export ("statisticsForType:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKStatistics? GetStatistics (HKQuantityType quantityType)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			HKStatistics? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKStatistics> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStatisticsForType_XHandle, quantityType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKStatistics> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStatisticsForType_XHandle, quantityType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (quantityType);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual NSDictionary<HKQuantityType, HKStatistics> AllStatistics {
			[Export ("allStatistics", ArgumentSemantic.Copy)]
			get {
				NSDictionary<HKQuantityType, HKStatistics>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<HKQuantityType, HKStatistics>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllStatisticsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<HKQuantityType, HKStatistics>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllStatisticsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual HKQuantity? TotalDistance {
			[Export ("totalDistance", ArgumentSemantic.Retain)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTotalDistanceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTotalDistanceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual HKQuantity? TotalEnergyBurned {
			[Export ("totalEnergyBurned", ArgumentSemantic.Retain)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTotalEnergyBurnedXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTotalEnergyBurnedXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual HKQuantity? TotalFlightsClimbed {
			[Export ("totalFlightsClimbed", ArgumentSemantic.Retain)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTotalFlightsClimbedXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTotalFlightsClimbedXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual HKQuantity? TotalSwimmingStrokeCount {
			[Export ("totalSwimmingStrokeCount", ArgumentSemantic.Retain)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTotalSwimmingStrokeCountXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTotalSwimmingStrokeCountXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual HKWorkoutActivity[] WorkoutActivities {
			[Export ("workoutActivities", ArgumentSemantic.Copy)]
			get {
				HKWorkoutActivity[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<HKWorkoutActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWorkoutActivitiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<HKWorkoutActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWorkoutActivitiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKWorkoutActivityType WorkoutActivityType {
			[Export ("workoutActivityType")]
			get {
				HKWorkoutActivityType ret;
				if (IsDirectBinding) {
					ret = (HealthKit.HKWorkoutActivityType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selWorkoutActivityTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (HealthKit.HKWorkoutActivityType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selWorkoutActivityTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKWorkoutEvent[]? WorkoutEvents {
			[Export ("workoutEvents")]
			get {
				HKWorkoutEvent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<HKWorkoutEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWorkoutEventsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<HKWorkoutEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWorkoutEventsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortIdentifierDuration;
		/// <summary>Represents the value associated with the constant HKWorkoutSortIdentifierDuration</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKWorkoutSortIdentifierDuration",  "HealthKit")]
		public static NSString SortIdentifierDuration {
			get {
				if (_SortIdentifierDuration is null)
					_SortIdentifierDuration = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKWorkoutSortIdentifierDuration")!;
				return _SortIdentifierDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortIdentifierTotalDistance;
		/// <summary>Represents the value associated with the constant HKWorkoutSortIdentifierTotalDistance</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKWorkoutSortIdentifierTotalDistance",  "HealthKit")]
		public static NSString SortIdentifierTotalDistance {
			get {
				if (_SortIdentifierTotalDistance is null)
					_SortIdentifierTotalDistance = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKWorkoutSortIdentifierTotalDistance")!;
				return _SortIdentifierTotalDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortIdentifierTotalEnergyBurned;
		/// <summary>Represents the value associated with the constant HKWorkoutSortIdentifierTotalEnergyBurned</summary><value></value><remarks>To be added.</remarks>
		[Field ("HKWorkoutSortIdentifierTotalEnergyBurned",  "HealthKit")]
		public static NSString SortIdentifierTotalEnergyBurned {
			get {
				if (_SortIdentifierTotalEnergyBurned is null)
					_SortIdentifierTotalEnergyBurned = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKWorkoutSortIdentifierTotalEnergyBurned")!;
				return _SortIdentifierTotalEnergyBurned;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortIdentifierTotalFlightsClimbed;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKWorkoutSortIdentifierTotalFlightsClimbed",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SortIdentifierTotalFlightsClimbed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SortIdentifierTotalFlightsClimbed is null)
					_SortIdentifierTotalFlightsClimbed = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKWorkoutSortIdentifierTotalFlightsClimbed")!;
				return _SortIdentifierTotalFlightsClimbed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortIdentifierTotalSwimmingStrokeCount;
		/// <summary>Represents the value that is associated with the HKWorkoutSortIdentifierTotalSwimmingStrokeCount constant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKWorkoutSortIdentifierTotalSwimmingStrokeCount",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString SortIdentifierTotalSwimmingStrokeCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_SortIdentifierTotalSwimmingStrokeCount is null)
					_SortIdentifierTotalSwimmingStrokeCount = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKWorkoutSortIdentifierTotalSwimmingStrokeCount")!;
				return _SortIdentifierTotalSwimmingStrokeCount;
			}
		}
	} /* class HKWorkout */
}
