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
namespace PassKit {
	[Register("PKPaymentRequestUpdate", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PKPaymentRequestUpdate : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticReloadPaymentRequestX = "automaticReloadPaymentRequest";
		static readonly NativeHandle selAutomaticReloadPaymentRequestXHandle = Selector.GetHandle ("automaticReloadPaymentRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeferredPaymentRequestX = "deferredPaymentRequest";
		static readonly NativeHandle selDeferredPaymentRequestXHandle = Selector.GetHandle ("deferredPaymentRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPaymentSummaryItems_X = "initWithPaymentSummaryItems:";
		static readonly NativeHandle selInitWithPaymentSummaryItems_XHandle = Selector.GetHandle ("initWithPaymentSummaryItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiTokenContextsX = "multiTokenContexts";
		static readonly NativeHandle selMultiTokenContextsXHandle = Selector.GetHandle ("multiTokenContexts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaymentSummaryItemsX = "paymentSummaryItems";
		static readonly NativeHandle selPaymentSummaryItemsXHandle = Selector.GetHandle ("paymentSummaryItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecurringPaymentRequestX = "recurringPaymentRequest";
		static readonly NativeHandle selRecurringPaymentRequestXHandle = Selector.GetHandle ("recurringPaymentRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticReloadPaymentRequest_X = "setAutomaticReloadPaymentRequest:";
		static readonly NativeHandle selSetAutomaticReloadPaymentRequest_XHandle = Selector.GetHandle ("setAutomaticReloadPaymentRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeferredPaymentRequest_X = "setDeferredPaymentRequest:";
		static readonly NativeHandle selSetDeferredPaymentRequest_XHandle = Selector.GetHandle ("setDeferredPaymentRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMultiTokenContexts_X = "setMultiTokenContexts:";
		static readonly NativeHandle selSetMultiTokenContexts_XHandle = Selector.GetHandle ("setMultiTokenContexts:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaymentSummaryItems_X = "setPaymentSummaryItems:";
		static readonly NativeHandle selSetPaymentSummaryItems_XHandle = Selector.GetHandle ("setPaymentSummaryItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecurringPaymentRequest_X = "setRecurringPaymentRequest:";
		static readonly NativeHandle selSetRecurringPaymentRequest_XHandle = Selector.GetHandle ("setRecurringPaymentRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShippingMethods_X = "setShippingMethods:";
		static readonly NativeHandle selSetShippingMethods_XHandle = Selector.GetHandle ("setShippingMethods:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStatus_X = "setStatus:";
		static readonly NativeHandle selSetStatus_XHandle = Selector.GetHandle ("setStatus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShippingMethodsX = "shippingMethods";
		static readonly NativeHandle selShippingMethodsXHandle = Selector.GetHandle ("shippingMethods");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PKPaymentRequestUpdate");
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
		protected PKPaymentRequestUpdate (NSObjectFlag t) : base (t)
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
		protected internal PKPaymentRequestUpdate (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="paymentSummaryItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPaymentSummaryItems:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKPaymentRequestUpdate (PKPaymentSummaryItem[] paymentSummaryItems)
			: base (NSObjectFlag.Empty)
		{
			if (paymentSummaryItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paymentSummaryItems));
			using var nsa_paymentSummaryItems = NSArray.FromNSObjects (paymentSummaryItems);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPaymentSummaryItems_XHandle, nsa_paymentSummaryItems.Handle), "initWithPaymentSummaryItems:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPaymentSummaryItems_XHandle, nsa_paymentSummaryItems.Handle), "initWithPaymentSummaryItems:");
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual PKAutomaticReloadPaymentRequest? AutomaticReloadPaymentRequest {
			[Export ("automaticReloadPaymentRequest", ArgumentSemantic.Retain)]
			get {
				PKAutomaticReloadPaymentRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PKAutomaticReloadPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAutomaticReloadPaymentRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PKAutomaticReloadPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAutomaticReloadPaymentRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutomaticReloadPaymentRequest:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAutomaticReloadPaymentRequest_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAutomaticReloadPaymentRequest_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual PKDeferredPaymentRequest? DeferredPaymentRequest {
			[Export ("deferredPaymentRequest", ArgumentSemantic.Retain)]
			get {
				PKDeferredPaymentRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PKDeferredPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeferredPaymentRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PKDeferredPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeferredPaymentRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDeferredPaymentRequest:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDeferredPaymentRequest_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDeferredPaymentRequest_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual PKPaymentTokenContext[]? MultiTokenContexts {
			[Export ("multiTokenContexts", ArgumentSemantic.Copy)]
			get {
				PKPaymentTokenContext[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PKPaymentTokenContext>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMultiTokenContextsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PKPaymentTokenContext>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMultiTokenContextsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMultiTokenContexts:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMultiTokenContexts_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMultiTokenContexts_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPaymentSummaryItem[] PaymentSummaryItems {
			[Export ("paymentSummaryItems", ArgumentSemantic.Copy)]
			get {
				PKPaymentSummaryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PKPaymentSummaryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPaymentSummaryItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PKPaymentSummaryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPaymentSummaryItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPaymentSummaryItems:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPaymentSummaryItems_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPaymentSummaryItems_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual PKRecurringPaymentRequest? RecurringPaymentRequest {
			[Export ("recurringPaymentRequest", ArgumentSemantic.Retain)]
			get {
				PKRecurringPaymentRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PKRecurringPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecurringPaymentRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PKRecurringPaymentRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecurringPaymentRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRecurringPaymentRequest:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRecurringPaymentRequest_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRecurringPaymentRequest_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual PKShippingMethod[] ShippingMethods {
			[Export ("shippingMethods", ArgumentSemantic.Copy)]
			get {
				PKShippingMethod[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PKShippingMethod>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShippingMethodsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PKShippingMethod>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShippingMethodsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setShippingMethods:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetShippingMethods_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetShippingMethods_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPaymentAuthorizationStatus Status {
			[Export ("status", ArgumentSemantic.Assign)]
			get {
				PKPaymentAuthorizationStatus ret;
				if (IsDirectBinding) {
					ret = (PassKit.PKPaymentAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PassKit.PKPaymentAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStatus:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatus_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetStatus_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class PKPaymentRequestUpdate */
}
