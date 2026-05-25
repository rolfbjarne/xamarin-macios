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
	/// <summary>Interface defining an image provider.</summary>
	[Protocol (Name = "CIImageProvider", WrapperType = typeof (CIImageProviderWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideImageData", Selector = "provideImageData:bytesPerRow:origin::size::userInfo:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProvideImageToMTLTexture", Selector = "provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (IMTLCommandBuffer), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	public partial interface ICIImageProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("provideImageData:bytesPerRow:origin::size::userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProvideImageData (nint data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProvideImageData (ICIImageProvider This, nint data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info)
		{
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("provideImageData:bytesPerRow:origin::size::userInfo:"), data, rowbytes, x, y, width, height, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (info);
		}
		[global::Foundation.OptionalMember]
		[Export ("provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProvideImageToMTLTexture (global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer commandBuffer, nuint originx, nuint originy, nuint width, nuint height, NSObject? info)
		{
			_ProvideImageToMTLTexture (this, texture, commandBuffer, originx, originy, width, height, info);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProvideImageToMTLTexture (ICIImageProvider This, global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer commandBuffer, nuint originx, nuint originy, nuint width, nuint height, NSObject? info)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:"), texture__handle__, commandBuffer__handle__, originx, originy, width, height, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (info);
		}
		[DynamicDependencyAttribute ("ProvideImageData(System.IntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ProvideImageToMTLTexture(Metal.IMTLTexture,Metal.IMTLCommandBuffer,System.UIntPtr,System.UIntPtr,System.UIntPtr,System.UIntPtr,Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIImageProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICIImageProvider" /> interface to support all the methods from the CIImageProvider protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICIImageProvider" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CIImageProvider protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CIImageProvider_Extensions {
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProvideImageToMTLTexture (this ICIImageProvider This, global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer commandBuffer, nuint originx, nuint originy, nuint width, nuint height, NSObject? info)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:"), texture__handle__, commandBuffer__handle__, originx, originy, width, height, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (info);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIImageProviderWrapper : BaseWrapper, ICIImageProvider {
		public CIImageProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIImageProviderWrapper))]
		static CIImageProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("provideImageData:bytesPerRow:origin::size::userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ProvideImageData (nint data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info)
		{
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("provideImageData:bytesPerRow:origin::size::userInfo:"), data, rowbytes, x, y, width, height, info__handle__);
			GC.KeepAlive (info);
		}
	}
}
