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
	/// <summary>An enumeration of strategies for dealing with pixels lost at the edge of the screen.</summary><remarks>To be added.</remarks><altmember cref="P:UIKit.UIScreen.OverscanCompensation" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIScreenOverscanCompensation : long {
		/// <summary>The final screenbuffer is scaled so that all pixels are visible.</summary>
		Scale = 0,
		/// <summary>The screen bounds are reduced so that all pixels are visible.</summary>
		InsetBounds = 1,
		/// <summary>No scaling is performed.</summary>
		None = 2,
		/// <summary>The application frame is reduced to compensate for overscan.</summary>
		[Obsolete ("Use 'UIScreenOverscanCompensation.None' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		InsetApplicationFrame = 2,
	}
}
