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
namespace CoreImage {
	/// <summary>Contains options for core image filter user interfaces.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CIUIParameterSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Advanced;
		/// <summary>Advanced user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetAdvanced",  "CoreImage")]
		public static NSString Advanced {
			get {
				if (_Advanced is null)
					_Advanced = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIUISetAdvanced")!;
				return _Advanced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Basic;
		/// <summary>Basic  user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetBasic",  "CoreImage")]
		public static NSString Basic {
			get {
				if (_Basic is null)
					_Basic = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIUISetBasic")!;
				return _Basic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Development;
		/// <summary>Development user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetDevelopment",  "CoreImage")]
		public static NSString Development {
			get {
				if (_Development is null)
					_Development = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIUISetDevelopment")!;
				return _Development;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Intermediate;
		/// <summary>Intermediate user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetIntermediate",  "CoreImage")]
		public static NSString Intermediate {
			get {
				if (_Intermediate is null)
					_Intermediate = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIUISetIntermediate")!;
				return _Intermediate;
			}
		}
	} /* class CIUIParameterSet */
}
