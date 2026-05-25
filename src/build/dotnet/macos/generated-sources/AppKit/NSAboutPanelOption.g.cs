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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSAboutPanelOption  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationIcon;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAboutPanelOptionApplicationIcon",  "AppKit")]
		public static NSString ApplicationIcon {
			get {
				if (_ApplicationIcon is null)
					_ApplicationIcon = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationIcon")!;
				return _ApplicationIcon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAboutPanelOptionApplicationName",  "AppKit")]
		public static NSString ApplicationName {
			get {
				if (_ApplicationName is null)
					_ApplicationName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationName")!;
				return _ApplicationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAboutPanelOptionApplicationVersion",  "AppKit")]
		public static NSString ApplicationVersion {
			get {
				if (_ApplicationVersion is null)
					_ApplicationVersion = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationVersion")!;
				return _ApplicationVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Credits;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAboutPanelOptionCredits",  "AppKit")]
		public static NSString Credits {
			get {
				if (_Credits is null)
					_Credits = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAboutPanelOptionCredits")!;
				return _Credits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Version;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAboutPanelOptionVersion",  "AppKit")]
		public static NSString Version {
			get {
				if (_Version is null)
					_Version = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAboutPanelOptionVersion")!;
				return _Version;
			}
		}
	} /* class NSAboutPanelOption */
}
