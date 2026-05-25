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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	/// <summary>An enumeration whose values specify actions caused by control characters.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSControlCharacterAction : long {
		/// <summary>Glyphs with this action are filtered from the layout.</summary>
		ZeroAdvancement = 1,
		/// <summary>Uses <see cref="M:AppKit.NSLayoutManagerDelegate.ShouldUseAction(AppKit.NSLayoutManager,AppKit.NSControlCharacterAction,System.UIntPtr)" /> or, if not overridden, <see cref="F:AppKit.NSControlCharacterAction.ZeroAdvancement" />.</summary>
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
