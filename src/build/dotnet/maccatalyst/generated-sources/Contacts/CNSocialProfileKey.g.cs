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
	/// <summary>Provides string constants whose values specify the properties of social services that are always fetched.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNSocialProfileKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Service;
		/// <summary>The key associated with <see cref="Contacts.CNSocialProfileOption.Service" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileServiceKey",  "Contacts")]
		public static NSString Service {
			get {
				if (_Service is null)
					_Service = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileServiceKey")!;
				return _Service;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UrlString;
		/// <summary>The key associated with <see cref="Contacts.CNSocialProfileOption.UrlString" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileURLStringKey",  "Contacts")]
		public static NSString UrlString {
			get {
				if (_UrlString is null)
					_UrlString = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileURLStringKey")!;
				return _UrlString;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserIdentifier;
		/// <summary>The key associated with <see cref="Contacts.CNSocialProfileOption.UserIdentifier" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileUserIdentifierKey",  "Contacts")]
		public static NSString UserIdentifier {
			get {
				if (_UserIdentifier is null)
					_UserIdentifier = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileUserIdentifierKey")!;
				return _UserIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Username;
		/// <summary>The key associated with <see cref="Contacts.CNSocialProfileOption.Username" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNSocialProfileUsernameKey",  "Contacts")]
		public static NSString Username {
			get {
				if (_Username is null)
					_Username = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNSocialProfileUsernameKey")!;
				return _Username;
			}
		}
	} /* class CNSocialProfileKey */
}
