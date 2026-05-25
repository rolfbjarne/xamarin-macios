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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[Register("UIPageViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIPageViewController : UIViewController, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIPageViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIPageViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPageViewController () : base (NSObjectFlag.Empty)
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
		public UIPageViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UIPageViewController (NSObjectFlag t) : base (t)
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
		protected internal UIPageViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIPageViewController (string? nibName, NSBundle? bundle)
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
		[Export ("initWithTransitionStyle:navigationOrientation:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIPageViewController (UIPageViewControllerTransitionStyle style, UIPageViewControllerNavigationOrientation navigationOrientation, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithTransitionStyle:navigationOrientation:options:"), (IntPtr) (long) style, (IntPtr) (long) navigationOrientation, options__handle__), "initWithTransitionStyle:navigationOrientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTransitionStyle:navigationOrientation:options:"), (IntPtr) (long) style, (IntPtr) (long) navigationOrientation, options__handle__), "initWithTransitionStyle:navigationOrientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
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
		public new virtual void EncodeTo (NSCoder encoder)
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
		[Export ("setViewControllers:direction:animated:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetViewControllers (UIViewController[] viewControllers, UIPageViewControllerNavigationDirection direction, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (viewControllers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (viewControllers));
			using var nsa_viewControllers = NSArray.FromNSObjects (viewControllers);
			using var block_completionHandler = Trampolines.SDUICompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (this.Handle, Selector.GetHandle ("setViewControllers:direction:animated:completion:"), nsa_viewControllers.Handle, (IntPtr) (long) direction, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("setViewControllers:direction:animated:completion:"), nsa_viewControllers.Handle, (IntPtr) (long) direction, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="viewControllers">To be added.</param>
		/// <param name="direction">To be added.</param>
		/// <param name="animated">To be added.</param>
		/// <summary>Sets the UIViewControllers to be displayed.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous SetViewControllers operation.   The value of the TResult parameter is a <see cref="UIKit.UICompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The SetViewControllersAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SetViewControllersAsync (UIViewController[] viewControllers, UIPageViewControllerNavigationDirection direction, bool animated)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetViewControllers(viewControllers, direction, animated, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		/// <summary>The source for data for this UIPageViewController.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIPageViewControllerDataSource DataSource {
			get {
				return (WeakDataSource as IUIPageViewControllerDataSource)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDataSource = rvalue;
			}
		}
		/// <summary>An instance of the UIKit.IUIPageViewControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUIPageViewControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIPageViewControllerDelegate Delegate {
			get {
				return (WeakDelegate as IUIPageViewControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Whether content appears on the backs of pages. The default is false.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoubleSided {
			[Export ("isDoubleSided")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDoubleSided"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isDoubleSided"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDoubleSided:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDoubleSided:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setDoubleSided:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIGestureRecognizer[] GestureRecognizers {
			[Export ("gestureRecognizers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIGestureRecognizer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIGestureRecognizer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("gestureRecognizers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIGestureRecognizer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("gestureRecognizers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPageViewControllerNavigationOrientation NavigationOrientation {
			[Export ("navigationOrientation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPageViewControllerNavigationOrientation ret;
				if (IsDirectBinding) {
					ret = (UIPageViewControllerNavigationOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationOrientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIPageViewControllerNavigationOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("navigationOrientation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPageViewControllerSpineLocation SpineLocation {
			[Export ("spineLocation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPageViewControllerSpineLocation ret;
				if (IsDirectBinding) {
					ret = (UIPageViewControllerSpineLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("spineLocation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIPageViewControllerSpineLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("spineLocation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPageViewControllerTransitionStyle TransitionStyle {
			[Export ("transitionStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPageViewControllerTransitionStyle ret;
				if (IsDirectBinding) {
					ret = (UIPageViewControllerTransitionStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transitionStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIPageViewControllerTransitionStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transitionStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController[] ViewControllers {
			[Export ("viewControllers")]
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
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataSource")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret!;
			}
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDataSource_var, value, GetInternalEventDataSourceType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDataSource:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDataSource:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDataSource_var = value;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionInterPageSpacingKey;
		/// <summary>Represents the value associated with the constant 'UIPageViewControllerOptionInterPageSpacingKey'.</summary>
		[Field ("UIPageViewControllerOptionInterPageSpacingKey",  "UIKit")]
		internal static NSString OptionInterPageSpacingKey {
			get {
				if (_OptionInterPageSpacingKey is null)
					_OptionInterPageSpacingKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPageViewControllerOptionInterPageSpacingKey")!;
				return _OptionInterPageSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionSpineLocationKey;
		/// <summary>Represents the value associated with the constant UIPageViewControllerOptionSpineLocationKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPageViewControllerOptionSpineLocationKey",  "UIKit")]
		public static NSString OptionSpineLocationKey {
			get {
				if (_OptionSpineLocationKey is null)
					_OptionSpineLocationKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPageViewControllerOptionSpineLocationKey")!;
				return _OptionSpineLocationKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_UIPageViewControllerDelegate); }
		}
		internal virtual _UIPageViewControllerDelegate CreateInternalEventDelegateType ()
		{
			return (_UIPageViewControllerDelegate)(new _UIPageViewControllerDelegate());
		}
		internal _UIPageViewControllerDelegate EnsureUIPageViewControllerDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UIPageViewControllerDelegate;
			if (del is null){
				del = (_UIPageViewControllerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUIPageViewControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UIPageViewControllerDelegate : NSObject, IUIPageViewControllerDelegate { 
			public _UIPageViewControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIPageViewControllerDelegate))]
			static _UIPageViewControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<UIPageViewFinishedAnimationEventArgs>? didFinishAnimating;
			[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
			public void DidFinishAnimating (UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed)
			{
				var handler = didFinishAnimating;
				if (handler is not null){
					var args = new UIPageViewFinishedAnimationEventArgs (finished, previousViewControllers, completed);
					handler (pageViewController, args);
				}
			}
			internal EventHandler<UIPageViewControllerTransitionEventArgs>? willTransition;
			[Export ("pageViewController:willTransitionToViewControllers:")]
			public void WillTransition (UIPageViewController pageViewController, UIViewController[] pendingViewControllers)
			{
				var handler = willTransition;
				if (handler is not null){
					var args = new UIPageViewControllerTransitionEventArgs (pendingViewControllers);
					handler (pageViewController, args);
				}
			}
		}
		#pragma warning restore 672
		internal virtual Type GetInternalEventDataSourceType
		{
			get { return typeof (_UIPageViewControllerDataSource); }
		}
		internal virtual _UIPageViewControllerDataSource CreateInternalEventDataSourceType ()
		{
			return (_UIPageViewControllerDataSource)(new _UIPageViewControllerDataSource());
		}
		internal _UIPageViewControllerDataSource EnsureUIPageViewControllerDataSource ()
		{
			if (WeakDataSource is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDataSource, GetInternalEventDataSourceType);
			var del = DataSource as _UIPageViewControllerDataSource;
			if (del is null){
				del = (_UIPageViewControllerDataSource)CreateInternalEventDataSourceType ();
				DataSource = (IUIPageViewControllerDataSource)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UIPageViewControllerDataSource : NSObject, IUIPageViewControllerDataSource { 
			public _UIPageViewControllerDataSource () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIPageViewControllerDataSource))]
			static _UIPageViewControllerDataSource ()
			{
				GC.KeepAlive (null);
			}
			internal UIPageViewGetViewController? getNextViewController;
			[Export ("pageViewController:viewControllerAfterViewController:")]
			public UIViewController GetNextViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
			{
				var handler = getNextViewController;
				if (handler is not null)
					return handler (pageViewController, referenceViewController);
				return null!;
			}
			internal UIPageViewGetNumber? getPresentationCount;
			[Export ("presentationCountForPageViewController:")]
			public IntPtr GetPresentationCount (UIPageViewController pageViewController)
			{
				var handler = getPresentationCount;
				if (handler is not null)
					return handler (pageViewController);
				return ((nint) (1));
			}
			internal UIPageViewGetNumber? getPresentationIndex;
			[Export ("presentationIndexForPageViewController:")]
			public IntPtr GetPresentationIndex (UIPageViewController pageViewController)
			{
				var handler = getPresentationIndex;
				if (handler is not null)
					return handler (pageViewController);
				return ((nint) (1));
			}
			internal UIPageViewGetViewController? getPreviousViewController;
			[Export ("pageViewController:viewControllerBeforeViewController:")]
			public UIViewController GetPreviousViewController (UIPageViewController pageViewController, UIViewController referenceViewController)
			{
				var handler = getPreviousViewController;
				if (handler is not null)
					return handler (pageViewController, referenceViewController);
				return null!;
			}
		}
		#pragma warning restore 672
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDataSource property to an internal handler that maps delegates to events.</remarks>
		public UIPageViewGetViewController? GetNextViewController {
			get { return EnsureUIPageViewControllerDataSource ()!.getNextViewController; }
			set { EnsureUIPageViewControllerDataSource ()!.getNextViewController = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDataSource property to an internal handler that maps delegates to events.</remarks>
		public UIPageViewGetNumber? GetPresentationCount {
			get { return EnsureUIPageViewControllerDataSource ()!.getPresentationCount; }
			set { EnsureUIPageViewControllerDataSource ()!.getPresentationCount = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDataSource property to an internal handler that maps delegates to events.</remarks>
		public UIPageViewGetNumber? GetPresentationIndex {
			get { return EnsureUIPageViewControllerDataSource ()!.getPresentationIndex; }
			set { EnsureUIPageViewControllerDataSource ()!.getPresentationIndex = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDataSource property to an internal handler that maps delegates to events.</remarks>
		public UIPageViewGetViewController? GetPreviousViewController {
			get { return EnsureUIPageViewControllerDataSource ()!.getPreviousViewController; }
			set { EnsureUIPageViewControllerDataSource ()!.getPreviousViewController = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UIPageViewFinishedAnimationEventArgs> DidFinishAnimating {
			add { EnsureUIPageViewControllerDelegate ()!.didFinishAnimating += value; }
			remove { EnsureUIPageViewControllerDelegate ()!.didFinishAnimating -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UIPageViewControllerTransitionEventArgs> WillTransition {
			add { EnsureUIPageViewControllerDelegate ()!.willTransition += value; }
			remove { EnsureUIPageViewControllerDelegate ()!.willTransition -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class UIPageViewController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UIPageViewControllerTransitionEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UIPageViewControllerTransitionEventArgs" /> with the specified event data.</summary>
		/// <param name="pendingViewControllers">The value for the <see cref="PendingViewControllers" /> property.</param>
		public UIPageViewControllerTransitionEventArgs (UIViewController[] pendingViewControllers)
		{
			this.PendingViewControllers = pendingViewControllers;
		}
		public UIViewController[] PendingViewControllers { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UIPageViewFinishedAnimationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UIPageViewFinishedAnimationEventArgs" /> with the specified event data.</summary>
		/// <param name="finished">The value for the <see cref="Finished" /> property.</param>
		/// <param name="previousViewControllers">The value for the <see cref="PreviousViewControllers" /> property.</param>
		/// <param name="completed">The value for the <see cref="Completed" /> property.</param>
		public UIPageViewFinishedAnimationEventArgs (bool finished, UIViewController[] previousViewControllers, bool completed)
		{
			this.Completed = completed;
			this.Finished = finished;
			this.PreviousViewControllers = previousViewControllers;
		}
		public bool Completed { get; set; }
		public bool Finished { get; set; }
		public UIViewController[] PreviousViewControllers { get; set; }
	}
}
