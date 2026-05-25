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
namespace CloudKit {
	/// <summary>Holds error constants used by CloudKit.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CKErrorFields  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorRetryAfterKey;
		/// <summary>Represents the value associated with the constant CKErrorRetryAfterKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKErrorRetryAfterKey",  "CloudKit")]
		public static NSString ErrorRetryAfterKey {
			get {
				if (_ErrorRetryAfterKey is null)
					_ErrorRetryAfterKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKErrorRetryAfterKey")!;
				return _ErrorRetryAfterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PartialErrorsByItemIdKey;
		/// <summary>Represents the value associated with the constant CKPartialErrorsByItemIDKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKPartialErrorsByItemIDKey",  "CloudKit")]
		public static NSString PartialErrorsByItemIdKey {
			get {
				if (_PartialErrorsByItemIdKey is null)
					_PartialErrorsByItemIdKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKPartialErrorsByItemIDKey")!;
				return _PartialErrorsByItemIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordChangedErrorAncestorRecordKey;
		/// <summary>Represents the value associated with the constant CKRecordChangedErrorAncestorRecordKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKRecordChangedErrorAncestorRecordKey",  "CloudKit")]
		public static NSString RecordChangedErrorAncestorRecordKey {
			get {
				if (_RecordChangedErrorAncestorRecordKey is null)
					_RecordChangedErrorAncestorRecordKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordChangedErrorAncestorRecordKey")!;
				return _RecordChangedErrorAncestorRecordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordChangedErrorClientRecordKey;
		/// <summary>Represents the value associated with the constant CKRecordChangedErrorClientRecordKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKRecordChangedErrorClientRecordKey",  "CloudKit")]
		public static NSString RecordChangedErrorClientRecordKey {
			get {
				if (_RecordChangedErrorClientRecordKey is null)
					_RecordChangedErrorClientRecordKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordChangedErrorClientRecordKey")!;
				return _RecordChangedErrorClientRecordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordChangedErrorServerRecordKey;
		/// <summary>Represents the value associated with the constant CKRecordChangedErrorServerRecordKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKRecordChangedErrorServerRecordKey",  "CloudKit")]
		public static NSString RecordChangedErrorServerRecordKey {
			get {
				if (_RecordChangedErrorServerRecordKey is null)
					_RecordChangedErrorServerRecordKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordChangedErrorServerRecordKey")!;
				return _RecordChangedErrorServerRecordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserDidResetEncryptedDataKey;
		/// <summary>Represents the value associated with the constant 'CKErrorUserDidResetEncryptedDataKey'.</summary>
		[Field ("CKErrorUserDidResetEncryptedDataKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UserDidResetEncryptedDataKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UserDidResetEncryptedDataKey is null)
					_UserDidResetEncryptedDataKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKErrorUserDidResetEncryptedDataKey")!;
				return _UserDidResetEncryptedDataKey;
			}
		}
	} /* class CKErrorFields */
}
