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
	/// <summary>An <see cref="T:HealthKit.HKQuery" /> that on its initial call returns the most recent result and in subsequent calls returns only data added after the initial call.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKAnchoredObjectQuery_Class/index.html">Apple documentation for <c>HKAnchoredObjectQuery</c></related>
	[Register("HKAnchoredObjectQuery", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKAnchoredObjectQuery : HKQuery {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithQueryDescriptors_Anchor_Limit_ResultsHandler_X = "initWithQueryDescriptors:anchor:limit:resultsHandler:";
		static readonly NativeHandle selInitWithQueryDescriptors_Anchor_Limit_ResultsHandler_XHandle = Selector.GetHandle ("initWithQueryDescriptors:anchor:limit:resultsHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithType_Predicate_Anchor_Limit_CompletionHandler_X = "initWithType:predicate:anchor:limit:completionHandler:";
		static readonly NativeHandle selInitWithType_Predicate_Anchor_Limit_CompletionHandler_XHandle = Selector.GetHandle ("initWithType:predicate:anchor:limit:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithType_Predicate_Anchor_Limit_ResultsHandler_X = "initWithType:predicate:anchor:limit:resultsHandler:";
		static readonly NativeHandle selInitWithType_Predicate_Anchor_Limit_ResultsHandler_XHandle = Selector.GetHandle ("initWithType:predicate:anchor:limit:resultsHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUpdateHandler_X = "setUpdateHandler:";
		static readonly NativeHandle selSetUpdateHandler_XHandle = Selector.GetHandle ("setUpdateHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateHandlerX = "updateHandler";
		static readonly NativeHandle selUpdateHandlerXHandle = Selector.GetHandle ("updateHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKAnchoredObjectQuery");
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
		protected HKAnchoredObjectQuery (NSObjectFlag t) : base (t)
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
		protected internal HKAnchoredObjectQuery (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="type">To be added.</param><param name="predicate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="anchor">To be added.</param><param name="limit">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated constructor. </summary><remarks>To be added.</remarks>
		[Export ("initWithType:predicate:anchor:limit:completionHandler:")]
		[ObsoletedOSPlatform ("ios9.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe HKAnchoredObjectQuery (HKSampleType type, NSPredicate? predicate, nuint anchor, nuint limit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKAnchoredObjectResultHandler))]HKAnchoredObjectResultHandler completion)
			: base (NSObjectFlag.Empty)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			var predicate__handle__ = predicate.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKAnchoredObjectResultHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (this.Handle, selInitWithType_Predicate_Anchor_Limit_CompletionHandler_XHandle, type__handle__, predicate__handle__, anchor, limit, (IntPtr) block_ptr_completion), "initWithType:predicate:anchor:limit:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selInitWithType_Predicate_Anchor_Limit_CompletionHandler_XHandle, type__handle__, predicate__handle__, anchor, limit, (IntPtr) block_ptr_completion), "initWithType:predicate:anchor:limit:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (type);
			GC.KeepAlive (predicate);
		}
		/// <param name="type">To be added.</param><param name="predicate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="anchor"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="limit">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithType:predicate:anchor:limit:resultsHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe HKAnchoredObjectQuery (HKSampleType type, NSPredicate? predicate, HKQueryAnchor? anchor, nuint limit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKAnchoredObjectUpdateHandler))]HKAnchoredObjectUpdateHandler handler)
			: base (NSObjectFlag.Empty)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			var predicate__handle__ = predicate.GetHandle ();
			var anchor__handle__ = anchor.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDHKAnchoredObjectUpdateHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selInitWithType_Predicate_Anchor_Limit_ResultsHandler_XHandle, type__handle__, predicate__handle__, anchor__handle__, limit, (IntPtr) block_ptr_handler), "initWithType:predicate:anchor:limit:resultsHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selInitWithType_Predicate_Anchor_Limit_ResultsHandler_XHandle, type__handle__, predicate__handle__, anchor__handle__, limit, (IntPtr) block_ptr_handler), "initWithType:predicate:anchor:limit:resultsHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (type);
			GC.KeepAlive (predicate);
			GC.KeepAlive (anchor);
		}
		[Export ("initWithQueryDescriptors:anchor:limit:resultsHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe HKAnchoredObjectQuery (HKQueryDescriptor[] queryDescriptors, HKQueryAnchor? anchor, nint limit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKAnchoredObjectUpdateHandler))]HKAnchoredObjectUpdateHandler resultsHandler)
			: base (NSObjectFlag.Empty)
		{
			if (queryDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryDescriptors));
			var anchor__handle__ = anchor.GetHandle ();
			if (resultsHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resultsHandler));
			using var nsa_queryDescriptors = NSArray.FromNSObjects (queryDescriptors);
			using var block_resultsHandler = Trampolines.SDHKAnchoredObjectUpdateHandler.CreateBlock (resultsHandler);
			BlockLiteral *block_ptr_resultsHandler = &block_resultsHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (this.Handle, selInitWithQueryDescriptors_Anchor_Limit_ResultsHandler_XHandle, nsa_queryDescriptors.Handle, anchor__handle__, limit, (IntPtr) block_ptr_resultsHandler), "initWithQueryDescriptors:anchor:limit:resultsHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selInitWithQueryDescriptors_Anchor_Limit_ResultsHandler_XHandle, nsa_queryDescriptors.Handle, anchor__handle__, limit, (IntPtr) block_ptr_resultsHandler), "initWithQueryDescriptors:anchor:limit:resultsHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public unsafe virtual HKAnchoredObjectUpdateHandler? UpdateHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDHKAnchoredObjectUpdateHandler))]
			[Export ("updateHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUpdateHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUpdateHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDHKAnchoredObjectUpdateHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKAnchoredObjectUpdateHandler))]
			[Export ("setUpdateHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDHKAnchoredObjectUpdateHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUpdateHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUpdateHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class HKAnchoredObjectQuery */
}
