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
	/// <summary>Contains keys that index trust data.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SecTrustResultKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CertificateTransparency;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecTrustCertificateTransparency",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CertificateTransparency {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CertificateTransparency is null)
					_CertificateTransparency = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustCertificateTransparency")!;
				return _CertificateTransparency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CertificateTransparencyWhiteList;
		/// <summary>Developers should not use this deprecated property. </summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecTrustCertificateTransparencyWhiteList",  "Security")]
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CertificateTransparencyWhiteList {
			[ObsoletedOSPlatform ("ios11.0")]
			[ObsoletedOSPlatform ("macos10.13")]
			[ObsoletedOSPlatform ("tvos11.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CertificateTransparencyWhiteList is null)
					_CertificateTransparencyWhiteList = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustCertificateTransparencyWhiteList")!;
				return _CertificateTransparencyWhiteList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EvaluationDate;
		/// <summary>Represents the value associated with the constant kSecTrustEvaluationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustEvaluationDate",  "Security")]
		public static NSString EvaluationDate {
			get {
				if (_EvaluationDate is null)
					_EvaluationDate = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustEvaluationDate")!;
				return _EvaluationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedValidation;
		/// <summary>Represents the value associated with the constant kSecTrustExtendedValidation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustExtendedValidation",  "Security")]
		public static NSString ExtendedValidation {
			get {
				if (_ExtendedValidation is null)
					_ExtendedValidation = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustExtendedValidation")!;
				return _ExtendedValidation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationName;
		/// <summary>Represents the value associated with the constant kSecTrustOrganizationName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustOrganizationName",  "Security")]
		public static NSString OrganizationName {
			get {
				if (_OrganizationName is null)
					_OrganizationName = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustOrganizationName")!;
				return _OrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QCStatements;
		/// <summary>Represents the value associated with the constant 'kSecTrustQCStatements'.</summary>
		[Field ("kSecTrustQCStatements",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString QCStatements {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_QCStatements is null)
					_QCStatements = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustQCStatements")!;
				return _QCStatements;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QwacValidation;
		/// <summary>Represents the value associated with the constant 'kSecTrustQWACValidation'.</summary>
		[Field ("kSecTrustQWACValidation",  "Security")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		public static NSString QwacValidation {
			[SupportedOSPlatform ("ios18.4")]
			[SupportedOSPlatform ("tvos18.4")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				if (_QwacValidation is null)
					_QwacValidation = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustQWACValidation")!;
				return _QwacValidation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultValue;
		/// <summary>Represents the value associated with the constant kSecTrustResultValue</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustResultValue",  "Security")]
		public static NSString ResultValue {
			get {
				if (_ResultValue is null)
					_ResultValue = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustResultValue")!;
				return _ResultValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RevocationChecked;
		/// <summary>Represents the value associated with the constant kSecTrustRevocationChecked</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustRevocationChecked",  "Security")]
		public static NSString RevocationChecked {
			get {
				if (_RevocationChecked is null)
					_RevocationChecked = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustRevocationChecked")!;
				return _RevocationChecked;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RevocationValidUntilDate;
		/// <summary>Represents the value associated with the constant kSecTrustRevocationValidUntilDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecTrustRevocationValidUntilDate",  "Security")]
		public static NSString RevocationValidUntilDate {
			get {
				if (_RevocationValidUntilDate is null)
					_RevocationValidUntilDate = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecTrustRevocationValidUntilDate")!;
				return _RevocationValidUntilDate;
			}
		}
	} /* class SecTrustResultKey */
}
