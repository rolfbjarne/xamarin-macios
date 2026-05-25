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
namespace PassKit {
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PKAddSecureElementPassErrorCode : long {
		GenericError = 0,
		[ObsoletedOSPlatform ("ios18.0", "Use 'GenericError' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'GenericError' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'GenericError' instead.")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		UnknownError = 0,
		UserCanceledError = 1,
		UnavailableError = 2,
		InvalidConfigurationError = 3,
		DeviceNotSupportedError = 4,
		DeviceNotReadyError = 5,
		OSVersionNotSupportedError = 6,
	}
	/// <summary>Extension methods for the <see cref="global::PassKit.PKAddSecureElementPassErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::PassKit.PKAddSecureElementPassErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PKAddSecureElementPassErrorCodeExtensions {
		[Field ("PKAddSecureElementPassErrorDomain", "PassKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the PassKit.PKAddSecureElementPassErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this PKAddSecureElementPassErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKAddSecureElementPassErrorDomain");
			return _domain;
		}
	}
}
