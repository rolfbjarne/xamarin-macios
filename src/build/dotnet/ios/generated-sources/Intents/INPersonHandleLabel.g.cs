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
namespace Intents {
	/// <summary>Enumerates the types of information associated with a particular value of a <see cref="T:Intents.INPersonHandleType" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum INPersonHandleLabel : int {
		/// <summary>Indicates that no label is specified.</summary>
		None = 0,
		/// <summary>Indicates a handle for the user's home.</summary>
		Home = 1,
		/// <summary>Indicates a handle for the user's work.</summary>
		Work = 2,
		/// <summary>Indicates a handle for the user's iPhone.</summary>
		iPhone = 3,
		/// <summary>Indicates a handle for one of the user's mobile devices.</summary>
		Mobile = 4,
		/// <summary>Indicates the primary handle for the user.</summary>
		Main = 5,
		/// <summary>Indicates a handle for the user's home fax.</summary>
		HomeFax = 6,
		/// <summary>Indicates a handle for the user's work fax.</summary>
		WorkFax = 7,
		/// <summary>Indicates a handle for the user's pager.</summary>
		Pager = 8,
		/// <summary>Indicates a handle for a miscellaneous category.</summary>
		Other = 9,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		School = 10,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INPersonHandleLabel" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INPersonHandleLabelExtensions {
		static IntPtr[] values = new IntPtr [10];
		[Field ("INPersonHandleLabelHome", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelHome {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelHome", storage);
			}
		}
		[Field ("INPersonHandleLabelWork", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelWork {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelWork", storage);
			}
		}
		[Field ("INPersonHandleLabeliPhone", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabeliPhone {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabeliPhone", storage);
			}
		}
		[Field ("INPersonHandleLabelMobile", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelMobile {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelMobile", storage);
			}
		}
		[Field ("INPersonHandleLabelMain", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelMain {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelMain", storage);
			}
		}
		[Field ("INPersonHandleLabelHomeFax", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelHomeFax {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelHomeFax", storage);
			}
		}
		[Field ("INPersonHandleLabelWorkFax", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelWorkFax {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelWorkFax", storage);
			}
		}
		[Field ("INPersonHandleLabelPager", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelPager {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelPager", storage);
			}
		}
		[Field ("INPersonHandleLabelOther", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelOther {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelOther", storage);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[Field ("INPersonHandleLabelSchool", "Intents")]
		internal unsafe static IntPtr INPersonHandleLabelSchool {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonHandleLabelSchool", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INPersonHandleLabel self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // INPersonHandleLabel.Home
				ptr = INPersonHandleLabelHome;
				break;
			case 2: // INPersonHandleLabel.Work
				ptr = INPersonHandleLabelWork;
				break;
			case 3: // INPersonHandleLabel.iPhone
				ptr = INPersonHandleLabeliPhone;
				break;
			case 4: // INPersonHandleLabel.Mobile
				ptr = INPersonHandleLabelMobile;
				break;
			case 5: // INPersonHandleLabel.Main
				ptr = INPersonHandleLabelMain;
				break;
			case 6: // INPersonHandleLabel.HomeFax
				ptr = INPersonHandleLabelHomeFax;
				break;
			case 7: // INPersonHandleLabel.WorkFax
				ptr = INPersonHandleLabelWorkFax;
				break;
			case 8: // INPersonHandleLabel.Pager
				ptr = INPersonHandleLabelPager;
				break;
			case 9: // INPersonHandleLabel.Other
				ptr = INPersonHandleLabelOther;
				break;
			case 10: // INPersonHandleLabel.School
				ptr = INPersonHandleLabelSchool;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonHandleLabel" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static INPersonHandleLabel GetValue (NSString? constant)
		{
			if (constant is null)
				return INPersonHandleLabel.None;
			if (constant.IsEqualTo (INPersonHandleLabelHome))
				return INPersonHandleLabel.Home;
			if (constant.IsEqualTo (INPersonHandleLabelWork))
				return INPersonHandleLabel.Work;
			if (constant.IsEqualTo (INPersonHandleLabeliPhone))
				return INPersonHandleLabel.iPhone;
			if (constant.IsEqualTo (INPersonHandleLabelMobile))
				return INPersonHandleLabel.Mobile;
			if (constant.IsEqualTo (INPersonHandleLabelMain))
				return INPersonHandleLabel.Main;
			if (constant.IsEqualTo (INPersonHandleLabelHomeFax))
				return INPersonHandleLabel.HomeFax;
			if (constant.IsEqualTo (INPersonHandleLabelWorkFax))
				return INPersonHandleLabel.WorkFax;
			if (constant.IsEqualTo (INPersonHandleLabelPager))
				return INPersonHandleLabel.Pager;
			if (constant.IsEqualTo (INPersonHandleLabelOther))
				return INPersonHandleLabel.Other;
			if (constant.IsEqualTo (INPersonHandleLabelSchool))
				return INPersonHandleLabel.School;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonHandleLabel" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INPersonHandleLabel GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonHandleLabel" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INPersonHandleLabel? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Intents.INPersonHandleLabel" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this INPersonHandleLabel[]? values)
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
		internal static INPersonHandleLabel[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<INPersonHandleLabel> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
