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
namespace PassKit {
	/// <summary>An enumeration whose values specify errors relating to the passes and passbook functionality.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PKPassKitErrorCode : long {
		/// <summary>An unknown error.</summary>
		Unknown = -1,
		/// <summary>No error.</summary>
		None = 0,
		/// <summary>Invalid data.</summary>
		InvalidData = 1,
		/// <summary>The pass version is not supported on this device.</summary>
		UnsupportedVersion = 2,
		/// <summary>Indicates a mismatch in the signature, such as pass type identifier in the certificate versus the pass.</summary>
		InvalidSignature = 3,
		/// <summary>The app does not have the required entitlements.</summary>
		NotEntitled = 4,
	}
	/// <summary>Extension methods for the <see cref="global::PassKit.PKPassKitErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::PassKit.PKPassKitErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PKPassKitErrorCodeExtensions {
		[Field ("PKPassKitErrorDomain", "PassKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the PassKit.PKPassKitErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this PKPassKitErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassKitErrorDomain");
			return _domain;
		}
	}
}
