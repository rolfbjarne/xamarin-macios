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
namespace NetworkExtension {
	/// <summary>Enumerates errors relating to a DNS proxy.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum NEDnsProxyManagerError : long {
		/// <summary>To be added.</summary>
		Invalid = 1,
		/// <summary>To be added.</summary>
		Disabled = 2,
		/// <summary>To be added.</summary>
		Stale = 3,
		/// <summary>To be added.</summary>
		CannotBeRemoved = 4,
	}
	/// <summary>Extension methods for the <see cref="global::NetworkExtension.NEDnsProxyManagerError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::NetworkExtension.NEDnsProxyManagerError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NEDnsProxyManagerErrorExtensions {
		[Field ("NEDNSProxyErrorDomain", "NetworkExtension")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the NetworkExtension.NEDnsProxyManagerError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NEDnsProxyManagerError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NEDNSProxyErrorDomain");
			return _domain;
		}
	}
}
