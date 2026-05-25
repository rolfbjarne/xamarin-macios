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
namespace HealthKit {
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	[SupportedOSPlatform ("macos13.0")]
	public enum HKVerifiableClinicalRecordCredentialType : int {
		None = 0,
		Covid19 = 1,
		Immunization = 2,
		Laboratory = 3,
		Recovery = 4,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKVerifiableClinicalRecordCredentialType" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	[SupportedOSPlatform ("macos13.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKVerifiableClinicalRecordCredentialTypeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("HKVerifiableClinicalRecordCredentialTypeCOVID19", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordCredentialTypeCOVID19 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordCredentialTypeCOVID19", storage);
			}
		}
		[Field ("HKVerifiableClinicalRecordCredentialTypeImmunization", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordCredentialTypeImmunization {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordCredentialTypeImmunization", storage);
			}
		}
		[Field ("HKVerifiableClinicalRecordCredentialTypeLaboratory", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordCredentialTypeLaboratory {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordCredentialTypeLaboratory", storage);
			}
		}
		[Field ("HKVerifiableClinicalRecordCredentialTypeRecovery", "HealthKit")]
		internal unsafe static IntPtr HKVerifiableClinicalRecordCredentialTypeRecovery {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKVerifiableClinicalRecordCredentialTypeRecovery", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKVerifiableClinicalRecordCredentialType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // HKVerifiableClinicalRecordCredentialType.Covid19
				ptr = HKVerifiableClinicalRecordCredentialTypeCOVID19;
				break;
			case 2: // HKVerifiableClinicalRecordCredentialType.Immunization
				ptr = HKVerifiableClinicalRecordCredentialTypeImmunization;
				break;
			case 3: // HKVerifiableClinicalRecordCredentialType.Laboratory
				ptr = HKVerifiableClinicalRecordCredentialTypeLaboratory;
				break;
			case 4: // HKVerifiableClinicalRecordCredentialType.Recovery
				ptr = HKVerifiableClinicalRecordCredentialTypeRecovery;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordCredentialType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordCredentialType GetValue (NSString? constant)
		{
			if (constant is null)
				return HKVerifiableClinicalRecordCredentialType.None;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordCredentialTypeCOVID19))
				return HKVerifiableClinicalRecordCredentialType.Covid19;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordCredentialTypeImmunization))
				return HKVerifiableClinicalRecordCredentialType.Immunization;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordCredentialTypeLaboratory))
				return HKVerifiableClinicalRecordCredentialType.Laboratory;
			if (constant.IsEqualTo (HKVerifiableClinicalRecordCredentialTypeRecovery))
				return HKVerifiableClinicalRecordCredentialType.Recovery;
			return HKVerifiableClinicalRecordCredentialType.None;
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordCredentialType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordCredentialType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKVerifiableClinicalRecordCredentialType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKVerifiableClinicalRecordCredentialType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKVerifiableClinicalRecordCredentialType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKVerifiableClinicalRecordCredentialType[]? values)
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
		internal static HKVerifiableClinicalRecordCredentialType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKVerifiableClinicalRecordCredentialType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
