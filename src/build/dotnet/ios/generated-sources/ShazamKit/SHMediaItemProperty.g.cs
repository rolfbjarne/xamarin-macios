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
namespace ShazamKit {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum SHMediaItemProperty : int {
		ShazamId = 0,
		Title = 1,
		Subtitle = 2,
		Artist = 3,
		WebUrl = 4,
		AppleMusicId = 5,
		AppleMusicUrl = 6,
		ArtworkUrl = 7,
		VideoUrl = 8,
		ExplicitContent = 9,
		Genres = 10,
		Isrc = 11,
		MatchOffset = 12,
		FrequencySkew = 13,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		TimeRanges = 14,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		FrequencySkewRanges = 15,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		CreationDate = 16,
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		Confidence = 17,
	}
	/// <summary>Extension methods for the <see cref="global::ShazamKit.SHMediaItemProperty" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SHMediaItemPropertyExtensions {
		static IntPtr[] values = new IntPtr [18];
		[Field ("SHMediaItemShazamID", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemShazamID {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemShazamID", storage);
			}
		}
		[Field ("SHMediaItemTitle", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemTitle {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemTitle", storage);
			}
		}
		[Field ("SHMediaItemSubtitle", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemSubtitle {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemSubtitle", storage);
			}
		}
		[Field ("SHMediaItemArtist", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemArtist {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemArtist", storage);
			}
		}
		[Field ("SHMediaItemWebURL", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemWebURL {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemWebURL", storage);
			}
		}
		[Field ("SHMediaItemAppleMusicID", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemAppleMusicID {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemAppleMusicID", storage);
			}
		}
		[Field ("SHMediaItemAppleMusicURL", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemAppleMusicURL {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemAppleMusicURL", storage);
			}
		}
		[Field ("SHMediaItemArtworkURL", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemArtworkURL {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemArtworkURL", storage);
			}
		}
		[Field ("SHMediaItemVideoURL", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemVideoURL {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemVideoURL", storage);
			}
		}
		[Field ("SHMediaItemExplicitContent", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemExplicitContent {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemExplicitContent", storage);
			}
		}
		[Field ("SHMediaItemGenres", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemGenres {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemGenres", storage);
			}
		}
		[Field ("SHMediaItemISRC", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemISRC {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemISRC", storage);
			}
		}
		[Field ("SHMediaItemMatchOffset", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemMatchOffset {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemMatchOffset", storage);
			}
		}
		[Field ("SHMediaItemFrequencySkew", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemFrequencySkew {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemFrequencySkew", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("SHMediaItemTimeRanges", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemTimeRanges {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemTimeRanges", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("SHMediaItemFrequencySkewRanges", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemFrequencySkewRanges {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemFrequencySkewRanges", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("SHMediaItemCreationDate", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemCreationDate {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemCreationDate", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[Field ("SHMediaItemConfidence", "ShazamKit")]
		internal unsafe static IntPtr SHMediaItemConfidence {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.ShazamKit.Handle, "SHMediaItemConfidence", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SHMediaItemProperty self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SHMediaItemProperty.ShazamId
				ptr = SHMediaItemShazamID;
				break;
			case 1: // SHMediaItemProperty.Title
				ptr = SHMediaItemTitle;
				break;
			case 2: // SHMediaItemProperty.Subtitle
				ptr = SHMediaItemSubtitle;
				break;
			case 3: // SHMediaItemProperty.Artist
				ptr = SHMediaItemArtist;
				break;
			case 4: // SHMediaItemProperty.WebUrl
				ptr = SHMediaItemWebURL;
				break;
			case 5: // SHMediaItemProperty.AppleMusicId
				ptr = SHMediaItemAppleMusicID;
				break;
			case 6: // SHMediaItemProperty.AppleMusicUrl
				ptr = SHMediaItemAppleMusicURL;
				break;
			case 7: // SHMediaItemProperty.ArtworkUrl
				ptr = SHMediaItemArtworkURL;
				break;
			case 8: // SHMediaItemProperty.VideoUrl
				ptr = SHMediaItemVideoURL;
				break;
			case 9: // SHMediaItemProperty.ExplicitContent
				ptr = SHMediaItemExplicitContent;
				break;
			case 10: // SHMediaItemProperty.Genres
				ptr = SHMediaItemGenres;
				break;
			case 11: // SHMediaItemProperty.Isrc
				ptr = SHMediaItemISRC;
				break;
			case 12: // SHMediaItemProperty.MatchOffset
				ptr = SHMediaItemMatchOffset;
				break;
			case 13: // SHMediaItemProperty.FrequencySkew
				ptr = SHMediaItemFrequencySkew;
				break;
			case 14: // SHMediaItemProperty.TimeRanges
				ptr = SHMediaItemTimeRanges;
				break;
			case 15: // SHMediaItemProperty.FrequencySkewRanges
				ptr = SHMediaItemFrequencySkewRanges;
				break;
			case 16: // SHMediaItemProperty.CreationDate
				ptr = SHMediaItemCreationDate;
				break;
			case 17: // SHMediaItemProperty.Confidence
				ptr = SHMediaItemConfidence;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ShazamKit.SHMediaItemProperty" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SHMediaItemProperty GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (SHMediaItemShazamID))
				return SHMediaItemProperty.ShazamId;
			if (constant.IsEqualTo (SHMediaItemTitle))
				return SHMediaItemProperty.Title;
			if (constant.IsEqualTo (SHMediaItemSubtitle))
				return SHMediaItemProperty.Subtitle;
			if (constant.IsEqualTo (SHMediaItemArtist))
				return SHMediaItemProperty.Artist;
			if (constant.IsEqualTo (SHMediaItemWebURL))
				return SHMediaItemProperty.WebUrl;
			if (constant.IsEqualTo (SHMediaItemAppleMusicID))
				return SHMediaItemProperty.AppleMusicId;
			if (constant.IsEqualTo (SHMediaItemAppleMusicURL))
				return SHMediaItemProperty.AppleMusicUrl;
			if (constant.IsEqualTo (SHMediaItemArtworkURL))
				return SHMediaItemProperty.ArtworkUrl;
			if (constant.IsEqualTo (SHMediaItemVideoURL))
				return SHMediaItemProperty.VideoUrl;
			if (constant.IsEqualTo (SHMediaItemExplicitContent))
				return SHMediaItemProperty.ExplicitContent;
			if (constant.IsEqualTo (SHMediaItemGenres))
				return SHMediaItemProperty.Genres;
			if (constant.IsEqualTo (SHMediaItemISRC))
				return SHMediaItemProperty.Isrc;
			if (constant.IsEqualTo (SHMediaItemMatchOffset))
				return SHMediaItemProperty.MatchOffset;
			if (constant.IsEqualTo (SHMediaItemFrequencySkew))
				return SHMediaItemProperty.FrequencySkew;
			if (constant.IsEqualTo (SHMediaItemTimeRanges))
				return SHMediaItemProperty.TimeRanges;
			if (constant.IsEqualTo (SHMediaItemFrequencySkewRanges))
				return SHMediaItemProperty.FrequencySkewRanges;
			if (constant.IsEqualTo (SHMediaItemCreationDate))
				return SHMediaItemProperty.CreationDate;
			if (constant.IsEqualTo (SHMediaItemConfidence))
				return SHMediaItemProperty.Confidence;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ShazamKit.SHMediaItemProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SHMediaItemProperty GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ShazamKit.SHMediaItemProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SHMediaItemProperty? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ShazamKit.SHMediaItemProperty" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SHMediaItemProperty[]? values)
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
		internal static SHMediaItemProperty[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SHMediaItemProperty> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
