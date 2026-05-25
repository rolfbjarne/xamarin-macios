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
	/// <summary>This interface represents the Objective-C protocol <c>MTLFXSpatialScaler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos18.4")]
	[Protocol (Name = "MTLFXSpatialScaler", WrapperType = typeof (MTLFXSpatialScalerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeToCommandBuffer:", ParameterType = new Type [] { typeof (IMTLCommandBuffer) }, ParameterByRef = new bool [] { false })]
	public partial interface IMTLFXSpatialScaler : INativeObject, IDisposable, 
		MetalFX.IMTLFXSpatialScalerBase
	{
		[global::Foundation.RequiredMember]
		[Export ("encodeToCommandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer commandBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Encode (IMTLFXSpatialScaler This, global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeToCommandBuffer:"), commandBuffer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
		}
		[DynamicDependencyAttribute ("Encode(Metal.IMTLCommandBuffer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXSpatialScalerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFXSpatialScaler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFXSpatialScalerWrapper : BaseWrapper, IMTLFXSpatialScaler {
		public MTLFXSpatialScalerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXSpatialScalerWrapper))]
		static MTLFXSpatialScalerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("encodeToCommandBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Encode (global::Metal.IMTLCommandBuffer commandBuffer)
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
		public nuint InputContentWidth {
			[Export ("inputContentWidth")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentWidth"));
				return ret;
			}
			[Export ("setInputContentWidth:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setInputContentWidth:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint InputContentHeight {
			[Export ("inputContentHeight")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentHeight"));
				return ret;
			}
			[Export ("setInputContentHeight:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setInputContentHeight:"), value);
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
		public MTLFXSpatialScalerColorProcessingMode ColorProcessingMode {
			[Export ("colorProcessingMode")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLFXSpatialScalerColorProcessingMode ret;
				ret = (MetalFX.MTLFXSpatialScalerColorProcessingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorProcessingMode"));
				return ret!;
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
	}
}
