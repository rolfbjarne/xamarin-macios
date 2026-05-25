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
	/// <summary>Enumeration defining the various audio categories supported by AVAudioSession.</summary><remarks>
	/// These enumeration values are used with the strongly typed version of <see cref="M:AVFoundation.AVAudioSession.SetCategory(System.String,System.String,AVFoundation.AVAudioSessionRouteSharingPolicy,AVFoundation.AVAudioSessionCategoryOptions,Foundation.NSError@)" /> methods. 
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum AVAudioSessionCategory : int {
		/// <summary>
		/// 	    Use this category if playing audio is not your
		/// 	    application's main use and if your application can be used
		/// 	    with the sound off.  This allows background music to be
		/// 	    mixed with the audio your application produces.
		/// 	  </summary>
		Ambient = 0,
		/// <summary>
		/// 	    This is the default audio session category.
		/// 	  </summary>
		SoloAmbient = 1,
		/// <summary>
		/// 	    Use this if the main use of your application is to play back music.
		/// 	  </summary>
		Playback = 2,
		/// <summary>
		/// 	    Used to record audio.   This will prevent background audio and messages from playing back.
		/// 	  </summary>
		Record = 3,
		/// <summary>
		/// 	    Used to perform both playback and recording at the same time, for example for live chat applications.   
		/// 	  </summary>
		PlayAndRecord = 4,
		/// <summary>
		/// 	    Use this category when you want to use the hardware accelerated audio support to perform audio conversions.   
		/// 	  </summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		AudioProcessing = 5,
		/// <summary>To be added.</summary>
		MultiRoute = 6,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVAudioSessionCategory" /> enumeration.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVAudioSessionCategoryExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("AVAudioSessionCategoryAmbient", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryAmbient {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryAmbient", storage);
			}
		}
		[Field ("AVAudioSessionCategorySoloAmbient", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategorySoloAmbient {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategorySoloAmbient", storage);
			}
		}
		[Field ("AVAudioSessionCategoryPlayback", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryPlayback {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryPlayback", storage);
			}
		}
		[Field ("AVAudioSessionCategoryRecord", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryRecord {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryRecord", storage);
			}
		}
		[Field ("AVAudioSessionCategoryPlayAndRecord", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryPlayAndRecord {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryPlayAndRecord", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("AVAudioSessionCategoryAudioProcessing", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryAudioProcessing {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryAudioProcessing", storage);
			}
		}
		[Field ("AVAudioSessionCategoryMultiRoute", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionCategoryMultiRoute {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionCategoryMultiRoute", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVAudioSessionCategory self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVAudioSessionCategory.Ambient
				ptr = AVAudioSessionCategoryAmbient;
				break;
			case 1: // AVAudioSessionCategory.SoloAmbient
				ptr = AVAudioSessionCategorySoloAmbient;
				break;
			case 2: // AVAudioSessionCategory.Playback
				ptr = AVAudioSessionCategoryPlayback;
				break;
			case 3: // AVAudioSessionCategory.Record
				ptr = AVAudioSessionCategoryRecord;
				break;
			case 4: // AVAudioSessionCategory.PlayAndRecord
				ptr = AVAudioSessionCategoryPlayAndRecord;
				break;
			case 5: // AVAudioSessionCategory.AudioProcessing
				ptr = AVAudioSessionCategoryAudioProcessing;
				break;
			case 6: // AVAudioSessionCategory.MultiRoute
				ptr = AVAudioSessionCategoryMultiRoute;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionCategory" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVAudioSessionCategory GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVAudioSessionCategoryAmbient))
				return AVAudioSessionCategory.Ambient;
			if (constant.IsEqualTo (AVAudioSessionCategorySoloAmbient))
				return AVAudioSessionCategory.SoloAmbient;
			if (constant.IsEqualTo (AVAudioSessionCategoryPlayback))
				return AVAudioSessionCategory.Playback;
			if (constant.IsEqualTo (AVAudioSessionCategoryRecord))
				return AVAudioSessionCategory.Record;
			if (constant.IsEqualTo (AVAudioSessionCategoryPlayAndRecord))
				return AVAudioSessionCategory.PlayAndRecord;
			if (constant.IsEqualTo (AVAudioSessionCategoryAudioProcessing))
				return AVAudioSessionCategory.AudioProcessing;
			if (constant.IsEqualTo (AVAudioSessionCategoryMultiRoute))
				return AVAudioSessionCategory.MultiRoute;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAudioSessionCategory GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAudioSessionCategory? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVAudioSessionCategory" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVAudioSessionCategory[]? values)
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
		internal static AVAudioSessionCategory[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVAudioSessionCategory> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
