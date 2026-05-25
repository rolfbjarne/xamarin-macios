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
namespace Accounts {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("macos10.13", "Use LinkedIn SDK instead.")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class ACLinkedInKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppId;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("ACLinkedInAppIdKey",  "Accounts")]
		public static NSString AppId {
			get {
				if (_AppId is null)
					_AppId = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACLinkedInAppIdKey")!;
				return _AppId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Permissions;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("ACLinkedInPermissionsKey",  "Accounts")]
		public static NSString Permissions {
			get {
				if (_Permissions is null)
					_Permissions = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACLinkedInPermissionsKey")!;
				return _Permissions;
			}
		}
	} /* class ACLinkedInKey */
}
