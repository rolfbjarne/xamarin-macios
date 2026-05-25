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
	/// <summary>Enumerates known types of <see cref="T:HomeKit.HMCharacteristic" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum HMCharacteristicType : int {
		/// <summary>No type is specified.</summary>
		None = 0,
		/// <summary>A Boolean value that indicates the accessory's power state.</summary>
		PowerState = 1,
		/// <summary>A float that indicates the hue of a color in degrees.</summary>
		Hue = 2,
		/// <summary>A float that indicates the saturation of a color.</summary>
		Saturation = 3,
		/// <summary>An integer brightness percentage.</summary>
		Brightness = 4,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueTemperatureUnit" /> value that indicates the units in which the accessory reports temperature.</summary>
		TemperatureUnits = 5,
		/// <summary>A float that indicates the current temperature in degrees Celsius.</summary>
		CurrentTemperature = 6,
		/// <summary>A float that indicates the desired temperature in degrees Celsius.</summary>
		TargetTemperature = 7,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueHeatingCooling" /> value that indicates the heating or cooling state.</summary>
		CurrentHeatingCooling = 8,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueHeatingCooling" /> that represents the desired heating or cooling state.</summary>
		TargetHeatingCooling = 9,
		/// <summary>A float that indicates the Celsius temperature above which cooling begins.</summary>
		CoolingThreshold = 10,
		/// <summary>A float that indicates the Celsius temperature below which heating begins.</summary>
		HeatingThreshold = 11,
		/// <summary>A float that indicates the current relative humidity percentage.</summary>
		CurrentRelativeHumidity = 12,
		/// <summary>A float that indicates the desired percentage of relative humidity.</summary>
		TargetRelativeHumidity = 13,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueDoorState" /> value that indicates the door state.</summary>
		CurrentDoorState = 14,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueDoorState" /> that represents the desired door state.</summary>
		TargetDoorState = 15,
		/// <summary>A Boolean that indicates whether the accessory has detected an obstruction.</summary>
		ObstructionDetected = 16,
		/// <summary>A string that contains the name of the accessory.</summary>
		Name = 17,
		/// <summary>A string that specifies the accessory manufacturer.</summary>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.Manufacturer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.Manufacturer' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.Manufacturer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Manufacturer = 18,
		/// <summary>A string that specifies the model of the accessory.</summary>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.Model' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.Model' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.Model' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Model = 19,
		/// <summary>A string that contains a serial number for an accessory.</summary>
		[ObsoletedOSPlatform ("tvos11.0", "No longer supported.")]
		[ObsoletedOSPlatform ("ios11.0", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "No longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		SerialNumber = 20,
		/// <summary>A write-only Boolean that is used to identify the device.</summary>
		Identify = 21,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueRotationDirection" /> value that indicates the accessory's rotatoin.</summary>
		RotationDirection = 22,
		/// <summary>A float that indicates the accessory's rotation speed.</summary>
		RotationSpeed = 23,
		/// <summary>A Boolean value that indicates whether an outlet is in use.</summary>
		OutletInUse = 24,
		/// <summary>A string that contains the version of the accessory.</summary>
		Version = 25,
		/// <summary>TLV8 data, in an NSData object, that contains the log data for the accessory.</summary>
		Logs = 26,
		/// <summary>A Boolean that indicates whether a device provides audio feedback.</summary>
		AudioFeedback = 27,
		/// <summary>A Boolean that indicates whether admin access is required.</summary>
		AdminOnlyAccess = 28,
		/// <summary>A Boolean that indicates whether the accessory has detected movement.</summary>
		MotionDetected = 29,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueLockMechanismState" /> value that indicates the lock mechanism state.</summary>
		CurrentLockMechanismState = 30,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueLockMechanismState" /> that represents the desired lock mechanism state.</summary>
		TargetLockMechanismState = 31,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueLockMechanism" /> value that specifies the last known action taken on the lock.</summary>
		LockMechanismLastKnownAction = 32,
		/// <summary>TLV8 data, in an NSData object, that specifies a control point for lock management.</summary>
		LockManagementControlPoint = 33,
		/// <summary>An unsigned 32-bit integer that describes the time in seconds after which an autolockable device will lock.</summary>
		LockManagementAutoSecureTimeout = 34,
		/// <summary>A measure of air quality. </summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirParticulateDensity = 35,
		/// <summary>The size of the particles measured for air quality purposes. The value is an element in the <see cref="T:HomeKit.HMCharacteristicValueAirParticulate" /> enum.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirParticulateSize = 36,
		/// <summary>Measure of air quality. The value is an element in the <see cref="T:HomeKit.HMCharacteristicValueAirQuality" /> enum.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AirQuality = 37,
		/// <summary>A power level. The result is a <see langword="byte" /> representing the percentage of charge in the range [0..100]</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		BatteryLevel = 38,
		/// <summary>Indicates the presence of CO2. The result is a <see langword="byte" /> where 0 indicates normal CO2 levels.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonDioxideDetected = 39,
		/// <summary>The measured level of CO2. The result is a <see langword="float" /> indicating CO2 parts-per-million.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonDioxideLevel = 40,
		/// <summary>The highest recorded CO2 level. The resultis a <see langword="float" /> indicating CO2 parts-per-million.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonDioxidePeakLevel = 41,
		/// <summary>Indicates the presence of CO. The result is a <see langword="byte" /> where 0 indicates normal CO levels.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonMonoxideDetected = 42,
		/// <summary>The measured level of CO. The result is a <see langword="float" /> indicating CO parts-per-million.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonMonoxideLevel = 43,
		/// <summary>The highest measured level of CO. The result is a <see langword="float" /> indicating CO parts-per-million.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CarbonMonoxidePeakLevel = 44,
		/// <summary>A value in <see cref="T:HomeKit.HMCharacteristicValueChargingState" />.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ChargingState = 45,
		/// <summary>A value in <see cref="T:HomeKit.HMCharacteristicValueContactState" />.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ContactState = 46,
		/// <summary>The security system state. Will be a value in <see cref="T:HomeKit.HMCharacteristicValueCurrentSecuritySystemState" />.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentSecuritySystemState = 47,
		/// <summary>A float measuring the tilt from horizontal in degrees.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentHorizontalTilt = 48,
		/// <summary>The luminance, in lux.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentLightLevel = 49,
		/// <summary>A <see langword="byte" /> between 0 and 100, representing the percent a door or window is open.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentPosition = 50,
		/// <summary>The current tilt, in degrees.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentVerticalTilt = 51,
		/// <summary>Developers should not use this deprecated field. Developers should use 'HMAccessory.FirmwareVersion' instead.</summary>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FirmwareVersion = 52,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HardwareVersion = 53,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HoldPosition = 54,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		InputEvent = 55,
		/// <summary>A <see langword="byte" /> whose value will be either 0 (no leak detected) or 1 (leak detected).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LeakDetected = 56,
		/// <summary>A <see langword="byte" /> whose value will either be 0 (no occupancy detected) or 1 (occupancy detected).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		OccupancyDetected = 57,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		OutputState = 58,
		/// <summary>The result will be an element in the <see cref="T:HomeKit.HMCharacteristicValuePositionState" /> enum.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PositionState = 59,
		/// <summary>A <see langword="byte" /> that will either be 0 (no smoke detected) or 1 (smoke detected).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SmokeDetected = 60,
		/// <summary>Returns the accessory's software version in a <see langword="string" />.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SoftwareVersion = 61,
		/// <summary>A Boolean indicating whether a service is active.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatusActive = 62,
		/// <summary>A <see langword="byte" /> whose value will either be 0 (no fault) or 1 (the system is in a fault state).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatusFault = 63,
		/// <summary>A <see langword="byte" /> whose value will either be 0 (not jammed) or 1 (jammed).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatusJammed = 64,
		/// <summary>A <see langword="byte" /> whose value will either be 0 (battery level is not low) or 1 (battery is low).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatusLowBattery = 65,
		/// <summary>A <see langword="byte" /> whose value will either be 0 (no tampering detected) or 1 (tampering detected).</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StatusTampered = 66,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetSecuritySystemState = 67,
		/// <summary>The desired horizontal tilt, in arc degrees.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetHorizontalTilt = 68,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetPosition = 69,
		/// <summary>The desired vertical tilt, in arc degrees.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetVerticalTilt = 70,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		StreamingStatus = 71,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SetupStreamEndpoint = 72,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SupportedVideoStreamConfiguration = 73,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SupportedAudioStreamConfiguration = 74,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SupportedRtpConfiguration = 75,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SelectedStreamConfiguration = 76,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Volume = 77,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Mute = 78,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		NightVision = 79,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		OpticalZoom = 80,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		DigitalZoom = 81,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ImageRotation = 82,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ImageMirroring = 83,
		/// <summary>A Boolean that tells whether a service is active.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Active = 84,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueCurrentAirPurifierState" /> value that indicates the fan state state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentAirPurifierState = 85,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetAirPurifierState = 86,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueCurrentFanState" /> value that indicates the fan state state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentFanState = 87,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueCurrentHeaterCoolerState" /> value that indicates the fan state state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentHeaterCoolerState = 88,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueCurrentHumidifierDehumidifierState" /> value that indicates the fan state state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentHumidifierDehumidifierState = 89,
		/// <summary>A <see cref="T:HomeKit.HMCharacteristicValueCurrentSlatState" /> value that indicates the lock mechanism state.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentSlatState = 90,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		WaterLevel = 91,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FilterChangeIndication = 92,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FilterLifeLevel = 93,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FilterResetChangeIndication = 94,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LockPhysicalControls = 95,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SwingMode = 96,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetHeaterCoolerState = 97,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetHumidifierDehumidifierState = 98,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetFanState = 99,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SlatType = 100,
		/// <summary>The current tilt, in degrees.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CurrentTilt = 101,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TargetTilt = 102,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		OzoneDensity = 103,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		NitrogenDioxideDensity = 104,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SulphurDioxideDensity = 105,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PM2_5Density = 106,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PM10Density = 107,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VolatileOrganicCompoundDensity = 108,
		/// <summary>The threshold relative humidity at which the dehumidifier starts.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		DehumidifierThreshold = 109,
		/// <summary>The relative humidity threshold when the humidifier starts.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		HumidifierThreshold = 110,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SecuritySystemAlarmType = 111,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LabelNamespace = 112,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LabelIndex = 113,
		/// <summary>The color temperature of a light.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ColorTemperature = 114,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ProgramMode = 115,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		InUse = 116,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SetDuration = 117,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		RemainingDuration = 118,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		ValveType = 119,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		IsConfigured = 120,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		InputSourceType = 121,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		InputDeviceType = 122,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		ClosedCaptions = 123,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		PowerModeSelection = 124,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		CurrentMediaState = 125,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		RemoteKey = 126,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		PictureMode = 127,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		ConfiguredName = 128,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Identifier = 129,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		ActiveIdentifier = 130,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		TargetVisibilityState = 131,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		CurrentVisibilityState = 132,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		RouterStatus = 133,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WanStatusList = 134,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		WiFiSatelliteStatus = 135,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		VolumeControlType = 136,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		VolumeSelector = 137,
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		TargetMediaState = 138,
	}
	/// <summary>Extension methods for the <see cref="global::HomeKit.HMCharacteristicType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HMCharacteristicTypeExtensions {
		static IntPtr[] values = new IntPtr [138];
		[Field ("HMCharacteristicTypePowerState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePowerState {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePowerState", storage);
			}
		}
		[Field ("HMCharacteristicTypeHue", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeHue {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeHue", storage);
			}
		}
		[Field ("HMCharacteristicTypeSaturation", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSaturation {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSaturation", storage);
			}
		}
		[Field ("HMCharacteristicTypeBrightness", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeBrightness {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeBrightness", storage);
			}
		}
		[Field ("HMCharacteristicTypeTemperatureUnits", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTemperatureUnits {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTemperatureUnits", storage);
			}
		}
		[Field ("HMCharacteristicTypeCurrentTemperature", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentTemperature {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentTemperature", storage);
			}
		}
		[Field ("HMCharacteristicTypeTargetTemperature", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetTemperature {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetTemperature", storage);
			}
		}
		[Field ("HMCharacteristicTypeCurrentHeatingCooling", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentHeatingCooling {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentHeatingCooling", storage);
			}
		}
		[Field ("HMCharacteristicTypeTargetHeatingCooling", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetHeatingCooling {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetHeatingCooling", storage);
			}
		}
		[Field ("HMCharacteristicTypeCoolingThreshold", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCoolingThreshold {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCoolingThreshold", storage);
			}
		}
		[Field ("HMCharacteristicTypeHeatingThreshold", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeHeatingThreshold {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeHeatingThreshold", storage);
			}
		}
		[Field ("HMCharacteristicTypeCurrentRelativeHumidity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentRelativeHumidity {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentRelativeHumidity", storage);
			}
		}
		[Field ("HMCharacteristicTypeTargetRelativeHumidity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetRelativeHumidity {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetRelativeHumidity", storage);
			}
		}
		[Field ("HMCharacteristicTypeCurrentDoorState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentDoorState {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentDoorState", storage);
			}
		}
		[Field ("HMCharacteristicTypeTargetDoorState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetDoorState {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetDoorState", storage);
			}
		}
		[Field ("HMCharacteristicTypeObstructionDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeObstructionDetected {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeObstructionDetected", storage);
			}
		}
		[Field ("HMCharacteristicTypeName", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeName {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeName", storage);
			}
		}
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.Manufacturer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.Manufacturer' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.Manufacturer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("HMCharacteristicTypeManufacturer", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeManufacturer {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeManufacturer", storage);
			}
		}
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.Model' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.Model' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.Model' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("HMCharacteristicTypeModel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeModel {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeModel", storage);
			}
		}
		[ObsoletedOSPlatform ("tvos11.0", "No longer supported.")]
		[ObsoletedOSPlatform ("ios11.0", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "No longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("HMCharacteristicTypeSerialNumber", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSerialNumber {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSerialNumber", storage);
			}
		}
		[Field ("HMCharacteristicTypeIdentify", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeIdentify {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeIdentify", storage);
			}
		}
		[Field ("HMCharacteristicTypeRotationDirection", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeRotationDirection {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeRotationDirection", storage);
			}
		}
		[Field ("HMCharacteristicTypeRotationSpeed", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeRotationSpeed {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeRotationSpeed", storage);
			}
		}
		[Field ("HMCharacteristicTypeOutletInUse", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeOutletInUse {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeOutletInUse", storage);
			}
		}
		[Field ("HMCharacteristicTypeVersion", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeVersion {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeVersion", storage);
			}
		}
		[Field ("HMCharacteristicTypeLogs", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLogs {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLogs", storage);
			}
		}
		[Field ("HMCharacteristicTypeAudioFeedback", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeAudioFeedback {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeAudioFeedback", storage);
			}
		}
		[Field ("HMCharacteristicTypeAdminOnlyAccess", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeAdminOnlyAccess {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeAdminOnlyAccess", storage);
			}
		}
		[Field ("HMCharacteristicTypeMotionDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeMotionDetected {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeMotionDetected", storage);
			}
		}
		[Field ("HMCharacteristicTypeCurrentLockMechanismState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentLockMechanismState {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentLockMechanismState", storage);
			}
		}
		[Field ("HMCharacteristicTypeTargetLockMechanismState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetLockMechanismState {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetLockMechanismState", storage);
			}
		}
		[Field ("HMCharacteristicTypeLockMechanismLastKnownAction", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLockMechanismLastKnownAction {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLockMechanismLastKnownAction", storage);
			}
		}
		[Field ("HMCharacteristicTypeLockManagementControlPoint", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLockManagementControlPoint {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLockManagementControlPoint", storage);
			}
		}
		[Field ("HMCharacteristicTypeLockManagementAutoSecureTimeout", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLockManagementAutoSecureTimeout {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLockManagementAutoSecureTimeout", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeAirParticulateDensity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeAirParticulateDensity {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeAirParticulateDensity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeAirParticulateSize", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeAirParticulateSize {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeAirParticulateSize", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeAirQuality", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeAirQuality {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeAirQuality", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeBatteryLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeBatteryLevel {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeBatteryLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonDioxideDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonDioxideDetected {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonDioxideDetected", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonDioxideLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonDioxideLevel {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonDioxideLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonDioxidePeakLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonDioxidePeakLevel {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonDioxidePeakLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonMonoxideDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonMonoxideDetected {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonMonoxideDetected", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonMonoxideLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonMonoxideLevel {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonMonoxideLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCarbonMonoxidePeakLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCarbonMonoxidePeakLevel {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCarbonMonoxidePeakLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeChargingState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeChargingState {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeChargingState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeContactState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeContactState {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeContactState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentSecuritySystemState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentSecuritySystemState {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentSecuritySystemState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentHorizontalTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentHorizontalTilt {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentHorizontalTilt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentLightLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentLightLevel {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentLightLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentPosition", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentPosition {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentPosition", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentVerticalTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentVerticalTilt {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentVerticalTilt", storage);
			}
		}
		[ObsoletedOSPlatform ("tvos11.0", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HMAccessory.FirmwareVersion' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeFirmwareVersion", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeFirmwareVersion {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeFirmwareVersion", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeHardwareVersion", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeHardwareVersion {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeHardwareVersion", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeHoldPosition", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeHoldPosition {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeHoldPosition", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeInputEvent", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeInputEvent {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeInputEvent", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeLeakDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLeakDetected {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLeakDetected", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeOccupancyDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeOccupancyDetected {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeOccupancyDetected", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeOutputState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeOutputState {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeOutputState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypePositionState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePositionState {
			get {
				fixed (IntPtr *storage = &values [58])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePositionState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSmokeDetected", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSmokeDetected {
			get {
				fixed (IntPtr *storage = &values [59])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSmokeDetected", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSoftwareVersion", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSoftwareVersion {
			get {
				fixed (IntPtr *storage = &values [60])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSoftwareVersion", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStatusActive", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStatusActive {
			get {
				fixed (IntPtr *storage = &values [61])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStatusActive", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStatusFault", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStatusFault {
			get {
				fixed (IntPtr *storage = &values [62])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStatusFault", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStatusJammed", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStatusJammed {
			get {
				fixed (IntPtr *storage = &values [63])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStatusJammed", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStatusLowBattery", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStatusLowBattery {
			get {
				fixed (IntPtr *storage = &values [64])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStatusLowBattery", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStatusTampered", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStatusTampered {
			get {
				fixed (IntPtr *storage = &values [65])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStatusTampered", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetSecuritySystemState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetSecuritySystemState {
			get {
				fixed (IntPtr *storage = &values [66])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetSecuritySystemState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetHorizontalTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetHorizontalTilt {
			get {
				fixed (IntPtr *storage = &values [67])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetHorizontalTilt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetPosition", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetPosition {
			get {
				fixed (IntPtr *storage = &values [68])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetPosition", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetVerticalTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetVerticalTilt {
			get {
				fixed (IntPtr *storage = &values [69])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetVerticalTilt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeStreamingStatus", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeStreamingStatus {
			get {
				fixed (IntPtr *storage = &values [70])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeStreamingStatus", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSetupStreamEndpoint", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSetupStreamEndpoint {
			get {
				fixed (IntPtr *storage = &values [71])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSetupStreamEndpoint", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSupportedVideoStreamConfiguration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSupportedVideoStreamConfiguration {
			get {
				fixed (IntPtr *storage = &values [72])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSupportedVideoStreamConfiguration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSupportedAudioStreamConfiguration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSupportedAudioStreamConfiguration {
			get {
				fixed (IntPtr *storage = &values [73])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSupportedAudioStreamConfiguration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSupportedRTPConfiguration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSupportedRTPConfiguration {
			get {
				fixed (IntPtr *storage = &values [74])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSupportedRTPConfiguration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSelectedStreamConfiguration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSelectedStreamConfiguration {
			get {
				fixed (IntPtr *storage = &values [75])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSelectedStreamConfiguration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeVolume", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeVolume {
			get {
				fixed (IntPtr *storage = &values [76])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeVolume", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeMute", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeMute {
			get {
				fixed (IntPtr *storage = &values [77])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeMute", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeNightVision", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeNightVision {
			get {
				fixed (IntPtr *storage = &values [78])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeNightVision", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeOpticalZoom", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeOpticalZoom {
			get {
				fixed (IntPtr *storage = &values [79])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeOpticalZoom", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeDigitalZoom", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeDigitalZoom {
			get {
				fixed (IntPtr *storage = &values [80])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeDigitalZoom", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeImageRotation", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeImageRotation {
			get {
				fixed (IntPtr *storage = &values [81])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeImageRotation", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeImageMirroring", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeImageMirroring {
			get {
				fixed (IntPtr *storage = &values [82])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeImageMirroring", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeActive", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeActive {
			get {
				fixed (IntPtr *storage = &values [83])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeActive", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentAirPurifierState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentAirPurifierState {
			get {
				fixed (IntPtr *storage = &values [84])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentAirPurifierState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetAirPurifierState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetAirPurifierState {
			get {
				fixed (IntPtr *storage = &values [85])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetAirPurifierState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentFanState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentFanState {
			get {
				fixed (IntPtr *storage = &values [86])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentFanState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentHeaterCoolerState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentHeaterCoolerState {
			get {
				fixed (IntPtr *storage = &values [87])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentHeaterCoolerState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentHumidifierDehumidifierState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentHumidifierDehumidifierState {
			get {
				fixed (IntPtr *storage = &values [88])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentHumidifierDehumidifierState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentSlatState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentSlatState {
			get {
				fixed (IntPtr *storage = &values [89])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentSlatState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeWaterLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeWaterLevel {
			get {
				fixed (IntPtr *storage = &values [90])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeWaterLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeFilterChangeIndication", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeFilterChangeIndication {
			get {
				fixed (IntPtr *storage = &values [91])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeFilterChangeIndication", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeFilterLifeLevel", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeFilterLifeLevel {
			get {
				fixed (IntPtr *storage = &values [92])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeFilterLifeLevel", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeFilterResetChangeIndication", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeFilterResetChangeIndication {
			get {
				fixed (IntPtr *storage = &values [93])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeFilterResetChangeIndication", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeLockPhysicalControls", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLockPhysicalControls {
			get {
				fixed (IntPtr *storage = &values [94])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLockPhysicalControls", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSwingMode", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSwingMode {
			get {
				fixed (IntPtr *storage = &values [95])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSwingMode", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetHeaterCoolerState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetHeaterCoolerState {
			get {
				fixed (IntPtr *storage = &values [96])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetHeaterCoolerState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetHumidifierDehumidifierState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetHumidifierDehumidifierState {
			get {
				fixed (IntPtr *storage = &values [97])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetHumidifierDehumidifierState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetFanState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetFanState {
			get {
				fixed (IntPtr *storage = &values [98])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetFanState", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSlatType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSlatType {
			get {
				fixed (IntPtr *storage = &values [99])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSlatType", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeCurrentTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentTilt {
			get {
				fixed (IntPtr *storage = &values [100])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentTilt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeTargetTilt", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetTilt {
			get {
				fixed (IntPtr *storage = &values [101])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetTilt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeOzoneDensity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeOzoneDensity {
			get {
				fixed (IntPtr *storage = &values [102])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeOzoneDensity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeNitrogenDioxideDensity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeNitrogenDioxideDensity {
			get {
				fixed (IntPtr *storage = &values [103])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeNitrogenDioxideDensity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSulphurDioxideDensity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSulphurDioxideDensity {
			get {
				fixed (IntPtr *storage = &values [104])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSulphurDioxideDensity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypePM2_5Density", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePM2_5Density {
			get {
				fixed (IntPtr *storage = &values [105])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePM2_5Density", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypePM10Density", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePM10Density {
			get {
				fixed (IntPtr *storage = &values [106])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePM10Density", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeVolatileOrganicCompoundDensity", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeVolatileOrganicCompoundDensity {
			get {
				fixed (IntPtr *storage = &values [107])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeVolatileOrganicCompoundDensity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeDehumidifierThreshold", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeDehumidifierThreshold {
			get {
				fixed (IntPtr *storage = &values [108])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeDehumidifierThreshold", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeHumidifierThreshold", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeHumidifierThreshold {
			get {
				fixed (IntPtr *storage = &values [109])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeHumidifierThreshold", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSecuritySystemAlarmType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSecuritySystemAlarmType {
			get {
				fixed (IntPtr *storage = &values [110])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSecuritySystemAlarmType", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeLabelNamespace", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLabelNamespace {
			get {
				fixed (IntPtr *storage = &values [111])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLabelNamespace", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeLabelIndex", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeLabelIndex {
			get {
				fixed (IntPtr *storage = &values [112])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeLabelIndex", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeColorTemperature", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeColorTemperature {
			get {
				fixed (IntPtr *storage = &values [113])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeColorTemperature", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeProgramMode", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeProgramMode {
			get {
				fixed (IntPtr *storage = &values [114])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeProgramMode", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeInUse", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeInUse {
			get {
				fixed (IntPtr *storage = &values [115])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeInUse", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeSetDuration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeSetDuration {
			get {
				fixed (IntPtr *storage = &values [116])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeSetDuration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeRemainingDuration", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeRemainingDuration {
			get {
				fixed (IntPtr *storage = &values [117])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeRemainingDuration", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeValveType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeValveType {
			get {
				fixed (IntPtr *storage = &values [118])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeValveType", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("HMCharacteristicTypeIsConfigured", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeIsConfigured {
			get {
				fixed (IntPtr *storage = &values [119])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeIsConfigured", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeInputSourceType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeInputSourceType {
			get {
				fixed (IntPtr *storage = &values [120])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeInputSourceType", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeInputDeviceType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeInputDeviceType {
			get {
				fixed (IntPtr *storage = &values [121])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeInputDeviceType", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeClosedCaptions", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeClosedCaptions {
			get {
				fixed (IntPtr *storage = &values [122])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeClosedCaptions", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypePowerModeSelection", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePowerModeSelection {
			get {
				fixed (IntPtr *storage = &values [123])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePowerModeSelection", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeCurrentMediaState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentMediaState {
			get {
				fixed (IntPtr *storage = &values [124])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentMediaState", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeRemoteKey", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeRemoteKey {
			get {
				fixed (IntPtr *storage = &values [125])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeRemoteKey", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypePictureMode", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypePictureMode {
			get {
				fixed (IntPtr *storage = &values [126])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypePictureMode", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeConfiguredName", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeConfiguredName {
			get {
				fixed (IntPtr *storage = &values [127])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeConfiguredName", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeIdentifier", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeIdentifier {
			get {
				fixed (IntPtr *storage = &values [128])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeIdentifier", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeActiveIdentifier", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeActiveIdentifier {
			get {
				fixed (IntPtr *storage = &values [129])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeActiveIdentifier", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeTargetVisibilityState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetVisibilityState {
			get {
				fixed (IntPtr *storage = &values [130])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetVisibilityState", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeCurrentVisibilityState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeCurrentVisibilityState {
			get {
				fixed (IntPtr *storage = &values [131])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeCurrentVisibilityState", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeRouterStatus", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeRouterStatus {
			get {
				fixed (IntPtr *storage = &values [132])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeRouterStatus", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeWANStatusList", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeWANStatusList {
			get {
				fixed (IntPtr *storage = &values [133])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeWANStatusList", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeWiFiSatelliteStatus", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeWiFiSatelliteStatus {
			get {
				fixed (IntPtr *storage = &values [134])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeWiFiSatelliteStatus", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeVolumeControlType", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeVolumeControlType {
			get {
				fixed (IntPtr *storage = &values [135])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeVolumeControlType", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeVolumeSelector", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeVolumeSelector {
			get {
				fixed (IntPtr *storage = &values [136])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeVolumeSelector", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("HMCharacteristicTypeTargetMediaState", "HomeKit")]
		internal unsafe static IntPtr HMCharacteristicTypeTargetMediaState {
			get {
				fixed (IntPtr *storage = &values [137])
					return Dlfcn.CachePointer (Libraries.HomeKit.Handle, "HMCharacteristicTypeTargetMediaState", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HMCharacteristicType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // HMCharacteristicType.PowerState
				ptr = HMCharacteristicTypePowerState;
				break;
			case 2: // HMCharacteristicType.Hue
				ptr = HMCharacteristicTypeHue;
				break;
			case 3: // HMCharacteristicType.Saturation
				ptr = HMCharacteristicTypeSaturation;
				break;
			case 4: // HMCharacteristicType.Brightness
				ptr = HMCharacteristicTypeBrightness;
				break;
			case 5: // HMCharacteristicType.TemperatureUnits
				ptr = HMCharacteristicTypeTemperatureUnits;
				break;
			case 6: // HMCharacteristicType.CurrentTemperature
				ptr = HMCharacteristicTypeCurrentTemperature;
				break;
			case 7: // HMCharacteristicType.TargetTemperature
				ptr = HMCharacteristicTypeTargetTemperature;
				break;
			case 8: // HMCharacteristicType.CurrentHeatingCooling
				ptr = HMCharacteristicTypeCurrentHeatingCooling;
				break;
			case 9: // HMCharacteristicType.TargetHeatingCooling
				ptr = HMCharacteristicTypeTargetHeatingCooling;
				break;
			case 10: // HMCharacteristicType.CoolingThreshold
				ptr = HMCharacteristicTypeCoolingThreshold;
				break;
			case 11: // HMCharacteristicType.HeatingThreshold
				ptr = HMCharacteristicTypeHeatingThreshold;
				break;
			case 12: // HMCharacteristicType.CurrentRelativeHumidity
				ptr = HMCharacteristicTypeCurrentRelativeHumidity;
				break;
			case 13: // HMCharacteristicType.TargetRelativeHumidity
				ptr = HMCharacteristicTypeTargetRelativeHumidity;
				break;
			case 14: // HMCharacteristicType.CurrentDoorState
				ptr = HMCharacteristicTypeCurrentDoorState;
				break;
			case 15: // HMCharacteristicType.TargetDoorState
				ptr = HMCharacteristicTypeTargetDoorState;
				break;
			case 16: // HMCharacteristicType.ObstructionDetected
				ptr = HMCharacteristicTypeObstructionDetected;
				break;
			case 17: // HMCharacteristicType.Name
				ptr = HMCharacteristicTypeName;
				break;
			case 18: // HMCharacteristicType.Manufacturer
				ptr = HMCharacteristicTypeManufacturer;
				break;
			case 19: // HMCharacteristicType.Model
				ptr = HMCharacteristicTypeModel;
				break;
			case 20: // HMCharacteristicType.SerialNumber
				ptr = HMCharacteristicTypeSerialNumber;
				break;
			case 21: // HMCharacteristicType.Identify
				ptr = HMCharacteristicTypeIdentify;
				break;
			case 22: // HMCharacteristicType.RotationDirection
				ptr = HMCharacteristicTypeRotationDirection;
				break;
			case 23: // HMCharacteristicType.RotationSpeed
				ptr = HMCharacteristicTypeRotationSpeed;
				break;
			case 24: // HMCharacteristicType.OutletInUse
				ptr = HMCharacteristicTypeOutletInUse;
				break;
			case 25: // HMCharacteristicType.Version
				ptr = HMCharacteristicTypeVersion;
				break;
			case 26: // HMCharacteristicType.Logs
				ptr = HMCharacteristicTypeLogs;
				break;
			case 27: // HMCharacteristicType.AudioFeedback
				ptr = HMCharacteristicTypeAudioFeedback;
				break;
			case 28: // HMCharacteristicType.AdminOnlyAccess
				ptr = HMCharacteristicTypeAdminOnlyAccess;
				break;
			case 29: // HMCharacteristicType.MotionDetected
				ptr = HMCharacteristicTypeMotionDetected;
				break;
			case 30: // HMCharacteristicType.CurrentLockMechanismState
				ptr = HMCharacteristicTypeCurrentLockMechanismState;
				break;
			case 31: // HMCharacteristicType.TargetLockMechanismState
				ptr = HMCharacteristicTypeTargetLockMechanismState;
				break;
			case 32: // HMCharacteristicType.LockMechanismLastKnownAction
				ptr = HMCharacteristicTypeLockMechanismLastKnownAction;
				break;
			case 33: // HMCharacteristicType.LockManagementControlPoint
				ptr = HMCharacteristicTypeLockManagementControlPoint;
				break;
			case 34: // HMCharacteristicType.LockManagementAutoSecureTimeout
				ptr = HMCharacteristicTypeLockManagementAutoSecureTimeout;
				break;
			case 35: // HMCharacteristicType.AirParticulateDensity
				ptr = HMCharacteristicTypeAirParticulateDensity;
				break;
			case 36: // HMCharacteristicType.AirParticulateSize
				ptr = HMCharacteristicTypeAirParticulateSize;
				break;
			case 37: // HMCharacteristicType.AirQuality
				ptr = HMCharacteristicTypeAirQuality;
				break;
			case 38: // HMCharacteristicType.BatteryLevel
				ptr = HMCharacteristicTypeBatteryLevel;
				break;
			case 39: // HMCharacteristicType.CarbonDioxideDetected
				ptr = HMCharacteristicTypeCarbonDioxideDetected;
				break;
			case 40: // HMCharacteristicType.CarbonDioxideLevel
				ptr = HMCharacteristicTypeCarbonDioxideLevel;
				break;
			case 41: // HMCharacteristicType.CarbonDioxidePeakLevel
				ptr = HMCharacteristicTypeCarbonDioxidePeakLevel;
				break;
			case 42: // HMCharacteristicType.CarbonMonoxideDetected
				ptr = HMCharacteristicTypeCarbonMonoxideDetected;
				break;
			case 43: // HMCharacteristicType.CarbonMonoxideLevel
				ptr = HMCharacteristicTypeCarbonMonoxideLevel;
				break;
			case 44: // HMCharacteristicType.CarbonMonoxidePeakLevel
				ptr = HMCharacteristicTypeCarbonMonoxidePeakLevel;
				break;
			case 45: // HMCharacteristicType.ChargingState
				ptr = HMCharacteristicTypeChargingState;
				break;
			case 46: // HMCharacteristicType.ContactState
				ptr = HMCharacteristicTypeContactState;
				break;
			case 47: // HMCharacteristicType.CurrentSecuritySystemState
				ptr = HMCharacteristicTypeCurrentSecuritySystemState;
				break;
			case 48: // HMCharacteristicType.CurrentHorizontalTilt
				ptr = HMCharacteristicTypeCurrentHorizontalTilt;
				break;
			case 49: // HMCharacteristicType.CurrentLightLevel
				ptr = HMCharacteristicTypeCurrentLightLevel;
				break;
			case 50: // HMCharacteristicType.CurrentPosition
				ptr = HMCharacteristicTypeCurrentPosition;
				break;
			case 51: // HMCharacteristicType.CurrentVerticalTilt
				ptr = HMCharacteristicTypeCurrentVerticalTilt;
				break;
			case 52: // HMCharacteristicType.FirmwareVersion
				ptr = HMCharacteristicTypeFirmwareVersion;
				break;
			case 53: // HMCharacteristicType.HardwareVersion
				ptr = HMCharacteristicTypeHardwareVersion;
				break;
			case 54: // HMCharacteristicType.HoldPosition
				ptr = HMCharacteristicTypeHoldPosition;
				break;
			case 55: // HMCharacteristicType.InputEvent
				ptr = HMCharacteristicTypeInputEvent;
				break;
			case 56: // HMCharacteristicType.LeakDetected
				ptr = HMCharacteristicTypeLeakDetected;
				break;
			case 57: // HMCharacteristicType.OccupancyDetected
				ptr = HMCharacteristicTypeOccupancyDetected;
				break;
			case 58: // HMCharacteristicType.OutputState
				ptr = HMCharacteristicTypeOutputState;
				break;
			case 59: // HMCharacteristicType.PositionState
				ptr = HMCharacteristicTypePositionState;
				break;
			case 60: // HMCharacteristicType.SmokeDetected
				ptr = HMCharacteristicTypeSmokeDetected;
				break;
			case 61: // HMCharacteristicType.SoftwareVersion
				ptr = HMCharacteristicTypeSoftwareVersion;
				break;
			case 62: // HMCharacteristicType.StatusActive
				ptr = HMCharacteristicTypeStatusActive;
				break;
			case 63: // HMCharacteristicType.StatusFault
				ptr = HMCharacteristicTypeStatusFault;
				break;
			case 64: // HMCharacteristicType.StatusJammed
				ptr = HMCharacteristicTypeStatusJammed;
				break;
			case 65: // HMCharacteristicType.StatusLowBattery
				ptr = HMCharacteristicTypeStatusLowBattery;
				break;
			case 66: // HMCharacteristicType.StatusTampered
				ptr = HMCharacteristicTypeStatusTampered;
				break;
			case 67: // HMCharacteristicType.TargetSecuritySystemState
				ptr = HMCharacteristicTypeTargetSecuritySystemState;
				break;
			case 68: // HMCharacteristicType.TargetHorizontalTilt
				ptr = HMCharacteristicTypeTargetHorizontalTilt;
				break;
			case 69: // HMCharacteristicType.TargetPosition
				ptr = HMCharacteristicTypeTargetPosition;
				break;
			case 70: // HMCharacteristicType.TargetVerticalTilt
				ptr = HMCharacteristicTypeTargetVerticalTilt;
				break;
			case 71: // HMCharacteristicType.StreamingStatus
				ptr = HMCharacteristicTypeStreamingStatus;
				break;
			case 72: // HMCharacteristicType.SetupStreamEndpoint
				ptr = HMCharacteristicTypeSetupStreamEndpoint;
				break;
			case 73: // HMCharacteristicType.SupportedVideoStreamConfiguration
				ptr = HMCharacteristicTypeSupportedVideoStreamConfiguration;
				break;
			case 74: // HMCharacteristicType.SupportedAudioStreamConfiguration
				ptr = HMCharacteristicTypeSupportedAudioStreamConfiguration;
				break;
			case 75: // HMCharacteristicType.SupportedRtpConfiguration
				ptr = HMCharacteristicTypeSupportedRTPConfiguration;
				break;
			case 76: // HMCharacteristicType.SelectedStreamConfiguration
				ptr = HMCharacteristicTypeSelectedStreamConfiguration;
				break;
			case 77: // HMCharacteristicType.Volume
				ptr = HMCharacteristicTypeVolume;
				break;
			case 78: // HMCharacteristicType.Mute
				ptr = HMCharacteristicTypeMute;
				break;
			case 79: // HMCharacteristicType.NightVision
				ptr = HMCharacteristicTypeNightVision;
				break;
			case 80: // HMCharacteristicType.OpticalZoom
				ptr = HMCharacteristicTypeOpticalZoom;
				break;
			case 81: // HMCharacteristicType.DigitalZoom
				ptr = HMCharacteristicTypeDigitalZoom;
				break;
			case 82: // HMCharacteristicType.ImageRotation
				ptr = HMCharacteristicTypeImageRotation;
				break;
			case 83: // HMCharacteristicType.ImageMirroring
				ptr = HMCharacteristicTypeImageMirroring;
				break;
			case 84: // HMCharacteristicType.Active
				ptr = HMCharacteristicTypeActive;
				break;
			case 85: // HMCharacteristicType.CurrentAirPurifierState
				ptr = HMCharacteristicTypeCurrentAirPurifierState;
				break;
			case 86: // HMCharacteristicType.TargetAirPurifierState
				ptr = HMCharacteristicTypeTargetAirPurifierState;
				break;
			case 87: // HMCharacteristicType.CurrentFanState
				ptr = HMCharacteristicTypeCurrentFanState;
				break;
			case 88: // HMCharacteristicType.CurrentHeaterCoolerState
				ptr = HMCharacteristicTypeCurrentHeaterCoolerState;
				break;
			case 89: // HMCharacteristicType.CurrentHumidifierDehumidifierState
				ptr = HMCharacteristicTypeCurrentHumidifierDehumidifierState;
				break;
			case 90: // HMCharacteristicType.CurrentSlatState
				ptr = HMCharacteristicTypeCurrentSlatState;
				break;
			case 91: // HMCharacteristicType.WaterLevel
				ptr = HMCharacteristicTypeWaterLevel;
				break;
			case 92: // HMCharacteristicType.FilterChangeIndication
				ptr = HMCharacteristicTypeFilterChangeIndication;
				break;
			case 93: // HMCharacteristicType.FilterLifeLevel
				ptr = HMCharacteristicTypeFilterLifeLevel;
				break;
			case 94: // HMCharacteristicType.FilterResetChangeIndication
				ptr = HMCharacteristicTypeFilterResetChangeIndication;
				break;
			case 95: // HMCharacteristicType.LockPhysicalControls
				ptr = HMCharacteristicTypeLockPhysicalControls;
				break;
			case 96: // HMCharacteristicType.SwingMode
				ptr = HMCharacteristicTypeSwingMode;
				break;
			case 97: // HMCharacteristicType.TargetHeaterCoolerState
				ptr = HMCharacteristicTypeTargetHeaterCoolerState;
				break;
			case 98: // HMCharacteristicType.TargetHumidifierDehumidifierState
				ptr = HMCharacteristicTypeTargetHumidifierDehumidifierState;
				break;
			case 99: // HMCharacteristicType.TargetFanState
				ptr = HMCharacteristicTypeTargetFanState;
				break;
			case 100: // HMCharacteristicType.SlatType
				ptr = HMCharacteristicTypeSlatType;
				break;
			case 101: // HMCharacteristicType.CurrentTilt
				ptr = HMCharacteristicTypeCurrentTilt;
				break;
			case 102: // HMCharacteristicType.TargetTilt
				ptr = HMCharacteristicTypeTargetTilt;
				break;
			case 103: // HMCharacteristicType.OzoneDensity
				ptr = HMCharacteristicTypeOzoneDensity;
				break;
			case 104: // HMCharacteristicType.NitrogenDioxideDensity
				ptr = HMCharacteristicTypeNitrogenDioxideDensity;
				break;
			case 105: // HMCharacteristicType.SulphurDioxideDensity
				ptr = HMCharacteristicTypeSulphurDioxideDensity;
				break;
			case 106: // HMCharacteristicType.PM2_5Density
				ptr = HMCharacteristicTypePM2_5Density;
				break;
			case 107: // HMCharacteristicType.PM10Density
				ptr = HMCharacteristicTypePM10Density;
				break;
			case 108: // HMCharacteristicType.VolatileOrganicCompoundDensity
				ptr = HMCharacteristicTypeVolatileOrganicCompoundDensity;
				break;
			case 109: // HMCharacteristicType.DehumidifierThreshold
				ptr = HMCharacteristicTypeDehumidifierThreshold;
				break;
			case 110: // HMCharacteristicType.HumidifierThreshold
				ptr = HMCharacteristicTypeHumidifierThreshold;
				break;
			case 111: // HMCharacteristicType.SecuritySystemAlarmType
				ptr = HMCharacteristicTypeSecuritySystemAlarmType;
				break;
			case 112: // HMCharacteristicType.LabelNamespace
				ptr = HMCharacteristicTypeLabelNamespace;
				break;
			case 113: // HMCharacteristicType.LabelIndex
				ptr = HMCharacteristicTypeLabelIndex;
				break;
			case 114: // HMCharacteristicType.ColorTemperature
				ptr = HMCharacteristicTypeColorTemperature;
				break;
			case 115: // HMCharacteristicType.ProgramMode
				ptr = HMCharacteristicTypeProgramMode;
				break;
			case 116: // HMCharacteristicType.InUse
				ptr = HMCharacteristicTypeInUse;
				break;
			case 117: // HMCharacteristicType.SetDuration
				ptr = HMCharacteristicTypeSetDuration;
				break;
			case 118: // HMCharacteristicType.RemainingDuration
				ptr = HMCharacteristicTypeRemainingDuration;
				break;
			case 119: // HMCharacteristicType.ValveType
				ptr = HMCharacteristicTypeValveType;
				break;
			case 120: // HMCharacteristicType.IsConfigured
				ptr = HMCharacteristicTypeIsConfigured;
				break;
			case 121: // HMCharacteristicType.InputSourceType
				ptr = HMCharacteristicTypeInputSourceType;
				break;
			case 122: // HMCharacteristicType.InputDeviceType
				ptr = HMCharacteristicTypeInputDeviceType;
				break;
			case 123: // HMCharacteristicType.ClosedCaptions
				ptr = HMCharacteristicTypeClosedCaptions;
				break;
			case 124: // HMCharacteristicType.PowerModeSelection
				ptr = HMCharacteristicTypePowerModeSelection;
				break;
			case 125: // HMCharacteristicType.CurrentMediaState
				ptr = HMCharacteristicTypeCurrentMediaState;
				break;
			case 126: // HMCharacteristicType.RemoteKey
				ptr = HMCharacteristicTypeRemoteKey;
				break;
			case 127: // HMCharacteristicType.PictureMode
				ptr = HMCharacteristicTypePictureMode;
				break;
			case 128: // HMCharacteristicType.ConfiguredName
				ptr = HMCharacteristicTypeConfiguredName;
				break;
			case 129: // HMCharacteristicType.Identifier
				ptr = HMCharacteristicTypeIdentifier;
				break;
			case 130: // HMCharacteristicType.ActiveIdentifier
				ptr = HMCharacteristicTypeActiveIdentifier;
				break;
			case 131: // HMCharacteristicType.TargetVisibilityState
				ptr = HMCharacteristicTypeTargetVisibilityState;
				break;
			case 132: // HMCharacteristicType.CurrentVisibilityState
				ptr = HMCharacteristicTypeCurrentVisibilityState;
				break;
			case 133: // HMCharacteristicType.RouterStatus
				ptr = HMCharacteristicTypeRouterStatus;
				break;
			case 134: // HMCharacteristicType.WanStatusList
				ptr = HMCharacteristicTypeWANStatusList;
				break;
			case 135: // HMCharacteristicType.WiFiSatelliteStatus
				ptr = HMCharacteristicTypeWiFiSatelliteStatus;
				break;
			case 136: // HMCharacteristicType.VolumeControlType
				ptr = HMCharacteristicTypeVolumeControlType;
				break;
			case 137: // HMCharacteristicType.VolumeSelector
				ptr = HMCharacteristicTypeVolumeSelector;
				break;
			case 138: // HMCharacteristicType.TargetMediaState
				ptr = HMCharacteristicTypeTargetMediaState;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMCharacteristicType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HMCharacteristicType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HMCharacteristicTypePowerState))
				return HMCharacteristicType.PowerState;
			if (constant.IsEqualTo (HMCharacteristicTypeHue))
				return HMCharacteristicType.Hue;
			if (constant.IsEqualTo (HMCharacteristicTypeSaturation))
				return HMCharacteristicType.Saturation;
			if (constant.IsEqualTo (HMCharacteristicTypeBrightness))
				return HMCharacteristicType.Brightness;
			if (constant.IsEqualTo (HMCharacteristicTypeTemperatureUnits))
				return HMCharacteristicType.TemperatureUnits;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentTemperature))
				return HMCharacteristicType.CurrentTemperature;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetTemperature))
				return HMCharacteristicType.TargetTemperature;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentHeatingCooling))
				return HMCharacteristicType.CurrentHeatingCooling;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetHeatingCooling))
				return HMCharacteristicType.TargetHeatingCooling;
			if (constant.IsEqualTo (HMCharacteristicTypeCoolingThreshold))
				return HMCharacteristicType.CoolingThreshold;
			if (constant.IsEqualTo (HMCharacteristicTypeHeatingThreshold))
				return HMCharacteristicType.HeatingThreshold;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentRelativeHumidity))
				return HMCharacteristicType.CurrentRelativeHumidity;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetRelativeHumidity))
				return HMCharacteristicType.TargetRelativeHumidity;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentDoorState))
				return HMCharacteristicType.CurrentDoorState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetDoorState))
				return HMCharacteristicType.TargetDoorState;
			if (constant.IsEqualTo (HMCharacteristicTypeObstructionDetected))
				return HMCharacteristicType.ObstructionDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeName))
				return HMCharacteristicType.Name;
			if (constant.IsEqualTo (HMCharacteristicTypeManufacturer))
				return HMCharacteristicType.Manufacturer;
			if (constant.IsEqualTo (HMCharacteristicTypeModel))
				return HMCharacteristicType.Model;
			if (constant.IsEqualTo (HMCharacteristicTypeSerialNumber))
				return HMCharacteristicType.SerialNumber;
			if (constant.IsEqualTo (HMCharacteristicTypeIdentify))
				return HMCharacteristicType.Identify;
			if (constant.IsEqualTo (HMCharacteristicTypeRotationDirection))
				return HMCharacteristicType.RotationDirection;
			if (constant.IsEqualTo (HMCharacteristicTypeRotationSpeed))
				return HMCharacteristicType.RotationSpeed;
			if (constant.IsEqualTo (HMCharacteristicTypeOutletInUse))
				return HMCharacteristicType.OutletInUse;
			if (constant.IsEqualTo (HMCharacteristicTypeVersion))
				return HMCharacteristicType.Version;
			if (constant.IsEqualTo (HMCharacteristicTypeLogs))
				return HMCharacteristicType.Logs;
			if (constant.IsEqualTo (HMCharacteristicTypeAudioFeedback))
				return HMCharacteristicType.AudioFeedback;
			if (constant.IsEqualTo (HMCharacteristicTypeAdminOnlyAccess))
				return HMCharacteristicType.AdminOnlyAccess;
			if (constant.IsEqualTo (HMCharacteristicTypeMotionDetected))
				return HMCharacteristicType.MotionDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentLockMechanismState))
				return HMCharacteristicType.CurrentLockMechanismState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetLockMechanismState))
				return HMCharacteristicType.TargetLockMechanismState;
			if (constant.IsEqualTo (HMCharacteristicTypeLockMechanismLastKnownAction))
				return HMCharacteristicType.LockMechanismLastKnownAction;
			if (constant.IsEqualTo (HMCharacteristicTypeLockManagementControlPoint))
				return HMCharacteristicType.LockManagementControlPoint;
			if (constant.IsEqualTo (HMCharacteristicTypeLockManagementAutoSecureTimeout))
				return HMCharacteristicType.LockManagementAutoSecureTimeout;
			if (constant.IsEqualTo (HMCharacteristicTypeAirParticulateDensity))
				return HMCharacteristicType.AirParticulateDensity;
			if (constant.IsEqualTo (HMCharacteristicTypeAirParticulateSize))
				return HMCharacteristicType.AirParticulateSize;
			if (constant.IsEqualTo (HMCharacteristicTypeAirQuality))
				return HMCharacteristicType.AirQuality;
			if (constant.IsEqualTo (HMCharacteristicTypeBatteryLevel))
				return HMCharacteristicType.BatteryLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonDioxideDetected))
				return HMCharacteristicType.CarbonDioxideDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonDioxideLevel))
				return HMCharacteristicType.CarbonDioxideLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonDioxidePeakLevel))
				return HMCharacteristicType.CarbonDioxidePeakLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonMonoxideDetected))
				return HMCharacteristicType.CarbonMonoxideDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonMonoxideLevel))
				return HMCharacteristicType.CarbonMonoxideLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeCarbonMonoxidePeakLevel))
				return HMCharacteristicType.CarbonMonoxidePeakLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeChargingState))
				return HMCharacteristicType.ChargingState;
			if (constant.IsEqualTo (HMCharacteristicTypeContactState))
				return HMCharacteristicType.ContactState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentSecuritySystemState))
				return HMCharacteristicType.CurrentSecuritySystemState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentHorizontalTilt))
				return HMCharacteristicType.CurrentHorizontalTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentLightLevel))
				return HMCharacteristicType.CurrentLightLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentPosition))
				return HMCharacteristicType.CurrentPosition;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentVerticalTilt))
				return HMCharacteristicType.CurrentVerticalTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeFirmwareVersion))
				return HMCharacteristicType.FirmwareVersion;
			if (constant.IsEqualTo (HMCharacteristicTypeHardwareVersion))
				return HMCharacteristicType.HardwareVersion;
			if (constant.IsEqualTo (HMCharacteristicTypeHoldPosition))
				return HMCharacteristicType.HoldPosition;
			if (constant.IsEqualTo (HMCharacteristicTypeInputEvent))
				return HMCharacteristicType.InputEvent;
			if (constant.IsEqualTo (HMCharacteristicTypeLeakDetected))
				return HMCharacteristicType.LeakDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeOccupancyDetected))
				return HMCharacteristicType.OccupancyDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeOutputState))
				return HMCharacteristicType.OutputState;
			if (constant.IsEqualTo (HMCharacteristicTypePositionState))
				return HMCharacteristicType.PositionState;
			if (constant.IsEqualTo (HMCharacteristicTypeSmokeDetected))
				return HMCharacteristicType.SmokeDetected;
			if (constant.IsEqualTo (HMCharacteristicTypeSoftwareVersion))
				return HMCharacteristicType.SoftwareVersion;
			if (constant.IsEqualTo (HMCharacteristicTypeStatusActive))
				return HMCharacteristicType.StatusActive;
			if (constant.IsEqualTo (HMCharacteristicTypeStatusFault))
				return HMCharacteristicType.StatusFault;
			if (constant.IsEqualTo (HMCharacteristicTypeStatusJammed))
				return HMCharacteristicType.StatusJammed;
			if (constant.IsEqualTo (HMCharacteristicTypeStatusLowBattery))
				return HMCharacteristicType.StatusLowBattery;
			if (constant.IsEqualTo (HMCharacteristicTypeStatusTampered))
				return HMCharacteristicType.StatusTampered;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetSecuritySystemState))
				return HMCharacteristicType.TargetSecuritySystemState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetHorizontalTilt))
				return HMCharacteristicType.TargetHorizontalTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetPosition))
				return HMCharacteristicType.TargetPosition;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetVerticalTilt))
				return HMCharacteristicType.TargetVerticalTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeStreamingStatus))
				return HMCharacteristicType.StreamingStatus;
			if (constant.IsEqualTo (HMCharacteristicTypeSetupStreamEndpoint))
				return HMCharacteristicType.SetupStreamEndpoint;
			if (constant.IsEqualTo (HMCharacteristicTypeSupportedVideoStreamConfiguration))
				return HMCharacteristicType.SupportedVideoStreamConfiguration;
			if (constant.IsEqualTo (HMCharacteristicTypeSupportedAudioStreamConfiguration))
				return HMCharacteristicType.SupportedAudioStreamConfiguration;
			if (constant.IsEqualTo (HMCharacteristicTypeSupportedRTPConfiguration))
				return HMCharacteristicType.SupportedRtpConfiguration;
			if (constant.IsEqualTo (HMCharacteristicTypeSelectedStreamConfiguration))
				return HMCharacteristicType.SelectedStreamConfiguration;
			if (constant.IsEqualTo (HMCharacteristicTypeVolume))
				return HMCharacteristicType.Volume;
			if (constant.IsEqualTo (HMCharacteristicTypeMute))
				return HMCharacteristicType.Mute;
			if (constant.IsEqualTo (HMCharacteristicTypeNightVision))
				return HMCharacteristicType.NightVision;
			if (constant.IsEqualTo (HMCharacteristicTypeOpticalZoom))
				return HMCharacteristicType.OpticalZoom;
			if (constant.IsEqualTo (HMCharacteristicTypeDigitalZoom))
				return HMCharacteristicType.DigitalZoom;
			if (constant.IsEqualTo (HMCharacteristicTypeImageRotation))
				return HMCharacteristicType.ImageRotation;
			if (constant.IsEqualTo (HMCharacteristicTypeImageMirroring))
				return HMCharacteristicType.ImageMirroring;
			if (constant.IsEqualTo (HMCharacteristicTypeActive))
				return HMCharacteristicType.Active;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentAirPurifierState))
				return HMCharacteristicType.CurrentAirPurifierState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetAirPurifierState))
				return HMCharacteristicType.TargetAirPurifierState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentFanState))
				return HMCharacteristicType.CurrentFanState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentHeaterCoolerState))
				return HMCharacteristicType.CurrentHeaterCoolerState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentHumidifierDehumidifierState))
				return HMCharacteristicType.CurrentHumidifierDehumidifierState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentSlatState))
				return HMCharacteristicType.CurrentSlatState;
			if (constant.IsEqualTo (HMCharacteristicTypeWaterLevel))
				return HMCharacteristicType.WaterLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeFilterChangeIndication))
				return HMCharacteristicType.FilterChangeIndication;
			if (constant.IsEqualTo (HMCharacteristicTypeFilterLifeLevel))
				return HMCharacteristicType.FilterLifeLevel;
			if (constant.IsEqualTo (HMCharacteristicTypeFilterResetChangeIndication))
				return HMCharacteristicType.FilterResetChangeIndication;
			if (constant.IsEqualTo (HMCharacteristicTypeLockPhysicalControls))
				return HMCharacteristicType.LockPhysicalControls;
			if (constant.IsEqualTo (HMCharacteristicTypeSwingMode))
				return HMCharacteristicType.SwingMode;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetHeaterCoolerState))
				return HMCharacteristicType.TargetHeaterCoolerState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetHumidifierDehumidifierState))
				return HMCharacteristicType.TargetHumidifierDehumidifierState;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetFanState))
				return HMCharacteristicType.TargetFanState;
			if (constant.IsEqualTo (HMCharacteristicTypeSlatType))
				return HMCharacteristicType.SlatType;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentTilt))
				return HMCharacteristicType.CurrentTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetTilt))
				return HMCharacteristicType.TargetTilt;
			if (constant.IsEqualTo (HMCharacteristicTypeOzoneDensity))
				return HMCharacteristicType.OzoneDensity;
			if (constant.IsEqualTo (HMCharacteristicTypeNitrogenDioxideDensity))
				return HMCharacteristicType.NitrogenDioxideDensity;
			if (constant.IsEqualTo (HMCharacteristicTypeSulphurDioxideDensity))
				return HMCharacteristicType.SulphurDioxideDensity;
			if (constant.IsEqualTo (HMCharacteristicTypePM2_5Density))
				return HMCharacteristicType.PM2_5Density;
			if (constant.IsEqualTo (HMCharacteristicTypePM10Density))
				return HMCharacteristicType.PM10Density;
			if (constant.IsEqualTo (HMCharacteristicTypeVolatileOrganicCompoundDensity))
				return HMCharacteristicType.VolatileOrganicCompoundDensity;
			if (constant.IsEqualTo (HMCharacteristicTypeDehumidifierThreshold))
				return HMCharacteristicType.DehumidifierThreshold;
			if (constant.IsEqualTo (HMCharacteristicTypeHumidifierThreshold))
				return HMCharacteristicType.HumidifierThreshold;
			if (constant.IsEqualTo (HMCharacteristicTypeSecuritySystemAlarmType))
				return HMCharacteristicType.SecuritySystemAlarmType;
			if (constant.IsEqualTo (HMCharacteristicTypeLabelNamespace))
				return HMCharacteristicType.LabelNamespace;
			if (constant.IsEqualTo (HMCharacteristicTypeLabelIndex))
				return HMCharacteristicType.LabelIndex;
			if (constant.IsEqualTo (HMCharacteristicTypeColorTemperature))
				return HMCharacteristicType.ColorTemperature;
			if (constant.IsEqualTo (HMCharacteristicTypeProgramMode))
				return HMCharacteristicType.ProgramMode;
			if (constant.IsEqualTo (HMCharacteristicTypeInUse))
				return HMCharacteristicType.InUse;
			if (constant.IsEqualTo (HMCharacteristicTypeSetDuration))
				return HMCharacteristicType.SetDuration;
			if (constant.IsEqualTo (HMCharacteristicTypeRemainingDuration))
				return HMCharacteristicType.RemainingDuration;
			if (constant.IsEqualTo (HMCharacteristicTypeValveType))
				return HMCharacteristicType.ValveType;
			if (constant.IsEqualTo (HMCharacteristicTypeIsConfigured))
				return HMCharacteristicType.IsConfigured;
			if (constant.IsEqualTo (HMCharacteristicTypeInputSourceType))
				return HMCharacteristicType.InputSourceType;
			if (constant.IsEqualTo (HMCharacteristicTypeInputDeviceType))
				return HMCharacteristicType.InputDeviceType;
			if (constant.IsEqualTo (HMCharacteristicTypeClosedCaptions))
				return HMCharacteristicType.ClosedCaptions;
			if (constant.IsEqualTo (HMCharacteristicTypePowerModeSelection))
				return HMCharacteristicType.PowerModeSelection;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentMediaState))
				return HMCharacteristicType.CurrentMediaState;
			if (constant.IsEqualTo (HMCharacteristicTypeRemoteKey))
				return HMCharacteristicType.RemoteKey;
			if (constant.IsEqualTo (HMCharacteristicTypePictureMode))
				return HMCharacteristicType.PictureMode;
			if (constant.IsEqualTo (HMCharacteristicTypeConfiguredName))
				return HMCharacteristicType.ConfiguredName;
			if (constant.IsEqualTo (HMCharacteristicTypeIdentifier))
				return HMCharacteristicType.Identifier;
			if (constant.IsEqualTo (HMCharacteristicTypeActiveIdentifier))
				return HMCharacteristicType.ActiveIdentifier;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetVisibilityState))
				return HMCharacteristicType.TargetVisibilityState;
			if (constant.IsEqualTo (HMCharacteristicTypeCurrentVisibilityState))
				return HMCharacteristicType.CurrentVisibilityState;
			if (constant.IsEqualTo (HMCharacteristicTypeRouterStatus))
				return HMCharacteristicType.RouterStatus;
			if (constant.IsEqualTo (HMCharacteristicTypeWANStatusList))
				return HMCharacteristicType.WanStatusList;
			if (constant.IsEqualTo (HMCharacteristicTypeWiFiSatelliteStatus))
				return HMCharacteristicType.WiFiSatelliteStatus;
			if (constant.IsEqualTo (HMCharacteristicTypeVolumeControlType))
				return HMCharacteristicType.VolumeControlType;
			if (constant.IsEqualTo (HMCharacteristicTypeVolumeSelector))
				return HMCharacteristicType.VolumeSelector;
			if (constant.IsEqualTo (HMCharacteristicTypeTargetMediaState))
				return HMCharacteristicType.TargetMediaState;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMCharacteristicType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMCharacteristicType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HomeKit.HMCharacteristicType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HMCharacteristicType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HomeKit.HMCharacteristicType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HMCharacteristicType[]? values)
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
		internal static HMCharacteristicType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HMCharacteristicType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
