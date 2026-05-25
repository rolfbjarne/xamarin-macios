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
	/// <summary>An enumeration of values specifying search path domain constants for use with <see cref="T:Foundation.NSSearchPathDirectory" />.</summary><remarks>The domain is used to specify the kind of directory you want to get from the <see cref="M:Foundation.NSFileManager.GetUrls(Foundation.NSSearchPathDirectory,Foundation.NSSearchPathDomain)" /> method.</remarks>
	[Flags]
	[Native]
	public enum NSSearchPathDomain : ulong {
		/// <summary>Do not return anything.</summary>
		None = 0,
		/// <summary>Return user directories.</summary>
		User = 1,
		/// <summary>Return local directories.</summary>
		Local = 2,
		/// <summary>Return network directories.</summary>
		Network = 4,
		/// <summary>Return the system directories.</summary>
		System = 8,
		/// <summary>Return items for all domains.</summary>
		All = 65535,
	}
}
