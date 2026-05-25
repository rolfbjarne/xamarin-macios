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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum MTLBinaryArchiveError : ulong {
		None = 0,
		InvalidFile = 1,
		UnexpectedElement = 2,
		CompilationFailure = 3,
		InternalError = 4,
	}
	/// <summary>Extension methods for the <see cref="global::Metal.MTLBinaryArchiveError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Metal.MTLBinaryArchiveError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MTLBinaryArchiveErrorExtensions {
		[Field ("MTLBinaryArchiveDomain", "Metal")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Metal.MTLBinaryArchiveError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MTLBinaryArchiveError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Metal.Handle, "MTLBinaryArchiveDomain");
			return _domain;
		}
	}
}
