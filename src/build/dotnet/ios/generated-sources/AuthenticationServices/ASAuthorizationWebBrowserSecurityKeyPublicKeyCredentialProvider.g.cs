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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	[SupportedOSPlatform ("macos14.4")]
	[Protocol (Name = "ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider", WrapperType = typeof (ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCredentialRegistrationRequest", Selector = "createCredentialRegistrationRequestWithClientData:displayName:name:userID:", ReturnType = typeof (AuthenticationServices.ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest), ParameterType = new Type [] { typeof (AuthenticationServices.ASPublicKeyCredentialClientData), typeof (string), typeof (string), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCredentialAssertionRequest", Selector = "createCredentialAssertionRequestWithClientData:", ReturnType = typeof (AuthenticationServices.ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest), ParameterType = new Type [] { typeof (AuthenticationServices.ASPublicKeyCredentialClientData) }, ParameterByRef = new bool [] { false })]
	public partial interface IASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("createCredentialRegistrationRequestWithClientData:displayName:name:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string displayName, string name, NSData userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest _CreateCredentialRegistrationRequest (IASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider This, ASPublicKeyCredentialClientData clientData, string displayName, string name, NSData userId)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (displayName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (displayName));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsdisplayName = CFString.CreateNative (displayName);
			var nsname = CFString.CreateNative (name);
			ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:displayName:name:userID:"), clientData__handle__, nsdisplayName, nsname, userId__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsdisplayName);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("createCredentialAssertionRequestWithClientData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest CreateCredentialAssertionRequest (ASPublicKeyCredentialClientData clientData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest _CreateCredentialAssertionRequest (IASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider This, ASPublicKeyCredentialClientData clientData)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("createCredentialAssertionRequestWithClientData:"), clientData__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (clientData);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateCredentialAssertionRequest(AuthenticationServices.ASPublicKeyCredentialClientData)")]
		[DynamicDependencyAttribute ("CreateCredentialRegistrationRequest(AuthenticationServices.ASPublicKeyCredentialClientData,System.String,System.String,Foundation.NSData)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper : BaseWrapper, IASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProvider {
		public ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper))]
		static ASAuthorizationWebBrowserSecurityKeyPublicKeyCredentialProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("createCredentialRegistrationRequestWithClientData:displayName:name:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest CreateCredentialRegistrationRequest (ASPublicKeyCredentialClientData clientData, string displayName, string name, NSData userId)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			if (displayName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (displayName));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var userId__handle__ = userId!.GetNonNullHandle (nameof (userId));
			var nsdisplayName = CFString.CreateNative (displayName);
			var nsname = CFString.CreateNative (name);
			ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationSecurityKeyPublicKeyCredentialRegistrationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createCredentialRegistrationRequestWithClientData:displayName:name:userID:"), clientData__handle__, nsdisplayName, nsname, userId__handle__), false)!;
			GC.KeepAlive (clientData);
			GC.KeepAlive (userId);
			CFString.ReleaseNative (nsdisplayName);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("createCredentialAssertionRequestWithClientData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest CreateCredentialAssertionRequest (ASPublicKeyCredentialClientData clientData)
		{
			var clientData__handle__ = clientData!.GetNonNullHandle (nameof (clientData));
			ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest? ret;
			ret =  Runtime.GetNSObject<ASAuthorizationSecurityKeyPublicKeyCredentialAssertionRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("createCredentialAssertionRequestWithClientData:"), clientData__handle__), false)!;
			GC.KeepAlive (clientData);
			return ret!;
		}
	}
}
