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
namespace FileProvider {
	/// <summary>A shared object that is accessible from both the containing app and the extension.</summary>
	[Register("NSFileProviderManager", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFileProviderManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddDomain_CompletionHandler_X = "addDomain:completionHandler:";
		static readonly NativeHandle selAddDomain_CompletionHandler_XHandle = Selector.GetHandle ("addDomain:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_X = "checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:";
		static readonly NativeHandle selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_XHandle = Selector.GetHandle ("checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectWithReason_Options_CompletionHandler_X = "disconnectWithReason:options:completionHandler:";
		static readonly NativeHandle selDisconnectWithReason_Options_CompletionHandler_XHandle = Selector.GetHandle ("disconnectWithReason:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorForMaterializedItemsX = "enumeratorForMaterializedItems";
		static readonly NativeHandle selEnumeratorForMaterializedItemsXHandle = Selector.GetHandle ("enumeratorForMaterializedItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorForPendingItemsX = "enumeratorForPendingItems";
		static readonly NativeHandle selEnumeratorForPendingItemsXHandle = Selector.GetHandle ("enumeratorForPendingItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEvictItemWithIdentifier_CompletionHandler_X = "evictItemWithIdentifier:completionHandler:";
		static readonly NativeHandle selEvictItemWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("evictItemWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetDomainsWithCompletionHandler_X = "getDomainsWithCompletionHandler:";
		static readonly NativeHandle selGetDomainsWithCompletionHandler_XHandle = Selector.GetHandle ("getDomainsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetIdentifierForUserVisibleFileAtURL_CompletionHandler_X = "getIdentifierForUserVisibleFileAtURL:completionHandler:";
		static readonly NativeHandle selGetIdentifierForUserVisibleFileAtURL_CompletionHandler_XHandle = Selector.GetHandle ("getIdentifierForUserVisibleFileAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetServiceWithName_ItemIdentifier_CompletionHandler_X = "getServiceWithName:itemIdentifier:completionHandler:";
		static readonly NativeHandle selGetServiceWithName_ItemIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("getServiceWithName:itemIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetUserVisibleURLForItemIdentifier_CompletionHandler_X = "getUserVisibleURLForItemIdentifier:completionHandler:";
		static readonly NativeHandle selGetUserVisibleURLForItemIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("getUserVisibleURLForItemIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlobalProgressForKind_X = "globalProgressForKind:";
		static readonly NativeHandle selGlobalProgressForKind_XHandle = Selector.GetHandle ("globalProgressForKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImportDomain_FromDirectoryAtURL_CompletionHandler_X = "importDomain:fromDirectoryAtURL:completionHandler:";
		static readonly NativeHandle selImportDomain_FromDirectoryAtURL_CompletionHandler_XHandle = Selector.GetHandle ("importDomain:fromDirectoryAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListAvailableTestingOperationsWithError_X = "listAvailableTestingOperationsWithError:";
		static readonly NativeHandle selListAvailableTestingOperationsWithError_XHandle = Selector.GetHandle ("listAvailableTestingOperationsWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManagerForDomain_X = "managerForDomain:";
		static readonly NativeHandle selManagerForDomain_XHandle = Selector.GetHandle ("managerForDomain:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReconnectWithCompletionHandler_X = "reconnectWithCompletionHandler:";
		static readonly NativeHandle selReconnectWithCompletionHandler_XHandle = Selector.GetHandle ("reconnectWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterURLSessionTask_ForItemWithIdentifier_CompletionHandler_X = "registerURLSessionTask:forItemWithIdentifier:completionHandler:";
		static readonly NativeHandle selRegisterURLSessionTask_ForItemWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("registerURLSessionTask:forItemWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReimportItemsBelowItemWithIdentifier_CompletionHandler_X = "reimportItemsBelowItemWithIdentifier:completionHandler:";
		static readonly NativeHandle selReimportItemsBelowItemWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("reimportItemsBelowItemWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllDomainsWithCompletionHandler_X = "removeAllDomainsWithCompletionHandler:";
		static readonly NativeHandle selRemoveAllDomainsWithCompletionHandler_XHandle = Selector.GetHandle ("removeAllDomainsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDomain_CompletionHandler_X = "removeDomain:completionHandler:";
		static readonly NativeHandle selRemoveDomain_CompletionHandler_XHandle = Selector.GetHandle ("removeDomain:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDomain_Mode_CompletionHandler_X = "removeDomain:mode:completionHandler:";
		static readonly NativeHandle selRemoveDomain_Mode_CompletionHandler_XHandle = Selector.GetHandle ("removeDomain:mode:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestDownloadForItemWithIdentifier_RequestedRange_CompletionHandler_X = "requestDownloadForItemWithIdentifier:requestedRange:completionHandler:";
		static readonly NativeHandle selRequestDownloadForItemWithIdentifier_RequestedRange_CompletionHandler_XHandle = Selector.GetHandle ("requestDownloadForItemWithIdentifier:requestedRange:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestModificationOfFields_ForItemWithIdentifier_Options_CompletionHandler_X = "requestModificationOfFields:forItemWithIdentifier:options:completionHandler:";
		static readonly NativeHandle selRequestModificationOfFields_ForItemWithIdentifier_Options_CompletionHandler_XHandle = Selector.GetHandle ("requestModificationOfFields:forItemWithIdentifier:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunTestingOperations_Error_X = "runTestingOperations:error:";
		static readonly NativeHandle selRunTestingOperations_Error_XHandle = Selector.GetHandle ("runTestingOperations:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignalEnumeratorForContainerItemIdentifier_CompletionHandler_X = "signalEnumeratorForContainerItemIdentifier:completionHandler:";
		static readonly NativeHandle selSignalEnumeratorForContainerItemIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("signalEnumeratorForContainerItemIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignalErrorResolved_CompletionHandler_X = "signalErrorResolved:completionHandler:";
		static readonly NativeHandle selSignalErrorResolved_CompletionHandler_XHandle = Selector.GetHandle ("signalErrorResolved:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryDirectoryURLWithError_X = "temporaryDirectoryURLWithError:";
		static readonly NativeHandle selTemporaryDirectoryURLWithError_XHandle = Selector.GetHandle ("temporaryDirectoryURLWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitForChangesOnItemsBelowItemWithIdentifier_CompletionHandler_X = "waitForChangesOnItemsBelowItemWithIdentifier:completionHandler:";
		static readonly NativeHandle selWaitForChangesOnItemsBelowItemWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("waitForChangesOnItemsBelowItemWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitForStabilizationWithCompletionHandler_X = "waitForStabilizationWithCompletionHandler:";
		static readonly NativeHandle selWaitForStabilizationWithCompletionHandler_XHandle = Selector.GetHandle ("waitForStabilizationWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileProviderManager");
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
		protected NSFileProviderManager (NSObjectFlag t) : base (t)
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
		protected internal NSFileProviderManager (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="domain">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addDomain:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddDomain (NSFileProviderDomain domain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAddDomain_CompletionHandler_XHandle, domain__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (domain);
		}
		/// <param name="domain">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous AddDomain operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task AddDomainAsync (NSFileProviderDomain domain)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AddDomain(domain, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool CheckDomainsCanBeStored (out bool eligible, NSUrl volumeAtUrl, out NSFileProviderVolumeUnsupportedReason unsupportedReason, out NSError? error)
		{
			var volumeAtUrl__handle__ = volumeAtUrl!.GetNonNullHandle (nameof (volumeAtUrl));
			fixed (bool* eligible__pointer = &eligible) {
			fixed (NSFileProviderVolumeUnsupportedReason* unsupportedReason__pointer = &unsupportedReason) {
			NativeHandle errorValue = IntPtr.Zero;
			eligible = default;
			unsupportedReason = default;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_Boolean_NativeHandle_out_NSFileProviderVolumeUnsupportedReason_ref_NativeHandle (class_ptr, selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_XHandle, (byte*) eligible__pointer, volumeAtUrl__handle__, unsupportedReason__pointer, &errorValue);
			GC.KeepAlive (volumeAtUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
			}
			}
		}
		[Export ("disconnectWithReason:options:completionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Disconnect (string localizedReason, NSFileProviderManagerDisconnectionOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (localizedReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedReason));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nslocalizedReason = CFString.CreateNative (localizedReason);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDisconnectWithReason_Options_CompletionHandler_XHandle, nslocalizedReason, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDisconnectWithReason_Options_CompletionHandler_XHandle, nslocalizedReason, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizedReason);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DisconnectAsync (string localizedReason, NSFileProviderManagerDisconnectionOptions options)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Disconnect(localizedReason, options, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("evictItemWithIdentifier:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvictItem (NSString itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEvictItemWithIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEvictItemWithIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EvictItemAsync (NSString itemIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EvictItem(itemIdentifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="domain">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("managerForDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderManager? FromDomain (NSFileProviderDomain domain)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			NSFileProviderManager? ret;
			ret =  Runtime.GetNSObject<NSFileProviderManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selManagerForDomain_XHandle, domain__handle__), false)!;
			GC.KeepAlive (domain);
			return ret!;
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getDomainsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetDomains ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V71))]global::System.Action<NSFileProviderDomain[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V71.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selGetDomainsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetDomains operation.  The value of the TResult parameter is of type System.Action&lt;FileProvider.NSFileProviderDomain[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSFileProviderDomain[]> GetDomainsAsync ()
		{
			var tcs = new TaskCompletionSource<NSFileProviderDomain[]> ();
			GetDomains((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("enumeratorForPendingItems")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderPendingSetEnumerator GetEnumeratorForPendingItems ()
		{
			INSFileProviderPendingSetEnumerator ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSFileProviderPendingSetEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEnumeratorForPendingItemsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSFileProviderPendingSetEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEnumeratorForPendingItemsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("globalProgressForKind:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSProgress GetGlobalProgress (NSString kind)
		{
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGlobalProgressForKind_XHandle, kind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGlobalProgressForKind_XHandle, kind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			return ret!;
		}
		[Export ("getIdentifierForUserVisibleFileAtURL:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetIdentifierForUserVisibleFile (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderGetIdentifierHandler))]NSFileProviderGetIdentifierHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderGetIdentifierHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selGetIdentifierForUserVisibleFileAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSFileProviderGetIdentifierResult> GetIdentifierForUserVisibleFileAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<NSFileProviderGetIdentifierResult> ();
			GetIdentifierForUserVisibleFile(url, (itemIdentifier_, domainIdentifier_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSFileProviderGetIdentifierResult (itemIdentifier_!, domainIdentifier_!));
			});
			return tcs.Task;
		}
		[Export ("enumeratorForMaterializedItems")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderEnumerator GetMaterializedItemsEnumerator ()
		{
			INSFileProviderEnumerator ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSFileProviderEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEnumeratorForMaterializedItemsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSFileProviderEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEnumeratorForMaterializedItemsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("runTestingOperations:error:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary<INSFileProviderTestingOperation, NSError>? GetRunTestingOperations (INSFileProviderTestingOperation[] operations, out NSError? error)
		{
			if (operations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (operations));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_operations = NSArray.FromNSObjects (operations);
			NSDictionary<INSFileProviderTestingOperation, NSError>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<INSFileProviderTestingOperation, NSError>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selRunTestingOperations_Error_XHandle, nsa_operations.Handle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<INSFileProviderTestingOperation, NSError>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selRunTestingOperations_Error_XHandle, nsa_operations.Handle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("getServiceWithName:itemIdentifier:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetService (string serviceName, string itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V72))]global::System.Action<NSFileProviderService, NSError> completionHandler)
		{
			if (serviceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceName));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsserviceName = CFString.CreateNative (serviceName);
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V72.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGetServiceWithName_ItemIdentifier_CompletionHandler_XHandle, nsserviceName, nsitemIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGetServiceWithName_ItemIdentifier_CompletionHandler_XHandle, nsserviceName, nsitemIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsserviceName);
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSFileProviderService> GetServiceAsync (string serviceName, string itemIdentifier)
		{
			var tcs = new TaskCompletionSource<NSFileProviderService> ();
			GetService(serviceName, itemIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("temporaryDirectoryURLWithError:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl? GetTemporaryDirectoryUrl (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selTemporaryDirectoryURLWithError_XHandle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selTemporaryDirectoryURLWithError_XHandle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("getUserVisibleURLForItemIdentifier:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetUserVisibleUrl (NSString itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V23))]global::System.Action<NSUrl, NSError> completionHandler)
		{
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V23.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetUserVisibleURLForItemIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetUserVisibleURLForItemIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSUrl> GetUserVisibleUrlAsync (NSString itemIdentifier)
		{
			var tcs = new TaskCompletionSource<NSUrl> ();
			GetUserVisibleUrl(itemIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("importDomain:fromDirectoryAtURL:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Import (NSFileProviderDomain domain, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selImportDomain_FromDirectoryAtURL_CompletionHandler_XHandle, domain__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (domain);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ImportAsync (NSFileProviderDomain domain, NSUrl url)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Import(domain, url, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("listAvailableTestingOperationsWithError:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual INSFileProviderTestingOperation[]? ListAvailableTestingOperations (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			INSFileProviderTestingOperation[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<INSFileProviderTestingOperation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selListAvailableTestingOperationsWithError_XHandle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<INSFileProviderTestingOperation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selListAvailableTestingOperationsWithError_XHandle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("reconnectWithCompletionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Reconnect ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReconnectWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReconnectWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReconnectAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			Reconnect((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="task">To be added.</param><param name="identifier">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("registerURLSessionTask:forItemWithIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Register (NSUrlSessionTask task, string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRegisterURLSessionTask_ForItemWithIdentifier_CompletionHandler_XHandle, task__handle__, nsidentifier, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRegisterURLSessionTask_ForItemWithIdentifier_CompletionHandler_XHandle, task__handle__, nsidentifier, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (task);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("reimportItemsBelowItemWithIdentifier:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReimportItemsBelowItem (NSString itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReimportItemsBelowItemWithIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReimportItemsBelowItemWithIdentifier_CompletionHandler_XHandle, itemIdentifier__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReimportItemsBelowItemAsync (NSString itemIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReimportItemsBelowItem(itemIdentifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllDomainsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RemoveAllDomains ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRemoveAllDomainsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous RemoveAllDomains operation</returns>
		/// <remarks>
		///           <para copied="true">The RemoveAllDomainsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task RemoveAllDomainsAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveAllDomains((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="domain">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeDomain:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RemoveDomain (NSFileProviderDomain domain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selRemoveDomain_CompletionHandler_XHandle, domain__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (domain);
		}
		/// <param name="domain">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous RemoveDomain operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task RemoveDomainAsync (NSFileProviderDomain domain)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveDomain(domain, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("removeDomain:mode:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RemoveDomain (NSFileProviderDomain domain, NSFileProviderDomainRemovalMode mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V23))]global::System.Action<NSUrl, NSError> completionHandler)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V23.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (class_ptr, selRemoveDomain_Mode_CompletionHandler_XHandle, domain__handle__, (IntPtr) (long) mode, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (domain);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSUrl> RemoveDomainAsync (NSFileProviderDomain domain, NSFileProviderDomainRemovalMode mode)
		{
			var tcs = new TaskCompletionSource<NSUrl> ();
			RemoveDomain(domain, mode, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("requestDownloadForItemWithIdentifier:requestedRange:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestDownload (string itemIdentifier, NSRange rangeToMaterialize, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle (this.Handle, selRequestDownloadForItemWithIdentifier_RequestedRange_CompletionHandler_XHandle, nsitemIdentifier, rangeToMaterialize, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_NativeHandle (&__objc_super__, selRequestDownloadForItemWithIdentifier_RequestedRange_CompletionHandler_XHandle, nsitemIdentifier, rangeToMaterialize, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RequestDownloadAsync (string itemIdentifier, NSRange rangeToMaterialize)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RequestDownload(itemIdentifier, rangeToMaterialize, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("requestModificationOfFields:forItemWithIdentifier:options:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestModification (NSFileProviderItemFields fields, string itemIdentifier, NSFileProviderModifyItemOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle (this.Handle, selRequestModificationOfFields_ForItemWithIdentifier_Options_CompletionHandler_XHandle, (UIntPtr) (ulong) fields, nsitemIdentifier, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selRequestModificationOfFields_ForItemWithIdentifier_Options_CompletionHandler_XHandle, (UIntPtr) (ulong) fields, nsitemIdentifier, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RequestModificationAsync (NSFileProviderItemFields fields, string itemIdentifier, NSFileProviderModifyItemOptions options)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RequestModification(fields, itemIdentifier, options, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="containerItemIdentifier">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("signalEnumeratorForContainerItemIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SignalEnumerator (string containerItemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			if (containerItemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (containerItemIdentifier));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscontainerItemIdentifier = CFString.CreateNative (containerItemIdentifier);
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSignalEnumeratorForContainerItemIdentifier_CompletionHandler_XHandle, nscontainerItemIdentifier, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSignalEnumeratorForContainerItemIdentifier_CompletionHandler_XHandle, nscontainerItemIdentifier, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscontainerItemIdentifier);
		}
		[Export ("signalErrorResolved:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SignalErrorResolved (NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSignalErrorResolved_CompletionHandler_XHandle, error__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSignalErrorResolved_CompletionHandler_XHandle, error__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SignalErrorResolvedAsync (NSError error)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SignalErrorResolved(error, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("waitForChangesOnItemsBelowItemWithIdentifier:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WaitForChangesOnItemsBelowItem (string itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWaitForChangesOnItemsBelowItemWithIdentifier_CompletionHandler_XHandle, nsitemIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWaitForChangesOnItemsBelowItemWithIdentifier_CompletionHandler_XHandle, nsitemIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task WaitForChangesOnItemsBelowItemAsync (string itemIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			WaitForChangesOnItemsBelowItem(itemIdentifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("waitForStabilizationWithCompletionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WaitForStabilization ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWaitForStabilizationWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWaitForStabilizationWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task WaitForStabilizationAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			WaitForStabilization((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaterializedSetDidChange;
		/// <summary>Notification constant for MaterializedSetDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMaterializedSetDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMaterializedSetDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSFileProviderManager.Notifications.ObserveMaterializedSetDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSFileProviderManager.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFileProviderManager.Notifications.ObserveMaterializedSetDidChange (Callback);
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
		///     NSFileProviderManager.MaterializedSetDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification MaterializedSetDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MaterializedSetDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFileProviderManager.MaterializedSetDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSFileProviderMaterializedSetDidChange",  "FileProvider")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSFileProviderManager.Notifications.ObserveMaterializedSetDidChange helper method instead.")]
		public static NSString MaterializedSetDidChange {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MaterializedSetDidChange is null)
					_MaterializedSetDidChange = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderMaterializedSetDidChange")!;
				return _MaterializedSetDidChange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PendingSetDidChange;
		/// <summary>Notification constant for PendingSetDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePendingSetDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePendingSetDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSFileProviderManager.Notifications.ObservePendingSetDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSFileProviderManager.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFileProviderManager.Notifications.ObservePendingSetDidChange (Callback);
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
		///     NSFileProviderManager.PendingSetDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification PendingSetDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PendingSetDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFileProviderManager.PendingSetDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSFileProviderPendingSetDidChange",  "FileProvider")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSFileProviderManager.Notifications.ObservePendingSetDidChange helper method instead.")]
		public static NSString PendingSetDidChange {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PendingSetDidChange is null)
					_PendingSetDidChange = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderPendingSetDidChange")!;
				return _PendingSetDidChange;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::FileProvider.NSFileProviderManager" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::FileProvider.NSFileProviderManager.MaterializedSetDidChange" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::FileProvider.NSFileProviderManager.MaterializedSetDidChange" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFileProviderManager.Notifications.ObserveMaterializedSetDidChange ((notification) => {
			///   Console.WriteLine ("Observed MaterializedSetDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMaterializedSetDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MaterializedSetDidChange, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::FileProvider.NSFileProviderManager.MaterializedSetDidChange" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::FileProvider.NSFileProviderManager.MaterializedSetDidChange" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFileProviderManager.Notifications.ObserveMaterializedSetDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MaterializedSetDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMaterializedSetDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MaterializedSetDidChange, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::FileProvider.NSFileProviderManager.PendingSetDidChange" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::FileProvider.NSFileProviderManager.PendingSetDidChange" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFileProviderManager.Notifications.ObservePendingSetDidChange ((notification) => {
			///   Console.WriteLine ("Observed PendingSetDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePendingSetDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PendingSetDidChange, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::FileProvider.NSFileProviderManager.PendingSetDidChange" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::FileProvider.NSFileProviderManager.PendingSetDidChange" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFileProviderManager.Notifications.ObservePendingSetDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PendingSetDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePendingSetDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PendingSetDidChange, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSFileProviderManager */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSFileProviderGetIdentifierResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSString ItemIdentifier { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSString DomainIdentifier { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="itemIdentifier">Result value from an asynchronous operation.</param>
		/// <param name="domainIdentifier">Result value from an asynchronous operation.</param>
		public NSFileProviderGetIdentifierResult (NSString itemIdentifier, NSString domainIdentifier) {
			this.ItemIdentifier = itemIdentifier;
			this.DomainIdentifier = domainIdentifier;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSFileProviderRemoveDomainResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSUrl Arg1 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		public NSFileProviderRemoveDomainResult (NSUrl arg1) {
			this.Arg1 = arg1;
			Initialize ();
		}
	}
}
