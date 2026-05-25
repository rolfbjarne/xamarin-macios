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
	[SupportedOSPlatform ("tvos26.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum AVCaptureWhiteBalanceTemperatureAndTintValue : int {
		Tungsten = 0,
		Fluorescent = 1,
		Daylight = 2,
		Cloudy = 3,
		Shadow = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCaptureWhiteBalanceTemperatureAndTintValue" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCaptureWhiteBalanceTemperatureAndTintValueExtensions {
		static AVCaptureWhiteBalanceTemperatureAndTintValues?[] values = new AVCaptureWhiteBalanceTemperatureAndTintValues? [5];
		[Field ("AVCaptureWhiteBalanceTemperatureAndTintValuesTungsten", "AVFoundation")]
		internal unsafe static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValuesTungsten {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<AVCaptureWhiteBalanceTemperatureAndTintValues> (Libraries.AVFoundation.Handle, "AVCaptureWhiteBalanceTemperatureAndTintValuesTungsten");
				return values [0]!.Value;
			}
		}
		[Field ("AVCaptureWhiteBalanceTemperatureAndTintValuesFluorescent", "AVFoundation")]
		internal unsafe static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValuesFluorescent {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<AVCaptureWhiteBalanceTemperatureAndTintValues> (Libraries.AVFoundation.Handle, "AVCaptureWhiteBalanceTemperatureAndTintValuesFluorescent");
				return values [1]!.Value;
			}
		}
		[Field ("AVCaptureWhiteBalanceTemperatureAndTintValuesDaylight", "AVFoundation")]
		internal unsafe static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValuesDaylight {
			get {
				if (!values [2].HasValue)
					values [2] = Dlfcn.GetStruct<AVCaptureWhiteBalanceTemperatureAndTintValues> (Libraries.AVFoundation.Handle, "AVCaptureWhiteBalanceTemperatureAndTintValuesDaylight");
				return values [2]!.Value;
			}
		}
		[Field ("AVCaptureWhiteBalanceTemperatureAndTintValuesCloudy", "AVFoundation")]
		internal unsafe static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValuesCloudy {
			get {
				if (!values [3].HasValue)
					values [3] = Dlfcn.GetStruct<AVCaptureWhiteBalanceTemperatureAndTintValues> (Libraries.AVFoundation.Handle, "AVCaptureWhiteBalanceTemperatureAndTintValuesCloudy");
				return values [3]!.Value;
			}
		}
		[Field ("AVCaptureWhiteBalanceTemperatureAndTintValuesShadow", "AVFoundation")]
		internal unsafe static AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValuesShadow {
			get {
				if (!values [4].HasValue)
					values [4] = Dlfcn.GetStruct<AVCaptureWhiteBalanceTemperatureAndTintValues> (Libraries.AVFoundation.Handle, "AVCaptureWhiteBalanceTemperatureAndTintValuesShadow");
				return values [4]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureWhiteBalanceTemperatureAndTintValues" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe AVCaptureWhiteBalanceTemperatureAndTintValues? GetConstant (this AVCaptureWhiteBalanceTemperatureAndTintValue self)
		{
			switch ((int) self) {
			case 0: // AVCaptureWhiteBalanceTemperatureAndTintValue.Tungsten
				return AVCaptureWhiteBalanceTemperatureAndTintValuesTungsten;
			case 1: // AVCaptureWhiteBalanceTemperatureAndTintValue.Fluorescent
				return AVCaptureWhiteBalanceTemperatureAndTintValuesFluorescent;
			case 2: // AVCaptureWhiteBalanceTemperatureAndTintValue.Daylight
				return AVCaptureWhiteBalanceTemperatureAndTintValuesDaylight;
			case 3: // AVCaptureWhiteBalanceTemperatureAndTintValue.Cloudy
				return AVCaptureWhiteBalanceTemperatureAndTintValuesCloudy;
			case 4: // AVCaptureWhiteBalanceTemperatureAndTintValue.Shadow
				return AVCaptureWhiteBalanceTemperatureAndTintValuesShadow;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureWhiteBalanceTemperatureAndTintValue" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe AVCaptureWhiteBalanceTemperatureAndTintValue GetValue (AVCaptureWhiteBalanceTemperatureAndTintValues constant)
		{
			if (constant == AVCaptureWhiteBalanceTemperatureAndTintValuesTungsten)
				return AVCaptureWhiteBalanceTemperatureAndTintValue.Tungsten;
			if (constant == AVCaptureWhiteBalanceTemperatureAndTintValuesFluorescent)
				return AVCaptureWhiteBalanceTemperatureAndTintValue.Fluorescent;
			if (constant == AVCaptureWhiteBalanceTemperatureAndTintValuesDaylight)
				return AVCaptureWhiteBalanceTemperatureAndTintValue.Daylight;
			if (constant == AVCaptureWhiteBalanceTemperatureAndTintValuesCloudy)
				return AVCaptureWhiteBalanceTemperatureAndTintValue.Cloudy;
			if (constant == AVCaptureWhiteBalanceTemperatureAndTintValuesShadow)
				return AVCaptureWhiteBalanceTemperatureAndTintValue.Shadow;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCaptureWhiteBalanceTemperatureAndTintValue" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static AVCaptureWhiteBalanceTemperatureAndTintValues?[]? ToConstantArray (this AVCaptureWhiteBalanceTemperatureAndTintValue[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureWhiteBalanceTemperatureAndTintValues?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="AVCaptureWhiteBalanceTemperatureAndTintValues" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="AVCaptureWhiteBalanceTemperatureAndTintValues" /> values to convert.</param>
		internal static AVCaptureWhiteBalanceTemperatureAndTintValue[]? ToEnumArray (this AVCaptureWhiteBalanceTemperatureAndTintValues[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureWhiteBalanceTemperatureAndTintValue> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
