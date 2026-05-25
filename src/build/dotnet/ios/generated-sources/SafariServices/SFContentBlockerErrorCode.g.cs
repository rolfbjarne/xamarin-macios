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
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios10.0", "Use 'SFErrorCode' enum.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.4", "Use 'SFErrorCode' enum.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum SFContentBlockerErrorCode : long {
		/// <summary>To be added.</summary>
		Ok = 0,
		/// <summary>To be added.</summary>
		NoExtensionFound = 1,
		/// <summary>To be added.</summary>
		NoAttachmentFound = 2,
		/// <summary>To be added.</summary>
		LoadingInterrupted = 3,
	}
	/// <summary>Extension methods for the <see cref="global::SafariServices.SFContentBlockerErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::SafariServices.SFContentBlockerErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios10.0", "Use 'SFErrorCode' enum.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.4", "Use 'SFErrorCode' enum.")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SFContentBlockerErrorCodeExtensions {
		[Field ("SFContentBlockerErrorDomain", "SafariServices")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the SafariServices.SFContentBlockerErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SFContentBlockerErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.SafariServices.Handle, "SFContentBlockerErrorDomain");
			return _domain;
		}
	}
}
