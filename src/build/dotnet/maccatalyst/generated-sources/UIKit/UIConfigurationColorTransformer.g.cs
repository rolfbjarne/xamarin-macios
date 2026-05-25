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
namespace UIKit {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UIConfigurationColorTransformer  {
		/// <summary>Represents the value associated with the constant 'UIConfigurationColorTransformerGrayscale'.</summary>
		[Field ("UIConfigurationColorTransformerGrayscale",  "UIKit")]
		internal static nint _Grayscale {
			get {
				return Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIConfigurationColorTransformerGrayscale");
			}
		}
		/// <summary>Represents the value associated with the constant 'UIConfigurationColorTransformerMonochromeTint'.</summary>
		[Obsolete ("Use the 'MonochromeTint' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIConfigurationColorTransformerMonochromeTint",  "UIKit")]
		public static nint _MonochromeTint {
			get {
				return Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIConfigurationColorTransformerMonochromeTint");
			}
		}
		/// <summary>Represents the value associated with the constant 'UIConfigurationColorTransformerPreferredTint'.</summary>
		[Obsolete ("Use the 'PreferredTint' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIConfigurationColorTransformerPreferredTint",  "UIKit")]
		public static nint _PreferredTint {
			get {
				return Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIConfigurationColorTransformerPreferredTint");
			}
		}
	} /* class UIConfigurationColorTransformer */
}
