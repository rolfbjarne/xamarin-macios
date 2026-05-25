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
namespace WebKit {
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Flags]
	public enum WKWebExtensionPermission : int {
		ActiveTab = 1,
		Alarms = 2,
		ClipboardWrite = 4,
		ContextMenus = 8,
		Cookies = 16,
		DeclarativeNetRequest = 32,
		DeclarativeNetRequestFeedback = 64,
		DeclarativeNetRequestWithHostAccess = 128,
		Menus = 256,
		NativeMessaging = 512,
		Scripting = 1024,
		Storage = 2048,
		Tabs = 4096,
		UnlimitedStorage = 8192,
		WebNavigation = 16384,
		WebRequest = 32768,
	}
	/// <summary>Extension methods for the <see cref="global::WebKit.WKWebExtensionPermission" /> enumeration.</summary>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKWebExtensionPermissionExtensions {
		static IntPtr[] values = new IntPtr [16];
		[Field ("WKWebExtensionPermissionActiveTab", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionActiveTab {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionActiveTab", storage);
			}
		}
		[Field ("WKWebExtensionPermissionAlarms", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionAlarms {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionAlarms", storage);
			}
		}
		[Field ("WKWebExtensionPermissionClipboardWrite", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionClipboardWrite {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionClipboardWrite", storage);
			}
		}
		[Field ("WKWebExtensionPermissionContextMenus", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionContextMenus {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionContextMenus", storage);
			}
		}
		[Field ("WKWebExtensionPermissionCookies", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionCookies {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionCookies", storage);
			}
		}
		[Field ("WKWebExtensionPermissionDeclarativeNetRequest", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionDeclarativeNetRequest {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionDeclarativeNetRequest", storage);
			}
		}
		[Field ("WKWebExtensionPermissionDeclarativeNetRequestFeedback", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionDeclarativeNetRequestFeedback {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionDeclarativeNetRequestFeedback", storage);
			}
		}
		[Field ("WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess", storage);
			}
		}
		[Field ("WKWebExtensionPermissionMenus", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionMenus {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionMenus", storage);
			}
		}
		[Field ("WKWebExtensionPermissionNativeMessaging", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionNativeMessaging {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionNativeMessaging", storage);
			}
		}
		[Field ("WKWebExtensionPermissionScripting", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionScripting {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionScripting", storage);
			}
		}
		[Field ("WKWebExtensionPermissionStorage", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionStorage {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionStorage", storage);
			}
		}
		[Field ("WKWebExtensionPermissionTabs", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionTabs {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionTabs", storage);
			}
		}
		[Field ("WKWebExtensionPermissionUnlimitedStorage", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionUnlimitedStorage {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionUnlimitedStorage", storage);
			}
		}
		[Field ("WKWebExtensionPermissionWebNavigation", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionWebNavigation {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionWebNavigation", storage);
			}
		}
		[Field ("WKWebExtensionPermissionWebRequest", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionPermissionWebRequest {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionPermissionWebRequest", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this WKWebExtensionPermission self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // WKWebExtensionPermission.ActiveTab
				ptr = WKWebExtensionPermissionActiveTab;
				break;
			case 2: // WKWebExtensionPermission.Alarms
				ptr = WKWebExtensionPermissionAlarms;
				break;
			case 4: // WKWebExtensionPermission.ClipboardWrite
				ptr = WKWebExtensionPermissionClipboardWrite;
				break;
			case 8: // WKWebExtensionPermission.ContextMenus
				ptr = WKWebExtensionPermissionContextMenus;
				break;
			case 16: // WKWebExtensionPermission.Cookies
				ptr = WKWebExtensionPermissionCookies;
				break;
			case 32: // WKWebExtensionPermission.DeclarativeNetRequest
				ptr = WKWebExtensionPermissionDeclarativeNetRequest;
				break;
			case 64: // WKWebExtensionPermission.DeclarativeNetRequestFeedback
				ptr = WKWebExtensionPermissionDeclarativeNetRequestFeedback;
				break;
			case 128: // WKWebExtensionPermission.DeclarativeNetRequestWithHostAccess
				ptr = WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess;
				break;
			case 256: // WKWebExtensionPermission.Menus
				ptr = WKWebExtensionPermissionMenus;
				break;
			case 512: // WKWebExtensionPermission.NativeMessaging
				ptr = WKWebExtensionPermissionNativeMessaging;
				break;
			case 1024: // WKWebExtensionPermission.Scripting
				ptr = WKWebExtensionPermissionScripting;
				break;
			case 2048: // WKWebExtensionPermission.Storage
				ptr = WKWebExtensionPermissionStorage;
				break;
			case 4096: // WKWebExtensionPermission.Tabs
				ptr = WKWebExtensionPermissionTabs;
				break;
			case 8192: // WKWebExtensionPermission.UnlimitedStorage
				ptr = WKWebExtensionPermissionUnlimitedStorage;
				break;
			case 16384: // WKWebExtensionPermission.WebNavigation
				ptr = WKWebExtensionPermissionWebNavigation;
				break;
			case 32768: // WKWebExtensionPermission.WebRequest
				ptr = WKWebExtensionPermissionWebRequest;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionPermission" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static WKWebExtensionPermission GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (WKWebExtensionPermissionActiveTab))
				return WKWebExtensionPermission.ActiveTab;
			if (constant.IsEqualTo (WKWebExtensionPermissionAlarms))
				return WKWebExtensionPermission.Alarms;
			if (constant.IsEqualTo (WKWebExtensionPermissionClipboardWrite))
				return WKWebExtensionPermission.ClipboardWrite;
			if (constant.IsEqualTo (WKWebExtensionPermissionContextMenus))
				return WKWebExtensionPermission.ContextMenus;
			if (constant.IsEqualTo (WKWebExtensionPermissionCookies))
				return WKWebExtensionPermission.Cookies;
			if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequest))
				return WKWebExtensionPermission.DeclarativeNetRequest;
			if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequestFeedback))
				return WKWebExtensionPermission.DeclarativeNetRequestFeedback;
			if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess))
				return WKWebExtensionPermission.DeclarativeNetRequestWithHostAccess;
			if (constant.IsEqualTo (WKWebExtensionPermissionMenus))
				return WKWebExtensionPermission.Menus;
			if (constant.IsEqualTo (WKWebExtensionPermissionNativeMessaging))
				return WKWebExtensionPermission.NativeMessaging;
			if (constant.IsEqualTo (WKWebExtensionPermissionScripting))
				return WKWebExtensionPermission.Scripting;
			if (constant.IsEqualTo (WKWebExtensionPermissionStorage))
				return WKWebExtensionPermission.Storage;
			if (constant.IsEqualTo (WKWebExtensionPermissionTabs))
				return WKWebExtensionPermission.Tabs;
			if (constant.IsEqualTo (WKWebExtensionPermissionUnlimitedStorage))
				return WKWebExtensionPermission.UnlimitedStorage;
			if (constant.IsEqualTo (WKWebExtensionPermissionWebNavigation))
				return WKWebExtensionPermission.WebNavigation;
			if (constant.IsEqualTo (WKWebExtensionPermissionWebRequest))
				return WKWebExtensionPermission.WebRequest;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionPermission" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static WKWebExtensionPermission GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionPermission" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static WKWebExtensionPermission? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::WebKit.WKWebExtensionPermission" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this WKWebExtensionPermission[]? values)
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
		internal static WKWebExtensionPermission[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<WKWebExtensionPermission> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::WebKit.WKWebExtensionPermission" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this WKWebExtensionPermission value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (WKWebExtensionPermission.ActiveTab) && WKWebExtensionPermissionActiveTab != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionActiveTab)!);
			if (value.HasFlag (WKWebExtensionPermission.Alarms) && WKWebExtensionPermissionAlarms != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionAlarms)!);
			if (value.HasFlag (WKWebExtensionPermission.ClipboardWrite) && WKWebExtensionPermissionClipboardWrite != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionClipboardWrite)!);
			if (value.HasFlag (WKWebExtensionPermission.ContextMenus) && WKWebExtensionPermissionContextMenus != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionContextMenus)!);
			if (value.HasFlag (WKWebExtensionPermission.Cookies) && WKWebExtensionPermissionCookies != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionCookies)!);
			if (value.HasFlag (WKWebExtensionPermission.DeclarativeNetRequest) && WKWebExtensionPermissionDeclarativeNetRequest != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionDeclarativeNetRequest)!);
			if (value.HasFlag (WKWebExtensionPermission.DeclarativeNetRequestFeedback) && WKWebExtensionPermissionDeclarativeNetRequestFeedback != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionDeclarativeNetRequestFeedback)!);
			if (value.HasFlag (WKWebExtensionPermission.DeclarativeNetRequestWithHostAccess) && WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess)!);
			if (value.HasFlag (WKWebExtensionPermission.Menus) && WKWebExtensionPermissionMenus != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionMenus)!);
			if (value.HasFlag (WKWebExtensionPermission.NativeMessaging) && WKWebExtensionPermissionNativeMessaging != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionNativeMessaging)!);
			if (value.HasFlag (WKWebExtensionPermission.Scripting) && WKWebExtensionPermissionScripting != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionScripting)!);
			if (value.HasFlag (WKWebExtensionPermission.Storage) && WKWebExtensionPermissionStorage != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionStorage)!);
			if (value.HasFlag (WKWebExtensionPermission.Tabs) && WKWebExtensionPermissionTabs != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionTabs)!);
			if (value.HasFlag (WKWebExtensionPermission.UnlimitedStorage) && WKWebExtensionPermissionUnlimitedStorage != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionUnlimitedStorage)!);
			if (value.HasFlag (WKWebExtensionPermission.WebNavigation) && WKWebExtensionPermissionWebNavigation != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionWebNavigation)!);
			if (value.HasFlag (WKWebExtensionPermission.WebRequest) && WKWebExtensionPermissionWebRequest != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionPermissionWebRequest)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static WKWebExtensionPermission ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (WKWebExtensionPermission);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (WKWebExtensionPermissionActiveTab))
					rv |= WKWebExtensionPermission.ActiveTab;
				else if (constant.IsEqualTo (WKWebExtensionPermissionAlarms))
					rv |= WKWebExtensionPermission.Alarms;
				else if (constant.IsEqualTo (WKWebExtensionPermissionClipboardWrite))
					rv |= WKWebExtensionPermission.ClipboardWrite;
				else if (constant.IsEqualTo (WKWebExtensionPermissionContextMenus))
					rv |= WKWebExtensionPermission.ContextMenus;
				else if (constant.IsEqualTo (WKWebExtensionPermissionCookies))
					rv |= WKWebExtensionPermission.Cookies;
				else if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequest))
					rv |= WKWebExtensionPermission.DeclarativeNetRequest;
				else if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequestFeedback))
					rv |= WKWebExtensionPermission.DeclarativeNetRequestFeedback;
				else if (constant.IsEqualTo (WKWebExtensionPermissionDeclarativeNetRequestWithHostAccess))
					rv |= WKWebExtensionPermission.DeclarativeNetRequestWithHostAccess;
				else if (constant.IsEqualTo (WKWebExtensionPermissionMenus))
					rv |= WKWebExtensionPermission.Menus;
				else if (constant.IsEqualTo (WKWebExtensionPermissionNativeMessaging))
					rv |= WKWebExtensionPermission.NativeMessaging;
				else if (constant.IsEqualTo (WKWebExtensionPermissionScripting))
					rv |= WKWebExtensionPermission.Scripting;
				else if (constant.IsEqualTo (WKWebExtensionPermissionStorage))
					rv |= WKWebExtensionPermission.Storage;
				else if (constant.IsEqualTo (WKWebExtensionPermissionTabs))
					rv |= WKWebExtensionPermission.Tabs;
				else if (constant.IsEqualTo (WKWebExtensionPermissionUnlimitedStorage))
					rv |= WKWebExtensionPermission.UnlimitedStorage;
				else if (constant.IsEqualTo (WKWebExtensionPermissionWebNavigation))
					rv |= WKWebExtensionPermission.WebNavigation;
				else if (constant.IsEqualTo (WKWebExtensionPermissionWebRequest))
					rv |= WKWebExtensionPermission.WebRequest;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
