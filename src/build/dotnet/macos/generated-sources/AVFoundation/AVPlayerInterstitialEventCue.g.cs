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
namespace AVFoundation {
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public enum AVPlayerInterstitialEventCue : int {
		NoCue = 0,
		JoinCue = 1,
		LeaveCue = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVPlayerInterstitialEventCue" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVPlayerInterstitialEventCueExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("AVPlayerInterstitialEventNoCue", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerInterstitialEventNoCue {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerInterstitialEventNoCue", storage);
			}
		}
		[Field ("AVPlayerInterstitialEventJoinCue", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerInterstitialEventJoinCue {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerInterstitialEventJoinCue", storage);
			}
		}
		[Field ("AVPlayerInterstitialEventLeaveCue", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerInterstitialEventLeaveCue {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerInterstitialEventLeaveCue", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVPlayerInterstitialEventCue self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVPlayerInterstitialEventCue.NoCue
				ptr = AVPlayerInterstitialEventNoCue;
				break;
			case 1: // AVPlayerInterstitialEventCue.JoinCue
				ptr = AVPlayerInterstitialEventJoinCue;
				break;
			case 2: // AVPlayerInterstitialEventCue.LeaveCue
				ptr = AVPlayerInterstitialEventLeaveCue;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerInterstitialEventCue" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVPlayerInterstitialEventCue GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVPlayerInterstitialEventNoCue))
				return AVPlayerInterstitialEventCue.NoCue;
			if (constant.IsEqualTo (AVPlayerInterstitialEventJoinCue))
				return AVPlayerInterstitialEventCue.JoinCue;
			if (constant.IsEqualTo (AVPlayerInterstitialEventLeaveCue))
				return AVPlayerInterstitialEventCue.LeaveCue;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerInterstitialEventCue" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerInterstitialEventCue GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerInterstitialEventCue" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerInterstitialEventCue? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVPlayerInterstitialEventCue" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVPlayerInterstitialEventCue[]? values)
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
		internal static AVPlayerInterstitialEventCue[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVPlayerInterstitialEventCue> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
