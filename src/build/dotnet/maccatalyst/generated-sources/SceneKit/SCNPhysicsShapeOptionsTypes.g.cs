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
namespace SceneKit {
	/// <summary>Geometrical type associated with <see cref="T:SceneKit.SCNPhysicsShape" />s.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class SCNPhysicsShapeOptionsTypes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoundingBox;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeTypeBoundingBox</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeTypeBoundingBox",  "SceneKit")]
		public static NSString BoundingBox {
			get {
				if (_BoundingBox is null)
					_BoundingBox = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeBoundingBox")!;
				return _BoundingBox;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConcavePolyhedron;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeTypeConcavePolyhedron</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeTypeConcavePolyhedron",  "SceneKit")]
		public static NSString ConcavePolyhedron {
			get {
				if (_ConcavePolyhedron is null)
					_ConcavePolyhedron = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeConcavePolyhedron")!;
				return _ConcavePolyhedron;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConvexHull;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeTypeConvexHull</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeTypeConvexHull",  "SceneKit")]
		public static NSString ConvexHull {
			get {
				if (_ConvexHull is null)
					_ConvexHull = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeConvexHull")!;
				return _ConvexHull;
			}
		}
	} /* class SCNPhysicsShapeOptionsTypes */
}
