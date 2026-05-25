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
namespace CoreFoundation {
	/// <summary>Main loop implementation for Cocoa and CocoaTouch applications.</summary><remarks>Run loops can be executed recursively.</remarks>
	public unsafe partial class CFRunLoop  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModeCommon;
		/// <summary>Represents the value associated with the constant kCFRunLoopCommonModes</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCFRunLoopCommonModes",  "CoreFoundation")]
		public static NSString ModeCommon {
			get {
				if (_ModeCommon is null)
					_ModeCommon = Dlfcn.GetStringConstant (Libraries.CoreFoundation.Handle, "kCFRunLoopCommonModes")!;
				return _ModeCommon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModeDefault;
		/// <summary>Represents the value associated with the constant kCFRunLoopDefaultMode</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCFRunLoopDefaultMode",  "CoreFoundation")]
		public static NSString ModeDefault {
			get {
				if (_ModeDefault is null)
					_ModeDefault = Dlfcn.GetStringConstant (Libraries.CoreFoundation.Handle, "kCFRunLoopDefaultMode")!;
				return _ModeDefault;
			}
		}
	} /* class CFRunLoop */
}
