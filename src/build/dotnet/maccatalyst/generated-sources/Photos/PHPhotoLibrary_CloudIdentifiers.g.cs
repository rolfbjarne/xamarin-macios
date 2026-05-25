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
namespace Photos {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PHPhotoLibrary_CloudIdentifiers  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHPhotoLibrary");
		[Export ("cloudIdentifierMappingsForLocalIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, PHCloudIdentifierMapping> GetCloudIdentifierMappings (this PHPhotoLibrary This, string[] localIdentifiers)
		{
			if (localIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localIdentifiers));
			using var nsa_localIdentifiers = NSArray.FromStrings (localIdentifiers);
			NSDictionary<NSString, PHCloudIdentifierMapping> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, PHCloudIdentifierMapping>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudIdentifierMappingsForLocalIdentifiers:"), nsa_localIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("localIdentifierMappingsForCloudIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping> GetLocalIdentifierMappings (this PHPhotoLibrary This, PHCloudIdentifier[] cloudIdentifiers)
		{
			if (cloudIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cloudIdentifiers));
			using var nsa_cloudIdentifiers = NSArray.FromNSObjects (cloudIdentifiers);
			NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping> ret;
			ret =  Runtime.GetNSObject<NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localIdentifierMappingsForCloudIdentifiers:"), nsa_cloudIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class PHPhotoLibrary_CloudIdentifiers */
}
