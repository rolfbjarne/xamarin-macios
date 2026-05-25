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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class CHHapticAudioResourceDefinition : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CHHapticAudioResourceDefinition" /> with default (empty) values.</summary>
		public CHHapticAudioResourceDefinition () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CHHapticAudioResourceDefinition" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CHHapticAudioResourceDefinition (NSDictionary? dictionary) : base (dictionary) {}
		public bool? UseVolumeEnvelope {
			get {
				return  GetBoolValue (CHHapticAudioResourceKeys.UseVolumeEnvelopeKey!);
			}
			set {
				SetBooleanValue (CHHapticAudioResourceKeys.UseVolumeEnvelopeKey!, value);
			}
		}
		public bool? LoopEnabled {
			get {
				return  GetBoolValue (CHHapticAudioResourceKeys.LoopEnabledKey!);
			}
			set {
				SetBooleanValue (CHHapticAudioResourceKeys.LoopEnabledKey!, value);
			}
		}
#endif
	}
}
