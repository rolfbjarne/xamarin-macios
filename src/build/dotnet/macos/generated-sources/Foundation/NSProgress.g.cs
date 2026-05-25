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
	[Register("NSProgress", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSProgress : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcknowledgeWithSuccess_X = "acknowledgeWithSuccess:";
		static readonly NativeHandle selAcknowledgeWithSuccess_XHandle = Selector.GetHandle ("acknowledgeWithSuccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChild_WithPendingUnitCount_X = "addChild:withPendingUnitCount:";
		static readonly NativeHandle selAddChild_WithPendingUnitCount_XHandle = Selector.GetHandle ("addChild:withPendingUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSubscriberForFileURL_WithPublishingHandler_X = "addSubscriberForFileURL:withPublishingHandler:";
		static readonly NativeHandle selAddSubscriberForFileURL_WithPublishingHandler_XHandle = Selector.GetHandle ("addSubscriberForFileURL:withPublishingHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBecomeCurrentWithPendingUnitCount_X = "becomeCurrentWithPendingUnitCount:";
		static readonly NativeHandle selBecomeCurrentWithPendingUnitCount_XHandle = Selector.GetHandle ("becomeCurrentWithPendingUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletedUnitCountX = "completedUnitCount";
		static readonly NativeHandle selCompletedUnitCountXHandle = Selector.GetHandle ("completedUnitCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentProgressX = "currentProgress";
		static readonly NativeHandle selCurrentProgressXHandle = Selector.GetHandle ("currentProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscreteProgressWithTotalUnitCount_X = "discreteProgressWithTotalUnitCount:";
		static readonly NativeHandle selDiscreteProgressWithTotalUnitCount_XHandle = Selector.GetHandle ("discreteProgressWithTotalUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimatedTimeRemainingX = "estimatedTimeRemaining";
		static readonly NativeHandle selEstimatedTimeRemainingXHandle = Selector.GetHandle ("estimatedTimeRemaining");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileCompletedCountX = "fileCompletedCount";
		static readonly NativeHandle selFileCompletedCountXHandle = Selector.GetHandle ("fileCompletedCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileOperationKindX = "fileOperationKind";
		static readonly NativeHandle selFileOperationKindXHandle = Selector.GetHandle ("fileOperationKind");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileTotalCountX = "fileTotalCount";
		static readonly NativeHandle selFileTotalCountXHandle = Selector.GetHandle ("fileTotalCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLX = "fileURL";
		static readonly NativeHandle selFileURLXHandle = Selector.GetHandle ("fileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFractionCompletedX = "fractionCompleted";
		static readonly NativeHandle selFractionCompletedXHandle = Selector.GetHandle ("fractionCompleted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithParent_UserInfo_X = "initWithParent:userInfo:";
		static readonly NativeHandle selInitWithParent_UserInfo_XHandle = Selector.GetHandle ("initWithParent:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCancellableX = "isCancellable";
		static readonly NativeHandle selIsCancellableXHandle = Selector.GetHandle ("isCancellable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCancelledX = "isCancelled";
		static readonly NativeHandle selIsCancelledXHandle = Selector.GetHandle ("isCancelled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFinishedX = "isFinished";
		static readonly NativeHandle selIsFinishedXHandle = Selector.GetHandle ("isFinished");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsIndeterminateX = "isIndeterminate";
		static readonly NativeHandle selIsIndeterminateXHandle = Selector.GetHandle ("isIndeterminate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOldX = "isOld";
		static readonly NativeHandle selIsOldXHandle = Selector.GetHandle ("isOld");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPausableX = "isPausable";
		static readonly NativeHandle selIsPausableXHandle = Selector.GetHandle ("isPausable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPausedX = "isPaused";
		static readonly NativeHandle selIsPausedXHandle = Selector.GetHandle ("isPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKindX = "kind";
		static readonly NativeHandle selKindXHandle = Selector.GetHandle ("kind");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedAdditionalDescriptionX = "localizedAdditionalDescription";
		static readonly NativeHandle selLocalizedAdditionalDescriptionXHandle = Selector.GetHandle ("localizedAdditionalDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionX = "localizedDescription";
		static readonly NativeHandle selLocalizedDescriptionXHandle = Selector.GetHandle ("localizedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformAsCurrentWithPendingUnitCount_UsingBlock_X = "performAsCurrentWithPendingUnitCount:usingBlock:";
		static readonly NativeHandle selPerformAsCurrentWithPendingUnitCount_UsingBlock_XHandle = Selector.GetHandle ("performAsCurrentWithPendingUnitCount:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProgressWithTotalUnitCount_X = "progressWithTotalUnitCount:";
		static readonly NativeHandle selProgressWithTotalUnitCount_XHandle = Selector.GetHandle ("progressWithTotalUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProgressWithTotalUnitCount_Parent_PendingUnitCount_X = "progressWithTotalUnitCount:parent:pendingUnitCount:";
		static readonly NativeHandle selProgressWithTotalUnitCount_Parent_PendingUnitCount_XHandle = Selector.GetHandle ("progressWithTotalUnitCount:parent:pendingUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPublishX = "publish";
		static readonly NativeHandle selPublishXHandle = Selector.GetHandle ("publish");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveSubscriber_X = "removeSubscriber:";
		static readonly NativeHandle selRemoveSubscriber_XHandle = Selector.GetHandle ("removeSubscriber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResignCurrentX = "resignCurrent";
		static readonly NativeHandle selResignCurrentXHandle = Selector.GetHandle ("resignCurrent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeX = "resume";
		static readonly NativeHandle selResumeXHandle = Selector.GetHandle ("resume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAcknowledgementHandler_ForAppBundleIdentifier_X = "setAcknowledgementHandler:forAppBundleIdentifier:";
		static readonly NativeHandle selSetAcknowledgementHandler_ForAppBundleIdentifier_XHandle = Selector.GetHandle ("setAcknowledgementHandler:forAppBundleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCancellable_X = "setCancellable:";
		static readonly NativeHandle selSetCancellable_XHandle = Selector.GetHandle ("setCancellable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCancellationHandler_X = "setCancellationHandler:";
		static readonly NativeHandle selSetCancellationHandler_XHandle = Selector.GetHandle ("setCancellationHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompletedUnitCount_X = "setCompletedUnitCount:";
		static readonly NativeHandle selSetCompletedUnitCount_XHandle = Selector.GetHandle ("setCompletedUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEstimatedTimeRemaining_X = "setEstimatedTimeRemaining:";
		static readonly NativeHandle selSetEstimatedTimeRemaining_XHandle = Selector.GetHandle ("setEstimatedTimeRemaining:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileCompletedCount_X = "setFileCompletedCount:";
		static readonly NativeHandle selSetFileCompletedCount_XHandle = Selector.GetHandle ("setFileCompletedCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileOperationKind_X = "setFileOperationKind:";
		static readonly NativeHandle selSetFileOperationKind_XHandle = Selector.GetHandle ("setFileOperationKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileTotalCount_X = "setFileTotalCount:";
		static readonly NativeHandle selSetFileTotalCount_XHandle = Selector.GetHandle ("setFileTotalCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileURL_X = "setFileURL:";
		static readonly NativeHandle selSetFileURL_XHandle = Selector.GetHandle ("setFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKind_X = "setKind:";
		static readonly NativeHandle selSetKind_XHandle = Selector.GetHandle ("setKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalizedAdditionalDescription_X = "setLocalizedAdditionalDescription:";
		static readonly NativeHandle selSetLocalizedAdditionalDescription_XHandle = Selector.GetHandle ("setLocalizedAdditionalDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalizedDescription_X = "setLocalizedDescription:";
		static readonly NativeHandle selSetLocalizedDescription_XHandle = Selector.GetHandle ("setLocalizedDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPausable_X = "setPausable:";
		static readonly NativeHandle selSetPausable_XHandle = Selector.GetHandle ("setPausable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPausingHandler_X = "setPausingHandler:";
		static readonly NativeHandle selSetPausingHandler_XHandle = Selector.GetHandle ("setPausingHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResumingHandler_X = "setResumingHandler:";
		static readonly NativeHandle selSetResumingHandler_XHandle = Selector.GetHandle ("setResumingHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetThroughput_X = "setThroughput:";
		static readonly NativeHandle selSetThroughput_XHandle = Selector.GetHandle ("setThroughput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTotalUnitCount_X = "setTotalUnitCount:";
		static readonly NativeHandle selSetTotalUnitCount_XHandle = Selector.GetHandle ("setTotalUnitCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInfoObject_ForKey_X = "setUserInfoObject:forKey:";
		static readonly NativeHandle selSetUserInfoObject_ForKey_XHandle = Selector.GetHandle ("setUserInfoObject:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThroughputX = "throughput";
		static readonly NativeHandle selThroughputXHandle = Selector.GetHandle ("throughput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalUnitCountX = "totalUnitCount";
		static readonly NativeHandle selTotalUnitCountXHandle = Selector.GetHandle ("totalUnitCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnpublishX = "unpublish";
		static readonly NativeHandle selUnpublishXHandle = Selector.GetHandle ("unpublish");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInfoX = "userInfo";
		static readonly NativeHandle selUserInfoXHandle = Selector.GetHandle ("userInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSProgress");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSProgress" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSProgress () : base (NSObjectFlag.Empty)
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
		protected NSProgress (NSObjectFlag t) : base (t)
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
		protected internal NSProgress (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithParent:userInfo:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSProgress (NSProgress? parentProgress, NSDictionary? userInfo)
			: base (NSObjectFlag.Empty)
		{
			var parentProgress__handle__ = parentProgress.GetHandle ();
			var userInfo__handle__ = userInfo.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithParent_UserInfo_XHandle, parentProgress__handle__, userInfo__handle__), "initWithParent:userInfo:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithParent_UserInfo_XHandle, parentProgress__handle__, userInfo__handle__), "initWithParent:userInfo:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parentProgress);
			GC.KeepAlive (userInfo);
		}
		/// <param name="success">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("acknowledgeWithSuccess:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AcknowledgeWithSuccess (bool success)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selAcknowledgeWithSuccess_XHandle, success ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selAcknowledgeWithSuccess_XHandle, success ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addChild:withPendingUnitCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChild (NSProgress child, long pendingUnitCount)
		{
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64 (this.Handle, selAddChild_WithPendingUnitCount_XHandle, child__handle__, pendingUnitCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Int64 (&__objc_super__, selAddChild_WithPendingUnitCount_XHandle, child__handle__, pendingUnitCount);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
		}
		[Export ("addSubscriberForFileURL:withPublishingHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSObject AddSubscriberForFile (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V53))]global::System.Action<NSProgress> publishingHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (publishingHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (publishingHandler));
			using var block_publishingHandler = Trampolines.SDActionArity1V53.CreateBlock (publishingHandler);
			BlockLiteral *block_ptr_publishingHandler = &block_publishingHandler;
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAddSubscriberForFileURL_WithPublishingHandler_XHandle, url__handle__, (IntPtr) block_ptr_publishingHandler), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("becomeCurrentWithPendingUnitCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BecomeCurrent (long pendingUnitCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selBecomeCurrentWithPendingUnitCount_XHandle, pendingUnitCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selBecomeCurrentWithPendingUnitCount_XHandle, pendingUnitCount);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("progressWithTotalUnitCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSProgress FromTotalUnitCount (long unitCount)
		{
			NSProgress ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (class_ptr, selProgressWithTotalUnitCount_XHandle, unitCount), false)!;
			return ret;
		}
		[Export ("progressWithTotalUnitCount:parent:pendingUnitCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSProgress FromTotalUnitCount (long unitCount, NSProgress parent, long portionOfParentTotalUnitCount)
		{
			var parent__handle__ = parent!.GetNonNullHandle (nameof (parent));
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_NativeHandle_Int64 (class_ptr, selProgressWithTotalUnitCount_Parent_PendingUnitCount_XHandle, unitCount, parent__handle__, portionOfParentTotalUnitCount), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("discreteProgressWithTotalUnitCount:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSProgress GetDiscreteProgress (long unitCount)
		{
			NSProgress ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (class_ptr, selDiscreteProgressWithTotalUnitCount_XHandle, unitCount), false)!;
			return ret;
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performAsCurrentWithPendingUnitCount:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformAsCurrent (long unitCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action work)
		{
			if (work is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (work));
			using var block_work = Trampolines.SDAction.CreateBlock (work);
			BlockLiteral *block_ptr_work = &block_work;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (this.Handle, selPerformAsCurrentWithPendingUnitCount_UsingBlock_XHandle, unitCount, (IntPtr) block_ptr_work);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64_NativeHandle (&__objc_super__, selPerformAsCurrentWithPendingUnitCount_UsingBlock_XHandle, unitCount, (IntPtr) block_ptr_work);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="unitCount">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous PerformAsCurrent operation</returns>
		/// <remarks>
		///           <para copied="true">The PerformAsCurrentAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PerformAsCurrentAsync (long unitCount)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PerformAsCurrent(unitCount, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("publish")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Publish ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPublishXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPublishXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeSubscriber:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveSubscriber (NSObject subscriber)
		{
			var subscriber__handle__ = subscriber!.GetNonNullHandle (nameof (subscriber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRemoveSubscriber_XHandle, subscriber__handle__);
			GC.KeepAlive (subscriber);
		}
		[Export ("resignCurrent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResignCurrent ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResignCurrentXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResignCurrentXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resume")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResumeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResumeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="acknowledgementHandler">To be added.</param><param name="appBundleIdentifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAcknowledgementHandler:forAppBundleIdentifier:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetAcknowledgementHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> acknowledgementHandler, string appBundleIdentifier)
		{
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			if (appBundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appBundleIdentifier));
			using var block_acknowledgementHandler = Trampolines.SDActionArity1V2.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			var nsappBundleIdentifier = CFString.CreateNative (appBundleIdentifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetAcknowledgementHandler_ForAppBundleIdentifier_XHandle, (IntPtr) block_ptr_acknowledgementHandler, nsappBundleIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetAcknowledgementHandler_ForAppBundleIdentifier_XHandle, (IntPtr) block_ptr_acknowledgementHandler, nsappBundleIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsappBundleIdentifier);
		}
		/// <param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setCancellationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCancellationHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCancellationHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCancellationHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setPausingHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetPauseHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPausingHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPausingHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setResumingHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetResumingHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetResumingHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetResumingHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setUserInfoObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUserInfo (NSObject? obj, NSString key)
		{
			var obj__handle__ = obj.GetHandle ();
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetUserInfoObject_ForKey_XHandle, obj__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetUserInfoObject_ForKey_XHandle, obj__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (key);
		}
		[Export ("unpublish")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unpublish ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnpublishXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnpublishXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Whether this is tracking work that can be cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Cancellable {
			[Export ("isCancellable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCancellableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCancellableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCancellable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCancellable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCancellable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether this is tracking work that was cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Cancelled {
			[Export ("isCancelled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCancelledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCancelledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long CompletedUnitCount {
			[Export ("completedUnitCount")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selCompletedUnitCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selCompletedUnitCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCompletedUnitCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetCompletedUnitCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetCompletedUnitCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSProgress CurrentProgress {
			[Export ("currentProgress")]
			get {
				NSProgress? ret;
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentProgressXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? FileOperationKind {
			[Export ("fileOperationKind")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileOperationKindXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileOperationKindXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFileOperationKind:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileOperationKind_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileOperationKind_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSUrl? FileUrl {
			[Export ("fileURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFileURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Finished {
			[Export ("isFinished")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFinishedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFinishedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double FractionCompleted {
			[Export ("fractionCompleted")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selFractionCompletedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selFractionCompletedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Whether the tracked progress is indeterminate. Read-only.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Indeterminate {
			[Export ("isIndeterminate")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsIndeterminateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsIndeterminateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? Kind {
			[Export ("kind", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKindXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKindXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKind:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetKind_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetKind_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LocalizedAdditionalDescription {
			[Export ("localizedAdditionalDescription", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedAdditionalDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedAdditionalDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLocalizedAdditionalDescription:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocalizedAdditionalDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocalizedAdditionalDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LocalizedDescription {
			[Export ("localizedDescription", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLocalizedDescription:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocalizedDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocalizedDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool Old {
			[Export ("isOld")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOldXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOldXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Pausable {
			[Export ("isPausable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPausableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPausableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPausable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPausable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPausable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paused {
			[Export ("isPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long TotalUnitCount {
			[Export ("totalUnitCount")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selTotalUnitCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selTotalUnitCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTotalUnitCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetTotalUnitCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetTotalUnitCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal virtual NSNumber? _EstimatedTimeRemaining {
			[Export ("estimatedTimeRemaining", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEstimatedTimeRemainingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEstimatedTimeRemainingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setEstimatedTimeRemaining:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetEstimatedTimeRemaining_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetEstimatedTimeRemaining_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal virtual NSNumber? _FileCompletedCount {
			[Export ("fileCompletedCount", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileCompletedCountXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileCompletedCountXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFileCompletedCount:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileCompletedCount_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileCompletedCount_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal virtual NSNumber? _FileTotalCount {
			[Export ("fileTotalCount", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileTotalCountXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileTotalCountXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFileTotalCount:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileTotalCount_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileTotalCount_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal virtual NSNumber? _Throughput {
			[Export ("throughput", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selThroughputXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selThroughputXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setThroughput:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetThroughput_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetThroughput_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EstimatedTimeRemainingKey;
		/// <summary>Represents the value associated with the constant NSProgressEstimatedTimeRemainingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressEstimatedTimeRemainingKey",  "Foundation")]
		public static NSString EstimatedTimeRemainingKey {
			get {
				if (_EstimatedTimeRemainingKey is null)
					_EstimatedTimeRemainingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressEstimatedTimeRemainingKey")!;
				return _EstimatedTimeRemainingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileAnimationImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSProgressFileAnimationImageKey",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileAnimationImageKey {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileAnimationImageKey is null)
					_FileAnimationImageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileAnimationImageKey")!;
				return _FileAnimationImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileAnimationImageOriginalRectKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSProgressFileAnimationImageOriginalRectKey",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileAnimationImageOriginalRectKey {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileAnimationImageOriginalRectKey is null)
					_FileAnimationImageOriginalRectKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileAnimationImageOriginalRectKey")!;
				return _FileAnimationImageOriginalRectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileCompletedCountKey;
		/// <summary>Represents the value associated with the constant NSProgressFileCompletedCountKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileCompletedCountKey",  "Foundation")]
		public static NSString FileCompletedCountKey {
			get {
				if (_FileCompletedCountKey is null)
					_FileCompletedCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileCompletedCountKey")!;
				return _FileCompletedCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileIconKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSProgressFileIconKey",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileIconKey {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileIconKey is null)
					_FileIconKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileIconKey")!;
				return _FileIconKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindCopying;
		/// <summary>Represents the value associated with the constant NSProgressFileOperationKindCopying</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileOperationKindCopying",  "Foundation")]
		public static NSString FileOperationKindCopying {
			get {
				if (_FileOperationKindCopying is null)
					_FileOperationKindCopying = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindCopying")!;
				return _FileOperationKindCopying;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindDecompressingAfterDownloading;
		/// <summary>Represents the value associated with the constant NSProgressFileOperationKindDecompressingAfterDownloading</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileOperationKindDecompressingAfterDownloading",  "Foundation")]
		public static NSString FileOperationKindDecompressingAfterDownloading {
			get {
				if (_FileOperationKindDecompressingAfterDownloading is null)
					_FileOperationKindDecompressingAfterDownloading = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindDecompressingAfterDownloading")!;
				return _FileOperationKindDecompressingAfterDownloading;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindDownloading;
		/// <summary>Represents the value associated with the constant NSProgressFileOperationKindDownloading</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileOperationKindDownloading",  "Foundation")]
		public static NSString FileOperationKindDownloading {
			get {
				if (_FileOperationKindDownloading is null)
					_FileOperationKindDownloading = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindDownloading")!;
				return _FileOperationKindDownloading;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindDuplicatingKey;
		/// <summary>Represents the value associated with the constant 'NSProgressFileOperationKindDuplicating'.</summary>
		[Field ("NSProgressFileOperationKindDuplicating",  "Foundation")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileOperationKindDuplicatingKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileOperationKindDuplicatingKey is null)
					_FileOperationKindDuplicatingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindDuplicating")!;
				return _FileOperationKindDuplicatingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindKey;
		/// <summary>Represents the value associated with the constant NSProgressFileOperationKindKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileOperationKindKey",  "Foundation")]
		public static NSString FileOperationKindKey {
			get {
				if (_FileOperationKindKey is null)
					_FileOperationKindKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindKey")!;
				return _FileOperationKindKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindReceiving;
		/// <summary>Represents the value associated with the constant NSProgressFileOperationKindReceiving</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileOperationKindReceiving",  "Foundation")]
		public static NSString FileOperationKindReceiving {
			get {
				if (_FileOperationKindReceiving is null)
					_FileOperationKindReceiving = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindReceiving")!;
				return _FileOperationKindReceiving;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileOperationKindUploading;
		/// <summary>Represents the value associated with the constant 'NSProgressFileOperationKindUploading'.</summary>
		[Field ("NSProgressFileOperationKindUploading",  "Foundation")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileOperationKindUploading {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileOperationKindUploading is null)
					_FileOperationKindUploading = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileOperationKindUploading")!;
				return _FileOperationKindUploading;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileTotalCountKey;
		/// <summary>Represents the value associated with the constant NSProgressFileTotalCountKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileTotalCountKey",  "Foundation")]
		public static NSString FileTotalCountKey {
			get {
				if (_FileTotalCountKey is null)
					_FileTotalCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileTotalCountKey")!;
				return _FileTotalCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileURLKey;
		/// <summary>Represents the value associated with the constant NSProgressFileURLKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressFileURLKey",  "Foundation")]
		public static NSString FileURLKey {
			get {
				if (_FileURLKey is null)
					_FileURLKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressFileURLKey")!;
				return _FileURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KindFile;
		/// <summary>Represents the value associated with the constant NSProgressKindFile</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressKindFile",  "Foundation")]
		public static NSString KindFile {
			get {
				if (_KindFile is null)
					_KindFile = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressKindFile")!;
				return _KindFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThroughputKey;
		/// <summary>Represents the value associated with the constant NSProgressThroughputKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSProgressThroughputKey",  "Foundation")]
		public static NSString ThroughputKey {
			get {
				if (_ThroughputKey is null)
					_ThroughputKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSProgressThroughputKey")!;
				return _ThroughputKey;
			}
		}
	} /* class NSProgress */
}
