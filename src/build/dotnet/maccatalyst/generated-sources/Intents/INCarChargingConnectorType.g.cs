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
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum INCarChargingConnectorType : int {
		None = 0,
		J1772 = 1,
		Ccs1 = 2,
		Ccs2 = 3,
		ChaDeMo = 4,
		Gbtac = 5,
		Gbtdc = 6,
		[ObsoletedOSPlatform ("ios17.4", "Use 'INCarChargingConnectorType.NacsDc' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use 'INCarChargingConnectorType.NacsDc' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		Tesla = 7,
		Mennekes = 8,
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		NacsDC = 9,
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		NacsAC = 10,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INCarChargingConnectorType" /> enumeration.</summary>
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INCarChargingConnectorTypeExtensions {
		static IntPtr[] values = new IntPtr [10];
		[Field ("INCarChargingConnectorTypeJ1772", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeJ1772 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeJ1772", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeCCS1", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeCCS1 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeCCS1", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeCCS2", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeCCS2 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeCCS2", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeCHAdeMO", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeCHAdeMO {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeCHAdeMO", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeGBTAC", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeGBTAC {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeGBTAC", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeGBTDC", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeGBTDC {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeGBTDC", storage);
			}
		}
		[ObsoletedOSPlatform ("ios17.4", "Use 'INCarChargingConnectorType.NacsDc' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use 'INCarChargingConnectorType.NacsDc' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("INCarChargingConnectorTypeTesla", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeTesla {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeTesla", storage);
			}
		}
		[Field ("INCarChargingConnectorTypeMennekes", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeMennekes {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeMennekes", storage);
			}
		}
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("INCarChargingConnectorTypeNACSDC", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeNACSDC {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeNACSDC", storage);
			}
		}
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("INCarChargingConnectorTypeNACSAC", "Intents")]
		internal unsafe static IntPtr INCarChargingConnectorTypeNACSAC {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INCarChargingConnectorTypeNACSAC", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INCarChargingConnectorType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // INCarChargingConnectorType.J1772
				ptr = INCarChargingConnectorTypeJ1772;
				break;
			case 2: // INCarChargingConnectorType.Ccs1
				ptr = INCarChargingConnectorTypeCCS1;
				break;
			case 3: // INCarChargingConnectorType.Ccs2
				ptr = INCarChargingConnectorTypeCCS2;
				break;
			case 4: // INCarChargingConnectorType.ChaDeMo
				ptr = INCarChargingConnectorTypeCHAdeMO;
				break;
			case 5: // INCarChargingConnectorType.Gbtac
				ptr = INCarChargingConnectorTypeGBTAC;
				break;
			case 6: // INCarChargingConnectorType.Gbtdc
				ptr = INCarChargingConnectorTypeGBTDC;
				break;
			case 7: // INCarChargingConnectorType.Tesla
				ptr = INCarChargingConnectorTypeTesla;
				break;
			case 8: // INCarChargingConnectorType.Mennekes
				ptr = INCarChargingConnectorTypeMennekes;
				break;
			case 9: // INCarChargingConnectorType.NacsDC
				ptr = INCarChargingConnectorTypeNACSDC;
				break;
			case 10: // INCarChargingConnectorType.NacsAC
				ptr = INCarChargingConnectorTypeNACSAC;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INCarChargingConnectorType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static INCarChargingConnectorType GetValue (NSString? constant)
		{
			if (constant is null)
				return INCarChargingConnectorType.None;
			if (constant.IsEqualTo (INCarChargingConnectorTypeJ1772))
				return INCarChargingConnectorType.J1772;
			if (constant.IsEqualTo (INCarChargingConnectorTypeCCS1))
				return INCarChargingConnectorType.Ccs1;
			if (constant.IsEqualTo (INCarChargingConnectorTypeCCS2))
				return INCarChargingConnectorType.Ccs2;
			if (constant.IsEqualTo (INCarChargingConnectorTypeCHAdeMO))
				return INCarChargingConnectorType.ChaDeMo;
			if (constant.IsEqualTo (INCarChargingConnectorTypeGBTAC))
				return INCarChargingConnectorType.Gbtac;
			if (constant.IsEqualTo (INCarChargingConnectorTypeGBTDC))
				return INCarChargingConnectorType.Gbtdc;
			if (constant.IsEqualTo (INCarChargingConnectorTypeTesla))
				return INCarChargingConnectorType.Tesla;
			if (constant.IsEqualTo (INCarChargingConnectorTypeMennekes))
				return INCarChargingConnectorType.Mennekes;
			if (constant.IsEqualTo (INCarChargingConnectorTypeNACSDC))
				return INCarChargingConnectorType.NacsDC;
			if (constant.IsEqualTo (INCarChargingConnectorTypeNACSAC))
				return INCarChargingConnectorType.NacsAC;
			return INCarChargingConnectorType.None;
		}
		/// <summary>Retrieves the <see cref="global::Intents.INCarChargingConnectorType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INCarChargingConnectorType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INCarChargingConnectorType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INCarChargingConnectorType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Intents.INCarChargingConnectorType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this INCarChargingConnectorType[]? values)
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
		internal static INCarChargingConnectorType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<INCarChargingConnectorType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
