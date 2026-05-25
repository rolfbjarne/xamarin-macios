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
	/// <summary>Delegate object whose methods are called in reaction to "3D Touch" on supported hardware</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIViewControllerPreviewingDelegate_Protocol/index.html">Apple documentation for <c>UIViewControllerPreviewingDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerPreviewingDelegate", WrapperType = typeof (UIViewControllerPreviewingDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewControllerForPreview", Selector = "previewingContext:viewControllerForLocation:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (IUIViewControllerPreviewing), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitViewController", Selector = "previewingContext:commitViewController:", ParameterType = new Type [] { typeof (IUIViewControllerPreviewing), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIViewControllerPreviewingDelegate : INativeObject, IDisposable
	{
		/// <param name="previewingContext">The context in which the 3D Touch is occurring..</param><param name="location">The location where the 3D touch is occurring.</param><summary>Method that is called when the user has pressed a source view, blurring the remainder of the screen, so that a preview view controller can be returned.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("previewingContext:viewControllerForLocation:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForPreview (IUIViewControllerPreviewing previewingContext, CGPoint location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring..</param><param name="location">The location where the 3D touch is occurring.</param><summary>Method that is called when the user has pressed a source view, blurring the remainder of the screen, so that a preview view controller can be returned.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewControllerForPreview (IUIViewControllerPreviewingDelegate This, IUIViewControllerPreviewing previewingContext, CGPoint location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewingContext__handle__ = previewingContext!.GetNonNullHandle (nameof (previewingContext));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("previewingContext:viewControllerForLocation:"), previewingContext__handle__, location), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (previewingContext);
			return ret!;
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring.</param><param name="viewControllerToCommit">The  to which the app should transfer control.</param><summary>Method that is called to allow the developer to prepare the commit view.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("previewingContext:commitViewController:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitViewController (IUIViewControllerPreviewing previewingContext, UIViewController viewControllerToCommit)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring.</param><param name="viewControllerToCommit">The  to which the app should transfer control.</param><summary>Method that is called to allow the developer to prepare the commit view.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CommitViewController (IUIViewControllerPreviewingDelegate This, IUIViewControllerPreviewing previewingContext, UIViewController viewControllerToCommit)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewingContext__handle__ = previewingContext!.GetNonNullHandle (nameof (previewingContext));
			var viewControllerToCommit__handle__ = viewControllerToCommit!.GetNonNullHandle (nameof (viewControllerToCommit));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewingContext:commitViewController:"), previewingContext__handle__, viewControllerToCommit__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewingContext);
			GC.KeepAlive (viewControllerToCommit);
		}
		[DynamicDependencyAttribute ("CommitViewController(UIKit.IUIViewControllerPreviewing,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetViewControllerForPreview(UIKit.IUIViewControllerPreviewing,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerPreviewingDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerPreviewingDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerPreviewingDelegateWrapper : BaseWrapper, IUIViewControllerPreviewingDelegate {
		public UIViewControllerPreviewingDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerPreviewingDelegateWrapper))]
		static UIViewControllerPreviewingDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring..</param><param name="location">The location where the 3D touch is occurring.</param><summary>Method that is called when the user has pressed a source view, blurring the remainder of the screen, so that a preview view controller can be returned.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewingContext:viewControllerForLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController GetViewControllerForPreview (IUIViewControllerPreviewing previewingContext, CGPoint location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewingContext__handle__ = previewingContext!.GetNonNullHandle (nameof (previewingContext));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("previewingContext:viewControllerForLocation:"), previewingContext__handle__, location), false)!;
			GC.KeepAlive (previewingContext);
			return ret!;
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring.</param><param name="viewControllerToCommit">The  to which the app should transfer control.</param><summary>Method that is called to allow the developer to prepare the commit view.</summary><remarks>To be added.</remarks>
		[Export ("previewingContext:commitViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CommitViewController (IUIViewControllerPreviewing previewingContext, UIViewController viewControllerToCommit)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewingContext__handle__ = previewingContext!.GetNonNullHandle (nameof (previewingContext));
			var viewControllerToCommit__handle__ = viewControllerToCommit!.GetNonNullHandle (nameof (viewControllerToCommit));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("previewingContext:commitViewController:"), previewingContext__handle__, viewControllerToCommit__handle__);
			GC.KeepAlive (previewingContext);
			GC.KeepAlive (viewControllerToCommit);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object whose methods are called in reaction to "3D Touch" on supported hardware</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIViewControllerPreviewingDelegate_Protocol/index.html">Apple documentation for <c>UIViewControllerPreviewingDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIViewControllerPreviewingDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIViewControllerPreviewingDelegate : NSObject, IUIViewControllerPreviewingDelegate {
		/// <summary>Creates a new <see cref="UIViewControllerPreviewingDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIViewControllerPreviewingDelegate () : base (NSObjectFlag.Empty)
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
		protected UIViewControllerPreviewingDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIViewControllerPreviewingDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="previewingContext">The context in which the 3D Touch is occurring.</param><param name="viewControllerToCommit">The  to which the app should transfer control.</param><summary>Method that is called to allow the developer to prepare the commit view.</summary><remarks>To be added.</remarks>
		[Export ("previewingContext:commitViewController:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitViewController (IUIViewControllerPreviewing previewingContext, UIViewController viewControllerToCommit)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewingContext">The context in which the 3D Touch is occurring..</param><param name="location">The location where the 3D touch is occurring.</param><summary>Method that is called when the user has pressed a source view, blurring the remainder of the screen, so that a preview view controller can be returned.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewingContext:viewControllerForLocation:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForPreview (IUIViewControllerPreviewing previewingContext, CGPoint location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIViewControllerPreviewingDelegate */
}
