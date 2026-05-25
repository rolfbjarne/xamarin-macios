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
namespace MediaExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEVideoDecoderExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MEVideoDecoderExtension", WrapperType = typeof (MEVideoDecoderExtensionWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateVideoDecoder", Selector = "videoDecoderWithCodecType:videoFormatDescription:videoDecoderSpecifications:extensionDecoderPixelBufferManager:error:", ReturnType = typeof (MediaExtension.IMEVideoDecoder), ParameterType = new Type [] { typeof (CMVideoCodecType), typeof (CMVideoFormatDescription), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (MediaExtension.MEVideoDecoderPixelBufferManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, true })]
	public partial interface IMEVideoDecoderExtension : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> () where T: NSObject, IMEVideoDecoderExtension
		{
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (__handle__, Selector.GetHandle ("init"));
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("videoDecoderWithCodecType:videoFormatDescription:videoDecoderSpecifications:extensionDecoderPixelBufferManager:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMEVideoDecoder? CreateVideoDecoder (global::CoreMedia.CMVideoCodecType codecType, global::CoreMedia.CMVideoFormatDescription videoFormatDescription, NSDictionary<NSString, NSObject> videoDecoderSpecifications, MEVideoDecoderPixelBufferManager extensionDecoderPixelBufferManager, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMEVideoDecoder? _CreateVideoDecoder (IMEVideoDecoderExtension This, global::CoreMedia.CMVideoCodecType codecType, global::CoreMedia.CMVideoFormatDescription videoFormatDescription, NSDictionary<NSString, NSObject> videoDecoderSpecifications, MEVideoDecoderPixelBufferManager extensionDecoderPixelBufferManager, out NSError? error)
		{
			var videoFormatDescription__handle__ = videoFormatDescription!.GetNonNullHandle (nameof (videoFormatDescription));
			var videoDecoderSpecifications__handle__ = videoDecoderSpecifications!.GetNonNullHandle (nameof (videoDecoderSpecifications));
			var extensionDecoderPixelBufferManager__handle__ = extensionDecoderPixelBufferManager!.GetNonNullHandle (nameof (extensionDecoderPixelBufferManager));
			NativeHandle errorValue = IntPtr.Zero;
			IMEVideoDecoder? ret;
			ret =  Runtime.GetINativeObject<IMEVideoDecoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("videoDecoderWithCodecType:videoFormatDescription:videoDecoderSpecifications:extensionDecoderPixelBufferManager:error:"), (UInt32)codecType, videoFormatDescription.Handle, videoDecoderSpecifications__handle__, extensionDecoderPixelBufferManager__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (videoFormatDescription);
			GC.KeepAlive (videoDecoderSpecifications);
			GC.KeepAlive (extensionDecoderPixelBufferManager);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateVideoDecoder(CoreMedia.CMVideoCodecType,CoreMedia.CMVideoFormatDescription,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},MediaExtension.MEVideoDecoderPixelBufferManager,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEVideoDecoderExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEVideoDecoderExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEVideoDecoderExtensionWrapper : BaseWrapper, IMEVideoDecoderExtension {
		public MEVideoDecoderExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEVideoDecoderExtensionWrapper))]
		static MEVideoDecoderExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("videoDecoderWithCodecType:videoFormatDescription:videoDecoderSpecifications:extensionDecoderPixelBufferManager:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMEVideoDecoder? CreateVideoDecoder (global::CoreMedia.CMVideoCodecType codecType, global::CoreMedia.CMVideoFormatDescription videoFormatDescription, NSDictionary<NSString, NSObject> videoDecoderSpecifications, MEVideoDecoderPixelBufferManager extensionDecoderPixelBufferManager, out NSError? error)
		{
			var videoFormatDescription__handle__ = videoFormatDescription!.GetNonNullHandle (nameof (videoFormatDescription));
			var videoDecoderSpecifications__handle__ = videoDecoderSpecifications!.GetNonNullHandle (nameof (videoDecoderSpecifications));
			var extensionDecoderPixelBufferManager__handle__ = extensionDecoderPixelBufferManager!.GetNonNullHandle (nameof (extensionDecoderPixelBufferManager));
			NativeHandle errorValue = IntPtr.Zero;
			IMEVideoDecoder? ret;
			ret =  Runtime.GetINativeObject<IMEVideoDecoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("videoDecoderWithCodecType:videoFormatDescription:videoDecoderSpecifications:extensionDecoderPixelBufferManager:error:"), (UInt32)codecType, videoFormatDescription.Handle, videoDecoderSpecifications__handle__, extensionDecoderPixelBufferManager__handle__, &errorValue), false)!;
			GC.KeepAlive (videoFormatDescription);
			GC.KeepAlive (videoDecoderSpecifications);
			GC.KeepAlive (extensionDecoderPixelBufferManager);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
