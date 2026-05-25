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
namespace MetricKit {
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[Native]
	public enum MXErrorCode : long {
		InvalidId = 0,
		MaxCount = 1,
		PastDeadline = 2,
		Duplicated = 3,
		Unknown = 4,
		InternalFailure = 5,
	}
	/// <summary>Extension methods for the <see cref="global::MetricKit.MXErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::MetricKit.MXErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MXErrorCodeExtensions {
		[Field ("MXErrorDomain", "MetricKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the MetricKit.MXErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MXErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.MetricKit.Handle, "MXErrorDomain");
			return _domain;
		}
	}
}
