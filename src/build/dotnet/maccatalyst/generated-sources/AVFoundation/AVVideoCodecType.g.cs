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
	/// <summary>Constants for known video codecs.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVVideoCodecType : int {
		/// <summary>To be added.</summary>
		H264 = 0,
		/// <summary>To be added.</summary>
		Jpeg = 1,
		/// <summary>To be added.</summary>
		AppleProRes422 = 3,
		/// <summary>To be added.</summary>
		AppleProRes4444 = 4,
		/// <summary>To be added.</summary>
		Hevc = 5,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AppleProRes422HQ = 6,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AppleProRes422LT = 7,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AppleProRes422Proxy = 8,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		HevcWithAlpha = 9,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		AppleProRes4444XQ = 10,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		JpegXl = 11,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		AppleProResRaw = 12,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		AppleProResRawHQ = 13,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVVideoCodecType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVVideoCodecTypeExtensions {
		static IntPtr[] values = new IntPtr [13];
		[Field ("AVVideoCodecTypeH264", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeH264 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeH264", storage);
			}
		}
		[Field ("AVVideoCodecTypeJPEG", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeJPEG {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeJPEG", storage);
			}
		}
		[Field ("AVVideoCodecTypeAppleProRes422", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422", storage);
			}
		}
		[Field ("AVVideoCodecTypeAppleProRes4444", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes4444 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes4444", storage);
			}
		}
		[Field ("AVVideoCodecTypeHEVC", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeHEVC {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeHEVC", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVVideoCodecTypeAppleProRes422HQ", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422HQ {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422HQ", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVVideoCodecTypeAppleProRes422LT", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422LT {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422LT", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVVideoCodecTypeAppleProRes422Proxy", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422Proxy {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422Proxy", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVVideoCodecTypeHEVCWithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeHEVCWithAlpha {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeHEVCWithAlpha", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[Field ("AVVideoCodecTypeAppleProRes4444XQ", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProRes4444XQ {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes4444XQ", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[Field ("AVVideoCodecTypeJPEGXL", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeJPEGXL {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeJPEGXL", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVVideoCodecTypeAppleProResRAW", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProResRAW {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProResRAW", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVVideoCodecTypeAppleProResRAWHQ", "AVFoundation")]
		internal unsafe static IntPtr AVVideoCodecTypeAppleProResRAWHQ {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProResRAWHQ", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVVideoCodecType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVVideoCodecType.H264
				ptr = AVVideoCodecTypeH264;
				break;
			case 1: // AVVideoCodecType.Jpeg
				ptr = AVVideoCodecTypeJPEG;
				break;
			case 3: // AVVideoCodecType.AppleProRes422
				ptr = AVVideoCodecTypeAppleProRes422;
				break;
			case 4: // AVVideoCodecType.AppleProRes4444
				ptr = AVVideoCodecTypeAppleProRes4444;
				break;
			case 5: // AVVideoCodecType.Hevc
				ptr = AVVideoCodecTypeHEVC;
				break;
			case 6: // AVVideoCodecType.AppleProRes422HQ
				ptr = AVVideoCodecTypeAppleProRes422HQ;
				break;
			case 7: // AVVideoCodecType.AppleProRes422LT
				ptr = AVVideoCodecTypeAppleProRes422LT;
				break;
			case 8: // AVVideoCodecType.AppleProRes422Proxy
				ptr = AVVideoCodecTypeAppleProRes422Proxy;
				break;
			case 9: // AVVideoCodecType.HevcWithAlpha
				ptr = AVVideoCodecTypeHEVCWithAlpha;
				break;
			case 10: // AVVideoCodecType.AppleProRes4444XQ
				ptr = AVVideoCodecTypeAppleProRes4444XQ;
				break;
			case 11: // AVVideoCodecType.JpegXl
				ptr = AVVideoCodecTypeJPEGXL;
				break;
			case 12: // AVVideoCodecType.AppleProResRaw
				ptr = AVVideoCodecTypeAppleProResRAW;
				break;
			case 13: // AVVideoCodecType.AppleProResRawHQ
				ptr = AVVideoCodecTypeAppleProResRAWHQ;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCodecType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVVideoCodecType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVVideoCodecTypeH264))
				return AVVideoCodecType.H264;
			if (constant.IsEqualTo (AVVideoCodecTypeJPEG))
				return AVVideoCodecType.Jpeg;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes422))
				return AVVideoCodecType.AppleProRes422;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes4444))
				return AVVideoCodecType.AppleProRes4444;
			if (constant.IsEqualTo (AVVideoCodecTypeHEVC))
				return AVVideoCodecType.Hevc;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes422HQ))
				return AVVideoCodecType.AppleProRes422HQ;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes422LT))
				return AVVideoCodecType.AppleProRes422LT;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes422Proxy))
				return AVVideoCodecType.AppleProRes422Proxy;
			if (constant.IsEqualTo (AVVideoCodecTypeHEVCWithAlpha))
				return AVVideoCodecType.HevcWithAlpha;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProRes4444XQ))
				return AVVideoCodecType.AppleProRes4444XQ;
			if (constant.IsEqualTo (AVVideoCodecTypeJPEGXL))
				return AVVideoCodecType.JpegXl;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProResRAW))
				return AVVideoCodecType.AppleProResRaw;
			if (constant.IsEqualTo (AVVideoCodecTypeAppleProResRAWHQ))
				return AVVideoCodecType.AppleProResRawHQ;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCodecType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVVideoCodecType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVVideoCodecType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVVideoCodecType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVVideoCodecType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVVideoCodecType[]? values)
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
		internal static AVVideoCodecType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVVideoCodecType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
