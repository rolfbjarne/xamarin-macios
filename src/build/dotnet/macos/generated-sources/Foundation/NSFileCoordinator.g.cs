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
namespace Foundation {
	[Register("NSFileCoordinator", true)]
	public unsafe partial class NSFileCoordinator : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddFilePresenter_X = "addFilePresenter:";
		static readonly NativeHandle selAddFilePresenter_XHandle = Selector.GetHandle ("addFilePresenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateAccessWithIntents_Queue_ByAccessor_X = "coordinateAccessWithIntents:queue:byAccessor:";
		static readonly NativeHandle selCoordinateAccessWithIntents_Queue_ByAccessor_XHandle = Selector.GetHandle ("coordinateAccessWithIntents:queue:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateReadingItemAtURL_Options_Error_ByAccessor_X = "coordinateReadingItemAtURL:options:error:byAccessor:";
		static readonly NativeHandle selCoordinateReadingItemAtURL_Options_Error_ByAccessor_XHandle = Selector.GetHandle ("coordinateReadingItemAtURL:options:error:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_X = "coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:";
		static readonly NativeHandle selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle = Selector.GetHandle ("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateWritingItemAtURL_Options_Error_ByAccessor_X = "coordinateWritingItemAtURL:options:error:byAccessor:";
		static readonly NativeHandle selCoordinateWritingItemAtURL_Options_Error_ByAccessor_XHandle = Selector.GetHandle ("coordinateWritingItemAtURL:options:error:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_X = "coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:";
		static readonly NativeHandle selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle = Selector.GetHandle ("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilePresentersX = "filePresenters";
		static readonly NativeHandle selFilePresentersXHandle = Selector.GetHandle ("filePresenters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFilePresenter_X = "initWithFilePresenter:";
		static readonly NativeHandle selInitWithFilePresenter_XHandle = Selector.GetHandle ("initWithFilePresenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtURL_DidChangeUbiquityAttributes_X = "itemAtURL:didChangeUbiquityAttributes:";
		static readonly NativeHandle selItemAtURL_DidChangeUbiquityAttributes_XHandle = Selector.GetHandle ("itemAtURL:didChangeUbiquityAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtURL_DidMoveToURL_X = "itemAtURL:didMoveToURL:";
		static readonly NativeHandle selItemAtURL_DidMoveToURL_XHandle = Selector.GetHandle ("itemAtURL:didMoveToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtURL_WillMoveToURL_X = "itemAtURL:willMoveToURL:";
		static readonly NativeHandle selItemAtURL_WillMoveToURL_XHandle = Selector.GetHandle ("itemAtURL:willMoveToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_X = "prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:";
		static readonly NativeHandle selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_XHandle = Selector.GetHandle ("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPurposeIdentifierX = "purposeIdentifier";
		static readonly NativeHandle selPurposeIdentifierXHandle = Selector.GetHandle ("purposeIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFilePresenter_X = "removeFilePresenter:";
		static readonly NativeHandle selRemoveFilePresenter_XHandle = Selector.GetHandle ("removeFilePresenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPurposeIdentifier_X = "setPurposeIdentifier:";
		static readonly NativeHandle selSetPurposeIdentifier_XHandle = Selector.GetHandle ("setPurposeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileCoordinator");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFileCoordinator" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFileCoordinator () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSFileCoordinator (NSObjectFlag t) : base (t)
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
		protected internal NSFileCoordinator (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFilePresenter:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFileCoordinator (INSFilePresenter? filePresenterOrNil)
			: base (NSObjectFlag.Empty)
		{
			var filePresenterOrNil__handle__ = filePresenterOrNil.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithFilePresenter_XHandle, filePresenterOrNil__handle__), "initWithFilePresenter:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithFilePresenter_XHandle, filePresenterOrNil__handle__), "initWithFilePresenter:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (filePresenterOrNil);
		}
		[Export ("addFilePresenter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddFilePresenter (INSFilePresenter filePresenter)
		{
			var filePresenter__handle__ = filePresenter!.GetNonNullHandle (nameof (filePresenter));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selAddFilePresenter_XHandle, filePresenter__handle__);
			GC.KeepAlive (filePresenter);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("coordinateAccessWithIntents:queue:byAccessor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateAccess (NSFileAccessIntent[] intents, NSOperationQueue executionQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> accessor)
		{
			if (intents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (intents));
			var executionQueue__handle__ = executionQueue!.GetNonNullHandle (nameof (executionQueue));
			if (accessor is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accessor));
			using var nsa_intents = NSArray.FromNSObjects (intents);
			using var block_accessor = Trampolines.SDActionArity1V16.CreateBlock (accessor);
			BlockLiteral *block_ptr_accessor = &block_accessor;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCoordinateAccessWithIntents_Queue_ByAccessor_XHandle, nsa_intents.Handle, executionQueue__handle__, (IntPtr) block_ptr_accessor);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCoordinateAccessWithIntents_Queue_ByAccessor_XHandle, nsa_intents.Handle, executionQueue__handle__, (IntPtr) block_ptr_accessor);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (executionQueue);
		}
		[Export ("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateBatch (NSUrl[] readingURLs, NSFileCoordinatorReadingOptions readingOptions, NSUrl[] writingURLs, NSFileCoordinatorWritingOptions writingOptions, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action batchHandler)
		{
			if (readingURLs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readingURLs));
			if (writingURLs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (writingURLs));
			if (batchHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (batchHandler));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_readingURLs = NSArray.FromNSObjects (readingURLs);
			using var nsa_writingURLs = NSArray.FromNSObjects (writingURLs);
			using var block_batchHandler = Trampolines.SDAction.CreateBlock (batchHandler);
			BlockLiteral *block_ptr_batchHandler = &block_batchHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (this.Handle, selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_XHandle, nsa_readingURLs.Handle, (UIntPtr) (ulong) readingOptions, nsa_writingURLs.Handle, (UIntPtr) (ulong) writingOptions, &errorValue, (IntPtr) block_ptr_batchHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (&__objc_super__, selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_XHandle, nsa_readingURLs.Handle, (UIntPtr) (ulong) readingOptions, nsa_writingURLs.Handle, (UIntPtr) (ulong) writingOptions, &errorValue, (IntPtr) block_ptr_batchHandler);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("coordinateReadingItemAtURL:options:error:byAccessor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateRead (NSUrl itemUrl, NSFileCoordinatorReadingOptions options, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V49))]global::System.Action<NSUrl> worker)
		{
			var itemUrl__handle__ = itemUrl!.GetNonNullHandle (nameof (itemUrl));
			if (worker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (worker));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_worker = Trampolines.SDActionArity1V49.CreateBlock (worker);
			BlockLiteral *block_ptr_worker = &block_worker;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (this.Handle, selCoordinateReadingItemAtURL_Options_Error_ByAccessor_XHandle, itemUrl__handle__, (UIntPtr) (ulong) options, &errorValue, (IntPtr) block_ptr_worker);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (&__objc_super__, selCoordinateReadingItemAtURL_Options_Error_ByAccessor_XHandle, itemUrl__handle__, (UIntPtr) (ulong) options, &errorValue, (IntPtr) block_ptr_worker);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateReadWrite (NSUrl readingURL, NSFileCoordinatorReadingOptions readingOptions, NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileCoordinatorWorkerRW))]NSFileCoordinatorWorkerRW readWriteWorker)
		{
			var readingURL__handle__ = readingURL!.GetNonNullHandle (nameof (readingURL));
			var writingURL__handle__ = writingURL!.GetNonNullHandle (nameof (writingURL));
			if (readWriteWorker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readWriteWorker));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_readWriteWorker = Trampolines.SDNSFileCoordinatorWorkerRW.CreateBlock (readWriteWorker);
			BlockLiteral *block_ptr_readWriteWorker = &block_readWriteWorker;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (this.Handle, selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle, readingURL__handle__, (UIntPtr) (ulong) readingOptions, writingURL__handle__, (UIntPtr) (ulong) writingOptions, &errorValue, (IntPtr) block_ptr_readWriteWorker);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (&__objc_super__, selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle, readingURL__handle__, (UIntPtr) (ulong) readingOptions, writingURL__handle__, (UIntPtr) (ulong) writingOptions, &errorValue, (IntPtr) block_ptr_readWriteWorker);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (readingURL);
			GC.KeepAlive (writingURL);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("coordinateWritingItemAtURL:options:error:byAccessor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateWrite (NSUrl url, NSFileCoordinatorWritingOptions options, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V49))]global::System.Action<NSUrl> worker)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (worker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (worker));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_worker = Trampolines.SDActionArity1V49.CreateBlock (worker);
			BlockLiteral *block_ptr_worker = &block_worker;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (this.Handle, selCoordinateWritingItemAtURL_Options_Error_ByAccessor_XHandle, url__handle__, (UIntPtr) (ulong) options, &errorValue, (IntPtr) block_ptr_worker);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (&__objc_super__, selCoordinateWritingItemAtURL_Options_Error_ByAccessor_XHandle, url__handle__, (UIntPtr) (ulong) options, &errorValue, (IntPtr) block_ptr_worker);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CoordinateWriteWrite (NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, NSUrl writingURL2, NSFileCoordinatorWritingOptions writingOptions2, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileCoordinatorWorkerRW))]NSFileCoordinatorWorkerRW writeWriteWorker)
		{
			var writingURL__handle__ = writingURL!.GetNonNullHandle (nameof (writingURL));
			var writingURL2__handle__ = writingURL2!.GetNonNullHandle (nameof (writingURL2));
			if (writeWriteWorker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (writeWriteWorker));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_writeWriteWorker = Trampolines.SDNSFileCoordinatorWorkerRW.CreateBlock (writeWriteWorker);
			BlockLiteral *block_ptr_writeWriteWorker = &block_writeWriteWorker;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (this.Handle, selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle, writingURL__handle__, (UIntPtr) (ulong) writingOptions, writingURL2__handle__, (UIntPtr) (ulong) writingOptions2, &errorValue, (IntPtr) block_ptr_writeWriteWorker);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_UIntPtr_ref_NativeHandle_NativeHandle (&__objc_super__, selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_XHandle, writingURL__handle__, (UIntPtr) (ulong) writingOptions, writingURL2__handle__, (UIntPtr) (ulong) writingOptions2, &errorValue, (IntPtr) block_ptr_writeWriteWorker);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (writingURL);
			GC.KeepAlive (writingURL2);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("itemAtURL:didMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemMoved (NSUrl fromUrl, NSUrl toUrl)
		{
			var fromUrl__handle__ = fromUrl!.GetNonNullHandle (nameof (fromUrl));
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selItemAtURL_DidMoveToURL_XHandle, fromUrl__handle__, toUrl__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selItemAtURL_DidMoveToURL_XHandle, fromUrl__handle__, toUrl__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromUrl);
			GC.KeepAlive (toUrl);
		}
		[Export ("itemAtURL:didChangeUbiquityAttributes:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemUbiquityAttributesChanged (NSUrl url, NSSet<NSString> attributes)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selItemAtURL_DidChangeUbiquityAttributes_XHandle, url__handle__, attributes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selItemAtURL_DidChangeUbiquityAttributes_XHandle, url__handle__, attributes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (attributes);
		}
		[Export ("removeFilePresenter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveFilePresenter (INSFilePresenter filePresenter)
		{
			var filePresenter__handle__ = filePresenter!.GetNonNullHandle (nameof (filePresenter));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRemoveFilePresenter_XHandle, filePresenter__handle__);
			GC.KeepAlive (filePresenter);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("itemAtURL:willMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMove (NSUrl oldUrl, NSUrl newUrl)
		{
			var oldUrl__handle__ = oldUrl!.GetNonNullHandle (nameof (oldUrl));
			var newUrl__handle__ = newUrl!.GetNonNullHandle (nameof (newUrl));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selItemAtURL_WillMoveToURL_XHandle, oldUrl__handle__, newUrl__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selItemAtURL_WillMoveToURL_XHandle, oldUrl__handle__, newUrl__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldUrl);
			GC.KeepAlive (newUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSFilePresenter[] FilePresenters {
			[Export ("filePresenters", ArgumentSemantic.Copy)]
			get {
				INSFilePresenter[]? ret;
				ret = CFArray.ArrayFromHandle<INSFilePresenter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFilePresentersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PurposeIdentifier {
			[Export ("purposeIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPurposeIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPurposeIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPurposeIdentifier:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPurposeIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPurposeIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class NSFileCoordinator */
}
