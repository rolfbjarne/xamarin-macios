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
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerInteractiveTransitioning</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerInteractiveTransitioning", WrapperType = typeof (UIViewControllerInteractiveTransitioningWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartInteractiveTransition", Selector = "startInteractiveTransition:", ParameterType = new Type [] { typeof (IUIViewControllerContextTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CompletionSpeed", Selector = "completionSpeed", PropertyType = typeof (NFloat), GetterSelector = "completionSpeed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CompletionCurve", Selector = "completionCurve", PropertyType = typeof (UIViewAnimationCurve), GetterSelector = "completionCurve", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WantsInteractiveStart", Selector = "wantsInteractiveStart", PropertyType = typeof (bool), GetterSelector = "wantsInteractiveStart", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIViewControllerInteractiveTransitioning : INativeObject, IDisposable
	{
		/// <param name="transitionContext">To be added.</param><summary>Sets up and begins a view controller interactive transition.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartInteractiveTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="transitionContext">To be added.</param><summary>Sets up and begins a view controller interactive transition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartInteractiveTransition (IUIViewControllerInteractiveTransitioning This, IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("startInteractiveTransition:"), transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (transitionContext);
		}
		[DynamicDependencyAttribute ("CompletionCurve")]
		[DynamicDependencyAttribute ("CompletionSpeed")]
		[DynamicDependencyAttribute ("StartInteractiveTransition(UIKit.IUIViewControllerContextTransitioning)")]
		[DynamicDependencyAttribute ("WantsInteractiveStart")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerInteractiveTransitioningWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerInteractiveTransitioning ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns the overall relative speed of an animation. The default value is 1.0.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nfloat CompletionSpeed {
			[Export ("completionSpeed")]
			get {
				return _GetCompletionSpeed (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetCompletionSpeed (IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("completionSpeed"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the completion curve, which controls the speed of the animation as it progresses.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			get {
				return _GetCompletionCurve (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewAnimationCurve _GetCompletionCurve (IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewAnimationCurve ret;
			ret = (UIViewAnimationCurve) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("completionCurve"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets whether the transition is interactive.</summary><returns>The default value is <see langword="true" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual bool WantsInteractiveStart {
			[Export ("wantsInteractiveStart")]
			get {
				return _GetWantsInteractiveStart (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetWantsInteractiveStart (IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("wantsInteractiveStart"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIViewControllerInteractiveTransitioning" /> interface to support all the methods from the UIViewControllerInteractiveTransitioning protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIViewControllerInteractiveTransitioning" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIViewControllerInteractiveTransitioning protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIViewControllerInteractiveTransitioning_Extensions {
		/// <summary>Returns the overall relative speed of an animation. The default value is 1.0.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetCompletionSpeed (this IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("completionSpeed"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the completion curve, which controls the speed of the animation as it progresses.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewAnimationCurve GetCompletionCurve (this IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewAnimationCurve ret;
			ret = (UIViewAnimationCurve) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("completionCurve"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets whether the transition is interactive.</summary><returns>The default value is <see langword="true" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetWantsInteractiveStart (this IUIViewControllerInteractiveTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("wantsInteractiveStart"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerInteractiveTransitioningWrapper : BaseWrapper, IUIViewControllerInteractiveTransitioning {
		public UIViewControllerInteractiveTransitioningWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerInteractiveTransitioningWrapper))]
		static UIViewControllerInteractiveTransitioningWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="transitionContext">To be added.</param><summary>Sets up and begins a view controller interactive transition.</summary><remarks>To be added.</remarks>
		[Export ("startInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartInteractiveTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startInteractiveTransition:"), transitionContext__handle__);
			GC.KeepAlive (transitionContext);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIViewControllerInteractiveTransitioning" /> (for the protocol <c>UIViewControllerInteractiveTransitioning</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIViewControllerInteractiveTransitioning" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIViewControllerInteractiveTransitioning", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIViewControllerInteractiveTransitioning : NSObject, IUIViewControllerInteractiveTransitioning {
		/// <summary>Creates a new <see cref="UIViewControllerInteractiveTransitioning" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIViewControllerInteractiveTransitioning () : base (NSObjectFlag.Empty)
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
		protected UIViewControllerInteractiveTransitioning (NSObjectFlag t) : base (t)
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
		protected internal UIViewControllerInteractiveTransitioning (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="transitionContext">To be added.</param><summary>Sets up and begins a view controller interactive transition.</summary><remarks>To be added.</remarks>
		[Export ("startInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartInteractiveTransition (IUIViewControllerContextTransitioning transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the completion curve, which controls the speed of the animation as it progresses.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns the overall relative speed of an animation. The default value is 1.0.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CompletionSpeed {
			[Export ("completionSpeed")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets whether the transition is interactive.</summary><returns>The default value is <see langword="true" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool WantsInteractiveStart {
			[Export ("wantsInteractiveStart")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIViewControllerInteractiveTransitioning */
}
