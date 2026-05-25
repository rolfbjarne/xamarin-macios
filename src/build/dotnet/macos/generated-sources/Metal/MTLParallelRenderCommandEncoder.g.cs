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
	/// <summary>System protocol for breaking a single rendering pass into parallel command sets.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLParallelRenderCommandEncoder", WrapperType = typeof (MTLParallelRenderCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoder", ReturnType = typeof (IMTLRenderCommandEncoder))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorStoreAction", Selector = "setColorStoreAction:atIndex:", ParameterType = new Type [] { typeof (MTLStoreAction), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStoreAction", Selector = "setDepthStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilStoreAction", Selector = "setStencilStoreAction:", ParameterType = new Type [] { typeof (MTLStoreAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetColorStoreActionOptions", Selector = "setColorStoreActionOptions:atIndex:", ParameterType = new Type [] { typeof (MTLStoreActionOptions), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDepthStoreActionOptions", Selector = "setDepthStoreActionOptions:", ParameterType = new Type [] { typeof (MTLStoreActionOptions) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStencilStoreActionOptions", Selector = "setStencilStoreActionOptions:", ParameterType = new Type [] { typeof (MTLStoreActionOptions) }, ParameterByRef = new bool [] { false })]
	public partial interface IMTLParallelRenderCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("renderCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLRenderCommandEncoder? CreateRenderCommandEncoder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLRenderCommandEncoder? _CreateRenderCommandEncoder (IMTLParallelRenderCommandEncoder This)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLRenderCommandEncoder ret;
				ret =  Runtime.GetINativeObject<IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("renderCommandEncoder")), false)!;
				GC.KeepAlive (This);
				return ret;
			}
		}
		[global::Foundation.RequiredMember]
		[Export ("setColorStoreAction:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorStoreAction (IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStoreAction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStoreAction (IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setStencilStoreAction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilStoreAction (IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[global::Foundation.RequiredMember]
		[Export ("setColorStoreActionOptions:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorStoreActionOptions (MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetColorStoreActionOptions (IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setColorStoreActionOptions:atIndex:"), (UIntPtr) (ulong) storeActionOptions, colorAttachmentIndex);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setDepthStoreActionOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDepthStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDepthStoreActionOptions (IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDepthStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
			GC.KeepAlive (This);
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[global::Foundation.RequiredMember]
		[Export ("setStencilStoreActionOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStencilStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStencilStoreActionOptions (IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setStencilStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CreateRenderCommandEncoder()")]
		[DynamicDependencyAttribute ("SetColorStoreAction(Metal.MTLStoreAction,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetColorStoreActionOptions(Metal.MTLStoreActionOptions,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetDepthStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetDepthStoreActionOptions(Metal.MTLStoreActionOptions)")]
		[DynamicDependencyAttribute ("SetStencilStoreAction(Metal.MTLStoreAction)")]
		[DynamicDependencyAttribute ("SetStencilStoreActionOptions(Metal.MTLStoreActionOptions)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLParallelRenderCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLParallelRenderCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLParallelRenderCommandEncoderWrapper : BaseWrapper, IMTLParallelRenderCommandEncoder {
		public MTLParallelRenderCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLParallelRenderCommandEncoderWrapper))]
		static MTLParallelRenderCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("renderCommandEncoder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLRenderCommandEncoder? CreateRenderCommandEncoder ()
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				IMTLRenderCommandEncoder ret;
				ret =  Runtime.GetINativeObject<IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("renderCommandEncoder")), false)!;
				return ret;
			}
		}
		[Export ("setColorStoreAction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorStoreAction (MTLStoreAction storeAction, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setColorStoreAction:atIndex:"), (UIntPtr) (ulong) storeAction, colorAttachmentIndex);
		}
		[Export ("setDepthStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		[Export ("setStencilStoreAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilStoreAction (MTLStoreAction storeAction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setStencilStoreAction:"), (UIntPtr) (ulong) storeAction);
		}
		/// <summary>Sets the store action options on the color attachment at the specified index.</summary><param name="storeActionOptions">The action to set.</param><param name="colorAttachmentIndex">The index of the color attachment.</param>
		[Export ("setColorStoreActionOptions:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetColorStoreActionOptions (MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setColorStoreActionOptions:atIndex:"), (UIntPtr) (ulong) storeActionOptions, colorAttachmentIndex);
		}
		[Export ("setDepthStoreActionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDepthStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDepthStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
		}
		/// <summary>Sets the store action options on the stencil attachment.</summary><param name="storeActionOptions">The action options to set.</param>
		[Export ("setStencilStoreActionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStencilStoreActionOptions (MTLStoreActionOptions storeActionOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setStencilStoreActionOptions:"), (UIntPtr) (ulong) storeActionOptions);
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
	}
}
