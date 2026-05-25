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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerTransitionCoordinator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerTransitionCoordinator", WrapperType = typeof (UIViewControllerTransitionCoordinatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnimateAlongsideTransition", Selector = "animateAlongsideTransition:completion:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>), typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V273), typeof (ObjCRuntime.Trampolines.NIDActionArity1V273) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnimateAlongsideTransitionInView", Selector = "animateAlongsideTransitionInView:animation:completion:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIView), typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>), typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V273), typeof (ObjCRuntime.Trampolines.NIDActionArity1V273) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyWhenInteractionEndsUsingBlock", Selector = "notifyWhenInteractionEndsUsingBlock:", ParameterType = new Type [] { typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V273) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyWhenInteractionChanges", Selector = "notifyWhenInteractionChangesUsingBlock:", ParameterType = new Type [] { typeof (global::System.Action<global::UIKit.IUIViewControllerTransitionCoordinatorContext>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V273) })]
	public partial interface IUIViewControllerTransitionCoordinator : INativeObject, IDisposable, 
		UIKit.IUIViewControllerTransitionCoordinatorContext
	{
		/// <param name="animate">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animate" /> animation simultaneously with the animated view controller transition, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("animateAlongsideTransition:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AnimateAlongsideTransition ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animate">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animate" /> animation simultaneously with the animated view controller transition, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AnimateAlongsideTransition (IUIViewControllerTransitionCoordinator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animate));
			using var block_animate = Trampolines.SDActionArity1V273.CreateBlock (animate);
			BlockLiteral *block_ptr_animate = &block_animate;
			using var block_completion = Trampolines.SDActionArity1V273.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("animateAlongsideTransition:completion:"), (IntPtr) block_ptr_animate, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="view">To be added.</param><param name="animation">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animation" /> animation inside of <paramref name="view" />, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("animateAlongsideTransitionInView:animation:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AnimateAlongsideTransitionInView (UIView view, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="animation">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animation" /> animation inside of <paramref name="view" />, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AnimateAlongsideTransitionInView (IUIViewControllerTransitionCoordinator This, UIView view, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDActionArity1V273.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			using var block_completion = Trampolines.SDActionArity1V273.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("animateAlongsideTransitionInView:animation:completion:"), view__handle__, (IntPtr) block_ptr_animation, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret != 0;
		}
		/// <param name="handler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'NotifyWhenInteractionChanges' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("notifyWhenInteractionEndsUsingBlock:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'NotifyWhenInteractionChanges' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'NotifyWhenInteractionChanges' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NotifyWhenInteractionChanges' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NotifyWhenInteractionEndsUsingBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="handler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'NotifyWhenInteractionChanges' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use 'NotifyWhenInteractionChanges' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'NotifyWhenInteractionChanges' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NotifyWhenInteractionChanges' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _NotifyWhenInteractionEndsUsingBlock (IUIViewControllerTransitionCoordinator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V273.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("notifyWhenInteractionEndsUsingBlock:"), (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
		/// <summary>Registers <paramref name="handler" /> to be called when the transition changes from interactive to non-interactive or vice versa.</summary>
		[global::Foundation.RequiredMember]
		[Export ("notifyWhenInteractionChangesUsingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NotifyWhenInteractionChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Registers <paramref name="handler" /> to be called when the transition changes from interactive to non-interactive or vice versa.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _NotifyWhenInteractionChanges (IUIViewControllerTransitionCoordinator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V273.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("notifyWhenInteractionChangesUsingBlock:"), (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AnimateAlongsideTransition(System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext},System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext})")]
		[DynamicDependencyAttribute ("AnimateAlongsideTransitionInView(UIKit.UIView,System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext},System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext})")]
		[DynamicDependencyAttribute ("NotifyWhenInteractionChanges(System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext})")]
		[DynamicDependencyAttribute ("NotifyWhenInteractionEndsUsingBlock(System.Action{UIKit.IUIViewControllerTransitionCoordinatorContext})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitionCoordinatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerTransitionCoordinator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerTransitionCoordinatorWrapper : BaseWrapper, IUIViewControllerTransitionCoordinator {
		public UIViewControllerTransitionCoordinatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitionCoordinatorWrapper))]
		static UIViewControllerTransitionCoordinatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="animate">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animate" /> animation simultaneously with the animated view controller transition, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animateAlongsideTransition:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AnimateAlongsideTransition ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animate));
			using var block_animate = Trampolines.SDActionArity1V273.CreateBlock (animate);
			BlockLiteral *block_ptr_animate = &block_animate;
			using var block_completion = Trampolines.SDActionArity1V273.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("animateAlongsideTransition:completion:"), (IntPtr) block_ptr_animate, (IntPtr) block_ptr_completion);
			return ret != 0;
		}
		/// <param name="view">To be added.</param><param name="animation">To be added.</param><param name="completion">To be added.</param><summary>Runs the <paramref name="animation" /> animation inside of <paramref name="view" />, and runs <paramref name="completion" /> when it is finished.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animateAlongsideTransitionInView:animation:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AnimateAlongsideTransitionInView (UIView view, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext>? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDActionArity1V273.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			using var block_completion = Trampolines.SDActionArity1V273.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("animateAlongsideTransitionInView:animation:completion:"), view__handle__, (IntPtr) block_ptr_animation, (IntPtr) block_ptr_completion);
			GC.KeepAlive (view);
			return ret != 0;
		}
		/// <param name="handler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'NotifyWhenInteractionChanges' instead.</summary><remarks>To be added.</remarks>
		[Export ("notifyWhenInteractionEndsUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void NotifyWhenInteractionEndsUsingBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V273.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("notifyWhenInteractionEndsUsingBlock:"), (IntPtr) block_ptr_handler);
		}
		/// <summary>Registers <paramref name="handler" /> to be called when the transition changes from interactive to non-interactive or vice versa.</summary>
		[Export ("notifyWhenInteractionChangesUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void NotifyWhenInteractionChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V273))]global::System.Action<IUIViewControllerTransitionCoordinatorContext> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V273.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("notifyWhenInteractionChangesUsingBlock:"), (IntPtr) block_ptr_handler);
		}
		/// <param name="uiTransitionKey">To be added.</param><summary>The UIViewController for the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewControllerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController GetViewControllerForKey (NSString uiTransitionKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionKey__handle__ = uiTransitionKey!.GetNonNullHandle (nameof (uiTransitionKey));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewControllerForKey:"), uiTransitionKey__handle__), false)!;
			GC.KeepAlive (uiTransitionKey);
			return ret!;
		}
		/// <summary>Returns the transform that describes the rotation of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("targetTransform")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGAffineTransform TargetTransform ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("targetTransform"));
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("targetTransform"));
			}
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Gets the transition that is specified by <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView GetTransitionViewControllerForKey (NSString key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForKey:"), key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		/// <summary><see langword="true" /> if the transition is explicitly animated or uses <see cref="F:UIKit.UIModalPresentationStyle.Custom" /> presentation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool IsAnimated {
			[Export ("isAnimated")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnimated"));
				return ret != 0;
			}
		}
		/// <summary>The presentation style whose transition is being modified.</summary><value>Use <see cref="F:UIKit.UIModalPresentationStyle.None" /> if the transition is not a modal presentation or dismissal.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIModalPresentationStyle ret;
				ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationStyle"));
				return ret!;
			}
		}
		/// <summary><see langword="true" /> iff <see cref="UIKit.IUIViewControllerTransitionCoordinatorContext.IsAnimated" /> is <see langword="true" /> and the transition was initiated interactively.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool InitiallyInteractive {
			[Export ("initiallyInteractive")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("initiallyInteractive"));
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the transition is currently interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool IsInteractive {
			[Export ("isInteractive")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInteractive"));
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the interactive transition is ending and the user canceled the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool IsCancelled {
			[Export ("isCancelled")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCancelled"));
				return ret != 0;
			}
		}
		/// <summary>The expected duration, in seconds, of the transition, if it is noninteractive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public double TransitionDuration {
			[Export ("transitionDuration")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("transitionDuration"));
				return ret;
			}
		}
		/// <summary>The percent of completion of a transition when it moves to the noninteractive completion phase.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public nfloat PercentComplete {
			[Export ("percentComplete")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("percentComplete"));
				return ret;
			}
		}
		/// <summary>The completion velocity for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public nfloat CompletionVelocity {
			[Export ("completionVelocity")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("completionVelocity"));
				return ret;
			}
		}
		/// <summary>The UIViewAnimationCurve for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewAnimationCurve ret;
				ret = (UIViewAnimationCurve) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("completionCurve"));
				return ret!;
			}
		}
		/// <summary>The container UIView for the view controller transition animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIView ContainerView {
			[Export ("containerView")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView ret;
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("containerView")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public bool IsInterruptible {
			[Export ("isInterruptible")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInterruptible"));
				return ret != 0;
			}
		}
	}
}
