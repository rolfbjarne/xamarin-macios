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
	/// <summary>This interface represents the Objective-C protocol <c>CIColorCubeWithColorSpace</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIColorCubeWithColorSpace", WrapperType = typeof (CIColorCubeWithColorSpaceProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof (CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubeDimension", Selector = "cubeDimension", PropertyType = typeof (float), GetterSelector = "cubeDimension", SetterSelector = "setCubeDimension:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubeData", Selector = "cubeData", PropertyType = typeof (NSData), GetterSelector = "cubeData", SetterSelector = "setCubeData:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorSpace", Selector = "colorSpace", PropertyType = typeof (CGColorSpace), GetterSelector = "colorSpace", SetterSelector = "setColorSpace:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Extrapolate", Selector = "extrapolate", PropertyType = typeof (bool), GetterSelector = "extrapolate", SetterSelector = "setExtrapolate:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIColorCubeWithColorSpaceProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("ColorSpace")]
		[DynamicDependencyAttribute ("CubeData")]
		[DynamicDependencyAttribute ("CubeDimension")]
		[DynamicDependencyAttribute ("Extrapolate")]
		[DynamicDependencyAttribute ("InputImage")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIColorCubeWithColorSpaceProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIColorCubeWithColorSpaceProtocol ()
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
		internal static CIImage _GetInputImage (ICIColorCubeWithColorSpaceProtocol This)
		{
			CIImage ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputImage (ICIColorCubeWithColorSpaceProtocol This, CIImage? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float CubeDimension {
			[Export ("cubeDimension")]
			get {
				return _GetCubeDimension (this);
			}
			[Export ("setCubeDimension:")]
			set {
				_SetCubeDimension (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetCubeDimension (ICIColorCubeWithColorSpaceProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("cubeDimension"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCubeDimension (ICIColorCubeWithColorSpaceProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCubeDimension:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData CubeData {
			[Export ("cubeData", ArgumentSemantic.Retain)]
			get {
				return _GetCubeData (this);
			}
			[Export ("setCubeData:", ArgumentSemantic.Retain)]
			set {
				_SetCubeData (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetCubeData (ICIColorCubeWithColorSpaceProtocol This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("cubeData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCubeData (ICIColorCubeWithColorSpaceProtocol This, NSData value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCubeData:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the color space to use.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGColorSpace? ColorSpace {
			[Export ("colorSpace", ArgumentSemantic.Assign)]
			get {
				return _GetColorSpace (this);
			}
			[Export ("setColorSpace:", ArgumentSemantic.Assign)]
			set {
				_SetColorSpace (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGColorSpace _GetColorSpace (ICIColorCubeWithColorSpaceProtocol This)
		{
			CGColorSpace ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("colorSpace")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorSpace (ICIColorCubeWithColorSpaceProtocol This, CGColorSpace? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setColorSpace:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.OptionalMember]
		public virtual bool Extrapolate {
			[Export ("extrapolate")]
			get {
				return _GetExtrapolate (this);
			}
			[Export ("setExtrapolate:")]
			set {
				_SetExtrapolate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetExtrapolate (ICIColorCubeWithColorSpaceProtocol This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("extrapolate"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetExtrapolate (ICIColorCubeWithColorSpaceProtocol This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setExtrapolate:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICIColorCubeWithColorSpaceProtocol" /> interface to support all the methods from the CIColorCubeWithColorSpace protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICIColorCubeWithColorSpaceProtocol" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CIColorCubeWithColorSpace protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CIColorCubeWithColorSpaceProtocol_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetExtrapolate (this ICIColorCubeWithColorSpaceProtocol This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("extrapolate"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetExtrapolate (this ICIColorCubeWithColorSpaceProtocol This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setExtrapolate:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIColorCubeWithColorSpaceProtocolWrapper : BaseWrapper, ICIColorCubeWithColorSpaceProtocol {
		public CIColorCubeWithColorSpaceProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIColorCubeWithColorSpaceProtocolWrapper))]
		static CIColorCubeWithColorSpaceProtocolWrapper ()
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
		public float CubeDimension {
			[Export ("cubeDimension")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("cubeDimension"));
				return ret;
			}
			[Export ("setCubeDimension:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCubeDimension:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData CubeData {
			[Export ("cubeData", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cubeData")), false)!;
				return ret;
			}
			[Export ("setCubeData:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCubeData:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the color space to use.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGColorSpace? ColorSpace {
			[Export ("colorSpace", ArgumentSemantic.Assign)]
			get {
				CGColorSpace ret;
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colorSpace")), false)!;
				return ret;
			}
			[Export ("setColorSpace:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColorSpace:"), value__handle__);
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
