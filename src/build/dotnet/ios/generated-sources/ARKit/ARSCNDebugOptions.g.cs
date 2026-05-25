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
namespace ARKit {
	/// <summary>Visualization options for use with the <see cref="SceneKit.SCNView.DebugOptions" /> property of <see cref="T:ARKit.ARSCNView" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class ARSCNDebugOptions  {
		/// <summary>The point cloud being used by image processing will be shown as a series of + shapes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("ARSCNDebugOptionShowFeaturePoints",  "ARKit")]
		public static global::SceneKit.SCNDebugOptions ShowFeaturePoints {
			get {
				return (SCNDebugOptions) (ulong) Dlfcn.GetNUInt (Libraries.ARKit.Handle, "ARSCNDebugOptionShowFeaturePoints");
			}
		}
		/// <summary>The [0, 0, 0] coordinate of the world coordinate system will be displayed as a large heavy + shape.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("ARSCNDebugOptionShowWorldOrigin",  "ARKit")]
		public static global::SceneKit.SCNDebugOptions ShowWorldOrigin {
			get {
				return (SCNDebugOptions) (ulong) Dlfcn.GetNUInt (Libraries.ARKit.Handle, "ARSCNDebugOptionShowWorldOrigin");
			}
		}
	} /* class ARSCNDebugOptions */
}
