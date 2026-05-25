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
namespace CoreLocation {
	/// <summary>An enumeration whose values represent the device's physical orientation.</summary>
	public enum CLDeviceOrientation : uint {
		/// <summary>The device's orientation is unavailable.</summary>
		Unknown = 0,
		/// <summary>The device is in an upright position, with the home button towards the ground.</summary>
		Portrait = 1,
		/// <summary>The device is in an upright position, with the home button towards the sky.</summary>
		PortraitUpsideDown = 2,
		/// <summary>The device is in an upright position, with the home button to the right.</summary>
		LandscapeLeft = 3,
		/// <summary>The device is in an upright position, with the home button to the left.</summary>
		LandscapeRight = 4,
		/// <summary>The device is parallel to the ground and the face is pointing towards the sky.</summary>
		FaceUp = 5,
		/// <summary>The device is parallel to the ground and the face is pointing towards the ground.</summary>
		FaceDown = 6,
	}
}
