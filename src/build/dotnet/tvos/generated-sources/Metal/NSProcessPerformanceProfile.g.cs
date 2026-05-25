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
namespace Metal {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum NSProcessPerformanceProfile : int {
		Default = 0,
		Sustained = 1,
	}
	/// <summary>Extension methods for the <see cref="global::Metal.NSProcessPerformanceProfile" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSProcessPerformanceProfileExtensions {
		static nint?[] values = new nint? [2];
		[Field ("NSProcessPerformanceProfileDefault", "Metal")]
		internal unsafe static nint NSProcessPerformanceProfileDefault {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<IntPtr> (Libraries.Metal.Handle, "NSProcessPerformanceProfileDefault");
				return values [0]!.Value;
			}
		}
		[Field ("NSProcessPerformanceProfileSustained", "Metal")]
		internal unsafe static nint NSProcessPerformanceProfileSustained {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<IntPtr> (Libraries.Metal.Handle, "NSProcessPerformanceProfileSustained");
				return values [1]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.IntPtr" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe nint? GetConstant (this NSProcessPerformanceProfile self)
		{
			switch ((int) self) {
			case 0: // NSProcessPerformanceProfile.Default
				return NSProcessPerformanceProfileDefault;
			case 1: // NSProcessPerformanceProfile.Sustained
				return NSProcessPerformanceProfileSustained;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::Metal.NSProcessPerformanceProfile" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe NSProcessPerformanceProfile GetValue (nint constant)
		{
			if (constant == NSProcessPerformanceProfileDefault)
				return NSProcessPerformanceProfile.Default;
			if (constant == NSProcessPerformanceProfileSustained)
				return NSProcessPerformanceProfile.Sustained;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::Metal.NSProcessPerformanceProfile" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static nint?[]? ToConstantArray (this NSProcessPerformanceProfile[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<nint?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="nint" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="nint" /> values to convert.</param>
		internal static NSProcessPerformanceProfile[]? ToEnumArray (this nint[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSProcessPerformanceProfile> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
