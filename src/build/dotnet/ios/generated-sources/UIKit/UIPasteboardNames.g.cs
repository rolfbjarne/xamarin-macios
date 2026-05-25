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
	/// <summary>Constants that identify the name of a pasteboard.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class UIPasteboardNames  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Find;
		/// <summary>Developers should not use this deprecated property. The 'Find' pasteboard is no longer available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIPasteboardNameFind",  "UIKit")]
		[ObsoletedOSPlatform ("ios10.0", "The 'Find' pasteboard is no longer available.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "The 'Find' pasteboard is no longer available.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString Find {
			[ObsoletedOSPlatform ("ios10.0", "The 'Find' pasteboard is no longer available.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "The 'Find' pasteboard is no longer available.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_Find is null)
					_Find = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardNameFind")!;
				return _Find;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _General;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIPasteboardNameGeneral",  "UIKit")]
		public static NSString General {
			get {
				if (_General is null)
					_General = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardNameGeneral")!;
				return _General;
			}
		}
	} /* class UIPasteboardNames */
}
