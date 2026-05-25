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
	/// <summary>Enumerates errors associated with a <see cref="T:AuthenticationServices.ASWebAuthenticationSession" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum ASWebAuthenticationSessionErrorCode : long {
		/// <summary>The login was cancelled.</summary>
		CanceledLogin = 1,
		PresentationContextNotProvided = 2,
		PresentationContextInvalid = 3,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASWebAuthenticationSessionErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::AuthenticationServices.ASWebAuthenticationSessionErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASWebAuthenticationSessionErrorCodeExtensions {
		[Field ("ASWebAuthenticationSessionErrorDomain", "AuthenticationServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the AuthenticationServices.ASWebAuthenticationSessionErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this ASWebAuthenticationSessionErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASWebAuthenticationSessionErrorDomain");
			return _domain;
		}
	}
}
