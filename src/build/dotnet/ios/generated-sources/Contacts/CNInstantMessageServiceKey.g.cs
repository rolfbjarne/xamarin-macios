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
namespace Contacts {
	/// <summary>Provides string constants whose values are the names of common providers of instant messaging services.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNInstantMessageServiceKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Aim;
		/// <summary>AOL Instant Messenger.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceAIM",  "Contacts")]
		public static NSString Aim {
			get {
				if (_Aim is null)
					_Aim = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceAIM")!;
				return _Aim;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Facebook;
		/// <summary>Facebook Messenger.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceFacebook",  "Contacts")]
		public static NSString Facebook {
			get {
				if (_Facebook is null)
					_Facebook = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceFacebook")!;
				return _Facebook;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GaduGadu;
		/// <summary>Gadu-Gadu (Polish).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceGaduGadu",  "Contacts")]
		public static NSString GaduGadu {
			get {
				if (_GaduGadu is null)
					_GaduGadu = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceGaduGadu")!;
				return _GaduGadu;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GoogleTalk;
		/// <summary>Google Talk.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceGoogleTalk",  "Contacts")]
		public static NSString GoogleTalk {
			get {
				if (_GoogleTalk is null)
					_GoogleTalk = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceGoogleTalk")!;
				return _GoogleTalk;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Icq;
		/// <summary>ICQ.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceICQ",  "Contacts")]
		public static NSString Icq {
			get {
				if (_Icq is null)
					_Icq = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceICQ")!;
				return _Icq;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Jabber;
		/// <summary>Jabber.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceJabber",  "Contacts")]
		public static NSString Jabber {
			get {
				if (_Jabber is null)
					_Jabber = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceJabber")!;
				return _Jabber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Msn;
		/// <summary>MSN Messenger.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceMSN",  "Contacts")]
		public static NSString Msn {
			get {
				if (_Msn is null)
					_Msn = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceMSN")!;
				return _Msn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QQ;
		/// <summary>Tencent QQ.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceQQ",  "Contacts")]
		public static NSString QQ {
			get {
				if (_QQ is null)
					_QQ = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceQQ")!;
				return _QQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Skype;
		/// <summary>Microsoft Skype.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceSkype",  "Contacts")]
		public static NSString Skype {
			get {
				if (_Skype is null)
					_Skype = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceSkype")!;
				return _Skype;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Yahoo;
		/// <summary>Yahoo Messenger.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageServiceYahoo",  "Contacts")]
		public static NSString Yahoo {
			get {
				if (_Yahoo is null)
					_Yahoo = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageServiceYahoo")!;
				return _Yahoo;
			}
		}
	} /* class CNInstantMessageServiceKey */
}
