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
namespace CFNetwork {
	/// <summary>A <see cref="CoreFoundation.CFReadStream" /> that reads HTTP stream data.</summary>
	public unsafe partial class CFHTTPStream  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AttemptPersistentConnection;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPAttemptPersistentConnection'.</summary>
		[Field ("kCFStreamPropertyHTTPAttemptPersistentConnection",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _AttemptPersistentConnection {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__AttemptPersistentConnection is null)
					__AttemptPersistentConnection = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPAttemptPersistentConnection")!;
				return __AttemptPersistentConnection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __FinalRequest;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPFinalRequest'.</summary>
		[Field ("kCFStreamPropertyHTTPFinalRequest",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _FinalRequest {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__FinalRequest is null)
					__FinalRequest = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPFinalRequest")!;
				return __FinalRequest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __FinalURL;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPFinalURL'.</summary>
		[Field ("kCFStreamPropertyHTTPFinalURL",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _FinalURL {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__FinalURL is null)
					__FinalURL = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPFinalURL")!;
				return __FinalURL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Proxy;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPProxy'.</summary>
		[Field ("kCFStreamPropertyHTTPProxy",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _Proxy {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__Proxy is null)
					__Proxy = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPProxy")!;
				return __Proxy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __RequestBytesWrittenCount;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPRequestBytesWrittenCount'.</summary>
		[Field ("kCFStreamPropertyHTTPRequestBytesWrittenCount",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _RequestBytesWrittenCount {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__RequestBytesWrittenCount is null)
					__RequestBytesWrittenCount = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPRequestBytesWrittenCount")!;
				return __RequestBytesWrittenCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __ResponseHeader;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPResponseHeader'.</summary>
		[Field ("kCFStreamPropertyHTTPResponseHeader",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _ResponseHeader {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__ResponseHeader is null)
					__ResponseHeader = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPResponseHeader")!;
				return __ResponseHeader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __ShouldAutoredirect;
		/// <summary>Represents the value associated with the constant 'kCFStreamPropertyHTTPShouldAutoredirect'.</summary>
		[Field ("kCFStreamPropertyHTTPShouldAutoredirect",  "CFNetwork")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		internal static NSString _ShouldAutoredirect {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (__ShouldAutoredirect is null)
					__ShouldAutoredirect = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPShouldAutoredirect")!;
				return __ShouldAutoredirect;
			}
		}
	} /* class CFHTTPStream */
}
