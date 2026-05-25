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
	/// <summary>Defines keys for use with <see cref="M:SceneKit.SCNNodeRendererDelegate.Render(SceneKit.SCNNode,SceneKit.SCNRenderer,Foundation.NSDictionary)" /> and <see cref="M:SceneKit.SCNProgram.SetSemantic(Foundation.NSString,System.String,SceneKit.SCNProgramSemanticOptions)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNRenderingArguments  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModelTransform;
		/// <summary>Represents the value associated with the constant SCNModelTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNModelTransform",  "SceneKit")]
		public static NSString ModelTransform {
			get {
				if (_ModelTransform is null)
					_ModelTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNModelTransform")!;
				return _ModelTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModelViewProjectionTransform;
		/// <summary>Represents the value associated with the constant SCNModelViewProjectionTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNModelViewProjectionTransform",  "SceneKit")]
		public static NSString ModelViewProjectionTransform {
			get {
				if (_ModelViewProjectionTransform is null)
					_ModelViewProjectionTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNModelViewProjectionTransform")!;
				return _ModelViewProjectionTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModelViewTransform;
		/// <summary>Represents the value associated with the constant SCNModelViewTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNModelViewTransform",  "SceneKit")]
		public static NSString ModelViewTransform {
			get {
				if (_ModelViewTransform is null)
					_ModelViewTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNModelViewTransform")!;
				return _ModelViewTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NormalTransform;
		/// <summary>Represents the value associated with the constant SCNNormalTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNNormalTransform",  "SceneKit")]
		public static NSString NormalTransform {
			get {
				if (_NormalTransform is null)
					_NormalTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNNormalTransform")!;
				return _NormalTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProjectionTransform;
		/// <summary>Represents the value associated with the constant SCNProjectionTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNProjectionTransform",  "SceneKit")]
		public static NSString ProjectionTransform {
			get {
				if (_ProjectionTransform is null)
					_ProjectionTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNProjectionTransform")!;
				return _ProjectionTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewTransform;
		/// <summary>Represents the value associated with the constant SCNViewTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNViewTransform",  "SceneKit")]
		public static NSString ViewTransform {
			get {
				if (_ViewTransform is null)
					_ViewTransform = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNViewTransform")!;
				return _ViewTransform;
			}
		}
	} /* class SCNRenderingArguments */
}
