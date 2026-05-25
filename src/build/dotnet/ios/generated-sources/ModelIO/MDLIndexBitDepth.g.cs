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
namespace ModelIO {
	/// <summary>Enumerates bit depths for <see cref="T:ModelIO.MDLSubmesh" /> index buffers.</summary>
	[Native]
	public enum MDLIndexBitDepth : ulong {
		/// <summary>The index buffer has not been initialized.</summary>
		Invalid = 0,
		/// <summary>Each index is an unsigned 8-bit integer.</summary>
		UInt8 = 8,
		/// <summary>Each index is an unsigned 16-bit integer.</summary>
		UInt16 = 16,
		/// <summary>Each index is an unsigned 32-bit integer.</summary>
		UInt32 = 32,
	}
}
