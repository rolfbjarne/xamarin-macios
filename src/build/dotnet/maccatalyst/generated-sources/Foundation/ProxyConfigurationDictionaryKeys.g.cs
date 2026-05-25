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
namespace Foundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class ProxyConfigurationDictionaryKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpEnableKey;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesHTTPEnable'.</summary>
		[Field ("kCFNetworkProxiesHTTPEnable",  "Foundation")]
		public static NSString HttpEnableKey {
			get {
				if (_HttpEnableKey is null)
					_HttpEnableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "kCFNetworkProxiesHTTPEnable")!;
				return _HttpEnableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpProxyHostKey;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPProxyHost'.</summary>
		[Field ("kCFStreamPropertyHTTPProxyHost",  "Foundation")]
		public static NSString HttpProxyHostKey {
			get {
				if (_HttpProxyHostKey is null)
					_HttpProxyHostKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "kCFStreamPropertyHTTPProxyHost")!;
				return _HttpProxyHostKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpProxyPortKey;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPProxyPort'.</summary>
		[Field ("kCFStreamPropertyHTTPProxyPort",  "Foundation")]
		public static NSString HttpProxyPortKey {
			get {
				if (_HttpProxyPortKey is null)
					_HttpProxyPortKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "kCFStreamPropertyHTTPProxyPort")!;
				return _HttpProxyPortKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpsProxyHostKey;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPSProxyHost'.</summary>
		[Field ("kCFStreamPropertyHTTPSProxyHost",  "Foundation")]
		public static NSString HttpsProxyHostKey {
			get {
				if (_HttpsProxyHostKey is null)
					_HttpsProxyHostKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "kCFStreamPropertyHTTPSProxyHost")!;
				return _HttpsProxyHostKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpsProxyPortKey;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPSProxyPort'.</summary>
		[Field ("kCFStreamPropertyHTTPSProxyPort",  "Foundation")]
		public static NSString HttpsProxyPortKey {
			get {
				if (_HttpsProxyPortKey is null)
					_HttpsProxyPortKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "kCFStreamPropertyHTTPSProxyPort")!;
				return _HttpsProxyPortKey;
			}
		}
	} /* class ProxyConfigurationDictionaryKeys */
}
