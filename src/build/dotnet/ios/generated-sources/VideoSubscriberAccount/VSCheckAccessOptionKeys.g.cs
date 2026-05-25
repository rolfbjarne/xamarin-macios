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
