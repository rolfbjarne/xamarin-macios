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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[Protocol (Name = "ASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider", WrapperType = typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCredentialRegistrationRequest", Selector = "createCredentialRegistrationRequestWithClientData:name:userID:", ReturnType = typeof (AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest), ParameterType = new Type [] { typeof (AuthenticationServices.ASPublicKeyCredentialClientData), typeof (string), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCredentialAssertionRequest", Selector = "createCredentialAssertionRequestWithClientData:", ReturnType = typeof (AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialAssertionRequest), ParameterType = new Type [] { typeof (AuthenticationServices.ASPublicKeyCredentialClientData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCredentialRegistrationRequest", Selector = "createCredentialRegistrationRequestWithClientData:name:userID:requestStyle:", ReturnType = typeof (AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest), ParameterType = new Type [] { typeof (AuthenticationServices.ASPublicKeyCredentialClientData), typeof (string), typeof (NSData), typeof (AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialRegistrationRequestStyle) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("createCredentialRegistrationRequestWithClientData:name:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string name, NSData userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest _CreateCredentialRegistrationRequest (IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider This, ASPublicKeyCredentialClientData clientData, string name, NSData userId)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsname = CFString.CreateNative (name);
			ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:name:userID:"), clientData__handle__, nsname, userId__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("createCredentialAssertionRequestWithClientData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationPlatformPublicKeyCredentialAssertionRequest CreateCredentialAssertionRequest (ASPublicKeyCredentialClientData clientData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationPlatformPublicKeyCredentialAssertionRequest _CreateCredentialAssertionRequest (IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider This, ASPublicKeyCredentialClientData clientData)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			ASAuthorizationPlatformPublicKeyCredentialAssertionRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialAssertionRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("createCredentialAssertionRequestWithClientData:"), clientData__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (clientData);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("createCredentialRegistrationRequestWithClientData:name:userID:requestStyle:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string name, NSData userId, ASAuthorizationPlatformPublicKeyCredentialRegistrationRequestStyle requestStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest _CreateCredentialRegistrationRequest (IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider This, ASPublicKeyCredentialClientData clientData, string name, NSData userId, ASAuthorizationPlatformPublicKeyCredentialRegistrationRequestStyle requestStyle)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsname = CFString.CreateNative (name);
			ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:name:userID:requestStyle:"), clientData__handle__, nsname, userId__handle__, (IntPtr) (long) requestStyle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateCredentialAssertionRequest(AuthenticationServices.ASPublicKeyCredentialClientData)")]
		[DynamicDependencyAttribute ("CreateCredentialRegistrationRequest(AuthenticationServices.ASPublicKeyCredentialClientData,System.String,Foundation.NSData,AuthenticationServices.ASAuthorizationPlatformPublicKeyCredentialRegistrationRequestStyle)")]
		[DynamicDependencyAttribute ("CreateCredentialRegistrationRequest(AuthenticationServices.ASPublicKeyCredentialClientData,System.String,Foundation.NSData)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper : BaseWrapper, IASAuthorizationWebBrowserPlatformPublicKeyCredentialProvider {
		public ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper))]
		static ASAuthorizationWebBrowserPlatformPublicKeyCredentialProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("createCredentialRegistrationRequestWithClientData:name:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string name, NSData userId)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsname = CFString.CreateNative (name);
			ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:name:userID:"), clientData__handle__, nsname, userId__handle__), false)!;
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("createCredentialAssertionRequestWithClientData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationPlatformPublicKeyCredentialAssertionRequest CreateCredentialAssertionRequest (ASPublicKeyCredentialClientData clientData)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			ASAuthorizationPlatformPublicKeyCredentialAssertionRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialAssertionRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("createCredentialAssertionRequestWithClientData:"), clientData__handle__), false)!;
			GC.KeepAlive (clientData);
			return ret!;
		}
		[Export ("createCredentialRegistrationRequestWithClientData:name:userID:requestStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string name, NSData userId, ASAuthorizationPlatformPublicKeyCredentialRegistrationRequestStyle requestStyle)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsname = CFString.CreateNative (name);
			ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationPlatformPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:name:userID:requestStyle:"), clientData__handle__, nsname, userId__handle__, (IntPtr) (long) requestStyle), false)!;
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	}
}
