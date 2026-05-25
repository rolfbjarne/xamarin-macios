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
namespace CoreGraphics {
	/// <summary>Drawing mode.</summary><remarks><para>This enumeration allows the application developer to choose between showing the fill, stroke, or both of a path. Additionally, it allows the developer to choose whether to use the Core Graphics standing "non-zero winding rule" fill mode or the "even-odd rule" fill mode.</para><para>Both the "non-zero winding rule" and the "even-odd rule" decide whether to fill a pixel by considering a line drawn from the point to outside the path.</para><para>The “non-zero winding rule” mode does not fill the pixel if the path crosses that line clockwise and counterclockwise an equal number of times. If the count of clockwise versus counterclockwise crossings is non-zero, the point is considered inside the path and is filled. As the following illustration shows, this makes path direction an important consideration.</para><para><img href="~/xml/CoreGraphics/_images/CGPathDrawingMode.NonZeroWindingRule.png" alt="Graphic illustrating the non-zero winding rule" /></para><para>The “even-odd” rule fills a pixel if the number of paths crossed is odd. It does not take the direction of the path into account.</para><para><img href="~/xml/CoreGraphics/_images/CGPathDrawingMode.EvenOddRule.png" alt="Graphic illustrating the even-odd winding rule" /></para><para>The following example shows a more complex situation. The top path is drawn with the "even-odd rule" (<see cref="F:CoreGraphics.CGPathDrawingMode.EOFillStroke" />) while the bottom is filled with the "non-zero winding rule" (<see cref="F:CoreGraphics.CGPathDrawingMode.FillStroke" />). In both cases, the path is both stroked in red and filled in green.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public override void Draw (CGRect rect)
	/// {
	/// 	base.Draw (rect);
	/// 
	/// 	using (var ctxt = UIGraphics.GetCurrentContext ()) {
	/// 		ctxt.ScaleCTM (1, -1);
	/// 		ctxt.TranslateCTM (0, -Bounds.Height);
	/// 	DrawPathWithWindingMode (ctxt, Bounds.Height / 2, CGPathDrawingMode.EOFillStroke);
	/// 	  DrawPathWithWindingMode (ctxt, 0, CGPathDrawingMode.FillStroke);
	/// 		}
	/// }
	/// 
	/// void DrawPathWithWindingMode (CGContext ctxt, float yOffset, CGPathDrawingMode mode)
	/// {
	/// 	var points = new CGPoint[] {
	/// 		new CGPoint (50, 50),
	/// 		new CGPoint (200, 50),
	/// 		new CGPoint (200, 100),
	/// 		new CGPoint (50, 100),
	/// 		new CGPoint (50, 50),
	/// 		new CGPoint (150, 50),
	/// 		new CGPoint (150, 150),
	/// 		new CGPoint (100, 150),
	/// 		new CGPoint (100, 25)
	/// 	};
	/// 	points = points.Select (pt => new CGPoint(pt.X, pt.Y += yOffset)).ToArray();
	/// 	ctxt.SetStrokeColor (UIColor.Red.CGColor);
	/// 	ctxt.SetFillColor (UIColor.Green.CGColor);
	/// 	ctxt.MoveTo (points [0].X, points [0].Y);
	/// 	for (var i = 1; i < points.Length; i++) {
	/// 		ctxt.AddLineToPoint (points [i].X, points [i].Y);
	/// 	}
	/// 	ctxt.DrawPath (mode);
	/// }         
	/// ]]></code></example><para><img href="~/xml/CoreGraphics/_images/CGPathDrawingMode.NonZeroVsEvenOdd.png" alt="Graphic created by the previous code, illustrating the two different winding rules." /></para></remarks>
	public enum CGPathDrawingMode : int {
		/// <summary>Fills the path using the non-zero winding rule.</summary>
		Fill = 0,
		/// <summary>Fills the path using the even-odd rule.</summary>
		EOFill = 1,
		/// <summary>Strokes the path.</summary>
		Stroke = 2,
		/// <summary>Fills and strokes the path using the non-zero winding rule.</summary>
		FillStroke = 3,
		/// <summary>Fills and strokes the path using the even-odd rule.</summary>
		EOFillStroke = 4,
	}
}
