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
	/// <summary>Builds quantity sample series.</summary>
	[Register("HKQuantitySeriesSampleBuilder", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKQuantitySeriesSampleBuilder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscardX = "discard";
		static readonly NativeHandle selDiscardXHandle = Selector.GetHandle ("discard");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishSeriesWithMetadata_Completion_X = "finishSeriesWithMetadata:completion:";
		static readonly NativeHandle selFinishSeriesWithMetadata_Completion_XHandle = Selector.GetHandle ("finishSeriesWithMetadata:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishSeriesWithMetadata_EndDate_Completion_X = "finishSeriesWithMetadata:endDate:completion:";
		static readonly NativeHandle selFinishSeriesWithMetadata_EndDate_Completion_XHandle = Selector.GetHandle ("finishSeriesWithMetadata:endDate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHealthStore_QuantityType_StartDate_Device_X = "initWithHealthStore:quantityType:startDate:device:";
		static readonly NativeHandle selInitWithHealthStore_QuantityType_StartDate_Device_XHandle = Selector.GetHandle ("initWithHealthStore:quantityType:startDate:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertQuantity_Date_Error_X = "insertQuantity:date:error:";
		static readonly NativeHandle selInsertQuantity_Date_Error_XHandle = Selector.GetHandle ("insertQuantity:date:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertQuantity_DateInterval_Error_X = "insertQuantity:dateInterval:error:";
		static readonly NativeHandle selInsertQuantity_DateInterval_Error_XHandle = Selector.GetHandle ("insertQuantity:dateInterval:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantityTypeX = "quantityType";
		static readonly NativeHandle selQuantityTypeXHandle = Selector.GetHandle ("quantityType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKQuantitySeriesSampleBuilder");
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
		protected HKQuantitySeriesSampleBuilder (NSObjectFlag t) : base (t)
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
		protected internal HKQuantitySeriesSampleBuilder (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithHealthStore:quantityType:startDate:device:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public HKQuantitySeriesSampleBuilder (HKHealthStore healthStore, HKQuantityType quantityType, NSDate startDate, HKDevice? device)
			: base (NSObjectFlag.Empty)
		{
			var healthStore__handle__ = healthStore!.GetNonNullHandle (nameof (healthStore));
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var device__handle__ = device.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithHealthStore_QuantityType_StartDate_Device_XHandle, healthStore__handle__, quantityType__handle__, startDate__handle__, device__handle__), "initWithHealthStore:quantityType:startDate:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithHealthStore_QuantityType_StartDate_Device_XHandle, healthStore__handle__, quantityType__handle__, startDate__handle__, device__handle__), "initWithHealthStore:quantityType:startDate:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (healthStore);
			GC.KeepAlive (quantityType);
			GC.KeepAlive (startDate);
			GC.KeepAlive (device);
		}
		[Export ("discard")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Discard ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDiscardXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDiscardXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finishSeriesWithMetadata:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual void FinishSeries (NSDictionary? metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKQuantitySeriesSampleBuilderFinishSeriesDelegate))]HKQuantitySeriesSampleBuilderFinishSeriesDelegate completionHandler)
		{
			var metadata__handle__ = metadata.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKQuantitySeriesSampleBuilderFinishSeriesDelegate.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFinishSeriesWithMetadata_Completion_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFinishSeriesWithMetadata_Completion_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (metadata);
		}
		/// <param name="metadata">The metadata to add to the series.</param>
		/// <summary>Finishes and saves the series and returns a task that contains the sample data.</summary>
		/// <returns>A task that contains the sample data.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual Task<HKQuantitySample[]> FinishSeriesAsync (NSDictionary? metadata)
		{
			var tcs = new TaskCompletionSource<HKQuantitySample[]> ();
			FinishSeries(metadata, (samples_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (samples_!);
			});
			return tcs.Task;
		}
		/// <param name="metadata">The metadata to add to the series.</param><param name="completionHandler">A handler to run when the operation completes.</param><summary>Finishes and saves the series.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishSeries (HKMetadata? metadata, HKQuantitySeriesSampleBuilderFinishSeriesDelegate completionHandler)
		{
			FinishSeries (metadata.GetDictionary (), completionHandler);
		}
		/// <param name="metadata">The metadata to add to the series.</param>
		/// <summary>Finishes and saves the series and returns a task that contains the sample data.</summary>
		/// <returns>A task that contains the sample data.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<HKQuantitySample[]> FinishSeriesAsync (HKMetadata? metadata)
		{
			var tcs = new TaskCompletionSource<HKQuantitySample[]> ();
			FinishSeries(metadata, (samples_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (samples_!);
			});
			return tcs.Task;
		}
		[Export ("finishSeriesWithMetadata:endDate:completion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishSeries (NSDictionary? metadata, NSDate? endDate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKQuantitySeriesSampleBuilderFinishSeriesDelegate))]HKQuantitySeriesSampleBuilderFinishSeriesDelegate completionHandler)
		{
			var metadata__handle__ = metadata.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDHKQuantitySeriesSampleBuilderFinishSeriesDelegate.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selFinishSeriesWithMetadata_EndDate_Completion_XHandle, metadata__handle__, endDate__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selFinishSeriesWithMetadata_EndDate_Completion_XHandle, metadata__handle__, endDate__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (metadata);
			GC.KeepAlive (endDate);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<HKQuantitySample[]> FinishSeriesAsync (NSDictionary? metadata, NSDate? endDate)
		{
			var tcs = new TaskCompletionSource<HKQuantitySample[]> ();
			FinishSeries(metadata, endDate, (samples_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (samples_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishSeries (HKMetadata? metadata, NSDate? endDate, HKQuantitySeriesSampleBuilderFinishSeriesDelegate completionHandler)
		{
			FinishSeries (metadata.GetDictionary (), endDate, completionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<HKQuantitySample[]> FinishSeriesAsync (HKMetadata? metadata, NSDate? endDate)
		{
			var tcs = new TaskCompletionSource<HKQuantitySample[]> ();
			FinishSeries(metadata, endDate, (samples_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (samples_!);
			});
			return tcs.Task;
		}
		[Export ("insertQuantity:date:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Insert (HKQuantity quantity, NSDate date, out NSError? error)
		{
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInsertQuantity_Date_Error_XHandle, quantity__handle__, date__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInsertQuantity_Date_Error_XHandle, quantity__handle__, date__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (quantity);
			GC.KeepAlive (date);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("insertQuantity:dateInterval:error:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Insert (HKQuantity quantity, NSDateInterval dateInterval, out NSError? error)
		{
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			var dateInterval__handle__ = dateInterval!.GetNonNullHandle (nameof (dateInterval));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInsertQuantity_DateInterval_Error_XHandle, quantity__handle__, dateInterval__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInsertQuantity_DateInterval_Error_XHandle, quantity__handle__, dateInterval__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (quantity);
			GC.KeepAlive (dateInterval);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
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
		public virtual HKQuantityType QuantityType {
			[Export ("quantityType", ArgumentSemantic.Copy)]
			get {
				HKQuantityType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantityType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQuantityTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantityType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQuantityTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate StartDate {
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
	} /* class HKQuantitySeriesSampleBuilder */
}
