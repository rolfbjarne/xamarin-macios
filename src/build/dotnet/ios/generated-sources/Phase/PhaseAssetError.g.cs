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
namespace Phase {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PhaseAssetError : long {
		FailedToLoad = 1346920801,
		InvalidEngineInstance = 1346920802,
		BadParameters = 1346920803,
		AlreadyExists = 1346920804,
		GeneralError = 1346920805,
		MemoryAllocation = 1346920806,
	}
	/// <summary>Extension methods for the <see cref="global::Phase.PhaseAssetError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Phase.PhaseAssetError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PhaseAssetErrorExtensions {
		[Field ("PHASEAssetErrorDomain", "Phase")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Phase.PhaseAssetError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this PhaseAssetError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Phase.Handle, "PHASEAssetErrorDomain");
			return _domain;
		}
	}
}
