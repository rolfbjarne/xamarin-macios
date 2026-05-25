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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>System protocol for objects that can queue command buffers for running on a GPU.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLCommandQueue", WrapperType = typeof (MTLCommandQueueWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommandBuffer", Selector = "commandBuffer", ReturnType = typeof (IMTLCommandBuffer))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommandBufferWithUnretainedReferences", Selector = "commandBufferWithUnretainedReferences", ReturnType = typeof (IMTLCommandBuffer))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertDebugCaptureBoundary", Selector = "insertDebugCaptureBoundary")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandBuffer", Selector = "commandBufferWithDescriptor:", ReturnType = typeof (IMTLCommandBuffer), ParameterType = new Type [] { typeof (MTLCommandBufferDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddResidencySet", Selector = "addResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddResidencySets", Selector = "addResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveResidencySet", Selector = "removeResidencySet:", ParameterType = new Type [] { typeof (IMTLResidencySet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveResidencySets", Selector = "removeResidencySets:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLCommandQueue : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commandBuffer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandBuffer? CommandBuffer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandBuffer? _CommandBuffer (IMTLCommandQueue This)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLCommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("commandBuffer")), false)!;
				GC.KeepAlive (This);
				return ret;
			}
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commandBufferWithUnretainedReferences")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandBuffer? CommandBufferWithUnretainedReferences ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandBuffer? _CommandBufferWithUnretainedReferences (IMTLCommandQueue This)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLCommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("commandBufferWithUnretainedReferences")), false)!;
				GC.KeepAlive (This);
				return ret;
			}
		}
		/// <summary>Developers should not use this deprecated method. Developers should use 'MTLCaptureScope' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("insertDebugCaptureBoundary")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MTLCaptureScope' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDebugCaptureBoundary ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Developers should not use this deprecated method. Developers should use 'MTLCaptureScope' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'MTLCaptureScope' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MTLCaptureScope' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertDebugCaptureBoundary (IMTLCommandQueue This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("insertDebugCaptureBoundary"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("commandBufferWithDescriptor:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCommandBuffer? CreateCommandBuffer (MTLCommandBufferDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLCommandBuffer? _CreateCommandBuffer (IMTLCommandQueue This, MTLCommandBufferDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLCommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("commandBufferWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("addResidencySet:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddResidencySet (IMTLCommandQueue This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("addResidencySets:count:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddResidencySets (IMTLCommandQueue This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("addResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeResidencySet:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveResidencySet (IMTLResidencySet residencySet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveResidencySet (IMTLCommandQueue This, IMTLResidencySet residencySet)
		{
			var residencySet__handle__ = residencySet!.GetNonNullHandle (nameof (residencySet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeResidencySet:"), residencySet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (residencySet);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeResidencySets:count:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveResidencySets (nint residencySets, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveResidencySets (IMTLCommandQueue This, nint residencySets, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("removeResidencySets:count:"), residencySets, count);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("AddResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CommandBuffer()")]
		[DynamicDependencyAttribute ("CommandBufferWithUnretainedReferences()")]
		[DynamicDependencyAttribute ("CreateCommandBuffer(Metal.MTLCommandBufferDescriptor)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("InsertDebugCaptureBoundary()")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("RemoveResidencySet(Metal.IMTLResidencySet)")]
		[DynamicDependencyAttribute ("RemoveResidencySets(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLCommandQueueWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLCommandQueue ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Label {
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
		internal static string _GetLabel (IMTLCommandQueue This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLCommandQueue This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
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
		internal static IMTLDevice _GetDevice (IMTLCommandQueue This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLCommandQueueWrapper : BaseWrapper, IMTLCommandQueue {
		public MTLCommandQueueWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLCommandQueueWrapper))]
		static MTLCommandQueueWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("commandBuffer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandBuffer? CommandBuffer ()
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLCommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandBuffer")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("commandBufferWithUnretainedReferences")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandBuffer? CommandBufferWithUnretainedReferences ()
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLCommandBuffer ret;
				ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandBufferWithUnretainedReferences")), false)!;
				return ret;
			}
		}
		/// <summary>Developers should not use this deprecated method. Developers should use 'MTLCaptureScope' instead.</summary><remarks>To be added.</remarks>
		[Export ("insertDebugCaptureBoundary")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugCaptureBoundary ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("insertDebugCaptureBoundary"));
		}
		[Export ("commandBufferWithDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLCommandBuffer? CreateCommandBuffer (MTLCommandBufferDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLCommandBuffer? ret;
			ret =  Runtime.GetINativeObject<IMTLCommandBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("commandBufferWithDescriptor:"), descriptor__handle__), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
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
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
	}
}
