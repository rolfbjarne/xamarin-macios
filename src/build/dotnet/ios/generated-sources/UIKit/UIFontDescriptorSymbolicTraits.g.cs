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
	/// <summary>Describes some stylistic properties of a typeface (lower 16 bits), and font appearance (top 16 bits), used with UIFontDescriptor.</summary><remarks></remarks>
	[Flags]
	public enum UIFontDescriptorSymbolicTraits : uint {
		/// <summary>Typeface: italic.</summary>
		Italic = 1,
		/// <summary>Style is bold</summary>
		Bold = 2,
		/// <summary>Typeface: Expanded (can not be used with Condensed).</summary>
		Expanded = 32,
		/// <summary>Typeface: Condensed (can not be used with expanded).</summary>
		Condensed = 64,
		/// <summary>Typeface: is monospace.</summary>
		MonoSpace = 1024,
		/// <summary>Typeface: contains vertical glyphs and metrics.</summary>
		Vertical = 2048,
		/// <summary>Typeface: is optimized for rendering UI controls.</summary>
		UIOptimized = 4096,
		/// <summary>Typeface: tight leading values (spacing between text lines).</summary>
		TightLeading = 32768,
		/// <summary>Typeface: uses looser leading values (spacing between text lines).</summary>
		LooseLeading = 65536,
		/// <summary>Bitmask that can be used to isolate the font appearance from the typeface information.</summary>
		ClassMask = 4026531840,
		/// <summary>Unknown font appearance.</summary>
		ClassUnknown = 0,
		/// <summary>Font appearance: Old style serifs.</summary>
		ClassOldStyleSerifs = 268435456,
		/// <summary>Font appearance: transitional serifs.</summary>
		ClassTransitionalSerifs = 536870912,
		/// <summary>Font appearance: Modern serifs.</summary>
		ClassModernSerifs = 805306368,
		/// <summary>Font appearance: Clarendon style of slab serifs (examples include fonts like Clarendon and Egyptienne).</summary>
		ClassClarendonSerifs = 1073741824,
		/// <summary>Font appearance: Slab serifs.</summary>
		ClassSlabSerifs = 1342177280,
		/// <summary>Font appearance: Includes some serifs</summary>
		ClassFreeformSerifs = 1879048192,
		/// <summary>Font appearance: Sans serifs.</summary>
		ClassSansSerif = 2147483648,
		/// <summary>Font appearance: Ornamental</summary>
		ClassOrnamentals = 2415919104,
		/// <summary>Font appearance: Scripts.</summary>
		ClassScripts = 2684354560,
		/// <summary>Font appearance: symbolic.</summary>
		ClassSymbolic = 3221225472,
	}
}
