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
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Interface to resolve, confirm and handle Siri requests for the corresponding action.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INSearchForBillsIntentHandling", WrapperType = typeof (INSearchForBillsIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSearch", Selector = "handleSearchForBills:completion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INSearchForBillsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V136) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSearchForBills:completion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INSearchForBillsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V136) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveBillPayee", Selector = "resolveBillPayeeForSearchForBills:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INBillPayeeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V129) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePaymentDateRange", Selector = "resolvePaymentDateRangeForSearchForBills:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INDateComponentsRangeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V132) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveBillType", Selector = "resolveBillTypeForSearchForBills:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INBillTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V133) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveStatus", Selector = "resolveStatusForSearchForBills:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INPaymentStatusResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V160) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDueDateRange", Selector = "resolveDueDateRangeForSearchForBills:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForBillsIntent), typeof (global::System.Action<global::Intents.INDateComponentsRangeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V132) })]
	public partial interface IINSearchForBillsIntentHandling : INativeObject, IDisposable
	{
		/// <summary>Developers may implement this method to customize bill searches.</summary><param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param>
		[global::Foundation.RequiredMember]
		[Export ("handleSearchForBills:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSearch (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Developers may implement this method to customize bill searches.</summary><param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSearch (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V136.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSearchForBills:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize search confirmation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSearchForBills:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize search confirmation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V136.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSearchForBills:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveBillPayeeForSearchForBills:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveBillPayee (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INBillPayeeResolutionResult> completion)
		{
			_ResolveBillPayee (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveBillPayee (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INBillPayeeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveBillPayeeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the date range of payments.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePaymentDateRangeForSearchForBills:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePaymentDateRange (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			_ResolvePaymentDateRange (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the date range of payments.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePaymentDateRange (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePaymentDateRangeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill type.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveBillTypeForSearchForBills:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveBillType (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V133))]global::System.Action<INBillTypeResolutionResult> completion)
		{
			_ResolveBillType (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill type.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveBillType (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V133))]global::System.Action<INBillTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V133.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveBillTypeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill status.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveStatusForSearchForBills:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveStatus (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V160))]global::System.Action<INPaymentStatusResolutionResult> completion)
		{
			_ResolveStatus (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveStatus (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V160))]global::System.Action<INPaymentStatusResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V160.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveStatusForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the range of due dates.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveDueDateRangeForSearchForBills:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveDueDateRange (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			_ResolveDueDateRange (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the range of due dates.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveDueDateRange (IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDueDateRangeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSearchForBillsIntent,System.Action{Intents.INSearchForBillsIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSearch(Intents.INSearchForBillsIntent,System.Action{Intents.INSearchForBillsIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveBillPayee(Intents.INSearchForBillsIntent,System.Action{Intents.INBillPayeeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveBillType(Intents.INSearchForBillsIntent,System.Action{Intents.INBillTypeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveDueDateRange(Intents.INSearchForBillsIntent,System.Action{Intents.INDateComponentsRangeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePaymentDateRange(Intents.INSearchForBillsIntent,System.Action{Intents.INDateComponentsRangeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveStatus(Intents.INSearchForBillsIntent,System.Action{Intents.INPaymentStatusResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSearchForBillsIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSearchForBillsIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSearchForBillsIntentHandling" /> interface to support all the methods from the INSearchForBillsIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSearchForBillsIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSearchForBillsIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSearchForBillsIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize search confirmation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V136.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSearchForBills:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the payee.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveBillPayee (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INBillPayeeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveBillPayeeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the date range of payments.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePaymentDateRange (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePaymentDateRangeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill type.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveBillType (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V133))]global::System.Action<INBillTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V133.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveBillTypeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the bill status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveStatus (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V160))]global::System.Action<INPaymentStatusResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V160.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveStatusForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the range of due dates.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveDueDateRange (this IINSearchForBillsIntentHandling This, INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDueDateRangeForSearchForBills:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSearchForBillsIntentHandlingWrapper : BaseWrapper, IINSearchForBillsIntentHandling {
		public INSearchForBillsIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSearchForBillsIntentHandlingWrapper))]
		static INSearchForBillsIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers may implement this method to customize bill searches.</summary><param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param>
		[Export ("handleSearchForBills:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearch (INSearchForBillsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V136))]global::System.Action<INSearchForBillsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V136.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchForBills:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
