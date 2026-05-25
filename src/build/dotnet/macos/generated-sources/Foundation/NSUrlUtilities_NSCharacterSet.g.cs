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
namespace Foundation {
	/// <summary>Defines static methods defining character sets for various subcomponents of a <see cref="T:Foundation.NSUrl" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSUrlUtilities_NSCharacterSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLFragmentAllowedCharacterSetX = "URLFragmentAllowedCharacterSet";
		static readonly NativeHandle selURLFragmentAllowedCharacterSetXHandle = Selector.GetHandle ("URLFragmentAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLHostAllowedCharacterSetX = "URLHostAllowedCharacterSet";
		static readonly NativeHandle selURLHostAllowedCharacterSetXHandle = Selector.GetHandle ("URLHostAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLPasswordAllowedCharacterSetX = "URLPasswordAllowedCharacterSet";
		static readonly NativeHandle selURLPasswordAllowedCharacterSetXHandle = Selector.GetHandle ("URLPasswordAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLPathAllowedCharacterSetX = "URLPathAllowedCharacterSet";
		static readonly NativeHandle selURLPathAllowedCharacterSetXHandle = Selector.GetHandle ("URLPathAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLQueryAllowedCharacterSetX = "URLQueryAllowedCharacterSet";
		static readonly NativeHandle selURLQueryAllowedCharacterSetXHandle = Selector.GetHandle ("URLQueryAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLUserAllowedCharacterSetX = "URLUserAllowedCharacterSet";
		static readonly NativeHandle selURLUserAllowedCharacterSetXHandle = Selector.GetHandle ("URLUserAllowedCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCharacterSet");
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a fragment URL component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlFragmentAllowedCharacterSet {
			[Export ("URLFragmentAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLFragmentAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a host URL.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlHostAllowedCharacterSet {
			[Export ("URLHostAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLHostAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL password component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPasswordAllowedCharacterSet {
			[Export ("URLPasswordAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLPasswordAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL path component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPathAllowedCharacterSet {
			[Export ("URLPathAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLPathAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL query component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlQueryAllowedCharacterSet {
			[Export ("URLQueryAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLQueryAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>The <see cref="T:Foundation.NSCharacterSet" /> for characters allowed in a URL user component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlUserAllowedCharacterSet {
			[Export ("URLUserAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selURLUserAllowedCharacterSetXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSUrlUtilities_NSCharacterSet */
}
