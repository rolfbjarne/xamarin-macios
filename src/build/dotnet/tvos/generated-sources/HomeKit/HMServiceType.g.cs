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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HomeKit {
	/// <summary>Enumerates known types of <see cref="T:HomeKit.HMService" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	public enum HMServiceType : int {
		/// <summary>Indicates the absence of a service.</summary>
		None = 0,
		/// <summary>The service represents a light bulb.</summary>
		LightBulb = 1,
		/// <summary>The service represents a switch.</summary>
		Switch = 2,
		/// <summary>The service represents a thermostat.</summary>
		Thermostat = 3,
		/// <summary>The service represents a garage door opener.</summary>
		GarageDoorOpener = 4,
		/// <summary>Indicates accessory information.</summary>
		AccessoryInformation = 5,
		/// <summary>The service represents a fan.</summary>
		Fan = 6,
		/// <summary>The service represents an outlet.</summary>
		Outlet = 7,
		/// <summary>The service represents a lock mechanism.</summary>
		LockMechanism = 8,
		/// <summary>The service manages locks.</summary>
		LockManagement = 9,
		/// <summary>A sensor that monitors air quality.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirQualitySensor = 10,
		/// <summary>An energy storage device.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Battery = 11,
		/// <summary>A sensor that detects CO2.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonDioxideSensor = 12,
		/// <summary>A sensor that detects CO.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonMonoxideSensor = 13,
		/// <summary>A sensor that detects physical contact.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ContactSensor = 14,
		/// <summary>A door.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Door = 15,
		/// <summary>A sensor that monitors the water content of the air.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HumiditySensor = 16,
		/// <summary>A sensor for detecting seepage.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LeakSensor = 17,
		/// <summary>A sensor that monitors luminance.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LightSensor = 18,
		/// <summary>A device that senses movement.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		MotionSensor = 19,
		/// <summary>A device that detects occupancy using an unspecified technology.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		OccupancySensor = 20,
		/// <summary>A system that can be armed and will trigger alerts.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SecuritySystem = 21,
		/// <summary>A switch that maintains internal state and rules.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatefulProgrammableSwitch = 22,
		/// <summary>A switch that does not maintain internal state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatelessProgrammableSwitch = 23,
		/// <summary>A detector used to monitor smoke or fire.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SmokeSensor = 24,
		/// <summary>A thermometer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TemperatureSensor = 25,
		/// <summary>A pane of glass.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Window = 26,
		/// <summary>Drapes or shades.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		WindowCovering = 27,
		/// <summary>A camera management interface.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CameraRtpStreamManagement = 28,
		/// <summary>A video camera.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CameraControl = 29,
		/// <summary>An audio sensor.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Microphone = 30,
		/// <summary>A speaker.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Speaker = 31,
		/// <summary>A doorbell.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Doorbell = 32,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirPurifier = 33,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VentilationFan = 34,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FilterMaintenance = 35,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HeaterCooler = 36,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HumidifierDehumidifier = 37,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Slats = 38,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Label = 39,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		IrrigationSystem = 40,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Valve = 41,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Faucet = 42,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Television = 43,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		InputSource = 44,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WiFiRouter = 45,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WiFiSatellite = 46,
	}
	/// <summary>Extension methods for the <see cref="global::HomeKit.HMServiceType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HMServiceTypeExtensions {
		static IntPtr[] values = new IntPtr [46];
		[Field ("HMServiceTypeLightbulb", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLightbulb {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLightbulb", storage);
			}
		}
		[Field ("HMServiceTypeSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSwitch {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSwitch", storage);
			}
		}
		[Field ("HMServiceTypeThermostat", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeThermostat {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeThermostat", storage);
			}
		}
		[Field ("HMServiceTypeGarageDoorOpener", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeGarageDoorOpener {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeGarageDoorOpener", storage);
			}
		}
		[Field ("HMServiceTypeAccessoryInformation", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAccessoryInformation {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAccessoryInformation", storage);
			}
		}
		[Field ("HMServiceTypeFan", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeFan {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeFan", storage);
			}
		}
		[Field ("HMServiceTypeOutlet", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeOutlet {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeOutlet", storage);
			}
		}
		[Field ("HMServiceTypeLockMechanism", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLockMechanism {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLockMechanism", storage);
			}
		}
		[Field ("HMServiceTypeLockManagement", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLockManagement {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLockManagement", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeAirQualitySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAirQualitySensor {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAirQualitySensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeBattery", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeBattery {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeBattery", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeCarbonDioxideSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCarbonDioxideSensor {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCarbonDioxideSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeCarbonMonoxideSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCarbonMonoxideSensor {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCarbonMonoxideSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeContactSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeContactSensor {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeContactSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeDoor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeDoor {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeDoor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeHumiditySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHumiditySensor {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHumiditySensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeLeakSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLeakSensor {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLeakSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeLightSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLightSensor {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLightSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeMotionSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeMotionSensor {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeMotionSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeOccupancySensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeOccupancySensor {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeOccupancySensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeSecuritySystem", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSecuritySystem {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSecuritySystem", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeStatefulProgrammableSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeStatefulProgrammableSwitch {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeStatefulProgrammableSwitch", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeStatelessProgrammableSwitch", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeStatelessProgrammableSwitch {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeStatelessProgrammableSwitch", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeSmokeSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSmokeSensor {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSmokeSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeTemperatureSensor", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeTemperatureSensor {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeTemperatureSensor", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeWindow", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWindow {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWindow", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeWindowCovering", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWindowCovering {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWindowCovering", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeCameraRTPStreamManagement", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCameraRTPStreamManagement {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCameraRTPStreamManagement", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeCameraControl", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeCameraControl {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeCameraControl", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeMicrophone", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeMicrophone {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeMicrophone", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeSpeaker", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSpeaker {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSpeaker", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeDoorbell", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeDoorbell {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeDoorbell", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeAirPurifier", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeAirPurifier {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeAirPurifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeVentilationFan", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeVentilationFan {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeVentilationFan", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeFilterMaintenance", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeFilterMaintenance {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeFilterMaintenance", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeHeaterCooler", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHeaterCooler {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHeaterCooler", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeHumidifierDehumidifier", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeHumidifierDehumidifier {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeHumidifierDehumidifier", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeSlats", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeSlats {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeSlats", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeLabel", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeLabel {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeLabel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeIrrigationSystem", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeIrrigationSystem {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeIrrigationSystem", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeValve", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeValve {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeValve", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMServiceTypeFaucet", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeFaucet {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeFaucet", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMServiceTypeTelevision", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeTelevision {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeTelevision", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMServiceTypeInputSource", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeInputSource {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeInputSource", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMServiceTypeWiFiRouter", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWiFiRouter {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWiFiRouter", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMServiceTypeWiFiSatellite", "HomeKit")]
		internal unsafe static IntPtr HMServiceTypeWiFiSatellite {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMServiceTypeWiFiSatellite", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HMServiceType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // HMServiceType.LightBulb
				ptr = HMServiceTypeLightbulb;
				break;
			case 2: // HMServiceType.Switch
				ptr = HMServiceTypeSwitch;
				break;
			case 3: // HMServiceType.Thermostat
				ptr = HMServiceTypeThermostat;
				break;
			case 4: // HMServiceType.GarageDoorOpener
				ptr = HMServiceTypeGarageDoorOpener;
				break;
			case 5: // HMServiceType.AccessoryInformation
				ptr = HMServiceTypeAccessoryInformation;
				break;
			case 6: // HMServiceType.Fan
				ptr = HMServiceTypeFan;
				break;
			case 7: // HMServiceType.Outlet
				ptr = HMServiceTypeOutlet;
				break;
			case 8: // HMServiceType.LockMechanism
				ptr = HMServiceTypeLockMechanism;
				break;
			case 9: // HMServiceType.LockManagement
				ptr = HMServiceTypeLockManagement;
				break;
			case 10: // HMServiceType.AirQualitySensor
				ptr = HMServiceTypeAirQualitySensor;
				break;
			case 11: // HMServiceType.Battery
				ptr = HMServiceTypeBattery;
				break;
			case 12: // HMServiceType.CarbonDioxideSensor
				ptr = HMServiceTypeCarbonDioxideSensor;
				break;
			case 13: // HMServiceType.CarbonMonoxideSensor
				ptr = HMServiceTypeCarbonMonoxideSensor;
				break;
			case 14: // HMServiceType.ContactSensor
				ptr = HMServiceTypeContactSensor;
				break;
			case 15: // HMServiceType.Door
				ptr = HMServiceTypeDoor;
				break;
			case 16: // HMServiceType.HumiditySensor
				ptr = HMServiceTypeHumiditySensor;
				break;
			case 17: // HMServiceType.LeakSensor
				ptr = HMServiceTypeLeakSensor;
				break;
			case 18: // HMServiceType.LightSensor
				ptr = HMServiceTypeLightSensor;
				break;
			case 19: // HMServiceType.MotionSensor
				ptr = HMServiceTypeMotionSensor;
				break;
			case 20: // HMServiceType.OccupancySensor
				ptr = HMServiceTypeOccupancySensor;
				break;
			case 21: // HMServiceType.SecuritySystem
				ptr = HMServiceTypeSecuritySystem;
				break;
			case 22: // HMServiceType.StatefulProgrammableSwitch
				ptr = HMServiceTypeStatefulProgrammableSwitch;
				break;
			case 23: // HMServiceType.StatelessProgrammableSwitch
				ptr = HMServiceTypeStatelessProgrammableSwitch;
				break;
			case 24: // HMServiceType.SmokeSensor
				ptr = HMServiceTypeSmokeSensor;
				break;
			case 25: // HMServiceType.TemperatureSensor
				ptr = HMServiceTypeTemperatureSensor;
				break;
			case 26: // HMServiceType.Window
				ptr = HMServiceTypeWindow;
				break;
			case 27: // HMServiceType.WindowCovering
				ptr = HMServiceTypeWindowCovering;
				break;
			case 28: // HMServiceType.CameraRtpStreamManagement
				ptr = HMServiceTypeCameraRTPStreamManagement;
				break;
			case 29: // HMServiceType.CameraControl
				ptr = HMServiceTypeCameraControl;
				break;
			case 30: // HMServiceType.Microphone
				ptr = HMServiceTypeMicrophone;
				break;
			case 31: // HMServiceType.Speaker
				ptr = HMServiceTypeSpeaker;
				break;
			case 32: // HMServiceType.Doorbell
				ptr = HMServiceTypeDoorbell;
				break;
			case 33: // HMServiceType.AirPurifier
				ptr = HMServiceTypeAirPurifier;
				break;
			case 34: // HMServiceType.VentilationFan
				ptr = HMServiceTypeVentilationFan;
				break;
			case 35: // HMServiceType.FilterMaintenance
				ptr = HMServiceTypeFilterMaintenance;
				break;
			case 36: // HMServiceType.HeaterCooler
				ptr = HMServiceTypeHeaterCooler;
				break;
			case 37: // HMServiceType.HumidifierDehumidifier
				ptr = HMServiceTypeHumidifierDehumidifier;
				break;
			case 38: // HMServiceType.Slats
				ptr = HMServiceTypeSlats;
				break;
			case 39: // HMServiceType.Label
				ptr = HMServiceTypeLabel;
				break;
			case 40: // HMServiceType.IrrigationSystem
				ptr = HMServiceTypeIrrigationSystem;
				break;
			case 41: // HMServiceType.Valve
				ptr = HMServiceTypeValve;
				break;
			case 42: // HMServiceType.Faucet
				ptr = HMServiceTypeFaucet;
				break;
			case 43: // HMServiceType.Television
				ptr = HMServiceTypeTelevision;
				break;
			case 44: // HMServiceType.InputSource
				ptr = HMServiceTypeInputSource;
				break;
			case 45: // HMServiceType.WiFiRouter
				ptr = HMServiceTypeWiFiRouter;
				break;
			case 46: // HMServiceType.WiFiSatellite
				ptr = HMServiceTypeWiFiSatellite;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMServiceType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HMServiceType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HMServiceTypeLightbulb))
				return HMServiceType.LightBulb;
			if (constant.IsEqualTo (HMServiceTypeSwitch))
				return HMServiceType.Switch;
			if (constant.IsEqualTo (HMServiceTypeThermostat))
				return HMServiceType.Thermostat;
			if (constant.IsEqualTo (HMServiceTypeGarageDoorOpener))
				return HMServiceType.GarageDoorOpener;
			if (constant.IsEqualTo (HMServiceTypeAccessoryInformation))
				return HMServiceType.AccessoryInformation;
			if (constant.IsEqualTo (HMServiceTypeFan))
				return HMServiceType.Fan;
			if (constant.IsEqualTo (HMServiceTypeOutlet))
				return HMServiceType.Outlet;
			if (constant.IsEqualTo (HMServiceTypeLockMechanism))
				return HMServiceType.LockMechanism;
			if (constant.IsEqualTo (HMServiceTypeLockManagement))
				return HMServiceType.LockManagement;
			if (constant.IsEqualTo (HMServiceTypeAirQualitySensor))
				return HMServiceType.AirQualitySensor;
			if (constant.IsEqualTo (HMServiceTypeBattery))
				return HMServiceType.Battery;
			if (constant.IsEqualTo (HMServiceTypeCarbonDioxideSensor))
				return HMServiceType.CarbonDioxideSensor;
			if (constant.IsEqualTo (HMServiceTypeCarbonMonoxideSensor))
				return HMServiceType.CarbonMonoxideSensor;
			if (constant.IsEqualTo (HMServiceTypeContactSensor))
				return HMServiceType.ContactSensor;
			if (constant.IsEqualTo (HMServiceTypeDoor))
				return HMServiceType.Door;
			if (constant.IsEqualTo (HMServiceTypeHumiditySensor))
				return HMServiceType.HumiditySensor;
			if (constant.IsEqualTo (HMServiceTypeLeakSensor))
				return HMServiceType.LeakSensor;
			if (constant.IsEqualTo (HMServiceTypeLightSensor))
				return HMServiceType.LightSensor;
			if (constant.IsEqualTo (HMServiceTypeMotionSensor))
				return HMServiceType.MotionSensor;
			if (constant.IsEqualTo (HMServiceTypeOccupancySensor))
				return HMServiceType.OccupancySensor;
			if (constant.IsEqualTo (HMServiceTypeSecuritySystem))
				return HMServiceType.SecuritySystem;
			if (constant.IsEqualTo (HMServiceTypeStatefulProgrammableSwitch))
				return HMServiceType.StatefulProgrammableSwitch;
			if (constant.IsEqualTo (HMServiceTypeStatelessProgrammableSwitch))
				return HMServiceType.StatelessProgrammableSwitch;
			if (constant.IsEqualTo (HMServiceTypeSmokeSensor))
				return HMServiceType.SmokeSensor;
			if (constant.IsEqualTo (HMServiceTypeTemperatureSensor))
				return HMServiceType.TemperatureSensor;
			if (constant.IsEqualTo (HMServiceTypeWindow))
				return HMServiceType.Window;
			if (constant.IsEqualTo (HMServiceTypeWindowCovering))
				return HMServiceType.WindowCovering;
			if (constant.IsEqualTo (HMServiceTypeCameraRTPStreamManagement))
				return HMServiceType.CameraRtpStreamManagement;
			if (constant.IsEqualTo (HMServiceTypeCameraControl))
				return HMServiceType.CameraControl;
			if (constant.IsEqualTo (HMServiceTypeMicrophone))
				return HMServiceType.Microphone;
			if (constant.IsEqualTo (HMServiceTypeSpeaker))
				return HMServiceType.Speaker;
			if (constant.IsEqualTo (HMServiceTypeDoorbell))
				return HMServiceType.Doorbell;
			if (constant.IsEqualTo (HMServiceTypeAirPurifier))
				return HMServiceType.AirPurifier;
			if (constant.IsEqualTo (HMServiceTypeVentilationFan))
				return HMServiceType.VentilationFan;
			if (constant.IsEqualTo (HMServiceTypeFilterMaintenance))
				return HMServiceType.FilterMaintenance;
			if (constant.IsEqualTo (HMServiceTypeHeaterCooler))
				return HMServiceType.HeaterCooler;
			if (constant.IsEqualTo (HMServiceTypeHumidifierDehumidifier))
				return HMServiceType.HumidifierDehumidifier;
			if (constant.IsEqualTo (HMServiceTypeSlats))
				return HMServiceType.Slats;
			if (constant.IsEqualTo (HMServiceTypeLabel))
				return HMServiceType.Label;
			if (constant.IsEqualTo (HMServiceTypeIrrigationSystem))
				return HMServiceType.IrrigationSystem;
			if (constant.IsEqualTo (HMServiceTypeValve))
				return HMServiceType.Valve;
			if (constant.IsEqualTo (HMServiceTypeFaucet))
				return HMServiceType.Faucet;
			if (constant.IsEqualTo (HMServiceTypeTelevision))
				return HMServiceType.Television;
			if (constant.IsEqualTo (HMServiceTypeInputSource))
				return HMServiceType.InputSource;
			if (constant.IsEqualTo (HMServiceTypeWiFiRouter))
				return HMServiceType.WiFiRouter;
			if (constant.IsEqualTo (HMServiceTypeWiFiSatellite))
				return HMServiceType.WiFiSatellite;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMServiceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMServiceType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMServiceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMServiceType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HomeKit.HMServiceType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HMServiceType[]? values)
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
		internal static HMServiceType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HMServiceType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::HomeKit.HMServiceType" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this HMServiceType value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (HMServiceType.LightBulb) && HMServiceTypeLightbulb != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLightbulb)!);
			if (value.HasFlag (HMServiceType.Switch) && HMServiceTypeSwitch != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeSwitch)!);
			if (value.HasFlag (HMServiceType.Thermostat) && HMServiceTypeThermostat != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeThermostat)!);
			if (value.HasFlag (HMServiceType.GarageDoorOpener) && HMServiceTypeGarageDoorOpener != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeGarageDoorOpener)!);
			if (value.HasFlag (HMServiceType.AccessoryInformation) && HMServiceTypeAccessoryInformation != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeAccessoryInformation)!);
			if (value.HasFlag (HMServiceType.Fan) && HMServiceTypeFan != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeFan)!);
			if (value.HasFlag (HMServiceType.Outlet) && HMServiceTypeOutlet != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeOutlet)!);
			if (value.HasFlag (HMServiceType.LockMechanism) && HMServiceTypeLockMechanism != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLockMechanism)!);
			if (value.HasFlag (HMServiceType.LockManagement) && HMServiceTypeLockManagement != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLockManagement)!);
			if (value.HasFlag (HMServiceType.AirQualitySensor) && HMServiceTypeAirQualitySensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeAirQualitySensor)!);
			if (value.HasFlag (HMServiceType.Battery) && HMServiceTypeBattery != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeBattery)!);
			if (value.HasFlag (HMServiceType.CarbonDioxideSensor) && HMServiceTypeCarbonDioxideSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeCarbonDioxideSensor)!);
			if (value.HasFlag (HMServiceType.CarbonMonoxideSensor) && HMServiceTypeCarbonMonoxideSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeCarbonMonoxideSensor)!);
			if (value.HasFlag (HMServiceType.ContactSensor) && HMServiceTypeContactSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeContactSensor)!);
			if (value.HasFlag (HMServiceType.Door) && HMServiceTypeDoor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeDoor)!);
			if (value.HasFlag (HMServiceType.HumiditySensor) && HMServiceTypeHumiditySensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeHumiditySensor)!);
			if (value.HasFlag (HMServiceType.LeakSensor) && HMServiceTypeLeakSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLeakSensor)!);
			if (value.HasFlag (HMServiceType.LightSensor) && HMServiceTypeLightSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLightSensor)!);
			if (value.HasFlag (HMServiceType.MotionSensor) && HMServiceTypeMotionSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeMotionSensor)!);
			if (value.HasFlag (HMServiceType.OccupancySensor) && HMServiceTypeOccupancySensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeOccupancySensor)!);
			if (value.HasFlag (HMServiceType.SecuritySystem) && HMServiceTypeSecuritySystem != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeSecuritySystem)!);
			if (value.HasFlag (HMServiceType.StatefulProgrammableSwitch) && HMServiceTypeStatefulProgrammableSwitch != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeStatefulProgrammableSwitch)!);
			if (value.HasFlag (HMServiceType.StatelessProgrammableSwitch) && HMServiceTypeStatelessProgrammableSwitch != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeStatelessProgrammableSwitch)!);
			if (value.HasFlag (HMServiceType.SmokeSensor) && HMServiceTypeSmokeSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeSmokeSensor)!);
			if (value.HasFlag (HMServiceType.TemperatureSensor) && HMServiceTypeTemperatureSensor != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeTemperatureSensor)!);
			if (value.HasFlag (HMServiceType.Window) && HMServiceTypeWindow != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeWindow)!);
			if (value.HasFlag (HMServiceType.WindowCovering) && HMServiceTypeWindowCovering != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeWindowCovering)!);
			if (value.HasFlag (HMServiceType.CameraRtpStreamManagement) && HMServiceTypeCameraRTPStreamManagement != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeCameraRTPStreamManagement)!);
			if (value.HasFlag (HMServiceType.CameraControl) && HMServiceTypeCameraControl != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeCameraControl)!);
			if (value.HasFlag (HMServiceType.Microphone) && HMServiceTypeMicrophone != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeMicrophone)!);
			if (value.HasFlag (HMServiceType.Speaker) && HMServiceTypeSpeaker != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeSpeaker)!);
			if (value.HasFlag (HMServiceType.Doorbell) && HMServiceTypeDoorbell != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeDoorbell)!);
			if (value.HasFlag (HMServiceType.AirPurifier) && HMServiceTypeAirPurifier != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeAirPurifier)!);
			if (value.HasFlag (HMServiceType.VentilationFan) && HMServiceTypeVentilationFan != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeVentilationFan)!);
			if (value.HasFlag (HMServiceType.FilterMaintenance) && HMServiceTypeFilterMaintenance != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeFilterMaintenance)!);
			if (value.HasFlag (HMServiceType.HeaterCooler) && HMServiceTypeHeaterCooler != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeHeaterCooler)!);
			if (value.HasFlag (HMServiceType.HumidifierDehumidifier) && HMServiceTypeHumidifierDehumidifier != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeHumidifierDehumidifier)!);
			if (value.HasFlag (HMServiceType.Slats) && HMServiceTypeSlats != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeSlats)!);
			if (value.HasFlag (HMServiceType.Label) && HMServiceTypeLabel != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeLabel)!);
			if (value.HasFlag (HMServiceType.IrrigationSystem) && HMServiceTypeIrrigationSystem != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeIrrigationSystem)!);
			if (value.HasFlag (HMServiceType.Valve) && HMServiceTypeValve != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeValve)!);
			if (value.HasFlag (HMServiceType.Faucet) && HMServiceTypeFaucet != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeFaucet)!);
			if (value.HasFlag (HMServiceType.Television) && HMServiceTypeTelevision != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeTelevision)!);
			if (value.HasFlag (HMServiceType.InputSource) && HMServiceTypeInputSource != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeInputSource)!);
			if (value.HasFlag (HMServiceType.WiFiRouter) && HMServiceTypeWiFiRouter != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeWiFiRouter)!);
			if (value.HasFlag (HMServiceType.WiFiSatellite) && HMServiceTypeWiFiSatellite != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (HMServiceTypeWiFiSatellite)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static HMServiceType ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (HMServiceType);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (HMServiceTypeLightbulb))
					rv |= HMServiceType.LightBulb;
				else if (constant.IsEqualTo (HMServiceTypeSwitch))
					rv |= HMServiceType.Switch;
				else if (constant.IsEqualTo (HMServiceTypeThermostat))
					rv |= HMServiceType.Thermostat;
				else if (constant.IsEqualTo (HMServiceTypeGarageDoorOpener))
					rv |= HMServiceType.GarageDoorOpener;
				else if (constant.IsEqualTo (HMServiceTypeAccessoryInformation))
					rv |= HMServiceType.AccessoryInformation;
				else if (constant.IsEqualTo (HMServiceTypeFan))
					rv |= HMServiceType.Fan;
				else if (constant.IsEqualTo (HMServiceTypeOutlet))
					rv |= HMServiceType.Outlet;
				else if (constant.IsEqualTo (HMServiceTypeLockMechanism))
					rv |= HMServiceType.LockMechanism;
				else if (constant.IsEqualTo (HMServiceTypeLockManagement))
					rv |= HMServiceType.LockManagement;
				else if (constant.IsEqualTo (HMServiceTypeAirQualitySensor))
					rv |= HMServiceType.AirQualitySensor;
				else if (constant.IsEqualTo (HMServiceTypeBattery))
					rv |= HMServiceType.Battery;
				else if (constant.IsEqualTo (HMServiceTypeCarbonDioxideSensor))
					rv |= HMServiceType.CarbonDioxideSensor;
				else if (constant.IsEqualTo (HMServiceTypeCarbonMonoxideSensor))
					rv |= HMServiceType.CarbonMonoxideSensor;
				else if (constant.IsEqualTo (HMServiceTypeContactSensor))
					rv |= HMServiceType.ContactSensor;
				else if (constant.IsEqualTo (HMServiceTypeDoor))
					rv |= HMServiceType.Door;
				else if (constant.IsEqualTo (HMServiceTypeHumiditySensor))
					rv |= HMServiceType.HumiditySensor;
				else if (constant.IsEqualTo (HMServiceTypeLeakSensor))
					rv |= HMServiceType.LeakSensor;
				else if (constant.IsEqualTo (HMServiceTypeLightSensor))
					rv |= HMServiceType.LightSensor;
				else if (constant.IsEqualTo (HMServiceTypeMotionSensor))
					rv |= HMServiceType.MotionSensor;
				else if (constant.IsEqualTo (HMServiceTypeOccupancySensor))
					rv |= HMServiceType.OccupancySensor;
				else if (constant.IsEqualTo (HMServiceTypeSecuritySystem))
					rv |= HMServiceType.SecuritySystem;
				else if (constant.IsEqualTo (HMServiceTypeStatefulProgrammableSwitch))
					rv |= HMServiceType.StatefulProgrammableSwitch;
				else if (constant.IsEqualTo (HMServiceTypeStatelessProgrammableSwitch))
					rv |= HMServiceType.StatelessProgrammableSwitch;
				else if (constant.IsEqualTo (HMServiceTypeSmokeSensor))
					rv |= HMServiceType.SmokeSensor;
				else if (constant.IsEqualTo (HMServiceTypeTemperatureSensor))
					rv |= HMServiceType.TemperatureSensor;
				else if (constant.IsEqualTo (HMServiceTypeWindow))
					rv |= HMServiceType.Window;
				else if (constant.IsEqualTo (HMServiceTypeWindowCovering))
					rv |= HMServiceType.WindowCovering;
				else if (constant.IsEqualTo (HMServiceTypeCameraRTPStreamManagement))
					rv |= HMServiceType.CameraRtpStreamManagement;
				else if (constant.IsEqualTo (HMServiceTypeCameraControl))
					rv |= HMServiceType.CameraControl;
				else if (constant.IsEqualTo (HMServiceTypeMicrophone))
					rv |= HMServiceType.Microphone;
				else if (constant.IsEqualTo (HMServiceTypeSpeaker))
					rv |= HMServiceType.Speaker;
				else if (constant.IsEqualTo (HMServiceTypeDoorbell))
					rv |= HMServiceType.Doorbell;
				else if (constant.IsEqualTo (HMServiceTypeAirPurifier))
					rv |= HMServiceType.AirPurifier;
				else if (constant.IsEqualTo (HMServiceTypeVentilationFan))
					rv |= HMServiceType.VentilationFan;
				else if (constant.IsEqualTo (HMServiceTypeFilterMaintenance))
					rv |= HMServiceType.FilterMaintenance;
				else if (constant.IsEqualTo (HMServiceTypeHeaterCooler))
					rv |= HMServiceType.HeaterCooler;
				else if (constant.IsEqualTo (HMServiceTypeHumidifierDehumidifier))
					rv |= HMServiceType.HumidifierDehumidifier;
				else if (constant.IsEqualTo (HMServiceTypeSlats))
					rv |= HMServiceType.Slats;
				else if (constant.IsEqualTo (HMServiceTypeLabel))
					rv |= HMServiceType.Label;
				else if (constant.IsEqualTo (HMServiceTypeIrrigationSystem))
					rv |= HMServiceType.IrrigationSystem;
				else if (constant.IsEqualTo (HMServiceTypeValve))
					rv |= HMServiceType.Valve;
				else if (constant.IsEqualTo (HMServiceTypeFaucet))
					rv |= HMServiceType.Faucet;
				else if (constant.IsEqualTo (HMServiceTypeTelevision))
					rv |= HMServiceType.Television;
				else if (constant.IsEqualTo (HMServiceTypeInputSource))
					rv |= HMServiceType.InputSource;
				else if (constant.IsEqualTo (HMServiceTypeWiFiRouter))
					rv |= HMServiceType.WiFiRouter;
				else if (constant.IsEqualTo (HMServiceTypeWiFiSatellite))
					rv |= HMServiceType.WiFiSatellite;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
