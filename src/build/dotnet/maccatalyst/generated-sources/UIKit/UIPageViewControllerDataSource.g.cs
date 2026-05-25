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
	/// <summary>This interface represents the Objective-C protocol <c>UIPageViewControllerDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIPageViewControllerDataSource", WrapperType = typeof (UIPageViewControllerDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPreviousViewController", Selector = "pageViewController:viewControllerBeforeViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIPageViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextViewController", Selector = "pageViewController:viewControllerAfterViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIPageViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPresentationCount", Selector = "presentationCountForPageViewController:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UIPageViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPresentationIndex", Selector = "presentationIndexForPageViewController:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UIPageViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIPageViewControllerDataSource : INativeObject, IDisposable
	{
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Retrieves the previous UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pageViewController:viewControllerBeforeViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPreviousViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Retrieves the previous UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetPreviousViewController (IUIPageViewControllerDataSource This, UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			var referenceViewController__handle__ = referenceViewController!.GetNonNullHandle (nameof (referenceViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageViewController:viewControllerBeforeViewController:"), pageViewController__handle__, referenceViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			GC.KeepAlive (referenceViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Returns the next UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pageViewController:viewControllerAfterViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetNextViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Returns the next UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetNextViewController (IUIPageViewControllerDataSource This, UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			var referenceViewController__handle__ = referenceViewController!.GetNonNullHandle (nameof (referenceViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageViewController:viewControllerAfterViewController:"), pageViewController__handle__, referenceViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			GC.KeepAlive (referenceViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><summary>The number of pages to be shown in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentationCountForPageViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPresentationCount (UIPageViewController pageViewController)
		{
			return _GetPresentationCount (this, pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The number of pages to be shown in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPresentationCount (IUIPageViewControllerDataSource This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationCountForPageViewController:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><summary>The index of the page to be highlighted in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentationIndexForPageViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPresentationIndex (UIPageViewController pageViewController)
		{
			return _GetPresentationIndex (this, pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The index of the page to be highlighted in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPresentationIndex (IUIPageViewControllerDataSource This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationIndexForPageViewController:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetNextViewController(UIKit.UIPageViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetPresentationCount(UIKit.UIPageViewController)")]
		[DynamicDependencyAttribute ("GetPresentationIndex(UIKit.UIPageViewController)")]
		[DynamicDependencyAttribute ("GetPreviousViewController(UIKit.UIPageViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageViewControllerDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPageViewControllerDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPageViewControllerDataSource" /> interface to support all the methods from the UIPageViewControllerDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPageViewControllerDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPageViewControllerDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPageViewControllerDataSource_Extensions {
		/// <param name="pageViewController">To be added.</param><summary>The number of pages to be shown in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetPresentationCount (this IUIPageViewControllerDataSource This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationCountForPageViewController:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><summary>The index of the page to be highlighted in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetPresentationIndex (this IUIPageViewControllerDataSource This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationIndexForPageViewController:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPageViewControllerDataSourceWrapper : BaseWrapper, IUIPageViewControllerDataSource {
		public UIPageViewControllerDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageViewControllerDataSourceWrapper))]
		static UIPageViewControllerDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Retrieves the previous UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewController:viewControllerBeforeViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController GetPreviousViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			var referenceViewController__handle__ = referenceViewController!.GetNonNullHandle (nameof (referenceViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pageViewController:viewControllerBeforeViewController:"), pageViewController__handle__, referenceViewController__handle__), false)!;
			GC.KeepAlive (pageViewController);
			GC.KeepAlive (referenceViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Returns the next UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewController:viewControllerAfterViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController GetNextViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			var referenceViewController__handle__ = referenceViewController!.GetNonNullHandle (nameof (referenceViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pageViewController:viewControllerAfterViewController:"), pageViewController__handle__, referenceViewController__handle__), false)!;
			GC.KeepAlive (pageViewController);
			GC.KeepAlive (referenceViewController);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPageViewControllerDataSource" /> (for the protocol <c>UIPageViewControllerDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPageViewControllerDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPageViewControllerDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIPageViewControllerDataSource : NSObject, IUIPageViewControllerDataSource {
		/// <summary>Creates a new <see cref="UIPageViewControllerDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIPageViewControllerDataSource () : base (NSObjectFlag.Empty)
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
		protected UIPageViewControllerDataSource (NSObjectFlag t) : base (t)
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
		protected internal UIPageViewControllerDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Returns the next UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewController:viewControllerAfterViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetNextViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><summary>The number of pages to be shown in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationCountForPageViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPresentationCount (UIPageViewController pageViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><summary>The index of the page to be highlighted in the page indicator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationIndexForPageViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPresentationIndex (UIPageViewController pageViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><param name="referenceViewController">To be added.</param><summary>Retrieves the previous UIViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewController:viewControllerBeforeViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPreviousViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPageViewControllerDataSource */
}
