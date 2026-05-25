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
namespace VideoToolbox {
	/// <summary>Strongly typed set of options.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTMultiPassStorageCreationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTMultiPassStorageCreationOptions" /> with default (empty) values.</summary>
		public VTMultiPassStorageCreationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTMultiPassStorageCreationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTMultiPassStorageCreationOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? DoNotDelete {
			get {
				return  GetBoolValue (VTMultiPassStorageCreationOptionKeys.DoNotDelete!);
			}
			set {
				SetBooleanValue (VTMultiPassStorageCreationOptionKeys.DoNotDelete!, value);
			}
		}
#endif
	}
}
