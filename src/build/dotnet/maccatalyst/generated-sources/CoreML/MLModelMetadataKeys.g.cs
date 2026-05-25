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
namespace CoreML {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class MLModelMetadataKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorKey;
		/// <summary>Represents the value associated with the constant 'MLModelAuthorKey'.</summary>
		[Field ("MLModelAuthorKey",  "CoreML")]
		public static NSString AuthorKey {
			get {
				if (_AuthorKey is null)
					_AuthorKey = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelAuthorKey")!;
				return _AuthorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreatorDefinedKey;
		/// <summary>Represents the value associated with the constant 'MLModelCreatorDefinedKey'.</summary>
		[Field ("MLModelCreatorDefinedKey",  "CoreML")]
		public static NSString CreatorDefinedKey {
			get {
				if (_CreatorDefinedKey is null)
					_CreatorDefinedKey = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelCreatorDefinedKey")!;
				return _CreatorDefinedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescriptionKey;
		/// <summary>Represents the value associated with the constant 'MLModelDescriptionKey'.</summary>
		[Field ("MLModelDescriptionKey",  "CoreML")]
		public static NSString DescriptionKey {
			get {
				if (_DescriptionKey is null)
					_DescriptionKey = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelDescriptionKey")!;
				return _DescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LicenseKey;
		/// <summary>Represents the value associated with the constant 'MLModelLicenseKey'.</summary>
		[Field ("MLModelLicenseKey",  "CoreML")]
		public static NSString LicenseKey {
			get {
				if (_LicenseKey is null)
					_LicenseKey = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelLicenseKey")!;
				return _LicenseKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VersionStringKey;
		/// <summary>Represents the value associated with the constant 'MLModelVersionStringKey'.</summary>
		[Field ("MLModelVersionStringKey",  "CoreML")]
		public static NSString VersionStringKey {
			get {
				if (_VersionStringKey is null)
					_VersionStringKey = Dlfcn.GetStringConstant (Libraries.CoreML.Handle, "MLModelVersionStringKey")!;
				return _VersionStringKey;
			}
		}
	} /* class MLModelMetadataKeys */
}
