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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalKit {
	/// <summary>Contains a dictionary of texture loading options and exposes them as discoverably named properties.</summary>
	public partial class MTKTextureLoaderOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="MTKTextureLoaderOptions" /> with default (empty) values.</summary>
		public MTKTextureLoaderOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="MTKTextureLoaderOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public MTKTextureLoaderOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets a Boolean value that tells whether to allocate mipmap memory when loading the texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? AllocateMipmaps {
			get {
				return  GetBoolValue (MTKTextureLoaderKeys.AllocateMipmapsKey!);
			}
			set {
				SetBooleanValue (MTKTextureLoaderKeys.AllocateMipmapsKey!, value);
			}
		}
		/// <summary>Gets a value that tells whether mipmaps will be created for the new texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? GenerateMipmaps {
			get {
				return  GetBoolValue (MTKTextureLoaderKeys.GenerateMipmapsKey!);
			}
			set {
				SetBooleanValue (MTKTextureLoaderKeys.GenerateMipmapsKey!, value);
			}
		}
		/// <summary>Gets a Boolean value that tells whether the texture should be loaded from the sRGB color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? Srgb {
			get {
				return  GetBoolValue (MTKTextureLoaderKeys.SrgbKey!);
			}
			set {
				SetBooleanValue (MTKTextureLoaderKeys.SrgbKey!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? LoadAsArray {
			get {
				return  GetBoolValue (MTKTextureLoaderKeys.LoadAsArrayKey!);
			}
			set {
				SetBooleanValue (MTKTextureLoaderKeys.LoadAsArrayKey!, value);
			}
		}
#endif
	}
}
