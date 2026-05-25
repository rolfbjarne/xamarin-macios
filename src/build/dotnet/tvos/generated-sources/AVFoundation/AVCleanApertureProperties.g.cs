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
	/// <summary>Contains clear aperture properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AVCleanApertureProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVCleanApertureProperties" /> with default (empty) values.</summary>
		public AVCleanApertureProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVCleanApertureProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVCleanApertureProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the width of the clean aperture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? Width {
			get {
				return Dictionary [AVCleanAperturePropertiesKeys.WidthKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCleanAperturePropertiesKeys.WidthKey!, value);
			}
		}
		/// <summary>Gets or sets the height of the clean aperture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? Height {
			get {
				return Dictionary [AVCleanAperturePropertiesKeys.HeightKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCleanAperturePropertiesKeys.HeightKey!, value);
			}
		}
		/// <summary>Gets or sets the horizontal offset of the clean aperture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? HorizontalOffset {
			get {
				return Dictionary [AVCleanAperturePropertiesKeys.HorizontalOffsetKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCleanAperturePropertiesKeys.HorizontalOffsetKey!, value);
			}
		}
		/// <summary>Gets or sets the vertical offset of the clean aperture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? VerticalOffset {
			get {
				return Dictionary [AVCleanAperturePropertiesKeys.VerticalOffsetKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AVCleanAperturePropertiesKeys.VerticalOffsetKey!, value);
			}
		}
#endif
	}
}
