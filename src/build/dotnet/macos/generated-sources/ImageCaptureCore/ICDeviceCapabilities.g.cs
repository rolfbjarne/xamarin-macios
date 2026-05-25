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
	public unsafe static partial class ICDeviceCapabilities  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanAcceptPtpCommands;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanAcceptPTPCommands'.</summary>
		[Field ("ICCameraDeviceCanAcceptPTPCommands",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanAcceptPtpCommands {
			get {
				if (_CameraDeviceCanAcceptPtpCommands is null)
					_CameraDeviceCanAcceptPtpCommands = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanAcceptPTPCommands")!;
				return _CameraDeviceCanAcceptPtpCommands;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanDeleteAllFiles;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanDeleteAllFiles'.</summary>
		[Field ("ICCameraDeviceCanDeleteAllFiles",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanDeleteAllFiles {
			get {
				if (_CameraDeviceCanDeleteAllFiles is null)
					_CameraDeviceCanDeleteAllFiles = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanDeleteAllFiles")!;
				return _CameraDeviceCanDeleteAllFiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanDeleteOneFile;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanDeleteOneFile'.</summary>
		[Field ("ICCameraDeviceCanDeleteOneFile",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanDeleteOneFile {
			get {
				if (_CameraDeviceCanDeleteOneFile is null)
					_CameraDeviceCanDeleteOneFile = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanDeleteOneFile")!;
				return _CameraDeviceCanDeleteOneFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanReceiveFile;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanReceiveFile'.</summary>
		[Field ("ICCameraDeviceCanReceiveFile",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanReceiveFile {
			get {
				if (_CameraDeviceCanReceiveFile is null)
					_CameraDeviceCanReceiveFile = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanReceiveFile")!;
				return _CameraDeviceCanReceiveFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanSyncClock;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanSyncClock'.</summary>
		[Field ("ICCameraDeviceCanSyncClock",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanSyncClock {
			get {
				if (_CameraDeviceCanSyncClock is null)
					_CameraDeviceCanSyncClock = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanSyncClock")!;
				return _CameraDeviceCanSyncClock;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanTakePicture;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanTakePicture'.</summary>
		[Field ("ICCameraDeviceCanTakePicture",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanTakePicture {
			get {
				if (_CameraDeviceCanTakePicture is null)
					_CameraDeviceCanTakePicture = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanTakePicture")!;
				return _CameraDeviceCanTakePicture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraDeviceCanTakePictureUsingShutterReleaseOnCamera;
		/// <summary>Represents the value associated with the constant 'ICCameraDeviceCanTakePictureUsingShutterReleaseOnCamera'.</summary>
		[Field ("ICCameraDeviceCanTakePictureUsingShutterReleaseOnCamera",  "ImageCaptureCore")]
		public static NSString CameraDeviceCanTakePictureUsingShutterReleaseOnCamera {
			get {
				if (_CameraDeviceCanTakePictureUsingShutterReleaseOnCamera is null)
					_CameraDeviceCanTakePictureUsingShutterReleaseOnCamera = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanTakePictureUsingShutterReleaseOnCamera")!;
				return _CameraDeviceCanTakePictureUsingShutterReleaseOnCamera;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceCanEjectOrDisconnect;
		/// <summary>Represents the value associated with the constant 'ICDeviceCanEjectOrDisconnect'.</summary>
		[Field ("ICDeviceCanEjectOrDisconnect",  "ImageCaptureCore")]
		public static NSString DeviceCanEjectOrDisconnect {
			get {
				if (_DeviceCanEjectOrDisconnect is null)
					_DeviceCanEjectOrDisconnect = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeviceCanEjectOrDisconnect")!;
				return _DeviceCanEjectOrDisconnect;
			}
		}
	} /* class ICDeviceCapabilities */
}
