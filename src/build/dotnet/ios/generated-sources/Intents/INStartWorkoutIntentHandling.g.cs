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
	[Protocol (Name = "INStartWorkoutIntentHandling", WrapperType = typeof (INStartWorkoutIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleStartWorkout", Selector = "handleStartWorkout:completion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INStartWorkoutIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V210) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmStartWorkout:completion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INStartWorkoutIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V210) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveWorkoutName", Selector = "resolveWorkoutNameForStartWorkout:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V80) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveGoalValue", Selector = "resolveGoalValueForStartWorkout:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INDoubleResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V193) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveWorkoutGoalUnitType", Selector = "resolveWorkoutGoalUnitTypeForStartWorkout:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INWorkoutGoalUnitTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V211) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveWorkoutLocationType", Selector = "resolveWorkoutLocationTypeForStartWorkout:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INWorkoutLocationTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V212) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveIsOpenEnded", Selector = "resolveIsOpenEndedForStartWorkout:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartWorkoutIntent), typeof (global::System.Action<global::Intents.INBooleanResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V158) })]
	public partial interface IINStartWorkoutIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INStartWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleStartWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleStartWorkout (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INStartWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleStartWorkout (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V210.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleStartWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize a workout's starting confirmation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmStartWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize a workout's starting confirmation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V210.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmStartWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can call this method to trigger validation of the workout name.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveWorkoutNameForStartWorkout:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveWorkoutName (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveWorkoutName (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can call this method to trigger validation of the workout name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveWorkoutName (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutNameForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a workout goal.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveGoalValueForStartWorkout:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveGoalValue (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V193))]global::System.Action<INDoubleResolutionResult> completion)
		{
			_ResolveGoalValue (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a workout goal.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveGoalValue (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V193))]global::System.Action<INDoubleResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V193.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveGoalValueForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the type of the workout goal.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveWorkoutGoalUnitTypeForStartWorkout:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveWorkoutGoalUnitType (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V211))]global::System.Action<INWorkoutGoalUnitTypeResolutionResult> completion)
		{
			_ResolveWorkoutGoalUnitType (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the type of the workout goal.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveWorkoutGoalUnitType (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V211))]global::System.Action<INWorkoutGoalUnitTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V211.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutGoalUnitTypeForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the workout location.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveWorkoutLocationTypeForStartWorkout:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveWorkoutLocationType (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V212))]global::System.Action<INWorkoutLocationTypeResolutionResult> completion)
		{
			_ResolveWorkoutLocationType (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the workout location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveWorkoutLocationType (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V212))]global::System.Action<INWorkoutLocationTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V212.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutLocationTypeForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the determination of whether a workout is open-ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveIsOpenEndedForStartWorkout:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveIsOpenEnded (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			_ResolveIsOpenEnded (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the determination of whether a workout is open-ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveIsOpenEnded (IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveIsOpenEndedForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INStartWorkoutIntent,System.Action{Intents.INStartWorkoutIntentResponse})")]
		[DynamicDependencyAttribute ("HandleStartWorkout(Intents.INStartWorkoutIntent,System.Action{Intents.INStartWorkoutIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveGoalValue(Intents.INStartWorkoutIntent,System.Action{Intents.INDoubleResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveIsOpenEnded(Intents.INStartWorkoutIntent,System.Action{Intents.INBooleanResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveWorkoutGoalUnitType(Intents.INStartWorkoutIntent,System.Action{Intents.INWorkoutGoalUnitTypeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveWorkoutLocationType(Intents.INStartWorkoutIntent,System.Action{Intents.INWorkoutLocationTypeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveWorkoutName(Intents.INStartWorkoutIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INStartWorkoutIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINStartWorkoutIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINStartWorkoutIntentHandling" /> interface to support all the methods from the INStartWorkoutIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINStartWorkoutIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INStartWorkoutIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INStartWorkoutIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize a workout's starting confirmation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V210.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmStartWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers can call this method to trigger validation of the workout name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveWorkoutName (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V80))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V80.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutNameForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a workout goal.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveGoalValue (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V193))]global::System.Action<INDoubleResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V193.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveGoalValueForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the type of the workout goal.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveWorkoutGoalUnitType (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V211))]global::System.Action<INWorkoutGoalUnitTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V211.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutGoalUnitTypeForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the workout location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveWorkoutLocationType (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V212))]global::System.Action<INWorkoutLocationTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V212.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveWorkoutLocationTypeForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the determination of whether a workout is open-ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveIsOpenEnded (this IINStartWorkoutIntentHandling This, INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V158))]global::System.Action<INBooleanResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V158.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveIsOpenEndedForStartWorkout:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INStartWorkoutIntentHandlingWrapper : BaseWrapper, IINStartWorkoutIntentHandling {
		public INStartWorkoutIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INStartWorkoutIntentHandlingWrapper))]
		static INStartWorkoutIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INStartWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleStartWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleStartWorkout (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V210))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V210.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleStartWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
