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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ModelIO {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MDLMeshBufferAllocator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLMeshBufferAllocator", WrapperType = typeof (MDLMeshBufferAllocatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateZone", Selector = "newZone:", ReturnType = typeof (IMDLMeshBufferZone), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateZone", Selector = "newZoneForBuffersWithSize:andType:", ReturnType = typeof (IMDLMeshBufferZone), ParameterType = new Type [] { typeof (NSNumber[]), typeof (NSNumber[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBuffer:type:", ReturnType = typeof (IMDLMeshBuffer), ParameterType = new Type [] { typeof (UIntPtr), typeof (MDLMeshBufferType) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithData:type:", ReturnType = typeof (IMDLMeshBuffer), ParameterType = new Type [] { typeof (NSData), typeof (MDLMeshBufferType) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferFromZone:length:type:", ReturnType = typeof (IMDLMeshBuffer), ParameterType = new Type [] { typeof (IMDLMeshBufferZone), typeof (UIntPtr), typeof (MDLMeshBufferType) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferFromZone:data:type:", ReturnType = typeof (IMDLMeshBuffer), ParameterType = new Type [] { typeof (IMDLMeshBufferZone), typeof (NSData), typeof (MDLMeshBufferType) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IMDLMeshBufferAllocator : INativeObject, IDisposable
	{
		/// <param name="capacity">To be added.</param><summary>Creates and returns a new mesh buffer zone with the specified  <paramref name="capacity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBufferZone CreateZone (nuint capacity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="capacity">To be added.</param><summary>Creates and returns a new mesh buffer zone with the specified  <paramref name="capacity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBufferZone _CreateZone (IMDLMeshBufferAllocator This, nuint capacity)
		{
			IMDLMeshBufferZone ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newZone:"), capacity), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="sizes">To be added.</param><param name="types">To be added.</param><summary>Creates a new zone that is large enough to contain buffers from the list of sizes and corresponding types.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newZoneForBuffersWithSize:andType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBufferZone CreateZone (NSNumber[] sizes, NSNumber[] types)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sizes">To be added.</param><param name="types">To be added.</param><summary>Creates a new zone that is large enough to contain buffers from the list of sizes and corresponding types.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBufferZone _CreateZone (IMDLMeshBufferAllocator This, NSNumber[] sizes, NSNumber[] types)
		{
			if (sizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sizes));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_sizes = NSArray.FromNSObjects (sizes);
			using var nsa_types = NSArray.FromNSObjects (types);
			IMDLMeshBufferZone ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newZoneForBuffersWithSize:andType:"), nsa_sizes.Handle, nsa_types.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBuffer:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer CreateBuffer (nuint length, MDLMeshBufferType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBuffer _CreateBuffer (IMDLMeshBufferAllocator This, nuint length, MDLMeshBufferType type)
		{
			IMDLMeshBuffer ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBuffer:type:"), length, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the default zone of the implementor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBufferWithData:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer CreateBuffer (NSData data, MDLMeshBufferType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the default zone of the implementor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBuffer _CreateBuffer (IMDLMeshBufferAllocator This, NSData data, MDLMeshBufferType type)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newBufferWithData:type:"), data__handle__, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBufferFromZone:length:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="zone">To be added.</param><param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBuffer? _CreateBuffer (IMDLMeshBufferAllocator This, IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newBufferFromZone:length:type:"), zone__handle__, length, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the specified zone.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newBufferFromZone:data:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="zone">To be added.</param><param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the specified zone.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBuffer? _CreateBuffer (IMDLMeshBufferAllocator This, IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newBufferFromZone:data:type:"), zone__handle__, data__handle__, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (data);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateBuffer(Foundation.NSData,ModelIO.MDLMeshBufferType)")]
		[DynamicDependencyAttribute ("CreateBuffer(ModelIO.IMDLMeshBufferZone,Foundation.NSData,ModelIO.MDLMeshBufferType)")]
		[DynamicDependencyAttribute ("CreateBuffer(ModelIO.IMDLMeshBufferZone,System.UIntPtr,ModelIO.MDLMeshBufferType)")]
		[DynamicDependencyAttribute ("CreateBuffer(System.UIntPtr,ModelIO.MDLMeshBufferType)")]
		[DynamicDependencyAttribute ("CreateZone(Foundation.NSNumber[],Foundation.NSNumber[])")]
		[DynamicDependencyAttribute ("CreateZone(System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferAllocatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLMeshBufferAllocator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLMeshBufferAllocatorWrapper : BaseWrapper, IMDLMeshBufferAllocator {
		public MDLMeshBufferAllocatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferAllocatorWrapper))]
		static MDLMeshBufferAllocatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="capacity">To be added.</param><summary>Creates and returns a new mesh buffer zone with the specified  <paramref name="capacity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBufferZone CreateZone (nuint capacity)
		{
			IMDLMeshBufferZone ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newZone:"), capacity), false)!;
			return ret;
		}
		/// <param name="sizes">To be added.</param><param name="types">To be added.</param><summary>Creates a new zone that is large enough to contain buffers from the list of sizes and corresponding types.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newZoneForBuffersWithSize:andType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBufferZone CreateZone (NSNumber[] sizes, NSNumber[] types)
		{
			if (sizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sizes));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_sizes = NSArray.FromNSObjects (sizes);
			using var nsa_types = NSArray.FromNSObjects (types);
			IMDLMeshBufferZone ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newZoneForBuffersWithSize:andType:"), nsa_sizes.Handle, nsa_types.Handle), false)!;
			return ret;
		}
		/// <param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBuffer:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBuffer CreateBuffer (nuint length, MDLMeshBufferType type)
		{
			IMDLMeshBuffer ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBuffer:type:"), length, (UIntPtr) (ulong) type), false)!;
			return ret;
		}
		/// <param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the default zone of the implementor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferWithData:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBuffer CreateBuffer (NSData data, MDLMeshBufferType type)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newBufferWithData:type:"), data__handle__, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferFromZone:length:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newBufferFromZone:length:type:"), zone__handle__, length, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the specified zone.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferFromZone:data:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newBufferFromZone:data:type:"), zone__handle__, data__handle__, (UIntPtr) (ulong) type), false)!;
			GC.KeepAlive (zone);
			GC.KeepAlive (data);
			return ret!;
		}
	}
}
