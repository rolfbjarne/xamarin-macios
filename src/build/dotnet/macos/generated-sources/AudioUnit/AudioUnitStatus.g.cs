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
namespace AudioUnit {
	/// <summary>An enumeration whose values specify the status of an <see cref="T:AudioUnit.AudioUnit" />.</summary>
	public enum AudioUnitStatus : int {
		/// <summary>To be added.</summary>
		NoError = 0,
		/// <summary>To be added.</summary>
		OK = 0,
		/// <summary>To be added.</summary>
		FileNotFound = -43,
		/// <summary>To be added.</summary>
		ParameterError = -50,
		/// <summary>To be added.</summary>
		InvalidProperty = -10879,
		/// <summary>To be added.</summary>
		InvalidParameter = -10878,
		/// <summary>To be added.</summary>
		InvalidElement = -10877,
		/// <summary>To be added.</summary>
		NoConnection = -10876,
		/// <summary>To be added.</summary>
		FailedInitialization = -10875,
		/// <summary>To be added.</summary>
		TooManyFramesToProcess = -10874,
		/// <summary>To be added.</summary>
		InvalidFile = -10871,
		/// <summary>To be added.</summary>
		FormatNotSupported = -10868,
		/// <summary>To be added.</summary>
		Uninitialized = -10867,
		/// <summary>To be added.</summary>
		InvalidScope = -10866,
		/// <summary>To be added.</summary>
		PropertyNotWritable = -10865,
		/// <summary>To be added.</summary>
		CannotDoInCurrentContext = -10863,
		/// <summary>To be added.</summary>
		InvalidPropertyValue = -10851,
		/// <summary>To be added.</summary>
		PropertyNotInUse = -10850,
		/// <summary>To be added.</summary>
		Initialized = -10849,
		/// <summary>To be added.</summary>
		InvalidOfflineRender = -10848,
		/// <summary>To be added.</summary>
		Unauthorized = -10847,
		/// <summary>To be added.</summary>
		MidiOutputBufferFull = -66753,
		RenderTimeout = -66745,
		/// <summary>To be added.</summary>
		InvalidParameterValue = -66743,
		/// <summary>To be added.</summary>
		ExtensionNotFound = -66744,
		InvalidFilePath = -66742,
		MissingKey = -66741,
		ComponentManagerNotSupported = -66740,
		MultipleVoiceProcessors = -66635,
	}
}
