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
	/// <summary>An enumeration that specify possible errors associated with adding a URL to the Safari Reading List.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native ("SSReadingListErrorCode")]
	public enum SSReadingListError : long {
		/// <summary>To be added.</summary>
		UrlSchemeNotAllowed = 1,
	}
	/// <summary>Extension methods for the <see cref="global::SafariServices.SSReadingListError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::SafariServices.SSReadingListError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SSReadingListErrorExtensions {
		[Field ("SSReadingListErrorDomain", "SafariServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the SafariServices.SSReadingListError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SSReadingListError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SSReadingListErrorDomain");
			return _domain;
		}
	}
}
