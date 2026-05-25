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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ICCameraDeviceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "ICCameraDeviceDelegate", WrapperType = typeof (ICCameraDeviceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidAddItem", Selector = "cameraDevice:didAddItem:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveItem", Selector = "cameraDevice:didRemoveItem:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRenameItems", Selector = "cameraDevice:didRenameItems:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCompleteDeleteFiles", Selector = "cameraDevice:didCompleteDeleteFilesWithError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeCapability", Selector = "cameraDeviceDidChangeCapability:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveThumbnail", Selector = "cameraDevice:didReceiveThumbnailForItem:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveThumbnailForItem", Selector = "cameraDevice:didReceiveThumbnail:forItem:error:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (IntPtr), typeof (ImageCaptureCore.ICCameraItem), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveMetadata", Selector = "cameraDevice:didReceiveMetadataForItem:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceivePtpEvent", Selector = "cameraDevice:didReceivePTPEvent:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidBecomeReadyWithCompleteContentCatalog", Selector = "deviceDidBecomeReadyWithCompleteContentCatalog:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddItems", Selector = "cameraDevice:didAddItems:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveItems", Selector = "cameraDevice:didRemoveItems:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGetThumbnail", Selector = "cameraDevice:shouldGetThumbnailOfItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGetMetadata", Selector = "cameraDevice:shouldGetMetadataOfItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ImageCaptureCore.ICCameraDevice), typeof (ImageCaptureCore.ICCameraItem) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IICCameraDeviceDelegate : INativeObject, IDisposable, 
		ImageCaptureCore.IICDeviceDelegate
	{
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didAddItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddItem (ICCameraDevice camera, ICCameraItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddItem (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem item)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didAddItem:"), camera__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didRemoveItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItem (ICCameraDevice camera, ICCameraItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveItem (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem item)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didRemoveItem:"), camera__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didRenameItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenameItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRenameItems (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didRenameItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didCompleteDeleteFilesWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteDeleteFiles (ICCameraDevice scanner, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteDeleteFiles (IICCameraDeviceDelegate This, ICCameraDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didCompleteDeleteFilesWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDeviceDidChangeCapability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeCapability (ICCameraDevice camera)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeCapability (IICCameraDeviceDelegate This, ICCameraDevice camera)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceDidChangeCapability:"), camera__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didReceiveThumbnailForItem:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'DidReceiveThumbnailForItem (ICCameraDevice, CGImageRef, ICCameraItem, NSError)' instead.")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveThumbnail (ICCameraDevice camera, ICCameraItem forItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[ObsoletedOSPlatform ("macos10.15", "Use 'DidReceiveThumbnailForItem (ICCameraDevice, CGImageRef, ICCameraItem, NSError)' instead.")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveThumbnail (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem forItem)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didReceiveThumbnailForItem:"), camera__handle__, forItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDevice:didReceiveThumbnail:forItem:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveThumbnailForItem (ICCameraDevice camera, nint thumbnail, ICCameraItem forItem, NSError? error)
		{
			_DidReceiveThumbnailForItem (this, camera, thumbnail, forItem, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveThumbnailForItem (IICCameraDeviceDelegate This, ICCameraDevice camera, nint thumbnail, ICCameraItem forItem, NSError? error)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didReceiveThumbnail:forItem:error:"), camera__handle__, thumbnail, forItem__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
			GC.KeepAlive (error);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didReceiveMetadataForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMetadata (ICCameraDevice camera, ICCameraItem forItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMetadata (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem forItem)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didReceiveMetadataForItem:"), camera__handle__, forItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
		}
		[global::Foundation.RequiredMember]
		[Export ("cameraDevice:didReceivePTPEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceivePtpEvent (ICCameraDevice camera, NSData eventData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceivePtpEvent (IICCameraDeviceDelegate This, ICCameraDevice camera, NSData eventData)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var eventData__handle__ = eventData!.GetNonNullHandle (nameof (eventData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didReceivePTPEvent:"), camera__handle__, eventData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (eventData);
		}
		[global::Foundation.RequiredMember]
		[Export ("deviceDidBecomeReadyWithCompleteContentCatalog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeReadyWithCompleteContentCatalog (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeReadyWithCompleteContentCatalog (IICCameraDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidBecomeReadyWithCompleteContentCatalog:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDevice:didAddItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			_DidAddItems (this, camera, items);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddItems (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didAddItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDevice:didRemoveItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			_DidRemoveItems (this, camera, items);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveItems (IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didRemoveItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDevice:shouldGetThumbnailOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldGetThumbnail (ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			return _ShouldGetThumbnail (this, cameraDevice, ofItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldGetThumbnail (IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			var cameraDevice__handle__ = cameraDevice!.GetNonNullHandle (nameof (cameraDevice));
			var ofItem__handle__ = ofItem!.GetNonNullHandle (nameof (ofItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:shouldGetThumbnailOfItem:"), cameraDevice__handle__, ofItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDevice);
			GC.KeepAlive (ofItem);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDevice:shouldGetMetadataOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldGetMetadata (ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			return _ShouldGetMetadata (this, cameraDevice, ofItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldGetMetadata (IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			var cameraDevice__handle__ = cameraDevice!.GetNonNullHandle (nameof (cameraDevice));
			var ofItem__handle__ = ofItem!.GetNonNullHandle (nameof (ofItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:shouldGetMetadataOfItem:"), cameraDevice__handle__, ofItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDevice);
			GC.KeepAlive (ofItem);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidAddItem(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute ("DidAddItems(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem[])")]
		[DynamicDependencyAttribute ("DidBecomeReadyWithCompleteContentCatalog(ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DidChangeCapability(ImageCaptureCore.ICCameraDevice)")]
		[DynamicDependencyAttribute ("DidCompleteDeleteFiles(ImageCaptureCore.ICCameraDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveMetadata(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute ("DidReceivePtpEvent(ImageCaptureCore.ICCameraDevice,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidReceiveThumbnail(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute ("DidReceiveThumbnailForItem(ImageCaptureCore.ICCameraDevice,System.IntPtr,ImageCaptureCore.ICCameraItem,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidRemoveItem(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute ("DidRemoveItems(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem[])")]
		[DynamicDependencyAttribute ("DidRenameItems(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem[])")]
		[DynamicDependencyAttribute ("ShouldGetMetadata(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute ("ShouldGetThumbnail(ImageCaptureCore.ICCameraDevice,ImageCaptureCore.ICCameraItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICCameraDeviceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IICCameraDeviceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IICCameraDeviceDelegate" /> interface to support all the methods from the ICCameraDeviceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IICCameraDeviceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ICCameraDeviceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ICCameraDeviceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveThumbnailForItem (this IICCameraDeviceDelegate This, ICCameraDevice camera, nint thumbnail, ICCameraItem forItem, NSError? error)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didReceiveThumbnail:forItem:error:"), camera__handle__, thumbnail, forItem__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddItems (this IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didAddItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveItems (this IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:didRemoveItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (camera);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldGetThumbnail (this IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			var cameraDevice__handle__ = cameraDevice!.GetNonNullHandle (nameof (cameraDevice));
			var ofItem__handle__ = ofItem!.GetNonNullHandle (nameof (ofItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:shouldGetThumbnailOfItem:"), cameraDevice__handle__, ofItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDevice);
			GC.KeepAlive (ofItem);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldGetMetadata (this IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			var cameraDevice__handle__ = cameraDevice!.GetNonNullHandle (nameof (cameraDevice));
			var ofItem__handle__ = ofItem!.GetNonNullHandle (nameof (ofItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDevice:shouldGetMetadataOfItem:"), cameraDevice__handle__, ofItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDevice);
			GC.KeepAlive (ofItem);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ICCameraDeviceDelegateWrapper : BaseWrapper, IICCameraDeviceDelegate {
		public ICCameraDeviceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICCameraDeviceDelegateWrapper))]
		static ICCameraDeviceDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("cameraDevice:didAddItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidAddItem (ICCameraDevice camera, ICCameraItem item)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didAddItem:"), camera__handle__, item__handle__);
			GC.KeepAlive (camera);
			GC.KeepAlive (item);
		}
		[Export ("cameraDevice:didRemoveItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRemoveItem (ICCameraDevice camera, ICCameraItem item)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didRemoveItem:"), camera__handle__, item__handle__);
			GC.KeepAlive (camera);
			GC.KeepAlive (item);
		}
		[Export ("cameraDevice:didRenameItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRenameItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didRenameItems:"), camera__handle__, nsa_items.Handle);
			GC.KeepAlive (camera);
		}
		[Export ("cameraDevice:didCompleteDeleteFilesWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCompleteDeleteFiles (ICCameraDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didCompleteDeleteFilesWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
		[Export ("cameraDeviceDidChangeCapability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidChangeCapability (ICCameraDevice camera)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("cameraDeviceDidChangeCapability:"), camera__handle__);
			GC.KeepAlive (camera);
		}
		[Export ("cameraDevice:didReceiveThumbnailForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveThumbnail (ICCameraDevice camera, ICCameraItem forItem)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didReceiveThumbnailForItem:"), camera__handle__, forItem__handle__);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
		}
		[Export ("cameraDevice:didReceiveMetadataForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveMetadata (ICCameraDevice camera, ICCameraItem forItem)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didReceiveMetadataForItem:"), camera__handle__, forItem__handle__);
			GC.KeepAlive (camera);
			GC.KeepAlive (forItem);
		}
		[Export ("cameraDevice:didReceivePTPEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceivePtpEvent (ICCameraDevice camera, NSData eventData)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			var eventData__handle__ = eventData!.GetNonNullHandle (nameof (eventData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cameraDevice:didReceivePTPEvent:"), camera__handle__, eventData__handle__);
			GC.KeepAlive (camera);
			GC.KeepAlive (eventData);
		}
		[Export ("deviceDidBecomeReadyWithCompleteContentCatalog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidBecomeReadyWithCompleteContentCatalog (ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("deviceDidBecomeReadyWithCompleteContentCatalog:"), device__handle__);
			GC.KeepAlive (device);
		}
		[Export ("didRemoveDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRemoveDevice (ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didRemoveDevice:"), device__handle__);
			GC.KeepAlive (device);
		}
	}
}
namespace ImageCaptureCore {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IICCameraDeviceDelegate" /> (for the protocol <c>ICCameraDeviceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IICCameraDeviceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageCaptureCore_ICCameraDeviceDelegate", false)]
	[Model]
	public unsafe abstract partial class ICCameraDeviceDelegate : NSObject, IICCameraDeviceDelegate, IICDeviceDelegate {
		/// <summary>Creates a new <see cref="ICCameraDeviceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ICCameraDeviceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ICCameraDeviceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ICCameraDeviceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("cameraDevice:didAddItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddItem (ICCameraDevice camera, ICCameraItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didAddItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidBecomeReady:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeReady (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidBecomeReadyWithCompleteContentCatalog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeReadyWithCompleteContentCatalog (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDeviceDidChangeCapability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeCapability (ICCameraDevice camera)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidChangeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeName (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidChangeSharingState:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSharingState (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didCloseSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseSession (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didCompleteDeleteFilesWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteDeleteFiles (ICCameraDevice scanner, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didEncounterError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didOpenSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenSession (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveButtonPress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveButtonPress (ICDevice device, NSString buttonType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveCustomNotification:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveCustomNotification (ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didReceiveMetadataForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMetadata (ICCameraDevice camera, ICCameraItem forItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didReceivePTPEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceivePtpEvent (ICCameraDevice camera, NSData eventData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveStatusInformation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveStatusInformation (ICDevice device, NSDictionary<NSString, NSObject> status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didReceiveThumbnailForItem:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'DidReceiveThumbnailForItem (ICCameraDevice, CGImageRef, ICCameraItem, NSError)' instead.")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveThumbnail (ICCameraDevice camera, ICCameraItem forItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didReceiveThumbnail:forItem:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveThumbnailForItem (ICCameraDevice camera, nint thumbnail, ICCameraItem forItem, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didRemoveDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveDevice (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didRemoveItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItem (ICCameraDevice camera, ICCameraItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didRemoveItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:didRenameItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenameItems (ICCameraDevice camera, ICCameraItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:shouldGetMetadataOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldGetMetadata (ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraDevice:shouldGetThumbnailOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldGetThumbnail (ICCameraDevice cameraDevice, ICCameraItem ofItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ICCameraDeviceDelegate */
}
