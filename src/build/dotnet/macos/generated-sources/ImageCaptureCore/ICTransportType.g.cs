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
namespace ImageCaptureCore {
	public enum ICTransportType : int {
		Usb = 0,
		FireWire = 1,
		Bluetooth = 2,
		TcpIp = 3,
		MassStorage = 4,
		/// <summary>Represents a proximity transport type for devices.</summary>
		[SupportedOSPlatform ("macos14.0")]
		Proximity = 5,
	}
	/// <summary>Extension methods for the <see cref="global::ImageCaptureCore.ICTransportType" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ICTransportTypeExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("ICTransportTypeUSB", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeUSB {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeUSB", storage);
			}
		}
		[Field ("ICTransportTypeFireWire", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeFireWire {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeFireWire", storage);
			}
		}
		[Field ("ICTransportTypeBluetooth", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeBluetooth {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeBluetooth", storage);
			}
		}
		[Field ("ICTransportTypeTCPIP", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeTCPIP {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeTCPIP", storage);
			}
		}
		[Field ("ICTransportTypeMassStorage", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeMassStorage {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeMassStorage", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[Field ("ICTransportTypeProximity", "ImageCaptureCore")]
		internal unsafe static IntPtr ICTransportTypeProximity {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ImageCaptureCore.Handle, "ICTransportTypeProximity", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ICTransportType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ICTransportType.Usb
				ptr = ICTransportTypeUSB;
				break;
			case 1: // ICTransportType.FireWire
				ptr = ICTransportTypeFireWire;
				break;
			case 2: // ICTransportType.Bluetooth
				ptr = ICTransportTypeBluetooth;
				break;
			case 3: // ICTransportType.TcpIp
				ptr = ICTransportTypeTCPIP;
				break;
			case 4: // ICTransportType.MassStorage
				ptr = ICTransportTypeMassStorage;
				break;
			case 5: // ICTransportType.Proximity
				ptr = ICTransportTypeProximity;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ImageCaptureCore.ICTransportType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ICTransportType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ICTransportTypeUSB))
				return ICTransportType.Usb;
			if (constant.IsEqualTo (ICTransportTypeFireWire))
				return ICTransportType.FireWire;
			if (constant.IsEqualTo (ICTransportTypeBluetooth))
				return ICTransportType.Bluetooth;
			if (constant.IsEqualTo (ICTransportTypeTCPIP))
				return ICTransportType.TcpIp;
			if (constant.IsEqualTo (ICTransportTypeMassStorage))
				return ICTransportType.MassStorage;
			if (constant.IsEqualTo (ICTransportTypeProximity))
				return ICTransportType.Proximity;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ImageCaptureCore.ICTransportType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ICTransportType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ImageCaptureCore.ICTransportType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ICTransportType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ImageCaptureCore.ICTransportType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ICTransportType[]? values)
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
		internal static ICTransportType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ICTransportType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
