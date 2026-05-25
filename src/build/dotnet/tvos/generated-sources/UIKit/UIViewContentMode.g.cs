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
	/// <summary>An enumeration indicating how the cached bitmap of a view must be rendered when the view's bounds change.</summary><remarks><para>
	/// The contents of the <see cref="T:UIKit.UIView" /> are cached in a bitmap, the values in this enumeration determine what happens to a view when the bounds of that view change.   With these you can control whether the bitmap is stretched or whether the view is redrawn.
	/// </para><para>The following table shows the behavior as it works placing this {638, 475} image in a <see cref="T:UIKit.UIImageView" /> of size {280, 100}.</para><para><img href="~/xml/CoreImage/_images/flower.png" alt="Photograph of a sunflower." /></para><list type="table"><listheader><term>Value</term><description>Behavior</description><description /></listheader><item><term><see cref="F:UIKit.UIViewContentMode.Bottom" /></term><description>Aligns the content to the bottom of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.Bottom.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomLeft" /></term><description>Aligns the content to the bottom left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomLeft" /></term><description>Aligns the content to the bottom left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomLeft" /></term><description>Aligns the content to the bottom left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomLeft" /></term><description>Aligns the content to the bottom left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomLeft" /></term><description>Aligns the content to the bottom left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.BottomRight" /></term><description>Aligns the content to the bottom right of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.BottomRight.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.Center" /></term><description>Center the content in the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.Center.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.Left" /></term><description>Aligns the content to the left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.Left.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.Redraw" /></term><description>Forces a redraw when the <see cref="P:UIKit.UIView.Frame" /> of an object changes.</description><description></description></item><item><term><see cref="F:UIKit.UIViewContentMode.Right" /></term><description>Aligns the content to the right of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.Right.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.ScaleAspectFill" /></term><description>Scales the contents to fill the new bounaries of the view, while preserving the aspect ratio.   This means that the contents might be clipped.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.ScaleAspectFill.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.ScaleAspectFit" /></term><description>Scales the contents so that everything is visible, while preserving the aspect ratio.   Any areas that are not filled become transparent. (In the image, the <see cref="P:UIKit.UIView.BackgroundColor" /> property was set to black to emphasize the scaling behavior.)</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.ScaleAspectFit.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.ScaleToFill" /></term><description>Scales the contents to fit the new bounds, this might distort the contents.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.ScaleToFill.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.Top" /></term><description>Aligns the content to the top of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.Top.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.TopLeft" /></term><description>Aligns the content to the top left of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.TopLeft.png" alt="Image layout for the specified content mode" /></description></item><item><term><see cref="F:UIKit.UIViewContentMode.TopRight" /></term><description>Aligns the content to the top right of the view.</description><description><img href="~/xml/UIKit/_images/UIViewContentMode.TopRight.png" alt="Image layout for the specified content mode" /></description></item></list></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIViewContentMode : long {
		/// <summary>Scales the contents to fit the new bounds, this might distort the contents.</summary>
		ScaleToFill = 0,
		/// <summary>Scales the contents so that everything is visible, while preserving the aspect ration.   Any areas that are not filled become transparent.</summary>
		ScaleAspectFit = 1,
		/// <summary>Scales the contents to fill the new bounaries of the view, while preserving the aspect ratio.   This means that the contents might be clipped.</summary>
		ScaleAspectFill = 2,
		/// <summary>This forces a redraw when the <see cref="P:UIKit.UIView.Frame" /> of an object changes.</summary>
		Redraw = 3,
		/// <summary>Centers the contents in the view</summary>
		Center = 4,
		/// <summary>Aligns the content to the top of the view.</summary>
		Top = 5,
		/// <summary>Aligns the content to the bottom of the view.</summary>
		Bottom = 6,
		/// <summary>Aligns the content to the left of the view.</summary>
		Left = 7,
		/// <summary>Aligns the content to the right of the view..</summary>
		Right = 8,
		/// <summary>Aligns the content to the top left of the view.</summary>
		TopLeft = 9,
		/// <summary>Aligns the content to the top right of the view.</summary>
		TopRight = 10,
		/// <summary>Aligns the content to the bottom left of the view.</summary>
		BottomLeft = 11,
		/// <summary>Aligns the content to the bottom right side of the view.</summary>
		BottomRight = 12,
	}
}
