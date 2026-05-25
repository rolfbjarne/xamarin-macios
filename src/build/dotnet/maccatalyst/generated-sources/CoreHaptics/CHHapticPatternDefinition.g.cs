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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class CHHapticPatternDefinition : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CHHapticPatternDefinition" /> with default (empty) values.</summary>
		public CHHapticPatternDefinition () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CHHapticPatternDefinition" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CHHapticPatternDefinition (NSDictionary? dictionary) : base (dictionary) {}
		public double? Version {
			get {
				return  GetDoubleValue (CHHapticPatternDefinitionKeys.VersionKey!);
			}
			set {
				SetNumberValue (CHHapticPatternDefinitionKeys.VersionKey!, value);
			}
		}
		public NSArray? Pattern {
			get {
				return Dictionary [CHHapticPatternDefinitionKeys.PatternKey!] as Foundation.NSArray;
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.PatternKey!, value);
			}
		}
		public NSDictionary? Event {
			get {
				return GetNSDictionary (CHHapticPatternDefinitionKeys.EventKey!);
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.EventKey!, value);
			}
		}
		public CHHapticEventType? EventType {
			get {
				return TryGetNativeValue (CHHapticPatternDefinitionKeys.EventTypeKey!, out var handle) ? global::CoreHaptics.CHHapticEventTypeExtensions.GetNullableValue (handle) : null;
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.EventTypeKey!, value.HasValue ? value.Value.GetConstant () : null);
			}
		}
		public double? Time {
			get {
				return  GetDoubleValue (CHHapticPatternDefinitionKeys.TimeKey!);
			}
			set {
				SetNumberValue (CHHapticPatternDefinitionKeys.TimeKey!, value);
			}
		}
		public double? EventDuration {
			get {
				return  GetDoubleValue (CHHapticPatternDefinitionKeys.EventDurationKey!);
			}
			set {
				SetNumberValue (CHHapticPatternDefinitionKeys.EventDurationKey!, value);
			}
		}
		public NSString? EventWaveformPath {
			get {
				return GetNSStringValue (CHHapticPatternDefinitionKeys.EventWaveformPathKey!);
			}
			set {
				SetStringValue (CHHapticPatternDefinitionKeys.EventWaveformPathKey!, value);
			}
		}
		public NSArray? EventParameters {
			get {
				return Dictionary [CHHapticPatternDefinitionKeys.EventParametersKey!] as Foundation.NSArray;
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.EventParametersKey!, value);
			}
		}
		public NSDictionary? Parameter {
			get {
				return GetNSDictionary (CHHapticPatternDefinitionKeys.ParameterKey!);
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.ParameterKey!, value);
			}
		}
		public NSString? ParameterId {
			get {
				return GetNSStringValue (CHHapticPatternDefinitionKeys.ParameterIdKey!);
			}
			set {
				SetStringValue (CHHapticPatternDefinitionKeys.ParameterIdKey!, value);
			}
		}
		public double? ParameterValue {
			get {
				return  GetDoubleValue (CHHapticPatternDefinitionKeys.ParameterValueKey!);
			}
			set {
				SetNumberValue (CHHapticPatternDefinitionKeys.ParameterValueKey!, value);
			}
		}
		public NSObject? WeakParameterCurve {
			get {
				return GetNativeValue<Foundation.NSObject> (CHHapticPatternDefinitionKeys.ParameterCurveKey!);
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.ParameterCurveKey!, value);
			}
		}
		public NSObject? WeakParameterCurveControlPoints {
			get {
				return GetNativeValue<Foundation.NSObject> (CHHapticPatternDefinitionKeys.ParameterCurveControlPointsKey!);
			}
			set {
				SetNativeValue (CHHapticPatternDefinitionKeys.ParameterCurveControlPointsKey!, value);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? EventWaveformUseVolumeEnvelope {
			get {
				return  GetBoolValue (CHHapticPatternDefinitionKeys.EventWaveformUseVolumeEnvelopeKey!);
			}
			set {
				SetBooleanValue (CHHapticPatternDefinitionKeys.EventWaveformUseVolumeEnvelopeKey!, value);
			}
		}
#endif
	}
}
