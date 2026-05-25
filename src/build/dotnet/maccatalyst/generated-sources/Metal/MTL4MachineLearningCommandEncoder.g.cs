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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4MachineLearningCommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4MachineLearningCommandEncoder", WrapperType = typeof (MTL4MachineLearningCommandEncoderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPipelineState", Selector = "setPipelineState:", ParameterType = new Type [] { typeof (IMTL4MachineLearningPipelineState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentTable", Selector = "setArgumentTable:", ParameterType = new Type [] { typeof (IMTL4ArgumentTable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchNetwork", Selector = "dispatchNetworkWithIntermediatesHeap:", ParameterType = new Type [] { typeof (IMTLHeap) }, ParameterByRef = new bool [] { false })]
	public partial interface IMTL4MachineLearningCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTL4CommandEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("setPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPipelineState (IMTL4MachineLearningPipelineState pipelineState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPipelineState (IMTL4MachineLearningCommandEncoder This, IMTL4MachineLearningPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pipelineState);
		}
		[global::Foundation.RequiredMember]
		[Export ("setArgumentTable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetArgumentTable (IMTL4ArgumentTable argumentTable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetArgumentTable (IMTL4MachineLearningCommandEncoder This, IMTL4ArgumentTable argumentTable)
		{
			var argumentTable__handle__ = argumentTable!.GetNonNullHandle (nameof (argumentTable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setArgumentTable:"), argumentTable__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (argumentTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("dispatchNetworkWithIntermediatesHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DispatchNetwork (IMTLHeap intermediatesHeap)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DispatchNetwork (IMTL4MachineLearningCommandEncoder This, IMTLHeap intermediatesHeap)
		{
			var intermediatesHeap__handle__ = intermediatesHeap!.GetNonNullHandle (nameof (intermediatesHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("dispatchNetworkWithIntermediatesHeap:"), intermediatesHeap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intermediatesHeap);
		}
		[DynamicDependencyAttribute ("DispatchNetwork(Metal.IMTLHeap)")]
		[DynamicDependencyAttribute ("SetArgumentTable(Metal.IMTL4ArgumentTable)")]
		[DynamicDependencyAttribute ("SetPipelineState(Metal.IMTL4MachineLearningPipelineState)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4MachineLearningCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4MachineLearningCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4MachineLearningCommandEncoderWrapper : BaseWrapper, IMTL4MachineLearningCommandEncoder {
		public MTL4MachineLearningCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4MachineLearningCommandEncoderWrapper))]
		static MTL4MachineLearningCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setPipelineState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetPipelineState (IMTL4MachineLearningPipelineState pipelineState)
		{
			var pipelineState__handle__ = pipelineState!.GetNonNullHandle (nameof (pipelineState));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPipelineState:"), pipelineState__handle__);
			GC.KeepAlive (pipelineState);
		}
		[Export ("setArgumentTable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetArgumentTable (IMTL4ArgumentTable argumentTable)
		{
			var argumentTable__handle__ = argumentTable!.GetNonNullHandle (nameof (argumentTable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setArgumentTable:"), argumentTable__handle__);
			GC.KeepAlive (argumentTable);
		}
		[Export ("dispatchNetworkWithIntermediatesHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DispatchNetwork (IMTLHeap intermediatesHeap)
		{
			var intermediatesHeap__handle__ = intermediatesHeap!.GetNonNullHandle (nameof (intermediatesHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dispatchNetworkWithIntermediatesHeap:"), intermediatesHeap__handle__);
			GC.KeepAlive (intermediatesHeap);
		}
		[Export ("barrierAfterQueueStages:beforeStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:visibilityOptions:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("barrierAfterStages:beforeQueueStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterStages (MTLStages afterStages, MTLStages beforeQueueStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterStages:beforeQueueStages:visibilityOptions:"), (UIntPtr) (ulong) afterStages, (UIntPtr) (ulong) beforeQueueStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterEncoderStages (MTLStages afterEncoderStages, MTLStages beforeEncoderStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:"), (UIntPtr) (ulong) afterEncoderStages, (UIntPtr) (ulong) beforeEncoderStages, (UIntPtr) (ulong) visibilityOptions);
		}
		[Export ("updateFence:afterEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateFence (IMTLFence fence, MTLStages afterEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("updateFence:afterEncoderStages:"), fence__handle__, (UIntPtr) (ulong) afterEncoderStages);
			GC.KeepAlive (fence);
		}
		[Export ("waitForFence:beforeEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitForFence (IMTLFence fence, MTLStages beforeEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("waitForFence:beforeEncoderStages:"), fence__handle__, (UIntPtr) (ulong) beforeEncoderStages);
			GC.KeepAlive (fence);
		}
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugSignpost (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDebugSignpost:"), nsstring);
			CFString.ReleaseNative (nsstring);
		}
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PushDebugGroup (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushDebugGroup:"), nsstring);
			CFString.ReleaseNative (nsstring);
		}
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PopDebugGroup ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popDebugGroup"));
		}
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndEncoding ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEncoding"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public string? Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public IMTL4CommandBuffer? CommandBuffer {
			[Export ("commandBuffer")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				IMTL4CommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandBuffer")), false)!;
				return ret;
			}
		}
	}
}
