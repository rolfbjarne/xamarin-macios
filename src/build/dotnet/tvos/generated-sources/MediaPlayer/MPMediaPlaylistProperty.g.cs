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
namespace MediaPlayer {
	/// <summary>Properties of a <see cref="T:MediaPlayer.MPMediaPlaylist" />, such as name, attributes, and seed items.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MPMediaPlaylistProperty  {
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
