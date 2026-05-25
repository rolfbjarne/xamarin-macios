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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Interface defining methods for queueing sample buffers for presentation.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVQueuedSampleBufferRendering", WrapperType = typeof (AVQueuedSampleBufferRenderingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Enqueue", Selector = "enqueueSampleBuffer:", ParameterType = new Type [] { typeof (CMSampleBuffer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Flush", Selector = "flush")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestMediaData", Selector = "requestMediaDataWhenReadyOnQueue:usingBlock:", ParameterType = new Type [] { typeof (DispatchQueue), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopRequestingMediaData", Selector = "stopRequestingMediaData")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Timebase", Selector = "timebase", PropertyType = typeof (CMTimebase), GetterSelector = "timebase", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReadyForMoreMediaData", Selector = "readyForMoreMediaData", PropertyType = typeof (bool), GetterSelector = "isReadyForMoreMediaData", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HasSufficientMediaDataForReliablePlaybackStart", Selector = "hasSufficientMediaDataForReliablePlaybackStart", PropertyType = typeof (bool), GetterSelector = "hasSufficientMediaDataForReliablePlaybackStart", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IAVQueuedSampleBufferRendering : INativeObject, IDisposable
	{
		/// <param name="sampleBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("enqueueSampleBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Enqueue (global::CoreMedia.CMSampleBuffer sampleBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sampleBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Enqueue (IAVQueuedSampleBufferRendering This, global::CoreMedia.CMSampleBuffer sampleBuffer)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("enqueueSampleBuffer:"), sampleBuffer.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("flush")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Flush ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Flush (IAVQueuedSampleBufferRendering This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("flush"));
			GC.KeepAlive (This);
		}
		/// <param name="queue">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("requestMediaDataWhenReadyOnQueue:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaData (global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestMediaData (IAVQueuedSampleBufferRendering This, global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("requestMediaDataWhenReadyOnQueue:usingBlock:"), queue.Handle, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("stopRequestingMediaData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRequestingMediaData ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopRequestingMediaData (IAVQueuedSampleBufferRendering This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stopRequestingMediaData"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Enqueue(CoreMedia.CMSampleBuffer)")]
		[DynamicDependencyAttribute ("Flush()")]
		[DynamicDependencyAttribute ("HasSufficientMediaDataForReliablePlaybackStart")]
		[DynamicDependencyAttribute ("ReadyForMoreMediaData")]
		[DynamicDependencyAttribute ("RequestMediaData(CoreFoundation.DispatchQueue,System.Action)")]
		[DynamicDependencyAttribute ("StopRequestingMediaData()")]
		[DynamicDependencyAttribute ("Timebase")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVQueuedSampleBufferRenderingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVQueuedSampleBufferRendering ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMTimebase Timebase {
			[Export ("timebase", ArgumentSemantic.Retain)]
			get {
				return _GetTimebase (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTimebase _GetTimebase (IAVQueuedSampleBufferRendering This)
		{
			global::CoreMedia.CMTimebase ret;
			ret = Runtime.GetINativeObject<global::CoreMedia.CMTimebase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("timebase")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				return _GetReadyForMoreMediaData (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReadyForMoreMediaData (IAVQueuedSampleBufferRendering This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool HasSufficientMediaDataForReliablePlaybackStart {
			[Export ("hasSufficientMediaDataForReliablePlaybackStart")]
			get {
				return _GetHasSufficientMediaDataForReliablePlaybackStart (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasSufficientMediaDataForReliablePlaybackStart (IAVQueuedSampleBufferRendering This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasSufficientMediaDataForReliablePlaybackStart"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVQueuedSampleBufferRenderingWrapper : BaseWrapper, IAVQueuedSampleBufferRendering {
		public AVQueuedSampleBufferRenderingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVQueuedSampleBufferRenderingWrapper))]
		static AVQueuedSampleBufferRenderingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="sampleBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enqueueSampleBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Enqueue (global::CoreMedia.CMSampleBuffer sampleBuffer)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("enqueueSampleBuffer:"), sampleBuffer.Handle);
			GC.KeepAlive (sampleBuffer);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("flush")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Flush ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("flush"));
		}
		/// <param name="queue">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("requestMediaDataWhenReadyOnQueue:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestMediaData (global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestMediaDataWhenReadyOnQueue:usingBlock:"), queue.Handle, (IntPtr) block_ptr_handler);
			GC.KeepAlive (queue);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("stopRequestingMediaData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopRequestingMediaData ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopRequestingMediaData"));
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTimebase Timebase {
			[Export ("timebase", ArgumentSemantic.Retain)]
			get {
				global::CoreMedia.CMTimebase ret;
				ret = Runtime.GetINativeObject<global::CoreMedia.CMTimebase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("timebase")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool HasSufficientMediaDataForReliablePlaybackStart {
			[Export ("hasSufficientMediaDataForReliablePlaybackStart")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasSufficientMediaDataForReliablePlaybackStart"));
				return ret != 0;
			}
		}
	}
}
