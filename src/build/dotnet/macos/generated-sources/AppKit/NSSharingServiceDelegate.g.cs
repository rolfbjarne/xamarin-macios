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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSSharingServiceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSSharingServiceDelegate", WrapperType = typeof (NSSharingServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShareItems", Selector = "sharingService:willShareItems:", ParameterType = new Type [] { typeof (NSSharingService), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToShareItems", Selector = "sharingService:didFailToShareItems:error:", ParameterType = new Type [] { typeof (NSSharingService), typeof (NSObject[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShareItems", Selector = "sharingService:didShareItems:", ParameterType = new Type [] { typeof (NSSharingService), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceFrameOnScreenForShareItem", Selector = "sharingService:sourceFrameOnScreenForShareItem:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSSharingService), typeof (INSPasteboardWriting) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionImageForShareItem", Selector = "sharingService:transitionImageForShareItem:contentRect:", ReturnType = typeof (NSImage), ParameterType = new Type [] { typeof (NSSharingService), typeof (INSPasteboardWriting), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceWindowForShareItems", Selector = "sharingService:sourceWindowForShareItems:sharingContentScope:", ReturnType = typeof (NSWindow), ParameterType = new Type [] { typeof (NSSharingService), typeof (NSObject[]), typeof (NSSharingContentScope) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateAnchoringView", Selector = "anchoringViewForSharingService:showRelativeToRect:preferredEdge:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (NSSharingService), typeof (CGRect), typeof (NSRectEdge) }, ParameterByRef = new bool [] { false, true, true })]
	public partial interface INSSharingServiceDelegate : INativeObject, IDisposable
	{
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:willShareItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShareItems (NSSharingService sharingService, NSObject[] items)
		{
			_WillShareItems (this, sharingService, items);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShareItems (INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:willShareItems:"), sharingService__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:didFailToShareItems:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShareItems (NSSharingService sharingService, NSObject[] items, NSError error)
		{
			_DidFailToShareItems (this, sharingService, items, error);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToShareItems (INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didFailToShareItems:error:"), sharingService__handle__, nsa_items.Handle, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (error);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:didShareItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShareItems (NSSharingService sharingService, NSObject[] items)
		{
			_DidShareItems (this, sharingService, items);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShareItems (INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didShareItems:"), sharingService__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:sourceFrameOnScreenForShareItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect SourceFrameOnScreenForShareItem (NSSharingService sharingService, INSPasteboardWriting item)
		{
			return _SourceFrameOnScreenForShareItem (this, sharingService, item);
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _SourceFrameOnScreenForShareItem (INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:sourceFrameOnScreenForShareItem:"), sharingService__handle__, item__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:sourceFrameOnScreenForShareItem:"), sharingService__handle__, item__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sharingService);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:transitionImageForShareItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage TransitionImageForShareItem (NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
		{
			return _TransitionImageForShareItem (this, sharingService, item, contentRect);
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSImage _TransitionImageForShareItem (INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("sharingService:transitionImageForShareItem:contentRect:"), sharingService__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="sharingContentScope">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:sourceWindowForShareItems:sharingContentScope:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindow SourceWindowForShareItems (NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			return _SourceWindowForShareItems (this, sharingService, items, sharingContentScope);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="sharingContentScope">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWindow _SourceWindowForShareItems (INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			NSWindow? ret;
			ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("sharingService:sourceWindowForShareItems:sharingContentScope:"), sharingService__handle__, nsa_items.Handle, (IntPtr) (long) sharingContentScope), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="positioningRect">To be added.</param><param name="preferredEdge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("anchoringViewForSharingService:showRelativeToRect:preferredEdge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSView? CreateAnchoringView (NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
		{
			return _CreateAnchoringView (this, sharingService, ref positioningRect, ref preferredEdge);
		}
		/// <param name="sharingService">To be added.</param><param name="positioningRect">To be added.</param><param name="preferredEdge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSView? _CreateAnchoringView (INSSharingServiceDelegate This, NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			fixed (CGRect* positioningRect__pointer = &positioningRect) {
			fixed (NSRectEdge* preferredEdge__pointer = &preferredEdge) {
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_CGRect_ref_NSRectEdge (This.Handle, Selector.GetHandle ("anchoringViewForSharingService:showRelativeToRect:preferredEdge:"), sharingService__handle__, positioningRect__pointer, preferredEdge__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			return ret!;
			}
			}
		}
		[DynamicDependencyAttribute ("CreateAnchoringView(AppKit.NSSharingService,CoreGraphics.CGRect@,AppKit.NSRectEdge@)")]
		[DynamicDependencyAttribute ("DidFailToShareItems(AppKit.NSSharingService,Foundation.NSObject[],Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidShareItems(AppKit.NSSharingService,Foundation.NSObject[])")]
		[DynamicDependencyAttribute ("SourceFrameOnScreenForShareItem(AppKit.NSSharingService,AppKit.INSPasteboardWriting)")]
		[DynamicDependencyAttribute ("SourceWindowForShareItems(AppKit.NSSharingService,Foundation.NSObject[],AppKit.NSSharingContentScope)")]
		[DynamicDependencyAttribute ("TransitionImageForShareItem(AppKit.NSSharingService,AppKit.INSPasteboardWriting,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("WillShareItems(AppKit.NSSharingService,Foundation.NSObject[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSharingServiceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSSharingServiceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSSharingServiceDelegate" /> interface to support all the methods from the NSSharingServiceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSSharingServiceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSSharingServiceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSSharingServiceDelegate_Extensions {
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShareItems (this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:willShareItems:"), sharingService__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToShareItems (this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didFailToShareItems:error:"), sharingService__handle__, nsa_items.Handle, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (error);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShareItems (this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didShareItems:"), sharingService__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect SourceFrameOnScreenForShareItem (this INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:sourceFrameOnScreenForShareItem:"), sharingService__handle__, item__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:sourceFrameOnScreenForShareItem:"), sharingService__handle__, item__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (sharingService);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImage TransitionImageForShareItem (this INSSharingServiceDelegate This, NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("sharingService:transitionImageForShareItem:contentRect:"), sharingService__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="sharingContentScope">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSWindow SourceWindowForShareItems (this INSSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			NSWindow? ret;
			ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("sharingService:sourceWindowForShareItems:sharingContentScope:"), sharingService__handle__, nsa_items.Handle, (IntPtr) (long) sharingContentScope), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="positioningRect">To be added.</param><param name="preferredEdge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSView? CreateAnchoringView (this INSSharingServiceDelegate This, NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			fixed (CGRect* positioningRect__pointer = &positioningRect) {
			fixed (NSRectEdge* preferredEdge__pointer = &preferredEdge) {
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_CGRect_ref_NSRectEdge (This.Handle, Selector.GetHandle ("anchoringViewForSharingService:showRelativeToRect:preferredEdge:"), sharingService__handle__, positioningRect__pointer, preferredEdge__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			return ret!;
			}
			}
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSSharingServiceDelegateWrapper : BaseWrapper, INSSharingServiceDelegate {
		public NSSharingServiceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSharingServiceDelegateWrapper))]
		static NSSharingServiceDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSSharingServiceDelegate" /> (for the protocol <c>NSSharingServiceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSSharingServiceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSSharingServiceDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSharingServiceDelegate : NSObject, INSSharingServiceDelegate {
		/// <summary>Creates a new <see cref="NSSharingServiceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSharingServiceDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSSharingServiceDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSSharingServiceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sharingService">To be added.</param><param name="positioningRect">To be added.</param><param name="preferredEdge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("anchoringViewForSharingService:showRelativeToRect:preferredEdge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSView? CreateAnchoringView (NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:didFailToShareItems:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShareItems (NSSharingService sharingService, NSObject[] items, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:didShareItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShareItems (NSSharingService sharingService, NSObject[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sharingService:sourceFrameOnScreenForShareItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect SourceFrameOnScreenForShareItem (NSSharingService sharingService, INSPasteboardWriting item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="sharingContentScope">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sharingService:sourceWindowForShareItems:sharingContentScope:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindow SourceWindowForShareItems (NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sharingService:transitionImageForShareItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage TransitionImageForShareItem (NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:willShareItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShareItems (NSSharingService sharingService, NSObject[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSSharingServiceDelegate */
}
