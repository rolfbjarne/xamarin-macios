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
	/// <summary>An enumeration of values used by <see cref="M:AppKit.NSLayoutConstraint.FromVisualFormat(System.String,AppKit.NSLayoutFormatOptions,Foundation.NSDictionary,Foundation.NSDictionary)" /></summary><remarks>The method <see cref="M:AppKit.NSLayoutConstraint.FromVisualFormat(System.String,AppKit.NSLayoutFormatOptions,Foundation.NSDictionary,Foundation.NSDictionary)" /> takes as a parameter a <see cref="T:AppKit.NSLayoutFormatOptions" /> value. This specifies which alignment instruction (e.g., <see cref="F:AppKit.NSLayoutFormatOptions.AlignAllLeft" />) is to be used with the visual format string. For more on the visual format syntax, refer to the Apple document "Visual Format Language" (<format type="text/html"><a href="https://developer.apple.com/library/mac/#documentation/UserExperience/Conceptual/AutolayoutPG/Articles/formatLanguage.html">https://developer.apple.com/library/mac/#documentation/UserExperience/Conceptual/AutolayoutPG/Articles/formatLanguage.html</a></format>). </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSLayoutFormatOptions : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.Left" /> properties.</summary>
		AlignAllLeft = 2,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.Right" /> properties.</summary>
		AlignAllRight = 4,
		/// <summary>Aligns all attributes using their <see cref="F:AppKit.NSLayoutAttribute.Top" />s.</summary>
		AlignAllTop = 8,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.Bottom" />s.</summary>
		AlignAllBottom = 16,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.Leading" />s.</summary>
		AlignAllLeading = 32,
		/// <summary>Aligns all attributes using their <see cref="F:AppKit.NSLayoutAttribute.Trailing" />s.</summary>
		AlignAllTrailing = 64,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.CenterX" />s.</summary>
		AlignAllCenterX = 512,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.CenterY" />s.</summary>
		AlignAllCenterY = 1024,
		/// <summary>Aligns all elements using their <see cref="F:AppKit.NSLayoutAttribute.Baseline" />s.</summary>
		AlignAllBaseline = 2048,
		/// <summary>Align all elements by using their last baselines.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AlignAllLastBaseline = 2048,
		/// <summary>Align all elements by using their first baselines.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AlignAllFirstBaseline = 4096,
		/// <summary>Mask that can be applied to return only the alignment portion of the format options.</summary>
		AlignmentMask = 65535,
		/// <summary>Arranges objects in the normal direction of text. In most languages this is left-to-right.</summary>
		DirectionLeadingToTrailing = 0,
		/// <summary>Arranges objects so that the first object is left-most.</summary>
		DirectionLeftToRight = 65536,
		/// <summary>Arranges objects so that the first object is right-most.</summary>
		DirectionRightToLeft = 131072,
		/// <summary>Arrange objects edge to edge.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SpacingEdgeToEdge = 0,
		/// <summary>Arrange objects to that their baselines align.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SpacingBaselineToBaseline = 524288,
		/// <summary>A mask that selects only spacing bits of the format options.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SpacingMask = 524288,
		/// <summary>Mask that can be applied to return only the directional component of the format options.</summary>
		DirectionMask = 196608,
	}
}
