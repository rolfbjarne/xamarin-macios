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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShaders {
	[Register("MPSCNNBatchNormalization", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnBatchNormalization : MPSCnnKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNBatchNormalization");
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
		public MPSCnnBatchNormalization (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected MPSCnnBatchNormalization (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnBatchNormalization (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:dataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBatchNormalization (global::Metal.IMTLDevice device, IMPSCnnBatchNormalizationDataSource dataSource)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithDevice:dataSource:"), device__handle__, dataSource__handle__), "initWithDevice:dataSource:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDevice:dataSource:"), device__handle__, dataSource__handle__), "initWithDevice:dataSource:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (dataSource);
		}
		/// <param name="device">To be added.</param><param name="dataSource">To be added.</param><param name="fusedNeuronDescriptor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:dataSource:fusedNeuronDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBatchNormalization (global::Metal.IMTLDevice device, IMPSCnnBatchNormalizationDataSource dataSource, MPSNNNeuronDescriptor? fusedNeuronDescriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			var fusedNeuronDescriptor__handle__ = fusedNeuronDescriptor.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithDevice:dataSource:fusedNeuronDescriptor:"), device__handle__, dataSource__handle__, fusedNeuronDescriptor__handle__), "initWithDevice:dataSource:fusedNeuronDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDevice:dataSource:fusedNeuronDescriptor:"), device__handle__, dataSource__handle__, fusedNeuronDescriptor__handle__), "initWithDevice:dataSource:fusedNeuronDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (dataSource);
			GC.KeepAlive (fusedNeuronDescriptor);
		}
		/// <param name="decoder">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBatchNormalization (NSCoder decoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var decoder__handle__ = decoder!.GetNonNullHandle (nameof (decoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:device:"), decoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:device:"), decoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decoder);
			GC.KeepAlive (device);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="batchNormalizationState">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnBatchNormalizationState batchNormalizationState, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:"), commandBuffer__handle__, sourceImage__handle__, batchNormalizationState__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:"), commandBuffer__handle__, sourceImage__handle__, batchNormalizationState__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (batchNormalizationState);
			GC.KeepAlive (destinationImage);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImages">To be added.</param><param name="batchNormalizationState">To be added.</param><param name="destinationImages">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSImage> destinationImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImages__handle__ = sourceImages!.GetNonNullHandle (nameof (sourceImages));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			var destinationImages__handle__ = destinationImages!.GetNonNullHandle (nameof (destinationImages));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:"), commandBuffer__handle__, sourceImages__handle__, batchNormalizationState__handle__, destinationImages__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:"), commandBuffer__handle__, sourceImages__handle__, batchNormalizationState__handle__, destinationImages__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImages);
			GC.KeepAlive (batchNormalizationState);
			GC.KeepAlive (destinationImages);
		}
		/// <param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateForSourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnBatchNormalizationState? GetResultState (MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSCnnBatchNormalizationState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnBatchNormalizationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resultStateForSourceImage:sourceStates:destinationImage:"), sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnBatchNormalizationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("resultStateForSourceImage:sourceStates:destinationImage:"), sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnBatchNormalizationState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSCnnBatchNormalizationState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSCnnBatchNormalizationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:"), commandBuffer__handle__, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSCnnBatchNormalizationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:"), commandBuffer__handle__, sourceImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="gammaAndBetaState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnNormalizationGammaAndBetaState gammaAndBetaState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var gammaAndBetaState__handle__ = gammaAndBetaState!.GetNonNullHandle (nameof (gammaAndBetaState));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:"), commandBuffer__handle__, gammaAndBetaState__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:"), commandBuffer__handle__, gammaAndBetaState__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (gammaAndBetaState);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadGammaAndBetaFromDataSource")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadGammaAndBetaFromDataSource ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadGammaAndBetaFromDataSource"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reloadGammaAndBetaFromDataSource"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="commandBuffer">To be added.</param><param name="meanAndVarianceState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadMeanAndVariance (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnNormalizationMeanAndVarianceState meanAndVarianceState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var meanAndVarianceState__handle__ = meanAndVarianceState!.GetNonNullHandle (nameof (meanAndVarianceState));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:"), commandBuffer__handle__, meanAndVarianceState__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:"), commandBuffer__handle__, meanAndVarianceState__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (meanAndVarianceState);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadMeanAndVarianceFromDataSource")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadMeanAndVarianceFromDataSource ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadMeanAndVarianceFromDataSource"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reloadMeanAndVarianceFromDataSource"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnBatchNormalizationDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Retain)]
			get {
				IMPSCnnBatchNormalizationDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataSource")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("epsilon"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("epsilon"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setEpsilon:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setEpsilon:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setEpsilon:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfFeatureChannels"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSCnnBatchNormalization */
}
