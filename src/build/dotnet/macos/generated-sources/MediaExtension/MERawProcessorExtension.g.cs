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
	/// <summary>This interface represents the Objective-C protocol <c>MERAWProcessorExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MERAWProcessorExtension", WrapperType = typeof (MERawProcessorExtensionWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateProcessor", Selector = "processorWithFormatDescription:extensionPixelBufferManager:error:", ReturnType = typeof (MediaExtension.IMERawProcessor), ParameterType = new Type [] { typeof (CMVideoFormatDescription), typeof (MediaExtension.MERawProcessorPixelBufferManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public partial interface IMERawProcessorExtension : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> () where T: NSObject, IMERawProcessorExtension
		{
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (__handle__, Selector.GetHandle ("init"));
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("processorWithFormatDescription:extensionPixelBufferManager:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMERawProcessor? CreateProcessor (global::CoreMedia.CMVideoFormatDescription formatDescription, MERawProcessorPixelBufferManager extensionPixelBufferManager, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMERawProcessor? _CreateProcessor (IMERawProcessorExtension This, global::CoreMedia.CMVideoFormatDescription formatDescription, MERawProcessorPixelBufferManager extensionPixelBufferManager, out NSError? error)
		{
			var formatDescription__handle__ = formatDescription!.GetNonNullHandle (nameof (formatDescription));
			var extensionPixelBufferManager__handle__ = extensionPixelBufferManager!.GetNonNullHandle (nameof (extensionPixelBufferManager));
			NativeHandle errorValue = IntPtr.Zero;
			IMERawProcessor? ret;
			ret =  Runtime.GetINativeObject<IMERawProcessor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("processorWithFormatDescription:extensionPixelBufferManager:error:"), formatDescription.Handle, extensionPixelBufferManager__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (formatDescription);
			GC.KeepAlive (extensionPixelBufferManager);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateProcessor(CoreMedia.CMVideoFormatDescription,MediaExtension.MERawProcessorPixelBufferManager,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MERawProcessorExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMERawProcessorExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MERawProcessorExtensionWrapper : BaseWrapper, IMERawProcessorExtension {
		public MERawProcessorExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MERawProcessorExtensionWrapper))]
		static MERawProcessorExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("processorWithFormatDescription:extensionPixelBufferManager:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMERawProcessor? CreateProcessor (global::CoreMedia.CMVideoFormatDescription formatDescription, MERawProcessorPixelBufferManager extensionPixelBufferManager, out NSError? error)
		{
			var formatDescription__handle__ = formatDescription!.GetNonNullHandle (nameof (formatDescription));
			var extensionPixelBufferManager__handle__ = extensionPixelBufferManager!.GetNonNullHandle (nameof (extensionPixelBufferManager));
			NativeHandle errorValue = IntPtr.Zero;
			IMERawProcessor? ret;
			ret =  Runtime.GetINativeObject<IMERawProcessor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("processorWithFormatDescription:extensionPixelBufferManager:error:"), formatDescription.Handle, extensionPixelBufferManager__handle__, &errorValue), false)!;
			GC.KeepAlive (formatDescription);
			GC.KeepAlive (extensionPixelBufferManager);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
