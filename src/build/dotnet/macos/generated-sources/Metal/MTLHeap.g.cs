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
	/// <summary>This interface represents the Objective-C protocol <c>MTLHeap</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLHeap", WrapperType = typeof (MTLHeapWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMaxAvailableSize", Selector = "maxAvailableSizeWithAlignment:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLResourceOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPurgeableState", Selector = "setPurgeableState:", ReturnType = typeof (MTLPurgeableState), ParameterType = new Type [] { typeof (MTLPurgeableState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:offset:", ReturnType = typeof (IMTLBuffer), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLResourceOptions), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:offset:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithSize:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithDescriptor:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (MTLAccelerationStructureDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithSize:offset:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAccelerationStructure", Selector = "newAccelerationStructureWithDescriptor:offset:", ReturnType = typeof (IMTLAccelerationStructure), ParameterType = new Type [] { typeof (MTLAccelerationStructureDescriptor), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StorageMode", Selector = "storageMode", PropertyType = typeof (MTLStorageMode), GetterSelector = "storageMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CpuCacheMode", Selector = "cpuCacheMode", PropertyType = typeof (MTLCpuCacheMode), GetterSelector = "cpuCacheMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof (UIntPtr), GetterSelector = "size", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UsedSize", Selector = "usedSize", PropertyType = typeof (UIntPtr), GetterSelector = "usedSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentAllocatedSize", Selector = "currentAllocatedSize", PropertyType = typeof (UIntPtr), GetterSelector = "currentAllocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HazardTrackingMode", Selector = "hazardTrackingMode", PropertyType = typeof (MTLHazardTrackingMode), GetterSelector = "hazardTrackingMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ResourceOptions", Selector = "resourceOptions", PropertyType = typeof (MTLResourceOptions), GetterSelector = "resourceOptions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (MTLHeapType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLHeap : INativeObject, IDisposable, 
		Metal.IMTLAllocation
	{
		/// <param name="alignment">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("maxAvailableSizeWithAlignment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetMaxAvailableSize (nuint alignment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alignment">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxAvailableSize (IMTLHeap This, nuint alignment)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("maxAvailableSizeWithAlignment:"), alignment);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithLength:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer? _CreateBuffer (IMTLHeap This, nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBufferWithLength:options:"), length, (UIntPtr) (ulong) options), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="desc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTexture (MTLTextureDescriptor desc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="desc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTexture (IMTLHeap This, MTLTextureDescriptor desc)
		{
			var desc__handle__ = desc!.GetNonNullHandle (nameof (desc));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newTextureWithDescriptor:"), desc__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (desc);
			return ret!;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setPurgeableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLPurgeableState SetPurgeableState (MTLPurgeableState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLPurgeableState _SetPurgeableState (IMTLHeap This, MTLPurgeableState state)
		{
			MTLPurgeableState ret;
			ret = (MTLPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setPurgeableState:"), (UIntPtr) (ulong) state);
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithLength:options:offset:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLBuffer? _CreateBuffer (IMTLHeap This, nuint length, MTLResourceOptions options, nuint offset)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBufferWithLength:options:offset:"), length, (UIntPtr) (ulong) options, offset), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newTextureWithDescriptor:offset:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTexture (IMTLHeap This, MTLTextureDescriptor descriptor, nuint offset)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newTextureWithDescriptor:offset:"), descriptor__handle__, offset), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithSize:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (nuint size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLHeap This, nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLHeap This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithSize:offset:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (nuint size, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLHeap This, nuint size, nuint offset)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:offset:"), size, offset), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newAccelerationStructureWithDescriptor:offset:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAccelerationStructure? _CreateAccelerationStructure (IMTLHeap This, MTLAccelerationStructureDescriptor descriptor, nuint offset)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:offset:"), descriptor__handle__, offset), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[DynamicDependencyAttribute ("CpuCacheMode")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(Metal.MTLAccelerationStructureDescriptor,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(Metal.MTLAccelerationStructureDescriptor)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateAccelerationStructure(System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.UIntPtr,Metal.MTLResourceOptions,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.UIntPtr,Metal.MTLResourceOptions)")]
		[DynamicDependencyAttribute ("CreateTexture(Metal.MTLTextureDescriptor,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CreateTexture(Metal.MTLTextureDescriptor)")]
		[DynamicDependencyAttribute ("CurrentAllocatedSize")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("GetMaxAvailableSize(System.UIntPtr)")]
		[DynamicDependencyAttribute ("HazardTrackingMode")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("ResourceOptions")]
		[DynamicDependencyAttribute ("SetPurgeableState(Metal.MTLPurgeableState)")]
		[DynamicDependencyAttribute ("Size")]
		[DynamicDependencyAttribute ("StorageMode")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute ("UsedSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLHeapWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLHeap ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		internal static string _GetLabel (IMTLHeap This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLHeap This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLHeap This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLStorageMode StorageMode {
			[Export ("storageMode")]
			get {
				return _GetStorageMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLStorageMode _GetStorageMode (IMTLHeap This)
		{
			MTLStorageMode ret;
			ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("storageMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			get {
				return _GetCpuCacheMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLCpuCacheMode _GetCpuCacheMode (IMTLHeap This)
		{
			MTLCpuCacheMode ret;
			ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("cpuCacheMode"));
			GC.KeepAlive (This);
			return ret!;
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
		internal static nuint _GetSize (IMTLHeap This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("size"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint UsedSize {
			[Export ("usedSize")]
			get {
				return _GetUsedSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetUsedSize (IMTLHeap This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("usedSize"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the current allcoated size of the heap.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint CurrentAllocatedSize {
			[Export ("currentAllocatedSize")]
			get {
				return _GetCurrentAllocatedSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetCurrentAllocatedSize (IMTLHeap This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("currentAllocatedSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			get {
				return _GetHazardTrackingMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLHazardTrackingMode _GetHazardTrackingMode (IMTLHeap This)
		{
			MTLHazardTrackingMode ret;
			ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("hazardTrackingMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			get {
				return _GetResourceOptions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceOptions _GetResourceOptions (IMTLHeap This)
		{
			MTLResourceOptions ret;
			ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("resourceOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLHeapType Type {
			[Export ("type")]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLHeapType _GetType (IMTLHeap This)
		{
			MTLHeapType ret;
			ret = (MTLHeapType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLHeap" /> interface to support all the methods from the MTLHeap protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLHeap" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLHeap protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLHeap_Extensions {
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLHeap This, nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLHeap This, MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLHeap This, nuint size, nuint offset)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:offset:"), size, offset), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLAccelerationStructure? CreateAccelerationStructure (this IMTLHeap This, MTLAccelerationStructureDescriptor descriptor, nuint offset)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:offset:"), descriptor__handle__, offset), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLHeapWrapper : BaseWrapper, IMTLHeap {
		public MTLHeapWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLHeapWrapper))]
		static MTLHeapWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="alignment">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("maxAvailableSizeWithAlignment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetMaxAvailableSize (nuint alignment)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("maxAvailableSizeWithAlignment:"), alignment);
			return ret;
		}
		/// <param name="length">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferWithLength:options:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBufferWithLength:options:"), length, (UIntPtr) (ulong) options), true)!;
			return ret!;
		}
		/// <param name="desc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newTextureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTexture (MTLTextureDescriptor desc)
		{
			var desc__handle__ = desc!.GetNonNullHandle (nameof (desc));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newTextureWithDescriptor:"), desc__handle__), true)!;
			GC.KeepAlive (desc);
			return ret!;
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
		[Export ("newBufferWithLength:options:offset:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLBuffer? CreateBuffer (nuint length, MTLResourceOptions options, nuint offset)
		{
			IMTLBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBufferWithLength:options:offset:"), length, (UIntPtr) (ulong) options, offset), true)!;
			return ret!;
		}
		[Export ("newTextureWithDescriptor:offset:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, nuint offset)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newTextureWithDescriptor:offset:"), descriptor__handle__, offset), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newAccelerationStructureWithSize:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (nuint size)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:"), size), true)!;
			return ret!;
		}
		[Export ("newAccelerationStructureWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newAccelerationStructureWithSize:offset:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (nuint size, nuint offset)
		{
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newAccelerationStructureWithSize:offset:"), size, offset), true)!;
			return ret!;
		}
		[Export ("newAccelerationStructureWithDescriptor:offset:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAccelerationStructure? CreateAccelerationStructure (MTLAccelerationStructureDescriptor descriptor, nuint offset)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLAccelerationStructure? ret;
			ret =  Runtime.GetINativeObject<IMTLAccelerationStructure> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newAccelerationStructureWithDescriptor:offset:"), descriptor__handle__, offset), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			get {
				MTLStorageMode ret;
				ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storageMode"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			get {
				MTLCpuCacheMode ret;
				ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cpuCacheMode"));
				return ret!;
			}
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint UsedSize {
			[Export ("usedSize")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("usedSize"));
				return ret;
			}
		}
		/// <summary>Returns the current allcoated size of the heap.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint CurrentAllocatedSize {
			[Export ("currentAllocatedSize")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentAllocatedSize"));
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
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
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
		public MTLHeapType Type {
			[Export ("type")]
			get {
				MTLHeapType ret;
				ret = (MTLHeapType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
	}
}
