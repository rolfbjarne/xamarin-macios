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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	[SupportedOSPlatform ("macos14.4")]
	[Protocol (Name = "ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest", WrapperType = typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ClientData", Selector = "clientData", PropertyType = typeof (AuthenticationServices.ASPublicKeyCredentialClientData), GetterSelector = "clientData", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldShowHybridTransport", Selector = "shouldShowHybridTransport", PropertyType = typeof (bool), GetterSelector = "shouldShowHybridTransport", SetterSelector = "setShouldShowHybridTransport:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ClientData")]
		[DynamicDependencyAttribute ("ShouldShowHybridTransport")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual ASPublicKeyCredentialClientData ClientData {
			[Export ("clientData")]
			get {
				return _GetClientData (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASPublicKeyCredentialClientData _GetClientData (IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest This)
		{
			ASPublicKeyCredentialClientData ret;
			ret =  Runtime.GetNSObject<ASPublicKeyCredentialClientData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("clientData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ShouldShowHybridTransport {
			[Export ("shouldShowHybridTransport")]
			get {
				return _GetShouldShowHybridTransport (this);
			}
			[Export ("setShouldShowHybridTransport:")]
			set {
				_SetShouldShowHybridTransport (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShouldShowHybridTransport (IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldShowHybridTransport"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetShouldShowHybridTransport (IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldShowHybridTransport:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper : BaseWrapper, IASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequest {
		public ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper))]
		static ASAuthorizationWebBrowserPlatformPublicKeyCredentialAssertionRequestWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASPublicKeyCredentialClientData ClientData {
			[Export ("clientData")]
			get {
				ASPublicKeyCredentialClientData ret;
				ret =  Runtime.GetNSObject<ASPublicKeyCredentialClientData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("clientData")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldShowHybridTransport {
			[Export ("shouldShowHybridTransport")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowHybridTransport"));
				return ret != 0;
			}
			[Export ("setShouldShowHybridTransport:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldShowHybridTransport:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
