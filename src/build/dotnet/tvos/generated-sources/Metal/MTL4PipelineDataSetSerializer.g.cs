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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4PipelineDataSetSerializer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedSimulator ("tvos")]
	[Protocol (Name = "MTL4PipelineDataSetSerializer", WrapperType = typeof (MTL4PipelineDataSetSerializerWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SerializeAsArchiveAndFlush", Selector = "serializeAsArchiveAndFlushToURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SerializeAsPipelinesScript", Selector = "serializeAsPipelinesScriptWithError:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	public partial interface IMTL4PipelineDataSetSerializer : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("serializeAsArchiveAndFlushToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SerializeAsArchiveAndFlush (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _SerializeAsArchiveAndFlush (IMTL4PipelineDataSetSerializer This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("serializeAsArchiveAndFlushToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("serializeAsPipelinesScriptWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? SerializeAsPipelinesScript (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSData? _SerializeAsPipelinesScript (IMTL4PipelineDataSetSerializer This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("serializeAsPipelinesScriptWithError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("SerializeAsArchiveAndFlush(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SerializeAsPipelinesScript(Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4PipelineDataSetSerializerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4PipelineDataSetSerializer ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4PipelineDataSetSerializerWrapper : BaseWrapper, IMTL4PipelineDataSetSerializer {
		public MTL4PipelineDataSetSerializerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4PipelineDataSetSerializerWrapper))]
		static MTL4PipelineDataSetSerializerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("serializeAsArchiveAndFlushToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool SerializeAsArchiveAndFlush (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("serializeAsArchiveAndFlushToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("serializeAsPipelinesScriptWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSData? SerializeAsPipelinesScript (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("serializeAsPipelinesScriptWithError:"), &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
