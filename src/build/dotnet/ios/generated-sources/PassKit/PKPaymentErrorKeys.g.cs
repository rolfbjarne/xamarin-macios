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
namespace PassKit {
	/// <summary>Enumerates fields that caused payment errors.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class PKPaymentErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContactFieldUserInfoKey;
		/// <summary>Gets a key that identifies the contact field as the source of the error.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentErrorContactFieldUserInfoKey",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContactFieldUserInfoKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContactFieldUserInfoKey is null)
					_ContactFieldUserInfoKey = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentErrorContactFieldUserInfoKey")!;
				return _ContactFieldUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostalAddressUserInfoKey;
		/// <summary>Gets a key that identifies the postal address field as the source of the error.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentErrorPostalAddressUserInfoKey",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString PostalAddressUserInfoKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PostalAddressUserInfoKey is null)
					_PostalAddressUserInfoKey = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentErrorPostalAddressUserInfoKey")!;
				return _PostalAddressUserInfoKey;
			}
		}
	} /* class PKPaymentErrorKeys */
}
