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
namespace Photos {
	/// <summary>The entire set of data managed by the Photos app. This includes both locally stored assets and, if user-enabled, assets stored in iCloud.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHPhotoLibrary_Class/index.html">Apple documentation for <c>PHPhotoLibrary</c></related>
	[Register("PHPhotoLibrary", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHPhotoLibrary : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusX = "authorizationStatus";
		static readonly NativeHandle selAuthorizationStatusXHandle = Selector.GetHandle ("authorizationStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusForAccessLevel_X = "authorizationStatusForAccessLevel:";
		static readonly NativeHandle selAuthorizationStatusForAccessLevel_XHandle = Selector.GetHandle ("authorizationStatusForAccessLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentChangeTokenX = "currentChangeToken";
		static readonly NativeHandle selCurrentChangeTokenXHandle = Selector.GetHandle ("currentChangeToken");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchPersistentChangesSinceToken_Error_X = "fetchPersistentChangesSinceToken:error:";
		static readonly NativeHandle selFetchPersistentChangesSinceToken_Error_XHandle = Selector.GetHandle ("fetchPersistentChangesSinceToken:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformChanges_CompletionHandler_X = "performChanges:completionHandler:";
		static readonly NativeHandle selPerformChanges_CompletionHandler_XHandle = Selector.GetHandle ("performChanges:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformChangesAndWait_Error_X = "performChangesAndWait:error:";
		static readonly NativeHandle selPerformChangesAndWait_Error_XHandle = Selector.GetHandle ("performChangesAndWait:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterAvailabilityObserver_X = "registerAvailabilityObserver:";
		static readonly NativeHandle selRegisterAvailabilityObserver_XHandle = Selector.GetHandle ("registerAvailabilityObserver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterChangeObserver_X = "registerChangeObserver:";
		static readonly NativeHandle selRegisterChangeObserver_XHandle = Selector.GetHandle ("registerChangeObserver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAuthorization_X = "requestAuthorization:";
		static readonly NativeHandle selRequestAuthorization_XHandle = Selector.GetHandle ("requestAuthorization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAuthorizationForAccessLevel_Handler_X = "requestAuthorizationForAccessLevel:handler:";
		static readonly NativeHandle selRequestAuthorizationForAccessLevel_Handler_XHandle = Selector.GetHandle ("requestAuthorizationForAccessLevel:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedPhotoLibraryX = "sharedPhotoLibrary";
		static readonly NativeHandle selSharedPhotoLibraryXHandle = Selector.GetHandle ("sharedPhotoLibrary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnavailabilityReasonX = "unavailabilityReason";
		static readonly NativeHandle selUnavailabilityReasonXHandle = Selector.GetHandle ("unavailabilityReason");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnregisterAvailabilityObserver_X = "unregisterAvailabilityObserver:";
		static readonly NativeHandle selUnregisterAvailabilityObserver_XHandle = Selector.GetHandle ("unregisterAvailabilityObserver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnregisterChangeObserver_X = "unregisterChangeObserver:";
		static readonly NativeHandle selUnregisterChangeObserver_XHandle = Selector.GetHandle ("unregisterChangeObserver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHPhotoLibrary");
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
		protected PHPhotoLibrary (NSObjectFlag t) : base (t)
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
		protected internal PHPhotoLibrary (NativeHandle handle) : base (handle)
		{
		}

		[Export ("fetchPersistentChangesSinceToken:error:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual PHPersistentChangeFetchResult? FetchPersistentChanges (PHPersistentChangeToken since, out NSError? error)
		{
			var since__handle__ = since!.GetNonNullHandle (nameof (since));
			NativeHandle errorValue = IntPtr.Zero;
			PHPersistentChangeFetchResult? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PHPersistentChangeFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selFetchPersistentChangesSinceToken_Error_XHandle, since__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PHPersistentChangeFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selFetchPersistentChangesSinceToken_Error_XHandle, since__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (since);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("authorizationStatusForAccessLevel:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAuthorizationStatus GetAuthorizationStatus (PHAccessLevel accessLevel)
		{
			PHAuthorizationStatus ret;
			ret = (PHAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selAuthorizationStatusForAccessLevel_XHandle, (IntPtr) (long) accessLevel);
			return ret!;
		}
		[Export ("performChanges:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action changeHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V13))]global::System.Action<bool, NSError>? completionHandler)
		{
			if (changeHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (changeHandler));
			using var block_changeHandler = Trampolines.SDAction.CreateBlock (changeHandler);
			BlockLiteral *block_ptr_changeHandler = &block_changeHandler;
			using var block_completionHandler = Trampolines.SDActionArity2V13.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPerformChanges_CompletionHandler_XHandle, (IntPtr) block_ptr_changeHandler, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPerformChanges_CompletionHandler_XHandle, (IntPtr) block_ptr_changeHandler, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performChangesAndWait:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PerformChangesAndWait ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action changeHandler, out NSError error)
		{
			if (changeHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (changeHandler));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_changeHandler = Trampolines.SDAction.CreateBlock (changeHandler);
			BlockLiteral *block_ptr_changeHandler = &block_changeHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selPerformChangesAndWait_Error_XHandle, (IntPtr) block_ptr_changeHandler, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selPerformChangesAndWait_Error_XHandle, (IntPtr) block_ptr_changeHandler, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("registerAvailabilityObserver:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Register (IPHPhotoLibraryAvailabilityObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterAvailabilityObserver_XHandle, observer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterAvailabilityObserver_XHandle, observer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
		}
		[Export ("registerChangeObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterChangeObserver (IPHPhotoLibraryChangeObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterChangeObserver_XHandle, observer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterChangeObserver_XHandle, observer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
		}
		[Export ("requestAuthorization:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAuthorization ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V103))]global::System.Action<PHAuthorizationStatus> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V103.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRequestAuthorization_XHandle, (IntPtr) block_ptr_handler);
		}
		/// <summary>Asynchronously shows, if necessary, a permissions dialog allowing the user to allow or deny the application access to the photo library.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestAuthorization operation.  The value of the TResult parameter is of type System.Action&lt;Photos.PHAuthorizationStatus&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The RequestAuthorizationAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'RequestAuthorization(PHAccessLevel, Action<PHAuthorizationStatus>)' overload instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<PHAuthorizationStatus> RequestAuthorizationAsync ()
		{
			var tcs = new TaskCompletionSource<PHAuthorizationStatus> ();
			RequestAuthorization((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("requestAuthorizationForAccessLevel:handler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAuthorization (PHAccessLevel accessLevel, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V103))]global::System.Action<PHAuthorizationStatus> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V103.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (class_ptr, selRequestAuthorizationForAccessLevel_Handler_XHandle, (IntPtr) (long) accessLevel, (IntPtr) block_ptr_handler);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<PHAuthorizationStatus> RequestAuthorizationAsync (PHAccessLevel accessLevel)
		{
			var tcs = new TaskCompletionSource<PHAuthorizationStatus> ();
			RequestAuthorization(accessLevel, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("unregisterAvailabilityObserver:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unregister (IPHPhotoLibraryAvailabilityObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnregisterAvailabilityObserver_XHandle, observer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnregisterAvailabilityObserver_XHandle, observer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
		}
		[Export ("unregisterChangeObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterChangeObserver (IPHPhotoLibraryChangeObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnregisterChangeObserver_XHandle, observer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnregisterChangeObserver_XHandle, observer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GetAuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'GetAuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GetAuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'GetAuthorizationStatus' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHAuthorizationStatus AuthorizationStatus {
			[Export ("authorizationStatus")]
			get {
				PHAuthorizationStatus ret;
				ret = (PHAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selAuthorizationStatusXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual PHPersistentChangeToken CurrentChangeToken {
			[Export ("currentChangeToken")]
			get {
				PHPersistentChangeToken? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHPersistentChangeToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentChangeTokenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHPersistentChangeToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentChangeTokenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPhotoLibrary SharedPhotoLibrary {
			[Export ("sharedPhotoLibrary")]
			get {
				PHPhotoLibrary? ret;
				ret =  Runtime.GetNSObject<PHPhotoLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedPhotoLibraryXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSError? UnavailabilityReason {
			[Export ("unavailabilityReason", ArgumentSemantic.Retain)]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUnavailabilityReasonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUnavailabilityReasonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalIdentifiersErrorKey;
		/// <summary>Represents the value associated with the constant 'PHLocalIdentifiersErrorKey'.</summary>
		[Field ("PHLocalIdentifiersErrorKey",  "Photos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LocalIdentifiersErrorKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LocalIdentifiersErrorKey is null)
					_LocalIdentifiersErrorKey = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLocalIdentifiersErrorKey")!;
				return _LocalIdentifiersErrorKey;
			}
		}
	} /* class PHPhotoLibrary */
}
