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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Photos {
	#pragma warning disable CS1573
	/// <summary>Defines the interface for Live Photo frames that are produced by the system.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "PHLivePhotoFrame", WrapperType = typeof (PHLivePhotoFrameWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof (CIImage), GetterSelector = "image", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof (CMTime), GetterSelector = "time", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (PHLivePhotoFrameType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenderScale", Selector = "renderScale", PropertyType = typeof (NFloat), GetterSelector = "renderScale", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IPHLivePhotoFrame : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Image")]
		[DynamicDependencyAttribute ("RenderScale")]
		[DynamicDependencyAttribute ("Time")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHLivePhotoFrameWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHLivePhotoFrame ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the image that will be processed.</summary><value>The image that will be processed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreImage.CIImage Image {
			[Export ("image")]
			get {
				return _GetImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreImage.CIImage _GetImage (IPHLivePhotoFrame This)
		{
			global::CoreImage.CIImage ret;
			ret =  Runtime.GetNSObject<global::CoreImage.CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("image")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the time, in seconds from the beginning of the Live Photo, when the image appears.</summary><value>The time, in seconds from the beginning of the Live Photo, when the image appears.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMTime Time {
			[Export ("time")]
			get {
				return _GetTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetTime (IPHLivePhotoFrame This)
		{
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (This.Handle, Selector.GetHandle ("time"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (This.Handle, Selector.GetHandle ("time"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>Gets a value that tells whether the image is a still photo or a video frame.</summary><value>A value that tells whether the image is a still photo or a video frame.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual PHLivePhotoFrameType Type {
			[Export ("type")]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PHLivePhotoFrameType _GetType (IPHLivePhotoFrame This)
		{
			PHLivePhotoFrameType ret;
			ret = (PHLivePhotoFrameType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets the relative scale of <see cref="T:Photos.IPHLivePhotoFrame" /> compared to the Live Photo.</summary><value>The relative scale of <see cref="T:Photos.IPHLivePhotoFrame" /> compared to the Live Photo.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat RenderScale {
			[Export ("renderScale")]
			get {
				return _GetRenderScale (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetRenderScale (IPHLivePhotoFrame This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("renderScale"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHLivePhotoFrameWrapper : BaseWrapper, IPHLivePhotoFrame {
		public PHLivePhotoFrameWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHLivePhotoFrameWrapper))]
		static PHLivePhotoFrameWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the image that will be processed.</summary><value>The image that will be processed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreImage.CIImage Image {
			[Export ("image")]
			get {
				global::CoreImage.CIImage ret;
				ret =  Runtime.GetNSObject<global::CoreImage.CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the time, in seconds from the beginning of the Live Photo, when the image appears.</summary><value>The time, in seconds from the beginning of the Live Photo, when the image appears.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTime Time {
			[Export ("time")]
			get {
				global::CoreMedia.CMTime ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("time"));
				} else {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("time"));
				}
				return ret!;
			}
		}
		/// <summary>Gets a value that tells whether the image is a still photo or a video frame.</summary><value>A value that tells whether the image is a still photo or a video frame.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHLivePhotoFrameType Type {
			[Export ("type")]
			get {
				PHLivePhotoFrameType ret;
				ret = (PHLivePhotoFrameType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		/// <summary>Gets the relative scale of <see cref="T:Photos.IPHLivePhotoFrame" /> compared to the Live Photo.</summary><value>The relative scale of <see cref="T:Photos.IPHLivePhotoFrame" /> compared to the Live Photo.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat RenderScale {
			[Export ("renderScale")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("renderScale"));
				return ret;
			}
		}
	}
}
