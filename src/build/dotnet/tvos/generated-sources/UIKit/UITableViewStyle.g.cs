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
namespace UIKit {
	/// <summary>The visual style for a <see cref="T:UIKit.UITableView" />. A table view's style can only be set when it is instantiated.</summary><remarks>Some table view features are only available for a specific style, for example Plain tables can provide an index to help scroll through long lists but Grouped tables should not.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewStyle : long {
		/// <summary>Cells in the plain style take the entire width of the table view - there is no rounded-rectangle grouping. Section headers and footers 'float' (stick to the top/bottom of the table view) as the user scrolls through the section. An index may be implemented to make scrolling through long lists faster.</summary>
		Plain = 0,
		/// <summary>Table style where each section is grouped into a rounded-rectangle. The table view's background can be see behind the rounded-rectangle groupings. Section headers and footers do not 'float' while scrolling.</summary>
		Grouped = 1,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		InsetGrouped = 2,
	}
}
