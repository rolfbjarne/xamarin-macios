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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HealthKit {
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	[SupportedOSPlatform ("macos13.0")]
	public enum HKVerifiableClinicalRecordSourceType : int {
		None = 0,
		SmartHealthCard = 1,
		EuDigitalCovidCertificate = 2,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKVerifiableClinicalRecordSourceType" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	[SupportedOSPlatform ("macos13.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKVerifiableClinicalRecordSourceTypeExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("HKVerifiableClinicalRecordSourceTypeSMARTHealthCard", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordSourceTypeSMARTHealthCard {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordSourceTypeSMARTHealthCard", storage);
			}
		}
		[Field ("HKVerifiableClinicalRecordSourceTypeEUDigitalCOVIDCertificate", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordSourceTypeEUDigitalCOVIDCertificate {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordSourceTypeEUDigitalCOVIDCertificate", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKVerifiableClinicalRecordSourceType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // HKVerifiableClinicalRecordSourceType.SmartHealthCard
				ptr = HKVerifiableClinicalRecordSourceTypeSMARTHealthCard;
				break;
			case 2: // HKVerifiableClinicalRecordSourceType.EuDigitalCovidCertificate
				ptr = HKVerifiableClinicalRecordSourceTypeEUDigitalCOVIDCertificate;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordSourceType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordSourceType GetValue (NSString? constant)
		{
			if (constant is null)
				return HKVerifiableClinicalRecordSourceType.None;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordSourceTypeSMARTHealthCard))
				return HKVerifiableClinicalRecordSourceType.SmartHealthCard;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordSourceTypeEUDigitalCOVIDCertificate))
				return HKVerifiableClinicalRecordSourceType.EuDigitalCovidCertificate;
			return HKVerifiableClinicalRecordSourceType.None;
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordSourceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordSourceType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordSourceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordSourceType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKVerifiableClinicalRecordSourceType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKVerifiableClinicalRecordSourceType[]? values)
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
		internal static HKVerifiableClinicalRecordSourceType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKVerifiableClinicalRecordSourceType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
