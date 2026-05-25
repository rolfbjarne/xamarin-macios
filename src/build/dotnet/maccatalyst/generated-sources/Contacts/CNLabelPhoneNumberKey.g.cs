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
	/// <summary>Defines string constants whose values are labels for various types of phones.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNLabelPhoneNumberKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleWatch;
		/// <summary>Represents the value associated with the constant 'CNLabelPhoneNumberAppleWatch'.</summary>
		[Field ("CNLabelPhoneNumberAppleWatch",  "Contacts")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleWatch {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleWatch is null)
					_AppleWatch = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberAppleWatch")!;
				return _AppleWatch;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HomeFax;
		/// <summary>The user's home fax number.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberHomeFax",  "Contacts")]
		public static NSString HomeFax {
			get {
				if (_HomeFax is null)
					_HomeFax = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberHomeFax")!;
				return _HomeFax;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Main;
		/// <summary>The main phone number for a <see cref="T:Contacts.CNContact" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberMain",  "Contacts")]
		public static NSString Main {
			get {
				if (_Main is null)
					_Main = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberMain")!;
				return _Main;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mobile;
		/// <summary>A mobile phone number (see <see cref="P:Contacts.CNLabelPhoneNumberKey.iPhone" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberMobile",  "Contacts")]
		public static NSString Mobile {
			get {
				if (_Mobile is null)
					_Mobile = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberMobile")!;
				return _Mobile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OtherFax;
		/// <summary>A fax number (see <see cref="P:Contacts.CNLabelPhoneNumberKey.HomeFax" /> and <see cref="P:Contacts.CNLabelPhoneNumberKey.WorkFax" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberOtherFax",  "Contacts")]
		public static NSString OtherFax {
			get {
				if (_OtherFax is null)
					_OtherFax = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberOtherFax")!;
				return _OtherFax;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Pager;
		/// <summary>A pager number.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberPager",  "Contacts")]
		public static NSString Pager {
			get {
				if (_Pager is null)
					_Pager = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberPager")!;
				return _Pager;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkFax;
		/// <summary>Number for a fax located at work.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberWorkFax",  "Contacts")]
		public static NSString WorkFax {
			get {
				if (_WorkFax is null)
					_WorkFax = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberWorkFax")!;
				return _WorkFax;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _iPhone;
		/// <summary>Not to be confused with a mere <see cref="P:Contacts.CNLabelPhoneNumberKey.Mobile" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelPhoneNumberiPhone",  "Contacts")]
		public static NSString iPhone {
			get {
				if (_iPhone is null)
					_iPhone = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelPhoneNumberiPhone")!;
				return _iPhone;
			}
		}
	} /* class CNLabelPhoneNumberKey */
}
