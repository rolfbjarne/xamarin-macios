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
namespace ImageKit {
	public enum IKToolMode : int {
		/// <summary>To be added.</summary>
		Annotate = 0,
		/// <summary>To be added.</summary>
		Crop = 1,
		/// <summary>To be added.</summary>
		Move = 2,
		/// <summary>To be added.</summary>
		None = 3,
		/// <summary>To be added.</summary>
		Rotate = 4,
		/// <summary>To be added.</summary>
		Select = 5,
		/// <summary>To be added.</summary>
		SelectEllipse = 6,
		/// <summary>To be added.</summary>
		SelectLasso = 7,
		/// <summary>To be added.</summary>
		SelectRect = 8,
	}
	/// <summary>Extension methods for the <see cref="global::ImageKit.IKToolMode" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class IKToolModeExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("IKToolModeAnnotate", "ImageKit")]
		internal unsafe static IntPtr IKToolModeAnnotate {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeAnnotate", storage);
			}
		}
		[Field ("IKToolModeCrop", "ImageKit")]
		internal unsafe static IntPtr IKToolModeCrop {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeCrop", storage);
			}
		}
		[Field ("IKToolModeMove", "ImageKit")]
		internal unsafe static IntPtr IKToolModeMove {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeMove", storage);
			}
		}
		[Field ("IKToolModeNone", "ImageKit")]
		internal unsafe static IntPtr IKToolModeNone {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeNone", storage);
			}
		}
		[Field ("IKToolModeRotate", "ImageKit")]
		internal unsafe static IntPtr IKToolModeRotate {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeRotate", storage);
			}
		}
		[Field ("IKToolModeSelect", "ImageKit")]
		internal unsafe static IntPtr IKToolModeSelect {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeSelect", storage);
			}
		}
		[Field ("IKToolModeSelectEllipse", "ImageKit")]
		internal unsafe static IntPtr IKToolModeSelectEllipse {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeSelectEllipse", storage);
			}
		}
		[Field ("IKToolModeSelectLasso", "ImageKit")]
		internal unsafe static IntPtr IKToolModeSelectLasso {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeSelectLasso", storage);
			}
		}
		[Field ("IKToolModeSelectRect", "ImageKit")]
		internal unsafe static IntPtr IKToolModeSelectRect {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.ImageKit.Handle, "IKToolModeSelectRect", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this IKToolMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // IKToolMode.Annotate
				ptr = IKToolModeAnnotate;
				break;
			case 1: // IKToolMode.Crop
				ptr = IKToolModeCrop;
				break;
			case 2: // IKToolMode.Move
				ptr = IKToolModeMove;
				break;
			case 3: // IKToolMode.None
				ptr = IKToolModeNone;
				break;
			case 4: // IKToolMode.Rotate
				ptr = IKToolModeRotate;
				break;
			case 5: // IKToolMode.Select
				ptr = IKToolModeSelect;
				break;
			case 6: // IKToolMode.SelectEllipse
				ptr = IKToolModeSelectEllipse;
				break;
			case 7: // IKToolMode.SelectLasso
				ptr = IKToolModeSelectLasso;
				break;
			case 8: // IKToolMode.SelectRect
				ptr = IKToolModeSelectRect;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ImageKit.IKToolMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static IKToolMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (IKToolModeAnnotate))
				return IKToolMode.Annotate;
			if (constant.IsEqualTo (IKToolModeCrop))
				return IKToolMode.Crop;
			if (constant.IsEqualTo (IKToolModeMove))
				return IKToolMode.Move;
			if (constant.IsEqualTo (IKToolModeNone))
				return IKToolMode.None;
			if (constant.IsEqualTo (IKToolModeRotate))
				return IKToolMode.Rotate;
			if (constant.IsEqualTo (IKToolModeSelect))
				return IKToolMode.Select;
			if (constant.IsEqualTo (IKToolModeSelectEllipse))
				return IKToolMode.SelectEllipse;
			if (constant.IsEqualTo (IKToolModeSelectLasso))
				return IKToolMode.SelectLasso;
			if (constant.IsEqualTo (IKToolModeSelectRect))
				return IKToolMode.SelectRect;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ImageKit.IKToolMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static IKToolMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ImageKit.IKToolMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static IKToolMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ImageKit.IKToolMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this IKToolMode[]? values)
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
		internal static IKToolMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<IKToolMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
