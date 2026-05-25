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
namespace AVFoundation {
	[Register("AVContentKeySession", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVContentKeySession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentKeySessionWithKeySystem_X = "contentKeySessionWithKeySystem:";
		static readonly NativeHandle selContentKeySessionWithKeySystem_XHandle = Selector.GetHandle ("contentKeySessionWithKeySystem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentKeySessionWithKeySystem_StorageDirectoryAtURL_X = "contentKeySessionWithKeySystem:storageDirectoryAtURL:";
		static readonly NativeHandle selContentKeySessionWithKeySystem_StorageDirectoryAtURL_XHandle = Selector.GetHandle ("contentKeySessionWithKeySystem:storageDirectoryAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentProtectionSessionIdentifierX = "contentProtectionSessionIdentifier";
		static readonly NativeHandle selContentProtectionSessionIdentifierXHandle = Selector.GetHandle ("contentProtectionSessionIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateQueueX = "delegateQueue";
		static readonly NativeHandle selDelegateQueueXHandle = Selector.GetHandle ("delegateQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpireX = "expire";
		static readonly NativeHandle selExpireXHandle = Selector.GetHandle ("expire");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_X = "invalidateAllPersistableContentKeysForApp:options:completionHandler:";
		static readonly NativeHandle selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_XHandle = Selector.GetHandle ("invalidateAllPersistableContentKeysForApp:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidatePersistableContentKey_Options_CompletionHandler_X = "invalidatePersistableContentKey:options:completionHandler:";
		static readonly NativeHandle selInvalidatePersistableContentKey_Options_CompletionHandler_XHandle = Selector.GetHandle ("invalidatePersistableContentKey:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeySystemX = "keySystem";
		static readonly NativeHandle selKeySystemXHandle = Selector.GetHandle ("keySystem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_X = "makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:";
		static readonly NativeHandle selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_XHandle = Selector.GetHandle ("makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_X = "pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:";
		static readonly NativeHandle selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_XHandle = Selector.GetHandle ("pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessContentKeyRequestWithIdentifier_InitializationData_Options_X = "processContentKeyRequestWithIdentifier:initializationData:options:";
		static readonly NativeHandle selProcessContentKeyRequestWithIdentifier_InitializationData_Options_XHandle = Selector.GetHandle ("processContentKeyRequestWithIdentifier:initializationData:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_X = "removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:";
		static readonly NativeHandle selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_XHandle = Selector.GetHandle ("removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenewExpiringResponseDataForContentKeyRequest_X = "renewExpiringResponseDataForContentKeyRequest:";
		static readonly NativeHandle selRenewExpiringResponseDataForContentKeyRequest_XHandle = Selector.GetHandle ("renewExpiringResponseDataForContentKeyRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_Queue_X = "setDelegate:queue:";
		static readonly NativeHandle selSetDelegate_Queue_XHandle = Selector.GetHandle ("setDelegate:queue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStorageURLX = "storageURL";
		static readonly NativeHandle selStorageURLXHandle = Selector.GetHandle ("storageURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVContentKeySession");
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
		protected AVContentKeySession (NSObjectFlag t) : base (t)
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
		protected internal AVContentKeySession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("contentKeySessionWithKeySystem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVContentKeySession Create (string keySystem)
		{
			if (keySystem is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keySystem));
			var nskeySystem = CFString.CreateNative (keySystem);
			AVContentKeySession? ret;
			ret =  Runtime.GetNSObject<AVContentKeySession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContentKeySessionWithKeySystem_XHandle, nskeySystem), false)!;
			CFString.ReleaseNative (nskeySystem);
			return ret!;
		}
		[Export ("contentKeySessionWithKeySystem:storageDirectoryAtURL:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVContentKeySession Create (NSString keySystem, NSUrl storageUrl)
		{
			var keySystem__handle__ = keySystem!.GetNonNullHandle (nameof (keySystem));
			var storageUrl__handle__ = storageUrl!.GetNonNullHandle (nameof (storageUrl));
			AVContentKeySession? ret;
			ret =  Runtime.GetNSObject<AVContentKeySession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selContentKeySessionWithKeySystem_StorageDirectoryAtURL_XHandle, keySystem__handle__, storageUrl__handle__), false)!;
			GC.KeepAlive (keySystem);
			GC.KeepAlive (storageUrl);
			return ret!;
		}
		/// <param name="keySystem">The key system for the session.</param><param name="storageUrl">The directory at which to store abnormal termination reports</param><summary>Creates a new session for the provided error storage URL and set of decryption keys.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVContentKeySession Create (AVContentKeySystem keySystem, NSUrl storageUrl)
		{
			return Create (keySystem.GetConstant ()!, storageUrl);
		}
		[Export ("expire")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Expire ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selExpireXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selExpireXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary[] GetPendingExpiredSessionReports (NSData appIdentifier, NSUrl storageUrl)
		{
			var appIdentifier__handle__ = appIdentifier!.GetNonNullHandle (nameof (appIdentifier));
			var storageUrl__handle__ = storageUrl!.GetNonNullHandle (nameof (storageUrl));
			NSDictionary[]? ret;
			ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_XHandle, appIdentifier__handle__, storageUrl__handle__), false)!;
			GC.KeepAlive (appIdentifier);
			GC.KeepAlive (storageUrl);
			return ret!;
		}
		[Export ("invalidateAllPersistableContentKeysForApp:options:completionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InvalidateAllPersistableContentKeys (NSData appIdentifier, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> handler)
		{
			var appIdentifier__handle__ = appIdentifier!.GetNonNullHandle (nameof (appIdentifier));
			var options__handle__ = options.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V16.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_XHandle, appIdentifier__handle__, options__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_XHandle, appIdentifier__handle__, options__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (appIdentifier);
			GC.KeepAlive (options);
		}
		/// <param name="appIdentifier">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> InvalidateAllPersistableContentKeysAsync (NSData appIdentifier, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			InvalidateAllPersistableContentKeys(appIdentifier, options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("invalidatePersistableContentKey:options:completionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InvalidatePersistableContentKey (NSData persistableContentKeyData, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> handler)
		{
			var persistableContentKeyData__handle__ = persistableContentKeyData!.GetNonNullHandle (nameof (persistableContentKeyData));
			var options__handle__ = options.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V16.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInvalidatePersistableContentKey_Options_CompletionHandler_XHandle, persistableContentKeyData__handle__, options__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInvalidatePersistableContentKey_Options_CompletionHandler_XHandle, persistableContentKeyData__handle__, options__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (persistableContentKeyData);
			GC.KeepAlive (options);
		}
		/// <param name="persistableContentKeyData">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> InvalidatePersistableContentKeyAsync (NSData persistableContentKeyData, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			InvalidatePersistableContentKey(persistableContentKeyData, options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MakeSecureToken (NSData persistableContentKeyData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> handler)
		{
			var persistableContentKeyData__handle__ = persistableContentKeyData!.GetNonNullHandle (nameof (persistableContentKeyData));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V16.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_XHandle, persistableContentKeyData__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_XHandle, persistableContentKeyData__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (persistableContentKeyData);
		}
		/// <param name="persistableContentKeyData">The existing persistable content key data.</param>
		/// <summary>Asynchronously creates a secure temporary key for the provided persistent key, and returns the result.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous MakeSecureToken operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSData,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The MakeSecureTokenAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> MakeSecureTokenAsync (NSData persistableContentKeyData)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			MakeSecureToken(persistableContentKeyData, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("processContentKeyRequestWithIdentifier:initializationData:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessContentKeyRequest (NSObject? identifier, NSData? initializationData, NSDictionary<NSString, NSObject>? options)
		{
			var identifier__handle__ = identifier.GetHandle ();
			var initializationData__handle__ = initializationData.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selProcessContentKeyRequestWithIdentifier_InitializationData_Options_XHandle, identifier__handle__, initializationData__handle__, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selProcessContentKeyRequestWithIdentifier_InitializationData_Options_XHandle, identifier__handle__, initializationData__handle__, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (identifier);
			GC.KeepAlive (initializationData);
			GC.KeepAlive (options);
		}
		[Export ("removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemovePendingExpiredSessionReports (NSDictionary[] expiredSessionReports, NSData appIdentifier, NSUrl storageUrl)
		{
			if (expiredSessionReports is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (expiredSessionReports));
			var appIdentifier__handle__ = appIdentifier!.GetNonNullHandle (nameof (appIdentifier));
			var storageUrl__handle__ = storageUrl!.GetNonNullHandle (nameof (storageUrl));
			using var nsa_expiredSessionReports = NSArray.FromNSObjects (expiredSessionReports);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_XHandle, nsa_expiredSessionReports.Handle, appIdentifier__handle__, storageUrl__handle__);
			GC.KeepAlive (appIdentifier);
			GC.KeepAlive (storageUrl);
		}
		[Export ("renewExpiringResponseDataForContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenewExpiringResponseData (AVContentKeyRequest contentKeyRequest)
		{
			var contentKeyRequest__handle__ = contentKeyRequest!.GetNonNullHandle (nameof (contentKeyRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRenewExpiringResponseDataForContentKeyRequest_XHandle, contentKeyRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRenewExpiringResponseDataForContentKeyRequest_XHandle, contentKeyRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentKeyRequest);
		}
		[Export ("setDelegate:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDelegate (IAVContentKeySessionDelegate? newDelegate, global::CoreFoundation.DispatchQueue? delegateQueue)
		{
			var newDelegate__handle__ = newDelegate.GetHandle ();
			var delegateQueue__handle__ = delegateQueue.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDelegate_Queue_XHandle, newDelegate__handle__, delegateQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDelegate_Queue_XHandle, newDelegate__handle__, delegateQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newDelegate);
			GC.KeepAlive (delegateQueue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? ContentProtectionSessionIdentifier {
			[Export ("contentProtectionSessionIdentifier")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentProtectionSessionIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentProtectionSessionIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAVContentKeySessionDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IAVContentKeySessionDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVContentKeySessionDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVContentKeySessionDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreFoundation.DispatchQueue? DelegateQueue {
			[Export ("delegateQueue")]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVContentKeySystem KeySystem {
			get {
				return (AVContentKeySystem) (AVContentKeySystemExtensions.GetValue (this.KeySystemConstant));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSString KeySystemConstant {
			[Export ("keySystem")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeySystemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeySystemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? StorageUrl {
			[Export ("storageURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStorageURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStorageURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class AVContentKeySession */
}
