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
namespace Security {
	/// <summary>Result code for SecTrust.Evaluate</summary><remarks>In general both Proceed and Unspecified means you can trust the certificate, other values means it should not be trusted.</remarks>
	[NativeName ("SecTrustResultType")]
	public enum SecTrustResult : int {
		/// <summary>The supplied data cannot be used to determine if the certificate can be trusted.</summary>
		Invalid = 0,
		/// <summary>The certificate is trusted and the system is telling you to proceed with its intended usage.</summary>
		Proceed = 1,
		/// <summary>Developers should not use this deprecated field. </summary>
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("macos10.9")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Confirm = 2,
		/// <summary>Trust for this certificate is being denied.</summary>
		Deny = 3,
		/// <summary>The certificate is trusted and the default system action should be executed. In general it means it's trusted and you can go on.</summary>
		Unspecified = 4,
		/// <summary>Not enough information is available to trust this certificate. If extra information is supplied then it could be trusted (or not).</summary>
		RecoverableTrustFailure = 5,
		/// <summary>The certificate could not be traced back to a trusted root.</summary>
		FatalTrustFailure = 6,
		/// <summary>An error occurred while trying to determine the certificate trust.</summary>
		ResultOtherError = 7,
	}
}
