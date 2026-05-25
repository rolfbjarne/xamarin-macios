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
namespace TVServices {
	[SupportedOSPlatform ("tvos14.3")]
	public unsafe static partial class TVUserActivityType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrowsingChannelGuide;
		/// <summary>Represents the value associated with the constant 'TVUserActivityTypeBrowsingChannelGuide'.</summary>
		[Field ("TVUserActivityTypeBrowsingChannelGuide",  "TVServices")]
		public static NSString BrowsingChannelGuide {
			get {
				if (_BrowsingChannelGuide is null)
					_BrowsingChannelGuide = Dlfcn.GetStringConstant (Libraries.TVServices.Handle, "TVUserActivityTypeBrowsingChannelGuide")!;
				return _BrowsingChannelGuide;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrowsingEntertainmentContent;
		/// <summary>Represents the value associated with the constant 'TVUserActivityTypeBrowsingEntertainmentContent'.</summary>
		[Field ("TVUserActivityTypeBrowsingEntertainmentContent",  "TVServices")]
		[SupportedOSPlatform ("tvos18.1")]
		public static NSString BrowsingEntertainmentContent {
			[SupportedOSPlatform ("tvos18.1")]
			get {
				if (_BrowsingEntertainmentContent is null)
					_BrowsingEntertainmentContent = Dlfcn.GetStringConstant (Libraries.TVServices.Handle, "TVUserActivityTypeBrowsingEntertainmentContent")!;
				return _BrowsingEntertainmentContent;
			}
		}
	} /* class TVUserActivityType */
}
