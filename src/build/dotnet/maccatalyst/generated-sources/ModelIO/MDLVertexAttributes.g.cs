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
namespace ModelIO {
	/// <summary>Contains valid vertex attribute names.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MDLVertexAttributes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Anisotropy;
		/// <summary>The vertex attribute data describe the degree to which the surface changes appearance with rotation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeAnisotropy",  "ModelIO")]
		public static NSString Anisotropy {
			get {
				if (_Anisotropy is null)
					_Anisotropy = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeAnisotropy")!;
				return _Anisotropy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Binormal;
		/// <summary>The vertex attribute data describe binormal vector data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeBinormal",  "ModelIO")]
		public static NSString Binormal {
			get {
				if (_Binormal is null)
					_Binormal = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeBinormal")!;
				return _Binormal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bitangent;
		/// <summary>The vertex attribute data describe bitangent vector data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeBitangent",  "ModelIO")]
		public static NSString Bitangent {
			get {
				if (_Bitangent is null)
					_Bitangent = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeBitangent")!;
				return _Bitangent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Color;
		/// <summary>The vertex attribute data describe color data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeColor",  "ModelIO")]
		public static NSString Color {
			get {
				if (_Color is null)
					_Color = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeColor")!;
				return _Color;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EdgeCrease;
		/// <summary>The vertex attribute data describe edges that should not be modified during subdivision.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeEdgeCrease",  "ModelIO")]
		public static NSString EdgeCrease {
			get {
				if (_EdgeCrease is null)
					_EdgeCrease = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeEdgeCrease")!;
				return _EdgeCrease;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JointIndices;
		/// <summary>The vertex attribute data describe joint index data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeJointIndices",  "ModelIO")]
		public static NSString JointIndices {
			get {
				if (_JointIndices is null)
					_JointIndices = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeJointIndices")!;
				return _JointIndices;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JointWeights;
		/// <summary>The vertex attribute data describe joint weight data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeJointWeights",  "ModelIO")]
		public static NSString JointWeights {
			get {
				if (_JointWeights is null)
					_JointWeights = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeJointWeights")!;
				return _JointWeights;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Normal;
		/// <summary>The vertex attribute data describe a normal vector.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeNormal",  "ModelIO")]
		public static NSString Normal {
			get {
				if (_Normal is null)
					_Normal = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeNormal")!;
				return _Normal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OcclusionValue;
		/// <summary>The vertex attribute data describe ambient occlusion data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeOcclusionValue",  "ModelIO")]
		public static NSString OcclusionValue {
			get {
				if (_OcclusionValue is null)
					_OcclusionValue = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeOcclusionValue")!;
				return _OcclusionValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Position;
		/// <summary>The vertex attribute data describe position data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributePosition",  "ModelIO")]
		public static NSString Position {
			get {
				if (_Position is null)
					_Position = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributePosition")!;
				return _Position;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadingBasisU;
		/// <summary>The vertex attribute data describe the U component of a shading basis.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeShadingBasisU",  "ModelIO")]
		public static NSString ShadingBasisU {
			get {
				if (_ShadingBasisU is null)
					_ShadingBasisU = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeShadingBasisU")!;
				return _ShadingBasisU;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadingBasisV;
		/// <summary>The vertex attribute data describe the V component of a shading basis.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeShadingBasisV",  "ModelIO")]
		public static NSString ShadingBasisV {
			get {
				if (_ShadingBasisV is null)
					_ShadingBasisV = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeShadingBasisV")!;
				return _ShadingBasisV;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubdivisionStencil;
		/// <summary>The vertex attribute data describe data that control which neighboring vertices control subdivision.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeSubdivisionStencil",  "ModelIO")]
		public static NSString SubdivisionStencil {
			get {
				if (_SubdivisionStencil is null)
					_SubdivisionStencil = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeSubdivisionStencil")!;
				return _SubdivisionStencil;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Tangent;
		/// <summary>The vertex attribute data describe tangent vectors.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeTangent",  "ModelIO")]
		public static NSString Tangent {
			get {
				if (_Tangent is null)
					_Tangent = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeTangent")!;
				return _Tangent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextureCoordinate;
		/// <summary>The vertex attribute data describe texture coordinates.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MDLVertexAttributeTextureCoordinate",  "ModelIO")]
		public static NSString TextureCoordinate {
			get {
				if (_TextureCoordinate is null)
					_TextureCoordinate = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "MDLVertexAttributeTextureCoordinate")!;
				return _TextureCoordinate;
			}
		}
	} /* class MDLVertexAttributes */
}
