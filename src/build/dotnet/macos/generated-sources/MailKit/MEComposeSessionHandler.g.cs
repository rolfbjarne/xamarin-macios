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
	/// <summary>This interface represents the Objective-C protocol <c>MEComposeSessionHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEComposeSessionHandler", WrapperType = typeof (MEComposeSessionHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MailComposeSessionDidBegin", Selector = "mailComposeSessionDidBegin:", ParameterType = new Type [] { typeof (MailKit.MEComposeSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MailComposeSessionDidEnd", Selector = "mailComposeSessionDidEnd:", ParameterType = new Type [] { typeof (MailKit.MEComposeSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "viewControllerForSession:", ReturnType = typeof (MailKit.MEExtensionViewController), ParameterType = new Type [] { typeof (MailKit.MEComposeSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnnotateAddress", Selector = "session:annotateAddressesWithCompletionHandler:", ParameterType = new Type [] { typeof (MailKit.MEComposeSession), typeof (global::System.Action<NSDictionary<global::MailKit.MEEmailAddress, global::MailKit.MEAddressAnnotation>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V78) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AllowMessageSend", Selector = "session:canSendMessageWithCompletionHandler:", ParameterType = new Type [] { typeof (MailKit.MEComposeSession), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdditionalHeaders", Selector = "additionalHeadersForSession:", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSArray<NSString>>), ParameterType = new Type [] { typeof (MailKit.MEComposeSession) }, ParameterByRef = new bool [] { false })]
	public partial interface IMEComposeSessionHandler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("mailComposeSessionDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MailComposeSessionDidBegin (MEComposeSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MailComposeSessionDidBegin (IMEComposeSessionHandler This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mailComposeSessionDidBegin:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.RequiredMember]
		[Export ("mailComposeSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MailComposeSessionDidEnd (MEComposeSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MailComposeSessionDidEnd (IMEComposeSessionHandler This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mailComposeSessionDidEnd:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.RequiredMember]
		[Export ("viewControllerForSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MEExtensionViewController GetViewController (MEComposeSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MEExtensionViewController _GetViewController (IMEComposeSessionHandler This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			MEExtensionViewController? ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("session:annotateAddressesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AnnotateAddress (MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<NSDictionary<MEEmailAddress, MEAddressAnnotation>> completionHandler)
		{
			_AnnotateAddress (this, session, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AnnotateAddress (IMEComposeSessionHandler This, MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<NSDictionary<MEEmailAddress, MEAddressAnnotation>> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V78.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:annotateAddressesWithCompletionHandler:"), session__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:canSendMessageWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AllowMessageSend (MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			_AllowMessageSend (this, session, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AllowMessageSend (IMEComposeSessionHandler This, MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:canSendMessageWithCompletionHandler:"), session__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("additionalHeadersForSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSArray<NSString>> GetAdditionalHeaders (MEComposeSession session)
		{
			return _GetAdditionalHeaders (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSArray<NSString>> _GetAdditionalHeaders (IMEComposeSessionHandler This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			NSDictionary<NSString, NSArray<NSString>>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSArray<NSString>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("additionalHeadersForSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
		[DynamicDependencyAttribute ("AllowMessageSend(MailKit.MEComposeSession,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("AnnotateAddress(MailKit.MEComposeSession,System.Action{Foundation.NSDictionary{MailKit.MEEmailAddress,MailKit.MEAddressAnnotation}})")]
		[DynamicDependencyAttribute ("GetAdditionalHeaders(MailKit.MEComposeSession)")]
		[DynamicDependencyAttribute ("GetViewController(MailKit.MEComposeSession)")]
		[DynamicDependencyAttribute ("MailComposeSessionDidBegin(MailKit.MEComposeSession)")]
		[DynamicDependencyAttribute ("MailComposeSessionDidEnd(MailKit.MEComposeSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEComposeSessionHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEComposeSessionHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMEComposeSessionHandler" /> interface to support all the methods from the MEComposeSessionHandler protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMEComposeSessionHandler" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MEComposeSessionHandler protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MEComposeSessionHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnnotateAddress (this IMEComposeSessionHandler This, MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<NSDictionary<MEEmailAddress, MEAddressAnnotation>> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V78.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:annotateAddressesWithCompletionHandler:"), session__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AllowMessageSend (this IMEComposeSessionHandler This, MEComposeSession session, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:canSendMessageWithCompletionHandler:"), session__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSArray<NSString>> GetAdditionalHeaders (this IMEComposeSessionHandler This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			NSDictionary<NSString, NSArray<NSString>>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSArray<NSString>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("additionalHeadersForSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEComposeSessionHandlerWrapper : BaseWrapper, IMEComposeSessionHandler {
		public MEComposeSessionHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEComposeSessionHandlerWrapper))]
		static MEComposeSessionHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("mailComposeSessionDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MailComposeSessionDidBegin (MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("mailComposeSessionDidBegin:"), session__handle__);
			GC.KeepAlive (session);
		}
		[Export ("mailComposeSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MailComposeSessionDidEnd (MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("mailComposeSessionDidEnd:"), session__handle__);
			GC.KeepAlive (session);
		}
		[Export ("viewControllerForSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MEExtensionViewController GetViewController (MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			MEExtensionViewController? ret;
			ret =  Runtime.GetNSObject<MEExtensionViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewControllerForSession:"), session__handle__), false)!;
			GC.KeepAlive (session);
			return ret!;
		}
	}
}
