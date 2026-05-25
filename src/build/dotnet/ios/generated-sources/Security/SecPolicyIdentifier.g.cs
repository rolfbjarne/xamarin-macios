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
namespace Security {
	/// <summary>Contains values that represent security policies.</summary><remarks>To be added.</remarks>
	public unsafe static partial class SecPolicyIdentifier  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleCodeSigning;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleCodeSigning</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleCodeSigning",  "Security")]
		public static NSString AppleCodeSigning {
			get {
				if (_AppleCodeSigning is null)
					_AppleCodeSigning = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleCodeSigning")!;
				return _AppleCodeSigning;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleEAP;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleEAP</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleEAP",  "Security")]
		public static NSString AppleEAP {
			get {
				if (_AppleEAP is null)
					_AppleEAP = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleEAP")!;
				return _AppleEAP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleEapClient;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleEAPClient'.</summary>
		[Field ("kSecPolicyAppleEAPClient",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleEapClient {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleEapClient is null)
					_AppleEapClient = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleEAPClient")!;
				return _AppleEapClient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleEapServer;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleEAPServer'.</summary>
		[Field ("kSecPolicyAppleEAPServer",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleEapServer {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleEapServer is null)
					_AppleEapServer = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleEAPServer")!;
				return _AppleEapServer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleIDValidation;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleIDValidation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleIDValidation",  "Security")]
		public static NSString AppleIDValidation {
			get {
				if (_AppleIDValidation is null)
					_AppleIDValidation = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleIDValidation")!;
				return _AppleIDValidation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleIPSecClient;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleIPSecClient'.</summary>
		[Field ("kSecPolicyAppleIPSecClient",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleIPSecClient {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleIPSecClient is null)
					_AppleIPSecClient = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleIPSecClient")!;
				return _AppleIPSecClient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleIPSecServer;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleIPSecServer'.</summary>
		[Field ("kSecPolicyAppleIPSecServer",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleIPSecServer {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleIPSecServer is null)
					_AppleIPSecServer = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleIPSecServer")!;
				return _AppleIPSecServer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleIPsec;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleIPsec</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleIPsec",  "Security")]
		public static NSString AppleIPsec {
			get {
				if (_AppleIPsec is null)
					_AppleIPsec = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleIPsec")!;
				return _AppleIPsec;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplePassbookSigning;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecPolicyApplePassbookSigning",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ApplePassbookSigning {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ApplePassbookSigning is null)
					_ApplePassbookSigning = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyApplePassbookSigning")!;
				return _ApplePassbookSigning;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplePayIssuerEncryption;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecPolicyApplePayIssuerEncryption",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ApplePayIssuerEncryption {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ApplePayIssuerEncryption is null)
					_ApplePayIssuerEncryption = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyApplePayIssuerEncryption")!;
				return _ApplePayIssuerEncryption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleRevocation;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleRevocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleRevocation",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AppleRevocation {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AppleRevocation is null)
					_AppleRevocation = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleRevocation")!;
				return _AppleRevocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleSMIME;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleSMIME</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleSMIME",  "Security")]
		public static NSString AppleSMIME {
			get {
				if (_AppleSMIME is null)
					_AppleSMIME = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleSMIME")!;
				return _AppleSMIME;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleSSL;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleSSL</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleSSL",  "Security")]
		public static NSString AppleSSL {
			get {
				if (_AppleSSL is null)
					_AppleSSL = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleSSL")!;
				return _AppleSSL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleSslClient;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleSSLClient'.</summary>
		[Field ("kSecPolicyAppleSSLClient",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleSslClient {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleSslClient is null)
					_AppleSslClient = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleSSLClient")!;
				return _AppleSslClient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleSslServer;
		/// <summary>Represents the value associated with the constant 'kSecPolicyAppleSSLServer'.</summary>
		[Field ("kSecPolicyAppleSSLServer",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString AppleSslServer {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_AppleSslServer is null)
					_AppleSslServer = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleSSLServer")!;
				return _AppleSslServer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleTimeStamping;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleTimeStamping</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleTimeStamping",  "Security")]
		public static NSString AppleTimeStamping {
			get {
				if (_AppleTimeStamping is null)
					_AppleTimeStamping = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleTimeStamping")!;
				return _AppleTimeStamping;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleX509Basic;
		/// <summary>Represents the value associated with the constant kSecPolicyAppleX509Basic</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyAppleX509Basic",  "Security")]
		public static NSString AppleX509Basic {
			get {
				if (_AppleX509Basic is null)
					_AppleX509Basic = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyAppleX509Basic")!;
				return _AppleX509Basic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MacAppStoreReceipt;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecPolicyMacAppStoreReceipt",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MacAppStoreReceipt {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MacAppStoreReceipt is null)
					_MacAppStoreReceipt = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyMacAppStoreReceipt")!;
				return _MacAppStoreReceipt;
			}
		}
	} /* class SecPolicyIdentifier */
}
