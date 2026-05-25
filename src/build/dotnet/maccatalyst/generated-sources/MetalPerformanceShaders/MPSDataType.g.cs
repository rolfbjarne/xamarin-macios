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
namespace MetalPerformanceShaders {
	/// <summary>Enumerates values that specify floating point data types.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum MPSDataType : uint {
		/// <summary>To be added.</summary>
		Invalid = 0,
		/// <summary>Indicates floating point format data of any width.</summary>
		FloatBit = 268435456,
		/// <summary>To be added.</summary>
		Float16 = 268435472,
		/// <summary>Indicates 32-bit floating point format data.</summary>
		Float32 = 268435488,
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[SupportedOSPlatform ("tvos16.2")]
		[SupportedOSPlatform ("macos")]
		ComplexBit = 16777216,
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[SupportedOSPlatform ("tvos16.2")]
		[SupportedOSPlatform ("macos")]
		ComplexFloat32 = 285212736,
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[SupportedOSPlatform ("tvos16.2")]
		[SupportedOSPlatform ("macos")]
		ComplexFloat16 = 285212704,
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos")]
		ComplexBFloat16 = 2432696352,
		/// <summary>To be added.</summary>
		SignedBit = 536870912,
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		Int2 = 536870914,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Int4 = 536870916,
		/// <summary>To be added.</summary>
		Int8 = 536870920,
		/// <summary>To be added.</summary>
		Int16 = 536870928,
		Int32 = 536870944,
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Int64 = 536870976,
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		UInt2 = 2,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		UInt4 = 4,
		/// <summary>To be added.</summary>
		UInt8 = 8,
		/// <summary>To be added.</summary>
		UInt16 = 16,
		/// <summary>To be added.</summary>
		UInt32 = 32,
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UInt64 = 64,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		AlternateEncodingBit = 2147483648,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		Bool = 2147483656,
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos14.0")]
		BFloat16 = 2415919120,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		NormalizedBit = 1073741824,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Unorm1 = 1073741825,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Unorm8 = 1073741832,
	}
}
