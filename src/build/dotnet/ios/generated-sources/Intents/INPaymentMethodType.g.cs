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
namespace Intents {
	/// <summary>Enumeates payment categories.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum INPaymentMethodType : long {
		/// <summary>The payment method's category is not known.</summary>
		Unknown = 0,
		/// <summary>Payment from a checking account.</summary>
		Checking = 1,
		/// <summary>Payment from a savings account.</summary>
		Savings = 2,
		/// <summary>Payment from a brokerage account.</summary>
		Brokerage = 3,
		/// <summary>Payment from a debit card.</summary>
		Debit = 4,
		/// <summary>Payment from a credit card.</summary>
		Credit = 5,
		/// <summary>Payment from a prepaid card or account.</summary>
		Prepaid = 6,
		/// <summary>Payment using a store card.</summary>
		Store = 7,
		/// <summary>Payment from Apple Pay.</summary>
		ApplePay = 8,
	}
}
