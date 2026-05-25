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
namespace UIKit {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
	public enum UIPasteboardDetectionPattern : int {
		ProbableWebUrl = 0,
		ProbableWebSearch = 1,
		Number = 2,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		Link = 3,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		PhoneNumber = 4,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		EmailAddress = 5,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		PostalAddress = 6,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		CalendarEvent = 7,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		ShipmentTrackingNumber = 8,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		FlightNumber = 9,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		MoneyAmount = 10,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIPasteboardDetectionPattern" /> enumeration.</summary>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIPasteboardDetectionPatternExtensions {
		static IntPtr[] values = new IntPtr [11];
		[Field ("UIPasteboardDetectionPatternProbableWebURL", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternProbableWebURL {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternProbableWebURL", storage);
			}
		}
		[Field ("UIPasteboardDetectionPatternProbableWebSearch", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternProbableWebSearch {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternProbableWebSearch", storage);
			}
		}
		[Field ("UIPasteboardDetectionPatternNumber", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternNumber {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternNumber", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternLink", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternLink {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternLink", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternPhoneNumber", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternPhoneNumber {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternPhoneNumber", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternEmailAddress", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternEmailAddress {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternEmailAddress", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternPostalAddress", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternPostalAddress {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternPostalAddress", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternCalendarEvent", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternCalendarEvent {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternCalendarEvent", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternShipmentTrackingNumber", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternShipmentTrackingNumber {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternShipmentTrackingNumber", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternFlightNumber", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternFlightNumber {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternFlightNumber", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst17.4", "This API has been removed from the framework.")]
		[Field ("UIPasteboardDetectionPatternMoneyAmount", "UIKit")]
		internal unsafe static IntPtr UIPasteboardDetectionPatternMoneyAmount {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIPasteboardDetectionPatternMoneyAmount", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIPasteboardDetectionPattern self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIPasteboardDetectionPattern.ProbableWebUrl
				ptr = UIPasteboardDetectionPatternProbableWebURL;
				break;
			case 1: // UIPasteboardDetectionPattern.ProbableWebSearch
				ptr = UIPasteboardDetectionPatternProbableWebSearch;
				break;
			case 2: // UIPasteboardDetectionPattern.Number
				ptr = UIPasteboardDetectionPatternNumber;
				break;
			case 3: // UIPasteboardDetectionPattern.Link
				ptr = UIPasteboardDetectionPatternLink;
				break;
			case 4: // UIPasteboardDetectionPattern.PhoneNumber
				ptr = UIPasteboardDetectionPatternPhoneNumber;
				break;
			case 5: // UIPasteboardDetectionPattern.EmailAddress
				ptr = UIPasteboardDetectionPatternEmailAddress;
				break;
			case 6: // UIPasteboardDetectionPattern.PostalAddress
				ptr = UIPasteboardDetectionPatternPostalAddress;
				break;
			case 7: // UIPasteboardDetectionPattern.CalendarEvent
				ptr = UIPasteboardDetectionPatternCalendarEvent;
				break;
			case 8: // UIPasteboardDetectionPattern.ShipmentTrackingNumber
				ptr = UIPasteboardDetectionPatternShipmentTrackingNumber;
				break;
			case 9: // UIPasteboardDetectionPattern.FlightNumber
				ptr = UIPasteboardDetectionPatternFlightNumber;
				break;
			case 10: // UIPasteboardDetectionPattern.MoneyAmount
				ptr = UIPasteboardDetectionPatternMoneyAmount;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIPasteboardDetectionPattern" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIPasteboardDetectionPattern GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIPasteboardDetectionPatternProbableWebURL))
				return UIPasteboardDetectionPattern.ProbableWebUrl;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternProbableWebSearch))
				return UIPasteboardDetectionPattern.ProbableWebSearch;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternNumber))
				return UIPasteboardDetectionPattern.Number;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternLink))
				return UIPasteboardDetectionPattern.Link;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternPhoneNumber))
				return UIPasteboardDetectionPattern.PhoneNumber;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternEmailAddress))
				return UIPasteboardDetectionPattern.EmailAddress;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternPostalAddress))
				return UIPasteboardDetectionPattern.PostalAddress;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternCalendarEvent))
				return UIPasteboardDetectionPattern.CalendarEvent;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternShipmentTrackingNumber))
				return UIPasteboardDetectionPattern.ShipmentTrackingNumber;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternFlightNumber))
				return UIPasteboardDetectionPattern.FlightNumber;
			if (constant.IsEqualTo (UIPasteboardDetectionPatternMoneyAmount))
				return UIPasteboardDetectionPattern.MoneyAmount;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIPasteboardDetectionPattern" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIPasteboardDetectionPattern GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIPasteboardDetectionPattern" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIPasteboardDetectionPattern? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIPasteboardDetectionPattern" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIPasteboardDetectionPattern[]? values)
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
		internal static UIPasteboardDetectionPattern[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIPasteboardDetectionPattern> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
