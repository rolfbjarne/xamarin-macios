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
namespace AudioUnit {
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum AudioObjectPropertySelector : uint {
		/// <summary>To be added.</summary>
		PropertyDevices = 1684370979,
		/// <summary>To be added.</summary>
		Devices = 1684370979,
		/// <summary>To be added.</summary>
		DefaultInputDevice = 1682533920,
		/// <summary>To be added.</summary>
		DefaultOutputDevice = 1682929012,
		/// <summary>To be added.</summary>
		DefaultSystemOutputDevice = 1934587252,
		/// <summary>To be added.</summary>
		TranslateUIDToDevice = 1969841252,
		/// <summary>To be added.</summary>
		MixStereoToMono = 1937010031,
		/// <summary>To be added.</summary>
		PlugInList = 1886152483,
		/// <summary>To be added.</summary>
		TranslateBundleIDToPlugIn = 1651074160,
		/// <summary>To be added.</summary>
		TransportManagerList = 1953326883,
		/// <summary>To be added.</summary>
		TranslateBundleIDToTransportManager = 1953325673,
		/// <summary>To be added.</summary>
		BoxList = 1651472419,
		/// <summary>To be added.</summary>
		TranslateUIDToBox = 1969841250,
		ClockDeviceList = 1668049699,
		TranslateUidToClockDevice = 1969841251,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use the 'ProcessIsMain' element instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use the 'ProcessIsMain' element instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'ProcessIsMain' element instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'ProcessIsMain' element instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Obsolete ("Use the 'ProcessIsMain' element instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		ProcessIsMaster = 1835103092,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		ProcessIsMain = 1835100526,
		/// <summary>To be added.</summary>
		IsInitingOrExiting = 1768845172,
		/// <summary>To be added.</summary>
		UserIDChanged = 1702193508,
		/// <summary>To be added.</summary>
		ProcessIsAudible = 1886221684,
		/// <summary>To be added.</summary>
		SleepingIsAllowed = 1936483696,
		/// <summary>To be added.</summary>
		UnloadingIsAllowed = 1970170980,
		/// <summary>To be added.</summary>
		HogModeIsAllowed = 1752131442,
		/// <summary>To be added.</summary>
		UserSessionIsActiveOrHeadless = 1970496882,
		/// <summary>To be added.</summary>
		ServiceRestarted = 1936880500,
		/// <summary>To be added.</summary>
		PowerHint = 1886353256,
		ActualSampleRate = 1634955892,
		ClockDevice = 1634755428,
		IOThreadOSWorkgroup = 1869838183,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		ProcessMute = 1634758765,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		InputMute = 1852403056,
	}
}
