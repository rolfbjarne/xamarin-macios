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
namespace CoreBluetooth {
	/// <summary>The possible properties of a characteristic. A characteristic may have multiple properties.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum CBCharacteristicProperties : ulong {
		/// <summary>To be added.</summary>
		Broadcast = 1,
		/// <summary>To be added.</summary>
		Read = 2,
		/// <summary>To be added.</summary>
		WriteWithoutResponse = 4,
		/// <summary>To be added.</summary>
		Write = 8,
		/// <summary>To be added.</summary>
		Notify = 16,
		/// <summary>To be added.</summary>
		Indicate = 32,
		/// <summary>To be added.</summary>
		AuthenticatedSignedWrites = 64,
		/// <summary>To be added.</summary>
		ExtendedProperties = 128,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		NotifyEncryptionRequired = 256,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		IndicateEncryptionRequired = 512,
	}
}
