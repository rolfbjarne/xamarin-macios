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
namespace MediaPlayer {
	/// <summary>Properties of a <see cref="T:MediaPlayer.MPMediaPlaylist" />, such as name, attributes, and seed items.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MPMediaPlaylistProperty  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorDisplayName;
		/// <summary>Gets the display name for the author.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertyAuthorDisplayName",  "MediaPlayer")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuthorDisplayName {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuthorDisplayName is null)
					_AuthorDisplayName = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyAuthorDisplayName")!;
				return _AuthorDisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CloudGlobalId;
		/// <summary>Represents the value associated with the constant 'MPMediaPlaylistPropertyCloudGlobalID'.</summary>
		[Field ("MPMediaPlaylistPropertyCloudGlobalID",  "MediaPlayer")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CloudGlobalId {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CloudGlobalId is null)
					_CloudGlobalId = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyCloudGlobalID")!;
				return _CloudGlobalId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescriptionText;
		/// <summary>Gets the description text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertyDescriptionText",  "MediaPlayer")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString DescriptionText {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DescriptionText is null)
					_DescriptionText = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyDescriptionText")!;
				return _DescriptionText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyName</summary><value></value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertyName",  "MediaPlayer")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersistentID;
		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyPersistentID</summary><value></value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertyPersistentID",  "MediaPlayer")]
		public static NSString PersistentID {
			get {
				if (_PersistentID is null)
					_PersistentID = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyPersistentID")!;
				return _PersistentID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaylistAttributes;
		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyPlaylistAttributes</summary><value></value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertyPlaylistAttributes",  "MediaPlayer")]
		public static NSString PlaylistAttributes {
			get {
				if (_PlaylistAttributes is null)
					_PlaylistAttributes = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertyPlaylistAttributes")!;
				return _PlaylistAttributes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SeedItems;
		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertySeedItems</summary><value></value><remarks>To be added.</remarks>
		[Field ("MPMediaPlaylistPropertySeedItems",  "MediaPlayer")]
		public static NSString SeedItems {
			get {
				if (_SeedItems is null)
					_SeedItems = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaPlaylistPropertySeedItems")!;
				return _SeedItems;
			}
		}
	} /* class MPMediaPlaylistProperty */
}
