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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VideoToolbox {
	/// <summary>Strongly typed set of options.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VTPropertyOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VTPropertyOptions" /> with default (empty) values.</summary>
		public VTPropertyOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VTPropertyOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VTPropertyOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ShouldBeSerialized {
			get {
				return  GetBoolValue (VTPropertyKeys.ShouldBeSerialized!);
			}
			set {
				SetBooleanValue (VTPropertyKeys.ShouldBeSerialized!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? SupportedValueMinimum {
			get {
				return Dictionary [VTPropertyKeys.SupportedValueMinimumKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (VTPropertyKeys.SupportedValueMinimumKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? SupportedValueMaximum {
			get {
				return Dictionary [VTPropertyKeys.SupportedValueMaximumKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (VTPropertyKeys.SupportedValueMaximumKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber[]? SupportedValueList {
			get {
				return GetArray<NSNumber> (VTPropertyKeys.SupportedValueListKey!);
			}
			set {
				SetArrayValue (VTPropertyKeys.SupportedValueListKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? Documentation {
			get {
				return GetNSStringValue (VTPropertyKeys.DocumentationKey!);
			}
			set {
				SetStringValue (VTPropertyKeys.DocumentationKey!, value);
			}
		}
#endif
	}
}
