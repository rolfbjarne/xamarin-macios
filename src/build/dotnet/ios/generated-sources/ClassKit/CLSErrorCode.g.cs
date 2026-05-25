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
namespace ClassKit {
	/// <summary>Enumerates ClassKit error codes.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CLSErrorCode : long {
		/// <summary>No error occurred.</summary>
		None = 0,
		/// <summary>ClassKit was not available</summary>
		ClassKitUnavailable = 1,
		/// <summary>An argument was invalid.</summary>
		InvalidArgument = 2,
		/// <summary>An attempt was made to modify a read-only value.</summary>
		InvalidModification = 3,
		/// <summary>Authorization for the operation was denied.</summary>
		AuthorizationDenied = 4,
		/// <summary>A database could not be accessed.</summary>
		DatabaseInaccessible = 5,
		/// <summary>An unspecified limit was exceeded.</summary>
		Limits = 6,
		/// <summary>An attempt was made to save a created object that is identical to an existing one.</summary>
		InvalidCreate = 7,
		/// <summary>An update failed.</summary>
		InvalidUpdate = 8,
		/// <summary>More than one error occurred, so the topmost error has an underlying error or errors.</summary>
		PartialFailure = 9,
		InvalidAccountCredentials = 10,
	}
	/// <summary>Extension methods for the <see cref="global::ClassKit.CLSErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::ClassKit.CLSErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CLSErrorCodeExtensions {
		[Field ("CLSErrorCodeDomain", "ClassKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the ClassKit.CLSErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CLSErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSErrorCodeDomain");
			return _domain;
		}
	}
}
