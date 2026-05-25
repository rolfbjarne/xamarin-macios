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
namespace AppKit {
	[Register("NSPickerTouchBarItem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPickerTouchBarItem : NSTouchBarItem {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPickerTouchBarItem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSPickerTouchBarItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSPickerTouchBarItem (NSObjectFlag t) : base (t)
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
		protected internal NSPickerTouchBarItem (NativeHandle handle) : base (handle)
		{
		}

		[Export ("pickerTouchBarItemWithIdentifier:labels:selectionMode:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPickerTouchBarItem Create (NSTouchBarItemIdentifier identifier, string[] labels, NSPickerTouchBarItemSelectionMode selectionMode, NSObject? target, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (labels is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (labels));
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			using var nsa_labels = NSArray.FromStrings (labels);
			NSPickerTouchBarItem? ret;
			ret =  Runtime.GetNSObject<NSPickerTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("pickerTouchBarItemWithIdentifier:labels:selectionMode:target:action:"), (int)identifier, nsa_labels.Handle, (IntPtr) (long) selectionMode, target__handle__, action__handle__), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("pickerTouchBarItemWithIdentifier:images:selectionMode:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPickerTouchBarItem Create (NSTouchBarItemIdentifier identifier, NSImage[] images, NSPickerTouchBarItemSelectionMode selectionMode, NSObject? target, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (images is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (images));
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			using var nsa_images = NSArray.FromNSObjects (images);
			NSPickerTouchBarItem? ret;
			ret =  Runtime.GetNSObject<NSPickerTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("pickerTouchBarItemWithIdentifier:images:selectionMode:target:action:"), (int)identifier, nsa_images.Handle, (IntPtr) (long) selectionMode, target__handle__, action__handle__), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("isEnabledAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetEnabled (nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEnabledAtIndex:"), index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("isEnabledAtIndex:"), index);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("imageAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage? GetImage (nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("imageAtIndex:"), index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("imageAtIndex:"), index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("labelAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetLabel (nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("labelAtIndex:"), index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("labelAtIndex:"), index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setEnabled:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEnabled (bool enabled, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("setEnabled:atIndex:"), enabled ? (byte) 1 : (byte) 0, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (&__objc_super__, Selector.GetHandle ("setEnabled:atIndex:"), enabled ? (byte) 1 : (byte) 0, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setImage:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImage (NSImage? image, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setImage:atIndex:"), image__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setImage:atIndex:"), image__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("setLabel:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLabel (string label, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (label is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (label));
			var nslabel = CFString.CreateNative (label);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setLabel:atIndex:"), nslabel, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setLabel:atIndex:"), nslabel, index);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslabel);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? Action {
			[Export ("action", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("action")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("action")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAction:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAction:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAction:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage? CollapsedRepresentationImage {
			[Export ("collapsedRepresentationImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("collapsedRepresentationImage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collapsedRepresentationImage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCollapsedRepresentationImage:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCollapsedRepresentationImage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCollapsedRepresentationImage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CollapsedRepresentationLabel {
			[Export ("collapsedRepresentationLabel")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("collapsedRepresentationLabel")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collapsedRepresentationLabel")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCollapsedRepresentationLabel:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCollapsedRepresentationLabel:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCollapsedRepresentationLabel:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPickerTouchBarItemControlRepresentation ControlRepresentation {
			[Export ("controlRepresentation", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSPickerTouchBarItemControlRepresentation ret;
				if (IsDirectBinding) {
					ret = (NSPickerTouchBarItemControlRepresentation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("controlRepresentation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPickerTouchBarItemControlRepresentation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("controlRepresentation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlRepresentation:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setControlRepresentation:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setControlRepresentation:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CustomizationLabel {
			[Export ("customizationLabel", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customizationLabel")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("customizationLabel")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomizationLabel:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomizationLabel:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCustomizationLabel:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfOptions {
			[Export ("numberOfOptions")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfOptions:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNumberOfOptions:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setNumberOfOptions:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedIndex {
			[Export ("selectedIndex")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedIndex"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedIndex"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedIndex:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedIndex:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectedIndex:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor? SelectionColor {
			[Export ("selectionColor", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectionColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectionColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionColor:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectionColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectionColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPickerTouchBarItemSelectionMode SelectionMode {
			[Export ("selectionMode", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSPickerTouchBarItemSelectionMode ret;
				if (IsDirectBinding) {
					ret = (NSPickerTouchBarItemSelectionMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPickerTouchBarItemSelectionMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectionMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionMode:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectionMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectionMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Target_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Target {
			[Export ("target", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("target")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("target")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Weak)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTarget:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTarget:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Target_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Target_var = null;
			}
		}
	} /* class NSPickerTouchBarItem */
}
