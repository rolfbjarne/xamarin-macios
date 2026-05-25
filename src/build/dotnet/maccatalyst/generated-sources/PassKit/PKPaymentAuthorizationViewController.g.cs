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
namespace PassKit {
	/// <summary>Standard view controller that prompts the user to authorize a payment.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKPaymentAuthorizationViewController_Ref/index.html">Apple documentation for <c>PKPaymentAuthorizationViewController</c></related>
	[Register("PKPaymentAuthorizationViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PKPaymentAuthorizationViewController : global::UIKit.UIViewController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PKPaymentAuthorizationViewController");
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
		public PKPaymentAuthorizationViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected PKPaymentAuthorizationViewController (NSObjectFlag t) : base (t)
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
		protected internal PKPaymentAuthorizationViewController (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="request">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPaymentRequest:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKPaymentAuthorizationViewController (PKPaymentRequest request)
			: base (NSObjectFlag.Empty)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithPaymentRequest:"), request__handle__), "initWithPaymentRequest:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithPaymentRequest:"), request__handle__), "initWithPaymentRequest:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[Export ("initWithDisbursementRequest:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKPaymentAuthorizationViewController (PKDisbursementRequest request)
			: base (NSObjectFlag.Empty)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDisbursementRequest:"), request__handle__), "initWithDisbursementRequest:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDisbursementRequest:"), request__handle__), "initWithDisbursementRequest:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		/// <param name="paymentNetworks">To be added.</param><summary>Whether the user can make payments in at least one of the specified <paramref name="paymentNetworks" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canMakePaymentsUsingNetworks:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePaymentsUsingNetworks (NSString[] paymentNetworks)
		{
			if (paymentNetworks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paymentNetworks));
			using var nsa_paymentNetworks = NSArray.FromNSObjects (paymentNetworks);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("canMakePaymentsUsingNetworks:"), nsa_paymentNetworks.Handle);
			return ret != 0;
		}
		/// <param name="supportedNetworks">To be added.</param><param name="capabilties">To be added.</param><summary>Whether the user can make payments in at least one of the specified networks with the specified capabilities.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canMakePaymentsUsingNetworks:capabilities:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePaymentsUsingNetworks (string[] supportedNetworks, PKMerchantCapability capabilties)
		{
			if (supportedNetworks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportedNetworks));
			using var nsa_supportedNetworks = NSArray.FromStrings (supportedNetworks);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (class_ptr, Selector.GetHandle ("canMakePaymentsUsingNetworks:capabilities:"), nsa_supportedNetworks.Handle, (UIntPtr) (ulong) capabilties);
			return ret != 0;
		}
		[Export ("supportsDisbursements")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsDisbursements ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("supportsDisbursements"));
			return ret != 0;
		}
		[Export ("supportsDisbursementsUsingNetworks:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsDisbursements (string[] supportedNetworks)
		{
			if (supportedNetworks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportedNetworks));
			using var nsa_supportedNetworks = NSArray.FromStrings (supportedNetworks);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("supportsDisbursementsUsingNetworks:"), nsa_supportedNetworks.Handle);
			return ret != 0;
		}
		[Export ("supportsDisbursementsUsingNetworks:capabilities:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsDisbursements (string[] supportedNetworks, PKMerchantCapability capabilities)
		{
			if (supportedNetworks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportedNetworks));
			using var nsa_supportedNetworks = NSArray.FromStrings (supportedNetworks);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (class_ptr, Selector.GetHandle ("supportsDisbursementsUsingNetworks:capabilities:"), nsa_supportedNetworks.Handle, (UIntPtr) (ulong) capabilities);
			return ret != 0;
		}
		/// <summary>Whether the user can make payments.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePayments {
			[Export ("canMakePayments")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("canMakePayments"));
				return ret != 0;
			}
		}
		/// <summary>An instance of the PassKit.IPKPaymentAuthorizationViewControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the PassKit.IPKPaymentAuthorizationViewControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IPKPaymentAuthorizationViewControllerDelegate Delegate {
			get {
				return (WeakDelegate as IPKPaymentAuthorizationViewControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
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
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_PKPaymentAuthorizationViewControllerDelegate); }
		}
		internal virtual _PKPaymentAuthorizationViewControllerDelegate CreateInternalEventDelegateType ()
		{
			return (_PKPaymentAuthorizationViewControllerDelegate)(new _PKPaymentAuthorizationViewControllerDelegate());
		}
		internal _PKPaymentAuthorizationViewControllerDelegate EnsurePKPaymentAuthorizationViewControllerDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _PKPaymentAuthorizationViewControllerDelegate;
			if (del is null){
				del = (_PKPaymentAuthorizationViewControllerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IPKPaymentAuthorizationViewControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _PKPaymentAuthorizationViewControllerDelegate : NSObject, IPKPaymentAuthorizationViewControllerDelegate { 
			public _PKPaymentAuthorizationViewControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_PKPaymentAuthorizationViewControllerDelegate))]
			static _PKPaymentAuthorizationViewControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<PKPaymentAuthorizationEventArgs>? didAuthorizePayment;
			[Export ("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
			public void DidAuthorizePayment (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPayment payment, global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
			{
				var handler = didAuthorizePayment;
				if (handler is not null){
					var args = new PKPaymentAuthorizationEventArgs (payment, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentAuthorizationResultEventArgs>? didAuthorizePayment2;
			[Export ("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
			public void DidAuthorizePayment2 (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPayment payment, global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
			{
				var handler = didAuthorizePayment2;
				if (handler is not null){
					var args = new PKPaymentAuthorizationResultEventArgs (payment, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentRequestCouponCodeUpdateEventArgs>? didChangeCouponCode;
			[Export ("paymentAuthorizationViewController:didChangeCouponCode:handler:")]
			public void DidChangeCouponCode (PassKit.PKPaymentAuthorizationViewController controller, string couponCode, global::System.Action<global::PassKit.PKPaymentRequestCouponCodeUpdate> completion)
			{
				var handler = didChangeCouponCode;
				if (handler is not null){
					var args = new PKPaymentRequestCouponCodeUpdateEventArgs (couponCode, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentRequestMerchantSessionUpdateEventArgs>? didRequestMerchantSessionUpdate;
			[Export ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:")]
			public void DidRequestMerchantSessionUpdate (PassKit.PKPaymentAuthorizationViewController controller, global::System.Action<global::PassKit.PKPaymentRequestMerchantSessionUpdate> updateHandler)
			{
				var handler = didRequestMerchantSessionUpdate;
				if (handler is not null){
					var args = new PKPaymentRequestMerchantSessionUpdateEventArgs (updateHandler);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentMethodSelectedEventArgs>? didSelectPaymentMethod;
			[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
			public void DidSelectPaymentMethod (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPaymentMethod paymentMethod, global::System.Action<global::PassKit.PKPaymentSummaryItem[]> completion)
			{
				var handler = didSelectPaymentMethod;
				if (handler is not null){
					var args = new PKPaymentMethodSelectedEventArgs (paymentMethod, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentRequestPaymentMethodUpdateEventArgs>? didSelectPaymentMethod2;
			[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
			public void DidSelectPaymentMethod2 (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPaymentMethod paymentMethod, global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
			{
				var handler = didSelectPaymentMethod2;
				if (handler is not null){
					var args = new PKPaymentRequestPaymentMethodUpdateEventArgs (paymentMethod, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentSelectedContactEventArgs>? didSelectShippingContact;
			[Export ("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
			public void DidSelectShippingContact (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKContact contact, PassKit.PKPaymentShippingAddressSelected completion)
			{
				var handler = didSelectShippingContact;
				if (handler is not null){
					var args = new PKPaymentSelectedContactEventArgs (contact, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentRequestShippingContactUpdateEventArgs>? didSelectShippingContact2;
			[Export ("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
			public void DidSelectShippingContact2 (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKContact contact, global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
			{
				var handler = didSelectShippingContact2;
				if (handler is not null){
					var args = new PKPaymentRequestShippingContactUpdateEventArgs (contact, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentShippingMethodSelectedEventArgs>? didSelectShippingMethod;
			[Export ("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
			public void DidSelectShippingMethod (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKShippingMethod shippingMethod, PassKit.PKPaymentShippingMethodSelected completion)
			{
				var handler = didSelectShippingMethod;
				if (handler is not null){
					var args = new PKPaymentShippingMethodSelectedEventArgs (shippingMethod, completion);
					handler (controller, args);
				}
			}
			internal EventHandler<PKPaymentRequestShippingMethodUpdateEventArgs>? didSelectShippingMethod2;
			[Export ("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
			public void DidSelectShippingMethod2 (PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKShippingMethod shippingMethod, global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
			{
				var handler = didSelectShippingMethod2;
				if (handler is not null){
					var args = new PKPaymentRequestShippingMethodUpdateEventArgs (shippingMethod, completion);
					handler (controller, args);
				}
			}
			internal EventHandler? paymentAuthorizationViewControllerDidFinish;
			[Export ("paymentAuthorizationViewControllerDidFinish:")]
			public void PaymentAuthorizationViewControllerDidFinish (PassKit.PKPaymentAuthorizationViewController controller)
			{
				var handler = paymentAuthorizationViewControllerDidFinish;
				if (handler is not null){
					handler (controller, EventArgs.Empty);
				}
			}
			internal EventHandler? willAuthorizePayment;
			[Export ("paymentAuthorizationViewControllerWillAuthorizePayment:")]
			public void WillAuthorizePayment (PassKit.PKPaymentAuthorizationViewController controller)
			{
				var handler = willAuthorizePayment;
				if (handler is not null){
					handler (controller, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentAuthorizationEventArgs> DidAuthorizePayment {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didAuthorizePayment += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didAuthorizePayment -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentAuthorizationResultEventArgs> DidAuthorizePayment2 {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didAuthorizePayment2 += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didAuthorizePayment2 -= value; }
		}
		public event EventHandler<PKPaymentRequestCouponCodeUpdateEventArgs> DidChangeCouponCode {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didChangeCouponCode += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didChangeCouponCode -= value; }
		}
		public event EventHandler<PKPaymentRequestMerchantSessionUpdateEventArgs> DidRequestMerchantSessionUpdate {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didRequestMerchantSessionUpdate += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didRequestMerchantSessionUpdate -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentMethodSelectedEventArgs> DidSelectPaymentMethod {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectPaymentMethod += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectPaymentMethod -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentRequestPaymentMethodUpdateEventArgs> DidSelectPaymentMethod2 {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectPaymentMethod2 += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectPaymentMethod2 -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentSelectedContactEventArgs> DidSelectShippingContact {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingContact += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingContact -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentRequestShippingContactUpdateEventArgs> DidSelectShippingContact2 {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingContact2 += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingContact2 -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentShippingMethodSelectedEventArgs> DidSelectShippingMethod {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingMethod += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingMethod -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PKPaymentRequestShippingMethodUpdateEventArgs> DidSelectShippingMethod2 {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingMethod2 += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.didSelectShippingMethod2 -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler PaymentAuthorizationViewControllerDidFinish {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.paymentAuthorizationViewControllerDidFinish += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.paymentAuthorizationViewControllerDidFinish -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillAuthorizePayment {
			add { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.willAuthorizePayment += value; }
			remove { EnsurePKPaymentAuthorizationViewControllerDelegate ()!.willAuthorizePayment -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PKPaymentAuthorizationViewController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentAuthorizationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentAuthorizationEventArgs" /> with the specified event data.</summary>
		/// <param name="payment">The value for the <see cref="Payment" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentAuthorizationEventArgs (PassKit.PKPayment payment, global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
		{
			this.Completion = completion;
			this.Payment = payment;
		}
		public global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> Completion { get; set; }
		public PassKit.PKPayment Payment { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentAuthorizationResultEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentAuthorizationResultEventArgs" /> with the specified event data.</summary>
		/// <param name="payment">The value for the <see cref="Payment" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentAuthorizationResultEventArgs (PassKit.PKPayment payment, global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
		{
			this.Completion = completion;
			this.Payment = payment;
		}
		public global::System.Action<global::PassKit.PKPaymentAuthorizationResult> Completion { get; set; }
		public PassKit.PKPayment Payment { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentMethodSelectedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentMethodSelectedEventArgs" /> with the specified event data.</summary>
		/// <param name="paymentMethod">The value for the <see cref="PaymentMethod" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentMethodSelectedEventArgs (PassKit.PKPaymentMethod paymentMethod, global::System.Action<global::PassKit.PKPaymentSummaryItem[]> completion)
		{
			this.Completion = completion;
			this.PaymentMethod = paymentMethod;
		}
		public global::System.Action<global::PassKit.PKPaymentSummaryItem[]> Completion { get; set; }
		public PassKit.PKPaymentMethod PaymentMethod { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentRequestCouponCodeUpdateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentRequestCouponCodeUpdateEventArgs" /> with the specified event data.</summary>
		/// <param name="couponCode">The value for the <see cref="CouponCode" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentRequestCouponCodeUpdateEventArgs (string couponCode, global::System.Action<global::PassKit.PKPaymentRequestCouponCodeUpdate> completion)
		{
			this.Completion = completion;
			this.CouponCode = couponCode;
		}
		public global::System.Action<global::PassKit.PKPaymentRequestCouponCodeUpdate> Completion { get; set; }
		public string CouponCode { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentRequestMerchantSessionUpdateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentRequestMerchantSessionUpdateEventArgs" /> with the specified event data.</summary>
		/// <param name="updateHandler">The value for the <see cref="UpdateHandler" /> property.</param>
		public PKPaymentRequestMerchantSessionUpdateEventArgs (global::System.Action<global::PassKit.PKPaymentRequestMerchantSessionUpdate> updateHandler)
		{
			this.UpdateHandler = updateHandler;
		}
		public global::System.Action<global::PassKit.PKPaymentRequestMerchantSessionUpdate> UpdateHandler { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentRequestPaymentMethodUpdateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentRequestPaymentMethodUpdateEventArgs" /> with the specified event data.</summary>
		/// <param name="paymentMethod">The value for the <see cref="PaymentMethod" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentRequestPaymentMethodUpdateEventArgs (PassKit.PKPaymentMethod paymentMethod, global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
		{
			this.Completion = completion;
			this.PaymentMethod = paymentMethod;
		}
		public global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> Completion { get; set; }
		public PassKit.PKPaymentMethod PaymentMethod { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentRequestShippingContactUpdateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentRequestShippingContactUpdateEventArgs" /> with the specified event data.</summary>
		/// <param name="contact">The value for the <see cref="Contact" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentRequestShippingContactUpdateEventArgs (PassKit.PKContact contact, global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
		{
			this.Completion = completion;
			this.Contact = contact;
		}
		public global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> Completion { get; set; }
		public PassKit.PKContact Contact { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentRequestShippingMethodUpdateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentRequestShippingMethodUpdateEventArgs" /> with the specified event data.</summary>
		/// <param name="shippingMethod">The value for the <see cref="ShippingMethod" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentRequestShippingMethodUpdateEventArgs (PassKit.PKShippingMethod shippingMethod, global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
		{
			this.Completion = completion;
			this.ShippingMethod = shippingMethod;
		}
		public global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> Completion { get; set; }
		public PassKit.PKShippingMethod ShippingMethod { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentSelectedContactEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentSelectedContactEventArgs" /> with the specified event data.</summary>
		/// <param name="contact">The value for the <see cref="Contact" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentSelectedContactEventArgs (PassKit.PKContact contact, PassKit.PKPaymentShippingAddressSelected completion)
		{
			this.Completion = completion;
			this.Contact = contact;
		}
		public PassKit.PKPaymentShippingAddressSelected Completion { get; set; }
		public PassKit.PKContact Contact { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PKPaymentShippingMethodSelectedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PKPaymentShippingMethodSelectedEventArgs" /> with the specified event data.</summary>
		/// <param name="shippingMethod">The value for the <see cref="ShippingMethod" /> property.</param>
		/// <param name="completion">The value for the <see cref="Completion" /> property.</param>
		public PKPaymentShippingMethodSelectedEventArgs (PassKit.PKShippingMethod shippingMethod, PassKit.PKPaymentShippingMethodSelected completion)
		{
			this.Completion = completion;
			this.ShippingMethod = shippingMethod;
		}
		public PassKit.PKPaymentShippingMethodSelected Completion { get; set; }
		public PassKit.PKShippingMethod ShippingMethod { get; set; }
	}
}
