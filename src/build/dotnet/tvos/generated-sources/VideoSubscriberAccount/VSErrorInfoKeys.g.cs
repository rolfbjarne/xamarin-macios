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
namespace VideoSubscriberAccount {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class VSErrorInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccountProviderResponseKey;
		/// <summary>Represents the value associated with the constant 'VSErrorInfoKeyAccountProviderResponse'.</summary>
		[Field ("VSErrorInfoKeyAccountProviderResponse",  "VideoSubscriberAccount")]
		public static NSString AccountProviderResponseKey {
			get {
				if (_AccountProviderResponseKey is null)
					_AccountProviderResponseKey = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeyAccountProviderResponse")!;
				return _AccountProviderResponseKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SamlResponseKey;
		/// <summary>Represents the value associated with the constant 'VSErrorInfoKeySAMLResponse'.</summary>
		[Field ("VSErrorInfoKeySAMLResponse",  "VideoSubscriberAccount")]
		public static NSString SamlResponseKey {
			get {
				if (_SamlResponseKey is null)
					_SamlResponseKey = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeySAMLResponse")!;
				return _SamlResponseKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SamlResponseStatusKey;
		/// <summary>Represents the value associated with the constant 'VSErrorInfoKeySAMLResponseStatus'.</summary>
		[Field ("VSErrorInfoKeySAMLResponseStatus",  "VideoSubscriberAccount")]
		public static NSString SamlResponseStatusKey {
			get {
				if (_SamlResponseStatusKey is null)
					_SamlResponseStatusKey = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeySAMLResponseStatus")!;
				return _SamlResponseStatusKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnsupportedProviderIdentifierKey;
		/// <summary>Represents the value associated with the constant 'VSErrorInfoKeyUnsupportedProviderIdentifier'.</summary>
		[Field ("VSErrorInfoKeyUnsupportedProviderIdentifier",  "VideoSubscriberAccount")]
		public static NSString UnsupportedProviderIdentifierKey {
			get {
				if (_UnsupportedProviderIdentifierKey is null)
					_UnsupportedProviderIdentifierKey = Dlfcn.GetStringConstant (Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeyUnsupportedProviderIdentifier")!;
				return _UnsupportedProviderIdentifierKey;
			}
		}
	} /* class VSErrorInfoKeys */
}
