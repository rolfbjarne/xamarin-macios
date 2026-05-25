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
	/// <summary>Enumerates scrolling directions.</summary>
	public enum CAScroll : int {
		/// <summary>Neither vertical nor horizontal scrolling.</summary>
		None = 0,
		/// <summary>Vertical scrolling.</summary>
		Vertically = 1,
		/// <summary>Horizontal scrolling.</summary>
		Horizontally = 2,
		/// <summary>Both vertical and horizontal scrolling.</summary>
		Both = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CAScroll" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CAScrollExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kCAScrollNone", "CoreAnimation")]
		internal unsafe static IntPtr kCAScrollNone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAScrollNone", storage);
			}
		}
		[Field ("kCAScrollVertically", "CoreAnimation")]
		internal unsafe static IntPtr kCAScrollVertically {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAScrollVertically", storage);
			}
		}
		[Field ("kCAScrollHorizontally", "CoreAnimation")]
		internal unsafe static IntPtr kCAScrollHorizontally {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAScrollHorizontally", storage);
			}
		}
		[Field ("kCAScrollBoth", "CoreAnimation")]
		internal unsafe static IntPtr kCAScrollBoth {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAScrollBoth", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CAScroll self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CAScroll.None
				ptr = kCAScrollNone;
				break;
			case 1: // CAScroll.Vertically
				ptr = kCAScrollVertically;
				break;
			case 2: // CAScroll.Horizontally
				ptr = kCAScrollHorizontally;
				break;
			case 3: // CAScroll.Both
				ptr = kCAScrollBoth;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAScroll" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CAScroll GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCAScrollNone))
				return CAScroll.None;
			if (constant.IsEqualTo (kCAScrollVertically))
				return CAScroll.Vertically;
			if (constant.IsEqualTo (kCAScrollHorizontally))
				return CAScroll.Horizontally;
			if (constant.IsEqualTo (kCAScrollBoth))
				return CAScroll.Both;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAScroll" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAScroll GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAScroll" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAScroll? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CAScroll" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CAScroll[]? values)
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
		internal static CAScroll[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CAScroll> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
