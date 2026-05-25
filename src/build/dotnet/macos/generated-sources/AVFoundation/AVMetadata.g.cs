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
namespace AVFoundation {
	/// <summary>A class whose static members define constants relating to metadata.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVMetadata  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyAccessibilityDescription;
		/// <summary>Represents the value associated with the constant 'AVMetadataCommonKeyAccessibilityDescription'.</summary>
		[Field ("AVMetadataCommonKeyAccessibilityDescription",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CommonKeyAccessibilityDescription {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CommonKeyAccessibilityDescription is null)
					_CommonKeyAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyAccessibilityDescription")!;
				return _CommonKeyAccessibilityDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyAlbumName;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyAlbumName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyAlbumName",  "AVFoundation")]
		public static NSString CommonKeyAlbumName {
			get {
				if (_CommonKeyAlbumName is null)
					_CommonKeyAlbumName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyAlbumName")!;
				return _CommonKeyAlbumName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyArtist;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyArtist",  "AVFoundation")]
		public static NSString CommonKeyArtist {
			get {
				if (_CommonKeyArtist is null)
					_CommonKeyArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyArtist")!;
				return _CommonKeyArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyArtwork;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyArtwork</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyArtwork",  "AVFoundation")]
		public static NSString CommonKeyArtwork {
			get {
				if (_CommonKeyArtwork is null)
					_CommonKeyArtwork = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyArtwork")!;
				return _CommonKeyArtwork;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyAuthor;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyAuthor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyAuthor",  "AVFoundation")]
		public static NSString CommonKeyAuthor {
			get {
				if (_CommonKeyAuthor is null)
					_CommonKeyAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyAuthor")!;
				return _CommonKeyAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyContributor;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyContributor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyContributor",  "AVFoundation")]
		public static NSString CommonKeyContributor {
			get {
				if (_CommonKeyContributor is null)
					_CommonKeyContributor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyContributor")!;
				return _CommonKeyContributor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyCopyrights;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyCopyrights</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyCopyrights",  "AVFoundation")]
		public static NSString CommonKeyCopyrights {
			get {
				if (_CommonKeyCopyrights is null)
					_CommonKeyCopyrights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCopyrights")!;
				return _CommonKeyCopyrights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyCreationDate;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyCreationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyCreationDate",  "AVFoundation")]
		public static NSString CommonKeyCreationDate {
			get {
				if (_CommonKeyCreationDate is null)
					_CommonKeyCreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCreationDate")!;
				return _CommonKeyCreationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyCreator;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyCreator</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyCreator",  "AVFoundation")]
		public static NSString CommonKeyCreator {
			get {
				if (_CommonKeyCreator is null)
					_CommonKeyCreator = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCreator")!;
				return _CommonKeyCreator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyDescription;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyDescription",  "AVFoundation")]
		public static NSString CommonKeyDescription {
			get {
				if (_CommonKeyDescription is null)
					_CommonKeyDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyDescription")!;
				return _CommonKeyDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyFormat;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyFormat</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyFormat",  "AVFoundation")]
		public static NSString CommonKeyFormat {
			get {
				if (_CommonKeyFormat is null)
					_CommonKeyFormat = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyFormat")!;
				return _CommonKeyFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyIdentifier;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyIdentifier",  "AVFoundation")]
		public static NSString CommonKeyIdentifier {
			get {
				if (_CommonKeyIdentifier is null)
					_CommonKeyIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyIdentifier")!;
				return _CommonKeyIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyLanguage;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyLanguage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyLanguage",  "AVFoundation")]
		public static NSString CommonKeyLanguage {
			get {
				if (_CommonKeyLanguage is null)
					_CommonKeyLanguage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLanguage")!;
				return _CommonKeyLanguage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyLastModifiedDate;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyLastModifiedDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyLastModifiedDate",  "AVFoundation")]
		public static NSString CommonKeyLastModifiedDate {
			get {
				if (_CommonKeyLastModifiedDate is null)
					_CommonKeyLastModifiedDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLastModifiedDate")!;
				return _CommonKeyLastModifiedDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyLocation;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyLocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyLocation",  "AVFoundation")]
		public static NSString CommonKeyLocation {
			get {
				if (_CommonKeyLocation is null)
					_CommonKeyLocation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLocation")!;
				return _CommonKeyLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyMake;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyMake</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyMake",  "AVFoundation")]
		public static NSString CommonKeyMake {
			get {
				if (_CommonKeyMake is null)
					_CommonKeyMake = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyMake")!;
				return _CommonKeyMake;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyModel;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyModel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyModel",  "AVFoundation")]
		public static NSString CommonKeyModel {
			get {
				if (_CommonKeyModel is null)
					_CommonKeyModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyModel")!;
				return _CommonKeyModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyPublisher;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyPublisher</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyPublisher",  "AVFoundation")]
		public static NSString CommonKeyPublisher {
			get {
				if (_CommonKeyPublisher is null)
					_CommonKeyPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyPublisher")!;
				return _CommonKeyPublisher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyRelation;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyRelation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyRelation",  "AVFoundation")]
		public static NSString CommonKeyRelation {
			get {
				if (_CommonKeyRelation is null)
					_CommonKeyRelation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyRelation")!;
				return _CommonKeyRelation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeySoftware;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeySoftware</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeySoftware",  "AVFoundation")]
		public static NSString CommonKeySoftware {
			get {
				if (_CommonKeySoftware is null)
					_CommonKeySoftware = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeySoftware")!;
				return _CommonKeySoftware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeySource;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeySource</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeySource",  "AVFoundation")]
		public static NSString CommonKeySource {
			get {
				if (_CommonKeySource is null)
					_CommonKeySource = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeySource")!;
				return _CommonKeySource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeySubject;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeySubject</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeySubject",  "AVFoundation")]
		public static NSString CommonKeySubject {
			get {
				if (_CommonKeySubject is null)
					_CommonKeySubject = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeySubject")!;
				return _CommonKeySubject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyTitle;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyTitle",  "AVFoundation")]
		public static NSString CommonKeyTitle {
			get {
				if (_CommonKeyTitle is null)
					_CommonKeyTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyTitle")!;
				return _CommonKeyTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommonKeyType;
		/// <summary>Represents the value associated with the constant AVMetadataCommonKeyType</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataCommonKeyType",  "AVFoundation")]
		public static NSString CommonKeyType {
			get {
				if (_CommonKeyType is null)
					_CommonKeyType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonKeyType")!;
				return _CommonKeyType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FormatQuickTimeMetadata;
		/// <summary>Represents the value associated with the constant AVMetadataFormatQuickTimeMetadata</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataFormatQuickTimeMetadata",  "AVFoundation")]
		public static NSString FormatQuickTimeMetadata {
			get {
				if (_FormatQuickTimeMetadata is null)
					_FormatQuickTimeMetadata = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataFormatQuickTimeMetadata")!;
				return _FormatQuickTimeMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyAlbumSortOrder;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyAlbumSortOrder</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyAlbumSortOrder",  "AVFoundation")]
		public static NSString ID3MetadataKeyAlbumSortOrder {
			get {
				if (_ID3MetadataKeyAlbumSortOrder is null)
					_ID3MetadataKeyAlbumSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAlbumSortOrder")!;
				return _ID3MetadataKeyAlbumSortOrder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyAlbumTitle;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyAlbumTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyAlbumTitle",  "AVFoundation")]
		public static NSString ID3MetadataKeyAlbumTitle {
			get {
				if (_ID3MetadataKeyAlbumTitle is null)
					_ID3MetadataKeyAlbumTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAlbumTitle")!;
				return _ID3MetadataKeyAlbumTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyAttachedPicture;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyAttachedPicture</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyAttachedPicture",  "AVFoundation")]
		public static NSString ID3MetadataKeyAttachedPicture {
			get {
				if (_ID3MetadataKeyAttachedPicture is null)
					_ID3MetadataKeyAttachedPicture = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAttachedPicture")!;
				return _ID3MetadataKeyAttachedPicture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyAudioEncryption;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyAudioEncryption</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyAudioEncryption",  "AVFoundation")]
		public static NSString ID3MetadataKeyAudioEncryption {
			get {
				if (_ID3MetadataKeyAudioEncryption is null)
					_ID3MetadataKeyAudioEncryption = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAudioEncryption")!;
				return _ID3MetadataKeyAudioEncryption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyAudioSeekPointIndex;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyAudioSeekPointIndex</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyAudioSeekPointIndex",  "AVFoundation")]
		public static NSString ID3MetadataKeyAudioSeekPointIndex {
			get {
				if (_ID3MetadataKeyAudioSeekPointIndex is null)
					_ID3MetadataKeyAudioSeekPointIndex = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAudioSeekPointIndex")!;
				return _ID3MetadataKeyAudioSeekPointIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyBand;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyBand</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyBand",  "AVFoundation")]
		public static NSString ID3MetadataKeyBand {
			get {
				if (_ID3MetadataKeyBand is null)
					_ID3MetadataKeyBand = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyBand")!;
				return _ID3MetadataKeyBand;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyBeatsPerMinute;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyBeatsPerMinute</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyBeatsPerMinute",  "AVFoundation")]
		public static NSString ID3MetadataKeyBeatsPerMinute {
			get {
				if (_ID3MetadataKeyBeatsPerMinute is null)
					_ID3MetadataKeyBeatsPerMinute = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyBeatsPerMinute")!;
				return _ID3MetadataKeyBeatsPerMinute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyComments;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyComments</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyComments",  "AVFoundation")]
		public static NSString ID3MetadataKeyComments {
			get {
				if (_ID3MetadataKeyComments is null)
					_ID3MetadataKeyComments = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyComments")!;
				return _ID3MetadataKeyComments;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyCommercial;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyCommercial",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ID3MetadataKeyCommercial {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ID3MetadataKeyCommercial is null)
					_ID3MetadataKeyCommercial = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCommercial")!;
				return _ID3MetadataKeyCommercial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyCommercialInformation;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyCommercialInformation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyCommercialInformation",  "AVFoundation")]
		public static NSString ID3MetadataKeyCommercialInformation {
			get {
				if (_ID3MetadataKeyCommercialInformation is null)
					_ID3MetadataKeyCommercialInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCommercialInformation")!;
				return _ID3MetadataKeyCommercialInformation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyCommerical;
		/// <summary>Developers should not use this deprecated property. </summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyCommerical",  "AVFoundation")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ID3MetadataKeyCommerical {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("tvos9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ID3MetadataKeyCommerical is null)
					_ID3MetadataKeyCommerical = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCommerical")!;
				return _ID3MetadataKeyCommerical;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyComposer;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyComposer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyComposer",  "AVFoundation")]
		public static NSString ID3MetadataKeyComposer {
			get {
				if (_ID3MetadataKeyComposer is null)
					_ID3MetadataKeyComposer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyComposer")!;
				return _ID3MetadataKeyComposer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyConductor;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyConductor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyConductor",  "AVFoundation")]
		public static NSString ID3MetadataKeyConductor {
			get {
				if (_ID3MetadataKeyConductor is null)
					_ID3MetadataKeyConductor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyConductor")!;
				return _ID3MetadataKeyConductor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyContentGroupDescription;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyContentGroupDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyContentGroupDescription",  "AVFoundation")]
		public static NSString ID3MetadataKeyContentGroupDescription {
			get {
				if (_ID3MetadataKeyContentGroupDescription is null)
					_ID3MetadataKeyContentGroupDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyContentGroupDescription")!;
				return _ID3MetadataKeyContentGroupDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyContentType;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyContentType</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyContentType",  "AVFoundation")]
		public static NSString ID3MetadataKeyContentType {
			get {
				if (_ID3MetadataKeyContentType is null)
					_ID3MetadataKeyContentType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyContentType")!;
				return _ID3MetadataKeyContentType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyCopyright",  "AVFoundation")]
		public static NSString ID3MetadataKeyCopyright {
			get {
				if (_ID3MetadataKeyCopyright is null)
					_ID3MetadataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCopyright")!;
				return _ID3MetadataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyCopyrightInformation;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyCopyrightInformation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyCopyrightInformation",  "AVFoundation")]
		public static NSString ID3MetadataKeyCopyrightInformation {
			get {
				if (_ID3MetadataKeyCopyrightInformation is null)
					_ID3MetadataKeyCopyrightInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCopyrightInformation")!;
				return _ID3MetadataKeyCopyrightInformation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyDate;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyDate",  "AVFoundation")]
		public static NSString ID3MetadataKeyDate {
			get {
				if (_ID3MetadataKeyDate is null)
					_ID3MetadataKeyDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyDate")!;
				return _ID3MetadataKeyDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEncodedBy;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEncodedBy</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEncodedBy",  "AVFoundation")]
		public static NSString ID3MetadataKeyEncodedBy {
			get {
				if (_ID3MetadataKeyEncodedBy is null)
					_ID3MetadataKeyEncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodedBy")!;
				return _ID3MetadataKeyEncodedBy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEncodedWith;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEncodedWith</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEncodedWith",  "AVFoundation")]
		public static NSString ID3MetadataKeyEncodedWith {
			get {
				if (_ID3MetadataKeyEncodedWith is null)
					_ID3MetadataKeyEncodedWith = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodedWith")!;
				return _ID3MetadataKeyEncodedWith;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEncodingTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEncodingTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEncodingTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyEncodingTime {
			get {
				if (_ID3MetadataKeyEncodingTime is null)
					_ID3MetadataKeyEncodingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodingTime")!;
				return _ID3MetadataKeyEncodingTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEncryption;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEncryption</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEncryption",  "AVFoundation")]
		public static NSString ID3MetadataKeyEncryption {
			get {
				if (_ID3MetadataKeyEncryption is null)
					_ID3MetadataKeyEncryption = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncryption")!;
				return _ID3MetadataKeyEncryption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEqualization;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEqualization</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEqualization",  "AVFoundation")]
		public static NSString ID3MetadataKeyEqualization {
			get {
				if (_ID3MetadataKeyEqualization is null)
					_ID3MetadataKeyEqualization = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEqualization")!;
				return _ID3MetadataKeyEqualization;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEqualization2;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEqualization2</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEqualization2",  "AVFoundation")]
		public static NSString ID3MetadataKeyEqualization2 {
			get {
				if (_ID3MetadataKeyEqualization2 is null)
					_ID3MetadataKeyEqualization2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEqualization2")!;
				return _ID3MetadataKeyEqualization2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyEventTimingCodes;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyEventTimingCodes</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyEventTimingCodes",  "AVFoundation")]
		public static NSString ID3MetadataKeyEventTimingCodes {
			get {
				if (_ID3MetadataKeyEventTimingCodes is null)
					_ID3MetadataKeyEventTimingCodes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEventTimingCodes")!;
				return _ID3MetadataKeyEventTimingCodes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyFileOwner;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyFileOwner</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyFileOwner",  "AVFoundation")]
		public static NSString ID3MetadataKeyFileOwner {
			get {
				if (_ID3MetadataKeyFileOwner is null)
					_ID3MetadataKeyFileOwner = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyFileOwner")!;
				return _ID3MetadataKeyFileOwner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyFileType;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyFileType</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyFileType",  "AVFoundation")]
		public static NSString ID3MetadataKeyFileType {
			get {
				if (_ID3MetadataKeyFileType is null)
					_ID3MetadataKeyFileType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyFileType")!;
				return _ID3MetadataKeyFileType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyGeneralEncapsulatedObject;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyGeneralEncapsulatedObject</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyGeneralEncapsulatedObject",  "AVFoundation")]
		public static NSString ID3MetadataKeyGeneralEncapsulatedObject {
			get {
				if (_ID3MetadataKeyGeneralEncapsulatedObject is null)
					_ID3MetadataKeyGeneralEncapsulatedObject = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyGeneralEncapsulatedObject")!;
				return _ID3MetadataKeyGeneralEncapsulatedObject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyGroupIdentifier;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyGroupIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyGroupIdentifier",  "AVFoundation")]
		public static NSString ID3MetadataKeyGroupIdentifier {
			get {
				if (_ID3MetadataKeyGroupIdentifier is null)
					_ID3MetadataKeyGroupIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyGroupIdentifier")!;
				return _ID3MetadataKeyGroupIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInitialKey;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyInitialKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInitialKey",  "AVFoundation")]
		public static NSString ID3MetadataKeyInitialKey {
			get {
				if (_ID3MetadataKeyInitialKey is null)
					_ID3MetadataKeyInitialKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInitialKey")!;
				return _ID3MetadataKeyInitialKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInternationalStandardRecordingCode;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyInternationalStandardRecordingCode</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInternationalStandardRecordingCode",  "AVFoundation")]
		public static NSString ID3MetadataKeyInternationalStandardRecordingCode {
			get {
				if (_ID3MetadataKeyInternationalStandardRecordingCode is null)
					_ID3MetadataKeyInternationalStandardRecordingCode = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternationalStandardRecordingCode")!;
				return _ID3MetadataKeyInternationalStandardRecordingCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInternetRadioStationName;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyInternetRadioStationName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInternetRadioStationName",  "AVFoundation")]
		public static NSString ID3MetadataKeyInternetRadioStationName {
			get {
				if (_ID3MetadataKeyInternetRadioStationName is null)
					_ID3MetadataKeyInternetRadioStationName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternetRadioStationName")!;
				return _ID3MetadataKeyInternetRadioStationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInternetRadioStationOwner;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyInternetRadioStationOwner</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInternetRadioStationOwner",  "AVFoundation")]
		public static NSString ID3MetadataKeyInternetRadioStationOwner {
			get {
				if (_ID3MetadataKeyInternetRadioStationOwner is null)
					_ID3MetadataKeyInternetRadioStationOwner = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternetRadioStationOwner")!;
				return _ID3MetadataKeyInternetRadioStationOwner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInvolvedPeopleList;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyInvolvedPeopleList_v23</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInvolvedPeopleList_v23",  "AVFoundation")]
		public static NSString ID3MetadataKeyInvolvedPeopleList {
			get {
				if (_ID3MetadataKeyInvolvedPeopleList is null)
					_ID3MetadataKeyInvolvedPeopleList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInvolvedPeopleList_v23")!;
				return _ID3MetadataKeyInvolvedPeopleList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyInvolvedPeopleList_v24;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyInvolvedPeopleList_v24",  "AVFoundation")]
		public static NSString ID3MetadataKeyInvolvedPeopleList_v24 {
			get {
				if (_ID3MetadataKeyInvolvedPeopleList_v24 is null)
					_ID3MetadataKeyInvolvedPeopleList_v24 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInvolvedPeopleList_v24")!;
				return _ID3MetadataKeyInvolvedPeopleList_v24;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyLanguage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyLanguage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyLanguage",  "AVFoundation")]
		public static NSString ID3MetadataKeyLanguage {
			get {
				if (_ID3MetadataKeyLanguage is null)
					_ID3MetadataKeyLanguage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLanguage")!;
				return _ID3MetadataKeyLanguage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyLeadPerformer;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyLeadPerformer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyLeadPerformer",  "AVFoundation")]
		public static NSString ID3MetadataKeyLeadPerformer {
			get {
				if (_ID3MetadataKeyLeadPerformer is null)
					_ID3MetadataKeyLeadPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLeadPerformer")!;
				return _ID3MetadataKeyLeadPerformer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyLength;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyLength</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyLength",  "AVFoundation")]
		public static NSString ID3MetadataKeyLength {
			get {
				if (_ID3MetadataKeyLength is null)
					_ID3MetadataKeyLength = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLength")!;
				return _ID3MetadataKeyLength;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyLink;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyLink</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyLink",  "AVFoundation")]
		public static NSString ID3MetadataKeyLink {
			get {
				if (_ID3MetadataKeyLink is null)
					_ID3MetadataKeyLink = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLink")!;
				return _ID3MetadataKeyLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyLyricist;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyLyricist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyLyricist",  "AVFoundation")]
		public static NSString ID3MetadataKeyLyricist {
			get {
				if (_ID3MetadataKeyLyricist is null)
					_ID3MetadataKeyLyricist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLyricist")!;
				return _ID3MetadataKeyLyricist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyMPEGLocationLookupTable;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyMPEGLocationLookupTable</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyMPEGLocationLookupTable",  "AVFoundation")]
		public static NSString ID3MetadataKeyMPEGLocationLookupTable {
			get {
				if (_ID3MetadataKeyMPEGLocationLookupTable is null)
					_ID3MetadataKeyMPEGLocationLookupTable = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMPEGLocationLookupTable")!;
				return _ID3MetadataKeyMPEGLocationLookupTable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyMediaType;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyMediaType</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyMediaType",  "AVFoundation")]
		public static NSString ID3MetadataKeyMediaType {
			get {
				if (_ID3MetadataKeyMediaType is null)
					_ID3MetadataKeyMediaType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMediaType")!;
				return _ID3MetadataKeyMediaType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyModifiedBy;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyModifiedBy</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyModifiedBy",  "AVFoundation")]
		public static NSString ID3MetadataKeyModifiedBy {
			get {
				if (_ID3MetadataKeyModifiedBy is null)
					_ID3MetadataKeyModifiedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyModifiedBy")!;
				return _ID3MetadataKeyModifiedBy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyMood;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyMood</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyMood",  "AVFoundation")]
		public static NSString ID3MetadataKeyMood {
			get {
				if (_ID3MetadataKeyMood is null)
					_ID3MetadataKeyMood = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMood")!;
				return _ID3MetadataKeyMood;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyMusicCDIdentifier;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyMusicCDIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyMusicCDIdentifier",  "AVFoundation")]
		public static NSString ID3MetadataKeyMusicCDIdentifier {
			get {
				if (_ID3MetadataKeyMusicCDIdentifier is null)
					_ID3MetadataKeyMusicCDIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMusicCDIdentifier")!;
				return _ID3MetadataKeyMusicCDIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyMusicianCreditsList;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyMusicianCreditsList</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyMusicianCreditsList",  "AVFoundation")]
		public static NSString ID3MetadataKeyMusicianCreditsList {
			get {
				if (_ID3MetadataKeyMusicianCreditsList is null)
					_ID3MetadataKeyMusicianCreditsList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMusicianCreditsList")!;
				return _ID3MetadataKeyMusicianCreditsList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOfficialArtistWebpage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOfficialArtistWebpage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOfficialArtistWebpage",  "AVFoundation")]
		public static NSString ID3MetadataKeyOfficialArtistWebpage {
			get {
				if (_ID3MetadataKeyOfficialArtistWebpage is null)
					_ID3MetadataKeyOfficialArtistWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialArtistWebpage")!;
				return _ID3MetadataKeyOfficialArtistWebpage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOfficialAudioFileWebpage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOfficialAudioFileWebpage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOfficialAudioFileWebpage",  "AVFoundation")]
		public static NSString ID3MetadataKeyOfficialAudioFileWebpage {
			get {
				if (_ID3MetadataKeyOfficialAudioFileWebpage is null)
					_ID3MetadataKeyOfficialAudioFileWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialAudioFileWebpage")!;
				return _ID3MetadataKeyOfficialAudioFileWebpage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOfficialAudioSourceWebpage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOfficialAudioSourceWebpage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOfficialAudioSourceWebpage",  "AVFoundation")]
		public static NSString ID3MetadataKeyOfficialAudioSourceWebpage {
			get {
				if (_ID3MetadataKeyOfficialAudioSourceWebpage is null)
					_ID3MetadataKeyOfficialAudioSourceWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialAudioSourceWebpage")!;
				return _ID3MetadataKeyOfficialAudioSourceWebpage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOfficialInternetRadioStationHomepage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOfficialInternetRadioStationHomepage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOfficialInternetRadioStationHomepage",  "AVFoundation")]
		public static NSString ID3MetadataKeyOfficialInternetRadioStationHomepage {
			get {
				if (_ID3MetadataKeyOfficialInternetRadioStationHomepage is null)
					_ID3MetadataKeyOfficialInternetRadioStationHomepage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialInternetRadioStationHomepage")!;
				return _ID3MetadataKeyOfficialInternetRadioStationHomepage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOfficialPublisherWebpage;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOfficialPublisherWebpage</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOfficialPublisherWebpage",  "AVFoundation")]
		public static NSString ID3MetadataKeyOfficialPublisherWebpage {
			get {
				if (_ID3MetadataKeyOfficialPublisherWebpage is null)
					_ID3MetadataKeyOfficialPublisherWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialPublisherWebpage")!;
				return _ID3MetadataKeyOfficialPublisherWebpage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalAlbumTitle;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalAlbumTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalAlbumTitle",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalAlbumTitle {
			get {
				if (_ID3MetadataKeyOriginalAlbumTitle is null)
					_ID3MetadataKeyOriginalAlbumTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalAlbumTitle")!;
				return _ID3MetadataKeyOriginalAlbumTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalArtist;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalArtist",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalArtist {
			get {
				if (_ID3MetadataKeyOriginalArtist is null)
					_ID3MetadataKeyOriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalArtist")!;
				return _ID3MetadataKeyOriginalArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalFilename;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalFilename</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalFilename",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalFilename {
			get {
				if (_ID3MetadataKeyOriginalFilename is null)
					_ID3MetadataKeyOriginalFilename = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalFilename")!;
				return _ID3MetadataKeyOriginalFilename;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalLyricist;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalLyricist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalLyricist",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalLyricist {
			get {
				if (_ID3MetadataKeyOriginalLyricist is null)
					_ID3MetadataKeyOriginalLyricist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalLyricist")!;
				return _ID3MetadataKeyOriginalLyricist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalReleaseTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalReleaseTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalReleaseTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalReleaseTime {
			get {
				if (_ID3MetadataKeyOriginalReleaseTime is null)
					_ID3MetadataKeyOriginalReleaseTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalReleaseTime")!;
				return _ID3MetadataKeyOriginalReleaseTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOriginalReleaseYear;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOriginalReleaseYear</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOriginalReleaseYear",  "AVFoundation")]
		public static NSString ID3MetadataKeyOriginalReleaseYear {
			get {
				if (_ID3MetadataKeyOriginalReleaseYear is null)
					_ID3MetadataKeyOriginalReleaseYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalReleaseYear")!;
				return _ID3MetadataKeyOriginalReleaseYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyOwnership;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyOwnership</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyOwnership",  "AVFoundation")]
		public static NSString ID3MetadataKeyOwnership {
			get {
				if (_ID3MetadataKeyOwnership is null)
					_ID3MetadataKeyOwnership = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOwnership")!;
				return _ID3MetadataKeyOwnership;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPartOfASet;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPartOfASet</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPartOfASet",  "AVFoundation")]
		public static NSString ID3MetadataKeyPartOfASet {
			get {
				if (_ID3MetadataKeyPartOfASet is null)
					_ID3MetadataKeyPartOfASet = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPartOfASet")!;
				return _ID3MetadataKeyPartOfASet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPayment;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPayment</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPayment",  "AVFoundation")]
		public static NSString ID3MetadataKeyPayment {
			get {
				if (_ID3MetadataKeyPayment is null)
					_ID3MetadataKeyPayment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPayment")!;
				return _ID3MetadataKeyPayment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPerformerSortOrder;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPerformerSortOrder</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPerformerSortOrder",  "AVFoundation")]
		public static NSString ID3MetadataKeyPerformerSortOrder {
			get {
				if (_ID3MetadataKeyPerformerSortOrder is null)
					_ID3MetadataKeyPerformerSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPerformerSortOrder")!;
				return _ID3MetadataKeyPerformerSortOrder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPlayCounter;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPlayCounter</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPlayCounter",  "AVFoundation")]
		public static NSString ID3MetadataKeyPlayCounter {
			get {
				if (_ID3MetadataKeyPlayCounter is null)
					_ID3MetadataKeyPlayCounter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPlayCounter")!;
				return _ID3MetadataKeyPlayCounter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPlaylistDelay;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPlaylistDelay</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPlaylistDelay",  "AVFoundation")]
		public static NSString ID3MetadataKeyPlaylistDelay {
			get {
				if (_ID3MetadataKeyPlaylistDelay is null)
					_ID3MetadataKeyPlaylistDelay = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPlaylistDelay")!;
				return _ID3MetadataKeyPlaylistDelay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPopularimeter;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPopularimeter</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPopularimeter",  "AVFoundation")]
		public static NSString ID3MetadataKeyPopularimeter {
			get {
				if (_ID3MetadataKeyPopularimeter is null)
					_ID3MetadataKeyPopularimeter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPopularimeter")!;
				return _ID3MetadataKeyPopularimeter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPositionSynchronization;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPositionSynchronization</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPositionSynchronization",  "AVFoundation")]
		public static NSString ID3MetadataKeyPositionSynchronization {
			get {
				if (_ID3MetadataKeyPositionSynchronization is null)
					_ID3MetadataKeyPositionSynchronization = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPositionSynchronization")!;
				return _ID3MetadataKeyPositionSynchronization;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPrivate;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPrivate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPrivate",  "AVFoundation")]
		public static NSString ID3MetadataKeyPrivate {
			get {
				if (_ID3MetadataKeyPrivate is null)
					_ID3MetadataKeyPrivate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPrivate")!;
				return _ID3MetadataKeyPrivate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyProducedNotice;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyProducedNotice</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyProducedNotice",  "AVFoundation")]
		public static NSString ID3MetadataKeyProducedNotice {
			get {
				if (_ID3MetadataKeyProducedNotice is null)
					_ID3MetadataKeyProducedNotice = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyProducedNotice")!;
				return _ID3MetadataKeyProducedNotice;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyPublisher;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyPublisher</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyPublisher",  "AVFoundation")]
		public static NSString ID3MetadataKeyPublisher {
			get {
				if (_ID3MetadataKeyPublisher is null)
					_ID3MetadataKeyPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPublisher")!;
				return _ID3MetadataKeyPublisher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyRecommendedBufferSize;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyRecommendedBufferSize</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyRecommendedBufferSize",  "AVFoundation")]
		public static NSString ID3MetadataKeyRecommendedBufferSize {
			get {
				if (_ID3MetadataKeyRecommendedBufferSize is null)
					_ID3MetadataKeyRecommendedBufferSize = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecommendedBufferSize")!;
				return _ID3MetadataKeyRecommendedBufferSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyRecordingDates;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyRecordingDates</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyRecordingDates",  "AVFoundation")]
		public static NSString ID3MetadataKeyRecordingDates {
			get {
				if (_ID3MetadataKeyRecordingDates is null)
					_ID3MetadataKeyRecordingDates = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecordingDates")!;
				return _ID3MetadataKeyRecordingDates;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyRecordingTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyRecordingTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyRecordingTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyRecordingTime {
			get {
				if (_ID3MetadataKeyRecordingTime is null)
					_ID3MetadataKeyRecordingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecordingTime")!;
				return _ID3MetadataKeyRecordingTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyRelativeVolumeAdjustment;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyRelativeVolumeAdjustment</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyRelativeVolumeAdjustment",  "AVFoundation")]
		public static NSString ID3MetadataKeyRelativeVolumeAdjustment {
			get {
				if (_ID3MetadataKeyRelativeVolumeAdjustment is null)
					_ID3MetadataKeyRelativeVolumeAdjustment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRelativeVolumeAdjustment")!;
				return _ID3MetadataKeyRelativeVolumeAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyRelativeVolumeAdjustment2;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyRelativeVolumeAdjustment2</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyRelativeVolumeAdjustment2",  "AVFoundation")]
		public static NSString ID3MetadataKeyRelativeVolumeAdjustment2 {
			get {
				if (_ID3MetadataKeyRelativeVolumeAdjustment2 is null)
					_ID3MetadataKeyRelativeVolumeAdjustment2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRelativeVolumeAdjustment2")!;
				return _ID3MetadataKeyRelativeVolumeAdjustment2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyReleaseTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyReleaseTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyReleaseTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyReleaseTime {
			get {
				if (_ID3MetadataKeyReleaseTime is null)
					_ID3MetadataKeyReleaseTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyReleaseTime")!;
				return _ID3MetadataKeyReleaseTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyReverb;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyReverb</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyReverb",  "AVFoundation")]
		public static NSString ID3MetadataKeyReverb {
			get {
				if (_ID3MetadataKeyReverb is null)
					_ID3MetadataKeyReverb = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyReverb")!;
				return _ID3MetadataKeyReverb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySeek;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySeek</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySeek",  "AVFoundation")]
		public static NSString ID3MetadataKeySeek {
			get {
				if (_ID3MetadataKeySeek is null)
					_ID3MetadataKeySeek = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySeek")!;
				return _ID3MetadataKeySeek;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySetSubtitle;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySetSubtitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySetSubtitle",  "AVFoundation")]
		public static NSString ID3MetadataKeySetSubtitle {
			get {
				if (_ID3MetadataKeySetSubtitle is null)
					_ID3MetadataKeySetSubtitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySetSubtitle")!;
				return _ID3MetadataKeySetSubtitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySignature;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySignature</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySignature",  "AVFoundation")]
		public static NSString ID3MetadataKeySignature {
			get {
				if (_ID3MetadataKeySignature is null)
					_ID3MetadataKeySignature = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySignature")!;
				return _ID3MetadataKeySignature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySize;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySize</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySize",  "AVFoundation")]
		public static NSString ID3MetadataKeySize {
			get {
				if (_ID3MetadataKeySize is null)
					_ID3MetadataKeySize = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySize")!;
				return _ID3MetadataKeySize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySubTitle;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySubTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySubTitle",  "AVFoundation")]
		public static NSString ID3MetadataKeySubTitle {
			get {
				if (_ID3MetadataKeySubTitle is null)
					_ID3MetadataKeySubTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySubTitle")!;
				return _ID3MetadataKeySubTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySynchronizedLyric;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySynchronizedLyric</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySynchronizedLyric",  "AVFoundation")]
		public static NSString ID3MetadataKeySynchronizedLyric {
			get {
				if (_ID3MetadataKeySynchronizedLyric is null)
					_ID3MetadataKeySynchronizedLyric = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySynchronizedLyric")!;
				return _ID3MetadataKeySynchronizedLyric;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeySynchronizedTempoCodes;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeySynchronizedTempoCodes</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeySynchronizedTempoCodes",  "AVFoundation")]
		public static NSString ID3MetadataKeySynchronizedTempoCodes {
			get {
				if (_ID3MetadataKeySynchronizedTempoCodes is null)
					_ID3MetadataKeySynchronizedTempoCodes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySynchronizedTempoCodes")!;
				return _ID3MetadataKeySynchronizedTempoCodes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTaggingTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTaggingTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTaggingTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyTaggingTime {
			get {
				if (_ID3MetadataKeyTaggingTime is null)
					_ID3MetadataKeyTaggingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTaggingTime")!;
				return _ID3MetadataKeyTaggingTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTermsOfUse;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTermsOfUse</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTermsOfUse",  "AVFoundation")]
		public static NSString ID3MetadataKeyTermsOfUse {
			get {
				if (_ID3MetadataKeyTermsOfUse is null)
					_ID3MetadataKeyTermsOfUse = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTermsOfUse")!;
				return _ID3MetadataKeyTermsOfUse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTime;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTime",  "AVFoundation")]
		public static NSString ID3MetadataKeyTime {
			get {
				if (_ID3MetadataKeyTime is null)
					_ID3MetadataKeyTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTime")!;
				return _ID3MetadataKeyTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTitleDescription;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTitleDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTitleDescription",  "AVFoundation")]
		public static NSString ID3MetadataKeyTitleDescription {
			get {
				if (_ID3MetadataKeyTitleDescription is null)
					_ID3MetadataKeyTitleDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTitleDescription")!;
				return _ID3MetadataKeyTitleDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTitleSortOrder;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTitleSortOrder</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTitleSortOrder",  "AVFoundation")]
		public static NSString ID3MetadataKeyTitleSortOrder {
			get {
				if (_ID3MetadataKeyTitleSortOrder is null)
					_ID3MetadataKeyTitleSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTitleSortOrder")!;
				return _ID3MetadataKeyTitleSortOrder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyTrackNumber;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyTrackNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyTrackNumber",  "AVFoundation")]
		public static NSString ID3MetadataKeyTrackNumber {
			get {
				if (_ID3MetadataKeyTrackNumber is null)
					_ID3MetadataKeyTrackNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTrackNumber")!;
				return _ID3MetadataKeyTrackNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyUniqueFileIdentifier;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyUniqueFileIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyUniqueFileIdentifier",  "AVFoundation")]
		public static NSString ID3MetadataKeyUniqueFileIdentifier {
			get {
				if (_ID3MetadataKeyUniqueFileIdentifier is null)
					_ID3MetadataKeyUniqueFileIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUniqueFileIdentifier")!;
				return _ID3MetadataKeyUniqueFileIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyUnsynchronizedLyric;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyUnsynchronizedLyric</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyUnsynchronizedLyric",  "AVFoundation")]
		public static NSString ID3MetadataKeyUnsynchronizedLyric {
			get {
				if (_ID3MetadataKeyUnsynchronizedLyric is null)
					_ID3MetadataKeyUnsynchronizedLyric = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUnsynchronizedLyric")!;
				return _ID3MetadataKeyUnsynchronizedLyric;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyUserText;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyUserText</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyUserText",  "AVFoundation")]
		public static NSString ID3MetadataKeyUserText {
			get {
				if (_ID3MetadataKeyUserText is null)
					_ID3MetadataKeyUserText = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUserText")!;
				return _ID3MetadataKeyUserText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyUserURL;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyUserURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyUserURL",  "AVFoundation")]
		public static NSString ID3MetadataKeyUserURL {
			get {
				if (_ID3MetadataKeyUserURL is null)
					_ID3MetadataKeyUserURL = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUserURL")!;
				return _ID3MetadataKeyUserURL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ID3MetadataKeyYear;
		/// <summary>Represents the value associated with the constant AVMetadataID3MetadataKeyYear</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataID3MetadataKeyYear",  "AVFoundation")]
		public static NSString ID3MetadataKeyYear {
			get {
				if (_ID3MetadataKeyYear is null)
					_ID3MetadataKeyYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyYear")!;
				return _ID3MetadataKeyYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ISOUserDataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadataISOUserDataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataISOUserDataKeyCopyright",  "AVFoundation")]
		public static NSString ISOUserDataKeyCopyright {
			get {
				if (_ISOUserDataKeyCopyright is null)
					_ISOUserDataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataISOUserDataKeyCopyright")!;
				return _ISOUserDataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IcyMetadataKeyStreamTitle;
		/// <summary>Represents the value associated with the constant AVMetadataIcyMetadataKeyStreamTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataIcyMetadataKeyStreamTitle",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IcyMetadataKeyStreamTitle {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IcyMetadataKeyStreamTitle is null)
					_IcyMetadataKeyStreamTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIcyMetadataKeyStreamTitle")!;
				return _IcyMetadataKeyStreamTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IcyMetadataKeyStreamUrl;
		/// <summary>Represents the value associated with the constant AVMetadataIcyMetadataKeyStreamURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataIcyMetadataKeyStreamURL",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IcyMetadataKeyStreamUrl {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IcyMetadataKeyStreamUrl is null)
					_IcyMetadataKeyStreamUrl = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIcyMetadataKeyStreamURL")!;
				return _IcyMetadataKeyStreamUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsoUserDataAccessibilityDescription;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierISOUserDataAccessibilityDescription'.</summary>
		[Field ("AVMetadataIdentifierISOUserDataAccessibilityDescription",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsoUserDataAccessibilityDescription {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsoUserDataAccessibilityDescription is null)
					_IsoUserDataAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataAccessibilityDescription")!;
				return _IsoUserDataAccessibilityDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsoUserDataKeyAccessibilityDescription;
		/// <summary>Represents the value associated with the constant 'AVMetadataISOUserDataKeyAccessibilityDescription'.</summary>
		[Field ("AVMetadataISOUserDataKeyAccessibilityDescription",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsoUserDataKeyAccessibilityDescription {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsoUserDataKeyAccessibilityDescription is null)
					_IsoUserDataKeyAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataISOUserDataKeyAccessibilityDescription")!;
				return _IsoUserDataKeyAccessibilityDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsoUserDataKeyDate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataISOUserDataKeyDate",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IsoUserDataKeyDate {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IsoUserDataKeyDate is null)
					_IsoUserDataKeyDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataISOUserDataKeyDate")!;
				return _IsoUserDataKeyDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsoUserDataKeyTaggedCharacteristic;
		/// <summary>Represents the value associated with the constant AVMetadataISOUserDataKeyTaggedCharacteristic</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataISOUserDataKeyTaggedCharacteristic",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IsoUserDataKeyTaggedCharacteristic {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IsoUserDataKeyTaggedCharacteristic is null)
					_IsoUserDataKeyTaggedCharacteristic = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataISOUserDataKeyTaggedCharacteristic")!;
				return _IsoUserDataKeyTaggedCharacteristic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyAlbumAndTrack;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyAlbumAndTrack</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyAlbumAndTrack",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyAlbumAndTrack {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyAlbumAndTrack is null)
					_K3GPUserDataKeyAlbumAndTrack = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyAlbumAndTrack")!;
				return _K3GPUserDataKeyAlbumAndTrack;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyAuthor;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyAuthor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyAuthor",  "AVFoundation")]
		public static NSString K3GPUserDataKeyAuthor {
			get {
				if (_K3GPUserDataKeyAuthor is null)
					_K3GPUserDataKeyAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyAuthor")!;
				return _K3GPUserDataKeyAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyCollection;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyCollection</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyCollection",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyCollection {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyCollection is null)
					_K3GPUserDataKeyCollection = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyCollection")!;
				return _K3GPUserDataKeyCollection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyCopyright",  "AVFoundation")]
		public static NSString K3GPUserDataKeyCopyright {
			get {
				if (_K3GPUserDataKeyCopyright is null)
					_K3GPUserDataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyCopyright")!;
				return _K3GPUserDataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyDescription;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyDescription",  "AVFoundation")]
		public static NSString K3GPUserDataKeyDescription {
			get {
				if (_K3GPUserDataKeyDescription is null)
					_K3GPUserDataKeyDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyDescription")!;
				return _K3GPUserDataKeyDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyGenre;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyGenre</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyGenre",  "AVFoundation")]
		public static NSString K3GPUserDataKeyGenre {
			get {
				if (_K3GPUserDataKeyGenre is null)
					_K3GPUserDataKeyGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyGenre")!;
				return _K3GPUserDataKeyGenre;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyKeywordList;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyKeywordList</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyKeywordList",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyKeywordList {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyKeywordList is null)
					_K3GPUserDataKeyKeywordList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyKeywordList")!;
				return _K3GPUserDataKeyKeywordList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyLocation;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyLocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyLocation",  "AVFoundation")]
		public static NSString K3GPUserDataKeyLocation {
			get {
				if (_K3GPUserDataKeyLocation is null)
					_K3GPUserDataKeyLocation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyLocation")!;
				return _K3GPUserDataKeyLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyMediaClassification;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyMediaClassification</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyMediaClassification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyMediaClassification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyMediaClassification is null)
					_K3GPUserDataKeyMediaClassification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyMediaClassification")!;
				return _K3GPUserDataKeyMediaClassification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyMediaRating;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyMediaRating</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyMediaRating",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyMediaRating {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyMediaRating is null)
					_K3GPUserDataKeyMediaRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyMediaRating")!;
				return _K3GPUserDataKeyMediaRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyPerformer;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyPerformer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyPerformer",  "AVFoundation")]
		public static NSString K3GPUserDataKeyPerformer {
			get {
				if (_K3GPUserDataKeyPerformer is null)
					_K3GPUserDataKeyPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyPerformer")!;
				return _K3GPUserDataKeyPerformer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyRecordingYear;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyRecordingYear</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyRecordingYear",  "AVFoundation")]
		public static NSString K3GPUserDataKeyRecordingYear {
			get {
				if (_K3GPUserDataKeyRecordingYear is null)
					_K3GPUserDataKeyRecordingYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyRecordingYear")!;
				return _K3GPUserDataKeyRecordingYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyThumbnail;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyThumbnail</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyThumbnail",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyThumbnail {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyThumbnail is null)
					_K3GPUserDataKeyThumbnail = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyThumbnail")!;
				return _K3GPUserDataKeyThumbnail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyTitle;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyTitle",  "AVFoundation")]
		public static NSString K3GPUserDataKeyTitle {
			get {
				if (_K3GPUserDataKeyTitle is null)
					_K3GPUserDataKeyTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyTitle")!;
				return _K3GPUserDataKeyTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _K3GPUserDataKeyUserRating;
		/// <summary>Represents the value associated with the constant AVMetadata3GPUserDataKeyUserRating</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadata3GPUserDataKeyUserRating",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString K3GPUserDataKeyUserRating {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_K3GPUserDataKeyUserRating is null)
					_K3GPUserDataKeyUserRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyUserRating")!;
				return _K3GPUserDataKeyUserRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KKeySpaceISOUserData;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceISOUserData</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceISOUserData",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString KKeySpaceISOUserData {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_KKeySpaceISOUserData is null)
					_KKeySpaceISOUserData = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceISOUserData")!;
				return _KKeySpaceISOUserData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceAudioFile;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceAudioFile",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString KeySpaceAudioFile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_KeySpaceAudioFile is null)
					_KeySpaceAudioFile = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceAudioFile")!;
				return _KeySpaceAudioFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceCommon;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceCommon</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceCommon",  "AVFoundation")]
		public static NSString KeySpaceCommon {
			get {
				if (_KeySpaceCommon is null)
					_KeySpaceCommon = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceCommon")!;
				return _KeySpaceCommon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceHlsDateRange;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceHslDateRange.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceHLSDateRange",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString KeySpaceHlsDateRange {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_KeySpaceHlsDateRange is null)
					_KeySpaceHlsDateRange = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceHLSDateRange")!;
				return _KeySpaceHlsDateRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceID3;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceID3</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceID3",  "AVFoundation")]
		public static NSString KeySpaceID3 {
			get {
				if (_KeySpaceID3 is null)
					_KeySpaceID3 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceID3")!;
				return _KeySpaceID3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceIcy;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceIcy</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceIcy",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString KeySpaceIcy {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_KeySpaceIcy is null)
					_KeySpaceIcy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceIcy")!;
				return _KeySpaceIcy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceQuickTimeMetadata;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceQuickTimeMetadata</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceQuickTimeMetadata",  "AVFoundation")]
		public static NSString KeySpaceQuickTimeMetadata {
			get {
				if (_KeySpaceQuickTimeMetadata is null)
					_KeySpaceQuickTimeMetadata = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceQuickTimeMetadata")!;
				return _KeySpaceQuickTimeMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceQuickTimeUserData;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceQuickTimeUserData</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceQuickTimeUserData",  "AVFoundation")]
		public static NSString KeySpaceQuickTimeUserData {
			get {
				if (_KeySpaceQuickTimeUserData is null)
					_KeySpaceQuickTimeUserData = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceQuickTimeUserData")!;
				return _KeySpaceQuickTimeUserData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySpaceiTunes;
		/// <summary>Represents the value associated with the constant AVMetadataKeySpaceiTunes</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataKeySpaceiTunes",  "AVFoundation")]
		public static NSString KeySpaceiTunes {
			get {
				if (_KeySpaceiTunes is null)
					_KeySpaceiTunes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataKeySpaceiTunes")!;
				return _KeySpaceiTunes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataAimeData;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataAIMEData'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataAIMEData",  "AVFoundation")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos26.0")]
		public static NSString QuickTimeMetadataAimeData {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos26.0")]
			get {
				if (_QuickTimeMetadataAimeData is null)
					_QuickTimeMetadataAimeData = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAIMEData")!;
				return _QuickTimeMetadataAimeData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraFocalLength35mmEquivalent;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraFocalLength35mmEquivalent'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraFocalLength35mmEquivalent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraFocalLength35mmEquivalent {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraFocalLength35mmEquivalent is null)
					_QuickTimeMetadataCameraFocalLength35mmEquivalent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraFocalLength35mmEquivalent")!;
				return _QuickTimeMetadataCameraFocalLength35mmEquivalent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraIsoSensitivity;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraISOSensitivity'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraISOSensitivity",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraIsoSensitivity {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraIsoSensitivity is null)
					_QuickTimeMetadataCameraIsoSensitivity = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraISOSensitivity")!;
				return _QuickTimeMetadataCameraIsoSensitivity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraLensIrisFNumber;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraLensIrisFNumber'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraLensIrisFNumber",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraLensIrisFNumber {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraLensIrisFNumber is null)
					_QuickTimeMetadataCameraLensIrisFNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraLensIrisFNumber")!;
				return _QuickTimeMetadataCameraLensIrisFNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraLensModel;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraLensModel'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraLensModel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraLensModel {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraLensModel is null)
					_QuickTimeMetadataCameraLensModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraLensModel")!;
				return _QuickTimeMetadataCameraLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraShutterSpeedAngle;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedAngle'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedAngle",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraShutterSpeedAngle {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraShutterSpeedAngle is null)
					_QuickTimeMetadataCameraShutterSpeedAngle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedAngle")!;
				return _QuickTimeMetadataCameraShutterSpeedAngle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraShutterSpeedTime;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedTime'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedTime",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraShutterSpeedTime {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraShutterSpeedTime is null)
					_QuickTimeMetadataCameraShutterSpeedTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraShutterSpeedTime")!;
				return _QuickTimeMetadataCameraShutterSpeedTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCameraWhiteBalance;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCameraWhiteBalance'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCameraWhiteBalance",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCameraWhiteBalance {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCameraWhiteBalance is null)
					_QuickTimeMetadataCameraWhiteBalance = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraWhiteBalance")!;
				return _QuickTimeMetadataCameraWhiteBalance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataCinematicVideoIntent;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataCinematicVideoIntent'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataCinematicVideoIntent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataCinematicVideoIntent {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataCinematicVideoIntent is null)
					_QuickTimeMetadataCinematicVideoIntent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCinematicVideoIntent")!;
				return _QuickTimeMetadataCinematicVideoIntent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataFullFrameRatePlaybackIntent;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataFullFrameRatePlaybackIntent'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataFullFrameRatePlaybackIntent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public static NSString QuickTimeMetadataFullFrameRatePlaybackIntent {
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			get {
				if (_QuickTimeMetadataFullFrameRatePlaybackIntent is null)
					_QuickTimeMetadataFullFrameRatePlaybackIntent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataFullFrameRatePlaybackIntent")!;
				return _QuickTimeMetadataFullFrameRatePlaybackIntent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataIsMontage;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataIsMontage'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataIsMontage",  "AVFoundation")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString QuickTimeMetadataIsMontage {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QuickTimeMetadataIsMontage is null)
					_QuickTimeMetadataIsMontage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataIsMontage")!;
				return _QuickTimeMetadataIsMontage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyAccessibilityDescription;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyAccessibilityDescription'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyAccessibilityDescription",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString QuickTimeMetadataKeyAccessibilityDescription {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QuickTimeMetadataKeyAccessibilityDescription is null)
					_QuickTimeMetadataKeyAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyAccessibilityDescription")!;
				return _QuickTimeMetadataKeyAccessibilityDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyAlbum;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyAlbum</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyAlbum",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyAlbum {
			get {
				if (_QuickTimeMetadataKeyAlbum is null)
					_QuickTimeMetadataKeyAlbum = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyAlbum")!;
				return _QuickTimeMetadataKeyAlbum;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyArranger;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyArranger</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyArranger",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyArranger {
			get {
				if (_QuickTimeMetadataKeyArranger is null)
					_QuickTimeMetadataKeyArranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArranger")!;
				return _QuickTimeMetadataKeyArranger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyArtist;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyArtist",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyArtist {
			get {
				if (_QuickTimeMetadataKeyArtist is null)
					_QuickTimeMetadataKeyArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArtist")!;
				return _QuickTimeMetadataKeyArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyArtwork;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyArtwork</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyArtwork",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyArtwork {
			get {
				if (_QuickTimeMetadataKeyArtwork is null)
					_QuickTimeMetadataKeyArtwork = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArtwork")!;
				return _QuickTimeMetadataKeyArtwork;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyAuthor;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyAuthor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyAuthor",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyAuthor {
			get {
				if (_QuickTimeMetadataKeyAuthor is null)
					_QuickTimeMetadataKeyAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyAuthor")!;
				return _QuickTimeMetadataKeyAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraFocalLength35mmEquivalent;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraFocalLength35mmEquivalent'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraFocalLength35mmEquivalent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraFocalLength35mmEquivalent {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraFocalLength35mmEquivalent is null)
					_QuickTimeMetadataKeyCameraFocalLength35mmEquivalent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraFocalLength35mmEquivalent")!;
				return _QuickTimeMetadataKeyCameraFocalLength35mmEquivalent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraFrameReadoutTime;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCameraFrameReadoutTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraFrameReadoutTime",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCameraFrameReadoutTime {
			get {
				if (_QuickTimeMetadataKeyCameraFrameReadoutTime is null)
					_QuickTimeMetadataKeyCameraFrameReadoutTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraFrameReadoutTime")!;
				return _QuickTimeMetadataKeyCameraFrameReadoutTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraIdentifier;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCameraIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraIdentifier",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCameraIdentifier {
			get {
				if (_QuickTimeMetadataKeyCameraIdentifier is null)
					_QuickTimeMetadataKeyCameraIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraIdentifier")!;
				return _QuickTimeMetadataKeyCameraIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraIsoSensitivity;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraISOSensitivity'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraISOSensitivity",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraIsoSensitivity {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraIsoSensitivity is null)
					_QuickTimeMetadataKeyCameraIsoSensitivity = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraISOSensitivity")!;
				return _QuickTimeMetadataKeyCameraIsoSensitivity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraLensIrisFNumber;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraLensIrisFNumber'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraLensIrisFNumber",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraLensIrisFNumber {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraLensIrisFNumber is null)
					_QuickTimeMetadataKeyCameraLensIrisFNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraLensIrisFNumber")!;
				return _QuickTimeMetadataKeyCameraLensIrisFNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraLensModel;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraLensModel'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraLensModel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraLensModel {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraLensModel is null)
					_QuickTimeMetadataKeyCameraLensModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraLensModel")!;
				return _QuickTimeMetadataKeyCameraLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraShutterSpeedAngle;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraShutterSpeedAngle'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraShutterSpeedAngle",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraShutterSpeedAngle {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraShutterSpeedAngle is null)
					_QuickTimeMetadataKeyCameraShutterSpeedAngle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraShutterSpeedAngle")!;
				return _QuickTimeMetadataKeyCameraShutterSpeedAngle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraShutterSpeedTime;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraShutterSpeedTime'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraShutterSpeedTime",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraShutterSpeedTime {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraShutterSpeedTime is null)
					_QuickTimeMetadataKeyCameraShutterSpeedTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraShutterSpeedTime")!;
				return _QuickTimeMetadataKeyCameraShutterSpeedTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCameraWhiteBalance;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCameraWhiteBalance'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCameraWhiteBalance",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCameraWhiteBalance {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCameraWhiteBalance is null)
					_QuickTimeMetadataKeyCameraWhiteBalance = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraWhiteBalance")!;
				return _QuickTimeMetadataKeyCameraWhiteBalance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCinematicVideoIntent;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyCinematicVideoIntent'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyCinematicVideoIntent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyCinematicVideoIntent {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyCinematicVideoIntent is null)
					_QuickTimeMetadataKeyCinematicVideoIntent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCinematicVideoIntent")!;
				return _QuickTimeMetadataKeyCinematicVideoIntent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCollectionUser;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCollectionUser</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCollectionUser",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCollectionUser {
			get {
				if (_QuickTimeMetadataKeyCollectionUser is null)
					_QuickTimeMetadataKeyCollectionUser = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCollectionUser")!;
				return _QuickTimeMetadataKeyCollectionUser;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyComment;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyComment</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyComment",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyComment {
			get {
				if (_QuickTimeMetadataKeyComment is null)
					_QuickTimeMetadataKeyComment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyComment")!;
				return _QuickTimeMetadataKeyComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyComposer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyComposer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyComposer",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyComposer {
			get {
				if (_QuickTimeMetadataKeyComposer is null)
					_QuickTimeMetadataKeyComposer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyComposer")!;
				return _QuickTimeMetadataKeyComposer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyContentIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyContentIdentifier",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString QuickTimeMetadataKeyContentIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_QuickTimeMetadataKeyContentIdentifier is null)
					_QuickTimeMetadataKeyContentIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyContentIdentifier")!;
				return _QuickTimeMetadataKeyContentIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCopyright",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCopyright {
			get {
				if (_QuickTimeMetadataKeyCopyright is null)
					_QuickTimeMetadataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCopyright")!;
				return _QuickTimeMetadataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCreationDate;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCreationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCreationDate",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCreationDate {
			get {
				if (_QuickTimeMetadataKeyCreationDate is null)
					_QuickTimeMetadataKeyCreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCreationDate")!;
				return _QuickTimeMetadataKeyCreationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyCredits;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyCredits</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyCredits",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyCredits {
			get {
				if (_QuickTimeMetadataKeyCredits is null)
					_QuickTimeMetadataKeyCredits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCredits")!;
				return _QuickTimeMetadataKeyCredits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyDescription;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyDescription",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyDescription {
			get {
				if (_QuickTimeMetadataKeyDescription is null)
					_QuickTimeMetadataKeyDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDescription")!;
				return _QuickTimeMetadataKeyDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyDirectionFacing;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyDirectionFacing</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyDirectionFacing",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyDirectionFacing {
			get {
				if (_QuickTimeMetadataKeyDirectionFacing is null)
					_QuickTimeMetadataKeyDirectionFacing = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirectionFacing")!;
				return _QuickTimeMetadataKeyDirectionFacing;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyDirectionMotion;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyDirectionMotion</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyDirectionMotion",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyDirectionMotion {
			get {
				if (_QuickTimeMetadataKeyDirectionMotion is null)
					_QuickTimeMetadataKeyDirectionMotion = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirectionMotion")!;
				return _QuickTimeMetadataKeyDirectionMotion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyDirector;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyDirector</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyDirector",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyDirector {
			get {
				if (_QuickTimeMetadataKeyDirector is null)
					_QuickTimeMetadataKeyDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirector")!;
				return _QuickTimeMetadataKeyDirector;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyDisplayName;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyDisplayName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyDisplayName",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyDisplayName {
			get {
				if (_QuickTimeMetadataKeyDisplayName is null)
					_QuickTimeMetadataKeyDisplayName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDisplayName")!;
				return _QuickTimeMetadataKeyDisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyEncodedBy;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyEncodedBy</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyEncodedBy",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyEncodedBy {
			get {
				if (_QuickTimeMetadataKeyEncodedBy is null)
					_QuickTimeMetadataKeyEncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyEncodedBy")!;
				return _QuickTimeMetadataKeyEncodedBy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyFullFrameRatePlaybackIntent;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyFullFrameRatePlaybackIntent'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyFullFrameRatePlaybackIntent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public static NSString QuickTimeMetadataKeyFullFrameRatePlaybackIntent {
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			get {
				if (_QuickTimeMetadataKeyFullFrameRatePlaybackIntent is null)
					_QuickTimeMetadataKeyFullFrameRatePlaybackIntent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyFullFrameRatePlaybackIntent")!;
				return _QuickTimeMetadataKeyFullFrameRatePlaybackIntent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyGenre;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyGenre</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyGenre",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyGenre {
			get {
				if (_QuickTimeMetadataKeyGenre is null)
					_QuickTimeMetadataKeyGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyGenre")!;
				return _QuickTimeMetadataKeyGenre;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyInformation;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyInformation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyInformation",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyInformation {
			get {
				if (_QuickTimeMetadataKeyInformation is null)
					_QuickTimeMetadataKeyInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyInformation")!;
				return _QuickTimeMetadataKeyInformation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyIsMontage;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyIsMontage'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyIsMontage",  "AVFoundation")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString QuickTimeMetadataKeyIsMontage {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QuickTimeMetadataKeyIsMontage is null)
					_QuickTimeMetadataKeyIsMontage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyIsMontage")!;
				return _QuickTimeMetadataKeyIsMontage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyKeywords;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyKeywords</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyKeywords",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyKeywords {
			get {
				if (_QuickTimeMetadataKeyKeywords is null)
					_QuickTimeMetadataKeyKeywords = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyKeywords")!;
				return _QuickTimeMetadataKeyKeywords;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationBody;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationBody</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationBody",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationBody {
			get {
				if (_QuickTimeMetadataKeyLocationBody is null)
					_QuickTimeMetadataKeyLocationBody = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationBody")!;
				return _QuickTimeMetadataKeyLocationBody;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationDate;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationDate",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationDate {
			get {
				if (_QuickTimeMetadataKeyLocationDate is null)
					_QuickTimeMetadataKeyLocationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationDate")!;
				return _QuickTimeMetadataKeyLocationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationISO6709;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationISO6709</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationISO6709",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationISO6709 {
			get {
				if (_QuickTimeMetadataKeyLocationISO6709 is null)
					_QuickTimeMetadataKeyLocationISO6709 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationISO6709")!;
				return _QuickTimeMetadataKeyLocationISO6709;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationName;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationName",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationName {
			get {
				if (_QuickTimeMetadataKeyLocationName is null)
					_QuickTimeMetadataKeyLocationName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationName")!;
				return _QuickTimeMetadataKeyLocationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationNote;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationNote</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationNote",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationNote {
			get {
				if (_QuickTimeMetadataKeyLocationNote is null)
					_QuickTimeMetadataKeyLocationNote = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationNote")!;
				return _QuickTimeMetadataKeyLocationNote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyLocationRole;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyLocationRole</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyLocationRole",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyLocationRole {
			get {
				if (_QuickTimeMetadataKeyLocationRole is null)
					_QuickTimeMetadataKeyLocationRole = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationRole")!;
				return _QuickTimeMetadataKeyLocationRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyMake;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyMake</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyMake",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyMake {
			get {
				if (_QuickTimeMetadataKeyMake is null)
					_QuickTimeMetadataKeyMake = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyMake")!;
				return _QuickTimeMetadataKeyMake;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyModel;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyModel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyModel",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyModel {
			get {
				if (_QuickTimeMetadataKeyModel is null)
					_QuickTimeMetadataKeyModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyModel")!;
				return _QuickTimeMetadataKeyModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyOriginalArtist;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyOriginalArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyOriginalArtist",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyOriginalArtist {
			get {
				if (_QuickTimeMetadataKeyOriginalArtist is null)
					_QuickTimeMetadataKeyOriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyOriginalArtist")!;
				return _QuickTimeMetadataKeyOriginalArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyPerformer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyPerformer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyPerformer",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyPerformer {
			get {
				if (_QuickTimeMetadataKeyPerformer is null)
					_QuickTimeMetadataKeyPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPerformer")!;
				return _QuickTimeMetadataKeyPerformer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyPhonogramRights;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyPhonogramRights</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyPhonogramRights",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyPhonogramRights {
			get {
				if (_QuickTimeMetadataKeyPhonogramRights is null)
					_QuickTimeMetadataKeyPhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPhonogramRights")!;
				return _QuickTimeMetadataKeyPhonogramRights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyProducer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyProducer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyProducer",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyProducer {
			get {
				if (_QuickTimeMetadataKeyProducer is null)
					_QuickTimeMetadataKeyProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyProducer")!;
				return _QuickTimeMetadataKeyProducer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyPublisher;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyPublisher</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyPublisher",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyPublisher {
			get {
				if (_QuickTimeMetadataKeyPublisher is null)
					_QuickTimeMetadataKeyPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPublisher")!;
				return _QuickTimeMetadataKeyPublisher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyRatingUser;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyRatingUser</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyRatingUser",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyRatingUser {
			get {
				if (_QuickTimeMetadataKeyRatingUser is null)
					_QuickTimeMetadataKeyRatingUser = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyRatingUser")!;
				return _QuickTimeMetadataKeyRatingUser;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeySoftware;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeySoftware</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeySoftware",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeySoftware {
			get {
				if (_QuickTimeMetadataKeySoftware is null)
					_QuickTimeMetadataKeySoftware = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeySoftware")!;
				return _QuickTimeMetadataKeySoftware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyTitle;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyTitle",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyTitle {
			get {
				if (_QuickTimeMetadataKeyTitle is null)
					_QuickTimeMetadataKeyTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyTitle")!;
				return _QuickTimeMetadataKeyTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyWhiteBalanceByCctColorMatrices;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTColorMatrices'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTColorMatrices",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyWhiteBalanceByCctColorMatrices {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyWhiteBalanceByCctColorMatrices is null)
					_QuickTimeMetadataKeyWhiteBalanceByCctColorMatrices = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTColorMatrices")!;
				return _QuickTimeMetadataKeyWhiteBalanceByCctColorMatrices;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyWhiteBalanceByCctWhiteBalanceFactors;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTWhiteBalanceFactors'.</summary>
		[Field ("AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTWhiteBalanceFactors",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataKeyWhiteBalanceByCctWhiteBalanceFactors {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataKeyWhiteBalanceByCctWhiteBalanceFactors is null)
					_QuickTimeMetadataKeyWhiteBalanceByCctWhiteBalanceFactors = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyWhiteBalanceByCCTWhiteBalanceFactors")!;
				return _QuickTimeMetadataKeyWhiteBalanceByCctWhiteBalanceFactors;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyYear;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyYear</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyYear",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyYear {
			get {
				if (_QuickTimeMetadataKeyYear is null)
					_QuickTimeMetadataKeyYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyYear")!;
				return _QuickTimeMetadataKeyYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataKeyiXML;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeMetadataKeyiXML</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeMetadataKeyiXML",  "AVFoundation")]
		public static NSString QuickTimeMetadataKeyiXML {
			get {
				if (_QuickTimeMetadataKeyiXML is null)
					_QuickTimeMetadataKeyiXML = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyiXML")!;
				return _QuickTimeMetadataKeyiXML;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataPresentationImmersiveMedia;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataPresentationImmersiveMedia'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataPresentationImmersiveMedia",  "AVFoundation")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos26.0")]
		public static NSString QuickTimeMetadataPresentationImmersiveMedia {
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos26.0")]
			get {
				if (_QuickTimeMetadataPresentationImmersiveMedia is null)
					_QuickTimeMetadataPresentationImmersiveMedia = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPresentationImmersiveMedia")!;
				return _QuickTimeMetadataPresentationImmersiveMedia;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataWhiteBalanceByCctColorMatrices;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTColorMatrices'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTColorMatrices",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataWhiteBalanceByCctColorMatrices {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataWhiteBalanceByCctColorMatrices is null)
					_QuickTimeMetadataWhiteBalanceByCctColorMatrices = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTColorMatrices")!;
				return _QuickTimeMetadataWhiteBalanceByCctColorMatrices;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMetadataWhiteBalanceByCctWhiteBalanceFactors;
		/// <summary>Represents the value associated with the constant 'AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTWhiteBalanceFactors'.</summary>
		[Field ("AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTWhiteBalanceFactors",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString QuickTimeMetadataWhiteBalanceByCctWhiteBalanceFactors {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_QuickTimeMetadataWhiteBalanceByCctWhiteBalanceFactors is null)
					_QuickTimeMetadataWhiteBalanceByCctWhiteBalanceFactors = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataWhiteBalanceByCCTWhiteBalanceFactors")!;
				return _QuickTimeMetadataWhiteBalanceByCctWhiteBalanceFactors;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyAccessibilityDescription;
		/// <summary>Represents the value associated with the constant 'AVMetadataQuickTimeUserDataKeyAccessibilityDescription'.</summary>
		[Field ("AVMetadataQuickTimeUserDataKeyAccessibilityDescription",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString QuickTimeUserDataKeyAccessibilityDescription {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QuickTimeUserDataKeyAccessibilityDescription is null)
					_QuickTimeUserDataKeyAccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyAccessibilityDescription")!;
				return _QuickTimeUserDataKeyAccessibilityDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyAlbum;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyAlbum</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyAlbum",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyAlbum {
			get {
				if (_QuickTimeUserDataKeyAlbum is null)
					_QuickTimeUserDataKeyAlbum = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyAlbum")!;
				return _QuickTimeUserDataKeyAlbum;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyArranger;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyArranger</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyArranger",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyArranger {
			get {
				if (_QuickTimeUserDataKeyArranger is null)
					_QuickTimeUserDataKeyArranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyArranger")!;
				return _QuickTimeUserDataKeyArranger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyArtist;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyArtist",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyArtist {
			get {
				if (_QuickTimeUserDataKeyArtist is null)
					_QuickTimeUserDataKeyArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyArtist")!;
				return _QuickTimeUserDataKeyArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyAuthor;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyAuthor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyAuthor",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyAuthor {
			get {
				if (_QuickTimeUserDataKeyAuthor is null)
					_QuickTimeUserDataKeyAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyAuthor")!;
				return _QuickTimeUserDataKeyAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyChapter;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyChapter</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyChapter",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyChapter {
			get {
				if (_QuickTimeUserDataKeyChapter is null)
					_QuickTimeUserDataKeyChapter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyChapter")!;
				return _QuickTimeUserDataKeyChapter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyComment;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyComment</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyComment",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyComment {
			get {
				if (_QuickTimeUserDataKeyComment is null)
					_QuickTimeUserDataKeyComment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyComment")!;
				return _QuickTimeUserDataKeyComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyComposer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyComposer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyComposer",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyComposer {
			get {
				if (_QuickTimeUserDataKeyComposer is null)
					_QuickTimeUserDataKeyComposer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyComposer")!;
				return _QuickTimeUserDataKeyComposer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyCopyright",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyCopyright {
			get {
				if (_QuickTimeUserDataKeyCopyright is null)
					_QuickTimeUserDataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCopyright")!;
				return _QuickTimeUserDataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyCreationDate;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyCreationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyCreationDate",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyCreationDate {
			get {
				if (_QuickTimeUserDataKeyCreationDate is null)
					_QuickTimeUserDataKeyCreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCreationDate")!;
				return _QuickTimeUserDataKeyCreationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyCredits;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyCredits</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyCredits",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyCredits {
			get {
				if (_QuickTimeUserDataKeyCredits is null)
					_QuickTimeUserDataKeyCredits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCredits")!;
				return _QuickTimeUserDataKeyCredits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyDescription;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyDescription",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyDescription {
			get {
				if (_QuickTimeUserDataKeyDescription is null)
					_QuickTimeUserDataKeyDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDescription")!;
				return _QuickTimeUserDataKeyDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyDirector;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyDirector</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyDirector",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyDirector {
			get {
				if (_QuickTimeUserDataKeyDirector is null)
					_QuickTimeUserDataKeyDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDirector")!;
				return _QuickTimeUserDataKeyDirector;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyDisclaimer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyDisclaimer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyDisclaimer",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyDisclaimer {
			get {
				if (_QuickTimeUserDataKeyDisclaimer is null)
					_QuickTimeUserDataKeyDisclaimer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDisclaimer")!;
				return _QuickTimeUserDataKeyDisclaimer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyEncodedBy;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyEncodedBy</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyEncodedBy",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyEncodedBy {
			get {
				if (_QuickTimeUserDataKeyEncodedBy is null)
					_QuickTimeUserDataKeyEncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyEncodedBy")!;
				return _QuickTimeUserDataKeyEncodedBy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyFullName;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyFullName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyFullName",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyFullName {
			get {
				if (_QuickTimeUserDataKeyFullName is null)
					_QuickTimeUserDataKeyFullName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyFullName")!;
				return _QuickTimeUserDataKeyFullName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyGenre;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyGenre</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyGenre",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyGenre {
			get {
				if (_QuickTimeUserDataKeyGenre is null)
					_QuickTimeUserDataKeyGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyGenre")!;
				return _QuickTimeUserDataKeyGenre;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyHostComputer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyHostComputer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyHostComputer",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyHostComputer {
			get {
				if (_QuickTimeUserDataKeyHostComputer is null)
					_QuickTimeUserDataKeyHostComputer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyHostComputer")!;
				return _QuickTimeUserDataKeyHostComputer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyInformation;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyInformation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyInformation",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyInformation {
			get {
				if (_QuickTimeUserDataKeyInformation is null)
					_QuickTimeUserDataKeyInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyInformation")!;
				return _QuickTimeUserDataKeyInformation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyKeywords;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyKeywords</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyKeywords",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyKeywords {
			get {
				if (_QuickTimeUserDataKeyKeywords is null)
					_QuickTimeUserDataKeyKeywords = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyKeywords")!;
				return _QuickTimeUserDataKeyKeywords;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyLocationISO6709;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyLocationISO6709</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyLocationISO6709",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyLocationISO6709 {
			get {
				if (_QuickTimeUserDataKeyLocationISO6709 is null)
					_QuickTimeUserDataKeyLocationISO6709 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyLocationISO6709")!;
				return _QuickTimeUserDataKeyLocationISO6709;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyMake;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyMake</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyMake",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyMake {
			get {
				if (_QuickTimeUserDataKeyMake is null)
					_QuickTimeUserDataKeyMake = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyMake")!;
				return _QuickTimeUserDataKeyMake;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyModel;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyModel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyModel",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyModel {
			get {
				if (_QuickTimeUserDataKeyModel is null)
					_QuickTimeUserDataKeyModel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyModel")!;
				return _QuickTimeUserDataKeyModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyOriginalArtist;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyOriginalArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyOriginalArtist",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyOriginalArtist {
			get {
				if (_QuickTimeUserDataKeyOriginalArtist is null)
					_QuickTimeUserDataKeyOriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalArtist")!;
				return _QuickTimeUserDataKeyOriginalArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyOriginalFormat;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyOriginalFormat</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyOriginalFormat",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyOriginalFormat {
			get {
				if (_QuickTimeUserDataKeyOriginalFormat is null)
					_QuickTimeUserDataKeyOriginalFormat = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalFormat")!;
				return _QuickTimeUserDataKeyOriginalFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyOriginalSource;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyOriginalSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyOriginalSource",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyOriginalSource {
			get {
				if (_QuickTimeUserDataKeyOriginalSource is null)
					_QuickTimeUserDataKeyOriginalSource = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalSource")!;
				return _QuickTimeUserDataKeyOriginalSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyPerformers;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyPerformers</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyPerformers",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyPerformers {
			get {
				if (_QuickTimeUserDataKeyPerformers is null)
					_QuickTimeUserDataKeyPerformers = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPerformers")!;
				return _QuickTimeUserDataKeyPerformers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyPhonogramRights;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyPhonogramRights</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyPhonogramRights",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyPhonogramRights {
			get {
				if (_QuickTimeUserDataKeyPhonogramRights is null)
					_QuickTimeUserDataKeyPhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPhonogramRights")!;
				return _QuickTimeUserDataKeyPhonogramRights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyProducer;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyProducer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyProducer",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyProducer {
			get {
				if (_QuickTimeUserDataKeyProducer is null)
					_QuickTimeUserDataKeyProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyProducer")!;
				return _QuickTimeUserDataKeyProducer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyProduct;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyProduct</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyProduct",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyProduct {
			get {
				if (_QuickTimeUserDataKeyProduct is null)
					_QuickTimeUserDataKeyProduct = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyProduct")!;
				return _QuickTimeUserDataKeyProduct;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyPublisher;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyPublisher</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyPublisher",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyPublisher {
			get {
				if (_QuickTimeUserDataKeyPublisher is null)
					_QuickTimeUserDataKeyPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPublisher")!;
				return _QuickTimeUserDataKeyPublisher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeySoftware;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeySoftware</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeySoftware",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeySoftware {
			get {
				if (_QuickTimeUserDataKeySoftware is null)
					_QuickTimeUserDataKeySoftware = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeySoftware")!;
				return _QuickTimeUserDataKeySoftware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeySpecialPlaybackRequirements;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeySpecialPlaybackRequirements</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeySpecialPlaybackRequirements",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeySpecialPlaybackRequirements {
			get {
				if (_QuickTimeUserDataKeySpecialPlaybackRequirements is null)
					_QuickTimeUserDataKeySpecialPlaybackRequirements = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeySpecialPlaybackRequirements")!;
				return _QuickTimeUserDataKeySpecialPlaybackRequirements;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyTaggedCharacteristic;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyTaggedCharacteristic</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyTaggedCharacteristic",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyTaggedCharacteristic {
			get {
				if (_QuickTimeUserDataKeyTaggedCharacteristic is null)
					_QuickTimeUserDataKeyTaggedCharacteristic = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTaggedCharacteristic")!;
				return _QuickTimeUserDataKeyTaggedCharacteristic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyTrack;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyTrack</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyTrack",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyTrack {
			get {
				if (_QuickTimeUserDataKeyTrack is null)
					_QuickTimeUserDataKeyTrack = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTrack")!;
				return _QuickTimeUserDataKeyTrack;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyTrackName;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyTrackName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyTrackName",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyTrackName {
			get {
				if (_QuickTimeUserDataKeyTrackName is null)
					_QuickTimeUserDataKeyTrackName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTrackName")!;
				return _QuickTimeUserDataKeyTrackName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyURLLink;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyURLLink</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyURLLink",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyURLLink {
			get {
				if (_QuickTimeUserDataKeyURLLink is null)
					_QuickTimeUserDataKeyURLLink = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyURLLink")!;
				return _QuickTimeUserDataKeyURLLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyWarning;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyWarning</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyWarning",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyWarning {
			get {
				if (_QuickTimeUserDataKeyWarning is null)
					_QuickTimeUserDataKeyWarning = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyWarning")!;
				return _QuickTimeUserDataKeyWarning;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeUserDataKeyWriter;
		/// <summary>Represents the value associated with the constant AVMetadataQuickTimeUserDataKeyWriter</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataQuickTimeUserDataKeyWriter",  "AVFoundation")]
		public static NSString QuickTimeUserDataKeyWriter {
			get {
				if (_QuickTimeUserDataKeyWriter is null)
					_QuickTimeUserDataKeyWriter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyWriter")!;
				return _QuickTimeUserDataKeyWriter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAccountKind;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAccountKind</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAccountKind",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAccountKind {
			get {
				if (_iTunesMetadataKeyAccountKind is null)
					_iTunesMetadataKeyAccountKind = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAccountKind")!;
				return _iTunesMetadataKeyAccountKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAcknowledgement;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAcknowledgement</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAcknowledgement",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAcknowledgement {
			get {
				if (_iTunesMetadataKeyAcknowledgement is null)
					_iTunesMetadataKeyAcknowledgement = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAcknowledgement")!;
				return _iTunesMetadataKeyAcknowledgement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAlbum;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAlbum</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAlbum",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAlbum {
			get {
				if (_iTunesMetadataKeyAlbum is null)
					_iTunesMetadataKeyAlbum = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAlbum")!;
				return _iTunesMetadataKeyAlbum;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAlbumArtist;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAlbumArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAlbumArtist",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAlbumArtist {
			get {
				if (_iTunesMetadataKeyAlbumArtist is null)
					_iTunesMetadataKeyAlbumArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAlbumArtist")!;
				return _iTunesMetadataKeyAlbumArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAppleID;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAppleID</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAppleID",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAppleID {
			get {
				if (_iTunesMetadataKeyAppleID is null)
					_iTunesMetadataKeyAppleID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAppleID")!;
				return _iTunesMetadataKeyAppleID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyArranger;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyArranger</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyArranger",  "AVFoundation")]
		public static NSString iTunesMetadataKeyArranger {
			get {
				if (_iTunesMetadataKeyArranger is null)
					_iTunesMetadataKeyArranger = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArranger")!;
				return _iTunesMetadataKeyArranger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyArtDirector;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyArtDirector</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyArtDirector",  "AVFoundation")]
		public static NSString iTunesMetadataKeyArtDirector {
			get {
				if (_iTunesMetadataKeyArtDirector is null)
					_iTunesMetadataKeyArtDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtDirector")!;
				return _iTunesMetadataKeyArtDirector;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyArtist;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyArtist",  "AVFoundation")]
		public static NSString iTunesMetadataKeyArtist {
			get {
				if (_iTunesMetadataKeyArtist is null)
					_iTunesMetadataKeyArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtist")!;
				return _iTunesMetadataKeyArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyArtistID;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyArtistID</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyArtistID",  "AVFoundation")]
		public static NSString iTunesMetadataKeyArtistID {
			get {
				if (_iTunesMetadataKeyArtistID is null)
					_iTunesMetadataKeyArtistID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtistID")!;
				return _iTunesMetadataKeyArtistID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyAuthor;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyAuthor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyAuthor",  "AVFoundation")]
		public static NSString iTunesMetadataKeyAuthor {
			get {
				if (_iTunesMetadataKeyAuthor is null)
					_iTunesMetadataKeyAuthor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAuthor")!;
				return _iTunesMetadataKeyAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyBeatsPerMin;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyBeatsPerMin</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyBeatsPerMin",  "AVFoundation")]
		public static NSString iTunesMetadataKeyBeatsPerMin {
			get {
				if (_iTunesMetadataKeyBeatsPerMin is null)
					_iTunesMetadataKeyBeatsPerMin = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyBeatsPerMin")!;
				return _iTunesMetadataKeyBeatsPerMin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyComposer;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyComposer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyComposer",  "AVFoundation")]
		public static NSString iTunesMetadataKeyComposer {
			get {
				if (_iTunesMetadataKeyComposer is null)
					_iTunesMetadataKeyComposer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyComposer")!;
				return _iTunesMetadataKeyComposer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyConductor;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyConductor</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyConductor",  "AVFoundation")]
		public static NSString iTunesMetadataKeyConductor {
			get {
				if (_iTunesMetadataKeyConductor is null)
					_iTunesMetadataKeyConductor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyConductor")!;
				return _iTunesMetadataKeyConductor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyContentRating;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyContentRating</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyContentRating",  "AVFoundation")]
		public static NSString iTunesMetadataKeyContentRating {
			get {
				if (_iTunesMetadataKeyContentRating is null)
					_iTunesMetadataKeyContentRating = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyContentRating")!;
				return _iTunesMetadataKeyContentRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyCopyright;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyCopyright</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyCopyright",  "AVFoundation")]
		public static NSString iTunesMetadataKeyCopyright {
			get {
				if (_iTunesMetadataKeyCopyright is null)
					_iTunesMetadataKeyCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCopyright")!;
				return _iTunesMetadataKeyCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyCoverArt;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyCoverArt</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyCoverArt",  "AVFoundation")]
		public static NSString iTunesMetadataKeyCoverArt {
			get {
				if (_iTunesMetadataKeyCoverArt is null)
					_iTunesMetadataKeyCoverArt = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCoverArt")!;
				return _iTunesMetadataKeyCoverArt;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyCredits;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyCredits</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyCredits",  "AVFoundation")]
		public static NSString iTunesMetadataKeyCredits {
			get {
				if (_iTunesMetadataKeyCredits is null)
					_iTunesMetadataKeyCredits = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCredits")!;
				return _iTunesMetadataKeyCredits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyDescription;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyDescription</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyDescription",  "AVFoundation")]
		public static NSString iTunesMetadataKeyDescription {
			get {
				if (_iTunesMetadataKeyDescription is null)
					_iTunesMetadataKeyDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDescription")!;
				return _iTunesMetadataKeyDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyDirector;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyDirector</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyDirector",  "AVFoundation")]
		public static NSString iTunesMetadataKeyDirector {
			get {
				if (_iTunesMetadataKeyDirector is null)
					_iTunesMetadataKeyDirector = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDirector")!;
				return _iTunesMetadataKeyDirector;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyDiscCompilation;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyDiscCompilation</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyDiscCompilation",  "AVFoundation")]
		public static NSString iTunesMetadataKeyDiscCompilation {
			get {
				if (_iTunesMetadataKeyDiscCompilation is null)
					_iTunesMetadataKeyDiscCompilation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDiscCompilation")!;
				return _iTunesMetadataKeyDiscCompilation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyDiscNumber;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyDiscNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyDiscNumber",  "AVFoundation")]
		public static NSString iTunesMetadataKeyDiscNumber {
			get {
				if (_iTunesMetadataKeyDiscNumber is null)
					_iTunesMetadataKeyDiscNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDiscNumber")!;
				return _iTunesMetadataKeyDiscNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyEQ;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyEQ</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyEQ",  "AVFoundation")]
		public static NSString iTunesMetadataKeyEQ {
			get {
				if (_iTunesMetadataKeyEQ is null)
					_iTunesMetadataKeyEQ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEQ")!;
				return _iTunesMetadataKeyEQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyEncodedBy;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyEncodedBy</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyEncodedBy",  "AVFoundation")]
		public static NSString iTunesMetadataKeyEncodedBy {
			get {
				if (_iTunesMetadataKeyEncodedBy is null)
					_iTunesMetadataKeyEncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEncodedBy")!;
				return _iTunesMetadataKeyEncodedBy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyEncodingTool;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyEncodingTool</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyEncodingTool",  "AVFoundation")]
		public static NSString iTunesMetadataKeyEncodingTool {
			get {
				if (_iTunesMetadataKeyEncodingTool is null)
					_iTunesMetadataKeyEncodingTool = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEncodingTool")!;
				return _iTunesMetadataKeyEncodingTool;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyExecProducer;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyExecProducer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyExecProducer",  "AVFoundation")]
		public static NSString iTunesMetadataKeyExecProducer {
			get {
				if (_iTunesMetadataKeyExecProducer is null)
					_iTunesMetadataKeyExecProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyExecProducer")!;
				return _iTunesMetadataKeyExecProducer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyGenreID;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyGenreID</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyGenreID",  "AVFoundation")]
		public static NSString iTunesMetadataKeyGenreID {
			get {
				if (_iTunesMetadataKeyGenreID is null)
					_iTunesMetadataKeyGenreID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyGenreID")!;
				return _iTunesMetadataKeyGenreID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyGrouping;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyGrouping</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyGrouping",  "AVFoundation")]
		public static NSString iTunesMetadataKeyGrouping {
			get {
				if (_iTunesMetadataKeyGrouping is null)
					_iTunesMetadataKeyGrouping = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyGrouping")!;
				return _iTunesMetadataKeyGrouping;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyLinerNotes;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyLinerNotes</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyLinerNotes",  "AVFoundation")]
		public static NSString iTunesMetadataKeyLinerNotes {
			get {
				if (_iTunesMetadataKeyLinerNotes is null)
					_iTunesMetadataKeyLinerNotes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyLinerNotes")!;
				return _iTunesMetadataKeyLinerNotes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyLyrics;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyLyrics</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyLyrics",  "AVFoundation")]
		public static NSString iTunesMetadataKeyLyrics {
			get {
				if (_iTunesMetadataKeyLyrics is null)
					_iTunesMetadataKeyLyrics = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyLyrics")!;
				return _iTunesMetadataKeyLyrics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyOnlineExtras;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyOnlineExtras</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyOnlineExtras",  "AVFoundation")]
		public static NSString iTunesMetadataKeyOnlineExtras {
			get {
				if (_iTunesMetadataKeyOnlineExtras is null)
					_iTunesMetadataKeyOnlineExtras = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyOnlineExtras")!;
				return _iTunesMetadataKeyOnlineExtras;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyOriginalArtist;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyOriginalArtist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyOriginalArtist",  "AVFoundation")]
		public static NSString iTunesMetadataKeyOriginalArtist {
			get {
				if (_iTunesMetadataKeyOriginalArtist is null)
					_iTunesMetadataKeyOriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyOriginalArtist")!;
				return _iTunesMetadataKeyOriginalArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyPerformer;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyPerformer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyPerformer",  "AVFoundation")]
		public static NSString iTunesMetadataKeyPerformer {
			get {
				if (_iTunesMetadataKeyPerformer is null)
					_iTunesMetadataKeyPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPerformer")!;
				return _iTunesMetadataKeyPerformer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyPhonogramRights;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyPhonogramRights</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyPhonogramRights",  "AVFoundation")]
		public static NSString iTunesMetadataKeyPhonogramRights {
			get {
				if (_iTunesMetadataKeyPhonogramRights is null)
					_iTunesMetadataKeyPhonogramRights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPhonogramRights")!;
				return _iTunesMetadataKeyPhonogramRights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyPlaylistID;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyPlaylistID</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyPlaylistID",  "AVFoundation")]
		public static NSString iTunesMetadataKeyPlaylistID {
			get {
				if (_iTunesMetadataKeyPlaylistID is null)
					_iTunesMetadataKeyPlaylistID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPlaylistID")!;
				return _iTunesMetadataKeyPlaylistID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyPredefinedGenre;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyPredefinedGenre</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyPredefinedGenre",  "AVFoundation")]
		public static NSString iTunesMetadataKeyPredefinedGenre {
			get {
				if (_iTunesMetadataKeyPredefinedGenre is null)
					_iTunesMetadataKeyPredefinedGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPredefinedGenre")!;
				return _iTunesMetadataKeyPredefinedGenre;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyProducer;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyProducer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyProducer",  "AVFoundation")]
		public static NSString iTunesMetadataKeyProducer {
			get {
				if (_iTunesMetadataKeyProducer is null)
					_iTunesMetadataKeyProducer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyProducer")!;
				return _iTunesMetadataKeyProducer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyPublisher;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyPublisher</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyPublisher",  "AVFoundation")]
		public static NSString iTunesMetadataKeyPublisher {
			get {
				if (_iTunesMetadataKeyPublisher is null)
					_iTunesMetadataKeyPublisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPublisher")!;
				return _iTunesMetadataKeyPublisher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyRecordCompany;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyRecordCompany</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyRecordCompany",  "AVFoundation")]
		public static NSString iTunesMetadataKeyRecordCompany {
			get {
				if (_iTunesMetadataKeyRecordCompany is null)
					_iTunesMetadataKeyRecordCompany = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyRecordCompany")!;
				return _iTunesMetadataKeyRecordCompany;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyReleaseDate;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyReleaseDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyReleaseDate",  "AVFoundation")]
		public static NSString iTunesMetadataKeyReleaseDate {
			get {
				if (_iTunesMetadataKeyReleaseDate is null)
					_iTunesMetadataKeyReleaseDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyReleaseDate")!;
				return _iTunesMetadataKeyReleaseDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeySoloist;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeySoloist</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeySoloist",  "AVFoundation")]
		public static NSString iTunesMetadataKeySoloist {
			get {
				if (_iTunesMetadataKeySoloist is null)
					_iTunesMetadataKeySoloist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySoloist")!;
				return _iTunesMetadataKeySoloist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeySongID;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeySongID</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeySongID",  "AVFoundation")]
		public static NSString iTunesMetadataKeySongID {
			get {
				if (_iTunesMetadataKeySongID is null)
					_iTunesMetadataKeySongID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySongID")!;
				return _iTunesMetadataKeySongID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeySongName;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeySongName</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeySongName",  "AVFoundation")]
		public static NSString iTunesMetadataKeySongName {
			get {
				if (_iTunesMetadataKeySongName is null)
					_iTunesMetadataKeySongName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySongName")!;
				return _iTunesMetadataKeySongName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeySoundEngineer;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeySoundEngineer</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeySoundEngineer",  "AVFoundation")]
		public static NSString iTunesMetadataKeySoundEngineer {
			get {
				if (_iTunesMetadataKeySoundEngineer is null)
					_iTunesMetadataKeySoundEngineer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySoundEngineer")!;
				return _iTunesMetadataKeySoundEngineer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyThanks;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyThanks</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyThanks",  "AVFoundation")]
		public static NSString iTunesMetadataKeyThanks {
			get {
				if (_iTunesMetadataKeyThanks is null)
					_iTunesMetadataKeyThanks = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyThanks")!;
				return _iTunesMetadataKeyThanks;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyTrackNumber;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyTrackNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyTrackNumber",  "AVFoundation")]
		public static NSString iTunesMetadataKeyTrackNumber {
			get {
				if (_iTunesMetadataKeyTrackNumber is null)
					_iTunesMetadataKeyTrackNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyTrackNumber")!;
				return _iTunesMetadataKeyTrackNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyTrackSubTitle;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyTrackSubTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyTrackSubTitle",  "AVFoundation")]
		public static NSString iTunesMetadataKeyTrackSubTitle {
			get {
				if (_iTunesMetadataKeyTrackSubTitle is null)
					_iTunesMetadataKeyTrackSubTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyTrackSubTitle")!;
				return _iTunesMetadataKeyTrackSubTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyUserComment;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyUserComment</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyUserComment",  "AVFoundation")]
		public static NSString iTunesMetadataKeyUserComment {
			get {
				if (_iTunesMetadataKeyUserComment is null)
					_iTunesMetadataKeyUserComment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyUserComment")!;
				return _iTunesMetadataKeyUserComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iTunesMetadataKeyUserGenre;
		/// <summary>Represents the value associated with the constant AVMetadataiTunesMetadataKeyUserGenre</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVMetadataiTunesMetadataKeyUserGenre",  "AVFoundation")]
		public static NSString iTunesMetadataKeyUserGenre {
			get {
				if (_iTunesMetadataKeyUserGenre is null)
					_iTunesMetadataKeyUserGenre = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyUserGenre")!;
				return _iTunesMetadataKeyUserGenre;
			}
		}
	} /* class AVMetadata */
}
