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
namespace FileProvider {
	/// <summary>Defines constants regarding errors regarding keys of the file provider enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSFileProviderErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollidingItemKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFileProviderErrorCollidingItemKey",  "FileProvider")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSFileProviderErrorItemKey' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSFileProviderErrorItemKey' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString CollidingItemKey {
			[UnsupportedOSPlatform ("macos")]
			[ObsoletedOSPlatform ("ios13.0", "Use 'NSFileProviderErrorItemKey' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSFileProviderErrorItemKey' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_CollidingItemKey is null)
					_CollidingItemKey = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderErrorCollidingItemKey")!;
				return _CollidingItemKey;
			}
		}
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
