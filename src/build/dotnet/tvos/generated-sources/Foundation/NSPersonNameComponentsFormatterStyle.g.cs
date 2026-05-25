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
namespace Foundation {
	/// <summary>Enumerates values that control the way that names are displayed.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NSPersonNameComponentsFormatterStyle : long {
		/// <summary>Display a medium-length representation of the name. Equivalent to <c>Medium</c>.</summary>
		Default = 0,
		/// <summary>Display a shortened form of the name by abbreviating or omitting various, user-specified, components.</summary>
		Short = 1,
		/// <summary>Display a medium-length representation of the name. Equivalent to <c>Default</c>.</summary>
		Medium = 2,
		/// <summary>Use all available name components, except for the nickname, to display the name.</summary>
		Long = 3,
		/// <summary>Display the most abbreviated form of the name.</summary>
		Abbreviated = 4,
	}
}
