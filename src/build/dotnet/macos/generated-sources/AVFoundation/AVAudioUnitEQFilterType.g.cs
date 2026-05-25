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
namespace AVFoundation {
	/// <summary>Filter types. Used with the <see cref="P:AVFoundation.AVAudioUnitEQFilterParameters.FilterType" /> property.</summary><remarks>To be added.</remarks>
	[Native]
	public enum AVAudioUnitEQFilterType : long {
		/// <summary>Parametric filter based on Butterworth analog prototype. Must have <c>frequency</c> for center, <c>bandwidth</c>, and <c>gain</c></summary>
		Parametric = 0,
		/// <summary>To be added.</summary>
		LowPass = 1,
		/// <summary>To be added.</summary>
		HighPass = 2,
		/// <summary>Low pass filter with resonance. Must have <c>frequency</c> (-3dB cutoff) and <c>bandwidth</c>.</summary>
		ResonantLowPass = 3,
		/// <summary>High pass filter with resonance. Must have <c>frequency</c> (-3dB cutoff) and <c>bandwidth</c>.</summary>
		ResonantHighPass = 4,
		/// <summary>Band pass filter. Must specify <c>frequency</c> and <c>bandwidth</c>.</summary>
		BandPass = 5,
		/// <summary>Band stop / notch filter. Must specify <c>frequency</c> and <c>bandwidth</c>.</summary>
		BandStop = 6,
		/// <summary>To be added.</summary>
		LowShelf = 7,
		/// <summary>To be added.</summary>
		HighShelf = 8,
		/// <summary>Low shelf filter with resonance. Must have <c>frequency</c>, <c>bandwidth</c>, and <c>gain</c>.</summary>
		ResonantLowShelf = 9,
		/// <summary>High shelf filter with resonance. Must have <c>frequency</c>, <c>bandwidth</c>, and <c>gain</c>.</summary>
		ResonantHighShelf = 10,
	}
}
