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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSToolbarDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSToolbarDelegate", WrapperType = typeof (NSToolbarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillInsertItem", Selector = "toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:", ReturnType = typeof (NSToolbarItem), ParameterType = new Type [] { typeof (NSToolbar), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DefaultItemIdentifiers", Selector = "toolbarDefaultItemIdentifiers:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AllowedItemIdentifiers", Selector = "toolbarAllowedItemIdentifiers:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectableItemIdentifiers", Selector = "toolbarSelectableItemIdentifiers:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAddItem", Selector = "toolbarWillAddItem:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveItem", Selector = "toolbarDidRemoveItem:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetToolbarImmovableItemIdentifiers", Selector = "toolbarImmovableItemIdentifiers:", ReturnType = typeof (global::Foundation.NSSet<NSString>), ParameterType = new Type [] { typeof (NSToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemCanBeInsertedAt", Selector = "toolbar:itemIdentifier:canBeInsertedAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSToolbar), typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSToolbarDelegate : INativeObject, IDisposable
	{
		/// <param name="toolbar">To be added.</param><param name="itemIdentifier">To be added.</param><param name="willBeInserted">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSToolbarItem? WillInsertItem (NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			return _WillInsertItem (this, toolbar, itemIdentifier, willBeInserted);
		}
		/// <param name="toolbar">To be added.</param><param name="itemIdentifier">To be added.</param><param name="willBeInserted">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSToolbarItem? _WillInsertItem (INSToolbarDelegate This, NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			NSToolbarItem? ret;
			ret =  Runtime.GetNSObject<NSToolbarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:"), toolbar__handle__, nsitemIdentifier, willBeInserted ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarDefaultItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] DefaultItemIdentifiers (NSToolbar toolbar)
		{
			return _DefaultItemIdentifiers (this, toolbar);
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _DefaultItemIdentifiers (INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarDefaultItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarAllowedItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AllowedItemIdentifiers (NSToolbar toolbar)
		{
			return _AllowedItemIdentifiers (this, toolbar);
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _AllowedItemIdentifiers (INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarAllowedItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarSelectableItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SelectableItemIdentifiers (NSToolbar toolbar)
		{
			return _SelectableItemIdentifiers (this, toolbar);
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _SelectableItemIdentifiers (INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarSelectableItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarWillAddItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAddItem (NSNotification notification)
		{
			_WillAddItem (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAddItem (INSToolbarDelegate This, NSNotification notification)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarWillAddItem:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("toolbarDidRemoveItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItem (NSNotification notification)
		{
			_DidRemoveItem (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveItem (INSToolbarDelegate This, NSNotification notification)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarDidRemoveItem:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[global::Foundation.OptionalMember]
		[Export ("toolbarImmovableItemIdentifiers:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString> GetToolbarImmovableItemIdentifiers (NSToolbar toolbar)
		{
			return _GetToolbarImmovableItemIdentifiers (this, toolbar);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<NSString> _GetToolbarImmovableItemIdentifiers (INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			NSSet<NSString>? ret;
			ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarImmovableItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("toolbar:itemIdentifier:canBeInsertedAtIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetItemCanBeInsertedAt (NSToolbar toolbar, string itemIdentifier, nint index)
		{
			return _GetItemCanBeInsertedAt (this, toolbar, itemIdentifier, index);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetItemCanBeInsertedAt (INSToolbarDelegate This, NSToolbar toolbar, string itemIdentifier, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("toolbar:itemIdentifier:canBeInsertedAtIndex:"), toolbar__handle__, nsitemIdentifier, index);
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AllowedItemIdentifiers(AppKit.NSToolbar)")]
		[DynamicDependencyAttribute ("DefaultItemIdentifiers(AppKit.NSToolbar)")]
		[DynamicDependencyAttribute ("DidRemoveItem(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("GetItemCanBeInsertedAt(AppKit.NSToolbar,System.String,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetToolbarImmovableItemIdentifiers(AppKit.NSToolbar)")]
		[DynamicDependencyAttribute ("SelectableItemIdentifiers(AppKit.NSToolbar)")]
		[DynamicDependencyAttribute ("WillAddItem(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillInsertItem(AppKit.NSToolbar,System.String,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSToolbarDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSToolbarDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSToolbarDelegate" /> interface to support all the methods from the NSToolbarDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSToolbarDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSToolbarDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSToolbarDelegate_Extensions {
		/// <param name="toolbar">To be added.</param><param name="itemIdentifier">To be added.</param><param name="willBeInserted">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSToolbarItem? WillInsertItem (this INSToolbarDelegate This, NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			NSToolbarItem? ret;
			ret =  Runtime.GetNSObject<NSToolbarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:"), toolbar__handle__, nsitemIdentifier, willBeInserted ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] DefaultItemIdentifiers (this INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarDefaultItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AllowedItemIdentifiers (this INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarAllowedItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] SelectableItemIdentifiers (this INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarSelectableItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAddItem (this INSToolbarDelegate This, NSNotification notification)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarWillAddItem:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveItem (this INSToolbarDelegate This, NSNotification notification)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarDidRemoveItem:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet<NSString> GetToolbarImmovableItemIdentifiers (this INSToolbarDelegate This, NSToolbar toolbar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			NSSet<NSString>? ret;
			ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolbarImmovableItemIdentifiers:"), toolbar__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			return ret!;
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetItemCanBeInsertedAt (this INSToolbarDelegate This, NSToolbar toolbar, string itemIdentifier, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("toolbar:itemIdentifier:canBeInsertedAtIndex:"), toolbar__handle__, nsitemIdentifier, index);
			GC.KeepAlive (This);
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSToolbarDelegateWrapper : BaseWrapper, INSToolbarDelegate {
		public NSToolbarDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSToolbarDelegateWrapper))]
		static NSToolbarDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSToolbarDelegate" /> (for the protocol <c>NSToolbarDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSToolbarDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AppKit_NSToolbarDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSToolbarDelegate : NSObject, INSToolbarDelegate {
		/// <summary>Creates a new <see cref="NSToolbarDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSToolbarDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected NSToolbarDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSToolbarDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("toolbarAllowedItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AllowedItemIdentifiers (NSToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("toolbarDefaultItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] DefaultItemIdentifiers (NSToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toolbarDidRemoveItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItem (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("toolbar:itemIdentifier:canBeInsertedAtIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetItemCanBeInsertedAt (NSToolbar toolbar, string itemIdentifier, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("toolbarImmovableItemIdentifiers:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString> GetToolbarImmovableItemIdentifiers (NSToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="toolbar">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("toolbarSelectableItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SelectableItemIdentifiers (NSToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toolbarWillAddItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAddItem (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="toolbar">To be added.</param><param name="itemIdentifier">To be added.</param><param name="willBeInserted">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSToolbarItem? WillInsertItem (NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSToolbarDelegate */
}
