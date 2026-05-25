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
	/// <summary>Enumerates WebKit errors.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum WKErrorCode : long {
		/// <summary>No error occurred.</summary>
		None = 0,
		/// <summary>An unknown error occurred.</summary>
		Unknown = 1,
		/// <summary>A WebContent process terminated unexpectetly.</summary>
		WebContentProcessTerminated = 2,
		/// <summary>A WebView was invalidated.</summary>
		WebViewInvalidated = 3,
		/// <summary>A JavaScript exception occurred.</summary>
		JavaScriptExceptionOccurred = 4,
		/// <summary>The result of a JavaScript execution was not supported.</summary>
		JavaScriptResultTypeIsUnsupported = 5,
		/// <summary>Indicates that a rule list could not be compiled.</summary>
		ContentRuleListStoreCompileFailed = 6,
		/// <summary>Indicates that a rule list could not be looked up.</summary>
		ContentRuleListStoreLookUpFailed = 7,
		/// <summary>Indicates that a rule list could not be removed from a store.</summary>
		ContentRuleListStoreRemoveFailed = 8,
		/// <summary>Indicates that there was a mismatch between rule list store versions.</summary>
		ContentRuleListStoreVersionMismatch = 9,
		AttributedStringContentFailedToLoad = 10,
		AttributedStringContentLoadTimedOut = 11,
		JavaScriptInvalidFrameTarget = 12,
		NavigationAppBoundDomain = 13,
		JavaScriptAppBoundDomain = 14,
		DuplicateCredential = 15,
		MalformedCredential = 16,
		CredentialNotFound = 17,
	}
	/// <summary>Extension methods for the <see cref="global::WebKit.WKErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::WebKit.WKErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKErrorCodeExtensions {
		[Field ("WKErrorDomain", "WebKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the WebKit.WKErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this WKErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKErrorDomain");
			return _domain;
		}
	}
}
