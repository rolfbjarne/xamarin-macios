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
namespace Speech {
	/// <summary>Enumeration of the permission status of speech recognition.</summary><remarks><para>Applications that use speech recognition must have an entry in their <c>info.plist</c> file with a key of <c>NSSpeechRecognitionUsageDescription</c> and a string value. The string value will be displayed in a standard system dialog after the developer calls <see cref="M:Speech.SFSpeechRecognizer.RequestAuthorization(System.Action{Speech.SFSpeechRecognizerAuthorizationStatus})" />.</para><example><code lang="XML"><![CDATA[
	/// 	<key>NSMicrophoneUsageDescription</key>
	/// 	<string>Your microphone will be used to record your speech when you press the "Start Recording" button.</string>
	/// 	<key>NSSpeechRecognitionUsageDescription</key>
	/// 	<string>Speech recognition will be used to determine which words you speak into this device's microphone.</string>          
	/// ]]></code></example><para>For instance:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// if (SFSpeechRecognizer.AuthorizationStatus != SFSpeechRecognizerAuthorizationStatus.Authorized)
	/// {
	/// 	SFSpeechRecognizer.RequestAuthorization((status) =>
	/// 	{
	/// 		switch (status)
	/// 		{
	/// 			case SFSpeechRecognizerAuthorizationStatus.Authorized:
	/// 				InvokeOnMainThread(() => prepareButton.Enabled = true);
	/// 				break;
	/// 			case SFSpeechRecognizerAuthorizationStatus.Restricted:
	/// 			case SFSpeechRecognizerAuthorizationStatus.NotDetermined:
	/// 			case SFSpeechRecognizerAuthorizationStatus.Denied:
	/// 				prepareButton.Enabled = false;
	/// 				break;
	/// 		}
	/// 	});
	/// }          
	/// ]]></code></example></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[Native]
	public enum SFSpeechRecognizerAuthorizationStatus : long {
		/// <summary>Permission has not been presented.</summary>
		NotDetermined = 0,
		/// <summary>The user has denied permission for speech recognition.</summary>
		Denied = 1,
		/// <summary>To be added.</summary>
		Restricted = 2,
		/// <summary>The user has allowed speech recognition.</summary>
		Authorized = 3,
	}
}
