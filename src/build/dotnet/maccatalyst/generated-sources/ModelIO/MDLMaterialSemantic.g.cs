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
	/// <summary>Enumerates the semantics of an <see cref="T:ModelIO.MDLMaterialProperty" />.</summary>
	[Native]
	public enum MDLMaterialSemantic : ulong {
		/// <summary>The property represents the base color of a surface.</summary>
		BaseColor = 0,
		/// <summary>The property represents the degree of subsurface light penetration.</summary>
		Subsurface = 1,
		/// <summary>The property represents the degree that a surface appears metallic.</summary>
		Metallic = 2,
		/// <summary>The property represents the intensity of specular highligths.</summary>
		Specular = 3,
		/// <summary>The property represents the Blinn-Phong exponent.</summary>
		SpecularExponent = 4,
		/// <summary>The property represents the balance between light color and surface color for specular highligts.</summary>
		SpecularTint = 5,
		/// <summary>The property represents the roughness of the material.</summary>
		Roughness = 6,
		/// <summary>The property represents the degree of elongation in the tangential direction.</summary>
		Anisotropic = 7,
		/// <summary>The property represents the angle of anisotropy relative to the tangent direction. <c>[0.0, 1.0]</c> maps to <c>[0.0, 2*PI] radians</c>. </summary>
		AnisotropicRotation = 8,
		/// <summary>The property represents the intensity of glancing highligths.</summary>
		Sheen = 9,
		/// <summary>The property represents the tint of glancing highligths.</summary>
		SheenTint = 10,
		/// <summary>The property represents the intensity of added specular highlights.</summary>
		Clearcoat = 11,
		/// <summary>The property represents the spread of added specular highlights.</summary>
		ClearcoatGloss = 12,
		/// <summary>The property represents the color of surface radiance.</summary>
		Emission = 13,
		/// <summary>The property represents the magnitude of the bump perturbation of a surface.</summary>
		Bump = 14,
		/// <summary>The property represents the opacity of the material.</summary>
		Opacity = 15,
		/// <summary>The property represents the n1 term in Schlick's approximation of the Fresnel factor in specular relection.</summary>
		InterfaceIndexOfRefraction = 16,
		/// <summary>The property represents the n2 term in Schlick's approximation of the Fresnel factor in specular relection.</summary>
		MaterialIndexOfRefraction = 17,
		/// <summary>The property represents the variation in normal vectors for a material, in the tangent coordinate system.</summary>
		ObjectSpaceNormal = 18,
		/// <summary>The property represents the variation in normal vectors for a material, in the tangent coordinate system.</summary>
		TangentSpaceNormal = 19,
		/// <summary>The property represents the displacement of a surface material in the normal direction.</summary>
		Displacement = 20,
		/// <summary>The property represents the magnitude of the displacement of a surface material in the normal direction.</summary>
		DisplacementScale = 21,
		/// <summary>The property represents the reduction in ambient light due to neighboring geometry on a surface.</summary>
		AmbientOcclusion = 22,
		/// <summary>The property represents the scaling factor for ambient occlusion.</summary>
		AmbientOcclusionScale = 23,
		/// <summary>The property's semantics have not been set.</summary>
		None = 32768,
		/// <summary>The property represents a user-defined semantic.</summary>
		UserDefined = 32769,
	}
}
