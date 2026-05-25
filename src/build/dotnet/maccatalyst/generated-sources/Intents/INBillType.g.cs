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
	/// <summary>Enumerates common bills.</summary>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INBillType : long {
		/// <summary>A bill of an indeterminate or unknown type.</summary>
		Unknown = 0,
		/// <summary>A bill for auto insurance.</summary>
		AutoInsurance = 1,
		/// <summary>A bill for a cable provider.</summary>
		Cable = 2,
		/// <summary>A bill for a car lease.</summary>
		CarLease = 3,
		/// <summary>A bill for a car loan.</summary>
		CarLoan = 4,
		/// <summary>A bill for a credit card.</summary>
		CreditCard = 5,
		/// <summary>A bill for electricity.</summary>
		Electricity = 6,
		/// <summary>A bill for gas.</summary>
		Gas = 7,
		/// <summary>A bill for waste removal.</summary>
		GarbageAndRecycling = 8,
		/// <summary>A bill for health insurance.</summary>
		HealthInsurance = 9,
		/// <summary>A bill for home insurance.</summary>
		HomeInsurance = 10,
		/// <summary>A bill for internet access.</summary>
		Internet = 11,
		/// <summary>A bill for life insurance.</summary>
		LifeInsurance = 12,
		/// <summary>A bill for a mortgage.</summary>
		Mortgage = 13,
		/// <summary>A bill for a music streaming service.</summary>
		MusicStreaming = 14,
		/// <summary>A phone bill.</summary>
		Phone = 15,
		/// <summary>A rent bill.</summary>
		Rent = 16,
		/// <summary>A bill for sewer use.</summary>
		Sewer = 17,
		/// <summary>A bill for a student loan.</summary>
		StudentLoan = 18,
		/// <summary>A fine for a traffic ticket.</summary>
		TrafficTicket = 19,
		/// <summary>A bill for tuition.</summary>
		Tuition = 20,
		/// <summary>A general utility bill.</summary>
		Utilities = 21,
		/// <summary>A bill for water.</summary>
		Water = 22,
	}
}
