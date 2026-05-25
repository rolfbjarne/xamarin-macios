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
namespace Photos {
	/// <summary>Contains a playback option for use when processing or editing a Live Photo.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class PHLivePhotoEditingOption : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="PHLivePhotoEditingOption" /> with default (empty) values.</summary>
		public PHLivePhotoEditingOption () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="PHLivePhotoEditingOption" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public PHLivePhotoEditingOption (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets a Boolean value that tells whether rendering should happen at playback time.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ShouldRenderAtPlaybackTime {
			get {
				return  GetBoolValue (PHLivePhotoEditingOptionKeys.ShouldRenderAtPlaybackTimeKey!);
			}
		}
#endif
	}
}
