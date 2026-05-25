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
	/// <summary>Constants that provide the keys for <see cref="M:AVFoundation.AVAssetTrack.GetAssociatedTracks(Foundation.NSString)" /></summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAssetTrackTrackAssociation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetTrack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioFallback;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeAudioFallback</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeAudioFallback",  "AVFoundation")]
		public static NSString AudioFallback {
			get {
				if (_AudioFallback is null)
					_AudioFallback = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeAudioFallback")!;
				return _AudioFallback;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChapterList;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeChapterList</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeChapterList",  "AVFoundation")]
		public static NSString ChapterList {
			get {
				if (_ChapterList is null)
					_ChapterList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeChapterList")!;
				return _ChapterList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForcedSubtitlesOnly;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeForcedSubtitlesOnly</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeForcedSubtitlesOnly",  "AVFoundation")]
		public static NSString ForcedSubtitlesOnly {
			get {
				if (_ForcedSubtitlesOnly is null)
					_ForcedSubtitlesOnly = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeForcedSubtitlesOnly")!;
				return _ForcedSubtitlesOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetadataReferent;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeMetadataReferent</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeMetadataReferent",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MetadataReferent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MetadataReferent is null)
					_MetadataReferent = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeMetadataReferent")!;
				return _MetadataReferent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RenderMetadataSource;
		/// <summary>Represents the value associated with the constant 'AVTrackAssociationTypeRenderMetadataSource'.</summary>
		[Field ("AVTrackAssociationTypeRenderMetadataSource",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString RenderMetadataSource {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_RenderMetadataSource is null)
					_RenderMetadataSource = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeRenderMetadataSource")!;
				return _RenderMetadataSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionFollower;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeSelectionFollower</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeSelectionFollower",  "AVFoundation")]
		public static NSString SelectionFollower {
			get {
				if (_SelectionFollower is null)
					_SelectionFollower = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeSelectionFollower")!;
				return _SelectionFollower;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Timecode;
		/// <summary>Represents the value associated with the constant AVTrackAssociationTypeTimecode</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVTrackAssociationTypeTimecode",  "AVFoundation")]
		public static NSString Timecode {
			get {
				if (_Timecode is null)
					_Timecode = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVTrackAssociationTypeTimecode")!;
				return _Timecode;
			}
		}
	} /* class AVAssetTrackTrackAssociation */
}
