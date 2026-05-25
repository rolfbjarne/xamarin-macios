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
	/// <summary>Enumerates the forms of <see cref="T:HealthKit.HKCharacteristicType" />.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum HKCharacteristicTypeIdentifier : int {
		/// <summary>The biological sex characteristic.</summary>
		BiologicalSex = 0,
		/// <summary>The blood type characteristic.</summary>
		BloodType = 1,
		/// <summary>The date of birth characteristic.</summary>
		DateOfBirth = 2,
		/// <summary>The Fitzpatrick skin type characteristic.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		FitzpatrickSkinType = 3,
		/// <summary>The wheelchair use characteristic.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		WheelchairUse = 4,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		ActivityMoveMode = 5,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKCharacteristicTypeIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKCharacteristicTypeIdentifierExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("HKCharacteristicTypeIdentifierBiologicalSex", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierBiologicalSex {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierBiologicalSex", storage);
			}
		}
		[Field ("HKCharacteristicTypeIdentifierBloodType", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierBloodType {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierBloodType", storage);
			}
		}
		[Field ("HKCharacteristicTypeIdentifierDateOfBirth", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierDateOfBirth {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierDateOfBirth", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCharacteristicTypeIdentifierFitzpatrickSkinType", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierFitzpatrickSkinType {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierFitzpatrickSkinType", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCharacteristicTypeIdentifierWheelchairUse", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierWheelchairUse {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierWheelchairUse", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[Field ("HKCharacteristicTypeIdentifierActivityMoveMode", "HealthKit")]
		internal unsafe static IntPtr HKCharacteristicTypeIdentifierActivityMoveMode {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKCharacteristicTypeIdentifierActivityMoveMode", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKCharacteristicTypeIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKCharacteristicTypeIdentifier.BiologicalSex
				ptr = HKCharacteristicTypeIdentifierBiologicalSex;
				break;
			case 1: // HKCharacteristicTypeIdentifier.BloodType
				ptr = HKCharacteristicTypeIdentifierBloodType;
				break;
			case 2: // HKCharacteristicTypeIdentifier.DateOfBirth
				ptr = HKCharacteristicTypeIdentifierDateOfBirth;
				break;
			case 3: // HKCharacteristicTypeIdentifier.FitzpatrickSkinType
				ptr = HKCharacteristicTypeIdentifierFitzpatrickSkinType;
				break;
			case 4: // HKCharacteristicTypeIdentifier.WheelchairUse
				ptr = HKCharacteristicTypeIdentifierWheelchairUse;
				break;
			case 5: // HKCharacteristicTypeIdentifier.ActivityMoveMode
				ptr = HKCharacteristicTypeIdentifierActivityMoveMode;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCharacteristicTypeIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKCharacteristicTypeIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierBiologicalSex))
				return HKCharacteristicTypeIdentifier.BiologicalSex;
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierBloodType))
				return HKCharacteristicTypeIdentifier.BloodType;
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierDateOfBirth))
				return HKCharacteristicTypeIdentifier.DateOfBirth;
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierFitzpatrickSkinType))
				return HKCharacteristicTypeIdentifier.FitzpatrickSkinType;
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierWheelchairUse))
				return HKCharacteristicTypeIdentifier.WheelchairUse;
			if (constant.IsEqualTo (HKCharacteristicTypeIdentifierActivityMoveMode))
				return HKCharacteristicTypeIdentifier.ActivityMoveMode;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCharacteristicTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCharacteristicTypeIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKCharacteristicTypeIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKCharacteristicTypeIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKCharacteristicTypeIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKCharacteristicTypeIdentifier[]? values)
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
		internal static HKCharacteristicTypeIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKCharacteristicTypeIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
