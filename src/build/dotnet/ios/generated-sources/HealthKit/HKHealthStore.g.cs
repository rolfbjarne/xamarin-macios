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
	/// <summary>MonoTouch.HealthKit.HKHealthStore A connection to the system-wide database of health-related information.</summary><remarks><para>Individual <see cref="T:HealthKit.HKHealthStore" /> instances represent connections to the underlying data store. Instantiating a <see cref="T:HealthKit.HKHealthStore" /> does not necessarily imply that the user has granted any amount of access for reading or querying data. App devs must call <see cref="M:HealthKit.HKHealthStore.RequestAuthorizationToShare(Foundation.NSSet,Foundation.NSSet,System.Action{System.Boolean,Foundation.NSError})" /> or <see cref="HealthKit.HKHealthStore.RequestAuthorizationToShareAsync(Foundation.NSSet,Foundation.NSSet)" /> prior to access.</para><para>The result of <see cref="HealthKit.HKHealthStore.RequestAuthorizationToShareAsync(Foundation.NSSet,Foundation.NSSet)" /> or <see cref="M:HealthKit.HKHealthStore.RequestAuthorizationToShare(Foundation.NSSet,Foundation.NSSet,System.Action{System.Boolean,Foundation.NSError})" /> does not indicate that the user allowed access to the requested data; it indicates only that the user interacted with the permissions dialog (or that an error occurred while presenting that dialog). To validate access to a particular data type, developers must use the <see cref="M:HealthKit.HKHealthStore.GetAuthorizationStatus(HealthKit.HKObjectType)" /> method:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var temperatureKey = HKQuantityTypeIdentifierKey.BodyTemperature;
	/// var tempQuantityType = HKObjectType.GetQuantityType (temperatureKey);
	/// 
	/// var hks = new HKHealthStore ();
	/// var success = await hks.RequestAuthorizationToShareAsync (new NSSet (new [] { tempQuantityType }), new NSSet ());
	/// if (success)
	/// {
	/// var access = hks.GetAuthorizationStatus (tempQuantityType);
	/// if (access.HasFlag (HKAuthorizationStatus.SharingAuthorized)) {
	/// 	 //...etc...
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKHealthStore_Class/index.html">Apple documentation for <c>HKHealthStore</c></related>
	[Register("HKHealthStore", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKHealthStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKHealthStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="HKHealthStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HKHealthStore () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
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
		protected HKHealthStore (NSObjectFlag t) : base (t)
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
		protected internal HKHealthStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addSamples:toWorkout:completion:")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'HKWorkoutBuilder.Add (HKSample [] samples, HKWorkoutBuilderCompletionHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use 'HKWorkoutBuilder.Add (HKSample [] samples, HKWorkoutBuilderCompletionHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'HKWorkoutBuilder.Add (HKSample [] samples, HKWorkoutBuilderCompletionHandler completionHandler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddSamples (HKSample[] samples, HKWorkout workout, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKStoreSampleAddedCallback))]HKStoreSampleAddedCallback callback)
		{
			if (samples is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (samples));
			var workout__handle__ = workout!.GetNonNullHandle (nameof (workout));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var nsa_samples = NSArray.FromNSObjects (samples);
			using var block_callback = Trampolines.SDHKStoreSampleAddedCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addSamples:toWorkout:completion:"), nsa_samples.Handle, workout__handle__, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("addSamples:toWorkout:completion:"), nsa_samples.Handle, workout__handle__, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (workout);
		}
		[Export ("deleteObject:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteObject (HKObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("deleteObject:withCompletion:"), obj__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("deleteObject:withCompletion:"), obj__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param>
		/// <summary>Deletes and object from the store and runs an action after it has been deleted.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DeleteObject operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> DeleteObjectAsync (HKObject obj)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			DeleteObject(obj, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("deleteObjects:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteObjects (HKObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("deleteObjects:withCompletion:"), nsa_objects.Handle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("deleteObjects:withCompletion:"), nsa_objects.Handle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objects">To be added.</param>
		/// <summary>Deletes the specified <paramref name="objects" /> from the store and runs a completion handler when it is finished.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DeleteObjects operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> DeleteObjectsAsync (HKObject[] objects)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			DeleteObjects(objects, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		/// <param name="objectType">To be added.</param><param name="predicate">To be added.</param><param name="completion">A handler to run when the operation completes.</param><summary>Deletes the objects that match the specified <paramref name="objectType" /> and <paramref name="predicate" /> from the store and runs a completion handler when it is finished.</summary><remarks>To be added.</remarks>
		[Export ("deleteObjectsOfType:predicate:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteObjects (HKObjectType objectType, NSPredicate predicate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V14))]global::System.Action<bool, nuint, NSError> completion)
		{
			var objectType__handle__ = objectType!.GetNonNullHandle (nameof (objectType));
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity3V14.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("deleteObjectsOfType:predicate:withCompletion:"), objectType__handle__, predicate__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("deleteObjectsOfType:predicate:withCompletion:"), objectType__handle__, predicate__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectType);
			GC.KeepAlive (predicate);
		}
		[Export ("disableAllBackgroundDeliveryWithCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DisableAllBackgroundDelivery ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("disableAllBackgroundDeliveryWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("disableAllBackgroundDeliveryWithCompletion:"), (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Disables the background delivery of notifications and runs an action after delivery has been disabled.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DisableAllBackgroundDelivery operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> DisableAllBackgroundDeliveryAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			DisableAllBackgroundDelivery((arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("disableBackgroundDeliveryForType:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DisableBackgroundDelivery (HKObjectType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("disableBackgroundDeliveryForType:withCompletion:"), type__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("disableBackgroundDeliveryForType:withCompletion:"), type__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (type);
		}
		/// <param name="type">The object type for which to disable background notifications.</param>
		/// <summary>Disables the background delivery of notifications of the specified type and runs an action after delivery has been disabled.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DisableBackgroundDelivery operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> DisableBackgroundDeliveryAsync (HKObjectType type)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			DisableBackgroundDelivery(type, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("enableBackgroundDeliveryForType:frequency:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnableBackgroundDelivery (HKObjectType type, HKUpdateFrequency frequency, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enableBackgroundDeliveryForType:frequency:withCompletion:"), type__handle__, (IntPtr) (long) frequency, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("enableBackgroundDeliveryForType:frequency:withCompletion:"), type__handle__, (IntPtr) (long) frequency, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (type);
		}
		/// <param name="type">The object type for which to enable background notifications.</param>
		/// <param name="frequency">The maximum allowed update frequency.</param>
		/// <summary>Enable the background delivery of notifications of the specified type and runs an action after delivery has been disabled.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous EnableBackgroundDelivery operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> EnableBackgroundDeliveryAsync (HKObjectType type, HKUpdateFrequency frequency)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			EnableBackgroundDelivery(type, frequency, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("executeQuery:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExecuteQuery (HKQuery query)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("executeQuery:"), query__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("executeQuery:"), query__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
		}
		[Export ("activityMoveModeWithError:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual HKActivityMoveModeObject? GetActivityMoveMode (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			HKActivityMoveModeObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKActivityMoveModeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("activityMoveModeWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKActivityMoveModeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("activityMoveModeWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("authorizationStatusForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKAuthorizationStatus GetAuthorizationStatus (HKObjectType type)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			HKAuthorizationStatus ret;
			if (IsDirectBinding) {
				ret = (HealthKit.HKAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("authorizationStatusForType:"), type__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (HealthKit.HKAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("authorizationStatusForType:"), type__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (type);
			return ret!;
		}
		[Export ("biologicalSexWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual HKBiologicalSexObject? GetBiologicalSex (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			HKBiologicalSexObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKBiologicalSexObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("biologicalSexWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKBiologicalSexObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("biologicalSexWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("bloodTypeWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual HKBloodTypeObject? GetBloodType (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			HKBloodTypeObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKBloodTypeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("bloodTypeWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKBloodTypeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("bloodTypeWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("dateOfBirthWithError:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'GetDateOfBirthComponents' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetDateOfBirthComponents' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDate? GetDateOfBirth (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("dateOfBirthWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("dateOfBirthWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("dateOfBirthComponentsWithError:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDateComponents? GetDateOfBirthComponents (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSDateComponents? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("dateOfBirthComponentsWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("dateOfBirthComponentsWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("fitzpatrickSkinTypeWithError:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual HKFitzpatrickSkinTypeObject? GetFitzpatrickSkinType (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			HKFitzpatrickSkinTypeObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKFitzpatrickSkinTypeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("fitzpatrickSkinTypeWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKFitzpatrickSkinTypeObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("fitzpatrickSkinTypeWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("preferredUnitsForQuantityTypes:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetPreferredUnits (NSSet quantityTypes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V110))]global::System.Action<NSDictionary, NSError> completion)
		{
			var quantityTypes__handle__ = quantityTypes!.GetNonNullHandle (nameof (quantityTypes));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V110.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("preferredUnitsForQuantityTypes:completion:"), quantityTypes__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("preferredUnitsForQuantityTypes:completion:"), quantityTypes__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (quantityTypes);
		}
		/// <param name="quantityTypes">To be added.</param>
		/// <summary>Asynchronously gets the preffered units as a <see cref="Foundation.NSDictionary" /> of <see cref="HealthKit.HKQuantityType" />-&gt;<see cref="HealthKit.HKUnit" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetPreferredUnits operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSDictionary,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetPreferredUnitsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary> GetPreferredUnitsAsync (NSSet quantityTypes)
		{
			var tcs = new TaskCompletionSource<NSDictionary> ();
			GetPreferredUnits(quantityTypes, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("getRequestStatusForAuthorizationToShareTypes:readTypes:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetRequestStatusForAuthorizationToShare (NSSet<HKSampleType> typesToShare, NSSet<HKObjectType> typesToRead, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKHealthStoreGetRequestStatusForAuthorizationToShareHandler))]HKHealthStoreGetRequestStatusForAuthorizationToShareHandler completion)
		{
			var typesToShare__handle__ = typesToShare!.GetNonNullHandle (nameof (typesToShare));
			var typesToRead__handle__ = typesToRead!.GetNonNullHandle (nameof (typesToRead));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKHealthStoreGetRequestStatusForAuthorizationToShareHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getRequestStatusForAuthorizationToShareTypes:readTypes:completion:"), typesToShare__handle__, typesToRead__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("getRequestStatusForAuthorizationToShareTypes:readTypes:completion:"), typesToShare__handle__, typesToRead__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (typesToShare);
			GC.KeepAlive (typesToRead);
		}
		/// <param name="typesToShare">The types for which to request share authorization status.</param>
		/// <param name="typesToRead">The types for which to request read authorization status.</param>
		/// <summary>Queries the the authorization request status of the specified types.</summary>
		/// <returns>A task that contains the value that communicates whether the app needs to request user permission.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<HKAuthorizationRequestStatus> GetRequestStatusForAuthorizationToShareAsync (NSSet<HKSampleType> typesToShare, NSSet<HKObjectType> typesToRead)
		{
			var tcs = new TaskCompletionSource<HKAuthorizationRequestStatus> ();
			GetRequestStatusForAuthorizationToShare(typesToShare, typesToRead, (requestStatus_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (requestStatus_!);
			});
			return tcs.Task;
		}
		[Export ("wheelchairUseWithError:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual HKWheelchairUseObject? GetWheelchairUse (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			HKWheelchairUseObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKWheelchairUseObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("wheelchairUseWithError:"), &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKWheelchairUseObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("wheelchairUseWithError:"), &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("handleAuthorizationForExtensionWithCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAuthorizationForExtension ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("handleAuthorizationForExtensionWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("handleAuthorizationForExtensionWithCompletion:"), (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Requests authorization for an extension to read and write data, and runs a completion handler that receives a Boolean success value and an error object.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous HandleAuthorizationForExtension operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> HandleAuthorizationForExtensionAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			HandleAuthorizationForExtension((arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("recalibrateEstimatesForSampleType:atDate:completion:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RecalibrateEstimates (HKSampleType sampleType, NSDate date, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var sampleType__handle__ = sampleType!.GetNonNullHandle (nameof (sampleType));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("recalibrateEstimatesForSampleType:atDate:completion:"), sampleType__handle__, date__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("recalibrateEstimatesForSampleType:atDate:completion:"), sampleType__handle__, date__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleType);
			GC.KeepAlive (date);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> RecalibrateEstimatesAsync (HKSampleType sampleType, NSDate date)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			RecalibrateEstimates(sampleType, date, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("recoverActiveWorkoutSessionWithCompletion:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RecoverActiveWorkoutSession ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKHealthStoreRecoverActiveWorkoutSessionHandler))]HKHealthStoreRecoverActiveWorkoutSessionHandler completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKHealthStoreRecoverActiveWorkoutSessionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recoverActiveWorkoutSessionWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("recoverActiveWorkoutSessionWithCompletion:"), (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<HKWorkoutSession> RecoverActiveWorkoutSessionAsync ()
		{
			var tcs = new TaskCompletionSource<HKWorkoutSession> ();
			RecoverActiveWorkoutSession((session_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (session_!);
			});
			return tcs.Task;
		}
		[Export ("requestAuthorizationToShareTypes:readTypes:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAuthorizationToShare (NSSet? typesToShare, NSSet? typesToRead, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var typesToShare__handle__ = typesToShare.GetHandle ();
			var typesToRead__handle__ = typesToRead.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestAuthorizationToShareTypes:readTypes:completion:"), typesToShare__handle__, typesToRead__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("requestAuthorizationToShareTypes:readTypes:completion:"), typesToShare__handle__, typesToRead__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (typesToShare);
			GC.KeepAlive (typesToRead);
		}
		/// <param name="typesToShare">To be added.</param>
		/// <param name="typesToRead">To be added.</param>
		/// <summary>Requests autorization to save and read user data and runs an action after a determination has been made.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestAuthorizationToShare operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> RequestAuthorizationToShareAsync (NSSet? typesToShare, NSSet? typesToRead)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			RequestAuthorizationToShare(typesToShare, typesToRead, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("requestPerObjectReadAuthorizationForType:predicate:completion:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestPerObjectReadAuthorization (HKObjectType objectType, NSPredicate? predicate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKHealthStoreCompletionHandler))]HKHealthStoreCompletionHandler completion)
		{
			var objectType__handle__ = objectType!.GetNonNullHandle (nameof (objectType));
			var predicate__handle__ = predicate.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKHealthStoreCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestPerObjectReadAuthorizationForType:predicate:completion:"), objectType__handle__, predicate__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("requestPerObjectReadAuthorizationForType:predicate:completion:"), objectType__handle__, predicate__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectType);
			GC.KeepAlive (predicate);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestPerObjectReadAuthorizationAsync (HKObjectType objectType, NSPredicate? predicate)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestPerObjectReadAuthorization(objectType, predicate, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("saveObject:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveObject (HKObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("saveObject:withCompletion:"), obj__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("saveObject:withCompletion:"), obj__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param>
		/// <summary>Asynchronously saves <paramref name="obj" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SaveObject operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> SaveObjectAsync (HKObject obj)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			SaveObject(obj, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("saveObjects:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveObjects (HKObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("saveObjects:withCompletion:"), nsa_objects.Handle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("saveObjects:withCompletion:"), nsa_objects.Handle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objects">To be added.</param>
		/// <summary>Asynchronously saves the objects that are contained in  <paramref name="objects" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SaveObjects operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> SaveObjectsAsync (HKObject[] objects)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			SaveObjects(objects, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("splitTotalEnergy:startDate:endDate:resultsHandler:")]
		[ObsoletedOSPlatform ("ios11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SplitTotalEnergy (HKQuantity totalEnergy, NSDate startDate, NSDate endDate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V15))]global::System.Action<HKQuantity, HKQuantity, NSError> resultsHandler)
		{
			var totalEnergy__handle__ = totalEnergy!.GetNonNullHandle (nameof (totalEnergy));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			if (resultsHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resultsHandler));
			using var block_resultsHandler = Trampolines.SDActionArity3V15.CreateBlock (resultsHandler);
			BlockLiteral *block_ptr_resultsHandler = &block_resultsHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("splitTotalEnergy:startDate:endDate:resultsHandler:"), totalEnergy__handle__, startDate__handle__, endDate__handle__, (IntPtr) block_ptr_resultsHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("splitTotalEnergy:startDate:endDate:resultsHandler:"), totalEnergy__handle__, startDate__handle__, endDate__handle__, (IntPtr) block_ptr_resultsHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (totalEnergy);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
		}
		[Export ("startWatchAppWithWorkoutConfiguration:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartWatchApp (HKWorkoutConfiguration workoutConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError> completion)
		{
			var workoutConfiguration__handle__ = workoutConfiguration!.GetNonNullHandle (nameof (workoutConfiguration));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("startWatchAppWithWorkoutConfiguration:completion:"), workoutConfiguration__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("startWatchAppWithWorkoutConfiguration:completion:"), workoutConfiguration__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (workoutConfiguration);
		}
		/// <param name="workoutConfiguration">To be added.</param>
		/// <summary>Launches or wakes the Watch app for the workout.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous StartWatchApp operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> StartWatchAppAsync (HKWorkoutConfiguration workoutConfiguration)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			StartWatchApp(workoutConfiguration, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("stopQuery:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopQuery (HKQuery query)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stopQuery:"), query__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("stopQuery:"), query__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual global::UIKit.UIViewController? AuthorizationViewControllerPresenter {
			[Export ("authorizationViewControllerPresenter")]
			get {
				global::UIKit.UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("authorizationViewControllerPresenter")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("authorizationViewControllerPresenter")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAuthorizationViewControllerPresenter:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAuthorizationViewControllerPresenter:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAuthorizationViewControllerPresenter:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual NSDate EarliestPermittedSampleDate {
			[Export ("earliestPermittedSampleDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("earliestPermittedSampleDate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("earliestPermittedSampleDate")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsHealthDataAvailable {
			[Export ("isHealthDataAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isHealthDataAvailable"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual bool SupportsHealthRecords {
			[Export ("supportsHealthRecords")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsHealthRecords"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supportsHealthRecords"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public unsafe virtual global::System.Action<HKWorkoutSession>? WorkoutSessionMirroringStartHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V76))]
			[Export ("workoutSessionMirroringStartHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("workoutSessionMirroringStartHandler"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("workoutSessionMirroringStartHandler"));
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V76.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]
			[Export ("setWorkoutSessionMirroringStartHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V76.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setWorkoutSessionMirroringStartHandler:"), (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setWorkoutSessionMirroringStartHandler:"), (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserPreferencesDidChangeNotification;
		/// <summary>Notification constant for UserPreferencesDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUserPreferencesDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUserPreferencesDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = HKHealthStore.Notifications.ObserveUserPreferencesDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, HKHealthStore.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = HKHealthStore.Notifications.ObserveUserPreferencesDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     HKHealthStore.UserPreferencesDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification UserPreferencesDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UserPreferencesDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (HKHealthStore.UserPreferencesDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("HKUserPreferencesDidChangeNotification",  "HealthKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Advice ("Use HKHealthStore.Notifications.ObserveUserPreferencesDidChange helper method instead.")]
		public static NSString UserPreferencesDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_UserPreferencesDidChangeNotification is null)
					_UserPreferencesDidChangeNotification = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKUserPreferencesDidChangeNotification")!;
				return _UserPreferencesDidChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::HealthKit.HKHealthStore" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::HealthKit.HKHealthStore.UserPreferencesDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::HealthKit.HKHealthStore.UserPreferencesDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = HKHealthStore.Notifications.ObserveUserPreferencesDidChange ((notification) => {
			///   Console.WriteLine ("Observed UserPreferencesDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUserPreferencesDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UserPreferencesDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::HealthKit.HKHealthStore.UserPreferencesDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::HealthKit.HKHealthStore.UserPreferencesDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = HKHealthStore.Notifications.ObserveUserPreferencesDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UserPreferencesDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUserPreferencesDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UserPreferencesDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class HKHealthStore */
}
