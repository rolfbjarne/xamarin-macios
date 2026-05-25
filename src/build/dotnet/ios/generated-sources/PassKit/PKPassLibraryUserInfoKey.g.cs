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
namespace PassKit {
	/// <summary>A class whose static members represent keys to be used with the <see cref="M:PassKit.PKPass.GetLocalizedValue(Foundation.NSString)" /> method.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PKPassLibraryUserInfoKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddedPasses;
		/// <summary>Represents the value associated with the constant PKPassLibraryAddedPassesUserInfoKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPassLibraryAddedPassesUserInfoKey",  "PassKit")]
		public static NSString AddedPasses {
			get {
				if (_AddedPasses is null)
					_AddedPasses = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryAddedPassesUserInfoKey")!;
				return _AddedPasses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PassTypeIdentifier;
		/// <summary>Represents the value associated with the constant PKPassLibraryPassTypeIdentifierUserInfoKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPassLibraryPassTypeIdentifierUserInfoKey",  "PassKit")]
		public static NSString PassTypeIdentifier {
			get {
				if (_PassTypeIdentifier is null)
					_PassTypeIdentifier = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryPassTypeIdentifierUserInfoKey")!;
				return _PassTypeIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecoveredPasses;
		/// <summary>Represents the value associated with the constant 'PKPassLibraryRecoveredPassesUserInfoKey'.</summary>
		[Field ("PKPassLibraryRecoveredPassesUserInfoKey",  "PassKit")]
		[SupportedOSPlatform ("ios15.2")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("maccatalyst15.2")]
		public static NSString RecoveredPasses {
			[SupportedOSPlatform ("ios15.2")]
			[SupportedOSPlatform ("macos12.1")]
			[SupportedOSPlatform ("maccatalyst15.2")]
			get {
				if (_RecoveredPasses is null)
					_RecoveredPasses = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryRecoveredPassesUserInfoKey")!;
				return _RecoveredPasses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemovedPassInfos;
		/// <summary>Represents the value associated with the constant PKPassLibraryRemovedPassInfosUserInfoKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPassLibraryRemovedPassInfosUserInfoKey",  "PassKit")]
		public static NSString RemovedPassInfos {
			get {
				if (_RemovedPassInfos is null)
					_RemovedPassInfos = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryRemovedPassInfosUserInfoKey")!;
				return _RemovedPassInfos;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReplacementPasses;
		/// <summary>Represents the value associated with the constant PKPassLibraryReplacementPassesUserInfoKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPassLibraryReplacementPassesUserInfoKey",  "PassKit")]
		public static NSString ReplacementPasses {
			get {
				if (_ReplacementPasses is null)
					_ReplacementPasses = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryReplacementPassesUserInfoKey")!;
				return _ReplacementPasses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SerialNumber;
		/// <summary>Represents the value associated with the constant PKPassLibrarySerialNumberUserInfoKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPassLibrarySerialNumberUserInfoKey",  "PassKit")]
		public static NSString SerialNumber {
			get {
				if (_SerialNumber is null)
					_SerialNumber = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibrarySerialNumberUserInfoKey")!;
				return _SerialNumber;
			}
		}
	} /* class PKPassLibraryUserInfoKey */
}
