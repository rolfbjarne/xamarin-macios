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
	/// <summary>This interface represents the Objective-C protocol <c>MTL4CommandBuffer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4CommandBuffer", WrapperType = typeof (MTL4CommandBufferWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginCommandBuffer", Selector = "beginCommandBufferWithAllocator:", ParameterType = new Type [] { typeof (IMTL4CommandAllocator) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginCommandBuffer", Selector = "beginCommandBufferWithAllocator:options:", ParameterType = new Type [] { typeof (IMTL4CommandAllocator), typeof (MTL4CommandBufferOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndCommandBuffer", Selector = "endCommandBuffer")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoderWithDescriptor:", ReturnType = typeof (IMTL4RenderCommandEncoder), ParameterType = new Type [] { typeof (MTL4RenderPassDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoderWithDescriptor:options:", ReturnType = typeof (IMTL4RenderCommandEncoder), ParameterType = new Type [] { typeof (MTL4RenderPassDescriptor), typeof (MTL4RenderEncoderOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputeCommandEncoder", Selector = "computeCommandEncoder", ReturnType = typeof (IMTL4ComputeCommandEncoder))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateMachineLearningCommandEncoder", Selector = "machineLearningCommandEncoder", ReturnType = typeof (IMTL4MachineLearningCommandEncoder))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResidencySet", Selector = "useResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResidencySets", Selector = "useResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PushDebugGroup", Selector = "pushDebugGroup:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopDebugGroup", Selector = "popDebugGroup")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteTimestamp", Selector = "writeTimestampIntoHeap:atIndex:", ParameterType = new Type [] { typeof (IMTL4CounterHeap), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResolveCounterHeap", Selector = "resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:", ParameterType = new Type [] { typeof (IMTL4CounterHeap), typeof (NSRange), typeof (MTL4BufferRange), typeof (IMTLFence), typeof (IMTLFence) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4CommandBuffer : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("beginCommandBufferWithAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginCommandBuffer (IMTL4CommandAllocator allocator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginCommandBuffer (IMTL4CommandBuffer This, IMTL4CommandAllocator allocator)
		{
			var allocator__handle__ = allocator!.GetNonNullHandle (nameof (allocator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("beginCommandBufferWithAllocator:"), allocator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (allocator);
		}
		[global::Foundation.RequiredMember]
		[Export ("beginCommandBufferWithAllocator:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginCommandBuffer (IMTL4CommandAllocator allocator, MTL4CommandBufferOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginCommandBuffer (IMTL4CommandBuffer This, IMTL4CommandAllocator allocator, MTL4CommandBufferOptions options)
		{
			var allocator__handle__ = allocator!.GetNonNullHandle (nameof (allocator));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("beginCommandBufferWithAllocator:options:"), allocator__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (allocator);
			GC.KeepAlive (options);
		}
		[global::Foundation.RequiredMember]
		[Export ("endCommandBuffer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndCommandBuffer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndCommandBuffer (IMTL4CommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endCommandBuffer"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("renderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4RenderCommandEncoder? CreateRenderCommandEncoder (MTL4RenderPassDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4RenderCommandEncoder? _CreateRenderCommandEncoder (IMTL4CommandBuffer This, MTL4RenderPassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4RenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTL4RenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("renderCommandEncoderWithDescriptor:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4RenderCommandEncoder? CreateRenderCommandEncoder (MTL4RenderPassDescriptor descriptor, MTL4RenderEncoderOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4RenderCommandEncoder? _CreateRenderCommandEncoder (IMTL4CommandBuffer This, MTL4RenderPassDescriptor descriptor, MTL4RenderEncoderOptions options)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4RenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTL4RenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:options:"), descriptor__handle__, (UIntPtr) (ulong) options), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("computeCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4ComputeCommandEncoder? CreateComputeCommandEncoder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4ComputeCommandEncoder? _CreateComputeCommandEncoder (IMTL4CommandBuffer This)
		{
			IMTL4ComputeCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTL4ComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("computeCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("machineLearningCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTL4MachineLearningCommandEncoder? CreateMachineLearningCommandEncoder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4MachineLearningCommandEncoder? _CreateMachineLearningCommandEncoder (IMTL4CommandBuffer This)
		{
			IMTL4MachineLearningCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTL4MachineLearningCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("machineLearningCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("useResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResidencySet (IMTL4CommandBuffer This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResidencySets (IMTL4CommandBuffer This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushDebugGroup (string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PushDebugGroup (IMTL4CommandBuffer This, string @string)
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
		internal static void _PopDebugGroup (IMTL4CommandBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("popDebugGroup"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeTimestampIntoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteTimestamp (IMTL4CounterHeap counterHeap, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteTimestamp (IMTL4CommandBuffer This, IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("writeTimestampIntoHeap:atIndex:"), counterHeap__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (counterHeap);
		}
		[global::Foundation.RequiredMember]
		[Export ("resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResolveCounterHeap (IMTL4CounterHeap counterHeap, NSRange range, MTL4BufferRange bufferRange, IMTLFence? fenceToWait, IMTLFence? fenceToUpdate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResolveCounterHeap (IMTL4CommandBuffer This, IMTL4CounterHeap counterHeap, NSRange range, MTL4BufferRange bufferRange, IMTLFence? fenceToWait, IMTLFence? fenceToUpdate)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			var fenceToWait__handle__ = fenceToWait.GetHandle ();
			var fenceToUpdate__handle__ = fenceToUpdate.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_MTL4BufferRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:"), counterHeap__handle__, range, bufferRange, fenceToWait__handle__, fenceToUpdate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (counterHeap);
			GC.KeepAlive (fenceToWait);
			GC.KeepAlive (fenceToUpdate);
		}
		[DynamicDependencyAttribute ("BeginCommandBuffer(Metal.IMTL4CommandAllocator,Metal.MTL4CommandBufferOptions)")]
		[DynamicDependencyAttribute ("BeginCommandBuffer(Metal.IMTL4CommandAllocator)")]
		[DynamicDependencyAttribute ("CreateComputeCommandEncoder()")]
		[DynamicDependencyAttribute ("CreateMachineLearningCommandEncoder()")]
		[DynamicDependencyAttribute ("CreateRenderCommandEncoder(Metal.MTL4RenderPassDescriptor,Metal.MTL4RenderEncoderOptions)")]
		[DynamicDependencyAttribute ("CreateRenderCommandEncoder(Metal.MTL4RenderPassDescriptor)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("EndCommandBuffer()")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("PopDebugGroup()")]
		[DynamicDependencyAttribute ("PushDebugGroup(System.String)")]
		[DynamicDependencyAttribute ("ResolveCounterHeap(Metal.IMTL4CounterHeap,Foundation.NSRange,Metal.MTL4BufferRange,Metal.IMTLFence,Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("UseResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("UseResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("WriteTimestamp(Metal.IMTL4CounterHeap,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandBufferWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4CommandBuffer ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTL4CommandBuffer This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
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
		internal static string _GetLabel (IMTL4CommandBuffer This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTL4CommandBuffer This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4CommandBufferWrapper : BaseWrapper, IMTL4CommandBuffer {
		public MTL4CommandBufferWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandBufferWrapper))]
		static MTL4CommandBufferWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("beginCommandBufferWithAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginCommandBuffer (IMTL4CommandAllocator allocator)
		{
			var allocator__handle__ = allocator!.GetNonNullHandle (nameof (allocator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("beginCommandBufferWithAllocator:"), allocator__handle__);
			GC.KeepAlive (allocator);
		}
		[Export ("beginCommandBufferWithAllocator:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginCommandBuffer (IMTL4CommandAllocator allocator, MTL4CommandBufferOptions options)
		{
			var allocator__handle__ = allocator!.GetNonNullHandle (nameof (allocator));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("beginCommandBufferWithAllocator:options:"), allocator__handle__, options__handle__);
			GC.KeepAlive (allocator);
			GC.KeepAlive (options);
		}
		[Export ("endCommandBuffer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndCommandBuffer ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endCommandBuffer"));
		}
		[Export ("renderCommandEncoderWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4RenderCommandEncoder? CreateRenderCommandEncoder (MTL4RenderPassDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4RenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTL4RenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("renderCommandEncoderWithDescriptor:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4RenderCommandEncoder? CreateRenderCommandEncoder (MTL4RenderPassDescriptor descriptor, MTL4RenderEncoderOptions options)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTL4RenderCommandEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTL4RenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("renderCommandEncoderWithDescriptor:options:"), descriptor__handle__, (UIntPtr) (ulong) options), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("computeCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4ComputeCommandEncoder? CreateComputeCommandEncoder ()
		{
			IMTL4ComputeCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTL4ComputeCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("computeCommandEncoder")), false)!;
			return ret;
		}
		[Export ("machineLearningCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4MachineLearningCommandEncoder? CreateMachineLearningCommandEncoder ()
		{
			IMTL4MachineLearningCommandEncoder ret;
			ret =  Runtime.GetINativeObject<IMTL4MachineLearningCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("machineLearningCommandEncoder")), false)!;
			return ret;
		}
		[Export ("useResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResidencySet (IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("useResidencySet:"), residencySet__handle__);
			GC.KeepAlive (residencySet);
		}
		[Export ("useResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResidencySets (nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResidencySets:count:"), residencySets, count);
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
		[Export ("writeTimestampIntoHeap:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteTimestamp (IMTL4CounterHeap counterHeap, nuint index)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("writeTimestampIntoHeap:atIndex:"), counterHeap__handle__, index);
			GC.KeepAlive (counterHeap);
		}
		[Export ("resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResolveCounterHeap (IMTL4CounterHeap counterHeap, NSRange range, MTL4BufferRange bufferRange, IMTLFence? fenceToWait, IMTLFence? fenceToUpdate)
		{
			var counterHeap__handle__ = counterHeap!.GetNonNullHandle (nameof (counterHeap));
			var fenceToWait__handle__ = fenceToWait.GetHandle ();
			var fenceToUpdate__handle__ = fenceToUpdate.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_MTL4BufferRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:"), counterHeap__handle__, range, bufferRange, fenceToWait__handle__, fenceToUpdate__handle__);
			GC.KeepAlive (counterHeap);
			GC.KeepAlive (fenceToWait);
			GC.KeepAlive (fenceToUpdate);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
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
	}
}
