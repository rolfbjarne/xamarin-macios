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
	/// <summary>An enumeration indicating various types of events.</summary><remarks>The list of events for UIControl objects.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native ("UIControlEvents")]
	public enum UIControlEvent : ulong {
		/// <summary>Touch down event.</summary>
		TouchDown = 1,
		/// <summary>Repeated touch-down event.   The UITouch.TapCount property will be greater than one.</summary>
		TouchDownRepeat = 2,
		/// <summary>A finger is being dragged within the control.</summary>
		TouchDragInside = 4,
		/// <summary>A finger is being dragged outside of the bounds of the control, but close to it.</summary>
		TouchDragOutside = 8,
		/// <summary>A dragging finger has entered the control.</summary>
		TouchDragEnter = 16,
		/// <summary>A dragging finger has left the bounds of the control.</summary>
		TouchDragExit = 32,
		/// <summary>Touch-up event within the control.</summary>
		TouchUpInside = 64,
		/// <summary>Touch-up event outside the control.</summary>
		TouchUpOutside = 128,
		/// <summary>The system is cancelling the touch event.</summary>
		TouchCancel = 256,
		/// <summary>The value changed, emitted by various controls.</summary>
		ValueChanged = 4096,
		/// <summary>To be added.</summary>
		PrimaryActionTriggered = 8192,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		MenuActionTriggered = 16384,
		/// <summary>UITextField event: editing started.</summary>
		EditingDidBegin = 65536,
		/// <summary>UITextField event: the contents changed.</summary>
		EditingChanged = 131072,
		/// <summary>UITextField event: editing finished.</summary>
		EditingDidEnd = 262144,
		/// <summary>UITextField event: editing ended.</summary>
		EditingDidEndOnExit = 524288,
		/// <summary>All touch events.</summary>
		AllTouchEvents = 4095,
		/// <summary>All editing events for the UITextField.</summary>
		AllEditingEvents = 983040,
		/// <summary>This mask describes the range of bytes available for application events.   Any values within [0x01000000,0x0f000000] can be used as application specific events.</summary>
		ApplicationReserved = 251658240,
		/// <summary>Mask of events reserved for system use.</summary>
		SystemReserved = 4026531840,
		/// <summary>All events</summary>
		AllEvents = 4294967295,
	}
}
