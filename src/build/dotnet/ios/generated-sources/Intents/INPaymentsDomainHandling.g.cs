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
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Interface combining several interfaces related to various payment-related intents.</summary>
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INSendPaymentIntentHandling, INRequestPaymentIntentHandling, INPayBillIntentHandling, INSearchForBillsIntentHandling, INSearchForAccountsIntentHandling and INTransferMoneyIntentHandling' instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INSendPaymentIntentHandling, INRequestPaymentIntentHandling, INPayBillIntentHandling, INSearchForBillsIntentHandling, INSearchForAccountsIntentHandling and INTransferMoneyIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INPaymentsDomainHandling", WrapperType = typeof (INPaymentsDomainHandlingWrapper))]
	public partial interface IINPaymentsDomainHandling : INativeObject, IDisposable, 
		Intents.IINPayBillIntentHandling
		, Intents.IINRequestPaymentIntentHandling
		, Intents.IINSearchForAccountsIntentHandling
		, Intents.IINSearchForBillsIntentHandling
		, Intents.IINSendPaymentIntentHandling
		, Intents.IINTransferMoneyIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INPaymentsDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINPaymentsDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INPaymentsDomainHandlingWrapper : BaseWrapper, IINPaymentsDomainHandling {
		public INPaymentsDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INPaymentsDomainHandlingWrapper))]
		static INPaymentsDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers may implement this method to schedule bill payment.</summary><param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param>
		[Export ("handlePayBill:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandlePayBill (INPayBillIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INPayBillIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handlePayBill:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INRequestPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INRequestPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleRequestPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleRequestPayment (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V149.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchForAccountsIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchForAccountsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSearchForAccounts:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearchForAccounts (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V150))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V150.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchForAccounts:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <summary>Developers may implement this method to customize bill searches.</summary><param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param>
		[Export ("handleSearchForBills:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearch (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V151))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V151.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchForBills:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INSendPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSendPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSendPayment (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V152.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INTransferMoneyIntentResponse" /> appropriate to the <see cref="T:Intents.INTransferMoneyIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleTransferMoney:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleTransferMoney (INTransferMoneyIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V153))]global::System.Action<INTransferMoneyIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V153.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleTransferMoney:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
