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
namespace Photos {
	/// <summary>Enumerates values that describe the particular subtype (For example, time lapses, bursts, shared collections in the cloud, and etc.) of an asset collection.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum PHAssetCollectionSubtype : long {
		/// <summary>Album created in Photos app.</summary>
		AlbumRegular = 2,
		/// <summary>An event synced to the device from iPhoto.</summary>
		AlbumSyncedEvent = 3,
		/// <summary>A faces group synced from iPhoto.</summary>
		AlbumSyncedFaces = 4,
		/// <summary>An album synced to the device from iPhoto.</summary>
		AlbumSyncedAlbum = 5,
		/// <summary>Album imported from a camera or other external device.</summary>
		AlbumImported = 6,
		/// <summary>The user's iCloud Photo Stream.</summary>
		AlbumMyPhotoStream = 100,
		/// <summary>A shared iCloud album.</summary>
		AlbumCloudShared = 101,
		/// <summary>A smart album of no particular subtype.</summary>
		SmartAlbumGeneric = 200,
		/// <summary>A smart album that holds all the panoramas in the library.</summary>
		SmartAlbumPanoramas = 201,
		/// <summary>A smart album that holds all the videos in the library.</summary>
		SmartAlbumVideos = 202,
		/// <summary>A smart album that holds all assets marked as a favorite.</summary>
		SmartAlbumFavorites = 203,
		/// <summary>A smart album that contains all the timelapse videos in the library.</summary>
		SmartAlbumTimelapses = 204,
		/// <summary>A smart album that holds all assets hidden from Moments view.</summary>
		SmartAlbumAllHidden = 205,
		/// <summary>A smart album that holds recently added assets.</summary>
		SmartAlbumRecentlyAdded = 206,
		/// <summary>A smart album that holds all the burst sequences in the library.</summary>
		SmartAlbumBursts = 207,
		/// <summary>A smart album that contains all the slow-motion videos in the library.</summary>
		SmartAlbumSlomoVideos = 208,
		/// <summary>A smart album that holds all the assets created by the user (as opposed to, for instance, iCloud Shared Albums).</summary>
		SmartAlbumUserLibrary = 209,
		/// <summary>A smart album that holds self portraits.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumSelfPortraits = 210,
		/// <summary>A smart album that holds screenshots.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumScreenshots = 211,
		/// <summary>A smart album that groups Depth Effect images.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumDepthEffect = 212,
		/// <summary>A smart album that groups Live Photo images.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumLivePhotos = 213,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumAnimated = 214,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmartAlbumLongExposures = 215,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SmartAlbumUnableToUpload = 216,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SmartAlbumRAW = 217,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SmartAlbumCinematic = 218,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		SmartAlbumSpatial = 219,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		SmartAlbumScreenRecordings = 220,
		/// <summary>A bitmask of all possible subtypes.</summary>
		Any = 9223372036854775807,
	}
}
