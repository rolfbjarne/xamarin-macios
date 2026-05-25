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
namespace HomeKit {
	/// <summary>Enumerates the data types that can represent characteristics.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum HMCharacteristicMetadataFormat : int {
		/// <summary>The data format is either unspecified or unknown.</summary>
		None = 0,
		/// <summary>The data are represented by Boolean values.</summary>
		Bool = 1,
		/// <summary>The data are represented by int values.</summary>
		Int = 2,
		/// <summary>The data are represented by float values.</summary>
		Float = 3,
		/// <summary>The data are represented by string values.</summary>
		String = 4,
		/// <summary>The data are represented by arrays.</summary>
		Array = 5,
		/// <summary>The data are represented by dictionary values.</summary>
		Dictionary = 6,
		/// <summary>The data are represented by UInt8 values.</summary>
		UInt8 = 7,
		/// <summary>The data are represented by UInt16 values.</summary>
		UInt16 = 8,
		/// <summary>The data are represented by UInt32 values.</summary>
		UInt32 = 9,
		/// <summary>The data are represented by UInt64 values.</summary>
		UInt64 = 10,
		/// <summary>The data are represented by binary blobs.</summary>
		Data = 11,
		/// <summary>The data are represented by Tlv8 values, which are packed 8-bit type and length values, followed by the number of bytes that are specified in the packed length field.</summary>
		Tlv8 = 12,
	}
}
