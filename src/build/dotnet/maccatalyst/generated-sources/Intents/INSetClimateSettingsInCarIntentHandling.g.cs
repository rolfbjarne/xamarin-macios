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
	[Protocol (Name = "INSetClimateSettingsInCarIntentHandling", WrapperType = typeof (INSetClimateSettingsInCarIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSetClimateSettingsInCar", Selector = "handleSetClimateSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetClimateSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V99) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSetClimateSettingsInCar:completion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSetClimateSettingsInCarIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V99) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableFan", Selector = "resolveEnableFanForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V143) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableAirConditioner", Selector = "resolveEnableAirConditionerForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V143) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableClimateControl", Selector = "resolveEnableClimateControlForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V143) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveEnableAutoMode", Selector = "resolveEnableAutoModeForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V143) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAirCirculationMode", Selector = "resolveAirCirculationModeForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INCarAirCirculationModeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V177) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveFanSpeedIndex", Selector = "resolveFanSpeedIndexForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INIntegerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V86) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveFanSpeedPercentage", Selector = "resolveFanSpeedPercentageForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INDoubleResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V178) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRelativeFanSpeedSetting", Selector = "resolveRelativeFanSpeedSettingForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INRelativeSettingResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V179) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTemperature", Selector = "resolveTemperatureForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INTemperatureResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V180) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRelativeTemperatureSetting", Selector = "resolveRelativeTemperatureSettingForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INRelativeSettingResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V179) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveClimateZone", Selector = "resolveClimateZoneForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INCarSeatResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V181) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCarName", Selector = "resolveCarNameForSetClimateSettingsInCar:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetClimateSettingsInCarIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V66) })]
	public partial interface IINSetClimateSettingsInCarIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetClimateSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetClimateSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSetClimateSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSetClimateSettingsInCar (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetClimateSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetClimateSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSetClimateSettingsInCar (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSetClimateSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of climate settings.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSetClimateSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of climate settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetClimateSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the requested fan can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableFanForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableFan (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableFan (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the requested fan can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableFan (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableFanForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the air conditioner can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableAirConditionerForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableAirConditioner (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableAirConditioner (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the air conditioner can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableAirConditioner (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableAirConditionerForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether climate control can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableClimateControlForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableClimateControl (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableClimateControl (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether climate control can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableClimateControl (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableClimateControlForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether automatic mode can be enabled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveEnableAutoModeForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveEnableAutoMode (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveEnableAutoMode (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether automatic mode can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveEnableAutoMode (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableAutoModeForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the air circulation mode.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveAirCirculationModeForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAirCirculationMode (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V177))]global::System.Action<INCarAirCirculationModeResolutionResult> completion)
		{
			_ResolveAirCirculationMode (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the air circulation mode.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAirCirculationMode (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V177))]global::System.Action<INCarAirCirculationModeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V177.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAirCirculationModeForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed index.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveFanSpeedIndexForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveFanSpeedIndex (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V86))]global::System.Action<INIntegerResolutionResult> completion)
		{
			_ResolveFanSpeedIndex (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed index.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveFanSpeedIndex (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V86))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V86.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveFanSpeedIndexForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed, as a percentage.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveFanSpeedPercentageForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveFanSpeedPercentage (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V178))]global::System.Action<INDoubleResolutionResult> completion)
		{
			_ResolveFanSpeedPercentage (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed, as a percentage.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveFanSpeedPercentage (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V178))]global::System.Action<INDoubleResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V178.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveFanSpeedPercentageForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in the fan speed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRelativeFanSpeedSettingForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveRelativeFanSpeedSetting (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			_ResolveRelativeFanSpeedSetting (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in the fan speed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveRelativeFanSpeedSetting (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V179.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeFanSpeedSettingForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the specified temperature value.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTemperatureForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTemperature (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V180))]global::System.Action<INTemperatureResolutionResult> completion)
		{
			_ResolveTemperature (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the specified temperature value.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTemperature (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V180))]global::System.Action<INTemperatureResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V180.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemperatureForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in temperature settings.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRelativeTemperatureSettingForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveRelativeTemperatureSetting (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			_ResolveRelativeTemperatureSetting (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in temperature settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveRelativeTemperatureSetting (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V179.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeTemperatureSettingForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a requested climate zone.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveClimateZoneForSetClimateSettingsInCar:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveClimateZone (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V181))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			_ResolveClimateZone (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a requested climate zone.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveClimateZone (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V181))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V181.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveClimateZoneForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCarNameForSetClimateSettingsInCar:withCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCarName (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
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
		internal unsafe static void _ResolveCarName (IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INSetClimateSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSetClimateSettingsInCar(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INSetClimateSettingsInCarIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveAirCirculationMode(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INCarAirCirculationModeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveCarName(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveClimateZone(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INCarSeatResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableAirConditioner(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableAutoMode(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableClimateControl(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveEnableFan(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveFanSpeedIndex(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INIntegerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveFanSpeedPercentage(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INDoubleResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveRelativeFanSpeedSetting(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INRelativeSettingResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveRelativeTemperatureSetting(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INRelativeSettingResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTemperature(Intents.INSetClimateSettingsInCarIntent,System.Action{Intents.INTemperatureResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetClimateSettingsInCarIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSetClimateSettingsInCarIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSetClimateSettingsInCarIntentHandling" /> interface to support all the methods from the INSetClimateSettingsInCarIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSetClimateSettingsInCarIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSetClimateSettingsInCarIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSetClimateSettingsInCarIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of climate settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetClimateSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the requested fan can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableFan (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableFanForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether the air conditioner can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableAirConditioner (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableAirConditionerForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether climate control can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableClimateControl (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableClimateControlForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of whether automatic mode can be enabled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveEnableAutoMode (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V143))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V143.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveEnableAutoModeForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the air circulation mode.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAirCirculationMode (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V177))]global::System.Action<INCarAirCirculationModeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V177.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAirCirculationModeForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed index.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveFanSpeedIndex (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V86))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V86.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveFanSpeedIndexForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a fan speed, as a percentage.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveFanSpeedPercentage (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V178))]global::System.Action<INDoubleResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V178.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveFanSpeedPercentageForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in the fan speed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveRelativeFanSpeedSetting (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V179.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeFanSpeedSettingForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the specified temperature value.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTemperature (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V180))]global::System.Action<INTemperatureResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V180.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemperatureForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a relative increase or decrease in temperature settings.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveRelativeTemperatureSetting (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V179))]global::System.Action<INRelativeSettingResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V179.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRelativeTemperatureSettingForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of a requested climate zone.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveClimateZone (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V181))]global::System.Action<INCarSeatResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V181.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveClimateZoneForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
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
		public unsafe static void ResolveCarName (this IINSetClimateSettingsInCarIntentHandling This, INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForSetClimateSettingsInCar:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSetClimateSettingsInCarIntentHandlingWrapper : BaseWrapper, IINSetClimateSettingsInCarIntentHandling {
		public INSetClimateSettingsInCarIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetClimateSettingsInCarIntentHandlingWrapper))]
		static INSetClimateSettingsInCarIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetClimateSettingsInCarIntentResponse" /> appropriate to the <see cref="T:Intents.INSetClimateSettingsInCarIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetClimateSettingsInCar:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetClimateSettingsInCar (INSetClimateSettingsInCarIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INSetClimateSettingsInCarIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetClimateSettingsInCar:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
