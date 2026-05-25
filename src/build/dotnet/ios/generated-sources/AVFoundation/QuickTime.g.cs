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
namespace AVFoundation {
	/// <summary>Constants identifying Quicktime metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class QuickTime  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataAccessibilityDescription;
			/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeUserDataAccessibilityDescription'.</summary>
			[Field ("AVMetadataIdentifierQuickTimeUserDataAccessibilityDescription",  "AVFoundation")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			public static NSString UserDataAccessibilityDescription {
				[SupportedOSPlatform ("tvos14.0")]
				[SupportedOSPlatform ("ios14.0")]
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("macos")]
				get {
					if (_UserDataAccessibilityDescription is null)
						_UserDataAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataAccessibilityDescription")!;
					return _UserDataAccessibilityDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataAlbum;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataAlbum</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataAlbum",  "AVFoundation")]
			public static NSString UserDataAlbum {
				get {
					if (_UserDataAlbum is null)
						_UserDataAlbum = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataAlbum")!;
					return _UserDataAlbum;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataArranger;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataArranger</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataArranger",  "AVFoundation")]
			public static NSString UserDataArranger {
				get {
					if (_UserDataArranger is null)
						_UserDataArranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataArranger")!;
					return _UserDataArranger;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataArtist",  "AVFoundation")]
			public static NSString UserDataArtist {
				get {
					if (_UserDataArtist is null)
						_UserDataArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataArtist")!;
					return _UserDataArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataAuthor;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataAuthor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataAuthor",  "AVFoundation")]
			public static NSString UserDataAuthor {
				get {
					if (_UserDataAuthor is null)
						_UserDataAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataAuthor")!;
					return _UserDataAuthor;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataChapter;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataChapter</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataChapter",  "AVFoundation")]
			public static NSString UserDataChapter {
				get {
					if (_UserDataChapter is null)
						_UserDataChapter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataChapter")!;
					return _UserDataChapter;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataComment;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataComment</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataComment",  "AVFoundation")]
			public static NSString UserDataComment {
				get {
					if (_UserDataComment is null)
						_UserDataComment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataComment")!;
					return _UserDataComment;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataComposer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataComposer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataComposer",  "AVFoundation")]
			public static NSString UserDataComposer {
				get {
					if (_UserDataComposer is null)
						_UserDataComposer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataComposer")!;
					return _UserDataComposer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCopyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataCopyright",  "AVFoundation")]
			public static NSString UserDataCopyright {
				get {
					if (_UserDataCopyright is null)
						_UserDataCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCopyright")!;
					return _UserDataCopyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCreationDate;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataCreationDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataCreationDate",  "AVFoundation")]
			public static NSString UserDataCreationDate {
				get {
					if (_UserDataCreationDate is null)
						_UserDataCreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCreationDate")!;
					return _UserDataCreationDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCredits;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataCredits</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataCredits",  "AVFoundation")]
			public static NSString UserDataCredits {
				get {
					if (_UserDataCredits is null)
						_UserDataCredits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCredits")!;
					return _UserDataCredits;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataDescription;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataDescription",  "AVFoundation")]
			public static NSString UserDataDescription {
				get {
					if (_UserDataDescription is null)
						_UserDataDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDescription")!;
					return _UserDataDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataDirector;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataDirector</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataDirector",  "AVFoundation")]
			public static NSString UserDataDirector {
				get {
					if (_UserDataDirector is null)
						_UserDataDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDirector")!;
					return _UserDataDirector;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataDisclaimer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataDisclaimer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataDisclaimer",  "AVFoundation")]
			public static NSString UserDataDisclaimer {
				get {
					if (_UserDataDisclaimer is null)
						_UserDataDisclaimer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDisclaimer")!;
					return _UserDataDisclaimer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataEncodedBy;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataEncodedBy</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataEncodedBy",  "AVFoundation")]
			public static NSString UserDataEncodedBy {
				get {
					if (_UserDataEncodedBy is null)
						_UserDataEncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataEncodedBy")!;
					return _UserDataEncodedBy;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataFullName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataFullName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataFullName",  "AVFoundation")]
			public static NSString UserDataFullName {
				get {
					if (_UserDataFullName is null)
						_UserDataFullName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataFullName")!;
					return _UserDataFullName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataGenre;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataGenre</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataGenre",  "AVFoundation")]
			public static NSString UserDataGenre {
				get {
					if (_UserDataGenre is null)
						_UserDataGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataGenre")!;
					return _UserDataGenre;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataHostComputer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataHostComputer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataHostComputer",  "AVFoundation")]
			public static NSString UserDataHostComputer {
				get {
					if (_UserDataHostComputer is null)
						_UserDataHostComputer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataHostComputer")!;
					return _UserDataHostComputer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataInformation;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataInformation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataInformation",  "AVFoundation")]
			public static NSString UserDataInformation {
				get {
					if (_UserDataInformation is null)
						_UserDataInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataInformation")!;
					return _UserDataInformation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataKeywords;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataKeywords</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataKeywords",  "AVFoundation")]
			public static NSString UserDataKeywords {
				get {
					if (_UserDataKeywords is null)
						_UserDataKeywords = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataKeywords")!;
					return _UserDataKeywords;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataLocationISO6709;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataLocationISO6709</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataLocationISO6709",  "AVFoundation")]
			public static NSString UserDataLocationISO6709 {
				get {
					if (_UserDataLocationISO6709 is null)
						_UserDataLocationISO6709 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataLocationISO6709")!;
					return _UserDataLocationISO6709;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataMake;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataMake</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataMake",  "AVFoundation")]
			public static NSString UserDataMake {
				get {
					if (_UserDataMake is null)
						_UserDataMake = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataMake")!;
					return _UserDataMake;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataModel;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataModel</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataModel",  "AVFoundation")]
			public static NSString UserDataModel {
				get {
					if (_UserDataModel is null)
						_UserDataModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataModel")!;
					return _UserDataModel;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataOriginalArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataOriginalArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataOriginalArtist",  "AVFoundation")]
			public static NSString UserDataOriginalArtist {
				get {
					if (_UserDataOriginalArtist is null)
						_UserDataOriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalArtist")!;
					return _UserDataOriginalArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataOriginalFormat;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataOriginalFormat</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataOriginalFormat",  "AVFoundation")]
			public static NSString UserDataOriginalFormat {
				get {
					if (_UserDataOriginalFormat is null)
						_UserDataOriginalFormat = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalFormat")!;
					return _UserDataOriginalFormat;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataOriginalSource;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataOriginalSource</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataOriginalSource",  "AVFoundation")]
			public static NSString UserDataOriginalSource {
				get {
					if (_UserDataOriginalSource is null)
						_UserDataOriginalSource = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalSource")!;
					return _UserDataOriginalSource;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataPerformers;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataPerformers</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataPerformers",  "AVFoundation")]
			public static NSString UserDataPerformers {
				get {
					if (_UserDataPerformers is null)
						_UserDataPerformers = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPerformers")!;
					return _UserDataPerformers;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataPhonogramRights;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataPhonogramRights</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataPhonogramRights",  "AVFoundation")]
			public static NSString UserDataPhonogramRights {
				get {
					if (_UserDataPhonogramRights is null)
						_UserDataPhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPhonogramRights")!;
					return _UserDataPhonogramRights;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataProducer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataProducer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataProducer",  "AVFoundation")]
			public static NSString UserDataProducer {
				get {
					if (_UserDataProducer is null)
						_UserDataProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataProducer")!;
					return _UserDataProducer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataProduct;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataProduct</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataProduct",  "AVFoundation")]
			public static NSString UserDataProduct {
				get {
					if (_UserDataProduct is null)
						_UserDataProduct = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataProduct")!;
					return _UserDataProduct;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataPublisher;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataPublisher</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataPublisher",  "AVFoundation")]
			public static NSString UserDataPublisher {
				get {
					if (_UserDataPublisher is null)
						_UserDataPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPublisher")!;
					return _UserDataPublisher;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataSoftware;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataSoftware</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataSoftware",  "AVFoundation")]
			public static NSString UserDataSoftware {
				get {
					if (_UserDataSoftware is null)
						_UserDataSoftware = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataSoftware")!;
					return _UserDataSoftware;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataSpecialPlaybackRequirements;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataSpecialPlaybackRequirements</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataSpecialPlaybackRequirements",  "AVFoundation")]
			public static NSString UserDataSpecialPlaybackRequirements {
				get {
					if (_UserDataSpecialPlaybackRequirements is null)
						_UserDataSpecialPlaybackRequirements = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataSpecialPlaybackRequirements")!;
					return _UserDataSpecialPlaybackRequirements;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataTaggedCharacteristic;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataTaggedCharacteristic</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataTaggedCharacteristic",  "AVFoundation")]
			public static NSString UserDataTaggedCharacteristic {
				get {
					if (_UserDataTaggedCharacteristic is null)
						_UserDataTaggedCharacteristic = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTaggedCharacteristic")!;
					return _UserDataTaggedCharacteristic;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataTrack;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataTrack</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataTrack",  "AVFoundation")]
			public static NSString UserDataTrack {
				get {
					if (_UserDataTrack is null)
						_UserDataTrack = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTrack")!;
					return _UserDataTrack;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataTrackName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataTrackName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataTrackName",  "AVFoundation")]
			public static NSString UserDataTrackName {
				get {
					if (_UserDataTrackName is null)
						_UserDataTrackName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTrackName")!;
					return _UserDataTrackName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataUrlLink;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataURLLink</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataURLLink",  "AVFoundation")]
			public static NSString UserDataUrlLink {
				get {
					if (_UserDataUrlLink is null)
						_UserDataUrlLink = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataURLLink")!;
					return _UserDataUrlLink;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataWarning;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataWarning</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataWarning",  "AVFoundation")]
			public static NSString UserDataWarning {
				get {
					if (_UserDataWarning is null)
						_UserDataWarning = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataWarning")!;
					return _UserDataWarning;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataWriter;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierQuickTimeUserDataWriter</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierQuickTimeUserDataWriter",  "AVFoundation")]
			public static NSString UserDataWriter {
				get {
					if (_UserDataWriter is null)
						_UserDataWriter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataWriter")!;
					return _UserDataWriter;
				}
			}
		} /* class QuickTime */
	}
}
