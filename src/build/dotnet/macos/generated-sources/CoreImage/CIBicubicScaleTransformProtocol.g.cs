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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CIBicubicScaleTransform</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIBicubicScaleTransform", WrapperType = typeof (CIBicubicScaleTransformProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof (CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scale", Selector = "scale", PropertyType = typeof (float), GetterSelector = "scale", SetterSelector = "setScale:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AspectRatio", Selector = "aspectRatio", PropertyType = typeof (float), GetterSelector = "aspectRatio", SetterSelector = "setAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterB", Selector = "parameterB", PropertyType = typeof (float), GetterSelector = "parameterB", SetterSelector = "setParameterB:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterC", Selector = "parameterC", PropertyType = typeof (float), GetterSelector = "parameterC", SetterSelector = "setParameterC:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIBicubicScaleTransformProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("AspectRatio")]
		[DynamicDependencyAttribute ("InputImage")]
		[DynamicDependencyAttribute ("ParameterB")]
		[DynamicDependencyAttribute ("ParameterC")]
		[DynamicDependencyAttribute ("Scale")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIBicubicScaleTransformProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIBicubicScaleTransformProtocol ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets an image to filter.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIImage? InputImage {
			[Export ("inputImage", ArgumentSemantic.Retain)]
			get {
				return _GetInputImage (this);
			}
			[Export ("setInputImage:", ArgumentSemantic.Retain)]
			set {
				_SetInputImage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIImage _GetInputImage (ICIBicubicScaleTransformProtocol This)
		{
			CIImage ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputImage (ICIBicubicScaleTransformProtocol This, CIImage? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Scale {
			[Export ("scale")]
			get {
				return _GetScale (this);
			}
			[Export ("setScale:")]
			set {
				_SetScale (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetScale (ICIBicubicScaleTransformProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("scale"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScale (ICIBicubicScaleTransformProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setScale:"), value);
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
		internal static float _GetAspectRatio (ICIBicubicScaleTransformProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("aspectRatio"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAspectRatio (ICIBicubicScaleTransformProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float ParameterB {
			[Export ("parameterB")]
			get {
				return _GetParameterB (this);
			}
			[Export ("setParameterB:")]
			set {
				_SetParameterB (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetParameterB (ICIBicubicScaleTransformProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("parameterB"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetParameterB (ICIBicubicScaleTransformProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setParameterB:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float ParameterC {
			[Export ("parameterC")]
			get {
				return _GetParameterC (this);
			}
			[Export ("setParameterC:")]
			set {
				_SetParameterC (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetParameterC (ICIBicubicScaleTransformProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("parameterC"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetParameterC (ICIBicubicScaleTransformProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setParameterC:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIBicubicScaleTransformProtocolWrapper : BaseWrapper, ICIBicubicScaleTransformProtocol {
		public CIBicubicScaleTransformProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIBicubicScaleTransformProtocolWrapper))]
		static CIBicubicScaleTransformProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets an image to filter.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? InputImage {
			[Export ("inputImage", ArgumentSemantic.Retain)]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputImage")), false)!;
				return ret;
			}
			[Export ("setInputImage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Scale {
			[Export ("scale")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("scale"));
				return ret;
			}
			[Export ("setScale:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setScale:"), value);
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
		public float ParameterB {
			[Export ("parameterB")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("parameterB"));
				return ret;
			}
			[Export ("setParameterB:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setParameterB:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float ParameterC {
			[Export ("parameterC")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("parameterC"));
				return ret;
			}
			[Export ("setParameterC:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setParameterC:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputImage")), false)!;
				return ret;
			}
		}
	}
}
