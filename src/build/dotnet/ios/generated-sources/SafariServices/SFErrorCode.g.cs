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
namespace SafariServices {
	/// <summary>Enumerates errors that that Safari can encounter when working with content blockers or app extensions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum SFErrorCode : long {
		/// <summary>No error occurred.</summary>
		Ok = 0,
		/// <summary>No blocker or extension was found for the specified bundle ID, or the specified extension is owned by someone else.</summary>
		NoExtensionFound = 1,
		/// <summary>The blocker returned an extension item that did not contain an attachment.</summary>
		NoAttachmentFound = 2,
		/// <summary>An error occurred that prevented the blocker or extension from loading.</summary>
		LoadingInterrupted = 3,
		/// <summary>An internal error occurred.</summary>
		InternalError = 4,
		/// <summary>The app is missing an entitlement.</summary>
		MissingEntitlement = 5,
		/// <summary>The maximum number of allowed attempts to load the extension has been exceeded.</summary>
		MaximumAttemptsExceeded = 6,
	}
	/// <summary>Extension methods for the <see cref="global::SafariServices.SFErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::SafariServices.SFErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SFErrorCodeExtensions {
		[Field ("SFErrorDomain", "SafariServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the SafariServices.SFErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SFErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SFErrorDomain");
			return _domain;
		}
	}
}
