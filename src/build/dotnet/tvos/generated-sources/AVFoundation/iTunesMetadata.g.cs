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
namespace AVFoundation {
	/// <summary>Constants identifying iTunes metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class iTunesMetadata  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AccountKind;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAccountKind</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAccountKind",  "AVFoundation")]
			public static NSString AccountKind {
				get {
					if (_AccountKind is null)
						_AccountKind = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAccountKind")!;
					return _AccountKind;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Acknowledgement;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAcknowledgement</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAcknowledgement",  "AVFoundation")]
			public static NSString Acknowledgement {
				get {
					if (_Acknowledgement is null)
						_Acknowledgement = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAcknowledgement")!;
					return _Acknowledgement;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Album;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAlbum</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAlbum",  "AVFoundation")]
			public static NSString Album {
				get {
					if (_Album is null)
						_Album = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAlbum")!;
					return _Album;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AlbumArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAlbumArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAlbumArtist",  "AVFoundation")]
			public static NSString AlbumArtist {
				get {
					if (_AlbumArtist is null)
						_AlbumArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAlbumArtist")!;
					return _AlbumArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AppleID;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAppleID</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAppleID",  "AVFoundation")]
			public static NSString AppleID {
				get {
					if (_AppleID is null)
						_AppleID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAppleID")!;
					return _AppleID;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Arranger;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataArranger</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataArranger",  "AVFoundation")]
			public static NSString Arranger {
				get {
					if (_Arranger is null)
						_Arranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArranger")!;
					return _Arranger;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ArtDirector;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataArtDirector</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataArtDirector",  "AVFoundation")]
			public static NSString ArtDirector {
				get {
					if (_ArtDirector is null)
						_ArtDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtDirector")!;
					return _ArtDirector;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Artist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataArtist",  "AVFoundation")]
			public static NSString Artist {
				get {
					if (_Artist is null)
						_Artist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtist")!;
					return _Artist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ArtistID;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataArtistID</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataArtistID",  "AVFoundation")]
			public static NSString ArtistID {
				get {
					if (_ArtistID is null)
						_ArtistID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtistID")!;
					return _ArtistID;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Author;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataAuthor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataAuthor",  "AVFoundation")]
			public static NSString Author {
				get {
					if (_Author is null)
						_Author = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAuthor")!;
					return _Author;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _BeatsPerMin;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataBeatsPerMin</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataBeatsPerMin",  "AVFoundation")]
			public static NSString BeatsPerMin {
				get {
					if (_BeatsPerMin is null)
						_BeatsPerMin = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataBeatsPerMin")!;
					return _BeatsPerMin;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Composer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataComposer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataComposer",  "AVFoundation")]
			public static NSString Composer {
				get {
					if (_Composer is null)
						_Composer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataComposer")!;
					return _Composer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Conductor;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataConductor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataConductor",  "AVFoundation")]
			public static NSString Conductor {
				get {
					if (_Conductor is null)
						_Conductor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataConductor")!;
					return _Conductor;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ContentRating;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataContentRating</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataContentRating",  "AVFoundation")]
			public static NSString ContentRating {
				get {
					if (_ContentRating is null)
						_ContentRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataContentRating")!;
					return _ContentRating;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Copyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataCopyright",  "AVFoundation")]
			public static NSString Copyright {
				get {
					if (_Copyright is null)
						_Copyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCopyright")!;
					return _Copyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CoverArt;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataCoverArt</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataCoverArt",  "AVFoundation")]
			public static NSString CoverArt {
				get {
					if (_CoverArt is null)
						_CoverArt = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCoverArt")!;
					return _CoverArt;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Credits;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataCredits</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataCredits",  "AVFoundation")]
			public static NSString Credits {
				get {
					if (_Credits is null)
						_Credits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCredits")!;
					return _Credits;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Description;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataDescription",  "AVFoundation")]
			public static NSString Description {
				get {
					if (_Description is null)
						_Description = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDescription")!;
					return _Description;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Director;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataDirector</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataDirector",  "AVFoundation")]
			public static NSString Director {
				get {
					if (_Director is null)
						_Director = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDirector")!;
					return _Director;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DiscCompilation;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataDiscCompilation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataDiscCompilation",  "AVFoundation")]
			public static NSString DiscCompilation {
				get {
					if (_DiscCompilation is null)
						_DiscCompilation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDiscCompilation")!;
					return _DiscCompilation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _DiscNumber;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataDiscNumber</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataDiscNumber",  "AVFoundation")]
			public static NSString DiscNumber {
				get {
					if (_DiscNumber is null)
						_DiscNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDiscNumber")!;
					return _DiscNumber;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EQ;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataEQ</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataEQ",  "AVFoundation")]
			public static NSString EQ {
				get {
					if (_EQ is null)
						_EQ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEQ")!;
					return _EQ;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodedBy;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataEncodedBy</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataEncodedBy",  "AVFoundation")]
			public static NSString EncodedBy {
				get {
					if (_EncodedBy is null)
						_EncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEncodedBy")!;
					return _EncodedBy;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodingTool;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataEncodingTool</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataEncodingTool",  "AVFoundation")]
			public static NSString EncodingTool {
				get {
					if (_EncodingTool is null)
						_EncodingTool = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEncodingTool")!;
					return _EncodingTool;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ExecProducer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataExecProducer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataExecProducer",  "AVFoundation")]
			public static NSString ExecProducer {
				get {
					if (_ExecProducer is null)
						_ExecProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataExecProducer")!;
					return _ExecProducer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _GenreID;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataGenreID</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataGenreID",  "AVFoundation")]
			public static NSString GenreID {
				get {
					if (_GenreID is null)
						_GenreID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataGenreID")!;
					return _GenreID;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Grouping;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataGrouping</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataGrouping",  "AVFoundation")]
			public static NSString Grouping {
				get {
					if (_Grouping is null)
						_Grouping = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataGrouping")!;
					return _Grouping;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LinerNotes;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataLinerNotes</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataLinerNotes",  "AVFoundation")]
			public static NSString LinerNotes {
				get {
					if (_LinerNotes is null)
						_LinerNotes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataLinerNotes")!;
					return _LinerNotes;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Lyrics;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataLyrics</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataLyrics",  "AVFoundation")]
			public static NSString Lyrics {
				get {
					if (_Lyrics is null)
						_Lyrics = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataLyrics")!;
					return _Lyrics;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OnlineExtras;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataOnlineExtras</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataOnlineExtras",  "AVFoundation")]
			public static NSString OnlineExtras {
				get {
					if (_OnlineExtras is null)
						_OnlineExtras = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataOnlineExtras")!;
					return _OnlineExtras;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataOriginalArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataOriginalArtist",  "AVFoundation")]
			public static NSString OriginalArtist {
				get {
					if (_OriginalArtist is null)
						_OriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataOriginalArtist")!;
					return _OriginalArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Performer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataPerformer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataPerformer",  "AVFoundation")]
			public static NSString Performer {
				get {
					if (_Performer is null)
						_Performer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPerformer")!;
					return _Performer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PhonogramRights;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataPhonogramRights</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataPhonogramRights",  "AVFoundation")]
			public static NSString PhonogramRights {
				get {
					if (_PhonogramRights is null)
						_PhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPhonogramRights")!;
					return _PhonogramRights;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PlaylistID;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataPlaylistID</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataPlaylistID",  "AVFoundation")]
			public static NSString PlaylistID {
				get {
					if (_PlaylistID is null)
						_PlaylistID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPlaylistID")!;
					return _PlaylistID;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PredefinedGenre;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataPredefinedGenre</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataPredefinedGenre",  "AVFoundation")]
			public static NSString PredefinedGenre {
				get {
					if (_PredefinedGenre is null)
						_PredefinedGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPredefinedGenre")!;
					return _PredefinedGenre;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Producer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataProducer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataProducer",  "AVFoundation")]
			public static NSString Producer {
				get {
					if (_Producer is null)
						_Producer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataProducer")!;
					return _Producer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Publisher;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataPublisher</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataPublisher",  "AVFoundation")]
			public static NSString Publisher {
				get {
					if (_Publisher is null)
						_Publisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPublisher")!;
					return _Publisher;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RecordCompany;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataRecordCompany</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataRecordCompany",  "AVFoundation")]
			public static NSString RecordCompany {
				get {
					if (_RecordCompany is null)
						_RecordCompany = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataRecordCompany")!;
					return _RecordCompany;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ReleaseDate;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataReleaseDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataReleaseDate",  "AVFoundation")]
			public static NSString ReleaseDate {
				get {
					if (_ReleaseDate is null)
						_ReleaseDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataReleaseDate")!;
					return _ReleaseDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Soloist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataSoloist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataSoloist",  "AVFoundation")]
			public static NSString Soloist {
				get {
					if (_Soloist is null)
						_Soloist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSoloist")!;
					return _Soloist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SongID;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataSongID</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataSongID",  "AVFoundation")]
			public static NSString SongID {
				get {
					if (_SongID is null)
						_SongID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSongID")!;
					return _SongID;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SongName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataSongName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataSongName",  "AVFoundation")]
			public static NSString SongName {
				get {
					if (_SongName is null)
						_SongName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSongName")!;
					return _SongName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SoundEngineer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataSoundEngineer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataSoundEngineer",  "AVFoundation")]
			public static NSString SoundEngineer {
				get {
					if (_SoundEngineer is null)
						_SoundEngineer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSoundEngineer")!;
					return _SoundEngineer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Thanks;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataThanks</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataThanks",  "AVFoundation")]
			public static NSString Thanks {
				get {
					if (_Thanks is null)
						_Thanks = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataThanks")!;
					return _Thanks;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TrackNumber;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataTrackNumber</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataTrackNumber",  "AVFoundation")]
			public static NSString TrackNumber {
				get {
					if (_TrackNumber is null)
						_TrackNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataTrackNumber")!;
					return _TrackNumber;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TrackSubTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataTrackSubTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataTrackSubTitle",  "AVFoundation")]
			public static NSString TrackSubTitle {
				get {
					if (_TrackSubTitle is null)
						_TrackSubTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataTrackSubTitle")!;
					return _TrackSubTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserComment;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataUserComment</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataUserComment",  "AVFoundation")]
			public static NSString UserComment {
				get {
					if (_UserComment is null)
						_UserComment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataUserComment")!;
					return _UserComment;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserGenre;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifieriTunesMetadataUserGenre</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifieriTunesMetadataUserGenre",  "AVFoundation")]
			public static NSString UserGenre {
				get {
					if (_UserGenre is null)
						_UserGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataUserGenre")!;
					return _UserGenre;
				}
			}
		} /* class iTunesMetadata */
	}
}
