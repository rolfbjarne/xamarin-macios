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
	/// <summary>Enumerates client errors that can occur with an <see cref="T:NetworkExtension.NERelayManager" />.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[Native]
	public enum NERelayManagerClientError : long {
		/// <summary>No error occurred.</summary>
		None = 1,
		/// <summary>DNS resolution failed.</summary>
		DNSFailed = 2,
		/// <summary>The relay server is unreachable.</summary>
		ServerUnreachable = 3,
		/// <summary>The relay server disconnected.</summary>
		ServerDisconnected = 4,
		/// <summary>The client certificate is missing.</summary>
		CertificateMissing = 5,
		/// <summary>The client certificate is invalid.</summary>
		CertificateInvalid = 6,
		/// <summary>The client certificate has expired.</summary>
		CertificateExpired = 7,
		/// <summary>The server certificate is invalid.</summary>
		ServerCertificateInvalid = 8,
		/// <summary>The server certificate has expired.</summary>
		ServerCertificateExpired = 9,
		/// <summary>An unspecified error occurred.</summary>
		Other = 10,
		/// <summary>The Provisioning Domain (PvD) configuration was truncated.</summary>
		PvDConfigurationTruncated = 11,
	}
	/// <summary>Extension methods for the <see cref="global::NetworkExtension.NERelayManagerClientError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::NetworkExtension.NERelayManagerClientError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NERelayManagerClientErrorExtensions {
		[Field ("NERelayClientErrorDomain", "NetworkExtension")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the NetworkExtension.NERelayManagerClientError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NERelayManagerClientError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NERelayClientErrorDomain");
			return _domain;
		}
	}
}
