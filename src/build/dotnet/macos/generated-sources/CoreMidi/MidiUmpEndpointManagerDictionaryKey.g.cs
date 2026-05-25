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
