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
namespace SceneKit {
	/// <summary>Enumerates vertex mode attributes.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNGeometrySourceSemantic  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoneIndices;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticBoneIndices</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticBoneIndices",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BoneIndices {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BoneIndices is null)
					_BoneIndices = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticBoneIndices")!;
				return _BoneIndices;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoneWeights;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticBoneWeights</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticBoneWeights",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BoneWeights {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BoneWeights is null)
					_BoneWeights = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticBoneWeights")!;
				return _BoneWeights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Color;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticColor</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticColor",  "SceneKit")]
		public static NSString Color {
			get {
				if (_Color is null)
					_Color = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticColor")!;
				return _Color;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EdgeCrease;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticEdgeCrease</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticEdgeCrease",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EdgeCrease {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EdgeCrease is null)
					_EdgeCrease = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticEdgeCrease")!;
				return _EdgeCrease;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Normal;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticNormal</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticNormal",  "SceneKit")]
		public static NSString Normal {
			get {
				if (_Normal is null)
					_Normal = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticNormal")!;
				return _Normal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Tangent;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticTangent",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Tangent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Tangent is null)
					_Tangent = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticTangent")!;
				return _Tangent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Texcoord;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticTexcoord</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticTexcoord",  "SceneKit")]
		public static NSString Texcoord {
			get {
				if (_Texcoord is null)
					_Texcoord = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticTexcoord")!;
				return _Texcoord;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Vertex;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticVertex</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticVertex",  "SceneKit")]
		public static NSString Vertex {
			get {
				if (_Vertex is null)
					_Vertex = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticVertex")!;
				return _Vertex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VertexCrease;
		/// <summary>Represents the value associated with the constant SCNGeometrySourceSemanticVertexCrease</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNGeometrySourceSemanticVertexCrease",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VertexCrease {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VertexCrease is null)
					_VertexCrease = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticVertexCrease")!;
				return _VertexCrease;
			}
		}
	} /* class SCNGeometrySourceSemantic */
}
