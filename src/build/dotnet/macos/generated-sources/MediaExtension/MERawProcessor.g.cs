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
	/// <summary>This interface represents the Objective-C protocol <c>MERAWProcessor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MERAWProcessor", WrapperType = typeof (MERawProcessorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProcessFrame", Selector = "processFrameFromImageBuffer:completionHandler:", ParameterType = new Type [] { typeof (CVPixelBuffer), typeof (MediaExtension.MERawProcessorProcessFrameCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMERawProcessorProcessFrameCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MetalDeviceRegistryId", Selector = "metalDeviceRegistryID", PropertyType = typeof (ulong), GetterSelector = "metalDeviceRegistryID", SetterSelector = "setMetalDeviceRegistryID:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "OutputColorAttachments", Selector = "outputColorAttachments", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "outputColorAttachments", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProcessingParameters", Selector = "processingParameters", PropertyType = typeof (MediaExtension.MERawProcessingParameter[]), GetterSelector = "processingParameters", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReadyForMoreMediaData", Selector = "readyForMoreMediaData", PropertyType = typeof (bool), GetterSelector = "isReadyForMoreMediaData", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MetadataForSidecarFile", Selector = "metadataForSidecarFile", PropertyType = typeof (NSData), GetterSelector = "metadataForSidecarFile", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMERawProcessor : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("processFrameFromImageBuffer:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProcessFrame (global::CoreVideo.CVPixelBuffer inputFrame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMERawProcessorProcessFrameCallback))]MERawProcessorProcessFrameCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ProcessFrame (IMERawProcessor This, global::CoreVideo.CVPixelBuffer inputFrame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMERawProcessorProcessFrameCallback))]MERawProcessorProcessFrameCallback completionHandler)
		{
			var inputFrame__handle__ = inputFrame!.GetNonNullHandle (nameof (inputFrame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMERawProcessorProcessFrameCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("processFrameFromImageBuffer:completionHandler:"), inputFrame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (inputFrame);
		}
		[DynamicDependencyAttribute ("MetadataForSidecarFile")]
		[DynamicDependencyAttribute ("MetalDeviceRegistryId")]
		[DynamicDependencyAttribute ("OutputColorAttachments")]
		[DynamicDependencyAttribute ("ProcessFrame(CoreVideo.CVPixelBuffer,MediaExtension.MERawProcessorProcessFrameCallback)")]
		[DynamicDependencyAttribute ("ProcessingParameters")]
		[DynamicDependencyAttribute ("ReadyForMoreMediaData")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MERawProcessorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMERawProcessor ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual ulong MetalDeviceRegistryId {
			[Export ("metalDeviceRegistryID")]
			get {
				return _GetMetalDeviceRegistryId (this);
			}
			[Export ("setMetalDeviceRegistryID:")]
			set {
				_SetMetalDeviceRegistryId (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetMetalDeviceRegistryId (IMERawProcessor This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("metalDeviceRegistryID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMetalDeviceRegistryId (IMERawProcessor This, ulong value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("setMetalDeviceRegistryID:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSDictionary<NSString, NSObject> OutputColorAttachments {
			[Export ("outputColorAttachments")]
			get {
				return _GetOutputColorAttachments (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject> _GetOutputColorAttachments (IMERawProcessor This)
		{
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputColorAttachments")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MERawProcessingParameter[] ProcessingParameters {
			[Export ("processingParameters")]
			get {
				return _GetProcessingParameters (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MERawProcessingParameter[] _GetProcessingParameters (IMERawProcessor This)
		{
			MERawProcessingParameter[] ret;
			ret = CFArray.ArrayFromHandle<MERawProcessingParameter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("processingParameters")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				return _GetReadyForMoreMediaData (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReadyForMoreMediaData (IMERawProcessor This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSData MetadataForSidecarFile {
			[Export ("metadataForSidecarFile")]
			get {
				return _GetMetadataForSidecarFile (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetMetadataForSidecarFile (IMERawProcessor This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("metadataForSidecarFile")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MERawProcessorWrapper : BaseWrapper, IMERawProcessor {
		public MERawProcessorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MERawProcessorWrapper))]
		static MERawProcessorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("processFrameFromImageBuffer:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ProcessFrame (global::CoreVideo.CVPixelBuffer inputFrame, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMERawProcessorProcessFrameCallback))]MERawProcessorProcessFrameCallback completionHandler)
		{
			var inputFrame__handle__ = inputFrame!.GetNonNullHandle (nameof (inputFrame));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMERawProcessorProcessFrameCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("processFrameFromImageBuffer:completionHandler:"), inputFrame__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (inputFrame);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MERawProcessingParameter[] ProcessingParameters {
			[Export ("processingParameters")]
			get {
				MERawProcessingParameter[] ret;
				ret = CFArray.ArrayFromHandle<MERawProcessingParameter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("processingParameters")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
				return ret != 0;
			}
		}
	}
}
