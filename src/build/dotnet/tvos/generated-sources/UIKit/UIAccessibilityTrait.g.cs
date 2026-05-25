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
namespace UIKit {
	/// <summary>An enumeration whose values can be used as flags for <see cref="UIKit.UIView.AccessibilityTraits" />.</summary><remarks>To be added.</remarks>
	[Flags]
	public enum UIAccessibilityTrait : long {
		/// <summary>The accessibility element has no traits.</summary>
		None = 0,
		/// <summary>The accessibility element should be treated as a button.</summary>
		Button = 1,
		/// <summary>The accessibility element should be treated as a link.</summary>
		Link = 2,
		/// <summary>The accessibility element should be treated as an image.</summary>
		Image = 4,
		/// <summary>The accessibility element is selected.</summary>
		Selected = 8,
		/// <summary>The accessibility element plays a sound when it is activated.</summary>
		PlaysSound = 16,
		/// <summary>The accessibility element behaves like a keyboard key.</summary>
		KeyboardKey = 32,
		/// <summary>The accessibility element should be treated as static, immutable text.</summary>
		StaticText = 64,
		/// <summary>The accessibility element provides summary information when the app starts.</summary>
		SummaryElement = 128,
		/// <summary>The accessibility element is not enabled.</summary>
		NotEnabled = 256,
		/// <summary>Indicates that the accessibility element frequently changes its label or value.</summary>
		UpdatesFrequently = 512,
		/// <summary>The accessibility element should be treated as a search field.</summary>
		SearchField = 1024,
		/// <summary>The accessibility element starts a media session when activated.</summary>
		StartsMediaSession = 2048,
		/// <summary>The accessibility element allows a continuous adjustment over a range of values.</summary>
		Adjustable = 4096,
		/// <summary>The accessibility element allows direct touch interaction for VoiceOver users.</summary>
		AllowsDirectInteraction = 8192,
		/// <summary>The accessibility element causes an automatic page turn when VoiceOver finishes reading the text within the element.</summary>
		CausesPageTurn = 16384,
		/// <summary>The accessibility element is a header that divides content into sections.</summary>
		Header = 65536,
	}
}
