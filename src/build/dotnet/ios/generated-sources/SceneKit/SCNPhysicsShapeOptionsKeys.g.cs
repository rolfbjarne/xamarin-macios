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
	/// <summary>Defines valid keys for use with the <c>options</c> dictionary passed to <see cref="SCNPhysicsShape.Create(SCNGeometry,SCNPhysicsShapeOptions)" /> and <see cref="SCNPhysicsShape.Create(SCNNode,SCNPhysicsShapeOptions)" /> .</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class SCNPhysicsShapeOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollisionMargin;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeOptionCollisionMargin",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CollisionMargin {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CollisionMargin is null)
					_CollisionMargin = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeOptionCollisionMargin")!;
				return _CollisionMargin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeepAsCompound;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeKeepAsCompoundKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeKeepAsCompoundKey",  "SceneKit")]
		public static NSString KeepAsCompound {
			get {
				if (_KeepAsCompound is null)
					_KeepAsCompound = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeKeepAsCompoundKey")!;
				return _KeepAsCompound;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Scale;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeScaleKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeScaleKey",  "SceneKit")]
		public static NSString Scale {
			get {
				if (_Scale is null)
					_Scale = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeScaleKey")!;
				return _Scale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>Represents the value associated with the constant SCNPhysicsShapeTypeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsShapeTypeKey",  "SceneKit")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeKey")!;
				return _Type;
			}
		}
	} /* class SCNPhysicsShapeOptionsKeys */
}
