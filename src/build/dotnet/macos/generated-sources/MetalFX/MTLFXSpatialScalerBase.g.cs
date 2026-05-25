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
	/// <summary>This interface represents the Objective-C protocol <c>MTLFXSpatialScalerBase</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Protocol (Name = "MTLFXSpatialScalerBase", WrapperType = typeof (MTLFXSpatialScalerBaseWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureUsage", Selector = "colorTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "colorTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureUsage", Selector = "outputTextureUsage", PropertyType = typeof (MTLTextureUsage), GetterSelector = "outputTextureUsage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentWidth", Selector = "inputContentWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputContentWidth", SetterSelector = "setInputContentWidth:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputContentHeight", Selector = "inputContentHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputContentHeight", SetterSelector = "setInputContentHeight:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTexture", Selector = "colorTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "colorTexture", SetterSelector = "setColorTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTexture", Selector = "outputTexture", PropertyType = typeof (IMTLTexture), GetterSelector = "outputTexture", SetterSelector = "setOutputTexture:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorTextureFormat", Selector = "colorTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "colorTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputTextureFormat", Selector = "outputTextureFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "outputTextureFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputWidth", Selector = "inputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "inputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputHeight", Selector = "inputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "inputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputWidth", Selector = "outputWidth", PropertyType = typeof (UIntPtr), GetterSelector = "outputWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OutputHeight", Selector = "outputHeight", PropertyType = typeof (UIntPtr), GetterSelector = "outputHeight", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorProcessingMode", Selector = "colorProcessingMode", PropertyType = typeof (MetalFX.MTLFXSpatialScalerColorProcessingMode), GetterSelector = "colorProcessingMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Fence", Selector = "fence", PropertyType = typeof (IMTLFence), GetterSelector = "fence", SetterSelector = "setFence:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IMTLFXSpatialScalerBase : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ColorProcessingMode")]
		[DynamicDependencyAttribute ("ColorTexture")]
		[DynamicDependencyAttribute ("ColorTextureFormat")]
		[DynamicDependencyAttribute ("ColorTextureUsage")]
		[DynamicDependencyAttribute ("Fence")]
		[DynamicDependencyAttribute ("InputContentHeight")]
		[DynamicDependencyAttribute ("InputContentWidth")]
		[DynamicDependencyAttribute ("InputHeight")]
		[DynamicDependencyAttribute ("InputWidth")]
		[DynamicDependencyAttribute ("OutputHeight")]
		[DynamicDependencyAttribute ("OutputTexture")]
		[DynamicDependencyAttribute ("OutputTextureFormat")]
		[DynamicDependencyAttribute ("OutputTextureUsage")]
		[DynamicDependencyAttribute ("OutputWidth")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXSpatialScalerBaseWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFXSpatialScalerBase ()
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
		internal static global::Metal.MTLTextureUsage _GetColorTextureUsage (IMTLFXSpatialScalerBase This)
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
		internal static global::Metal.MTLTextureUsage _GetOutputTextureUsage (IMTLFXSpatialScalerBase This)
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
		internal static nuint _GetInputContentWidth (IMTLFXSpatialScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputContentWidth (IMTLFXSpatialScalerBase This, nuint value)
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
		internal static nuint _GetInputContentHeight (IMTLFXSpatialScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputContentHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputContentHeight (IMTLFXSpatialScalerBase This, nuint value)
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
		internal static global::Metal.IMTLTexture _GetColorTexture (IMTLFXSpatialScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("colorTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorTexture (IMTLFXSpatialScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorTexture:"), value__handle__);
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
		internal static global::Metal.IMTLTexture _GetOutputTexture (IMTLFXSpatialScalerBase This)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputTexture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOutputTexture (IMTLFXSpatialScalerBase This, global::Metal.IMTLTexture? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setOutputTexture:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
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
		internal static global::Metal.MTLPixelFormat _GetColorTextureFormat (IMTLFXSpatialScalerBase This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorTextureFormat"));
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
		internal static global::Metal.MTLPixelFormat _GetOutputTextureFormat (IMTLFXSpatialScalerBase This)
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
		internal static nuint _GetInputWidth (IMTLFXSpatialScalerBase This)
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
		internal static nuint _GetInputHeight (IMTLFXSpatialScalerBase This)
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
		internal static nuint _GetOutputWidth (IMTLFXSpatialScalerBase This)
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
		internal static nuint _GetOutputHeight (IMTLFXSpatialScalerBase This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("outputHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLFXSpatialScalerColorProcessingMode ColorProcessingMode {
			[Export ("colorProcessingMode")]
			get {
				return _GetColorProcessingMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLFXSpatialScalerColorProcessingMode _GetColorProcessingMode (IMTLFXSpatialScalerBase This)
		{
			MTLFXSpatialScalerColorProcessingMode ret;
			ret = (MetalFX.MTLFXSpatialScalerColorProcessingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorProcessingMode"));
			GC.KeepAlive (This);
			return ret!;
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
		internal static global::Metal.IMTLFence _GetFence (IMTLFXSpatialScalerBase This)
		{
			global::Metal.IMTLFence ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLFence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("fence")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFence (IMTLFXSpatialScalerBase This, global::Metal.IMTLFence? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFence:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFXSpatialScalerBaseWrapper : BaseWrapper, IMTLFXSpatialScalerBase {
		public MTLFXSpatialScalerBaseWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFXSpatialScalerBaseWrapper))]
		static MTLFXSpatialScalerBaseWrapper ()
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
		public global::Metal.MTLPixelFormat ColorTextureFormat {
			[Export ("colorTextureFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorTextureFormat"));
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
		public MTLFXSpatialScalerColorProcessingMode ColorProcessingMode {
			[Export ("colorProcessingMode")]
			get {
				MTLFXSpatialScalerColorProcessingMode ret;
				ret = (MetalFX.MTLFXSpatialScalerColorProcessingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorProcessingMode"));
				return ret!;
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
