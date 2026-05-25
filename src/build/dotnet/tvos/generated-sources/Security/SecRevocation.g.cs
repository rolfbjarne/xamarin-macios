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
namespace Security {
	/// <summary>Enumerates certificate revocation methods.</summary>
	[Flags]
	[Native]
	public enum SecRevocation : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		OCSPMethod = 1,
		/// <summary>To be added.</summary>
		CRLMethod = 2,
		/// <summary>To be added.</summary>
		PreferCRL = 4,
		/// <summary>To be added.</summary>
		RequirePositiveResponse = 8,
		/// <summary>To be added.</summary>
		NetworkAccessDisabled = 16,
		/// <summary>To be added.</summary>
		UseAnyAvailableMethod = 3,
	}
}
