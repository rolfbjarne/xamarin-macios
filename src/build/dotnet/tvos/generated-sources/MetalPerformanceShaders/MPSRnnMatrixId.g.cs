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
namespace MetalPerformanceShaders {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MPSRnnMatrixId : ulong {
		/// <summary>To be added.</summary>
		SingleGateInputWeights = 0,
		/// <summary>To be added.</summary>
		SingleGateRecurrentWeights = 1,
		/// <summary>To be added.</summary>
		SingleGateBiasTerms = 2,
		/// <summary>To be added.</summary>
		LstmInputGateInputWeights = 3,
		/// <summary>To be added.</summary>
		LstmInputGateRecurrentWeights = 4,
		/// <summary>To be added.</summary>
		LstmInputGateMemoryWeights = 5,
		/// <summary>To be added.</summary>
		LstmInputGateBiasTerms = 6,
		/// <summary>To be added.</summary>
		LstmForgetGateInputWeights = 7,
		/// <summary>To be added.</summary>
		LstmForgetGateRecurrentWeights = 8,
		/// <summary>To be added.</summary>
		LstmForgetGateMemoryWeights = 9,
		/// <summary>To be added.</summary>
		LstmForgetGateBiasTerms = 10,
		/// <summary>To be added.</summary>
		LstmMemoryGateInputWeights = 11,
		/// <summary>To be added.</summary>
		LstmMemoryGateRecurrentWeights = 12,
		/// <summary>To be added.</summary>
		LstmMemoryGateMemoryWeights = 13,
		/// <summary>To be added.</summary>
		LstmMemoryGateBiasTerms = 14,
		/// <summary>To be added.</summary>
		LstmOutputGateInputWeights = 15,
		/// <summary>To be added.</summary>
		LstmOutputGateRecurrentWeights = 16,
		/// <summary>To be added.</summary>
		LstmOutputGateMemoryWeights = 17,
		/// <summary>To be added.</summary>
		LstmOutputGateBiasTerms = 18,
		/// <summary>To be added.</summary>
		GruInputGateInputWeights = 19,
		/// <summary>To be added.</summary>
		GruInputGateRecurrentWeights = 20,
		/// <summary>To be added.</summary>
		GruInputGateBiasTerms = 21,
		/// <summary>To be added.</summary>
		GruRecurrentGateInputWeights = 22,
		/// <summary>To be added.</summary>
		GruRecurrentGateRecurrentWeights = 23,
		/// <summary>To be added.</summary>
		GruRecurrentGateBiasTerms = 24,
		/// <summary>To be added.</summary>
		GruOutputGateInputWeights = 25,
		/// <summary>To be added.</summary>
		GruOutputGateRecurrentWeights = 26,
		/// <summary>To be added.</summary>
		GruOutputGateInputGateWeights = 27,
		/// <summary>To be added.</summary>
		GruOutputGateBiasTerms = 28,
	}
}
