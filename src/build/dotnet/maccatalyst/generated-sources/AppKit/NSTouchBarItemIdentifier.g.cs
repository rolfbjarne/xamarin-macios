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
namespace AppKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSTouchBarItemIdentifier : int {
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		FixedSpaceSmall = 0,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		FixedSpaceLarge = 1,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		FlexibleSpace = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		OtherItemsProxy = 3,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		CharacterPicker = 4,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TextColorPicker = 5,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TextStyle = 6,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TextAlignment = 7,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TextList = 8,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TextFormat = 9,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		CandidateList = 10,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSTouchBarItemIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSTouchBarItemIdentifierExtensions {
		static IntPtr[] values = new IntPtr [4];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSTouchBarItemIdentifierFixedSpaceSmall", "AppKit")]
		internal unsafe static IntPtr NSTouchBarItemIdentifierFixedSpaceSmall {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFixedSpaceSmall", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSTouchBarItemIdentifierFixedSpaceLarge", "AppKit")]
		internal unsafe static IntPtr NSTouchBarItemIdentifierFixedSpaceLarge {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFixedSpaceLarge", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSTouchBarItemIdentifierFlexibleSpace", "AppKit")]
		internal unsafe static IntPtr NSTouchBarItemIdentifierFlexibleSpace {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFlexibleSpace", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSTouchBarItemIdentifierOtherItemsProxy", "AppKit")]
		internal unsafe static IntPtr NSTouchBarItemIdentifierOtherItemsProxy {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTouchBarItemIdentifierOtherItemsProxy", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSTouchBarItemIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSTouchBarItemIdentifier.FixedSpaceSmall
				ptr = NSTouchBarItemIdentifierFixedSpaceSmall;
				break;
			case 1: // NSTouchBarItemIdentifier.FixedSpaceLarge
				ptr = NSTouchBarItemIdentifierFixedSpaceLarge;
				break;
			case 2: // NSTouchBarItemIdentifier.FlexibleSpace
				ptr = NSTouchBarItemIdentifierFlexibleSpace;
				break;
			case 3: // NSTouchBarItemIdentifier.OtherItemsProxy
				ptr = NSTouchBarItemIdentifierOtherItemsProxy;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTouchBarItemIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSTouchBarItemIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSTouchBarItemIdentifierFixedSpaceSmall))
				return NSTouchBarItemIdentifier.FixedSpaceSmall;
			if (constant.IsEqualTo (NSTouchBarItemIdentifierFixedSpaceLarge))
				return NSTouchBarItemIdentifier.FixedSpaceLarge;
			if (constant.IsEqualTo (NSTouchBarItemIdentifierFlexibleSpace))
				return NSTouchBarItemIdentifier.FlexibleSpace;
			if (constant.IsEqualTo (NSTouchBarItemIdentifierOtherItemsProxy))
				return NSTouchBarItemIdentifier.OtherItemsProxy;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTouchBarItemIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTouchBarItemIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTouchBarItemIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTouchBarItemIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSTouchBarItemIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSTouchBarItemIdentifier[]? values)
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
		internal static NSTouchBarItemIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSTouchBarItemIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
