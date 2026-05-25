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
namespace SceneKit {
	/// <summary>Contains values that control searching, backface culling, and collision testing.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNPhysicsTestKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackfaceCullingKey;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestBackfaceCullingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestBackfaceCullingKey",  "SceneKit")]
		public static NSString BackfaceCullingKey {
			get {
				if (_BackfaceCullingKey is null)
					_BackfaceCullingKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestBackfaceCullingKey")!;
				return _BackfaceCullingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollisionBitMaskKey;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestCollisionBitMaskKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestCollisionBitMaskKey",  "SceneKit")]
		public static NSString CollisionBitMaskKey {
			get {
				if (_CollisionBitMaskKey is null)
					_CollisionBitMaskKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestCollisionBitMaskKey")!;
				return _CollisionBitMaskKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SearchModeKey;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestSearchModeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestSearchModeKey",  "SceneKit")]
		public static NSString SearchModeKey {
			get {
				if (_SearchModeKey is null)
					_SearchModeKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeKey")!;
				return _SearchModeKey;
			}
		}
	} /* class SCNPhysicsTestKeys */
}
