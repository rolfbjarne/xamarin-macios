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
	/// <summary>Enumerates types of payment accounts.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INAccountType : long {
		/// <summary>An account whose type is unknown.</summary>
		Unknown = 0,
		/// <summary>A checking account maintained at a bank.</summary>
		Checking = 1,
		/// <summary>A credit line.</summary>
		Credit = 2,
		/// <summary>An account with a set debit amount.</summary>
		Debit = 3,
		/// <summary>An investment account.</summary>
		Investment = 4,
		/// <summary>A mortgage account.</summary>
		Mortgage = 5,
		/// <summary>A prepaid debit card.</summary>
		Prepaid = 6,
		/// <summary>A savings account held at a bank.</summary>
		Saving = 7,
	}
}
