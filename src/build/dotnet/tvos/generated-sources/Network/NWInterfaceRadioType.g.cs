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
namespace Network {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NWInterfaceRadioType : int {
		Unknown = 0,
		WifiB = 1,
		WifiA = 2,
		WifiG = 3,
		WifiN = 4,
		WifiAC = 5,
		WifiAX = 6,
		CellLte = 128,
		CellEndcSub6 = 129,
		CellEndcMmw = 130,
		CellNrSaSub6 = 131,
		CellNrSaMmw = 132,
		CellWcdma = 133,
		CellGsm = 134,
		CellCdma = 135,
		CellEvdo = 136,
	}
}
