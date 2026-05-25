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
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum HKMedicationGeneralForm : int {
		Capsule = 0,
		Cream = 1,
		Device = 2,
		Drops = 3,
		Foam = 4,
		Gel = 5,
		Inhaler = 6,
		Injection = 7,
		Liquid = 8,
		Lotion = 9,
		Ointment = 10,
		Patch = 11,
		Powder = 12,
		Spray = 13,
		Suppository = 14,
		Tablet = 15,
		Topical = 16,
		Unknown = 17,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKMedicationGeneralForm" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKMedicationGeneralFormExtensions {
		static IntPtr[] values = new IntPtr [18];
		[Field ("HKMedicationGeneralFormCapsule", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormCapsule {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormCapsule", storage);
			}
		}
		[Field ("HKMedicationGeneralFormCream", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormCream {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormCream", storage);
			}
		}
		[Field ("HKMedicationGeneralFormDevice", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormDevice {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormDevice", storage);
			}
		}
		[Field ("HKMedicationGeneralFormDrops", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormDrops {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormDrops", storage);
			}
		}
		[Field ("HKMedicationGeneralFormFoam", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormFoam {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormFoam", storage);
			}
		}
		[Field ("HKMedicationGeneralFormGel", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormGel {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormGel", storage);
			}
		}
		[Field ("HKMedicationGeneralFormInhaler", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormInhaler {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormInhaler", storage);
			}
		}
		[Field ("HKMedicationGeneralFormInjection", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormInjection {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormInjection", storage);
			}
		}
		[Field ("HKMedicationGeneralFormLiquid", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormLiquid {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormLiquid", storage);
			}
		}
		[Field ("HKMedicationGeneralFormLotion", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormLotion {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormLotion", storage);
			}
		}
		[Field ("HKMedicationGeneralFormOintment", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormOintment {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormOintment", storage);
			}
		}
		[Field ("HKMedicationGeneralFormPatch", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormPatch {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormPatch", storage);
			}
		}
		[Field ("HKMedicationGeneralFormPowder", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormPowder {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormPowder", storage);
			}
		}
		[Field ("HKMedicationGeneralFormSpray", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormSpray {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormSpray", storage);
			}
		}
		[Field ("HKMedicationGeneralFormSuppository", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormSuppository {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormSuppository", storage);
			}
		}
		[Field ("HKMedicationGeneralFormTablet", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormTablet {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormTablet", storage);
			}
		}
		[Field ("HKMedicationGeneralFormTopical", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormTopical {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormTopical", storage);
			}
		}
		[Field ("HKMedicationGeneralFormUnknown", "HealthKit")]
		internal unsafe static IntPtr HKMedicationGeneralFormUnknown {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.HealthKit.Handle, "HKMedicationGeneralFormUnknown", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this HKMedicationGeneralForm self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // HKMedicationGeneralForm.Capsule
				ptr = HKMedicationGeneralFormCapsule;
				break;
			case 1: // HKMedicationGeneralForm.Cream
				ptr = HKMedicationGeneralFormCream;
				break;
			case 2: // HKMedicationGeneralForm.Device
				ptr = HKMedicationGeneralFormDevice;
				break;
			case 3: // HKMedicationGeneralForm.Drops
				ptr = HKMedicationGeneralFormDrops;
				break;
			case 4: // HKMedicationGeneralForm.Foam
				ptr = HKMedicationGeneralFormFoam;
				break;
			case 5: // HKMedicationGeneralForm.Gel
				ptr = HKMedicationGeneralFormGel;
				break;
			case 6: // HKMedicationGeneralForm.Inhaler
				ptr = HKMedicationGeneralFormInhaler;
				break;
			case 7: // HKMedicationGeneralForm.Injection
				ptr = HKMedicationGeneralFormInjection;
				break;
			case 8: // HKMedicationGeneralForm.Liquid
				ptr = HKMedicationGeneralFormLiquid;
				break;
			case 9: // HKMedicationGeneralForm.Lotion
				ptr = HKMedicationGeneralFormLotion;
				break;
			case 10: // HKMedicationGeneralForm.Ointment
				ptr = HKMedicationGeneralFormOintment;
				break;
			case 11: // HKMedicationGeneralForm.Patch
				ptr = HKMedicationGeneralFormPatch;
				break;
			case 12: // HKMedicationGeneralForm.Powder
				ptr = HKMedicationGeneralFormPowder;
				break;
			case 13: // HKMedicationGeneralForm.Spray
				ptr = HKMedicationGeneralFormSpray;
				break;
			case 14: // HKMedicationGeneralForm.Suppository
				ptr = HKMedicationGeneralFormSuppository;
				break;
			case 15: // HKMedicationGeneralForm.Tablet
				ptr = HKMedicationGeneralFormTablet;
				break;
			case 16: // HKMedicationGeneralForm.Topical
				ptr = HKMedicationGeneralFormTopical;
				break;
			case 17: // HKMedicationGeneralForm.Unknown
				ptr = HKMedicationGeneralFormUnknown;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKMedicationGeneralForm" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static HKMedicationGeneralForm GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (HKMedicationGeneralFormCapsule))
				return HKMedicationGeneralForm.Capsule;
			if (constant.IsEqualTo (HKMedicationGeneralFormCream))
				return HKMedicationGeneralForm.Cream;
			if (constant.IsEqualTo (HKMedicationGeneralFormDevice))
				return HKMedicationGeneralForm.Device;
			if (constant.IsEqualTo (HKMedicationGeneralFormDrops))
				return HKMedicationGeneralForm.Drops;
			if (constant.IsEqualTo (HKMedicationGeneralFormFoam))
				return HKMedicationGeneralForm.Foam;
			if (constant.IsEqualTo (HKMedicationGeneralFormGel))
				return HKMedicationGeneralForm.Gel;
			if (constant.IsEqualTo (HKMedicationGeneralFormInhaler))
				return HKMedicationGeneralForm.Inhaler;
			if (constant.IsEqualTo (HKMedicationGeneralFormInjection))
				return HKMedicationGeneralForm.Injection;
			if (constant.IsEqualTo (HKMedicationGeneralFormLiquid))
				return HKMedicationGeneralForm.Liquid;
			if (constant.IsEqualTo (HKMedicationGeneralFormLotion))
				return HKMedicationGeneralForm.Lotion;
			if (constant.IsEqualTo (HKMedicationGeneralFormOintment))
				return HKMedicationGeneralForm.Ointment;
			if (constant.IsEqualTo (HKMedicationGeneralFormPatch))
				return HKMedicationGeneralForm.Patch;
			if (constant.IsEqualTo (HKMedicationGeneralFormPowder))
				return HKMedicationGeneralForm.Powder;
			if (constant.IsEqualTo (HKMedicationGeneralFormSpray))
				return HKMedicationGeneralForm.Spray;
			if (constant.IsEqualTo (HKMedicationGeneralFormSuppository))
				return HKMedicationGeneralForm.Suppository;
			if (constant.IsEqualTo (HKMedicationGeneralFormTablet))
				return HKMedicationGeneralForm.Tablet;
			if (constant.IsEqualTo (HKMedicationGeneralFormTopical))
				return HKMedicationGeneralForm.Topical;
			if (constant.IsEqualTo (HKMedicationGeneralFormUnknown))
				return HKMedicationGeneralForm.Unknown;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKMedicationGeneralForm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKMedicationGeneralForm GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::HealthKit.HKMedicationGeneralForm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static HKMedicationGeneralForm? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::HealthKit.HKMedicationGeneralForm" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this HKMedicationGeneralForm[]? values)
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
		internal static HKMedicationGeneralForm[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<HKMedicationGeneralForm> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
