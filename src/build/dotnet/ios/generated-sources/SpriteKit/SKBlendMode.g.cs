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
namespace SpriteKit {
	/// <summary>An enumeration whose values specify options for blending of visual <see cref="T:SpriteKit.SKNode" />s or particles.</summary>
	[Native]
	public enum SKBlendMode : long {
		/// <summary>The alpha value of the source color is used to blend the colors.</summary>
		Alpha = 0,
		/// <summary>The colors are added.</summary>
		Add = 1,
		/// <summary>The source color is subtracted from the destination.</summary>
		Subtract = 2,
		/// <summary>The colors are multiplied.</summary>
		Multiply = 3,
		/// <summary>The colors are multiplied and then doubled.</summary>
		MultiplyX2 = 4,
		/// <summary>The inverted source color is multiplied by the destination color, and the source color is added to the result..</summary>
		Screen = 5,
		/// <summary>The source color is used.</summary>
		Replace = 6,
		/// <summary>To be added.</summary>
		MultiplyAlpha = 7,
	}
}
