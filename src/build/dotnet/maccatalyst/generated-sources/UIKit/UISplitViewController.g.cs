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
	[Register("UISplitViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UISplitViewController : UIViewController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UISplitViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UISplitViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISplitViewController () : base (NSObjectFlag.Empty)
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
		public UISplitViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UISplitViewController (NSObjectFlag t) : base (t)
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
		protected internal UISplitViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISplitViewController (string? nibName, NSBundle? bundle)
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
		[Export ("initWithStyle:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISplitViewController (UISplitViewControllerStyle style)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithStyle:"), (IntPtr) (long) style), "initWithStyle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithStyle:"), (IntPtr) (long) style), "initWithStyle:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewControllerForColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetViewController (UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewController ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("viewControllerForColumn:"), (IntPtr) (long) column), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("viewControllerForColumn:"), (IntPtr) (long) column), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hideColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideColumn (UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideColumn:"), (IntPtr) (long) column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("hideColumn:"), (IntPtr) (long) column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("isShowingColumn:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsShowingColumn (UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isShowingColumn:"), (IntPtr) (long) column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("isShowingColumn:"), (IntPtr) (long) column);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("setViewController:forColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewController (UIViewController? viewController, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setViewController:forColumn:"), viewController__handle__, (IntPtr) (long) column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setViewController:forColumn:"), viewController__handle__, (IntPtr) (long) column);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewController);
		}
		[Export ("showColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowColumn (UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showColumn:"), (IntPtr) (long) column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("showColumn:"), (IntPtr) (long) column);
					GC.KeepAlive (this);
				}
			}
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
		/// <summary>Gets whether to display only one child view controller.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool Collapsed {
			[Export ("isCollapsed")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCollapsed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isCollapsed"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>An instance of the UIKit.IUISplitViewControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUISplitViewControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUISplitViewControllerDelegate Delegate {
			get {
				return (WeakDelegate as IUISplitViewControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UISplitViewControllerDisplayMode DisplayMode {
			[Export ("displayMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerDisplayMode ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayMode"));
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
		public virtual UIBarButtonItem DisplayModeButtonItem {
			[Export ("displayModeButtonItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("displayModeButtonItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayModeButtonItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISplitViewControllerDisplayModeButtonVisibility DisplayModeButtonVisibility {
			[Export ("displayModeButtonVisibility", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerDisplayModeButtonVisibility ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerDisplayModeButtonVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayModeButtonVisibility"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerDisplayModeButtonVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayModeButtonVisibility"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayModeButtonVisibility:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisplayModeButtonVisibility:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setDisplayModeButtonVisibility:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat MaximumInspectorColumnWidth {
			[Export ("maximumInspectorColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumInspectorColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumInspectorColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumInspectorColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumInspectorColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMaximumInspectorColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat MaximumPrimaryColumnWidth {
			[Export ("maximumPrimaryColumnWidth", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumPrimaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumPrimaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumPrimaryColumnWidth:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumPrimaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMaximumPrimaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat MaximumSupplementaryColumnWidth {
			[Export ("maximumSupplementaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumSupplementaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumSupplementaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumSupplementaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumSupplementaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMaximumSupplementaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat MinimumInspectorColumnWidth {
			[Export ("minimumInspectorColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumInspectorColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumInspectorColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumInspectorColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumInspectorColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumInspectorColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat MinimumPrimaryColumnWidth {
			[Export ("minimumPrimaryColumnWidth", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumPrimaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumPrimaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumPrimaryColumnWidth:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumPrimaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumPrimaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat MinimumSecondaryColumnWidth {
			[Export ("minimumSecondaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumSecondaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumSecondaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumSecondaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumSecondaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumSecondaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat MinimumSupplementaryColumnWidth {
			[Export ("minimumSupplementaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumSupplementaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumSupplementaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumSupplementaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumSupplementaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumSupplementaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UISplitViewControllerDisplayMode PreferredDisplayMode {
			[Export ("preferredDisplayMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerDisplayMode ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredDisplayMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredDisplayMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredDisplayMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredDisplayMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPreferredDisplayMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat PreferredInspectorColumnWidth {
			[Export ("preferredInspectorColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredInspectorColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredInspectorColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredInspectorColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredInspectorColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredInspectorColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat PreferredInspectorColumnWidthFraction {
			[Export ("preferredInspectorColumnWidthFraction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredInspectorColumnWidthFraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredInspectorColumnWidthFraction"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredInspectorColumnWidthFraction:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredInspectorColumnWidthFraction:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredInspectorColumnWidthFraction:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat PreferredPrimaryColumnWidth {
			[Export ("preferredPrimaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredPrimaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredPrimaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredPrimaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredPrimaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredPrimaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat PreferredPrimaryColumnWidthFraction {
			[Export ("preferredPrimaryColumnWidthFraction", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredPrimaryColumnWidthFraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredPrimaryColumnWidthFraction"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredPrimaryColumnWidthFraction:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredPrimaryColumnWidthFraction:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredPrimaryColumnWidthFraction:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat PreferredSecondaryColumnWidth {
			[Export ("preferredSecondaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredSecondaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredSecondaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredSecondaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredSecondaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredSecondaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat PreferredSecondaryColumnWidthFraction {
			[Export ("preferredSecondaryColumnWidthFraction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredSecondaryColumnWidthFraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredSecondaryColumnWidthFraction"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredSecondaryColumnWidthFraction:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredSecondaryColumnWidthFraction:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredSecondaryColumnWidthFraction:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISplitViewControllerSplitBehavior PreferredSplitBehavior {
			[Export ("preferredSplitBehavior", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerSplitBehavior ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerSplitBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredSplitBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerSplitBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredSplitBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredSplitBehavior:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredSplitBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPreferredSplitBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat PreferredSupplementaryColumnWidth {
			[Export ("preferredSupplementaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredSupplementaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredSupplementaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredSupplementaryColumnWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredSupplementaryColumnWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredSupplementaryColumnWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat PreferredSupplementaryColumnWidthFraction {
			[Export ("preferredSupplementaryColumnWidthFraction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("preferredSupplementaryColumnWidthFraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredSupplementaryColumnWidthFraction"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredSupplementaryColumnWidthFraction:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPreferredSupplementaryColumnWidthFraction:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setPreferredSupplementaryColumnWidthFraction:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PresentsWithGesture {
			[Export ("presentsWithGesture")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("presentsWithGesture"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentsWithGesture"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPresentsWithGesture:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPresentsWithGesture:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPresentsWithGesture:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISplitViewControllerBackgroundStyle PrimaryBackgroundStyle {
			[Export ("primaryBackgroundStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerBackgroundStyle ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryBackgroundStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryBackgroundStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrimaryBackgroundStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrimaryBackgroundStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPrimaryBackgroundStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat PrimaryColumnWidth {
			[Export ("primaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("primaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UISplitViewControllerPrimaryEdge PrimaryEdge {
			[Export ("primaryEdge", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerPrimaryEdge ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerPrimaryEdge) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryEdge"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerPrimaryEdge) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryEdge"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrimaryEdge:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrimaryEdge:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPrimaryEdge:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsSecondaryOnlyButton {
			[Export ("showsSecondaryOnlyButton")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsSecondaryOnlyButton"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsSecondaryOnlyButton"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsSecondaryOnlyButton:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsSecondaryOnlyButton:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsSecondaryOnlyButton:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISplitViewControllerSplitBehavior SplitBehavior {
			[Export ("splitBehavior")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerSplitBehavior ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerSplitBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("splitBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerSplitBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("splitBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UISplitViewControllerStyle Style {
			[Export ("style")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerStyle ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("style"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nfloat SupplementaryColumnWidth {
			[Export ("supplementaryColumnWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("supplementaryColumnWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supplementaryColumnWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController[] ViewControllers {
			[Export ("viewControllers", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("viewControllers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewControllers")), false)!;
						GC.KeepAlive (this);
					}
				}
				#pragma warning disable 168
				#pragma warning restore 168
				return ret!;
			}
			[Export ("setViewControllers:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setViewControllers:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setViewControllers:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
				#pragma warning disable 168
				#pragma warning restore 168
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		/// <summary>Represents the value associated with the constant UISplitViewControllerAutomaticDimension</summary><value></value><remarks>To be added.</remarks>
		[Field ("UISplitViewControllerAutomaticDimension",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static nfloat AutomaticDimension {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UISplitViewControllerAutomaticDimension");
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_UISplitViewControllerDelegate); }
		}
		internal virtual _UISplitViewControllerDelegate CreateInternalEventDelegateType ()
		{
			return (_UISplitViewControllerDelegate)(new _UISplitViewControllerDelegate());
		}
		internal _UISplitViewControllerDelegate EnsureUISplitViewControllerDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UISplitViewControllerDelegate;
			if (del is null){
				del = (_UISplitViewControllerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUISplitViewControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UISplitViewControllerDelegate : NSObject, IUISplitViewControllerDelegate { 
			public _UISplitViewControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UISplitViewControllerDelegate))]
			static _UISplitViewControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal UISplitViewControllerCanCollapsePredicate? collapseSecondViewController;
			[Export ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:")]
			public bool CollapseSecondViewController (UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
			{
				var handler = collapseSecondViewController;
				if (handler is not null)
					return handler (splitViewController, secondaryViewController, primaryViewController);
				return true!;
			}
			internal EventHandler? didCollapse;
			[Export ("splitViewControllerDidCollapse:")]
			public void DidCollapse (UISplitViewController splitViewController)
			{
				var handler = didCollapse;
				if (handler is not null){
					handler (splitViewController, EventArgs.Empty);
				}
			}
			internal EventHandler? didExpand;
			[Export ("splitViewControllerDidExpand:")]
			public void DidExpand (UISplitViewController splitViewController)
			{
				var handler = didExpand;
				if (handler is not null){
					handler (splitViewController, EventArgs.Empty);
				}
			}
			internal EventHandler<UISplitViewControllerDidHideColumnEventArgs>? didHideColumn;
			[Export ("splitViewController:didHideColumn:")]
			public void DidHideColumn (UISplitViewController svc, UISplitViewControllerColumn column)
			{
				var handler = didHideColumn;
				if (handler is not null){
					var args = new UISplitViewControllerDidHideColumnEventArgs (column);
					handler (svc, args);
				}
			}
			internal EventHandler<UISplitViewControllerDidShowColumnEventArgs>? didShowColumn;
			[Export ("splitViewController:didShowColumn:")]
			public void DidShowColumn (UISplitViewController svc, UISplitViewControllerColumn column)
			{
				var handler = didShowColumn;
				if (handler is not null){
					var args = new UISplitViewControllerDidShowColumnEventArgs (column);
					handler (svc, args);
				}
			}
			internal UISplitViewControllerDisplayEvent? eventShowDetailViewController;
			[Export ("splitViewController:showDetailViewController:sender:")]
			public bool EventShowDetailViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
			{
				var handler = eventShowDetailViewController;
				if (handler is not null)
					return handler (splitViewController, vc, sender);
				return false!;
			}
			internal UISplitViewControllerDisplayEvent? eventShowViewController;
			[Export ("splitViewController:showViewController:sender:")]
			public bool EventShowViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
			{
				var handler = eventShowViewController;
				if (handler is not null)
					return handler (splitViewController, vc, sender);
				return false!;
			}
			internal UISplitViewControllerGetDisplayModeForExpanding? getDisplayModeForExpanding;
			[Export ("splitViewController:displayModeForExpandingToProposedDisplayMode:")]
			public UISplitViewControllerDisplayMode GetDisplayModeForExpanding (UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode)
			{
				var handler = getDisplayModeForExpanding;
				if (handler is not null)
					return handler (splitViewController, proposedDisplayMode);
				return proposedDisplayMode!;
			}
			internal Func<UISplitViewController,UIInterfaceOrientation>? getPreferredInterfaceOrientationForPresentation;
			[Export ("splitViewControllerPreferredInterfaceOrientationForPresentation:")]
			public UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (UISplitViewController splitViewController)
			{
				var handler = getPreferredInterfaceOrientationForPresentation;
				if (handler is not null)
					return handler (splitViewController);
				return UIKit.UIInterfaceOrientation.Unknown!;
			}
			internal UISplitViewControllerGetViewController? getPrimaryViewControllerForCollapsingSplitViewController;
			[Export ("primaryViewControllerForCollapsingSplitViewController:")]
			public UIViewController GetPrimaryViewControllerForCollapsingSplitViewController (UISplitViewController splitViewController)
			{
				var handler = getPrimaryViewControllerForCollapsingSplitViewController;
				if (handler is not null)
					return handler (splitViewController);
				return null!;
			}
			internal UISplitViewControllerGetViewController? getPrimaryViewControllerForExpandingSplitViewController;
			[Export ("primaryViewControllerForExpandingSplitViewController:")]
			public UIViewController GetPrimaryViewControllerForExpandingSplitViewController (UISplitViewController splitViewController)
			{
				var handler = getPrimaryViewControllerForExpandingSplitViewController;
				if (handler is not null)
					return handler (splitViewController);
				return null!;
			}
			internal UISplitViewControllerFetchTargetForActionHandler? getTargetDisplayModeForAction;
			[Export ("targetDisplayModeForActionInSplitViewController:")]
			public UISplitViewControllerDisplayMode GetTargetDisplayModeForAction (UISplitViewController svc)
			{
				var handler = getTargetDisplayModeForAction;
				if (handler is not null)
					return handler (svc);
				return UIKit.UISplitViewControllerDisplayMode.Automatic!;
			}
			internal UISplitViewControllerGetTopColumnForCollapsing? getTopColumnForCollapsing;
			[Export ("splitViewController:topColumnForCollapsingToProposedTopColumn:")]
			public UISplitViewControllerColumn GetTopColumnForCollapsing (UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn)
			{
				var handler = getTopColumnForCollapsing;
				if (handler is not null)
					return handler (splitViewController, proposedTopColumn);
				return proposedTopColumn!;
			}
			internal EventHandler? interactivePresentationGestureDidEnd;
			[Export ("splitViewControllerInteractivePresentationGestureDidEnd:")]
			public void InteractivePresentationGestureDidEnd (UISplitViewController svc)
			{
				var handler = interactivePresentationGestureDidEnd;
				if (handler is not null){
					handler (svc, EventArgs.Empty);
				}
			}
			internal EventHandler? interactivePresentationGestureWillBegin;
			[Export ("splitViewControllerInteractivePresentationGestureWillBegin:")]
			public void InteractivePresentationGestureWillBegin (UISplitViewController svc)
			{
				var handler = interactivePresentationGestureWillBegin;
				if (handler is not null){
					handler (svc, EventArgs.Empty);
				}
			}
			internal UISplitViewControllerGetSecondaryViewController? separateSecondaryViewController;
			[Export ("splitViewController:separateSecondaryViewControllerFromPrimaryViewController:")]
			public UIViewController SeparateSecondaryViewController (UISplitViewController splitViewController, UIViewController primaryViewController)
			{
				var handler = separateSecondaryViewController;
				if (handler is not null)
					return handler (splitViewController, primaryViewController);
				return null!;
			}
			internal UISplitViewControllerHidePredicate? shouldHideViewController;
			[Export ("splitViewController:shouldHideViewController:inOrientation:")]
			public bool ShouldHideViewController (UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
			{
				var handler = shouldHideViewController;
				if (handler is not null)
					return handler (svc, viewController, inOrientation);
				return true!;
			}
			internal Func<UISplitViewController,UIInterfaceOrientationMask>? supportedInterfaceOrientations;
			[Export ("splitViewControllerSupportedInterfaceOrientations:")]
			public UIInterfaceOrientationMask SupportedInterfaceOrientations (UISplitViewController splitViewController)
			{
				var handler = supportedInterfaceOrientations;
				if (handler is not null)
					return handler (splitViewController);
				return UIKit.UIInterfaceOrientationMask.All!;
			}
			internal EventHandler<UISplitViewControllerDisplayModeEventArgs>? willChangeDisplayMode;
			[Export ("splitViewController:willChangeToDisplayMode:")]
			public void WillChangeDisplayMode (UISplitViewController svc, UISplitViewControllerDisplayMode displayMode)
			{
				var handler = willChangeDisplayMode;
				if (handler is not null){
					var args = new UISplitViewControllerDisplayModeEventArgs (displayMode);
					handler (svc, args);
				}
			}
			internal EventHandler<UISplitViewControllerWillShowHideColumnEventArgs>? willHideColumn;
			[Export ("splitViewController:willHideColumn:")]
			public void WillHideColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
			{
				var handler = willHideColumn;
				if (handler is not null){
					var args = new UISplitViewControllerWillShowHideColumnEventArgs (column);
					handler (splitViewController, args);
				}
			}
			internal EventHandler<UISplitViewHideEventArgs>? willHideViewController;
			[Export ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:")]
			public void WillHideViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
			{
				var handler = willHideViewController;
				if (handler is not null){
					var args = new UISplitViewHideEventArgs (aViewController, barButtonItem, pc);
					handler (svc, args);
				}
			}
			internal EventHandler<UISplitViewPresentEventArgs>? willPresentViewController;
			[Export ("splitViewController:popoverController:willPresentViewController:")]
			public void WillPresentViewController (UISplitViewController svc, UIPopoverController pc, UIViewController aViewController)
			{
				var handler = willPresentViewController;
				if (handler is not null){
					var args = new UISplitViewPresentEventArgs (pc, aViewController);
					handler (svc, args);
				}
			}
			internal EventHandler<UISplitViewControllerWillShowHideColumnEventArgs>? willShowColumn;
			[Export ("splitViewController:willShowColumn:")]
			public void WillShowColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
			{
				var handler = willShowColumn;
				if (handler is not null){
					var args = new UISplitViewControllerWillShowHideColumnEventArgs (column);
					handler (splitViewController, args);
				}
			}
			internal EventHandler<UISplitViewShowEventArgs>? willShowViewController;
			[Export ("splitViewController:willShowViewController:invalidatingBarButtonItem:")]
			public void WillShowViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
			{
				var handler = willShowViewController;
				if (handler is not null){
					var args = new UISplitViewShowEventArgs (aViewController, button);
					handler (svc, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerCanCollapsePredicate? CollapseSecondViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.collapseSecondViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.collapseSecondViewController = value; }
		}
		public event EventHandler DidCollapse {
			add { EnsureUISplitViewControllerDelegate ()!.didCollapse += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.didCollapse -= value; }
		}
		public event EventHandler DidExpand {
			add { EnsureUISplitViewControllerDelegate ()!.didExpand += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.didExpand -= value; }
		}
		public event EventHandler<UISplitViewControllerDidHideColumnEventArgs> DidHideColumn {
			add { EnsureUISplitViewControllerDelegate ()!.didHideColumn += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.didHideColumn -= value; }
		}
		public event EventHandler<UISplitViewControllerDidShowColumnEventArgs> DidShowColumn {
			add { EnsureUISplitViewControllerDelegate ()!.didShowColumn += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.didShowColumn -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerDisplayEvent? EventShowDetailViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.eventShowDetailViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.eventShowDetailViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerDisplayEvent? EventShowViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.eventShowViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.eventShowViewController = value; }
		}
		public UISplitViewControllerGetDisplayModeForExpanding? GetDisplayModeForExpanding {
			get { return EnsureUISplitViewControllerDelegate ()!.getDisplayModeForExpanding; }
			set { EnsureUISplitViewControllerDelegate ()!.getDisplayModeForExpanding = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public Func<UISplitViewController,UIInterfaceOrientation>? GetPreferredInterfaceOrientationForPresentation {
			get { return EnsureUISplitViewControllerDelegate ()!.getPreferredInterfaceOrientationForPresentation; }
			set { EnsureUISplitViewControllerDelegate ()!.getPreferredInterfaceOrientationForPresentation = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerGetViewController? GetPrimaryViewControllerForCollapsingSplitViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.getPrimaryViewControllerForCollapsingSplitViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.getPrimaryViewControllerForCollapsingSplitViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerGetViewController? GetPrimaryViewControllerForExpandingSplitViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.getPrimaryViewControllerForExpandingSplitViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.getPrimaryViewControllerForExpandingSplitViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerFetchTargetForActionHandler? GetTargetDisplayModeForAction {
			get { return EnsureUISplitViewControllerDelegate ()!.getTargetDisplayModeForAction; }
			set { EnsureUISplitViewControllerDelegate ()!.getTargetDisplayModeForAction = value; }
		}
		public UISplitViewControllerGetTopColumnForCollapsing? GetTopColumnForCollapsing {
			get { return EnsureUISplitViewControllerDelegate ()!.getTopColumnForCollapsing; }
			set { EnsureUISplitViewControllerDelegate ()!.getTopColumnForCollapsing = value; }
		}
		public event EventHandler InteractivePresentationGestureDidEnd {
			add { EnsureUISplitViewControllerDelegate ()!.interactivePresentationGestureDidEnd += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.interactivePresentationGestureDidEnd -= value; }
		}
		public event EventHandler InteractivePresentationGestureWillBegin {
			add { EnsureUISplitViewControllerDelegate ()!.interactivePresentationGestureWillBegin += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.interactivePresentationGestureWillBegin -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerGetSecondaryViewController? SeparateSecondaryViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.separateSecondaryViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.separateSecondaryViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UISplitViewControllerHidePredicate? ShouldHideViewController {
			get { return EnsureUISplitViewControllerDelegate ()!.shouldHideViewController; }
			set { EnsureUISplitViewControllerDelegate ()!.shouldHideViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public Func<UISplitViewController,UIInterfaceOrientationMask>? SupportedInterfaceOrientations {
			get { return EnsureUISplitViewControllerDelegate ()!.supportedInterfaceOrientations; }
			set { EnsureUISplitViewControllerDelegate ()!.supportedInterfaceOrientations = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UISplitViewControllerDisplayModeEventArgs> WillChangeDisplayMode {
			add { EnsureUISplitViewControllerDelegate ()!.willChangeDisplayMode += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willChangeDisplayMode -= value; }
		}
		public event EventHandler<UISplitViewControllerWillShowHideColumnEventArgs> WillHideColumn {
			add { EnsureUISplitViewControllerDelegate ()!.willHideColumn += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willHideColumn -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UISplitViewHideEventArgs> WillHideViewController {
			add { EnsureUISplitViewControllerDelegate ()!.willHideViewController += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willHideViewController -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UISplitViewPresentEventArgs> WillPresentViewController {
			add { EnsureUISplitViewControllerDelegate ()!.willPresentViewController += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willPresentViewController -= value; }
		}
		public event EventHandler<UISplitViewControllerWillShowHideColumnEventArgs> WillShowColumn {
			add { EnsureUISplitViewControllerDelegate ()!.willShowColumn += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willShowColumn -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UISplitViewShowEventArgs> WillShowViewController {
			add { EnsureUISplitViewControllerDelegate ()!.willShowViewController += value; }
			remove { EnsureUISplitViewControllerDelegate ()!.willShowViewController -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class UISplitViewController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewControllerDidHideColumnEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewControllerDidHideColumnEventArgs" /> with the specified event data.</summary>
		/// <param name="column">The value for the <see cref="Column" /> property.</param>
		public UISplitViewControllerDidHideColumnEventArgs (UISplitViewControllerColumn column)
		{
			this.Column = column;
		}
		public UISplitViewControllerColumn Column { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewControllerDidShowColumnEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewControllerDidShowColumnEventArgs" /> with the specified event data.</summary>
		/// <param name="column">The value for the <see cref="Column" /> property.</param>
		public UISplitViewControllerDidShowColumnEventArgs (UISplitViewControllerColumn column)
		{
			this.Column = column;
		}
		public UISplitViewControllerColumn Column { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewControllerDisplayModeEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewControllerDisplayModeEventArgs" /> with the specified event data.</summary>
		/// <param name="displayMode">The value for the <see cref="DisplayMode" /> property.</param>
		public UISplitViewControllerDisplayModeEventArgs (UISplitViewControllerDisplayMode displayMode)
		{
			this.DisplayMode = displayMode;
		}
		public UISplitViewControllerDisplayMode DisplayMode { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewControllerWillShowHideColumnEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewControllerWillShowHideColumnEventArgs" /> with the specified event data.</summary>
		/// <param name="column">The value for the <see cref="Column" /> property.</param>
		public UISplitViewControllerWillShowHideColumnEventArgs (UISplitViewControllerColumn column)
		{
			this.Column = column;
		}
		public UISplitViewControllerColumn Column { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewHideEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewHideEventArgs" /> with the specified event data.</summary>
		/// <param name="aViewController">The value for the <see cref="AViewController" /> property.</param>
		/// <param name="barButtonItem">The value for the <see cref="BarButtonItem" /> property.</param>
		/// <param name="pc">The value for the <see cref="Pc" /> property.</param>
		public UISplitViewHideEventArgs (UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			this.AViewController = aViewController;
			this.BarButtonItem = barButtonItem;
			this.Pc = pc;
		}
		public UIViewController AViewController { get; set; }
		public UIBarButtonItem BarButtonItem { get; set; }
		public UIPopoverController Pc { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewPresentEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewPresentEventArgs" /> with the specified event data.</summary>
		/// <param name="pc">The value for the <see cref="Pc" /> property.</param>
		/// <param name="aViewController">The value for the <see cref="AViewController" /> property.</param>
		public UISplitViewPresentEventArgs (UIPopoverController pc, UIViewController aViewController)
		{
			this.AViewController = aViewController;
			this.Pc = pc;
		}
		public UIViewController AViewController { get; set; }
		public UIPopoverController Pc { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UISplitViewShowEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UISplitViewShowEventArgs" /> with the specified event data.</summary>
		/// <param name="aViewController">The value for the <see cref="AViewController" /> property.</param>
		/// <param name="button">The value for the <see cref="Button" /> property.</param>
		public UISplitViewShowEventArgs (UIViewController aViewController, UIBarButtonItem button)
		{
			this.AViewController = aViewController;
			this.Button = button;
		}
		public UIViewController AViewController { get; set; }
		public UIBarButtonItem Button { get; set; }
	}
}
