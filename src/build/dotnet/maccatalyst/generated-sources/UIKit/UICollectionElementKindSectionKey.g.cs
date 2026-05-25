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
namespace UIKit {
	/// <summary>Constants relating to <see cref="T:UIKit.UICollectionElementKindSection" />.</summary><remarks>To be added.</remarks><altmember cref="T:UIKit.UICollectionElementKindSection" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UICollectionElementKindSectionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Footer;
		/// <summary>Represents the value associated with the constant UICollectionElementKindSectionFooter</summary><value></value><remarks>To be added.</remarks>
		[Field ("UICollectionElementKindSectionFooter",  "UIKit")]
		public static NSString Footer {
			get {
				if (_Footer is null)
					_Footer = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UICollectionElementKindSectionFooter")!;
				return _Footer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Header;
		/// <summary>Represents the value associated with the constant UICollectionElementKindSectionHeader</summary><value></value><remarks>To be added.</remarks>
		[Field ("UICollectionElementKindSectionHeader",  "UIKit")]
		public static NSString Header {
			get {
				if (_Header is null)
					_Header = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UICollectionElementKindSectionHeader")!;
				return _Header;
			}
		}
	} /* class UICollectionElementKindSectionKey */
}
