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
namespace UIKit {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIWindowSceneSessionRole : int {
		Application = 0,
		ExternalDisplay = 1,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		CarTemplateApplication = 2,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		ExternalDisplayNonInteractive = 3,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		AssistiveAccessApplication = 4,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIWindowSceneSessionRole" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIWindowSceneSessionRoleExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("UIWindowSceneSessionRoleApplication", "UIKit")]
		internal unsafe static IntPtr UIWindowSceneSessionRoleApplication {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIWindowSceneSessionRoleApplication", storage);
			}
		}
		[Field ("UIWindowSceneSessionRoleExternalDisplay", "UIKit")]
		internal unsafe static IntPtr UIWindowSceneSessionRoleExternalDisplay {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIWindowSceneSessionRoleExternalDisplay", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("UIWindowSceneSessionRoleExternalDisplayNonInteractive", "UIKit")]
		internal unsafe static IntPtr UIWindowSceneSessionRoleExternalDisplayNonInteractive {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIWindowSceneSessionRoleExternalDisplayNonInteractive", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("UIWindowSceneSessionRoleAssistiveAccessApplication", "UIKit")]
		internal unsafe static IntPtr UIWindowSceneSessionRoleAssistiveAccessApplication {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIWindowSceneSessionRoleAssistiveAccessApplication", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIWindowSceneSessionRole self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIWindowSceneSessionRole.Application
				ptr = UIWindowSceneSessionRoleApplication;
				break;
			case 1: // UIWindowSceneSessionRole.ExternalDisplay
				ptr = UIWindowSceneSessionRoleExternalDisplay;
				break;
			case 3: // UIWindowSceneSessionRole.ExternalDisplayNonInteractive
				ptr = UIWindowSceneSessionRoleExternalDisplayNonInteractive;
				break;
			case 4: // UIWindowSceneSessionRole.AssistiveAccessApplication
				ptr = UIWindowSceneSessionRoleAssistiveAccessApplication;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIWindowSceneSessionRole" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIWindowSceneSessionRole GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIWindowSceneSessionRoleApplication))
				return UIWindowSceneSessionRole.Application;
			if (constant.IsEqualTo (UIWindowSceneSessionRoleExternalDisplay))
				return UIWindowSceneSessionRole.ExternalDisplay;
			if (constant.IsEqualTo (UIWindowSceneSessionRoleExternalDisplayNonInteractive))
				return UIWindowSceneSessionRole.ExternalDisplayNonInteractive;
			if (constant.IsEqualTo (UIWindowSceneSessionRoleAssistiveAccessApplication))
				return UIWindowSceneSessionRole.AssistiveAccessApplication;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIWindowSceneSessionRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIWindowSceneSessionRole GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIWindowSceneSessionRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIWindowSceneSessionRole? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIWindowSceneSessionRole" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIWindowSceneSessionRole[]? values)
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
		internal static UIWindowSceneSessionRole[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIWindowSceneSessionRole> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
