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
namespace SensorKit {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SRSensor : int {
		Invalid = -1,
		AmbientLightSensor = 0,
		Accelerometer = 1,
		RotationRate = 2,
		Visits = 3,
		PedometerData = 4,
		DeviceUsageReport = 5,
		MessagesUsageReport = 6,
		PhoneUsageReport = 7,
		OnWristState = 8,
		KeyboardMetrics = 9,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		SiriSpeechMetrics = 10,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		TelephonySpeechMetrics = 11,
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		AmbientPressure = 12,
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		MediaEvents = 13,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		FaceMetrics = 14,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		HeartRate = 15,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		Odometer = 16,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		WristTemperature = 17,
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		Electrocardiogram = 18,
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		Photoplethysmogram = 19,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		AcousticSettings = 20,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		SleepSessions = 21,
	}
	/// <summary>Extension methods for the <see cref="global::SensorKit.SRSensor" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SRSensorExtensions {
		static IntPtr[] values = new IntPtr [22];
		[Field ("SRSensorAmbientLightSensor", "SensorKit")]
		internal unsafe static IntPtr SRSensorAmbientLightSensor {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorAmbientLightSensor", storage);
			}
		}
		[Field ("SRSensorAccelerometer", "SensorKit")]
		internal unsafe static IntPtr SRSensorAccelerometer {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorAccelerometer", storage);
			}
		}
		[Field ("SRSensorRotationRate", "SensorKit")]
		internal unsafe static IntPtr SRSensorRotationRate {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorRotationRate", storage);
			}
		}
		[Field ("SRSensorVisits", "SensorKit")]
		internal unsafe static IntPtr SRSensorVisits {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorVisits", storage);
			}
		}
		[Field ("SRSensorPedometerData", "SensorKit")]
		internal unsafe static IntPtr SRSensorPedometerData {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorPedometerData", storage);
			}
		}
		[Field ("SRSensorDeviceUsageReport", "SensorKit")]
		internal unsafe static IntPtr SRSensorDeviceUsageReport {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorDeviceUsageReport", storage);
			}
		}
		[Field ("SRSensorMessagesUsageReport", "SensorKit")]
		internal unsafe static IntPtr SRSensorMessagesUsageReport {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorMessagesUsageReport", storage);
			}
		}
		[Field ("SRSensorPhoneUsageReport", "SensorKit")]
		internal unsafe static IntPtr SRSensorPhoneUsageReport {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorPhoneUsageReport", storage);
			}
		}
		[Field ("SRSensorOnWristState", "SensorKit")]
		internal unsafe static IntPtr SRSensorOnWristState {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorOnWristState", storage);
			}
		}
		[Field ("SRSensorKeyboardMetrics", "SensorKit")]
		internal unsafe static IntPtr SRSensorKeyboardMetrics {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorKeyboardMetrics", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorSiriSpeechMetrics", "SensorKit")]
		internal unsafe static IntPtr SRSensorSiriSpeechMetrics {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorSiriSpeechMetrics", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorTelephonySpeechMetrics", "SensorKit")]
		internal unsafe static IntPtr SRSensorTelephonySpeechMetrics {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorTelephonySpeechMetrics", storage);
			}
		}
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorAmbientPressure", "SensorKit")]
		internal unsafe static IntPtr SRSensorAmbientPressure {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorAmbientPressure", storage);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorMediaEvents", "SensorKit")]
		internal unsafe static IntPtr SRSensorMediaEvents {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorMediaEvents", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorFaceMetrics", "SensorKit")]
		internal unsafe static IntPtr SRSensorFaceMetrics {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorFaceMetrics", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorHeartRate", "SensorKit")]
		internal unsafe static IntPtr SRSensorHeartRate {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorHeartRate", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorOdometer", "SensorKit")]
		internal unsafe static IntPtr SRSensorOdometer {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorOdometer", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorWristTemperature", "SensorKit")]
		internal unsafe static IntPtr SRSensorWristTemperature {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorWristTemperature", storage);
			}
		}
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorElectrocardiogram", "SensorKit")]
		internal unsafe static IntPtr SRSensorElectrocardiogram {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorElectrocardiogram", storage);
			}
		}
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorPhotoplethysmogram", "SensorKit")]
		internal unsafe static IntPtr SRSensorPhotoplethysmogram {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorPhotoplethysmogram", storage);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorAcousticSettings", "SensorKit")]
		internal unsafe static IntPtr SRSensorAcousticSettings {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorAcousticSettings", storage);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[Field ("SRSensorSleepSessions", "SensorKit")]
		internal unsafe static IntPtr SRSensorSleepSessions {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRSensorSleepSessions", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SRSensor self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SRSensor.AmbientLightSensor
				ptr = SRSensorAmbientLightSensor;
				break;
			case 1: // SRSensor.Accelerometer
				ptr = SRSensorAccelerometer;
				break;
			case 2: // SRSensor.RotationRate
				ptr = SRSensorRotationRate;
				break;
			case 3: // SRSensor.Visits
				ptr = SRSensorVisits;
				break;
			case 4: // SRSensor.PedometerData
				ptr = SRSensorPedometerData;
				break;
			case 5: // SRSensor.DeviceUsageReport
				ptr = SRSensorDeviceUsageReport;
				break;
			case 6: // SRSensor.MessagesUsageReport
				ptr = SRSensorMessagesUsageReport;
				break;
			case 7: // SRSensor.PhoneUsageReport
				ptr = SRSensorPhoneUsageReport;
				break;
			case 8: // SRSensor.OnWristState
				ptr = SRSensorOnWristState;
				break;
			case 9: // SRSensor.KeyboardMetrics
				ptr = SRSensorKeyboardMetrics;
				break;
			case 10: // SRSensor.SiriSpeechMetrics
				ptr = SRSensorSiriSpeechMetrics;
				break;
			case 11: // SRSensor.TelephonySpeechMetrics
				ptr = SRSensorTelephonySpeechMetrics;
				break;
			case 12: // SRSensor.AmbientPressure
				ptr = SRSensorAmbientPressure;
				break;
			case 13: // SRSensor.MediaEvents
				ptr = SRSensorMediaEvents;
				break;
			case 14: // SRSensor.FaceMetrics
				ptr = SRSensorFaceMetrics;
				break;
			case 15: // SRSensor.HeartRate
				ptr = SRSensorHeartRate;
				break;
			case 16: // SRSensor.Odometer
				ptr = SRSensorOdometer;
				break;
			case 17: // SRSensor.WristTemperature
				ptr = SRSensorWristTemperature;
				break;
			case 18: // SRSensor.Electrocardiogram
				ptr = SRSensorElectrocardiogram;
				break;
			case 19: // SRSensor.Photoplethysmogram
				ptr = SRSensorPhotoplethysmogram;
				break;
			case 20: // SRSensor.AcousticSettings
				ptr = SRSensorAcousticSettings;
				break;
			case 21: // SRSensor.SleepSessions
				ptr = SRSensorSleepSessions;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRSensor" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SRSensor GetValue (NSString? constant)
		{
			if (constant is null)
				return SRSensor.Invalid;
			if (constant.IsEqualTo (SRSensorAmbientLightSensor))
				return SRSensor.AmbientLightSensor;
			if (constant.IsEqualTo (SRSensorAccelerometer))
				return SRSensor.Accelerometer;
			if (constant.IsEqualTo (SRSensorRotationRate))
				return SRSensor.RotationRate;
			if (constant.IsEqualTo (SRSensorVisits))
				return SRSensor.Visits;
			if (constant.IsEqualTo (SRSensorPedometerData))
				return SRSensor.PedometerData;
			if (constant.IsEqualTo (SRSensorDeviceUsageReport))
				return SRSensor.DeviceUsageReport;
			if (constant.IsEqualTo (SRSensorMessagesUsageReport))
				return SRSensor.MessagesUsageReport;
			if (constant.IsEqualTo (SRSensorPhoneUsageReport))
				return SRSensor.PhoneUsageReport;
			if (constant.IsEqualTo (SRSensorOnWristState))
				return SRSensor.OnWristState;
			if (constant.IsEqualTo (SRSensorKeyboardMetrics))
				return SRSensor.KeyboardMetrics;
			if (constant.IsEqualTo (SRSensorSiriSpeechMetrics))
				return SRSensor.SiriSpeechMetrics;
			if (constant.IsEqualTo (SRSensorTelephonySpeechMetrics))
				return SRSensor.TelephonySpeechMetrics;
			if (constant.IsEqualTo (SRSensorAmbientPressure))
				return SRSensor.AmbientPressure;
			if (constant.IsEqualTo (SRSensorMediaEvents))
				return SRSensor.MediaEvents;
			if (constant.IsEqualTo (SRSensorFaceMetrics))
				return SRSensor.FaceMetrics;
			if (constant.IsEqualTo (SRSensorHeartRate))
				return SRSensor.HeartRate;
			if (constant.IsEqualTo (SRSensorOdometer))
				return SRSensor.Odometer;
			if (constant.IsEqualTo (SRSensorWristTemperature))
				return SRSensor.WristTemperature;
			if (constant.IsEqualTo (SRSensorElectrocardiogram))
				return SRSensor.Electrocardiogram;
			if (constant.IsEqualTo (SRSensorPhotoplethysmogram))
				return SRSensor.Photoplethysmogram;
			if (constant.IsEqualTo (SRSensorAcousticSettings))
				return SRSensor.AcousticSettings;
			if (constant.IsEqualTo (SRSensorSleepSessions))
				return SRSensor.SleepSessions;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRSensor" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SRSensor GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRSensor" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SRSensor? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::SensorKit.SRSensor" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SRSensor[]? values)
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
		internal static SRSensor[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SRSensor> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
