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
namespace CoreSpotlight {
	/// <summary>Enumerates possible errors associated with using Core Spotlight and searching.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CSIndexErrorCode : long {
		/// <summary>An unknown error occurred.</summary>
		UnknownError = -1,
		/// <summary>The index was not available.</summary>
		IndexUnavailableError = -1000,
		/// <summary>The search item was invalid.</summary>
		InvalidItemError = -1001,
		/// <summary>The search client was in an invalid state.</summary>
		InvalidClientStateError = -1002,
		/// <summary>A remote connection failed.</summary>
		RemoteConnectionError = -1003,
		/// <summary>The quota was exceeded.</summary>
		QuotaExceeded = -1004,
		/// <summary>The device does not support indexing.</summary>
		IndexingUnsupported = -1005,
		MismatchedClientState = -1006,
	}
	/// <summary>Extension methods for the <see cref="global::CoreSpotlight.CSIndexErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreSpotlight.CSIndexErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CSIndexErrorCodeExtensions {
		[Field ("CSIndexErrorDomain", "CoreSpotlight")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreSpotlight.CSIndexErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CSIndexErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSIndexErrorDomain");
			return _domain;
		}
	}
}
