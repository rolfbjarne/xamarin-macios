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
		static IntPtr[] values = new IntPtr [28];
		[ObsoletedOSPlatform ("ios14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INStartAudioCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INStartAudioCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INStartAudioCallIntentIdentifier", storage);
			}
		}
		[ObsoletedOSPlatform ("ios14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'StartCall' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INStartVideoCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INStartVideoCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INStartVideoCallIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSearchCallHistoryIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSearchCallHistoryIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSearchCallHistoryIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetAudioSourceInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetAudioSourceInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetAudioSourceInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetClimateSettingsInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetClimateSettingsInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetClimateSettingsInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetDefrosterSettingsInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetDefrosterSettingsInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetDefrosterSettingsInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetSeatSettingsInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetSeatSettingsInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetSeatSettingsInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetProfileInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetProfileInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetProfileInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSaveProfileInCarIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSaveProfileInCarIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSaveProfileInCarIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INStartWorkoutIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INStartWorkoutIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INStartWorkoutIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INPauseWorkoutIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INPauseWorkoutIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPauseWorkoutIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INEndWorkoutIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INEndWorkoutIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INEndWorkoutIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INCancelWorkoutIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INCancelWorkoutIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCancelWorkoutIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INResumeWorkoutIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INResumeWorkoutIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INResumeWorkoutIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetRadioStationIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetRadioStationIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetRadioStationIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSendMessageIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSendMessageIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSendMessageIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSearchForMessagesIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSearchForMessagesIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSearchForMessagesIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSetMessageAttributeIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSetMessageAttributeIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSetMessageAttributeIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSendPaymentIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSendPaymentIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSendPaymentIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INRequestPaymentIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INRequestPaymentIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INRequestPaymentIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INSearchForPhotosIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INSearchForPhotosIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INSearchForPhotosIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INStartPhotoPlaybackIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INStartPhotoPlaybackIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INStartPhotoPlaybackIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INListRideOptionsIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INListRideOptionsIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INListRideOptionsIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INRequestRideIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INRequestRideIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INRequestRideIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INGetRideStatusIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INGetRideStatusIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INGetRideStatusIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("INStartCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INStartCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INStartCallIntentIdentifier", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[Field ("INAnswerCallIntentIdentifier", "Intents")]
		internal unsafe static IntPtr INAnswerCallIntentIdentifier {
			get {
				fixed (IntPtr *storage = &values [26])
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
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INHangUpCallIntentIdentifier", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INIntentIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // INIntentIdentifier.StartAudioCall
				ptr = INStartAudioCallIntentIdentifier;
				break;
			case 1: // INIntentIdentifier.StartVideoCall
				ptr = INStartVideoCallIntentIdentifier;
				break;
			case 2: // INIntentIdentifier.SearchCallHistory
				ptr = INSearchCallHistoryIntentIdentifier;
				break;
			case 3: // INIntentIdentifier.SetAudioSourceInCar
				ptr = INSetAudioSourceInCarIntentIdentifier;
				break;
			case 4: // INIntentIdentifier.SetClimateSettingsInCar
				ptr = INSetClimateSettingsInCarIntentIdentifier;
				break;
			case 5: // INIntentIdentifier.SetDefrosterSettingsInCar
				ptr = INSetDefrosterSettingsInCarIntentIdentifier;
				break;
			case 6: // INIntentIdentifier.SetSeatSettingsInCar
				ptr = INSetSeatSettingsInCarIntentIdentifier;
				break;
			case 7: // INIntentIdentifier.SetProfileInCar
				ptr = INSetProfileInCarIntentIdentifier;
				break;
			case 8: // INIntentIdentifier.SaveProfileInCar
				ptr = INSaveProfileInCarIntentIdentifier;
				break;
			case 9: // INIntentIdentifier.StartWorkout
				ptr = INStartWorkoutIntentIdentifier;
				break;
			case 10: // INIntentIdentifier.PauseWorkout
				ptr = INPauseWorkoutIntentIdentifier;
				break;
			case 11: // INIntentIdentifier.EndWorkout
				ptr = INEndWorkoutIntentIdentifier;
				break;
			case 12: // INIntentIdentifier.CancelWorkout
				ptr = INCancelWorkoutIntentIdentifier;
				break;
			case 13: // INIntentIdentifier.ResumeWorkout
				ptr = INResumeWorkoutIntentIdentifier;
				break;
			case 14: // INIntentIdentifier.SetRadioStation
				ptr = INSetRadioStationIntentIdentifier;
				break;
			case 15: // INIntentIdentifier.SendMessage
				ptr = INSendMessageIntentIdentifier;
				break;
			case 16: // INIntentIdentifier.SearchForMessages
				ptr = INSearchForMessagesIntentIdentifier;
				break;
			case 17: // INIntentIdentifier.SetMessageAttribute
				ptr = INSetMessageAttributeIntentIdentifier;
				break;
			case 18: // INIntentIdentifier.SendPayment
				ptr = INSendPaymentIntentIdentifier;
				break;
			case 19: // INIntentIdentifier.RequestPayment
				ptr = INRequestPaymentIntentIdentifier;
				break;
			case 20: // INIntentIdentifier.SearchForPhotos
				ptr = INSearchForPhotosIntentIdentifier;
				break;
			case 21: // INIntentIdentifier.StartPhotoPlayback
				ptr = INStartPhotoPlaybackIntentIdentifier;
				break;
			case 22: // INIntentIdentifier.ListRideOptions
				ptr = INListRideOptionsIntentIdentifier;
				break;
			case 23: // INIntentIdentifier.RequestRide
				ptr = INRequestRideIntentIdentifier;
				break;
			case 24: // INIntentIdentifier.GetRideStatus
				ptr = INGetRideStatusIntentIdentifier;
				break;
			case 25: // INIntentIdentifier.StartCall
				ptr = INStartCallIntentIdentifier;
				break;
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
			if (constant.IsEqualTo (INStartAudioCallIntentIdentifier))
				return INIntentIdentifier.StartAudioCall;
			if (constant.IsEqualTo (INStartVideoCallIntentIdentifier))
				return INIntentIdentifier.StartVideoCall;
			if (constant.IsEqualTo (INSearchCallHistoryIntentIdentifier))
				return INIntentIdentifier.SearchCallHistory;
			if (constant.IsEqualTo (INSetAudioSourceInCarIntentIdentifier))
				return INIntentIdentifier.SetAudioSourceInCar;
			if (constant.IsEqualTo (INSetClimateSettingsInCarIntentIdentifier))
				return INIntentIdentifier.SetClimateSettingsInCar;
			if (constant.IsEqualTo (INSetDefrosterSettingsInCarIntentIdentifier))
				return INIntentIdentifier.SetDefrosterSettingsInCar;
			if (constant.IsEqualTo (INSetSeatSettingsInCarIntentIdentifier))
				return INIntentIdentifier.SetSeatSettingsInCar;
			if (constant.IsEqualTo (INSetProfileInCarIntentIdentifier))
				return INIntentIdentifier.SetProfileInCar;
			if (constant.IsEqualTo (INSaveProfileInCarIntentIdentifier))
				return INIntentIdentifier.SaveProfileInCar;
			if (constant.IsEqualTo (INStartWorkoutIntentIdentifier))
				return INIntentIdentifier.StartWorkout;
			if (constant.IsEqualTo (INPauseWorkoutIntentIdentifier))
				return INIntentIdentifier.PauseWorkout;
			if (constant.IsEqualTo (INEndWorkoutIntentIdentifier))
				return INIntentIdentifier.EndWorkout;
			if (constant.IsEqualTo (INCancelWorkoutIntentIdentifier))
				return INIntentIdentifier.CancelWorkout;
			if (constant.IsEqualTo (INResumeWorkoutIntentIdentifier))
				return INIntentIdentifier.ResumeWorkout;
			if (constant.IsEqualTo (INSetRadioStationIntentIdentifier))
				return INIntentIdentifier.SetRadioStation;
			if (constant.IsEqualTo (INSendMessageIntentIdentifier))
				return INIntentIdentifier.SendMessage;
			if (constant.IsEqualTo (INSearchForMessagesIntentIdentifier))
				return INIntentIdentifier.SearchForMessages;
			if (constant.IsEqualTo (INSetMessageAttributeIntentIdentifier))
				return INIntentIdentifier.SetMessageAttribute;
			if (constant.IsEqualTo (INSendPaymentIntentIdentifier))
				return INIntentIdentifier.SendPayment;
			if (constant.IsEqualTo (INRequestPaymentIntentIdentifier))
				return INIntentIdentifier.RequestPayment;
			if (constant.IsEqualTo (INSearchForPhotosIntentIdentifier))
				return INIntentIdentifier.SearchForPhotos;
			if (constant.IsEqualTo (INStartPhotoPlaybackIntentIdentifier))
				return INIntentIdentifier.StartPhotoPlayback;
			if (constant.IsEqualTo (INListRideOptionsIntentIdentifier))
				return INIntentIdentifier.ListRideOptions;
			if (constant.IsEqualTo (INRequestRideIntentIdentifier))
				return INIntentIdentifier.RequestRide;
			if (constant.IsEqualTo (INGetRideStatusIntentIdentifier))
				return INIntentIdentifier.GetRideStatus;
			if (constant.IsEqualTo (INStartCallIntentIdentifier))
				return INIntentIdentifier.StartCall;
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
