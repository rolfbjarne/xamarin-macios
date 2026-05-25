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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum MPSCnnLossType : uint {
		/// <summary>To be added.</summary>
		MeanAbsoluteError = 0,
		/// <summary>To be added.</summary>
		MeanSquaredError = 1,
		/// <summary>To be added.</summary>
		SoftMaxCrossEntropy = 2,
		/// <summary>To be added.</summary>
		SigmoidCrossEntropy = 3,
		/// <summary>To be added.</summary>
		CategoricalCrossEntropy = 4,
		/// <summary>To be added.</summary>
		Hinge = 5,
		/// <summary>To be added.</summary>
		Huber = 6,
		/// <summary>To be added.</summary>
		CosineDistance = 7,
		/// <summary>To be added.</summary>
		Log = 8,
		/// <summary>To be added.</summary>
		KullbackLeiblerDivergence = 9,
	}
}
