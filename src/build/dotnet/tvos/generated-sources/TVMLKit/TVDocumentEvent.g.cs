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
namespace TVMLKit {
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos13.0")]
	public enum TVDocumentEvent : int {
		Play = 0,
		Select = 1,
		HoldSelect = 2,
		Highlight = 3,
		Load = 4,
		Unload = 5,
		Appear = 6,
		Disappear = 7,
	}
	/// <summary>Extension methods for the <see cref="global::TVMLKit.TVDocumentEvent" /> enumeration.</summary>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos13.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class TVDocumentEventExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("TVDocumentEventPlay", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventPlay {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventPlay", storage);
			}
		}
		[Field ("TVDocumentEventSelect", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventSelect {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventSelect", storage);
			}
		}
		[Field ("TVDocumentEventHoldSelect", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventHoldSelect {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventHoldSelect", storage);
			}
		}
		[Field ("TVDocumentEventHighlight", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventHighlight {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventHighlight", storage);
			}
		}
		[Field ("TVDocumentEventLoad", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventLoad {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventLoad", storage);
			}
		}
		[Field ("TVDocumentEventUnload", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventUnload {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventUnload", storage);
			}
		}
		[Field ("TVDocumentEventAppear", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventAppear {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventAppear", storage);
			}
		}
		[Field ("TVDocumentEventDisappear", "TVMLKit")]
		internal unsafe static IntPtr TVDocumentEventDisappear {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.TVMLKit.Handle, "TVDocumentEventDisappear", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this TVDocumentEvent self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // TVDocumentEvent.Play
				ptr = TVDocumentEventPlay;
				break;
			case 1: // TVDocumentEvent.Select
				ptr = TVDocumentEventSelect;
				break;
			case 2: // TVDocumentEvent.HoldSelect
				ptr = TVDocumentEventHoldSelect;
				break;
			case 3: // TVDocumentEvent.Highlight
				ptr = TVDocumentEventHighlight;
				break;
			case 4: // TVDocumentEvent.Load
				ptr = TVDocumentEventLoad;
				break;
			case 5: // TVDocumentEvent.Unload
				ptr = TVDocumentEventUnload;
				break;
			case 6: // TVDocumentEvent.Appear
				ptr = TVDocumentEventAppear;
				break;
			case 7: // TVDocumentEvent.Disappear
				ptr = TVDocumentEventDisappear;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVDocumentEvent" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static TVDocumentEvent GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (TVDocumentEventPlay))
				return TVDocumentEvent.Play;
			if (constant.IsEqualTo (TVDocumentEventSelect))
				return TVDocumentEvent.Select;
			if (constant.IsEqualTo (TVDocumentEventHoldSelect))
				return TVDocumentEvent.HoldSelect;
			if (constant.IsEqualTo (TVDocumentEventHighlight))
				return TVDocumentEvent.Highlight;
			if (constant.IsEqualTo (TVDocumentEventLoad))
				return TVDocumentEvent.Load;
			if (constant.IsEqualTo (TVDocumentEventUnload))
				return TVDocumentEvent.Unload;
			if (constant.IsEqualTo (TVDocumentEventAppear))
				return TVDocumentEvent.Appear;
			if (constant.IsEqualTo (TVDocumentEventDisappear))
				return TVDocumentEvent.Disappear;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVDocumentEvent" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static TVDocumentEvent GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::TVMLKit.TVDocumentEvent" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static TVDocumentEvent? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::TVMLKit.TVDocumentEvent" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this TVDocumentEvent[]? values)
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
		internal static TVDocumentEvent[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<TVDocumentEvent> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
