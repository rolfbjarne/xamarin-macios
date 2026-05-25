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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	/// <summary>Constants identifying 3GP metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class ThreeGP  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataAlbumAndTrack;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataAlbumAndTrack</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataAlbumAndTrack",  "AVFoundation")]
			public static NSString UserDataAlbumAndTrack {
				get {
					if (_UserDataAlbumAndTrack is null)
						_UserDataAlbumAndTrack = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataAlbumAndTrack")!;
					return _UserDataAlbumAndTrack;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataAuthor;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataAuthor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataAuthor",  "AVFoundation")]
			public static NSString UserDataAuthor {
				get {
					if (_UserDataAuthor is null)
						_UserDataAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataAuthor")!;
					return _UserDataAuthor;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCollection;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataCollection</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataCollection",  "AVFoundation")]
			public static NSString UserDataCollection {
				get {
					if (_UserDataCollection is null)
						_UserDataCollection = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataCollection")!;
					return _UserDataCollection;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCopyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataCopyright",  "AVFoundation")]
			public static NSString UserDataCopyright {
				get {
					if (_UserDataCopyright is null)
						_UserDataCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataCopyright")!;
					return _UserDataCopyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataDescription;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataDescription",  "AVFoundation")]
			public static NSString UserDataDescription {
				get {
					if (_UserDataDescription is null)
						_UserDataDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataDescription")!;
					return _UserDataDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataGenre;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataGenre</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataGenre",  "AVFoundation")]
			public static NSString UserDataGenre {
				get {
					if (_UserDataGenre is null)
						_UserDataGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataGenre")!;
					return _UserDataGenre;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataKeywordList;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataKeywordList</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataKeywordList",  "AVFoundation")]
			public static NSString UserDataKeywordList {
				get {
					if (_UserDataKeywordList is null)
						_UserDataKeywordList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataKeywordList")!;
					return _UserDataKeywordList;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataLocation;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataLocation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataLocation",  "AVFoundation")]
			public static NSString UserDataLocation {
				get {
					if (_UserDataLocation is null)
						_UserDataLocation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataLocation")!;
					return _UserDataLocation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataMediaClassification;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataMediaClassification</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataMediaClassification",  "AVFoundation")]
			public static NSString UserDataMediaClassification {
				get {
					if (_UserDataMediaClassification is null)
						_UserDataMediaClassification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataMediaClassification")!;
					return _UserDataMediaClassification;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataMediaRating;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataMediaRating</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataMediaRating",  "AVFoundation")]
			public static NSString UserDataMediaRating {
				get {
					if (_UserDataMediaRating is null)
						_UserDataMediaRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataMediaRating")!;
					return _UserDataMediaRating;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataPerformer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataPerformer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataPerformer",  "AVFoundation")]
			public static NSString UserDataPerformer {
				get {
					if (_UserDataPerformer is null)
						_UserDataPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataPerformer")!;
					return _UserDataPerformer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataRecordingYear;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataRecordingYear</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataRecordingYear",  "AVFoundation")]
			public static NSString UserDataRecordingYear {
				get {
					if (_UserDataRecordingYear is null)
						_UserDataRecordingYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataRecordingYear")!;
					return _UserDataRecordingYear;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataThumbnail;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataThumbnail</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataThumbnail",  "AVFoundation")]
			public static NSString UserDataThumbnail {
				get {
					if (_UserDataThumbnail is null)
						_UserDataThumbnail = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataThumbnail")!;
					return _UserDataThumbnail;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataTitle",  "AVFoundation")]
			public static NSString UserDataTitle {
				get {
					if (_UserDataTitle is null)
						_UserDataTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataTitle")!;
					return _UserDataTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataUserRating;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifier3GPUserDataUserRating</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifier3GPUserDataUserRating",  "AVFoundation")]
			public static NSString UserDataUserRating {
				get {
					if (_UserDataUserRating is null)
						_UserDataUserRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataUserRating")!;
					return _UserDataUserRating;
				}
			}
		} /* class ThreeGP */
	}
}
