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
namespace VideoToolbox {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public partial class VTMotionEstimationSessionCreationOption : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTMotionEstimationSessionCreationOption" /> with default (empty) values.</summary>
		public VTMotionEstimationSessionCreationOption () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTMotionEstimationSessionCreationOption" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTMotionEstimationSessionCreationOption (NSDictionary? dictionary) : base (dictionary) {}
		public nint? MotionVectorSize {
			get {
				return  GetNIntValue (VTMotionEstimationSessionCreationOptionKey.MotionVectorSize!);
			}
			set {
				SetNumberValue (VTMotionEstimationSessionCreationOptionKey.MotionVectorSize!, value);
			}
		}
		public bool? UseMultiPassSearch {
			get {
				return  GetBoolValue (VTMotionEstimationSessionCreationOptionKey.UseMultiPassSearch!);
			}
			set {
				SetBooleanValue (VTMotionEstimationSessionCreationOptionKey.UseMultiPassSearch!, value);
			}
		}
		public string? Label {
			get {
				return GetStringValue (VTMotionEstimationSessionCreationOptionKey.Label!);
			}
			set {
				SetStringValue (VTMotionEstimationSessionCreationOptionKey.Label!, value);
			}
		}
#endif
	}
}
