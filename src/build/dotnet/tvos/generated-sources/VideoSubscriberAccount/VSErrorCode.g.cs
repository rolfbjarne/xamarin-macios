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
namespace VideoSubscriberAccount {
	/// <summary>Encapsulates errors that may occur during attempts to verify credentials.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum VSErrorCode : long {
		/// <summary>The user has not affirmatively provided access.</summary>
		AccessNotGranted = 0,
		/// <summary>The requested provider is not supported.</summary>
		UnsupportedProvider = 1,
		/// <summary>The application cancelled the request.</summary>
		UserCancelled = 2,
		/// <summary>A transient error has occurred.</summary>
		ServiceTemporarilyUnavailable = 3,
		/// <summary>To be added.</summary>
		ProviderRejected = 4,
		/// <summary>The provider does not recognize the verification token provided by the app.</summary>
		InvalidVerificationToken = 5,
		Rejected = 6,
		Unsupported = 7,
	}
	/// <summary>Extension methods for the <see cref="global::VideoSubscriberAccount.VSErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::VideoSubscriberAccount.VSErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VSErrorCodeExtensions {
		[Field ("VSErrorDomain", "VideoSubscriberAccount")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the VideoSubscriberAccount.VSErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this VSErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSErrorDomain");
			return _domain;
		}
	}
}
