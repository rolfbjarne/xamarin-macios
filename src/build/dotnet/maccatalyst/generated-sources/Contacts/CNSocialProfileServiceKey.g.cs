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
namespace Contacts {
	/// <summary>Provides string constants naming known social networks.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNSocialProfileServiceKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Facebook;
		/// <summary>Facebook.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceFacebook",  "Contacts")]
		public static NSString Facebook {
			get {
				if (_Facebook is null)
					_Facebook = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceFacebook")!;
				return _Facebook;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Flickr;
		/// <summary>Flickr.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceFlickr",  "Contacts")]
		public static NSString Flickr {
			get {
				if (_Flickr is null)
					_Flickr = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceFlickr")!;
				return _Flickr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GameCenter;
		/// <summary>Apple GameCenter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceGameCenter",  "Contacts")]
		public static NSString GameCenter {
			get {
				if (_GameCenter is null)
					_GameCenter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceGameCenter")!;
				return _GameCenter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkedIn;
		/// <summary>LinkedIn.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceLinkedIn",  "Contacts")]
		public static NSString LinkedIn {
			get {
				if (_LinkedIn is null)
					_LinkedIn = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceLinkedIn")!;
				return _LinkedIn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MySpace;
		/// <summary>MySpace.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceMySpace",  "Contacts")]
		public static NSString MySpace {
			get {
				if (_MySpace is null)
					_MySpace = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceMySpace")!;
				return _MySpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SinaWeibo;
		/// <summary>SinaWeibo.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceSinaWeibo",  "Contacts")]
		public static NSString SinaWeibo {
			get {
				if (_SinaWeibo is null)
					_SinaWeibo = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceSinaWeibo")!;
				return _SinaWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TencentWeibo;
		/// <summary>TencentWeibo.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceTencentWeibo",  "Contacts")]
		public static NSString TencentWeibo {
			get {
				if (_TencentWeibo is null)
					_TencentWeibo = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceTencentWeibo")!;
				return _TencentWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Twitter;
		/// <summary>Twitter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceTwitter",  "Contacts")]
		public static NSString Twitter {
			get {
				if (_Twitter is null)
					_Twitter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceTwitter")!;
				return _Twitter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Yelp;
		/// <summary>Yelp.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceYelp",  "Contacts")]
		public static NSString Yelp {
			get {
				if (_Yelp is null)
					_Yelp = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceYelp")!;
				return _Yelp;
			}
		}
	} /* class CNSocialProfileServiceKey */
}
