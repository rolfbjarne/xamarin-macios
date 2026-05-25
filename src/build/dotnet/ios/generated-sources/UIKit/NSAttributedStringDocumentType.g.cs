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
	public enum NSAttributedStringDocumentType : int {
		Unknown = -1,
		Plain = 0,
		Rtfd = 2,
		Rtf = 1,
		Html = 3,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		MacSimple = 4,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		DocFormat = 5,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		WordML = 6,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		WebArchive = 8,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		OfficeOpenXml = 7,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		OpenDocument = 9,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.NSAttributedStringDocumentType" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSAttributedStringDocumentTypeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("NSPlainTextDocumentType", "UIKit")]
		internal unsafe static IntPtr NSPlainTextDocumentType {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSPlainTextDocumentType", storage);
			}
		}
		[Field ("NSRTFDTextDocumentType", "UIKit")]
		internal unsafe static IntPtr NSRTFDTextDocumentType {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSRTFDTextDocumentType", storage);
			}
		}
		[Field ("NSRTFTextDocumentType", "UIKit")]
		internal unsafe static IntPtr NSRTFTextDocumentType {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSRTFTextDocumentType", storage);
			}
		}
		[Field ("NSHTMLTextDocumentType", "UIKit")]
		internal unsafe static IntPtr NSHTMLTextDocumentType {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSHTMLTextDocumentType", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSAttributedStringDocumentType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSAttributedStringDocumentType.Plain
				ptr = NSPlainTextDocumentType;
				break;
			case 2: // NSAttributedStringDocumentType.Rtfd
				ptr = NSRTFDTextDocumentType;
				break;
			case 1: // NSAttributedStringDocumentType.Rtf
				ptr = NSRTFTextDocumentType;
				break;
			case 3: // NSAttributedStringDocumentType.Html
				ptr = NSHTMLTextDocumentType;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSAttributedStringDocumentType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSAttributedStringDocumentType GetValue (NSString? constant)
		{
			if (constant is null)
				return NSAttributedStringDocumentType.Unknown;
			if (constant.IsEqualTo (NSPlainTextDocumentType))
				return NSAttributedStringDocumentType.Plain;
			if (constant.IsEqualTo (NSRTFDTextDocumentType))
				return NSAttributedStringDocumentType.Rtfd;
			if (constant.IsEqualTo (NSRTFTextDocumentType))
				return NSAttributedStringDocumentType.Rtf;
			if (constant.IsEqualTo (NSHTMLTextDocumentType))
				return NSAttributedStringDocumentType.Html;
			return NSAttributedStringDocumentType.Unknown;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSAttributedStringDocumentType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSAttributedStringDocumentType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSAttributedStringDocumentType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSAttributedStringDocumentType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.NSAttributedStringDocumentType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSAttributedStringDocumentType[]? values)
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
		internal static NSAttributedStringDocumentType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSAttributedStringDocumentType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
