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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSSegmentBackgroundStyle_NSSegmentedCell  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSegmentedCell");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameAddToAperture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameAddToAperture",  "AppKit")]
		public static NSString SharingServiceNameAddToAperture {
			get {
				if (_SharingServiceNameAddToAperture is null)
					_SharingServiceNameAddToAperture = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameAddToAperture")!;
				return _SharingServiceNameAddToAperture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameAddToIPhoto;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameAddToIPhoto",  "AppKit")]
		public static NSString SharingServiceNameAddToIPhoto {
			get {
				if (_SharingServiceNameAddToIPhoto is null)
					_SharingServiceNameAddToIPhoto = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameAddToIPhoto")!;
				return _SharingServiceNameAddToIPhoto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameAddToSafariReadingList;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameAddToSafariReadingList",  "AppKit")]
		public static NSString SharingServiceNameAddToSafariReadingList {
			get {
				if (_SharingServiceNameAddToSafariReadingList is null)
					_SharingServiceNameAddToSafariReadingList = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameAddToSafariReadingList")!;
				return _SharingServiceNameAddToSafariReadingList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameComposeEmail;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameComposeEmail",  "AppKit")]
		public static NSString SharingServiceNameComposeEmail {
			get {
				if (_SharingServiceNameComposeEmail is null)
					_SharingServiceNameComposeEmail = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameComposeEmail")!;
				return _SharingServiceNameComposeEmail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameComposeMessage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameComposeMessage",  "AppKit")]
		public static NSString SharingServiceNameComposeMessage {
			get {
				if (_SharingServiceNameComposeMessage is null)
					_SharingServiceNameComposeMessage = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameComposeMessage")!;
				return _SharingServiceNameComposeMessage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostImageOnFlickr;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostImageOnFlickr",  "AppKit")]
		public static NSString SharingServiceNamePostImageOnFlickr {
			get {
				if (_SharingServiceNamePostImageOnFlickr is null)
					_SharingServiceNamePostImageOnFlickr = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostImageOnFlickr")!;
				return _SharingServiceNamePostImageOnFlickr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostOnFacebook;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostOnFacebook",  "AppKit")]
		public static NSString SharingServiceNamePostOnFacebook {
			get {
				if (_SharingServiceNamePostOnFacebook is null)
					_SharingServiceNamePostOnFacebook = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnFacebook")!;
				return _SharingServiceNamePostOnFacebook;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostOnSinaWeibo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostOnSinaWeibo",  "AppKit")]
		public static NSString SharingServiceNamePostOnSinaWeibo {
			get {
				if (_SharingServiceNamePostOnSinaWeibo is null)
					_SharingServiceNamePostOnSinaWeibo = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnSinaWeibo")!;
				return _SharingServiceNamePostOnSinaWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostOnTwitter;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostOnTwitter",  "AppKit")]
		public static NSString SharingServiceNamePostOnTwitter {
			get {
				if (_SharingServiceNamePostOnTwitter is null)
					_SharingServiceNamePostOnTwitter = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnTwitter")!;
				return _SharingServiceNamePostOnTwitter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostVideoOnTudou;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostVideoOnTudou",  "AppKit")]
		public static NSString SharingServiceNamePostVideoOnTudou {
			get {
				if (_SharingServiceNamePostVideoOnTudou is null)
					_SharingServiceNamePostVideoOnTudou = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnTudou")!;
				return _SharingServiceNamePostVideoOnTudou;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostVideoOnVimeo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostVideoOnVimeo",  "AppKit")]
		public static NSString SharingServiceNamePostVideoOnVimeo {
			get {
				if (_SharingServiceNamePostVideoOnVimeo is null)
					_SharingServiceNamePostVideoOnVimeo = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnVimeo")!;
				return _SharingServiceNamePostVideoOnVimeo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNamePostVideoOnYouku;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNamePostVideoOnYouku",  "AppKit")]
		public static NSString SharingServiceNamePostVideoOnYouku {
			get {
				if (_SharingServiceNamePostVideoOnYouku is null)
					_SharingServiceNamePostVideoOnYouku = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnYouku")!;
				return _SharingServiceNamePostVideoOnYouku;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameSendViaAirDrop;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameSendViaAirDrop",  "AppKit")]
		public static NSString SharingServiceNameSendViaAirDrop {
			get {
				if (_SharingServiceNameSendViaAirDrop is null)
					_SharingServiceNameSendViaAirDrop = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameSendViaAirDrop")!;
				return _SharingServiceNameSendViaAirDrop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameUseAsDesktopPicture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameUseAsDesktopPicture",  "AppKit")]
		public static NSString SharingServiceNameUseAsDesktopPicture {
			get {
				if (_SharingServiceNameUseAsDesktopPicture is null)
					_SharingServiceNameUseAsDesktopPicture = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsDesktopPicture")!;
				return _SharingServiceNameUseAsDesktopPicture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharingServiceNameUseAsTwitterProfileImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSharingServiceNameUseAsTwitterProfileImage",  "AppKit")]
		public static NSString SharingServiceNameUseAsTwitterProfileImage {
			get {
				if (_SharingServiceNameUseAsTwitterProfileImage is null)
					_SharingServiceNameUseAsTwitterProfileImage = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsTwitterProfileImage")!;
				return _SharingServiceNameUseAsTwitterProfileImage;
			}
		}
	} /* class NSSegmentBackgroundStyle_NSSegmentedCell */
}
