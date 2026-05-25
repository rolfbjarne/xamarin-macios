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
	[Register("MPSCNNYOLOLoss", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnYoloLoss : MPSCnnKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorBoxesX = "anchorBoxes";
		static readonly NativeHandle selAnchorBoxesXHandle = Selector.GetHandle ("anchorBoxes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_Labels_X = "encodeBatchToCommandBuffer:sourceImages:labels:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_Labels_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:labels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_X = "encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImage_Labels_X = "encodeToCommandBuffer:sourceImage:labels:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImage_Labels_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImage:labels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_X = "encodeToCommandBuffer:sourceImage:labels:destinationImage:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImage:labels:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_LossDescriptor_X = "initWithDevice:lossDescriptor:";
		static readonly NativeHandle selInitWithDevice_LossDescriptor_XHandle = Selector.GetHandle ("initWithDevice:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossClassesX = "lossClasses";
		static readonly NativeHandle selLossClassesXHandle = Selector.GetHandle ("lossClasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossConfidenceX = "lossConfidence";
		static readonly NativeHandle selLossConfidenceXHandle = Selector.GetHandle ("lossConfidence");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossWHX = "lossWH";
		static readonly NativeHandle selLossWHXHandle = Selector.GetHandle ("lossWH");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossXYX = "lossXY";
		static readonly NativeHandle selLossXYXHandle = Selector.GetHandle ("lossXY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxIOUForObjectAbsenceX = "maxIOUForObjectAbsence";
		static readonly NativeHandle selMaxIOUForObjectAbsenceXHandle = Selector.GetHandle ("maxIOUForObjectAbsence");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinIOUForObjectPresenceX = "minIOUForObjectPresence";
		static readonly NativeHandle selMinIOUForObjectPresenceXHandle = Selector.GetHandle ("minIOUForObjectPresence");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfAnchorBoxesX = "numberOfAnchorBoxes";
		static readonly NativeHandle selNumberOfAnchorBoxesXHandle = Selector.GetHandle ("numberOfAnchorBoxes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReduceAcrossBatchX = "reduceAcrossBatch";
		static readonly NativeHandle selReduceAcrossBatchXHandle = Selector.GetHandle ("reduceAcrossBatch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionTypeX = "reductionType";
		static readonly NativeHandle selReductionTypeXHandle = Selector.GetHandle ("reductionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleClassX = "scaleClass";
		static readonly NativeHandle selScaleClassXHandle = Selector.GetHandle ("scaleClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleNoObjectX = "scaleNoObject";
		static readonly NativeHandle selScaleNoObjectXHandle = Selector.GetHandle ("scaleNoObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleObjectX = "scaleObject";
		static readonly NativeHandle selScaleObjectXHandle = Selector.GetHandle ("scaleObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleWHX = "scaleWH";
		static readonly NativeHandle selScaleWHXHandle = Selector.GetHandle ("scaleWH");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleXYX = "scaleXY";
		static readonly NativeHandle selScaleXYXHandle = Selector.GetHandle ("scaleXY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNYOLOLoss");
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
		public MPSCnnYoloLoss (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnYoloLoss (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnYoloLoss (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="lossDescriptor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:lossDescriptor:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnYoloLoss (global::Metal.IMTLDevice device, MPSCnnYoloLossDescriptor lossDescriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var lossDescriptor__handle__ = lossDescriptor!.GetNonNullHandle (nameof (lossDescriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_LossDescriptor_XHandle, device__handle__, lossDescriptor__handle__), "initWithDevice:lossDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_LossDescriptor_XHandle, device__handle__, lossDescriptor__handle__), "initWithDevice:lossDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (lossDescriptor);
		}
		/// <param name="decoder">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnYoloLoss (NSCoder decoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var decoder__handle__ = decoder!.GetNonNullHandle (nameof (decoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithCoder_Device_XHandle, decoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithCoder_Device_XHandle, decoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decoder);
			GC.KeepAlive (device);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="labels">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImage:labels:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnLossLabels labels, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImage_Labels_DestinationImage_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (labels);
			GC.KeepAlive (destinationImage);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="labels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImage:labels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage Encode (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnLossLabels labels)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImage_Labels_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImage_Labels_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (labels);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="labels">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:labels:destinationImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSCnnLossLabels> labels, NSArray<MPSImage> destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_Labels_DestinationImages_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (labels);
			GC.KeepAlive (destinationImage);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImage">To be added.</param><param name="labels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:labels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSCnnLossLabels> labels)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_Labels_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_Labels_XHandle, commandBuffer__handle__, sourceImage__handle__, labels__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (labels);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData AnchorBoxes {
			[Export ("anchorBoxes", ArgumentSemantic.Retain)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnchorBoxesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnchorBoxesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnLoss LossClasses {
			[Export ("lossClasses", ArgumentSemantic.Retain)]
			get {
				MPSCnnLoss? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLossClassesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLossClassesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnLoss LossConfidence {
			[Export ("lossConfidence", ArgumentSemantic.Retain)]
			get {
				MPSCnnLoss? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLossConfidenceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLossConfidenceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnLoss LossWH {
			[Export ("lossWH", ArgumentSemantic.Retain)]
			get {
				MPSCnnLoss? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLossWHXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLossWHXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnLoss LossXY {
			[Export ("lossXY", ArgumentSemantic.Retain)]
			get {
				MPSCnnLoss? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLossXYXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSCnnLoss> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLossXYXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaxIouForObjectAbsence {
			[Export ("maxIOUForObjectAbsence")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaxIOUForObjectAbsenceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaxIOUForObjectAbsenceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinIouForObjectPresence {
			[Export ("minIOUForObjectPresence")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinIOUForObjectPresenceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinIOUForObjectPresenceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfAnchorBoxes {
			[Export ("numberOfAnchorBoxes")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfAnchorBoxesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfAnchorBoxesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ReduceAcrossBatch {
			[Export ("reduceAcrossBatch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReduceAcrossBatchXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReduceAcrossBatchXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnReductionType ReductionType {
			[Export ("reductionType")]
			get {
				MPSCnnReductionType ret;
				if (IsDirectBinding) {
					ret = (MPSCnnReductionType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selReductionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSCnnReductionType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selReductionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleClass {
			[Export ("scaleClass")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleClassXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleClassXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleNoObject {
			[Export ("scaleNoObject")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleNoObjectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleNoObjectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleObject {
			[Export ("scaleObject")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleObjectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleObjectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleWH {
			[Export ("scaleWH")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleWHXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleWHXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleXY {
			[Export ("scaleXY")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleXYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleXYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSCnnYoloLoss */
}
