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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Social {
	/// <summary>NSString constants with the various service types supported by the Social framework</summary><remarks>These constants are used typically when interacting with low-level Objective-C APIs.   In general, you can just use the higher level APIs that use strongly typed enumerations of type <see cref="T:Social.SLServiceKind" />.</remarks>
	public unsafe static partial class SLServiceType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Facebook;
		/// <summary>Developers should not use this deprecated property. Developers should use Facebook SDK instead.</summary><value></value><remarks>To be added.</remarks>
		[Field ("SLServiceTypeFacebook",  "Social")]
		[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString Facebook {
			[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_Facebook is null)
					_Facebook = Dlfcn.GetStringConstant (Libraries.Social.Handle, "SLServiceTypeFacebook")!;
				return _Facebook;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkedIn;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SLServiceTypeLinkedIn",  "Social")]
		[ObsoletedOSPlatform ("macos10.13", "Use LinkedIn SDK instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LinkedIn {
			[ObsoletedOSPlatform ("macos10.13", "Use LinkedIn SDK instead.")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LinkedIn is null)
					_LinkedIn = Dlfcn.GetStringConstant (Libraries.Social.Handle, "SLServiceTypeLinkedIn")!;
				return _LinkedIn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SinaWeibo;
		/// <summary>Represents the value associated with the constant SLServiceTypeSinaWeibo</summary><value></value><remarks>To be added.</remarks>
		[Field ("SLServiceTypeSinaWeibo",  "Social")]
		[ObsoletedOSPlatform ("ios11.0", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Sina Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString SinaWeibo {
			[ObsoletedOSPlatform ("ios11.0", "Use Sina Weibo SDK instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use Sina Weibo SDK instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use Sina Weibo SDK instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_SinaWeibo is null)
					_SinaWeibo = Dlfcn.GetStringConstant (Libraries.Social.Handle, "SLServiceTypeSinaWeibo")!;
				return _SinaWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TencentWeibo;
		/// <summary>Represents the value associated with the constant SLServiceTypeTencentWeibo</summary><value></value><remarks>To be added.</remarks>
		[Field ("SLServiceTypeTencentWeibo",  "Social")]
		[ObsoletedOSPlatform ("ios11.0", "Use Tencent Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString TencentWeibo {
			[ObsoletedOSPlatform ("ios11.0", "Use Tencent Weibo SDK instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use Tencent Weibo SDK instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use Tencent Weibo SDK instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TencentWeibo is null)
					_TencentWeibo = Dlfcn.GetStringConstant (Libraries.Social.Handle, "SLServiceTypeTencentWeibo")!;
				return _TencentWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Twitter;
		/// <summary>Represents the value associated with the constant SLServiceTypeTwitter</summary><value></value><remarks>To be added.</remarks>
		[Field ("SLServiceTypeTwitter",  "Social")]
		[ObsoletedOSPlatform ("ios11.0", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Twitter SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString Twitter {
			[ObsoletedOSPlatform ("ios11.0", "Use Twitter SDK instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use Twitter SDK instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use Twitter SDK instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_Twitter is null)
					_Twitter = Dlfcn.GetStringConstant (Libraries.Social.Handle, "SLServiceTypeTwitter")!;
				return _Twitter;
			}
		}
	} /* class SLServiceType */
}
