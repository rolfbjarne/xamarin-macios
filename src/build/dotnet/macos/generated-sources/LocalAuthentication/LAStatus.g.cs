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
namespace LocalAuthentication {
	/// <summary>Status and error codes returned by methods in LocalAuthentication.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native ("LAError")]
	public enum LAStatus : long {
		/// <summary>Authentication succeeded.</summary>
		Success = 0,
		/// <summary>Authentication was not successful, because user failed to provide valid credentials.</summary>
		AuthenticationFailed = -1,
		/// <summary>Authentication was canceled by user (e.g. tapped Cancel button).</summary>
		UserCancel = -2,
		/// <summary>Authentication was canceled, because the user tapped the fallback button (Enter Password).</summary>
		UserFallback = -3,
		/// <summary>Authentication was canceled by system (e.g. another application went to foreground).</summary>
		SystemCancel = -4,
		/// <summary>Authentication could not start, because passcode is not set on the device.</summary>
		PasscodeNotSet = -5,
		/// <summary>To be added.</summary>
		AppCancel = -9,
		/// <summary>To be added.</summary>
		InvalidContext = -10,
		[ObsoletedOSPlatform ("macos15.0", "Use 'CompanionNotAvailable' instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		WatchNotAvailable = -11,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		BiometryNotPaired = -12,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		BiometryDisconnected = -13,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		InvalidDimension = -14,
		/// <summary>Indicates that biometric authentication is not supported on the device.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		BiometryNotAvailable = -6,
		/// <summary>Indicates that the user has not enrolled for biometric authentication.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		BiometryNotEnrolled = -7,
		/// <summary>Indicates that biometric authentication has failed too many times, and the user is now locked out.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		BiometryLockout = -8,
		/// <summary>To be added.</summary>
		NotInteractive = -1004,
		CompanionNotAvailable = -11,
	}
	/// <summary>Extension methods for the <see cref="global::LocalAuthentication.LAStatus" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::LocalAuthentication.LAStatus" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class LAStatusExtensions {
		[Field ("LAErrorDomain", "LocalAuthentication")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the LocalAuthentication.LAStatus value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this LAStatus self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.LocalAuthentication.Handle, "LAErrorDomain");
			return _domain;
		}
	}
}
