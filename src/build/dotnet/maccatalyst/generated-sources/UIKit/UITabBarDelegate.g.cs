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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITabBarDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITabBarDelegate", WrapperType = typeof (UITabBarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemSelected", Selector = "tabBar:didSelectItem:", ParameterType = new Type [] { typeof (UITabBar), typeof (UITabBarItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginCustomizingItems", Selector = "tabBar:willBeginCustomizingItems:", ParameterType = new Type [] { typeof (UITabBar), typeof (UITabBarItem[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginCustomizingItems", Selector = "tabBar:didBeginCustomizingItems:", ParameterType = new Type [] { typeof (UITabBar), typeof (UITabBarItem[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndCustomizingItems", Selector = "tabBar:willEndCustomizingItems:changed:", ParameterType = new Type [] { typeof (UITabBar), typeof (UITabBarItem[]), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndCustomizingItems", Selector = "tabBar:didEndCustomizingItems:changed:", ParameterType = new Type [] { typeof (UITabBar), typeof (UITabBarItem[]), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITabBarDelegate : INativeObject, IDisposable
	{
		/// <param name="tabbar">To be added.</param><param name="item">To be added.</param><summary>Indicates that the specified UITabBarItem was selected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabBar:didSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UITabBar tabbar, UITabBarItem item)
		{
			_ItemSelected (this, tabbar, item);
		}
		/// <param name="tabbar">To be added.</param><param name="item">To be added.</param><summary>Indicates that the specified UITabBarItem was selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ItemSelected (IUITabBarDelegate This, UITabBar tabbar, UITabBarItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:didSelectItem:"), tabbar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
			GC.KeepAlive (item);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customization is about to begin on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabBar:willBeginCustomizingItems:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginCustomizingItems (UITabBar tabbar, UITabBarItem[] items)
		{
			_WillBeginCustomizingItems (this, tabbar, items);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customization is about to begin on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginCustomizingItems (IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:willBeginCustomizingItems:"), tabbar__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customizing the specified UITabBarItems has begun.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabBar:didBeginCustomizingItems:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginCustomizingItems (UITabBar tabbar, UITabBarItem[] items)
		{
			_DidBeginCustomizingItems (this, tabbar, items);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customizing the specified UITabBarItems has begun.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginCustomizingItems (IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:didBeginCustomizingItems:"), tabbar__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization is about to end on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabBar:willEndCustomizingItems:changed:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndCustomizingItems (UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			_WillEndCustomizingItems (this, tabbar, items, changed);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization is about to end on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndCustomizingItems (IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("tabBar:willEndCustomizingItems:changed:"), tabbar__handle__, nsa_items.Handle, changed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization of the specified items has ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabBar:didEndCustomizingItems:changed:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndCustomizingItems (UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			_DidEndCustomizingItems (this, tabbar, items, changed);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization of the specified items has ended.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndCustomizingItems (IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("tabBar:didEndCustomizingItems:changed:"), tabbar__handle__, nsa_items.Handle, changed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		[DynamicDependencyAttribute ("DidBeginCustomizingItems(UIKit.UITabBar,UIKit.UITabBarItem[])")]
		[DynamicDependencyAttribute ("DidEndCustomizingItems(UIKit.UITabBar,UIKit.UITabBarItem[],System.Boolean)")]
		[DynamicDependencyAttribute ("ItemSelected(UIKit.UITabBar,UIKit.UITabBarItem)")]
		[DynamicDependencyAttribute ("WillBeginCustomizingItems(UIKit.UITabBar,UIKit.UITabBarItem[])")]
		[DynamicDependencyAttribute ("WillEndCustomizingItems(UIKit.UITabBar,UIKit.UITabBarItem[],System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITabBarDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITabBarDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITabBarDelegate" /> interface to support all the methods from the UITabBarDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITabBarDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITabBarDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITabBarDelegate_Extensions {
		/// <param name="tabbar">To be added.</param><param name="item">To be added.</param><summary>Indicates that the specified UITabBarItem was selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ItemSelected (this IUITabBarDelegate This, UITabBar tabbar, UITabBarItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:didSelectItem:"), tabbar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
			GC.KeepAlive (item);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customization is about to begin on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginCustomizingItems (this IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:willBeginCustomizingItems:"), tabbar__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customizing the specified UITabBarItems has begun.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginCustomizingItems (this IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBar:didBeginCustomizingItems:"), tabbar__handle__, nsa_items.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization is about to end on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndCustomizingItems (this IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("tabBar:willEndCustomizingItems:changed:"), tabbar__handle__, nsa_items.Handle, changed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization of the specified items has ended.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndCustomizingItems (this IUITabBarDelegate This, UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabbar__handle__ = tabbar!.GetNonNullHandle (nameof (tabbar));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("tabBar:didEndCustomizingItems:changed:"), tabbar__handle__, nsa_items.Handle, changed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (tabbar);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITabBarDelegateWrapper : BaseWrapper, IUITabBarDelegate {
		public UITabBarDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITabBarDelegateWrapper))]
		static UITabBarDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITabBarDelegate" /> (for the protocol <c>UITabBarDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITabBarDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITabBarDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITabBarDelegate : NSObject, IUITabBarDelegate {
		/// <summary>Creates a new <see cref="UITabBarDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITabBarDelegate () : base (NSObjectFlag.Empty)
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
		protected UITabBarDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITabBarDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customizing the specified UITabBarItems has begun.</summary><remarks>To be added.</remarks>
		[Export ("tabBar:didBeginCustomizingItems:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginCustomizingItems (UITabBar tabbar, UITabBarItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization of the specified items has ended.</summary><remarks>To be added.</remarks>
		[Export ("tabBar:didEndCustomizingItems:changed:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndCustomizingItems (UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabbar">To be added.</param><param name="item">To be added.</param><summary>Indicates that the specified UITabBarItem was selected.</summary><remarks>To be added.</remarks>
		[Export ("tabBar:didSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UITabBar tabbar, UITabBarItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><summary>Indicates that customization is about to begin on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[Export ("tabBar:willBeginCustomizingItems:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginCustomizingItems (UITabBar tabbar, UITabBarItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabbar">To be added.</param><param name="items">To be added.</param><param name="changed">To be added.</param><summary>Indicates that customization is about to end on the specified UITabBarItems.</summary><remarks>To be added.</remarks>
		[Export ("tabBar:willEndCustomizingItems:changed:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndCustomizingItems (UITabBar tabbar, UITabBarItem[] items, bool changed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITabBarDelegate */
}
