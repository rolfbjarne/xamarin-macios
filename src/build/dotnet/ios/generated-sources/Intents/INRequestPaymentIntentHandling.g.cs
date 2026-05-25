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
	/// <summary>Interface to resolve, confirm and handle Siri requests for the corresponding action.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INRequestPaymentIntentHandling", WrapperType = typeof (INRequestPaymentIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleRequestPayment", Selector = "handleRequestPayment:completion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INRequestPaymentIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V149) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmRequestPayment:completion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INRequestPaymentIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V149) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePayer", Selector = "resolvePayerForRequestPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INPersonResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V164) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePayer", Selector = "resolvePayerForRequestPayment:completion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INRequestPaymentPayerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V165) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCurrencyAmount", Selector = "resolveCurrencyAmountForRequestPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INCurrencyAmountResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V166) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCurrencyAmount", Selector = "resolveCurrencyAmountForRequestPayment:completion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INRequestPaymentCurrencyAmountResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V167) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveNote", Selector = "resolveNoteForRequestPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INRequestPaymentIntent), typeof (global::System.Action<global::Intents.INStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V102) })]
	public partial interface IINRequestPaymentIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INRequestPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INRequestPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleRequestPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleRequestPayment (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INRequestPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INRequestPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleRequestPayment (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V149.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a payment request.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmRequestPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a payment request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V149.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payer.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePayerForRequestPayment:withCompletion:")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePayer (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			_ResolvePayer (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payer.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePayer (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V164.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayerForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a payer.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePayerForRequestPayment:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePayer (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V165))]global::System.Action<INRequestPaymentPayerResolutionResult> completion)
		{
			_ResolvePayer (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a payer.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePayer (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V165))]global::System.Action<INRequestPaymentPayerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V165.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayerForRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action&lt;INRequestPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCurrencyAmountForRequestPayment:withCompletion:")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCurrencyAmount (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			_ResolveCurrencyAmount (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action&lt;INRequestPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCurrencyAmount (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V166.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCurrencyAmountForRequestPayment:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCurrencyAmount (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INRequestPaymentCurrencyAmountResolutionResult> completion)
		{
			_ResolveCurrencyAmount (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCurrencyAmount (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INRequestPaymentCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V167.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note to accompany the request.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveNoteForRequestPayment:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveNote (INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			_ResolveNote (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note to accompany the request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveNote (IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V102.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveNoteForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INRequestPaymentIntent,System.Action{Intents.INRequestPaymentIntentResponse})")]
		[DynamicDependencyAttribute ("HandleRequestPayment(Intents.INRequestPaymentIntent,System.Action{Intents.INRequestPaymentIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveCurrencyAmount(Intents.INRequestPaymentIntent,System.Action{Intents.INCurrencyAmountResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveCurrencyAmount(Intents.INRequestPaymentIntent,System.Action{Intents.INRequestPaymentCurrencyAmountResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveNote(Intents.INRequestPaymentIntent,System.Action{Intents.INStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePayer(Intents.INRequestPaymentIntent,System.Action{Intents.INPersonResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePayer(Intents.INRequestPaymentIntent,System.Action{Intents.INRequestPaymentPayerResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INRequestPaymentIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINRequestPaymentIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINRequestPaymentIntentHandling" /> interface to support all the methods from the INRequestPaymentIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINRequestPaymentIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INRequestPaymentIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INRequestPaymentIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a payment request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V149))]global::System.Action<INRequestPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V149.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payer.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayer (INRequestPaymentIntent, Action<INRequestPaymentPayerResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePayer (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V164.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayerForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a payer.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePayer (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V165))]global::System.Action<INRequestPaymentPayerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V165.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayerForRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action&lt;INRequestPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INRequestPaymentIntent, Action<INRequestPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCurrencyAmount (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V166.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCurrencyAmount (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INRequestPaymentCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V167.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForRequestPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note to accompany the request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveNote (this IINRequestPaymentIntentHandling This, INRequestPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V102.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveNoteForRequestPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INRequestPaymentIntentHandlingWrapper : BaseWrapper, IINRequestPaymentIntentHandling {
		public INRequestPaymentIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INRequestPaymentIntentHandlingWrapper))]
		static INRequestPaymentIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
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
	}
}
