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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4ArgumentTable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4ArgumentTable", WrapperType = typeof (MTL4ArgumentTableWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAddress", Selector = "setAddress:atIndex:", ParameterType = new Type [] { typeof (ulong), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAddress", Selector = "setAddress:attributeStride:atIndex:", ParameterType = new Type [] { typeof (ulong), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetResource", Selector = "setResource:atBufferIndex:", ParameterType = new Type [] { typeof (MTLResourceId), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTexture", Selector = "setTexture:atIndex:", ParameterType = new Type [] { typeof (MTLResourceId), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:atIndex:", ParameterType = new Type [] { typeof (MTLResourceId), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4ArgumentTable : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("setAddress:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAddress (ulong gpuAddress, nuint bindingIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAddress (IMTL4ArgumentTable This, ulong gpuAddress, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_UIntPtr (This.Handle, Selector.GetHandle ("setAddress:atIndex:"), gpuAddress, bindingIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setAddress:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAddress (ulong gpuAddress, nuint stride, nuint bindingIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAddress (IMTL4ArgumentTable This, ulong gpuAddress, nuint stride, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setAddress:attributeStride:atIndex:"), gpuAddress, stride, bindingIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setResource:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetResource (MTLResourceId resourceId, nuint bindingIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetResource (IMTL4ArgumentTable This, MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (This.Handle, Selector.GetHandle ("setResource:atBufferIndex:"), resourceId, bindingIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTexture (MTLResourceId resourceId, nuint bindingIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTexture (IMTL4ArgumentTable This, MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (This.Handle, Selector.GetHandle ("setTexture:atIndex:"), resourceId, bindingIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSamplerState (MTLResourceId resourceId, nuint bindingIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSamplerState (IMTL4ArgumentTable This, MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (This.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), resourceId, bindingIndex);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("SetAddress(System.UInt64,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetAddress(System.UInt64,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetResource(Metal.MTLResourceId,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetSamplerState(Metal.MTLResourceId,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTexture(Metal.MTLResourceId,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ArgumentTableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4ArgumentTable ()
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
		internal static IMTLDevice _GetDevice (IMTL4ArgumentTable This)
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
		internal static string _GetLabel (IMTL4ArgumentTable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4ArgumentTableWrapper : BaseWrapper, IMTL4ArgumentTable {
		public MTL4ArgumentTableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ArgumentTableWrapper))]
		static MTL4ArgumentTableWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setAddress:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAddress (ulong gpuAddress, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_UIntPtr (this.Handle, Selector.GetHandle ("setAddress:atIndex:"), gpuAddress, bindingIndex);
		}
		[Export ("setAddress:attributeStride:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAddress (ulong gpuAddress, nuint stride, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setAddress:attributeStride:atIndex:"), gpuAddress, stride, bindingIndex);
		}
		[Export ("setResource:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetResource (MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (this.Handle, Selector.GetHandle ("setResource:atBufferIndex:"), resourceId, bindingIndex);
		}
		[Export ("setTexture:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTexture (MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (this.Handle, Selector.GetHandle ("setTexture:atIndex:"), resourceId, bindingIndex);
		}
		[Export ("setSamplerState:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSamplerState (MTLResourceId resourceId, nuint bindingIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MTLResourceId_UIntPtr (this.Handle, Selector.GetHandle ("setSamplerState:atIndex:"), resourceId, bindingIndex);
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
