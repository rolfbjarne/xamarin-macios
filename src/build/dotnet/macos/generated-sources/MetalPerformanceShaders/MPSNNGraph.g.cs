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
	/// <summary>An optimized neural network graph.</summary>
	[Register("MPSNNGraph", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSNNGraph : MPSKernel, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationImageAllocatorX = "destinationImageAllocator";
		static readonly NativeHandle selDestinationImageAllocatorXHandle = Selector.GetHandle ("destinationImageAllocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_SourceStates_X = "encodeBatchToCommandBuffer:sourceImages:sourceStates:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_SourceStates_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:sourceStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_X = "encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:";
		static readonly NativeHandle selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle = Selector.GetHandle ("encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImages_X = "encodeToCommandBuffer:sourceImages:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImages_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_X = "encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteAsyncWithSourceImages_CompletionHandler_X = "executeAsyncWithSourceImages:completionHandler:";
		static readonly NativeHandle selExecuteAsyncWithSourceImages_CompletionHandler_XHandle = Selector.GetHandle ("executeAsyncWithSourceImages:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatX = "format";
		static readonly NativeHandle selFormatXHandle = Selector.GetHandle ("format");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphWithDevice_ResultImage_ResultImageIsNeeded_X = "graphWithDevice:resultImage:resultImageIsNeeded:";
		static readonly NativeHandle selGraphWithDevice_ResultImage_ResultImageIsNeeded_XHandle = Selector.GetHandle ("graphWithDevice:resultImage:resultImageIsNeeded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphWithDevice_ResultImages_ResultsAreNeeded_X = "graphWithDevice:resultImages:resultsAreNeeded:";
		static readonly NativeHandle selGraphWithDevice_ResultImages_ResultsAreNeeded_XHandle = Selector.GetHandle ("graphWithDevice:resultImages:resultsAreNeeded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_Device_X = "initWithCoder:device:";
		static readonly NativeHandle selInitWithCoder_Device_XHandle = Selector.GetHandle ("initWithCoder:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ResultImage_X = "initWithDevice:resultImage:";
		static readonly NativeHandle selInitWithDevice_ResultImage_XHandle = Selector.GetHandle ("initWithDevice:resultImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ResultImage_ResultImageIsNeeded_X = "initWithDevice:resultImage:resultImageIsNeeded:";
		static readonly NativeHandle selInitWithDevice_ResultImage_ResultImageIsNeeded_XHandle = Selector.GetHandle ("initWithDevice:resultImage:resultImageIsNeeded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ResultImages_ResultsAreNeeded_X = "initWithDevice:resultImages:resultsAreNeeded:";
		static readonly NativeHandle selInitWithDevice_ResultImages_ResultsAreNeeded_XHandle = Selector.GetHandle ("initWithDevice:resultImages:resultsAreNeeded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntermediateImageHandlesX = "intermediateImageHandles";
		static readonly NativeHandle selIntermediateImageHandlesXHandle = Selector.GetHandle ("intermediateImageHandles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputStateIsTemporaryX = "outputStateIsTemporary";
		static readonly NativeHandle selOutputStateIsTemporaryXHandle = Selector.GetHandle ("outputStateIsTemporary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadCountForSourceImageAtIndex_X = "readCountForSourceImageAtIndex:";
		static readonly NativeHandle selReadCountForSourceImageAtIndex_XHandle = Selector.GetHandle ("readCountForSourceImageAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadCountForSourceStateAtIndex_X = "readCountForSourceStateAtIndex:";
		static readonly NativeHandle selReadCountForSourceStateAtIndex_XHandle = Selector.GetHandle ("readCountForSourceStateAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadFromDataSourcesX = "reloadFromDataSources";
		static readonly NativeHandle selReloadFromDataSourcesXHandle = Selector.GetHandle ("reloadFromDataSources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultHandleX = "resultHandle";
		static readonly NativeHandle selResultHandleXHandle = Selector.GetHandle ("resultHandle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultImageIsNeededX = "resultImageIsNeeded";
		static readonly NativeHandle selResultImageIsNeededXHandle = Selector.GetHandle ("resultImageIsNeeded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateHandlesX = "resultStateHandles";
		static readonly NativeHandle selResultStateHandlesXHandle = Selector.GetHandle ("resultStateHandles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDestinationImageAllocator_X = "setDestinationImageAllocator:";
		static readonly NativeHandle selSetDestinationImageAllocator_XHandle = Selector.GetHandle ("setDestinationImageAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFormat_X = "setFormat:";
		static readonly NativeHandle selSetFormat_XHandle = Selector.GetHandle ("setFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputStateIsTemporary_X = "setOutputStateIsTemporary:";
		static readonly NativeHandle selSetOutputStateIsTemporary_XHandle = Selector.GetHandle ("setOutputStateIsTemporary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceImageHandlesX = "sourceImageHandles";
		static readonly NativeHandle selSourceImageHandlesXHandle = Selector.GetHandle ("sourceImageHandles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceStateHandlesX = "sourceStateHandles";
		static readonly NativeHandle selSourceStateHandlesXHandle = Selector.GetHandle ("sourceStateHandles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNGraph");
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
		public MPSNNGraph (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSNNGraph (NSObjectFlag t) : base (t)
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
		protected internal MPSNNGraph (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="resultImage">To be added.</param><param name="resultIsNeeded">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:resultImage:resultImageIsNeeded:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNGraph (global::Metal.IMTLDevice device, MPSNNImageNode resultImage, bool resultIsNeeded)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var resultImage__handle__ = resultImage!.GetNonNullHandle (nameof (resultImage));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selInitWithDevice_ResultImage_ResultImageIsNeeded_XHandle, device__handle__, resultImage__handle__, resultIsNeeded ? (byte) 1 : (byte) 0), "initWithDevice:resultImage:resultImageIsNeeded:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithDevice_ResultImage_ResultImageIsNeeded_XHandle, device__handle__, resultImage__handle__, resultIsNeeded ? (byte) 1 : (byte) 0), "initWithDevice:resultImage:resultImageIsNeeded:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (resultImage);
		}
		/// <param name="device">To be added.</param><param name="resultImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:resultImage:")]
		[ObsoletedOSPlatform ("tvos11.3", "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
		[ObsoletedOSPlatform ("ios11.3", "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
		[ObsoletedOSPlatform ("macos10.13.4", "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNGraph (global::Metal.IMTLDevice device, MPSNNImageNode resultImage)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var resultImage__handle__ = resultImage!.GetNonNullHandle (nameof (resultImage));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_ResultImage_XHandle, device__handle__, resultImage__handle__), "initWithDevice:resultImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_ResultImage_XHandle, device__handle__, resultImage__handle__), "initWithDevice:resultImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (resultImage);
		}
		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNGraph (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="device">To be added.</param><param name="resultImage">To be added.</param><param name="resultIsNeeded">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("graphWithDevice:resultImage:resultImageIsNeeded:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNGraph? Create (global::Metal.IMTLDevice device, MPSNNImageNode resultImage, bool resultIsNeeded)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var resultImage__handle__ = resultImage!.GetNonNullHandle (nameof (resultImage));
			MPSNNGraph? ret;
			ret =  Runtime.GetNSObject<MPSNNGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, selGraphWithDevice_ResultImage_ResultImageIsNeeded_XHandle, device__handle__, resultImage__handle__, resultIsNeeded ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (device);
			GC.KeepAlive (resultImage);
			return ret!;
		}
		[Export ("graphWithDevice:resultImages:resultsAreNeeded:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNGraph? Create (global::Metal.IMTLDevice device, MPSNNImageNode[] resultImages, nint resultsAreNeeded)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (resultImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resultImages));
			using var nsa_resultImages = NSArray.FromNSObjects (resultImages);
			MPSNNGraph? ret;
			ret =  Runtime.GetNSObject<MPSNNGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selGraphWithDevice_ResultImages_ResultsAreNeeded_XHandle, device__handle__, nsa_resultImages.Handle, resultsAreNeeded), false)!;
			GC.KeepAlive (device);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><param name="intermediateImages">To be added.</param><param name="destinationStates">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage>? EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImages, NSArray<MPSState>[]? sourceStates, NSMutableArray<NSArray<MPSImage>>? intermediateImages, NSMutableArray<NSArray<MPSState>>? destinationStates)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var intermediateImages__handle__ = intermediateImages.GetHandle ();
			var destinationStates__handle__ = destinationStates.GetHandle ();
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), intermediateImages__handle__, destinationStates__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), intermediateImages__handle__, destinationStates__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (intermediateImages);
			GC.KeepAlive (destinationStates);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:sourceImages:sourceStates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage>? EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImages, NSArray<MPSState>[]? sourceStates)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImages">To be added.</param><param name="sourceStates"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="intermediateImages"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="destinationStates"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage? EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, MPSState[]? sourceStates, NSMutableArray<MPSImage>? intermediateImages, NSMutableArray<MPSState>? destinationStates)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var intermediateImages__handle__ = intermediateImages.GetHandle ();
			var destinationStates__handle__ = destinationStates.GetHandle ();
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), intermediateImages__handle__, destinationStates__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), intermediateImages__handle__, destinationStates__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (intermediateImages);
			GC.KeepAlive (destinationStates);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="sourceImages">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:sourceImages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage? EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceImages_XHandle, commandBuffer__handle__, nsa_sourceImages.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="sourceImages">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("executeAsyncWithSourceImages:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage Execute (MPSImage[] sourceImages, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V116))]global::System.Action<MPSImage, NSError> handler)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var block_handler = Trampolines.SDActionArity2V116.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			MPSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selExecuteAsyncWithSourceImages_CompletionHandler_XHandle, nsa_sourceImages.Handle, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selExecuteAsyncWithSourceImages_CompletionHandler_XHandle, nsa_sourceImages.Handle, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sourceImages">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous Execute operation.  The value of the TResult parameter is of type System.Action&lt;MetalPerformanceShaders.MPSImage,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The ExecuteAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MPSImage> ExecuteAsync (MPSImage[] sourceImages)
		{
			var tcs = new TaskCompletionSource<MPSImage> ();
			Execute(sourceImages, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="sourceImages">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MPSImage> ExecuteAsync (MPSImage[] sourceImages, out MPSImage result)
		{
			var tcs = new TaskCompletionSource<MPSImage> ();
			result = Execute(sourceImages, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readCountForSourceImageAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetReadCountForSourceImage (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selReadCountForSourceImageAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selReadCountForSourceImageAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readCountForSourceStateAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetReadCountForSourceState (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selReadCountForSourceStateAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selReadCountForSourceStateAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reloadFromDataSources")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadFromDataSources ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadFromDataSourcesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadFromDataSourcesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithDevice:resultImages:resultsAreNeeded:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithDevice (global::Metal.IMTLDevice device, MPSNNImageNode[] resultImages, nint areResultsNeeded)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (resultImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resultImages));
			using var nsa_resultImages = NSArray.FromNSObjects (resultImages);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selInitWithDevice_ResultImages_ResultsAreNeeded_XHandle, device__handle__, nsa_resultImages.Handle, areResultsNeeded);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selInitWithDevice_ResultImages_ResultsAreNeeded_XHandle, device__handle__, nsa_resultImages.Handle, areResultsNeeded);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSImageAllocator DestinationImageAllocator {
			[Export ("destinationImageAllocator", ArgumentSemantic.Retain)]
			get {
				IMPSImageAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationImageAllocatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationImageAllocatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDestinationImageAllocator:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDestinationImageAllocator_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDestinationImageAllocator_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPSImageFeatureChannelFormat Format {
			[Export ("format", ArgumentSemantic.Assign)]
			get {
				MPSImageFeatureChannelFormat ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageFeatureChannelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageFeatureChannelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHandle[]? IntermediateImageHandles {
			[Export ("intermediateImageHandles", ArgumentSemantic.Copy)]
			get {
				IMPSHandle[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIntermediateImageHandlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIntermediateImageHandlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsOutputStateTemporary {
			[Export ("outputStateIsTemporary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOutputStateIsTemporaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selOutputStateIsTemporaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setOutputStateIsTemporary:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOutputStateIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetOutputStateIsTemporary_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHandle? ResultHandle {
			[Export ("resultHandle")]
			get {
				IMPSHandle? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultHandleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultHandleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ResultImageIsNeeded {
			[Export ("resultImageIsNeeded")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResultImageIsNeededXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selResultImageIsNeededXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHandle[]? ResultStateHandles {
			[Export ("resultStateHandles", ArgumentSemantic.Copy)]
			get {
				IMPSHandle[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultStateHandlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultStateHandlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHandle[] SourceImageHandles {
			[Export ("sourceImageHandles", ArgumentSemantic.Copy)]
			get {
				IMPSHandle[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceImageHandlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceImageHandlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSHandle[]? SourceStateHandles {
			[Export ("sourceStateHandles", ArgumentSemantic.Copy)]
			get {
				IMPSHandle[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceStateHandlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMPSHandle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceStateHandlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPSNNGraph */
}
