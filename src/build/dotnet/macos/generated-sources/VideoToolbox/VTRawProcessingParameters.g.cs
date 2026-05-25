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
namespace VideoToolbox {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public partial class VTRawProcessingParameters : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTRawProcessingParameters" /> with default (empty) values.</summary>
		public VTRawProcessingParameters () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTRawProcessingParameters" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTRawProcessingParameters (NSDictionary? dictionary) : base (dictionary) {}
		public string? Key {
			get {
				return GetStringValue (VTRawProcessingParameterKey.Key!);
			}
			set {
				SetStringValue (VTRawProcessingParameterKey.Key!, value);
			}
		}
		public string? Name {
			get {
				return GetStringValue (VTRawProcessingParameterKey.Name!);
			}
			set {
				SetStringValue (VTRawProcessingParameterKey.Name!, value);
			}
		}
		public string? Description {
			get {
				return GetStringValue (VTRawProcessingParameterKey.Description!);
			}
			set {
				SetStringValue (VTRawProcessingParameterKey.Description!, value);
			}
		}
		public bool? Enabled {
			get {
				return  GetBoolValue (VTRawProcessingParameterKey.Enabled!);
			}
			set {
				SetBooleanValue (VTRawProcessingParameterKey.Enabled!, value);
			}
		}
		public VTRawProcessingParameterValueType? ValueType {
			get {
				return GetStrongDictionary<VTRawProcessingParameterValueType>(VTRawProcessingParameterKey.ValueType!, (dict) => new VTRawProcessingParameterValueType (dict));
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.ValueType!, value?.Dictionary);
			}
		}
		public NSObject? MaximumValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.MaximumValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.MaximumValue!, value);
			}
		}
		public NSObject? MinimumValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.MinimumValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.MinimumValue!, value);
			}
		}
		public NSObject? InitialValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.InitialValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.InitialValue!, value);
			}
		}
		public NSObject? NeutralValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.NeutralValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.NeutralValue!, value);
			}
		}
		public NSObject? CameraValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.CameraValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.CameraValue!, value);
			}
		}
		public NSObject? CurrentValue {
			get {
				return GetNativeValue<Foundation.NSObject> (VTRawProcessingParameterKey.CurrentValue!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterKey.CurrentValue!, value);
			}
		}
#endif
	}
}
