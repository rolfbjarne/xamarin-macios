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
namespace Cinematic {
	[Register("CNRenderingSession", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	public unsafe partial class CNRenderingSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandQueueX = "commandQueue";
		static readonly NativeHandle selCommandQueueXHandle = Selector.GetHandle ("commandQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationPixelFormatTypesX = "destinationPixelFormatTypes";
		static readonly NativeHandle selDestinationPixelFormatTypesXHandle = Selector.GetHandle ("destinationPixelFormatTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationImage_X = "encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationImage:";
		static readonly NativeHandle selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationImage_XHandle = Selector.GetHandle ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationLuma_DestinationChroma_X = "encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationLuma:destinationChroma:";
		static readonly NativeHandle selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationLuma_DestinationChroma_XHandle = Selector.GetHandle ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationLuma:destinationChroma:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationRGBA_X = "encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationRGBA:";
		static readonly NativeHandle selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationRGBA_XHandle = Selector.GetHandle ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationRGBA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCommandQueue_SessionAttributes_PreferredTransform_Quality_X = "initWithCommandQueue:sessionAttributes:preferredTransform:quality:";
		static readonly NativeHandle selInitWithCommandQueue_SessionAttributes_PreferredTransform_Quality_XHandle = Selector.GetHandle ("initWithCommandQueue:sessionAttributes:preferredTransform:quality:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredTransformX = "preferredTransform";
		static readonly NativeHandle selPreferredTransformXHandle = Selector.GetHandle ("preferredTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQualityX = "quality";
		static readonly NativeHandle selQualityXHandle = Selector.GetHandle ("quality");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSessionAttributesX = "sessionAttributes";
		static readonly NativeHandle selSessionAttributesXHandle = Selector.GetHandle ("sessionAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourcePixelFormatTypesX = "sourcePixelFormatTypes";
		static readonly NativeHandle selSourcePixelFormatTypesXHandle = Selector.GetHandle ("sourcePixelFormatTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CNRenderingSession");
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
		protected CNRenderingSession (NSObjectFlag t) : base (t)
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
		protected internal CNRenderingSession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCommandQueue:sessionAttributes:preferredTransform:quality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CNRenderingSession (global::Metal.IMTLCommandQueue commandQueue, CNRenderingSessionAttributes sessionAttributes, CGAffineTransform preferredTransform, CNRenderingQuality quality)
			: base (NSObjectFlag.Empty)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var sessionAttributes__handle__ = sessionAttributes!.GetNonNullHandle (nameof (sessionAttributes));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGAffineTransform_IntPtr (this.Handle, selInitWithCommandQueue_SessionAttributes_PreferredTransform_Quality_XHandle, commandQueue__handle__, sessionAttributes__handle__, preferredTransform, (IntPtr) (long) quality), "initWithCommandQueue:sessionAttributes:preferredTransform:quality:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_CGAffineTransform_IntPtr (&__objc_super__, selInitWithCommandQueue_SessionAttributes_PreferredTransform_Quality_XHandle, commandQueue__handle__, sessionAttributes__handle__, preferredTransform, (IntPtr) (long) quality), "initWithCommandQueue:sessionAttributes:preferredTransform:quality:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (sessionAttributes);
		}
		[Export ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EncodeRender (global::Metal.IMTLCommandBuffer commandBuffer, CNRenderingSessionFrameAttributes frameAttributes, global::CoreVideo.CVPixelBuffer sourceImage, global::CoreVideo.CVPixelBuffer sourceDisparity, global::CoreVideo.CVPixelBuffer destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var frameAttributes__handle__ = frameAttributes!.GetNonNullHandle (nameof (frameAttributes));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceDisparity__handle__ = sourceDisparity!.GetNonNullHandle (nameof (sourceDisparity));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationImage_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationImage_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (frameAttributes);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceDisparity);
			GC.KeepAlive (destinationImage);
			return ret != 0;
		}
		[Export ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationRGBA:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EncodeRender (global::Metal.IMTLCommandBuffer commandBuffer, CNRenderingSessionFrameAttributes frameAttributes, global::CoreVideo.CVPixelBuffer sourceImage, global::CoreVideo.CVPixelBuffer sourceDisparity, global::Metal.IMTLTexture destinationRgba)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var frameAttributes__handle__ = frameAttributes!.GetNonNullHandle (nameof (frameAttributes));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceDisparity__handle__ = sourceDisparity!.GetNonNullHandle (nameof (sourceDisparity));
			var destinationRgba__handle__ = destinationRgba!.GetNonNullHandle (nameof (destinationRgba));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationRGBA_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationRgba__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationRGBA_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationRgba__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (frameAttributes);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceDisparity);
			GC.KeepAlive (destinationRgba);
			return ret != 0;
		}
		[Export ("encodeRenderToCommandBuffer:frameAttributes:sourceImage:sourceDisparity:destinationLuma:destinationChroma:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EncodeRender (global::Metal.IMTLCommandBuffer commandBuffer, CNRenderingSessionFrameAttributes frameAttributes, global::CoreVideo.CVPixelBuffer sourceImage, global::CoreVideo.CVPixelBuffer sourceDisparity, global::Metal.IMTLTexture destinationLuma, global::Metal.IMTLTexture destinationChroma)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var frameAttributes__handle__ = frameAttributes!.GetNonNullHandle (nameof (frameAttributes));
			var sourceImage__handle__ = sourceImage!.GetNonNullHandle (nameof (sourceImage));
			var sourceDisparity__handle__ = sourceDisparity!.GetNonNullHandle (nameof (sourceDisparity));
			var destinationLuma__handle__ = destinationLuma!.GetNonNullHandle (nameof (destinationLuma));
			var destinationChroma__handle__ = destinationChroma!.GetNonNullHandle (nameof (destinationChroma));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationLuma_DestinationChroma_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationLuma__handle__, destinationChroma__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeRenderToCommandBuffer_FrameAttributes_SourceImage_SourceDisparity_DestinationLuma_DestinationChroma_XHandle, commandBuffer__handle__, frameAttributes__handle__, sourceImage__handle__, sourceDisparity__handle__, destinationLuma__handle__, destinationChroma__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (frameAttributes);
			GC.KeepAlive (sourceImage);
			GC.KeepAlive (sourceDisparity);
			GC.KeepAlive (destinationLuma);
			GC.KeepAlive (destinationChroma);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLCommandQueue CommandQueue {
			[Export ("commandQueue", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLCommandQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommandQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommandQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] DestinationPixelFormatTypes {
			[Export ("destinationPixelFormatTypes", ArgumentSemantic.Retain)]
			get {
				NSNumber[]? ret;
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationPixelFormatTypesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform PreferredTransform {
			[Export ("preferredTransform")]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, selPreferredTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, selPreferredTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, selPreferredTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, selPreferredTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNRenderingQuality Quality {
			[Export ("quality")]
			get {
				CNRenderingQuality ret;
				if (IsDirectBinding) {
					ret = (Cinematic.CNRenderingQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selQualityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Cinematic.CNRenderingQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selQualityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNRenderingSessionAttributes SessionAttributes {
			[Export ("sessionAttributes", ArgumentSemantic.Retain)]
			get {
				CNRenderingSessionAttributes? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CNRenderingSessionAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSessionAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CNRenderingSessionAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSessionAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] SourcePixelFormatTypes {
			[Export ("sourcePixelFormatTypes", ArgumentSemantic.Retain)]
			get {
				NSNumber[]? ret;
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourcePixelFormatTypesXHandle), false)!;
				return ret!;
			}
		}
	} /* class CNRenderingSession */
}
