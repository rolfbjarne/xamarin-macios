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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
	public enum WKWebExtensionContextError : long {
		Unknown = 1,
		AlreadyLoaded = 2,
		NotLoaded = 3,
		BaseUrlAlreadyInUse = 4,
		NoBackgroundContent = 5,
		BackgroundContentFailedToLoad = 6,
	}
	/// <summary>Extension methods for the <see cref="global::WebKit.WKWebExtensionContextError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::WebKit.WKWebExtensionContextError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKWebExtensionContextErrorExtensions {
		[Field ("WKWebExtensionContextErrorDomain", "WebKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the WebKit.WKWebExtensionContextError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this WKWebExtensionContextError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextErrorDomain");
			return _domain;
		}
	}
}
