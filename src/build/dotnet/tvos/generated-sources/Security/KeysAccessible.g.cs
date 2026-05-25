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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Security {
	internal unsafe static partial class KeysAccessible  {
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleAfterFirstUnlock'.</summary>
		[Field ("kSecAttrAccessibleAfterFirstUnlock",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint AfterFirstUnlock {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleAfterFirstUnlock");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly'.</summary>
		[Field ("kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint AfterFirstUnlockThisDeviceOnly {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleAlways'.</summary>
		[Field ("kSecAttrAccessibleAlways",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint Always {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleAlways");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleAlwaysThisDeviceOnly'.</summary>
		[Field ("kSecAttrAccessibleAlwaysThisDeviceOnly",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint AlwaysThisDeviceOnly {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleAlwaysThisDeviceOnly");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly'.</summary>
		[Field ("kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint WhenPasscodeSetThisDeviceOnly {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleWhenUnlocked'.</summary>
		[Field ("kSecAttrAccessibleWhenUnlocked",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint WhenUnlocked {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleWhenUnlocked");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessibleWhenUnlockedThisDeviceOnly'.</summary>
		[Field ("kSecAttrAccessibleWhenUnlockedThisDeviceOnly",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint WhenUnlockedThisDeviceOnly {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessibleWhenUnlockedThisDeviceOnly");
			}
		}
	} /* class KeysAccessible */
}
