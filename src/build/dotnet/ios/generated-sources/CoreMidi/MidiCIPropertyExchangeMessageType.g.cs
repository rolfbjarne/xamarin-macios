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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
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
