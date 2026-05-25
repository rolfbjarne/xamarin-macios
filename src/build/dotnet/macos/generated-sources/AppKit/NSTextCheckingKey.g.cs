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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class NSTextCheckingKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentAuthorKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingDocumentAuthorKey'.</summary>
		[Field ("NSTextCheckingDocumentAuthorKey",  "AppKit")]
		public static NSString DocumentAuthorKey {
			get {
				if (_DocumentAuthorKey is null)
					_DocumentAuthorKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentAuthorKey")!;
				return _DocumentAuthorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentTitleKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingDocumentTitleKey'.</summary>
		[Field ("NSTextCheckingDocumentTitleKey",  "AppKit")]
		public static NSString DocumentTitleKey {
			get {
				if (_DocumentTitleKey is null)
					_DocumentTitleKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentTitleKey")!;
				return _DocumentTitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentUrlKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingDocumentURLKey'.</summary>
		[Field ("NSTextCheckingDocumentURLKey",  "AppKit")]
		public static NSString DocumentUrlKey {
			get {
				if (_DocumentUrlKey is null)
					_DocumentUrlKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentURLKey")!;
				return _DocumentUrlKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrthographyKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingOrthographyKey'.</summary>
		[Field ("NSTextCheckingOrthographyKey",  "AppKit")]
		public static NSString OrthographyKey {
			get {
				if (_OrthographyKey is null)
					_OrthographyKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingOrthographyKey")!;
				return _OrthographyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuotesKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingQuotesKey'.</summary>
		[Field ("NSTextCheckingQuotesKey",  "AppKit")]
		public static NSString QuotesKey {
			get {
				if (_QuotesKey is null)
					_QuotesKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingQuotesKey")!;
				return _QuotesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceDateKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingReferenceDateKey'.</summary>
		[Field ("NSTextCheckingReferenceDateKey",  "AppKit")]
		public static NSString ReferenceDateKey {
			get {
				if (_ReferenceDateKey is null)
					_ReferenceDateKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReferenceDateKey")!;
				return _ReferenceDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceTimeZoneKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingReferenceTimeZoneKey'.</summary>
		[Field ("NSTextCheckingReferenceTimeZoneKey",  "AppKit")]
		public static NSString ReferenceTimeZoneKey {
			get {
				if (_ReferenceTimeZoneKey is null)
					_ReferenceTimeZoneKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReferenceTimeZoneKey")!;
				return _ReferenceTimeZoneKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReplacementsKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingReplacementsKey'.</summary>
		[Field ("NSTextCheckingReplacementsKey",  "AppKit")]
		public static NSString ReplacementsKey {
			get {
				if (_ReplacementsKey is null)
					_ReplacementsKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReplacementsKey")!;
				return _ReplacementsKey;
			}
		}
	} /* class NSTextCheckingKey */
}
