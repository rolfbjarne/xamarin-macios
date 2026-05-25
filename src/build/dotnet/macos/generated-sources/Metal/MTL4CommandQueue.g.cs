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
	/// <summary>This interface represents the Objective-C protocol <c>MTL4CommandQueue</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4CommandQueue", WrapperType = typeof (MTL4CommandQueueWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Commit", Selector = "commit:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Commit", Selector = "commit:count:options:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr), typeof (MTL4CommitOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SignalEvent", Selector = "signalEvent:value:", ParameterType = new Type [] { typeof (IMTLEvent), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitForEvent", Selector = "waitForEvent:value:", ParameterType = new Type [] { typeof (IMTLEvent), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SignalDrawable", Selector = "signalDrawable:", ParameterType = new Type [] { typeof (IMTLDrawable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitForDrawable", Selector = "waitForDrawable:", ParameterType = new Type [] { typeof (IMTLDrawable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddResidencySet", Selector = "addResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddResidencySets", Selector = "addResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveResidencySet", Selector = "removeResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveResidencySets", Selector = "removeResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateTextureMappings", Selector = "updateTextureMappings:heap:operations:count:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (IMTLHeap), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyTextureMappings", Selector = "copyTextureMappingsFromTexture:toTexture:operations:count:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (IMTLTexture), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateBufferMappings", Selector = "updateBufferMappings:heap:operations:count:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (IMTLHeap), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyBufferMappings", Selector = "copyBufferMappingsFromBuffer:toBuffer:operations:count:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (IMTLBuffer), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4CommandQueue : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("commit:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Commit (nint commandBuffers, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Commit (IMTL4CommandQueue This, nint commandBuffers, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("commit:count:"), commandBuffers, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("commit:count:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Commit (nint commandBuffers, nuint count, MTL4CommitOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Commit (IMTL4CommandQueue This, nint commandBuffers, nuint count, MTL4CommitOptions options)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("commit:count:options:"), commandBuffers, count, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
		}
		[global::Foundation.RequiredMember]
		[Export ("signalEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SignalEvent (IMTLEvent @event, ulong value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SignalEvent (IMTL4CommandQueue This, IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("signalEvent:value:"), @event__handle__, value);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("waitForEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitForEvent (IMTLEvent @event, ulong value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitForEvent (IMTL4CommandQueue This, IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("waitForEvent:value:"), @event__handle__, value);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("signalDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SignalDrawable (IMTLDrawable drawable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SignalDrawable (IMTL4CommandQueue This, IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("signalDrawable:"), drawable__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (drawable);
		}
		[global::Foundation.RequiredMember]
		[Export ("waitForDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitForDrawable (IMTLDrawable drawable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitForDrawable (IMTL4CommandQueue This, IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("waitForDrawable:"), drawable__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (drawable);
		}
		[global::Foundation.RequiredMember]
		[Export ("addResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddResidencySet (IMTL4CommandQueue This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("addResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddResidencySets (IMTL4CommandQueue This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("addResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveResidencySet (IMTL4CommandQueue This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveResidencySets (IMTL4CommandQueue This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("removeResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateTextureMappings:heap:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTextureMappings (IMTLTexture texture, IMTLHeap? heap, nint operations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateTextureMappings (IMTL4CommandQueue This, IMTLTexture texture, IMTLHeap? heap, nint operations, nuint count)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var heap__handle__ = heap.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("updateTextureMappings:heap:operations:count:"), texture__handle__, heap__handle__, operations, count);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (heap);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyTextureMappingsFromTexture:toTexture:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyTextureMappings (IMTLTexture sourceTexture, IMTLTexture destinationTexture, nint operations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyTextureMappings (IMTL4CommandQueue This, IMTLTexture sourceTexture, IMTLTexture destinationTexture, nint operations, nuint count)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyTextureMappingsFromTexture:toTexture:operations:count:"), sourceTexture__handle__, destinationTexture__handle__, operations, count);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateBufferMappings:heap:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateBufferMappings (IMTLBuffer buffer, IMTLHeap? heap, nint operations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateBufferMappings (IMTL4CommandQueue This, IMTLBuffer buffer, IMTLHeap? heap, nint operations, nuint count)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var heap__handle__ = heap.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("updateBufferMappings:heap:operations:count:"), buffer__handle__, heap__handle__, operations, count);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
			GC.KeepAlive (heap);
		}
		[global::Foundation.RequiredMember]
		[Export ("copyBufferMappingsFromBuffer:toBuffer:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyBufferMappings (IMTLBuffer sourceBuffer, IMTLBuffer destinationBuffer, nint operations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyBufferMappings (IMTL4CommandQueue This, IMTLBuffer sourceBuffer, IMTLBuffer destinationBuffer, nint operations, nuint count)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("copyBufferMappingsFromBuffer:toBuffer:operations:count:"), sourceBuffer__handle__, destinationBuffer__handle__, operations, count);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationBuffer);
		}
		[DynamicDependencyAttribute ("AddResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("AddResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Commit(System.IntPtr,System.UIntPtr,Metal.MTL4CommitOptions)")]
		[DynamicDependencyAttribute ("Commit(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyBufferMappings(Metal.IMTLBuffer,Metal.IMTLBuffer,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CopyTextureMappings(Metal.IMTLTexture,Metal.IMTLTexture,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("RemoveResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("RemoveResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SignalDrawable(Metal.IMTLDrawable)")]
		[DynamicDependencyAttribute ("SignalEvent(Metal.IMTLEvent,System.UInt64)")]
		[DynamicDependencyAttribute ("UpdateBufferMappings(Metal.IMTLBuffer,Metal.IMTLHeap,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("UpdateTextureMappings(Metal.IMTLTexture,Metal.IMTLHeap,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("WaitForDrawable(Metal.IMTLDrawable)")]
		[DynamicDependencyAttribute ("WaitForEvent(Metal.IMTLEvent,System.UInt64)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandQueueWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4CommandQueue ()
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
		internal static IMTLDevice _GetDevice (IMTL4CommandQueue This)
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTL4CommandQueue This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4CommandQueueWrapper : BaseWrapper, IMTL4CommandQueue {
		public MTL4CommandQueueWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CommandQueueWrapper))]
		static MTL4CommandQueueWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("commit:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Commit (nint commandBuffers, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("commit:count:"), commandBuffers, count);
		}
		[Export ("commit:count:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Commit (nint commandBuffers, nuint count, MTL4CommitOptions options)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("commit:count:options:"), commandBuffers, count, options__handle__);
			GC.KeepAlive (options);
		}
		[Export ("signalEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SignalEvent (IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("signalEvent:value:"), @event__handle__, value);
			GC.KeepAlive (@event);
		}
		[Export ("waitForEvent:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitForEvent (IMTLEvent @event, ulong value)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64 (this.Handle, Selector.GetHandle ("waitForEvent:value:"), @event__handle__, value);
			GC.KeepAlive (@event);
		}
		[Export ("signalDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SignalDrawable (IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("signalDrawable:"), drawable__handle__);
			GC.KeepAlive (drawable);
		}
		[Export ("waitForDrawable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitForDrawable (IMTLDrawable drawable)
		{
			var drawable__handle__ = drawable!.GetNonNullHandle (nameof (drawable));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("waitForDrawable:"), drawable__handle__);
			GC.KeepAlive (drawable);
		}
		[Export ("addResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddResidencySet (IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addResidencySet:"), residencySet__handle__);
			GC.KeepAlive (residencySet);
		}
		[Export ("addResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddResidencySets (nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("addResidencySets:count:"), residencySets, count);
		}
		[Export ("removeResidencySet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveResidencySet (IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeResidencySet:"), residencySet__handle__);
			GC.KeepAlive (residencySet);
		}
		[Export ("removeResidencySets:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveResidencySets (nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("removeResidencySets:count:"), residencySets, count);
		}
		[Export ("updateTextureMappings:heap:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateTextureMappings (IMTLTexture texture, IMTLHeap? heap, nint operations, nuint count)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var heap__handle__ = heap.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("updateTextureMappings:heap:operations:count:"), texture__handle__, heap__handle__, operations, count);
			GC.KeepAlive (texture);
			GC.KeepAlive (heap);
		}
		[Export ("copyTextureMappingsFromTexture:toTexture:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyTextureMappings (IMTLTexture sourceTexture, IMTLTexture destinationTexture, nint operations, nuint count)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyTextureMappingsFromTexture:toTexture:operations:count:"), sourceTexture__handle__, destinationTexture__handle__, operations, count);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[Export ("updateBufferMappings:heap:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateBufferMappings (IMTLBuffer buffer, IMTLHeap? heap, nint operations, nuint count)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var heap__handle__ = heap.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("updateBufferMappings:heap:operations:count:"), buffer__handle__, heap__handle__, operations, count);
			GC.KeepAlive (buffer);
			GC.KeepAlive (heap);
		}
		[Export ("copyBufferMappingsFromBuffer:toBuffer:operations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyBufferMappings (IMTLBuffer sourceBuffer, IMTLBuffer destinationBuffer, nint operations, nuint count)
		{
			var sourceBuffer__handle__ = sourceBuffer!.GetNonNullHandle (nameof (sourceBuffer));
			var destinationBuffer__handle__ = destinationBuffer!.GetNonNullHandle (nameof (destinationBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("copyBufferMappingsFromBuffer:toBuffer:operations:count:"), sourceBuffer__handle__, destinationBuffer__handle__, operations, count);
			GC.KeepAlive (sourceBuffer);
			GC.KeepAlive (destinationBuffer);
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
		}
	}
}
