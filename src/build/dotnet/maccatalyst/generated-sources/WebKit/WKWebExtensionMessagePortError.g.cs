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
namespace WebKit {
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Native]
	public enum WKWebExtensionMessagePortError : long {
		Unknown = 1,
		NotConnected = 2,
		MessageInvalid = 3,
	}
	/// <summary>Extension methods for the <see cref="global::WebKit.WKWebExtensionMessagePortError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::WebKit.WKWebExtensionMessagePortError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKWebExtensionMessagePortErrorExtensions {
		[Field ("WKWebExtensionMessagePortErrorDomain", "WebKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the WebKit.WKWebExtensionMessagePortError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this WKWebExtensionMessagePortError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionMessagePortErrorDomain");
			return _domain;
		}
	}
}
