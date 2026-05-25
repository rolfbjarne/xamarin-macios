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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4CommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4CommandEncoder", WrapperType = typeof (MTL4CommandEncoderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BarrierAfterQueueStages", Selector = "barrierAfterQueueStages:beforeStages:visibilityOptions:", ParameterType = new Type [] { typeof (MTLStages), typeof (MTLStages), typeof (MTL4VisibilityOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BarrierAfterStages", Selector = "barrierAfterStages:beforeQueueStages:visibilityOptions:", ParameterType = new Type [] { typeof (MTLStages), typeof (MTLStages), typeof (MTL4VisibilityOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BarrierAfterEncoderStages", Selector = "barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:", ParameterType = new Type [] { typeof (MTLStages), typeof (MTLStages), typeof (MTL4VisibilityOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateFence", Selector = "updateFence:afterEncoderStages:", ParameterType = new Type [] { typeof (IMTLFence), typeof (MTLStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitForFence", Selector = "waitForFence:beforeEncoderStages:", ParameterType = new Type [] { typeof (IMTLFence), typeof (MTLStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertDebugSignpost", Selector = "insertDebugSignpost:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PushDebugGroup", Selector = "pushDebugGroup:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopDebugGroup", Selector = "popDebugGroup")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndEncoding", Selector = "endEncoding")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CommandBuffer", Selector = "commandBuffer", PropertyType = typeof (IMTL4CommandBuffer), GetterSelector = "commandBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4CommandEncoder : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("barrierAfterQueueStages:beforeStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages, MTL4VisibilityOptions visibilityOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BarrierAfterQueueStages (IMTL4CommandEncoder This, MTLStages afterQueueStages, MTLStages beforeStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:visibilityOptions:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages, (UIntPtr) (ulong) visibilityOptions);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("barrierAfterStages:beforeQueueStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BarrierAfterStages (MTLStages afterStages, MTLStages beforeQueueStages, MTL4VisibilityOptions visibilityOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BarrierAfterStages (IMTL4CommandEncoder This, MTLStages afterStages, MTLStages beforeQueueStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("barrierAfterStages:beforeQueueStages:visibilityOptions:"), (UIntPtr) (ulong) afterStages, (UIntPtr) (ulong) beforeQueueStages, (UIntPtr) (ulong) visibilityOptions);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BarrierAfterEncoderStages (MTLStages afterEncoderStages, MTLStages beforeEncoderStages, MTL4VisibilityOptions visibilityOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BarrierAfterEncoderStages (IMTL4CommandEncoder This, MTLStages afterEncoderStages, MTLStages beforeEncoderStages, MTL4VisibilityOptions visibilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:"), (UIntPtr) (ulong) afterEncoderStages, (UIntPtr) (ulong) beforeEncoderStages, (UIntPtr) (ulong) visibilityOptions);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateFence:afterEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFence (IMTLFence fence, MTLStages afterEncoderStages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateFence (IMTL4CommandEncoder This, IMTLFence fence, MTLStages afterEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("updateFence:afterEncoderStages:"), fence__handle__, (UIntPtr) (ulong) afterEncoderStages);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("waitForFence:beforeEncoderStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitForFence (IMTLFence fence, MTLStages beforeEncoderStages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitForFence (IMTL4CommandEncoder This, IMTLFence fence, MTLStages beforeEncoderStages)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("waitForFence:beforeEncoderStages:"), fence__handle__, (UIntPtr) (ulong) beforeEncoderStages);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDebugSignpost (string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertDebugSignpost (IMTL4CommandEncoder This, string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertDebugSignpost:"), nsstring);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstring);
		}
		[global::Foundation.RequiredMember]
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushDebugGroup (string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PushDebugGroup (IMTL4CommandEncoder This, string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pushDebugGroup:"), nsstring);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstring);
		}
		[global::Foundation.RequiredMember]
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopDebugGroup ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PopDebugGroup (IMTL4CommandEncoder This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("popDebugGroup"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndEncoding ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndEncoding (IMTL4CommandEncoder This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endEncoding"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("BarrierAfterEncoderStages(Metal.MTLStages,Metal.MTLStages,Metal.MTL4VisibilityOptions)")]
		[DynamicDependencyAttribute ("BarrierAfterQueueStages(Metal.MTLStages,Metal.MTLStages,Metal.MTL4VisibilityOptions)")]
		[DynamicDependencyAttribute ("BarrierAfterStages(Metal.MTLStages,Metal.MTLStages,Metal.MTL4VisibilityOptions)")]
		[DynamicDependencyAttribute ("CommandBuffer")]
		[DynamicDependencyAttribute ("EndEncoding()")]
		[DynamicDependencyAttribute ("InsertDebugSignpost(System.String)")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("PopDebugGroup()")]
		[DynamicDependencyAttribute ("PushDebugGroup(System.String)")]
		[DynamicDependencyAttribute ("UpdateFence(Metal.IMTLFence,Metal.MTLStages)")]
		[DynamicDependencyAttribute ("WaitForFence(Metal.IMTLFence,Metal.MTLStages)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4CommandEncoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
			[Export ("setLabel:")]
			set {
				_SetLabel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTL4CommandEncoder This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTL4CommandEncoder This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTL4CommandBuffer? CommandBuffer {
			[Export ("commandBuffer")]
			get {
				return _GetCommandBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4CommandBuffer _GetCommandBuffer (IMTL4CommandEncoder This)
		{
			IMTL4CommandBuffer ret;
			ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("commandBuffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4CommandEncoderWrapper : BaseWrapper, IMTL4CommandEncoder {
		public MTL4CommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandEncoderWrapper))]
		static MTL4CommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
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
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4CommandBuffer? CommandBuffer {
			[Export ("commandBuffer")]
			get {
				IMTL4CommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTL4CommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandBuffer")), false)!;
				return ret;
			}
		}
	}
}
