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
namespace WebKit {
	/// <summary>Contains NSString constants that represent data types for data related to websites.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class WKWebsiteDataType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Cookies;
		/// <summary>Gets an NSString that signifies cookie data.</summary><value>The NSString object for "WKWebsiteDataTypeCookies".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeCookies",  "WebKit")]
		public static NSString Cookies {
			get {
				if (_Cookies is null)
					_Cookies = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeCookies")!;
				return _Cookies;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DiskCache;
		/// <summary>Gets an NSString that signifies a disk cache.</summary><value>The NSString object for "WKWebsiteDataTypeDiskCache".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeDiskCache",  "WebKit")]
		public static NSString DiskCache {
			get {
				if (_DiskCache is null)
					_DiskCache = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeDiskCache")!;
				return _DiskCache;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FetchCache;
		/// <summary>Gets an NSString that signifies a fetch cache.</summary><value>The NSString object for "WKWebsiteDataTypeFetchCache".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeFetchCache",  "WebKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString FetchCache {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FetchCache is null)
					_FetchCache = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeFetchCache")!;
				return _FetchCache;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileSystem;
		/// <summary>Represents the value associated with the constant 'WKWebsiteDataTypeFileSystem'.</summary>
		[Field ("WKWebsiteDataTypeFileSystem",  "WebKit")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString FileSystem {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_FileSystem is null)
					_FileSystem = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeFileSystem")!;
				return _FileSystem;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HashSalt;
		/// <summary>Represents the value associated with the constant 'WKWebsiteDataTypeHashSalt'.</summary>
		[Field ("WKWebsiteDataTypeHashSalt",  "WebKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HashSalt {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HashSalt is null)
					_HashSalt = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeHashSalt")!;
				return _HashSalt;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndexedDBDatabases;
		/// <summary>Gets an NSString that signifies IndexedDB databases.</summary><value>The NSString object for "WKWebsiteDataTypeIndexedDBDatabases".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeIndexedDBDatabases",  "WebKit")]
		public static NSString IndexedDBDatabases {
			get {
				if (_IndexedDBDatabases is null)
					_IndexedDBDatabases = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeIndexedDBDatabases")!;
				return _IndexedDBDatabases;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalStorage;
		/// <summary>Gets an NSString that signifies local HTML storage.</summary><value>The NSString object for "WKWebsiteDataTypeLocalStorage".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeLocalStorage",  "WebKit")]
		public static NSString LocalStorage {
			get {
				if (_LocalStorage is null)
					_LocalStorage = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeLocalStorage")!;
				return _LocalStorage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaKeys;
		/// <summary>Represents the value associated with the constant 'WKWebsiteDataTypeMediaKeys'.</summary>
		[Field ("WKWebsiteDataTypeMediaKeys",  "WebKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString MediaKeys {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_MediaKeys is null)
					_MediaKeys = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeMediaKeys")!;
				return _MediaKeys;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MemoryCache;
		/// <summary>Gets an NSString that signifies an in-memory cache.</summary><value>The NSString object for "WKWebsiteDataTypeMemoryCache".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeMemoryCache",  "WebKit")]
		public static NSString MemoryCache {
			get {
				if (_MemoryCache is null)
					_MemoryCache = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeMemoryCache")!;
				return _MemoryCache;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OfflineWebApplicationCache;
		/// <summary>Gets an NSString that signifies an offline HTML cache for a web app.</summary><value>The NSString object for "WKWebsiteDataTypeOfflineWebApplicationCache".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeOfflineWebApplicationCache",  "WebKit")]
		public static NSString OfflineWebApplicationCache {
			get {
				if (_OfflineWebApplicationCache is null)
					_OfflineWebApplicationCache = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeOfflineWebApplicationCache")!;
				return _OfflineWebApplicationCache;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SearchFieldRecentSearches;
		/// <summary>Represents the value associated with the constant 'WKWebsiteDataTypeSearchFieldRecentSearches'.</summary>
		[Field ("WKWebsiteDataTypeSearchFieldRecentSearches",  "WebKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString SearchFieldRecentSearches {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_SearchFieldRecentSearches is null)
					_SearchFieldRecentSearches = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeSearchFieldRecentSearches")!;
				return _SearchFieldRecentSearches;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServiceWorkerRegistrations;
		/// <summary>Gets an NSString that signifies service worker registrations.</summary><value>The NSString object for "WKWebsiteDataTypeServiceWorkerRegistrations".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeServiceWorkerRegistrations",  "WebKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString ServiceWorkerRegistrations {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ServiceWorkerRegistrations is null)
					_ServiceWorkerRegistrations = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeServiceWorkerRegistrations")!;
				return _ServiceWorkerRegistrations;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SessionStorage;
		/// <summary>Gets an NSString that signifies HTML storage for a session.</summary><value>The NSString object for "WKWebsiteDataTypeSessionStorage".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeSessionStorage",  "WebKit")]
		public static NSString SessionStorage {
			get {
				if (_SessionStorage is null)
					_SessionStorage = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeSessionStorage")!;
				return _SessionStorage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeScreenTime;
		/// <summary>Represents the value associated with the constant 'WKWebsiteDataTypeScreenTime'.</summary>
		[Field ("WKWebsiteDataTypeScreenTime",  "WebKit")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static NSString TypeScreenTime {
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				if (_TypeScreenTime is null)
					_TypeScreenTime = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeScreenTime")!;
				return _TypeScreenTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebSQLDatabases;
		/// <summary>Gets an NSString that signifies a WebSQL database.</summary><value>The NSString object for "WKWebsiteDataTypeWebSQLDatabases".</value><remarks>To be added.</remarks>
		[Field ("WKWebsiteDataTypeWebSQLDatabases",  "WebKit")]
		public static NSString WebSQLDatabases {
			get {
				if (_WebSQLDatabases is null)
					_WebSQLDatabases = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebsiteDataTypeWebSQLDatabases")!;
				return _WebSQLDatabases;
			}
		}
	} /* class WKWebsiteDataType */
}
