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
namespace ModelIO {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MDLMeshBuffer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLMeshBuffer", WrapperType = typeof (MDLMeshBufferWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FillData", Selector = "fillData:offset:", ParameterType = new Type [] { typeof (NSData), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Map", Selector = "map", PropertyType = typeof (MDLMeshBufferMap), GetterSelector = "map", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Length", Selector = "length", PropertyType = typeof (UIntPtr), GetterSelector = "length", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Allocator", Selector = "allocator", PropertyType = typeof (IMDLMeshBufferAllocator), GetterSelector = "allocator", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Zone", Selector = "zone", PropertyType = typeof (IMDLMeshBufferZone), GetterSelector = "zone", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (MDLMeshBufferType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMDLMeshBuffer : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		/// <param name="data">To be added.</param><param name="offset">To be added.</param><summary>Writes <paramref name="data" /> into the buffer at the specified <paramref name="offset" /> number of bytes.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("fillData:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FillData (NSData data, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="data">To be added.</param><param name="offset">To be added.</param><summary>Writes <paramref name="data" /> into the buffer at the specified <paramref name="offset" /> number of bytes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FillData (IMDLMeshBuffer This, NSData data, nuint offset)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("fillData:offset:"), data__handle__, offset);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
		}
		[DynamicDependencyAttribute ("Allocator")]
		[DynamicDependencyAttribute ("FillData(Foundation.NSData,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Length")]
		[DynamicDependencyAttribute ("Map")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute ("Zone")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLMeshBuffer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets a mesh buffer map that provides read-only access to the data in the buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MDLMeshBufferMap Map {
			[Export ("map")]
			get {
				return _GetMap (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLMeshBufferMap _GetMap (IMDLMeshBuffer This)
		{
			MDLMeshBufferMap ret;
			ret =  Runtime.GetNSObject<MDLMeshBufferMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("map")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the length of the buffer, in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Length {
			[Export ("length")]
			get {
				return _GetLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetLength (IMDLMeshBuffer This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("length"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the allocator that is used to allocate memory for the mesh buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMDLMeshBufferAllocator Allocator {
			[Export ("allocator", ArgumentSemantic.Retain)]
			get {
				return _GetAllocator (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBufferAllocator _GetAllocator (IMDLMeshBuffer This)
		{
			IMDLMeshBufferAllocator ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("allocator")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the memory pool that the buffer occupies.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMDLMeshBufferZone? Zone {
			[Export ("zone", ArgumentSemantic.Retain)]
			get {
				return _GetZone (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBufferZone _GetZone (IMDLMeshBuffer This)
		{
			IMDLMeshBufferZone ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("zone")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets a value that indicates whether the buffer contains indices or vertices.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MDLMeshBufferType Type {
			[Export ("type")]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLMeshBufferType _GetType (IMDLMeshBuffer This)
		{
			MDLMeshBufferType ret;
			ret = (MDLMeshBufferType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLMeshBufferWrapper : BaseWrapper, IMDLMeshBuffer {
		public MDLMeshBufferWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferWrapper))]
		static MDLMeshBufferWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="data">To be added.</param><param name="offset">To be added.</param><summary>Writes <paramref name="data" /> into the buffer at the specified <paramref name="offset" /> number of bytes.</summary><remarks>To be added.</remarks>
		[Export ("fillData:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FillData (NSData data, nuint offset)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("fillData:offset:"), data__handle__, offset);
			GC.KeepAlive (data);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Gets a mesh buffer map that provides read-only access to the data in the buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMeshBufferMap Map {
			[Export ("map")]
			get {
				MDLMeshBufferMap ret;
				ret =  Runtime.GetNSObject<MDLMeshBufferMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("map")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the length of the buffer, in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Length {
			[Export ("length")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("length"));
				return ret;
			}
		}
		/// <summary>Gets the allocator that is used to allocate memory for the mesh buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBufferAllocator Allocator {
			[Export ("allocator", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBufferAllocator ret;
				ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allocator")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the memory pool that the buffer occupies.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBufferZone? Zone {
			[Export ("zone", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBufferZone ret;
				ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("zone")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a value that indicates whether the buffer contains indices or vertices.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMeshBufferType Type {
			[Export ("type")]
			get {
				MDLMeshBufferType ret;
				ret = (MDLMeshBufferType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
	}
}
