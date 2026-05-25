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
namespace AVFoundation {
	/// <summary>Constants identify ISO copyright and tagged characteristic metadata.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class Iso  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataCopyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierISOUserDataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierISOUserDataCopyright",  "AVFoundation")]
			public static NSString UserDataCopyright {
				get {
					if (_UserDataCopyright is null)
						_UserDataCopyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataCopyright")!;
					return _UserDataCopyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataDate;
			/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierISOUserDataDate",  "AVFoundation")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString UserDataDate {
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_UserDataDate is null)
						_UserDataDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataDate")!;
					return _UserDataDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserDataTaggedCharacteristic;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierISOUserDataTaggedCharacteristic</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierISOUserDataTaggedCharacteristic",  "AVFoundation")]
			public static NSString UserDataTaggedCharacteristic {
				get {
					if (_UserDataTaggedCharacteristic is null)
						_UserDataTaggedCharacteristic = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataTaggedCharacteristic")!;
					return _UserDataTaggedCharacteristic;
				}
			}
		} /* class Iso */
	}
}
