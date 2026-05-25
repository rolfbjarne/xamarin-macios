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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NetworkExtension {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[Native]
	public enum NEVpnConnectionError : long {
		Overslept = 1,
		NoNetworkAvailable = 2,
		UnrecoverableNetworkChange = 3,
		ConfigurationFailed = 4,
		ServerAddressResolutionFailed = 5,
		ServerNotResponding = 6,
		ServerDead = 7,
		AuthenticationFailed = 8,
		ClientCertificateInvalid = 9,
		ClientCertificateNotYetValid = 10,
		ClientCertificateExpired = 11,
		PluginFailed = 12,
		ConfigurationNotFound = 13,
		PluginDisabled = 14,
		NegotiationFailed = 15,
		ServerDisconnected = 16,
		ServerCertificateInvalid = 17,
		ServerCertificateNotYetValid = 18,
		ServerCertificateExpired = 19,
	}
	/// <summary>Extension methods for the <see cref="global::NetworkExtension.NEVpnConnectionError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::NetworkExtension.NEVpnConnectionError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NEVpnConnectionErrorExtensions {
		[Field ("NEVPNConnectionErrorDomain", "NetworkExtension")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the NetworkExtension.NEVpnConnectionError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NEVpnConnectionError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NEVPNConnectionErrorDomain");
			return _domain;
		}
	}
}
