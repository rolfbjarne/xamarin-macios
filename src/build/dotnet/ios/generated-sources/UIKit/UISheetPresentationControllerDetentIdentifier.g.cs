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
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UISheetPresentationControllerDetentIdentifier : int {
		Unknown = -1,
		Medium = 0,
		Large = 1,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UISheetPresentationControllerDetentIdentifier" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UISheetPresentationControllerDetentIdentifierExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("UISheetPresentationControllerDetentIdentifierMedium", "UIKit")]
		internal unsafe static IntPtr UISheetPresentationControllerDetentIdentifierMedium {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UISheetPresentationControllerDetentIdentifierMedium", storage);
			}
		}
		[Field ("UISheetPresentationControllerDetentIdentifierLarge", "UIKit")]
		internal unsafe static IntPtr UISheetPresentationControllerDetentIdentifierLarge {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UISheetPresentationControllerDetentIdentifierLarge", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UISheetPresentationControllerDetentIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UISheetPresentationControllerDetentIdentifier.Medium
				ptr = UISheetPresentationControllerDetentIdentifierMedium;
				break;
			case 1: // UISheetPresentationControllerDetentIdentifier.Large
				ptr = UISheetPresentationControllerDetentIdentifierLarge;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UISheetPresentationControllerDetentIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UISheetPresentationControllerDetentIdentifier GetValue (NSString? constant)
		{
			if (constant is null)
				return UISheetPresentationControllerDetentIdentifier.Unknown;
			if (constant.IsEqualTo (UISheetPresentationControllerDetentIdentifierMedium))
				return UISheetPresentationControllerDetentIdentifier.Medium;
			if (constant.IsEqualTo (UISheetPresentationControllerDetentIdentifierLarge))
				return UISheetPresentationControllerDetentIdentifier.Large;
			return UISheetPresentationControllerDetentIdentifier.Unknown;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UISheetPresentationControllerDetentIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UISheetPresentationControllerDetentIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UISheetPresentationControllerDetentIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UISheetPresentationControllerDetentIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UISheetPresentationControllerDetentIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UISheetPresentationControllerDetentIdentifier[]? values)
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
		internal static UISheetPresentationControllerDetentIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UISheetPresentationControllerDetentIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
