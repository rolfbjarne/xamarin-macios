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
	public partial class VTRawProcessingParametersListElement : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTRawProcessingParametersListElement" /> with default (empty) values.</summary>
		public VTRawProcessingParametersListElement () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTRawProcessingParametersListElement" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTRawProcessingParametersListElement (NSDictionary? dictionary) : base (dictionary) {}
		public string? Label {
			get {
				return GetStringValue (VTRawProcessingParameterListElementKey.Label!);
			}
			set {
				SetStringValue (VTRawProcessingParameterListElementKey.Label!, value);
			}
		}
		public string? Description {
			get {
				return GetStringValue (VTRawProcessingParameterListElementKey.Description!);
			}
			set {
				SetStringValue (VTRawProcessingParameterListElementKey.Description!, value);
			}
		}
		public nint? ListElementId {
			get {
				return  GetNIntValue (VTRawProcessingParameterListElementKey.ListElementId!);
			}
			set {
				SetNumberValue (VTRawProcessingParameterListElementKey.ListElementId!, value);
			}
		}
#endif
	}
}
