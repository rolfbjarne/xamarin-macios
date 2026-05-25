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
	/// <summary>The visual style for a <see cref="T:UIKit.UIScrollView" />'s scroll indicator.</summary><remarks><para>Specifies the visual appearance of the scroll indicators in a <see cref="T:UIKit.UIScrollView" />. Values are:</para><list type="table"><listheader><term>Constant</term><description>Description</description></listheader><item><term><see cref="F:UIKit.UIScrollViewIndicatorStyle.Default" /></term><description>Black with a white border.</description></item><item><term><see cref="F:UIKit.UIScrollViewIndicatorStyle.Black" /></term><description>Black. Narrower than <see cref="F:UIKit.UIScrollViewIndicatorStyle.Default" />.</description></item><item><term><see cref="F:UIKit.UIScrollViewIndicatorStyle.White" /></term><description>White. Narrower than <see cref="F:UIKit.UIScrollViewIndicatorStyle.Default" />.</description></item></list><para>The following image shows the three styles in closeup:</para><para><img href="~/xml/UIKit/_images/UIKit.UIScrollViewIndicatorStyle.png" alt="Screenshot of the various scrollview indicator styles" /></para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIScrollViewIndicatorStyle : long {
		/// <summary>A black scroll indicator with a narrow white border. Slightly wider than either <see cref="F:UIKit.UIScrollViewIndicatorStyle.Black" /> or <see cref="F:UIKit.UIScrollViewIndicatorStyle.White" /></summary>
		Default = 0,
		/// <summary>A black, borderless scroll indicator. Slightly narrower than <see cref="F:UIKit.UIScrollViewIndicatorStyle.Default" />.</summary>
		Black = 1,
		/// <summary>A white, borderless scroll indicator. Slightly narrower than <see cref="F:UIKit.UIScrollViewIndicatorStyle.Default" />.</summary>
		White = 2,
	}
}
