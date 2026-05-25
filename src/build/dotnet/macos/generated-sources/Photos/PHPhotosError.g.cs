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
namespace Photos {
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PHPhotosError : long {
		InternalError = -1,
		UserCancelled = 3072,
		LibraryVolumeOffline = 3114,
		RelinquishingLibraryBundleToWriter = 3142,
		SwitchingSystemPhotoLibrary = 3143,
		NetworkAccessRequired = 3164,
		NetworkError = 3169,
		IdentifierNotFound = 3201,
		MultipleIdentifiersFound = 3202,
		ChangeNotSupported = 3300,
		OperationInterrupted = 3301,
		InvalidResource = 3302,
		MissingResource = 3303,
		NotEnoughSpace = 3305,
		RequestNotSupportedForAsset = 3306,
		LimitExceeded = 3307,
		AccessRestricted = 3310,
		AccessUserDenied = 3311,
		LibraryInFileProviderSyncRoot = 5423,
		PersistentChangeTokenExpired = 3105,
		PersistentChangeDetailsUnavailable = 3210,
	}
	/// <summary>Extension methods for the <see cref="global::Photos.PHPhotosError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Photos.PHPhotosError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PHPhotosErrorExtensions {
		[Field ("PHPhotosErrorDomain", "Photos")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Photos.PHPhotosError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this PHPhotosError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHPhotosErrorDomain");
			return _domain;
		}
	}
}
