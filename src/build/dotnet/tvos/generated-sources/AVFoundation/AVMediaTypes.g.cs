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
namespace AVFoundation {
	/// <summary>Enumerates media types.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVMediaTypes : int {
		/// <summary>Indicates video.</summary>
		Video = 0,
		/// <summary>Indicates audio.</summary>
		Audio = 1,
		/// <summary>Indicates text.</summary>
		Text = 2,
		/// <summary>Indicates closed captions.</summary>
		ClosedCaption = 3,
		/// <summary>Indicates subtitles.</summary>
		Subtitle = 4,
		/// <summary>Indicates a time code.</summary>
		Timecode = 5,
		/// <summary>Indicates muxed content.</summary>
		Muxed = 7,
		/// <summary>Indicates a metadata object.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		MetadataObject = 8,
		/// <summary>Indicates metadata.</summary>
		Metadata = 9,
		/// <summary>Indicates depth data.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DepthData = 10,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		AuxiliaryPicture = 11,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Haptic = 12,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVMediaTypes" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVMediaTypesExtensions {
		static IntPtr[] values = new IntPtr [12];
		[Field ("AVMediaTypeVideo", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeVideo {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeVideo", storage);
			}
		}
		[Field ("AVMediaTypeAudio", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeAudio {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeAudio", storage);
			}
		}
		[Field ("AVMediaTypeText", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeText {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeText", storage);
			}
		}
		[Field ("AVMediaTypeClosedCaption", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeClosedCaption {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeClosedCaption", storage);
			}
		}
		[Field ("AVMediaTypeSubtitle", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeSubtitle {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeSubtitle", storage);
			}
		}
		[Field ("AVMediaTypeTimecode", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeTimecode {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeTimecode", storage);
			}
		}
		[Field ("AVMediaTypeMuxed", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeMuxed {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeMuxed", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaTypeMetadataObject", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeMetadataObject {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeMetadataObject", storage);
			}
		}
		[Field ("AVMediaTypeMetadata", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeMetadata {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeMetadata", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaTypeDepthData", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeDepthData {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeDepthData", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[Field ("AVMediaTypeAuxiliaryPicture", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeAuxiliaryPicture {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeAuxiliaryPicture", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaTypeHaptic", "AVFoundation")]
		internal unsafe static IntPtr AVMediaTypeHaptic {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaTypeHaptic", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVMediaTypes self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVMediaTypes.Video
				ptr = AVMediaTypeVideo;
				break;
			case 1: // AVMediaTypes.Audio
				ptr = AVMediaTypeAudio;
				break;
			case 2: // AVMediaTypes.Text
				ptr = AVMediaTypeText;
				break;
			case 3: // AVMediaTypes.ClosedCaption
				ptr = AVMediaTypeClosedCaption;
				break;
			case 4: // AVMediaTypes.Subtitle
				ptr = AVMediaTypeSubtitle;
				break;
			case 5: // AVMediaTypes.Timecode
				ptr = AVMediaTypeTimecode;
				break;
			case 7: // AVMediaTypes.Muxed
				ptr = AVMediaTypeMuxed;
				break;
			case 8: // AVMediaTypes.MetadataObject
				ptr = AVMediaTypeMetadataObject;
				break;
			case 9: // AVMediaTypes.Metadata
				ptr = AVMediaTypeMetadata;
				break;
			case 10: // AVMediaTypes.DepthData
				ptr = AVMediaTypeDepthData;
				break;
			case 11: // AVMediaTypes.AuxiliaryPicture
				ptr = AVMediaTypeAuxiliaryPicture;
				break;
			case 12: // AVMediaTypes.Haptic
				ptr = AVMediaTypeHaptic;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaTypes" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVMediaTypes GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVMediaTypeVideo))
				return AVMediaTypes.Video;
			if (constant.IsEqualTo (AVMediaTypeAudio))
				return AVMediaTypes.Audio;
			if (constant.IsEqualTo (AVMediaTypeText))
				return AVMediaTypes.Text;
			if (constant.IsEqualTo (AVMediaTypeClosedCaption))
				return AVMediaTypes.ClosedCaption;
			if (constant.IsEqualTo (AVMediaTypeSubtitle))
				return AVMediaTypes.Subtitle;
			if (constant.IsEqualTo (AVMediaTypeTimecode))
				return AVMediaTypes.Timecode;
			if (constant.IsEqualTo (AVMediaTypeMuxed))
				return AVMediaTypes.Muxed;
			if (constant.IsEqualTo (AVMediaTypeMetadataObject))
				return AVMediaTypes.MetadataObject;
			if (constant.IsEqualTo (AVMediaTypeMetadata))
				return AVMediaTypes.Metadata;
			if (constant.IsEqualTo (AVMediaTypeDepthData))
				return AVMediaTypes.DepthData;
			if (constant.IsEqualTo (AVMediaTypeAuxiliaryPicture))
				return AVMediaTypes.AuxiliaryPicture;
			if (constant.IsEqualTo (AVMediaTypeHaptic))
				return AVMediaTypes.Haptic;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaTypes" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMediaTypes GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaTypes" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMediaTypes? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVMediaTypes" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVMediaTypes[]? values)
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
		internal static AVMediaTypes[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVMediaTypes> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
