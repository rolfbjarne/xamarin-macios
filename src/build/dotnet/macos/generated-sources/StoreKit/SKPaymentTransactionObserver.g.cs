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
namespace StoreKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SKPaymentTransactionObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("macos15.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SKPaymentTransactionObserver", WrapperType = typeof (SKPaymentTransactionObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatedTransactions", Selector = "paymentQueue:updatedTransactions:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (StoreKit.SKPaymentTransaction[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemovedTransactions", Selector = "paymentQueue:removedTransactions:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (StoreKit.SKPaymentTransaction[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreCompletedTransactionsFailedWithError", Selector = "paymentQueue:restoreCompletedTransactionsFailedWithError:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreCompletedTransactionsFinished", Selector = "paymentQueueRestoreCompletedTransactionsFinished:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedDownloads", Selector = "paymentQueue:updatedDownloads:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (StoreKit.SKDownload[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAddStorePayment", Selector = "paymentQueue:shouldAddStorePayment:forProduct:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (StoreKit.SKPayment), typeof (StoreKit.SKProduct) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeStorefront", Selector = "paymentQueueDidChangeStorefront:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRevokeEntitlements", Selector = "paymentQueue:didRevokeEntitlementsForProductIdentifiers:", ParameterType = new Type [] { typeof (StoreKit.SKPaymentQueue), typeof (String[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISKPaymentTransactionObserver : INativeObject, IDisposable
	{
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("paymentQueue:updatedTransactions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedTransactions (SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedTransactions (ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (transactions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transactions));
			using var nsa_transactions = NSArray.FromNSObjects (transactions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:updatedTransactions:"), queue__handle__, nsa_transactions.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>Method that is called after transactions have been removed from the queue.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentQueue:removedTransactions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemovedTransactions (SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			_RemovedTransactions (this, queue, transactions);
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>Method that is called after transactions have been removed from the queue.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemovedTransactions (ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (transactions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transactions));
			using var nsa_transactions = NSArray.FromNSObjects (transactions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:removedTransactions:"), queue__handle__, nsa_transactions.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">To be added.</param><param name="error">To be added.</param><summary>Method that is called when an error occurs while restoring transactions.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentQueue:restoreCompletedTransactionsFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreCompletedTransactionsFailedWithError (SKPaymentQueue queue, NSError error)
		{
			_RestoreCompletedTransactionsFailedWithError (this, queue, error);
		}
		/// <param name="queue">To be added.</param><param name="error">To be added.</param><summary>Method that is called when an error occurs while restoring transactions.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RestoreCompletedTransactionsFailedWithError (ISKPaymentTransactionObserver This, SKPaymentQueue queue, NSError error)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:restoreCompletedTransactionsFailedWithError:"), queue__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
			GC.KeepAlive (error);
		}
		/// <param name="queue">To be added.</param><summary>Method that is called after transactions have been restored.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentQueueRestoreCompletedTransactionsFinished:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreCompletedTransactionsFinished (SKPaymentQueue queue)
		{
			_RestoreCompletedTransactionsFinished (this, queue);
		}
		/// <param name="queue">To be added.</param><summary>Method that is called after transactions have been restored.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RestoreCompletedTransactionsFinished (ISKPaymentTransactionObserver This, SKPaymentQueue queue)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueueRestoreCompletedTransactionsFinished:"), queue__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">To be added.</param><param name="downloads">To be added.</param><summary>Method that is called when one or more downloads has been updated by the queue.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentQueue:updatedDownloads:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedDownloads (SKPaymentQueue queue, SKDownload[] downloads)
		{
			_UpdatedDownloads (this, queue, downloads);
		}
		/// <param name="queue">To be added.</param><param name="downloads">To be added.</param><summary>Method that is called when one or more downloads has been updated by the queue.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedDownloads (ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKDownload[] downloads)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (downloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (downloads));
			using var nsa_downloads = NSArray.FromNSObjects (downloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:updatedDownloads:"), queue__handle__, nsa_downloads.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">The payment queue on which the payment was made.</param><param name="payment">The payment.</param><param name="product">The product that was paid for.</param><summary>Called to indicate that the user has started an in-app App Store purchase.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("paymentQueue:shouldAddStorePayment:forProduct:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAddStorePayment (SKPaymentQueue queue, SKPayment payment, SKProduct product)
		{
			return _ShouldAddStorePayment (this, queue, payment, product);
		}
		/// <param name="queue">The payment queue on which the payment was made.</param><param name="payment">The payment.</param><param name="product">The product that was paid for.</param><summary>Called to indicate that the user has started an in-app App Store purchase.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAddStorePayment (ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPayment payment, SKProduct product)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			var product__handle__ = product!.GetNonNullHandle (nameof (product));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:shouldAddStorePayment:forProduct:"), queue__handle__, payment__handle__, product__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
			GC.KeepAlive (payment);
			GC.KeepAlive (product);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentQueueDidChangeStorefront:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeStorefront (SKPaymentQueue queue)
		{
			_DidChangeStorefront (this, queue);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeStorefront (ISKPaymentTransactionObserver This, SKPaymentQueue queue)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueueDidChangeStorefront:"), queue__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		[global::Foundation.OptionalMember]
		[Export ("paymentQueue:didRevokeEntitlementsForProductIdentifiers:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRevokeEntitlements (SKPaymentQueue queue, string[] productIdentifiers)
		{
			_DidRevokeEntitlements (this, queue, productIdentifiers);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRevokeEntitlements (ISKPaymentTransactionObserver This, SKPaymentQueue queue, string[] productIdentifiers)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (productIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productIdentifiers));
			using var nsa_productIdentifiers = NSArray.FromStrings (productIdentifiers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:didRevokeEntitlementsForProductIdentifiers:"), queue__handle__, nsa_productIdentifiers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		[DynamicDependencyAttribute ("DidChangeStorefront(StoreKit.SKPaymentQueue)")]
		[DynamicDependencyAttribute ("DidRevokeEntitlements(StoreKit.SKPaymentQueue,System.String[])")]
		[DynamicDependencyAttribute ("RemovedTransactions(StoreKit.SKPaymentQueue,StoreKit.SKPaymentTransaction[])")]
		[DynamicDependencyAttribute ("RestoreCompletedTransactionsFailedWithError(StoreKit.SKPaymentQueue,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RestoreCompletedTransactionsFinished(StoreKit.SKPaymentQueue)")]
		[DynamicDependencyAttribute ("ShouldAddStorePayment(StoreKit.SKPaymentQueue,StoreKit.SKPayment,StoreKit.SKProduct)")]
		[DynamicDependencyAttribute ("UpdatedDownloads(StoreKit.SKPaymentQueue,StoreKit.SKDownload[])")]
		[DynamicDependencyAttribute ("UpdatedTransactions(StoreKit.SKPaymentQueue,StoreKit.SKPaymentTransaction[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKPaymentTransactionObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISKPaymentTransactionObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISKPaymentTransactionObserver" /> interface to support all the methods from the SKPaymentTransactionObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISKPaymentTransactionObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SKPaymentTransactionObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SKPaymentTransactionObserver_Extensions {
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>Method that is called after transactions have been removed from the queue.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemovedTransactions (this ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (transactions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transactions));
			using var nsa_transactions = NSArray.FromNSObjects (transactions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:removedTransactions:"), queue__handle__, nsa_transactions.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">To be added.</param><param name="error">To be added.</param><summary>Method that is called when an error occurs while restoring transactions.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RestoreCompletedTransactionsFailedWithError (this ISKPaymentTransactionObserver This, SKPaymentQueue queue, NSError error)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:restoreCompletedTransactionsFailedWithError:"), queue__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
			GC.KeepAlive (error);
		}
		/// <param name="queue">To be added.</param><summary>Method that is called after transactions have been restored.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RestoreCompletedTransactionsFinished (this ISKPaymentTransactionObserver This, SKPaymentQueue queue)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueueRestoreCompletedTransactionsFinished:"), queue__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">To be added.</param><param name="downloads">To be added.</param><summary>Method that is called when one or more downloads has been updated by the queue.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedDownloads (this ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKDownload[] downloads)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (downloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (downloads));
			using var nsa_downloads = NSArray.FromNSObjects (downloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:updatedDownloads:"), queue__handle__, nsa_downloads.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		/// <param name="queue">The payment queue on which the payment was made.</param><param name="payment">The payment.</param><param name="product">The product that was paid for.</param><summary>Called to indicate that the user has started an in-app App Store purchase.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAddStorePayment (this ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPayment payment, SKProduct product)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			var payment__handle__ = payment!.GetNonNullHandle (nameof (payment));
			var product__handle__ = product!.GetNonNullHandle (nameof (product));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:shouldAddStorePayment:forProduct:"), queue__handle__, payment__handle__, product__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
			GC.KeepAlive (payment);
			GC.KeepAlive (product);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeStorefront (this ISKPaymentTransactionObserver This, SKPaymentQueue queue)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueueDidChangeStorefront:"), queue__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRevokeEntitlements (this ISKPaymentTransactionObserver This, SKPaymentQueue queue, string[] productIdentifiers)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (productIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productIdentifiers));
			using var nsa_productIdentifiers = NSArray.FromStrings (productIdentifiers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("paymentQueue:didRevokeEntitlementsForProductIdentifiers:"), queue__handle__, nsa_productIdentifiers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (queue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SKPaymentTransactionObserverWrapper : BaseWrapper, ISKPaymentTransactionObserver {
		public SKPaymentTransactionObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKPaymentTransactionObserverWrapper))]
		static SKPaymentTransactionObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueue:updatedTransactions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdatedTransactions (SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (transactions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transactions));
			using var nsa_transactions = NSArray.FromNSObjects (transactions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("paymentQueue:updatedTransactions:"), queue__handle__, nsa_transactions.Handle);
			GC.KeepAlive (queue);
		}
	}
}
namespace StoreKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISKPaymentTransactionObserver" /> (for the protocol <c>SKPaymentTransactionObserver</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISKPaymentTransactionObserver" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__StoreKit_SKPaymentTransactionObserver", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("macos15.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class SKPaymentTransactionObserver : NSObject, ISKPaymentTransactionObserver {
		/// <summary>Creates a new <see cref="SKPaymentTransactionObserver" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SKPaymentTransactionObserver () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected SKPaymentTransactionObserver (NSObjectFlag t) : base (t)
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
		protected internal SKPaymentTransactionObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("paymentQueueDidChangeStorefront:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeStorefront (SKPaymentQueue queue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("paymentQueue:didRevokeEntitlementsForProductIdentifiers:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRevokeEntitlements (SKPaymentQueue queue, string[] productIdentifiers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>Method that is called after transactions have been removed from the queue.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueue:removedTransactions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemovedTransactions (SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="error">To be added.</param><summary>Method that is called when an error occurs while restoring transactions.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueue:restoreCompletedTransactionsFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreCompletedTransactionsFailedWithError (SKPaymentQueue queue, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><summary>Method that is called after transactions have been restored.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueueRestoreCompletedTransactionsFinished:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreCompletedTransactionsFinished (SKPaymentQueue queue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">The payment queue on which the payment was made.</param><param name="payment">The payment.</param><param name="product">The product that was paid for.</param><summary>Called to indicate that the user has started an in-app App Store purchase.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("paymentQueue:shouldAddStorePayment:forProduct:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAddStorePayment (SKPaymentQueue queue, SKPayment payment, SKProduct product)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="downloads">To be added.</param><summary>Method that is called when one or more downloads has been updated by the queue.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueue:updatedDownloads:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedDownloads (SKPaymentQueue queue, SKDownload[] downloads)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queue">To be added.</param><param name="transactions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("paymentQueue:updatedTransactions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedTransactions (SKPaymentQueue queue, SKPaymentTransaction[] transactions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SKPaymentTransactionObserver */
}
