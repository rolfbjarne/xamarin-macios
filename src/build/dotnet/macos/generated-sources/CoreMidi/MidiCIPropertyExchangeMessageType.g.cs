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
namespace CoreMidi {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[NativeName ("MIDICIPropertyExchangeMessageType")]
	public enum MidiCIPropertyExchangeMessageType : byte {
		InquiryPropertyExchangeCapabilities = 48,
		ReplyToPropertyExchangeCapabilities = 49,
		InquiryHasPropertyData_Reserved = 50,
		InquiryReplyToHasPropertyData_Reserved = 51,
		InquiryGetPropertyData = 52,
		ReplyToGetProperty = 53,
		InquirySetPropertyData = 54,
		ReplyToSetPropertyData = 55,
		Subscription = 56,
		ReplyToSubscription = 57,
		Notify = 63,
	}
}
