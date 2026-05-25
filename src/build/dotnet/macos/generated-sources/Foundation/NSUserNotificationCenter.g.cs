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
namespace Foundation {
	[Register("NSUserNotificationCenter", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Advice (@"'NSUserNotification' usages should be replaced with 'UserNotifications' framework.")]
	public unsafe partial class NSUserNotificationCenter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultUserNotificationCenterX = "defaultUserNotificationCenter";
		static readonly NativeHandle selDefaultUserNotificationCenterXHandle = Selector.GetHandle ("defaultUserNotificationCenter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeliverNotification_X = "deliverNotification:";
		static readonly NativeHandle selDeliverNotification_XHandle = Selector.GetHandle ("deliverNotification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeliveredNotificationsX = "deliveredNotifications";
		static readonly NativeHandle selDeliveredNotificationsXHandle = Selector.GetHandle ("deliveredNotifications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllDeliveredNotificationsX = "removeAllDeliveredNotifications";
		static readonly NativeHandle selRemoveAllDeliveredNotificationsXHandle = Selector.GetHandle ("removeAllDeliveredNotifications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDeliveredNotification_X = "removeDeliveredNotification:";
		static readonly NativeHandle selRemoveDeliveredNotification_XHandle = Selector.GetHandle ("removeDeliveredNotification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveScheduledNotification_X = "removeScheduledNotification:";
		static readonly NativeHandle selRemoveScheduledNotification_XHandle = Selector.GetHandle ("removeScheduledNotification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleNotification_X = "scheduleNotification:";
		static readonly NativeHandle selScheduleNotification_XHandle = Selector.GetHandle ("scheduleNotification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduledNotificationsX = "scheduledNotifications";
		static readonly NativeHandle selScheduledNotificationsXHandle = Selector.GetHandle ("scheduledNotifications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScheduledNotifications_X = "setScheduledNotifications:";
		static readonly NativeHandle selSetScheduledNotifications_XHandle = Selector.GetHandle ("setScheduledNotifications:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUserNotificationCenter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSUserNotificationCenter (NSObjectFlag t) : base (t)
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
		protected internal NSUserNotificationCenter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("deliverNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeliverNotification (NSUserNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeliverNotification_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeliverNotification_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeAllDeliveredNotifications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllDeliveredNotifications ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllDeliveredNotificationsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllDeliveredNotificationsXHandle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeDeliveredNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDeliveredNotification (NSUserNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveDeliveredNotification_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveDeliveredNotification_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeScheduledNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveScheduledNotification (NSUserNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveScheduledNotification_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveScheduledNotification_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("scheduleNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScheduleNotification (NSUserNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selScheduleNotification_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selScheduleNotification_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUserNotificationCenter DefaultUserNotificationCenter {
			[Export ("defaultUserNotificationCenter")]
			get {
				NSUserNotificationCenter? ret;
				ret =  Runtime.GetNSObject<NSUserNotificationCenter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultUserNotificationCenterXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSUserNotificationCenterDelegate? Delegate {
			get {
				return (WeakDelegate as INSUserNotificationCenterDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserNotification[] DeliveredNotifications {
			[Export ("deliveredNotifications")]
			get {
				NSUserNotification[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUserNotification>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeliveredNotificationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUserNotification>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeliveredNotificationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserNotification[] ScheduledNotifications {
			[Export ("scheduledNotifications", ArgumentSemantic.Copy)]
			get {
				NSUserNotification[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUserNotification>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selScheduledNotificationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUserNotification>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selScheduledNotificationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setScheduledNotifications:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetScheduledNotifications_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetScheduledNotifications_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
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
			get { return typeof (_NSUserNotificationCenterDelegate); }
		}
		internal virtual _NSUserNotificationCenterDelegate CreateInternalEventDelegateType ()
		{
			return (_NSUserNotificationCenterDelegate)(new _NSUserNotificationCenterDelegate());
		}
		internal _NSUserNotificationCenterDelegate EnsureNSUserNotificationCenterDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSUserNotificationCenterDelegate;
			if (del is null){
				del = (_NSUserNotificationCenterDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSUserNotificationCenterDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSUserNotificationCenterDelegate : NSObject, INSUserNotificationCenterDelegate { 
			public _NSUserNotificationCenterDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSUserNotificationCenterDelegate))]
			static _NSUserNotificationCenterDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<UNCDidActivateNotificationEventArgs>? didActivateNotification;
			[Export ("userNotificationCenter:didActivateNotification:")]
			public void DidActivateNotification (NSUserNotificationCenter center, NSUserNotification notification)
			{
				var handler = didActivateNotification;
				if (handler is not null){
					var args = new UNCDidActivateNotificationEventArgs (notification);
					handler (center, args);
				}
			}
			internal EventHandler<UNCDidDeliverNotificationEventArgs>? didDeliverNotification;
			[Export ("userNotificationCenter:didDeliverNotification:")]
			public void DidDeliverNotification (NSUserNotificationCenter center, NSUserNotification notification)
			{
				var handler = didDeliverNotification;
				if (handler is not null){
					var args = new UNCDidDeliverNotificationEventArgs (notification);
					handler (center, args);
				}
			}
			internal UNCShouldPresentNotification? shouldPresentNotification;
			[Export ("userNotificationCenter:shouldPresentNotification:")]
			public bool ShouldPresentNotification (NSUserNotificationCenter center, NSUserNotification notification)
			{
				var handler = shouldPresentNotification;
				if (handler is not null)
					return handler (center, notification);
				return false!;
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<UNCDidActivateNotificationEventArgs> DidActivateNotification {
			add { EnsureNSUserNotificationCenterDelegate ()!.didActivateNotification += value; }
			remove { EnsureNSUserNotificationCenterDelegate ()!.didActivateNotification -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<UNCDidDeliverNotificationEventArgs> DidDeliverNotification {
			add { EnsureNSUserNotificationCenterDelegate ()!.didDeliverNotification += value; }
			remove { EnsureNSUserNotificationCenterDelegate ()!.didDeliverNotification -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public UNCShouldPresentNotification? ShouldPresentNotification {
			get { return EnsureNSUserNotificationCenterDelegate ()!.shouldPresentNotification; }
			set { EnsureNSUserNotificationCenterDelegate ()!.shouldPresentNotification = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSUserNotificationCenter */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UNCDidActivateNotificationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UNCDidActivateNotificationEventArgs" /> with the specified event data.</summary>
		/// <param name="notification">The value for the <see cref="Notification" /> property.</param>
		public UNCDidActivateNotificationEventArgs (NSUserNotification notification)
		{
			this.Notification = notification;
		}
		public NSUserNotification Notification { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UNCDidDeliverNotificationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UNCDidDeliverNotificationEventArgs" /> with the specified event data.</summary>
		/// <param name="notification">The value for the <see cref="Notification" /> property.</param>
		public UNCDidDeliverNotificationEventArgs (NSUserNotification notification)
		{
			this.Notification = notification;
		}
		public NSUserNotification Notification { get; set; }
	}
}
