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
namespace CoreMedia {
	public partial class CMFormatDescriptionCleanAperture : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMFormatDescriptionCleanAperture" /> with default (empty) values.</summary>
		public CMFormatDescriptionCleanAperture () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMFormatDescriptionCleanAperture" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMFormatDescriptionCleanAperture (NSDictionary? dictionary) : base (dictionary) {}
		public float? Width {
			get {
				return  GetFloatValue (CMFormatDescriptionCleanApertureKeys.Width!);
			}
		}
		public float? Height {
			get {
				return  GetFloatValue (CMFormatDescriptionCleanApertureKeys.Height!);
			}
		}
		public float? HorizontalOffset {
			get {
				return  GetFloatValue (CMFormatDescriptionCleanApertureKeys.HorizontalOffset!);
			}
		}
		public float? VerticalOffset {
			get {
				return  GetFloatValue (CMFormatDescriptionCleanApertureKeys.VerticalOffset!);
			}
		}
		/// <remarks>Array of two numbers: numerator and denominator. Also set <see cref="P:CoreMedia.CMFormatDescriptionCleanAperture.Width" /> because not all modules read the rational value.</remarks>
		public NSNumber[]? WidthRational {
			get {
				return GetArray<NSNumber> (CMFormatDescriptionCleanApertureKeys.WidthRational!);
			}
		}
		/// <remarks>Array of two numbers: numerator and denominator. Also set <see cref="P:CoreMedia.CMFormatDescriptionCleanAperture.Height" /> because not all modules read the rational value.</remarks>
		public NSNumber[]? HeightRational {
			get {
				return GetArray<NSNumber> (CMFormatDescriptionCleanApertureKeys.HeightRational!);
			}
		}
		/// <remarks>Array of two numbers: numerator and denominator. Also set <see cref="P:CoreMedia.CMFormatDescriptionCleanAperture.HorizontalOffset" /> because not all modules read the rational value.</remarks>
		public NSNumber[]? HorizontalOffsetRational {
			get {
				return GetArray<NSNumber> (CMFormatDescriptionCleanApertureKeys.HorizontalOffsetRational!);
			}
		}
		/// <remarks>Array of two numbers: numerator and denominator. Also set <see cref="P:CoreMedia.CMFormatDescriptionCleanAperture.VerticalOffset" /> because not all modules read the rational value.</remarks>
		public NSNumber[]? VerticalOffsetRational {
			get {
				return GetArray<NSNumber> (CMFormatDescriptionCleanApertureKeys.VerticalOffsetRational!);
			}
		}
#endif
	}
}
