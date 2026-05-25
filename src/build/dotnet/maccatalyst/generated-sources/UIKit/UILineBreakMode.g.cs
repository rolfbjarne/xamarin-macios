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
	/// <summary>An enumeration of values used to specify line break mode.</summary><remarks>To be added.</remarks>
	[Native]
	public enum UILineBreakMode : long {
		/// <summary>Wraps at the first word that does not fit.</summary>
		WordWrap = 0,
		/// <summary>Wraps at the first character that doesn't fit.</summary>
		CharacterWrap = 1,
		/// <summary>That which does not fit is not rendered.</summary>
		Clip = 2,
		/// <summary>The end of the text is shown, the head is truncated to an ellipse.</summary>
		HeadTruncation = 3,
		/// <summary>The start of the text is shown, the rest is indicated with an ellipse.</summary>
		TailTruncation = 4,
		/// <summary>The start and end of the text is shown, with an ellipse in the middle.</summary>
		MiddleTruncation = 5,
	}
}
