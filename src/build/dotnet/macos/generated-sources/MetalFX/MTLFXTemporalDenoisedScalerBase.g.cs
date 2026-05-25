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
	/// <summary>This interface represents the Objective-C protocol <c>MTLFXTemporalDenoisedScalerBase</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Protocol (Name = "MTLFXTemporalDenoisedScalerBase", WrapperType = typeof (MTLFXTemporalDenoisedScalerBaseWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureUsage", Selector = "colorTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "colorTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureUsage", Selector = "depthTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "depthTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureUsage", Selector = "motionTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "motionTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveTextureUsage", Selector = "reactiveTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "reactiveTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DiffuseAlbedoTextureUsage", Selector = "diffuseAlbedoTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "diffuseAlbedoTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularAlbedoTextureUsage", Selector = "specularAlbedoTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "specularAlbedoTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NormalTextureUsage", Selector = "normalTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "normalTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RoughnessTextureUsage", Selector = "roughnessTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "roughnessTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularHitDistanceTextureUsage", Selector = "specularHitDistanceTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "specularHitDistanceTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DenoiseStrengthMaskTextureUsage", Selector = "denoiseStrengthMaskTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "denoiseStrengthMaskTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TransparencyOverlayTextureUsage", Selector = "transparencyOverlayTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "transparencyOverlayTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureUsage", Selector = "outputTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "outputTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTexture", Selector = "colorTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "colorTexture", SetterSelector = "setColorTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTexture", Selector = "depthTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "depthTexture", SetterSelector = "setDepthTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTexture", Selector = "motionTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "motionTexture", SetterSelector = "setMotionTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DiffuseAlbedoTexture", Selector = "diffuseAlbedoTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "diffuseAlbedoTexture", SetterSelector = "setDiffuseAlbedoTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularAlbedoTexture", Selector = "specularAlbedoTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "specularAlbedoTexture", SetterSelector = "setSpecularAlbedoTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NormalTexture", Selector = "normalTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "normalTexture", SetterSelector = "setNormalTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RoughnessTexture", Selector = "roughnessTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "roughnessTexture", SetterSelector = "setRoughnessTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularHitDistanceTexture", Selector = "specularHitDistanceTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "specularHitDistanceTexture", SetterSelector = "setSpecularHitDistanceTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DenoiseStrengthMaskTexture", Selector = "denoiseStrengthMaskTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "denoiseStrengthMaskTexture", SetterSelector = "setDenoiseStrengthMaskTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TransparencyOverlayTexture", Selector = "transparencyOverlayTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "transparencyOverlayTexture", SetterSelector = "setTransparencyOverlayTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTexture", Selector = "outputTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "outputTexture", SetterSelector = "setOutputTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExposureTexture", Selector = "exposureTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "exposureTexture", SetterSelector = "setExposureTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreExposure", Selector = "preExposure", PropertyType = typeof (float), GetterSelector = "preExposure", SetterSelector = "setPreExposure:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveMaskTexture", Selector = "reactiveMaskTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "reactiveMaskTexture", SetterSelector = "setReactiveMaskTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetX", Selector = "jitterOffsetX", PropertyType = typeof (float), GetterSelector = "jitterOffsetX", SetterSelector = "setJitterOffsetX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitterOffsetY", Selector = "jitterOffsetY", PropertyType = typeof (float), GetterSelector = "jitterOffsetY", SetterSelector = "setJitterOffsetY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleX", Selector = "motionVectorScaleX", PropertyType = typeof (float), GetterSelector = "motionVectorScaleX", SetterSelector = "setMotionVectorScaleX:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionVectorScaleY", Selector = "motionVectorScaleY", PropertyType = typeof (float), GetterSelector = "motionVectorScaleY", SetterSelector = "setMotionVectorScaleY:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldResetHistory", Selector = "shouldResetHistory", PropertyType = typeof (bool), GetterSelector = "shouldResetHistory", SetterSelector = "setShouldResetHistory:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthReversed", Selector = "depthReversed", PropertyType = typeof (bool), GetterSelector = "isDepthReversed", SetterSelector = "setDepthReversed:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureFormat", Selector = "colorTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "colorTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTextureFormat", Selector = "depthTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "depthTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MotionTextureFormat", Selector = "motionTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "motionTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DiffuseAlbedoTextureFormat", Selector = "diffuseAlbedoTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "diffuseAlbedoTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularAlbedoTextureFormat", Selector = "specularAlbedoTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "specularAlbedoTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NormalTextureFormat", Selector = "normalTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "normalTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RoughnessTextureFormat", Selector = "roughnessTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "roughnessTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpecularHitDistanceTextureFormat", Selector = "specularHitDistanceTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "specularHitDistanceTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DenoiseStrengthMaskTextureFormat", Selector = "denoiseStrengthMaskTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "denoiseStrengthMaskTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TransparencyOverlayTextureFormat", Selector = "transparencyOverlayTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "transparencyOverlayTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReactiveMaskTextureFormat", Selector = "reactiveMaskTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "reactiveMaskTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureFormat", Selector = "outputTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "outputTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputWidth", Selector = "inputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputHeight", Selector = "inputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputWidth", Selector = "outputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "outputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputHeight", Selector = "outputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "outputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentMinScale", Selector = "inputContentMinScale", PropertyType = typeof (float), GetterSelector = "inputContentMinScale", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentMaxScale", Selector = "inputContentMaxScale", PropertyType = typeof (float), GetterSelector = "inputContentMaxScale", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WorldToViewMatrix", Selector = "worldToViewMatrix", PropertyType = typeof (NMatrix4), GetterSelector = "worldToViewMatrix", SetterSelector = "setWorldToViewMatrix:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ViewToClipMatrix", Selector = "viewToClipMatrix", PropertyType = typeof (NMatrix4), GetterSelector = "viewToClipMatrix", SetterSelector = "setViewToClipMatrix:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Fence", Selector = "fence", PropertyType = typeof (IMTLFence), GetterSelector = "fence", SetterSelector = "setFence:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IMTLFXTemporalDenoisedScalerBase : INativeObject, IDisposable, 
		MetalFX.IMTLFXFrameInterpolatableScaler
	{
		[DynamicDependencyAttribute ("ColorTexture")]
		[DynamicDependencyAttribute ("ColorTextureFormat")]
		[DynamicDependencyAttribute ("ColorTextureUsage")]
		[DynamicDependencyAttribute ("DenoiseStrengthMaskTexture")]
		[DynamicDependencyAttribute ("DenoiseStrengthMaskTextureFormat")]
		[DynamicDependencyAttribute ("DenoiseStrengthMaskTextureUsage")]
		[DynamicDependencyAttribute ("DepthReversed")]
		[DynamicDependencyAttribute ("DepthTexture")]
		[DynamicDependencyAttribute ("DepthTextureFormat")]
		[DynamicDependencyAttribute ("DepthTextureUsage")]
		[DynamicDependencyAttribute ("DiffuseAlbedoTexture")]
		[DynamicDependencyAttribute ("DiffuseAlbedoTextureFormat")]
		[DynamicDependencyAttribute ("DiffuseAlbedoTextureUsage")]
		[DynamicDependencyAttribute ("ExposureTexture")]
		[DynamicDependencyAttribute ("Fence")]
		[DynamicDependencyAttribute ("InputContentMaxScale")]
		[DynamicDependencyAttribute ("InputContentMinScale")]
		[DynamicDependencyAttribute ("InputHeight")]
		[DynamicDependencyAttribute ("InputWidth")]
		[DynamicDependencyAttribute ("JitterOffsetX")]
		[DynamicDependencyAttribute ("JitterOffsetY")]
		[DynamicDependencyAttribute ("MotionTexture")]
		[DynamicDependencyAttribute ("MotionTextureFormat")]
		[DynamicDependencyAttribute ("MotionTextureUsage")]
		[DynamicDependencyAttribute ("MotionVectorScaleX")]
		[DynamicDependencyAttribute ("MotionVectorScaleY")]
		[DynamicDependencyAttribute ("NormalTexture")]
		[DynamicDependencyAttribute ("NormalTextureFormat")]
		[DynamicDependencyAttribute ("NormalTextureUsage")]
		[DynamicDependencyAttribute ("OutputHeight")]
		[DynamicDependencyAttribute ("OutputTexture")]
		[DynamicDependencyAttribute ("OutputTextureFormat")]
		[DynamicDependencyAttribute ("OutputTextureUsage")]
		[DynamicDependencyAttribute ("OutputWidth")]
		[DynamicDependencyAttribute ("PreExposure")]
		[DynamicDependencyAttribute ("ReactiveMaskTexture")]
		[DynamicDependencyAttribute ("ReactiveMaskTextureFormat")]
		[DynamicDependencyAttribute ("ReactiveTextureUsage")]
		[DynamicDependencyAttribute ("RoughnessTexture")]
		[DynamicDependencyAttribute ("RoughnessTextureFormat")]
		[DynamicDependencyAttribute ("RoughnessTextureUsage")]
		[DynamicDependencyAttribute ("ShouldResetHistory")]
		[DynamicDependencyAttribute ("SpecularAlbedoTexture")]
		[DynamicDependencyAttribute ("SpecularAlbedoTextureFormat")]
		[DynamicDependencyAttribute ("SpecularAlbedoTextureUsage")]
		[DynamicDependencyAttribute ("SpecularHitDistanceTexture")]
		[DynamicDependencyAttribute ("SpecularHitDistanceTextureFormat")]
		[DynamicDependencyAttribute ("SpecularHitDistanceTextureUsage")]
		[DynamicDependencyAttribute ("TransparencyOverlayTexture")]
		[DynamicDependencyAttribute ("TransparencyOverlayTextureFormat")]
		[DynamicDependencyAttribute ("TransparencyOverlayTextureUsage")]
		[DynamicDependencyAttribute ("ViewToClipMatrix")]
		[DynamicDependencyAttribute ("WorldToViewMatrix")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXTemporalDenoisedScalerBaseWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFXTemporalDenoisedScalerBase ()
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
		internal static global::Metal.MTLTextureUsage _GetColorTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLTextureUsage _GetDepthTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLTextureUsage _GetMotionTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLTextureUsage _GetReactiveTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("reactiveTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage DiffuseAlbedoTextureUsage {
			[Export ("diffuseAlbedoTextureUsage")]
			get {
				return _GetDiffuseAlbedoTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetDiffuseAlbedoTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("diffuseAlbedoTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage SpecularAlbedoTextureUsage {
			[Export ("specularAlbedoTextureUsage")]
			get {
				return _GetSpecularAlbedoTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetSpecularAlbedoTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("specularAlbedoTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage NormalTextureUsage {
			[Export ("normalTextureUsage")]
			get {
				return _GetNormalTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetNormalTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("normalTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage RoughnessTextureUsage {
			[Export ("roughnessTextureUsage")]
			get {
				return _GetRoughnessTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetRoughnessTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roughnessTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage SpecularHitDistanceTextureUsage {
			[Export ("specularHitDistanceTextureUsage")]
			get {
				return _GetSpecularHitDistanceTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetSpecularHitDistanceTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("specularHitDistanceTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage DenoiseStrengthMaskTextureUsage {
			[Export ("denoiseStrengthMaskTextureUsage")]
			get {
				return _GetDenoiseStrengthMaskTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetDenoiseStrengthMaskTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("denoiseStrengthMaskTextureUsage"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLTextureUsage TransparencyOverlayTextureUsage {
			[Export ("transparencyOverlayTextureUsage")]
			get {
				return _GetTransparencyOverlayTextureUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLTextureUsage _GetTransparencyOverlayTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("transparencyOverlayTextureUsage"));
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
		internal static global::Metal.MTLTextureUsage _GetOutputTextureUsage (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLTextureUsage ret;
			ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputTextureUsage"));
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
		internal static global::Metal.IMTLTexture _GetColorTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("colorTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
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
		internal static global::Metal.IMTLTexture _GetDepthTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("depthTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
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
		internal static global::Metal.IMTLTexture _GetMotionTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("motionTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMotionTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? DiffuseAlbedoTexture {
			[Export ("diffuseAlbedoTexture", ArgumentSemantic.Retain)]
			get {
				return _GetDiffuseAlbedoTexture (this);
			}
			[Export ("setDiffuseAlbedoTexture:", ArgumentSemantic.Retain)]
			set {
				_SetDiffuseAlbedoTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetDiffuseAlbedoTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("diffuseAlbedoTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDiffuseAlbedoTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDiffuseAlbedoTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? SpecularAlbedoTexture {
			[Export ("specularAlbedoTexture", ArgumentSemantic.Retain)]
			get {
				return _GetSpecularAlbedoTexture (this);
			}
			[Export ("setSpecularAlbedoTexture:", ArgumentSemantic.Retain)]
			set {
				_SetSpecularAlbedoTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetSpecularAlbedoTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("specularAlbedoTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpecularAlbedoTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSpecularAlbedoTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? NormalTexture {
			[Export ("normalTexture", ArgumentSemantic.Retain)]
			get {
				return _GetNormalTexture (this);
			}
			[Export ("setNormalTexture:", ArgumentSemantic.Retain)]
			set {
				_SetNormalTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetNormalTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("normalTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNormalTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setNormalTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? RoughnessTexture {
			[Export ("roughnessTexture", ArgumentSemantic.Retain)]
			get {
				return _GetRoughnessTexture (this);
			}
			[Export ("setRoughnessTexture:", ArgumentSemantic.Retain)]
			set {
				_SetRoughnessTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetRoughnessTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("roughnessTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRoughnessTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRoughnessTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? SpecularHitDistanceTexture {
			[Export ("specularHitDistanceTexture", ArgumentSemantic.Retain)]
			get {
				return _GetSpecularHitDistanceTexture (this);
			}
			[Export ("setSpecularHitDistanceTexture:", ArgumentSemantic.Retain)]
			set {
				_SetSpecularHitDistanceTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetSpecularHitDistanceTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("specularHitDistanceTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpecularHitDistanceTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSpecularHitDistanceTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? DenoiseStrengthMaskTexture {
			[Export ("denoiseStrengthMaskTexture", ArgumentSemantic.Retain)]
			get {
				return _GetDenoiseStrengthMaskTexture (this);
			}
			[Export ("setDenoiseStrengthMaskTexture:", ArgumentSemantic.Retain)]
			set {
				_SetDenoiseStrengthMaskTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetDenoiseStrengthMaskTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("denoiseStrengthMaskTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDenoiseStrengthMaskTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDenoiseStrengthMaskTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLTexture? TransparencyOverlayTexture {
			[Export ("transparencyOverlayTexture", ArgumentSemantic.Retain)]
			get {
				return _GetTransparencyOverlayTexture (this);
			}
			[Export ("setTransparencyOverlayTexture:", ArgumentSemantic.Retain)]
			set {
				_SetTransparencyOverlayTexture (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture _GetTransparencyOverlayTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("transparencyOverlayTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTransparencyOverlayTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTransparencyOverlayTexture:"), value__handle__);
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
		internal static global::Metal.IMTLTexture _GetOutputTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOutputTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
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
		internal static global::Metal.IMTLTexture _GetExposureTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("exposureTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetExposureTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setExposureTexture:"), value__handle__);
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
		internal static float _GetPreExposure (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("preExposure"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPreExposure (IMTLFXTemporalDenoisedScalerBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setPreExposure:"), value);
			GC.KeepAlive (This);
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
		internal static global::Metal.IMTLTexture _GetReactiveMaskTexture (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("reactiveMaskTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReactiveMaskTexture (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setReactiveMaskTexture:"), value__handle__);
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
		internal static float _GetJitterOffsetX (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetX (IMTLFXTemporalDenoisedScalerBase This, float value)
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
		internal static float _GetJitterOffsetY (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("jitterOffsetY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitterOffsetY (IMTLFXTemporalDenoisedScalerBase This, float value)
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
		internal static float _GetMotionVectorScaleX (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleX"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleX (IMTLFXTemporalDenoisedScalerBase This, float value)
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
		internal static float _GetMotionVectorScaleY (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("motionVectorScaleY"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMotionVectorScaleY (IMTLFXTemporalDenoisedScalerBase This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMotionVectorScaleY:"), value);
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
		internal static bool _GetShouldResetHistory (IMTLFXTemporalDenoisedScalerBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldResetHistory"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetShouldResetHistory (IMTLFXTemporalDenoisedScalerBase This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldResetHistory:"), value ? (byte) 1 : (byte) 0);
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
		internal static bool _GetDepthReversed (IMTLFXTemporalDenoisedScalerBase This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDepthReversed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthReversed (IMTLFXTemporalDenoisedScalerBase This, bool value)
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
		internal static global::Metal.MTLPixelFormat _GetColorTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLPixelFormat _GetDepthTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLPixelFormat _GetMotionTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("motionTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat DiffuseAlbedoTextureFormat {
			[Export ("diffuseAlbedoTextureFormat")]
			get {
				return _GetDiffuseAlbedoTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetDiffuseAlbedoTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("diffuseAlbedoTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat SpecularAlbedoTextureFormat {
			[Export ("specularAlbedoTextureFormat")]
			get {
				return _GetSpecularAlbedoTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetSpecularAlbedoTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("specularAlbedoTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat NormalTextureFormat {
			[Export ("normalTextureFormat")]
			get {
				return _GetNormalTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetNormalTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("normalTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat RoughnessTextureFormat {
			[Export ("roughnessTextureFormat")]
			get {
				return _GetRoughnessTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetRoughnessTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roughnessTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat SpecularHitDistanceTextureFormat {
			[Export ("specularHitDistanceTextureFormat")]
			get {
				return _GetSpecularHitDistanceTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetSpecularHitDistanceTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("specularHitDistanceTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat DenoiseStrengthMaskTextureFormat {
			[Export ("denoiseStrengthMaskTextureFormat")]
			get {
				return _GetDenoiseStrengthMaskTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetDenoiseStrengthMaskTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("denoiseStrengthMaskTextureFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat TransparencyOverlayTextureFormat {
			[Export ("transparencyOverlayTextureFormat")]
			get {
				return _GetTransparencyOverlayTextureFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetTransparencyOverlayTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("transparencyOverlayTextureFormat"));
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
		internal static global::Metal.MTLPixelFormat _GetReactiveMaskTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static global::Metal.MTLPixelFormat _GetOutputTextureFormat (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static nuint _GetInputWidth (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static nuint _GetInputHeight (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static nuint _GetOutputWidth (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static nuint _GetOutputHeight (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static float _GetInputContentMinScale (IMTLFXTemporalDenoisedScalerBase This)
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
		internal static float _GetInputContentMaxScale (IMTLFXTemporalDenoisedScalerBase This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentMaxScale"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NMatrix4 WorldToViewMatrix {
			[Export ("worldToViewMatrix", ArgumentSemantic.Assign)]
			get {
				return _GetWorldToViewMatrix (this);
			}
			[Export ("setWorldToViewMatrix:", ArgumentSemantic.Assign)]
			set {
				_SetWorldToViewMatrix (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4 _GetWorldToViewMatrix (IMTLFXTemporalDenoisedScalerBase This)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (This.Handle, Selector.GetHandle ("worldToViewMatrix"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (This.Handle, Selector.GetHandle ("worldToViewMatrix"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWorldToViewMatrix (IMTLFXTemporalDenoisedScalerBase This, NMatrix4 value)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (This.Handle, Selector.GetHandle ("setWorldToViewMatrix:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NMatrix4 ViewToClipMatrix {
			[Export ("viewToClipMatrix", ArgumentSemantic.Assign)]
			get {
				return _GetViewToClipMatrix (this);
			}
			[Export ("setViewToClipMatrix:", ArgumentSemantic.Assign)]
			set {
				_SetViewToClipMatrix (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4 _GetViewToClipMatrix (IMTLFXTemporalDenoisedScalerBase This)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (This.Handle, Selector.GetHandle ("viewToClipMatrix"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (This.Handle, Selector.GetHandle ("viewToClipMatrix"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetViewToClipMatrix (IMTLFXTemporalDenoisedScalerBase This, NMatrix4 value)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (This.Handle, Selector.GetHandle ("setViewToClipMatrix:"), value);
			GC.KeepAlive (This);
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
		internal static global::Metal.IMTLFence _GetFence (IMTLFXTemporalDenoisedScalerBase This)
		{
			global::Metal.IMTLFence ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("fence")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFence (IMTLFXTemporalDenoisedScalerBase This, global::Metal.IMTLFence? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFence:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFXTemporalDenoisedScalerBaseWrapper : BaseWrapper, IMTLFXTemporalDenoisedScalerBase {
		public MTLFXTemporalDenoisedScalerBaseWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXTemporalDenoisedScalerBaseWrapper))]
		static MTLFXTemporalDenoisedScalerBaseWrapper ()
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
		public global::Metal.MTLTextureUsage DiffuseAlbedoTextureUsage {
			[Export ("diffuseAlbedoTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("diffuseAlbedoTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage SpecularAlbedoTextureUsage {
			[Export ("specularAlbedoTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("specularAlbedoTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage NormalTextureUsage {
			[Export ("normalTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("normalTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage RoughnessTextureUsage {
			[Export ("roughnessTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("roughnessTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage SpecularHitDistanceTextureUsage {
			[Export ("specularHitDistanceTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("specularHitDistanceTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage DenoiseStrengthMaskTextureUsage {
			[Export ("denoiseStrengthMaskTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("denoiseStrengthMaskTextureUsage"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLTextureUsage TransparencyOverlayTextureUsage {
			[Export ("transparencyOverlayTextureUsage")]
			get {
				global::Metal.MTLTextureUsage ret;
				ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transparencyOverlayTextureUsage"));
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
		public global::Metal.IMTLTexture? DiffuseAlbedoTexture {
			[Export ("diffuseAlbedoTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("diffuseAlbedoTexture")), false)!;
				return ret;
			}
			[Export ("setDiffuseAlbedoTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDiffuseAlbedoTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? SpecularAlbedoTexture {
			[Export ("specularAlbedoTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("specularAlbedoTexture")), false)!;
				return ret;
			}
			[Export ("setSpecularAlbedoTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSpecularAlbedoTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? NormalTexture {
			[Export ("normalTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("normalTexture")), false)!;
				return ret;
			}
			[Export ("setNormalTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNormalTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? RoughnessTexture {
			[Export ("roughnessTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("roughnessTexture")), false)!;
				return ret;
			}
			[Export ("setRoughnessTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRoughnessTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? SpecularHitDistanceTexture {
			[Export ("specularHitDistanceTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("specularHitDistanceTexture")), false)!;
				return ret;
			}
			[Export ("setSpecularHitDistanceTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSpecularHitDistanceTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? DenoiseStrengthMaskTexture {
			[Export ("denoiseStrengthMaskTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("denoiseStrengthMaskTexture")), false)!;
				return ret;
			}
			[Export ("setDenoiseStrengthMaskTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDenoiseStrengthMaskTexture:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? TransparencyOverlayTexture {
			[Export ("transparencyOverlayTexture", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLTexture ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("transparencyOverlayTexture")), false)!;
				return ret;
			}
			[Export ("setTransparencyOverlayTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTransparencyOverlayTexture:"), value__handle__);
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
		public global::Metal.MTLPixelFormat DiffuseAlbedoTextureFormat {
			[Export ("diffuseAlbedoTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("diffuseAlbedoTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat SpecularAlbedoTextureFormat {
			[Export ("specularAlbedoTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("specularAlbedoTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat NormalTextureFormat {
			[Export ("normalTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("normalTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat RoughnessTextureFormat {
			[Export ("roughnessTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("roughnessTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat SpecularHitDistanceTextureFormat {
			[Export ("specularHitDistanceTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("specularHitDistanceTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat DenoiseStrengthMaskTextureFormat {
			[Export ("denoiseStrengthMaskTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("denoiseStrengthMaskTextureFormat"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.MTLPixelFormat TransparencyOverlayTextureFormat {
			[Export ("transparencyOverlayTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transparencyOverlayTextureFormat"));
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
		public NMatrix4 WorldToViewMatrix {
			[Export ("worldToViewMatrix", ArgumentSemantic.Assign)]
			get {
				NMatrix4 ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("worldToViewMatrix"));
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("worldToViewMatrix"));
				}
				return ret!;
			}
			[Export ("setWorldToViewMatrix:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, Selector.GetHandle ("setWorldToViewMatrix:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NMatrix4 ViewToClipMatrix {
			[Export ("viewToClipMatrix", ArgumentSemantic.Assign)]
			get {
				NMatrix4 ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("viewToClipMatrix"));
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("viewToClipMatrix"));
				}
				return ret!;
			}
			[Export ("setViewToClipMatrix:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, Selector.GetHandle ("setViewToClipMatrix:"), value);
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
