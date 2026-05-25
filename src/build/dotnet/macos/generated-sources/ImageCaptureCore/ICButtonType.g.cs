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
	public unsafe static partial class ICButtonType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Copy;
		/// <summary>Represents the value associated with the constant 'ICButtonTypeCopy'.</summary>
		[Field ("ICButtonTypeCopy",  "ImageCaptureCore")]
		public static NSString Copy {
			get {
				if (_Copy is null)
					_Copy = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypeCopy")!;
				return _Copy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mail;
		/// <summary>Represents the value associated with the constant 'ICButtonTypeMail'.</summary>
		[Field ("ICButtonTypeMail",  "ImageCaptureCore")]
		public static NSString Mail {
			get {
				if (_Mail is null)
					_Mail = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypeMail")!;
				return _Mail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Print;
		/// <summary>Represents the value associated with the constant 'ICButtonTypePrint'.</summary>
		[Field ("ICButtonTypePrint",  "ImageCaptureCore")]
		public static NSString Print {
			get {
				if (_Print is null)
					_Print = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypePrint")!;
				return _Print;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Scan;
		/// <summary>Represents the value associated with the constant 'ICButtonTypeScan'.</summary>
		[Field ("ICButtonTypeScan",  "ImageCaptureCore")]
		public static NSString Scan {
			get {
				if (_Scan is null)
					_Scan = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypeScan")!;
				return _Scan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Transfer;
		/// <summary>Represents the value associated with the constant 'ICButtonTypeTransfer'.</summary>
		[Field ("ICButtonTypeTransfer",  "ImageCaptureCore")]
		public static NSString Transfer {
			get {
				if (_Transfer is null)
					_Transfer = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypeTransfer")!;
				return _Transfer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Web;
		/// <summary>Represents the value associated with the constant 'ICButtonTypeWeb'.</summary>
		[Field ("ICButtonTypeWeb",  "ImageCaptureCore")]
		public static NSString Web {
			get {
				if (_Web is null)
					_Web = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICButtonTypeWeb")!;
				return _Web;
			}
		}
	} /* class ICButtonType */
}
