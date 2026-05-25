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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UINavigationBarDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UINavigationBarDelegate", WrapperType = typeof (UINavigationBarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPopItem", Selector = "navigationBar:didPopItem:", ParameterType = new Type [] { typeof (UINavigationBar), typeof (UINavigationItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPopItem", Selector = "navigationBar:shouldPopItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UINavigationBar), typeof (UINavigationItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPushItem", Selector = "navigationBar:didPushItem:", ParameterType = new Type [] { typeof (UINavigationBar), typeof (UINavigationItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPushItem", Selector = "navigationBar:shouldPushItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UINavigationBar), typeof (UINavigationItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNSToolbarSection", Selector = "navigationBarNSToolbarSection:", ReturnType = typeof (UINavigationBarNSToolbarSection), ParameterType = new Type [] { typeof (UINavigationBar) }, ParameterByRef = new bool [] { false })]
	public partial interface IUINavigationBarDelegate : INativeObject, IDisposable, 
		UIKit.IUIBarPositioningDelegate
	{
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been popped from the navigation stack.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationBar:didPopItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPopItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			_DidPopItem (this, navigationBar, item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been popped from the navigation stack.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPopItem (IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:didPopItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to popping the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationBar:shouldPopItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPopItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			return _ShouldPopItem (this, navigationBar, item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to popping the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPopItem (IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:shouldPopItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been pushed onto the navigation stack.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationBar:didPushItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPushItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			_DidPushItem (this, navigationBar, item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been pushed onto the navigation stack.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPushItem (IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:didPushItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to pushing the  onto the navigation stack.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationBar:shouldPushItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPushItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			return _ShouldPushItem (this, navigationBar, item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to pushing the  onto the navigation stack.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPushItem (IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:shouldPushItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("navigationBarNSToolbarSection:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UINavigationBarNSToolbarSection GetNSToolbarSection (UINavigationBar navigationBar)
		{
			return _GetNSToolbarSection (this, navigationBar);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UINavigationBarNSToolbarSection _GetNSToolbarSection (IUINavigationBarDelegate This, UINavigationBar navigationBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			UINavigationBarNSToolbarSection ret;
			ret = (UINavigationBarNSToolbarSection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationBarNSToolbarSection:"), navigationBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidPopItem(UIKit.UINavigationBar,UIKit.UINavigationItem)")]
		[DynamicDependencyAttribute ("DidPushItem(UIKit.UINavigationBar,UIKit.UINavigationItem)")]
		[DynamicDependencyAttribute ("GetNSToolbarSection(UIKit.UINavigationBar)")]
		[DynamicDependencyAttribute ("ShouldPopItem(UIKit.UINavigationBar,UIKit.UINavigationItem)")]
		[DynamicDependencyAttribute ("ShouldPushItem(UIKit.UINavigationBar,UIKit.UINavigationItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationBarDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUINavigationBarDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUINavigationBarDelegate" /> interface to support all the methods from the UINavigationBarDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUINavigationBarDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UINavigationBarDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UINavigationBarDelegate_Extensions {
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been popped from the navigation stack.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPopItem (this IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:didPopItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to popping the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPopItem (this IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:shouldPopItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been pushed onto the navigation stack.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPushItem (this IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:didPushItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to pushing the  onto the navigation stack.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPushItem (this IUINavigationBarDelegate This, UINavigationBar navigationBar, UINavigationItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationBar:shouldPushItem:"), navigationBar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			GC.KeepAlive (item);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UINavigationBarNSToolbarSection GetNSToolbarSection (this IUINavigationBarDelegate This, UINavigationBar navigationBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationBar__handle__ = navigationBar!.GetNonNullHandle (nameof (navigationBar));
			UINavigationBarNSToolbarSection ret;
			ret = (UINavigationBarNSToolbarSection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationBarNSToolbarSection:"), navigationBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationBar);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UINavigationBarDelegateWrapper : BaseWrapper, IUINavigationBarDelegate {
		public UINavigationBarDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationBarDelegateWrapper))]
		static UINavigationBarDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUINavigationBarDelegate" /> (for the protocol <c>UINavigationBarDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUINavigationBarDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UINavigationBarDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UINavigationBarDelegate : UIBarPositioningDelegate, IUINavigationBarDelegate {
		/// <summary>Creates a new <see cref="UINavigationBarDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UINavigationBarDelegate () : base (NSObjectFlag.Empty)
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
		protected UINavigationBarDelegate (NSObjectFlag t) : base (t)
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
		protected internal UINavigationBarDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been popped from the navigation stack.</summary><remarks>To be added.</remarks>
		[Export ("navigationBar:didPopItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPopItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system shortly after the  has been pushed onto the navigation stack.</summary><remarks>To be added.</remarks>
		[Export ("navigationBar:didPushItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPushItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("navigationBarNSToolbarSection:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UINavigationBarNSToolbarSection GetNSToolbarSection (UINavigationBar navigationBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to popping the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationBar:shouldPopItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPopItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationBar">To be added.</param><param name="item">To be added.</param><summary>Called by the system prior to pushing the  onto the navigation stack.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationBar:shouldPushItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPushItem (UINavigationBar navigationBar, UINavigationItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UINavigationBarDelegate */
}
