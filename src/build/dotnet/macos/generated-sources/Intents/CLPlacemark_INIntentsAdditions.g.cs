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
namespace Intents {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class CLPlacemark_INIntentsAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlacemarkWithLocation_Name_PostalAddress_X = "placemarkWithLocation:name:postalAddress:";
		static readonly NativeHandle selPlacemarkWithLocation_Name_PostalAddress_XHandle = Selector.GetHandle ("placemarkWithLocation:name:postalAddress:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLPlacemark");
		[Export ("placemarkWithLocation:name:postalAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreLocation.CLPlacemark _GetPlacemark (this global::CoreLocation.CLPlacemark This, global::CoreLocation.CLLocation location, string? name, global::Contacts.CNPostalAddress? postalAddress)
		{
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var postalAddress__handle__ = postalAddress.GetHandle ();
			var nsname = CFString.CreateNative (name);
			global::CoreLocation.CLPlacemark? ret;
			ret =  Runtime.GetNSObject<global::CoreLocation.CLPlacemark> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPlacemarkWithLocation_Name_PostalAddress_XHandle, location__handle__, nsname, postalAddress__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			GC.KeepAlive (postalAddress);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class CLPlacemark_INIntentsAdditions */
}
