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
namespace AudioUnit {
	/// <summary>Enumerates attentuation curve types.</summary>
	public enum AU3DMixerAttenuationCurve : uint {
		/// <summary>Indicates an equal-power attenuation curve.</summary>
		Power = 0,
		/// <summary>Indicates an exponential attenuation curve.</summary>
		Exponential = 1,
		/// <summary>Indicates an inverse attenuation curve.</summary>
		Inverse = 2,
		/// <summary>Indicates a linear attenuation curve.</summary>
		Linear = 3,
	}
}
