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
namespace CoreImage {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CISpotColor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CISpotColor", WrapperType = typeof (CISpotColorProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof (CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor1", Selector = "centerColor1", PropertyType = typeof (CIColor), GetterSelector = "centerColor1", SetterSelector = "setCenterColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor1", Selector = "replacementColor1", PropertyType = typeof (CIColor), GetterSelector = "replacementColor1", SetterSelector = "setReplacementColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness1", Selector = "closeness1", PropertyType = typeof (float), GetterSelector = "closeness1", SetterSelector = "setCloseness1:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast1", Selector = "contrast1", PropertyType = typeof (float), GetterSelector = "contrast1", SetterSelector = "setContrast1:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor2", Selector = "centerColor2", PropertyType = typeof (CIColor), GetterSelector = "centerColor2", SetterSelector = "setCenterColor2:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor2", Selector = "replacementColor2", PropertyType = typeof (CIColor), GetterSelector = "replacementColor2", SetterSelector = "setReplacementColor2:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness2", Selector = "closeness2", PropertyType = typeof (float), GetterSelector = "closeness2", SetterSelector = "setCloseness2:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast2", Selector = "contrast2", PropertyType = typeof (float), GetterSelector = "contrast2", SetterSelector = "setContrast2:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterColor3", Selector = "centerColor3", PropertyType = typeof (CIColor), GetterSelector = "centerColor3", SetterSelector = "setCenterColor3:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplacementColor3", Selector = "replacementColor3", PropertyType = typeof (CIColor), GetterSelector = "replacementColor3", SetterSelector = "setReplacementColor3:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Closeness3", Selector = "closeness3", PropertyType = typeof (float), GetterSelector = "closeness3", SetterSelector = "setCloseness3:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contrast3", Selector = "contrast3", PropertyType = typeof (float), GetterSelector = "contrast3", SetterSelector = "setContrast3:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICISpotColorProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("CenterColor1")]
		[DynamicDependencyAttribute ("CenterColor2")]
		[DynamicDependencyAttribute ("CenterColor3")]
		[DynamicDependencyAttribute ("Closeness1")]
		[DynamicDependencyAttribute ("Closeness2")]
		[DynamicDependencyAttribute ("Closeness3")]
		[DynamicDependencyAttribute ("Contrast1")]
		[DynamicDependencyAttribute ("Contrast2")]
		[DynamicDependencyAttribute ("Contrast3")]
		[DynamicDependencyAttribute ("InputImage")]
		[DynamicDependencyAttribute ("ReplacementColor1")]
		[DynamicDependencyAttribute ("ReplacementColor2")]
		[DynamicDependencyAttribute ("ReplacementColor3")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CISpotColorProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICISpotColorProtocol ()
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
		internal static CIImage _GetInputImage (ICISpotColorProtocol This)
		{
			CIImage ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputImage (ICISpotColorProtocol This, CIImage? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the center of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor CenterColor1 {
			[Export ("centerColor1", ArgumentSemantic.Retain)]
			get {
				return _GetCenterColor1 (this);
			}
			[Export ("setCenterColor1:", ArgumentSemantic.Retain)]
			set {
				_SetCenterColor1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetCenterColor1 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("centerColor1")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenterColor1 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCenterColor1:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the first replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor ReplacementColor1 {
			[Export ("replacementColor1", ArgumentSemantic.Retain)]
			get {
				return _GetReplacementColor1 (this);
			}
			[Export ("setReplacementColor1:", ArgumentSemantic.Retain)]
			set {
				_SetReplacementColor1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetReplacementColor1 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("replacementColor1")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReplacementColor1 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setReplacementColor1:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the width about the center of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Closeness1 {
			[Export ("closeness1")]
			get {
				return _GetCloseness1 (this);
			}
			[Export ("setCloseness1:")]
			set {
				_SetCloseness1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetCloseness1 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("closeness1"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCloseness1 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCloseness1:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the contrast of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Contrast1 {
			[Export ("contrast1")]
			get {
				return _GetContrast1 (this);
			}
			[Export ("setContrast1:")]
			set {
				_SetContrast1 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetContrast1 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("contrast1"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContrast1 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setContrast1:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the center of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor CenterColor2 {
			[Export ("centerColor2", ArgumentSemantic.Retain)]
			get {
				return _GetCenterColor2 (this);
			}
			[Export ("setCenterColor2:", ArgumentSemantic.Retain)]
			set {
				_SetCenterColor2 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetCenterColor2 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("centerColor2")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenterColor2 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCenterColor2:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the second replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor ReplacementColor2 {
			[Export ("replacementColor2", ArgumentSemantic.Retain)]
			get {
				return _GetReplacementColor2 (this);
			}
			[Export ("setReplacementColor2:", ArgumentSemantic.Retain)]
			set {
				_SetReplacementColor2 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetReplacementColor2 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("replacementColor2")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReplacementColor2 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setReplacementColor2:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the width about the center of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Closeness2 {
			[Export ("closeness2")]
			get {
				return _GetCloseness2 (this);
			}
			[Export ("setCloseness2:")]
			set {
				_SetCloseness2 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetCloseness2 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("closeness2"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCloseness2 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCloseness2:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the contrast of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Contrast2 {
			[Export ("contrast2")]
			get {
				return _GetContrast2 (this);
			}
			[Export ("setContrast2:")]
			set {
				_SetContrast2 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetContrast2 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("contrast2"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContrast2 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setContrast2:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the center of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor CenterColor3 {
			[Export ("centerColor3", ArgumentSemantic.Retain)]
			get {
				return _GetCenterColor3 (this);
			}
			[Export ("setCenterColor3:", ArgumentSemantic.Retain)]
			set {
				_SetCenterColor3 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetCenterColor3 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("centerColor3")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenterColor3 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCenterColor3:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the third replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CIColor ReplacementColor3 {
			[Export ("replacementColor3", ArgumentSemantic.Retain)]
			get {
				return _GetReplacementColor3 (this);
			}
			[Export ("setReplacementColor3:", ArgumentSemantic.Retain)]
			set {
				_SetReplacementColor3 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIColor _GetReplacementColor3 (ICISpotColorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("replacementColor3")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReplacementColor3 (ICISpotColorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setReplacementColor3:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the width about the center of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Closeness3 {
			[Export ("closeness3")]
			get {
				return _GetCloseness3 (this);
			}
			[Export ("setCloseness3:")]
			set {
				_SetCloseness3 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetCloseness3 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("closeness3"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCloseness3 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCloseness3:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the contrast of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Contrast3 {
			[Export ("contrast3")]
			get {
				return _GetContrast3 (this);
			}
			[Export ("setContrast3:")]
			set {
				_SetContrast3 (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetContrast3 (ICISpotColorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("contrast3"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContrast3 (ICISpotColorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setContrast3:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CISpotColorProtocolWrapper : BaseWrapper, ICISpotColorProtocol {
		public CISpotColorProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CISpotColorProtocolWrapper))]
		static CISpotColorProtocolWrapper ()
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
		/// <summary>Gets or sets the center of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor CenterColor1 {
			[Export ("centerColor1", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("centerColor1")), false)!;
				return ret;
			}
			[Export ("setCenterColor1:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCenterColor1:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the first replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor ReplacementColor1 {
			[Export ("replacementColor1", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("replacementColor1")), false)!;
				return ret;
			}
			[Export ("setReplacementColor1:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReplacementColor1:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the width about the center of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Closeness1 {
			[Export ("closeness1")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("closeness1"));
				return ret;
			}
			[Export ("setCloseness1:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCloseness1:"), value);
			}
		}
		/// <summary>Gets or sets the contrast of the first color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Contrast1 {
			[Export ("contrast1")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("contrast1"));
				return ret;
			}
			[Export ("setContrast1:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setContrast1:"), value);
			}
		}
		/// <summary>Gets or sets the center of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor CenterColor2 {
			[Export ("centerColor2", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("centerColor2")), false)!;
				return ret;
			}
			[Export ("setCenterColor2:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCenterColor2:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the second replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor ReplacementColor2 {
			[Export ("replacementColor2", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("replacementColor2")), false)!;
				return ret;
			}
			[Export ("setReplacementColor2:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReplacementColor2:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the width about the center of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Closeness2 {
			[Export ("closeness2")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("closeness2"));
				return ret;
			}
			[Export ("setCloseness2:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCloseness2:"), value);
			}
		}
		/// <summary>Gets or sets the contrast of the second color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Contrast2 {
			[Export ("contrast2")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("contrast2"));
				return ret;
			}
			[Export ("setContrast2:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setContrast2:"), value);
			}
		}
		/// <summary>Gets or sets the center of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor CenterColor3 {
			[Export ("centerColor3", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("centerColor3")), false)!;
				return ret;
			}
			[Export ("setCenterColor3:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCenterColor3:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the third replacement color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor ReplacementColor3 {
			[Export ("replacementColor3", ArgumentSemantic.Retain)]
			get {
				CIColor ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("replacementColor3")), false)!;
				return ret;
			}
			[Export ("setReplacementColor3:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReplacementColor3:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the width about the center of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Closeness3 {
			[Export ("closeness3")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("closeness3"));
				return ret;
			}
			[Export ("setCloseness3:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCloseness3:"), value);
			}
		}
		/// <summary>Gets or sets the contrast of the third color range.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Contrast3 {
			[Export ("contrast3")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("contrast3"));
				return ret;
			}
			[Export ("setContrast3:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setContrast3:"), value);
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
