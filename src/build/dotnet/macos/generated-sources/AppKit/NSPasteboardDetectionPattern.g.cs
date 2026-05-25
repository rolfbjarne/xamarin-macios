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
namespace AppKit {
	[SupportedOSPlatform ("macos15.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public enum NSPasteboardDetectionPattern : int {
		ProbableWebUrl = 0,
		ProbableWebSearch = 1,
		Number = 2,
		Link = 3,
		PhoneNumber = 4,
		EmailAddress = 5,
		PostalAddress = 6,
		CalendarEvent = 7,
		ShipmentTrackingNumber = 8,
		FlightNumber = 9,
		MoneyAmount = 10,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSPasteboardDetectionPattern" /> enumeration.</summary>
	[SupportedOSPlatform ("macos15.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSPasteboardDetectionPatternExtensions {
		static IntPtr[] values = new IntPtr [11];
		[Field ("NSPasteboardDetectionPatternProbableWebURL", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternProbableWebURL {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternProbableWebURL", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternProbableWebSearch", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternProbableWebSearch {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternProbableWebSearch", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternNumber", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternNumber {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternNumber", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternLink", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternLink {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternLink", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternPhoneNumber", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternPhoneNumber {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternPhoneNumber", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternEmailAddress", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternEmailAddress {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternEmailAddress", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternPostalAddress", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternPostalAddress {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternPostalAddress", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternCalendarEvent", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternCalendarEvent {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternCalendarEvent", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternShipmentTrackingNumber", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternShipmentTrackingNumber {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternShipmentTrackingNumber", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternFlightNumber", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternFlightNumber {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternFlightNumber", storage);
			}
		}
		[Field ("NSPasteboardDetectionPatternMoneyAmount", "AppKit")]
		internal unsafe static IntPtr NSPasteboardDetectionPatternMoneyAmount {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardDetectionPatternMoneyAmount", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSPasteboardDetectionPattern self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSPasteboardDetectionPattern.ProbableWebUrl
				ptr = NSPasteboardDetectionPatternProbableWebURL;
				break;
			case 1: // NSPasteboardDetectionPattern.ProbableWebSearch
				ptr = NSPasteboardDetectionPatternProbableWebSearch;
				break;
			case 2: // NSPasteboardDetectionPattern.Number
				ptr = NSPasteboardDetectionPatternNumber;
				break;
			case 3: // NSPasteboardDetectionPattern.Link
				ptr = NSPasteboardDetectionPatternLink;
				break;
			case 4: // NSPasteboardDetectionPattern.PhoneNumber
				ptr = NSPasteboardDetectionPatternPhoneNumber;
				break;
			case 5: // NSPasteboardDetectionPattern.EmailAddress
				ptr = NSPasteboardDetectionPatternEmailAddress;
				break;
			case 6: // NSPasteboardDetectionPattern.PostalAddress
				ptr = NSPasteboardDetectionPatternPostalAddress;
				break;
			case 7: // NSPasteboardDetectionPattern.CalendarEvent
				ptr = NSPasteboardDetectionPatternCalendarEvent;
				break;
			case 8: // NSPasteboardDetectionPattern.ShipmentTrackingNumber
				ptr = NSPasteboardDetectionPatternShipmentTrackingNumber;
				break;
			case 9: // NSPasteboardDetectionPattern.FlightNumber
				ptr = NSPasteboardDetectionPatternFlightNumber;
				break;
			case 10: // NSPasteboardDetectionPattern.MoneyAmount
				ptr = NSPasteboardDetectionPatternMoneyAmount;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardDetectionPattern" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSPasteboardDetectionPattern GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSPasteboardDetectionPatternProbableWebURL))
				return NSPasteboardDetectionPattern.ProbableWebUrl;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternProbableWebSearch))
				return NSPasteboardDetectionPattern.ProbableWebSearch;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternNumber))
				return NSPasteboardDetectionPattern.Number;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternLink))
				return NSPasteboardDetectionPattern.Link;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternPhoneNumber))
				return NSPasteboardDetectionPattern.PhoneNumber;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternEmailAddress))
				return NSPasteboardDetectionPattern.EmailAddress;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternPostalAddress))
				return NSPasteboardDetectionPattern.PostalAddress;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternCalendarEvent))
				return NSPasteboardDetectionPattern.CalendarEvent;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternShipmentTrackingNumber))
				return NSPasteboardDetectionPattern.ShipmentTrackingNumber;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternFlightNumber))
				return NSPasteboardDetectionPattern.FlightNumber;
			if (constant.IsEqualTo (NSPasteboardDetectionPatternMoneyAmount))
				return NSPasteboardDetectionPattern.MoneyAmount;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardDetectionPattern" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardDetectionPattern GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardDetectionPattern" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardDetectionPattern? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSPasteboardDetectionPattern" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSPasteboardDetectionPattern[]? values)
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
		internal static NSPasteboardDetectionPattern[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSPasteboardDetectionPattern> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
