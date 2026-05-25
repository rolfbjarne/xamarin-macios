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
	/// <summary>This interface represents the Objective-C protocol <c>CISpotLight</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CISpotLight", WrapperType = typeof (CISpotLightProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof (CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LightPosition", Selector = "lightPosition", PropertyType = typeof (CIVector), GetterSelector = "lightPosition", SetterSelector = "setLightPosition:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LightPointsAt", Selector = "lightPointsAt", PropertyType = typeof (CIVector), GetterSelector = "lightPointsAt", SetterSelector = "setLightPointsAt:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Brightness", Selector = "brightness", PropertyType = typeof (float), GetterSelector = "brightness", SetterSelector = "setBrightness:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Concentration", Selector = "concentration", PropertyType = typeof (float), GetterSelector = "concentration", SetterSelector = "setConcentration:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof (CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICISpotLightProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("Brightness")]
		[DynamicDependencyAttribute ("Color")]
		[DynamicDependencyAttribute ("Concentration")]
		[DynamicDependencyAttribute ("InputImage")]
		[DynamicDependencyAttribute ("LightPointsAt")]
		[DynamicDependencyAttribute ("LightPosition")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CISpotLightProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICISpotLightProtocol ()
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
		internal static CIImage _GetInputImage (ICISpotLightProtocol This)
		{
			CIImage ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputImage (ICISpotLightProtocol This, CIImage? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the 3-dimensional point in image coordinates from which the spotlight shines.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIVector LightPosition {
			[Export ("lightPosition", ArgumentSemantic.Retain)]
			get {
				return _GetLightPosition (this);
			}
			[Export ("setLightPosition:", ArgumentSemantic.Retain)]
			set {
				_SetLightPosition (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIVector _GetLightPosition (ICISpotLightProtocol This)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("lightPosition")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLightPosition (ICISpotLightProtocol This, CIVector value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLightPosition:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the 3-dimensional point in image coordinates at which the spotlight points.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIVector LightPointsAt {
			[Export ("lightPointsAt", ArgumentSemantic.Retain)]
			get {
				return _GetLightPointsAt (this);
			}
			[Export ("setLightPointsAt:", ArgumentSemantic.Retain)]
			set {
				_SetLightPointsAt (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIVector _GetLightPointsAt (ICISpotLightProtocol This)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("lightPointsAt")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLightPointsAt (ICISpotLightProtocol This, CIVector value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLightPointsAt:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the brightness of the spotlight.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Brightness {
			[Export ("brightness")]
			get {
				return _GetBrightness (this);
			}
			[Export ("setBrightness:")]
			set {
				_SetBrightness (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetBrightness (ICISpotLightProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("brightness"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBrightness (ICISpotLightProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setBrightness:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a value that controls how tightly the spotlight beam is focused.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Concentration {
			[Export ("concentration")]
			get {
				return _GetConcentration (this);
			}
			[Export ("setConcentration:")]
			set {
				_SetConcentration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetConcentration (ICISpotLightProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("concentration"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetConcentration (ICISpotLightProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setConcentration:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the color of the spotlight.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				return _GetColor (this);
			}
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				_SetColor (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetColor (ICISpotLightProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor (ICISpotLightProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CISpotLightProtocolWrapper : BaseWrapper, ICISpotLightProtocol {
		public CISpotLightProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CISpotLightProtocolWrapper))]
		static CISpotLightProtocolWrapper ()
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
		/// <summary>Gets or sets the 3-dimensional point in image coordinates from which the spotlight shines.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector LightPosition {
			[Export ("lightPosition", ArgumentSemantic.Retain)]
			get {
				CIVector ret;
				ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lightPosition")), false)!;
				return ret;
			}
			[Export ("setLightPosition:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLightPosition:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the 3-dimensional point in image coordinates at which the spotlight points.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector LightPointsAt {
			[Export ("lightPointsAt", ArgumentSemantic.Retain)]
			get {
				CIVector ret;
				ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lightPointsAt")), false)!;
				return ret;
			}
			[Export ("setLightPointsAt:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLightPointsAt:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the brightness of the spotlight.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Brightness {
			[Export ("brightness")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("brightness"));
				return ret;
			}
			[Export ("setBrightness:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBrightness:"), value);
			}
		}
		/// <summary>Gets or sets a value that controls how tightly the spotlight beam is focused.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Concentration {
			[Export ("concentration")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("concentration"));
				return ret;
			}
			[Export ("setConcentration:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setConcentration:"), value);
			}
		}
		/// <summary>Gets or sets the color of the spotlight.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("color")), false)!;
				return ret;
			}
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColor:"), value__handle__);
				GC.KeepAlive (value);
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
