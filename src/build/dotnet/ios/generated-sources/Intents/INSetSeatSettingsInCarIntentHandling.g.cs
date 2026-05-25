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
	[Protocol (Name = "INSetSeatSettingsInCarIntentHandling", WrapperType = typeof (INSetSeatSettingsInCarIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSetSeatSettingsInCar", Selector = "handleSetSeatSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetSeatSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V116) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSetSeatSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetSeatSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V116) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableHeating", Selector = "resolveEnableHeatingForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableCooling", Selector = "resolveEnableCoolingForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableMassage", Selector = "resolveEnableMassageForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSeat", Selector = "resolveSeatForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INCarSeatResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V196) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveLevel", Selector = "resolveLevelForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INIntegerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V100) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRelativeLevelSetting", Selector = "resolveRelativeLevelSettingForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INRelativeSettingResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V194) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCarName", Selector = "resolveCarNameForSetSeatSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetSeatSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V80) })]
	public partial interface IINSetSeatSettingsInCarIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetSeatSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetSeatSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSetSeatSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSetSeatSettingsInCar (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetSeatSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetSeatSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSetSeatSettingsInCar (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V116.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSetSeatSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the confirmation of a change in seat settings.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSetSeatSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the confirmation of a change in seat settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V116.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetSeatSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat heating can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableHeatingForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableHeating (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableHeating (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat heating can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableHeating (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableHeatingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat cooling can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableCoolingForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableCooling (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableCooling (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat cooling can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableCooling (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableCoolingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat massage can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableMassageForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableMassage (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableMassage (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat massage can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableMassage (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableMassageForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of choosing a particular seat.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveSeatForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveSeat (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V196))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			_ResolveSeat (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of choosing a particular seat.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveSeat (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V196))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V196.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSeatForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting the absolute level of the requested service.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveLevelForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveLevel (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			_ResolveLevel (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting the absolute level of the requested service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveLevel (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V100.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveLevelForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting a relative level of the requested service.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRelativeLevelSettingForSetSeatSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveRelativeLevelSetting (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V194))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			_ResolveRelativeLevelSetting (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting a relative level of the requested service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveRelativeLevelSetting (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V194))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V194.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeLevelSettingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCarNameForSetSeatSettingsInCar:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCarName (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
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
		internal unsafe static void _ResolveCarName (IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INSetSeatSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSetSeatSettingsInCar(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INSetSeatSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveCarName(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableCooling(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableHeating(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableMassage(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveLevel(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INIntegerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveRelativeLevelSetting(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INRelativeSettingResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveSeat(Intents.INSetSeatSettingsInCarIntent,System.Action{Intents.INCarSeatResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetSeatSettingsInCarIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSetSeatSettingsInCarIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSetSeatSettingsInCarIntentHandling" /> interface to support all the methods from the INSetSeatSettingsInCarIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSetSeatSettingsInCarIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSetSeatSettingsInCarIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSetSeatSettingsInCarIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the confirmation of a change in seat settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V116.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetSeatSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat heating can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableHeating (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableHeatingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat cooling can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableCooling (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableCoolingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of whether seat massage can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableMassage (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableMassageForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of choosing a particular seat.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveSeat (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V196))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V196.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSeatForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting the absolute level of the requested service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveLevel (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V100.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveLevelForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can override this method to customize the resolution of setting a relative level of the requested service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveRelativeLevelSetting (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V194))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V194.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeLevelSettingForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
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
		public unsafe static void ResolveCarName (this IINSetSeatSettingsInCarIntentHandling This, INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetSeatSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSetSeatSettingsInCarIntentHandlingWrapper : BaseWrapper, IINSetSeatSettingsInCarIntentHandling {
		public INSetSeatSettingsInCarIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetSeatSettingsInCarIntentHandlingWrapper))]
		static INSetSeatSettingsInCarIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetSeatSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetSeatSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetSeatSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetSeatSettingsInCar (INSetSeatSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V116))]global::System.Action<INSetSeatSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V116.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetSeatSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
