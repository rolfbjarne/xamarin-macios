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
namespace IdentityLookup {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[Native]
	public enum ILMessageFilterSubAction : long {
		None = 0,
		TransactionalOthers = 10000,
		TransactionalFinance = 10001,
		TransactionalOrders = 10002,
		TransactionalReminders = 10003,
		TransactionalHealth = 10004,
		TransactionalWeather = 10005,
		TransactionalCarrier = 10006,
		TransactionalRewards = 10007,
		TransactionalPublicServices = 10008,
		PromotionalOthers = 20000,
		PromotionalOffers = 20001,
		PromotionalCoupons = 20002,
	}
}
