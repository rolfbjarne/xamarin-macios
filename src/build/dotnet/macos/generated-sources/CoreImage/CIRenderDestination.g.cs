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
namespace CoreImage {
	[Register("CIRenderDestination", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CIRenderDestination : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaModeX = "alphaMode";
		static readonly NativeHandle selAlphaModeXHandle = Selector.GetHandle ("alphaMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendKernelX = "blendKernel";
		static readonly NativeHandle selBlendKernelXHandle = Selector.GetHandle ("blendKernel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendsInDestinationColorSpaceX = "blendsInDestinationColorSpace";
		static readonly NativeHandle selBlendsInDestinationColorSpaceXHandle = Selector.GetHandle ("blendsInDestinationColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptureTraceURLX = "captureTraceURL";
		static readonly NativeHandle selCaptureTraceURLXHandle = Selector.GetHandle ("captureTraceURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceX = "colorSpace";
		static readonly NativeHandle selColorSpaceXHandle = Selector.GetHandle ("colorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeightX = "height";
		static readonly NativeHandle selHeightXHandle = Selector.GetHandle ("height");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBitmapData_Width_Height_BytesPerRow_Format_X = "initWithBitmapData:width:height:bytesPerRow:format:";
		static readonly NativeHandle selInitWithBitmapData_Width_Height_BytesPerRow_Format_XHandle = Selector.GetHandle ("initWithBitmapData:width:height:bytesPerRow:format:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithGLTexture_Target_Width_Height_X = "initWithGLTexture:target:width:height:";
		static readonly NativeHandle selInitWithGLTexture_Target_Width_Height_XHandle = Selector.GetHandle ("initWithGLTexture:target:width:height:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithIOSurface_X = "initWithIOSurface:";
		static readonly NativeHandle selInitWithIOSurface_XHandle = Selector.GetHandle ("initWithIOSurface:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMTLTexture_CommandBuffer_X = "initWithMTLTexture:commandBuffer:";
		static readonly NativeHandle selInitWithMTLTexture_CommandBuffer_XHandle = Selector.GetHandle ("initWithMTLTexture:commandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPixelBuffer_X = "initWithPixelBuffer:";
		static readonly NativeHandle selInitWithPixelBuffer_XHandle = Selector.GetHandle ("initWithPixelBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_X = "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:";
		static readonly NativeHandle selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_XHandle = Selector.GetHandle ("initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsClampedX = "isClamped";
		static readonly NativeHandle selIsClampedXHandle = Selector.GetHandle ("isClamped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDitheredX = "isDithered";
		static readonly NativeHandle selIsDitheredXHandle = Selector.GetHandle ("isDithered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFlippedX = "isFlipped";
		static readonly NativeHandle selIsFlippedXHandle = Selector.GetHandle ("isFlipped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlphaMode_X = "setAlphaMode:";
		static readonly NativeHandle selSetAlphaMode_XHandle = Selector.GetHandle ("setAlphaMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlendKernel_X = "setBlendKernel:";
		static readonly NativeHandle selSetBlendKernel_XHandle = Selector.GetHandle ("setBlendKernel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlendsInDestinationColorSpace_X = "setBlendsInDestinationColorSpace:";
		static readonly NativeHandle selSetBlendsInDestinationColorSpace_XHandle = Selector.GetHandle ("setBlendsInDestinationColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCaptureTraceURL_X = "setCaptureTraceURL:";
		static readonly NativeHandle selSetCaptureTraceURL_XHandle = Selector.GetHandle ("setCaptureTraceURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClamped_X = "setClamped:";
		static readonly NativeHandle selSetClamped_XHandle = Selector.GetHandle ("setClamped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorSpace_X = "setColorSpace:";
		static readonly NativeHandle selSetColorSpace_XHandle = Selector.GetHandle ("setColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDithered_X = "setDithered:";
		static readonly NativeHandle selSetDithered_XHandle = Selector.GetHandle ("setDithered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFlipped_X = "setFlipped:";
		static readonly NativeHandle selSetFlipped_XHandle = Selector.GetHandle ("setFlipped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWidthX = "width";
		static readonly NativeHandle selWidthXHandle = Selector.GetHandle ("width");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIRenderDestination");
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
		protected CIRenderDestination (NSObjectFlag t) : base (t)
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
		protected internal CIRenderDestination (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="pixelBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPixelBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRenderDestination (global::CoreVideo.CVPixelBuffer pixelBuffer)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPixelBuffer_XHandle, pixelBuffer__handle__), "initWithPixelBuffer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPixelBuffer_XHandle, pixelBuffer__handle__), "initWithPixelBuffer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
		}
		/// <param name="surface">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithIOSurface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRenderDestination (global::IOSurface.IOSurface surface)
			: base (NSObjectFlag.Empty)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithIOSurface_XHandle, surface__handle__), "initWithIOSurface:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithIOSurface_XHandle, surface__handle__), "initWithIOSurface:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (surface);
		}
		/// <param name="texture">To be added.</param><param name="commandBuffer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithMTLTexture:commandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRenderDestination (global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer? commandBuffer)
			: base (NSObjectFlag.Empty)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var commandBuffer__handle__ = commandBuffer.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithMTLTexture_CommandBuffer_XHandle, texture__handle__, commandBuffer__handle__), "initWithMTLTexture:commandBuffer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithMTLTexture_CommandBuffer_XHandle, texture__handle__, commandBuffer__handle__), "initWithMTLTexture:commandBuffer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
			GC.KeepAlive (commandBuffer);
		}
		/// <param name="width">To be added.</param><param name="height">To be added.</param><param name="pixelFormat">To be added.</param><param name="commandBuffer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CIRenderDestination (nuint width, nuint height, global::Metal.MTLPixelFormat pixelFormat, global::Metal.IMTLCommandBuffer? commandBuffer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V2))]global::System.Func<global::Metal.IMTLTexture>? block)
			: base (NSObjectFlag.Empty)
		{
			var commandBuffer__handle__ = commandBuffer.GetHandle ();
			using var block_block = Trampolines.SDFuncArity1V2.CreateNullableBlock (block);
			BlockLiteral *block_ptr_block = null;
			if (block is not null)
				block_ptr_block = &block_block;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle (this.Handle, selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_XHandle, width, height, (UIntPtr) (ulong) pixelFormat, commandBuffer__handle__, (IntPtr) block_ptr_block), "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_XHandle, width, height, (UIntPtr) (ulong) pixelFormat, commandBuffer__handle__, (IntPtr) block_ptr_block), "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		/// <param name="texture">To be added.</param><param name="target">To be added.</param><param name="width">To be added.</param><param name="height">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithGLTexture:target:width:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRenderDestination (uint texture, uint target, nuint width, nuint height)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_UInt32_UIntPtr_UIntPtr (this.Handle, selInitWithGLTexture_Target_Width_Height_XHandle, texture, target, width, height), "initWithGLTexture:target:width:height:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32_UInt32_UIntPtr_UIntPtr (&__objc_super__, selInitWithGLTexture_Target_Width_Height_XHandle, texture, target, width, height), "initWithGLTexture:target:width:height:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithBitmapData:width:height:bytesPerRow:format:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRenderDestination (nint data, nuint width, nuint height, nuint bytesPerRow, CIFormat format)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_int (this.Handle, selInitWithBitmapData_Width_Height_BytesPerRow_Format_XHandle, data, width, height, bytesPerRow, (int)format), "initWithBitmapData:width:height:bytesPerRow:format:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_UIntPtr_UIntPtr_UIntPtr_int (&__objc_super__, selInitWithBitmapData_Width_Height_BytesPerRow_Format_XHandle, data, width, height, bytesPerRow, (int)format), "initWithBitmapData:width:height:bytesPerRow:format:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIRenderDestinationAlphaMode AlphaMode {
			[Export ("alphaMode", ArgumentSemantic.Assign)]
			get {
				CIRenderDestinationAlphaMode ret;
				if (IsDirectBinding) {
					ret = (CIRenderDestinationAlphaMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAlphaModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CIRenderDestinationAlphaMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAlphaModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlphaMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAlphaMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAlphaMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIBlendKernel? BlendKernel {
			[Export ("blendKernel", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBlendKernelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBlendKernelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBlendKernel:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBlendKernel_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBlendKernel_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BlendsInDestinationColorSpace {
			[Export ("blendsInDestinationColorSpace")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBlendsInDestinationColorSpaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBlendsInDestinationColorSpaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBlendsInDestinationColorSpace:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBlendsInDestinationColorSpace_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBlendsInDestinationColorSpace_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual NSUrl? CaptureTraceUrl {
			[Export ("captureTraceURL", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCaptureTraceURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCaptureTraceURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCaptureTraceURL:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCaptureTraceURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCaptureTraceURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Clamped {
			[Export ("isClamped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsClampedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsClampedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClamped:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClamped_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetClamped_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColorSpace? ColorSpace {
			[Export ("colorSpace", ArgumentSemantic.Assign)]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorSpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorSpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorSpace:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorSpace_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorSpace_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Dithered {
			[Export ("isDithered")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDitheredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDitheredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDithered:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDithered_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDithered_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Flipped {
			[Export ("isFlipped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFlippedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFlippedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFlipped:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFlipped_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFlipped_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
	} /* class CIRenderDestination */
}
