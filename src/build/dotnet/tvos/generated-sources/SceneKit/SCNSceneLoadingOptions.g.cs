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
	/// <summary>Options for scene loading.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNSceneLoadingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNSceneLoadingOptions" /> with default (empty) values.</summary>
		public SCNSceneLoadingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNSceneLoadingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNSceneLoadingOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSUrl[]? AssetDirectoryUrls {
			get {
				return GetArray<NSUrl> (SCNSceneSourceLoading.AssetDirectoryUrlsKey!);
			}
			set {
				SetArrayValue (SCNSceneSourceLoading.AssetDirectoryUrlsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? CreateNormalsIfAbsent {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.CreateNormalsIfAbsentKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.CreateNormalsIfAbsentKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? FlattenScene {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.FlattenSceneKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.FlattenSceneKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? CheckConsistency {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.CheckConsistencyKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.CheckConsistencyKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? OverrideAssetUrls {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.OverrideAssetUrlsKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.OverrideAssetUrlsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? StrictConformance {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.StrictConformanceKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.StrictConformanceKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? UseSafeMode {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.UseSafeModeKey!);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.UseSafeModeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? PreserveOriginalTopology {
			get {
				return  GetBoolValue (SCNSceneSourceLoading.OptionPreserveOriginalTopology);
			}
			set {
				SetBooleanValue (SCNSceneSourceLoading.OptionPreserveOriginalTopology, value);
			}
		}
		internal NSString? _AnimationImportPolicyKey {
			get {
				return GetNSStringValue (SCNSceneSourceLoading.AnimationImportPolicyKey);
			}
			set {
				SetStringValue (SCNSceneSourceLoading.AnimationImportPolicyKey, value);
			}
		}
#endif
	}
}
