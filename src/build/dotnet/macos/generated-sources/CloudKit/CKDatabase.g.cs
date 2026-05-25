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
namespace CloudKit {
	[Register("CKDatabase", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CKDatabase : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOperation_X = "addOperation:";
		static readonly NativeHandle selAddOperation_XHandle = Selector.GetHandle ("addOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDatabaseScopeX = "databaseScope";
		static readonly NativeHandle selDatabaseScopeXHandle = Selector.GetHandle ("databaseScope");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteRecordWithID_CompletionHandler_X = "deleteRecordWithID:completionHandler:";
		static readonly NativeHandle selDeleteRecordWithID_CompletionHandler_XHandle = Selector.GetHandle ("deleteRecordWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteRecordZoneWithID_CompletionHandler_X = "deleteRecordZoneWithID:completionHandler:";
		static readonly NativeHandle selDeleteRecordZoneWithID_CompletionHandler_XHandle = Selector.GetHandle ("deleteRecordZoneWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSubscriptionWithID_CompletionHandler_X = "deleteSubscriptionWithID:completionHandler:";
		static readonly NativeHandle selDeleteSubscriptionWithID_CompletionHandler_XHandle = Selector.GetHandle ("deleteSubscriptionWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAllRecordZonesWithCompletionHandler_X = "fetchAllRecordZonesWithCompletionHandler:";
		static readonly NativeHandle selFetchAllRecordZonesWithCompletionHandler_XHandle = Selector.GetHandle ("fetchAllRecordZonesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAllSubscriptionsWithCompletionHandler_X = "fetchAllSubscriptionsWithCompletionHandler:";
		static readonly NativeHandle selFetchAllSubscriptionsWithCompletionHandler_XHandle = Selector.GetHandle ("fetchAllSubscriptionsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchRecordWithID_CompletionHandler_X = "fetchRecordWithID:completionHandler:";
		static readonly NativeHandle selFetchRecordWithID_CompletionHandler_XHandle = Selector.GetHandle ("fetchRecordWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchRecordZoneWithID_CompletionHandler_X = "fetchRecordZoneWithID:completionHandler:";
		static readonly NativeHandle selFetchRecordZoneWithID_CompletionHandler_XHandle = Selector.GetHandle ("fetchRecordZoneWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchSubscriptionWithID_CompletionHandler_X = "fetchSubscriptionWithID:completionHandler:";
		static readonly NativeHandle selFetchSubscriptionWithID_CompletionHandler_XHandle = Selector.GetHandle ("fetchSubscriptionWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformQuery_InZoneWithID_CompletionHandler_X = "performQuery:inZoneWithID:completionHandler:";
		static readonly NativeHandle selPerformQuery_InZoneWithID_CompletionHandler_XHandle = Selector.GetHandle ("performQuery:inZoneWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveRecord_CompletionHandler_X = "saveRecord:completionHandler:";
		static readonly NativeHandle selSaveRecord_CompletionHandler_XHandle = Selector.GetHandle ("saveRecord:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveRecordZone_CompletionHandler_X = "saveRecordZone:completionHandler:";
		static readonly NativeHandle selSaveRecordZone_CompletionHandler_XHandle = Selector.GetHandle ("saveRecordZone:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveSubscription_CompletionHandler_X = "saveSubscription:completionHandler:";
		static readonly NativeHandle selSaveSubscription_CompletionHandler_XHandle = Selector.GetHandle ("saveSubscription:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKDatabase");
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
		protected CKDatabase (NSObjectFlag t) : base (t)
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
		protected internal CKDatabase (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOperation (CKDatabaseOperation operation)
		{
			var operation__handle__ = operation!.GetNonNullHandle (nameof (operation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOperation_XHandle, operation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOperation_XHandle, operation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (operation);
		}
		[Export ("deleteRecordWithID:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteRecord (CKRecordID recordId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V46))]global::System.Action<CKRecordID, NSError> completionHandler)
		{
			var recordId__handle__ = recordId!.GetNonNullHandle (nameof (recordId));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V46.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteRecordWithID_CompletionHandler_XHandle, recordId__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteRecordWithID_CompletionHandler_XHandle, recordId__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (recordId);
		}
		/// <param name="recordId">To be added.</param>
		/// <summary>Deletes the record with the <paramref name="recordId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DeleteRecord operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordID,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordID> DeleteRecordAsync (CKRecordID recordId)
		{
			var tcs = new TaskCompletionSource<CKRecordID> ();
			DeleteRecord(recordId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("deleteRecordZoneWithID:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteRecordZone (CKRecordZoneID zoneId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V49))]global::System.Action<CKRecordZoneID, NSError> completionHandler)
		{
			var zoneId__handle__ = zoneId!.GetNonNullHandle (nameof (zoneId));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V49.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteRecordZoneWithID_CompletionHandler_XHandle, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteRecordZoneWithID_CompletionHandler_XHandle, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zoneId);
		}
		/// <param name="zoneId">To be added.</param>
		/// <summary>Deletes the zone at the specified <paramref name="zoneId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DeleteRecordZone operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordZoneID,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordZoneID> DeleteRecordZoneAsync (CKRecordZoneID zoneId)
		{
			var tcs = new TaskCompletionSource<CKRecordZoneID> ();
			DeleteRecordZone(zoneId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("deleteSubscriptionWithID:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteSubscription (string subscriptionID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCKDatabaseDeleteSubscriptionHandler))]CKDatabaseDeleteSubscriptionHandler completionHandler)
		{
			if (subscriptionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subscriptionID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssubscriptionID = CFString.CreateNative (subscriptionID);
			using var block_completionHandler = Trampolines.SDCKDatabaseDeleteSubscriptionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteSubscriptionWithID_CompletionHandler_XHandle, nssubscriptionID, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteSubscriptionWithID_CompletionHandler_XHandle, nssubscriptionID, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssubscriptionID);
		}
		/// <param name="subscriptionID">To be added.</param>
		/// <summary>Deletes the <see cref="CloudKit.CKSubscription" /> with the specified <paramref name="subscriptionID" />.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous DeleteSubscription operation.   The value of the TResult parameter is a CloudKit.CKDatabaseDeleteSubscriptionHandler.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The DeleteSubscriptionAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string> DeleteSubscriptionAsync (string subscriptionID)
		{
			var tcs = new TaskCompletionSource<string> ();
			DeleteSubscription(subscriptionID, (subscriptionId_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (subscriptionId_!);
			});
			return tcs.Task;
		}
		[Export ("fetchAllRecordZonesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchAllRecordZones ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V50))]global::System.Action<CKRecordZone[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V50.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchAllRecordZonesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchAllRecordZonesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Retrieves all record zones, with low priority.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchAllRecordZones operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordZone[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordZone[]> FetchAllRecordZonesAsync ()
		{
			var tcs = new TaskCompletionSource<CKRecordZone[]> ();
			FetchAllRecordZones((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchAllSubscriptionsWithCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchAllSubscriptions ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V51))]global::System.Action<CKSubscription[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V51.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchAllSubscriptionsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchAllSubscriptionsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Retrieves all the <see cref="CloudKit.CKSubscription" /> objects from the database.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchAllSubscriptions operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKSubscription[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKSubscription[]> FetchAllSubscriptionsAsync ()
		{
			var tcs = new TaskCompletionSource<CKSubscription[]> ();
			FetchAllSubscriptions((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchRecordWithID:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchRecord (CKRecordID recordId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V52))]global::System.Action<CKRecord, NSError> completionHandler)
		{
			var recordId__handle__ = recordId!.GetNonNullHandle (nameof (recordId));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V52.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchRecordWithID_CompletionHandler_XHandle, recordId__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchRecordWithID_CompletionHandler_XHandle, recordId__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (recordId);
		}
		/// <param name="recordId">To be added.</param>
		/// <summary>Fetches the <see cref="CloudKit.CKRecord" /> with the specified <paramref name="recordId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchRecord operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecord,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecord> FetchRecordAsync (CKRecordID recordId)
		{
			var tcs = new TaskCompletionSource<CKRecord> ();
			FetchRecord(recordId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchRecordZoneWithID:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchRecordZone (CKRecordZoneID zoneId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V53))]global::System.Action<CKRecordZone, NSError> completionHandler)
		{
			var zoneId__handle__ = zoneId!.GetNonNullHandle (nameof (zoneId));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V53.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchRecordZoneWithID_CompletionHandler_XHandle, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchRecordZoneWithID_CompletionHandler_XHandle, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zoneId);
		}
		/// <param name="zoneId">To be added.</param>
		/// <summary>Fetches the <see cref="CloudKit.CKRecordZone" /> with the specified <paramref name="zoneId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchRecordZone operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordZone,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordZone> FetchRecordZoneAsync (CKRecordZoneID zoneId)
		{
			var tcs = new TaskCompletionSource<CKRecordZone> ();
			FetchRecordZone(zoneId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchSubscriptionWithID:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchSubscription (string subscriptionId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V54))]global::System.Action<CKSubscription, NSError> completionHandler)
		{
			if (subscriptionId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subscriptionId));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssubscriptionId = CFString.CreateNative (subscriptionId);
			using var block_completionHandler = Trampolines.SDActionArity2V54.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchSubscriptionWithID_CompletionHandler_XHandle, nssubscriptionId, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchSubscriptionWithID_CompletionHandler_XHandle, nssubscriptionId, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssubscriptionId);
		}
		/// <param name="subscriptionId">To be added.</param>
		/// <summary>Fetches the <see cref="CloudKit.CKSubscription" /> with the specified <paramref name="subscriptionId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchSubscription operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKSubscription,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKSubscription> FetchSubscriptionAsync (string subscriptionId)
		{
			var tcs = new TaskCompletionSource<CKSubscription> ();
			FetchSubscription(subscriptionId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("performQuery:inZoneWithID:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformQuery (CKQuery query, CKRecordZoneID? zoneId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V55))]global::System.Action<CKRecord[], NSError> completionHandler)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			var zoneId__handle__ = zoneId.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V55.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPerformQuery_InZoneWithID_CompletionHandler_XHandle, query__handle__, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPerformQuery_InZoneWithID_CompletionHandler_XHandle, query__handle__, zoneId__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
			GC.KeepAlive (zoneId);
		}
		/// <param name="query">To be added.</param>
		/// <param name="zoneId">To be added.</param>
		/// <summary>Executes the <paramref name="query" /> on the zone identified by <paramref name="zoneId" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous PerformQuery operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecord[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecord[]> PerformQueryAsync (CKQuery query, CKRecordZoneID? zoneId)
		{
			var tcs = new TaskCompletionSource<CKRecord[]> ();
			PerformQuery(query, zoneId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("saveRecord:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveRecord (CKRecord record, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V52))]global::System.Action<CKRecord, NSError> completionHandler)
		{
			var record__handle__ = record!.GetNonNullHandle (nameof (record));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V52.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSaveRecord_CompletionHandler_XHandle, record__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSaveRecord_CompletionHandler_XHandle, record__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (record);
		}
		/// <param name="record">To be added.</param>
		/// <summary>Saves the specified <see cref="CloudKit.CKRecord" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SaveRecord operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecord,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecord> SaveRecordAsync (CKRecord record)
		{
			var tcs = new TaskCompletionSource<CKRecord> ();
			SaveRecord(record, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("saveRecordZone:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveRecordZone (CKRecordZone zone, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V53))]global::System.Action<CKRecordZone, NSError> completionHandler)
		{
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V53.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSaveRecordZone_CompletionHandler_XHandle, zone__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSaveRecordZone_CompletionHandler_XHandle, zone__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
		}
		/// <param name="zone">To be added.</param>
		/// <summary>Saves the specified <paramref name="zone" /> to the current database.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SaveRecordZone operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordZone,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordZone> SaveRecordZoneAsync (CKRecordZone zone)
		{
			var tcs = new TaskCompletionSource<CKRecordZone> ();
			SaveRecordZone(zone, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("saveSubscription:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveSubscription (CKSubscription subscription, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V54))]global::System.Action<CKSubscription, NSError> completionHandler)
		{
			var subscription__handle__ = subscription!.GetNonNullHandle (nameof (subscription));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V54.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSaveSubscription_CompletionHandler_XHandle, subscription__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSaveSubscription_CompletionHandler_XHandle, subscription__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (subscription);
		}
		/// <param name="subscription">To be added.</param>
		/// <summary>Saves the specified <paramref name="subscription" /> to the current database.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SaveSubscription operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKSubscription,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKSubscription> SaveSubscriptionAsync (CKSubscription subscription)
		{
			var tcs = new TaskCompletionSource<CKSubscription> ();
			SaveSubscription(subscription, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKDatabaseScope DatabaseScope {
			[Export ("databaseScope", ArgumentSemantic.Assign)]
			get {
				CKDatabaseScope ret;
				if (IsDirectBinding) {
					ret = (CKDatabaseScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDatabaseScopeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CKDatabaseScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDatabaseScopeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class CKDatabase */
}
