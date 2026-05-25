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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSAnimationDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAnimationDelegate", WrapperType = typeof (NSAnimationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationShouldStart", Selector = "animationShouldStart:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSAnimation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidStop", Selector = "animationDidStop:", ParameterType = new Type [] { typeof (NSAnimation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidEnd", Selector = "animationDidEnd:", ParameterType = new Type [] { typeof (NSAnimation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ComputeAnimationCurve", Selector = "animation:valueForProgress:", ReturnType = typeof (float), ParameterType = new Type [] { typeof (NSAnimation), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidReachProgressMark", Selector = "animation:didReachProgressMark:", ParameterType = new Type [] { typeof (NSAnimation), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSAnimationDelegate : INativeObject, IDisposable
	{
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationShouldStart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AnimationShouldStart (NSAnimation animation)
		{
			return _AnimationShouldStart (this, animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AnimationShouldStart (INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationShouldStart:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
			return ret != 0;
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationDidStop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidStop (NSAnimation animation)
		{
			_AnimationDidStop (this, animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnimationDidStop (INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationDidStop:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidEnd (NSAnimation animation)
		{
			_AnimationDidEnd (this, animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnimationDidEnd (INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationDidEnd:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animation:valueForProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ComputeAnimationCurve (NSAnimation animation, float progress)
		{
			return _ComputeAnimationCurve (this, animation, progress);
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _ComputeAnimationCurve (INSAnimationDelegate This, NSAnimation animation, float progress)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle_float (This.Handle, Selector.GetHandle ("animation:valueForProgress:"), animation__handle__, progress);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
			return ret!;
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animation:didReachProgressMark:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidReachProgressMark (NSAnimation animation, float progress)
		{
			_AnimationDidReachProgressMark (this, animation, progress);
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnimationDidReachProgressMark (INSAnimationDelegate This, NSAnimation animation, float progress)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (This.Handle, Selector.GetHandle ("animation:didReachProgressMark:"), animation__handle__, progress);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
		[DynamicDependencyAttribute ("AnimationDidEnd(AppKit.NSAnimation)")]
		[DynamicDependencyAttribute ("AnimationDidReachProgressMark(AppKit.NSAnimation,System.Single)")]
		[DynamicDependencyAttribute ("AnimationDidStop(AppKit.NSAnimation)")]
		[DynamicDependencyAttribute ("AnimationShouldStart(AppKit.NSAnimation)")]
		[DynamicDependencyAttribute ("ComputeAnimationCurve(AppKit.NSAnimation,System.Single)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAnimationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAnimationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSAnimationDelegate" /> interface to support all the methods from the NSAnimationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSAnimationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSAnimationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSAnimationDelegate_Extensions {
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AnimationShouldStart (this INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationShouldStart:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
			return ret != 0;
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AnimationDidStop (this INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationDidStop:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AnimationDidEnd (this INSAnimationDelegate This, NSAnimation animation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationDidEnd:"), animation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float ComputeAnimationCurve (this INSAnimationDelegate This, NSAnimation animation, float progress)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle_float (This.Handle, Selector.GetHandle ("animation:valueForProgress:"), animation__handle__, progress);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
			return ret!;
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AnimationDidReachProgressMark (this INSAnimationDelegate This, NSAnimation animation, float progress)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (This.Handle, Selector.GetHandle ("animation:didReachProgressMark:"), animation__handle__, progress);
			GC.KeepAlive (This);
			GC.KeepAlive (animation);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAnimationDelegateWrapper : BaseWrapper, INSAnimationDelegate {
		public NSAnimationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAnimationDelegateWrapper))]
		static NSAnimationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSAnimationDelegate" /> (for the protocol <c>NSAnimationDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSAnimationDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSAnimationDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSAnimationDelegate : NSObject, INSAnimationDelegate {
		/// <summary>Creates a new <see cref="NSAnimationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSAnimationDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSAnimationDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSAnimationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animationDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidEnd (NSAnimation animation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animation:didReachProgressMark:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidReachProgressMark (NSAnimation animation, float progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animationDidStop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidStop (NSAnimation animation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationShouldStart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AnimationShouldStart (NSAnimation animation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animation:valueForProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ComputeAnimationCurve (NSAnimation animation, float progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSAnimationDelegate */
}
