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
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public partial class AVAudioSequencerInfoDictionary : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVAudioSequencerInfoDictionary" /> with default (empty) values.</summary>
		public AVAudioSequencerInfoDictionary () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVAudioSequencerInfoDictionary" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVAudioSequencerInfoDictionary (NSDictionary? dictionary) : base (dictionary) {}
		public string? Album {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.AlbumKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.AlbumKey!, value);
			}
		}
		public double? ApproximateDurationInSeconds {
			get {
				return  GetDoubleValue (AVAudioSequencerInfoDictionaryKeys.ApproximateDurationInSecondsKey!);
			}
			set {
				SetNumberValue (AVAudioSequencerInfoDictionaryKeys.ApproximateDurationInSecondsKey!, value);
			}
		}
		public string? Artist {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.ArtistKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.ArtistKey!, value);
			}
		}
		public NSObject? ChannelLayout {
			get {
				return GetNativeValue<Foundation.NSObject> (AVAudioSequencerInfoDictionaryKeys.ChannelLayoutKey!);
			}
			set {
				SetNativeValue (AVAudioSequencerInfoDictionaryKeys.ChannelLayoutKey!, value);
			}
		}
		public string? Comments {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.CommentsKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.CommentsKey!, value);
			}
		}
		public string? Composer {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.ComposerKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.ComposerKey!, value);
			}
		}
		public string? Copyright {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.CopyrightKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.CopyrightKey!, value);
			}
		}
		public string? EncodingApplication {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.EncodingApplicationKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.EncodingApplicationKey!, value);
			}
		}
		public string? Genre {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.GenreKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.GenreKey!, value);
			}
		}
		public NSObject? Isrc {
			get {
				return GetNativeValue<Foundation.NSObject> (AVAudioSequencerInfoDictionaryKeys.IsrcKey!);
			}
			set {
				SetNativeValue (AVAudioSequencerInfoDictionaryKeys.IsrcKey!, value);
			}
		}
		public string? KeySignature {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.KeySignatureKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.KeySignatureKey!, value);
			}
		}
		public string? Lyricist {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.LyricistKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.LyricistKey!, value);
			}
		}
		public double? NominalBitRate {
			get {
				return  GetDoubleValue (AVAudioSequencerInfoDictionaryKeys.NominalBitRateKey!);
			}
			set {
				SetNumberValue (AVAudioSequencerInfoDictionaryKeys.NominalBitRateKey!, value);
			}
		}
		public NSObject? RecordedDate {
			get {
				return GetNativeValue<Foundation.NSObject> (AVAudioSequencerInfoDictionaryKeys.RecordedDateKey!);
			}
			set {
				SetNativeValue (AVAudioSequencerInfoDictionaryKeys.RecordedDateKey!, value);
			}
		}
		public double? SourceBitDepth {
			get {
				return  GetDoubleValue (AVAudioSequencerInfoDictionaryKeys.SourceBitDepthKey!);
			}
			set {
				SetNumberValue (AVAudioSequencerInfoDictionaryKeys.SourceBitDepthKey!, value);
			}
		}
		public string? SourceEncoder {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.SourceEncoderKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.SourceEncoderKey!, value);
			}
		}
		public string? SubTitle {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.SubTitleKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.SubTitleKey!, value);
			}
		}
		public double? Tempo {
			get {
				return  GetDoubleValue (AVAudioSequencerInfoDictionaryKeys.TempoKey!);
			}
			set {
				SetNumberValue (AVAudioSequencerInfoDictionaryKeys.TempoKey!, value);
			}
		}
		public string? TimeSignature {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.TimeSignatureKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.TimeSignatureKey!, value);
			}
		}
		public string? Title {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.TitleKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.TitleKey!, value);
			}
		}
		public int? TrackNumber {
			get {
				return  GetInt32Value (AVAudioSequencerInfoDictionaryKeys.TrackNumberKey!);
			}
			set {
				SetNumberValue (AVAudioSequencerInfoDictionaryKeys.TrackNumberKey!, value);
			}
		}
		public string? Year {
			get {
				return GetStringValue (AVAudioSequencerInfoDictionaryKeys.YearKey!);
			}
			set {
				SetStringValue (AVAudioSequencerInfoDictionaryKeys.YearKey!, value);
			}
		}
#endif
	}
}
