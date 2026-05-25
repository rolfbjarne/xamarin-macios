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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
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
		/// <summary>The status bar group. This group displays below other groups.</summary><value>The value is 1000.</value><remarks>To be added.</remarks>
		[Field ("UIWindowLevelStatusBar",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static nfloat StatusBar {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIWindowLevelStatusBar");
			}
		}
	} /* class UIWindowLevel */
}
