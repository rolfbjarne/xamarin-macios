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
	/// <summary>Constants identifying Quicktime metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class QuickTimeMetadata  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AccessibilityDescription;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataAccessibilityDescription'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataAccessibilityDescription",  "AVFoundation")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			public static NSString AccessibilityDescription {
				[SupportedOSPlatform ("tvos14.0")]
				[SupportedOSPlatform ("ios14.0")]
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("macos")]
				get {
					if (_AccessibilityDescription is null)
						_AccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAccessibilityDescription")!;
					return _AccessibilityDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Album;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataAlbum</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataAlbum",  "AVFoundation")]
			public static NSString Album {
				get {
					if (_Album is null)
						_Album = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAlbum")!;
					return _Album;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Arranger;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataArranger</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataArranger",  "AVFoundation")]
			public static NSString Arranger {
				get {
					if (_Arranger is null)
						_Arranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArranger")!;
					return _Arranger;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Artist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataArtist",  "AVFoundation")]
			public static NSString Artist {
				get {
					if (_Artist is null)
						_Artist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArtist")!;
					return _Artist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Artwork;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataArtwork</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataArtwork",  "AVFoundation")]
			public static NSString Artwork {
				get {
					if (_Artwork is null)
						_Artwork = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArtwork")!;
					return _Artwork;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Author;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataAuthor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataAuthor",  "AVFoundation")]
			public static NSString Author {
				get {
					if (_Author is null)
						_Author = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAuthor")!;
					return _Author;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AutoLivePhoto;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataAutoLivePhoto'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataAutoLivePhoto",  "AVFoundation")]
			[SupportedOSPlatform ("tvos13.0")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString AutoLivePhoto {
				[SupportedOSPlatform ("tvos13.0")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_AutoLivePhoto is null)
						_AutoLivePhoto = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAutoLivePhoto")!;
					return _AutoLivePhoto;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CameraFrameReadoutTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCameraFrameReadoutTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCameraFrameReadoutTime",  "AVFoundation")]
			public static NSString CameraFrameReadoutTime {
				get {
					if (_CameraFrameReadoutTime is null)
						_CameraFrameReadoutTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraFrameReadoutTime")!;
					return _CameraFrameReadoutTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CameraIdentifier;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCameraIdentifier</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCameraIdentifier",  "AVFoundation")]
			public static NSString CameraIdentifier {
				get {
					if (_CameraIdentifier is null)
						_CameraIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraIdentifier")!;
					return _CameraIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CollectionUser;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCollectionUser</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCollectionUser",  "AVFoundation")]
			public static NSString CollectionUser {
				get {
					if (_CollectionUser is null)
						_CollectionUser = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCollectionUser")!;
					return _CollectionUser;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Comment;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataComment</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataComment",  "AVFoundation")]
			public static NSString Comment {
				get {
					if (_Comment is null)
						_Comment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataComment")!;
					return _Comment;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Composer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataComposer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataComposer",  "AVFoundation")]
			public static NSString Composer {
				get {
					if (_Composer is null)
						_Composer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataComposer")!;
					return _Composer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ContentIdentifier;
			/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataContentIdentifier",  "AVFoundation")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString ContentIdentifier {
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_ContentIdentifier is null)
						_ContentIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataContentIdentifier")!;
					return _ContentIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Copyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCopyright",  "AVFoundation")]
			public static NSString Copyright {
				get {
					if (_Copyright is null)
						_Copyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCopyright")!;
					return _Copyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CreationDate;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCreationDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCreationDate",  "AVFoundation")]
			public static NSString CreationDate {
				get {
					if (_CreationDate is null)
						_CreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCreationDate")!;
					return _CreationDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Credits;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataCredits</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataCredits",  "AVFoundation")]
			public static NSString Credits {
				get {
					if (_Credits is null)
						_Credits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCredits")!;
					return _Credits;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Description;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDescription",  "AVFoundation")]
			public static NSString Description {
				get {
					if (_Description is null)
						_Description = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDescription")!;
					return _Description;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DetectedCatBody;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataDetectedCatBody'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDetectedCatBody",  "AVFoundation")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString DetectedCatBody {
				[UnsupportedOSPlatform ("tvos")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_DetectedCatBody is null)
						_DetectedCatBody = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedCatBody")!;
					return _DetectedCatBody;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DetectedDogBody;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataDetectedDogBody'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDetectedDogBody",  "AVFoundation")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString DetectedDogBody {
				[UnsupportedOSPlatform ("tvos")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_DetectedDogBody is null)
						_DetectedDogBody = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedDogBody")!;
					return _DetectedDogBody;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DetectedFace;
			/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDetectedFace",  "AVFoundation")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString DetectedFace {
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_DetectedFace is null)
						_DetectedFace = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedFace")!;
					return _DetectedFace;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DetectedHumanBody;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataDetectedHumanBody'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDetectedHumanBody",  "AVFoundation")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString DetectedHumanBody {
				[UnsupportedOSPlatform ("tvos")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_DetectedHumanBody is null)
						_DetectedHumanBody = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedHumanBody")!;
					return _DetectedHumanBody;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DetectedSalientObject;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataDetectedSalientObject'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDetectedSalientObject",  "AVFoundation")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString DetectedSalientObject {
				[UnsupportedOSPlatform ("tvos")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_DetectedSalientObject is null)
						_DetectedSalientObject = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedSalientObject")!;
					return _DetectedSalientObject;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DirectionFacing;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataDirectionFacing</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDirectionFacing",  "AVFoundation")]
			public static NSString DirectionFacing {
				get {
					if (_DirectionFacing is null)
						_DirectionFacing = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirectionFacing")!;
					return _DirectionFacing;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DirectionMotion;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataDirectionMotion</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDirectionMotion",  "AVFoundation")]
			public static NSString DirectionMotion {
				get {
					if (_DirectionMotion is null)
						_DirectionMotion = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirectionMotion")!;
					return _DirectionMotion;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Director;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataDirector</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDirector",  "AVFoundation")]
			public static NSString Director {
				get {
					if (_Director is null)
						_Director = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirector")!;
					return _Director;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DisplayName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataDisplayName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataDisplayName",  "AVFoundation")]
			public static NSString DisplayName {
				get {
					if (_DisplayName is null)
						_DisplayName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDisplayName")!;
					return _DisplayName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodedBy;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataEncodedBy</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataEncodedBy",  "AVFoundation")]
			public static NSString EncodedBy {
				get {
					if (_EncodedBy is null)
						_EncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataEncodedBy")!;
					return _EncodedBy;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Genre;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataGenre</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataGenre",  "AVFoundation")]
			public static NSString Genre {
				get {
					if (_Genre is null)
						_Genre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataGenre")!;
					return _Genre;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Information;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataInformation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataInformation",  "AVFoundation")]
			public static NSString Information {
				get {
					if (_Information is null)
						_Information = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataInformation")!;
					return _Information;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Keywords;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataKeywords</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataKeywords",  "AVFoundation")]
			public static NSString Keywords {
				get {
					if (_Keywords is null)
						_Keywords = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataKeywords")!;
					return _Keywords;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LivePhotoVitalityScore;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScore'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScore",  "AVFoundation")]
			[SupportedOSPlatform ("tvos13.0")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString LivePhotoVitalityScore {
				[SupportedOSPlatform ("tvos13.0")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_LivePhotoVitalityScore is null)
						_LivePhotoVitalityScore = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScore")!;
					return _LivePhotoVitalityScore;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LivePhotoVitalityScoringVersion;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScoringVersion'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScoringVersion",  "AVFoundation")]
			[SupportedOSPlatform ("tvos13.0")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString LivePhotoVitalityScoringVersion {
				[SupportedOSPlatform ("tvos13.0")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_LivePhotoVitalityScoringVersion is null)
						_LivePhotoVitalityScoringVersion = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLivePhotoVitalityScoringVersion")!;
					return _LivePhotoVitalityScoringVersion;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationBody;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationBody</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationBody",  "AVFoundation")]
			public static NSString LocationBody {
				get {
					if (_LocationBody is null)
						_LocationBody = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationBody")!;
					return _LocationBody;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationDate;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationDate",  "AVFoundation")]
			public static NSString LocationDate {
				get {
					if (_LocationDate is null)
						_LocationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationDate")!;
					return _LocationDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationHorizontalAccuracyInMeters;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataLocationHorizontalAccuracyInMeters'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationHorizontalAccuracyInMeters",  "AVFoundation")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			public static NSString LocationHorizontalAccuracyInMeters {
				[SupportedOSPlatform ("tvos14.0")]
				[SupportedOSPlatform ("ios14.0")]
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("macos")]
				get {
					if (_LocationHorizontalAccuracyInMeters is null)
						_LocationHorizontalAccuracyInMeters = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationHorizontalAccuracyInMeters")!;
					return _LocationHorizontalAccuracyInMeters;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationISO6709;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationISO6709</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationISO6709",  "AVFoundation")]
			public static NSString LocationISO6709 {
				get {
					if (_LocationISO6709 is null)
						_LocationISO6709 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationISO6709")!;
					return _LocationISO6709;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationName",  "AVFoundation")]
			public static NSString LocationName {
				get {
					if (_LocationName is null)
						_LocationName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationName")!;
					return _LocationName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationNote;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationNote</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationNote",  "AVFoundation")]
			public static NSString LocationNote {
				get {
					if (_LocationNote is null)
						_LocationNote = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationNote")!;
					return _LocationNote;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LocationRole;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataLocationRole</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataLocationRole",  "AVFoundation")]
			public static NSString LocationRole {
				get {
					if (_LocationRole is null)
						_LocationRole = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationRole")!;
					return _LocationRole;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Make;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataMake</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataMake",  "AVFoundation")]
			public static NSString Make {
				get {
					if (_Make is null)
						_Make = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataMake")!;
					return _Make;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Model;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataModel</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataModel",  "AVFoundation")]
			public static NSString Model {
				get {
					if (_Model is null)
						_Model = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataModel")!;
					return _Model;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataOriginalArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataOriginalArtist",  "AVFoundation")]
			public static NSString OriginalArtist {
				get {
					if (_OriginalArtist is null)
						_OriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataOriginalArtist")!;
					return _OriginalArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Performer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataPerformer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataPerformer",  "AVFoundation")]
			public static NSString Performer {
				get {
					if (_Performer is null)
						_Performer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPerformer")!;
					return _Performer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PhonogramRights;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataPhonogramRights</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataPhonogramRights",  "AVFoundation")]
			public static NSString PhonogramRights {
				get {
					if (_PhonogramRights is null)
						_PhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPhonogramRights")!;
					return _PhonogramRights;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PreferredAffineTransform;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataPreferredAffineTransform</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataPreferredAffineTransform",  "AVFoundation")]
			public static NSString PreferredAffineTransform {
				get {
					if (_PreferredAffineTransform is null)
						_PreferredAffineTransform = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPreferredAffineTransform")!;
					return _PreferredAffineTransform;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Producer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataProducer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataProducer",  "AVFoundation")]
			public static NSString Producer {
				get {
					if (_Producer is null)
						_Producer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataProducer")!;
					return _Producer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Publisher;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataPublisher</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataPublisher",  "AVFoundation")]
			public static NSString Publisher {
				get {
					if (_Publisher is null)
						_Publisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPublisher")!;
					return _Publisher;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RatingUser;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataRatingUser</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataRatingUser",  "AVFoundation")]
			public static NSString RatingUser {
				get {
					if (_RatingUser is null)
						_RatingUser = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataRatingUser")!;
					return _RatingUser;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Software;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataSoftware</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataSoftware",  "AVFoundation")]
			public static NSString Software {
				get {
					if (_Software is null)
						_Software = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataSoftware")!;
					return _Software;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SpatialOverCaptureQualityScore;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScore'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScore",  "AVFoundation")]
			[SupportedOSPlatform ("tvos13.0")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString SpatialOverCaptureQualityScore {
				[SupportedOSPlatform ("tvos13.0")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_SpatialOverCaptureQualityScore is null)
						_SpatialOverCaptureQualityScore = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScore")!;
					return _SpatialOverCaptureQualityScore;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SpatialOverCaptureQualityScoringVersion;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScoringVersion'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScoringVersion",  "AVFoundation")]
			[SupportedOSPlatform ("tvos13.0")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public static NSString SpatialOverCaptureQualityScoringVersion {
				[SupportedOSPlatform ("tvos13.0")]
				[UnsupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("ios13.0")]
				[SupportedOSPlatform ("maccatalyst")]
				get {
					if (_SpatialOverCaptureQualityScoringVersion is null)
						_SpatialOverCaptureQualityScoringVersion = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataSpatialOverCaptureQualityScoringVersion")!;
					return _SpatialOverCaptureQualityScoringVersion;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Title;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataTitle",  "AVFoundation")]
			public static NSString Title {
				get {
					if (_Title is null)
						_Title = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataTitle")!;
					return _Title;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _VideoOrientation;
			/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataVideoOrientation",  "AVFoundation")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString VideoOrientation {
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_VideoOrientation is null)
						_VideoOrientation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataVideoOrientation")!;
					return _VideoOrientation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Year;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataYear</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataYear",  "AVFoundation")]
			public static NSString Year {
				get {
					if (_Year is null)
						_Year = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataYear")!;
					return _Year;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _iXML;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeMetadataiXML</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeMetadataiXML",  "AVFoundation")]
			public static NSString iXML {
				get {
					if (_iXML is null)
						_iXML = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataiXML")!;
					return _iXML;
				}
			}
		} /* class QuickTimeMetadata */
	}
}
