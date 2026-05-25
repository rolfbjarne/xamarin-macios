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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst17.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[NativeName ("AVVideoCompositionPerFrameHDRDisplayMetadataPolicy")]
	public enum AVVideoCompositionPerFrameHdrDisplayMetadataPolicy : int {
		Propagate = 0,
		Generate = 1,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVVideoCompositionPerFrameHdrDisplayMetadataPolicy" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst17.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVVideoCompositionPerFrameHdrDisplayMetadataPolicyExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("AVVideoCompositionPerFrameHDRDisplayMetadataPolicyPropagate", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCompositionPerFrameHDRDisplayMetadataPolicyPropagate {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCompositionPerFrameHDRDisplayMetadataPolicyPropagate", storage);
			}
		}
		[Field ("AVVideoCompositionPerFrameHDRDisplayMetadataPolicyGenerate", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCompositionPerFrameHDRDisplayMetadataPolicyGenerate {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCompositionPerFrameHDRDisplayMetadataPolicyGenerate", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVVideoCompositionPerFrameHdrDisplayMetadataPolicy self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVVideoCompositionPerFrameHdrDisplayMetadataPolicy.Propagate
				ptr = AVVideoCompositionPerFrameHDRDisplayMetadataPolicyPropagate;
				break;
			case 1: // AVVideoCompositionPerFrameHdrDisplayMetadataPolicy.Generate
				ptr = AVVideoCompositionPerFrameHDRDisplayMetadataPolicyGenerate;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCompositionPerFrameHdrDisplayMetadataPolicy" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVVideoCompositionPerFrameHdrDisplayMetadataPolicy GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVVideoCompositionPerFrameHDRDisplayMetadataPolicyPropagate))
				return AVVideoCompositionPerFrameHdrDisplayMetadataPolicy.Propagate;
			if (constant.IsEqualTo (AVVideoCompositionPerFrameHDRDisplayMetadataPolicyGenerate))
				return AVVideoCompositionPerFrameHdrDisplayMetadataPolicy.Generate;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCompositionPerFrameHdrDisplayMetadataPolicy" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVVideoCompositionPerFrameHdrDisplayMetadataPolicy GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCompositionPerFrameHdrDisplayMetadataPolicy" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVVideoCompositionPerFrameHdrDisplayMetadataPolicy? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVVideoCompositionPerFrameHdrDisplayMetadataPolicy" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVVideoCompositionPerFrameHdrDisplayMetadataPolicy[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static AVVideoCompositionPerFrameHdrDisplayMetadataPolicy[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVVideoCompositionPerFrameHdrDisplayMetadataPolicy> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
