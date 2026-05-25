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
namespace TVMLKit {
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum TVMLKitError : long {
		Unknown = 1,
		InternetUnavailable = 2,
		FailedToLaunch = 3,
		Last = 4,
	}
	/// <summary>Extension methods for the <see cref="global::TVMLKit.TVMLKitError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::TVMLKit.TVMLKitError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class TVMLKitErrorExtensions {
		[Field ("TVMLKitErrorDomain", "TVMLKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the TVMLKit.TVMLKitError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this TVMLKitError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.TVMLKit.Handle, "TVMLKitErrorDomain");
			return _domain;
		}
	}
}
