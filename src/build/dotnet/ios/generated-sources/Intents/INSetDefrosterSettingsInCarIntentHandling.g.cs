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
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INSetDefrosterSettingsInCarIntentHandling", WrapperType = typeof (INSetDefrosterSettingsInCarIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSetDefrosterSettingsInCar", Selector = "handleSetDefrosterSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetDefrosterSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetDefrosterSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V114) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSetDefrosterSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetDefrosterSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetDefrosterSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V114) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnable", Selector = "resolveEnableForSetDefrosterSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetDefrosterSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDefroster", Selector = "resolveDefrosterForSetDefrosterSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetDefrosterSettingsInCarIntent), typeof (global::System.Action<global::Intents.INCarDefrosterResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V197) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCarName", Selector = "resolveCarNameForSetDefrosterSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetDefrosterSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V80) })]
	public partial interface IINSetDefrosterSettingsInCarIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetDefrosterSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetDefrosterSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSetDefrosterSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSetDefrosterSettingsInCar (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetDefrosterSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetDefrosterSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSetDefrosterSettingsInCar (IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSetDefrosterSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of defroster settings.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSetDefrosterSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of defroster settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetDefrosterSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether the defroster can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableForSetDefrosterSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnable (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnable (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether the defroster can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnable (IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of the requested defroster.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveDefrosterForSetDefrosterSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveDefroster (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V197))]global::System.Action<INCarDefrosterResolutionResult> completion)
		{
			_ResolveDefroster (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of the requested defroster.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveDefroster (IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V197))]global::System.Action<INCarDefrosterResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V197.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDefrosterForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCarNameForSetDefrosterSettingsInCar:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCarName (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveCarName (this, intent, completion);
		}
		/// <param name="intent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCarName (IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSetDefrosterSettingsInCarIntent,System.Action{Intents.INSetDefrosterSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSetDefrosterSettingsInCar(Intents.INSetDefrosterSettingsInCarIntent,System.Action{Intents.INSetDefrosterSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveCarName(Intents.INSetDefrosterSettingsInCarIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveDefroster(Intents.INSetDefrosterSettingsInCarIntent,System.Action{Intents.INCarDefrosterResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnable(Intents.INSetDefrosterSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetDefrosterSettingsInCarIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSetDefrosterSettingsInCarIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSetDefrosterSettingsInCarIntentHandling" /> interface to support all the methods from the INSetDefrosterSettingsInCarIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSetDefrosterSettingsInCarIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSetDefrosterSettingsInCarIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSetDefrosterSettingsInCarIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of defroster settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetDefrosterSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether the defroster can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnable (this IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of the requested defroster.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveDefroster (this IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V197))]global::System.Action<INCarDefrosterResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V197.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDefrosterForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCarName (this IINSetDefrosterSettingsInCarIntentHandling This, INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetDefrosterSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSetDefrosterSettingsInCarIntentHandlingWrapper : BaseWrapper, IINSetDefrosterSettingsInCarIntentHandling {
		public INSetDefrosterSettingsInCarIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetDefrosterSettingsInCarIntentHandlingWrapper))]
		static INSetDefrosterSettingsInCarIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetDefrosterSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetDefrosterSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetDefrosterSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetDefrosterSettingsInCar (INSetDefrosterSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INSetDefrosterSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetDefrosterSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
