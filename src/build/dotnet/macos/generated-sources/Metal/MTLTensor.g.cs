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
	/// <summary>This interface represents the Objective-C protocol <c>MTLTensor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTLTensor", WrapperType = typeof (MTLTensorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceSliceOrigin", Selector = "replaceSliceOrigin:sliceDimensions:withBytes:strides:", ParameterType = new Type [] { typeof (MTLTensorExtents), typeof (MTLTensorExtents), typeof (IntPtr), typeof (MTLTensorExtents) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBytes", Selector = "getBytes:strides:fromSliceOrigin:sliceDimensions:", ParameterType = new Type [] { typeof (IntPtr), typeof (MTLTensorExtents), typeof (MTLTensorExtents), typeof (MTLTensorExtents) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceId", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Buffer", Selector = "buffer", PropertyType = typeof (IMTLBuffer), GetterSelector = "buffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferOffset", Selector = "bufferOffset", PropertyType = typeof (UIntPtr), GetterSelector = "bufferOffset", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Strides", Selector = "strides", PropertyType = typeof (MTLTensorExtents), GetterSelector = "strides", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Dimensions", Selector = "dimensions", PropertyType = typeof (MTLTensorExtents), GetterSelector = "dimensions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DataType", Selector = "dataType", PropertyType = typeof (MTLTensorDataType), GetterSelector = "dataType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Usage", Selector = "usage", PropertyType = typeof (MTLTensorUsage), GetterSelector = "usage", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLTensor : INativeObject, IDisposable, 
		Metal.IMTLAllocation
		, Metal.IMTLResource
	{
		[global::Foundation.RequiredMember]
		[Export ("replaceSliceOrigin:sliceDimensions:withBytes:strides:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceSliceOrigin (MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions, nint bytes, MTLTensorExtents strides)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceSliceOrigin (IMTLTensor This, MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions, nint bytes, MTLTensorExtents strides)
		{
			var sliceOrigin__handle__ = sliceOrigin!.GetNonNullHandle (nameof (sliceOrigin));
			var sliceDimensions__handle__ = sliceDimensions!.GetNonNullHandle (nameof (sliceDimensions));
			var strides__handle__ = strides!.GetNonNullHandle (nameof (strides));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("replaceSliceOrigin:sliceDimensions:withBytes:strides:"), sliceOrigin__handle__, sliceDimensions__handle__, bytes, strides__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sliceOrigin);
			GC.KeepAlive (sliceDimensions);
			GC.KeepAlive (strides);
		}
		[global::Foundation.RequiredMember]
		[Export ("getBytes:strides:fromSliceOrigin:sliceDimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetBytes (nint bytes, MTLTensorExtents strides, MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetBytes (IMTLTensor This, nint bytes, MTLTensorExtents strides, MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions)
		{
			var strides__handle__ = strides!.GetNonNullHandle (nameof (strides));
			var sliceOrigin__handle__ = sliceOrigin!.GetNonNullHandle (nameof (sliceOrigin));
			var sliceDimensions__handle__ = sliceDimensions!.GetNonNullHandle (nameof (sliceDimensions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getBytes:strides:fromSliceOrigin:sliceDimensions:"), bytes, strides__handle__, sliceOrigin__handle__, sliceDimensions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (strides);
			GC.KeepAlive (sliceOrigin);
			GC.KeepAlive (sliceDimensions);
		}
		[DynamicDependencyAttribute ("Buffer")]
		[DynamicDependencyAttribute ("BufferOffset")]
		[DynamicDependencyAttribute ("DataType")]
		[DynamicDependencyAttribute ("Dimensions")]
		[DynamicDependencyAttribute ("GetBytes(System.IntPtr,Metal.MTLTensorExtents,Metal.MTLTensorExtents,Metal.MTLTensorExtents)")]
		[DynamicDependencyAttribute ("GpuResourceId")]
		[DynamicDependencyAttribute ("ReplaceSliceOrigin(Metal.MTLTensorExtents,Metal.MTLTensorExtents,System.IntPtr,Metal.MTLTensorExtents)")]
		[DynamicDependencyAttribute ("Strides")]
		[DynamicDependencyAttribute ("Usage")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTensorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLTensor ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceId (IMTLTensor This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLBuffer? Buffer {
			[Export ("buffer")]
			get {
				return _GetBuffer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer _GetBuffer (IMTLTensor This)
		{
			IMTLBuffer ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("buffer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint BufferOffset {
			[Export ("bufferOffset")]
			get {
				return _GetBufferOffset (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBufferOffset (IMTLTensor This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferOffset"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTensorExtents? Strides {
			[Export ("strides")]
			get {
				return _GetStrides (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTensorExtents _GetStrides (IMTLTensor This)
		{
			MTLTensorExtents ret;
			ret =  Runtime.GetNSObject<MTLTensorExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("strides")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTensorExtents Dimensions {
			[Export ("dimensions")]
			get {
				return _GetDimensions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTensorExtents _GetDimensions (IMTLTensor This)
		{
			MTLTensorExtents ret;
			ret =  Runtime.GetNSObject<MTLTensorExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dimensions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTensorDataType DataType {
			[Export ("dataType")]
			get {
				return _GetDataType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTensorDataType _GetDataType (IMTLTensor This)
		{
			MTLTensorDataType ret;
			ret = (MTLTensorDataType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dataType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTensorUsage Usage {
			[Export ("usage")]
			get {
				return _GetUsage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTensorUsage _GetUsage (IMTLTensor This)
		{
			MTLTensorUsage ret;
			ret = (MTLTensorUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("usage"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLTensorWrapper : BaseWrapper, IMTLTensor {
		public MTLTensorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTensorWrapper))]
		static MTLTensorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("replaceSliceOrigin:sliceDimensions:withBytes:strides:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceSliceOrigin (MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions, nint bytes, MTLTensorExtents strides)
		{
			var sliceOrigin__handle__ = sliceOrigin!.GetNonNullHandle (nameof (sliceOrigin));
			var sliceDimensions__handle__ = sliceDimensions!.GetNonNullHandle (nameof (sliceDimensions));
			var strides__handle__ = strides!.GetNonNullHandle (nameof (strides));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("replaceSliceOrigin:sliceDimensions:withBytes:strides:"), sliceOrigin__handle__, sliceDimensions__handle__, bytes, strides__handle__);
			GC.KeepAlive (sliceOrigin);
			GC.KeepAlive (sliceDimensions);
			GC.KeepAlive (strides);
		}
		[Export ("getBytes:strides:fromSliceOrigin:sliceDimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetBytes (nint bytes, MTLTensorExtents strides, MTLTensorExtents sliceOrigin, MTLTensorExtents sliceDimensions)
		{
			var strides__handle__ = strides!.GetNonNullHandle (nameof (strides));
			var sliceOrigin__handle__ = sliceOrigin!.GetNonNullHandle (nameof (sliceOrigin));
			var sliceDimensions__handle__ = sliceDimensions!.GetNonNullHandle (nameof (sliceDimensions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getBytes:strides:fromSliceOrigin:sliceDimensions:"), bytes, strides__handle__, sliceOrigin__handle__, sliceDimensions__handle__);
			GC.KeepAlive (strides);
			GC.KeepAlive (sliceOrigin);
			GC.KeepAlive (sliceDimensions);
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? Buffer {
			[Export ("buffer")]
			get {
				IMTLBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buffer")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint BufferOffset {
			[Export ("bufferOffset")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTensorExtents? Strides {
			[Export ("strides")]
			get {
				MTLTensorExtents ret;
				ret =  Runtime.GetNSObject<MTLTensorExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("strides")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTensorExtents Dimensions {
			[Export ("dimensions")]
			get {
				MTLTensorExtents ret;
				ret =  Runtime.GetNSObject<MTLTensorExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dimensions")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTensorDataType DataType {
			[Export ("dataType")]
			get {
				MTLTensorDataType ret;
				ret = (MTLTensorDataType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataType"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTensorUsage Usage {
			[Export ("usage")]
			get {
				MTLTensorUsage ret;
				ret = (MTLTensorUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("usage"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public string Label {
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
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLCpuCacheMode ret;
				ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cpuCacheMode"));
				return ret!;
			}
		}
		/// <summary>Returns a description of the location and permissions of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLStorageMode ret;
				ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storageMode"));
				return ret!;
			}
		}
		/// <summary>Returns the heap that sub-allocated the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public IMTLHeap? Heap {
			[Export ("heap")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				IMTLHeap ret;
				ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heap")), false)!;
				return ret;
			}
		}
		/// <summary>Returns a Boolean value that tells whether future sub-allocations can alias the resource's memory.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public bool IsAliasable {
			[Export ("isAliasable")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAliasable"));
				return ret != 0;
			}
		}
		/// <summary>Returns the allocated size of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLResourceOptions ret;
				ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		public nuint HeapOffset {
			[Export ("heapOffset")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heapOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		public MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
	}
}
