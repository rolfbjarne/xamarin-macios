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
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	internal unsafe static partial class AVAudioSequencerInfoDictionaryKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyAlbum'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyAlbum",  "AVFoundation")]
		public static NSString AlbumKey {
			get {
				if (_AlbumKey is null)
					_AlbumKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyAlbum")!;
				return _AlbumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApproximateDurationInSecondsKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyApproximateDurationInSeconds'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyApproximateDurationInSeconds",  "AVFoundation")]
		public static NSString ApproximateDurationInSecondsKey {
			get {
				if (_ApproximateDurationInSecondsKey is null)
					_ApproximateDurationInSecondsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyApproximateDurationInSeconds")!;
				return _ApproximateDurationInSecondsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArtistKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyArtist'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyArtist",  "AVFoundation")]
		public static NSString ArtistKey {
			get {
				if (_ArtistKey is null)
					_ArtistKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyArtist")!;
				return _ArtistKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChannelLayoutKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyChannelLayout'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyChannelLayout",  "AVFoundation")]
		public static NSString ChannelLayoutKey {
			get {
				if (_ChannelLayoutKey is null)
					_ChannelLayoutKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyChannelLayout")!;
				return _ChannelLayoutKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommentsKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyComments'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyComments",  "AVFoundation")]
		public static NSString CommentsKey {
			get {
				if (_CommentsKey is null)
					_CommentsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyComments")!;
				return _CommentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComposerKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyComposer'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyComposer",  "AVFoundation")]
		public static NSString ComposerKey {
			get {
				if (_ComposerKey is null)
					_ComposerKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyComposer")!;
				return _ComposerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CopyrightKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyCopyright'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyCopyright",  "AVFoundation")]
		public static NSString CopyrightKey {
			get {
				if (_CopyrightKey is null)
					_CopyrightKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyCopyright")!;
				return _CopyrightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingApplicationKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyEncodingApplication'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyEncodingApplication",  "AVFoundation")]
		public static NSString EncodingApplicationKey {
			get {
				if (_EncodingApplicationKey is null)
					_EncodingApplicationKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyEncodingApplication")!;
				return _EncodingApplicationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenreKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyGenre'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyGenre",  "AVFoundation")]
		public static NSString GenreKey {
			get {
				if (_GenreKey is null)
					_GenreKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyGenre")!;
				return _GenreKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsrcKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyISRC'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyISRC",  "AVFoundation")]
		public static NSString IsrcKey {
			get {
				if (_IsrcKey is null)
					_IsrcKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyISRC")!;
				return _IsrcKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySignatureKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyKeySignature'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyKeySignature",  "AVFoundation")]
		public static NSString KeySignatureKey {
			get {
				if (_KeySignatureKey is null)
					_KeySignatureKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyKeySignature")!;
				return _KeySignatureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LyricistKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyLyricist'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyLyricist",  "AVFoundation")]
		public static NSString LyricistKey {
			get {
				if (_LyricistKey is null)
					_LyricistKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyLyricist")!;
				return _LyricistKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NominalBitRateKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyNominalBitRate'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyNominalBitRate",  "AVFoundation")]
		public static NSString NominalBitRateKey {
			get {
				if (_NominalBitRateKey is null)
					_NominalBitRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyNominalBitRate")!;
				return _NominalBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordedDateKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyRecordedDate'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyRecordedDate",  "AVFoundation")]
		public static NSString RecordedDateKey {
			get {
				if (_RecordedDateKey is null)
					_RecordedDateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyRecordedDate")!;
				return _RecordedDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceBitDepthKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeySourceBitDepth'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeySourceBitDepth",  "AVFoundation")]
		public static NSString SourceBitDepthKey {
			get {
				if (_SourceBitDepthKey is null)
					_SourceBitDepthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeySourceBitDepth")!;
				return _SourceBitDepthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceEncoderKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeySourceEncoder'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeySourceEncoder",  "AVFoundation")]
		public static NSString SourceEncoderKey {
			get {
				if (_SourceEncoderKey is null)
					_SourceEncoderKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeySourceEncoder")!;
				return _SourceEncoderKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubTitleKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeySubTitle'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeySubTitle",  "AVFoundation")]
		public static NSString SubTitleKey {
			get {
				if (_SubTitleKey is null)
					_SubTitleKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeySubTitle")!;
				return _SubTitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TempoKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyTempo'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyTempo",  "AVFoundation")]
		public static NSString TempoKey {
			get {
				if (_TempoKey is null)
					_TempoKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyTempo")!;
				return _TempoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeSignatureKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyTimeSignature'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyTimeSignature",  "AVFoundation")]
		public static NSString TimeSignatureKey {
			get {
				if (_TimeSignatureKey is null)
					_TimeSignatureKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyTimeSignature")!;
				return _TimeSignatureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyTitle'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyTitle",  "AVFoundation")]
		public static NSString TitleKey {
			get {
				if (_TitleKey is null)
					_TitleKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyTitle")!;
				return _TitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrackNumberKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyTrackNumber'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyTrackNumber",  "AVFoundation")]
		public static NSString TrackNumberKey {
			get {
				if (_TrackNumberKey is null)
					_TrackNumberKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyTrackNumber")!;
				return _TrackNumberKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YearKey;
		/// <summary>Represents the value associated with the constant 'AVAudioSequencerInfoDictionaryKeyYear'.</summary>
		[Field ("AVAudioSequencerInfoDictionaryKeyYear",  "AVFoundation")]
		public static NSString YearKey {
			get {
				if (_YearKey is null)
					_YearKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSequencerInfoDictionaryKeyYear")!;
				return _YearKey;
			}
		}
	} /* class AVAudioSequencerInfoDictionaryKeys */
}
