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
namespace Intents {
	/// <summary>Enumerates Intents / SiriKit intent types.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum INIntentIdentifier : int {
		None = -1,
		/// <summary>Start an audio call.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		StartAudioCall = 0,
		/// <summary>Start a video call.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		StartVideoCall = 1,
		/// <summary>Search the device call log.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SearchCallHistory = 2,
		/// <summary>Set the playback device in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetAudioSourceInCar = 3,
		/// <summary>Set the climate controls in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetClimateSettingsInCar = 4,
		/// <summary>Set the defroster settings in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetDefrosterSettingsInCar = 5,
		/// <summary>Set the seat configuration in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetSeatSettingsInCar = 6,
		/// <summary>Select a user configuration in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetProfileInCar = 7,
		/// <summary>Save a list of user preferences.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SaveProfileInCar = 8,
		/// <summary>Start a workout.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		StartWorkout = 9,
		/// <summary>Pause an active workout.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		PauseWorkout = 10,
		/// <summary>Complete an active workout.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		EndWorkout = 11,
		/// <summary>Cancel an active workout.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		CancelWorkout = 12,
		/// <summary>Resume a paused workout.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		ResumeWorkout = 13,
		/// <summary>Set a radio station in a car.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetRadioStation = 14,
		/// <summary>Send a text or messaging-app message.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SendMessage = 15,
		/// <summary>Search messages on the device.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SearchForMessages = 16,
		/// <summary>Change the metadata associated with a message.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SetMessageAttribute = 17,
		/// <summary>Send money.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SendPayment = 18,
		/// <summary>Request money.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		RequestPayment = 19,
		/// <summary>Search for photos.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SearchForPhotos = 20,
		/// <summary>Start a slideshow.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		StartPhotoPlayback = 21,
		/// <summary>Retrieve a list of available options for a ride.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		ListRideOptions = 22,
		/// <summary>Request a ride.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		RequestRide = 23,
		/// <summary>Retrieve the current status of a ride.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		GetRideStatus = 24,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		StartCall = 25,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		AnswerCall = 26,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		HangUpCall = 27,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INIntentIdentifier" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INIntentIdentifierExtensions {
		static IntPtr[] values = new IntPtr [2];
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[Field ("INAnswerCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INAnswerCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INAnswerCallIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[Field ("INHangUpCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INHangUpCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INHangUpCallIntentIdentifier", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INIntentIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 26: // INIntentIdentifier.AnswerCall
				ptr = INAnswerCallIntentIdentifier;
				break;
			case 27: // INIntentIdentifier.HangUpCall
				ptr = INHangUpCallIntentIdentifier;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INIntentIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static INIntentIdentifier GetValue (NSString? constant)
		{
			if (constant is null)
				return INIntentIdentifier.None;
			if (constant.IsEqualTo (INAnswerCallIntentIdentifier))
				return INIntentIdentifier.AnswerCall;
			if (constant.IsEqualTo (INHangUpCallIntentIdentifier))
				return INIntentIdentifier.HangUpCall;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Intents.INIntentIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INIntentIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INIntentIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INIntentIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Intents.INIntentIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this INIntentIdentifier[]? values)
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
		internal static INIntentIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<INIntentIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
