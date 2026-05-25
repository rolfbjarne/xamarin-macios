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
	/// <summary>This interface represents the Objective-C protocol <c>NSTabViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTabViewDelegate", WrapperType = typeof (NSTabViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTabViewItem", Selector = "tabView:shouldSelectTabViewItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTabView), typeof (NSTabViewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSelect", Selector = "tabView:willSelectTabViewItem:", ParameterType = new Type [] { typeof (NSTabView), typeof (NSTabViewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelect", Selector = "tabView:didSelectTabViewItem:", ParameterType = new Type [] { typeof (NSTabView), typeof (NSTabViewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NumberOfItemsChanged", Selector = "tabViewDidChangeNumberOfTabViewItems:", ParameterType = new Type [] { typeof (NSTabView) }, ParameterByRef = new bool [] { false })]
	public partial interface INSTabViewDelegate : INativeObject, IDisposable
	{
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabView:shouldSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTabViewItem (NSTabView tabView, NSTabViewItem item)
		{
			return _ShouldSelectTabViewItem (this, tabView, item);
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectTabViewItem (INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:shouldSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabView:willSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSelect (NSTabView tabView, NSTabViewItem item)
		{
			_WillSelect (this, tabView, item);
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSelect (INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:willSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabView:didSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (NSTabView tabView, NSTabViewItem item)
		{
			_DidSelect (this, tabView, item);
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelect (INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:didSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		/// <param name="tabView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tabViewDidChangeNumberOfTabViewItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NumberOfItemsChanged (NSTabView tabView)
		{
			_NumberOfItemsChanged (this, tabView);
		}
		/// <param name="tabView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NumberOfItemsChanged (INSTabViewDelegate This, NSTabView tabView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tabViewDidChangeNumberOfTabViewItems:"), tabView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
		}
		[DynamicDependencyAttribute ("DidSelect(AppKit.NSTabView,AppKit.NSTabViewItem)")]
		[DynamicDependencyAttribute ("NumberOfItemsChanged(AppKit.NSTabView)")]
		[DynamicDependencyAttribute ("ShouldSelectTabViewItem(AppKit.NSTabView,AppKit.NSTabViewItem)")]
		[DynamicDependencyAttribute ("WillSelect(AppKit.NSTabView,AppKit.NSTabViewItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTabViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTabViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTabViewDelegate" /> interface to support all the methods from the NSTabViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTabViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTabViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTabViewDelegate_Extensions {
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectTabViewItem (this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:shouldSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSelect (this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:willSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelect (this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabView:didSelectTabViewItem:"), tabView__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		/// <param name="tabView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NumberOfItemsChanged (this INSTabViewDelegate This, NSTabView tabView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tabViewDidChangeNumberOfTabViewItems:"), tabView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTabViewDelegateWrapper : BaseWrapper, INSTabViewDelegate {
		public NSTabViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTabViewDelegateWrapper))]
		static NSTabViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTabViewDelegate" /> (for the protocol <c>NSTabViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTabViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTabViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTabViewDelegate : NSObject, INSTabViewDelegate {
		/// <summary>Creates a new <see cref="NSTabViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTabViewDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTabViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTabViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tabView:didSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (NSTabView tabView, NSTabViewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tabViewDidChangeNumberOfTabViewItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NumberOfItemsChanged (NSTabView tabView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tabView:shouldSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectTabViewItem (NSTabView tabView, NSTabViewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tabView">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tabView:willSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSelect (NSTabView tabView, NSTabViewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTabViewDelegate */
}
