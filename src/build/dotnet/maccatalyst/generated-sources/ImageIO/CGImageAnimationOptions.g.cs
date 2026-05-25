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
namespace ImageIO {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class CGImageAnimationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGImageAnimationOptions" /> with default (empty) values.</summary>
		public CGImageAnimationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGImageAnimationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGImageAnimationOptions (NSDictionary? dictionary) : base (dictionary) {}
		public double? DelayTime {
			get {
				return  GetDoubleValue (CGImageAnimationOptionsKeys.DelayTimeKey!);
			}
			set {
				SetNumberValue (CGImageAnimationOptionsKeys.DelayTimeKey!, value);
			}
		}
		public nuint? LoopCount {
			get {
				return  GetNUIntValue (CGImageAnimationOptionsKeys.LoopCountKey!);
			}
			set {
				SetNumberValue (CGImageAnimationOptionsKeys.LoopCountKey!, value);
			}
		}
		public nuint? StartIndex {
			get {
				return  GetNUIntValue (CGImageAnimationOptionsKeys.StartIndexKey!);
			}
			set {
				SetNumberValue (CGImageAnimationOptionsKeys.StartIndexKey!, value);
			}
		}
#endif
	}
}
