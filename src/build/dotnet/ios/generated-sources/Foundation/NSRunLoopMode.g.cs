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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>Run loop modes for <see cref="T:Foundation.NSRunLoop" />.</summary>
	public enum NSRunLoopMode : int {
		/// <summary>The default mode to handle input sources.   The most common run loop mode.</summary>
		Default = 0,
		/// <summary>Run loop mode constant used to run handlers in any of the declared “common” modes.</summary>
		Common = 1,
		/// <summary>The NSRunLoop mode used when tracking controls. Use this to receive timers and events during UI tracking.</summary>
		UITracking = 100,
		/// <summary>To be added.</summary>
		Other = 1000,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSRunLoopMode" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSRunLoopModeExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("NSDefaultRunLoopMode", "Foundation")]
		internal unsafe static IntPtr NSDefaultRunLoopMode {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSDefaultRunLoopMode", storage);
			}
		}
		[Field ("NSRunLoopCommonModes", "Foundation")]
		internal unsafe static IntPtr NSRunLoopCommonModes {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSRunLoopCommonModes", storage);
			}
		}
		[Field ("UITrackingRunLoopMode", "UIKit")]
		internal unsafe static IntPtr UITrackingRunLoopMode {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITrackingRunLoopMode", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSRunLoopMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSRunLoopMode.Default
			default:
				ptr = NSDefaultRunLoopMode;
				break;
			case 1: // NSRunLoopMode.Common
				ptr = NSRunLoopCommonModes;
				break;
			case 100: // NSRunLoopMode.UITracking
				ptr = UITrackingRunLoopMode;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSRunLoopMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSRunLoopMode GetValue (NSString? constant)
		{
			if (constant is null)
				return NSRunLoopMode.Other;
			if (constant.IsEqualTo (NSDefaultRunLoopMode))
				return NSRunLoopMode.Default;
			if (constant.IsEqualTo (NSRunLoopCommonModes))
				return NSRunLoopMode.Common;
			if (constant.IsEqualTo (UITrackingRunLoopMode))
				return NSRunLoopMode.UITracking;
			return NSRunLoopMode.Default;
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSRunLoopMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSRunLoopMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSRunLoopMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSRunLoopMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSRunLoopMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSRunLoopMode[]? values)
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
		internal static NSRunLoopMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSRunLoopMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
