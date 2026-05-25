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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object that responds to user interactions on behalf of a <see cref="T:PassKit.PKPaymentAuthorizationController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/PassKit/PKPaymentAuthorizationControllerDelegate">Apple documentation for <c>PKPaymentAuthorizationControllerDelegate</c></related>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "PKPaymentAuthorizationControllerDelegate", WrapperType = typeof (PKPaymentAuthorizationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAuthorizePayment", Selector = "paymentAuthorizationController:didAuthorizePayment:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V235) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAuthorizePayment", Selector = "paymentAuthorizationController:didAuthorizePayment:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V236) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "paymentAuthorizationControllerDidFinish:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAuthorizePayment", Selector = "paymentAuthorizationControllerWillAuthorizePayment:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingMethod", Selector = "paymentAuthorizationController:didSelectShippingMethod:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, global::PassKit.PKPaymentSummaryItem[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V145) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingMethod", Selector = "paymentAuthorizationController:didSelectShippingMethod:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V237) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingContact", Selector = "paymentAuthorizationController:didSelectShippingContact:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, global::PassKit.PKShippingMethod[], global::PassKit.PKPaymentSummaryItem[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V19) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectShippingContact", Selector = "paymentAuthorizationController:didSelectShippingContact:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V238) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPaymentMethod", Selector = "paymentAuthorizationController:didSelectPaymentMethod:completion:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentSummaryItem[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V239) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPaymentMethod", Selector = "paymentAuthorizationController:didSelectPaymentMethod:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V237) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMerchantSessionUpdate", Selector = "paymentAuthorizationController:didRequestMerchantSessionUpdate:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (global::System.Action<global::PassKit.PKPaymentRequestMerchantSessionUpdate>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V240) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCouponCode", Selector = "paymentAuthorizationController:didChangeCouponCode:handler:", ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController), typeof (string), typeof (global::System.Action<global::PassKit.PKPaymentRequestCouponCodeUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V241) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPresentationWindow", Selector = "presentationWindowForPaymentAuthorizationController:", ReturnType = typeof (UIWindow), ParameterType = new Type [] { typeof (PassKit.PKPaymentAuthorizationController) }, ParameterByRef = new bool [] { false })]
	public partial interface IPKPaymentAuthorizationControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment' overload with the 'Action&lt;PKPaymentAuthorizationResult&gt;' parameter instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didAuthorizePayment:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V235))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			_DidAuthorizePayment (this, controller, payment, completion);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment' overload with the 'Action&lt;PKPaymentAuthorizationResult&gt;' parameter instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidAuthorizePayment (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V235))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V235.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:completion:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V236))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			_DidAuthorizePayment (this, controller, payment, completion);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidAuthorizePayment (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V236))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V236.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:handler:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">The <see cref="T:PassKit.PKPaymentAuthorizationController" /> for which the payment authorization has finished.</param><summary>Method that is called when payment authorization has finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (PKPaymentAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The <see cref="T:PassKit.PKPaymentAuthorizationController" /> for which the payment authorization has finished.</param><summary>Method that is called when payment authorization has finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that owns this delegate.</param><summary>Method that is called when the user is authorizing a payment request.</summary><remarks>This method is called after the user authenticates, but before the request is authorized.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationControllerWillAuthorizePayment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAuthorizePayment (PKPaymentAuthorizationController controller)
		{
			_WillAuthorizePayment (this, controller);
		}
		/// <param name="controller">The controller that owns this delegate.</param><summary>Method that is called when the user is authorizing a payment request.</summary><remarks>This method is called after the user authenticates, but before the request is authorized.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAuthorizePayment (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationControllerWillAuthorizePayment:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="shippingMethod">The new shipping method.</param><param name="completion">A handler that takes the authorization status for the payment and a list of updated payment summary items.</param><summary>Method that is called when a user selects a new shipping method.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectShippingMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V145))]global::System.Action<PKPaymentAuthorizationStatus, PKPaymentSummaryItem[]> completion)
		{
			_DidSelectShippingMethod (this, controller, shippingMethod, completion);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="shippingMethod">The new shipping method.</param><param name="completion">A handler that takes the authorization status for the payment and a list of updated payment summary items.</param><summary>Method that is called when a user selects a new shipping method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingMethod (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V145))]global::System.Action<PKPaymentAuthorizationStatus, PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V145.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:completion:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			_DidSelectShippingMethod (this, controller, paymentMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingMethod (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V237.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="contact">The new shipping address.</param><param name="completion">A handler that takes the payment authorization status, a list of updated shipping method objects, and a list of updated payment summary items.</param><summary>Method that is called when a user selects a contact to ship to.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectShippingContact:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V19))]global::System.Action<PKPaymentAuthorizationStatus, PKShippingMethod[], PKPaymentSummaryItem[]> completion)
		{
			_DidSelectShippingContact (this, controller, contact, completion);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="contact">The new shipping address.</param><param name="completion">A handler that takes the payment authorization status, a list of updated shipping method objects, and a list of updated payment summary items.</param><summary>Method that is called when a user selects a contact to ship to.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingContact (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V19))]global::System.Action<PKPaymentAuthorizationStatus, PKShippingMethod[], PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity3V19.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:completion:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V238))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			_DidSelectShippingContact (this, controller, contact, completion);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectShippingContact (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V238))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V238.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:handler:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="paymentMethod">The payment method that was selected.</param><param name="completion">A handler that takes a list of updated payment summary items.</param><summary>Method that is called when the user selects a payment method.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V239))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			_DidSelectPaymentMethod (this, controller, paymentMethod, completion);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="paymentMethod">The payment method that was selected.</param><param name="completion">A handler that takes a list of updated payment summary items.</param><summary>Method that is called when the user selects a payment method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectPaymentMethod (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V239))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V239.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:completion:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			_DidSelectPaymentMethod (this, controller, paymentMethod, completion);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectPaymentMethod (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V237.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didRequestMerchantSessionUpdate:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V240))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> handler)
		{
			_DidRequestMerchantSessionUpdate (this, controller, handler);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidRequestMerchantSessionUpdate (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V240))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> handler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V240.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didRequestMerchantSessionUpdate:"), controller__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentAuthorizationController:didChangeCouponCode:handler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidChangeCouponCode (PKPaymentAuthorizationController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V241))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			_DidChangeCouponCode (this, controller, couponCode, completion);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidChangeCouponCode (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V241))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (couponCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (couponCode));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscouponCode = CFString.CreateNative (couponCode);
			using var block_completion = Trampolines.SDActionArity1V241.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didChangeCouponCode:handler:"), controller__handle__, nscouponCode, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nscouponCode);
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationWindowForPaymentAuthorizationController:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIWindow? GetPresentationWindow (PKPaymentAuthorizationController controller)
		{
			return _GetPresentationWindow (this, controller);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIWindow? _GetPresentationWindow (IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationWindowForPaymentAuthorizationController:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidAuthorizePayment(PassKit.PKPaymentAuthorizationController,PassKit.PKPayment,System.Action{PassKit.PKPaymentAuthorizationResult})")]
		[DynamicDependencyAttribute ("DidAuthorizePayment(PassKit.PKPaymentAuthorizationController,PassKit.PKPayment,System.Action{PassKit.PKPaymentAuthorizationStatus})")]
		[DynamicDependencyAttribute ("DidChangeCouponCode(PassKit.PKPaymentAuthorizationController,System.String,System.Action{PassKit.PKPaymentRequestCouponCodeUpdate})")]
		[DynamicDependencyAttribute ("DidFinish(PassKit.PKPaymentAuthorizationController)")]
		[DynamicDependencyAttribute ("DidRequestMerchantSessionUpdate(PassKit.PKPaymentAuthorizationController,System.Action{PassKit.PKPaymentRequestMerchantSessionUpdate})")]
		[DynamicDependencyAttribute ("DidSelectPaymentMethod(PassKit.PKPaymentAuthorizationController,PassKit.PKPaymentMethod,System.Action{PassKit.PKPaymentRequestPaymentMethodUpdate})")]
		[DynamicDependencyAttribute ("DidSelectPaymentMethod(PassKit.PKPaymentAuthorizationController,PassKit.PKPaymentMethod,System.Action{PassKit.PKPaymentSummaryItem[]})")]
		[DynamicDependencyAttribute ("DidSelectShippingContact(PassKit.PKPaymentAuthorizationController,PassKit.PKContact,System.Action{PassKit.PKPaymentAuthorizationStatus,PassKit.PKShippingMethod[],PassKit.PKPaymentSummaryItem[]})")]
		[DynamicDependencyAttribute ("DidSelectShippingContact(PassKit.PKPaymentAuthorizationController,PassKit.PKContact,System.Action{PassKit.PKPaymentRequestShippingContactUpdate})")]
		[DynamicDependencyAttribute ("DidSelectShippingMethod(PassKit.PKPaymentAuthorizationController,PassKit.PKPaymentMethod,System.Action{PassKit.PKPaymentRequestPaymentMethodUpdate})")]
		[DynamicDependencyAttribute ("DidSelectShippingMethod(PassKit.PKPaymentAuthorizationController,PassKit.PKShippingMethod,System.Action{PassKit.PKPaymentAuthorizationStatus,PassKit.PKPaymentSummaryItem[]})")]
		[DynamicDependencyAttribute ("GetPresentationWindow(PassKit.PKPaymentAuthorizationController)")]
		[DynamicDependencyAttribute ("WillAuthorizePayment(PassKit.PKPaymentAuthorizationController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentAuthorizationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKPaymentAuthorizationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKPaymentAuthorizationControllerDelegate" /> interface to support all the methods from the PKPaymentAuthorizationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKPaymentAuthorizationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKPaymentAuthorizationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKPaymentAuthorizationControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment' overload with the 'Action&lt;PKPaymentAuthorizationResult&gt;' parameter instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidAuthorizePayment (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V235))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V235.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:completion:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidAuthorizePayment (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V236))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V236.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:handler:"), controller__handle__, payment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (payment);
		}
		/// <param name="controller">The controller that owns this delegate.</param><summary>Method that is called when the user is authorizing a payment request.</summary><remarks>This method is called after the user authenticates, but before the request is authorized.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAuthorizePayment (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationControllerWillAuthorizePayment:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="shippingMethod">The new shipping method.</param><param name="completion">A handler that takes the authorization status for the payment and a list of updated payment summary items.</param><summary>Method that is called when a user selects a new shipping method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingMethod (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V145))]global::System.Action<PKPaymentAuthorizationStatus, PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var shippingMethod__handle__ = shippingMethod!.GetNonNullHandle (nameof (shippingMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V145.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:completion:"), controller__handle__, shippingMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (shippingMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingMethod (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V237.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="contact">The new shipping address.</param><param name="completion">A handler that takes the payment authorization status, a list of updated shipping method objects, and a list of updated payment summary items.</param><summary>Method that is called when a user selects a contact to ship to.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingContact (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V19))]global::System.Action<PKPaymentAuthorizationStatus, PKShippingMethod[], PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity3V19.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:completion:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectShippingContact (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V238))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V238.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:handler:"), controller__handle__, contact__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (contact);
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="paymentMethod">The payment method that was selected.</param><param name="completion">A handler that takes a list of updated payment summary items.</param><summary>Method that is called when the user selects a payment method.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectPaymentMethod (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V239))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V239.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:completion:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidSelectPaymentMethod (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var paymentMethod__handle__ = paymentMethod!.GetNonNullHandle (nameof (paymentMethod));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V237.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:handler:"), controller__handle__, paymentMethod__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (paymentMethod);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidRequestMerchantSessionUpdate (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V240))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> handler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V240.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didRequestMerchantSessionUpdate:"), controller__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidChangeCouponCode (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V241))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (couponCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (couponCode));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscouponCode = CFString.CreateNative (couponCode);
			using var block_completion = Trampolines.SDActionArity1V241.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didChangeCouponCode:handler:"), controller__handle__, nscouponCode, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nscouponCode);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow? GetPresentationWindow (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationWindowForPaymentAuthorizationController:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKPaymentAuthorizationControllerDelegateWrapper : BaseWrapper, IPKPaymentAuthorizationControllerDelegate {
		public PKPaymentAuthorizationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentAuthorizationControllerDelegateWrapper))]
		static PKPaymentAuthorizationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="controller">The <see cref="T:PassKit.PKPaymentAuthorizationController" /> for which the payment authorization has finished.</param><summary>Method that is called when payment authorization has finished.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinish (PKPaymentAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("paymentAuthorizationControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (controller);
		}
	}
}
namespace PassKit {
	/// <summary>Delegate object that responds to user interactions on behalf of a <see cref="T:PassKit.PKPaymentAuthorizationController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/PassKit/PKPaymentAuthorizationControllerDelegate">Apple documentation for <c>PKPaymentAuthorizationControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__PassKit_PKPaymentAuthorizationControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class PKPaymentAuthorizationControllerDelegate : NSObject, IPKPaymentAuthorizationControllerDelegate {
		/// <summary>Creates a new <see cref="PKPaymentAuthorizationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKPaymentAuthorizationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PKPaymentAuthorizationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal PKPaymentAuthorizationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAuthorizePayment' overload with the 'Action&lt;PKPaymentAuthorizationResult&gt;' parameter instead.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didAuthorizePayment:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V235))]global::System.Action<PKPaymentAuthorizationStatus> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="payment">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V236))]global::System.Action<PKPaymentAuthorizationResult> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("paymentAuthorizationController:didChangeCouponCode:handler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidChangeCouponCode (PKPaymentAuthorizationController controller, string couponCode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V241))]global::System.Action<PKPaymentRequestCouponCodeUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The <see cref="T:PassKit.PKPaymentAuthorizationController" /> for which the payment authorization has finished.</param><summary>Method that is called when payment authorization has finished.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (PKPaymentAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("paymentAuthorizationController:didRequestMerchantSessionUpdate:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V240))]global::System.Action<PKPaymentRequestMerchantSessionUpdate> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="paymentMethod">The payment method that was selected.</param><param name="completion">A handler that takes a list of updated payment summary items.</param><summary>Method that is called when the user selects a payment method.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V239))]global::System.Action<PKPaymentSummaryItem[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="contact">The new shipping address.</param><param name="completion">A handler that takes the payment authorization status, a list of updated shipping method objects, and a list of updated payment summary items.</param><summary>Method that is called when a user selects a contact to ship to.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectShippingContact:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V19))]global::System.Action<PKPaymentAuthorizationStatus, PKShippingMethod[], PKPaymentSummaryItem[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="contact">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V238))]global::System.Action<PKPaymentRequestShippingContactUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that owns this delegate.</param><param name="shippingMethod">The new shipping method.</param><param name="completion">A handler that takes the authorization status for the payment and a list of updated payment summary items.</param><summary>Method that is called when a user selects a new shipping method.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectShippingMethod:completion:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V145))]global::System.Action<PKPaymentAuthorizationStatus, PKPaymentSummaryItem[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="paymentMethod">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V237))]global::System.Action<PKPaymentRequestPaymentMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationWindowForPaymentAuthorizationController:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIWindow? GetPresentationWindow (PKPaymentAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that owns this delegate.</param><summary>Method that is called when the user is authorizing a payment request.</summary><remarks>This method is called after the user authenticates, but before the request is authorized.</remarks>
		[Export ("paymentAuthorizationControllerWillAuthorizePayment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAuthorizePayment (PKPaymentAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKPaymentAuthorizationControllerDelegate */
}
