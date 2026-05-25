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
	[Register("AVMutableVideoComposition", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVMutableVideoComposition : AVVideoComposition {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationToolX = "animationTool";
		static readonly NativeHandle selAnimationToolXHandle = Selector.GetHandle ("animationTool");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorPrimariesX = "colorPrimaries";
		static readonly NativeHandle selColorPrimariesXHandle = Selector.GetHandle ("colorPrimaries");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorTransferFunctionX = "colorTransferFunction";
		static readonly NativeHandle selColorTransferFunctionXHandle = Selector.GetHandle ("colorTransferFunction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorYCbCrMatrixX = "colorYCbCrMatrix";
		static readonly NativeHandle selColorYCbCrMatrixXHandle = Selector.GetHandle ("colorYCbCrMatrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomVideoCompositorClassX = "customVideoCompositorClass";
		static readonly NativeHandle selCustomVideoCompositorClassXHandle = Selector.GetHandle ("customVideoCompositorClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameDurationX = "frameDuration";
		static readonly NativeHandle selFrameDurationXHandle = Selector.GetHandle ("frameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstructionsX = "instructions";
		static readonly NativeHandle selInstructionsXHandle = Selector.GetHandle ("instructions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputBufferDescriptionX = "outputBufferDescription";
		static readonly NativeHandle selOutputBufferDescriptionXHandle = Selector.GetHandle ("outputBufferDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerFrameHDRDisplayMetadataPolicyX = "perFrameHDRDisplayMetadataPolicy";
		static readonly NativeHandle selPerFrameHDRDisplayMetadataPolicyXHandle = Selector.GetHandle ("perFrameHDRDisplayMetadataPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderScaleX = "renderScale";
		static readonly NativeHandle selRenderScaleXHandle = Selector.GetHandle ("renderScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderSizeX = "renderSize";
		static readonly NativeHandle selRenderSizeXHandle = Selector.GetHandle ("renderSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimationTool_X = "setAnimationTool:";
		static readonly NativeHandle selSetAnimationTool_XHandle = Selector.GetHandle ("setAnimationTool:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorPrimaries_X = "setColorPrimaries:";
		static readonly NativeHandle selSetColorPrimaries_XHandle = Selector.GetHandle ("setColorPrimaries:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorTransferFunction_X = "setColorTransferFunction:";
		static readonly NativeHandle selSetColorTransferFunction_XHandle = Selector.GetHandle ("setColorTransferFunction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorYCbCrMatrix_X = "setColorYCbCrMatrix:";
		static readonly NativeHandle selSetColorYCbCrMatrix_XHandle = Selector.GetHandle ("setColorYCbCrMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomVideoCompositorClass_X = "setCustomVideoCompositorClass:";
		static readonly NativeHandle selSetCustomVideoCompositorClass_XHandle = Selector.GetHandle ("setCustomVideoCompositorClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFrameDuration_X = "setFrameDuration:";
		static readonly NativeHandle selSetFrameDuration_XHandle = Selector.GetHandle ("setFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstructions_X = "setInstructions:";
		static readonly NativeHandle selSetInstructions_XHandle = Selector.GetHandle ("setInstructions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputBufferDescription_X = "setOutputBufferDescription:";
		static readonly NativeHandle selSetOutputBufferDescription_XHandle = Selector.GetHandle ("setOutputBufferDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPerFrameHDRDisplayMetadataPolicy_X = "setPerFrameHDRDisplayMetadataPolicy:";
		static readonly NativeHandle selSetPerFrameHDRDisplayMetadataPolicy_XHandle = Selector.GetHandle ("setPerFrameHDRDisplayMetadataPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRenderScale_X = "setRenderScale:";
		static readonly NativeHandle selSetRenderScale_XHandle = Selector.GetHandle ("setRenderScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRenderSize_X = "setRenderSize:";
		static readonly NativeHandle selSetRenderSize_XHandle = Selector.GetHandle ("setRenderSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceSampleDataTrackIDs_X = "setSourceSampleDataTrackIDs:";
		static readonly NativeHandle selSetSourceSampleDataTrackIDs_XHandle = Selector.GetHandle ("setSourceSampleDataTrackIDs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceTrackIDForFrameTiming_X = "setSourceTrackIDForFrameTiming:";
		static readonly NativeHandle selSetSourceTrackIDForFrameTiming_XHandle = Selector.GetHandle ("setSourceTrackIDForFrameTiming:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceSampleDataTrackIDsX = "sourceSampleDataTrackIDs";
		static readonly NativeHandle selSourceSampleDataTrackIDsXHandle = Selector.GetHandle ("sourceSampleDataTrackIDs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceTrackIDForFrameTimingX = "sourceTrackIDForFrameTiming";
		static readonly NativeHandle selSourceTrackIDForFrameTimingXHandle = Selector.GetHandle ("sourceTrackIDForFrameTiming");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionX = "videoComposition";
		static readonly NativeHandle selVideoCompositionXHandle = Selector.GetHandle ("videoComposition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_X = "videoCompositionWithAsset:applyingCIFiltersWithHandler:";
		static readonly NativeHandle selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_XHandle = Selector.GetHandle ("videoCompositionWithAsset:applyingCIFiltersWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_CompletionHandler_X = "videoCompositionWithAsset:applyingCIFiltersWithHandler:completionHandler:";
		static readonly NativeHandle selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_CompletionHandler_XHandle = Selector.GetHandle ("videoCompositionWithAsset:applyingCIFiltersWithHandler:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithPropertiesOfAsset_X = "videoCompositionWithPropertiesOfAsset:";
		static readonly NativeHandle selVideoCompositionWithPropertiesOfAsset_XHandle = Selector.GetHandle ("videoCompositionWithPropertiesOfAsset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithPropertiesOfAsset_CompletionHandler_X = "videoCompositionWithPropertiesOfAsset:completionHandler:";
		static readonly NativeHandle selVideoCompositionWithPropertiesOfAsset_CompletionHandler_XHandle = Selector.GetHandle ("videoCompositionWithPropertiesOfAsset:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_X = "videoCompositionWithPropertiesOfAsset:prototypeInstruction:";
		static readonly NativeHandle selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_XHandle = Selector.GetHandle ("videoCompositionWithPropertiesOfAsset:prototypeInstruction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_CompletionHandler_X = "videoCompositionWithPropertiesOfAsset:prototypeInstruction:completionHandler:";
		static readonly NativeHandle selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_CompletionHandler_XHandle = Selector.GetHandle ("videoCompositionWithPropertiesOfAsset:prototypeInstruction:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableVideoComposition");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVMutableVideoComposition" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVMutableVideoComposition () : base (NSObjectFlag.Empty)
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
		protected AVMutableVideoComposition (NSObjectFlag t) : base (t)
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
		protected internal AVMutableVideoComposition (NativeHandle handle) : base (handle)
		{
		}

		[Export ("videoComposition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableVideoComposition Create ()
		{
			AVMutableVideoComposition ret;
			ret =  Runtime.GetNSObject<AVMutableVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selVideoCompositionXHandle), false)!;
			return ret;
		}
		[Export ("videoCompositionWithPropertiesOfAsset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos15.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableVideoComposition Create (AVAsset asset)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			AVMutableVideoComposition? ret;
			ret =  Runtime.GetNSObject<AVMutableVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selVideoCompositionWithPropertiesOfAsset_XHandle, asset__handle__), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[Export ("videoCompositionWithPropertiesOfAsset:prototypeInstruction:")]
		[ObsoletedOSPlatform ("macos15.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use the overload of 'Create' that takes a completion handler instead.")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableVideoComposition Create (AVAsset asset, AVVideoCompositionInstruction prototypeInstruction)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var prototypeInstruction__handle__ = prototypeInstruction!.GetNonNullHandle (nameof (prototypeInstruction));
			AVMutableVideoComposition? ret;
			ret =  Runtime.GetNSObject<AVMutableVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_XHandle, asset__handle__, prototypeInstruction__handle__), false)!;
			GC.KeepAlive (asset);
			GC.KeepAlive (prototypeInstruction);
			return ret!;
		}
		[Export ("videoCompositionWithAsset:applyingCIFiltersWithHandler:completionHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Create (AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableVideoCompositionCreateApplier))]AVMutableVideoCompositionCreateApplier applier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableVideoCompositionCreateCallback))]AVMutableVideoCompositionCreateCallback completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (applier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_applier = Trampolines.SDAVMutableVideoCompositionCreateApplier.CreateBlock (applier);
			BlockLiteral *block_ptr_applier = &block_applier;
			using var block_completionHandler = Trampolines.SDAVMutableVideoCompositionCreateCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_CompletionHandler_XHandle, asset__handle__, (IntPtr) block_ptr_applier, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVMutableVideoComposition> CreateAsync (AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableVideoCompositionCreateApplier))]AVMutableVideoCompositionCreateApplier applier)
		{
			var tcs = new TaskCompletionSource<AVMutableVideoComposition> ();
			Create(asset, applier, (videoComposition_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (videoComposition_!);
			});
			return tcs.Task;
		}
		[Export ("videoCompositionWithPropertiesOfAsset:completionHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Create (AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableVideoCompositionCreateCallback))]AVMutableVideoCompositionCreateCallback completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAVMutableVideoCompositionCreateCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selVideoCompositionWithPropertiesOfAsset_CompletionHandler_XHandle, asset__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVMutableVideoComposition> CreateAsync (AVAsset asset)
		{
			var tcs = new TaskCompletionSource<AVMutableVideoComposition> ();
			Create(asset, (videoComposition_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (videoComposition_!);
			});
			return tcs.Task;
		}
		[Export ("videoCompositionWithPropertiesOfAsset:prototypeInstruction:completionHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Create (AVAsset asset, AVVideoCompositionInstruction prototypeInstruction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableVideoCompositionCreateCallback))]AVMutableVideoCompositionCreateCallback completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var prototypeInstruction__handle__ = prototypeInstruction!.GetNonNullHandle (nameof (prototypeInstruction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAVMutableVideoCompositionCreateCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_CompletionHandler_XHandle, asset__handle__, prototypeInstruction__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
			GC.KeepAlive (prototypeInstruction);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVMutableVideoComposition> CreateAsync (AVAsset asset, AVVideoCompositionInstruction prototypeInstruction)
		{
			var tcs = new TaskCompletionSource<AVMutableVideoComposition> ();
			Create(asset, prototypeInstruction, (videoComposition_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (videoComposition_!);
			});
			return tcs.Task;
		}
		[Export ("videoCompositionWithAsset:applyingCIFiltersWithHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos13.0", "Call 'Create' instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Call 'Create' instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Call 'Create' instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Call 'Create' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVMutableVideoComposition GetVideoComposition (AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V8))]global::System.Action<AVAsynchronousCIImageFilteringRequest> applier)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (applier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applier));
			using var block_applier = Trampolines.SDActionArity1V8.CreateBlock (applier);
			BlockLiteral *block_ptr_applier = &block_applier;
			AVMutableVideoComposition? ret;
			ret =  Runtime.GetNSObject<AVMutableVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_XHandle, asset__handle__, (IntPtr) block_ptr_applier), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVVideoCompositionCoreAnimationTool? AnimationTool {
			[Export ("animationTool", ArgumentSemantic.Retain)]
			get {
				AVVideoCompositionCoreAnimationTool? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimationToolXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimationToolXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAnimationTool:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAnimationTool_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAnimationTool_XHandle, value__handle__);
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
		public virtual string? ColorPrimaries {
			[Export ("colorPrimaries")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorPrimariesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorPrimariesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorPrimaries:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorPrimaries_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorPrimaries_XHandle, nsvalue);
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
		public virtual string? ColorTransferFunction {
			[Export ("colorTransferFunction")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorTransferFunctionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorTransferFunctionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorTransferFunction:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorTransferFunction_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorTransferFunction_XHandle, nsvalue);
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
		public virtual string? ColorYCbCrMatrix {
			[Export ("colorYCbCrMatrix")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorYCbCrMatrixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorYCbCrMatrixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorYCbCrMatrix:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorYCbCrMatrix_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorYCbCrMatrix_XHandle, nsvalue);
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
		public override Class? CustomVideoCompositorClass {
			[Export ("customVideoCompositorClass", ArgumentSemantic.Retain)]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomVideoCompositorClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomVideoCompositorClassXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomVideoCompositorClass:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomVideoCompositorClass_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomVideoCompositorClass_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime FrameDuration {
			[Export ("frameDuration", ArgumentSemantic.Assign)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setFrameDuration:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetFrameDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVVideoCompositionInstruction[] Instructions {
			[Export ("instructions", ArgumentSemantic.Copy)]
			get {
				AVVideoCompositionInstruction[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVVideoCompositionInstruction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInstructionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVVideoCompositionInstruction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInstructionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInstructions:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInstructions_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInstructions_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual NSObject[]? OutputBufferDescription {
			[Export ("outputBufferDescription", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputBufferDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputBufferDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputBufferDescription:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputBufferDescription_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputBufferDescription_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual string PerFrameHdrDisplayMetadataPolicy {
			[Export ("perFrameHDRDisplayMetadataPolicy")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPerFrameHDRDisplayMetadataPolicyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPerFrameHDRDisplayMetadataPolicyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPerFrameHDRDisplayMetadataPolicy:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPerFrameHDRDisplayMetadataPolicy_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPerFrameHDRDisplayMetadataPolicy_XHandle, nsvalue);
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
		public virtual float RenderScale {
			[Export ("renderScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRenderScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRenderScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRenderScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRenderScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetRenderScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize RenderSize {
			[Export ("renderSize", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selRenderSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selRenderSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRenderSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetRenderSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetRenderSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] SourceSampleDataTrackIds {
			[Export ("sourceSampleDataTrackIDs", ArgumentSemantic.Copy)]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceSampleDataTrackIDsXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceSampleDataTrackIDsXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSourceSampleDataTrackIDs:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_SourceSampleDataTrackIds = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSourceSampleDataTrackIDs_XHandle, nsb_SourceSampleDataTrackIds.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSourceSampleDataTrackIDs_XHandle, nsb_SourceSampleDataTrackIds.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_SourceSampleDataTrackIds?.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual int SourceTrackIdForFrameTiming {
			[Export ("sourceTrackIDForFrameTiming")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSourceTrackIDForFrameTimingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selSourceTrackIDForFrameTimingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSourceTrackIDForFrameTiming:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSourceTrackIDForFrameTiming_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetSourceTrackIDForFrameTiming_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class AVMutableVideoComposition */
}
