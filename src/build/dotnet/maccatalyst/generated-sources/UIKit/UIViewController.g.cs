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
	[Register("UIViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIViewController : UIResponder, INSCoding, INSExtensionRequestHandling, IUIAppearanceContainer, IUIContentContainer, IUIFocusEnvironment, IUITraitChangeObservable, IUITraitEnvironment {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIViewController () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UIViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected UIViewController (NSObjectFlag t) : base (t)
		{
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
		protected internal UIViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController (string? nibName, NSBundle? bundle)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var bundle__handle__ = bundle.GetHandle ();
			var nsnibName = CFString.CreateNative (nibName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsnibName);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addChildViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChildViewController (UIViewController childController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childController__handle__ = childController!.GetNonNullHandle (nameof (childController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addChildViewController:"), childController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addChildViewController:"), childController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (childController);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addKeyCommand:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddKeyCommand (UIKeyCommand command)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addKeyCommand:"), command__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addKeyCommand:"), command__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (command);
		}
		[Export ("applicationFinishedRestoringState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationFinishedRestoringState ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("applicationFinishedRestoringState"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("applicationFinishedRestoringState"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("attemptRotationToDeviceOrientation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AttemptRotationToDeviceOrientation ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("attemptRotationToDeviceOrientation"));
		}
		[Export ("beginAppearanceTransition:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginAppearanceTransition (bool isAppearing, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("beginAppearanceTransition:animated:"), isAppearing ? (byte) 1 : (byte) 0, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (&__objc_super__, Selector.GetHandle ("beginAppearanceTransition:animated:"), isAppearing ? (byte) 1 : (byte) 0, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="context">The <see cref="T:Foundation.NSExtensionContext" /> containing extension-relevant data.</param><summary>Developers can implement this method to prepare their extension for the host application request.</summary><remarks><para>Developers who implement this method must call <c>base.BeginRequestWithExtensionContext(context)</c> within their implementation.</para></remarks>
		[Export ("beginRequestWithExtensionContext:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginRequestWithExtensionContext (NSExtensionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("beginRequestWithExtensionContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("beginRequestWithExtensionContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("canPerformUnwindSegueAction:fromViewController:sender:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformUnwind (Selector segueAction, UIViewController fromViewController, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segueAction__handle__ = segueAction!.GetNonNullHandle (nameof (segueAction));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var sender__handle__ = sender.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("canPerformUnwindSegueAction:fromViewController:sender:"), segueAction.Handle, fromViewController__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("canPerformUnwindSegueAction:fromViewController:sender:"), segueAction.Handle, fromViewController__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segueAction);
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("canPerformUnwindSegueAction:fromViewController:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CanPerformUnwind' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'CanPerformUnwind' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CanPerformUnwind' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformUnwindDeprecated (Selector segueAction, UIViewController fromViewController, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segueAction__handle__ = segueAction!.GetNonNullHandle (nameof (segueAction));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("canPerformUnwindSegueAction:fromViewController:withSender:"), segueAction.Handle, fromViewController__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("canPerformUnwindSegueAction:fromViewController:withSender:"), segueAction.Handle, fromViewController__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segueAction);
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("childViewControllerForStatusBarHidden")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? ChildViewControllerForStatusBarHidden ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewController ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForStatusBarHidden")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForStatusBarHidden")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("childViewControllerForStatusBarStyle")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? ChildViewControllerForStatusBarStyle ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewController ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForStatusBarStyle")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForStatusBarStyle")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodeRestorableState (NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		[Export ("didAnimateFirstHalfOfRotationToInterfaceOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios5.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAnimateFirstHalfOfRotation (UIInterfaceOrientation toInterfaceOrientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didAnimateFirstHalfOfRotationToInterfaceOrientation:"), (IntPtr) (long) toInterfaceOrientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("didAnimateFirstHalfOfRotationToInterfaceOrientation:"), (IntPtr) (long) toInterfaceOrientation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didMoveToParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMoveToParentViewController (UIViewController? parent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parent__handle__ = parent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didMoveToParentViewController:"), parent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didMoveToParentViewController:"), parent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parent);
		}
		[Export ("didReceiveMemoryWarning")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMemoryWarning ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didReceiveMemoryWarning"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didReceiveMemoryWarning"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didRotateFromInterfaceOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didRotateFromInterfaceOrientation:"), (IntPtr) (long) fromInterfaceOrientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("didRotateFromInterfaceOrientation:"), (IntPtr) (long) fromInterfaceOrientation);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		[Export ("dismissModalViewControllerAnimated:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'DismissViewController (bool, NSAction)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DismissViewController (bool, NSAction)' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissModalViewController (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("dismissModalViewControllerAnimated:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("dismissModalViewControllerAnimated:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Dismisses the <see cref="T:MediaPlayer.MPMoviePlayerViewController" />.</summary><remarks><para>Along with <see cref="M:UIKit.UIViewController.PresentMoviePlayerViewController(MediaPlayer.MPMoviePlayerViewController)" />, this method can be used to control the presentation and dismissal of a <see cref="T:MediaPlayer.MPMoviePlayerViewController" /></para></remarks><altmember cref="M:UIKit.UIViewController.PresentMoviePlayerViewController(MediaPlayer.MPMoviePlayerViewController)" />
		[Export ("dismissMoviePlayerViewControllerAnimated")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'AVPlayerViewController' (AVKit) instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayerViewController' (AVKit) instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissMoviePlayerViewController ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dismissMoviePlayerViewControllerAnimated"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dismissMoviePlayerViewControllerAnimated"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dismissViewControllerAnimated:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DismissViewController (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("dismissViewControllerAnimated:completion:"), animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("dismissViewControllerAnimated:completion:"), animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="animated">Boolean that determines if the transition is to be animated.</param>
		/// <summary>Dismisses the presented view controller.</summary>
		/// <returns>A task that represents the asynchronous DismissViewController operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DismissViewControllerAsync (bool animated)
		{
			var tcs = new TaskCompletionSource<bool> ();
			DismissViewController(animated, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("encodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("endAppearanceTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndAppearanceTransition ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endAppearanceTransition"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("endAppearanceTransition"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("allowedChildViewControllersForUnwindingFromSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController[] GetAllowedChildViewControllersForUnwinding (UIStoryboardUnwindSegueSource segueSource)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segueSource__handle__ = segueSource!.GetNonNullHandle (nameof (segueSource));
			UIViewController[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("allowedChildViewControllersForUnwindingFromSource:"), segueSource__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("allowedChildViewControllersForUnwindingFromSource:"), segueSource__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segueSource);
			return ret!;
		}
		[Export ("childViewControllerContainingSegueSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetChildViewControllerContainingSegueSource (UIStoryboardUnwindSegueSource segueSource)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segueSource__handle__ = segueSource!.GetNonNullHandle (nameof (segueSource));
			UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("childViewControllerContainingSegueSource:"), segueSource__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("childViewControllerContainingSegueSource:"), segueSource__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segueSource);
			return ret!;
		}
		[Export ("childViewControllerForInterfaceOrientationLock")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetChildViewControllerForInterfaceOrientationLock ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewController ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForInterfaceOrientationLock")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForInterfaceOrientationLock")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("contentScrollViewForEdge:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIScrollView? GetContentScrollView (NSDirectionalRectEdge edge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIScrollView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("contentScrollViewForEdge:"), (UIntPtr) (ulong) edge), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("contentScrollViewForEdge:"), (UIntPtr) (ulong) edge), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("overrideTraitCollectionForChildViewController:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'TraitOverrides' property of th echild view controller instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'TraitOverrides' property of th echild view controller instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'TraitOverrides' property of th echild view controller instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitCollection GetOverrideTraitCollectionForChildViewController (UIViewController childViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childViewController__handle__ = childViewController!.GetNonNullHandle (nameof (childViewController));
			UITraitCollection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("overrideTraitCollectionForChildViewController:"), childViewController__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("overrideTraitCollectionForChildViewController:"), childViewController__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (childViewController);
			return ret!;
		}
		[Export ("segueForUnwindingToViewController:fromViewController:identifier:")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIStoryboardSegue GetSegueForUnwinding (UIViewController toViewController, UIViewController fromViewController, string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toViewController__handle__ = toViewController!.GetNonNullHandle (nameof (toViewController));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			UIStoryboardSegue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIStoryboardSegue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("segueForUnwindingToViewController:fromViewController:identifier:"), toViewController__handle__, fromViewController__handle__, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIStoryboardSegue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("segueForUnwindingToViewController:fromViewController:identifier:"), toViewController__handle__, fromViewController__handle__, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toViewController);
			GC.KeepAlive (fromViewController);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="contentContainer">The child container whose size is being request.</param><param name="parentContainerSize">The  of the .</param><summary>Gets the size of the content of the specified child <see cref="T:UIKit.IUIContentContainer" /> by using the size of the parent container.</summary><returns>The <see cref="T:CoreGraphics.CGSize" /> of the content of the <paramref name="contentContainer" />.</returns><remarks>To be added.</remarks>
		[Export ("sizeForChildContentContainer:withParentContainerSize:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSizeForChildContentContainer (IUIContentContainer contentContainer, CGSize parentContainerSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var contentContainer__handle__ = contentContainer!.GetNonNullHandle (nameof (contentContainer));
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_CGSize (this.Handle, Selector.GetHandle ("sizeForChildContentContainer:withParentContainerSize:"), contentContainer__handle__, parentContainerSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_NativeHandle_CGSize (&__objc_super__, Selector.GetHandle ("sizeForChildContentContainer:withParentContainerSize:"), contentContainer__handle__, parentContainerSize);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentContainer);
			return ret!;
		}
		[Export ("supportedInterfaceOrientations")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask GetSupportedInterfaceOrientations ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIInterfaceOrientationMask ret;
			if (IsDirectBinding) {
				ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("supportedInterfaceOrientations"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supportedInterfaceOrientations"));
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("targetViewControllerForAction:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetTargetViewControllerForAction (Selector action, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var sender__handle__ = sender.GetHandle ();
			UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("targetViewControllerForAction:sender:"), action.Handle, sender__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("targetViewControllerForAction:sender:"), action.Handle, sender__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			GC.KeepAlive (sender);
			return ret!;
		}
		[Export ("viewControllerForUnwindSegueAction:fromViewController:withSender:")]
		[ObsoletedOSPlatform ("ios9.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForUnwind (Selector segueAction, UIViewController fromViewController, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segueAction__handle__ = segueAction!.GetNonNullHandle (nameof (segueAction));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("viewControllerForUnwindSegueAction:fromViewController:withSender:"), segueAction.Handle, fromViewController__handle__, sender__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("viewControllerForUnwindSegueAction:fromViewController:withSender:"), segueAction.Handle, fromViewController__handle__, sender__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segueAction);
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (sender);
			return ret!;
		}
		[Export ("loadView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadView ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadView"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("loadView"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("loadViewIfNeeded")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadViewIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadViewIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("loadViewIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performSegueWithIdentifier:sender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSegue (string identifier, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var sender__handle__ = sender.GetHandle ();
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performSegueWithIdentifier:sender:"), nsidentifier, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("performSegueWithIdentifier:sender:"), nsidentifier, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="container">The child .</param><summary>Notifies this controller that the preferred size for content for a specified child container has changed.</summary><remarks>To be added.</remarks>
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PreferredContentSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("preferredContentSizeDidChangeForChildContentContainer:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("preferredContentSizeDidChangeForChildContentContainer:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		[Export ("preferredInterfaceOrientationForPresentation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation PreferredInterfaceOrientationForPresentation ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIInterfaceOrientation ret;
			if (IsDirectBinding) {
				ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredInterfaceOrientationForPresentation"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredInterfaceOrientationForPresentation"));
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("preferredStatusBarStyle")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIStatusBarStyle PreferredStatusBarStyle ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIStatusBarStyle ret;
			if (IsDirectBinding) {
				ret = (UIStatusBarStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredStatusBarStyle"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (UIStatusBarStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredStatusBarStyle"));
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("prefersInterfaceOrientationLocked")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersInterfaceOrientationLocked ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersInterfaceOrientationLocked"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prefersInterfaceOrientationLocked"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("prefersStatusBarHidden")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersStatusBarHidden ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersStatusBarHidden"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prefersStatusBarHidden"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("prepareForSegue:sender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForSegue (UIStoryboardSegue segue, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var segue__handle__ = segue!.GetNonNullHandle (nameof (segue));
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("prepareForSegue:sender:"), segue__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareForSegue:sender:"), segue__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (segue);
			GC.KeepAlive (sender);
		}
		[Export ("presentModalViewController:animated:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'PresentViewController (UIViewController, bool, NSAction)' instead and set the 'ModalViewController' property to true.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PresentViewController (UIViewController, bool, NSAction)' instead and set the 'ModalViewController' property to true.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentModalViewController (UIViewController modalViewController, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var modalViewController__handle__ = modalViewController!.GetNonNullHandle (nameof (modalViewController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("presentModalViewController:animated:"), modalViewController__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("presentModalViewController:animated:"), modalViewController__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (modalViewController);
		}
		/// <param name="moviePlayerViewController">The <see cref="T:MediaPlayer.MPMoviePlayerViewController" /> to be presented.</param><summary>Displays a movie controller using the standard transition.</summary><remarks>Along with <see cref="M:UIKit.UIViewController.DismissMoviePlayerViewController" />, this method can be used to control the presentation and dismissal of a <see cref="T:MediaPlayer.MPMoviePlayerViewController" /></remarks>
		[Export ("presentMoviePlayerViewControllerAnimated:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'AVPlayerViewController' (AVKit) instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayerViewController' (AVKit) instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentMoviePlayerViewController (global::MediaPlayer.MPMoviePlayerViewController moviePlayerViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var moviePlayerViewController__handle__ = moviePlayerViewController!.GetNonNullHandle (nameof (moviePlayerViewController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentMoviePlayerViewControllerAnimated:"), moviePlayerViewController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("presentMoviePlayerViewControllerAnimated:"), moviePlayerViewController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (moviePlayerViewController);
		}
		[Export ("presentViewController:animated:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentViewController (UIViewController viewControllerToPresent, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewControllerToPresent__handle__ = viewControllerToPresent!.GetNonNullHandle (nameof (viewControllerToPresent));
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("presentViewController:animated:completion:"), viewControllerToPresent__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("presentViewController:animated:completion:"), viewControllerToPresent__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewControllerToPresent);
		}
		/// <param name="viewControllerToPresent">View controller that displays over the current view controller content.</param>
		/// <param name="animated">Boolean indicating whether to animate presentation or not.</param>
		/// <summary>Modally presents  a view controller.</summary>
		/// <returns>A task that represents the asynchronous PresentViewController operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PresentViewControllerAsync (UIViewController viewControllerToPresent, bool animated)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PresentViewController(viewControllerToPresent, animated, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("registerForPreviewingWithDelegate:sourceView:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerPreviewing RegisterForPreviewingWithDelegate (IUIViewControllerPreviewingDelegate previewingDelegate, UIView sourceView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewingDelegate__handle__ = previewingDelegate!.GetNonNullHandle (nameof (previewingDelegate));
			var sourceView__handle__ = sourceView!.GetNonNullHandle (nameof (sourceView));
			IUIViewControllerPreviewing? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUIViewControllerPreviewing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForPreviewingWithDelegate:sourceView:"), previewingDelegate__handle__, sourceView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUIViewControllerPreviewing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForPreviewingWithDelegate:sourceView:"), previewingDelegate__handle__, sourceView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (previewingDelegate);
			GC.KeepAlive (sourceView);
			return ret!;
		}
		[Export ("registerForTraitChanges:withHandler:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V169))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.SDActionArity2V169.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			IUITraitChangeRegistration ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("registerForTraitChanges:withTarget:action:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("registerForTraitChanges:withAction:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("removeFromParentViewController")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromParentViewController ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeFromParentViewController"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeFromParentViewController"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeKeyCommand:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveKeyCommand (UIKeyCommand command)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeKeyCommand:"), command__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeKeyCommand:"), command__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (command);
		}
		[Export ("setContentScrollView:forEdge:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentScrollView (UIScrollView? scrollView, NSDirectionalRectEdge edge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setContentScrollView:forEdge:"), scrollView__handle__, (UIntPtr) (ulong) edge);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setContentScrollView:forEdge:"), scrollView__handle__, (UIntPtr) (ulong) edge);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		[Export ("setEditing:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEditing (bool editing, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setEditing:animated:"), editing ? (byte) 1 : (byte) 0, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (&__objc_super__, Selector.GetHandle ("setEditing:animated:"), editing ? (byte) 1 : (byte) 0, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[Export ("setNeedsFocusUpdate")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsFocusUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsFocusUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsStatusBarAppearanceUpdate")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsStatusBarAppearanceUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsStatusBarAppearanceUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsStatusBarAppearanceUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsTouchBarUpdate")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsTouchBarUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsTouchBarUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsTouchBarUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateContentUnavailableConfiguration")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateContentUnavailableConfiguration ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateContentUnavailableConfiguration"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateContentUnavailableConfiguration"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateOfHomeIndicatorAutoHidden")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateOfHomeIndicatorAutoHidden ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateOfHomeIndicatorAutoHidden"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateOfHomeIndicatorAutoHidden"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateOfPrefersInterfaceOrientationLocked")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateOfPrefersInterfaceOrientationLocked ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateOfPrefersInterfaceOrientationLocked"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateOfPrefersInterfaceOrientationLocked"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateOfPrefersPointerLocked")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateOfPrefersPointerLocked ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateOfPrefersPointerLocked"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateOfPrefersPointerLocked"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateOfScreenEdgesDeferringSystemGestures")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateOfScreenEdgesDeferringSystemGestures ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateOfScreenEdgesDeferringSystemGestures"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateOfScreenEdgesDeferringSystemGestures"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateOfSupportedInterfaceOrientations")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateOfSupportedInterfaceOrientations ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateOfSupportedInterfaceOrientations"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateOfSupportedInterfaceOrientations"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateProperties")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateProperties ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateProperties"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateProperties"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setOverrideTraitCollection:forChildViewController:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'TraitOverrides' property instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'TraitOverrides' instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'TraitOverrides' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOverrideTraitCollection (UITraitCollection collection, UIViewController childViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collection__handle__ = collection!.GetNonNullHandle (nameof (collection));
			var childViewController__handle__ = childViewController!.GetNonNullHandle (nameof (childViewController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setOverrideTraitCollection:forChildViewController:"), collection__handle__, childViewController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setOverrideTraitCollection:forChildViewController:"), collection__handle__, childViewController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collection);
			GC.KeepAlive (childViewController);
		}
		[Export ("setToolbarItems:animated:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetToolbarItems (UIBarButtonItem[]? items, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_items = items is null ? null : NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setToolbarItems:animated:"), nsa_items.GetHandle (), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setToolbarItems:animated:"), nsa_items.GetHandle (), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("shouldAutorotate")]
		[ObsoletedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutorotate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldAutorotate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldAutorotate"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("shouldAutorotateToInterfaceOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use both 'GetSupportedInterfaceOrientations' and 'PreferredInterfaceOrientationForPresentation' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use both 'GetSupportedInterfaceOrientations' and 'PreferredInterfaceOrientationForPresentation' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("shouldAutorotateToInterfaceOrientation:"), (IntPtr) (long) toInterfaceOrientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("shouldAutorotateToInterfaceOrientation:"), (IntPtr) (long) toInterfaceOrientation);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("shouldPerformSegueWithIdentifier:sender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPerformSegue (string segueIdentifier, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (segueIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (segueIdentifier));
			var sender__handle__ = sender.GetHandle ();
			var nssegueIdentifier = CFString.CreateNative (segueIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldPerformSegueWithIdentifier:sender:"), nssegueIdentifier, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldPerformSegueWithIdentifier:sender:"), nssegueIdentifier, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nssegueIdentifier);
			return ret != 0;
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldUpdateFocusInContext:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UIFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			return ret != 0;
		}
		[Export ("showDetailViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowDetailViewController (UIViewController vc, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showDetailViewController:sender:"), vc__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("showDetailViewController:sender:"), vc__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
		}
		[Export ("showViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowViewController (UIViewController vc, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showViewController:sender:"), vc__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("showViewController:sender:"), vc__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
		}
		/// <param name="container">The child .</param><summary>Notifies this container that auto layout resized a specified child container.</summary><remarks>To be added.</remarks>
		[Export ("systemLayoutFittingSizeDidChangeForChildContentContainer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SystemLayoutFittingSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("systemLayoutFittingSizeDidChangeForChildContentContainer:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("systemLayoutFittingSizeDidChangeForChildContentContainer:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[Export ("traitCollectionDidChange:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TraitCollectionDidChange (UITraitCollection? previousTraitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previousTraitCollection__handle__ = previousTraitCollection.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (previousTraitCollection);
		}
		[Export ("transitionFromViewController:toViewController:duration:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Transition (UIViewController fromViewController, UIViewController toViewController, double duration, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var toViewController__handle__ = toViewController!.GetNonNullHandle (nameof (toViewController));
			using var block_animations = Trampolines.SDAction.CreateNullableBlock (animations);
			BlockLiteral *block_ptr_animations = null;
			if (animations is not null)
				block_ptr_animations = &block_animations;
			using var block_completionHandler = Trampolines.SDUICompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("transitionFromViewController:toViewController:duration:options:animations:completion:"), fromViewController__handle__, toViewController__handle__, duration, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("transitionFromViewController:toViewController:duration:options:animations:completion:"), fromViewController__handle__, toViewController__handle__, duration, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (toViewController);
		}
		/// <param name="fromViewController">The view controller that initiates the action and which is currently visible in the parent hierarchy.</param>
		/// <param name="toViewController">The target view controller (not currently visible).</param>
		/// <param name="duration">Total duration of the animations, measured in seconds.</param>
		/// <param name="options">A mask of options that determines how you want the animations performed.</param>
		/// <param name="animations">An action object containing the changes that the application developer wants to commit to the views. Here is where developers can modify any animatable properties of the views.</param>
		/// <summary>Used for transitioning between two view controller's child view controllers.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Transition operation.   The value of the TResult parameter is a UIKit.UICompletionHandler.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The TransitionAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> TransitionAsync (UIViewController fromViewController, UIViewController toViewController, double duration, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? animations)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Transition(fromViewController, toViewController, duration, options, animations, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("unregisterForPreviewingWithContext:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterForPreviewingWithContext (IUIViewControllerPreviewing previewing)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewing__handle__ = previewing!.GetNonNullHandle (nameof (previewing));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unregisterForPreviewingWithContext:"), previewing__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unregisterForPreviewingWithContext:"), previewing__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (previewing);
		}
		[Export ("unregisterForTraitChanges:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterForTraitChanges (IUITraitChangeRegistration registration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var registration__handle__ = registration!.GetNonNullHandle (nameof (registration));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (registration);
		}
		[Export ("unwindForSegue:towardsViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unwind (UIStoryboardSegue unwindSegue, UIViewController subsequentVC)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var unwindSegue__handle__ = unwindSegue!.GetNonNullHandle (nameof (unwindSegue));
			var subsequentVC__handle__ = subsequentVC!.GetNonNullHandle (nameof (subsequentVC));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("unwindForSegue:towardsViewController:"), unwindSegue__handle__, subsequentVC__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("unwindForSegue:towardsViewController:"), unwindSegue__handle__, subsequentVC__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unwindSegue);
			GC.KeepAlive (subsequentVC);
		}
		[Export ("updateContentUnavailableConfigurationUsingState:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateContentUnavailableConfiguration (UIContentUnavailableConfigurationState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateContentUnavailableConfigurationUsingState:"), state__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("updateContentUnavailableConfigurationUsingState:"), state__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (state);
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[Export ("updateFocusIfNeeded")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFocusIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateFocusIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateProperties")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void UpdateProperties ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateProperties"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateProperties"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updatePropertiesIfNeeded")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatePropertiesIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updatePropertiesIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updatePropertiesIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateTraitsIfNeeded")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTraitsIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateTraitsIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateTraitsIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateViewConstraints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateViewConstraints ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateViewConstraints"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateViewConstraints"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewDidAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidAppear (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidAppear:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("viewDidAppear:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewDidDisappear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidDisappear (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidDisappear:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("viewDidDisappear:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewDidLayoutSubviews")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidLayoutSubviews ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewDidLayoutSubviews"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewDidLayoutSubviews"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidLoad ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewDidLoad"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewDidLoad"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewDidUnload")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidUnload ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewDidUnload"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewDidUnload"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewIsAppearing:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewIsAppearing (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewIsAppearing:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("viewIsAppearing:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewLayoutMarginsDidChange")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void ViewLayoutMarginsDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewLayoutMarginsDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewLayoutMarginsDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewSafeAreaInsetsDidChange")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void ViewSafeAreaInsetsDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewSafeAreaInsetsDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewSafeAreaInsetsDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewWillAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillAppear (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewWillAppear:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("viewWillAppear:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewWillDisappear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillDisappear (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewWillDisappear:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("viewWillDisappear:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewWillLayoutSubviews")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillLayoutSubviews ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewWillLayoutSubviews"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewWillLayoutSubviews"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="toSize">To be added.</param><param name="coordinator">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillTransitionToSize (CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (this.Handle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), toSize, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize_NativeHandle (&__objc_super__, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), toSize, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coordinator);
		}
		[Export ("viewWillUnload")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillUnload ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewWillUnload"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewWillUnload"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willAnimateFirstHalfOfRotationToInterfaceOrientation:duration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios5.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateFirstHalfOfRotation (UIInterfaceOrientation toInterfaceOrientation, double duration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, Selector.GetHandle ("willAnimateFirstHalfOfRotationToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (&__objc_super__, Selector.GetHandle ("willAnimateFirstHalfOfRotationToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willAnimateRotationToInterfaceOrientation:duration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateRotation (UIInterfaceOrientation toInterfaceOrientation, double duration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, Selector.GetHandle ("willAnimateRotationToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (&__objc_super__, Selector.GetHandle ("willAnimateRotationToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willAnimateSecondHalfOfRotationFromInterfaceOrientation:duration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios5.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateSecondHalfOfRotation (UIInterfaceOrientation fromInterfaceOrientation, double duration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, Selector.GetHandle ("willAnimateSecondHalfOfRotationFromInterfaceOrientation:duration:"), (IntPtr) (long) fromInterfaceOrientation, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (&__objc_super__, Selector.GetHandle ("willAnimateSecondHalfOfRotationFromInterfaceOrientation:duration:"), (IntPtr) (long) fromInterfaceOrientation, duration);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willMoveToParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMoveToParentViewController (UIViewController? parent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parent__handle__ = parent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willMoveToParentViewController:"), parent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willMoveToParentViewController:"), parent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parent);
		}
		[Export ("willRotateToInterfaceOrientation:duration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRotate (UIInterfaceOrientation toInterfaceOrientation, double duration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, Selector.GetHandle ("willRotateToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (&__objc_super__, Selector.GetHandle ("willRotateToInterfaceOrientation:duration:"), (IntPtr) (long) toInterfaceOrientation, duration);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="traitCollection">The new trait collection.</param><param name="coordinator">The  coordinating the transition.This parameter can be .</param><summary>Notifies <c>this</c> that its trait collection will change to <paramref name="traitCollection" />, as coordinated by <paramref name="coordinator" />.</summary><remarks>To be added.</remarks>
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransitionToTraitCollection (UITraitCollection traitCollection, IUIViewControllerTransitionCoordinator? coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var traitCollection__handle__ = traitCollection!.GetNonNullHandle (nameof (traitCollection));
			var coordinator__handle__ = coordinator.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("willTransitionToTraitCollection:withTransitionCoordinator:"), traitCollection__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("willTransitionToTraitCollection:withTransitionCoordinator:"), traitCollection__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (traitCollection);
			GC.KeepAlive (coordinator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIPresentationController? ActivePresentationController {
			[Export ("activePresentationController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPresentationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activePresentationController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activePresentationController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIEdgeInsets AdditionalSafeAreaInsets {
			[Export ("additionalSafeAreaInsets", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("additionalSafeAreaInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("additionalSafeAreaInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("additionalSafeAreaInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("additionalSafeAreaInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setAdditionalSafeAreaInsets:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setAdditionalSafeAreaInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setAdditionalSafeAreaInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'UIScrollView.ContentInsetAdjustmentBehavior' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'UIScrollView.ContentInsetAdjustmentBehavior' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIScrollView.ContentInsetAdjustmentBehavior' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AutomaticallyAdjustsScrollViewInsets {
			[Export ("automaticallyAdjustsScrollViewInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyAdjustsScrollViewInsets"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyAdjustsScrollViewInsets"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyAdjustsScrollViewInsets:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyAdjustsScrollViewInsets:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyAdjustsScrollViewInsets:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		public virtual bool AutomaticallyForwardAppearanceAndRotationMethodsToChildViewControllers {
			[Export ("automaticallyForwardAppearanceAndRotationMethodsToChildViewControllers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyForwardAppearanceAndRotationMethodsToChildViewControllers"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyForwardAppearanceAndRotationMethodsToChildViewControllers"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'UIView.SafeAreaLayoutGuide.BottomAnchor' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'UIView.SafeAreaLayoutGuide.BottomAnchor' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIView.SafeAreaLayoutGuide.BottomAnchor' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUILayoutSupport BottomLayoutGuide {
			[Export ("bottomLayoutGuide")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUILayoutSupport? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUILayoutSupport> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bottomLayoutGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUILayoutSupport> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bottomLayoutGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIViewController? ChildViewControllerForHomeIndicatorAutoHidden {
			[Export ("childViewControllerForHomeIndicatorAutoHidden")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForHomeIndicatorAutoHidden")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForHomeIndicatorAutoHidden")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIViewController? ChildViewControllerForPointerLock {
			[Export ("childViewControllerForPointerLock")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForPointerLock")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForPointerLock")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIViewController? ChildViewControllerForScreenEdgesDeferringSystemGestures {
			[Export ("childViewControllerForScreenEdgesDeferringSystemGestures")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForScreenEdgesDeferringSystemGestures")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForScreenEdgesDeferringSystemGestures")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIViewController? ChildViewControllerForTouchBar {
			[Export ("childViewControllerForTouchBar")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllerForTouchBar")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllerForTouchBar")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController[] ChildViewControllers {
			[Export ("childViewControllers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childViewControllers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childViewControllers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'PreferredContentSize' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredContentSize' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual CGSize ContentSizeForViewInPopover {
			[Export ("contentSizeForViewInPopover")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("contentSizeForViewInPopover"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentSizeForViewInPopover"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentSizeForViewInPopover:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setContentSizeForViewInPopover:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("setContentSizeForViewInPopover:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual IUIContentConfiguration? ContentUnavailableConfiguration {
			[Export ("contentUnavailableConfiguration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIContentConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentUnavailableConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentUnavailableConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentUnavailableConfiguration:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContentUnavailableConfiguration:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setContentUnavailableConfiguration:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UIContentUnavailableConfigurationState ContentUnavailableConfigurationState {
			[Export ("contentUnavailableConfigurationState")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIContentUnavailableConfigurationState? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIContentUnavailableConfigurationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentUnavailableConfigurationState")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIContentUnavailableConfigurationState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentUnavailableConfigurationState")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DefinesPresentationContext {
			[Export ("definesPresentationContext")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("definesPresentationContext"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("definesPresentationContext"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDefinesPresentationContext:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDefinesPresentationContext:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setDefinesPresentationContext:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisablesAutomaticKeyboardDismissal {
			[Export ("disablesAutomaticKeyboardDismissal")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disablesAutomaticKeyboardDismissal"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("disablesAutomaticKeyboardDismissal"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIRectEdge EdgesForExtendedLayout {
			[Export ("edgesForExtendedLayout", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIRectEdge ret;
				if (IsDirectBinding) {
					ret = (UIRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("edgesForExtendedLayout"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("edgesForExtendedLayout"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setEdgesForExtendedLayout:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setEdgesForExtendedLayout:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setEdgesForExtendedLayout:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIBarButtonItem EditButtonItem {
			[Export ("editButtonItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("editButtonItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("editButtonItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary><see langword="true" /> if the <see cref="T:UIKit.UIViewController" /> allows the application user to edit the <see cref="T:UIKit.UIView" /> contents.</summary><value><see langword="true" /> if in editing mode, <see langword="false" /> otherwise.</value><remarks><para>
		/// If the application developer wishes to allow editing in the <see cref="T:UIKit.UIViewController" />, they should set this value to <see langword="true" />. If the <see cref="T:UIKit.UIBarButtonItem" /> retrieved by the <see cref="P:UIKit.UIViewController.EditButtonItem" /> is visible in the <see cref="T:UIKit.UINavigationBar" />, that button’s <see cref="P:UIKit.UIBarItem.Title" /> will reflect this value.
		/// </para></remarks><altmember cref="P:UIKit.UIViewController.EditButtonItem" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Editing {
			[Export ("isEditing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEditing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEditing:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEditing:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEditing:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExtendedLayoutIncludesOpaqueBars {
			[Export ("extendedLayoutIncludesOpaqueBars")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("extendedLayoutIncludesOpaqueBars"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extendedLayoutIncludesOpaqueBars"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setExtendedLayoutIncludesOpaqueBars:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setExtendedLayoutIncludesOpaqueBars:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setExtendedLayoutIncludesOpaqueBars:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSExtensionContext? ExtensionContext {
			[Export ("extensionContext")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSExtensionContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("extensionContext")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extensionContext")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? FocusGroupIdentifier {
			[Export ("focusGroupIdentifier")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusGroupIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusGroupIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFocusGroupIdentifier:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFocusGroupIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setFocusGroupIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusItemContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool HidesBottomBarWhenPushed {
			[Export ("hidesBottomBarWhenPushed")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hidesBottomBarWhenPushed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hidesBottomBarWhenPushed"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidesBottomBarWhenPushed:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidesBottomBarWhenPushed:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidesBottomBarWhenPushed:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual string? InteractionActivityTrackingBaseName {
			[Export ("interactionActivityTrackingBaseName")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interactionActivityTrackingBaseName")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interactionActivityTrackingBaseName")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInteractionActivityTrackingBaseName:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInteractionActivityTrackingBaseName:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInteractionActivityTrackingBaseName:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual UIInterfaceOrientation InterfaceOrientation {
			[Export ("interfaceOrientation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIInterfaceOrientation ret;
				if (IsDirectBinding) {
					ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("interfaceOrientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interfaceOrientation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary><see langword="true" /> if the current <see cref="T:UIKit.UIViewController" /> is in the process of being dismissed.</summary><value><see langword="true" /> only if called during the execution of <see cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /> or <see cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" /></value><remarks><para>The dismissal process is bookended by the functions <see cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /> and <see cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" />. While those are executing, this property will return <see langword="true" />, at all other times, it will return <see langword="false" />.</para></remarks><altmember cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /><altmember cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBeingDismissed {
			[Export ("isBeingDismissed")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBeingDismissed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isBeingDismissed"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the current <see cref="T:UIKit.UIViewController" /> is in the process of being presented.</summary><value><see langword="true" /> only if called during the execution of <see cref="M:UIKit.UIViewController.ViewWillAppear(System.Boolean)" /> or <see cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" />.</value><remarks><para>The presentation process is bookended by the functions <see cref="M:UIKit.UIViewController.ViewWillAppear(System.Boolean)" /> and <see cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" />. While those are executing, this property will return <see langword="true" />, at all other times, it will return <see langword="false" />.</para></remarks><altmember cref="M:UIKit.UIViewController.ViewWillAppear(System.Boolean)" /><altmember cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" /><altmember cref="P:UIKit.UIViewController.IsMovingToParentViewController" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBeingPresented {
			[Export ("isBeingPresented")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBeingPresented"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isBeingPresented"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the current <see cref="T:UIKit.UIViewController" /> is in the process of being removed from its parent <see cref="T:UIKit.UIViewController" />.</summary><value><see langword="true" /> only if called during the execution of <see cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /> or <see cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" />.</value><remarks><para>The process of removing a <see cref="T:UIKit.UIViewController" /> from its parent <see cref="T:UIKit.UIViewController" /> is bookended by the functions <see cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /> and <see cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" />. While those are executing, this property will return <see langword="true" />, at all other times, it will return <see langword="false" />.</para></remarks><altmember cref="M:UIKit.UIViewController.ViewWillDisappear(System.Boolean)" /><altmember cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" /><altmember cref="M:UIKit.UIViewController.RemoveFromParentViewController" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMovingFromParentViewController {
			[Export ("isMovingFromParentViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMovingFromParentViewController"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMovingFromParentViewController"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the current <see cref="T:UIKit.UIViewController" /> is in the process of being added to a parent <see cref="T:UIKit.UIViewController" />.</summary><value><see langword="true" /> only if called during the execution of <see cref="M:UIKit.UIViewController.ViewWillAppear(System.Boolean)" /> or <see cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" />.</value><remarks><para>The process of adding a <see cref="T:UIKit.UIViewController" /> to a parent <see cref="T:UIKit.UIViewController" /> is bookended by the functions <see cref="M:UIKit.UIViewController.ViewWillAppear(System.Boolean)" /> and <see cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" />. While those are executing, this property will return <see langword="true" />, at all other times, it will return <see langword="false" />.</para></remarks><altmember cref="M:UIKit.UIViewController.ViewDidAppear(System.Boolean)" /><altmember cref="M:UIKit.UIViewController.ViewDidDisappear(System.Boolean)" /><altmember cref="P:UIKit.UIViewController.IsBeingPresented" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMovingToParentViewController {
			[Export ("isMovingToParentViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMovingToParentViewController"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMovingToParentViewController"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>A <see cref="T:System.Boolean" /> indicating whether the <see cref="P:UIKit.UIViewController.View" /> is loaded into memory.</summary><value><see langword="true" /> if the <see cref="P:UIKit.UIViewController.View" /> is currently loaded into memory.</value><remarks><para>
		/// The <see cref="P:UIKit.UIViewController.View" /> property may be lazily loaded into memory when accessed. This function may be used to determine if that loading has already taken place. 
		/// </para></remarks><altmember cref="P:UIKit.UIViewController.View" /><altmember cref="M:UIKit.UIViewController.LoadView" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsViewLoaded {
			[Export ("isViewLoaded")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isViewLoaded"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isViewLoaded"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if this <see cref="T:UIKit.UIViewController" /> should be presented modally by a <see cref="T:UIKit.UIPopoverController" />.</summary><value>The default value is <see langword="false" />.</value><remarks>Application developers should set this property to <see langword="true" /> if this <see cref="T:UIKit.UIViewController" /> is intended to be presented modally by a <see cref="T:UIKit.UIPopoverController" />. Setting this property to <see langword="true" /> disallows actions outside this <see cref="T:UIKit.UIViewController" /> when it is displayed.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ModalInPresentation' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'ModalInPresentation' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ModalInPresentation' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ModalInPopover {
			[Export ("isModalInPopover")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isModalInPopover"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isModalInPopover"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setModalInPopover:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setModalInPopover:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setModalInPopover:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ModalInPresentation {
			[Export ("isModalInPresentation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isModalInPresentation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isModalInPresentation"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setModalInPresentation:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setModalInPresentation:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setModalInPresentation:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool ModalPresentationCapturesStatusBarAppearance {
			[Export ("modalPresentationCapturesStatusBarAppearance")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("modalPresentationCapturesStatusBarAppearance"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("modalPresentationCapturesStatusBarAppearance"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setModalPresentationCapturesStatusBarAppearance:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setModalPresentationCapturesStatusBarAppearance:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setModalPresentationCapturesStatusBarAppearance:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle ModalPresentationStyle {
			[Export ("modalPresentationStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIModalPresentationStyle ret;
				if (IsDirectBinding) {
					ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("modalPresentationStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("modalPresentationStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setModalPresentationStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setModalPresentationStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setModalPresentationStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalTransitionStyle ModalTransitionStyle {
			[Export ("modalTransitionStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIModalTransitionStyle ret;
				if (IsDirectBinding) {
					ret = (UIModalTransitionStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("modalTransitionStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIModalTransitionStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("modalTransitionStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setModalTransitionStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setModalTransitionStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setModalTransitionStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'PresentedViewController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PresentedViewController' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual UIViewController ModalViewController {
			[Export ("modalViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("modalViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("modalViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UINavigationController? NavigationController {
			[Export ("navigationController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UINavigationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UINavigationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("navigationController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UINavigationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("navigationController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UINavigationItem NavigationItem {
			[Export ("navigationItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UINavigationItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UINavigationItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("navigationItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UINavigationItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("navigationItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBundle? NibBundle {
			[Export ("nibBundle", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSBundle? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("nibBundle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("nibBundle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? NibName {
			[Export ("nibName", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("nibName")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("nibName")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIUserInterfaceStyle OverrideUserInterfaceStyle {
			[Export ("overrideUserInterfaceStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceStyle ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overrideUserInterfaceStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("overrideUserInterfaceStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOverrideUserInterfaceStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOverrideUserInterfaceStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setOverrideUserInterfaceStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentFocusEnvironment_var;
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentFocusEnvironment")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentFocusEnvironment_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? ParentViewController {
			[Export ("parentViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool PerformsActionsWhilePresentingModally {
			[Export ("performsActionsWhilePresentingModally")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("performsActionsWhilePresentingModally"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("performsActionsWhilePresentingModally"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIPopoverPresentationController? PopoverPresentationController {
			[Export ("popoverPresentationController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPopoverPresentationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPopoverPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("popoverPresentationController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPopoverPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("popoverPresentationController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize PreferredContentSize {
			[Export ("preferredContentSize", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredContentSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredContentSize:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setPreferredContentSize:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("setPreferredContentSize:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PreferredFocusedView_var;
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredFocusEnvironments' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView? PreferredFocusedView {
			[Export ("preferredFocusedView", ArgumentSemantic.Weak)]
			[ObsoletedOSPlatform ("ios12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("tvos12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PreferredFocusEnvironments' instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusedView")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PreferredFocusedView_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIRectEdge PreferredScreenEdgesDeferringSystemGestures {
			[Export ("preferredScreenEdgesDeferringSystemGestures")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIRectEdge ret;
				if (IsDirectBinding) {
					ret = (UIRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredScreenEdgesDeferringSystemGestures"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredScreenEdgesDeferringSystemGestures"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIStatusBarAnimation PreferredStatusBarUpdateAnimation {
			[Export ("preferredStatusBarUpdateAnimation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIStatusBarAnimation ret;
				if (IsDirectBinding) {
					ret = (UIStatusBarAnimation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredStatusBarUpdateAnimation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIStatusBarAnimation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredStatusBarUpdateAnimation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual UIViewControllerTransition? PreferredTransition {
			[Export ("preferredTransition", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewControllerTransition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewControllerTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredTransition")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewControllerTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredTransition")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredTransition:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPreferredTransition:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPreferredTransition:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool PrefersHomeIndicatorAutoHidden {
			[Export ("prefersHomeIndicatorAutoHidden")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersHomeIndicatorAutoHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prefersHomeIndicatorAutoHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool PrefersPointerLocked {
			[Export ("prefersPointerLocked")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersPointerLocked"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prefersPointerLocked"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIPresentationController? PresentationController {
			[Export ("presentationController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPresentationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentationController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentationController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? PresentedViewController {
			[Export ("presentedViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentedViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentedViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? PresentingViewController {
			[Export ("presentingViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentingViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentingViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIPreviewActionItem[] PreviewActionItems {
			[Export ("previewActionItems")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIPreviewActionItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIPreviewActionItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("previewActionItems")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIPreviewActionItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("previewActionItems")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProvidesPresentationContextTransitionStyle {
			[Export ("providesPresentationContextTransitionStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("providesPresentationContextTransitionStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("providesPresentationContextTransitionStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setProvidesPresentationContextTransitionStyle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setProvidesPresentationContextTransitionStyle:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setProvidesPresentationContextTransitionStyle:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class? RestorationClass {
			[Export ("restorationClass")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("restorationClass")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("restorationClass")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRestorationClass:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRestorationClass:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRestorationClass:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RestorationIdentifier {
			[Export ("restorationIdentifier", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("restorationIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("restorationIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRestorationIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRestorationIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRestorationIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool RestoresFocusAfterTransition {
			[Export ("restoresFocusAfterTransition")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("restoresFocusAfterTransition"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("restoresFocusAfterTransition"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRestoresFocusAfterTransition:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRestoresFocusAfterTransition:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setRestoresFocusAfterTransition:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual UIView RotatingFooterView {
			[Export ("rotatingFooterView")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rotatingFooterView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rotatingFooterView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual UIView RotatingHeaderView {
			[Export ("rotatingHeaderView")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rotatingHeaderView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rotatingHeaderView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISheetPresentationController? SheetPresentationController {
			[Export ("sheetPresentationController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISheetPresentationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UISheetPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sheetPresentationController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UISheetPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sheetPresentationController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyForwardAppearanceMethods {
			[Export ("shouldAutomaticallyForwardAppearanceMethods")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldAutomaticallyForwardAppearanceMethods"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldAutomaticallyForwardAppearanceMethods"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Adaptive View Controllers instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual bool ShouldAutomaticallyForwardRotationMethods {
			[Export ("shouldAutomaticallyForwardRotationMethods")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldAutomaticallyForwardRotationMethods"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldAutomaticallyForwardRotationMethods"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewController? SplitViewController {
			[Export ("splitViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UISplitViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("splitViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UISplitViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("splitViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIStoryboard? Storyboard {
			[Export ("storyboard", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIStoryboard? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIStoryboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("storyboard")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIStoryboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("storyboard")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSDirectionalEdgeInsets SystemMinimumLayoutMargins {
			[Export ("systemMinimumLayoutMargins")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDirectionalEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("systemMinimumLayoutMargins"));
					} else {
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("systemMinimumLayoutMargins"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("systemMinimumLayoutMargins"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("systemMinimumLayoutMargins"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Tab_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual UITab? Tab {
			[Export ("tab", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITab? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tab")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tab")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Tab_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITabBarController? TabBarController {
			[Export ("tabBarController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITabBarController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITabBarController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tabBarController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITabBarController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tabBarController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITabBarItem TabBarItem {
			[Export ("tabBarItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITabBarItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITabBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tabBarItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITabBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tabBarItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTabBarItem:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTabBarItem:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTabBarItem:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("title")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTitle:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIBarButtonItem[]? ToolbarItems {
			[Export ("toolbarItems", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIBarButtonItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarItems")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIBarButtonItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("toolbarItems")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setToolbarItems:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setToolbarItems:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setToolbarItems:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'UIView.SafeAreaLayoutGuide.TopAnchor' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'UIView.SafeAreaLayoutGuide.TopAnchor' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIView.SafeAreaLayoutGuide.TopAnchor' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUILayoutSupport TopLayoutGuide {
			[Export ("topLayoutGuide")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUILayoutSupport? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUILayoutSupport> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topLayoutGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUILayoutSupport> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("topLayoutGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the trait collection that describes the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitCollection")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("traitCollection")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual IUITraitOverrides TraitOverrides {
			[Export ("traitOverrides")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITraitOverrides? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITraitOverrides> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitOverrides")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITraitOverrides> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("traitOverrides")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>A delegate object that is responsible for producing <see cref="T:UIKit.IUIViewControllerAnimatedTransitioning" />s for custom presentation.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIViewControllerTransitioningDelegate TransitioningDelegate {
			get {
				return (WeakTransitioningDelegate as IUIViewControllerTransitioningDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakTransitioningDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? View {
			[Export ("view", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("view")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("view")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView? ViewIfLoaded {
			[Export ("viewIfLoaded", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("viewIfLoaded")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewIfLoaded")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ViewRespectsSystemMinimumLayoutMargins {
			[Export ("viewRespectsSystemMinimumLayoutMargins")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("viewRespectsSystemMinimumLayoutMargins"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewRespectsSystemMinimumLayoutMargins"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setViewRespectsSystemMinimumLayoutMargins:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setViewRespectsSystemMinimumLayoutMargins:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setViewRespectsSystemMinimumLayoutMargins:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'EdgesForExtendedLayout', 'ExtendedLayoutIncludesOpaqueBars' and 'AutomaticallyAdjustsScrollViewInsets' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'EdgesForExtendedLayout', 'ExtendedLayoutIncludesOpaqueBars' and 'AutomaticallyAdjustsScrollViewInsets' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual bool WantsFullScreenLayout {
			[Export ("wantsFullScreenLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsFullScreenLayout"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("wantsFullScreenLayout"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWantsFullScreenLayout:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWantsFullScreenLayout:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setWantsFullScreenLayout:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakTransitioningDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakTransitioningDelegate {
			[Export ("transitioningDelegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("transitioningDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transitioningDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakTransitioningDelegate_var = ret;
				return ret!;
			}
			[Export ("setTransitioningDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTransitioningDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTransitioningDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakTransitioningDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HierarchyInconsistencyException;
		/// <summary>Constant used to identify broken <see cref="T:UIKit.UIViewController" /> hierarchies.</summary><value>To be added.</value><remarks><para>This identifier is used to identify the exception thrown when a <see cref="T:UIKit.UIView" /> is added to the <see cref="T:UIKit.UIView" /> hierarchy, but that <see cref="T:UIKit.UIView" />'s <see cref="T:UIKit.UIViewController" /> is not part of the <see cref="T:UIKit.UIViewController" /> hierarchy. In other words, the <see cref="T:UIKit.UIView" /> hierarchy and <see cref="T:UIKit.UIViewController" /> hierarchy must be consistent.</para></remarks>
		[Field ("UIViewControllerHierarchyInconsistencyException",  "UIKit")]
		public static NSString HierarchyInconsistencyException {
			get {
				if (_HierarchyInconsistencyException is null)
					_HierarchyInconsistencyException = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIViewControllerHierarchyInconsistencyException")!;
				return _HierarchyInconsistencyException;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowDetailTargetDidChangeNotification;
		/// <summary>Notification constant for ShowDetailTargetDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveShowDetailTargetDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveShowDetailTargetDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIViewController.Notifications.ObserveShowDetailTargetDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIViewController.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIViewController.Notifications.ObserveShowDetailTargetDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIViewController.ShowDetailTargetDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ShowDetailTargetDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ShowDetailTargetDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIViewController.ShowDetailTargetDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIViewControllerShowDetailTargetDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIViewController.Notifications.ObserveShowDetailTargetDidChange helper method instead.")]
		public static NSString ShowDetailTargetDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ShowDetailTargetDidChangeNotification is null)
					_ShowDetailTargetDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIViewControllerShowDetailTargetDidChangeNotification")!;
				return _ShowDetailTargetDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentFocusEnvironment_var = null;
				__mt_PreferredFocusedView_var = null;
				__mt_Tab_var = null;
				__mt_WeakTransitioningDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UIViewController" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIViewController.ShowDetailTargetDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIViewController.ShowDetailTargetDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIViewController.Notifications.ObserveShowDetailTargetDidChange ((notification) => {
			///   Console.WriteLine ("Observed ShowDetailTargetDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShowDetailTargetDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShowDetailTargetDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIViewController.ShowDetailTargetDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIViewController.ShowDetailTargetDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIViewController.Notifications.ObserveShowDetailTargetDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ShowDetailTargetDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShowDetailTargetDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShowDetailTargetDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UIViewController */
}
