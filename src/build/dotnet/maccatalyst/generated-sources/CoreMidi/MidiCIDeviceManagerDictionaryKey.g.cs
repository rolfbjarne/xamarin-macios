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
namespace CoreMidi {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class MidiCIDeviceManagerDictionaryKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIDeviceObject;
		/// <summary>Represents the value associated with the constant 'MIDICIDeviceObjectKey'.</summary>
		[Field ("MIDICIDeviceObjectKey",  "CoreMidi")]
		public static NSString CIDeviceObject {
			get {
				if (_CIDeviceObject is null)
					_CIDeviceObject = Dlfcn.GetStringConstant (Libraries.CoreMidi.Handle, "MIDICIDeviceObjectKey")!;
				return _CIDeviceObject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIProfileObjectKey;
		/// <summary>Represents the value associated with the constant 'MIDICIProfileObjectKey'.</summary>
		[Field ("MIDICIProfileObjectKey",  "CoreMidi")]
		public static NSString CIProfileObjectKey {
			get {
				if (_CIProfileObjectKey is null)
					_CIProfileObjectKey = Dlfcn.GetStringConstant (Libraries.CoreMidi.Handle, "MIDICIProfileObjectKey")!;
				return _CIProfileObjectKey;
			}
		}
	} /* class MidiCIDeviceManagerDictionaryKey */
}
