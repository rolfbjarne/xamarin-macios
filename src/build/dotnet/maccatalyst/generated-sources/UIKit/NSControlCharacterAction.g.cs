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
	/// <summary>An enumeration whose values specify actions caused by control characters.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum NSControlCharacterAction : long {
		/// <summary>Glyphs with this action are filtered from the layout.</summary>
		ZeroAdvancement = 1,
		/// <summary>Uses <see cref="M:UIKit.NSLayoutManagerDelegate.ShouldUseAction(UIKit.NSLayoutManager,UIKit.NSControlCharacterAction,System.UIntPtr)" /> or, if not overridden, <see cref="F:UIKit.NSControlCharacterAction.ZeroAdvancement" />.</summary>
		Whitespace = 2,
		/// <summary>Treated as a tab character.</summary>
		HorizontalTab = 4,
		/// <summary>Causes a line break.</summary>
		LineBreak = 8,
		/// <summary>Causes a paragraph break.</summary>
		ParagraphBreak = 16,
		/// <summary>Causes container break.</summary>
		ContainerBreak = 32,
	}
}
