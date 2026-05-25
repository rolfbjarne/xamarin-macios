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
namespace CoreVideo {
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public partial class CVImageBufferDisplayMaskRectangle : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CVImageBufferDisplayMaskRectangle" /> with default (empty) values.</summary>
		public CVImageBufferDisplayMaskRectangle () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CVImageBufferDisplayMaskRectangle" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CVImageBufferDisplayMaskRectangle (NSDictionary? dictionary) : base (dictionary) {}
		public ushort? ReferenceRasterWidth {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.ReferenceRasterWidthKey!);
			}
		}
		public ushort? ReferenceRasterHeight {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.ReferenceRasterHeightKey!);
			}
		}
		public ushort? RectangleLeft {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.RectangleLeftKey!);
			}
		}
		public ushort? RectangleWidth {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.RectangleWidthKey!);
			}
		}
		public ushort? RectangleTop {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.RectangleTopKey!);
			}
		}
		public ushort? RectangleHeight {
			get {
				return  GetUInt16Value (CVImageBufferDisplayMaskRectangleKeys.RectangleHeightKey!);
			}
		}
		public ushort[]? LeftEdgePoints {
			get {
				return GetArray<UInt16> (CVImageBufferDisplayMaskRectangleKeys.LeftEdgePointsKey!, (ptr) => (UInt16?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt16Value ?? default (UInt16));
			}
		}
		public ushort[]? RightEdgePoints {
			get {
				return GetArray<UInt16> (CVImageBufferDisplayMaskRectangleKeys.RightEdgePointsKey!, (ptr) => (UInt16?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt16Value ?? default (UInt16));
			}
		}
#endif
	}
}
