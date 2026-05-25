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
	#pragma warning disable CS1573
	/// <summary>Delegate object providing events relating to a payment authorization request made with a <see cref="T:PassKit.PKPaymentAuthorizationViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKPaymentAuthorizationViewControllerDelegate_Ref/index.html">Apple documentation for <c>PKPaymentAuthorizationViewControllerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PKPaymentAuthorizationViewControllerDelegate", WrapperType = typeof (PKPaymentAuthorizationViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAuthorizePayment", Selector = "paymentAuthorizationViewController:didAuthorizePayment:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V217) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAuthorizePayment2", Selector = "paymentAuthorizationViewController:didAuthorizePayment:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V218) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewControllerDidFinish", Selector = "paymentAuthorizationViewControllerDidFinish:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingMethod", Selector = "paymentAuthorizationViewController:didSelectShippingMethod:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKShippingMethod), typeof (PassKit.PKPaymentShippingMethodSelected) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingMethodSelected) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingMethod2", Selector = "paymentAuthorizationViewController:didSelectShippingMethod:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V224) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAuthorizePayment", Selector = "paymentAuthorizationViewControllerWillAuthorizePayment:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingContact", Selector = "paymentAuthorizationViewController:didSelectShippingContact:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKContact), typeof (PassKit.PKPaymentShippingAddressSelected) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingAddressSelected) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingContact2", Selector = "paymentAuthorizationViewController:didSelectShippingContact:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V220) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPaymentMethod", Selector = "paymentAuthorizationViewController:didSelectPaymentMethod:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentSummaryItem[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V221) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPaymentMethod2", Selector = "paymentAuthorizationViewController:didSelectPaymentMethod:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V219) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMerchantSessionUpdate", Selector = "paymentAuthorizationViewController:didRequestMerchantSessionUpdate:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (global::System.Action<global::PassKit.PKPaymentRequestMerchantSessionUpdate>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V222) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCouponCode", Selector = "paymentAuthorizationViewController:didChangeCouponCode:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationViewController), typeof (string), typeof (global::System.Action<global::PassKit.PKPaymentRequestCouponCodeUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V223) })]
	public partial interface IPKPaymentAuthorizationViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment2' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			_DidAuthorizePayment (this, controller, payment, completion);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment2' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidAuthorizePayment (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V217.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:completion:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment2 (PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V218))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			_DidAuthorizePayment2 (this, controller, payment, completion);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidAuthorizePayment2 (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V218))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V218.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:handler:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><summary>Indicates the payment authorization has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates the payment authorization has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PaymentAuthorizationViewControllerDidFinish (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>Indicates the user selected a shippingmethod.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingMethodSelected))]PKPaymentShippingMethodSelected completion)
		{
			_DidSelectShippingMethod (this, controller, shippingMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>Indicates the user selected a shippingmethod.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingMethod (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingMethodSelected))]PKPaymentShippingMethodSelected completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKPaymentShippingMethodSelected.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:completion:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod2 (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V224))]global::System.Action<PKPaymentRequestShippingMethodUpdate> completion)
		{
			_DidSelectShippingMethod2 (this, controller, shippingMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingMethod2 (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V224))]global::System.Action<PKPaymentRequestShippingMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V224.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:handler:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that payment authorization will shortly begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewControllerWillAuthorizePayment:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAuthorizePayment (PKPaymentAuthorizationViewController controller)
		{
			_WillAuthorizePayment (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that payment authorization will shortly begin.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAuthorizePayment (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerWillAuthorizePayment:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a shipping contact.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingAddressSelected))]PKPaymentShippingAddressSelected completion)
		{
			_DidSelectShippingContact (this, controller, contact, completion);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a shipping contact.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingContact (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingAddressSelected))]PKPaymentShippingAddressSelected completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKPaymentShippingAddressSelected.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:completion:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact2 (PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V220))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			_DidSelectShippingContact2 (this, controller, contact, completion);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingContact2 (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V220))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V220.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:handler:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a payment method.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V221))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			_DidSelectPaymentMethod (this, controller, paymentMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a payment method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectPaymentMethod (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V221))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V221.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod2 (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V219))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			_DidSelectPaymentMethod2 (this, controller, paymentMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectPaymentMethod2 (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V219))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V219.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V222))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> updateHandler)
		{
			_DidRequestMerchantSessionUpdate (this, controller, updateHandler);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidRequestMerchantSessionUpdate (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V222))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> updateHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (updateHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updateHandler));
			using var block_updateHandler = Trampolines.SDActionArity1V222.CreateBlock (updateHandler);
			BlockLiteral *block_ptr_updateHandler = &block_updateHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:"), controller__handle__, (IntPtr) block_ptr_updateHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationViewController:didChangeCouponCode:handler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidChangeCouponCode (PKPaymentAuthorizationViewController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V223))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			_DidChangeCouponCode (this, controller, couponCode, completion);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidChangeCouponCode (IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V223))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (couponCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (couponCode));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscouponCode = CFString.CreateNative (couponCode);
			using var block_completion = Trampolines.SDActionArity1V223.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didChangeCouponCode:handler:"), controller__handle__, nscouponCode, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nscouponCode);
		}
		[DynamicDependencyAttribute ("DidAuthorizePayment(PassKit.PKPaymentAuthorizationViewController,PassKit.PKPayment,System.Action{PassKit.PKPaymentAuthorizationStatus})")]
		[DynamicDependencyAttribute ("DidAuthorizePayment2(PassKit.PKPaymentAuthorizationViewController,PassKit.PKPayment,System.Action{PassKit.PKPaymentAuthorizationResult})")]
		[DynamicDependencyAttribute ("DidChangeCouponCode(PassKit.PKPaymentAuthorizationViewController,System.String,System.Action{PassKit.PKPaymentRequestCouponCodeUpdate})")]
		[DynamicDependencyAttribute ("DidRequestMerchantSessionUpdate(PassKit.PKPaymentAuthorizationViewController,System.Action{PassKit.PKPaymentRequestMerchantSessionUpdate})")]
		[DynamicDependencyAttribute ("DidSelectPaymentMethod(PassKit.PKPaymentAuthorizationViewController,PassKit.PKPaymentMethod,System.Action{PassKit.PKPaymentSummaryItem[]})")]
		[DynamicDependencyAttribute ("DidSelectPaymentMethod2(PassKit.PKPaymentAuthorizationViewController,PassKit.PKPaymentMethod,System.Action{PassKit.PKPaymentRequestPaymentMethodUpdate})")]
		[DynamicDependencyAttribute ("DidSelectShippingContact(PassKit.PKPaymentAuthorizationViewController,PassKit.PKContact,PassKit.PKPaymentShippingAddressSelected)")]
		[DynamicDependencyAttribute ("DidSelectShippingContact2(PassKit.PKPaymentAuthorizationViewController,PassKit.PKContact,System.Action{PassKit.PKPaymentRequestShippingContactUpdate})")]
		[DynamicDependencyAttribute ("DidSelectShippingMethod(PassKit.PKPaymentAuthorizationViewController,PassKit.PKShippingMethod,PassKit.PKPaymentShippingMethodSelected)")]
		[DynamicDependencyAttribute ("DidSelectShippingMethod2(PassKit.PKPaymentAuthorizationViewController,PassKit.PKShippingMethod,System.Action{PassKit.PKPaymentRequestShippingMethodUpdate})")]
		[DynamicDependencyAttribute ("PaymentAuthorizationViewControllerDidFinish(PassKit.PKPaymentAuthorizationViewController)")]
		[DynamicDependencyAttribute ("WillAuthorizePayment(PassKit.PKPaymentAuthorizationViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentAuthorizationViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKPaymentAuthorizationViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKPaymentAuthorizationViewControllerDelegate" /> interface to support all the methods from the PKPaymentAuthorizationViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKPaymentAuthorizationViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKPaymentAuthorizationViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKPaymentAuthorizationViewControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment2' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidAuthorizePayment (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V217.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:completion:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidAuthorizePayment2 (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V218))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V218.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:handler:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>Indicates the user selected a shippingmethod.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingMethod (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingMethodSelected))]PKPaymentShippingMethodSelected completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKPaymentShippingMethodSelected.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:completion:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingMethod2 (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V224))]global::System.Action<PKPaymentRequestShippingMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V224.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:handler:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that payment authorization will shortly begin.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAuthorizePayment (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerWillAuthorizePayment:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a shipping contact.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingContact (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingAddressSelected))]PKPaymentShippingAddressSelected completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKPaymentShippingAddressSelected.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:completion:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingContact2 (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V220))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V220.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:handler:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a payment method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectPaymentMethod (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V221))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V221.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectPaymentMethod2 (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V219))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V219.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidRequestMerchantSessionUpdate (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V222))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> updateHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (updateHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updateHandler));
			using var block_updateHandler = Trampolines.SDActionArity1V222.CreateBlock (updateHandler);
			BlockLiteral *block_ptr_updateHandler = &block_updateHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:"), controller__handle__, (IntPtr) block_ptr_updateHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidChangeCouponCode (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V223))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (couponCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (couponCode));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscouponCode = CFString.CreateNative (couponCode);
			using var block_completion = Trampolines.SDActionArity1V223.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didChangeCouponCode:handler:"), controller__handle__, nscouponCode, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nscouponCode);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKPaymentAuthorizationViewControllerDelegateWrapper : BaseWrapper, IPKPaymentAuthorizationViewControllerDelegate {
		public PKPaymentAuthorizationViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentAuthorizationViewControllerDelegateWrapper))]
		static PKPaymentAuthorizationViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="controller">To be added.</param><summary>Indicates the payment authorization has completed.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (controller);
		}
	}
}
namespace PassKit {
	/// <summary>Delegate object providing events relating to a payment authorization request made with a <see cref="T:PassKit.PKPaymentAuthorizationViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKPaymentAuthorizationViewControllerDelegate_Ref/index.html">Apple documentation for <c>PKPaymentAuthorizationViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__PassKit_PKPaymentAuthorizationViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class PKPaymentAuthorizationViewControllerDelegate : NSObject, IPKPaymentAuthorizationViewControllerDelegate {
		/// <summary>Creates a new <see cref="PKPaymentAuthorizationViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKPaymentAuthorizationViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected PKPaymentAuthorizationViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal PKPaymentAuthorizationViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment2' instead.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment2 (PKPaymentAuthorizationViewController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V218))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("paymentAuthorizationViewController:didChangeCouponCode:handler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidChangeCouponCode (PKPaymentAuthorizationViewController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V223))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V222))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> updateHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a payment method.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V221))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod2 (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V219))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>Called after the user has selected a shipping contact.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingAddressSelected))]PKPaymentShippingAddressSelected completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact2 (PKPaymentAuthorizationViewController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V220))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>Indicates the user selected a shippingmethod.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod2' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPaymentShippingMethodSelected))]PKPaymentShippingMethodSelected completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="shippingMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod2 (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V224))]global::System.Action<PKPaymentRequestShippingMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates the payment authorization has completed.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that payment authorization will shortly begin.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationViewControllerWillAuthorizePayment:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAuthorizePayment (PKPaymentAuthorizationViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKPaymentAuthorizationViewControllerDelegate */
}
