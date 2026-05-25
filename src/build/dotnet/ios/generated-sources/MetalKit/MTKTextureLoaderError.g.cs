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
namespace MetalKit {
	/// <summary>Key and domain strings for working with texture loading errors.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MTKTextureLoaderError  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Domain;
		/// <summary>Gets the error domain where texture initialization errors are reported.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MTKTextureLoaderErrorDomain",  "MetalKit")]
		public static NSString Domain {
			get {
				if (_Domain is null)
					_Domain = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderErrorDomain")!;
				return _Domain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Key;
		/// <summary>Gets the key that is used to retrieve error information from the <see cref="P:Foundation.NSError.UserInfo" /> property of a texture initialization error.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MTKTextureLoaderErrorKey",  "MetalKit")]
		public static NSString Key {
			get {
				if (_Key is null)
					_Key = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderErrorKey")!;
				return _Key;
			}
		}
	} /* class MTKTextureLoaderError */
}
