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
namespace ImageCaptureCore {
	public unsafe static partial class ICCameraDownloadOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeleteAfterSuccessfulDownload;
		/// <summary>Represents the value associated with the constant 'ICDeleteAfterSuccessfulDownload'.</summary>
		[Field ("ICDeleteAfterSuccessfulDownload",  "ImageCaptureCore")]
		public static NSString DeleteAfterSuccessfulDownload {
			get {
				if (_DeleteAfterSuccessfulDownload is null)
					_DeleteAfterSuccessfulDownload = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeleteAfterSuccessfulDownload")!;
				return _DeleteAfterSuccessfulDownload;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownloadSidecarFiles;
		/// <summary>Represents the value associated with the constant 'ICDownloadSidecarFiles'.</summary>
		[Field ("ICDownloadSidecarFiles",  "ImageCaptureCore")]
		public static NSString DownloadSidecarFiles {
			get {
				if (_DownloadSidecarFiles is null)
					_DownloadSidecarFiles = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDownloadSidecarFiles")!;
				return _DownloadSidecarFiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownloadsDirectoryUrl;
		/// <summary>Represents the value associated with the constant 'ICDownloadsDirectoryURL'.</summary>
		[Field ("ICDownloadsDirectoryURL",  "ImageCaptureCore")]
		public static NSString DownloadsDirectoryUrl {
			get {
				if (_DownloadsDirectoryUrl is null)
					_DownloadsDirectoryUrl = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDownloadsDirectoryURL")!;
				return _DownloadsDirectoryUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Overwrite;
		/// <summary>Represents the value associated with the constant 'ICOverwrite'.</summary>
		[Field ("ICOverwrite",  "ImageCaptureCore")]
		public static NSString Overwrite {
			get {
				if (_Overwrite is null)
					_Overwrite = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICOverwrite")!;
				return _Overwrite;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SaveAsFilename;
		/// <summary>Represents the value associated with the constant 'ICSaveAsFilename'.</summary>
		[Field ("ICSaveAsFilename",  "ImageCaptureCore")]
		public static NSString SaveAsFilename {
			get {
				if (_SaveAsFilename is null)
					_SaveAsFilename = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICSaveAsFilename")!;
				return _SaveAsFilename;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SavedAncillaryFiles;
		/// <summary>Represents the value associated with the constant 'ICSavedAncillaryFiles'.</summary>
		[Field ("ICSavedAncillaryFiles",  "ImageCaptureCore")]
		public static NSString SavedAncillaryFiles {
			get {
				if (_SavedAncillaryFiles is null)
					_SavedAncillaryFiles = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICSavedAncillaryFiles")!;
				return _SavedAncillaryFiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SavedFilename;
		/// <summary>Represents the value associated with the constant 'ICSavedFilename'.</summary>
		[Field ("ICSavedFilename",  "ImageCaptureCore")]
		public static NSString SavedFilename {
			get {
				if (_SavedFilename is null)
					_SavedFilename = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICSavedFilename")!;
				return _SavedFilename;
			}
		}
	} /* class ICCameraDownloadOptionKeys */
}
