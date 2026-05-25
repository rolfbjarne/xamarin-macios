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
	/// <summary>The visual style for a <see cref="T:UIKit.UIActionSheet" />.</summary><remarks><para>The values of <see cref="F:UIKit.UIActionSheetStyle.Automatic" /> and <see cref="F:UIKit.UIActionSheetStyle.Default" /> are the same.</para><para>In this image, the left phone is displaying with <see cref="F:UIKit.UIActionSheetStyle.BlackTranslucent" /> style and the right with <see cref="F:UIKit.UIActionSheetStyle.BlackOpaque" /> style.</para><para><img href="~/xml/UIKit/_images/UIKit.UIActionSheetStyle.png" alt="Screenshot showing alternate styles for the UIActionSheet" /></para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIActionSheetStyle : long {
		/// <summary>Same as <see cref="F:UIKit.UIActionSheetStyle.Default" /> default.</summary>
		Automatic = -1,
		/// <summary>The default style takes appearance of the bottom bar.</summary>
		Default = 0,
		/// <summary>A background with some amount of translucence.</summary>
		BlackTranslucent = 2,
		/// <summary>A black, opaque style.</summary>
		BlackOpaque = 1,
	}
}
