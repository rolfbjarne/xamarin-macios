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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVPlayerViewControllerAnimationCoordinator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVPlayerViewControllerAnimationCoordinator", WrapperType = typeof (AVPlayerViewControllerAnimationCoordinatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddCoordinatedAnimations", Selector = "addCoordinatedAnimations:completion:", ParameterType = new Type [] { typeof (Action), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction), typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	public partial interface IAVPlayerViewControllerAnimationCoordinator : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("addCoordinatedAnimations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCoordinatedAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddCoordinatedAnimations (IAVPlayerViewControllerAnimationCoordinator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addCoordinatedAnimations:completion:"), (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddCoordinatedAnimations(System.Action,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewControllerAnimationCoordinatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPlayerViewControllerAnimationCoordinator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPlayerViewControllerAnimationCoordinatorWrapper : BaseWrapper, IAVPlayerViewControllerAnimationCoordinator {
		public AVPlayerViewControllerAnimationCoordinatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewControllerAnimationCoordinatorWrapper))]
		static AVPlayerViewControllerAnimationCoordinatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("addCoordinatedAnimations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddCoordinatedAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addCoordinatedAnimations:completion:"), (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
		}
	}
}
