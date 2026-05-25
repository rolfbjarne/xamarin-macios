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
namespace CoreAnimation {
	public enum CATextLayerTruncationMode : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Start = 1,
		/// <summary>To be added.</summary>
		Middle = 2,
		/// <summary>To be added.</summary>
		End = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CATextLayerTruncationMode" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CATextLayerTruncationModeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kCATruncationNone", "CoreAnimation")]
		internal unsafe static IntPtr kCATruncationNone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCATruncationNone", storage);
			}
		}
		[Field ("kCATruncationStart", "CoreAnimation")]
		internal unsafe static IntPtr kCATruncationStart {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCATruncationStart", storage);
			}
		}
		[Field ("kCATruncationMiddle", "CoreAnimation")]
		internal unsafe static IntPtr kCATruncationMiddle {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCATruncationMiddle", storage);
			}
		}
		[Field ("kCATruncationEnd", "CoreAnimation")]
		internal unsafe static IntPtr kCATruncationEnd {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCATruncationEnd", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CATextLayerTruncationMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CATextLayerTruncationMode.None
				ptr = kCATruncationNone;
				break;
			case 1: // CATextLayerTruncationMode.Start
				ptr = kCATruncationStart;
				break;
			case 2: // CATextLayerTruncationMode.Middle
				ptr = kCATruncationMiddle;
				break;
			case 3: // CATextLayerTruncationMode.End
				ptr = kCATruncationEnd;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerTruncationMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CATextLayerTruncationMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCATruncationNone))
				return CATextLayerTruncationMode.None;
			if (constant.IsEqualTo (kCATruncationStart))
				return CATextLayerTruncationMode.Start;
			if (constant.IsEqualTo (kCATruncationMiddle))
				return CATextLayerTruncationMode.Middle;
			if (constant.IsEqualTo (kCATruncationEnd))
				return CATextLayerTruncationMode.End;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerTruncationMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CATextLayerTruncationMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CATextLayerTruncationMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CATextLayerTruncationMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CATextLayerTruncationMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CATextLayerTruncationMode[]? values)
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
		internal static CATextLayerTruncationMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CATextLayerTruncationMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
