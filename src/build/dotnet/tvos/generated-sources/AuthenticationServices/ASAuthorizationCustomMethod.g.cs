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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AuthenticationServices {
	[SupportedOSPlatform ("tvos15.0")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class ASAuthorizationCustomMethod  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Other;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationCustomMethodOther'.</summary>
		[Field ("ASAuthorizationCustomMethodOther",  "AuthenticationServices")]
		public static NSString Other {
			get {
				if (_Other is null)
					_Other = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationCustomMethodOther")!;
				return _Other;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RestorePurchase;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationCustomMethodRestorePurchase'.</summary>
		[Field ("ASAuthorizationCustomMethodRestorePurchase",  "AuthenticationServices")]
		public static NSString RestorePurchase {
			get {
				if (_RestorePurchase is null)
					_RestorePurchase = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationCustomMethodRestorePurchase")!;
				return _RestorePurchase;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubscriberAccount;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationCustomMethodVideoSubscriberAccount'.</summary>
		[Field ("ASAuthorizationCustomMethodVideoSubscriberAccount",  "AuthenticationServices")]
		public static NSString SubscriberAccount {
			get {
				if (_SubscriberAccount is null)
					_SubscriberAccount = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationCustomMethodVideoSubscriberAccount")!;
				return _SubscriberAccount;
			}
		}
	} /* class ASAuthorizationCustomMethod */
}
