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
namespace MetalFX {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLFXTemporalScalerBase</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Protocol (Name = "MTLFXTemporalScalerBase", WrapperType = typeof (MTLFXTemporalScalerBaseWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureUsage", Selector = "colorTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "colorTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureUsage", Selector = "depthTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "depthTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureUsage", Selector = "motionTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "motionTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveTextureUsage", Selector = "reactiveTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "reactiveTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureUsage", Selector = "outputTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "outputTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentWidth", Selector = "inputContentWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputContentWidth", SetterSelector = "setInputContentWidth:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentHeight", Selector = "inputContentHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputContentHeight", SetterSelector = "setInputContentHeight:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTexture", Selector = "colorTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "colorTexture", SetterSelector = "setColorTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTexture", Selector = "depthTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "depthTexture", SetterSelector = "setDepthTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTexture", Selector = "motionTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "motionTexture", SetterSelector = "setMotionTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTexture", Selector = "outputTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "outputTexture", SetterSelector = "setOutputTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExposureTexture", Selector = "exposureTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "exposureTexture", SetterSelector = "setExposureTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveMaskTexture", Selector = "reactiveMaskTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "reactiveMaskTexture", SetterSelector = "setReactiveMaskTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreExposure", Selector = "preExposure", PropertyType = typeof (float), GetterSelector = "preExposure", SetterSelector = "setPreExposure:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetX", Selector = "jitterOffsetX", PropertyType = typeof (float), GetterSelector = "jitterOffsetX", SetterSelector = "setJitterOffsetX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetY", Selector = "jitterOffsetY", PropertyType = typeof (float), GetterSelector = "jitterOffsetY", SetterSelector = "setJitterOffsetY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleX", Selector = "motionVectorScaleX", PropertyType = typeof (float), GetterSelector = "motionVectorScaleX", SetterSelector = "setMotionVectorScaleX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleY", Selector = "motionVectorScaleY", PropertyType = typeof (float), GetterSelector = "motionVectorScaleY", SetterSelector = "setMotionVectorScaleY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Reset", Selector = "reset", PropertyType = typeof (bool), GetterSelector = "reset", SetterSelector = "setReset:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthReversed", Selector = "depthReversed", PropertyType = typeof (bool), GetterSelector = "isDepthReversed", SetterSelector = "setDepthReversed:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureFormat", Selector = "colorTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "colorTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureFormat", Selector = "depthTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "depthTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureFormat", Selector = "motionTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "motionTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveMaskTextureFormat", Selector = "reactiveMaskTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "reactiveMaskTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureFormat", Selector = "outputTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "outputTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputWidth", Selector = "inputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputHeight", Selector = "inputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputWidth", Selector = "outputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "outputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputHeight", Selector = "outputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "outputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentMinScale", Selector = "inputContentMinScale", PropertyType = typeof (float), GetterSelector = "inputContentMinScale", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentMaxScale", Selector = "inputContentMaxScale", PropertyType = typeof (float), GetterSelector = "inputContentMaxScale", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Fence", Selector = "fence", PropertyType = typeof (IMTLFence), GetterSelector = "fence", SetterSelector = "setFence:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IMTLFXTemporalScalerBase : INativeObject, IDisposable, 
		MetalFX.IMTLFXFrameInterpolatableScaler
	{
		[DynamicDependencyAttribute ("ColorTexture")]
		[DynamicDependencyAttribute ("ColorTextureFormat")]
		[DynamicDependencyAttribute ("ColorTextureUsage")]
		[DynamicDependencyAttribute ("DepthReversed")]
		[DynamicDependencyAttribute ("DepthTexture")]
		[DynamicDependencyAttribute ("DepthTextureFormat")]
		[DynamicDependencyAttribute ("DepthTextureUsage")]
		[DynamicDependencyAttribute ("ExposureTexture")]
		[DynamicDependencyAttribute ("Fence")]
		[DynamicDependencyAttribute ("InputContentHeight")]
		[DynamicDependencyAttribute ("InputContentMaxScale")]
		[DynamicDependencyAttribute ("InputContentMinScale")]
		[DynamicDependencyAttribute ("InputContentWidth")]
		[DynamicDependencyAttribute ("InputHeight")]
		[DynamicDependencyAttribute ("InputWidth")]
		[DynamicDependencyAttribute ("JitterOffsetX")]
		[DynamicDependencyAttribute ("JitterOffsetY")]
		[DynamicDependencyAttribute ("MotionTexture")]
		[DynamicDependencyAttribute ("MotionTextureFormat")]
		[DynamicDependencyAttribute ("MotionTextureUsage")]
		[DynamicDependencyAttribute ("MotionVectorScaleX")]
		[DynamicDependencyAttribute ("MotionVectorScaleY")]
		[DynamicDependencyAttribute ("OutputHeight")]
		[DynamicDependencyAttribute ("OutputTexture")]
		[DynamicDependencyAttribute ("OutputTextureFormat")]
		[DynamicDependencyAttribute ("OutputTextureUsage")]
		[DynamicDependencyAttribute ("OutputWidth")]
		[DynamicDependencyAttribute ("PreExposure")]
		[DynamicDependencyAttribute ("ReactiveMaskTexture")]
		[DynamicDependencyAttribute ("ReactiveMaskTextureFormat")]
		[DynamicDependencyAttribute ("ReactiveTextureUsage")]
		[DynamicDependencyAttribute ("Reset")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXTemporalScalerBaseWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFXTemporalScalerBase ()
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
		internal static global::Metal.MTLTextureUsage _GetColorTextureUsage (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorTextureUsage"));
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
		internal static global::Metal.MTLTextureUsage _GetDepthTextureUsage (IMTLFXTemporalScalerBase This)
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
		internal static global::Metal.MTLTextureUsage _GetMotionTextureUsage (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("motionTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage ReactiveTextureUsage {
			[Export ("reactiveTextureUsage")]
			get {
				return _GetReactiveTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetReactiveTextureUsage (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("reactiveTextureUsage"));
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
		internal static global::Metal.MTLTextureUsage _GetOutputTextureUsage (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint InputContentWidth {
			[Export ("inputContentWidth")]
			get {
				return _GetInputContentWidth (this);
			}
			[Export ("setInputContentWidth:")]
			set {
				_SetInputContentWidth (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetInputContentWidth (IMTLFXTemporalScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputContentWidth (IMTLFXTemporalScalerBase This, nuint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setInputContentWidth:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint InputContentHeight {
			[Export ("inputContentHeight")]
			get {
				return _GetInputContentHeight (this);
			}
			[Export ("setInputContentHeight:")]
			set {
				_SetInputContentHeight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetInputContentHeight (IMTLFXTemporalScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputContentHeight (IMTLFXTemporalScalerBase This, nuint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setInputContentHeight:"), value);
			GC.KeepAlive (This);
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
		internal static global::Metal.IMTLTexture _GetColorTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("colorTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorTexture:"), value__handle__);
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
		internal static global::Metal.IMTLTexture _GetDepthTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("depthTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
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
		internal static global::Metal.IMTLTexture _GetMotionTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("motionTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMotionTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
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
		internal static global::Metal.IMTLTexture _GetOutputTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOutputTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setOutputTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? ExposureTexture {
			[Export ("exposureTexture", ArgumentSemantic.Retain)]
			get {
				return _GetExposureTexture (this);
			}
			[Export ("setExposureTexture:", ArgumentSemantic.Retain)]
			set {
				_SetExposureTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetExposureTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("exposureTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetExposureTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setExposureTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? ReactiveMaskTexture {
			[Export ("reactiveMaskTexture", ArgumentSemantic.Retain)]
			get {
				return _GetReactiveMaskTexture (this);
			}
			[Export ("setReactiveMaskTexture:", ArgumentSemantic.Retain)]
			set {
				_SetReactiveMaskTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetReactiveMaskTexture (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("reactiveMaskTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReactiveMaskTexture (IMTLFXTemporalScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setReactiveMaskTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float PreExposure {
			[Export ("preExposure")]
			get {
				return _GetPreExposure (this);
			}
			[Export ("setPreExposure:")]
			set {
				_SetPreExposure (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetPreExposure (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("preExposure"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPreExposure (IMTLFXTemporalScalerBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setPreExposure:"), value);
			GC.KeepAlive (This);
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
		internal static float _GetJitterOffsetX (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetX (IMTLFXTemporalScalerBase This, float value)
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
		internal static float _GetJitterOffsetY (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetY (IMTLFXTemporalScalerBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setJitterOffsetY:"), value);
			GC.KeepAlive (This);
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
		internal static float _GetMotionVectorScaleX (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleX (IMTLFXTemporalScalerBase This, float value)
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
		internal static float _GetMotionVectorScaleY (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleY (IMTLFXTemporalScalerBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMotionVectorScaleY:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Reset {
			[Export ("reset")]
			get {
				return _GetReset (this);
			}
			[Export ("setReset:")]
			set {
				_SetReset (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReset (IMTLFXTemporalScalerBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("reset"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReset (IMTLFXTemporalScalerBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setReset:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
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
		internal static bool _GetDepthReversed (IMTLFXTemporalScalerBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDepthReversed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthReversed (IMTLFXTemporalScalerBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDepthReversed:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
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
		internal static global::Metal.MTLPixelFormat _GetColorTextureFormat (IMTLFXTemporalScalerBase This)
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
		internal static global::Metal.MTLPixelFormat _GetDepthTextureFormat (IMTLFXTemporalScalerBase This)
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
		internal static global::Metal.MTLPixelFormat _GetMotionTextureFormat (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("motionTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat ReactiveMaskTextureFormat {
			[Export ("reactiveMaskTextureFormat")]
			get {
				return _GetReactiveMaskTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetReactiveMaskTextureFormat (IMTLFXTemporalScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("reactiveMaskTextureFormat"));
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
		internal static global::Metal.MTLPixelFormat _GetOutputTextureFormat (IMTLFXTemporalScalerBase This)
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
		internal static nuint _GetInputWidth (IMTLFXTemporalScalerBase This)
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
		internal static nuint _GetInputHeight (IMTLFXTemporalScalerBase This)
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
		internal static nuint _GetOutputWidth (IMTLFXTemporalScalerBase This)
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
		internal static nuint _GetOutputHeight (IMTLFXTemporalScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputContentMinScale {
			[Export ("inputContentMinScale")]
			get {
				return _GetInputContentMinScale (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputContentMinScale (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentMinScale"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputContentMaxScale {
			[Export ("inputContentMaxScale")]
			get {
				return _GetInputContentMaxScale (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputContentMaxScale (IMTLFXTemporalScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentMaxScale"));
			GC.KeepAlive (This);
			return ret;
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
		internal static global::Metal.IMTLFence _GetFence (IMTLFXTemporalScalerBase This)
		{
			global::Metal.IMTLFence ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("fence")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFence (IMTLFXTemporalScalerBase This, global::Metal.IMTLFence? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFence:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFXTemporalScalerBaseWrapper : BaseWrapper, IMTLFXTemporalScalerBase {
		public MTLFXTemporalScalerBaseWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXTemporalScalerBaseWrapper))]
		static MTLFXTemporalScalerBaseWrapper ()
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
		public global::Metal.MTLTextureUsage ReactiveTextureUsage {
			[Export ("reactiveTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reactiveTextureUsage"));
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
		public nuint InputContentWidth {
			[Export ("inputContentWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentWidth"));
				return ret;
			}
			[Export ("setInputContentWidth:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setInputContentWidth:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint InputContentHeight {
			[Export ("inputContentHeight")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentHeight"));
				return ret;
			}
			[Export ("setInputContentHeight:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setInputContentHeight:"), value);
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
		public global::Metal.IMTLTexture? ExposureTexture {
			[Export ("exposureTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("exposureTexture")), false)!;
				return ret;
			}
			[Export ("setExposureTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setExposureTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? ReactiveMaskTexture {
			[Export ("reactiveMaskTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reactiveMaskTexture")), false)!;
				return ret;
			}
			[Export ("setReactiveMaskTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReactiveMaskTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float PreExposure {
			[Export ("preExposure")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("preExposure"));
				return ret;
			}
			[Export ("setPreExposure:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPreExposure:"), value);
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
		public bool Reset {
			[Export ("reset")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
				return ret != 0;
			}
			[Export ("setReset:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setReset:"), value ? (byte) 1 : (byte) 0);
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
		public global::Metal.MTLPixelFormat ReactiveMaskTextureFormat {
			[Export ("reactiveMaskTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reactiveMaskTextureFormat"));
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
		public float InputContentMinScale {
			[Export ("inputContentMinScale")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentMinScale"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputContentMaxScale {
			[Export ("inputContentMaxScale")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("inputContentMaxScale"));
				return ret;
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
	}
}
