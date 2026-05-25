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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SafariServices {
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'ASWebAuthenticationSessionErrorCode' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ASWebAuthenticationSessionErrorCode' instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum SFAuthenticationError : long {
		/// <summary>To be added.</summary>
		CanceledLogin = 1,
	}
	/// <summary>Extension methods for the <see cref="global::SafariServices.SFAuthenticationError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::SafariServices.SFAuthenticationError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'ASWebAuthenticationSessionErrorCode' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ASWebAuthenticationSessionErrorCode' instead.")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SFAuthenticationErrorExtensions {
		[Field ("SFAuthenticationErrorDomain", "SafariServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the SafariServices.SFAuthenticationError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SFAuthenticationError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SFAuthenticationErrorDomain");
			return _domain;
		}
	}
}
