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
namespace Foundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NSFileProtectionType : int {
		Complete = 0,
		CompleteUnlessOpen = 1,
		CompleteUntilFirstUserAuthentication = 2,
		None = 3,
		[SupportedOSPlatform ("tvos17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		CompleteWhenUserInactive = 4,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSFileProtectionType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSFileProtectionTypeExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("NSFileProtectionComplete", "Foundation")]
		internal unsafe static IntPtr NSFileProtectionComplete {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSFileProtectionComplete", storage);
			}
		}
		[Field ("NSFileProtectionCompleteUnlessOpen", "Foundation")]
		internal unsafe static IntPtr NSFileProtectionCompleteUnlessOpen {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSFileProtectionCompleteUnlessOpen", storage);
			}
		}
		[Field ("NSFileProtectionCompleteUntilFirstUserAuthentication", "Foundation")]
		internal unsafe static IntPtr NSFileProtectionCompleteUntilFirstUserAuthentication {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSFileProtectionCompleteUntilFirstUserAuthentication", storage);
			}
		}
		[Field ("NSFileProtectionNone", "Foundation")]
		internal unsafe static IntPtr NSFileProtectionNone {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSFileProtectionNone", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("NSFileProtectionCompleteWhenUserInactive", "Foundation")]
		internal unsafe static IntPtr NSFileProtectionCompleteWhenUserInactive {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSFileProtectionCompleteWhenUserInactive", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSFileProtectionType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSFileProtectionType.Complete
				ptr = NSFileProtectionComplete;
				break;
			case 1: // NSFileProtectionType.CompleteUnlessOpen
				ptr = NSFileProtectionCompleteUnlessOpen;
				break;
			case 2: // NSFileProtectionType.CompleteUntilFirstUserAuthentication
				ptr = NSFileProtectionCompleteUntilFirstUserAuthentication;
				break;
			case 3: // NSFileProtectionType.None
				ptr = NSFileProtectionNone;
				break;
			case 4: // NSFileProtectionType.CompleteWhenUserInactive
				ptr = NSFileProtectionCompleteWhenUserInactive;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSFileProtectionType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSFileProtectionType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSFileProtectionComplete))
				return NSFileProtectionType.Complete;
			if (constant.IsEqualTo (NSFileProtectionCompleteUnlessOpen))
				return NSFileProtectionType.CompleteUnlessOpen;
			if (constant.IsEqualTo (NSFileProtectionCompleteUntilFirstUserAuthentication))
				return NSFileProtectionType.CompleteUntilFirstUserAuthentication;
			if (constant.IsEqualTo (NSFileProtectionNone))
				return NSFileProtectionType.None;
			if (constant.IsEqualTo (NSFileProtectionCompleteWhenUserInactive))
				return NSFileProtectionType.CompleteWhenUserInactive;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSFileProtectionType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFileProtectionType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSFileProtectionType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFileProtectionType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSFileProtectionType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSFileProtectionType[]? values)
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
		internal static NSFileProtectionType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSFileProtectionType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
