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
namespace MetalFX {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4FXFrameInterpolator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Protocol (Name = "MTL4FXFrameInterpolator", WrapperType = typeof (MTL4FXFrameInterpolatorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeToCommandBuffer:", ParameterType = new Type [] { typeof (IMTL4CommandBuffer) }, ParameterByRef = new bool [] { false })]
	public partial interface IMTL4FXFrameInterpolator : INativeObject, IDisposable, 
		MetalFX.IMTLFXFrameInterpolatorBase
	{
		[global::Foundation.RequiredMember]
		[Export ("encodeToCommandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTL4CommandBuffer commandBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Encode (IMTL4FXFrameInterpolator This, global::Metal.IMTL4CommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeToCommandBuffer:"), commandBuffer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
		}
		[DynamicDependencyAttribute ("Encode(Metal.IMTL4CommandBuffer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4FXFrameInterpolatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4FXFrameInterpolator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4FXFrameInterpolatorWrapper : BaseWrapper, IMTL4FXFrameInterpolator {
		public MTL4FXFrameInterpolatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4FXFrameInterpolatorWrapper))]
		static MTL4FXFrameInterpolatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("encodeToCommandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Encode (global::Metal.IMTL4CommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:"), commandBuffer__handle__);
			GC.KeepAlive (commandBuffer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLTextureUsage ColorTextureUsage {
			[Export ("colorTextureUsage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLTextureUsage OutputTextureUsage {
			[Export ("outputTextureUsage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLTextureUsage DepthTextureUsage {
			[Export ("depthTextureUsage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depthTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLTextureUsage MotionTextureUsage {
			[Export ("motionTextureUsage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("motionTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLTextureUsage UITextureUsage {
			[Export ("uiTextureUsage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uiTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLPixelFormat ColorTextureFormat {
			[Export ("colorTextureFormat")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLPixelFormat DepthTextureFormat {
			[Export ("depthTextureFormat")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depthTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLPixelFormat MotionTextureFormat {
			[Export ("motionTextureFormat")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("motionTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLPixelFormat OutputTextureFormat {
			[Export ("outputTextureFormat")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint InputWidth {
			[Export ("inputWidth")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint InputHeight {
			[Export ("inputHeight")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputHeight"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint OutputWidth {
			[Export ("outputWidth")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint OutputHeight {
			[Export ("outputHeight")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputHeight"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.MTLPixelFormat UITextureFormat {
			[Export ("uiTextureFormat")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uiTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? ColorTexture {
			[Export ("colorTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colorTexture")), false)!;
				return ret;
			}
			[Export ("setColorTexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColorTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? PrevColorTexture {
			[Export ("prevColorTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("prevColorTexture")), false)!;
				return ret;
			}
			[Export ("setPrevColorTexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrevColorTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? DepthTexture {
			[Export ("depthTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("depthTexture")), false)!;
				return ret;
			}
			[Export ("setDepthTexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDepthTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? MotionTexture {
			[Export ("motionTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("motionTexture")), false)!;
				return ret;
			}
			[Export ("setMotionTexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMotionTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float MotionVectorScaleX {
			[Export ("motionVectorScaleX")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("motionVectorScaleX"));
				return ret;
			}
			[Export ("setMotionVectorScaleX:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMotionVectorScaleX:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float MotionVectorScaleY {
			[Export ("motionVectorScaleY")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("motionVectorScaleY"));
				return ret;
			}
			[Export ("setMotionVectorScaleY:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMotionVectorScaleY:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float DeltaTime {
			[Export ("deltaTime")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("deltaTime"));
				return ret;
			}
			[Export ("setDeltaTime:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDeltaTime:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float NearPlane {
			[Export ("nearPlane")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("nearPlane"));
				return ret;
			}
			[Export ("setNearPlane:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setNearPlane:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float FarPlane {
			[Export ("farPlane")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("farPlane"));
				return ret;
			}
			[Export ("setFarPlane:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFarPlane:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float FieldOfView {
			[Export ("fieldOfView")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("fieldOfView"));
				return ret;
			}
			[Export ("setFieldOfView:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFieldOfView:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float AspectRatio {
			[Export ("aspectRatio")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("aspectRatio"));
				return ret;
			}
			[Export ("setAspectRatio:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? UiTexture {
			[Export ("uiTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("uiTexture")), false)!;
				return ret;
			}
			[Export ("setUITexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUITexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float JitterOffsetX {
			[Export ("jitterOffsetX")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("jitterOffsetX"));
				return ret;
			}
			[Export ("setJitterOffsetX:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setJitterOffsetX:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public float JitterOffsetY {
			[Export ("jitterOffsetY")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("jitterOffsetY"));
				return ret;
			}
			[Export ("setJitterOffsetY:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setJitterOffsetY:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool UITextureComposited {
			[Export ("isUITextureComposited")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUITextureComposited"));
				return ret != 0;
			}
			[Export ("setIsUITextureComposited:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsUITextureComposited:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool ShouldResetHistory {
			[Export ("shouldResetHistory")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldResetHistory"));
				return ret != 0;
			}
			[Export ("setShouldResetHistory:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldResetHistory:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLTexture? OutputTexture {
			[Export ("outputTexture", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputTexture")), false)!;
				return ret;
			}
			[Export ("setOutputTexture:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOutputTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::Metal.IMTLFence? Fence {
			[Export ("fence", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::Metal.IMTLFence ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fence")), false)!;
				return ret;
			}
			[Export ("setFence:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFence:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool DepthReversed {
			[Export ("isDepthReversed")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDepthReversed"));
				return ret != 0;
			}
			[Export ("setDepthReversed:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDepthReversed:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
