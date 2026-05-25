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
	/// <summary>An image that may contain more than 4 channels. (For example, an image in a layer of a convolutional neural network.)</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/MetalPerformanceShaders/MPSImage">Apple documentation for <c>MPSImage</c></related>
	[Register("MPSImage", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSImage : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchRepresentationX = "batchRepresentation";
		static readonly NativeHandle selBatchRepresentationXHandle = Selector.GetHandle ("batchRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchRepresentationWithSubRange_X = "batchRepresentationWithSubRange:";
		static readonly NativeHandle selBatchRepresentationWithSubRange_XHandle = Selector.GetHandle ("batchRepresentationWithSubRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultAllocatorX = "defaultAllocator";
		static readonly NativeHandle selDefaultAllocatorXHandle = Selector.GetHandle ("defaultAllocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFeatureChannelFormatX = "featureChannelFormat";
		static readonly NativeHandle selFeatureChannelFormatXHandle = Selector.GetHandle ("featureChannelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFeatureChannelsX = "featureChannels";
		static readonly NativeHandle selFeatureChannelsXHandle = Selector.GetHandle ("featureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeightX = "height";
		static readonly NativeHandle selHeightXHandle = Selector.GetHandle ("height");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ImageDescriptor_X = "initWithDevice:imageDescriptor:";
		static readonly NativeHandle selInitWithDevice_ImageDescriptor_XHandle = Selector.GetHandle ("initWithDevice:imageDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithParentImage_SliceRange_FeatureChannels_X = "initWithParentImage:sliceRange:featureChannels:";
		static readonly NativeHandle selInitWithParentImage_SliceRange_FeatureChannels_XHandle = Selector.GetHandle ("initWithParentImage:sliceRange:featureChannels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTexture_FeatureChannels_X = "initWithTexture:featureChannels:";
		static readonly NativeHandle selInitWithTexture_FeatureChannels_XHandle = Selector.GetHandle ("initWithTexture:featureChannels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfImagesX = "numberOfImages";
		static readonly NativeHandle selNumberOfImagesXHandle = Selector.GetHandle ("numberOfImages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentX = "parent";
		static readonly NativeHandle selParentXHandle = Selector.GetHandle ("parent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelFormatX = "pixelFormat";
		static readonly NativeHandle selPixelFormatXHandle = Selector.GetHandle ("pixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelSizeX = "pixelSize";
		static readonly NativeHandle selPixelSizeXHandle = Selector.GetHandle ("pixelSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrecisionX = "precision";
		static readonly NativeHandle selPrecisionXHandle = Selector.GetHandle ("precision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_X = "readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";
		static readonly NativeHandle selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle = Selector.GetHandle ("readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_X = "readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:";
		static readonly NativeHandle selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle = Selector.GetHandle ("readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadBytes_DataLayout_ImageIndex_X = "readBytes:dataLayout:imageIndex:";
		static readonly NativeHandle selReadBytes_DataLayout_ImageIndex_XHandle = Selector.GetHandle ("readBytes:dataLayout:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceSizeX = "resourceSize";
		static readonly NativeHandle selResourceSizeXHandle = Selector.GetHandle ("resourceSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPurgeableState_X = "setPurgeableState:";
		static readonly NativeHandle selSetPurgeableState_XHandle = Selector.GetHandle ("setPurgeableState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubImageWithFeatureChannelRange_X = "subImageWithFeatureChannelRange:";
		static readonly NativeHandle selSubImageWithFeatureChannelRange_XHandle = Selector.GetHandle ("subImageWithFeatureChannelRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeOnCommandBuffer_X = "synchronizeOnCommandBuffer:";
		static readonly NativeHandle selSynchronizeOnCommandBuffer_XHandle = Selector.GetHandle ("synchronizeOnCommandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureX = "texture";
		static readonly NativeHandle selTextureXHandle = Selector.GetHandle ("texture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureTypeX = "textureType";
		static readonly NativeHandle selTextureTypeXHandle = Selector.GetHandle ("textureType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsageX = "usage";
		static readonly NativeHandle selUsageXHandle = Selector.GetHandle ("usage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWidthX = "width";
		static readonly NativeHandle selWidthXHandle = Selector.GetHandle ("width");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_X = "writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";
		static readonly NativeHandle selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle = Selector.GetHandle ("writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_X = "writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";
		static readonly NativeHandle selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle = Selector.GetHandle ("writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_X = "writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:";
		static readonly NativeHandle selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle = Selector.GetHandle ("writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteBytes_DataLayout_ImageIndex_X = "writeBytes:dataLayout:imageIndex:";
		static readonly NativeHandle selWriteBytes_DataLayout_ImageIndex_XHandle = Selector.GetHandle ("writeBytes:dataLayout:imageIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSImage");
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
		protected MPSImage (NSObjectFlag t) : base (t)
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
		protected internal MPSImage (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="imageDescriptor">To be added.</param><summary>Creates a new <see cref="T:MetalPerformanceShaders.MPSImage" /> for the specified <paramref name="device" /> with the specified <paramref name="imageDescriptor" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:imageDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSImage (global::Metal.IMTLDevice device, MPSImageDescriptor imageDescriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var imageDescriptor__handle__ = imageDescriptor!.GetNonNullHandle (nameof (imageDescriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_ImageDescriptor_XHandle, device__handle__, imageDescriptor__handle__), "initWithDevice:imageDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_ImageDescriptor_XHandle, device__handle__, imageDescriptor__handle__), "initWithDevice:imageDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (imageDescriptor);
		}
		/// <param name="parent">To be added.</param><param name="sliceRange">To be added.</param><param name="featureChannels">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithParentImage:sliceRange:featureChannels:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSImage (MPSImage parent, NSRange sliceRange, nuint featureChannels)
			: base (NSObjectFlag.Empty)
		{
			var parent__handle__ = parent!.GetNonNullHandle (nameof (parent));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_UIntPtr (this.Handle, selInitWithParentImage_SliceRange_FeatureChannels_XHandle, parent__handle__, sliceRange, featureChannels), "initWithParentImage:sliceRange:featureChannels:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange_UIntPtr (&__objc_super__, selInitWithParentImage_SliceRange_FeatureChannels_XHandle, parent__handle__, sliceRange, featureChannels), "initWithParentImage:sliceRange:featureChannels:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parent);
		}
		/// <param name="texture">To be added.</param><param name="featureChannels">To be added.</param><summary>Creates a new <see cref="T:MetalPerformanceShaders.MPSImage" /> from the specified <paramref name="texture" /> with the specified <paramref name="featureChannels" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithTexture:featureChannels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSImage (global::Metal.IMTLTexture texture, nuint featureChannels)
			: base (NSObjectFlag.Empty)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInitWithTexture_FeatureChannels_XHandle, texture__handle__, featureChannels), "initWithTexture:featureChannels:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInitWithTexture_FeatureChannels_XHandle, texture__handle__, featureChannels), "initWithTexture:featureChannels:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
		}
		/// <param name="subRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("batchRepresentationWithSubRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> GetBatchRepresentation (NSRange subRange)
		{
			NSArray<MPSImage> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selBatchRepresentationWithSubRange_XHandle, subRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selBatchRepresentationWithSubRange_XHandle, subRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="featureChannelRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("subImageWithFeatureChannelRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage GetSubImage (NSRange featureChannelRange)
		{
			MPSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selSubImageWithFeatureChannelRange_XHandle, featureChannelRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selSubImageWithFeatureChannelRange_XHandle, featureChannelRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadBytes (nint dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, global::Metal.MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (this.Handle, selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (&__objc_super__, selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadBytes (nint dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, nuint bytesPerImage, global::Metal.MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (this.Handle, selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (&__objc_super__, selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("readBytes:dataLayout:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadBytes (nint dataBytes, MPSDataLayout dataLayout, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, selReadBytes_DataLayout_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr (&__objc_super__, selReadBytes_DataLayout_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="state">To be added.</param><summary>Sets the purgeable state of the underlying texture for the image.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setPurgeableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSPurgeableState SetPurgeableState (MPSPurgeableState state)
		{
			MPSPurgeableState ret;
			if (IsDirectBinding) {
				ret = (MetalPerformanceShaders.MPSPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selSetPurgeableState_XHandle, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (MetalPerformanceShaders.MPSPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPurgeableState_XHandle, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("synchronizeOnCommandBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Synchronize (global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSynchronizeOnCommandBuffer_XHandle, commandBuffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSynchronizeOnCommandBuffer_XHandle, commandBuffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		[Export ("writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteBytes (nint dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, global::Metal.MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (this.Handle, selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (&__objc_super__, selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteBytes (nint dataBytes, MPSDataLayout dataLayout, nuint bytesPerColumn, nuint bytesPerRow, nuint bytesPerImage, global::Metal.MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (this.Handle, selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerColumn, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (&__objc_super__, selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerColumn, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteBytes (nint dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, nuint bytesPerImage, global::Metal.MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (this.Handle, selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_UIntPtr_MTLRegion_MPSImageReadWriteParams_UIntPtr (&__objc_super__, selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("writeBytes:dataLayout:imageIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteBytes (nint dataBytes, MPSDataLayout dataLayout, nuint imageIndex)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (this.Handle, selWriteBytes_DataLayout_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, imageIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr (&__objc_super__, selWriteBytes_DataLayout_ImageIndex_XHandle, dataBytes, (UIntPtr) (ulong) dataLayout, imageIndex);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSArray<MPSImage> BatchRepresentation {
			[Export ("batchRepresentation")]
			get {
				NSArray<MPSImage>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBatchRepresentationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBatchRepresentationXHandle), false)!;
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
		public static IMPSImageAllocator DefaultAllocator {
			[Export ("defaultAllocator")]
			get {
				IMPSImageAllocator? ret;
				ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultAllocatorXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the Metal device for the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLDevice Device {
			[Export ("device", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MPSImageFeatureChannelFormat FeatureChannelFormat {
			[Export ("featureChannelFormat")]
			get {
				MPSImageFeatureChannelFormat ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageFeatureChannelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFeatureChannelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageFeatureChannelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFeatureChannelFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of feature channels for the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FeatureChannels {
			[Export ("featureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the height of the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Height {
			[Export ("height")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the image object's label.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the number of images in a batch of images for processing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfImages {
			[Export ("numberOfImages")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfImagesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfImagesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPSImage? Parent {
			[Export ("parent", ArgumentSemantic.Retain)]
			get {
				MPSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets pixel format of the image texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLPixelFormat PixelFormat {
			[Export ("pixelFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				if (IsDirectBinding) {
					ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPixelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPixelFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of bytes that are between the start of each pixel and the start of the next sequential pixel. (The stride for one pixel, in bytes.)</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PixelSize {
			[Export ("pixelSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPixelSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPixelSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the number of bits of precision for each feature channel.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Precision {
			[Export ("precision")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrecisionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrecisionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint ResourceSize {
			[Export ("resourceSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selResourceSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selResourceSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the underlying texture for the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLTexture Texture {
			[Export ("texture")]
			get {
				global::Metal.IMTLTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextureXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextureXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the type of the underlying texture for the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLTextureType TextureType {
			[Export ("textureType")]
			get {
				global::Metal.MTLTextureType ret;
				if (IsDirectBinding) {
					ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTextureTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTextureTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the intended use of the image's underlying texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLTextureUsage Usage {
			[Export ("usage")]
			get {
				global::Metal.MTLTextureUsage ret;
				if (IsDirectBinding) {
					ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUsageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUsageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the height of the image.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Width {
			[Export ("width")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSImage */
}
