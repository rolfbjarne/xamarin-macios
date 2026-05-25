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
namespace CoreAnimation {
	public enum CATextLayerAlignmentMode : int {
		/// <summary>To be added.</summary>
		Left = 0,
		/// <summary>To be added.</summary>
		Right = 1,
		/// <summary>To be added.</summary>
		Center = 2,
		/// <summary>To be added.</summary>
		Justified = 3,
		/// <summary>To be added.</summary>
		Natural = 4,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CATextLayerAlignmentMode" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CATextLayerAlignmentModeExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("kCAAlignmentLeft", "CoreAnimation")]
		internal unsafe static IntPtr kCAAlignmentLeft {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAAlignmentLeft", storage);
			}
		}
		[Field ("kCAAlignmentRight", "CoreAnimation")]
		internal unsafe static IntPtr kCAAlignmentRight {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAAlignmentRight", storage);
			}
		}
		[Field ("kCAAlignmentCenter", "CoreAnimation")]
		internal unsafe static IntPtr kCAAlignmentCenter {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAAlignmentCenter", storage);
			}
		}
		[Field ("kCAAlignmentJustified", "CoreAnimation")]
		internal unsafe static IntPtr kCAAlignmentJustified {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAAlignmentJustified", storage);
			}
		}
		[Field ("kCAAlignmentNatural", "CoreAnimation")]
		internal unsafe static IntPtr kCAAlignmentNatural {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAAlignmentNatural", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CATextLayerAlignmentMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CATextLayerAlignmentMode.Left
				ptr = kCAAlignmentLeft;
				break;
			case 1: // CATextLayerAlignmentMode.Right
				ptr = kCAAlignmentRight;
				break;
			case 2: // CATextLayerAlignmentMode.Center
				ptr = kCAAlignmentCenter;
				break;
			case 3: // CATextLayerAlignmentMode.Justified
				ptr = kCAAlignmentJustified;
				break;
			case 4: // CATextLayerAlignmentMode.Natural
				ptr = kCAAlignmentNatural;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerAlignmentMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CATextLayerAlignmentMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCAAlignmentLeft))
				return CATextLayerAlignmentMode.Left;
			if (constant.IsEqualTo (kCAAlignmentRight))
				return CATextLayerAlignmentMode.Right;
			if (constant.IsEqualTo (kCAAlignmentCenter))
				return CATextLayerAlignmentMode.Center;
			if (constant.IsEqualTo (kCAAlignmentJustified))
				return CATextLayerAlignmentMode.Justified;
			if (constant.IsEqualTo (kCAAlignmentNatural))
				return CATextLayerAlignmentMode.Natural;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerAlignmentMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CATextLayerAlignmentMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerAlignmentMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CATextLayerAlignmentMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CATextLayerAlignmentMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CATextLayerAlignmentMode[]? values)
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
		internal static CATextLayerAlignmentMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CATextLayerAlignmentMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
