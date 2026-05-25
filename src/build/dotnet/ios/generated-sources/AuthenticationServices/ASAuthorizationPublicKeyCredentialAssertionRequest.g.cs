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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationPublicKeyCredentialAssertionRequest</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "ASAuthorizationPublicKeyCredentialAssertionRequest", WrapperType = typeof (ASAuthorizationPublicKeyCredentialAssertionRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Challenge", Selector = "challenge", PropertyType = typeof (NSData), GetterSelector = "challenge", SetterSelector = "setChallenge:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RelyingPartyIdentifier", Selector = "relyingPartyIdentifier", PropertyType = typeof (string), GetterSelector = "relyingPartyIdentifier", SetterSelector = "setRelyingPartyIdentifier:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowedCredentials", Selector = "allowedCredentials", PropertyType = typeof (AuthenticationServices.IASAuthorizationPublicKeyCredentialDescriptor[]), GetterSelector = "allowedCredentials", SetterSelector = "setAllowedCredentials:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserVerificationPreference", Selector = "userVerificationPreference", PropertyType = typeof (NSString), GetterSelector = "userVerificationPreference", SetterSelector = "setUserVerificationPreference:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IASAuthorizationPublicKeyCredentialAssertionRequest : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[DynamicDependencyAttribute ("AllowedCredentials")]
		[DynamicDependencyAttribute ("Challenge")]
		[DynamicDependencyAttribute ("RelyingPartyIdentifier")]
		[DynamicDependencyAttribute ("UserVerificationPreference")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationPublicKeyCredentialAssertionRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationPublicKeyCredentialAssertionRequest ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData Challenge {
			[Export ("challenge", ArgumentSemantic.Copy)]
			get {
				return _GetChallenge (this);
			}
			[Export ("setChallenge:", ArgumentSemantic.Copy)]
			set {
				_SetChallenge (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetChallenge (IASAuthorizationPublicKeyCredentialAssertionRequest This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("challenge")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetChallenge (IASAuthorizationPublicKeyCredentialAssertionRequest This, NSData value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setChallenge:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string RelyingPartyIdentifier {
			[Export ("relyingPartyIdentifier")]
			get {
				return _GetRelyingPartyIdentifier (this);
			}
			[Export ("setRelyingPartyIdentifier:")]
			set {
				_SetRelyingPartyIdentifier (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetRelyingPartyIdentifier (IASAuthorizationPublicKeyCredentialAssertionRequest This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("relyingPartyIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRelyingPartyIdentifier (IASAuthorizationPublicKeyCredentialAssertionRequest This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRelyingPartyIdentifier:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IASAuthorizationPublicKeyCredentialDescriptor[] AllowedCredentials {
			[Export ("allowedCredentials", ArgumentSemantic.Copy)]
			get {
				return _GetAllowedCredentials (this);
			}
			[Export ("setAllowedCredentials:", ArgumentSemantic.Copy)]
			set {
				_SetAllowedCredentials (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IASAuthorizationPublicKeyCredentialDescriptor[] _GetAllowedCredentials (IASAuthorizationPublicKeyCredentialAssertionRequest This)
		{
			IASAuthorizationPublicKeyCredentialDescriptor[] ret;
			ret = CFArray.ArrayFromHandle<IASAuthorizationPublicKeyCredentialDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("allowedCredentials")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAllowedCredentials (IASAuthorizationPublicKeyCredentialAssertionRequest This, IASAuthorizationPublicKeyCredentialDescriptor[] value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAllowedCredentials:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSString UserVerificationPreference {
			[Export ("userVerificationPreference")]
			get {
				return _GetUserVerificationPreference (this);
			}
			[Export ("setUserVerificationPreference:")]
			set {
				_SetUserVerificationPreference (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetUserVerificationPreference (IASAuthorizationPublicKeyCredentialAssertionRequest This)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userVerificationPreference")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUserVerificationPreference (IASAuthorizationPublicKeyCredentialAssertionRequest This, NSString value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUserVerificationPreference:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationPublicKeyCredentialAssertionRequestWrapper : BaseWrapper, IASAuthorizationPublicKeyCredentialAssertionRequest {
		public ASAuthorizationPublicKeyCredentialAssertionRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationPublicKeyCredentialAssertionRequestWrapper))]
		static ASAuthorizationPublicKeyCredentialAssertionRequestWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			GC.KeepAlive (encoder);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Challenge {
			[Export ("challenge", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("challenge")), false)!;
				return ret;
			}
			[Export ("setChallenge:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setChallenge:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string RelyingPartyIdentifier {
			[Export ("relyingPartyIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("relyingPartyIdentifier")), false)!;
				return ret;
			}
			[Export ("setRelyingPartyIdentifier:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRelyingPartyIdentifier:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IASAuthorizationPublicKeyCredentialDescriptor[] AllowedCredentials {
			[Export ("allowedCredentials", ArgumentSemantic.Copy)]
			get {
				IASAuthorizationPublicKeyCredentialDescriptor[] ret;
				ret = CFArray.ArrayFromHandle<IASAuthorizationPublicKeyCredentialDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allowedCredentials")), false)!;
				return ret;
			}
			[Export ("setAllowedCredentials:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAllowedCredentials:"), nsa_value.Handle);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString UserVerificationPreference {
			[Export ("userVerificationPreference")]
			get {
				NSString ret;
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userVerificationPreference")), false)!;
				return ret;
			}
			[Export ("setUserVerificationPreference:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserVerificationPreference:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
