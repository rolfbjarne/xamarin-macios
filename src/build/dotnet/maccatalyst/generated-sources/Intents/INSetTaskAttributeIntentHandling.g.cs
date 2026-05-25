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
	[Protocol (Name = "INSetTaskAttributeIntentHandling", WrapperType = typeof (INSetTaskAttributeIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSetTaskAttribute", Selector = "handleSetTaskAttribute:completion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INSetTaskAttributeIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V126) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSetTaskAttribute:completion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INSetTaskAttributeIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V126) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTargetTask", Selector = "resolveTargetTaskForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INTaskResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V185) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTaskTitle", Selector = "resolveTaskTitleForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V66) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveStatus", Selector = "resolveStatusForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INTaskStatusResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V167) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePriority", Selector = "resolvePriorityForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INTaskPriorityResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V78) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSpatialEventTrigger", Selector = "resolveSpatialEventTriggerForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INSpatialEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V75) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTemporalEventTrigger", Selector = "resolveTemporalEventTriggerForSetTaskAttribute:withCompletion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INTemporalEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V76) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTemporalEventTrigger", Selector = "resolveTemporalEventTriggerForSetTaskAttribute:completion:", ParameterType = new Type [] { typeof (Intents.INSetTaskAttributeIntent), typeof (global::System.Action<global::Intents.INSetTaskAttributeTemporalEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V186) })]
	public partial interface IINSetTaskAttributeIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetTaskAttributeIntentResponse" /> appropriate to the <see cref="T:Intents.INSetTaskAttributeIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSetTaskAttribute:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSetTaskAttribute (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetTaskAttributeIntentResponse" /> appropriate to the <see cref="T:Intents.INSetTaskAttributeIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSetTaskAttribute (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to update the attributes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSetTaskAttribute:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to update the attributes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the task to update.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTargetTaskForSetTaskAttribute:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTargetTask (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V185))]global::System.Action<INTaskResolutionResult> completion)
		{
			_ResolveTargetTask (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the task to update.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTargetTask (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V185))]global::System.Action<INTaskResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V185.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTaskTitleForSetTaskAttribute:withCompletion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTaskTitle (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveTaskTitle (this, intent, completion);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTaskTitle (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskTitleForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the task status.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveStatusForSetTaskAttribute:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveStatus (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INTaskStatusResolutionResult> completion)
		{
			_ResolveStatus (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the task status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveStatus (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INTaskStatusResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V167.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveStatusForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolvePriorityForSetTaskAttribute:withCompletion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePriority (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			_ResolvePriority (this, intent, completion);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePriority (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePriorityForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a spatial event trigger.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveSpatialEventTriggerForSetTaskAttribute:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveSpatialEventTrigger (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			_ResolveSpatialEventTrigger (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a spatial event trigger.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveSpatialEventTrigger (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V75.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSpatialEventTriggerForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customise resolution of the temporal trigger.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTemporalEventTriggerForSetTaskAttribute:withCompletion:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTemporalEventTrigger (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			_ResolveTemporalEventTrigger (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customise resolution of the temporal trigger.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTemporalEventTrigger (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTemporalEventTriggerForSetTaskAttribute:completion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTemporalEventTrigger (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V186))]global::System.Action<INSetTaskAttributeTemporalEventTriggerResolutionResult> completionHandler)
		{
			_ResolveTemporalEventTrigger (this, intent, completionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTemporalEventTrigger (IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V186))]global::System.Action<INSetTaskAttributeTemporalEventTriggerResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V186.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSetTaskAttributeIntent,System.Action{Intents.INSetTaskAttributeIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSetTaskAttribute(Intents.INSetTaskAttributeIntent,System.Action{Intents.INSetTaskAttributeIntentResponse})")]
		[DynamicDependencyAttribute ("ResolvePriority(Intents.INSetTaskAttributeIntent,System.Action{Intents.INTaskPriorityResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveSpatialEventTrigger(Intents.INSetTaskAttributeIntent,System.Action{Intents.INSpatialEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveStatus(Intents.INSetTaskAttributeIntent,System.Action{Intents.INTaskStatusResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTargetTask(Intents.INSetTaskAttributeIntent,System.Action{Intents.INTaskResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTaskTitle(Intents.INSetTaskAttributeIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTemporalEventTrigger(Intents.INSetTaskAttributeIntent,System.Action{Intents.INSetTaskAttributeTemporalEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTemporalEventTrigger(Intents.INSetTaskAttributeIntent,System.Action{Intents.INTemporalEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetTaskAttributeIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSetTaskAttributeIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSetTaskAttributeIntentHandling" /> interface to support all the methods from the INSetTaskAttributeIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSetTaskAttributeIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSetTaskAttributeIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSetTaskAttributeIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to update the attributes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the task to update.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTargetTask (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V185))]global::System.Action<INTaskResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V185.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTaskTitle (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskTitleForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of the task status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveStatus (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V167))]global::System.Action<INTaskStatusResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V167.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveStatusForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePriority (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePriorityForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the resolution of a spatial event trigger.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveSpatialEventTrigger (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V75.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSpatialEventTriggerForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customise resolution of the temporal trigger.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (INSetTaskAttributeIntent Action<INSetTaskAttributeTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTemporalEventTrigger (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForSetTaskAttribute:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTemporalEventTrigger (this IINSetTaskAttributeIntentHandling This, INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V186))]global::System.Action<INSetTaskAttributeTemporalEventTriggerResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V186.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSetTaskAttributeIntentHandlingWrapper : BaseWrapper, IINSetTaskAttributeIntentHandling {
		public INSetTaskAttributeIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSetTaskAttributeIntentHandlingWrapper))]
		static INSetTaskAttributeIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetTaskAttributeIntentResponse" /> appropriate to the <see cref="T:Intents.INSetTaskAttributeIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetTaskAttribute:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetTaskAttribute (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
