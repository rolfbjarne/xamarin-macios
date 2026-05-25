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
namespace UIKit {
	/// <summary>Enumerates the ways in which a <see cref="T:UIKit.UIStackView" /> can arrange its subviews.</summary><remarks><list type="table"><listheader><term>Alignment</term><description>Description</description><description>Example Image</description></listheader><item><term><see cref="F:UIKit.UIStackViewAlignment.Bottom" /></term><description>Horizontal layout, bottom edges aligned to the bottom of the <see cref="T:UIKit.UIStackView" />. </description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Bottom.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.Center" /></term><description>Views are aligned along the <see cref="P:UIKit.UIStackView.Axis" />, in the center of the <see cref="T:UIKit.UIStackView" />.</description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Center.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.Fill" /></term><description>Views are arranged to fill available space perpendicular to the <see cref="P:UIKit.UIStackView.Axis" />.</description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Fill.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.FirstBaseline" /></term><description>
	/// Views are aligned based on the baseline of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Horizontal only.)
	/// </description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_FirstBaseline.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.LastBaseline" /></term><description>
	/// Views are aligned based on the baseline of the last <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Horizontal only.)
	/// </description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_LastBaseline.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.Leading" /></term><description>
	/// Views are aligned based on the leading edge of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Vertical only.)
	/// 
	/// </description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Leading.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.Top" /></term><description>Horizontal layout, top edges aligned to the top of the <see cref="T:UIKit.UIStackView" />. </description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Top.png" alt="Image showing the alignment layout." /></description></item><item><term><see cref="F:UIKit.UIStackViewAlignment.Trailing" /></term><description>Views are aligned based on the trailing edge of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Vertical only.)</description><description><img href="~/xml/UIKit/_images/UIKit.UIStackViewAlignment_Trailing.png" alt="Image showing the alignment layout." /></description></item></list></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIStackViewAlignment : long {
		/// <summary>Views are arranged to fill available space perpendicular to the <see cref="P:UIKit.UIStackView.Axis" />.</summary>
		Fill = 0,
		/// <summary>Views are aligned based on the leading edge of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Vertical only.)
		/// </summary>
		Leading = 1,
		/// <summary>Horizontal layout, top edges aligned to the top of the <see cref="T:UIKit.UIStackView" />.</summary>
		Top = 1,
		/// <summary>Views are aligned based on the baseline of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Horizontal only.)</summary>
		FirstBaseline = 2,
		/// <summary>Views are aligned along the <see cref="P:UIKit.UIStackView.Axis" />, in the center of the <see cref="T:UIKit.UIStackView" />.</summary>
		Center = 3,
		/// <summary>Views are aligned based on the trailing edge of the first <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Vertical only.)</summary>
		Trailing = 4,
		/// <summary>Horizontal layout, bottom edges aligned to the bottom of the <see cref="T:UIKit.UIStackView" />.</summary>
		Bottom = 4,
		/// <summary>Views are aligned based on the baseline of the last <see cref="P:UIKit.UIStackView.ArrangedSubviews" />. (Horizontal only.)</summary>
		LastBaseline = 5,
	}
}
