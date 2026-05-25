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
namespace AudioUnit {
	/// <summary>Flagging enumeration used with <see cref="AudioUnitParameterInfo.Flags" />.</summary>
	[Flags]
	public enum AudioUnitParameterFlag : uint {
		/// <summary>To be added.</summary>
		CFNameRelease = 16,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		OmitFromPresets = 8192,
		/// <summary>To be added.</summary>
		PlotHistory = 16384,
		/// <summary>To be added.</summary>
		MeterReadOnly = 32768,
		/// <summary>To be added.</summary>
		DisplayMask = 4653056,
		/// <summary>To be added.</summary>
		DisplaySquareRoot = 65536,
		/// <summary>To be added.</summary>
		DisplaySquared = 131072,
		/// <summary>To be added.</summary>
		DisplayCubed = 196608,
		/// <summary>To be added.</summary>
		DisplayCubeRoot = 262144,
		/// <summary>To be added.</summary>
		DisplayExponential = 327680,
		/// <summary>To be added.</summary>
		HasClump = 1048576,
		/// <summary>To be added.</summary>
		ValuesHaveStrings = 2097152,
		/// <summary>To be added.</summary>
		DisplayLogarithmic = 4194304,
		/// <summary>To be added.</summary>
		IsHighResolution = 8388608,
		/// <summary>To be added.</summary>
		NonRealTime = 16777216,
		/// <summary>To be added.</summary>
		CanRamp = 33554432,
		/// <summary>To be added.</summary>
		ExpertMode = 67108864,
		/// <summary>To be added.</summary>
		HasCFNameString = 134217728,
		/// <summary>To be added.</summary>
		IsGlobalMeta = 268435456,
		/// <summary>To be added.</summary>
		IsElementMeta = 536870912,
		/// <summary>To be added.</summary>
		IsReadable = 1073741824,
		/// <summary>To be added.</summary>
		IsWritable = 2147483648,
	}
}
