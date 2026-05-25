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
	/// <summary>This interface represents the Objective-C protocol <c>MTLIndirectCommandBuffer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLIndirectCommandBuffer", WrapperType = typeof (MTLIndirectCommandBufferWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reset", Selector = "resetWithRange:", ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCommand", Selector = "indirectRenderCommandAtIndex:", ReturnType = typeof (IMTLIndirectRenderCommand), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetIndirectComputeCommand", Selector = "indirectComputeCommandAtIndex:", ReturnType = typeof (IMTLIndirectComputeCommand), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof (UIntPtr), GetterSelector = "size", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceID", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLIndirectCommandBuffer : INativeObject, IDisposable, 
		Metal.IMTLAllocation
		, Metal.IMTLResource
	{
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("resetWithRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Reset (IMTLIndirectCommandBuffer This, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("resetWithRange:"), range);
			GC.KeepAlive (This);
		}
		/// <param name="commandIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("indirectRenderCommandAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLIndirectRenderCommand GetCommand (nuint commandIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="commandIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLIndirectRenderCommand _GetCommand (IMTLIndirectCommandBuffer This, nuint commandIndex)
		{
			IMTLIndirectRenderCommand ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectRenderCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("indirectRenderCommandAtIndex:"), commandIndex), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("indirectComputeCommandAtIndex:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLIndirectComputeCommand GetIndirectComputeCommand (nuint commandIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLIndirectComputeCommand _GetIndirectComputeCommand (IMTLIndirectCommandBuffer This, nuint commandIndex)
		{
			IMTLIndirectComputeCommand ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectComputeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("indirectComputeCommandAtIndex:"), commandIndex), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetCommand(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetIndirectComputeCommand(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GpuResourceID")]
		[DynamicDependencyAttribute ("Reset(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("Size")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectCommandBufferWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLIndirectCommandBuffer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Size {
			[Export ("size")]
			get {
				return _GetSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSize (IMTLIndirectCommandBuffer This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("size"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId GpuResourceID {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceID (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceID (IMTLIndirectCommandBuffer This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLIndirectCommandBuffer" /> interface to support all the methods from the MTLIndirectCommandBuffer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLIndirectCommandBuffer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLIndirectCommandBuffer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLIndirectCommandBuffer_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLResourceId GetGpuResourceID (this IMTLIndirectCommandBuffer This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLIndirectCommandBufferWrapper : BaseWrapper, IMTLIndirectCommandBuffer {
		public MTLIndirectCommandBufferWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIndirectCommandBufferWrapper))]
		static MTLIndirectCommandBufferWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resetWithRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Reset (NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("resetWithRange:"), range);
		}
		/// <param name="commandIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indirectRenderCommandAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLIndirectRenderCommand GetCommand (nuint commandIndex)
		{
			IMTLIndirectRenderCommand ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectRenderCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("indirectRenderCommandAtIndex:"), commandIndex), false)!;
			return ret;
		}
		[Export ("indirectComputeCommandAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLIndirectComputeCommand GetIndirectComputeCommand (nuint commandIndex)
		{
			IMTLIndirectComputeCommand ret;
			ret =  Runtime.GetINativeObject<IMTLIndirectComputeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("indirectComputeCommandAtIndex:"), commandIndex), false)!;
			return ret;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setPurgeableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLPurgeableState SetPurgeableState (MTLPurgeableState state)
		{
			MTLPurgeableState ret;
			ret = (MTLPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPurgeableState:"), (UIntPtr) (ulong) state);
			return ret!;
		}
		/// <summary>Makes the resource aliasable.</summary>
		[Export ("makeAliasable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MakeAliasable ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("makeAliasable"));
		}
		[Export ("setOwnerWithIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public int SetOwnerWithIdentity (uint taskIdToken)
		{
			int ret;
			ret = global::ObjCRuntime.Messaging.int_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setOwnerWithIdentity:"), taskIdToken);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Size {
			[Export ("size")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLResourceId GpuResourceID {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLCpuCacheMode ret;
				ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cpuCacheMode"));
				return ret!;
			}
		}
		/// <summary>Returns a description of the location and permissions of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLStorageMode ret;
				ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storageMode"));
				return ret!;
			}
		}
		/// <summary>Returns the heap that sub-allocated the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLHeap? Heap {
			[Export ("heap")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLHeap ret;
				ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heap")), false)!;
				return ret;
			}
		}
		/// <summary>Returns a Boolean value that tells whether future sub-allocations can alias the resource's memory.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool IsAliasable {
			[Export ("isAliasable")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAliasable"));
				return ret != 0;
			}
		}
		/// <summary>Returns the allocated size of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLResourceOptions ret;
				ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint HeapOffset {
			[Export ("heapOffset")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heapOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
	}
}
