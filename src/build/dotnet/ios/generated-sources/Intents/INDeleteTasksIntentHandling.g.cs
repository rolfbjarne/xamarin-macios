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
	/// <summary>This interface represents the Objective-C protocol <c>INDeleteTasksIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[Protocol (Name = "INDeleteTasksIntentHandling", WrapperType = typeof (INDeleteTasksIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleDeleteTasks", Selector = "handleDeleteTasks:completion:", ParameterType = new Type [] { typeof (Intents.INDeleteTasksIntent), typeof (global::System.Action<global::Intents.INDeleteTasksIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V119) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmDeleteTasks:completion:", ParameterType = new Type [] { typeof (Intents.INDeleteTasksIntent), typeof (global::System.Action<global::Intents.INDeleteTasksIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V119) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTaskList", Selector = "resolveTaskListForDeleteTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INDeleteTasksIntent), typeof (global::System.Action<global::Intents.INDeleteTasksTaskListResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V120) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveTasks", Selector = "resolveTasksForDeleteTasks:withCompletion:", ParameterType = new Type [] { typeof (Intents.INDeleteTasksIntent), typeof (global::System.Action<global::Intents.INDeleteTasksTaskResolutionResult[]>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V121) })]
	public partial interface IINDeleteTasksIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleDeleteTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleDeleteTasks (INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleDeleteTasks (IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V119.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleDeleteTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmDeleteTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V119.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmDeleteTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTaskListForDeleteTasks:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTaskList (INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INDeleteTasksTaskListResolutionResult> completion)
		{
			_ResolveTaskList (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTaskList (IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INDeleteTasksTaskListResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskListForDeleteTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveTasksForDeleteTasks:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveTasks (INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INDeleteTasksTaskResolutionResult[]> completion)
		{
			_ResolveTasks (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveTasks (IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INDeleteTasksTaskResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTasksForDeleteTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INDeleteTasksIntent,System.Action{Intents.INDeleteTasksIntentResponse})")]
		[DynamicDependencyAttribute ("HandleDeleteTasks(Intents.INDeleteTasksIntent,System.Action{Intents.INDeleteTasksIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveTaskList(Intents.INDeleteTasksIntent,System.Action{Intents.INDeleteTasksTaskListResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveTasks(Intents.INDeleteTasksIntent,System.Action{Intents.INDeleteTasksTaskResolutionResult[]})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INDeleteTasksIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINDeleteTasksIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINDeleteTasksIntentHandling" /> interface to support all the methods from the INDeleteTasksIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINDeleteTasksIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INDeleteTasksIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INDeleteTasksIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V119.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmDeleteTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTaskList (this IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INDeleteTasksTaskListResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTaskListForDeleteTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveTasks (this IINDeleteTasksIntentHandling This, INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INDeleteTasksTaskResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveTasksForDeleteTasks:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INDeleteTasksIntentHandlingWrapper : BaseWrapper, IINDeleteTasksIntentHandling {
		public INDeleteTasksIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INDeleteTasksIntentHandlingWrapper))]
		static INDeleteTasksIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleDeleteTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleDeleteTasks (INDeleteTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V119))]global::System.Action<INDeleteTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V119.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleDeleteTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
