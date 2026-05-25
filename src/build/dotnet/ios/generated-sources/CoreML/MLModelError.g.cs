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
namespace CoreML {
	/// <summary>Enumerates errors that may occur in the use of Core ML.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MLModelError : long {
		/// <summary>A non-specific generic error.</summary>
		Generic = 0,
		/// <summary>Indicates an error relating to some incompatibility of an <see cref="T:CoreML.MLFeatureType" />.</summary>
		FeatureType = 1,
		/// <summary>Indicates an I/O error.</summary>
		IO = 3,
		/// <summary>Indicates an error relating to a custom layer.</summary>
		CustomLayer = 4,
		/// <summary>To be added.</summary>
		CustomModel = 5,
		Update = 6,
		Parameters = 7,
		ModelDecryptionKeyFetch = 8,
		ModelDecryption = 9,
		ModelCollection = 10,
		PredictionCancelled = 11,
	}
	/// <summary>Extension methods for the <see cref="global::CoreML.MLModelError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreML.MLModelError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MLModelErrorExtensions {
		[Field ("MLModelErrorDomain", "CoreML")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreML.MLModelError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MLModelError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelErrorDomain");
			return _domain;
		}
	}
}
