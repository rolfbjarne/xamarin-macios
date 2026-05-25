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
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIActivityItemsConfigurationPreviewIntent : int {
		FullSize = 0,
		Thumbnail = 1,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIActivityItemsConfigurationPreviewIntent" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIActivityItemsConfigurationPreviewIntentExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("UIActivityItemsConfigurationPreviewIntentFullSize", "UIKit")]
		internal unsafe static IntPtr UIActivityItemsConfigurationPreviewIntentFullSize {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActivityItemsConfigurationPreviewIntentFullSize", storage);
			}
		}
		[Field ("UIActivityItemsConfigurationPreviewIntentThumbnail", "UIKit")]
		internal unsafe static IntPtr UIActivityItemsConfigurationPreviewIntentThumbnail {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActivityItemsConfigurationPreviewIntentThumbnail", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIActivityItemsConfigurationPreviewIntent self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIActivityItemsConfigurationPreviewIntent.FullSize
				ptr = UIActivityItemsConfigurationPreviewIntentFullSize;
				break;
			case 1: // UIActivityItemsConfigurationPreviewIntent.Thumbnail
				ptr = UIActivityItemsConfigurationPreviewIntentThumbnail;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActivityItemsConfigurationPreviewIntent" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIActivityItemsConfigurationPreviewIntent GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIActivityItemsConfigurationPreviewIntentFullSize))
				return UIActivityItemsConfigurationPreviewIntent.FullSize;
			if (constant.IsEqualTo (UIActivityItemsConfigurationPreviewIntentThumbnail))
				return UIActivityItemsConfigurationPreviewIntent.Thumbnail;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActivityItemsConfigurationPreviewIntent" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIActivityItemsConfigurationPreviewIntent GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActivityItemsConfigurationPreviewIntent" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIActivityItemsConfigurationPreviewIntent? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIActivityItemsConfigurationPreviewIntent" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIActivityItemsConfigurationPreviewIntent[]? values)
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
		internal static UIActivityItemsConfigurationPreviewIntent[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIActivityItemsConfigurationPreviewIntent> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
