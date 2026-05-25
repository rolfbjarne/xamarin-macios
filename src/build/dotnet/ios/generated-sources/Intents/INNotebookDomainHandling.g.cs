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
	/// <summary>Composite interface for adopting all of lists and notes protocols.</summary>
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INCreateNoteIntentHandling, INAppendToNoteIntentHandling, INAddTasksIntentHandling, INCreateTaskListIntentHandling, INSetTaskAttributeIntentHandling and INSearchForNotebookItemsIntentHandling' instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INCreateNoteIntentHandling, INAppendToNoteIntentHandling, INAddTasksIntentHandling, INCreateTaskListIntentHandling, INSetTaskAttributeIntentHandling and INSearchForNotebookItemsIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INNotebookDomainHandling", WrapperType = typeof (INNotebookDomainHandlingWrapper))]
	public partial interface IINNotebookDomainHandling : INativeObject, IDisposable, 
		Intents.IINAddTasksIntentHandling
		, Intents.IINAppendToNoteIntentHandling
		, Intents.IINCreateNoteIntentHandling
		, Intents.IINCreateTaskListIntentHandling
		, Intents.IINSearchForNotebookItemsIntentHandling
		, Intents.IINSetTaskAttributeIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INNotebookDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINNotebookDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INNotebookDomainHandlingWrapper : BaseWrapper, IINNotebookDomainHandling {
		public INNotebookDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INNotebookDomainHandlingWrapper))]
		static INNotebookDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAddTasksIntentResponse" /> appropriate to the <see cref="T:Intents.INAddTasksIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleAddTasks:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleAddTasks (INAddTasksIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V85))]global::System.Action<INAddTasksIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V85.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleAddTasks:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAppendToNoteIntentResponse" /> appropriate to the <see cref="T:Intents.INAppendToNoteIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleAppendToNote:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleAppendToNote (INAppendToNoteIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V94))]global::System.Action<INAppendToNoteIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V94.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleAppendToNote:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INCreateNoteIntentResponse" /> appropriate to the <see cref="T:Intents.INCreateNoteIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleCreateNote:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleCreateNote (INCreateNoteIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V117))]global::System.Action<INCreateNoteIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V117.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleCreateNote:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INAddTasksIntentResponse" /> appropriate to the <see cref="T:Intents.INAddTasksIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleCreateTaskList:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleCreateTaskList (INCreateTaskListIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V118))]global::System.Action<INCreateTaskListIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V118.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleCreateTaskList:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchForNotebookItemsIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchForNotebookItemsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSearchForNotebookItems:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearchForNotebookItems (INSearchForNotebookItemsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INSearchForNotebookItemsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V140.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchForNotebookItems:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetTaskAttributeIntentResponse" /> appropriate to the <see cref="T:Intents.INSetTaskAttributeIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetTaskAttribute:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetTaskAttribute (INSetTaskAttributeIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V141))]global::System.Action<INSetTaskAttributeIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V141.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetTaskAttribute:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
