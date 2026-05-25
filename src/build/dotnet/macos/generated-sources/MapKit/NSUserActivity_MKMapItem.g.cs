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
namespace MapKit {
	/// <summary>Extension class for getting and setting map items on a <see cref="T:Foundation.NSUserActivity" /> object.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSUserActivity_MKMapItem  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapItemX = "mapItem";
		static readonly NativeHandle selMapItemXHandle = Selector.GetHandle ("mapItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMapItem_X = "setMapItem:";
		static readonly NativeHandle selSetMapItem_XHandle = Selector.GetHandle ("setMapItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUserActivity");
		/// <summary>Gets the mapkit item.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("mapItem")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKMapItem GetMapItem (this NSUserActivity This)
		{
			MKMapItem ret;
			ret =  Runtime.GetNSObject<MKMapItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selMapItemXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="item">The new mapkit item.</param><summary>Sets the mapkit item to <paramref name="item" />.</summary><remarks>To be added.</remarks>
		[Export ("setMapItem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMapItem (this NSUserActivity This, MKMapItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetMapItem_XHandle, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
	} /* class NSUserActivity_MKMapItem */
}
