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
namespace NotificationCenter {
	[Register("NCWidgetListViewController", true)]
	[UnsupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NCWidgetListViewController : global::AppKit.NSViewController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsX = "contents";
		static readonly NativeHandle selContentsXHandle = Selector.GetHandle ("contents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditingX = "editing";
		static readonly NativeHandle selEditingXHandle = Selector.GetHandle ("editing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasDividerLinesX = "hasDividerLines";
		static readonly NativeHandle selHasDividerLinesXHandle = Selector.GetHandle ("hasDividerLines");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNibName_Bundle_X = "initWithNibName:bundle:";
		static readonly NativeHandle selInitWithNibName_Bundle_XHandle = Selector.GetHandle ("initWithNibName:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumVisibleRowCountX = "minimumVisibleRowCount";
		static readonly NativeHandle selMinimumVisibleRowCountXHandle = Selector.GetHandle ("minimumVisibleRowCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowForViewController_X = "rowForViewController:";
		static readonly NativeHandle selRowForViewController_XHandle = Selector.GetHandle ("rowForViewController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContents_X = "setContents:";
		static readonly NativeHandle selSetContents_XHandle = Selector.GetHandle ("setContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEditing_X = "setEditing:";
		static readonly NativeHandle selSetEditing_XHandle = Selector.GetHandle ("setEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasDividerLines_X = "setHasDividerLines:";
		static readonly NativeHandle selSetHasDividerLines_XHandle = Selector.GetHandle ("setHasDividerLines:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumVisibleRowCount_X = "setMinimumVisibleRowCount:";
		static readonly NativeHandle selSetMinimumVisibleRowCount_XHandle = Selector.GetHandle ("setMinimumVisibleRowCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsAddButtonWhenEditing_X = "setShowsAddButtonWhenEditing:";
		static readonly NativeHandle selSetShowsAddButtonWhenEditing_XHandle = Selector.GetHandle ("setShowsAddButtonWhenEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsAddButtonWhenEditingX = "showsAddButtonWhenEditing";
		static readonly NativeHandle selShowsAddButtonWhenEditingXHandle = Selector.GetHandle ("showsAddButtonWhenEditing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewControllerAtRow_MakeIfNecessary_X = "viewControllerAtRow:makeIfNecessary:";
		static readonly NativeHandle selViewControllerAtRow_MakeIfNecessary_XHandle = Selector.GetHandle ("viewControllerAtRow:makeIfNecessary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NCWidgetListViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NCWidgetListViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NCWidgetListViewController () : base (NSObjectFlag.Empty)
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
		public NCWidgetListViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NCWidgetListViewController (NSObjectFlag t) : base (t)
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
		protected internal NCWidgetListViewController (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="nibNameOrNull">To be added.</param><param name="nibBundleOrNull">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NCWidgetListViewController (string? nibNameOrNull, NSBundle? nibBundleOrNull)
			: base (NSObjectFlag.Empty)
		{
			var nibBundleOrNull__handle__ = nibBundleOrNull.GetHandle ();
			var nsnibNameOrNull = CFString.CreateNative (nibNameOrNull);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nibBundleOrNull);
			CFString.ReleaseNative (nsnibNameOrNull);
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rowForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetRow (global::AppKit.NSViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selRowForViewController_XHandle, viewController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowForViewController_XHandle, viewController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewController);
			return ret!;
		}
		/// <param name="row">To be added.</param><param name="makeIfNecesary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewControllerAtRow:makeIfNecessary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSViewController GetViewController (nuint row, bool makeIfNecesary)
		{
			global::AppKit.NSViewController ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_bool (this.Handle, selViewControllerAtRow_MakeIfNecessary_XHandle, row, makeIfNecesary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selViewControllerAtRow_MakeIfNecessary_XHandle, row, makeIfNecesary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSViewController[] Contents {
			[Export ("contents", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSViewController[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::AppKit.NSViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::AppKit.NSViewController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContents:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContents_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContents_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INCWidgetListViewDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				INCWidgetListViewDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INCWidgetListViewDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<INCWidgetListViewDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Editing {
			[Export ("editing")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEditingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEditingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEditing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEditing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEditing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDividerLines {
			[Export ("hasDividerLines")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDividerLinesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasDividerLinesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasDividerLines:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasDividerLines_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasDividerLines_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MinimumVisibleRowCount {
			[Export ("minimumVisibleRowCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMinimumVisibleRowCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMinimumVisibleRowCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumVisibleRowCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMinimumVisibleRowCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMinimumVisibleRowCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsAddButtonWhenEditing {
			[Export ("showsAddButtonWhenEditing")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsAddButtonWhenEditingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsAddButtonWhenEditingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsAddButtonWhenEditing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsAddButtonWhenEditing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsAddButtonWhenEditing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NCWidgetListViewDelegate); }
		}
		internal virtual _NCWidgetListViewDelegate CreateInternalEventDelegateType ()
		{
			return (_NCWidgetListViewDelegate)(new _NCWidgetListViewDelegate());
		}
		internal _NCWidgetListViewDelegate EnsureNCWidgetListViewDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _NCWidgetListViewDelegate))){
				del = new _NCWidgetListViewDelegate ();
				Delegate = del;
			}
			return (_NCWidgetListViewDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NCWidgetListViewDelegate : NSObject, INCWidgetListViewDelegate { 
			public _NCWidgetListViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NCWidgetListViewDelegate))]
			static _NCWidgetListViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs>? didRemoveRow;
			[Export ("widgetList:didRemoveRow:")]
			public void DidRemoveRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row)
			{
				var handler = didRemoveRow;
				if (handler is not null){
					var args = new NCWidgetListViewControllerDidRemoveRowEventArgs (row);
					handler (list, args);
				}
			}
			internal EventHandler<NCWidgetListViewControllerDidReorderEventArgs>? didReorderRow;
			[Export ("widgetList:didReorderRow:toRow:")]
			public void DidReorderRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row, UIntPtr newIndex)
			{
				var handler = didReorderRow;
				if (handler is not null){
					var args = new NCWidgetListViewControllerDidReorderEventArgs (row, newIndex);
					handler (list, args);
				}
			}
			internal NCWidgetListViewGetController? getViewControllerForRow;
			[Export ("widgetList:viewControllerForRow:")]
			public NSViewController GetViewControllerForRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row)
			{
				var handler = getViewControllerForRow;
				if (handler is not null)
					return handler (list, row);
				return null!;
			}
			internal EventHandler? performAddAction;
			[Export ("widgetListPerformAddAction:")]
			public void PerformAddAction (NotificationCenter.NCWidgetListViewController list)
			{
				var handler = performAddAction;
				if (handler is not null){
					handler (list, EventArgs.Empty);
				}
			}
			internal NCWidgetListViewControllerShouldRemoveRow? shouldRemoveRow;
			[Export ("widgetList:shouldRemoveRow:")]
			public bool ShouldRemoveRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row)
			{
				var handler = shouldRemoveRow;
				if (handler is not null)
					return handler (list, row);
				return false!;
			}
			internal NCWidgetListViewControllerShouldReorderRow? shouldReorderRow;
			[Export ("widgetList:shouldReorderRow:")]
			public bool ShouldReorderRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row)
			{
				var handler = shouldReorderRow;
				if (handler is not null)
					return handler (list, row);
				return false!;
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NCWidgetListViewControllerDidRemoveRowEventArgs> DidRemoveRow {
			add { EnsureNCWidgetListViewDelegate ()!.didRemoveRow += value; }
			remove { EnsureNCWidgetListViewDelegate ()!.didRemoveRow -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NCWidgetListViewControllerDidReorderEventArgs> DidReorderRow {
			add { EnsureNCWidgetListViewDelegate ()!.didReorderRow += value; }
			remove { EnsureNCWidgetListViewDelegate ()!.didReorderRow -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NCWidgetListViewGetController? GetViewControllerForRow {
			get { return EnsureNCWidgetListViewDelegate ()!.getViewControllerForRow; }
			set { EnsureNCWidgetListViewDelegate ()!.getViewControllerForRow = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler PerformAddAction {
			add { EnsureNCWidgetListViewDelegate ()!.performAddAction += value; }
			remove { EnsureNCWidgetListViewDelegate ()!.performAddAction -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NCWidgetListViewControllerShouldRemoveRow? ShouldRemoveRow {
			get { return EnsureNCWidgetListViewDelegate ()!.shouldRemoveRow; }
			set { EnsureNCWidgetListViewDelegate ()!.shouldRemoveRow = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NCWidgetListViewControllerShouldReorderRow? ShouldReorderRow {
			get { return EnsureNCWidgetListViewDelegate ()!.shouldReorderRow; }
			set { EnsureNCWidgetListViewDelegate ()!.shouldReorderRow = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class NCWidgetListViewController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NCWidgetListViewControllerDidRemoveRowEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NCWidgetListViewControllerDidRemoveRowEventArgs" /> with the specified event data.</summary>
		/// <param name="row">The value for the <see cref="Row" /> property.</param>
		public NCWidgetListViewControllerDidRemoveRowEventArgs (UIntPtr row)
		{
			this.Row = row;
		}
		public UIntPtr Row { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NCWidgetListViewControllerDidReorderEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NCWidgetListViewControllerDidReorderEventArgs" /> with the specified event data.</summary>
		/// <param name="row">The value for the <see cref="Row" /> property.</param>
		/// <param name="newIndex">The value for the <see cref="NewIndex" /> property.</param>
		public NCWidgetListViewControllerDidReorderEventArgs (UIntPtr row, UIntPtr newIndex)
		{
			this.NewIndex = newIndex;
			this.Row = row;
		}
		public UIntPtr NewIndex { get; set; }
		public UIntPtr Row { get; set; }
	}
}
