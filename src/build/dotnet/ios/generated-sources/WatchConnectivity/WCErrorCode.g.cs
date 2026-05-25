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
namespace WatchConnectivity {
	/// <summary>Enumerates error codes relating to watch connectivity.</summary>
	[Native]
	public enum WCErrorCode : long {
		/// <summary>The exact error is unknown.</summary>
		GenericError = 7001,
		/// <summary>The device does not support <see cref="T:WatchConnectivity.WCSession" /> objects.</summary>
		SessionNotSupported = 7002,
		/// <summary>There is no active extension delegate for the <see cref="T:WatchConnectivity.WCSession" />.</summary>
		SessionMissingDelegate = 7003,
		/// <summary>The companion app has not activated a <see cref="T:WatchConnectivity.WCSession" />.</summary>
		SessionNotActivated = 7004,
		/// <summary>Indicates that no device was paired.</summary>
		DeviceNotPaired = 7005,
		/// <summary>The app is not installed on the user's paired Apple Watch.</summary>
		WatchAppNotInstalled = 7006,
		/// <summary>The companion app is not available.</summary>
		NotReachable = 7007,
		/// <summary>A bad argument was passed.</summary>
		InvalidParameter = 7008,
		/// <summary>The data was too large to transfer.</summary>
		PayloadTooLarge = 7009,
		/// <summary>Transferred dictionaries may only contain property-list types.</summary>
		PayloadUnsupportedTypes = 7010,
		/// <summary>The reply could not be returned.</summary>
		MessageReplyFailed = 7011,
		/// <summary>The companion app did not return a reply within the allowed time.</summary>
		MessageReplyTimedOut = 7012,
		/// <summary>File transfer failed due to permissions.</summary>
		FileAccessDenied = 7013,
		/// <summary>Indicates that the payload was not delivered.</summary>
		DeliveryFailed = 7014,
		/// <summary>Indicates that the receiver did not have enough storage to receive the payload.</summary>
		InsufficientSpace = 7015,
		/// <summary>Indicates that the session was not active.</summary>
		SessionInactive = 7016,
		/// <summary>Indicates that the transfer timed out.</summary>
		TransferTimedOut = 7017,
		CompanionAppNotInstalled = 7018,
		WatchOnlyApp = 7019,
	}
}
