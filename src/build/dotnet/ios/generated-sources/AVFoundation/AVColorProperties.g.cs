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
namespace AVFoundation {
	/// <summary>Contains color properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AVColorProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AVColorProperties" /> with default (empty) values.</summary>
		public AVColorProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AVColorProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AVColorProperties (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? AVVideoColorPrimaries {
			get {
				return GetNSStringValue (AVColorPropertiesKeys.AVVideoColorPrimariesKey!);
			}
			set {
				SetStringValue (AVColorPropertiesKeys.AVVideoColorPrimariesKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? AVVideoTransferFunction {
			get {
				return GetNSStringValue (AVColorPropertiesKeys.AVVideoTransferFunctionKey!);
			}
			set {
				SetStringValue (AVColorPropertiesKeys.AVVideoTransferFunctionKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? AVVideoYCbCrMatrix {
			get {
				return GetNSStringValue (AVColorPropertiesKeys.AVVideoYCbCrMatrixKey!);
			}
		}
#endif
	}
}
