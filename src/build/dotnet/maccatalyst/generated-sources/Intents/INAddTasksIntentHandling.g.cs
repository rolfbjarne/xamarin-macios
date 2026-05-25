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
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INAddTasksIntentHandling", WrapperType = typeof (INAddTasksIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleAddTasks", Selector = "handleAddTasks:completion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INAddTasksIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V71) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmAddTasks:completion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INAddTasksIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V71) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTargetTaskList", Selector = "resolveTargetTaskListForAddTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INTaskListResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V72) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTargetTaskList", Selector = "resolveTargetTaskListForAddTasks:completion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INAddTasksTargetTaskListResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V73) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTaskTitles", Selector = "resolveTaskTitlesForAddTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult[]>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V74) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSpatialEventTrigger", Selector = "resolveSpatialEventTriggerForAddTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INSpatialEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V75) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTemporalEventTrigger", Selector = "resolveTemporalEventTriggerForAddTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INTemporalEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V76) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTemporalEventTrigger", Selector = "resolveTemporalEventTriggerForAddTasks:completion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INAddTasksTemporalEventTriggerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V77) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePriority", Selector = "resolvePriorityForAddTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INAddTasksIntent), typeof (global::System.Action<global::Intents.INTaskPriorityResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V78) })]
	public partial interface IINAddTasksIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAddTasksIntentResponse" /> appropriate to the <see cref="T:Intents.INAddTasksIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleAddTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAddTasks (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAddTasksIntentResponse" /> appropriate to the <see cref="T:Intents.INAddTasksIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleAddTasks (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to add the task.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmAddTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to add the task.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the list that will receive added tasks.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTargetTaskListForAddTasks:withCompletion:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTargetTaskList (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V72))]global::System.Action<INTaskListResolutionResult> completion)
		{
			_ResolveTargetTaskList (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the list that will receive added tasks.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTargetTaskList (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V72))]global::System.Action<INTaskListResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V72.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskListForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTargetTaskListForAddTasks:completion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTargetTaskList (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V73))]global::System.Action<INAddTasksTargetTaskListResolutionResult> completionHandler)
		{
			_ResolveTargetTaskList (this, intent, completionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTargetTaskList (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V73))]global::System.Action<INAddTasksTargetTaskListResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskListForAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a task title.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTaskTitlesForAddTasks:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTaskTitles (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V74))]global::System.Action<INSpeakableStringResolutionResult[]> completion)
		{
			_ResolveTaskTitles (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a task title.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTaskTitles (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V74))]global::System.Action<INSpeakableStringResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V74.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskTitlesForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a spatial trigger for a task.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveSpatialEventTriggerForAddTasks:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveSpatialEventTrigger (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			_ResolveSpatialEventTrigger (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a spatial trigger for a task.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveSpatialEventTrigger (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V75.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSpatialEventTriggerForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a temporal trigger for a task.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveTemporalEventTriggerForAddTasks:withCompletion:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTemporalEventTrigger (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			_ResolveTemporalEventTrigger (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a temporal trigger for a task.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTemporalEventTrigger (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTemporalEventTriggerForAddTasks:completion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTemporalEventTrigger (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INAddTasksTemporalEventTriggerResolutionResult> completionHandler)
		{
			_ResolveTemporalEventTrigger (this, intent, completionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTemporalEventTrigger (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INAddTasksTemporalEventTriggerResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V77.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolvePriorityForAddTasks:withCompletion:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePriority (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			_ResolvePriority (this, intent, completion);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePriority (IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePriorityForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INAddTasksIntent,System.Action{Intents.INAddTasksIntentResponse})")]
		[DynamicDependencyAttribute ("HandleAddTasks(Intents.INAddTasksIntent,System.Action{Intents.INAddTasksIntentResponse})")]
		[DynamicDependencyAttribute ("ResolvePriority(Intents.INAddTasksIntent,System.Action{Intents.INTaskPriorityResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveSpatialEventTrigger(Intents.INAddTasksIntent,System.Action{Intents.INSpatialEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTargetTaskList(Intents.INAddTasksIntent,System.Action{Intents.INAddTasksTargetTaskListResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTargetTaskList(Intents.INAddTasksIntent,System.Action{Intents.INTaskListResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTaskTitles(Intents.INAddTasksIntent,System.Action{Intents.INSpeakableStringResolutionResult[]})")]
		[DynamicDependencyAttribute ("ResolveTemporalEventTrigger(Intents.INAddTasksIntent,System.Action{Intents.INAddTasksTemporalEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTemporalEventTrigger(Intents.INAddTasksIntent,System.Action{Intents.INTemporalEventTriggerResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INAddTasksIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINAddTasksIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINAddTasksIntentHandling" /> interface to support all the methods from the INAddTasksIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINAddTasksIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INAddTasksIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INAddTasksIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether local and remote resources are ready to add the task.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of the list that will receive added tasks.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTargetTaskList (Action<INAddTasksTargetTaskListResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTargetTaskList (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V72))]global::System.Action<INTaskListResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V72.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskListForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTargetTaskList (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V73))]global::System.Action<INAddTasksTargetTaskListResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTargetTaskListForAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a task title.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTaskTitles (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V74))]global::System.Action<INSpeakableStringResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V74.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskTitlesForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a spatial trigger for a task.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveSpatialEventTrigger (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V75))]global::System.Action<INSpatialEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V75.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveSpatialEventTriggerForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize resolution of a temporal trigger for a task.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ResolveTemporalEventTrigger (Action<INAddTasksTemporalEventTriggerResolutionResult>)' overload instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTemporalEventTrigger (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INTemporalEventTriggerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTemporalEventTrigger (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INAddTasksTemporalEventTriggerResolutionResult> completionHandler)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V77.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTemporalEventTriggerForAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePriority (this IINAddTasksIntentHandling This, INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<INTaskPriorityResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePriorityForAddTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INAddTasksIntentHandlingWrapper : BaseWrapper, IINAddTasksIntentHandling {
		public INAddTasksIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INAddTasksIntentHandlingWrapper))]
		static INAddTasksIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAddTasksIntentResponse" /> appropriate to the <see cref="T:Intents.INAddTasksIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleAddTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleAddTasks (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
