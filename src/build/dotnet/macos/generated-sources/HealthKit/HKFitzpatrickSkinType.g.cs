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
namespace HealthKit {
	/// <summary>Enumerates skin types using the Fitzpatrick scale.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKFitzpatrickSkinType : long {
		/// <summary>Either the user's skin type has not been set or permissions have not been granted.</summary>
		NotSet = 0,
		/// <summary>Pale white skin that never tans and burns easily.</summary>
		I = 1,
		/// <summary>White skin that tans minimally and burns easily.</summary>
		II = 2,
		/// <summary>White to light-brown skin that tans uniformly and burns moderately.</summary>
		III = 3,
		/// <summary>Beige-olive, lightly-tanned skin that tans uniformly and burns moderately.</summary>
		IV = 4,
		/// <summary>Brown skin that tans profusely and rarely burns.</summary>
		V = 5,
		/// <summary>Dark brown to black skin that tans profusely and never burns.</summary>
		VI = 6,
	}
}
