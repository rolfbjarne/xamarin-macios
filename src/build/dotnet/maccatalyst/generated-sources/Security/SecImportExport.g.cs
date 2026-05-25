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
	public unsafe partial class SecImportExport  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CertChain;
		/// <summary>Represents the value associated with the constant kSecImportItemCertChain</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportItemCertChain",  "Security")]
		public static NSString CertChain {
			get {
				if (_CertChain is null)
					_CertChain = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportItemCertChain")!;
				return _CertChain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identity;
		/// <summary>Represents the value associated with the constant kSecImportItemIdentity</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportItemIdentity",  "Security")]
		public static NSString Identity {
			get {
				if (_Identity is null)
					_Identity = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportItemIdentity")!;
				return _Identity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyId;
		/// <summary>Represents the value associated with the constant kSecImportItemKeyID</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportItemKeyID",  "Security")]
		public static NSString KeyId {
			get {
				if (_KeyId is null)
					_KeyId = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportItemKeyID")!;
				return _KeyId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Label;
		/// <summary>Represents the value associated with the constant kSecImportItemLabel</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportItemLabel",  "Security")]
		public static NSString Label {
			get {
				if (_Label is null)
					_Label = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportItemLabel")!;
				return _Label;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Passphrase;
		/// <summary>Represents the value associated with the constant kSecImportExportPassphrase</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportExportPassphrase",  "Security")]
		public static NSString Passphrase {
			get {
				if (_Passphrase is null)
					_Passphrase = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportExportPassphrase")!;
				return _Passphrase;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToMemoryOnly;
		/// <summary>Represents the value associated with the constant 'kSecImportToMemoryOnly'.</summary>
		[Field ("kSecImportToMemoryOnly",  "Security")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ToMemoryOnly {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ToMemoryOnly is null)
					_ToMemoryOnly = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportToMemoryOnly")!;
				return _ToMemoryOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Trust;
		/// <summary>Represents the value associated with the constant kSecImportItemTrust</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecImportItemTrust",  "Security")]
		public static NSString Trust {
			get {
				if (_Trust is null)
					_Trust = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecImportItemTrust")!;
				return _Trust;
			}
		}
	} /* class SecImportExport */
}
