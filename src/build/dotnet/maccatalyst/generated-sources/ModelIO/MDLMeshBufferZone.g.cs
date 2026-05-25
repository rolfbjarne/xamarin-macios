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
	/// <summary>This interface represents the Objective-C protocol <c>MDLMeshBufferZone</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLMeshBufferZone", WrapperType = typeof (MDLMeshBufferZoneWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Capacity", Selector = "capacity", PropertyType = typeof (UIntPtr), GetterSelector = "capacity", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Allocator", Selector = "allocator", PropertyType = typeof (IMDLMeshBufferAllocator), GetterSelector = "allocator", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMDLMeshBufferZone : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Allocator")]
		[DynamicDependencyAttribute ("Capacity")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferZoneWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLMeshBufferZone ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the capacity of the zone, in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Capacity {
			[Export ("capacity")]
			get {
				return _GetCapacity (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetCapacity (IMDLMeshBufferZone This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("capacity"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the allocator that created the zone.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMDLMeshBufferAllocator Allocator {
			[Export ("allocator")]
			get {
				return _GetAllocator (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMDLMeshBufferAllocator _GetAllocator (IMDLMeshBufferZone This)
		{
			IMDLMeshBufferAllocator ret;
			ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("allocator")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLMeshBufferZoneWrapper : BaseWrapper, IMDLMeshBufferZone {
		public MDLMeshBufferZoneWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLMeshBufferZoneWrapper))]
		static MDLMeshBufferZoneWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the capacity of the zone, in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Capacity {
			[Export ("capacity")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("capacity"));
				return ret;
			}
		}
		/// <summary>Gets the allocator that created the zone.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLMeshBufferAllocator Allocator {
			[Export ("allocator")]
			get {
				IMDLMeshBufferAllocator ret;
				ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allocator")), false)!;
				return ret;
			}
		}
	}
}
