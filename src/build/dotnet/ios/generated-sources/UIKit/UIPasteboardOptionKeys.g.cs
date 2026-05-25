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
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class UIPasteboardOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpirationDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIPasteboardOptionExpirationDate",  "UIKit")]
		public static NSString ExpirationDateKey {
			get {
				if (_ExpirationDateKey is null)
					_ExpirationDateKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardOptionExpirationDate")!;
				return _ExpirationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalOnlyKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIPasteboardOptionLocalOnly",  "UIKit")]
		public static NSString LocalOnlyKey {
			get {
				if (_LocalOnlyKey is null)
					_LocalOnlyKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardOptionLocalOnly")!;
				return _LocalOnlyKey;
			}
		}
	} /* class UIPasteboardOptionKeys */
}
