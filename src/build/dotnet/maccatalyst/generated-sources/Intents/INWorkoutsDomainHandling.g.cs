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
	/// <summary>Interface combining several interfaces related to various workout-related intents.</summary>
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INStartWorkoutIntentHandling, INPauseWorkoutIntentHandling, INEndWorkoutIntentHandling, INCancelWorkoutIntentHandling and INResumeWorkoutIntentHandling' instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INStartWorkoutIntentHandling, INPauseWorkoutIntentHandling, INEndWorkoutIntentHandling, INCancelWorkoutIntentHandling and INResumeWorkoutIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INWorkoutsDomainHandling", WrapperType = typeof (INWorkoutsDomainHandlingWrapper))]
	public partial interface IINWorkoutsDomainHandling : INativeObject, IDisposable, 
		Intents.IINCancelWorkoutIntentHandling
		, Intents.IINEndWorkoutIntentHandling
		, Intents.IINPauseWorkoutIntentHandling
		, Intents.IINResumeWorkoutIntentHandling
		, Intents.IINStartWorkoutIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INWorkoutsDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINWorkoutsDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INWorkoutsDomainHandlingWrapper : BaseWrapper, IINWorkoutsDomainHandling {
		public INWorkoutsDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INWorkoutsDomainHandlingWrapper))]
		static INWorkoutsDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INCancelWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INCancelWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleCancelWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleCancelWorkout (INCancelWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V93))]global::System.Action<INCancelWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V93.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleCancelWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INEndWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INEndWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleEndWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleEndWorkout (INEndWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<INEndWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V109.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleEndWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INPauseWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INPauseWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handlePauseWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandlePauseWorkout (INPauseWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INPauseWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V127.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handlePauseWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INResumeWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INResumeWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleResumeWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleResumeWorkout (INResumeWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V154))]global::System.Action<INResumeWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V154.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleResumeWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartWorkoutIntentResponse" /> appropriate to the <see cref="T:Intents.INStartWorkoutIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleStartWorkout:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleStartWorkout (INStartWorkoutIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V195))]global::System.Action<INStartWorkoutIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V195.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleStartWorkout:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
