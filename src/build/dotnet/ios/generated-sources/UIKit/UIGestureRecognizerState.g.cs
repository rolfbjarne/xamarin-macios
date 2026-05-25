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
	/// <summary>An enumeration of states for a <see cref="T:UIKit.UIGestureRecognizer" />.</summary><remarks><para>
	/// 	This describes the state of a <see cref="T:UIKit.UIGestureRecognizer" />.  All of
	/// 	UIGestureRecognizers start in the Possible state.  Once one or
	/// 	more touches has been received, the recognizers transition to
	/// 	the Began state.  For one-shot patterns (like Tap), this will
	/// 	either transition into the Recognized state or the Failed
	/// 	state.  For continuous gestures (like panning, pinching,
	/// 	rotating) the recognizer will transition to the Changed state
	/// 	and emit multiple calls back to the action and finally
	/// 	transition to either the Ended or Cancelled states.
	/// 
	/// </para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIGestureRecognizerState : long {
		/// <summary>The default state: no gesture is recognized, but the recognizer may be evaluating touch events.</summary>
		Possible = 0,
		/// <summary>Touch object have begun that are recognized as a continuous gesture.</summary>
		Began = 1,
		/// <summary>Touch objects that are part of a continuous gesture have changed.</summary>
		Changed = 2,
		/// <summary>Touch objects that are part of a continuous gesture have ended.</summary>
		Ended = 3,
		/// <summary>Touches have cancelled a continuous gesture.</summary>
		Cancelled = 4,
		/// <summary>An unrecognized multi-touch gesture has occurred. </summary>
		Failed = 5,
		/// <summary>A multi-touch has been recognized. The state is changed to UIGestureRecognizerState.Possible.</summary>
		Recognized = 3,
	}
}
