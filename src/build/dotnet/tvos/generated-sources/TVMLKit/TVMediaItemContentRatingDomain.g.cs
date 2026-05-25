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
namespace TVMLKit {
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	public enum TVMediaItemContentRatingDomain : int {
		UnknownCustomExtension = -1,
		None = 0,
		Movie = 1,
		TVShow = 2,
		Music = 3,
	}
	/// <summary>Extension methods for the <see cref="global::TVMLKit.TVMediaItemContentRatingDomain" /> enumeration.</summary>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class TVMediaItemContentRatingDomainExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("TVMediaItemContentRatingDomainMovie", "TVMLKit")]
		internal unsafe static IntPtr TVMediaItemContentRatingDomainMovie {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVMediaItemContentRatingDomainMovie", storage);
			}
		}
		[Field ("TVMediaItemContentRatingDomainTVShow", "TVMLKit")]
		internal unsafe static IntPtr TVMediaItemContentRatingDomainTVShow {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVMediaItemContentRatingDomainTVShow", storage);
			}
		}
		[Field ("TVMediaItemContentRatingDomainMusic", "TVMLKit")]
		internal unsafe static IntPtr TVMediaItemContentRatingDomainMusic {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVMediaItemContentRatingDomainMusic", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this TVMediaItemContentRatingDomain self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // TVMediaItemContentRatingDomain.Movie
				ptr = TVMediaItemContentRatingDomainMovie;
				break;
			case 2: // TVMediaItemContentRatingDomain.TVShow
				ptr = TVMediaItemContentRatingDomainTVShow;
				break;
			case 3: // TVMediaItemContentRatingDomain.Music
				ptr = TVMediaItemContentRatingDomainMusic;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVMediaItemContentRatingDomain" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static TVMediaItemContentRatingDomain GetValue (NSString? constant)
		{
			if (constant is null)
				return TVMediaItemContentRatingDomain.None;
			if (constant.IsEqualTo (TVMediaItemContentRatingDomainMovie))
				return TVMediaItemContentRatingDomain.Movie;
			if (constant.IsEqualTo (TVMediaItemContentRatingDomainTVShow))
				return TVMediaItemContentRatingDomain.TVShow;
			if (constant.IsEqualTo (TVMediaItemContentRatingDomainMusic))
				return TVMediaItemContentRatingDomain.Music;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVMediaItemContentRatingDomain" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static TVMediaItemContentRatingDomain GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVMediaItemContentRatingDomain" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static TVMediaItemContentRatingDomain? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::TVMLKit.TVMediaItemContentRatingDomain" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this TVMediaItemContentRatingDomain[]? values)
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
		internal static TVMediaItemContentRatingDomain[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<TVMediaItemContentRatingDomain> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
