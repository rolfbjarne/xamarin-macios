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
namespace NetworkExtension {
	/// <summary>Enumerates reasons that a provider extension has stopped.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NEProviderStopReason : long {
		/// <summary>An unspecified failure occurred, or no failure occurred.</summary>
		None = 0,
		/// <summary>The user stopped the provider.</summary>
		UserInitiated = 1,
		/// <summary>The provider failed.</summary>
		ProviderFailed = 2,
		/// <summary>The network was unavailable.</summary>
		NoNetworkAvailable = 3,
		/// <summary>The network connectivity changed and the provider could not recover.</summary>
		UnrecoverableNetworkChange = 4,
		/// <summary>The provider was not enabled.</summary>
		ProviderDisabled = 5,
		/// <summary>An authentication operation was canceled.</summary>
		AuthenticationCanceled = 6,
		/// <summary>The network configuration failed.</summary>
		ConfigurationFailed = 7,
		/// <summary>The session timed out.</summary>
		IdleTimeout = 8,
		/// <summary>The network configuration was disabled.</summary>
		ConfigurationDisabled = 9,
		/// <summary>The network configuration was removed.</summary>
		ConfigurationRemoved = 10,
		/// <summary>The configuration was superseded by another.</summary>
		Superseded = 11,
		/// <summary>The user logged off.</summary>
		UserLogout = 12,
		/// <summary>The user changed.</summary>
		UserSwitch = 13,
		/// <summary>The network connection failed.</summary>
		ConnectionFailed = 14,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Sleep = 15,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AppUpdate = 16,
		[SupportedOSPlatform ("ios18.1")]
		[SupportedOSPlatform ("maccatalyst18.1")]
		[SupportedOSPlatform ("tvos18.1")]
		[SupportedOSPlatform ("macos15.1")]
		InternalError = 17,
	}
}
