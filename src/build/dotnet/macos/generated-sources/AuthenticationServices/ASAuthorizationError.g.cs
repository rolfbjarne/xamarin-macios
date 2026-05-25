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
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum ASAuthorizationError : long {
		Unknown = 1000,
		Canceled = 1001,
		InvalidResponse = 1002,
		NotHandled = 1003,
		Failed = 1004,
		NotInteractive = 1005,
		MatchedExcludedCredential = 1006,
		CredentialImport = 1007,
		CredentialExport = 1008,
		PreferSignInWithApple = 1009,
		DeviceNotConfiguredForPasskeyCreation = 1010,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::AuthenticationServices.ASAuthorizationError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationErrorExtensions {
		[Field ("ASAuthorizationErrorDomain", "AuthenticationServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the AuthenticationServices.ASAuthorizationError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this ASAuthorizationError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationErrorDomain");
			return _domain;
		}
	}
}
