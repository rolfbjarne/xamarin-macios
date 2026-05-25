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
namespace Accounts {
	/// <summary>Key to use when accessing Tencent Weibo accounts. Used with <see cref="M:Accounts.ACAccountStore.RequestAccess(Accounts.ACAccountType,Accounts.AccountStoreOptions,Accounts.ACRequestCompletionHandler)" />.</summary>
	[ObsoletedOSPlatform ("ios11.0", "Use Tencent Weibo SDK instead.")]
	[ObsoletedOSPlatform ("macos10.13", "Use Tencent Weibo SDK instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use Tencent Weibo SDK instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class ACTencentWeiboKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppId;
		/// <summary>Represents the value associated with the constant ACTencentWeiboAppIdKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACTencentWeiboAppIdKey",  "Accounts")]
		public static NSString AppId {
			get {
				if (_AppId is null)
					_AppId = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACTencentWeiboAppIdKey")!;
				return _AppId;
			}
		}
	} /* class ACTencentWeiboKey */
}
