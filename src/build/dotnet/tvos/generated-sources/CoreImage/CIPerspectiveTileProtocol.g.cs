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
	/// <summary>This interface represents the Objective-C protocol <c>CIPerspectiveTile</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIPerspectiveTile", WrapperType = typeof (CIPerspectiveTileProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof (CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputTopLeft", Selector = "topLeft", PropertyType = typeof (CGPoint), GetterSelector = "topLeft", SetterSelector = "setTopLeft:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputTopRight", Selector = "topRight", PropertyType = typeof (CGPoint), GetterSelector = "topRight", SetterSelector = "setTopRight:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputBottomRight", Selector = "bottomRight", PropertyType = typeof (CGPoint), GetterSelector = "bottomRight", SetterSelector = "setBottomRight:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputBottomLeft", Selector = "bottomLeft", PropertyType = typeof (CGPoint), GetterSelector = "bottomLeft", SetterSelector = "setBottomLeft:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface ICIPerspectiveTileProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("InputBottomLeft")]
		[DynamicDependencyAttribute ("InputBottomRight")]
		[DynamicDependencyAttribute ("InputImage")]
		[DynamicDependencyAttribute ("InputTopLeft")]
		[DynamicDependencyAttribute ("InputTopRight")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIPerspectiveTileProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIPerspectiveTileProtocol ()
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
		internal static CIImage _GetInputImage (ICIPerspectiveTileProtocol This)
		{
			CIImage ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputImage (ICIPerspectiveTileProtocol This, CIImage? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets location of the top left corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint InputTopLeft {
			[Export ("topLeft", ArgumentSemantic.Assign)]
			get {
				return _GetInputTopLeft (this);
			}
			[Export ("setTopLeft:", ArgumentSemantic.Assign)]
			set {
				_SetInputTopLeft (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetInputTopLeft (ICIPerspectiveTileProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("topLeft"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputTopLeft (ICIPerspectiveTileProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setTopLeft:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets location of the top right corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint InputTopRight {
			[Export ("topRight", ArgumentSemantic.Assign)]
			get {
				return _GetInputTopRight (this);
			}
			[Export ("setTopRight:", ArgumentSemantic.Assign)]
			set {
				_SetInputTopRight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetInputTopRight (ICIPerspectiveTileProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("topRight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputTopRight (ICIPerspectiveTileProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setTopRight:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets location of the bottom right corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint InputBottomRight {
			[Export ("bottomRight", ArgumentSemantic.Assign)]
			get {
				return _GetInputBottomRight (this);
			}
			[Export ("setBottomRight:", ArgumentSemantic.Assign)]
			set {
				_SetInputBottomRight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetInputBottomRight (ICIPerspectiveTileProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("bottomRight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputBottomRight (ICIPerspectiveTileProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setBottomRight:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets location of the bottom left corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint InputBottomLeft {
			[Export ("bottomLeft", ArgumentSemantic.Assign)]
			get {
				return _GetInputBottomLeft (this);
			}
			[Export ("setBottomLeft:", ArgumentSemantic.Assign)]
			set {
				_SetInputBottomLeft (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetInputBottomLeft (ICIPerspectiveTileProtocol This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("bottomLeft"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputBottomLeft (ICIPerspectiveTileProtocol This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setBottomLeft:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIPerspectiveTileProtocolWrapper : BaseWrapper, ICIPerspectiveTileProtocol {
		public CIPerspectiveTileProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIPerspectiveTileProtocolWrapper))]
		static CIPerspectiveTileProtocolWrapper ()
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
		/// <summary>Gets or sets location of the top left corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputTopLeft {
			[Export ("topLeft", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("topLeft"));
				return ret;
			}
			[Export ("setTopLeft:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setTopLeft:"), value);
			}
		}
		/// <summary>Gets or sets location of the top right corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputTopRight {
			[Export ("topRight", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("topRight"));
				return ret;
			}
			[Export ("setTopRight:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setTopRight:"), value);
			}
		}
		/// <summary>Gets or sets location of the bottom right corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputBottomRight {
			[Export ("bottomRight", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("bottomRight"));
				return ret;
			}
			[Export ("setBottomRight:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setBottomRight:"), value);
			}
		}
		/// <summary>Gets or sets location of the bottom left corner of the source image in the output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputBottomLeft {
			[Export ("bottomLeft", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("bottomLeft"));
				return ret;
			}
			[Export ("setBottomLeft:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setBottomLeft:"), value);
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
