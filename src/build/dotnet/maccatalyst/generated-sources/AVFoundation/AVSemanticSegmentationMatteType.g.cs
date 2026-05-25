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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public enum AVSemanticSegmentationMatteType : int {
		None = 0,
		Skin = 1,
		Hair = 2,
		Teeth = 3,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		Glasses = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVSemanticSegmentationMatteType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVSemanticSegmentationMatteTypeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("AVSemanticSegmentationMatteTypeSkin", "AVFoundation")]
		internal unsafe static IntPtr AVSemanticSegmentationMatteTypeSkin {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeSkin", storage);
			}
		}
		[Field ("AVSemanticSegmentationMatteTypeHair", "AVFoundation")]
		internal unsafe static IntPtr AVSemanticSegmentationMatteTypeHair {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeHair", storage);
			}
		}
		[Field ("AVSemanticSegmentationMatteTypeTeeth", "AVFoundation")]
		internal unsafe static IntPtr AVSemanticSegmentationMatteTypeTeeth {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeTeeth", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVSemanticSegmentationMatteTypeGlasses", "AVFoundation")]
		internal unsafe static IntPtr AVSemanticSegmentationMatteTypeGlasses {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeGlasses", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVSemanticSegmentationMatteType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // AVSemanticSegmentationMatteType.Skin
				ptr = AVSemanticSegmentationMatteTypeSkin;
				break;
			case 2: // AVSemanticSegmentationMatteType.Hair
				ptr = AVSemanticSegmentationMatteTypeHair;
				break;
			case 3: // AVSemanticSegmentationMatteType.Teeth
				ptr = AVSemanticSegmentationMatteTypeTeeth;
				break;
			case 4: // AVSemanticSegmentationMatteType.Glasses
				ptr = AVSemanticSegmentationMatteTypeGlasses;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVSemanticSegmentationMatteType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVSemanticSegmentationMatteType GetValue (NSString? constant)
		{
			if (constant is null)
				return AVSemanticSegmentationMatteType.None;
			if (constant.IsEqualTo (AVSemanticSegmentationMatteTypeSkin))
				return AVSemanticSegmentationMatteType.Skin;
			if (constant.IsEqualTo (AVSemanticSegmentationMatteTypeHair))
				return AVSemanticSegmentationMatteType.Hair;
			if (constant.IsEqualTo (AVSemanticSegmentationMatteTypeTeeth))
				return AVSemanticSegmentationMatteType.Teeth;
			if (constant.IsEqualTo (AVSemanticSegmentationMatteTypeGlasses))
				return AVSemanticSegmentationMatteType.Glasses;
			return AVSemanticSegmentationMatteType.None;
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVSemanticSegmentationMatteType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVSemanticSegmentationMatteType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVSemanticSegmentationMatteType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVSemanticSegmentationMatteType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVSemanticSegmentationMatteType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVSemanticSegmentationMatteType[]? values)
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
		internal static AVSemanticSegmentationMatteType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVSemanticSegmentationMatteType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
