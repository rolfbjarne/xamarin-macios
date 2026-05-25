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
namespace CoreMedia {
	/// <summary>Enumerates pixel formats.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMPixelFormat : uint {
		/// <summary>To be added.</summary>
		AlphaRedGreenBlue32bits = 32,
		/// <summary>To be added.</summary>
		BlueGreenRedAlpha32bits = 1111970369,
		/// <summary>To be added.</summary>
		RedGreenBlue24bits = 24,
		/// <summary>To be added.</summary>
		BigEndian555_16bits = 16,
		/// <summary>To be added.</summary>
		BigEndian565_16bits = 1110783541,
		/// <summary>To be added.</summary>
		LittleEndian555_16bits = 1278555445,
		/// <summary>To be added.</summary>
		LittleEndian565_16bits = 1278555701,
		/// <summary>To be added.</summary>
		LittleEndian5551_16bits = 892679473,
		/// <summary>To be added.</summary>
		YpCbCr422_8bits = 846624121,
		/// <summary>To be added.</summary>
		YpCbCr422yuvs_8bits = 2037741171,
		/// <summary>To be added.</summary>
		YpCbCr444_8bits = 1983066168,
		/// <summary>To be added.</summary>
		YpCbCrA4444_8bits = 1983131704,
		/// <summary>To be added.</summary>
		YpCbCr422_16bits = 1983000886,
		/// <summary>To be added.</summary>
		YpCbCr422_10bits = 1983000880,
		/// <summary>To be added.</summary>
		YpCbCr444_10bits = 1983131952,
		/// <summary>To be added.</summary>
		IndexedGrayWhiteIsZero_8bits = 40,
	}
}
