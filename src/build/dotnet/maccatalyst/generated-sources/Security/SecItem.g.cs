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
	internal unsafe static partial class SecItem  {
		/// <summary>Represents the value associated with the constant 'kSecMatchCaseInsensitive'.</summary>
		[Field ("kSecMatchCaseInsensitive",  "Security")]
		public static nint MatchCaseInsensitive {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchCaseInsensitive");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchEmailAddressIfPresent'.</summary>
		[Field ("kSecMatchEmailAddressIfPresent",  "Security")]
		public static nint MatchEmailAddressIfPresent {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchEmailAddressIfPresent");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchHostOrSubdomainOfHost'.</summary>
		[Field ("kSecMatchHostOrSubdomainOfHost",  "Security")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static nint MatchHostOrSubdomainOfHost {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchHostOrSubdomainOfHost");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchIssuers'.</summary>
		[Field ("kSecMatchIssuers",  "Security")]
		public static nint MatchIssuers {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchIssuers");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchItemList'.</summary>
		[Field ("kSecMatchItemList",  "Security")]
		public static nint MatchItemList {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchItemList");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchLimit'.</summary>
		[Field ("kSecMatchLimit",  "Security")]
		public static nint MatchLimit {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchLimit");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchPolicy'.</summary>
		[Field ("kSecMatchPolicy",  "Security")]
		public static nint MatchPolicy {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchPolicy");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchSearchList'.</summary>
		[Field ("kSecMatchSearchList",  "Security")]
		public static nint MatchSearchList {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchSearchList");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchSubjectContains'.</summary>
		[Field ("kSecMatchSubjectContains",  "Security")]
		public static nint MatchSubjectContains {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchSubjectContains");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchTrustedOnly'.</summary>
		[Field ("kSecMatchTrustedOnly",  "Security")]
		public static nint MatchTrustedOnly {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchTrustedOnly");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecMatchValidOnDate'.</summary>
		[Field ("kSecMatchValidOnDate",  "Security")]
		public static nint MatchValidOnDate {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchValidOnDate");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecReturnAttributes'.</summary>
		[Field ("kSecReturnAttributes",  "Security")]
		public static nint ReturnAttributes {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecReturnAttributes");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecReturnData'.</summary>
		[Field ("kSecReturnData",  "Security")]
		public static nint ReturnData {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecReturnData");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecReturnPersistentRef'.</summary>
		[Field ("kSecReturnPersistentRef",  "Security")]
		public static nint ReturnPersistentRef {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecReturnPersistentRef");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecReturnRef'.</summary>
		[Field ("kSecReturnRef",  "Security")]
		public static nint ReturnRef {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecReturnRef");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseAuthenticationContext'.</summary>
		[Field ("kSecUseAuthenticationContext",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint UseAuthenticationContext {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseAuthenticationContext");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseAuthenticationUI'.</summary>
		[Field ("kSecUseAuthenticationUI",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint UseAuthenticationUI {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseAuthenticationUI");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseDataProtectionKeychain'.</summary>
		[Field ("kSecUseDataProtectionKeychain",  "Security")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static nint UseDataProtectionKeychain {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseDataProtectionKeychain");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseItemList'.</summary>
		[Field ("kSecUseItemList",  "Security")]
		public static nint UseItemList {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseItemList");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseNoAuthenticationUI'.</summary>
		[Field ("kSecUseNoAuthenticationUI",  "Security")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint UseNoAuthenticationUI {
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[ObsoletedOSPlatform ("tvos9.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseNoAuthenticationUI");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecUseOperationPrompt'.</summary>
		[Field ("kSecUseOperationPrompt",  "Security")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint UseOperationPrompt {
			[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
			[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecUseOperationPrompt");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecValueData'.</summary>
		[Field ("kSecValueData",  "Security")]
		public static nint ValueData {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecValueData");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecValuePersistentRef'.</summary>
		[Field ("kSecValuePersistentRef",  "Security")]
		public static nint ValuePersistentRef {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecValuePersistentRef");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecValueRef'.</summary>
		[Field ("kSecValueRef",  "Security")]
		public static nint ValueRef {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecValueRef");
			}
		}
	} /* class SecItem */
}
