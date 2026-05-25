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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>WKScriptMessageHandlerWithReply</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKScriptMessageHandlerWithReply", WrapperType = typeof (WKScriptMessageHandlerWithReplyWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveScriptMessage", Selector = "userContentController:didReceiveScriptMessage:replyHandler:", ParameterType = new Type [] { typeof (WebKit.WKUserContentController), typeof (WebKit.WKScriptMessage), typeof (global::System.Action<NSObject, NSString>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V184) })]
	public partial interface IWKScriptMessageHandlerWithReply : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("userContentController:didReceiveScriptMessage:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveScriptMessage (WKUserContentController userContentController, WKScriptMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V184))]global::System.Action<NSObject, NSString> replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveScriptMessage (IWKScriptMessageHandlerWithReply This, WKUserContentController userContentController, WKScriptMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V184))]global::System.Action<NSObject, NSString> replyHandler)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDActionArity2V184.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:replyHandler:"), userContentController__handle__, message__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (userContentController);
			GC.KeepAlive (message);
		}
		[DynamicDependencyAttribute ("DidReceiveScriptMessage(WebKit.WKUserContentController,WebKit.WKScriptMessage,System.Action{Foundation.NSObject,Foundation.NSString})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKScriptMessageHandlerWithReplyWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKScriptMessageHandlerWithReply ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKScriptMessageHandlerWithReplyWrapper : BaseWrapper, IWKScriptMessageHandlerWithReply {
		public WKScriptMessageHandlerWithReplyWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKScriptMessageHandlerWithReplyWrapper))]
		static WKScriptMessageHandlerWithReplyWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("userContentController:didReceiveScriptMessage:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidReceiveScriptMessage (WKUserContentController userContentController, WKScriptMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V184))]global::System.Action<NSObject, NSString> replyHandler)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDActionArity2V184.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:replyHandler:"), userContentController__handle__, message__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (userContentController);
			GC.KeepAlive (message);
		}
	}
}
