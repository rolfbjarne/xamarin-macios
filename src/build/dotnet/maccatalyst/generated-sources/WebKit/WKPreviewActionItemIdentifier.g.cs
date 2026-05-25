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
namespace WebKit {
	/// <summary>Contains preview action type identifiers.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'TBD' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TBD' instead.")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class WKPreviewActionItemIdentifier  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddToReadingList;
		/// <summary>Gets the string that identifies the action that adds the item to the user's reading list.</summary><value>The string that identifies the action that adds the item to the user's reading list.</value><remarks>To be added.</remarks>
		[Field ("WKPreviewActionItemIdentifierAddToReadingList",  "WebKit")]
		public static NSString AddToReadingList {
			get {
				if (_AddToReadingList is null)
					_AddToReadingList = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKPreviewActionItemIdentifierAddToReadingList")!;
				return _AddToReadingList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Copy;
		/// <summary>Gets the string that identifies the action that copies the item.</summary><value>The string that identifies the action that copies the item.</value><remarks>To be added.</remarks>
		[Field ("WKPreviewActionItemIdentifierCopy",  "WebKit")]
		public static NSString Copy {
			get {
				if (_Copy is null)
					_Copy = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKPreviewActionItemIdentifierCopy")!;
				return _Copy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Open;
		/// <summary>Gets the string that identifies the action that opens the item.</summary><value>The string that identifies the action that opens the item.</value><remarks>To be added.</remarks>
		[Field ("WKPreviewActionItemIdentifierOpen",  "WebKit")]
		public static NSString Open {
			get {
				if (_Open is null)
					_Open = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKPreviewActionItemIdentifierOpen")!;
				return _Open;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Share;
		/// <summary>Gets the string that identifies the action that shares the item.</summary><value>The string that identifies the action that shares the item.</value><remarks>To be added.</remarks>
		[Field ("WKPreviewActionItemIdentifierShare",  "WebKit")]
		public static NSString Share {
			get {
				if (_Share is null)
					_Share = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKPreviewActionItemIdentifierShare")!;
				return _Share;
			}
		}
	} /* class WKPreviewActionItemIdentifier */
}
