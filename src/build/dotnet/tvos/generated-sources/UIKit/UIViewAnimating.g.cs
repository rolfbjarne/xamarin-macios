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
	/// <summary>Interface defining methods for custom animator objects.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewAnimating", WrapperType = typeof (UIViewAnimatingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartAnimation", Selector = "startAnimation")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartAnimation", Selector = "startAnimationAfterDelay:", ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PauseAnimation", Selector = "pauseAnimation")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopAnimation", Selector = "stopAnimation:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishAnimation", Selector = "finishAnimationAtPosition:", ParameterType = new Type [] { typeof (UIViewAnimatingPosition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "State", Selector = "state", PropertyType = typeof (UIViewAnimatingState), GetterSelector = "state", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Running", Selector = "running", PropertyType = typeof (bool), GetterSelector = "isRunning", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Reversed", Selector = "reversed", PropertyType = typeof (bool), GetterSelector = "isReversed", SetterSelector = "setReversed:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FractionComplete", Selector = "fractionComplete", PropertyType = typeof (NFloat), GetterSelector = "fractionComplete", SetterSelector = "setFractionComplete:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIViewAnimating : INativeObject, IDisposable
	{
		/// <summary>Begins the animation.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startAnimation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartAnimation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Begins the animation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartAnimation (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("startAnimation"));
			GC.KeepAlive (This);
		}
		/// <param name="delay">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startAnimationAfterDelay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartAnimation (double delay)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="delay">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartAnimation (IUIViewAnimating This, double delay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("startAnimationAfterDelay:"), delay);
			GC.KeepAlive (This);
		}
		/// <summary>Pauses the animation.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pauseAnimation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAnimation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Pauses the animation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PauseAnimation (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("pauseAnimation"));
			GC.KeepAlive (This);
		}
		/// <param name="withoutFinishing">To be added.</param><summary>Stops the animation at the current position.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("stopAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopAnimation (bool withoutFinishing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="withoutFinishing">To be added.</param><summary>Stops the animation at the current position.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopAnimation (IUIViewAnimating This, bool withoutFinishing)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("stopAnimation:"), withoutFinishing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="finalPosition">To be added.</param><summary>Finishes the animation. Must be preceded by call to <see cref="M:UIKit.UIViewPropertyAnimator.CreateRunningPropertyAnimator(System.Double,System.Double,UIKit.UIViewAnimationOptions,System.Action,System.Action{UIKit.UIViewAnimatingPosition})" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishAnimationAtPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishAnimation (UIViewAnimatingPosition finalPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="finalPosition">To be added.</param><summary>Finishes the animation. Must be preceded by call to <see cref="M:UIKit.UIViewPropertyAnimator.CreateRunningPropertyAnimator(System.Double,System.Double,UIKit.UIViewAnimationOptions,System.Action,System.Action{UIKit.UIViewAnimatingPosition})" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishAnimation (IUIViewAnimating This, UIViewAnimatingPosition finalPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("finishAnimationAtPosition:"), (IntPtr) (long) finalPosition);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("FinishAnimation(UIKit.UIViewAnimatingPosition)")]
		[DynamicDependencyAttribute ("FractionComplete")]
		[DynamicDependencyAttribute ("PauseAnimation()")]
		[DynamicDependencyAttribute ("Reversed")]
		[DynamicDependencyAttribute ("Running")]
		[DynamicDependencyAttribute ("StartAnimation()")]
		[DynamicDependencyAttribute ("StartAnimation(System.Double)")]
		[DynamicDependencyAttribute ("State")]
		[DynamicDependencyAttribute ("StopAnimation(System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewAnimatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewAnimating ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The current <see cref="T:UIKit.UIViewAnimatingState" /> of the animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIViewAnimatingState State {
			[Export ("state")]
			get {
				return _GetState (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewAnimatingState _GetState (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewAnimatingState ret;
			ret = (UIViewAnimatingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("state"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Whether the animation is currently running.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Running {
			[Export ("isRunning")]
			get {
				return _GetRunning (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRunning (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRunning"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets or sets the direction of the animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Reversed {
			[Export ("isReversed")]
			get {
				return _GetReversed (this);
			}
			[Export ("setReversed:")]
			set {
				_SetReversed (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReversed (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReversed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReversed (IUIViewAnimating This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setReversed:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the percentage of the property's animation completion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat FractionComplete {
			[Export ("fractionComplete")]
			get {
				return _GetFractionComplete (this);
			}
			[Export ("setFractionComplete:")]
			set {
				_SetFractionComplete (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetFractionComplete (IUIViewAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("fractionComplete"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFractionComplete (IUIViewAnimating This, nfloat value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setFractionComplete:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewAnimatingWrapper : BaseWrapper, IUIViewAnimating {
		public UIViewAnimatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewAnimatingWrapper))]
		static UIViewAnimatingWrapper ()
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
		public UIViewAnimatingState State {
			[Export ("state")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewAnimatingState ret;
				ret = (UIViewAnimatingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				return ret!;
			}
		}
		/// <summary>Whether the animation is currently running.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Running {
			[Export ("isRunning")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRunning"));
				return ret != 0;
			}
		}
		/// <summary>Gets or sets the direction of the animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Reversed {
			[Export ("isReversed")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReversed"));
				return ret != 0;
			}
			[Export ("setReversed:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setReversed:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets or sets the percentage of the property's animation completion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat FractionComplete {
			[Export ("fractionComplete")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fractionComplete"));
				return ret;
			}
			[Export ("setFractionComplete:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFractionComplete:"), value);
			}
		}
	}
}
