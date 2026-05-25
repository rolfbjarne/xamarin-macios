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
	/// <summary>This interface represents the Objective-C protocol <c>MTLAccelerationStructureCommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLAccelerationStructureCommandEncoder", WrapperType = typeof (MTLAccelerationStructureCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BuildAccelerationStructure", Selector = "buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTLAccelerationStructureDescriptor), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RefitAccelerationStructure", Selector = "refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTLAccelerationStructureDescriptor), typeof (IMTLAccelerationStructure), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyAccelerationStructure", Selector = "copyAccelerationStructure:toAccelerationStructure:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLAccelerationStructure) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteCompactedAccelerationStructureSize", Selector = "writeCompactedAccelerationStructureSize:toBuffer:offset:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyAndCompactAccelerationStructure", Selector = "copyAndCompactAccelerationStructure:toAccelerationStructure:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLAccelerationStructure) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateFence", Selector = "updateFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitForFence", Selector = "waitForFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResource", Selector = "useResource:usage:", ParameterType = new Type [] { typeof (IMTLResource), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseResources", Selector = "useResources:count:usage:", ParameterType = new Type [] { typeof (IMTLResource[]), typeof (UIntPtr), typeof (MTLResourceUsage) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeap", Selector = "useHeap:", ParameterType = new Type [] { typeof (IMTLHeap) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseHeaps", Selector = "useHeaps:count:", ParameterType = new Type [] { typeof (IMTLHeap[]), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SampleCountersInBuffer", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type [] { typeof (IMTLCounterSampleBuffer), typeof (UIntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteCompactedAccelerationStructureSize", Selector = "writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (IMTLBuffer), typeof (UIntPtr), typeof (MTLDataType) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RefitAccelerationStructure", Selector = "refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:", ParameterType = new Type [] { typeof (IMTLAccelerationStructure), typeof (MTLAccelerationStructureDescriptor), typeof (IMTLAccelerationStructure), typeof (IMTLBuffer), typeof (UIntPtr), typeof (MTLAccelerationStructureRefitOptions) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	public partial interface IMTLAccelerationStructureCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BuildAccelerationStructure (IMTLAccelerationStructure accelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BuildAccelerationStructure (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure accelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var scratchBuffer__handle__ = scratchBuffer!.GetNonNullHandle (nameof (scratchBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:"), accelerationStructure__handle__, descriptor__handle__, scratchBuffer__handle__, scratchBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (scratchBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RefitAccelerationStructure (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			var scratchBuffer__handle__ = scratchBuffer!.GetNonNullHandle (nameof (scratchBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer__handle__, scratchBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
			GC.KeepAlive (scratchBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyAccelerationStructure (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteCompactedAccelerationStructureSize (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:offset:"), accelerationStructure__handle__, buffer__handle__, offset);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyAndCompactAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyAndCompactAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyAndCompactAccelerationStructure (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyAndCompactAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFence (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateFence (IMTLAccelerationStructureCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitForFence (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitForFence (IMTLAccelerationStructureCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResource:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResource (IMTLResource resource, MTLResourceUsage usage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResource (IMTLAccelerationStructureCommandEncoder This, IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		[global::Foundation.RequiredMember]
		[Export ("useResources:count:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseResources (IMTLAccelerationStructureCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeap (IMTLHeap heap)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeap (IMTLAccelerationStructureCommandEncoder This, IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
		[global::Foundation.RequiredMember]
		[Export ("useHeaps:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseHeaps (IMTLHeap[] heaps, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseHeaps (IMTLAccelerationStructureCommandEncoder This, IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SampleCountersInBuffer (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SampleCountersInBuffer (IMTLAccelerationStructureCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset, MTLDataType sizeDataType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteCompactedAccelerationStructureSize (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset, MTLDataType sizeDataType)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:"), accelerationStructure__handle__, buffer__handle__, offset, (UIntPtr) (ulong) sizeDataType);
			GC.KeepAlive (This);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer? scratchBuffer, nuint scratchBufferOffset, MTLAccelerationStructureRefitOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RefitAccelerationStructure (IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer? scratchBuffer, nuint scratchBufferOffset, MTLAccelerationStructureRefitOptions options)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			var scratchBuffer__handle__ = scratchBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer__handle__, scratchBufferOffset, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
			GC.KeepAlive (scratchBuffer);
		}
		[DynamicDependencyAttribute ("BuildAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTLAccelerationStructureDescriptor,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.IMTLAccelerationStructure)")]
		[DynamicDependencyAttribute ("CopyAndCompactAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.IMTLAccelerationStructure)")]
		[DynamicDependencyAttribute ("RefitAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTLAccelerationStructureDescriptor,Metal.IMTLAccelerationStructure,Metal.IMTLBuffer,System.UIntPtr,Metal.MTLAccelerationStructureRefitOptions)")]
		[DynamicDependencyAttribute ("RefitAccelerationStructure(Metal.IMTLAccelerationStructure,Metal.MTLAccelerationStructureDescriptor,Metal.IMTLAccelerationStructure,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SampleCountersInBuffer(Metal.IMTLCounterSampleBuffer,System.UIntPtr,System.Boolean)")]
		[DynamicDependencyAttribute ("UpdateFence(Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("UseHeap(Metal.IMTLHeap)")]
		[DynamicDependencyAttribute ("UseHeaps(Metal.IMTLHeap[],System.UIntPtr)")]
		[DynamicDependencyAttribute ("UseResource(Metal.IMTLResource,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("UseResources(Metal.IMTLResource[],System.UIntPtr,Metal.MTLResourceUsage)")]
		[DynamicDependencyAttribute ("WaitForFence(Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("WriteCompactedAccelerationStructureSize(Metal.IMTLAccelerationStructure,Metal.IMTLBuffer,System.UIntPtr,Metal.MTLDataType)")]
		[DynamicDependencyAttribute ("WriteCompactedAccelerationStructureSize(Metal.IMTLAccelerationStructure,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLAccelerationStructureCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLAccelerationStructureCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLAccelerationStructureCommandEncoder" /> interface to support all the methods from the MTLAccelerationStructureCommandEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLAccelerationStructureCommandEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLAccelerationStructureCommandEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLAccelerationStructureCommandEncoder_Extensions {
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RefitAccelerationStructure (this IMTLAccelerationStructureCommandEncoder This, IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer? scratchBuffer, nuint scratchBufferOffset, MTLAccelerationStructureRefitOptions options)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			var scratchBuffer__handle__ = scratchBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer__handle__, scratchBufferOffset, (UIntPtr) (ulong) options);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
			GC.KeepAlive (scratchBuffer);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLAccelerationStructureCommandEncoderWrapper : BaseWrapper, IMTLAccelerationStructureCommandEncoder {
		public MTLAccelerationStructureCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLAccelerationStructureCommandEncoderWrapper))]
		static MTLAccelerationStructureCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BuildAccelerationStructure (IMTLAccelerationStructure accelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var scratchBuffer__handle__ = scratchBuffer!.GetNonNullHandle (nameof (scratchBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:"), accelerationStructure__handle__, descriptor__handle__, scratchBuffer__handle__, scratchBufferOffset);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (scratchBuffer);
		}
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer scratchBuffer, nuint scratchBufferOffset)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			var scratchBuffer__handle__ = scratchBuffer!.GetNonNullHandle (nameof (scratchBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer__handle__, scratchBufferOffset);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
			GC.KeepAlive (scratchBuffer);
		}
		[Export ("copyAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:offset:"), accelerationStructure__handle__, buffer__handle__, offset);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (buffer);
		}
		[Export ("copyAndCompactAccelerationStructure:toAccelerationStructure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyAndCompactAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, IMTLAccelerationStructure destinationAccelerationStructure)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure!.GetNonNullHandle (nameof (destinationAccelerationStructure));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyAndCompactAccelerationStructure:toAccelerationStructure:"), sourceAccelerationStructure__handle__, destinationAccelerationStructure__handle__);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (destinationAccelerationStructure);
		}
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateFence (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitForFence (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		[Export ("useResource:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResource (IMTLResource resource, MTLResourceUsage usage)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useResource:usage:"), resource__handle__, (UIntPtr) (ulong) usage);
			GC.KeepAlive (resource);
		}
		[Export ("useResources:count:usage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseResources (IMTLResource[] resources, nuint count, MTLResourceUsage usage)
		{
			if (resources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resources));
			using var nsa_resources = NSArray.FromNSObjects (resources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("useResources:count:usage:"), nsa_resources.Handle, count, (UIntPtr) (ulong) usage);
		}
		[Export ("useHeap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeap (IMTLHeap heap)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("useHeap:"), heap__handle__);
			GC.KeepAlive (heap);
		}
		[Export ("useHeaps:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseHeaps (IMTLHeap[] heaps, nuint count)
		{
			if (heaps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (heaps));
			using var nsa_heaps = NSArray.FromNSObjects (heaps);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("useHeaps:count:"), nsa_heaps.Handle, count);
		}
		[Export ("sampleCountersInBuffer:atSampleIndex:withBarrier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SampleCountersInBuffer (IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer__handle__, sampleIndex, barrier ? (byte) 1 : (byte) 0);
			GC.KeepAlive (sampleBuffer);
		}
		[Export ("writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WriteCompactedAccelerationStructureSize (IMTLAccelerationStructure accelerationStructure, IMTLBuffer buffer, nuint offset, MTLDataType sizeDataType)
		{
			var accelerationStructure__handle__ = accelerationStructure!.GetNonNullHandle (nameof (accelerationStructure));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:"), accelerationStructure__handle__, buffer__handle__, offset, (UIntPtr) (ulong) sizeDataType);
			GC.KeepAlive (accelerationStructure);
			GC.KeepAlive (buffer);
		}
		[Export ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RefitAccelerationStructure (IMTLAccelerationStructure sourceAccelerationStructure, MTLAccelerationStructureDescriptor descriptor, IMTLAccelerationStructure? destinationAccelerationStructure, IMTLBuffer? scratchBuffer, nuint scratchBufferOffset, MTLAccelerationStructureRefitOptions options)
		{
			var sourceAccelerationStructure__handle__ = sourceAccelerationStructure!.GetNonNullHandle (nameof (sourceAccelerationStructure));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var destinationAccelerationStructure__handle__ = destinationAccelerationStructure.GetHandle ();
			var scratchBuffer__handle__ = scratchBuffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:"), sourceAccelerationStructure__handle__, descriptor__handle__, destinationAccelerationStructure__handle__, scratchBuffer__handle__, scratchBufferOffset, (UIntPtr) (ulong) options);
			GC.KeepAlive (sourceAccelerationStructure);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (destinationAccelerationStructure);
			GC.KeepAlive (scratchBuffer);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndEncoding ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEncoding"));
		}
		/// <param name="signpost">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugSignpost (string signpost)
		{
			if (signpost is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (signpost));
			var nssignpost = CFString.CreateNative (signpost);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDebugSignpost:"), nssignpost);
			CFString.ReleaseNative (nssignpost);
		}
		/// <param name="debugGroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PushDebugGroup (string debugGroup)
		{
			if (debugGroup is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (debugGroup));
			var nsdebugGroup = CFString.CreateNative (debugGroup);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushDebugGroup:"), nsdebugGroup);
			CFString.ReleaseNative (nsdebugGroup);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PopDebugGroup ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popDebugGroup"));
		}
		[Export ("barrierAfterQueueStages:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
