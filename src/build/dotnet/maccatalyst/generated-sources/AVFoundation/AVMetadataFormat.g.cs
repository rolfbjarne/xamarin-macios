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
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVMetadataFormat : int {
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		FormatHlsMetadata = 0,
		/// <summary>To be added.</summary>
		FormatiTunesMetadata = 1,
		/// <summary>To be added.</summary>
		FormatID3Metadata = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		FormatISOUserData = 3,
		/// <summary>To be added.</summary>
		FormatQuickTimeUserData = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Unknown = 5,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVMetadataFormat" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVMetadataFormatExtensions {
		static IntPtr[] values = new IntPtr [6];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataFormatHLSMetadata", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatHLSMetadata {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatHLSMetadata", storage);
			}
		}
		[Field ("AVMetadataFormatiTunesMetadata", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatiTunesMetadata {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatiTunesMetadata", storage);
			}
		}
		[Field ("AVMetadataFormatID3Metadata", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatID3Metadata {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatID3Metadata", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataFormatISOUserData", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatISOUserData {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatISOUserData", storage);
			}
		}
		[Field ("AVMetadataFormatQuickTimeUserData", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatQuickTimeUserData {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatQuickTimeUserData", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataFormatUnknown", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataFormatUnknown {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataFormatUnknown", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVMetadataFormat self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVMetadataFormat.FormatHlsMetadata
				ptr = AVMetadataFormatHLSMetadata;
				break;
			case 1: // AVMetadataFormat.FormatiTunesMetadata
				ptr = AVMetadataFormatiTunesMetadata;
				break;
			case 2: // AVMetadataFormat.FormatID3Metadata
				ptr = AVMetadataFormatID3Metadata;
				break;
			case 3: // AVMetadataFormat.FormatISOUserData
				ptr = AVMetadataFormatISOUserData;
				break;
			case 4: // AVMetadataFormat.FormatQuickTimeUserData
				ptr = AVMetadataFormatQuickTimeUserData;
				break;
			case 5: // AVMetadataFormat.Unknown
				ptr = AVMetadataFormatUnknown;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataFormat" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVMetadataFormat GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVMetadataFormatHLSMetadata))
				return AVMetadataFormat.FormatHlsMetadata;
			if (constant.IsEqualTo (AVMetadataFormatiTunesMetadata))
				return AVMetadataFormat.FormatiTunesMetadata;
			if (constant.IsEqualTo (AVMetadataFormatID3Metadata))
				return AVMetadataFormat.FormatID3Metadata;
			if (constant.IsEqualTo (AVMetadataFormatISOUserData))
				return AVMetadataFormat.FormatISOUserData;
			if (constant.IsEqualTo (AVMetadataFormatQuickTimeUserData))
				return AVMetadataFormat.FormatQuickTimeUserData;
			if (constant.IsEqualTo (AVMetadataFormatUnknown))
				return AVMetadataFormat.Unknown;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataFormat" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMetadataFormat GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataFormat" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMetadataFormat? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVMetadataFormat" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVMetadataFormat[]? values)
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
		internal static AVMetadataFormat[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVMetadataFormat> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
