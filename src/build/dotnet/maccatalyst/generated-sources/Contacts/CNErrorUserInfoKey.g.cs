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
namespace Contacts {
	/// <summary>Provides string constants whose values identify the form of an error.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNErrorUserInfoKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AffectedRecordIdentifiers;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNErrorUserInfoAffectedRecordIdentifiersKey",  "Contacts")]
		public static NSString AffectedRecordIdentifiers {
			get {
				if (_AffectedRecordIdentifiers is null)
					_AffectedRecordIdentifiers = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNErrorUserInfoAffectedRecordIdentifiersKey")!;
				return _AffectedRecordIdentifiers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AffectedRecords;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNErrorUserInfoAffectedRecordsKey",  "Contacts")]
		public static NSString AffectedRecords {
			get {
				if (_AffectedRecords is null)
					_AffectedRecords = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNErrorUserInfoAffectedRecordsKey")!;
				return _AffectedRecords;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyPaths;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNErrorUserInfoKeyPathsKey",  "Contacts")]
		public static NSString KeyPaths {
			get {
				if (_KeyPaths is null)
					_KeyPaths = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNErrorUserInfoKeyPathsKey")!;
				return _KeyPaths;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValidationErrors;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNErrorUserInfoValidationErrorsKey",  "Contacts")]
		public static NSString ValidationErrors {
			get {
				if (_ValidationErrors is null)
					_ValidationErrors = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNErrorUserInfoValidationErrorsKey")!;
				return _ValidationErrors;
			}
		}
	} /* class CNErrorUserInfoKey */
}
