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
	/// <summary>This interface represents the Objective-C protocol <c>CIFlashTransition</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIFlashTransition", WrapperType = typeof (CIFlashTransitionProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCenter", Selector = "center", PropertyType = typeof (CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputExtent", Selector = "extent", PropertyType = typeof (CGRect), GetterSelector = "extent", SetterSelector = "setExtent:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color", Selector = "color", PropertyType = typeof (CIColor), GetterSelector = "color", SetterSelector = "setColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxStriationRadius", Selector = "maxStriationRadius", PropertyType = typeof (float), GetterSelector = "maxStriationRadius", SetterSelector = "setMaxStriationRadius:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationStrength", Selector = "striationStrength", PropertyType = typeof (float), GetterSelector = "striationStrength", SetterSelector = "setStriationStrength:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StriationContrast", Selector = "striationContrast", PropertyType = typeof (float), GetterSelector = "striationContrast", SetterSelector = "setStriationContrast:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FadeThreshold", Selector = "fadeThreshold", PropertyType = typeof (float), GetterSelector = "fadeThreshold", SetterSelector = "setFadeThreshold:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIFlashTransitionProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
		, CoreImage.ICITransitionFilterProtocol
	{
		[DynamicDependencyAttribute ("Color")]
		[DynamicDependencyAttribute ("FadeThreshold")]
		[DynamicDependencyAttribute ("InputCenter")]
		[DynamicDependencyAttribute ("InputExtent")]
		[DynamicDependencyAttribute ("MaxStriationRadius")]
		[DynamicDependencyAttribute ("StriationContrast")]
		[DynamicDependencyAttribute ("StriationStrength")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIFlashTransitionProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIFlashTransitionProtocol ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or set the center of the flash.</summary>
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
		internal static CGPoint _GetInputCenter (ICIFlashTransitionProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("center"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputCenter (ICIFlashTransitionProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setCenter:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a vector of the form (x,y,w,h) that represents the rectangular extent of the flash.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect InputExtent {
			[Export ("extent", ArgumentSemantic.Assign)]
			get {
				return _GetInputExtent (this);
			}
			[Export ("setExtent:", ArgumentSemantic.Assign)]
			set {
				_SetInputExtent (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetInputExtent (ICIFlashTransitionProtocol This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("extent"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("extent"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputExtent (ICIFlashTransitionProtocol This, CGRect value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("setExtent:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the color of the flash.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		internal static CIColor _GetColor (ICIFlashTransitionProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor (ICIFlashTransitionProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the maximum radius of the flash effect.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MaxStriationRadius {
			[Export ("maxStriationRadius")]
			get {
				return _GetMaxStriationRadius (this);
			}
			[Export ("setMaxStriationRadius:")]
			set {
				_SetMaxStriationRadius (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMaxStriationRadius (ICIFlashTransitionProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("maxStriationRadius"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMaxStriationRadius (ICIFlashTransitionProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMaxStriationRadius:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the strength of the striations in the flash.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float StriationStrength {
			[Export ("striationStrength")]
			get {
				return _GetStriationStrength (this);
			}
			[Export ("setStriationStrength:")]
			set {
				_SetStriationStrength (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetStriationStrength (ICIFlashTransitionProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("striationStrength"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStriationStrength (ICIFlashTransitionProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setStriationStrength:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the striation contrast.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float StriationContrast {
			[Export ("striationContrast")]
			get {
				return _GetStriationContrast (this);
			}
			[Export ("setStriationContrast:")]
			set {
				_SetStriationContrast (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetStriationContrast (ICIFlashTransitionProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("striationContrast"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStriationContrast (ICIFlashTransitionProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setStriationContrast:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the threshold at which the flash starts or stops appearing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float FadeThreshold {
			[Export ("fadeThreshold")]
			get {
				return _GetFadeThreshold (this);
			}
			[Export ("setFadeThreshold:")]
			set {
				_SetFadeThreshold (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetFadeThreshold (ICIFlashTransitionProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("fadeThreshold"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFadeThreshold (ICIFlashTransitionProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setFadeThreshold:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIFlashTransitionProtocolWrapper : BaseWrapper, ICIFlashTransitionProtocol {
		public CIFlashTransitionProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIFlashTransitionProtocolWrapper))]
		static CIFlashTransitionProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or set the center of the flash.</summary>
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
		/// <summary>Gets or sets a vector of the form (x,y,w,h) that represents the rectangular extent of the flash.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect InputExtent {
			[Export ("extent", ArgumentSemantic.Assign)]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("extent"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("extent"));
				}
				return ret!;
			}
			[Export ("setExtent:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setExtent:"), value);
			}
		}
		/// <summary>Gets or sets the color of the flash.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the maximum radius of the flash effect.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MaxStriationRadius {
			[Export ("maxStriationRadius")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maxStriationRadius"));
				return ret;
			}
			[Export ("setMaxStriationRadius:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaxStriationRadius:"), value);
			}
		}
		/// <summary>Gets or sets the strength of the striations in the flash.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float StriationStrength {
			[Export ("striationStrength")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("striationStrength"));
				return ret;
			}
			[Export ("setStriationStrength:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStriationStrength:"), value);
			}
		}
		/// <summary>Gets or sets the striation contrast.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float StriationContrast {
			[Export ("striationContrast")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("striationContrast"));
				return ret;
			}
			[Export ("setStriationContrast:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStriationContrast:"), value);
			}
		}
		/// <summary>Gets or sets the threshold at which the flash starts or stops appearing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float FadeThreshold {
			[Export ("fadeThreshold")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("fadeThreshold"));
				return ret;
			}
			[Export ("setFadeThreshold:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setFadeThreshold:"), value);
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
		/// <summary>Gets or sets an image to filter.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public CIImage? InputImage {
			[Export ("inputImage", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputImage")), false)!;
				return ret;
			}
			[Export ("setInputImage:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>The image that will be displayed at the end of the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public CIImage? TargetImage {
			[Export ("targetImage", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("targetImage")), false)!;
				return ret;
			}
			[Export ("setTargetImage:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTargetImage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the current time in the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public float Time {
			[Export ("time")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("time"));
				return ret;
			}
			[Export ("setTime:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setTime:"), value);
			}
		}
	}
}
