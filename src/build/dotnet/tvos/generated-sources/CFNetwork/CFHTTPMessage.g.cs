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
namespace CFNetwork {
	/// <summary>An HTTP message.</summary>
	public unsafe partial class CFHTTPMessage  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AuthenticationAccountDomain;
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationAccountDomain'.</summary>
		[Field ("kCFHTTPAuthenticationAccountDomain",  "CFNetwork")]
		internal static NSString _AuthenticationAccountDomain {
			get {
				if (__AuthenticationAccountDomain is null)
					__AuthenticationAccountDomain = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationAccountDomain")!;
				return __AuthenticationAccountDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AuthenticationPassword;
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationPassword'.</summary>
		[Field ("kCFHTTPAuthenticationPassword",  "CFNetwork")]
		internal static NSString _AuthenticationPassword {
			get {
				if (__AuthenticationPassword is null)
					__AuthenticationPassword = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationPassword")!;
				return __AuthenticationPassword;
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationSchemeBasic'.</summary>
		[Field ("kCFHTTPAuthenticationSchemeBasic",  "CFNetwork")]
		internal static nint _AuthenticationSchemeBasic {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeBasic");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationSchemeDigest'.</summary>
		[Field ("kCFHTTPAuthenticationSchemeDigest",  "CFNetwork")]
		internal static nint _AuthenticationSchemeDigest {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeDigest");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationSchemeNTLM'.</summary>
		[Field ("kCFHTTPAuthenticationSchemeNTLM",  "CFNetwork")]
		internal static nint _AuthenticationSchemeNTLM {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeNTLM");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationSchemeNegotiate'.</summary>
		[Field ("kCFHTTPAuthenticationSchemeNegotiate",  "CFNetwork")]
		internal static nint _AuthenticationSchemeNegotiate {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeNegotiate");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AuthenticationUsername;
		/// <summary>Represents the value associated with the constant 'kCFHTTPAuthenticationUsername'.</summary>
		[Field ("kCFHTTPAuthenticationUsername",  "CFNetwork")]
		internal static NSString _AuthenticationUsername {
			get {
				if (__AuthenticationUsername is null)
					__AuthenticationUsername = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationUsername")!;
				return __AuthenticationUsername;
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPVersion1_0'.</summary>
		[Field ("kCFHTTPVersion1_0",  "CFNetwork")]
		internal static nint _HTTPVersion1_0 {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPVersion1_0");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPVersion1_1'.</summary>
		[Field ("kCFHTTPVersion1_1",  "CFNetwork")]
		internal static nint _HTTPVersion1_1 {
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPVersion1_1");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPVersion2_0'.</summary>
		[Field ("kCFHTTPVersion2_0",  "CFNetwork")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static nint _HTTPVersion2_0 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPVersion2_0");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCFHTTPVersion3_0'.</summary>
		[Field ("kCFHTTPVersion3_0",  "CFNetwork")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal static nint _HTTPVersion3_0 {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.CFNetwork.Handle, "kCFHTTPVersion3_0");
			}
		}
	} /* class CFHTTPMessage */
}
