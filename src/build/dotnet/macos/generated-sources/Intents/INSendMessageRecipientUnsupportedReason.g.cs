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
	/// <summary>Enumerates reasons that a recipient was not supported.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum INSendMessageRecipientUnsupportedReason : long {
		/// <summary>Indicates that the recipient had no account.</summary>
		NoAccount = 1,
		/// <summary>Indicates that the recipient is offline.</summary>
		Offline = 2,
		/// <summary>Indicates that the recipient was not enabled in the messaging service.</summary>
		MessagingServiceNotEnabledForRecipient = 3,
		/// <summary>To be added.</summary>
		NoValidHandle = 4,
		/// <summary>To be added.</summary>
		RequestedHandleInvalid = 5,
		/// <summary>To be added.</summary>
		NoHandleForLabel = 6,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		RequiringInAppAuthentication = 7,
	}
}
