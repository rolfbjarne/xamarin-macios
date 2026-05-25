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
namespace Accessibility {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum AXTechnology : int {
		VoiceOver = 0,
		SwitchControl = 1,
		VoiceControl = 2,
		FullKeyboardAccess = 3,
		SpeakScreen = 4,
		Automation = 5,
		HoverText = 6,
		Zoom = 7,
	}
	/// <summary>Extension methods for the <see cref="global::Accessibility.AXTechnology" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AXTechnologyExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("AXTechnologyVoiceOver", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyVoiceOver {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyVoiceOver", storage);
			}
		}
		[Field ("AXTechnologySwitchControl", "Accessibility")]
		internal unsafe static IntPtr AXTechnologySwitchControl {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologySwitchControl", storage);
			}
		}
		[Field ("AXTechnologyVoiceControl", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyVoiceControl {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyVoiceControl", storage);
			}
		}
		[Field ("AXTechnologyFullKeyboardAccess", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyFullKeyboardAccess {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyFullKeyboardAccess", storage);
			}
		}
		[Field ("AXTechnologySpeakScreen", "Accessibility")]
		internal unsafe static IntPtr AXTechnologySpeakScreen {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologySpeakScreen", storage);
			}
		}
		[Field ("AXTechnologyAutomation", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyAutomation {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyAutomation", storage);
			}
		}
		[Field ("AXTechnologyHoverText", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyHoverText {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyHoverText", storage);
			}
		}
		[Field ("AXTechnologyZoom", "Accessibility")]
		internal unsafe static IntPtr AXTechnologyZoom {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Accessibility.Handle, "AXTechnologyZoom", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AXTechnology self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AXTechnology.VoiceOver
				ptr = AXTechnologyVoiceOver;
				break;
			case 1: // AXTechnology.SwitchControl
				ptr = AXTechnologySwitchControl;
				break;
			case 2: // AXTechnology.VoiceControl
				ptr = AXTechnologyVoiceControl;
				break;
			case 3: // AXTechnology.FullKeyboardAccess
				ptr = AXTechnologyFullKeyboardAccess;
				break;
			case 4: // AXTechnology.SpeakScreen
				ptr = AXTechnologySpeakScreen;
				break;
			case 5: // AXTechnology.Automation
				ptr = AXTechnologyAutomation;
				break;
			case 6: // AXTechnology.HoverText
				ptr = AXTechnologyHoverText;
				break;
			case 7: // AXTechnology.Zoom
				ptr = AXTechnologyZoom;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Accessibility.AXTechnology" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AXTechnology GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AXTechnologyVoiceOver))
				return AXTechnology.VoiceOver;
			if (constant.IsEqualTo (AXTechnologySwitchControl))
				return AXTechnology.SwitchControl;
			if (constant.IsEqualTo (AXTechnologyVoiceControl))
				return AXTechnology.VoiceControl;
			if (constant.IsEqualTo (AXTechnologyFullKeyboardAccess))
				return AXTechnology.FullKeyboardAccess;
			if (constant.IsEqualTo (AXTechnologySpeakScreen))
				return AXTechnology.SpeakScreen;
			if (constant.IsEqualTo (AXTechnologyAutomation))
				return AXTechnology.Automation;
			if (constant.IsEqualTo (AXTechnologyHoverText))
				return AXTechnology.HoverText;
			if (constant.IsEqualTo (AXTechnologyZoom))
				return AXTechnology.Zoom;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Accessibility.AXTechnology" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AXTechnology GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Accessibility.AXTechnology" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AXTechnology? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Accessibility.AXTechnology" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AXTechnology[]? values)
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
		internal static AXTechnology[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AXTechnology> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
