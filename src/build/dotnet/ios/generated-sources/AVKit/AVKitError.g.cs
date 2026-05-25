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
namespace AVKit {
	/// <summary>Enumeration of error states that can occur while using AVKit.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum AVKitError : long {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Unknown = -1000,
		/// <summary>To be added.</summary>
		PictureInPictureStartFailed = -1001,
		ContentRatingUnknown = -1100,
		ContentDisallowedByPasscode = -1101,
		ContentDisallowedByProfile = -1102,
		RecordingFailed = -1200,
	}
	/// <summary>Extension methods for the <see cref="global::AVKit.AVKitError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::AVKit.AVKitError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVKitErrorExtensions {
		[Field ("AVKitErrorDomain", "AVKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the AVKit.AVKitError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this AVKitError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.AVKit.Handle, "AVKitErrorDomain");
			return _domain;
		}
	}
}
