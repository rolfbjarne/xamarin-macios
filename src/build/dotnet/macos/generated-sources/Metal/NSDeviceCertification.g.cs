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
namespace Metal {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum NSDeviceCertification : int {
		iPhonePerformanceGaming = 0,
	}
	/// <summary>Extension methods for the <see cref="global::Metal.NSDeviceCertification" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSDeviceCertificationExtensions {
		static nint?[] values = new nint? [1];
		[Field ("NSDeviceCertificationiPhonePerformanceGaming", "Metal")]
		internal unsafe static nint NSDeviceCertificationiPhonePerformanceGaming {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<IntPtr> (Libraries.Metal.Handle, "NSDeviceCertificationiPhonePerformanceGaming");
				return values [0]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.IntPtr" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe nint? GetConstant (this NSDeviceCertification self)
		{
			switch ((int) self) {
			case 0: // NSDeviceCertification.iPhonePerformanceGaming
				return NSDeviceCertificationiPhonePerformanceGaming;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::Metal.NSDeviceCertification" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe NSDeviceCertification GetValue (nint constant)
		{
			if (constant == NSDeviceCertificationiPhonePerformanceGaming)
				return NSDeviceCertification.iPhonePerformanceGaming;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::Metal.NSDeviceCertification" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static nint?[]? ToConstantArray (this NSDeviceCertification[]? values)
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
		internal static NSDeviceCertification[]? ToEnumArray (this nint[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSDeviceCertification> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
