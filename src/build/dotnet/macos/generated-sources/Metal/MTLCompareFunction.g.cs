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
namespace Metal {
	/// <summary>Holds a comparison test. When the comparison test passes, the incoming fragment is compared to the stored data at the specified location.</summary>
	[Native]
	public enum MTLCompareFunction : ulong {
		/// <summary>To be added.</summary>
		Never = 0,
		/// <summary>To be added.</summary>
		Less = 1,
		/// <summary>To be added.</summary>
		Equal = 2,
		/// <summary>To be added.</summary>
		LessEqual = 3,
		/// <summary>To be added.</summary>
		Greater = 4,
		/// <summary>To be added.</summary>
		NotEqual = 5,
		/// <summary>To be added.</summary>
		GreaterEqual = 6,
		/// <summary>To be added.</summary>
		Always = 7,
	}
}
