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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class CHHapticPatternDefinitionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventDurationKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventDuration'.</summary>
		[Field ("CHHapticPatternKeyEventDuration",  "CoreHaptics")]
		public static NSString EventDurationKey {
			get {
				if (_EventDurationKey is null)
					_EventDurationKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventDuration")!;
				return _EventDurationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEvent'.</summary>
		[Field ("CHHapticPatternKeyEvent",  "CoreHaptics")]
		public static NSString EventKey {
			get {
				if (_EventKey is null)
					_EventKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEvent")!;
				return _EventKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventParametersKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventParameters'.</summary>
		[Field ("CHHapticPatternKeyEventParameters",  "CoreHaptics")]
		public static NSString EventParametersKey {
			get {
				if (_EventParametersKey is null)
					_EventParametersKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventParameters")!;
				return _EventParametersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventTypeKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventType'.</summary>
		[Field ("CHHapticPatternKeyEventType",  "CoreHaptics")]
		public static NSString EventTypeKey {
			get {
				if (_EventTypeKey is null)
					_EventTypeKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventType")!;
				return _EventTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventWaveformLoopEnabledKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventWaveformLoopEnabled'.</summary>
		[Field ("CHHapticPatternKeyEventWaveformLoopEnabled",  "CoreHaptics")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString EventWaveformLoopEnabledKey {
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_EventWaveformLoopEnabledKey is null)
					_EventWaveformLoopEnabledKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventWaveformLoopEnabled")!;
				return _EventWaveformLoopEnabledKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventWaveformPathKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventWaveformPath'.</summary>
		[Field ("CHHapticPatternKeyEventWaveformPath",  "CoreHaptics")]
		public static NSString EventWaveformPathKey {
			get {
				if (_EventWaveformPathKey is null)
					_EventWaveformPathKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventWaveformPath")!;
				return _EventWaveformPathKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EventWaveformUseVolumeEnvelopeKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyEventWaveformUseVolumeEnvelope'.</summary>
		[Field ("CHHapticPatternKeyEventWaveformUseVolumeEnvelope",  "CoreHaptics")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EventWaveformUseVolumeEnvelopeKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EventWaveformUseVolumeEnvelopeKey is null)
					_EventWaveformUseVolumeEnvelopeKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyEventWaveformUseVolumeEnvelope")!;
				return _EventWaveformUseVolumeEnvelopeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParameterCurveControlPointsKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyParameterCurveControlPoints'.</summary>
		[Field ("CHHapticPatternKeyParameterCurveControlPoints",  "CoreHaptics")]
		public static NSString ParameterCurveControlPointsKey {
			get {
				if (_ParameterCurveControlPointsKey is null)
					_ParameterCurveControlPointsKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyParameterCurveControlPoints")!;
				return _ParameterCurveControlPointsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParameterCurveKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyParameterCurve'.</summary>
		[Field ("CHHapticPatternKeyParameterCurve",  "CoreHaptics")]
		public static NSString ParameterCurveKey {
			get {
				if (_ParameterCurveKey is null)
					_ParameterCurveKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyParameterCurve")!;
				return _ParameterCurveKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParameterIdKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyParameterID'.</summary>
		[Field ("CHHapticPatternKeyParameterID",  "CoreHaptics")]
		public static NSString ParameterIdKey {
			get {
				if (_ParameterIdKey is null)
					_ParameterIdKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyParameterID")!;
				return _ParameterIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParameterKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyParameter'.</summary>
		[Field ("CHHapticPatternKeyParameter",  "CoreHaptics")]
		public static NSString ParameterKey {
			get {
				if (_ParameterKey is null)
					_ParameterKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyParameter")!;
				return _ParameterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParameterValueKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyParameterValue'.</summary>
		[Field ("CHHapticPatternKeyParameterValue",  "CoreHaptics")]
		public static NSString ParameterValueKey {
			get {
				if (_ParameterValueKey is null)
					_ParameterValueKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyParameterValue")!;
				return _ParameterValueKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PatternKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyPattern'.</summary>
		[Field ("CHHapticPatternKeyPattern",  "CoreHaptics")]
		public static NSString PatternKey {
			get {
				if (_PatternKey is null)
					_PatternKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyPattern")!;
				return _PatternKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyTime'.</summary>
		[Field ("CHHapticPatternKeyTime",  "CoreHaptics")]
		public static NSString TimeKey {
			get {
				if (_TimeKey is null)
					_TimeKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyTime")!;
				return _TimeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VersionKey;
		/// <summary>Represents the value associated with the constant 'CHHapticPatternKeyVersion'.</summary>
		[Field ("CHHapticPatternKeyVersion",  "CoreHaptics")]
		public static NSString VersionKey {
			get {
				if (_VersionKey is null)
					_VersionKey = Dlfcn.GetStringConstant (Libraries.CoreHaptics.Handle, "CHHapticPatternKeyVersion")!;
				return _VersionKey;
			}
		}
	} /* class CHHapticPatternDefinitionKeys */
}
