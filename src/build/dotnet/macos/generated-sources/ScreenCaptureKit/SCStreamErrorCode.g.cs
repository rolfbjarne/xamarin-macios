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
namespace ScreenCaptureKit {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[Native]
	public enum SCStreamErrorCode : long {
		UserDeclined = -3801,
		FailedToStart = -3802,
		MissingEntitlements = -3803,
		FailedApplicationConnectionInvalid = -3804,
		FailedApplicationConnectionInterrupted = -3805,
		FailedNoMatchingApplicationContext = -3806,
		AttemptToStartStreamState = -3807,
		AttemptToStopStreamState = -3808,
		AttemptToUpdateFilterState = -3809,
		AttemptToConfigState = -3810,
		InternalError = -3811,
		InvalidParameter = -3812,
		NoWindowList = -3813,
		NoDisplayList = -3814,
		NoCaptureSource = -3815,
		RemovingStream = -3816,
		UserStopped = -3817,
		FailedToStartAudioCapture = -3818,
		FailedToStopAudioCapture = -3819,
		FailedToStartMicrophoneCapture = -3820,
		SystemStoppedStream = -3821,
	}
	/// <summary>Extension methods for the <see cref="global::ScreenCaptureKit.SCStreamErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::ScreenCaptureKit.SCStreamErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SCStreamErrorCodeExtensions {
		[Field ("SCStreamErrorDomain", "ScreenCaptureKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the ScreenCaptureKit.SCStreamErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this SCStreamErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamErrorDomain");
			return _domain;
		}
	}
}
