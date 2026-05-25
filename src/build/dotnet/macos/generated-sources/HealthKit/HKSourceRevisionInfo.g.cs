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
namespace HealthKit {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class HKSourceRevisionInfo  {
		/// <summary>Represents the value associated with the constant 'HKSourceRevisionAnyOperatingSystem'.</summary>
		[Field ("HKSourceRevisionAnyOperatingSystem",  "HealthKit")]
		public static NSOperatingSystemVersion AnyOperatingSystem {
			get {
				return Dlfcn.GetStruct<Foundation.NSOperatingSystemVersion> (Libraries.HealthKit.Handle, "HKSourceRevisionAnyOperatingSystem");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnyProductType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKSourceRevisionAnyProductType",  "HealthKit")]
		public static NSString AnyProductType {
			get {
				if (_AnyProductType is null)
					_AnyProductType = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKSourceRevisionAnyProductType")!;
				return _AnyProductType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnyVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKSourceRevisionAnyVersion",  "HealthKit")]
		public static NSString AnyVersion {
			get {
				if (_AnyVersion is null)
					_AnyVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKSourceRevisionAnyVersion")!;
				return _AnyVersion;
			}
		}
	} /* class HKSourceRevisionInfo */
}
