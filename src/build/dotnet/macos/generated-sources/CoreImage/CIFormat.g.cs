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
namespace CoreImage {
	/// <summary>An enumeration whose values specify pixel formats.</summary>
	public enum CIFormat : int {
		/// <summary>Value that represents the kCIFormatARGB8 pixel format.</summary>
		[Obsolete ("Use 'Argb8' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		ARGB8 = 0,
		/// <summary>Value that represents the kCIFormatRGBAh pixel format.</summary>
		[Obsolete ("Use 'Rgbah' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		RGBAh = 1,
		/// <summary>Value that represents the kCIFormatkRGBA16 pixel format.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Obsolete ("Use 'Rgba16' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		RGBA16 = 2,
		/// <summary>Value that represents the kCIFormatkRGBAf pixel format.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Obsolete ("Use 'Rgbaf' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		RGBAf = 3,
		/// <summary>Value that represents the kCIFormatkRGBAf pixel format.</summary>
		[Obsolete ("Use 'Rgbaf' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		kRGBAf = 4,
		/// <summary>Value that represents the kCIFormatkBGRA8 pixel format.</summary>
		[Obsolete ("Use 'Bgra8' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		kBGRA8 = 5,
		/// <summary>Value that represents the kCIFormatkRGBA8 pixel format.</summary>
		[Obsolete ("Use 'Rgba8' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		kRGBA8 = 6,
		/// <summary>Value that represents the kCIFormatABGR8 pixel format.</summary>
		[Obsolete ("Use 'Abgr8' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		ABGR8 = 7,
		/// <summary>Represents the value associated with the constant kCIFormatRGBA16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Rgba16 = 2,
		/// <summary>Represents the value associated with the constant kCIFormatARGB8</summary>
		Argb8 = 0,
		/// <summary>Represents the value associated with the constant kCIFormatRGBAh</summary>
		Rgbah = 1,
		/// <summary>Represents the value associated with the constant kCIFormatRGBAf</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Rgbaf = 4,
		/// <summary>Represents the value associated with the constant kCIFormatBGRA8</summary>
		Bgra8 = 5,
		/// <summary>Represents the value associated with the constant kCIFormatRGBA8</summary>
		Rgba8 = 6,
		/// <summary>Represents the value associated with the constant kCIFormatABGR8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Abgr8 = 7,
		/// <summary>Represents the value associated with the constant kCIFormatA8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		A8 = 11,
		/// <summary>Represents the value associated with the constant kCIFormatA16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		A16 = 12,
		/// <summary>Represents the value associated with the constant kCIFormatAh.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Ah = 13,
		/// <summary>Represents the value associated with the constant kCIFormatAf.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Af = 14,
		/// <summary>Represents the value associated with the constant kCIFormatR8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		R8 = 15,
		/// <summary>Represents the value associated with the constant kCIFormatR16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		R16 = 16,
		/// <summary>Represents the value associated with the constant kCIFormatRh.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Rh = 17,
		/// <summary>Represents the value associated with the constant kCIFormatRf.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Rf = 18,
		/// <summary>Represents the value associated with the constant kCIFormatRG8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RG8 = 19,
		/// <summary>Represents the value associated with the constant kCIFormatRG16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RG16 = 20,
		/// <summary>Represents the value associated with the constant kCIFormatRGh.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RGh = 21,
		/// <summary>Represents the value associated with the constant kCIFormatRGf.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RGf = 22,
		/// <summary>Represents the value associated with the constant kCIFormatL8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		L8 = 23,
		/// <summary>Represents the value associated with the constant kCIFormatL16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		L16 = 24,
		/// <summary>Represents the value associated with the constant kCIFormatLh.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Lh = 25,
		/// <summary>Represents the value associated with the constant kCIFormatLf.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Lf = 26,
		/// <summary>Represents the value associated with the constant kCIFormatLA8.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LA8 = 27,
		/// <summary>Represents the value associated with the constant kCIFormatLA16.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LA16 = 28,
		/// <summary>Represents the value associated with the constant kCIFormatLAh.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LAh = 29,
		/// <summary>Represents the value associated with the constant kCIFormatLAf.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LAf = 30,
		/// <summary>Represents the value associated with the constant kCIFormatRGB10.</summary>
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		Rgb10 = 31,
		/// <summary>Represents the value associated with the constant kCIFormatRGBX16.</summary>
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		RgbX16 = 32,
		/// <summary>Represents the value associated with the constant kCIFormatRGBXf.</summary>
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		RgbXf = 33,
		/// <summary>Represents the value associated with the constant kCIFormatRGBXh.</summary>
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		RgbXh = 34,
		/// <summary>Represents the value associated with the constant kCIFormatRGBX8</summary>
		Rgbx8 = 35,
	}
	/// <summary>Extension methods for the <see cref="global::CoreImage.CIFormat" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CIFormatExtensions {
		static int?[] values = new int? [32];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRGBA16", "CoreImage")]
		internal unsafe static int kCIFormatRGBA16 {
			get {
				if (!values [0].HasValue)
					values [0] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBA16");
				return values [0]!.Value;
			}
		}
		[Field ("kCIFormatARGB8", "CoreImage")]
		internal unsafe static int kCIFormatARGB8 {
			get {
				if (!values [1].HasValue)
					values [1] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatARGB8");
				return values [1]!.Value;
			}
		}
		[Field ("kCIFormatRGBAh", "CoreImage")]
		internal unsafe static int kCIFormatRGBAh {
			get {
				if (!values [2].HasValue)
					values [2] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBAh");
				return values [2]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRGBAf", "CoreImage")]
		internal unsafe static int kCIFormatRGBAf {
			get {
				if (!values [3].HasValue)
					values [3] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBAf");
				return values [3]!.Value;
			}
		}
		[Field ("kCIFormatBGRA8", "CoreImage")]
		internal unsafe static int kCIFormatBGRA8 {
			get {
				if (!values [4].HasValue)
					values [4] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatBGRA8");
				return values [4]!.Value;
			}
		}
		[Field ("kCIFormatRGBA8", "CoreImage")]
		internal unsafe static int kCIFormatRGBA8 {
			get {
				if (!values [5].HasValue)
					values [5] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBA8");
				return values [5]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatABGR8", "CoreImage")]
		internal unsafe static int kCIFormatABGR8 {
			get {
				if (!values [6].HasValue)
					values [6] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatABGR8");
				return values [6]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatA8", "CoreImage")]
		internal unsafe static int kCIFormatA8 {
			get {
				if (!values [7].HasValue)
					values [7] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatA8");
				return values [7]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatA16", "CoreImage")]
		internal unsafe static int kCIFormatA16 {
			get {
				if (!values [8].HasValue)
					values [8] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatA16");
				return values [8]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatAh", "CoreImage")]
		internal unsafe static int kCIFormatAh {
			get {
				if (!values [9].HasValue)
					values [9] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatAh");
				return values [9]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatAf", "CoreImage")]
		internal unsafe static int kCIFormatAf {
			get {
				if (!values [10].HasValue)
					values [10] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatAf");
				return values [10]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatR8", "CoreImage")]
		internal unsafe static int kCIFormatR8 {
			get {
				if (!values [11].HasValue)
					values [11] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatR8");
				return values [11]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatR16", "CoreImage")]
		internal unsafe static int kCIFormatR16 {
			get {
				if (!values [12].HasValue)
					values [12] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatR16");
				return values [12]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRh", "CoreImage")]
		internal unsafe static int kCIFormatRh {
			get {
				if (!values [13].HasValue)
					values [13] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRh");
				return values [13]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRf", "CoreImage")]
		internal unsafe static int kCIFormatRf {
			get {
				if (!values [14].HasValue)
					values [14] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRf");
				return values [14]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRG8", "CoreImage")]
		internal unsafe static int kCIFormatRG8 {
			get {
				if (!values [15].HasValue)
					values [15] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRG8");
				return values [15]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRG16", "CoreImage")]
		internal unsafe static int kCIFormatRG16 {
			get {
				if (!values [16].HasValue)
					values [16] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRG16");
				return values [16]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRGh", "CoreImage")]
		internal unsafe static int kCIFormatRGh {
			get {
				if (!values [17].HasValue)
					values [17] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGh");
				return values [17]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatRGf", "CoreImage")]
		internal unsafe static int kCIFormatRGf {
			get {
				if (!values [18].HasValue)
					values [18] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGf");
				return values [18]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatL8", "CoreImage")]
		internal unsafe static int kCIFormatL8 {
			get {
				if (!values [19].HasValue)
					values [19] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatL8");
				return values [19]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatL16", "CoreImage")]
		internal unsafe static int kCIFormatL16 {
			get {
				if (!values [20].HasValue)
					values [20] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatL16");
				return values [20]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLh", "CoreImage")]
		internal unsafe static int kCIFormatLh {
			get {
				if (!values [21].HasValue)
					values [21] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLh");
				return values [21]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLf", "CoreImage")]
		internal unsafe static int kCIFormatLf {
			get {
				if (!values [22].HasValue)
					values [22] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLf");
				return values [22]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLA8", "CoreImage")]
		internal unsafe static int kCIFormatLA8 {
			get {
				if (!values [23].HasValue)
					values [23] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLA8");
				return values [23]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLA16", "CoreImage")]
		internal unsafe static int kCIFormatLA16 {
			get {
				if (!values [24].HasValue)
					values [24] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLA16");
				return values [24]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLAh", "CoreImage")]
		internal unsafe static int kCIFormatLAh {
			get {
				if (!values [25].HasValue)
					values [25] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLAh");
				return values [25]!.Value;
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCIFormatLAf", "CoreImage")]
		internal unsafe static int kCIFormatLAf {
			get {
				if (!values [26].HasValue)
					values [26] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatLAf");
				return values [26]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[Field ("kCIFormatRGB10", "CoreImage")]
		internal unsafe static int kCIFormatRGB10 {
			get {
				if (!values [27].HasValue)
					values [27] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGB10");
				return values [27]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[Field ("kCIFormatRGBX16", "CoreImage")]
		internal unsafe static int kCIFormatRGBX16 {
			get {
				if (!values [28].HasValue)
					values [28] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBX16");
				return values [28]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[Field ("kCIFormatRGBXf", "CoreImage")]
		internal unsafe static int kCIFormatRGBXf {
			get {
				if (!values [29].HasValue)
					values [29] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBXf");
				return values [29]!.Value;
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[Field ("kCIFormatRGBXh", "CoreImage")]
		internal unsafe static int kCIFormatRGBXh {
			get {
				if (!values [30].HasValue)
					values [30] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBXh");
				return values [30]!.Value;
			}
		}
		[Field ("kCIFormatRGBX8", "CoreImage")]
		internal unsafe static int kCIFormatRGBX8 {
			get {
				if (!values [31].HasValue)
					values [31] = Dlfcn.GetStruct<Int32> (Libraries.CoreImage.Handle, "kCIFormatRGBX8");
				return values [31]!.Value;
			}
		}
		/// <summary>Retrieves the <see cref="global::System.Int32" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static unsafe int? GetConstant (this CIFormat self)
		{
			switch ((int) self) {
			case 2: // CIFormat.Rgba16
				return kCIFormatRGBA16;
			case 0: // CIFormat.Argb8
				return kCIFormatARGB8;
			case 1: // CIFormat.Rgbah
				return kCIFormatRGBAh;
			case 4: // CIFormat.Rgbaf
				return kCIFormatRGBAf;
			case 5: // CIFormat.Bgra8
				return kCIFormatBGRA8;
			case 6: // CIFormat.Rgba8
				return kCIFormatRGBA8;
			case 7: // CIFormat.Abgr8
				return kCIFormatABGR8;
			case 11: // CIFormat.A8
				return kCIFormatA8;
			case 12: // CIFormat.A16
				return kCIFormatA16;
			case 13: // CIFormat.Ah
				return kCIFormatAh;
			case 14: // CIFormat.Af
				return kCIFormatAf;
			case 15: // CIFormat.R8
				return kCIFormatR8;
			case 16: // CIFormat.R16
				return kCIFormatR16;
			case 17: // CIFormat.Rh
				return kCIFormatRh;
			case 18: // CIFormat.Rf
				return kCIFormatRf;
			case 19: // CIFormat.RG8
				return kCIFormatRG8;
			case 20: // CIFormat.RG16
				return kCIFormatRG16;
			case 21: // CIFormat.RGh
				return kCIFormatRGh;
			case 22: // CIFormat.RGf
				return kCIFormatRGf;
			case 23: // CIFormat.L8
				return kCIFormatL8;
			case 24: // CIFormat.L16
				return kCIFormatL16;
			case 25: // CIFormat.Lh
				return kCIFormatLh;
			case 26: // CIFormat.Lf
				return kCIFormatLf;
			case 27: // CIFormat.LA8
				return kCIFormatLA8;
			case 28: // CIFormat.LA16
				return kCIFormatLA16;
			case 29: // CIFormat.LAh
				return kCIFormatLAh;
			case 30: // CIFormat.LAf
				return kCIFormatLAf;
			case 31: // CIFormat.Rgb10
				return kCIFormatRGB10;
			case 32: // CIFormat.RgbX16
				return kCIFormatRGBX16;
			case 33: // CIFormat.RgbXf
				return kCIFormatRGBXf;
			case 34: // CIFormat.RgbXh
				return kCIFormatRGBXh;
			case 35: // CIFormat.Rgbx8
				return kCIFormatRGBX8;
			}
			return null;
		}
		/// <summary>Retrieves the <see cref="global::CoreImage.CIFormat" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static unsafe CIFormat GetValue (int constant)
		{
			if (constant == kCIFormatRGBA16)
				return CIFormat.Rgba16;
			if (constant == kCIFormatARGB8)
				return CIFormat.Argb8;
			if (constant == kCIFormatRGBAh)
				return CIFormat.Rgbah;
			if (constant == kCIFormatRGBAf)
				return CIFormat.Rgbaf;
			if (constant == kCIFormatBGRA8)
				return CIFormat.Bgra8;
			if (constant == kCIFormatRGBA8)
				return CIFormat.Rgba8;
			if (constant == kCIFormatABGR8)
				return CIFormat.Abgr8;
			if (constant == kCIFormatA8)
				return CIFormat.A8;
			if (constant == kCIFormatA16)
				return CIFormat.A16;
			if (constant == kCIFormatAh)
				return CIFormat.Ah;
			if (constant == kCIFormatAf)
				return CIFormat.Af;
			if (constant == kCIFormatR8)
				return CIFormat.R8;
			if (constant == kCIFormatR16)
				return CIFormat.R16;
			if (constant == kCIFormatRh)
				return CIFormat.Rh;
			if (constant == kCIFormatRf)
				return CIFormat.Rf;
			if (constant == kCIFormatRG8)
				return CIFormat.RG8;
			if (constant == kCIFormatRG16)
				return CIFormat.RG16;
			if (constant == kCIFormatRGh)
				return CIFormat.RGh;
			if (constant == kCIFormatRGf)
				return CIFormat.RGf;
			if (constant == kCIFormatL8)
				return CIFormat.L8;
			if (constant == kCIFormatL16)
				return CIFormat.L16;
			if (constant == kCIFormatLh)
				return CIFormat.Lh;
			if (constant == kCIFormatLf)
				return CIFormat.Lf;
			if (constant == kCIFormatLA8)
				return CIFormat.LA8;
			if (constant == kCIFormatLA16)
				return CIFormat.LA16;
			if (constant == kCIFormatLAh)
				return CIFormat.LAh;
			if (constant == kCIFormatLAf)
				return CIFormat.LAf;
			if (constant == kCIFormatRGB10)
				return CIFormat.Rgb10;
			if (constant == kCIFormatRGBX16)
				return CIFormat.RgbX16;
			if (constant == kCIFormatRGBXf)
				return CIFormat.RgbXf;
			if (constant == kCIFormatRGBXh)
				return CIFormat.RgbXh;
			if (constant == kCIFormatRGBX8)
				return CIFormat.Rgbx8;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Converts an array of <see cref="global::CoreImage.CIFormat" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static int?[]? ToConstantArray (this CIFormat[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<int?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="int" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="int" /> values to convert.</param>
		internal static CIFormat[]? ToEnumArray (this int[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CIFormat> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
