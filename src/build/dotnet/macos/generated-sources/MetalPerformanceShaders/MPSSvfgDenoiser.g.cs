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
	[Register("MPSSVGFDenoiser", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSSvfgDenoiser : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBilateralFilterIterationsX = "bilateralFilterIterations";
		static readonly NativeHandle selBilateralFilterIterationsXHandle = Selector.GetHandle ("bilateralFilterIterations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearTemporalHistoryX = "clearTemporalHistory";
		static readonly NativeHandle selClearTemporalHistoryXHandle = Selector.GetHandle ("clearTemporalHistory");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceTexture_DestinationTexture_SourceTexture2_DestinationTexture2_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_X = "encodeToCommandBuffer:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceTexture_DestinationTexture_SourceTexture2_DestinationTexture2_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_SourceTexture_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_X = "encodeToCommandBuffer:sourceTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:";
		static readonly NativeHandle selEncodeToCommandBuffer_SourceTexture_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle = Selector.GetHandle ("encodeToCommandBuffer:sourceTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_X = "initWithDevice:";
		static readonly NativeHandle selInitWithDevice_XHandle = Selector.GetHandle ("initWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSVGF_TextureAllocator_X = "initWithSVGF:textureAllocator:";
		static readonly NativeHandle selInitWithSVGF_TextureAllocator_XHandle = Selector.GetHandle ("initWithSVGF:textureAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseTemporaryTexturesX = "releaseTemporaryTextures";
		static readonly NativeHandle selReleaseTemporaryTexturesXHandle = Selector.GetHandle ("releaseTemporaryTextures");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBilateralFilterIterations_X = "setBilateralFilterIterations:";
		static readonly NativeHandle selSetBilateralFilterIterations_XHandle = Selector.GetHandle ("setBilateralFilterIterations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSvgfX = "svgf";
		static readonly NativeHandle selSvgfXHandle = Selector.GetHandle ("svgf");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureAllocatorX = "textureAllocator";
		static readonly NativeHandle selTextureAllocatorXHandle = Selector.GetHandle ("textureAllocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSSVGFDenoiser");
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
		protected MPSSvfgDenoiser (NSObjectFlag t) : base (t)
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
		protected internal MPSSvfgDenoiser (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSSvfgDenoiser (global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("initWithSVGF:textureAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSSvfgDenoiser (MPSSvgf svgf, IMPSSvgfTextureAllocator textureAllocator)
			: base (NSObjectFlag.Empty)
		{
			var svgf__handle__ = svgf!.GetNonNullHandle (nameof (svgf));
			var textureAllocator__handle__ = textureAllocator!.GetNonNullHandle (nameof (textureAllocator));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithSVGF_TextureAllocator_XHandle, svgf__handle__, textureAllocator__handle__), "initWithSVGF:textureAllocator:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithSVGF_TextureAllocator_XHandle, svgf__handle__, textureAllocator__handle__), "initWithSVGF:textureAllocator:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (svgf);
			GC.KeepAlive (textureAllocator);
		}
		[Export ("clearTemporalHistory")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearTemporalHistory ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearTemporalHistoryXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClearTemporalHistoryXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("encodeToCommandBuffer:sourceTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLTexture Encode (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture? motionVectorTexture, global::Metal.IMTLTexture depthNormalTexture, global::Metal.IMTLTexture? previousDepthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var motionVectorTexture__handle__ = motionVectorTexture.GetHandle ();
			var depthNormalTexture__handle__ = depthNormalTexture!.GetNonNullHandle (nameof (depthNormalTexture));
			var previousDepthNormalTexture__handle__ = previousDepthNormalTexture.GetHandle ();
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceTexture_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle, commandBuffer__handle__, sourceTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceTexture_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle, commandBuffer__handle__, sourceTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (motionVectorTexture);
			GC.KeepAlive (depthNormalTexture);
			GC.KeepAlive (previousDepthNormalTexture);
			return ret!;
		}
		[Export ("encodeToCommandBuffer:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, out global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture? sourceTexture2, out global::Metal.IMTLTexture destinationTexture2, global::Metal.IMTLTexture? motionVectorTexture, global::Metal.IMTLTexture depthNormalTexture, global::Metal.IMTLTexture? previousDepthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var sourceTexture2__handle__ = sourceTexture2.GetHandle ();
			var motionVectorTexture__handle__ = motionVectorTexture.GetHandle ();
			var depthNormalTexture__handle__ = depthNormalTexture!.GetNonNullHandle (nameof (depthNormalTexture));
			var previousDepthNormalTexture__handle__ = previousDepthNormalTexture.GetHandle ();
			NativeHandle destinationTextureValue = IntPtr.Zero;
			NativeHandle destinationTexture2Value = IntPtr.Zero;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_SourceTexture_DestinationTexture_SourceTexture2_DestinationTexture2_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle, commandBuffer__handle__, sourceTexture__handle__, &destinationTextureValue, sourceTexture2__handle__, &destinationTexture2Value, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_SourceTexture_DestinationTexture_SourceTexture2_DestinationTexture2_MotionVectorTexture_DepthNormalTexture_PreviousDepthNormalTexture_XHandle, commandBuffer__handle__, sourceTexture__handle__, &destinationTextureValue, sourceTexture2__handle__, &destinationTexture2Value, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (sourceTexture2);
			GC.KeepAlive (motionVectorTexture);
			GC.KeepAlive (depthNormalTexture);
			GC.KeepAlive (previousDepthNormalTexture);
			destinationTexture = Runtime.GetINativeObject<IMTLTexture> (destinationTextureValue, false, false)!;
			destinationTexture2 = Runtime.GetINativeObject<IMTLTexture> (destinationTexture2Value, false, false)!;
		}
		[Export ("releaseTemporaryTextures")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseTemporaryTextures ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReleaseTemporaryTexturesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReleaseTemporaryTexturesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint BilateralFilterIterations {
			[Export ("bilateralFilterIterations")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selBilateralFilterIterationsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selBilateralFilterIterationsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBilateralFilterIterations:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetBilateralFilterIterations_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetBilateralFilterIterations_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSSvgf Svgf {
			[Export ("svgf")]
			get {
				MPSSvgf? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSSvgf> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSvgfXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSSvgf> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSvgfXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSSvgfTextureAllocator TextureAllocator {
			[Export ("textureAllocator")]
			get {
				IMPSSvgfTextureAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSSvgfTextureAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextureAllocatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSSvgfTextureAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextureAllocatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPSSvfgDenoiser */
}
