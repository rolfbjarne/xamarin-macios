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
	/// <summary>Error codes associated with Authentication Services extensions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum ASExtensionErrorCode : long {
		/// <summary>A general failure.</summary>
		Failed = 0,
		/// <summary>The user initiated the cancellation of the authentication request.</summary>
		UserCanceled = 1,
		/// <summary>Additional user interaction is required.</summary>
		UserInteractionRequired = 100,
		/// <summary>The identity could not be found.</summary>
		CredentialIdentityNotFound = 101,
		MatchedExcludedCredential = 102,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASExtensionErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::AuthenticationServices.ASExtensionErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASExtensionErrorCodeExtensions {
		[Field ("ASExtensionErrorDomain", "AuthenticationServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the AuthenticationServices.ASExtensionErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this ASExtensionErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASExtensionErrorDomain");
			return _domain;
		}
	}
}
