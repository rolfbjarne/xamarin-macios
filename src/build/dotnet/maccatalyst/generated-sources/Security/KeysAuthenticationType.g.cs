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
namespace Security {
	internal unsafe static partial class KeysAuthenticationType  {
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeDPA'.</summary>
		[Field ("kSecAttrAuthenticationTypeDPA",  "Security")]
		public static nint DPA {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeDPA");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeDefault'.</summary>
		[Field ("kSecAttrAuthenticationTypeDefault",  "Security")]
		public static nint Default {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeDefault");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeHTMLForm'.</summary>
		[Field ("kSecAttrAuthenticationTypeHTMLForm",  "Security")]
		public static nint HTMLForm {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTMLForm");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeHTTPBasic'.</summary>
		[Field ("kSecAttrAuthenticationTypeHTTPBasic",  "Security")]
		public static nint HTTPBasic {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTTPBasic");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeHTTPDigest'.</summary>
		[Field ("kSecAttrAuthenticationTypeHTTPDigest",  "Security")]
		public static nint HTTPDigest {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTTPDigest");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeMSN'.</summary>
		[Field ("kSecAttrAuthenticationTypeMSN",  "Security")]
		public static nint MSN {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeMSN");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeNTLM'.</summary>
		[Field ("kSecAttrAuthenticationTypeNTLM",  "Security")]
		public static nint NTLM {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeNTLM");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationTypeRPA'.</summary>
		[Field ("kSecAttrAuthenticationTypeRPA",  "Security")]
		public static nint RPA {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationTypeRPA");
			}
		}
	} /* class KeysAuthenticationType */
}
