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
namespace BackgroundAssets {
	[Register("BAAssetPackManager", true)]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	public unsafe partial class BAAssetPackManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForPath_Error_X = "URLForPath:error:";
		static readonly NativeHandle selURLForPath_Error_XHandle = Selector.GetHandle ("URLForPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetPackIsAvailableLocallyWithIdentifier_X = "assetPackIsAvailableLocallyWithIdentifier:";
		static readonly NativeHandle selAssetPackIsAvailableLocallyWithIdentifier_XHandle = Selector.GetHandle ("assetPackIsAvailableLocallyWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckForUpdatesWithCompletionHandler_X = "checkForUpdatesWithCompletionHandler:";
		static readonly NativeHandle selCheckForUpdatesWithCompletionHandler_XHandle = Selector.GetHandle ("checkForUpdatesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsAtPath_SearchingInAssetPackWithIdentifier_Options_Error_X = "contentsAtPath:searchingInAssetPackWithIdentifier:options:error:";
		static readonly NativeHandle selContentsAtPath_SearchingInAssetPackWithIdentifier_Options_Error_XHandle = Selector.GetHandle ("contentsAtPath:searchingInAssetPackWithIdentifier:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLocalAvailabilityOfAssetPack_CompletionHandler_X = "ensureLocalAvailabilityOfAssetPack:completionHandler:";
		static readonly NativeHandle selEnsureLocalAvailabilityOfAssetPack_CompletionHandler_XHandle = Selector.GetHandle ("ensureLocalAvailabilityOfAssetPack:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLocalAvailabilityOfAssetPack_RequireLatestVersion_CompletionHandler_X = "ensureLocalAvailabilityOfAssetPack:requireLatestVersion:completionHandler:";
		static readonly NativeHandle selEnsureLocalAvailabilityOfAssetPack_RequireLatestVersion_CompletionHandler_XHandle = Selector.GetHandle ("ensureLocalAvailabilityOfAssetPack:requireLatestVersion:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileDescriptorForPath_SearchingInAssetPackWithIdentifier_Error_X = "fileDescriptorForPath:searchingInAssetPackWithIdentifier:error:";
		static readonly NativeHandle selFileDescriptorForPath_SearchingInAssetPackWithIdentifier_Error_XHandle = Selector.GetHandle ("fileDescriptorForPath:searchingInAssetPackWithIdentifier:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAllAssetPacksWithCompletionHandler_X = "getAllAssetPacksWithCompletionHandler:";
		static readonly NativeHandle selGetAllAssetPacksWithCompletionHandler_XHandle = Selector.GetHandle ("getAllAssetPacksWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAssetPackWithIdentifier_CompletionHandler_X = "getAssetPackWithIdentifier:completionHandler:";
		static readonly NativeHandle selGetAssetPackWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("getAssetPackWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLocalStatusOfAssetPackWithIdentifier_CompletionHandler_X = "getLocalStatusOfAssetPackWithIdentifier:completionHandler:";
		static readonly NativeHandle selGetLocalStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("getLocalStatusOfAssetPackWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetStatusOfAssetPackWithIdentifier_CompletionHandler_X = "getStatusOfAssetPackWithIdentifier:completionHandler:";
		static readonly NativeHandle selGetStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("getStatusOfAssetPackWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetStatusRelativeToAssetPack_CompletionHandler_X = "getStatusRelativeToAssetPack:completionHandler:";
		static readonly NativeHandle selGetStatusRelativeToAssetPack_CompletionHandler_XHandle = Selector.GetHandle ("getStatusRelativeToAssetPack:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAssetPackWithIdentifier_CompletionHandler_X = "removeAssetPackWithIdentifier:completionHandler:";
		static readonly NativeHandle selRemoveAssetPackWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("removeAssetPackWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedManagerX = "sharedManager";
		static readonly NativeHandle selSharedManagerXHandle = Selector.GetHandle ("sharedManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("BAAssetPackManager");
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
		protected BAAssetPackManager (NSObjectFlag t) : base (t)
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
		protected internal BAAssetPackManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("checkForUpdatesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CheckForUpdates ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerCheckForUpdatesCompletionHandler))]BAAssetPackManagerCheckForUpdatesCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerCheckForUpdatesCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckForUpdatesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckForUpdatesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<BAAssetPackManagerCheckForUpdatesResult> CheckForUpdatesAsync ()
		{
			var tcs = new TaskCompletionSource<BAAssetPackManagerCheckForUpdatesResult> ();
			CheckForUpdates((updatingIdentifiers_, removedIdentifiers_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new BAAssetPackManagerCheckForUpdatesResult (updatingIdentifiers_!, removedIdentifiers_!));
			});
			return tcs.Task;
		}
		[Export ("ensureLocalAvailabilityOfAssetPack:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnsureLocalAvailability (BAAssetPack assetPack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerEnsureLocalAvailabilityCompletionHandler))]BAAssetPackManagerEnsureLocalAvailabilityCompletionHandler completionHandler)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerEnsureLocalAvailabilityCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEnsureLocalAvailabilityOfAssetPack_CompletionHandler_XHandle, assetPack__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEnsureLocalAvailabilityOfAssetPack_CompletionHandler_XHandle, assetPack__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (assetPack);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EnsureLocalAvailabilityAsync (BAAssetPack assetPack)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EnsureLocalAvailability(assetPack, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <summary>Ensures that an asset pack is available locally, optionally requiring the latest version.</summary><param name="assetPack">The <see cref="T:BackgroundAssets.BAAssetPack" /> to make available.</param><param name="requireLatestVersion">If <see langword="true" />, checks for updates before making the asset pack available.</param><param name="completionHandler">A completion handler called with an optional error when the operation completes.</param>
		[Export ("ensureLocalAvailabilityOfAssetPack:requireLatestVersion:completionHandler:")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnsureLocalAvailability (BAAssetPack assetPack, bool requireLatestVersion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerEnsureLocalAvailabilityCompletionHandler))]BAAssetPackManagerEnsureLocalAvailabilityCompletionHandler completionHandler)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerEnsureLocalAvailabilityCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selEnsureLocalAvailabilityOfAssetPack_RequireLatestVersion_CompletionHandler_XHandle, assetPack__handle__, requireLatestVersion ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selEnsureLocalAvailabilityOfAssetPack_RequireLatestVersion_CompletionHandler_XHandle, assetPack__handle__, requireLatestVersion ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (assetPack);
		}
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EnsureLocalAvailabilityAsync (BAAssetPack assetPack, bool requireLatestVersion)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EnsureLocalAvailability(assetPack, requireLatestVersion, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("getAllAssetPacksWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetAllAssetPacks ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerGetAllAssetPacksCompletionHandler))]BAAssetPackManagerGetAllAssetPacksCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerGetAllAssetPacksCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGetAllAssetPacksWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetAllAssetPacksWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSSet<BAAssetPack>> GetAllAssetPacksAsync ()
		{
			var tcs = new TaskCompletionSource<NSSet<BAAssetPack>> ();
			GetAllAssetPacks((assetPacks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (assetPacks_!);
			});
			return tcs.Task;
		}
		[Export ("getAssetPackWithIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetAssetPack (string assetPackIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerGetAssetPackCompletionHandler))]BAAssetPackManagerGetAssetPackCompletionHandler completionHandler)
		{
			if (assetPackIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetPackIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerGetAssetPackCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsassetPackIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<BAAssetPack> GetAssetPackAsync (string assetPackIdentifier)
		{
			var tcs = new TaskCompletionSource<BAAssetPack> ();
			GetAssetPack(assetPackIdentifier, (assetPack_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (assetPack_!);
			});
			return tcs.Task;
		}
		[Export ("contentsAtPath:searchingInAssetPackWithIdentifier:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetContents (string path, string? assetPackIdentifier, NSDataReadingOptions options, out NSError? error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selContentsAtPath_SearchingInAssetPackWithIdentifier_Options_Error_XHandle, nspath, nsassetPackIdentifier, (UIntPtr) (ulong) options, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selContentsAtPath_SearchingInAssetPackWithIdentifier_Options_Error_XHandle, nspath, nsassetPackIdentifier, (UIntPtr) (ulong) options, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			CFString.ReleaseNative (nsassetPackIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("fileDescriptorForPath:searchingInAssetPackWithIdentifier:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual int GetFileDescriptor (string path, string? assetPackIdentifier, out NSError? error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			int ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.int_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selFileDescriptorForPath_SearchingInAssetPackWithIdentifier_Error_XHandle, nspath, nsassetPackIdentifier, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selFileDescriptorForPath_SearchingInAssetPackWithIdentifier_Error_XHandle, nspath, nsassetPackIdentifier, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			CFString.ReleaseNative (nsassetPackIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Gets the local status of an asset pack.</summary><param name="assetPackIdentifier">The identifier of the asset pack to query.</param><param name="completionHandler">A completion handler called with the <see cref="T:BackgroundAssets.BAAssetPackStatus" /> of the asset pack on the local device.</param>
		[Export ("getLocalStatusOfAssetPackWithIdentifier:completionHandler:")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLocalStatus (string assetPackIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerGetLocalStatusCompletionHandler))]BAAssetPackManagerGetLocalStatusCompletionHandler completionHandler)
		{
			if (assetPackIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetPackIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerGetLocalStatusCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetLocalStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetLocalStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsassetPackIdentifier);
		}
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<BAAssetPackStatus> GetLocalStatusAsync (string assetPackIdentifier)
		{
			var tcs = new TaskCompletionSource<BAAssetPackStatus> ();
			GetLocalStatus(assetPackIdentifier, (status_) => {
				tcs.SetResult (status_!);
			});
			return tcs.Task;
		}
		/// <summary>Gets the status of an asset pack relative to the server.</summary><param name="assetPack">The <see cref="T:BackgroundAssets.BAAssetPack" /> to query.</param><param name="completionHandler">A completion handler called with the <see cref="T:BackgroundAssets.BAAssetPackStatus" /> and an optional error.</param>
		[Export ("getStatusRelativeToAssetPack:completionHandler:")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetRelativeStatus (BAAssetPack assetPack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerGetStatusCompletionHandler))]BAAssetPackManagerGetStatusCompletionHandler completionHandler)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerGetStatusCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetStatusRelativeToAssetPack_CompletionHandler_XHandle, assetPack__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetStatusRelativeToAssetPack_CompletionHandler_XHandle, assetPack__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (assetPack);
		}
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<BAAssetPackStatus> GetRelativeStatusAsync (BAAssetPack assetPack)
		{
			var tcs = new TaskCompletionSource<BAAssetPackStatus> ();
			GetRelativeStatus(assetPack, (status_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (status_!);
			});
			return tcs.Task;
		}
		[Export ("getStatusOfAssetPackWithIdentifier:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("macos26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("tvos26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetStatus (string assetPackIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerGetStatusCompletionHandler))]BAAssetPackManagerGetStatusCompletionHandler completionHandler)
		{
			if (assetPackIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetPackIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerGetStatusCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetStatusOfAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsassetPackIdentifier);
		}
		[ObsoletedOSPlatform ("ios26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("macos26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("tvos26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.4", "Use 'GetRelativeStatus' or 'GetLocalStatus' instead.")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<BAAssetPackStatus> GetStatusAsync (string assetPackIdentifier)
		{
			var tcs = new TaskCompletionSource<BAAssetPackStatus> ();
			GetStatus(assetPackIdentifier, (status_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (status_!);
			});
			return tcs.Task;
		}
		[Export ("URLForPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl? GetUrl (string path, out NSError? error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selURLForPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selURLForPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Synchronously checks whether an asset pack is available on the local device.</summary><param name="assetPackIdentifier">The identifier of the asset pack to check.</param><returns><see langword="true" /> if the asset pack is available locally; otherwise, <see langword="false" />.</returns>
		[Export ("assetPackIsAvailableLocallyWithIdentifier:")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAssetPackAvailableLocally (string assetPackIdentifier)
		{
			if (assetPackIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetPackIdentifier));
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAssetPackIsAvailableLocallyWithIdentifier_XHandle, nsassetPackIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAssetPackIsAvailableLocallyWithIdentifier_XHandle, nsassetPackIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsassetPackIdentifier);
			return ret != 0;
		}
		[Export ("removeAssetPackWithIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveAssetPack (string assetPackIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBAAssetPackManagerRemoveAssetPackCompletionHandler))]BAAssetPackManagerRemoveAssetPackCompletionHandler? completionHandler)
		{
			if (assetPackIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetPackIdentifier));
			var nsassetPackIdentifier = CFString.CreateNative (assetPackIdentifier);
			using var block_completionHandler = Trampolines.SDBAAssetPackManagerRemoveAssetPackCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveAssetPackWithIdentifier_CompletionHandler_XHandle, nsassetPackIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsassetPackIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RemoveAssetPackAsync (string assetPackIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveAssetPack(assetPackIdentifier, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IBAManagedAssetPackDownloadDelegate? Delegate {
			get {
				return (WeakDelegate as IBAManagedAssetPackDownloadDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static BAAssetPackManager SharedManager {
			[Export ("sharedManager", ArgumentSemantic.Retain)]
			get {
				BAAssetPackManager? ret;
				ret =  Runtime.GetNSObject<BAAssetPackManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedManagerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class BAAssetPackManager */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class BAAssetPackManagerCheckForUpdatesResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSSet<NSString> UpdatingIdentifiers { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSSet<NSString> RemovedIdentifiers { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="updatingIdentifiers">Result value from an asynchronous operation.</param>
		/// <param name="removedIdentifiers">Result value from an asynchronous operation.</param>
		public BAAssetPackManagerCheckForUpdatesResult (NSSet<NSString> updatingIdentifiers, NSSet<NSString> removedIdentifiers) {
			this.UpdatingIdentifiers = updatingIdentifiers;
			this.RemovedIdentifiers = removedIdentifiers;
			Initialize ();
		}
	}
}
