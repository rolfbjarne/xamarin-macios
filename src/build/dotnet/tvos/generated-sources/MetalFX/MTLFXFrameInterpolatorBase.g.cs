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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalFX {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLFXFrameInterpolatorBase</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Protocol (Name = "MTLFXFrameInterpolatorBase", WrapperType = typeof (MTLFXFrameInterpolatorBaseWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureUsage", Selector = "colorTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "colorTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureUsage", Selector = "outputTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "outputTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureUsage", Selector = "depthTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "depthTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureUsage", Selector = "motionTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "motionTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UITextureUsage", Selector = "uiTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "uiTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureFormat", Selector = "colorTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "colorTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureFormat", Selector = "depthTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "depthTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureFormat", Selector = "motionTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "motionTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureFormat", Selector = "outputTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "outputTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputWidth", Selector = "inputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputHeight", Selector = "inputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputWidth", Selector = "outputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "outputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputHeight", Selector = "outputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "outputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UITextureFormat", Selector = "uiTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "uiTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTexture", Selector = "colorTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "colorTexture", SetterSelector = "setColorTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PrevColorTexture", Selector = "prevColorTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "prevColorTexture", SetterSelector = "setPrevColorTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTexture", Selector = "depthTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "depthTexture", SetterSelector = "setDepthTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTexture", Selector = "motionTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "motionTexture", SetterSelector = "setMotionTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleX", Selector = "motionVectorScaleX", PropertyType = typeof (float), GetterSelector = "motionVectorScaleX", SetterSelector = "setMotionVectorScaleX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleY", Selector = "motionVectorScaleY", PropertyType = typeof (float), GetterSelector = "motionVectorScaleY", SetterSelector = "setMotionVectorScaleY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DeltaTime", Selector = "deltaTime", PropertyType = typeof (float), GetterSelector = "deltaTime", SetterSelector = "setDeltaTime:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NearPlane", Selector = "nearPlane", PropertyType = typeof (float), GetterSelector = "nearPlane", SetterSelector = "setNearPlane:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FarPlane", Selector = "farPlane", PropertyType = typeof (float), GetterSelector = "farPlane", SetterSelector = "setFarPlane:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FieldOfView", Selector = "fieldOfView", PropertyType = typeof (float), GetterSelector = "fieldOfView", SetterSelector = "setFieldOfView:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AspectRatio", Selector = "aspectRatio", PropertyType = typeof (float), GetterSelector = "aspectRatio", SetterSelector = "setAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UiTexture", Selector = "uiTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "uiTexture", SetterSelector = "setUITexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetX", Selector = "jitterOffsetX", PropertyType = typeof (float), GetterSelector = "jitterOffsetX", SetterSelector = "setJitterOffsetX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetY", Selector = "jitterOffsetY", PropertyType = typeof (float), GetterSelector = "jitterOffsetY", SetterSelector = "setJitterOffsetY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UITextureComposited", Selector = "uiTextureComposited", PropertyType = typeof (bool), GetterSelector = "isUITextureComposited", SetterSelector = "setIsUITextureComposited:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldResetHistory", Selector = "shouldResetHistory", PropertyType = typeof (bool), GetterSelector = "shouldResetHistory", SetterSelector = "setShouldResetHistory:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTexture", Selector = "outputTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "outputTexture", SetterSelector = "setOutputTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Fence", Selector = "fence", PropertyType = typeof (IMTLFence), GetterSelector = "fence", SetterSelector = "setFence:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthReversed", Selector = "depthReversed", PropertyType = typeof (bool), GetterSelector = "isDepthReversed", SetterSelector = "setDepthReversed:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLFXFrameInterpolatorBase : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AspectRatio")]
		[DynamicDependencyAttribute ("ColorTexture")]
		[DynamicDependencyAttribute ("ColorTextureFormat")]
		[DynamicDependencyAttribute ("ColorTextureUsage")]
		[DynamicDependencyAttribute ("DeltaTime")]
		[DynamicDependencyAttribute ("DepthReversed")]
		[DynamicDependencyAttribute ("DepthTexture")]
		[DynamicDependencyAttribute ("DepthTextureFormat")]
		[DynamicDependencyAttribute ("DepthTextureUsage")]
		[DynamicDependencyAttribute ("FarPlane")]
		[DynamicDependencyAttribute ("Fence")]
		[DynamicDependencyAttribute ("FieldOfView")]
		[DynamicDependencyAttribute ("InputHeight")]
		[DynamicDependencyAttribute ("InputWidth")]
		[DynamicDependencyAttribute ("JitterOffsetX")]
		[DynamicDependencyAttribute ("JitterOffsetY")]
		[DynamicDependencyAttribute ("MotionTexture")]
		[DynamicDependencyAttribute ("MotionTextureFormat")]
		[DynamicDependencyAttribute ("MotionTextureUsage")]
		[DynamicDependencyAttribute ("MotionVectorScaleX")]
		[DynamicDependencyAttribute ("MotionVectorScaleY")]
		[DynamicDependencyAttribute ("NearPlane")]
		[DynamicDependencyAttribute ("OutputHeight")]
		[DynamicDependencyAttribute ("OutputTexture")]
		[DynamicDependencyAttribute ("OutputTextureFormat")]
		[DynamicDependencyAttribute ("OutputTextureUsage")]
		[DynamicDependencyAttribute ("OutputWidth")]
		[DynamicDependencyAttribute ("PrevColorTexture")]
		[DynamicDependencyAttribute ("ShouldResetHistory")]
		[DynamicDependencyAttribute ("UiTexture")]
		[DynamicDependencyAttribute ("UITextureComposited")]
		[DynamicDependencyAttribute ("UITextureFormat")]
		[DynamicDependencyAttribute ("UITextureUsage")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXFrameInterpolatorBaseWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFXFrameInterpolatorBase ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage ColorTextureUsage {
			[Export ("colorTextureUsage")]
			get {
				return _GetColorTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetColorTextureUsage (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage OutputTextureUsage {
			[Export ("outputTextureUsage")]
			get {
				return _GetOutputTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetOutputTextureUsage (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage DepthTextureUsage {
			[Export ("depthTextureUsage")]
			get {
				return _GetDepthTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetDepthTextureUsage (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("depthTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage MotionTextureUsage {
			[Export ("motionTextureUsage")]
			get {
				return _GetMotionTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetMotionTextureUsage (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("motionTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage UITextureUsage {
			[Export ("uiTextureUsage")]
			get {
				return _GetUITextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetUITextureUsage (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("uiTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat ColorTextureFormat {
			[Export ("colorTextureFormat")]
			get {
				return _GetColorTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetColorTextureFormat (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat DepthTextureFormat {
			[Export ("depthTextureFormat")]
			get {
				return _GetDepthTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetDepthTextureFormat (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("depthTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat MotionTextureFormat {
			[Export ("motionTextureFormat")]
			get {
				return _GetMotionTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetMotionTextureFormat (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("motionTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat OutputTextureFormat {
			[Export ("outputTextureFormat")]
			get {
				return _GetOutputTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetOutputTextureFormat (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint InputWidth {
			[Export ("inputWidth")]
			get {
				return _GetInputWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetInputWidth (IMTLFXFrameInterpolatorBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint InputHeight {
			[Export ("inputHeight")]
			get {
				return _GetInputHeight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetInputHeight (IMTLFXFrameInterpolatorBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint OutputWidth {
			[Export ("outputWidth")]
			get {
				return _GetOutputWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetOutputWidth (IMTLFXFrameInterpolatorBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint OutputHeight {
			[Export ("outputHeight")]
			get {
				return _GetOutputHeight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetOutputHeight (IMTLFXFrameInterpolatorBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat UITextureFormat {
			[Export ("uiTextureFormat")]
			get {
				return _GetUITextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetUITextureFormat (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("uiTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? ColorTexture {
			[Export ("colorTexture", ArgumentSemantic.Retain)]
			get {
				return _GetColorTexture (this);
			}
			[Export ("setColorTexture:", ArgumentSemantic.Retain)]
			set {
				_SetColorTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetColorTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("colorTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? PrevColorTexture {
			[Export ("prevColorTexture", ArgumentSemantic.Retain)]
			get {
				return _GetPrevColorTexture (this);
			}
			[Export ("setPrevColorTexture:", ArgumentSemantic.Retain)]
			set {
				_SetPrevColorTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetPrevColorTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("prevColorTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPrevColorTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPrevColorTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? DepthTexture {
			[Export ("depthTexture", ArgumentSemantic.Retain)]
			get {
				return _GetDepthTexture (this);
			}
			[Export ("setDepthTexture:", ArgumentSemantic.Retain)]
			set {
				_SetDepthTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetDepthTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("depthTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDepthTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? MotionTexture {
			[Export ("motionTexture", ArgumentSemantic.Retain)]
			get {
				return _GetMotionTexture (this);
			}
			[Export ("setMotionTexture:", ArgumentSemantic.Retain)]
			set {
				_SetMotionTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetMotionTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("motionTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMotionTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MotionVectorScaleX {
			[Export ("motionVectorScaleX")]
			get {
				return _GetMotionVectorScaleX (this);
			}
			[Export ("setMotionVectorScaleX:")]
			set {
				_SetMotionVectorScaleX (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMotionVectorScaleX (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleX (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMotionVectorScaleX:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MotionVectorScaleY {
			[Export ("motionVectorScaleY")]
			get {
				return _GetMotionVectorScaleY (this);
			}
			[Export ("setMotionVectorScaleY:")]
			set {
				_SetMotionVectorScaleY (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMotionVectorScaleY (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleY (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMotionVectorScaleY:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float DeltaTime {
			[Export ("deltaTime")]
			get {
				return _GetDeltaTime (this);
			}
			[Export ("setDeltaTime:")]
			set {
				_SetDeltaTime (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetDeltaTime (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("deltaTime"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDeltaTime (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setDeltaTime:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float NearPlane {
			[Export ("nearPlane")]
			get {
				return _GetNearPlane (this);
			}
			[Export ("setNearPlane:")]
			set {
				_SetNearPlane (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetNearPlane (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("nearPlane"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNearPlane (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setNearPlane:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float FarPlane {
			[Export ("farPlane")]
			get {
				return _GetFarPlane (this);
			}
			[Export ("setFarPlane:")]
			set {
				_SetFarPlane (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetFarPlane (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("farPlane"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFarPlane (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setFarPlane:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float FieldOfView {
			[Export ("fieldOfView")]
			get {
				return _GetFieldOfView (this);
			}
			[Export ("setFieldOfView:")]
			set {
				_SetFieldOfView (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetFieldOfView (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("fieldOfView"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFieldOfView (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setFieldOfView:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float AspectRatio {
			[Export ("aspectRatio")]
			get {
				return _GetAspectRatio (this);
			}
			[Export ("setAspectRatio:")]
			set {
				_SetAspectRatio (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetAspectRatio (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("aspectRatio"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAspectRatio (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? UiTexture {
			[Export ("uiTexture", ArgumentSemantic.Retain)]
			get {
				return _GetUiTexture (this);
			}
			[Export ("setUITexture:", ArgumentSemantic.Retain)]
			set {
				_SetUiTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetUiTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("uiTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUiTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUITexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float JitterOffsetX {
			[Export ("jitterOffsetX")]
			get {
				return _GetJitterOffsetX (this);
			}
			[Export ("setJitterOffsetX:")]
			set {
				_SetJitterOffsetX (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetJitterOffsetX (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetX (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setJitterOffsetX:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float JitterOffsetY {
			[Export ("jitterOffsetY")]
			get {
				return _GetJitterOffsetY (this);
			}
			[Export ("setJitterOffsetY:")]
			set {
				_SetJitterOffsetY (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetJitterOffsetY (IMTLFXFrameInterpolatorBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetY (IMTLFXFrameInterpolatorBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setJitterOffsetY:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool UITextureComposited {
			[Export ("isUITextureComposited")]
			get {
				return _GetUITextureComposited (this);
			}
			[Export ("setIsUITextureComposited:")]
			set {
				_SetUITextureComposited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetUITextureComposited (IMTLFXFrameInterpolatorBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUITextureComposited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUITextureComposited (IMTLFXFrameInterpolatorBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsUITextureComposited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ShouldResetHistory {
			[Export ("shouldResetHistory")]
			get {
				return _GetShouldResetHistory (this);
			}
			[Export ("setShouldResetHistory:")]
			set {
				_SetShouldResetHistory (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShouldResetHistory (IMTLFXFrameInterpolatorBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldResetHistory"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetShouldResetHistory (IMTLFXFrameInterpolatorBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldResetHistory:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? OutputTexture {
			[Export ("outputTexture", ArgumentSemantic.Retain)]
			get {
				return _GetOutputTexture (this);
			}
			[Export ("setOutputTexture:", ArgumentSemantic.Retain)]
			set {
				_SetOutputTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetOutputTexture (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOutputTexture (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setOutputTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLFence? Fence {
			[Export ("fence", ArgumentSemantic.Retain)]
			get {
				return _GetFence (this);
			}
			[Export ("setFence:", ArgumentSemantic.Retain)]
			set {
				_SetFence (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLFence _GetFence (IMTLFXFrameInterpolatorBase This)
		{
			global::Metal.IMTLFence ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("fence")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFence (IMTLFXFrameInterpolatorBase This, global::Metal.IMTLFence? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFence:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool DepthReversed {
			[Export ("isDepthReversed")]
			get {
				return _GetDepthReversed (this);
			}
			[Export ("setDepthReversed:")]
			set {
				_SetDepthReversed (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDepthReversed (IMTLFXFrameInterpolatorBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDepthReversed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthReversed (IMTLFXFrameInterpolatorBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDepthReversed:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFXFrameInterpolatorBaseWrapper : BaseWrapper, IMTLFXFrameInterpolatorBase {
		public MTLFXFrameInterpolatorBaseWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXFrameInterpolatorBaseWrapper))]
		static MTLFXFrameInterpolatorBaseWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage ColorTextureUsage {
			[Export ("colorTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage OutputTextureUsage {
			[Export ("outputTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage DepthTextureUsage {
			[Export ("depthTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depthTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage MotionTextureUsage {
			[Export ("motionTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("motionTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage UITextureUsage {
			[Export ("uiTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uiTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat ColorTextureFormat {
			[Export ("colorTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat DepthTextureFormat {
			[Export ("depthTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depthTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat MotionTextureFormat {
			[Export ("motionTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("motionTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat OutputTextureFormat {
			[Export ("outputTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint InputWidth {
			[Export ("inputWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint InputHeight {
			[Export ("inputHeight")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputHeight"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint OutputWidth {
			[Export ("outputWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint OutputHeight {
			[Export ("outputHeight")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputHeight"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat UITextureFormat {
			[Export ("uiTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uiTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? ColorTexture {
			[Export ("colorTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colorTexture")), false)!;
				return ret;
			}
			[Export ("setColorTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColorTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? PrevColorTexture {
			[Export ("prevColorTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("prevColorTexture")), false)!;
				return ret;
			}
			[Export ("setPrevColorTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrevColorTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? DepthTexture {
			[Export ("depthTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("depthTexture")), false)!;
				return ret;
			}
			[Export ("setDepthTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDepthTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? MotionTexture {
			[Export ("motionTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("motionTexture")), false)!;
				return ret;
			}
			[Export ("setMotionTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMotionTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MotionVectorScaleX {
			[Export ("motionVectorScaleX")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("motionVectorScaleX"));
				return ret;
			}
			[Export ("setMotionVectorScaleX:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMotionVectorScaleX:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MotionVectorScaleY {
			[Export ("motionVectorScaleY")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("motionVectorScaleY"));
				return ret;
			}
			[Export ("setMotionVectorScaleY:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMotionVectorScaleY:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float DeltaTime {
			[Export ("deltaTime")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("deltaTime"));
				return ret;
			}
			[Export ("setDeltaTime:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDeltaTime:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float NearPlane {
			[Export ("nearPlane")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("nearPlane"));
				return ret;
			}
			[Export ("setNearPlane:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setNearPlane:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float FarPlane {
			[Export ("farPlane")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("farPlane"));
				return ret;
			}
			[Export ("setFarPlane:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFarPlane:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float FieldOfView {
			[Export ("fieldOfView")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("fieldOfView"));
				return ret;
			}
			[Export ("setFieldOfView:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFieldOfView:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float AspectRatio {
			[Export ("aspectRatio")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("aspectRatio"));
				return ret;
			}
			[Export ("setAspectRatio:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? UiTexture {
			[Export ("uiTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("uiTexture")), false)!;
				return ret;
			}
			[Export ("setUITexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUITexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float JitterOffsetX {
			[Export ("jitterOffsetX")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("jitterOffsetX"));
				return ret;
			}
			[Export ("setJitterOffsetX:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setJitterOffsetX:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float JitterOffsetY {
			[Export ("jitterOffsetY")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("jitterOffsetY"));
				return ret;
			}
			[Export ("setJitterOffsetY:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setJitterOffsetY:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool UITextureComposited {
			[Export ("isUITextureComposited")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUITextureComposited"));
				return ret != 0;
			}
			[Export ("setIsUITextureComposited:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsUITextureComposited:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldResetHistory {
			[Export ("shouldResetHistory")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldResetHistory"));
				return ret != 0;
			}
			[Export ("setShouldResetHistory:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldResetHistory:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? OutputTexture {
			[Export ("outputTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputTexture")), false)!;
				return ret;
			}
			[Export ("setOutputTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOutputTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLFence? Fence {
			[Export ("fence", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLFence ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fence")), false)!;
				return ret;
			}
			[Export ("setFence:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFence:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool DepthReversed {
			[Export ("isDepthReversed")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDepthReversed"));
				return ret != 0;
			}
			[Export ("setDepthReversed:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDepthReversed:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
