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
namespace CoreSpotlight {
	/// <summary>Enumerates errors that can occur while running a Core Spotlight query with <see cref="M:CoreSpotlight.CSSearchQuery.Start" />.</summary><remarks>Developers can use the <see cref="CoreSpotlight.CSSearchQueryErrorCodeExtensions.GetDomain(CoreSpotlight.CSSearchQueryErrorCode)" /> extension method to get the error domain.</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CSSearchQueryErrorCode : long {
		/// <summary>Indicates that an unknown error ocurred.</summary>
		Unknown = -2000,
		/// <summary>Indicates that the search index could not be reached.</summary>
		IndexUnreachable = -2001,
		/// <summary>Indicates that the query was invalid.</summary>
		InvalidQuery = -2002,
		/// <summary>Indicates that the search was canceled.</summary>
		Cancelled = -2003,
	}
	/// <summary>Extension methods for the <see cref="global::CoreSpotlight.CSSearchQueryErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreSpotlight.CSSearchQueryErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CSSearchQueryErrorCodeExtensions {
		[Field ("CSSearchQueryErrorDomain", "CoreSpotlight")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreSpotlight.CSSearchQueryErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CSSearchQueryErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSSearchQueryErrorDomain");
			return _domain;
		}
	}
}
