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
namespace CoreMidi {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class MidiUmpEndpointManagerDictionaryKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UmpEndpointObject;
		/// <summary>Represents the value associated with the constant 'MIDIUMPEndpointObjectKey'.</summary>
		[Field ("MIDIUMPEndpointObjectKey",  "CoreMidi")]
		public static NSString UmpEndpointObject {
			get {
				if (_UmpEndpointObject is null)
					_UmpEndpointObject = Dlfcn.GetStringConstant (Libraries.CoreMidi.Handle, "MIDIUMPEndpointObjectKey")!;
				return _UmpEndpointObject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UmpFunctionBlockObject;
		/// <summary>Represents the value associated with the constant 'MIDIUMPFunctionBlockObjectKey'.</summary>
		[Field ("MIDIUMPFunctionBlockObjectKey",  "CoreMidi")]
		public static NSString UmpFunctionBlockObject {
			get {
				if (_UmpFunctionBlockObject is null)
					_UmpFunctionBlockObject = Dlfcn.GetStringConstant (Libraries.CoreMidi.Handle, "MIDIUMPFunctionBlockObjectKey")!;
				return _UmpFunctionBlockObject;
			}
		}
	} /* class MidiUmpEndpointManagerDictionaryKey */
}
