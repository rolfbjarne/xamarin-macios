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
namespace MetalPerformanceShaders {
	/// <summary>A recurrent neural net layer.</summary>
	[Register("MPSRNNMatrixInferenceLayer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSRnnMatrixInferenceLayer : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBidirectionalCombineModeX = "bidirectionalCombineMode";
		static readonly NativeHandle selBidirectionalCombineModeXHandle = Selector.GetHandle ("bidirectionalCombineMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_Device_X = "copyWithZone:device:";
		static readonly NativeHandle selCopyWithZone_Device_XHandle = Selector.GetHandle ("copyWithZone:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardMatrices_DestinationBackwardMatrices_X = "encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardMatrices:destinationBackwardMatrices:";
		static readonly NativeHandle selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardMatrices_DestinationBackwardMatrices_XHandle = Selector.GetHandle ("encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardMatrices:destinationBackwardMatrices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_RecurrentInputState_RecurrentOutputStates_X = "encodeSequenceToCommandBuffer:sourceMatrices:destinationMatrices:recurrentInputState:recurrentOutputStates:";
		static readonly NativeHandle selEncodeSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_RecurrentInputState_RecurrentOutputStates_XHandle = Selector.GetHandle ("encodeSequenceToCommandBuffer:sourceMatrices:destinationMatrices:recurrentInputState:recurrentOutputStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_RecurrentInputState_RecurrentOutputStates_X = "encodeSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:recurrentInputState:recurrentOutputStates:";
		static readonly NativeHandle selEncodeSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_RecurrentInputState_RecurrentOutputStates_XHandle = Selector.GetHandle ("encodeSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:recurrentInputState:recurrentOutputStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_RnnDescriptor_X = "initWithDevice:rnnDescriptor:";
		static readonly NativeHandle selInitWithDevice_RnnDescriptor_XHandle = Selector.GetHandle ("initWithDevice:rnnDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_RnnDescriptors_X = "initWithDevice:rnnDescriptors:";
		static readonly NativeHandle selInitWithDevice_RnnDescriptors_XHandle = Selector.GetHandle ("initWithDevice:rnnDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputFeatureChannelsX = "inputFeatureChannels";
		static readonly NativeHandle selInputFeatureChannelsXHandle = Selector.GetHandle ("inputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfLayersX = "numberOfLayers";
		static readonly NativeHandle selNumberOfLayersXHandle = Selector.GetHandle ("numberOfLayers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFeatureChannelsX = "outputFeatureChannels";
		static readonly NativeHandle selOutputFeatureChannelsXHandle = Selector.GetHandle ("outputFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecurrentOutputIsTemporaryX = "recurrentOutputIsTemporary";
		static readonly NativeHandle selRecurrentOutputIsTemporaryXHandle = Selector.GetHandle ("recurrentOutputIsTemporary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBidirectionalCombineMode_X = "setBidirectionalCombineMode:";
		static readonly NativeHandle selSetBidirectionalCombineMode_XHandle = Selector.GetHandle ("setBidirectionalCombineMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecurrentOutputIsTemporary_X = "setRecurrentOutputIsTemporary:";
		static readonly NativeHandle selSetRecurrentOutputIsTemporary_XHandle = Selector.GetHandle ("setRecurrentOutputIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStoreAllIntermediateStates_X = "setStoreAllIntermediateStates:";
		static readonly NativeHandle selSetStoreAllIntermediateStates_XHandle = Selector.GetHandle ("setStoreAllIntermediateStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreAllIntermediateStatesX = "storeAllIntermediateStates";
		static readonly NativeHandle selStoreAllIntermediateStatesXHandle = Selector.GetHandle ("storeAllIntermediateStates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSRNNMatrixInferenceLayer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MPSRnnMatrixInferenceLayer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected MPSRnnMatrixInferenceLayer (NSObjectFlag t) : base (t)
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
		protected internal MPSRnnMatrixInferenceLayer (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="rnnDescriptor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:rnnDescriptor:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSRnnMatrixInferenceLayer (global::Metal.IMTLDevice device, MPSRnnDescriptor rnnDescriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var rnnDescriptor__handle__ = rnnDescriptor!.GetNonNullHandle (nameof (rnnDescriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_RnnDescriptor_XHandle, device__handle__, rnnDescriptor__handle__), "initWithDevice:rnnDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_RnnDescriptor_XHandle, device__handle__, rnnDescriptor__handle__), "initWithDevice:rnnDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (rnnDescriptor);
		}
		/// <param name="device">To be added.</param><param name="rnnDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:rnnDescriptors:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSRnnMatrixInferenceLayer (global::Metal.IMTLDevice device, MPSRnnDescriptor[] rnnDescriptors)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (rnnDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rnnDescriptors));
			using var nsa_rnnDescriptors = NSArray.FromNSObjects (rnnDescriptors);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_RnnDescriptors_XHandle, device__handle__, nsa_rnnDescriptors.Handle), "initWithDevice:rnnDescriptors:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_RnnDescriptors_XHandle, device__handle__, nsa_rnnDescriptors.Handle), "initWithDevice:rnnDescriptors:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSRnnMatrixInferenceLayer (NSCoder aDecoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithCoder_Device_XHandle, aDecoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithCoder_Device_XHandle, aDecoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDecoder);
			GC.KeepAlive (device);
		}
		/// <param name="zone"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="device"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSRnnMatrixInferenceLayer Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			MPSRnnMatrixInferenceLayer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSRnnMatrixInferenceLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCopyWithZone_Device_XHandle, zone__handle__, device__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSRnnMatrixInferenceLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCopyWithZone_Device_XHandle, zone__handle__, device__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceSequence">To be added.</param><param name="destinationForwardMatrices">To be added.</param><param name="destinationBackwardMatrices"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBidirectionalSequenceToCommandBuffer:sourceSequence:destinationForwardMatrices:destinationBackwardMatrices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBidirectionalSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceSequence, MPSMatrix[] destinationForwardMatrices, MPSMatrix[]? destinationBackwardMatrices)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceSequence is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceSequence));
			if (destinationForwardMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationForwardMatrices));
			using var nsa_sourceSequence = NSArray.FromNSObjects (sourceSequence);
			using var nsa_destinationForwardMatrices = NSArray.FromNSObjects (destinationForwardMatrices);
			using var nsa_destinationBackwardMatrices = destinationBackwardMatrices is null ? null : NSArray.FromNSObjects (destinationBackwardMatrices);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardMatrices_DestinationBackwardMatrices_XHandle, commandBuffer__handle__, nsa_sourceSequence.Handle, nsa_destinationForwardMatrices.Handle, nsa_destinationBackwardMatrices.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBidirectionalSequenceToCommandBuffer_SourceSequence_DestinationForwardMatrices_DestinationBackwardMatrices_XHandle, commandBuffer__handle__, nsa_sourceSequence.Handle, nsa_destinationForwardMatrices.Handle, nsa_destinationBackwardMatrices.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceMatrices">To be added.</param><param name="destinationMatrices">To be added.</param><param name="recurrentInputState"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="recurrentOutputStates"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeSequenceToCommandBuffer:sourceMatrices:destinationMatrices:recurrentInputState:recurrentOutputStates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, MPSMatrix[] destinationMatrices, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceMatrices));
			if (destinationMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationMatrices));
			var recurrentInputState__handle__ = recurrentInputState.GetHandle ();
			var recurrentOutputStates__handle__ = recurrentOutputStates.GetHandle ();
			using var nsa_sourceMatrices = NSArray.FromNSObjects (sourceMatrices);
			using var nsa_destinationMatrices = NSArray.FromNSObjects (destinationMatrices);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_RecurrentInputState_RecurrentOutputStates_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, nsa_destinationMatrices.Handle, recurrentInputState__handle__, recurrentOutputStates__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_RecurrentInputState_RecurrentOutputStates_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, nsa_destinationMatrices.Handle, recurrentInputState__handle__, recurrentOutputStates__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (recurrentInputState);
			GC.KeepAlive (recurrentOutputStates);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceMatrices">To be added.</param><param name="sourceOffsets">To be added.</param><param name="destinationMatrices">To be added.</param><param name="destinationOffsets">To be added.</param><param name="recurrentInputState">To be added.</param><param name="recurrentOutputStates">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:recurrentInputState:recurrentOutputStates:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeSequence (global::Metal.IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, nint sourceOffsets, MPSMatrix[] destinationMatrices, nint destinationOffsets, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceMatrices));
			if (destinationMatrices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationMatrices));
			var recurrentInputState__handle__ = recurrentInputState.GetHandle ();
			var recurrentOutputStates__handle__ = recurrentOutputStates.GetHandle ();
			using var nsa_sourceMatrices = NSArray.FromNSObjects (sourceMatrices);
			using var nsa_destinationMatrices = NSArray.FromNSObjects (destinationMatrices);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, selEncodeSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_RecurrentInputState_RecurrentOutputStates_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, sourceOffsets, nsa_destinationMatrices.Handle, destinationOffsets, recurrentInputState__handle__, recurrentOutputStates__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selEncodeSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_RecurrentInputState_RecurrentOutputStates_XHandle, commandBuffer__handle__, nsa_sourceMatrices.Handle, sourceOffsets, nsa_destinationMatrices.Handle, destinationOffsets, recurrentInputState__handle__, recurrentOutputStates__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (recurrentInputState);
			GC.KeepAlive (recurrentOutputStates);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSRnnBidirectionalCombineMode BidirectionalCombineMode {
			[Export ("bidirectionalCombineMode", ArgumentSemantic.Assign)]
			get {
				MPSRnnBidirectionalCombineMode ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSRnnBidirectionalCombineMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selBidirectionalCombineModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSRnnBidirectionalCombineMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selBidirectionalCombineModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBidirectionalCombineMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetBidirectionalCombineMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetBidirectionalCombineMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint InputFeatureChannels {
			[Export ("inputFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInputFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInputFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRecurrentOutputTemporary {
			[Export ("recurrentOutputIsTemporary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRecurrentOutputIsTemporaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRecurrentOutputIsTemporaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRecurrentOutputIsTemporary:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRecurrentOutputIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRecurrentOutputIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfLayers {
			[Export ("numberOfLayers")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfLayersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfLayersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint OutputFeatureChannels {
			[Export ("outputFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOutputFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOutputFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StoreAllIntermediateStates {
			[Export ("storeAllIntermediateStates")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStoreAllIntermediateStatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStoreAllIntermediateStatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStoreAllIntermediateStates:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStoreAllIntermediateStates_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStoreAllIntermediateStates_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSRnnMatrixInferenceLayer */
}
