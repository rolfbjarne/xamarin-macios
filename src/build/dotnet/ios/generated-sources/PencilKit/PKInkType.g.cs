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
namespace PencilKit {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum PKInkType : int {
		Pen = 0,
		Pencil = 1,
		Marker = 2,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		Monoline = 3,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		FountainPen = 4,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		Watercolor = 5,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		Crayon = 6,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		Reed = 7,
	}
	/// <summary>Extension methods for the <see cref="global::PencilKit.PKInkType" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PKInkTypeExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("PKInkTypePen", "PencilKit")]
		internal unsafe static IntPtr PKInkTypePen {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypePen", storage);
			}
		}
		[Field ("PKInkTypePencil", "PencilKit")]
		internal unsafe static IntPtr PKInkTypePencil {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypePencil", storage);
			}
		}
		[Field ("PKInkTypeMarker", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeMarker {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeMarker", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("PKInkTypeMonoline", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeMonoline {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeMonoline", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("PKInkTypeFountainPen", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeFountainPen {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeFountainPen", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("PKInkTypeWatercolor", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeWatercolor {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeWatercolor", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("PKInkTypeCrayon", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeCrayon {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeCrayon", storage);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("PKInkTypeReed", "PencilKit")]
		internal unsafe static IntPtr PKInkTypeReed {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.PencilKit.Handle, "PKInkTypeReed", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PKInkType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PKInkType.Pen
				ptr = PKInkTypePen;
				break;
			case 1: // PKInkType.Pencil
				ptr = PKInkTypePencil;
				break;
			case 2: // PKInkType.Marker
				ptr = PKInkTypeMarker;
				break;
			case 3: // PKInkType.Monoline
				ptr = PKInkTypeMonoline;
				break;
			case 4: // PKInkType.FountainPen
				ptr = PKInkTypeFountainPen;
				break;
			case 5: // PKInkType.Watercolor
				ptr = PKInkTypeWatercolor;
				break;
			case 6: // PKInkType.Crayon
				ptr = PKInkTypeCrayon;
				break;
			case 7: // PKInkType.Reed
				ptr = PKInkTypeReed;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PencilKit.PKInkType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PKInkType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PKInkTypePen))
				return PKInkType.Pen;
			if (constant.IsEqualTo (PKInkTypePencil))
				return PKInkType.Pencil;
			if (constant.IsEqualTo (PKInkTypeMarker))
				return PKInkType.Marker;
			if (constant.IsEqualTo (PKInkTypeMonoline))
				return PKInkType.Monoline;
			if (constant.IsEqualTo (PKInkTypeFountainPen))
				return PKInkType.FountainPen;
			if (constant.IsEqualTo (PKInkTypeWatercolor))
				return PKInkType.Watercolor;
			if (constant.IsEqualTo (PKInkTypeCrayon))
				return PKInkType.Crayon;
			if (constant.IsEqualTo (PKInkTypeReed))
				return PKInkType.Reed;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PencilKit.PKInkType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PKInkType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PencilKit.PKInkType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PKInkType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PencilKit.PKInkType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PKInkType[]? values)
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
		internal static PKInkType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PKInkType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
