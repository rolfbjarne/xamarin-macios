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
namespace MultipeerConnectivity {
	/// <summary>An enumeration whose values specify various errors relating to multipeer connectivity.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native ("MCErrorCode")]
	public enum MCError : long {
		/// <summary>The type of the error could not be determined.</summary>
		Unknown = 0,
		/// <summary>Data was sent to a peer that is not connected.</summary>
		NotConnected = 1,
		/// <summary>The relevant operation was called with an invalid parameter.</summary>
		InvalidParameter = 2,
		/// <summary>The relevant operation is not supported (for instance, an attempt to send a non-local or non-Web-based resource).</summary>
		Unsupported = 3,
		/// <summary>Indicates a connection or data-transmission time-out.</summary>
		TimedOut = 4,
		/// <summary>The relevant operation was cancelled.</summary>
		Cancelled = 5,
		/// <summary>Indicates that Multipeer Connectivity is not available.</summary>
		Unavailable = 6,
	}
	/// <summary>Extension methods for the <see cref="global::MultipeerConnectivity.MCError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::MultipeerConnectivity.MCError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MCErrorExtensions {
		[Field ("MCErrorDomain", "MultipeerConnectivity")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the MultipeerConnectivity.MCError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MCError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.MultipeerConnectivity.Handle, "MCErrorDomain");
			return _domain;
		}
	}
}
