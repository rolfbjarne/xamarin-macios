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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVStreamingKeyDelivery  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentKeyType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVStreamingKeyDeliveryContentKeyType",  "AVFoundation")]
		public static NSString ContentKeyType {
			get {
				if (_ContentKeyType is null)
					_ContentKeyType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVStreamingKeyDeliveryContentKeyType")!;
				return _ContentKeyType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersistentContentKeyType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVStreamingKeyDeliveryPersistentContentKeyType",  "AVFoundation")]
		public static NSString PersistentContentKeyType {
			get {
				if (_PersistentContentKeyType is null)
					_PersistentContentKeyType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVStreamingKeyDeliveryPersistentContentKeyType")!;
				return _PersistentContentKeyType;
			}
		}
	} /* class AVStreamingKeyDelivery */
}
