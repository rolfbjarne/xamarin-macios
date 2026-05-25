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
namespace GameController {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum GCInputButtonName : int {
		ButtonA = 0,
		ButtonB = 1,
		ButtonX = 2,
		ButtonY = 3,
		LeftThumbstickButton = 4,
		RightThumbstickButton = 5,
		LeftShoulder = 6,
		RightShoulder = 7,
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		LeftBumper = 8,
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		RightBumper = 9,
		LeftTrigger = 10,
		RightTrigger = 11,
		ButtonHome = 12,
		ButtonMenu = 13,
		ButtonOptions = 14,
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ButtonShare = 15,
		PaddleOne = 16,
		PaddleTwo = 17,
		PaddleThree = 18,
		PaddleFour = 19,
		DualShockTouchpadButton = 20,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		LeftPaddle = 21,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		PedalAccelerator = 22,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		PedalBrake = 23,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		PedalClutch = 24,
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		RightPaddle = 25,
		/// <summary>Represents the left side button on a game controller.</summary>
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		LeftSideButton = 26,
		/// <summary>Represents the right side button on a game controller.</summary>
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		RightSideButton = 27,
	}
	/// <summary>Extension methods for the <see cref="global::GameController.GCInputButtonName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GCInputButtonNameExtensions {
		static IntPtr[] values = new IntPtr [23];
		[Field ("GCInputButtonA", "GameController")]
		internal unsafe static IntPtr GCInputButtonA {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonA", storage);
			}
		}
		[Field ("GCInputButtonB", "GameController")]
		internal unsafe static IntPtr GCInputButtonB {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonB", storage);
			}
		}
		[Field ("GCInputButtonX", "GameController")]
		internal unsafe static IntPtr GCInputButtonX {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonX", storage);
			}
		}
		[Field ("GCInputButtonY", "GameController")]
		internal unsafe static IntPtr GCInputButtonY {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonY", storage);
			}
		}
		[Field ("GCInputLeftThumbstickButton", "GameController")]
		internal unsafe static IntPtr GCInputLeftThumbstickButton {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftThumbstickButton", storage);
			}
		}
		[Field ("GCInputRightThumbstickButton", "GameController")]
		internal unsafe static IntPtr GCInputRightThumbstickButton {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightThumbstickButton", storage);
			}
		}
		[Field ("GCInputLeftShoulder", "GameController")]
		internal unsafe static IntPtr GCInputLeftShoulder {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftShoulder", storage);
			}
		}
		[Field ("GCInputRightShoulder", "GameController")]
		internal unsafe static IntPtr GCInputRightShoulder {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightShoulder", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[Field ("GCInputLeftBumper", "GameController")]
		internal unsafe static IntPtr GCInputLeftBumper {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftBumper", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[Field ("GCInputRightBumper", "GameController")]
		internal unsafe static IntPtr GCInputRightBumper {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightBumper", storage);
			}
		}
		[Field ("GCInputLeftTrigger", "GameController")]
		internal unsafe static IntPtr GCInputLeftTrigger {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftTrigger", storage);
			}
		}
		[Field ("GCInputRightTrigger", "GameController")]
		internal unsafe static IntPtr GCInputRightTrigger {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightTrigger", storage);
			}
		}
		[Field ("GCInputButtonHome", "GameController")]
		internal unsafe static IntPtr GCInputButtonHome {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonHome", storage);
			}
		}
		[Field ("GCInputButtonMenu", "GameController")]
		internal unsafe static IntPtr GCInputButtonMenu {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonMenu", storage);
			}
		}
		[Field ("GCInputButtonOptions", "GameController")]
		internal unsafe static IntPtr GCInputButtonOptions {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonOptions", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("GCInputButtonShare", "GameController")]
		internal unsafe static IntPtr GCInputButtonShare {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputButtonShare", storage);
			}
		}
		[Field ("GCInputXboxPaddleOne", "GameController")]
		internal unsafe static IntPtr GCInputXboxPaddleOne {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputXboxPaddleOne", storage);
			}
		}
		[Field ("GCInputXboxPaddleTwo", "GameController")]
		internal unsafe static IntPtr GCInputXboxPaddleTwo {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputXboxPaddleTwo", storage);
			}
		}
		[Field ("GCInputXboxPaddleThree", "GameController")]
		internal unsafe static IntPtr GCInputXboxPaddleThree {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputXboxPaddleThree", storage);
			}
		}
		[Field ("GCInputXboxPaddleFour", "GameController")]
		internal unsafe static IntPtr GCInputXboxPaddleFour {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputXboxPaddleFour", storage);
			}
		}
		[Field ("GCInputDualShockTouchpadButton", "GameController")]
		internal unsafe static IntPtr GCInputDualShockTouchpadButton {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputDualShockTouchpadButton", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[Field ("GCInputLeftSideButton", "GameController")]
		internal unsafe static IntPtr GCInputLeftSideButton {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputLeftSideButton", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[Field ("GCInputRightSideButton", "GameController")]
		internal unsafe static IntPtr GCInputRightSideButton {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.GameController.Handle, "GCInputRightSideButton", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this GCInputButtonName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // GCInputButtonName.ButtonA
				ptr = GCInputButtonA;
				break;
			case 1: // GCInputButtonName.ButtonB
				ptr = GCInputButtonB;
				break;
			case 2: // GCInputButtonName.ButtonX
				ptr = GCInputButtonX;
				break;
			case 3: // GCInputButtonName.ButtonY
				ptr = GCInputButtonY;
				break;
			case 4: // GCInputButtonName.LeftThumbstickButton
				ptr = GCInputLeftThumbstickButton;
				break;
			case 5: // GCInputButtonName.RightThumbstickButton
				ptr = GCInputRightThumbstickButton;
				break;
			case 6: // GCInputButtonName.LeftShoulder
				ptr = GCInputLeftShoulder;
				break;
			case 7: // GCInputButtonName.RightShoulder
				ptr = GCInputRightShoulder;
				break;
			case 8: // GCInputButtonName.LeftBumper
				ptr = GCInputLeftBumper;
				break;
			case 9: // GCInputButtonName.RightBumper
				ptr = GCInputRightBumper;
				break;
			case 10: // GCInputButtonName.LeftTrigger
				ptr = GCInputLeftTrigger;
				break;
			case 11: // GCInputButtonName.RightTrigger
				ptr = GCInputRightTrigger;
				break;
			case 12: // GCInputButtonName.ButtonHome
				ptr = GCInputButtonHome;
				break;
			case 13: // GCInputButtonName.ButtonMenu
				ptr = GCInputButtonMenu;
				break;
			case 14: // GCInputButtonName.ButtonOptions
				ptr = GCInputButtonOptions;
				break;
			case 15: // GCInputButtonName.ButtonShare
				ptr = GCInputButtonShare;
				break;
			case 16: // GCInputButtonName.PaddleOne
				ptr = GCInputXboxPaddleOne;
				break;
			case 17: // GCInputButtonName.PaddleTwo
				ptr = GCInputXboxPaddleTwo;
				break;
			case 18: // GCInputButtonName.PaddleThree
				ptr = GCInputXboxPaddleThree;
				break;
			case 19: // GCInputButtonName.PaddleFour
				ptr = GCInputXboxPaddleFour;
				break;
			case 20: // GCInputButtonName.DualShockTouchpadButton
				ptr = GCInputDualShockTouchpadButton;
				break;
			case 26: // GCInputButtonName.LeftSideButton
				ptr = GCInputLeftSideButton;
				break;
			case 27: // GCInputButtonName.RightSideButton
				ptr = GCInputRightSideButton;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputButtonName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static GCInputButtonName GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (GCInputButtonA))
				return GCInputButtonName.ButtonA;
			if (constant.IsEqualTo (GCInputButtonB))
				return GCInputButtonName.ButtonB;
			if (constant.IsEqualTo (GCInputButtonX))
				return GCInputButtonName.ButtonX;
			if (constant.IsEqualTo (GCInputButtonY))
				return GCInputButtonName.ButtonY;
			if (constant.IsEqualTo (GCInputLeftThumbstickButton))
				return GCInputButtonName.LeftThumbstickButton;
			if (constant.IsEqualTo (GCInputRightThumbstickButton))
				return GCInputButtonName.RightThumbstickButton;
			if (constant.IsEqualTo (GCInputLeftShoulder))
				return GCInputButtonName.LeftShoulder;
			if (constant.IsEqualTo (GCInputRightShoulder))
				return GCInputButtonName.RightShoulder;
			if (constant.IsEqualTo (GCInputLeftBumper))
				return GCInputButtonName.LeftBumper;
			if (constant.IsEqualTo (GCInputRightBumper))
				return GCInputButtonName.RightBumper;
			if (constant.IsEqualTo (GCInputLeftTrigger))
				return GCInputButtonName.LeftTrigger;
			if (constant.IsEqualTo (GCInputRightTrigger))
				return GCInputButtonName.RightTrigger;
			if (constant.IsEqualTo (GCInputButtonHome))
				return GCInputButtonName.ButtonHome;
			if (constant.IsEqualTo (GCInputButtonMenu))
				return GCInputButtonName.ButtonMenu;
			if (constant.IsEqualTo (GCInputButtonOptions))
				return GCInputButtonName.ButtonOptions;
			if (constant.IsEqualTo (GCInputButtonShare))
				return GCInputButtonName.ButtonShare;
			if (constant.IsEqualTo (GCInputXboxPaddleOne))
				return GCInputButtonName.PaddleOne;
			if (constant.IsEqualTo (GCInputXboxPaddleTwo))
				return GCInputButtonName.PaddleTwo;
			if (constant.IsEqualTo (GCInputXboxPaddleThree))
				return GCInputButtonName.PaddleThree;
			if (constant.IsEqualTo (GCInputXboxPaddleFour))
				return GCInputButtonName.PaddleFour;
			if (constant.IsEqualTo (GCInputDualShockTouchpadButton))
				return GCInputButtonName.DualShockTouchpadButton;
			if (constant.IsEqualTo (GCInputLeftSideButton))
				return GCInputButtonName.LeftSideButton;
			if (constant.IsEqualTo (GCInputRightSideButton))
				return GCInputButtonName.RightSideButton;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputButtonName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputButtonName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::GameController.GCInputButtonName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static GCInputButtonName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::GameController.GCInputButtonName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this GCInputButtonName[]? values)
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
		internal static GCInputButtonName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<GCInputButtonName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
