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
namespace CoreMedia {
	public enum CMMetadataIdentifier : int {
		QuickTimeMetadataLocation_ISO6709 = 0,
		QuickTimeMetadataDirection_Facing = 1,
		QuickTimeMetadataPreferredAffineTransform = 2,
		QuickTimeMetadataVideoOrientation = 3,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		QuickTimeMetadataLivePhotoStillImageTransform = 4,
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions = 5,
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		QuickTimeMetadataSegmentIdentifier = 6,
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		QuickTimeMetadataSceneIlluminance = 7,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		QuickTimeMetadataSpatialAudioMix = 8,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		QuickTimeMetadataDisplayMaskRectangleMono = 9,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		QuickTimeMetadataDisplayMaskRectangleStereoLeft = 10,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		QuickTimeMetadataDisplayMaskRectangleStereoRight = 11,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		QuickTimeMetadataPresentationImmersiveMedia = 12,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMMetadataIdentifier" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMMetadataIdentifierExtensions {
		static IntPtr[] values = new IntPtr [13];
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataLocation_ISO6709", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataLocation_ISO6709 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataLocation_ISO6709", storage);
			}
		}
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataDirection_Facing", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataDirection_Facing {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataDirection_Facing", storage);
			}
		}
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataPreferredAffineTransform", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataPreferredAffineTransform {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataPreferredAffineTransform", storage);
			}
		}
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataVideoOrientation", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataVideoOrientation {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataVideoOrientation", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransform", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransform {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransform", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataSegmentIdentifier", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataSegmentIdentifier {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataSegmentIdentifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataSceneIlluminance", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataSceneIlluminance {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataSceneIlluminance", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataSpatialAudioMix", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataSpatialAudioMix {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataSpatialAudioMix", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleMono", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleMono {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleMono", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoLeft", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoLeft {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoLeft", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoRight", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoRight {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoRight", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataIdentifier_QuickTimeMetadataPresentationImmersiveMedia", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataIdentifier_QuickTimeMetadataPresentationImmersiveMedia {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataIdentifier_QuickTimeMetadataPresentationImmersiveMedia", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMMetadataIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMMetadataIdentifier.QuickTimeMetadataLocation_ISO6709
				ptr = kCMMetadataIdentifier_QuickTimeMetadataLocation_ISO6709;
				break;
			case 1: // CMMetadataIdentifier.QuickTimeMetadataDirection_Facing
				ptr = kCMMetadataIdentifier_QuickTimeMetadataDirection_Facing;
				break;
			case 2: // CMMetadataIdentifier.QuickTimeMetadataPreferredAffineTransform
				ptr = kCMMetadataIdentifier_QuickTimeMetadataPreferredAffineTransform;
				break;
			case 3: // CMMetadataIdentifier.QuickTimeMetadataVideoOrientation
				ptr = kCMMetadataIdentifier_QuickTimeMetadataVideoOrientation;
				break;
			case 4: // CMMetadataIdentifier.QuickTimeMetadataLivePhotoStillImageTransform
				ptr = kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransform;
				break;
			case 5: // CMMetadataIdentifier.QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions
				ptr = kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions;
				break;
			case 6: // CMMetadataIdentifier.QuickTimeMetadataSegmentIdentifier
				ptr = kCMMetadataIdentifier_QuickTimeMetadataSegmentIdentifier;
				break;
			case 7: // CMMetadataIdentifier.QuickTimeMetadataSceneIlluminance
				ptr = kCMMetadataIdentifier_QuickTimeMetadataSceneIlluminance;
				break;
			case 8: // CMMetadataIdentifier.QuickTimeMetadataSpatialAudioMix
				ptr = kCMMetadataIdentifier_QuickTimeMetadataSpatialAudioMix;
				break;
			case 9: // CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleMono
				ptr = kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleMono;
				break;
			case 10: // CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleStereoLeft
				ptr = kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoLeft;
				break;
			case 11: // CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleStereoRight
				ptr = kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoRight;
				break;
			case 12: // CMMetadataIdentifier.QuickTimeMetadataPresentationImmersiveMedia
				ptr = kCMMetadataIdentifier_QuickTimeMetadataPresentationImmersiveMedia;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMMetadataIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataLocation_ISO6709))
				return CMMetadataIdentifier.QuickTimeMetadataLocation_ISO6709;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataDirection_Facing))
				return CMMetadataIdentifier.QuickTimeMetadataDirection_Facing;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataPreferredAffineTransform))
				return CMMetadataIdentifier.QuickTimeMetadataPreferredAffineTransform;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataVideoOrientation))
				return CMMetadataIdentifier.QuickTimeMetadataVideoOrientation;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransform))
				return CMMetadataIdentifier.QuickTimeMetadataLivePhotoStillImageTransform;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions))
				return CMMetadataIdentifier.QuickTimeMetadataLivePhotoStillImageTransformReferenceDimensions;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataSegmentIdentifier))
				return CMMetadataIdentifier.QuickTimeMetadataSegmentIdentifier;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataSceneIlluminance))
				return CMMetadataIdentifier.QuickTimeMetadataSceneIlluminance;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataSpatialAudioMix))
				return CMMetadataIdentifier.QuickTimeMetadataSpatialAudioMix;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleMono))
				return CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleMono;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoLeft))
				return CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleStereoLeft;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataDisplayMaskRectangleStereoRight))
				return CMMetadataIdentifier.QuickTimeMetadataDisplayMaskRectangleStereoRight;
			if (constant.IsEqualTo (kCMMetadataIdentifier_QuickTimeMetadataPresentationImmersiveMedia))
				return CMMetadataIdentifier.QuickTimeMetadataPresentationImmersiveMedia;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMMetadataIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMMetadataIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMMetadataIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMMetadataIdentifier[]? values)
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
		internal static CMMetadataIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMMetadataIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
