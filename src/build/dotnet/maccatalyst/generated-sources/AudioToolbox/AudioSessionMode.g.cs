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
namespace AudioToolbox {
	/// <summary>The fine detail over the audio mode, an extension to the AudioSession Category</summary><remarks>
	/// This property is used to do the fine-level control over
	/// the audio session. The major component is determined by
	/// the category of the audio session, and this is used to tune whether the session
	/// behaves in the default mode, Voice Chat, Video Recording or is being
	/// used in Measurement mode (where you get raw data, without
	/// any gain changes for Audio).
	/// </remarks>
	public enum AudioSessionMode : int {
		/// <summary>
		/// 
		/// 	  The default value uses the same settings that existed in the
		/// 	  pre iOS 5.0 days.  If there is more than one microphone on
		/// 	  the device, the primary one is used.
		/// 
		/// 	</summary>
		Default = 1684434036,
		/// <summary>
		/// Used when you want to perform voice chats over a network connection. The audio stack is configured for voice recording, the default system microphone is used and sets the <see cref="F:AudioToolbox.AudioSessionProperty.OverrideCategoryEnableBluetoothInput" /> property to true.
		/// </summary>
		VoiceChat = 1986225012,
		/// <summary>Configures the audio for video recording, and uses the microphone closer to the camera as its input.</summary>
		VideoRecording = 1987208036,
		/// <summary>Used when you want to measure the audio, so no gains are applied to the data. This is used when setting the category to <see cref="F:AudioToolbox.AudioSessionCategory.PlayAndRecord" /> or <see cref="F:AudioToolbox.AudioSessionCategory.RecordAudio" /> values.</summary>
		Measurement = 1836281204,
		/// <summary>Set by GameKit, users should not set this directly.  Use VoiceChat instead. </summary>
		GameChat = 1735222132,
	}
}
