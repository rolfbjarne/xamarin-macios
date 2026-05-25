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
namespace AuthenticationServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationWebBrowserExternallyAuthenticatableRequest</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.3")]
	[Protocol (Name = "ASAuthorizationWebBrowserExternallyAuthenticatableRequest", WrapperType = typeof (ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AuthenticatedContext", Selector = "authenticatedContext", PropertyType = typeof (LocalAuthentication.LAContext), GetterSelector = "authenticatedContext", SetterSelector = "setAuthenticatedContext:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IASAuthorizationWebBrowserExternallyAuthenticatableRequest : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AuthenticatedContext")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationWebBrowserExternallyAuthenticatableRequest ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::LocalAuthentication.LAContext? AuthenticatedContext {
			[Export ("authenticatedContext", ArgumentSemantic.Assign)]
			get {
				return _GetAuthenticatedContext (this);
			}
			[Export ("setAuthenticatedContext:", ArgumentSemantic.Assign)]
			set {
				_SetAuthenticatedContext (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::LocalAuthentication.LAContext _GetAuthenticatedContext (IASAuthorizationWebBrowserExternallyAuthenticatableRequest This)
		{
			global::LocalAuthentication.LAContext ret;
			ret =  Runtime.GetNSObject<global::LocalAuthentication.LAContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("authenticatedContext")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAuthenticatedContext (IASAuthorizationWebBrowserExternallyAuthenticatableRequest This, global::LocalAuthentication.LAContext? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAuthenticatedContext:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper : BaseWrapper, IASAuthorizationWebBrowserExternallyAuthenticatableRequest {
		public ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper))]
		static ASAuthorizationWebBrowserExternallyAuthenticatableRequestWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::LocalAuthentication.LAContext? AuthenticatedContext {
			[Export ("authenticatedContext", ArgumentSemantic.Assign)]
			get {
				global::LocalAuthentication.LAContext ret;
				ret =  Runtime.GetNSObject<global::LocalAuthentication.LAContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("authenticatedContext")), false)!;
				return ret;
			}
			[Export ("setAuthenticatedContext:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAuthenticatedContext:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
