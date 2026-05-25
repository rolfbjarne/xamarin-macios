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
	internal unsafe static partial class PdfDocumentAttributeKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentAuthorAttribute'.</summary>
		[Field ("PDFDocumentAuthorAttribute",  "PDFKit")]
		public static NSString AuthorKey {
			get {
				if (_AuthorKey is null)
					_AuthorKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentAuthorAttribute")!;
				return _AuthorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreationDateKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentCreationDateAttribute'.</summary>
		[Field ("PDFDocumentCreationDateAttribute",  "PDFKit")]
		public static NSString CreationDateKey {
			get {
				if (_CreationDateKey is null)
					_CreationDateKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentCreationDateAttribute")!;
				return _CreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreatorKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentCreatorAttribute'.</summary>
		[Field ("PDFDocumentCreatorAttribute",  "PDFKit")]
		public static NSString CreatorKey {
			get {
				if (_CreatorKey is null)
					_CreatorKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentCreatorAttribute")!;
				return _CreatorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeywordsKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentKeywordsAttribute'.</summary>
		[Field ("PDFDocumentKeywordsAttribute",  "PDFKit")]
		public static NSString KeywordsKey {
			get {
				if (_KeywordsKey is null)
					_KeywordsKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentKeywordsAttribute")!;
				return _KeywordsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModificationDateKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentModificationDateAttribute'.</summary>
		[Field ("PDFDocumentModificationDateAttribute",  "PDFKit")]
		public static NSString ModificationDateKey {
			get {
				if (_ModificationDateKey is null)
					_ModificationDateKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentModificationDateAttribute")!;
				return _ModificationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProducerKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentProducerAttribute'.</summary>
		[Field ("PDFDocumentProducerAttribute",  "PDFKit")]
		public static NSString ProducerKey {
			get {
				if (_ProducerKey is null)
					_ProducerKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentProducerAttribute")!;
				return _ProducerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubjectKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentSubjectAttribute'.</summary>
		[Field ("PDFDocumentSubjectAttribute",  "PDFKit")]
		public static NSString SubjectKey {
			get {
				if (_SubjectKey is null)
					_SubjectKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentSubjectAttribute")!;
				return _SubjectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentTitleAttribute'.</summary>
		[Field ("PDFDocumentTitleAttribute",  "PDFKit")]
		public static NSString TitleKey {
			get {
				if (_TitleKey is null)
					_TitleKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentTitleAttribute")!;
				return _TitleKey;
			}
		}
	} /* class PdfDocumentAttributeKeys */
}
