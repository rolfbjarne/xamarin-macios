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
namespace UIKit {
	/// <summary>An enumeration of error codes from the printing system.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum UIPrintError : int {
		/// <summary>The printer was not available.</summary>
		NotAvailable = 1,
		/// <summary>The job contained no content.</summary>
		NoContent = 2,
		/// <summary>The print job image was not in a recognized format.</summary>
		UnknownImageFormat = 3,
		/// <summary>The job failed.</summary>
		JobFailed = 4,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIPrintError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::UIKit.UIPrintError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIPrintErrorExtensions {
		[Field ("UIPrintErrorDomain", "UIKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the UIKit.UIPrintError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this UIPrintError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPrintErrorDomain");
			return _domain;
		}
	}
}
