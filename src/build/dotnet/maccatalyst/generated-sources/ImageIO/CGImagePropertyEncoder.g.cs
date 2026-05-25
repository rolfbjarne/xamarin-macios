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
namespace ImageIO {
	public enum CGImagePropertyEncoder : int {
		AstcEncoder = 0,
		PvrEncoder = 1,
		BCEncoder = 2,
	}
	/// <summary>Extension methods for the <see cref="global::ImageIO.CGImagePropertyEncoder" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CGImagePropertyEncoderExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kCGImagePropertyASTCEncoder", "ImageIO")]
		internal unsafe static IntPtr kCGImagePropertyASTCEncoder {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImagePropertyASTCEncoder", storage);
			}
		}
		[Field ("kCGImagePropertyPVREncoder", "ImageIO")]
		internal unsafe static IntPtr kCGImagePropertyPVREncoder {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImagePropertyPVREncoder", storage);
			}
		}
		[Field ("kCGImagePropertyBCEncoder", "ImageIO")]
		internal unsafe static IntPtr kCGImagePropertyBCEncoder {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImagePropertyBCEncoder", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CGImagePropertyEncoder self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CGImagePropertyEncoder.AstcEncoder
				ptr = kCGImagePropertyASTCEncoder;
				break;
			case 1: // CGImagePropertyEncoder.PvrEncoder
				ptr = kCGImagePropertyPVREncoder;
				break;
			case 2: // CGImagePropertyEncoder.BCEncoder
				ptr = kCGImagePropertyBCEncoder;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyEncoder" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CGImagePropertyEncoder GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCGImagePropertyASTCEncoder))
				return CGImagePropertyEncoder.AstcEncoder;
			if (constant.IsEqualTo (kCGImagePropertyPVREncoder))
				return CGImagePropertyEncoder.PvrEncoder;
			if (constant.IsEqualTo (kCGImagePropertyBCEncoder))
				return CGImagePropertyEncoder.BCEncoder;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyEncoder" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImagePropertyEncoder GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyEncoder" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImagePropertyEncoder? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ImageIO.CGImagePropertyEncoder" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CGImagePropertyEncoder[]? values)
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
		internal static CGImagePropertyEncoder[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CGImagePropertyEncoder> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
