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
namespace HealthKit {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	internal unsafe static partial class HKDetailedCdaErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValidationErrorKey;
		/// <summary>Represents the value associated with the constant 'HKDetailedCDAValidationErrorKey'.</summary>
		[Field ("HKDetailedCDAValidationErrorKey",  "HealthKit")]
		public static NSString ValidationErrorKey {
			get {
				if (_ValidationErrorKey is null)
					_ValidationErrorKey = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDetailedCDAValidationErrorKey")!;
				return _ValidationErrorKey;
			}
		}
	} /* class HKDetailedCdaErrorKeys */
}
