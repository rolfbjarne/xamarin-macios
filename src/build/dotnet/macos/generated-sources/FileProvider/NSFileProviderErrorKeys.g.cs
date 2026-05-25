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
namespace FileProvider {
	/// <summary>Defines constants regarding errors regarding keys of the file provider enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSFileProviderErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemKey;
		/// <summary>Represents the value associated with the constant 'NSFileProviderErrorItemKey'.</summary>
		[Field ("NSFileProviderErrorItemKey",  "FileProvider")]
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ItemKey {
			[SupportedOSPlatform ("ios15.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ItemKey is null)
					_ItemKey = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderErrorItemKey")!;
				return _ItemKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NonExistentItemIdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFileProviderErrorNonExistentItemIdentifierKey",  "FileProvider")]
		public static NSString NonExistentItemIdentifierKey {
			get {
				if (_NonExistentItemIdentifierKey is null)
					_NonExistentItemIdentifierKey = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderErrorNonExistentItemIdentifierKey")!;
				return _NonExistentItemIdentifierKey;
			}
		}
	} /* class NSFileProviderErrorKeys */
}
