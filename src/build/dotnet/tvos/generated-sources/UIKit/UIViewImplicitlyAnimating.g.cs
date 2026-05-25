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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface that defines methods for animations that can be modified while they are running.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewImplicitlyAnimating", WrapperType = typeof (UIViewImplicitlyAnimatingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddAnimations", Selector = "addAnimations:delayFactor:", ParameterType = new Type [] { typeof (Action), typeof (NFloat) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction), null })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddAnimations", Selector = "addAnimations:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddCompletion", Selector = "addCompletion:", ParameterType = new Type [] { typeof (global::System.Action<global::UIKit.UIViewAnimatingPosition>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V87) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContinueAnimation", Selector = "continueAnimationWithTimingParameters:durationFactor:", ParameterType = new Type [] { typeof (IUITimingCurveProvider), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIViewImplicitlyAnimating : INativeObject, IDisposable, 
		UIKit.IUIViewAnimating
	{
		/// <param name="animation">To be added.</param><param name="delayFactor">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("addAnimations:delayFactor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation, nfloat delayFactor)
		{
			_AddAnimations (this, animation, delayFactor);
		}
		/// <param name="animation">To be added.</param><param name="delayFactor">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddAnimations (IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation, nfloat delayFactor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("addAnimations:delayFactor:"), (IntPtr) block_ptr_animation, delayFactor);
			GC.KeepAlive (This);
		}
		/// <param name="animation">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("addAnimations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			_AddAnimations (this, animation);
		}
		/// <param name="animation">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddAnimations (IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addAnimations:"), (IntPtr) block_ptr_animation);
			GC.KeepAlive (This);
		}
		/// <param name="completion">To be added.</param><summary>Adds the <paramref name="completion" /> to run when the animation(s) end.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("addCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V87))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			_AddCompletion (this, completion);
		}
		/// <param name="completion">To be added.</param><summary>Adds the <paramref name="completion" /> to run when the animation(s) end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddCompletion (IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V87))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V87.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		/// <param name="parameters">New timing information.</param><param name="durationFactor">A multiplier applied to the animation's original duration.</param><summary>Changes the timing of the animation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("continueAnimationWithTimingParameters:durationFactor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueAnimation (IUITimingCurveProvider? parameters, nfloat durationFactor)
		{
			_ContinueAnimation (this, parameters, durationFactor);
		}
		/// <param name="parameters">New timing information.</param><param name="durationFactor">A multiplier applied to the animation's original duration.</param><summary>Changes the timing of the animation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContinueAnimation (IUIViewImplicitlyAnimating This, IUITimingCurveProvider? parameters, nfloat durationFactor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parameters__handle__ = parameters.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("continueAnimationWithTimingParameters:durationFactor:"), parameters__handle__, durationFactor);
			GC.KeepAlive (This);
			GC.KeepAlive (parameters);
		}
		[DynamicDependencyAttribute ("AddAnimations(System.Action,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("AddAnimations(System.Action)")]
		[DynamicDependencyAttribute ("AddCompletion(System.Action{UIKit.UIViewAnimatingPosition})")]
		[DynamicDependencyAttribute ("ContinueAnimation(UIKit.IUITimingCurveProvider,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewImplicitlyAnimatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewImplicitlyAnimating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIViewImplicitlyAnimating" /> interface to support all the methods from the UIViewImplicitlyAnimating protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIViewImplicitlyAnimating" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIViewImplicitlyAnimating protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIViewImplicitlyAnimating_Extensions {
		/// <param name="animation">To be added.</param><param name="delayFactor">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddAnimations (this IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation, nfloat delayFactor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("addAnimations:delayFactor:"), (IntPtr) block_ptr_animation, delayFactor);
			GC.KeepAlive (This);
		}
		/// <param name="animation">To be added.</param><summary>Appends the specified <paramref name="animation" /><see cref="T:System.Action" /> to the callback list.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddAnimations (this IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addAnimations:"), (IntPtr) block_ptr_animation);
			GC.KeepAlive (This);
		}
		/// <param name="completion">To be added.</param><summary>Adds the <paramref name="completion" /> to run when the animation(s) end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddCompletion (this IUIViewImplicitlyAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V87))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V87.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		/// <param name="parameters">New timing information.</param><param name="durationFactor">A multiplier applied to the animation's original duration.</param><summary>Changes the timing of the animation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContinueAnimation (this IUIViewImplicitlyAnimating This, IUITimingCurveProvider? parameters, nfloat durationFactor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parameters__handle__ = parameters.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("continueAnimationWithTimingParameters:durationFactor:"), parameters__handle__, durationFactor);
			GC.KeepAlive (This);
			GC.KeepAlive (parameters);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewImplicitlyAnimatingWrapper : BaseWrapper, IUIViewImplicitlyAnimating {
		public UIViewImplicitlyAnimatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewImplicitlyAnimatingWrapper))]
		static UIViewImplicitlyAnimatingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Begins the animation.</summary><remarks>To be added.</remarks>
		[Export ("startAnimation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartAnimation ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startAnimation"));
		}
		/// <param name="delay">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("startAnimationAfterDelay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartAnimation (double delay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("startAnimationAfterDelay:"), delay);
		}
		/// <summary>Pauses the animation.</summary><remarks>To be added.</remarks>
		[Export ("pauseAnimation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PauseAnimation ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pauseAnimation"));
		}
		/// <param name="withoutFinishing">To be added.</param><summary>Stops the animation at the current position.</summary><remarks>To be added.</remarks>
		[Export ("stopAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopAnimation (bool withoutFinishing)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("stopAnimation:"), withoutFinishing ? (byte) 1 : (byte) 0);
		}
		/// <param name="finalPosition">To be added.</param><summary>Finishes the animation. Must be preceded by call to <see cref="M:UIKit.UIViewPropertyAnimator.CreateRunningPropertyAnimator(System.Double,System.Double,UIKit.UIViewAnimationOptions,System.Action,System.Action{UIKit.UIViewAnimatingPosition})" />.</summary><remarks>To be added.</remarks>
		[Export ("finishAnimationAtPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishAnimation (UIViewAnimatingPosition finalPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("finishAnimationAtPosition:"), (IntPtr) (long) finalPosition);
		}
		/// <summary>The current <see cref="T:UIKit.UIViewAnimatingState" /> of the animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIViewAnimatingState State {
			[Export ("state")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewAnimatingState ret;
				ret = (UIViewAnimatingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				return ret!;
			}
		}
		/// <summary>Whether the animation is currently running.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool Running {
			[Export ("isRunning")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRunning"));
				return ret != 0;
			}
		}
		/// <summary>Gets or sets the direction of the animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool Reversed {
			[Export ("isReversed")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReversed"));
				return ret != 0;
			}
			[Export ("setReversed:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setReversed:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets or sets the percentage of the property's animation completion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public nfloat FractionComplete {
			[Export ("fractionComplete")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fractionComplete"));
				return ret;
			}
			[Export ("setFractionComplete:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFractionComplete:"), value);
			}
		}
	}
}
