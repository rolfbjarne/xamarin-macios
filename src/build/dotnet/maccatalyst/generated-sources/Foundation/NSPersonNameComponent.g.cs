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
namespace Foundation {
	/// <summary>Represents the components of a person name.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NSPersonNameComponent  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComponentKey;
		/// <summary>Gets the key for the name component.</summary><value>The key for the name component.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentKey",  "Foundation")]
		public static NSString ComponentKey {
			get {
				if (_ComponentKey is null)
					_ComponentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentKey")!;
				return _ComponentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Delimiter;
		/// <summary>Gets the delimiter.</summary><value>The delimiter.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentDelimiter",  "Foundation")]
		public static NSString Delimiter {
			get {
				if (_Delimiter is null)
					_Delimiter = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentDelimiter")!;
				return _Delimiter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyName;
		/// <summary>Gets the person's family name.</summary><value>The person's family name.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentFamilyName",  "Foundation")]
		public static NSString FamilyName {
			get {
				if (_FamilyName is null)
					_FamilyName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentFamilyName")!;
				return _FamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GivenName;
		/// <summary>Gets the person's given name.</summary><value>The person's given name.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentGivenName",  "Foundation")]
		public static NSString GivenName {
			get {
				if (_GivenName is null)
					_GivenName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentGivenName")!;
				return _GivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MiddleName;
		/// <summary>Gets the person's middle name.</summary><value>The person's middle name.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentMiddleName",  "Foundation")]
		public static NSString MiddleName {
			get {
				if (_MiddleName is null)
					_MiddleName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentMiddleName")!;
				return _MiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nickname;
		/// <summary>Gets the person's nickname.</summary><value>The person's nickname.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentNickname",  "Foundation")]
		public static NSString Nickname {
			get {
				if (_Nickname is null)
					_Nickname = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentNickname")!;
				return _Nickname;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Prefix;
		/// <summary>Gets the prefix to the person's name.</summary><value>The prefix to the person's name.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentPrefix",  "Foundation")]
		public static NSString Prefix {
			get {
				if (_Prefix is null)
					_Prefix = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentPrefix")!;
				return _Prefix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Suffix;
		/// <summary>Gets the suffix to the person's name.</summary><value>The suffix to the person's name.</value><remarks>To be added.</remarks>
		[Field ("NSPersonNameComponentSuffix",  "Foundation")]
		public static NSString Suffix {
			get {
				if (_Suffix is null)
					_Suffix = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPersonNameComponentSuffix")!;
				return _Suffix;
			}
		}
	} /* class NSPersonNameComponent */
}
