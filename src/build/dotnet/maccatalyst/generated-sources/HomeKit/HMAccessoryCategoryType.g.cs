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
namespace HomeKit {
	/// <summary>Enumerates the kind of accessories supported by HomeKit.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum HMAccessoryCategoryType : int {
		/// <summary>An accessory that does not fit into any of the enumerated <see cref="T:HomeKit.HMAccessoryCategoryType" /> categories.</summary>
		Other = 0,
		/// <summary>An accessory that monitors, and may have internal rules for controlling, security sensors and cameras.</summary>
		SecuritySystem = 1,
		/// <summary>Connects multiple accessories.</summary>
		Bridge = 2,
		/// <summary>Represents a physical door that may be opened or closed.</summary>
		Door = 3,
		/// <summary>An accessory that can lock or unlock a door.</summary>
		DoorLock = 4,
		/// <summary>A motorized air-mover.</summary>
		Fan = 5,
		/// <summary>An accessory that controls a garage door.</summary>
		GarageDoorOpener = 6,
		/// <summary>An accessory capable of opening and closing a door.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Obsolete ("Use 'GarageDoorOpener' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		DoorOpener = 6,
		/// <summary>Represents a physical lightbulb.</summary>
		Lightbulb = 7,
		/// <summary>An electrical power outlet.</summary>
		Outlet = 8,
		/// <summary>A switch accessory that may maintain a locally-stored set of rules. (See also <see cref="F:HomeKit.HMAccessoryCategoryType.Switch" />.)</summary>
		ProgrammableSwitch = 9,
		/// <summary>Represents a physical sensor.</summary>
		Sensor = 10,
		/// <summary>A switch. (See also <see cref="F:HomeKit.HMAccessoryCategoryType.ProgrammableSwitch" />.)</summary>
		Switch = 11,
		/// <summary>An accessory that controls heating and cooling systems.</summary>
		Thermostat = 12,
		/// <summary>Represents a physical window.</summary>
		Window = 13,
		/// <summary>Represents shades or drapes.</summary>
		WindowCovering = 14,
		/// <summary>An accessory that extends network communication.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		RangeExtender = 15,
		/// <summary>A video camera that can stream its data over IP networks.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		IPCamera = 16,
		/// <summary>Represents a video doorbell.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VideoDoorbell = 17,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirPurifier = 18,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirHeater = 19,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirConditioner = 20,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirHumidifier = 21,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirDehumidifier = 22,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Sprinkler = 23,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Faucet = 24,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ShowerHead = 25,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Television = 26,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		TelevisionSetTopBox = 27,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		TelevisionStreamingStick = 28,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WiFiRouter = 29,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Speaker = 30,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		AudioReceiver = 31,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		AirPort = 32,
	}
	/// <summary>Extension methods for the <see cref="global::HomeKit.HMAccessoryCategoryType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HMAccessoryCategoryTypeExtensions {
		static IntPtr[] values = new IntPtr [33];
		[Field ("HMAccessoryCategoryTypeOther", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeOther {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeOther", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeSecuritySystem", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeSecuritySystem {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeSecuritySystem", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeBridge", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeBridge {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeBridge", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeDoor", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeDoor {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeDoor", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeDoorLock", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeDoorLock {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeDoorLock", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeFan", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeFan {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeFan", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeGarageDoorOpener", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeGarageDoorOpener {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeGarageDoorOpener", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeLightbulb", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeLightbulb {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeLightbulb", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeOutlet", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeOutlet {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeOutlet", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeProgrammableSwitch", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeProgrammableSwitch {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeProgrammableSwitch", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeSensor", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeSensor {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeSensor", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeSwitch", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeSwitch {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeSwitch", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeThermostat", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeThermostat {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeThermostat", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeWindow", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeWindow {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeWindow", storage);
			}
		}
		[Field ("HMAccessoryCategoryTypeWindowCovering", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeWindowCovering {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeWindowCovering", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeRangeExtender", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeRangeExtender {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeRangeExtender", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeIPCamera", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeIPCamera {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeIPCamera", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeVideoDoorbell", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeVideoDoorbell {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeVideoDoorbell", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeAirPurifier", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirPurifier {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirPurifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeAirHeater", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirHeater {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirHeater", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeAirConditioner", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirConditioner {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirConditioner", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeAirHumidifier", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirHumidifier {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirHumidifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeAirDehumidifier", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirDehumidifier {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirDehumidifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeSprinkler", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeSprinkler {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeSprinkler", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeFaucet", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeFaucet {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeFaucet", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMAccessoryCategoryTypeShowerHead", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeShowerHead {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeShowerHead", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeTelevision", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeTelevision {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeTelevision", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeTelevisionSetTopBox", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeTelevisionSetTopBox {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeTelevisionSetTopBox", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeTelevisionStreamingStick", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeTelevisionStreamingStick {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeTelevisionStreamingStick", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeWiFiRouter", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeWiFiRouter {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeWiFiRouter", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeSpeaker", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeSpeaker {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeSpeaker", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeAudioReceiver", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAudioReceiver {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAudioReceiver", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMAccessoryCategoryTypeAirPort", "HomeKit")]
		internal unsafe static IntPtr HMAccessoryCategoryTypeAirPort {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMAccessoryCategoryTypeAirPort", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HMAccessoryCategoryType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HMAccessoryCategoryType.Other
				ptr = HMAccessoryCategoryTypeOther;
				break;
			case 1: // HMAccessoryCategoryType.SecuritySystem
				ptr = HMAccessoryCategoryTypeSecuritySystem;
				break;
			case 2: // HMAccessoryCategoryType.Bridge
				ptr = HMAccessoryCategoryTypeBridge;
				break;
			case 3: // HMAccessoryCategoryType.Door
				ptr = HMAccessoryCategoryTypeDoor;
				break;
			case 4: // HMAccessoryCategoryType.DoorLock
				ptr = HMAccessoryCategoryTypeDoorLock;
				break;
			case 5: // HMAccessoryCategoryType.Fan
				ptr = HMAccessoryCategoryTypeFan;
				break;
			case 6: // HMAccessoryCategoryType.GarageDoorOpener
				ptr = HMAccessoryCategoryTypeGarageDoorOpener;
				break;
			case 7: // HMAccessoryCategoryType.Lightbulb
				ptr = HMAccessoryCategoryTypeLightbulb;
				break;
			case 8: // HMAccessoryCategoryType.Outlet
				ptr = HMAccessoryCategoryTypeOutlet;
				break;
			case 9: // HMAccessoryCategoryType.ProgrammableSwitch
				ptr = HMAccessoryCategoryTypeProgrammableSwitch;
				break;
			case 10: // HMAccessoryCategoryType.Sensor
				ptr = HMAccessoryCategoryTypeSensor;
				break;
			case 11: // HMAccessoryCategoryType.Switch
				ptr = HMAccessoryCategoryTypeSwitch;
				break;
			case 12: // HMAccessoryCategoryType.Thermostat
				ptr = HMAccessoryCategoryTypeThermostat;
				break;
			case 13: // HMAccessoryCategoryType.Window
				ptr = HMAccessoryCategoryTypeWindow;
				break;
			case 14: // HMAccessoryCategoryType.WindowCovering
				ptr = HMAccessoryCategoryTypeWindowCovering;
				break;
			case 15: // HMAccessoryCategoryType.RangeExtender
				ptr = HMAccessoryCategoryTypeRangeExtender;
				break;
			case 16: // HMAccessoryCategoryType.IPCamera
				ptr = HMAccessoryCategoryTypeIPCamera;
				break;
			case 17: // HMAccessoryCategoryType.VideoDoorbell
				ptr = HMAccessoryCategoryTypeVideoDoorbell;
				break;
			case 18: // HMAccessoryCategoryType.AirPurifier
				ptr = HMAccessoryCategoryTypeAirPurifier;
				break;
			case 19: // HMAccessoryCategoryType.AirHeater
				ptr = HMAccessoryCategoryTypeAirHeater;
				break;
			case 20: // HMAccessoryCategoryType.AirConditioner
				ptr = HMAccessoryCategoryTypeAirConditioner;
				break;
			case 21: // HMAccessoryCategoryType.AirHumidifier
				ptr = HMAccessoryCategoryTypeAirHumidifier;
				break;
			case 22: // HMAccessoryCategoryType.AirDehumidifier
				ptr = HMAccessoryCategoryTypeAirDehumidifier;
				break;
			case 23: // HMAccessoryCategoryType.Sprinkler
				ptr = HMAccessoryCategoryTypeSprinkler;
				break;
			case 24: // HMAccessoryCategoryType.Faucet
				ptr = HMAccessoryCategoryTypeFaucet;
				break;
			case 25: // HMAccessoryCategoryType.ShowerHead
				ptr = HMAccessoryCategoryTypeShowerHead;
				break;
			case 26: // HMAccessoryCategoryType.Television
				ptr = HMAccessoryCategoryTypeTelevision;
				break;
			case 27: // HMAccessoryCategoryType.TelevisionSetTopBox
				ptr = HMAccessoryCategoryTypeTelevisionSetTopBox;
				break;
			case 28: // HMAccessoryCategoryType.TelevisionStreamingStick
				ptr = HMAccessoryCategoryTypeTelevisionStreamingStick;
				break;
			case 29: // HMAccessoryCategoryType.WiFiRouter
				ptr = HMAccessoryCategoryTypeWiFiRouter;
				break;
			case 30: // HMAccessoryCategoryType.Speaker
				ptr = HMAccessoryCategoryTypeSpeaker;
				break;
			case 31: // HMAccessoryCategoryType.AudioReceiver
				ptr = HMAccessoryCategoryTypeAudioReceiver;
				break;
			case 32: // HMAccessoryCategoryType.AirPort
				ptr = HMAccessoryCategoryTypeAirPort;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMAccessoryCategoryType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HMAccessoryCategoryType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HMAccessoryCategoryTypeOther))
				return HMAccessoryCategoryType.Other;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeSecuritySystem))
				return HMAccessoryCategoryType.SecuritySystem;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeBridge))
				return HMAccessoryCategoryType.Bridge;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeDoor))
				return HMAccessoryCategoryType.Door;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeDoorLock))
				return HMAccessoryCategoryType.DoorLock;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeFan))
				return HMAccessoryCategoryType.Fan;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeGarageDoorOpener))
				return HMAccessoryCategoryType.GarageDoorOpener;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeLightbulb))
				return HMAccessoryCategoryType.Lightbulb;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeOutlet))
				return HMAccessoryCategoryType.Outlet;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeProgrammableSwitch))
				return HMAccessoryCategoryType.ProgrammableSwitch;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeSensor))
				return HMAccessoryCategoryType.Sensor;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeSwitch))
				return HMAccessoryCategoryType.Switch;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeThermostat))
				return HMAccessoryCategoryType.Thermostat;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeWindow))
				return HMAccessoryCategoryType.Window;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeWindowCovering))
				return HMAccessoryCategoryType.WindowCovering;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeRangeExtender))
				return HMAccessoryCategoryType.RangeExtender;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeIPCamera))
				return HMAccessoryCategoryType.IPCamera;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeVideoDoorbell))
				return HMAccessoryCategoryType.VideoDoorbell;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirPurifier))
				return HMAccessoryCategoryType.AirPurifier;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirHeater))
				return HMAccessoryCategoryType.AirHeater;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirConditioner))
				return HMAccessoryCategoryType.AirConditioner;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirHumidifier))
				return HMAccessoryCategoryType.AirHumidifier;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirDehumidifier))
				return HMAccessoryCategoryType.AirDehumidifier;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeSprinkler))
				return HMAccessoryCategoryType.Sprinkler;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeFaucet))
				return HMAccessoryCategoryType.Faucet;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeShowerHead))
				return HMAccessoryCategoryType.ShowerHead;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeTelevision))
				return HMAccessoryCategoryType.Television;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeTelevisionSetTopBox))
				return HMAccessoryCategoryType.TelevisionSetTopBox;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeTelevisionStreamingStick))
				return HMAccessoryCategoryType.TelevisionStreamingStick;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeWiFiRouter))
				return HMAccessoryCategoryType.WiFiRouter;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeSpeaker))
				return HMAccessoryCategoryType.Speaker;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAudioReceiver))
				return HMAccessoryCategoryType.AudioReceiver;
			if (constant.IsEqualTo (HMAccessoryCategoryTypeAirPort))
				return HMAccessoryCategoryType.AirPort;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMAccessoryCategoryType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMAccessoryCategoryType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMAccessoryCategoryType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMAccessoryCategoryType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HomeKit.HMAccessoryCategoryType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HMAccessoryCategoryType[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static HMAccessoryCategoryType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HMAccessoryCategoryType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
