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
	[SupportedOSPlatform ("tvos13.0")]
	[Native]
	public enum TVDocumentError : long {
		Failed = 0,
		Cancelled = 1,
	}
	/// <summary>Extension methods for the <see cref="global::TVMLKit.TVDocumentError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::TVMLKit.TVDocumentError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos13.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class TVDocumentErrorExtensions {
		[Field ("TVDocumentErrorDomain", "TVMLKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the TVMLKit.TVDocumentError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this TVDocumentError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.TVMLKit.Handle, "TVDocumentErrorDomain");
			return _domain;
		}
	}
}
