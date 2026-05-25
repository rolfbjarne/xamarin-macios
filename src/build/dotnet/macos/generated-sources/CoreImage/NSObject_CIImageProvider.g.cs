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
	/// <summary>Interface defining an image provider.</summary>
	public unsafe static partial class NSObject_CIImageProvider  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProvideImageData_BytesPerRow_Origin__Size__UserInfo_X = "provideImageData:bytesPerRow:origin::size::userInfo:";
		static readonly NativeHandle selProvideImageData_BytesPerRow_Origin__Size__UserInfo_XHandle = Selector.GetHandle ("provideImageData:bytesPerRow:origin::size::userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProvideImageToMTLTexture_CommandBuffer_Originx_Originy_Width_Height_UserInfo_X = "provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:";
		static readonly NativeHandle selProvideImageToMTLTexture_CommandBuffer_Originx_Originy_Width_Height_UserInfo_XHandle = Selector.GetHandle ("provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		[Export ("provideImageData:bytesPerRow:origin::size::userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProvideImageData (this NSObject This, nint data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("provideImageToMTLTexture:commandBuffer:originx:originy:width:height:userInfo:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProvideImageToMTLTexture (this NSObject This, global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer commandBuffer, nuint originx, nuint originy, nuint width, nuint height, NSObject? info)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var info__handle__ = info.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_NativeHandle (This.Handle, selProvideImageToMTLTexture_CommandBuffer_Originx_Originy_Width_Height_UserInfo_XHandle, texture__handle__, commandBuffer__handle__, originx, originy, width, height, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (info);
		}
	} /* class NSObject_CIImageProvider */
}
