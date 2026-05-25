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
	public partial class VTRawProcessingParameterValueType : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTRawProcessingParameterValueType" /> with default (empty) values.</summary>
		public VTRawProcessingParameterValueType () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTRawProcessingParameterValueType" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTRawProcessingParameterValueType (NSDictionary? dictionary) : base (dictionary) {}
		public bool? Boolean {
			get {
				return  GetBoolValue (VTRawProcessingParameterValueTypeKey.Boolean!);
			}
			set {
				SetBooleanValue (VTRawProcessingParameterValueTypeKey.Boolean!, value);
			}
		}
		public int? Integer {
			get {
				return  GetInt32Value (VTRawProcessingParameterValueTypeKey.Integer!);
			}
			set {
				SetNumberValue (VTRawProcessingParameterValueTypeKey.Integer!, value);
			}
		}
		public float? Float {
			get {
				return  GetFloatValue (VTRawProcessingParameterValueTypeKey.Float!);
			}
			set {
				SetNumberValue (VTRawProcessingParameterValueTypeKey.Float!, value);
			}
		}
		public NSObject[]? List {
			get {
				return GetArray<NSObject> (VTRawProcessingParameterValueTypeKey.List!, (ptr) => Runtime.GetINativeObject<NSObject> (ptr, false)!);
			}
			set {
				SetArrayValue (VTRawProcessingParameterValueTypeKey.List!, value);
			}
		}
		public NSDictionary? SubGroup {
			get {
				return GetNSDictionary (VTRawProcessingParameterValueTypeKey.SubGroup!);
			}
			set {
				SetNativeValue (VTRawProcessingParameterValueTypeKey.SubGroup!, value);
			}
		}
#endif
	}
}
