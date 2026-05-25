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
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> containing options for shaders.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNShaderModifiers : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNShaderModifiers" /> with default (empty) values.</summary>
		public SCNShaderModifiers () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNShaderModifiers" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNShaderModifiers (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Represents the value associated with the constant SCNShaderModifierEntryPointGeometry</summary><value></value><remarks>To be added.</remarks>
		public string? EntryPointGeometry {
			get {
				return GetStringValue (_SCNShaderModifiers.EntryPointGeometryKey!);
			}
			set {
				SetStringValue (_SCNShaderModifiers.EntryPointGeometryKey!, value);
			}
		}
		/// <summary>Represents the value associated with the constant SCNShaderModifierEntryPointSurface</summary><value></value><remarks>To be added.</remarks>
		public string? EntryPointSurface {
			get {
				return GetStringValue (_SCNShaderModifiers.EntryPointSurfaceKey!);
			}
			set {
				SetStringValue (_SCNShaderModifiers.EntryPointSurfaceKey!, value);
			}
		}
		/// <summary>Represents the value associated with the constant SCNShaderModifierEntryPointLightingModel</summary><value></value><remarks>To be added.</remarks>
		public string? EntryPointLightingModel {
			get {
				return GetStringValue (_SCNShaderModifiers.EntryPointLightingModelKey!);
			}
			set {
				SetStringValue (_SCNShaderModifiers.EntryPointLightingModelKey!, value);
			}
		}
		/// <summary>Represents the value associated with the constant SCNShaderModifierEntryPointFragment</summary><value></value><remarks>To be added.</remarks>
		public string? EntryPointFragment {
			get {
				return GetStringValue (_SCNShaderModifiers.EntryPointFragmentKey!);
			}
			set {
				SetStringValue (_SCNShaderModifiers.EntryPointFragmentKey!, value);
			}
		}
#endif
	}
}
