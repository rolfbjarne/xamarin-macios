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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CIRadialGradient</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIRadialGradient", WrapperType = typeof (CIRadialGradientProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof (CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius0", Selector = "radius0", PropertyType = typeof (float), GetterSelector = "radius0", SetterSelector = "setRadius0:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Radius1", Selector = "radius1", PropertyType = typeof (float), GetterSelector = "radius1", SetterSelector = "setRadius1:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color0", Selector = "color0", PropertyType = typeof (CIColor), GetterSelector = "color0", SetterSelector = "setColor0:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color1", Selector = "color1", PropertyType = typeof (CIColor), GetterSelector = "color1", SetterSelector = "setColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICIRadialGradientProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("Color0")]
		[DynamicDependencyAttribute ("Color1")]
		[DynamicDependencyAttribute ("InputCenter")]
		[DynamicDependencyAttribute ("Radius0")]
		[DynamicDependencyAttribute ("Radius1")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIRadialGradientProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIRadialGradientProtocol ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the center of the gradient.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint InputCenter {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				return _GetInputCenter (this);
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				_SetInputCenter (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetInputCenter (ICIRadialGradientProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("center"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputCenter (ICIRadialGradientProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setCenter:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the first radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Radius0 {
			[Export ("radius0")]
			get {
				return _GetRadius0 (this);
			}
			[Export ("setRadius0:")]
			set {
				_SetRadius0 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetRadius0 (ICIRadialGradientProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("radius0"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRadius0 (ICIRadialGradientProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setRadius0:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the second radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Radius1 {
			[Export ("radius1")]
			get {
				return _GetRadius1 (this);
			}
			[Export ("setRadius1:")]
			set {
				_SetRadius1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetRadius1 (ICIRadialGradientProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("radius1"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRadius1 (ICIRadialGradientProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setRadius1:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius0" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor Color0 {
			[Export ("color0", ArgumentSemantic.Retain)]
			get {
				return _GetColor0 (this);
			}
			[Export ("setColor0:", ArgumentSemantic.Retain)]
			set {
				_SetColor0 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetColor0 (ICIRadialGradientProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color0")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor0 (ICIRadialGradientProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor0:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius1" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor Color1 {
			[Export ("color1", ArgumentSemantic.Retain)]
			get {
				return _GetColor1 (this);
			}
			[Export ("setColor1:", ArgumentSemantic.Retain)]
			set {
				_SetColor1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetColor1 (ICIRadialGradientProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color1")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor1 (ICIRadialGradientProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor1:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIRadialGradientProtocolWrapper : BaseWrapper, ICIRadialGradientProtocol {
		public CIRadialGradientProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIRadialGradientProtocolWrapper))]
		static CIRadialGradientProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the center of the gradient.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputCenter {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("center"));
				return ret;
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setCenter:"), value);
			}
		}
		/// <summary>Gets or sets the first radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Radius0 {
			[Export ("radius0")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("radius0"));
				return ret;
			}
			[Export ("setRadius0:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRadius0:"), value);
			}
		}
		/// <summary>Gets or sets the second radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Radius1 {
			[Export ("radius1")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("radius1"));
				return ret;
			}
			[Export ("setRadius1:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRadius1:"), value);
			}
		}
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius0" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color0 {
			[Export ("color0", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("color0")), false)!;
				return ret;
			}
			[Export ("setColor0:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColor0:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius1" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color1 {
			[Export ("color1", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("color1")), false)!;
				return ret;
			}
			[Export ("setColor1:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColor1:"), value__handle__);
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
