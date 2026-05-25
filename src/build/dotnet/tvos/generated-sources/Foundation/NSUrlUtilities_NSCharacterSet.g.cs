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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>Defines static methods defining character sets for various subcomponents of a <see cref="T:Foundation.NSUrl" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSUrlUtilities_NSCharacterSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCharacterSet");
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a fragment URL component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlFragmentAllowedCharacterSet {
			[Export ("URLFragmentAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLFragmentAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a host URL.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlHostAllowedCharacterSet {
			[Export ("URLHostAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLHostAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL password component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPasswordAllowedCharacterSet {
			[Export ("URLPasswordAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLPasswordAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL path component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPathAllowedCharacterSet {
			[Export ("URLPathAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLPathAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL query component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlQueryAllowedCharacterSet {
			[Export ("URLQueryAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLQueryAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL user component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlUserAllowedCharacterSet {
			[Export ("URLUserAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLUserAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
	} /* class NSUrlUtilities_NSCharacterSet */
}
