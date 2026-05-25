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
	/// <summary>This interface represents the Objective-C protocol <c>MTLSharedEvent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLSharedEvent", WrapperType = typeof (MTLSharedEventWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyListener", Selector = "notifyListener:atValue:block:", ParameterType = new Type [] { typeof (MTLSharedEventListener), typeof (ulong), typeof (MTLSharedEventNotificationBlock) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLSharedEventNotificationBlock) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedEventHandle", Selector = "newSharedEventHandle", ReturnType = typeof (MTLSharedEventHandle))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilSignaledValue", Selector = "waitUntilSignaledValue:timeoutMS:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ulong), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SignaledValue", Selector = "signaledValue", PropertyType = typeof (ulong), GetterSelector = "signaledValue", SetterSelector = "setSignaledValue:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLSharedEvent : INativeObject, IDisposable, 
		Metal.IMTLEvent
	{
		/// <param name="listener">To be added.</param><param name="atValue">To be added.</param><param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("notifyListener:atValue:block:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NotifyListener (MTLSharedEventListener listener, ulong atValue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLSharedEventNotificationBlock))]MTLSharedEventNotificationBlock block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="listener">To be added.</param><param name="atValue">To be added.</param><param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _NotifyListener (IMTLSharedEvent This, MTLSharedEventListener listener, ulong atValue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLSharedEventNotificationBlock))]MTLSharedEventNotificationBlock block)
		{
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDMTLSharedEventNotificationBlock.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_NativeHandle (This.Handle, Selector.GetHandle ("notifyListener:atValue:block:"), listener__handle__, atValue, (IntPtr) block_ptr_block);
			GC.KeepAlive (This);
			GC.KeepAlive (listener);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newSharedEventHandle")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSharedEventHandle CreateSharedEventHandle ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSharedEventHandle _CreateSharedEventHandle (IMTLSharedEvent This)
		{
			MTLSharedEventHandle? ret;
			ret =  Runtime.GetNSObject<MTLSharedEventHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newSharedEventHandle")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("waitUntilSignaledValue:timeoutMS:")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WaitUntilSignaledValue (ulong value, ulong milliseconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WaitUntilSignaledValue (IMTLSharedEvent This, ulong value, ulong milliseconds)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt64_UInt64 (This.Handle, Selector.GetHandle ("waitUntilSignaledValue:timeoutMS:"), value, milliseconds);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("CreateSharedEventHandle()")]
		[DynamicDependencyAttribute ("NotifyListener(Metal.MTLSharedEventListener,System.UInt64,Metal.MTLSharedEventNotificationBlock)")]
		[DynamicDependencyAttribute ("SignaledValue")]
		[DynamicDependencyAttribute ("WaitUntilSignaledValue(System.UInt64,System.UInt64)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLSharedEventWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLSharedEvent ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual ulong SignaledValue {
			[Export ("signaledValue")]
			get {
				return _GetSignaledValue (this);
			}
			[Export ("setSignaledValue:")]
			set {
				_SetSignaledValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetSignaledValue (IMTLSharedEvent This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("signaledValue"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSignaledValue (IMTLSharedEvent This, ulong value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("setSignaledValue:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLSharedEventWrapper : BaseWrapper, IMTLSharedEvent {
		public MTLSharedEventWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLSharedEventWrapper))]
		static MTLSharedEventWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="listener">To be added.</param><param name="atValue">To be added.</param><param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("notifyListener:atValue:block:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void NotifyListener (MTLSharedEventListener listener, ulong atValue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLSharedEventNotificationBlock))]MTLSharedEventNotificationBlock block)
		{
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDMTLSharedEventNotificationBlock.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_NativeHandle (this.Handle, Selector.GetHandle ("notifyListener:atValue:block:"), listener__handle__, atValue, (IntPtr) block_ptr_block);
			GC.KeepAlive (listener);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newSharedEventHandle")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSharedEventHandle CreateSharedEventHandle ()
		{
			MTLSharedEventHandle? ret;
			ret =  Runtime.GetNSObject<MTLSharedEventHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newSharedEventHandle")), true)!;
			return ret!;
		}
		[Export ("waitUntilSignaledValue:timeoutMS:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool WaitUntilSignaledValue (ulong value, ulong milliseconds)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt64_UInt64 (this.Handle, Selector.GetHandle ("waitUntilSignaledValue:timeoutMS:"), value, milliseconds);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ulong SignaledValue {
			[Export ("signaledValue")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("signaledValue"));
				return ret;
			}
			[Export ("setSignaledValue:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSignaledValue:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice? Device {
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
		public string? Label {
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
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
