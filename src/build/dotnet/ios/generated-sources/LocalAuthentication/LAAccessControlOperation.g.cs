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
namespace LocalAuthentication {
	/// <summary>Enumerates access control operations for the <see cref="M:LocalAuthentication.LAContext.EvaluateAccessControl(Security.SecAccessControl,LocalAuthentication.LAAccessControlOperation,System.String,System.Action{System.Boolean,Foundation.NSError})" /> method.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum LAAccessControlOperation : long {
		/// <summary>Indicates an item creation operation.</summary>
		CreateItem = 0,
		/// <summary>Indicates an item use operation.</summary>
		UseItem = 1,
		/// <summary>Indicates a key creation operation.</summary>
		CreateKey = 2,
		/// <summary>Indicates an key signing operation.</summary>
		UseKeySign = 3,
		/// <summary>Indicates a decryption operation with a key.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		UseKeyDecrypt = 4,
		/// <summary>Indicates an key exchange operation.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		UseKeyKeyExchange = 5,
	}
}
