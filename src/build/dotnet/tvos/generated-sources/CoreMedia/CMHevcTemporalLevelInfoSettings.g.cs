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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CMHevcTemporalLevelInfoSettings : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMHevcTemporalLevelInfoSettings" /> with default (empty) values.</summary>
		public CMHevcTemporalLevelInfoSettings () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMHevcTemporalLevelInfoSettings" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMHevcTemporalLevelInfoSettings (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? TemporalLevel {
			get {
				return  GetInt32Value (CMHevcTemporalLevelInfoKeys.TemporalLevelKey!);
			}
			set {
				SetNumberValue (CMHevcTemporalLevelInfoKeys.TemporalLevelKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? ProfileSpace {
			get {
				return  GetInt32Value (CMHevcTemporalLevelInfoKeys.ProfileSpaceKey!);
			}
			set {
				SetNumberValue (CMHevcTemporalLevelInfoKeys.ProfileSpaceKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? TierFlag {
			get {
				return  GetInt32Value (CMHevcTemporalLevelInfoKeys.TierFlagKey!);
			}
			set {
				SetNumberValue (CMHevcTemporalLevelInfoKeys.TierFlagKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? ProfileIndex {
			get {
				return  GetInt32Value (CMHevcTemporalLevelInfoKeys.ProfileIndexKey!);
			}
			set {
				SetNumberValue (CMHevcTemporalLevelInfoKeys.ProfileIndexKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? ProfileCompatibilityFlags {
			get {
				return Dictionary [CMHevcTemporalLevelInfoKeys.ProfileCompatibilityFlagsKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMHevcTemporalLevelInfoKeys.ProfileCompatibilityFlagsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? ConstraintIndicatorFlags {
			get {
				return Dictionary [CMHevcTemporalLevelInfoKeys.ConstraintIndicatorFlagsKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMHevcTemporalLevelInfoKeys.ConstraintIndicatorFlagsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? LevelIndex {
			get {
				return  GetInt32Value (CMHevcTemporalLevelInfoKeys.LevelIndexKey!);
			}
			set {
				SetNumberValue (CMHevcTemporalLevelInfoKeys.LevelIndexKey!, value);
			}
		}
#endif
	}
}
