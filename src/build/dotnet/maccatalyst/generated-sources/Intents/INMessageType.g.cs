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
	/// <summary>Enumerates message content types.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INMessageType : long {
		/// <summary>Indicates unspecified content.</summary>
		Unspecified = 0,
		/// <summary>Indicates text.</summary>
		Text = 1,
		/// <summary>Indicates audio content.</summary>
		Audio = 2,
		/// <summary>Indicates digital touch content.</summary>
		DigitalTouch = 3,
		/// <summary>Indicates handwriting.</summary>
		Handwriting = 4,
		/// <summary>Indicates a sticker.</summary>
		Sticker = 5,
		/// <summary>Indicates "liked" tap-back data.</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackLiked = 6,
		/// <summary>Indicates "disliked" tap-back data.</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackDisliked = 7,
		/// <summary>Indicates "emphasized" tap-back data.</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackEmphasized = 8,
		/// <summary>Indicates "loved" tap-back data.</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackLoved = 9,
		/// <summary>Indicates "questioned" tap-back data..</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackQuestioned = 10,
		/// <summary>Indicates "laughed" tap-back data.</summary>
		[ObsoletedOSPlatform ("ios18.1", "Use 'INMessageReaction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use 'INMessageReaction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		TapbackLaughed = 11,
		/// <summary>Indicates media with calendar data.</summary>
		MediaCalendar = 12,
		/// <summary>Indicates media with location data.</summary>
		MediaLocation = 13,
		/// <summary>Indicates media with card data.</summary>
		MediaAddressCard = 14,
		/// <summary>Indicates media with image data.</summary>
		MediaImage = 15,
		/// <summary>Indicates media with video data.</summary>
		MediaVideo = 16,
		/// <summary>Indicates media with PassKit data.</summary>
		MediaPass = 17,
		/// <summary>Indicates media with audio data.</summary>
		MediaAudio = 18,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		PaymentSent = 19,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		PaymentRequest = 20,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		PaymentNote = 21,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Animoji = 22,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		ActivitySnippet = 23,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		File = 24,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Link = 25,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		Reaction = 26,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		MediaAnimatedImage = 27,
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		ThirdPartyAttachment = 28,
	}
}
