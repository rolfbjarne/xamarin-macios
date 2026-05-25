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
	/// <summary>This interface represents the Objective-C protocol <c>MEExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEExtension", WrapperType = typeof (MEExtensionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHandlerForComposeSession", Selector = "handlerForComposeSession:", ReturnType = typeof (MailKit.IMEComposeSessionHandler), ParameterType = new Type [] { typeof (MailKit.MEComposeSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HandlerForMessageActions", Selector = "handlerForMessageActions", PropertyType = typeof (MailKit.IMEMessageActionHandler), GetterSelector = "handlerForMessageActions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HandlerForContentBlocker", Selector = "handlerForContentBlocker", PropertyType = typeof (MailKit.IMEContentBlocker), GetterSelector = "handlerForContentBlocker", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HandlerForMessageSecurity", Selector = "handlerForMessageSecurity", PropertyType = typeof (MailKit.IMEMessageSecurityHandler), GetterSelector = "handlerForMessageSecurity", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMEExtension : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("handlerForComposeSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMEComposeSessionHandler GetHandlerForComposeSession (MEComposeSession session)
		{
			return _GetHandlerForComposeSession (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMEComposeSessionHandler _GetHandlerForComposeSession (IMEExtension This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			IMEComposeSessionHandler? ret;
			ret =  Runtime.GetINativeObject<IMEComposeSessionHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handlerForComposeSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetHandlerForComposeSession(MailKit.MEComposeSession)")]
		[DynamicDependencyAttribute ("HandlerForContentBlocker")]
		[DynamicDependencyAttribute ("HandlerForMessageActions")]
		[DynamicDependencyAttribute ("HandlerForMessageSecurity")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEExtension ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual IMEMessageActionHandler HandlerForMessageActions {
			[Export ("handlerForMessageActions")]
			get {
				return _GetHandlerForMessageActions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMEMessageActionHandler _GetHandlerForMessageActions (IMEExtension This)
		{
			IMEMessageActionHandler ret;
			ret =  Runtime.GetINativeObject<IMEMessageActionHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForMessageActions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual IMEContentBlocker HandlerForContentBlocker {
			[Export ("handlerForContentBlocker")]
			get {
				return _GetHandlerForContentBlocker (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMEContentBlocker _GetHandlerForContentBlocker (IMEExtension This)
		{
			IMEContentBlocker ret;
			ret =  Runtime.GetINativeObject<IMEContentBlocker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForContentBlocker")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual IMEMessageSecurityHandler HandlerForMessageSecurity {
			[Export ("handlerForMessageSecurity")]
			get {
				return _GetHandlerForMessageSecurity (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMEMessageSecurityHandler _GetHandlerForMessageSecurity (IMEExtension This)
		{
			IMEMessageSecurityHandler ret;
			ret =  Runtime.GetINativeObject<IMEMessageSecurityHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForMessageSecurity")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMEExtension" /> interface to support all the methods from the MEExtension protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMEExtension" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MEExtension protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MEExtension_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMEComposeSessionHandler GetHandlerForComposeSession (this IMEExtension This, MEComposeSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			IMEComposeSessionHandler? ret;
			ret =  Runtime.GetINativeObject<IMEComposeSessionHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handlerForComposeSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMEMessageActionHandler GetHandlerForMessageActions (this IMEExtension This)
		{
			IMEMessageActionHandler ret;
			ret =  Runtime.GetINativeObject<IMEMessageActionHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForMessageActions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMEContentBlocker GetHandlerForContentBlocker (this IMEExtension This)
		{
			IMEContentBlocker ret;
			ret =  Runtime.GetINativeObject<IMEContentBlocker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForContentBlocker")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMEMessageSecurityHandler GetHandlerForMessageSecurity (this IMEExtension This)
		{
			IMEMessageSecurityHandler ret;
			ret =  Runtime.GetINativeObject<IMEMessageSecurityHandler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handlerForMessageSecurity")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEExtensionWrapper : BaseWrapper, IMEExtension {
		public MEExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEExtensionWrapper))]
		static MEExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
