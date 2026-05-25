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
	public unsafe static partial class ICDeviceLocationDescriptions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bluetooth;
		/// <summary>Represents the value associated with the constant 'ICDeviceLocationDescriptionBluetooth'.</summary>
		[Field ("ICDeviceLocationDescriptionBluetooth",  "ImageCaptureCore")]
		public static NSString Bluetooth {
			get {
				if (_Bluetooth is null)
					_Bluetooth = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionBluetooth")!;
				return _Bluetooth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FireWire;
		/// <summary>Represents the value associated with the constant 'ICDeviceLocationDescriptionFireWire'.</summary>
		[Field ("ICDeviceLocationDescriptionFireWire",  "ImageCaptureCore")]
		public static NSString FireWire {
			get {
				if (_FireWire is null)
					_FireWire = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionFireWire")!;
				return _FireWire;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MassStorage;
		/// <summary>Represents the value associated with the constant 'ICDeviceLocationDescriptionMassStorage'.</summary>
		[Field ("ICDeviceLocationDescriptionMassStorage",  "ImageCaptureCore")]
		public static NSString MassStorage {
			get {
				if (_MassStorage is null)
					_MassStorage = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionMassStorage")!;
				return _MassStorage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Usb;
		/// <summary>Represents the value associated with the constant 'ICDeviceLocationDescriptionUSB'.</summary>
		[Field ("ICDeviceLocationDescriptionUSB",  "ImageCaptureCore")]
		public static NSString Usb {
			get {
				if (_Usb is null)
					_Usb = Dlfcn.GetStringConstant (Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionUSB")!;
				return _Usb;
			}
		}
	} /* class ICDeviceLocationDescriptions */
}
