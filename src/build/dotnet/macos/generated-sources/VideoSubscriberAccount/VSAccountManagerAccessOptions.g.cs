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
namespace VideoSubscriberAccount {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class VSAccountManagerAccessOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="VSAccountManagerAccessOptions" /> with default (empty) values.</summary>
		public VSAccountManagerAccessOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="VSAccountManagerAccessOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public VSAccountManagerAccessOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>If not <see langword="null" />, specifies whether the user should be asked for access permission.</summary>
		public bool? CheckAccessOptionPrompt {
			get {
				return  GetBoolValue (VSCheckAccessOptionKeys.CheckAccessOptionPrompt!);
			}
			set {
				SetBooleanValue (VSCheckAccessOptionKeys.CheckAccessOptionPrompt!, value);
			}
		}
#endif
	}
}
