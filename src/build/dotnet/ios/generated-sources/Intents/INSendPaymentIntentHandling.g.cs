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
	[Protocol (Name = "INSendPaymentIntentHandling", WrapperType = typeof (INSendPaymentIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSendPayment", Selector = "handleSendPayment:completion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INSendPaymentIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V152) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSendPayment:completion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INSendPaymentIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V152) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePayee", Selector = "resolvePayeeForSendPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INPersonResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V164) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePayee", Selector = "resolvePayeeForSendPayment:completion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INSendPaymentPayeeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V188) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCurrencyAmount", Selector = "resolveCurrencyAmountForSendPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INCurrencyAmountResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V166) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCurrencyAmount", Selector = "resolveCurrencyAmountForSendPayment:completion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INSendPaymentCurrencyAmountResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V189) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveNote", Selector = "resolveNoteForSendPayment:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSendPaymentIntent), typeof (global::System.Action<global::Intents.INStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V102) })]
	public partial interface IINSendPaymentIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INSendPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSendPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSendPayment (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendPaymentIntentResponse" /> appropriate to the <see cref="T:Intents.INSendPaymentIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSendPayment (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V152.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a request to send a payment.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSendPayment:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a request to send a payment.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V152.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePayeeForSendPayment:withCompletion:")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePayee (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			_ResolvePayee (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePayee (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V164.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayeeForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the payee.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePayeeForSendPayment:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePayee (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V188))]global::System.Action<INSendPaymentPayeeResolutionResult> completion)
		{
			_ResolvePayee (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the payee.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePayee (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V188))]global::System.Action<INSendPaymentPayeeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V188.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayeeForSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INSendPaymentIntent, Action&lt;INSendPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCurrencyAmountForSendPayment:withCompletion:")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCurrencyAmount (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			_ResolveCurrencyAmount (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INSendPaymentIntent, Action&lt;INSendPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCurrencyAmount (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V166.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCurrencyAmountForSendPayment:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCurrencyAmount (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V189))]global::System.Action<INSendPaymentCurrencyAmountResolutionResult> completion)
		{
			_ResolveCurrencyAmount (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCurrencyAmount (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V189))]global::System.Action<INSendPaymentCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V189.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note associated with the payment.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveNoteForSendPayment:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveNote (INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			_ResolveNote (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note associated with the payment.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveNote (IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V102.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveNoteForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSendPaymentIntent,System.Action{Intents.INSendPaymentIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSendPayment(Intents.INSendPaymentIntent,System.Action{Intents.INSendPaymentIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveCurrencyAmount(Intents.INSendPaymentIntent,System.Action{Intents.INCurrencyAmountResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveCurrencyAmount(Intents.INSendPaymentIntent,System.Action{Intents.INSendPaymentCurrencyAmountResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveNote(Intents.INSendPaymentIntent,System.Action{Intents.INStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePayee(Intents.INSendPaymentIntent,System.Action{Intents.INPersonResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePayee(Intents.INSendPaymentIntent,System.Action{Intents.INSendPaymentPayeeResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSendPaymentIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSendPaymentIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSendPaymentIntentHandling" /> interface to support all the methods from the INSendPaymentIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSendPaymentIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSendPaymentIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSendPaymentIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a request to send a payment.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V152))]global::System.Action<INSendPaymentIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V152.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolvePayee (INSendPaymentIntent, Action<INSendPaymentPayeeResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePayee (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V164))]global::System.Action<INPersonResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V164.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayeeForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the payee.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePayee (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V188))]global::System.Action<INSendPaymentPayeeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V188.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePayeeForSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers should not use this deprecated method. Developers should use 'ResolveCurrencyAmount (INSendPaymentIntent, Action&lt;INSendPaymentCurrencyAmountResolutionResult&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveCurrencyAmount (INSendPaymentIntent, Action<INSendPaymentCurrencyAmountResolutionResult>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCurrencyAmount (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V166))]global::System.Action<INCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V166.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a currency and amount.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCurrencyAmount (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V189))]global::System.Action<INSendPaymentCurrencyAmountResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V189.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCurrencyAmountForSendPayment:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a note associated with the payment.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveNote (this IINSendPaymentIntentHandling This, INSendPaymentIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V102))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V102.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveNoteForSendPayment:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSendPaymentIntentHandlingWrapper : BaseWrapper, IINSendPaymentIntentHandling {
		public INSendPaymentIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSendPaymentIntentHandlingWrapper))]
		static INSendPaymentIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
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
	}
}
