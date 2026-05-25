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
	/// <summary>Builds a workout from workout data as it is added.</summary>
	[Register("HKWorkoutBuilder", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKWorkoutBuilder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddMetadata_Completion_X = "addMetadata:completion:";
		static readonly NativeHandle selAddMetadata_Completion_XHandle = Selector.GetHandle ("addMetadata:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSamples_Completion_X = "addSamples:completion:";
		static readonly NativeHandle selAddSamples_Completion_XHandle = Selector.GetHandle ("addSamples:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddWorkoutActivity_Completion_X = "addWorkoutActivity:completion:";
		static readonly NativeHandle selAddWorkoutActivity_Completion_XHandle = Selector.GetHandle ("addWorkoutActivity:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddWorkoutEvents_Completion_X = "addWorkoutEvents:completion:";
		static readonly NativeHandle selAddWorkoutEvents_Completion_XHandle = Selector.GetHandle ("addWorkoutEvents:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllStatisticsX = "allStatistics";
		static readonly NativeHandle selAllStatisticsXHandle = Selector.GetHandle ("allStatistics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginCollectionWithStartDate_Completion_X = "beginCollectionWithStartDate:completion:";
		static readonly NativeHandle selBeginCollectionWithStartDate_Completion_XHandle = Selector.GetHandle ("beginCollectionWithStartDate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscardWorkoutX = "discardWorkout";
		static readonly NativeHandle selDiscardWorkoutXHandle = Selector.GetHandle ("discardWorkout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElapsedTimeAtDate_X = "elapsedTimeAtDate:";
		static readonly NativeHandle selElapsedTimeAtDate_XHandle = Selector.GetHandle ("elapsedTimeAtDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndCollectionWithEndDate_Completion_X = "endCollectionWithEndDate:completion:";
		static readonly NativeHandle selEndCollectionWithEndDate_Completion_XHandle = Selector.GetHandle ("endCollectionWithEndDate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndDateX = "endDate";
		static readonly NativeHandle selEndDateXHandle = Selector.GetHandle ("endDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishWorkoutWithCompletion_X = "finishWorkoutWithCompletion:";
		static readonly NativeHandle selFinishWorkoutWithCompletion_XHandle = Selector.GetHandle ("finishWorkoutWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHealthStore_Configuration_Device_X = "initWithHealthStore:configuration:device:";
		static readonly NativeHandle selInitWithHealthStore_Configuration_Device_XHandle = Selector.GetHandle ("initWithHealthStore:configuration:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataX = "metadata";
		static readonly NativeHandle selMetadataXHandle = Selector.GetHandle ("metadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeriesBuilderForType_X = "seriesBuilderForType:";
		static readonly NativeHandle selSeriesBuilderForType_XHandle = Selector.GetHandle ("seriesBuilderForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatisticsForType_X = "statisticsForType:";
		static readonly NativeHandle selStatisticsForType_XHandle = Selector.GetHandle ("statisticsForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateActivityWithUUID_AddMedatata_Completion_X = "updateActivityWithUUID:addMedatata:completion:";
		static readonly NativeHandle selUpdateActivityWithUUID_AddMedatata_Completion_XHandle = Selector.GetHandle ("updateActivityWithUUID:addMedatata:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateActivityWithUUID_EndDate_Completion_X = "updateActivityWithUUID:endDate:completion:";
		static readonly NativeHandle selUpdateActivityWithUUID_EndDate_Completion_XHandle = Selector.GetHandle ("updateActivityWithUUID:endDate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutActivitiesX = "workoutActivities";
		static readonly NativeHandle selWorkoutActivitiesXHandle = Selector.GetHandle ("workoutActivities");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutConfigurationX = "workoutConfiguration";
		static readonly NativeHandle selWorkoutConfigurationXHandle = Selector.GetHandle ("workoutConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkoutEventsX = "workoutEvents";
		static readonly NativeHandle selWorkoutEventsXHandle = Selector.GetHandle ("workoutEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKWorkoutBuilder");
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
		protected HKWorkoutBuilder (NSObjectFlag t) : base (t)
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
		protected internal HKWorkoutBuilder (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithHealthStore:configuration:device:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public HKWorkoutBuilder (HKHealthStore healthStore, HKWorkoutConfiguration configuration, HKDevice? device)
			: base (NSObjectFlag.Empty)
		{
			var healthStore__handle__ = healthStore!.GetNonNullHandle (nameof (healthStore));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var device__handle__ = device.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithHealthStore_Configuration_Device_XHandle, healthStore__handle__, configuration__handle__, device__handle__), "initWithHealthStore:configuration:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithHealthStore_Configuration_Device_XHandle, healthStore__handle__, configuration__handle__, device__handle__), "initWithHealthStore:configuration:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (healthStore);
			GC.KeepAlive (configuration);
			GC.KeepAlive (device);
		}
		[Export ("addSamples:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Add (HKSample[] samples, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			if (samples is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samples));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_samples = NSArray.FromNSObjects (samples);
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddSamples_Completion_XHandle, nsa_samples.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddSamples_Completion_XHandle, nsa_samples.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="samples">The samples to add.</param>
		/// <summary>Adds the specified samples and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> AddAsync (HKSample[] samples)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			Add(samples, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("addWorkoutEvents:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Add (HKWorkoutEvent[] workoutEvents, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			if (workoutEvents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (workoutEvents));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_workoutEvents = NSArray.FromNSObjects (workoutEvents);
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddWorkoutEvents_Completion_XHandle, nsa_workoutEvents.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddWorkoutEvents_Completion_XHandle, nsa_workoutEvents.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="workoutEvents">The workout events to add.</param>
		/// <summary>Adds the specified workout events and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> AddAsync (HKWorkoutEvent[] workoutEvents)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			Add(workoutEvents, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("addMetadata:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual void Add (NSDictionary metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddMetadata_Completion_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddMetadata_Completion_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (metadata);
		}
		/// <param name="metadata">The metadata to add.</param>
		/// <summary>Adds the specified metadata and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual Task<Tuple<bool,NSError?>> AddAsync (NSDictionary metadata)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			Add(metadata, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		/// <param name="metadata">The metadata to add.</param><param name="completionHandler">A handler to run when the operation completes.</param><summary>Adds the specified metadata to the workout and runs a handler when the operation completes.</summary><remarks>To be added.</remarks><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Add (HKMetadata metadata, HKWorkoutBuilderCompletionHandler completionHandler)
		{
			Add (metadata.GetDictionary ()!, completionHandler);
		}
		/// <param name="metadata">The metadata to add.</param>
		/// <summary>Adds the specified metadata and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<Tuple<bool,NSError?>> AddAsync (HKMetadata metadata)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			Add(metadata, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("addWorkoutActivity:completion:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddWorkoutActivity (HKWorkoutActivity workoutActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completion)
		{
			var workoutActivity__handle__ = workoutActivity!.GetNonNullHandle (nameof (workoutActivity));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddWorkoutActivity_Completion_XHandle, workoutActivity__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddWorkoutActivity_Completion_XHandle, workoutActivity__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (workoutActivity);
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> AddWorkoutActivityAsync (HKWorkoutActivity workoutActivity)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			AddWorkoutActivity(workoutActivity, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("beginCollectionWithStartDate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginCollection (NSDate startDate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selBeginCollectionWithStartDate_Completion_XHandle, startDate__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selBeginCollectionWithStartDate_Completion_XHandle, startDate__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startDate);
		}
		/// <param name="startDate">The date and time the workout starts.</param>
		/// <summary>Starts the workout at the specified time, begins collecting workout data, and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> BeginCollectionAsync (NSDate startDate)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			BeginCollection(startDate, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("discardWorkout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscardWorkout ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDiscardWorkoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDiscardWorkoutXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("endCollectionWithEndDate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndCollection (NSDate endDate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEndCollectionWithEndDate_Completion_XHandle, endDate__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEndCollectionWithEndDate_Completion_XHandle, endDate__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (endDate);
		}
		/// <param name="endDate">The end time of the workout.</param>
		/// <summary>Ends the workout and returns a task that contains a success status and any error that occurred.</summary>
		/// <returns>A task that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> EndCollectionAsync (NSDate endDate)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			EndCollection(endDate, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("finishWorkoutWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishWorkout ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishWorkoutWithCompletion_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishWorkoutWithCompletion_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Saves a new workout, created with the collected data, to the Health Store. Returns a handler that contains a success status and any error that occurred.</summary>
		/// <returns>A handler that contains a success status and any error that occurred.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> FinishWorkoutAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			FinishWorkout((success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("elapsedTimeAtDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetElapsedTime (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, selElapsedTimeAtDate_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_NativeHandle (&__objc_super__, selElapsedTimeAtDate_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("seriesBuilderForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKSeriesBuilder? GetSeriesBuilder (HKSeriesType seriesType)
		{
			var seriesType__handle__ = seriesType!.GetNonNullHandle (nameof (seriesType));
			HKSeriesBuilder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKSeriesBuilder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSeriesBuilderForType_XHandle, seriesType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKSeriesBuilder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSeriesBuilderForType_XHandle, seriesType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (seriesType);
			return ret!;
		}
		[Export ("statisticsForType:")]
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
		[Export ("updateActivityWithUUID:endDate:completion:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdateActivity (NSUuid uuid, NSDate endDate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completion)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selUpdateActivityWithUUID_EndDate_Completion_XHandle, uuid__handle__, endDate__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selUpdateActivityWithUUID_EndDate_Completion_XHandle, uuid__handle__, endDate__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uuid);
			GC.KeepAlive (endDate);
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> UpdateActivityAsync (NSUuid uuid, NSDate endDate)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			UpdateActivity(uuid, endDate, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("updateActivityWithUUID:addMedatata:completion:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdateActivity (NSUuid uuid, NSDictionary<NSString, NSObject> metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutBuilderCompletionHandler))]HKWorkoutBuilderCompletionHandler completion)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKWorkoutBuilderCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selUpdateActivityWithUUID_AddMedatata_Completion_XHandle, uuid__handle__, metadata__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selUpdateActivityWithUUID_AddMedatata_Completion_XHandle, uuid__handle__, metadata__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uuid);
			GC.KeepAlive (metadata);
		}
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> UpdateActivityAsync (NSUuid uuid, NSDictionary<NSString, NSObject> metadata)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			UpdateActivity(uuid, metadata, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
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
		public virtual HKDevice? Device {
			[Export ("device", ArgumentSemantic.Copy)]
			get {
				HKDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? EndDate {
			[Export ("endDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEndDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEndDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the workout metadata.</summary><value>The workout metadata.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public HKMetadata Metadata {
			get {
				var src = NativeMetadata is not null ? new NSMutableDictionary (NativeMetadata) : null;
				return src is null ? null! : new HKMetadata(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSDictionary NativeMetadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? StartDate {
			[Export ("startDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartDateXHandle), false)!;
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
		public virtual HKWorkoutConfiguration WorkoutConfiguration {
			[Export ("workoutConfiguration", ArgumentSemantic.Copy)]
			get {
				HKWorkoutConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKWorkoutConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWorkoutConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKWorkoutConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWorkoutConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKWorkoutEvent[] WorkoutEvents {
			[Export ("workoutEvents", ArgumentSemantic.Copy)]
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
	} /* class HKWorkoutBuilder */
}
