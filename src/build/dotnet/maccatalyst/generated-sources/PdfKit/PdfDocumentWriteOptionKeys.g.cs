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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class PdfDocumentWriteOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccessPermissionsKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentAccessPermissionsOption'.</summary>
		[Field ("PDFDocumentAccessPermissionsOption",  "PDFKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString AccessPermissionsKey {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_AccessPermissionsKey is null)
					_AccessPermissionsKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentAccessPermissionsOption")!;
				return _AccessPermissionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BurnInAnnotationsKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentBurnInAnnotationsOption'.</summary>
		[Field ("PDFDocumentBurnInAnnotationsOption",  "PDFKit")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString BurnInAnnotationsKey {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_BurnInAnnotationsKey is null)
					_BurnInAnnotationsKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentBurnInAnnotationsOption")!;
				return _BurnInAnnotationsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptimizeImagesForScreenKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentOptimizeImagesForScreenOption'.</summary>
		[Field ("PDFDocumentOptimizeImagesForScreenOption",  "PDFKit")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString OptimizeImagesForScreenKey {
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_OptimizeImagesForScreenKey is null)
					_OptimizeImagesForScreenKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentOptimizeImagesForScreenOption")!;
				return _OptimizeImagesForScreenKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OwnerPasswordKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentOwnerPasswordOption'.</summary>
		[Field ("PDFDocumentOwnerPasswordOption",  "PDFKit")]
		public static NSString OwnerPasswordKey {
			get {
				if (_OwnerPasswordKey is null)
					_OwnerPasswordKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentOwnerPasswordOption")!;
				return _OwnerPasswordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SaveImagesAsJpegKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentSaveImagesAsJPEGOption'.</summary>
		[Field ("PDFDocumentSaveImagesAsJPEGOption",  "PDFKit")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString SaveImagesAsJpegKey {
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_SaveImagesAsJpegKey is null)
					_SaveImagesAsJpegKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentSaveImagesAsJPEGOption")!;
				return _SaveImagesAsJpegKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SaveTextFromOcrKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentSaveTextFromOCROption'.</summary>
		[Field ("PDFDocumentSaveTextFromOCROption",  "PDFKit")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString SaveTextFromOcrKey {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_SaveTextFromOcrKey is null)
					_SaveTextFromOcrKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentSaveTextFromOCROption")!;
				return _SaveTextFromOcrKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserPasswordKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentUserPasswordOption'.</summary>
		[Field ("PDFDocumentUserPasswordOption",  "PDFKit")]
		public static NSString UserPasswordKey {
			get {
				if (_UserPasswordKey is null)
					_UserPasswordKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentUserPasswordOption")!;
				return _UserPasswordKey;
			}
		}
	} /* class PdfDocumentWriteOptionKeys */
}
