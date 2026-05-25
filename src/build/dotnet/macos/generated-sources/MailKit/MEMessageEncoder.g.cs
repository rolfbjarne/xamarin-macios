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
namespace MailKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEMessageEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEMessageEncoder", WrapperType = typeof (MEMessageEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetEncodingStatus", Selector = "getEncodingStatusForMessage:composeContext:completionHandler:", ParameterType = new Type [] { typeof (MailKit.MEMessage), typeof (MailKit.MEComposeContext), typeof (global::System.Action<global::MailKit.MEOutgoingMessageEncodingStatus>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V80) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EncodeMessage", Selector = "encodeMessage:composeContext:completionHandler:", ParameterType = new Type [] { typeof (MailKit.MEMessage), typeof (MailKit.MEComposeContext), typeof (global::System.Action<global::MailKit.MEMessageEncodingResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V81) })]
	public partial interface IMEMessageEncoder : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("getEncodingStatusForMessage:composeContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetEncodingStatus (MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<MEOutgoingMessageEncodingStatus> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetEncodingStatus (IMEMessageEncoder This, MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<MEOutgoingMessageEncodingStatus> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var composeContext__handle__ = composeContext!.GetNonNullHandle (nameof (composeContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V80.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getEncodingStatusForMessage:composeContext:completionHandler:"), message__handle__, composeContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
			GC.KeepAlive (composeContext);
		}
		[global::Foundation.RequiredMember]
		[Export ("encodeMessage:composeContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EncodeMessage (MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V81))]global::System.Action<MEMessageEncodingResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EncodeMessage (IMEMessageEncoder This, MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V81))]global::System.Action<MEMessageEncodingResult> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var composeContext__handle__ = composeContext!.GetNonNullHandle (nameof (composeContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V81.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("encodeMessage:composeContext:completionHandler:"), message__handle__, composeContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
			GC.KeepAlive (composeContext);
		}
		[DynamicDependencyAttribute ("EncodeMessage(MailKit.MEMessage,MailKit.MEComposeContext,System.Action{MailKit.MEMessageEncodingResult})")]
		[DynamicDependencyAttribute ("GetEncodingStatus(MailKit.MEMessage,MailKit.MEComposeContext,System.Action{MailKit.MEOutgoingMessageEncodingStatus})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEMessageEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEMessageEncoderWrapper : BaseWrapper, IMEMessageEncoder {
		public MEMessageEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageEncoderWrapper))]
		static MEMessageEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("getEncodingStatusForMessage:composeContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetEncodingStatus (MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<MEOutgoingMessageEncodingStatus> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var composeContext__handle__ = composeContext!.GetNonNullHandle (nameof (composeContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V80.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getEncodingStatusForMessage:composeContext:completionHandler:"), message__handle__, composeContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
			GC.KeepAlive (composeContext);
		}
		[Export ("encodeMessage:composeContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EncodeMessage (MEMessage message, MEComposeContext composeContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V81))]global::System.Action<MEMessageEncodingResult> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var composeContext__handle__ = composeContext!.GetNonNullHandle (nameof (composeContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V81.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeMessage:composeContext:completionHandler:"), message__handle__, composeContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
			GC.KeepAlive (composeContext);
		}
	}
}
