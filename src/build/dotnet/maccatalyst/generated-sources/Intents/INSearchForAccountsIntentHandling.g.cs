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
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INSearchForAccountsIntentHandling", WrapperType = typeof (INSearchForAccountsIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSearchForAccounts", Selector = "handleSearchForAccounts:completion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INSearchForAccountsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V135) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSearchForAccounts:completion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INSearchForAccountsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V135) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAccountNickname", Selector = "resolveAccountNicknameForSearchForAccounts:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V66) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAccountType", Selector = "resolveAccountTypeForSearchForAccounts:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INAccountTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveOrganizationName", Selector = "resolveOrganizationNameForSearchForAccounts:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V66) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRequestedBalanceType", Selector = "resolveRequestedBalanceTypeForSearchForAccounts:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSearchForAccountsIntent), typeof (global::System.Action<global::Intents.INBalanceTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V159) })]
	public partial interface IINSearchForAccountsIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchForAccountsIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchForAccountsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSearchForAccounts:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSearchForAccounts (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchForAccountsIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchForAccountsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSearchForAccounts (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V135.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSearchForAccounts:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to perform the search.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSearchForAccounts:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to perform the search.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V135.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSearchForAccounts:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account nicknames.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveAccountNicknameForSearchForAccounts:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAccountNickname (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveAccountNickname (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account nicknames.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAccountNickname (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAccountNicknameForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account types.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveAccountTypeForSearchForAccounts:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAccountType (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INAccountTypeResolutionResult> completion)
		{
			_ResolveAccountType (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account types.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAccountType (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INAccountTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAccountTypeForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of organization names.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveOrganizationNameForSearchForAccounts:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveOrganizationName (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveOrganizationName (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of organization names.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveOrganizationName (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveOrganizationNameForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of requested balance types.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRequestedBalanceTypeForSearchForAccounts:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveRequestedBalanceType (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V159))]global::System.Action<INBalanceTypeResolutionResult> completion)
		{
			_ResolveRequestedBalanceType (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of requested balance types.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveRequestedBalanceType (IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V159))]global::System.Action<INBalanceTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V159.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRequestedBalanceTypeForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSearchForAccountsIntent,System.Action{Intents.INSearchForAccountsIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSearchForAccounts(Intents.INSearchForAccountsIntent,System.Action{Intents.INSearchForAccountsIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveAccountNickname(Intents.INSearchForAccountsIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveAccountType(Intents.INSearchForAccountsIntent,System.Action{Intents.INAccountTypeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveOrganizationName(Intents.INSearchForAccountsIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveRequestedBalanceType(Intents.INSearchForAccountsIntent,System.Action{Intents.INBalanceTypeResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSearchForAccountsIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSearchForAccountsIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSearchForAccountsIntentHandling" /> interface to support all the methods from the INSearchForAccountsIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSearchForAccountsIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSearchForAccountsIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSearchForAccountsIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to perform the search.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V135.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSearchForAccounts:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account nicknames.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAccountNickname (this IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAccountNicknameForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of account types.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAccountType (this IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INAccountTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAccountTypeForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of organization names.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveOrganizationName (this IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveOrganizationNameForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of requested balance types.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveRequestedBalanceType (this IINSearchForAccountsIntentHandling This, INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V159))]global::System.Action<INBalanceTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V159.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRequestedBalanceTypeForSearchForAccounts:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSearchForAccountsIntentHandlingWrapper : BaseWrapper, IINSearchForAccountsIntentHandling {
		public INSearchForAccountsIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSearchForAccountsIntentHandlingWrapper))]
		static INSearchForAccountsIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchForAccountsIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchForAccountsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSearchForAccounts:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearchForAccounts (INSearchForAccountsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INSearchForAccountsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V135.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchForAccounts:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
