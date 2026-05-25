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
	/// <summary>A class that encapsulates keys necessary for Facebook requests. Used with <see cref="M:Accounts.ACAccountStore.RequestAccess(Accounts.ACAccountType,Accounts.AccountStoreOptions,Accounts.ACRequestCompletionHandler)" />.</summary>
	[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
	[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class ACFacebookKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppId;
		/// <summary>Represents the value associated with the constant ACFacebookAppIdKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookAppIdKey",  "Accounts")]
		public static NSString AppId {
			get {
				if (_AppId is null)
					_AppId = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookAppIdKey")!;
				return _AppId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Audience;
		/// <summary>Represents the value associated with the constant ACFacebookAudienceKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookAudienceKey",  "Accounts")]
		public static NSString Audience {
			get {
				if (_Audience is null)
					_Audience = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookAudienceKey")!;
				return _Audience;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Permissions;
		/// <summary>Represents the value associated with the constant ACFacebookPermissionsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookPermissionsKey",  "Accounts")]
		public static NSString Permissions {
			get {
				if (_Permissions is null)
					_Permissions = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookPermissionsKey")!;
				return _Permissions;
			}
		}
	} /* class ACFacebookKey */
}
