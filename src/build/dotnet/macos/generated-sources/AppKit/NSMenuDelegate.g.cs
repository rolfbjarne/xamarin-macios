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
	/// <summary>This interface represents the Objective-C protocol <c>NSMenuDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSMenuDelegate", WrapperType = typeof (NSMenuDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedsUpdate", Selector = "menuNeedsUpdate:", ParameterType = new Type [] { typeof (NSMenu) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuItemCount", Selector = "numberOfItemsInMenu:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSMenu) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateItem", Selector = "menu:updateItem:atIndex:shouldCancel:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSMenu), typeof (NSMenuItem), typeof (IntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasKeyEquivalentForEvent", Selector = "menuHasKeyEquivalent:forEvent:target:action:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSMenu), typeof (NSEvent), typeof (NSObject), typeof (Selector) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuWillOpen", Selector = "menuWillOpen:", ParameterType = new Type [] { typeof (NSMenu) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuDidClose", Selector = "menuDidClose:", ParameterType = new Type [] { typeof (NSMenu) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuWillHighlightItem", Selector = "menu:willHighlightItem:", ParameterType = new Type [] { typeof (NSMenu), typeof (NSMenuItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfinementRectForMenu", Selector = "confinementRectForMenu:onScreen:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSMenu), typeof (NSScreen) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSMenuDelegate : INativeObject, IDisposable
	{
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menuNeedsUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NeedsUpdate (NSMenu menu)
		{
			_NeedsUpdate (this, menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NeedsUpdate (INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuNeedsUpdate:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfItemsInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MenuItemCount (NSMenu menu)
		{
			return _MenuItemCount (this, menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MenuItemCount (INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfItemsInMenu:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			return ret!;
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><param name="atIndex">To be added.</param><param name="shouldCancel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menu:updateItem:atIndex:shouldCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateItem (NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
		{
			return _UpdateItem (this, menu, item, atIndex, shouldCancel);
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><param name="atIndex">To be added.</param><param name="shouldCancel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UpdateItem (INSMenuDelegate This, NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_bool (This.Handle, Selector.GetHandle ("menu:updateItem:atIndex:shouldCancel:"), menu__handle__, item__handle__, atIndex, shouldCancel ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="target">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menuHasKeyEquivalent:forEvent:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasKeyEquivalentForEvent (NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
		{
			return _HasKeyEquivalentForEvent (this, menu, theEvent, target, action);
		}
		/// <param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="target">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasKeyEquivalentForEvent (INSMenuDelegate This, NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("menuHasKeyEquivalent:forEvent:target:action:"), menu__handle__, theEvent__handle__, target__handle__, action.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menuWillOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillOpen (NSMenu menu)
		{
			_MenuWillOpen (this, menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MenuWillOpen (INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuWillOpen:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menuDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuDidClose (NSMenu menu)
		{
			_MenuDidClose (this, menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MenuDidClose (INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuDidClose:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menu:willHighlightItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillHighlightItem (NSMenu menu, NSMenuItem item)
		{
			_MenuWillHighlightItem (this, menu, item);
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MenuWillHighlightItem (INSMenuDelegate This, NSMenu menu, NSMenuItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("menu:willHighlightItem:"), menu__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
		}
		/// <param name="menu">To be added.</param><param name="screen">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confinementRectForMenu:onScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConfinementRectForMenu (NSMenu menu, NSScreen screen)
		{
			return _ConfinementRectForMenu (this, menu, screen);
		}
		/// <param name="menu">To be added.</param><param name="screen">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _ConfinementRectForMenu (INSMenuDelegate This, NSMenu menu, NSScreen screen)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confinementRectForMenu:onScreen:"), menu__handle__, screen__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confinementRectForMenu:onScreen:"), menu__handle__, screen__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (screen);
			return ret!;
		}
		[DynamicDependencyAttribute ("ConfinementRectForMenu(AppKit.NSMenu,AppKit.NSScreen)")]
		[DynamicDependencyAttribute ("HasKeyEquivalentForEvent(AppKit.NSMenu,AppKit.NSEvent,Foundation.NSObject,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("MenuDidClose(AppKit.NSMenu)")]
		[DynamicDependencyAttribute ("MenuItemCount(AppKit.NSMenu)")]
		[DynamicDependencyAttribute ("MenuWillHighlightItem(AppKit.NSMenu,AppKit.NSMenuItem)")]
		[DynamicDependencyAttribute ("MenuWillOpen(AppKit.NSMenu)")]
		[DynamicDependencyAttribute ("NeedsUpdate(AppKit.NSMenu)")]
		[DynamicDependencyAttribute ("UpdateItem(AppKit.NSMenu,AppKit.NSMenuItem,System.IntPtr,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMenuDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSMenuDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSMenuDelegate" /> interface to support all the methods from the NSMenuDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSMenuDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSMenuDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSMenuDelegate_Extensions {
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NeedsUpdate (this INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuNeedsUpdate:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint MenuItemCount (this INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfItemsInMenu:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			return ret!;
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><param name="atIndex">To be added.</param><param name="shouldCancel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UpdateItem (this INSMenuDelegate This, NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_bool (This.Handle, Selector.GetHandle ("menu:updateItem:atIndex:shouldCancel:"), menu__handle__, item__handle__, atIndex, shouldCancel ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="target">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasKeyEquivalentForEvent (this INSMenuDelegate This, NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("menuHasKeyEquivalent:forEvent:target:action:"), menu__handle__, theEvent__handle__, target__handle__, action.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MenuWillOpen (this INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuWillOpen:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MenuDidClose (this INSMenuDelegate This, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuDidClose:"), menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MenuWillHighlightItem (this INSMenuDelegate This, NSMenu menu, NSMenuItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("menu:willHighlightItem:"), menu__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
		}
		/// <param name="menu">To be added.</param><param name="screen">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect ConfinementRectForMenu (this INSMenuDelegate This, NSMenu menu, NSScreen screen)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confinementRectForMenu:onScreen:"), menu__handle__, screen__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confinementRectForMenu:onScreen:"), menu__handle__, screen__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (screen);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSMenuDelegateWrapper : BaseWrapper, INSMenuDelegate {
		public NSMenuDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMenuDelegateWrapper))]
		static NSMenuDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSMenuDelegate" /> (for the protocol <c>NSMenuDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSMenuDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSMenuDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSMenuDelegate : NSObject, INSMenuDelegate {
		/// <summary>Creates a new <see cref="NSMenuDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMenuDelegate () : base (NSObjectFlag.Empty)
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
		protected NSMenuDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSMenuDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="menu">To be added.</param><param name="screen">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("confinementRectForMenu:onScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConfinementRectForMenu (NSMenu menu, NSScreen screen)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="target">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("menuHasKeyEquivalent:forEvent:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasKeyEquivalentForEvent (NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuDidClose (NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfItemsInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MenuItemCount (NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menu:willHighlightItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillHighlightItem (NSMenu menu, NSMenuItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuWillOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillOpen (NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuNeedsUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NeedsUpdate (NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><param name="atIndex">To be added.</param><param name="shouldCancel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("menu:updateItem:atIndex:shouldCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateItem (NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSMenuDelegate */
}
