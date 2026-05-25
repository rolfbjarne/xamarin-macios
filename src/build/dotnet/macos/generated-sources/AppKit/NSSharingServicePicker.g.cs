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
	[Register("NSSharingServicePicker", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSharingServicePicker : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseX = "close";
		static readonly NativeHandle selCloseXHandle = Selector.GetHandle ("close");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithItems_X = "initWithItems:";
		static readonly NativeHandle selInitWithItems_XHandle = Selector.GetHandle ("initWithItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowRelativeToRect_OfView_PreferredEdge_X = "showRelativeToRect:ofView:preferredEdge:";
		static readonly NativeHandle selShowRelativeToRect_OfView_PreferredEdge_XHandle = Selector.GetHandle ("showRelativeToRect:ofView:preferredEdge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardShareMenuItemX = "standardShareMenuItem";
		static readonly NativeHandle selStandardShareMenuItemXHandle = Selector.GetHandle ("standardShareMenuItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSharingServicePicker");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSSharingServicePicker" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSharingServicePicker () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSSharingServicePicker (NSObjectFlag t) : base (t)
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
		protected internal NSSharingServicePicker (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithItems:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSharingServicePicker (NSObject[] items)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithItems_XHandle, nsa_items.Handle), "initWithItems:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithItems_XHandle, nsa_items.Handle), "initWithItems:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("close")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Close ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCloseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("showRelativeToRect:ofView:preferredEdge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRelativeToRect (CGRect rect, NSView view, NSRectEdge preferredEdge)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr (this.Handle, selShowRelativeToRect_OfView_PreferredEdge_XHandle, rect, view__handle__, (UIntPtr) (ulong) preferredEdge);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_UIntPtr (&__objc_super__, selShowRelativeToRect_OfView_PreferredEdge_XHandle, rect, view__handle__, (UIntPtr) (ulong) preferredEdge);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSSharingServicePickerDelegate? Delegate {
			get {
				return (WeakDelegate as INSSharingServicePickerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSMenuItem StandardShareMenuItem {
			[Export ("standardShareMenuItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenuItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardShareMenuItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardShareMenuItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::AppKit.NSApplication.EnsureUIThread ();
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
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSSharingServicePickerDelegate); }
		}
		internal virtual _NSSharingServicePickerDelegate CreateInternalEventDelegateType ()
		{
			return (_NSSharingServicePickerDelegate)(new _NSSharingServicePickerDelegate());
		}
		internal _NSSharingServicePickerDelegate EnsureNSSharingServicePickerDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSSharingServicePickerDelegate;
			if (del is null){
				del = (_NSSharingServicePickerDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSSharingServicePickerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSSharingServicePickerDelegate : NSObject, INSSharingServicePickerDelegate { 
			public _NSSharingServicePickerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSSharingServicePickerDelegate))]
			static _NSSharingServicePickerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal NSSharingServicePickerDelegateForSharingService? delegateForSharingService;
			[Export ("sharingServicePicker:delegateForSharingService:")]
			public INSSharingServiceDelegate DelegateForSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
			{
				var handler = delegateForSharingService;
				if (handler is not null)
					return handler (sharingServicePicker, sharingService);
				return null!;
			}
			internal EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs>? didChooseSharingService;
			[Export ("sharingServicePicker:didChooseSharingService:")]
			public void DidChooseSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService service)
			{
				var handler = didChooseSharingService;
				if (handler is not null){
					var args = new NSSharingServicePickerDidChooseSharingServiceEventArgs (service);
					handler (sharingServicePicker, args);
				}
			}
			internal NSSharingServicePickerDelegateCollaborationModeRestrictions? getCollaborationModeRestrictions;
			[Export ("sharingServicePickerCollaborationModeRestrictions:")]
			public NSSharingCollaborationModeRestriction[]? GetCollaborationModeRestrictions (NSSharingServicePicker sharingServicePicker)
			{
				var handler = getCollaborationModeRestrictions;
				if (handler is not null)
					return handler (sharingServicePicker);
				return null!;
			}
			internal NSSharingServicePickerSharingServicesForItems? sharingServicesForItems;
			[Export ("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
			public NSSharingService[] SharingServicesForItems (NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
			{
				var handler = sharingServicesForItems;
				if (handler is not null)
					return handler (sharingServicePicker, items, proposedServices);
				return proposedServices!;
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServicePickerDelegateForSharingService? DelegateForSharingService {
			get { return EnsureNSSharingServicePickerDelegate ()!.delegateForSharingService; }
			set { EnsureNSSharingServicePickerDelegate ()!.delegateForSharingService = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs> DidChooseSharingService {
			add { EnsureNSSharingServicePickerDelegate ()!.didChooseSharingService += value; }
			remove { EnsureNSSharingServicePickerDelegate ()!.didChooseSharingService -= value; }
		}
		public NSSharingServicePickerDelegateCollaborationModeRestrictions? GetCollaborationModeRestrictions {
			get { return EnsureNSSharingServicePickerDelegate ()!.getCollaborationModeRestrictions; }
			set { EnsureNSSharingServicePickerDelegate ()!.getCollaborationModeRestrictions = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServicePickerSharingServicesForItems? SharingServicesForItems {
			get { return EnsureNSSharingServicePickerDelegate ()!.sharingServicesForItems; }
			set { EnsureNSSharingServicePickerDelegate ()!.sharingServicesForItems = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSSharingServicePicker */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSSharingServicePickerDidChooseSharingServiceEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSSharingServicePickerDidChooseSharingServiceEventArgs" /> with the specified event data.</summary>
		/// <param name="service">The value for the <see cref="Service" /> property.</param>
		public NSSharingServicePickerDidChooseSharingServiceEventArgs (NSSharingService service)
		{
			this.Service = service;
		}
		public NSSharingService Service { get; set; }
	}
}
