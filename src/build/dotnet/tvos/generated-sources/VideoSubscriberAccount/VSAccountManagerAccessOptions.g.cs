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
namespace VideoSubscriberAccount {
	/// <summary>
	/// A <see cref="T:Foundation.DictionaryContainer" /> holding keys appropriate to <see cref="VSAccountManager.CheckAccessStatus(VSAccountManagerAccessOptions,Action&lt;VSAccountAccessStatus,NSError&gt;)" />
	/// and <see cref="VSAccountManager.CheckAccessStatusAsync(VSAccountManagerAccessOptions)" />.
	/// </summary>
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
