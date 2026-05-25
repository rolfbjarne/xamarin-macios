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
	/// <summary>This interface represents the Objective-C protocol <c>CIRoundedQRCodeGenerator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "CIRoundedQRCodeGenerator", WrapperType = typeof (CIRoundedQRCodeGeneratorProtocolWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof (NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CorrectionLevel", Selector = "correctionLevel", PropertyType = typeof (string), GetterSelector = "correctionLevel", SetterSelector = "setCorrectionLevel:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scale", Selector = "scale", PropertyType = typeof (float), GetterSelector = "scale", SetterSelector = "setScale:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RoundedMarkers", Selector = "roundedMarkers", PropertyType = typeof (IntPtr), GetterSelector = "roundedMarkers", SetterSelector = "setRoundedMarkers:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RoundedData", Selector = "roundedData", PropertyType = typeof (bool), GetterSelector = "roundedData", SetterSelector = "setRoundedData:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CenterSpaceSize", Selector = "centerSpaceSize", PropertyType = typeof (float), GetterSelector = "centerSpaceSize", SetterSelector = "setCenterSpaceSize:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color0", Selector = "color0", PropertyType = typeof (CIColor), GetterSelector = "color0", SetterSelector = "setColor0:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Color1", Selector = "color1", PropertyType = typeof (CIColor), GetterSelector = "color1", SetterSelector = "setColor1:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICIRoundedQRCodeGeneratorProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("CenterSpaceSize")]
		[DynamicDependencyAttribute ("Color0")]
		[DynamicDependencyAttribute ("Color1")]
		[DynamicDependencyAttribute ("CorrectionLevel")]
		[DynamicDependencyAttribute ("Message")]
		[DynamicDependencyAttribute ("RoundedData")]
		[DynamicDependencyAttribute ("RoundedMarkers")]
		[DynamicDependencyAttribute ("Scale")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIRoundedQRCodeGeneratorProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIRoundedQRCodeGeneratorProtocol ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				return _GetMessage (this);
			}
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				_SetMessage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetMessage (ICIRoundedQRCodeGeneratorProtocol This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("message")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMessage (ICIRoundedQRCodeGeneratorProtocol This, NSData value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMessage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string CorrectionLevel {
			[Export ("correctionLevel", ArgumentSemantic.Retain)]
			get {
				return _GetCorrectionLevel (this);
			}
			[Export ("setCorrectionLevel:", ArgumentSemantic.Retain)]
			set {
				_SetCorrectionLevel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetCorrectionLevel (ICIRoundedQRCodeGeneratorProtocol This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("correctionLevel")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCorrectionLevel (ICIRoundedQRCodeGeneratorProtocol This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCorrectionLevel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
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
		internal static float _GetScale (ICIRoundedQRCodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("scale"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScale (ICIRoundedQRCodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setScale:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint RoundedMarkers {
			[Export ("roundedMarkers")]
			get {
				return _GetRoundedMarkers (this);
			}
			[Export ("setRoundedMarkers:")]
			set {
				_SetRoundedMarkers (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetRoundedMarkers (ICIRoundedQRCodeGeneratorProtocol This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("roundedMarkers"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRoundedMarkers (ICIRoundedQRCodeGeneratorProtocol This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRoundedMarkers:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool RoundedData {
			[Export ("roundedData")]
			get {
				return _GetRoundedData (this);
			}
			[Export ("setRoundedData:")]
			set {
				_SetRoundedData (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRoundedData (ICIRoundedQRCodeGeneratorProtocol This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("roundedData"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRoundedData (ICIRoundedQRCodeGeneratorProtocol This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setRoundedData:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float CenterSpaceSize {
			[Export ("centerSpaceSize")]
			get {
				return _GetCenterSpaceSize (this);
			}
			[Export ("setCenterSpaceSize:")]
			set {
				_SetCenterSpaceSize (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetCenterSpaceSize (ICIRoundedQRCodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("centerSpaceSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenterSpaceSize (ICIRoundedQRCodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCenterSpaceSize:"), value);
			GC.KeepAlive (This);
		}
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
		internal static CIColor _GetColor0 (ICIRoundedQRCodeGeneratorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color0")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor0 (ICIRoundedQRCodeGeneratorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor0:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
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
		internal static CIColor _GetColor1 (ICIRoundedQRCodeGeneratorProtocol This)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("color1")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColor1 (ICIRoundedQRCodeGeneratorProtocol This, CIColor value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColor1:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIRoundedQRCodeGeneratorProtocolWrapper : BaseWrapper, ICIRoundedQRCodeGeneratorProtocol {
		public CIRoundedQRCodeGeneratorProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIRoundedQRCodeGeneratorProtocolWrapper))]
		static CIRoundedQRCodeGeneratorProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("message")), false)!;
				return ret;
			}
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMessage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string CorrectionLevel {
			[Export ("correctionLevel", ArgumentSemantic.Retain)]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("correctionLevel")), false)!;
				return ret;
			}
			[Export ("setCorrectionLevel:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCorrectionLevel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
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
		public nint RoundedMarkers {
			[Export ("roundedMarkers")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("roundedMarkers"));
				return ret;
			}
			[Export ("setRoundedMarkers:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRoundedMarkers:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool RoundedData {
			[Export ("roundedData")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("roundedData"));
				return ret != 0;
			}
			[Export ("setRoundedData:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRoundedData:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float CenterSpaceSize {
			[Export ("centerSpaceSize")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("centerSpaceSize"));
				return ret;
			}
			[Export ("setCenterSpaceSize:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCenterSpaceSize:"), value);
			}
		}
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
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputImage")), false)!;
				return ret;
			}
		}
	}
}
