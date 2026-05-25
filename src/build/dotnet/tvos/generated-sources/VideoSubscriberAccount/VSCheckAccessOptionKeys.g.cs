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
namespace VideoSubscriberAccount {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VSCheckAccessOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CheckAccessOptionPrompt;
		/// <summary>Represents the value associated with the constant 'VSCheckAccessOptionPrompt'.</summary>
		[Field ("VSCheckAccessOptionPrompt",  "VideoSubscriberAccount")]
		public static NSString CheckAccessOptionPrompt {
			get {
				if (_CheckAccessOptionPrompt is null)
					_CheckAccessOptionPrompt = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSCheckAccessOptionPrompt")!;
				return _CheckAccessOptionPrompt;
			}
		}
	} /* class VSCheckAccessOptionKeys */
}
