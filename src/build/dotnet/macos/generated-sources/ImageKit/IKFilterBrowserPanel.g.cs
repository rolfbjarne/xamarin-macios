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
namespace ImageKit {
	[Register("IKFilterBrowserPanel", true)]
	public unsafe partial class IKFilterBrowserPanel : global::AppKit.NSPanel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_X = "beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_X = "beginWithOptions:modelessDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterBrowserPanelWithStyleMask_X = "filterBrowserPanelWithStyleMask:";
		static readonly NativeHandle selFilterBrowserPanelWithStyleMask_XHandle = Selector.GetHandle ("filterBrowserPanelWithStyleMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterBrowserViewWithOptions_X = "filterBrowserViewWithOptions:";
		static readonly NativeHandle selFilterBrowserViewWithOptions_XHandle = Selector.GetHandle ("filterBrowserViewWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterNameX = "filterName";
		static readonly NativeHandle selFilterNameXHandle = Selector.GetHandle ("filterName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinish_X = "finish:";
		static readonly NativeHandle selFinish_XHandle = Selector.GetHandle ("finish:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalWithOptions_X = "runModalWithOptions:";
		static readonly NativeHandle selRunModalWithOptions_XHandle = Selector.GetHandle ("runModalWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("IKFilterBrowserPanel");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="IKFilterBrowserPanel" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKFilterBrowserPanel () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		public IKFilterBrowserPanel (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected IKFilterBrowserPanel (NSObjectFlag t) : base (t)
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
		protected internal IKFilterBrowserPanel (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="options">To be added.</param><param name="modelessDelegate">To be added.</param><param name="didEndSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Begin (NSDictionary options, NSObject modelessDelegate, Selector didEndSelector, nint contextInfo)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var modelessDelegate__handle__ = modelessDelegate!.GetNonNullHandle (nameof (modelessDelegate));
			var didEndSelector__handle__ = didEndSelector!.GetNonNullHandle (nameof (didEndSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_XHandle, options__handle__, modelessDelegate__handle__, didEndSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_XHandle, options__handle__, modelessDelegate__handle__, didEndSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			GC.KeepAlive (modelessDelegate);
			GC.KeepAlive (didEndSelector);
		}
		/// <param name="options">To be added.</param><param name="docWindow">To be added.</param><param name="modalDelegate">To be added.</param><param name="didEndSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSheet (NSDictionary options, global::AppKit.NSWindow docWindow, NSObject modalDelegate, Selector didEndSelector, nint contextInfo)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var docWindow__handle__ = docWindow!.GetNonNullHandle (nameof (docWindow));
			var modalDelegate__handle__ = modalDelegate!.GetNonNullHandle (nameof (modalDelegate));
			var didEndSelector__handle__ = didEndSelector!.GetNonNullHandle (nameof (didEndSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle, options__handle__, docWindow__handle__, modalDelegate__handle__, didEndSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle, options__handle__, docWindow__handle__, modalDelegate__handle__, didEndSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			GC.KeepAlive (docWindow);
			GC.KeepAlive (modalDelegate);
			GC.KeepAlive (didEndSelector);
		}
		/// <param name="styleMask">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterBrowserPanelWithStyleMask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IKFilterBrowserPanel Create (IKFilterBrowserPanelStyleMask styleMask)
		{
			IKFilterBrowserPanel ret;
			ret =  Runtime.GetNSObject<IKFilterBrowserPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selFilterBrowserPanelWithStyleMask_XHandle, (UInt32)styleMask), false)!;
			return ret;
		}
		/// <param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterBrowserViewWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKFilterBrowserView FilterBrowserView (NSDictionary options)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			IKFilterBrowserView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<IKFilterBrowserView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFilterBrowserViewWithOptions_XHandle, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<IKFilterBrowserView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFilterBrowserViewWithOptions_XHandle, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finish (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinish_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinish_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("runModalWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int RunModal (NSDictionary options)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			int ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.int_objc_msgSend_NativeHandle (this.Handle, selRunModalWithOptions_XHandle, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunModalWithOptions_XHandle, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FilterName {
			[Export ("filterName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFilterNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFilterNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DefaultInputImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKFilterBrowserDefaultInputImage",  "ImageKit")]
		public static NSString DefaultInputImage {
			get {
				if (_DefaultInputImage is null)
					_DefaultInputImage = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserDefaultInputImage")!;
				return _DefaultInputImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExcludeCategories;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKFilterBrowserExcludeCategories",  "ImageKit")]
		public static NSString ExcludeCategories {
			get {
				if (_ExcludeCategories is null)
					_ExcludeCategories = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserExcludeCategories")!;
				return _ExcludeCategories;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExcludeFilters;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKFilterBrowserExcludeFilters",  "ImageKit")]
		public static NSString ExcludeFilters {
			get {
				if (_ExcludeFilters is null)
					_ExcludeFilters = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserExcludeFilters")!;
				return _ExcludeFilters;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterDoubleClickNotification;
		/// <summary>Notification constant for FilterDoubleClick</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveFilterDoubleClick(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveFilterDoubleClick(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick ((sender, args) => {
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
		/// void Callback (object sender, IKFilterBrowserPanel.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick (Callback);
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
		///     IKFilterBrowserPanel.FilterDoubleClickNotification, (notification) => { Console.WriteLine ("Received the notification FilterDoubleClick", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification FilterDoubleClick", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (IKFilterBrowserPanel.FilterDoubleClickNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("IKFilterBrowserFilterDoubleClickNotification",  "ImageKit")]
		[Advice ("Use IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick helper method instead.")]
		public static NSString FilterDoubleClickNotification {
			get {
				if (_FilterDoubleClickNotification is null)
					_FilterDoubleClickNotification = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserFilterDoubleClickNotification")!;
				return _FilterDoubleClickNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterSelectedNotification;
		/// <summary>Notification constant for FilterSelected</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveFilterSelected(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveFilterSelected(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = IKFilterBrowserPanel.Notifications.ObserveFilterSelected ((sender, args) => {
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
		/// void Callback (object sender, IKFilterBrowserPanel.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = IKFilterBrowserPanel.Notifications.ObserveFilterSelected (Callback);
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
		///     IKFilterBrowserPanel.FilterSelectedNotification, (notification) => { Console.WriteLine ("Received the notification FilterSelected", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification FilterSelected", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (IKFilterBrowserPanel.FilterSelectedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("IKFilterBrowserFilterSelectedNotification",  "ImageKit")]
		[Advice ("Use IKFilterBrowserPanel.Notifications.ObserveFilterSelected helper method instead.")]
		public static NSString FilterSelectedNotification {
			get {
				if (_FilterSelectedNotification is null)
					_FilterSelectedNotification = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserFilterSelectedNotification")!;
				return _FilterSelectedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowCategories;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKFilterBrowserShowCategories",  "ImageKit")]
		public static NSString ShowCategories {
			get {
				if (_ShowCategories is null)
					_ShowCategories = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserShowCategories")!;
				return _ShowCategories;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowPreview;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKFilterBrowserShowPreview",  "ImageKit")]
		public static NSString ShowPreview {
			get {
				if (_ShowPreview is null)
					_ShowPreview = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserShowPreview")!;
				return _ShowPreview;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillPreviewFilterNotification;
		/// <summary>Notification constant for WillPreviewFilter</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillPreviewFilter(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillPreviewFilter(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter ((sender, args) => {
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
		/// void Callback (object sender, IKFilterBrowserPanel.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter (Callback);
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
		///     IKFilterBrowserPanel.WillPreviewFilterNotification, (notification) => { Console.WriteLine ("Received the notification WillPreviewFilter", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillPreviewFilter", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (IKFilterBrowserPanel.WillPreviewFilterNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("IKFilterBrowserWillPreviewFilterNotification",  "ImageKit")]
		[Advice ("Use IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter helper method instead.")]
		public static NSString WillPreviewFilterNotification {
			get {
				if (_WillPreviewFilterNotification is null)
					_WillPreviewFilterNotification = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKFilterBrowserWillPreviewFilterNotification")!;
				return _WillPreviewFilterNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::ImageKit.IKFilterBrowserPanel" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.FilterDoubleClickNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.FilterDoubleClickNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick ((notification) => {
			///   Console.WriteLine ("Observed FilterDoubleClickNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFilterDoubleClick (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FilterDoubleClickNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.FilterDoubleClickNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.FilterDoubleClickNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed FilterDoubleClickNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFilterDoubleClick (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FilterDoubleClickNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.FilterSelectedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.FilterSelectedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveFilterSelected ((notification) => {
			///   Console.WriteLine ("Observed FilterSelectedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFilterSelected (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FilterSelectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.FilterSelectedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.FilterSelectedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveFilterSelected (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed FilterSelectedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFilterSelected (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FilterSelectedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.WillPreviewFilterNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.WillPreviewFilterNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter ((notification) => {
			///   Console.WriteLine ("Observed WillPreviewFilterNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPreviewFilter (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillPreviewFilterNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::ImageKit.IKFilterBrowserPanel.WillPreviewFilterNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::ImageKit.IKFilterBrowserPanel.WillPreviewFilterNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillPreviewFilterNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPreviewFilter (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillPreviewFilterNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class IKFilterBrowserPanel */
}
