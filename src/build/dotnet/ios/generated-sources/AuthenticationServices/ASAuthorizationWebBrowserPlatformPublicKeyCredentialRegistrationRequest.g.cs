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
namespace AuthenticationServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[Protocol (Name = "ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest", WrapperType = typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ClientData", Selector = "clientData", PropertyType = typeof (AuthenticationServices.ASPublicKeyCredentialClientData), GetterSelector = "clientData", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExcludedCredentials", Selector = "excludedCredentials", PropertyType = typeof (AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialDescriptor[]), GetterSelector = "excludedCredentials", SetterSelector = "setExcludedCredentials:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ClientData")]
		[DynamicDependencyAttribute ("ExcludedCredentials")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest ()
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
		internal static ASPublicKeyCredentialClientData _GetClientData (IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest This)
		{
			ASPublicKeyCredentialClientData ret;
			ret =  Runtime.GetNSObject<ASPublicKeyCredentialClientData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("clientData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual ASAuthorizationPlatformPublicKeyCredentialDescriptor[]? ExcludedCredentials {
			[Export ("excludedCredentials", ArgumentSemantic.Copy)]
			get {
				return _GetExcludedCredentials (this);
			}
			[Export ("setExcludedCredentials:", ArgumentSemantic.Copy)]
			set {
				_SetExcludedCredentials (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationPlatformPublicKeyCredentialDescriptor[] _GetExcludedCredentials (IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest This)
		{
			ASAuthorizationPlatformPublicKeyCredentialDescriptor[] ret;
			ret = CFArray.ArrayFromHandle<ASAuthorizationPlatformPublicKeyCredentialDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("excludedCredentials")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetExcludedCredentials (IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest This, ASAuthorizationPlatformPublicKeyCredentialDescriptor[]? value)
		{
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setExcludedCredentials:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper : BaseWrapper, IASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequest {
		public ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper))]
		static ASAuthorizationWebBrowserPlatformPublicKeyCredentialRegistrationRequestWrapper ()
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
		public ASAuthorizationPlatformPublicKeyCredentialDescriptor[]? ExcludedCredentials {
			[Export ("excludedCredentials", ArgumentSemantic.Copy)]
			get {
				ASAuthorizationPlatformPublicKeyCredentialDescriptor[] ret;
				ret = CFArray.ArrayFromHandle<ASAuthorizationPlatformPublicKeyCredentialDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("excludedCredentials")), false)!;
				return ret;
			}
			[Export ("setExcludedCredentials:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setExcludedCredentials:"), nsa_value.GetHandle ());
			}
		}
	}
}
