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
namespace CFNetwork {
	public unsafe static partial class CFNetworkProxies  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpEnable;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesHTTPEnable'.</summary>
		[Field ("kCFNetworkProxiesHTTPEnable",  "CFNetwork")]
		public static NSString HttpEnable {
			get {
				if (_HttpEnable is null)
					_HttpEnable = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPEnable")!;
				return _HttpEnable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpPort;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesHTTPPort'.</summary>
		[Field ("kCFNetworkProxiesHTTPPort",  "CFNetwork")]
		public static NSString HttpPort {
			get {
				if (_HttpPort is null)
					_HttpPort = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPPort")!;
				return _HttpPort;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpProxy;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesHTTPProxy'.</summary>
		[Field ("kCFNetworkProxiesHTTPProxy",  "CFNetwork")]
		public static NSString HttpProxy {
			get {
				if (_HttpProxy is null)
					_HttpProxy = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesHTTPProxy")!;
				return _HttpProxy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProxyAutoConfigEnable;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesProxyAutoConfigEnable'.</summary>
		[Field ("kCFNetworkProxiesProxyAutoConfigEnable",  "CFNetwork")]
		public static NSString ProxyAutoConfigEnable {
			get {
				if (_ProxyAutoConfigEnable is null)
					_ProxyAutoConfigEnable = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesProxyAutoConfigEnable")!;
				return _ProxyAutoConfigEnable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProxyAutoConfigJavaScript;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesProxyAutoConfigJavaScript'.</summary>
		[Field ("kCFNetworkProxiesProxyAutoConfigJavaScript",  "CFNetwork")]
		public static NSString ProxyAutoConfigJavaScript {
			get {
				if (_ProxyAutoConfigJavaScript is null)
					_ProxyAutoConfigJavaScript = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesProxyAutoConfigJavaScript")!;
				return _ProxyAutoConfigJavaScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProxyAutoConfigUrlString;
		/// <summary>Represents the value associated with the constant 'kCFNetworkProxiesProxyAutoConfigURLString'.</summary>
		[Field ("kCFNetworkProxiesProxyAutoConfigURLString",  "CFNetwork")]
		public static NSString ProxyAutoConfigUrlString {
			get {
				if (_ProxyAutoConfigUrlString is null)
					_ProxyAutoConfigUrlString = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFNetworkProxiesProxyAutoConfigURLString")!;
				return _ProxyAutoConfigUrlString;
			}
		}
	} /* class CFNetworkProxies */
}
