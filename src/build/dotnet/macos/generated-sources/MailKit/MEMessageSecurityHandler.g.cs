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
	/// <summary>This interface represents the Objective-C protocol <c>MEMessageSecurityHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEMessageSecurityHandler", WrapperType = typeof (MEMessageSecurityHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetExtensionViewController", Selector = "extensionViewControllerForMessageSigners:", ReturnType = typeof (MailKit.MEExtensionViewController), ParameterType = new Type [] { typeof (MailKit.MEMessageSigner[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetExtensionViewController", Selector = "extensionViewControllerForMessageContext:", ReturnType = typeof (MailKit.MEExtensionViewController), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPrimaryActionClicked", Selector = "primaryActionClickedForMessageContext:completionHandler:", ParameterType = new Type [] { typeof (NSData), typeof (global::System.Action<global::MailKit.MEExtensionViewController>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V82) })]
	public partial interface IMEMessageSecurityHandler : INativeObject, IDisposable, 
		MailKit.IMEMessageDecoder
		, MailKit.IMEMessageEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("extensionViewControllerForMessageSigners:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MEExtensionViewController? GetExtensionViewController (MEMessageSigner[] messageSigners)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MEExtensionViewController? _GetExtensionViewController (IMEMessageSecurityHandler This, MEMessageSigner[] messageSigners)
		{
			if (messageSigners is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageSigners));
			using var nsa_messageSigners = NSArray.FromNSObjects (messageSigners);
			MEExtensionViewController ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("extensionViewControllerForMessageSigners:"), nsa_messageSigners.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("extensionViewControllerForMessageContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MEExtensionViewController? GetExtensionViewController (NSData messageContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MEExtensionViewController? _GetExtensionViewController (IMEMessageSecurityHandler This, NSData messageContext)
		{
			var messageContext__handle__ = messageContext!.GetNonNullHandle (nameof (messageContext));
			MEExtensionViewController? ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("extensionViewControllerForMessageContext:"), messageContext__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (messageContext);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("primaryActionClickedForMessageContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetPrimaryActionClicked (NSData messageContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V82))]global::System.Action<MEExtensionViewController> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetPrimaryActionClicked (IMEMessageSecurityHandler This, NSData messageContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V82))]global::System.Action<MEExtensionViewController> completionHandler)
		{
			var messageContext__handle__ = messageContext!.GetNonNullHandle (nameof (messageContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V82.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("primaryActionClickedForMessageContext:completionHandler:"), messageContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (messageContext);
		}
		[DynamicDependencyAttribute ("GetExtensionViewController(Foundation.NSData)")]
		[DynamicDependencyAttribute ("GetExtensionViewController(MailKit.MEMessageSigner[])")]
		[DynamicDependencyAttribute ("SetPrimaryActionClicked(Foundation.NSData,System.Action{MailKit.MEExtensionViewController})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageSecurityHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEMessageSecurityHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEMessageSecurityHandlerWrapper : BaseWrapper, IMEMessageSecurityHandler {
		public MEMessageSecurityHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageSecurityHandlerWrapper))]
		static MEMessageSecurityHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("extensionViewControllerForMessageSigners:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MEExtensionViewController? GetExtensionViewController (MEMessageSigner[] messageSigners)
		{
			if (messageSigners is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageSigners));
			using var nsa_messageSigners = NSArray.FromNSObjects (messageSigners);
			MEExtensionViewController ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("extensionViewControllerForMessageSigners:"), nsa_messageSigners.Handle), false)!;
			return ret;
		}
		[Export ("extensionViewControllerForMessageContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MEExtensionViewController? GetExtensionViewController (NSData messageContext)
		{
			var messageContext__handle__ = messageContext!.GetNonNullHandle (nameof (messageContext));
			MEExtensionViewController? ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("extensionViewControllerForMessageContext:"), messageContext__handle__), false)!;
			GC.KeepAlive (messageContext);
			return ret!;
		}
		[Export ("primaryActionClickedForMessageContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SetPrimaryActionClicked (NSData messageContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V82))]global::System.Action<MEExtensionViewController> completionHandler)
		{
			var messageContext__handle__ = messageContext!.GetNonNullHandle (nameof (messageContext));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V82.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("primaryActionClickedForMessageContext:completionHandler:"), messageContext__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (messageContext);
		}
		[Export ("decodedMessageForMessageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MEDecodedMessage? DecodedMessage (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MEDecodedMessage? ret;
			ret =  Runtime.GetNSObject<MEDecodedMessage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decodedMessageForMessageData:"), data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
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
