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
	/// <summary>The layer group to which a <see cref="T:UIKit.UIWindow" /> belongs. Returned by <see cref="P:UIKit.UIWindow.WindowLevel" />.</summary><remarks><para>The z-order of windows is determined first by their window level (Alert and Status Bar windows appear above normal windows) and within the level by their order.</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UIWindowLevel  {
		/// <summary>The alert window group. This is the top-most level.</summary><value>The value is 100F.</value><remarks>To be added.</remarks>
		[Field ("UIWindowLevelAlert",  "UIKit")]
		public static nfloat Alert {
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIWindowLevelAlert");
			}
		}
		/// <summary>The normal window group (below alert windows).</summary><value>The value is 0.</value><remarks>To be added.</remarks>
		[Field ("UIWindowLevelNormal",  "UIKit")]
		public static nfloat Normal {
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIWindowLevelNormal");
			}
		}
	} /* class UIWindowLevel */
}
