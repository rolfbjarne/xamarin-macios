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
namespace ARKit {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> that defines the features available in <see cref="T:ARKit.ARFaceGeometry" /> .</summary><remarks><para>All values are in the range [0..1], where 0.0 indicates the neutral state and 1.0 indicates maximum displacement.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public partial class ARBlendShapeLocationOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="ARBlendShapeLocationOptions" /> with default (empty) values.</summary>
		public ARBlendShapeLocationOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="ARBlendShapeLocationOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public ARBlendShapeLocationOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? BrowDownLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.BrowDownLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.BrowDownLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? BrowDownRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.BrowDownRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.BrowDownRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? BrowInnerUp {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.BrowInnerUpKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.BrowInnerUpKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? BrowOuterUpLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.BrowOuterUpLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.BrowOuterUpLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? BrowOuterUpRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.BrowOuterUpRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.BrowOuterUpRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? CheekPuff {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.CheekPuffKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.CheekPuffKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? CheekSquintLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.CheekSquintLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.CheekSquintLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? CheekSquintRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.CheekSquintRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.CheekSquintRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeBlinkLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeBlinkLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeBlinkLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeBlinkRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeBlinkRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeBlinkRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookDownLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookDownLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookDownLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookDownRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookDownRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookDownRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookInLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookInLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookInLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookInRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookInRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookInRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookOutLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookOutLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookOutLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookOutRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookOutRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookOutRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookUpLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookUpLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookUpLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeLookUpRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeLookUpRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeLookUpRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeSquintLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeSquintLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeSquintLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeSquintRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeSquintRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeSquintRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeWideLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeWideLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeWideLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? EyeWideRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.EyeWideRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.EyeWideRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? JawForward {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.JawForwardKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.JawForwardKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? JawLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.JawLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.JawLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? JawOpen {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.JawOpenKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.JawOpenKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? JawRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.JawRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.JawRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthClose {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthCloseKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthCloseKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthDimpleLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthDimpleLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthDimpleLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthDimpleRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthDimpleRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthDimpleRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthFrownLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthFrownLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthFrownLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthFrownRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthFrownRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthFrownRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthFunnel {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthFunnelKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthFunnelKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthLowerDownLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthLowerDownLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthLowerDownLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthLowerDownRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthLowerDownRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthLowerDownRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthPressLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthPressLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthPressLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthPressRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthPressRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthPressRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthPucker {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthPuckerKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthPuckerKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthRollLower {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthRollLowerKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthRollLowerKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthRollUpper {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthRollUpperKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthRollUpperKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthShrugLower {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthShrugLowerKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthShrugLowerKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthShrugUpper {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthShrugUpperKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthShrugUpperKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthSmileLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthSmileLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthSmileLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthSmileRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthSmileRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthSmileRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthStretchLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthStretchLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthStretchLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthStretchRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthStretchRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthStretchRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthUpperUpLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthUpperUpLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthUpperUpLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? MouthUpperUpRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.MouthUpperUpRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.MouthUpperUpRightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? NoseSneerLeft {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.NoseSneerLeftKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.NoseSneerLeftKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? NoseSneerRight {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.NoseSneerRightKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.NoseSneerRightKey!, value);
			}
		}
		/// <summary>Gets or sets the extension of a tongue.</summary><value>The extension of a tongue.</value><remarks>To be added.</remarks>
		public float? TongueOut {
			get {
				return  GetFloatValue (ARBlendShapeLocationKeys.TongueOutKey!);
			}
			set {
				SetNumberValue (ARBlendShapeLocationKeys.TongueOutKey!, value);
			}
		}
#endif
	}
}
