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
namespace Metal {
	/// <summary>Enumerates the ways in which a <see cref="T:Metal.IMTLTexture" /> may be used.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum MTLTextureUsage : ulong {
		/// <summary>A value that indicates that it is not known what the texture usage option is.</summary>
		Unknown = 0,
		/// <summary>A value that indicates that the texture will be read by shaders at any stage in rendering.</summary>
		ShaderRead = 1,
		/// <summary>A value that indicates that the texture will be written to by compute shaders.</summary>
		ShaderWrite = 2,
		/// <summary>A value that indicates that the texture will be used as a color, depth, or stencil render target in a rendering pass.</summary>
		RenderTarget = 4,
		/// <summary>A value that indicates that the texture will be used for creating new textures.</summary>
		PixelFormatView = 16,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		ShaderAtomic = 32,
	}
}
