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
	/// <summary>Contains compression properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AVCompressionProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVCompressionProperties" /> with default (empty) values.</summary>
		public AVCompressionProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVCompressionProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVCompressionProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public AVCleanApertureProperties? CleanAperture {
			get {
				return GetStrongDictionary<AVCleanApertureProperties>(AVCompressionPropertiesKeys.CleanApertureKey!, (dict) => new AVCleanApertureProperties (dict));
			}
			set {
				SetNativeValue (AVCompressionPropertiesKeys.CleanApertureKey!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public AVPixelAspectRatioProperties? PixelAspectRatio {
			get {
				return GetStrongDictionary<AVPixelAspectRatioProperties>(AVCompressionPropertiesKeys.PixelAspectRatioKey!, (dict) => new AVPixelAspectRatioProperties (dict));
			}
			set {
				SetNativeValue (AVCompressionPropertiesKeys.PixelAspectRatioKey!, value?.Dictionary);
			}
		}
#endif
	}
}
