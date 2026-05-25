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
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerAnimatedTransitioning</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerAnimatedTransitioning", WrapperType = typeof (UIViewControllerAnimatedTransitioningWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TransitionDuration", Selector = "transitionDuration:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (IUIViewControllerContextTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnimateTransition", Selector = "animateTransition:", ParameterType = new Type [] { typeof (IUIViewControllerContextTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInterruptibleAnimator", Selector = "interruptibleAnimatorForTransition:", ReturnType = typeof (IUIViewImplicitlyAnimating), ParameterType = new Type [] { typeof (IUIViewControllerContextTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationEnded", Selector = "animationEnded:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIViewControllerAnimatedTransitioning : INativeObject, IDisposable
	{
		/// <param name="transitionContext">To be added.</param><summary>The duration, in seconds, of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("transitionDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TransitionDuration (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionContext">To be added.</param><summary>The duration, in seconds, of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _TransitionDuration (IUIViewControllerAnimatedTransitioning This, IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("transitionDuration:"), transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (transitionContext);
			return ret!;
		}
		/// <param name="transitionContext">To be added.</param><summary>Animate the transition with the animator object.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("animateTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimateTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionContext">To be added.</param><summary>Animate the transition with the animator object.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnimateTransition (IUIViewControllerAnimatedTransitioning This, IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animateTransition:"), transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (transitionContext);
		}
		/// <param name="transitionContext">To be added.</param><summary>Gets the <see cref="T:UIKit.IUIViewControllerAnimatedTransitioning" /> used for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("interruptibleAnimatorForTransition:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewImplicitlyAnimating GetInterruptibleAnimator (IUIViewControllerContextTransitioning transitionContext)
		{
			return _GetInterruptibleAnimator (this, transitionContext);
		}
		/// <param name="transitionContext">To be added.</param><summary>Gets the <see cref="T:UIKit.IUIViewControllerAnimatedTransitioning" /> used for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewImplicitlyAnimating _GetInterruptibleAnimator (IUIViewControllerAnimatedTransitioning This, IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			IUIViewImplicitlyAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIViewImplicitlyAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interruptibleAnimatorForTransition:"), transitionContext__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (transitionContext);
			return ret!;
		}
		/// <param name="transitionCompleted">To be added.</param><summary>Indicates that the animation has ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationEnded (bool transitionCompleted)
		{
			_AnimationEnded (this, transitionCompleted);
		}
		/// <param name="transitionCompleted">To be added.</param><summary>Indicates that the animation has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnimationEnded (IUIViewControllerAnimatedTransitioning This, bool transitionCompleted)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("animationEnded:"), transitionCompleted ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AnimateTransition(UIKit.IUIViewControllerContextTransitioning)")]
		[DynamicDependencyAttribute ("AnimationEnded(System.Boolean)")]
		[DynamicDependencyAttribute ("GetInterruptibleAnimator(UIKit.IUIViewControllerContextTransitioning)")]
		[DynamicDependencyAttribute ("TransitionDuration(UIKit.IUIViewControllerContextTransitioning)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerAnimatedTransitioningWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerAnimatedTransitioning ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIViewControllerAnimatedTransitioning" /> interface to support all the methods from the UIViewControllerAnimatedTransitioning protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIViewControllerAnimatedTransitioning" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIViewControllerAnimatedTransitioning protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIViewControllerAnimatedTransitioning_Extensions {
		/// <param name="transitionContext">To be added.</param><summary>Gets the <see cref="T:UIKit.IUIViewControllerAnimatedTransitioning" /> used for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewImplicitlyAnimating GetInterruptibleAnimator (this IUIViewControllerAnimatedTransitioning This, IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			IUIViewImplicitlyAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIViewImplicitlyAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interruptibleAnimatorForTransition:"), transitionContext__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (transitionContext);
			return ret!;
		}
		/// <param name="transitionCompleted">To be added.</param><summary>Indicates that the animation has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AnimationEnded (this IUIViewControllerAnimatedTransitioning This, bool transitionCompleted)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("animationEnded:"), transitionCompleted ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerAnimatedTransitioningWrapper : BaseWrapper, IUIViewControllerAnimatedTransitioning {
		public UIViewControllerAnimatedTransitioningWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerAnimatedTransitioningWrapper))]
		static UIViewControllerAnimatedTransitioningWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="transitionContext">To be added.</param><summary>The duration, in seconds, of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("transitionDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double TransitionDuration (IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("transitionDuration:"), transitionContext__handle__);
			GC.KeepAlive (transitionContext);
			return ret!;
		}
		/// <param name="transitionContext">To be added.</param><summary>Animate the transition with the animator object.</summary><remarks>To be added.</remarks>
		[Export ("animateTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AnimateTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("animateTransition:"), transitionContext__handle__);
			GC.KeepAlive (transitionContext);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIViewControllerAnimatedTransitioning" /> (for the protocol <c>UIViewControllerAnimatedTransitioning</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIViewControllerAnimatedTransitioning" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIViewControllerAnimatedTransitioning", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIViewControllerAnimatedTransitioning : NSObject, IUIViewControllerAnimatedTransitioning {
		/// <summary>Creates a new <see cref="UIViewControllerAnimatedTransitioning" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIViewControllerAnimatedTransitioning () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UIViewControllerAnimatedTransitioning (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIViewControllerAnimatedTransitioning (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="transitionContext">To be added.</param><summary>Animate the transition with the animator object.</summary><remarks>To be added.</remarks>
		[Export ("animateTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimateTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionCompleted">To be added.</param><summary>Indicates that the animation has ended.</summary><remarks>To be added.</remarks>
		[Export ("animationEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationEnded (bool transitionCompleted)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionContext">To be added.</param><summary>Gets the <see cref="T:UIKit.IUIViewControllerAnimatedTransitioning" /> used for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("interruptibleAnimatorForTransition:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewImplicitlyAnimating GetInterruptibleAnimator (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionContext">To be added.</param><summary>The duration, in seconds, of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("transitionDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TransitionDuration (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIViewControllerAnimatedTransitioning */
}
