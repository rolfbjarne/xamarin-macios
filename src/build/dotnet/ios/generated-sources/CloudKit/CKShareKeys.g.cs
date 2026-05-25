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
namespace CloudKit {
	/// <summary>Constants used by various CloudKit classes.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CKShareKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailImageData;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKShareThumbnailImageDataKey",  "CloudKit")]
		public static NSString ThumbnailImageData {
			get {
				if (_ThumbnailImageData is null)
					_ThumbnailImageData = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKShareThumbnailImageDataKey")!;
				return _ThumbnailImageData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Title;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKShareTitleKey",  "CloudKit")]
		public static NSString Title {
			get {
				if (_Title is null)
					_Title = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKShareTitleKey")!;
				return _Title;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKShareTypeKey",  "CloudKit")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKShareTypeKey")!;
				return _Type;
			}
		}
	} /* class CKShareKeys */
}
