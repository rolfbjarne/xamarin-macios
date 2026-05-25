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
	[Register("UIView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIView : UIResponder, INSCoding, IUIAccessibilityIdentification, IUIAppearance, IUIAppearanceContainer, IUICoordinateSpace, IUIDynamicItem, IUIFocusEnvironment, IUIFocusItem, IUIFocusItemContainer, IUITraitChangeObservable, IUITraitEnvironment, global::CoreAnimation.ICALayerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIView () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UIView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected UIView (NSObjectFlag t) : base (t)
		{
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
		protected internal UIView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("accessibilityActivate")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityActivate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityActivate"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("actionForLayer:forKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ActionForLayer (global::CoreAnimation.CALayer layer, string eventKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("actionForLayer:forKey:"), layer__handle__, nseventKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("actionForLayer:forKey:"), layer__handle__, nseventKey), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
		[Export ("addConstraint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddConstraint (NSLayoutConstraint constraint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addConstraint:"), constraint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addConstraint:"), constraint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (constraint);
		}
		[Export ("addConstraints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddConstraints (NSLayoutConstraint[] constraints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (constraints is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (constraints));
			using var nsa_constraints = NSArray.FromNSObjects (constraints);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addConstraints:"), nsa_constraints.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addConstraints:"), nsa_constraints.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddGestureRecognizer (UIGestureRecognizer gestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addGestureRecognizer:"), gestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addGestureRecognizer:"), gestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gestureRecognizer);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addInteraction:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddInteraction (IUIInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addInteraction:"), interaction__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addInteraction:"), interaction__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (interaction);
		}
		[Export ("addKeyframeWithRelativeStartTime:relativeDuration:animations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddKeyframeWithRelativeStartTime (double frameStartTime, double frameDuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double_NativeHandle (class_ptr, Selector.GetHandle ("addKeyframeWithRelativeStartTime:relativeDuration:animations:"), frameStartTime, frameDuration, (IntPtr) block_ptr_animations);
		}
		[Export ("addLayoutGuide:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddLayoutGuide (UILayoutGuide guide)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var guide__handle__ = guide!.GetNonNullHandle (nameof (guide));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addLayoutGuide:"), guide__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addLayoutGuide:"), guide__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (guide);
		}
		[Export ("addMotionEffect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMotionEffect (UIMotionEffect effect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var effect__handle__ = effect!.GetNonNullHandle (nameof (effect));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addMotionEffect:"), effect__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addMotionEffect:"), effect__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (effect);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSubview (UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addSubview:"), view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addSubview:"), view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("alignmentRectForFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect AlignmentRectForFrame (CGRect frame)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("alignmentRectForFrame:"), frame);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("alignmentRectForFrame:"), frame);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("alignmentRectForFrame:"), frame);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("alignmentRectForFrame:"), frame);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("animateWithDuration:animations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Animate (double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (class_ptr, Selector.GetHandle ("animateWithDuration:animations:"), duration, (IntPtr) block_ptr_animation);
		}
		[Export ("animateWithSpringDuration:bounce:initialSpringVelocity:delay:options:animations:completion:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Animate (double duration, nfloat bounce, nfloat velocity, double delay, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool>? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			using var block_completion = Trampolines.SDActionArity1V0.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_nfloat_nfloat_Double_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateWithSpringDuration:bounce:initialSpringVelocity:delay:options:animations:completion:"), duration, bounce, velocity, delay, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> AnimateAsync (double duration, nfloat bounce, nfloat velocity, double delay, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Animate(duration, bounce, velocity, delay, options, animations, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("animateKeyframesWithDuration:delay:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnimateKeyframes (double duration, double delay, UIViewKeyframeAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateKeyframesWithDuration:delay:options:animations:completion:"), duration, delay, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
		}
		/// <param name="duration">Duration in seconds for the animation.</param>
		/// <param name="delay">Duration in seconds before starting the animation.</param>
		/// <param name="options">Designates a mask of options that indicates how the developer wants to perform the animations.</param>
		/// <param name="animations">An action object that contains the changes to be committed to the views.</param>
		/// <summary>Creates an animation action object that is to be used to set up keyframe-based animations for the current view.</summary>
		/// <returns>Boolean indicating whether animations finished before a completion handler was called.</returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> AnimateKeyframesAsync (double duration, double delay, UIViewKeyframeAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AnimateKeyframes(duration, delay, options, animations, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("animateWithDuration:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnimateNotify (double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateWithDuration:animations:completion:"), duration, (IntPtr) block_ptr_animation, (IntPtr) block_ptr_completion);
		}
		/// <param name="duration">Duration in seconds for the animation.</param>
		/// <param name="animation">Code containing the changes that you will apply to your view.</param>
		/// <summary>Animates the property changes that take place in the specified action and invokes a completion callback when the animation completes.</summary>
		/// <returns>System.Threading.Tasks.Task&lt;System.Boolean&gt;</returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> AnimateNotifyAsync (double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AnimateNotify(duration, animation, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("animateWithDuration:delay:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnimateNotify (double duration, double delay, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animation));
			using var block_animation = Trampolines.SDAction.CreateBlock (animation);
			BlockLiteral *block_ptr_animation = &block_animation;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateWithDuration:delay:options:animations:completion:"), duration, delay, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animation, (IntPtr) block_ptr_completion);
		}
		/// <param name="duration">Duration in seconds for the animation.</param>
		/// <param name="delay">Delay before the animation begins.</param>
		/// <param name="options">Animation options.</param>
		/// <param name="animation">The changes to be applied to the view.</param>
		/// <summary>Executes the specified <paramref name="animation" /> as an asynchronous operation.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> AnimateNotifyAsync (double duration, double delay, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animation)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AnimateNotify(duration, delay, options, animation, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		/// <param name="duration">Duration in seconds for the animation.</param><param name="delay">Delay before the animation begins.</param><param name="springWithDampingRatio">Damping ratio set for spring animation when it is approaching its quiescent state. Value between 0 and 1 representing the amount of damping to apply to the spring effect.</param><param name="initialSpringVelocity">Initial spring velocity prior to attachment. The initial velocity of the spring, in points per second.</param><param name="options">Animation options.</param><param name="animations">Code containing the changes that you will apply to your view.</param><param name="completion"><para>The method to invoke when the animation has completed.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Executes a view animation that uses a timing curve that corresponds to the activity of a physical spring.</summary><remarks><para>The use of this method is discouraged. Application developers should prefer to use the <see cref="T:UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para></remarks>
		[Export ("animateWithDuration:delay:usingSpringWithDamping:initialSpringVelocity:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnimateNotify (double duration, double delay, nfloat springWithDampingRatio, nfloat initialSpringVelocity, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double_nfloat_nfloat_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateWithDuration:delay:usingSpringWithDamping:initialSpringVelocity:options:animations:completion:"), duration, delay, springWithDampingRatio, initialSpringVelocity, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
		}
		/// <param name="duration">Duration in seconds for the animation.</param>
		/// <param name="delay">Delay before the animation begins.</param>
		/// <param name="springWithDampingRatio">Damping ratio set for spring animation when it is approaching its quiescent state. Value between 0 and 1 representing the amount of damping to apply to the spring effect.</param>
		/// <param name="initialSpringVelocity">Initial spring velocity prior to attachment. The initial velocity of the spring, in points per second.</param>
		/// <param name="options">Animation options.</param>
		/// <param name="animations">Code containing the changes that you will apply to your view.</param>
		/// <summary>Executes a view animation that uses a timing curve that corresponds to the activity of a physical spring.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous AnimateNotify operation.   The value of the TResult parameter is a <see cref="UIKit.UICompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///           <para copied="true">The AnimateNotifyAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> AnimateNotifyAsync (double duration, double delay, nfloat springWithDampingRatio, nfloat initialSpringVelocity, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AnimateNotify(duration, delay, springWithDampingRatio, initialSpringVelocity, options, animations, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("beginAnimations:context:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginAnimations (string? animationID, nint context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nsanimationID = CFString.CreateNative (animationID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("beginAnimations:context:"), nsanimationID, context);
			CFString.ReleaseNative (nsanimationID);
		}
		[Export ("bringSubviewToFront:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BringSubviewToFront (UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("bringSubviewToFront:"), view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("bringSubviewToFront:"), view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("commitAnimations")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CommitAnimations ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("commitAnimations"));
		}
		[Export ("contentCompressionResistancePriorityForAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ContentCompressionResistancePriority (UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("contentCompressionResistancePriorityForAxis:"), (IntPtr) (long) axis);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("contentCompressionResistancePriorityForAxis:"), (IntPtr) (long) axis);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("contentHuggingPriorityForAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ContentHuggingPriority (UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("contentHuggingPriorityForAxis:"), (IntPtr) (long) axis);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("contentHuggingPriorityForAxis:"), (IntPtr) (long) axis);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertPoint:fromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromView (CGPoint point, UIView? fromView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromView__handle__ = fromView.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromView:"), point, fromView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:fromView:"), point, fromView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromView);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertPoint:toView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToView (CGPoint point, UIView? toView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toView__handle__ = toView.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toView:"), point, toView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:toView:"), point, toView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toView);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertRect:fromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromView (CGRect rect, UIView? fromView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromView__handle__ = fromView.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromView:"), rect, fromView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromView:"), rect, fromView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromView:"), rect, fromView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromView:"), rect, fromView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (fromView);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertRect:toView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToView (CGRect rect, UIView? toView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toView__handle__ = toView.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toView:"), rect, toView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toView:"), rect, toView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toView:"), rect, toView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toView:"), rect, toView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (toView);
			return ret!;
		}
		[Export ("decodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodeRestorableState (NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		/// <param name="hint">The focus movement hint.</param><summary>Called when a focus change may soon happen.</summary><remarks>To be added.</remarks>
		[Export ("didHintFocusMovement:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHintFocusMovement (UIFocusMovementHint hint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var hint__handle__ = hint!.GetNonNullHandle (nameof (hint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hint);
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("displayLayer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayLayer (global::CoreAnimation.CALayer layer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("displayLayer:"), layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("displayLayer:"), layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[Export ("drawRect:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("drawRect:"), rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("drawRect:"), rect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawLayer:inContext:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawLayer (global::CoreAnimation.CALayer layer, CGContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("drawLayer:inContext:"), layer__handle__, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("drawLayer:inContext:"), layer__handle__, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (context);
		}
		[Export ("drawViewHierarchyInRect:afterScreenUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawViewHierarchy (CGRect rect, bool afterScreenUpdates)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("drawViewHierarchyInRect:afterScreenUpdates:"), rect, afterScreenUpdates ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect_bool (&__objc_super__, Selector.GetHandle ("drawViewHierarchyInRect:afterScreenUpdates:"), rect, afterScreenUpdates ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("encodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="atIndex"><para>An index within the zero-based <see cref="P:UIKit.UIView.Subviews" /> array.</para></param><param name="withSubviewAtIndex"><para>Another index within the zero-based <see cref="P:UIKit.UIView.Subviews" /> array.</para></param><summary>This method exchanges the indices of two <see cref="T:UIKit.UIView" />s within the <see cref="P:UIKit.UIView.Subviews" /> array. </summary><remarks></remarks><altmember cref="M:UIKit.UIView.AddSubview(UIKit.UIView)" /><altmember cref="M:UIKit.UIView.InsertSubview(UIKit.UIView,System.IntPtr)" /><altmember cref="M:UIKit.UIView.InsertSubviewAbove(UIKit.UIView,UIKit.UIView)" /><altmember cref="M:UIKit.UIView.InsertSubviewBelow(UIKit.UIView,UIKit.UIView)" />
		[Export ("exchangeSubviewAtIndex:withSubviewAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeSubview (nint atIndex, nint withSubviewAtIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("exchangeSubviewAtIndex:withSubviewAtIndex:"), atIndex, withSubviewAtIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("exchangeSubviewAtIndex:withSubviewAtIndex:"), atIndex, withSubviewAtIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("exerciseAmbiguityInLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExerciseAmbiguityInLayout ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("exerciseAmbiguityInLayout"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("exerciseAmbiguityInLayout"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("frameForAlignmentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect FrameForAlignmentRect (CGRect alignmentRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("frameForAlignmentRect:"), alignmentRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("frameForAlignmentRect:"), alignmentRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("frameForAlignmentRect:"), alignmentRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("frameForAlignmentRect:"), alignmentRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("gestureRecognizerShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("gestureRecognizerShouldBegin:"), gestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("gestureRecognizerShouldBegin:"), gestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gestureRecognizer);
			return ret != 0;
		}
		[Export ("constraintsAffectingLayoutForAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint[] GetConstraintsAffectingLayout (UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSLayoutConstraint[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("constraintsAffectingLayoutForAxis:"), (IntPtr) (long) axis), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("constraintsAffectingLayoutForAxis:"), (IntPtr) (long) axis), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("directionalEdgeInsetsForLayoutRegion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDirectionalEdgeInsets GetDirectionalEdgeInsets (UIViewLayoutRegion layoutRegion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutRegion__handle__ = layoutRegion!.GetNonNullHandle (nameof (layoutRegion));
			NSDirectionalEdgeInsets ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("directionalEdgeInsetsForLayoutRegion:"), layoutRegion__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("directionalEdgeInsetsForLayoutRegion:"), layoutRegion__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("directionalEdgeInsetsForLayoutRegion:"), layoutRegion__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("directionalEdgeInsetsForLayoutRegion:"), layoutRegion__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (layoutRegion);
			return ret!;
		}
		[Export ("edgeInsetsForLayoutRegion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets GetEdgeInsets (UIViewLayoutRegion layoutRegion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutRegion__handle__ = layoutRegion!.GetNonNullHandle (nameof (layoutRegion));
			UIEdgeInsets ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("edgeInsetsForLayoutRegion:"), layoutRegion__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("edgeInsetsForLayoutRegion:"), layoutRegion__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("edgeInsetsForLayoutRegion:"), layoutRegion__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("edgeInsetsForLayoutRegion:"), layoutRegion__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (layoutRegion);
			return ret!;
		}
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[Export ("focusItemsInRect:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIFocusItem[] GetFocusItems (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutGuideForLayoutRegion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UILayoutGuide GetLayoutGuide (UIViewLayoutRegion layoutRegion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutRegion__handle__ = layoutRegion!.GetNonNullHandle (nameof (layoutRegion));
			UILayoutGuide? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("layoutGuideForLayoutRegion:"), layoutRegion__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("layoutGuideForLayoutRegion:"), layoutRegion__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layoutRegion);
			return ret!;
		}
		[Export ("soundIdentifierForFocusUpdateInContext:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? GetSoundIdentifier (UIFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("soundIdentifierForFocusUpdateInContext:"), context__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("soundIdentifierForFocusUpdateInContext:"), context__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("userInterfaceLayoutDirectionForSemanticContentAttribute:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIUserInterfaceLayoutDirection GetUserInterfaceLayoutDirection (UISemanticContentAttribute attribute)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceLayoutDirection ret;
			ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("userInterfaceLayoutDirectionForSemanticContentAttribute:"), (IntPtr) (long) attribute);
			return ret!;
		}
		[Export ("userInterfaceLayoutDirectionForSemanticContentAttribute:relativeToLayoutDirection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIUserInterfaceLayoutDirection GetUserInterfaceLayoutDirection (UISemanticContentAttribute semanticContentAttribute, UIUserInterfaceLayoutDirection layoutDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceLayoutDirection ret;
			ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("userInterfaceLayoutDirectionForSemanticContentAttribute:relativeToLayoutDirection:"), (IntPtr) (long) semanticContentAttribute, (IntPtr) (long) layoutDirection);
			return ret!;
		}
		[Export ("hitTest:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? HitTest (CGPoint point, UIEvent? uievent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uievent__handle__ = uievent.GetHandle ();
			UIView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("hitTest:withEvent:"), point, uievent__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("hitTest:withEvent:"), point, uievent__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uievent);
			return ret!;
		}
		/// <param name="view"><para>The view to add as a nested view of this view.</para></param><param name="atIndex"><para>The index in the stack of subviews where this view
		/// will be inserted.</para></param><summary>Inserts the specified subview at the specified
		/// location as a subview of this view.</summary><remarks></remarks>
		[Export ("insertSubview:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSubview (UIView view, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertSubview:atIndex:"), view__handle__, atIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertSubview:atIndex:"), view__handle__, atIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertSubview:aboveSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSubviewAbove (UIView view, UIView siblingSubview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var siblingSubview__handle__ = siblingSubview!.GetNonNullHandle (nameof (siblingSubview));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertSubview:aboveSubview:"), view__handle__, siblingSubview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertSubview:aboveSubview:"), view__handle__, siblingSubview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (siblingSubview);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertSubview:belowSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSubviewBelow (UIView view, UIView siblingSubview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var siblingSubview__handle__ = siblingSubview!.GetNonNullHandle (nameof (siblingSubview));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertSubview:belowSubview:"), view__handle__, siblingSubview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertSubview:belowSubview:"), view__handle__, siblingSubview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (siblingSubview);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("invalidateIntrinsicContentSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateIntrinsicContentSize ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateIntrinsicContentSize"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("invalidateIntrinsicContentSize"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("isDescendantOfView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDescendantOfView (UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isDescendantOfView:"), view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isDescendantOfView:"), view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret != 0;
		}
		[Export ("layoutIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("layoutIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("layoutMarginsDidChange")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutMarginsDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("layoutMarginsDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutMarginsDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("layoutSublayersOfLayer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayersOfLayer (global::CoreAnimation.CALayer layer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("layoutSublayersOfLayer:"), layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("layoutSublayersOfLayer:"), layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[Export ("layoutSubviews")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSubviews ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("layoutSubviews"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutSubviews"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("modifyAnimationsWithRepeatCount:autoreverses:animations:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ModifyAnimations (nfloat count, bool autoreverses, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_bool_NativeHandle (class_ptr, Selector.GetHandle ("modifyAnimationsWithRepeatCount:autoreverses:animations:"), count, autoreverses ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_animations);
		}
		[Export ("didMoveToSuperview")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MovedToSuperview ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didMoveToSuperview"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didMoveToSuperview"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didMoveToWindow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MovedToWindow ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didMoveToWindow"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didMoveToWindow"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("needsUpdateConstraints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NeedsUpdateConstraints ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("needsUpdateConstraints"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("needsUpdateConstraints"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("performSystemAnimation:onViews:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PerformSystemAnimation (UISystemAnimation animation, UIView[] views, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? parallelAnimations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			using var block_parallelAnimations = Trampolines.SDAction.CreateNullableBlock (parallelAnimations);
			BlockLiteral *block_ptr_parallelAnimations = null;
			if (parallelAnimations is not null)
				block_ptr_parallelAnimations = &block_parallelAnimations;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("performSystemAnimation:onViews:options:animations:completion:"), (UIntPtr) (ulong) animation, nsa_views.Handle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_parallelAnimations, (IntPtr) block_ptr_completion);
		}
		/// <param name="animation">Defined UISystemAnimation to perform.</param>
		/// <param name="views">Views on which to to perform the animations.</param>
		/// <param name="options">Mask of options that indicates how the animations are to be performed.</param>
		/// <param name="parallelAnimations">Additional animations specified to run alongside system animation.</param>
		/// <summary>Performs specified system-provided animation sequence on one or more views, together with user-defined parallel animations.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous PerformSystemAnimation operation.   The value of the TResult parameter is a UIKit.UICompletionHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> PerformSystemAnimationAsync (UISystemAnimation animation, UIView[] views, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? parallelAnimations)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PerformSystemAnimation(animation, views, options, parallelAnimations, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("performWithoutAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PerformWithoutAnimation ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action actionsWithoutAnimation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (actionsWithoutAnimation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionsWithoutAnimation));
			using var block_actionsWithoutAnimation = Trampolines.SDAction.CreateBlock (actionsWithoutAnimation);
			BlockLiteral *block_ptr_actionsWithoutAnimation = &block_actionsWithoutAnimation;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("performWithoutAnimation:"), (IntPtr) block_ptr_actionsWithoutAnimation);
		}
		[Export ("pointInside:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PointInside (CGPoint point, UIEvent? uievent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uievent__handle__ = uievent.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("pointInside:withEvent:"), point, uievent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("pointInside:withEvent:"), point, uievent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uievent);
			return ret != 0;
		}
		[Export ("registerForTraitChanges:withHandler:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.SDActionArity2V100.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			IUITraitChangeRegistration ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("registerForTraitChanges:withTarget:action:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("registerForTraitChanges:withAction:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("removeConstraint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveConstraint (NSLayoutConstraint constraint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeConstraint:"), constraint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeConstraint:"), constraint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (constraint);
		}
		[Export ("removeConstraints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveConstraints (NSLayoutConstraint[] constraints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (constraints is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (constraints));
			using var nsa_constraints = NSArray.FromNSObjects (constraints);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeConstraints:"), nsa_constraints.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeConstraints:"), nsa_constraints.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeFromSuperview")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromSuperview ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeFromSuperview"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeFromSuperview"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveGestureRecognizer (UIGestureRecognizer gestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeGestureRecognizer:"), gestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeGestureRecognizer:"), gestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gestureRecognizer);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeInteraction:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveInteraction (IUIInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeInteraction:"), interaction__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeInteraction:"), interaction__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (interaction);
		}
		[Export ("removeLayoutGuide:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveLayoutGuide (UILayoutGuide guide)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var guide__handle__ = guide!.GetNonNullHandle (nameof (guide));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeLayoutGuide:"), guide__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeLayoutGuide:"), guide__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (guide);
		}
		[Export ("removeMotionEffect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveMotionEffect (UIMotionEffect effect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var effect__handle__ = effect!.GetNonNullHandle (nameof (effect));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeMotionEffect:"), effect__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeMotionEffect:"), effect__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (effect);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("requiresConstraintBasedLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RequiresConstraintBasedLayout ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("requiresConstraintBasedLayout"));
			return ret != 0;
		}
		[Export ("resizableSnapshotViewFromRect:afterScreenUpdates:withCapInsets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? ResizableSnapshotView (CGRect rect, bool afterScreenUpdates, UIEdgeInsets capInsets)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_bool_UIEdgeInsets (this.Handle, Selector.GetHandle ("resizableSnapshotViewFromRect:afterScreenUpdates:withCapInsets:"), rect, afterScreenUpdates ? (byte) 1 : (byte) 0, capInsets), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_bool_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("resizableSnapshotViewFromRect:afterScreenUpdates:withCapInsets:"), rect, afterScreenUpdates ? (byte) 1 : (byte) 0, capInsets), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("safeAreaInsetsDidChange")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SafeAreaInsetsDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("safeAreaInsetsDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("safeAreaInsetsDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sendSubviewToBack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendSubviewToBack (UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sendSubviewToBack:"), view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("sendSubviewToBack:"), view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("setAnimationBeginsFromCurrentState:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationBeginsFromCurrentState (bool fromCurrentState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAnimationBeginsFromCurrentState:"), fromCurrentState ? (byte) 1 : (byte) 0);
		}
		[Export ("setAnimationCurve:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationCurve (UIViewAnimationCurve curve)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAnimationCurve:"), (IntPtr) (long) curve);
		}
		[Export ("setAnimationDelay:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationDelay (double delay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (class_ptr, Selector.GetHandle ("setAnimationDelay:"), delay);
		}
		[Export ("setAnimationDelegate:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationDelegate (NSObject del)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var del__handle__ = del!.GetNonNullHandle (nameof (del));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAnimationDelegate:"), del__handle__);
			GC.KeepAlive (del);
		}
		[Export ("setAnimationDidStopSelector:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationDidStopSelector (Selector sel)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAnimationDidStopSelector:"), sel.Handle);
			GC.KeepAlive (sel);
		}
		[Export ("setAnimationDuration:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationDuration (double duration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (class_ptr, Selector.GetHandle ("setAnimationDuration:"), duration);
		}
		[Export ("setAnimationRepeatAutoreverses:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationRepeatAutoreverses (bool repeatAutoreverses)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAnimationRepeatAutoreverses:"), repeatAutoreverses ? (byte) 1 : (byte) 0);
		}
		[Export ("setAnimationRepeatCount:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationRepeatCount (float repeatCount)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (class_ptr, Selector.GetHandle ("setAnimationRepeatCount:"), repeatCount);
		}
		[Export ("setAnimationStartDate:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationStartDate (NSDate startDate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAnimationStartDate:"), startDate__handle__);
			GC.KeepAlive (startDate);
		}
		[Export ("setAnimationTransition:forView:cache:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationTransition (UIViewAnimationTransition transition, UIView forView, bool cache)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forView__handle__ = forView!.GetNonNullHandle (nameof (forView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_bool (class_ptr, Selector.GetHandle ("setAnimationTransition:forView:cache:"), (IntPtr) (long) transition, forView__handle__, cache ? (byte) 1 : (byte) 0);
			GC.KeepAlive (forView);
		}
		[Export ("setAnimationWillStartSelector:")]
		[ObsoletedOSPlatform ("ios13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use the 'Action' handler based animation APIs instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use the 'Action' handler based animation APIs instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnimationWillStartSelector (Selector sel)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAnimationWillStartSelector:"), sel.Handle);
			GC.KeepAlive (sel);
		}
		[Export ("setContentCompressionResistancePriority:forAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentCompressionResistancePriority (float priority, UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_IntPtr (this.Handle, Selector.GetHandle ("setContentCompressionResistancePriority:forAxis:"), priority, (IntPtr) (long) axis);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_IntPtr (&__objc_super__, Selector.GetHandle ("setContentCompressionResistancePriority:forAxis:"), priority, (IntPtr) (long) axis);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setContentHuggingPriority:forAxis:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentHuggingPriority (float priority, UILayoutConstraintAxis axis)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_IntPtr (this.Handle, Selector.GetHandle ("setContentHuggingPriority:forAxis:"), priority, (IntPtr) (long) axis);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_IntPtr (&__objc_super__, Selector.GetHandle ("setContentHuggingPriority:forAxis:"), priority, (IntPtr) (long) axis);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("effectiveRadiusForCorner:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetEffectiveRadius (UIRectCorner corner)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("effectiveRadiusForCorner:"), (UIntPtr) (ulong) corner);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("effectiveRadiusForCorner:"), (UIntPtr) (ulong) corner);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setNeedsDisplay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsDisplay"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsDisplay"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsDisplayInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplayInRect (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setNeedsDisplayInRect:"), rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("setNeedsDisplayInRect:"), rect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[Export ("setNeedsFocusUpdate")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsFocusUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsFocusUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsLayout ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsLayout"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsLayout"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateConstraints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateConstraints ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateConstraints"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateConstraints"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsUpdateProperties")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsUpdateProperties ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsUpdateProperties"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsUpdateProperties"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldUpdateFocusInContext:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UIFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			return ret != 0;
		}
		[Export ("sizeThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize SizeThatFits (CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("sizeThatFits:"), size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("sizeThatFits:"), size);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sizeToFit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SizeToFit ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("sizeToFit"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sizeToFit"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("snapshotViewAfterScreenUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? SnapshotView (bool afterScreenUpdates)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, Selector.GetHandle ("snapshotViewAfterScreenUpdates:"), afterScreenUpdates ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("snapshotViewAfterScreenUpdates:"), afterScreenUpdates ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("didAddSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SubviewAdded (UIView uiview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiview__handle__ = uiview!.GetNonNullHandle (nameof (uiview));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didAddSubview:"), uiview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didAddSubview:"), uiview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uiview);
		}
		[Export ("systemLayoutSizeFittingSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize SystemLayoutSizeFittingSize (CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("systemLayoutSizeFittingSize:"), size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("systemLayoutSizeFittingSize:"), size);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize SystemLayoutSizeFittingSize (CGSize targetSize, float horizontalFittingPriority, float verticalFittingPriority)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize_float_float (this.Handle, Selector.GetHandle ("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:"), targetSize, horizontalFittingPriority, verticalFittingPriority);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGSize_float_float (&__objc_super__, Selector.GetHandle ("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:"), targetSize, horizontalFittingPriority, verticalFittingPriority);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tintColorDidChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TintColorDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("tintColorDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintColorDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[Export ("traitCollectionDidChange:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TraitCollectionDidChange (UITraitCollection? previousTraitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previousTraitCollection__handle__ = previousTraitCollection.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (previousTraitCollection);
		}
		[Export ("transitionFromView:toView:duration:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void TransitionNotify (UIView fromView, UIView toView, double duration, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromView__handle__ = fromView!.GetNonNullHandle (nameof (fromView));
			var toView__handle__ = toView!.GetNonNullHandle (nameof (toView));
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("transitionFromView:toView:duration:options:completion:"), fromView__handle__, toView__handle__, duration, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completion);
			GC.KeepAlive (fromView);
			GC.KeepAlive (toView);
		}
		/// <param name="fromView">The initial view.</param>
		/// <param name="toView">The final view.</param>
		/// <param name="duration">The duration, in seconds, of the animation.</param>
		/// <param name="options">A mask of options to be used with the animation.</param>
		/// <summary>Specifies a transition animation to be used between the specified <see cref="UIKit.UIView" />s.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous TransitionNotify operation.   The value of the TResult parameter is a <see cref="UIKit.UICompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> TransitionNotifyAsync (UIView fromView, UIView toView, double duration, UIViewAnimationOptions options)
		{
			var tcs = new TaskCompletionSource<bool> ();
			TransitionNotify(fromView, toView, duration, options, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("transitionWithView:duration:options:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void TransitionNotify (UIView withView, double duration, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? animation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUICompletionHandler))]UICompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withView__handle__ = withView!.GetNonNullHandle (nameof (withView));
			using var block_animation = Trampolines.SDAction.CreateNullableBlock (animation);
			BlockLiteral *block_ptr_animation = null;
			if (animation is not null)
				block_ptr_animation = &block_animation;
			using var block_completion = Trampolines.SDUICompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("transitionWithView:duration:options:animations:completion:"), withView__handle__, duration, (UIntPtr) (ulong) options, (IntPtr) block_ptr_animation, (IntPtr) block_ptr_completion);
			GC.KeepAlive (withView);
		}
		/// <param name="withView">View whose state is being manipulated and in which the animation should occur.</param>
		/// <param name="duration">The duration of the animation in seconds.</param>
		/// <param name="options">A mask of options to be used with the animation.</param>
		/// <param name="animation">Action containing the animation and state manipulation of the view.</param>
		/// <summary>Creates a transition animation action that is used for the current container view.</summary>
		/// <returns>A task that represents the asynchronous TransitionNotify operation. </returns>
		/// <remarks>
		///           <para>The use of this method is discouraged. Application developers should prefer to use the <see cref="UIKit.UIViewPropertyAnimator" /> class to animate UIViews.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> TransitionNotifyAsync (UIView withView, double duration, UIViewAnimationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? animation)
		{
			var tcs = new TaskCompletionSource<bool> ();
			TransitionNotify(withView, duration, options, animation, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("unregisterForTraitChanges:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterForTraitChanges (IUITraitChangeRegistration registration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var registration__handle__ = registration!.GetNonNullHandle (nameof (registration));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (registration);
		}
		[Export ("updateConstraints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void UpdateConstraints ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateConstraints"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateConstraints"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateConstraintsIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateConstraintsIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateConstraintsIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateConstraintsIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[Export ("updateFocusIfNeeded")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFocusIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateFocusIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateProperties")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void UpdateProperties ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateProperties"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateProperties"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updatePropertiesIfNeeded")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatePropertiesIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updatePropertiesIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updatePropertiesIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateTraitsIfNeeded")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTraitsIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateTraitsIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateTraitsIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="tag"><para>The identifier being searched for.</para></param><summary>Returns the <see cref="T:UIKit.UIView" /> identified by the <paramref name="tag" />. May return <see langword="null" />.</summary><returns><para>The view in the view hierarchy whose <see cref="P:UIKit.UIView.Tag" /> is equal to <paramref name="tag" />.</para></returns><remarks><para>This method searches the current <see cref="T:UIKit.UIView" />'s view hierarchy (i.e., <c>this</c>, its <see cref="P:UIKit.UIView.Subviews" /> and their descendants) and returns the <see cref="T:UIKit.UIView" />, if any, whose <see cref="P:UIKit.UIView.Tag" /> property is equal to the <paramref name="tag" /> parameter. If no such <see cref="T:UIKit.UIView" /> exists, this method returns <see langword="null" />.</para></remarks><altmember cref="P:UIKit.UIView.Tag" />
		[Export ("viewWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? ViewWithTag (nint tag)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("viewWithTag:"), tag), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("viewWithTag:"), tag), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[Export ("layerWillDraw:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDrawLayer (global::CoreAnimation.CALayer layer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("layerWillDraw:"), layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("layerWillDraw:"), layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[Export ("willMoveToSuperview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMoveToSuperview (UIView? newsuper)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var newsuper__handle__ = newsuper.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willMoveToSuperview:"), newsuper__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willMoveToSuperview:"), newsuper__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newsuper);
		}
		[Export ("willMoveToWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMoveToWindow (UIWindow? window)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var window__handle__ = window.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willMoveToWindow:"), window__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willMoveToWindow:"), window__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		[Export ("willRemoveSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRemoveSubview (UIView uiview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiview__handle__ = uiview!.GetNonNullHandle (nameof (uiview));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willRemoveSubview:"), uiview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willRemoveSubview:"), uiview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uiview);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGPoint AccessibilityActivationPoint {
			[Export ("accessibilityActivationPoint")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityActivationPoint"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityActivationPoint:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSAttributedString? AccessibilityAttributedHint {
			[Export ("accessibilityAttributedHint", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedHint")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityAttributedHint")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedHint:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAttributedHint:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityAttributedHint:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSAttributedString? AccessibilityAttributedLabel {
			[Export ("accessibilityAttributedLabel", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedLabel")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityAttributedLabel")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedLabel:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAttributedLabel:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityAttributedLabel:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSAttributedString[] AccessibilityAttributedUserInputLabels {
			[Export ("accessibilityAttributedUserInputLabels", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedUserInputLabels:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSAttributedString? AccessibilityAttributedValue {
			[Export ("accessibilityAttributedValue", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityAttributedValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedValue:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAttributedValue:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityAttributedValue:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UIAccessibilityDirectTouchOptions AccessibilityDirectTouchOptions {
			[Export ("accessibilityDirectTouchOptions", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityDirectTouchOptions ret;
				if (IsDirectBinding) {
					ret = (UIAccessibilityDirectTouchOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDirectTouchOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIAccessibilityDirectTouchOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityDirectTouchOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityDirectTouchOptions:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAccessibilityDirectTouchOptions:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setAccessibilityDirectTouchOptions:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AccessibilityElementsHidden {
			[Export ("accessibilityElementsHidden")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityElementsHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityElementsHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityElementsHidden:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityElementsHidden:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAccessibilityElementsHidden:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public virtual UIAccessibilityExpandedStatus AccessibilityExpandedStatus {
			[Export ("accessibilityExpandedStatus", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityExpandedStatus ret;
				if (IsDirectBinding) {
					ret = (UIAccessibilityExpandedStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityExpandedStatus"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIAccessibilityExpandedStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityExpandedStatus"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityExpandedStatus:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityExpandedStatus:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAccessibilityExpandedStatus:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFrame"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("accessibilityFrame"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityFrame"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("accessibilityFrame"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityFrame:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setAccessibilityFrame:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("setAccessibilityFrame:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSObject[]? AccessibilityHeaderElements {
			[Export ("accessibilityHeaderElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("tvos")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHeaderElements")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityHeaderElements")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityHeaderElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("tvos")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHeaderElements:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityHeaderElements:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityHint {
			[Export ("accessibilityHint", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHint")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityHint")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityHint:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHint:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityHint:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Uniquely identifies <c>this</c> for the purposes of accessibility.</summary><value><see langword="string" /> uniquely identifying <c>this</c> for the purposes of accessibility.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityIdentifier:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AccessibilityIgnoresInvertColors {
			[Export ("accessibilityIgnoresInvertColors")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIgnoresInvertColors"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityIgnoresInvertColors"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityIgnoresInvertColors:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityIgnoresInvertColors:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAccessibilityIgnoresInvertColors:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabel")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityLabel")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityLabel:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityLanguage {
			[Export ("accessibilityLanguage", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLanguage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityLanguage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityLanguage:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityLanguage:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityLanguage:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIAccessibilityNavigationStyle AccessibilityNavigationStyle {
			[Export ("accessibilityNavigationStyle")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityNavigationStyle ret;
				if (IsDirectBinding) {
					ret = (UIAccessibilityNavigationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityNavigationStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIAccessibilityNavigationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityNavigationStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityNavigationStyle:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIBezierPath? AccessibilityPath {
			[Export ("accessibilityPath", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBezierPath? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPath")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityPath")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityPath:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityPath:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityPath:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AccessibilityRespondsToUserInteraction {
			[Export ("accessibilityRespondsToUserInteraction")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRespondsToUserInteraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityRespondsToUserInteraction"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityRespondsToUserInteraction:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityRespondsToUserInteraction:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAccessibilityRespondsToUserInteraction:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityTextualContext {
			[Export ("accessibilityTextualContext", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTextualContext")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityTextualContext")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityTextualContext:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTextualContext:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityTextualContext:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIAccessibilityTrait AccessibilityTraits {
			[Export ("accessibilityTraits")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityTrait ret;
				if (IsDirectBinding) {
					ret = (UIAccessibilityTrait) global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTraits"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIAccessibilityTrait) global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityTraits"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityTraits:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setAccessibilityTraits:"), (Int64)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, Selector.GetHandle ("setAccessibilityTraits:"), (Int64)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string[] AccessibilityUserInputLabels {
			[Export ("accessibilityUserInputLabels", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityUserInputLabels:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityValue {
			[Export ("accessibilityValue", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityValue:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityValue:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityValue:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AccessibilityViewIsModal {
			[Export ("accessibilityViewIsModal")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityViewIsModal"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityViewIsModal"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityViewIsModal:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityViewIsModal:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAccessibilityViewIsModal:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets AlignmentRectInsets {
			[Export ("alignmentRectInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("alignmentRectInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("alignmentRectInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alignmentRectInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("alignmentRectInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Alpha {
			[Export ("alpha")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alpha"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAlpha:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setAlpha:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual CGPoint AnchorPoint {
			[Export ("anchorPoint", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("anchorPoint"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("anchorPoint"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAnchorPoint:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAnchorPoint:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setAnchorPoint:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AnimationsEnabled {
			[Export ("areAnimationsEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("areAnimationsEnabled"));
				return ret != 0;
			}
			[Export ("setAnimationsEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAnimationsEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string AppliedContentSizeCategoryLimitsDescription {
			[Export ("appliedContentSizeCategoryLimitsDescription")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("appliedContentSizeCategoryLimitsDescription")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("appliedContentSizeCategoryLimitsDescription")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewAutoresizing AutoresizingMask {
			[Export ("autoresizingMask")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewAutoresizing ret;
				if (IsDirectBinding) {
					ret = (UIViewAutoresizing) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("autoresizingMask"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIViewAutoresizing) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autoresizingMask"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutoresizingMask:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAutoresizingMask:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setAutoresizingMask:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosizesSubviews {
			[Export ("autoresizesSubviews")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoresizesSubviews"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autoresizesSubviews"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoresizesSubviews:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoresizesSubviews:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutoresizesSubviews:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The color used for the background.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("backgroundColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setBackgroundColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor BottomAnchor {
			[Export ("bottomAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bottomAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bottomAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bounds"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("bounds"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setBounds:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setBounds:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("setBounds:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool CanBecomeFocused {
			[Export ("canBecomeFocused")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canBecomeFocused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canBecomeFocused"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint Center {
			[Export ("center")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("center"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("center"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCenter:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setCenter:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setCenter:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutXAxisAnchor CenterXAnchor {
			[Export ("centerXAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutXAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("centerXAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("centerXAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor CenterYAnchor {
			[Export ("centerYAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("centerYAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("centerYAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsContextBeforeDrawing {
			[Export ("clearsContextBeforeDrawing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsContextBeforeDrawing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsContextBeforeDrawing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsContextBeforeDrawing:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsContextBeforeDrawing:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsContextBeforeDrawing:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClipsToBounds {
			[Export ("clipsToBounds")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clipsToBounds"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clipsToBounds"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClipsToBounds:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClipsToBounds:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClipsToBounds:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns the closed path that is used for collision detection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIBezierPath CollisionBoundingPath {
			[Export ("collisionBoundingPath")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBezierPath? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("collisionBoundingPath")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collisionBoundingPath")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns a value that tells how collision bounds are specified.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIDynamicItemCollisionBoundsType CollisionBoundsType {
			[Export ("collisionBoundsType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDynamicItemCollisionBoundsType ret;
				if (IsDirectBinding) {
					ret = (UIDynamicItemCollisionBoundsType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("collisionBoundsType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIDynamicItemCollisionBoundsType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collisionBoundsType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint[] Constraints {
			[Export ("constraints")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutConstraint[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("constraints")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("constraints")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewContentMode ContentMode {
			[Export ("contentMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewContentMode ret;
				if (IsDirectBinding) {
					ret = (UIViewContentMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIViewContentMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setContentMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ContentScaleFactor {
			[Export ("contentScaleFactor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("contentScaleFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentScaleFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentScaleFactor:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setContentScaleFactor:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setContentScaleFactor:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUICoordinateSpace? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("coordinateSpace")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UICornerConfiguration CornerConfiguration {
			[Export ("cornerConfiguration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICornerConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UICornerConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cornerConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UICornerConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cornerConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCornerConfiguration:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCornerConfiguration:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCornerConfiguration:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSDirectionalEdgeInsets DirectionalLayoutMargins {
			[Export ("directionalLayoutMargins", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDirectionalEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("directionalLayoutMargins"));
					} else {
						ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("directionalLayoutMargins"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("directionalLayoutMargins"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("directionalLayoutMargins"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setDirectionalLayoutMargins:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSDirectionalEdgeInsets (this.Handle, Selector.GetHandle ("setDirectionalLayoutMargins:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSDirectionalEdgeInsets (&__objc_super__, Selector.GetHandle ("setDirectionalLayoutMargins:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIUserInterfaceLayoutDirection EffectiveUserInterfaceLayoutDirection {
			[Export ("effectiveUserInterfaceLayoutDirection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("effectiveUserInterfaceLayoutDirection"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("effectiveUserInterfaceLayoutDirection"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor FirstBaselineAnchor {
			[Export ("firstBaselineAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("firstBaselineAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstBaselineAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusItemContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		public virtual UIFocusItemDeferralMode FocusItemDeferralMode {
			[Export ("focusItemDeferralMode")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIFocusItemDeferralMode ret;
				if (IsDirectBinding) {
					ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemDeferralMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemDeferralMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the <see cref="T:UIKit.UIView" /> is the focused view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool Focused {
			[Export ("isFocused")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFocused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isFocused"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("frame"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setFrame:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setFrame:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("setFrame:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIGestureRecognizer[]? GestureRecognizers {
			[Export ("gestureRecognizers", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIGestureRecognizer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIGestureRecognizer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("gestureRecognizers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIGestureRecognizer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("gestureRecognizers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGestureRecognizers:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGestureRecognizers:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setGestureRecognizers:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAmbiguousLayout {
			[Export ("hasAmbiguousLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasAmbiguousLayout"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasAmbiguousLayout"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutDimension HeightAnchor {
			[Export ("heightAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutDimension? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heightAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("heightAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Specifies whether the <see cref="T:UIKit.UIView" /> displays or not.</summary><value>The default value is <see langword="false" />.</value><remarks><para>A hidden <see cref="T:UIKit.UIView" /> does not display and does not receive input events. It does, however, participate in resizing and layout events and remains in its <see cref="P:UIKit.UIView.Superview" />'s list of <see cref="P:UIKit.UIView.Subviews" />s.</para><para>A hidden <see cref="T:UIKit.UIView" /> hides its descendant views in addition to hiding itself. This does not affect the <see cref="P:UIKit.UIView.Hidden" /> property of the descendant views. Thus, a <see cref="T:UIKit.UIView" /> may be hidden even though its <see cref="P:UIKit.UIView.Hidden" /> property is <see langword="false" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static double InheritedAnimationDuration {
			[Export ("inheritedAnimationDuration")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (class_ptr, Selector.GetHandle ("inheritedAnimationDuration"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool InsetsLayoutMarginsFromSafeArea {
			[Export ("insetsLayoutMarginsFromSafeArea")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("insetsLayoutMarginsFromSafeArea"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("insetsLayoutMarginsFromSafeArea"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInsetsLayoutMarginsFromSafeArea:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInsetsLayoutMarginsFromSafeArea:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setInsetsLayoutMarginsFromSafeArea:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual IUIInteraction[] Interactions {
			[Export ("interactions", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIInteraction[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIInteraction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interactions")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIInteraction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interactions")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractions:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInteractions:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInteractions:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize IntrinsicContentSize {
			[Export ("intrinsicContentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("intrinsicContentSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("intrinsicContentSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool IsAccessibilityElement {
			[Export ("isAccessibilityElement")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityElement"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isAccessibilityElement"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIsAccessibilityElement:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsAccessibilityElement:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setIsAccessibilityElement:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual bool IsTransparentFocusItem {
			[Export ("isTransparentFocusItem")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTransparentFocusItem"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTransparentFocusItem"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor LastBaselineAnchor {
			[Export ("lastBaselineAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lastBaselineAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("lastBaselineAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual global::CoreAnimation.CALayer Layer {
			[Export ("layer", ArgumentSemantic.Retain)]
			get {
				global::CoreAnimation.CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("layer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreAnimation.CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide[] LayoutGuides {
			[Export ("layoutGuides")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UILayoutGuide>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("layoutGuides")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UILayoutGuide>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutGuides")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIEdgeInsets LayoutMargins {
			[Export ("layoutMargins")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("layoutMargins"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("layoutMargins"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutMargins"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("layoutMargins"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setLayoutMargins:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setLayoutMargins:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setLayoutMargins:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide LayoutMarginsGuide {
			[Export ("layoutMarginsGuide", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("layoutMarginsGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutMarginsGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutXAxisAnchor LeadingAnchor {
			[Export ("leadingAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutXAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leadingAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leadingAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutXAxisAnchor LeftAnchor {
			[Export ("leftAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutXAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leftAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leftAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView? MaskView {
			[Export ("maskView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maskView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maskView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaskView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMaskView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMaskView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindAs (typeof (UIContentSizeCategory), OriginalType = typeof (NSString))]
		public virtual global::UIKit.UIContentSizeCategory MaximumContentSizeCategory {
			[Export ("maximumContentSizeCategory")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIContentSizeCategory ret;
				if (IsDirectBinding) {
					ret = global::UIKit.UIContentSizeCategoryExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maximumContentSizeCategory")));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::UIKit.UIContentSizeCategoryExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumContentSizeCategory")));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaximumContentSizeCategory:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsb_MaximumContentSizeCategory = global::UIKit.UIContentSizeCategoryExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMaximumContentSizeCategory:"), nsb_MaximumContentSizeCategory.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMaximumContentSizeCategory:"), nsb_MaximumContentSizeCategory.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindAs (typeof (UIContentSizeCategory), OriginalType = typeof (NSString))]
		public virtual global::UIKit.UIContentSizeCategory MinimumContentSizeCategory {
			[Export ("minimumContentSizeCategory")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIContentSizeCategory ret;
				if (IsDirectBinding) {
					ret = global::UIKit.UIContentSizeCategoryExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("minimumContentSizeCategory")));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::UIKit.UIContentSizeCategoryExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumContentSizeCategory")));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMinimumContentSizeCategory:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsb_MinimumContentSizeCategory = global::UIKit.UIContentSizeCategoryExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMinimumContentSizeCategory:"), nsb_MinimumContentSizeCategory.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMinimumContentSizeCategory:"), nsb_MinimumContentSizeCategory.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMotionEffect[]? MotionEffects {
			[Export ("motionEffects", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMotionEffect[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIMotionEffect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("motionEffects")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIMotionEffect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("motionEffects")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMotionEffects:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMotionEffects:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMotionEffects:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Determines whether the view is opaque or not.</summary><value></value><remarks><para>
		/// If you set this value to true, you should make sure that
		/// the entire area is painted, if you do not, the behavior is
		/// undefined.  You should also set the <see cref="P:UIKit.UIView.Alpha" /> property to 1.0.
		/// 
		/// </para><para>
		/// Whenever possible, you should try to set the view as
		/// opaque, as that informs UIKit that the view does not need
		/// to be composited and blended with underlying views.
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Opaque {
			[Export ("isOpaque")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOpaque"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isOpaque"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setOpaque:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOpaque:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setOpaque:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIUserInterfaceStyle OverrideUserInterfaceStyle {
			[Export ("overrideUserInterfaceStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceStyle ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overrideUserInterfaceStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("overrideUserInterfaceStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOverrideUserInterfaceStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOverrideUserInterfaceStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setOverrideUserInterfaceStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentFocusEnvironment_var;
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentFocusEnvironment")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentFocusEnvironment_var = ret;
				return ret!;
			}
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PreferredFocusedView_var;
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredFocusEnvironments' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView? PreferredFocusedView {
			[Export ("preferredFocusedView", ArgumentSemantic.Weak)]
			[ObsoletedOSPlatform ("ios12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("tvos12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PreferredFocusEnvironments' instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusedView")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PreferredFocusedView_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool PreservesSuperviewLayoutMargins {
			[Export ("preservesSuperviewLayoutMargins")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("preservesSuperviewLayoutMargins"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preservesSuperviewLayoutMargins"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreservesSuperviewLayoutMargins:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPreservesSuperviewLayoutMargins:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPreservesSuperviewLayoutMargins:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide ReadableContentGuide {
			[Export ("readableContentGuide", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("readableContentGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("readableContentGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RestorationIdentifier {
			[Export ("restorationIdentifier", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("restorationIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("restorationIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRestorationIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRestorationIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRestorationIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutXAxisAnchor RightAnchor {
			[Export ("rightAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutXAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rightAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rightAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIEdgeInsets SafeAreaInsets {
			[Export ("safeAreaInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("safeAreaInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("safeAreaInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("safeAreaInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("safeAreaInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide SafeAreaLayoutGuide {
			[Export ("safeAreaLayoutGuide", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("safeAreaLayoutGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("safeAreaLayoutGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UISemanticContentAttribute SemanticContentAttribute {
			[Export ("semanticContentAttribute", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISemanticContentAttribute ret;
				if (IsDirectBinding) {
					ret = (UISemanticContentAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("semanticContentAttribute"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISemanticContentAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("semanticContentAttribute"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSemanticContentAttribute:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSemanticContentAttribute:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSemanticContentAttribute:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShouldGroupAccessibilityChildren {
			[Export ("shouldGroupAccessibilityChildren")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldGroupAccessibilityChildren"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldGroupAccessibilityChildren"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldGroupAccessibilityChildren:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldGroupAccessibilityChildren:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShouldGroupAccessibilityChildren:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView[] Subviews {
			[Export ("subviews", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("subviews")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("subviews")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? Superview {
			[Export ("superview")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("superview")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("superview")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Tag {
			[Export ("tag")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tag"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tag"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTag:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTag:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTag:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewTintAdjustmentMode TintAdjustmentMode {
			[Export ("tintAdjustmentMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewTintAdjustmentMode ret;
				if (IsDirectBinding) {
					ret = (UIViewTintAdjustmentMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tintAdjustmentMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIViewTintAdjustmentMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintAdjustmentMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTintAdjustmentMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTintAdjustmentMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTintAdjustmentMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The color used for tinting.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? TintColor {
			[Export ("tintColor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tintColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTintColor:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTintColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTintColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor TopAnchor {
			[Export ("topAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("topAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutXAxisAnchor TrailingAnchor {
			[Export ("trailingAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutXAxisAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("trailingAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutXAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("trailingAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the trait collection that describes the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitCollection")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("traitCollection")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual IUITraitOverrides TraitOverrides {
			[Export ("traitOverrides")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITraitOverrides? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITraitOverrides> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitOverrides")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITraitOverrides> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("traitOverrides")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform Transform {
			[Export ("transform")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("transform"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("transform"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transform"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("transform"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTransform:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("setTransform:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (&__objc_super__, Selector.GetHandle ("setTransform:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreAnimation.CATransform3D Transform3D {
			[Export ("transform3D", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::CoreAnimation.CATransform3D ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend (this.Handle, Selector.GetHandle ("transform3D"));
					} else {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend_stret (this.Handle, Selector.GetHandle ("transform3D"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transform3D"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("transform3D"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTransform3D:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CATransform3D (this.Handle, Selector.GetHandle ("setTransform3D:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CATransform3D (&__objc_super__, Selector.GetHandle ("setTransform3D:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TranslatesAutoresizingMaskIntoConstraints {
			[Export ("translatesAutoresizingMaskIntoConstraints")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("translatesAutoresizingMaskIntoConstraints"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("translatesAutoresizingMaskIntoConstraints"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTranslatesAutoresizingMaskIntoConstraints:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTranslatesAutoresizingMaskIntoConstraints:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setTranslatesAutoresizingMaskIntoConstraints:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Determines whether input events are processed by this view.</summary><value></value><remarks><para>
		/// This property is used to control whether input events are
		/// delivered to the view.  By default all views receive
		/// events.  
		/// 
		/// </para><para>
		/// During animations, UIKit will disable event delivery to
		/// your view unless you pass the <see cref="T:UIKit.UIViewAnimationOptions" />.AllowUserInteraction
		/// flag to your animation function.
		/// 
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserInteractionEnabled {
			[Export ("isUserInteractionEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUserInteractionEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isUserInteractionEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUserInteractionEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUserInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUserInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView ViewForFirstBaselineLayout {
			[Export ("viewForFirstBaselineLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("viewForFirstBaselineLayout")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewForFirstBaselineLayout")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIView ViewForLastBaselineLayout {
			[Export ("viewForLastBaselineLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("viewForLastBaselineLayout")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("viewForLastBaselineLayout")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutDimension WidthAnchor {
			[Export ("widthAnchor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutDimension? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("widthAnchor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("widthAnchor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIWindow? Window {
			[Export ("window")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWindow ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("window")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("window")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnouncementDidFinishNotification;
		/// <summary>Notification constant for AnnouncementDidFinish</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAnnouncementDidFinish(NSObject,EventHandler{UIAccessibilityAnnouncementFinishedEventArgs})" />
		///     or <see cref="Notifications.ObserveAnnouncementDidFinish(EventHandler{UIAccessibilityAnnouncementFinishedEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveAnnouncementDidFinish ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.UIAccessibilityAnnouncementFinishedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveAnnouncementDidFinish (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.AnnouncementDidFinishNotification, (notification) => { Console.WriteLine ("Received the notification AnnouncementDidFinish", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AnnouncementDidFinish", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.AnnouncementDidFinishNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityAnnouncementDidFinishNotification",  "UIKit")]
		[Advice ("Use UIView.Notifications.ObserveAnnouncementDidFinish helper method instead.")]
		public static NSString AnnouncementDidFinishNotification {
			get {
				if (_AnnouncementDidFinishNotification is null)
					_AnnouncementDidFinishNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityAnnouncementDidFinishNotification")!;
				return _AnnouncementDidFinishNotification;
			}
		}
		/// <summary>Gets the notification posted by an application that an announcement requires assistive technology.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityAnnouncementNotification",  "UIKit")]
		public static int AnnouncementNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityAnnouncementNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssistiveTechnologyKey;
		/// <summary>Notification constant for AssistiveTechnologyKey</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAssistiveTechnologyKey(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAssistiveTechnologyKey(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveAssistiveTechnologyKey ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveAssistiveTechnologyKey (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.AssistiveTechnologyKeyNotification, (notification) => { Console.WriteLine ("Received the notification AssistiveTechnologyKey", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AssistiveTechnologyKey", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.AssistiveTechnologyKeyNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityAssistiveTechnologyKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveAssistiveTechnologyKey helper method instead.")]
		public static NSString AssistiveTechnologyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AssistiveTechnologyKey is null)
					_AssistiveTechnologyKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityAssistiveTechnologyKey")!;
				return _AssistiveTechnologyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssistiveTouchStatusDidChangeNotification;
		/// <summary>Notification constant for AssistiveTouchStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAssistiveTouchStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAssistiveTouchStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveAssistiveTouchStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveAssistiveTouchStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.AssistiveTouchStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification AssistiveTouchStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AssistiveTouchStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.AssistiveTouchStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityAssistiveTouchStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveAssistiveTouchStatusDidChange helper method instead.")]
		public static NSString AssistiveTouchStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AssistiveTouchStatusDidChangeNotification is null)
					_AssistiveTouchStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityAssistiveTouchStatusDidChangeNotification")!;
				return _AssistiveTouchStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoldTextStatusDidChangeNotification;
		/// <summary>Notification constant for BoldTextStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveBoldTextStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveBoldTextStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveBoldTextStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveBoldTextStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.BoldTextStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification BoldTextStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification BoldTextStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.BoldTextStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityBoldTextStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveBoldTextStatusDidChange helper method instead.")]
		public static NSString BoldTextStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BoldTextStatusDidChangeNotification is null)
					_BoldTextStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityBoldTextStatusDidChangeNotification")!;
				return _BoldTextStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ButtonShapesEnabledStatusDidChangeNotification;
		/// <summary>Notification constant for ButtonShapesEnabledStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveButtonShapesEnabledStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveButtonShapesEnabledStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveButtonShapesEnabledStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveButtonShapesEnabledStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ButtonShapesEnabledStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ButtonShapesEnabledStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ButtonShapesEnabledStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ButtonShapesEnabledStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityButtonShapesEnabledStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
		[Advice ("Use UIView.Notifications.ObserveButtonShapesEnabledStatusDidChange helper method instead.")]
		public static NSString ButtonShapesEnabledStatusDidChangeNotification {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
			[ObsoletedOSPlatform ("tvos26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
			[ObsoletedOSPlatform ("maccatalyst26.1", "Use 'AXSettings.ShowBordersEnabledStatusDidChangeNotification' instead.")]
			get {
				if (_ButtonShapesEnabledStatusDidChangeNotification is null)
					_ButtonShapesEnabledStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityButtonShapesEnabledStatusDidChangeNotification")!;
				return _ButtonShapesEnabledStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClosedCaptioningStatusDidChangeNotification;
		/// <summary>Notification constant for ClosedCaptioningStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveClosedCaptioningStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveClosedCaptioningStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveClosedCaptioningStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveClosedCaptioningStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ClosedCaptioningStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ClosedCaptioningStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ClosedCaptioningStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ClosedCaptioningStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityClosedCaptioningStatusDidChangeNotification",  "UIKit")]
		[Advice ("Use UIView.Notifications.ObserveClosedCaptioningStatusDidChange helper method instead.")]
		public static NSString ClosedCaptioningStatusDidChangeNotification {
			get {
				if (_ClosedCaptioningStatusDidChangeNotification is null)
					_ClosedCaptioningStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityClosedCaptioningStatusDidChangeNotification")!;
				return _ClosedCaptioningStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DarkerSystemColorsStatusDidChangeNotification;
		/// <summary>Notification constant for DarkerSystemColorsStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDarkerSystemColorsStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDarkerSystemColorsStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveDarkerSystemColorsStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveDarkerSystemColorsStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.DarkerSystemColorsStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification DarkerSystemColorsStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DarkerSystemColorsStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.DarkerSystemColorsStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityDarkerSystemColorsStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveDarkerSystemColorsStatusDidChange helper method instead.")]
		public static NSString DarkerSystemColorsStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DarkerSystemColorsStatusDidChangeNotification is null)
					_DarkerSystemColorsStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityDarkerSystemColorsStatusDidChangeNotification")!;
				return _DarkerSystemColorsStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElementFocusedNotification;
		/// <summary>Notification constant for ElementFocused</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveElementFocused(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveElementFocused(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveElementFocused ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveElementFocused (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ElementFocusedNotification, (notification) => { Console.WriteLine ("Received the notification ElementFocused", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ElementFocused", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ElementFocusedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityElementFocusedNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveElementFocused helper method instead.")]
		public static NSString ElementFocusedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ElementFocusedNotification is null)
					_ElementFocusedNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityElementFocusedNotification")!;
				return _ElementFocusedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocusedElementKey;
		/// <summary>Notification constant for FocusedElementKey</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveFocusedElementKey(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveFocusedElementKey(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveFocusedElementKey ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveFocusedElementKey (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.FocusedElementKeyNotification, (notification) => { Console.WriteLine ("Received the notification FocusedElementKey", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification FocusedElementKey", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.FocusedElementKeyNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityFocusedElementKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveFocusedElementKey helper method instead.")]
		public static NSString FocusedElementKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FocusedElementKey is null)
					_FocusedElementKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityFocusedElementKey")!;
				return _FocusedElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrayscaleStatusDidChangeNotification;
		/// <summary>Notification constant for GrayscaleStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveGrayscaleStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveGrayscaleStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveGrayscaleStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveGrayscaleStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.GrayscaleStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification GrayscaleStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification GrayscaleStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.GrayscaleStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityGrayscaleStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveGrayscaleStatusDidChange helper method instead.")]
		public static NSString GrayscaleStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GrayscaleStatusDidChangeNotification is null)
					_GrayscaleStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityGrayscaleStatusDidChangeNotification")!;
				return _GrayscaleStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GuidedAccessStatusDidChangeNotification;
		/// <summary>Notification constant for GuidedAccessStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveGuidedAccessStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveGuidedAccessStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveGuidedAccessStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveGuidedAccessStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.GuidedAccessStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification GuidedAccessStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification GuidedAccessStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.GuidedAccessStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityGuidedAccessStatusDidChangeNotification",  "UIKit")]
		[Advice ("Use UIView.Notifications.ObserveGuidedAccessStatusDidChange helper method instead.")]
		public static NSString GuidedAccessStatusDidChangeNotification {
			get {
				if (_GuidedAccessStatusDidChangeNotification is null)
					_GuidedAccessStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityGuidedAccessStatusDidChangeNotification")!;
				return _GuidedAccessStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InvertColorsStatusDidChangeNotification;
		/// <summary>Notification constant for InvertColorsStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveInvertColorsStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveInvertColorsStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveInvertColorsStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveInvertColorsStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.InvertColorsStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification InvertColorsStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification InvertColorsStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.InvertColorsStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityInvertColorsStatusDidChangeNotification",  "UIKit")]
		[Advice ("Use UIView.Notifications.ObserveInvertColorsStatusDidChange helper method instead.")]
		public static NSString InvertColorsStatusDidChangeNotification {
			get {
				if (_InvertColorsStatusDidChangeNotification is null)
					_InvertColorsStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityInvertColorsStatusDidChangeNotification")!;
				return _InvertColorsStatusDidChangeNotification;
			}
		}
		/// <summary>Gets the notification posted by an application that the layout of a screen has changed.</summary><value>The layer that the view is being rendered on.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityLayoutChangedNotification",  "UIKit")]
		public static int LayoutChangedNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityLayoutChangedNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MonoAudioStatusDidChangeNotification;
		/// <summary>Notification constant for MonoAudioStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMonoAudioStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMonoAudioStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveMonoAudioStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveMonoAudioStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.MonoAudioStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification MonoAudioStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MonoAudioStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.MonoAudioStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityMonoAudioStatusDidChangeNotification",  "UIKit")]
		[Advice ("Use UIView.Notifications.ObserveMonoAudioStatusDidChange helper method instead.")]
		public static NSString MonoAudioStatusDidChangeNotification {
			get {
				if (_MonoAudioStatusDidChangeNotification is null)
					_MonoAudioStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityMonoAudioStatusDidChangeNotification")!;
				return _MonoAudioStatusDidChangeNotification;
			}
		}
		/// <summary>Represents the value associated with the constant UIViewNoIntrinsicMetric</summary><value></value><remarks><para>This property is associated with the <see cref="P:UIKit.UIView.IntrinsicContentSize" /> method. This value indicates that the <see cref="T:UIKit.UIView" /> has no natural size in a particular dimension.</para></remarks>
		[Field ("UIViewNoIntrinsicMetric",  "UIKit")]
		public static nfloat NoIntrinsicMetric {
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIViewNoIntrinsicMetric");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationSwitchControlIdentifier;
		/// <summary>Notification constant for NotificationSwitchContr</summary><value>NSString constant, should be used as a token to NSNotificationCenter.</value><remarks><para id="tool-remark">This constant can be used with the <see cref="T:Foundation.NSNotificationCenter" /> to register a listener for this notification.   This is an NSString instead of a string, because these values can be used as tokens in some native libraries instead of being used purely for their actual string content.    The 'notification' parameter to the callback contains extra information that is specific to the notification type.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		/// UIBarItem.NotificationSwitchControlIdentifier, (notification) => {Console.WriteLine ("Received the notification UIBarItem", notification); }
		/// 
		/// 
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		/// Console.WriteLine ("Received a notification UIBarItem", notification);
		/// }
		/// 
		/// void Setup ()
		/// {
		/// NSNotificationCenter.DefaultCenter.AddObserver (UIBarItem.NotificationSwitchControlIdentifier, Callback);
		/// }
		/// ]]></code></example></remarks>
		[Field ("UIAccessibilityNotificationSwitchControlIdentifier",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NotificationSwitchControlIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NotificationSwitchControlIdentifier is null)
					_NotificationSwitchControlIdentifier = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityNotificationSwitchControlIdentifier")!;
				return _NotificationSwitchControlIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationVoiceOverIdentifier;
		/// <summary>Notification constant for NotificationVoiceOv</summary><value>NSString constant, should be used as a token to NSNotificationCenter.</value><remarks><para id="tool-remark">This constant can be used with the <see cref="T:Foundation.NSNotificationCenter" /> to register a listener for this notification.   This is an NSString instead of a string, because these values can be used as tokens in some native libraries instead of being used purely for their actual string content.    The 'notification' parameter to the callback contains extra information that is specific to the notification type.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		/// UIBarItem.NotificationVoiceOverIdentifier, (notification) => {Console.WriteLine ("Received the notification UIBarItem", notification); }
		/// 
		/// 
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		/// Console.WriteLine ("Received a notification UIBarItem", notification);
		/// }
		/// 
		/// void Setup ()
		/// {
		/// NSNotificationCenter.DefaultCenter.AddObserver (UIBarItem.NotificationVoiceOverIdentifier, Callback);
		/// }
		/// ]]></code></example></remarks>
		[Field ("UIAccessibilityNotificationVoiceOverIdentifier",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NotificationVoiceOverIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NotificationVoiceOverIdentifier is null)
					_NotificationVoiceOverIdentifier = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityNotificationVoiceOverIdentifier")!;
				return _NotificationVoiceOverIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnOffSwitchLabelsDidChangeNotification;
		/// <summary>Notification constant for OnOffSwitchLabelsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveOnOffSwitchLabelsDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveOnOffSwitchLabelsDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveOnOffSwitchLabelsDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveOnOffSwitchLabelsDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.OnOffSwitchLabelsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification OnOffSwitchLabelsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification OnOffSwitchLabelsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.OnOffSwitchLabelsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityOnOffSwitchLabelsDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use UIView.Notifications.ObserveOnOffSwitchLabelsDidChange helper method instead.")]
		public static NSString OnOffSwitchLabelsDidChangeNotification {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_OnOffSwitchLabelsDidChangeNotification is null)
					_OnOffSwitchLabelsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityOnOffSwitchLabelsDidChangeNotification")!;
				return _OnOffSwitchLabelsDidChangeNotification;
			}
		}
		/// <summary>Gets the notification posted by an application that a scroll action has finished.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityPageScrolledNotification",  "UIKit")]
		public static int PageScrolledNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityPageScrolledNotification");
			}
		}
		/// <summary>Pauses assistive technology notifications.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityPauseAssistiveTechnologyNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static int PauseAssistiveTechnologyNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityPauseAssistiveTechnologyNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrefersCrossFadeTransitionsStatusDidChangeNotification;
		/// <summary>Notification constant for PrefersCrossFadeTransitionsStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification PrefersCrossFadeTransitionsStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PrefersCrossFadeTransitionsStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityPrefersCrossFadeTransitionsStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use UIView.Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange helper method instead.")]
		public static NSString PrefersCrossFadeTransitionsStatusDidChangeNotification {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_PrefersCrossFadeTransitionsStatusDidChangeNotification is null)
					_PrefersCrossFadeTransitionsStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityPrefersCrossFadeTransitionsStatusDidChangeNotification")!;
				return _PrefersCrossFadeTransitionsStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReduceMotionStatusDidChangeNotification;
		/// <summary>Notification constant for ReduceMotionStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveReduceMotionStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveReduceMotionStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveReduceMotionStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveReduceMotionStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ReduceMotionStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ReduceMotionStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ReduceMotionStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ReduceMotionStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityReduceMotionStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveReduceMotionStatusDidChange helper method instead.")]
		public static NSString ReduceMotionStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ReduceMotionStatusDidChangeNotification is null)
					_ReduceMotionStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityReduceMotionStatusDidChangeNotification")!;
				return _ReduceMotionStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReduceTransparencyStatusDidChangeNotification;
		/// <summary>Notification constant for ReduceTransparencyStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveReduceTransparencyStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveReduceTransparencyStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveReduceTransparencyStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveReduceTransparencyStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ReduceTransparencyStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ReduceTransparencyStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ReduceTransparencyStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ReduceTransparencyStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityReduceTransparencyStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveReduceTransparencyStatusDidChange helper method instead.")]
		public static NSString ReduceTransparencyStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ReduceTransparencyStatusDidChangeNotification is null)
					_ReduceTransparencyStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityReduceTransparencyStatusDidChangeNotification")!;
				return _ReduceTransparencyStatusDidChangeNotification;
			}
		}
		/// <summary>Resumes assistive technology notifications.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityResumeAssistiveTechnologyNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static int ResumeAssistiveTechnologyNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityResumeAssistiveTechnologyNotification");
			}
		}
		/// <summary>Gets the notification posted by an application that a new view appears that includes a major portion of the screen.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityScreenChangedNotification",  "UIKit")]
		public static int ScreenChangedNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.UIKit.Handle, "UIAccessibilityScreenChangedNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShakeToUndoDidChangeNotification;
		/// <summary>Notification constant for ShakeToUndoDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveShakeToUndoDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveShakeToUndoDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveShakeToUndoDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveShakeToUndoDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ShakeToUndoDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ShakeToUndoDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ShakeToUndoDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ShakeToUndoDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityShakeToUndoDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveShakeToUndoDidChange helper method instead.")]
		public static NSString ShakeToUndoDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ShakeToUndoDidChangeNotification is null)
					_ShakeToUndoDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityShakeToUndoDidChangeNotification")!;
				return _ShakeToUndoDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldDifferentiateWithoutColorDidChangeNotification;
		/// <summary>Notification constant for ShouldDifferentiateWithoutColorDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveShouldDifferentiateWithoutColorDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveShouldDifferentiateWithoutColorDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveShouldDifferentiateWithoutColorDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveShouldDifferentiateWithoutColorDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.ShouldDifferentiateWithoutColorDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ShouldDifferentiateWithoutColorDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ShouldDifferentiateWithoutColorDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.ShouldDifferentiateWithoutColorDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityShouldDifferentiateWithoutColorDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use UIView.Notifications.ObserveShouldDifferentiateWithoutColorDidChange helper method instead.")]
		public static NSString ShouldDifferentiateWithoutColorDidChangeNotification {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ShouldDifferentiateWithoutColorDidChangeNotification is null)
					_ShouldDifferentiateWithoutColorDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityShouldDifferentiateWithoutColorDidChangeNotification")!;
				return _ShouldDifferentiateWithoutColorDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeakScreenStatusDidChangeNotification;
		/// <summary>Notification constant for SpeakScreenStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSpeakScreenStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSpeakScreenStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveSpeakScreenStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveSpeakScreenStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.SpeakScreenStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification SpeakScreenStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SpeakScreenStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.SpeakScreenStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilitySpeakScreenStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveSpeakScreenStatusDidChange helper method instead.")]
		public static NSString SpeakScreenStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SpeakScreenStatusDidChangeNotification is null)
					_SpeakScreenStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeakScreenStatusDidChangeNotification")!;
				return _SpeakScreenStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeakSelectionStatusDidChangeNotification;
		/// <summary>Notification constant for SpeakSelectionStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSpeakSelectionStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSpeakSelectionStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveSpeakSelectionStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveSpeakSelectionStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.SpeakSelectionStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification SpeakSelectionStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SpeakSelectionStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.SpeakSelectionStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilitySpeakSelectionStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveSpeakSelectionStatusDidChange helper method instead.")]
		public static NSString SpeakSelectionStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SpeakSelectionStatusDidChangeNotification is null)
					_SpeakSelectionStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeakSelectionStatusDidChangeNotification")!;
				return _SpeakSelectionStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributeAnnouncementPriority;
		/// <summary>Represents the value associated with the constant 'UIAccessibilitySpeechAttributeAnnouncementPriority'.</summary>
		[Field ("UIAccessibilitySpeechAttributeAnnouncementPriority",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString SpeechAttributeAnnouncementPriority {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_SpeechAttributeAnnouncementPriority is null)
					_SpeechAttributeAnnouncementPriority = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributeAnnouncementPriority")!;
				return _SpeechAttributeAnnouncementPriority;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributeIpaNotation;
		/// <summary>Returns the IPA notation for the accessibility attributed string.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilitySpeechAttributeIPANotation",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SpeechAttributeIpaNotation {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SpeechAttributeIpaNotation is null)
					_SpeechAttributeIpaNotation = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributeIPANotation")!;
				return _SpeechAttributeIpaNotation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributeLanguage;
		/// <summary>Gets a BCP-47 language code.</summary><value>A BCP-47 language code.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilitySpeechAttributeLanguage",  "UIKit")]
		public static NSString SpeechAttributeLanguage {
			get {
				if (_SpeechAttributeLanguage is null)
					_SpeechAttributeLanguage = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributeLanguage")!;
				return _SpeechAttributeLanguage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributePitch;
		/// <summary>Gets the value from 0.0 to 2.0 that determines the pitch for a spoken string.</summary><value>Values range from 0.0 (low pitch) to 2.0 (high pitch).</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilitySpeechAttributePitch",  "UIKit")]
		public static NSString SpeechAttributePitch {
			get {
				if (_SpeechAttributePitch is null)
					_SpeechAttributePitch = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributePitch")!;
				return _SpeechAttributePitch;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributePunctuation;
		/// <summary>Gets a value to be interpreted as a <see langword="bool" /> that determines whether the punctuation in a string is pronounced.</summary><value>String indicating whether punctuation is pronounced.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilitySpeechAttributePunctuation",  "UIKit")]
		public static NSString SpeechAttributePunctuation {
			get {
				if (_SpeechAttributePunctuation is null)
					_SpeechAttributePunctuation = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributePunctuation")!;
				return _SpeechAttributePunctuation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributeQueueAnnouncement;
		/// <summary>Key for option that spoken text interrupt existing spoken content.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilitySpeechAttributeQueueAnnouncement",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SpeechAttributeQueueAnnouncement {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SpeechAttributeQueueAnnouncement is null)
					_SpeechAttributeQueueAnnouncement = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributeQueueAnnouncement")!;
				return _SpeechAttributeQueueAnnouncement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeechAttributeSpellOut;
		/// <summary>Represents the value associated with the constant 'UIAccessibilitySpeechAttributeSpellOut'.</summary>
		[Field ("UIAccessibilitySpeechAttributeSpellOut",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString SpeechAttributeSpellOut {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_SpeechAttributeSpellOut is null)
					_SpeechAttributeSpellOut = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySpeechAttributeSpellOut")!;
				return _SpeechAttributeSpellOut;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SwitchControlStatusDidChangeNotification;
		/// <summary>Notification constant for SwitchControlStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSwitchControlStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSwitchControlStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveSwitchControlStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveSwitchControlStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.SwitchControlStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification SwitchControlStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SwitchControlStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.SwitchControlStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilitySwitchControlStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveSwitchControlStatusDidChange helper method instead.")]
		public static NSString SwitchControlStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SwitchControlStatusDidChangeNotification is null)
					_SwitchControlStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilitySwitchControlStatusDidChangeNotification")!;
				return _SwitchControlStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAttributeContext;
		/// <summary>Represents the value associated with the constant 'UIAccessibilityTextAttributeContext'.</summary>
		[Field ("UIAccessibilityTextAttributeContext",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString TextAttributeContext {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_TextAttributeContext is null)
					_TextAttributeContext = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityTextAttributeContext")!;
				return _TextAttributeContext;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAttributeCustom;
		/// <summary>Key for option that custom attributes be applied to the accessibility text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityTextAttributeCustom",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TextAttributeCustom {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TextAttributeCustom is null)
					_TextAttributeCustom = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityTextAttributeCustom")!;
				return _TextAttributeCustom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextAttributeHeadingLevel;
		/// <summary>Key for option of the accessibility text's heading level.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityTextAttributeHeadingLevel",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TextAttributeHeadingLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TextAttributeHeadingLevel is null)
					_TextAttributeHeadingLevel = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityTextAttributeHeadingLevel")!;
				return _TextAttributeHeadingLevel;
			}
		}
		/// <summary>Gets a trait that allows continuous adjustment of an accessibility element through a range of values.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitAdjustable",  "UIKit")]
		public static long TraitAdjustable {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitAdjustable");
			}
		}
		/// <summary>Gets a trait that allows direct touch interaction for users.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitAllowsDirectInteraction",  "UIKit")]
		public static long TraitAllowsDirectInteraction {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitAllowsDirectInteraction");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should be treated as a button.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitButton",  "UIKit")]
		public static long TraitButton {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitButton");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should turn the page when VoiceOver finishes that page.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitCausesPageTurn",  "UIKit")]
		public static long TraitCausesPageTurn {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitCausesPageTurn");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element is a header that divides content into sections.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitHeader",  "UIKit")]
		public static long TraitHeader {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitHeader");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should be treated as an image.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitImage",  "UIKit")]
		public static long TraitImage {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitImage");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element acts like a keyboard key.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitKeyboardKey",  "UIKit")]
		public static long TraitKeyboardKey {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitKeyboardKey");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should be considered a link.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitLink",  "UIKit")]
		public static long TraitLink {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitLink");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element has no traits.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitNone",  "UIKit")]
		public static long TraitNone {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitNone");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element is not enabled.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitNotEnabled",  "UIKit")]
		public static long TraitNotEnabled {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitNotEnabled");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> elements plays its own sound when activated.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitPlaysSound",  "UIKit")]
		public static long TraitPlaysSound {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitPlaysSound");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should be considered a search field.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitSearchField",  "UIKit")]
		public static long TraitSearchField {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitSearchField");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element is selected.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitSelected",  "UIKit")]
		public static long TraitSelected {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitSelected");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element starts a media session when it is activated.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitStartsMediaSession",  "UIKit")]
		public static long TraitStartsMediaSession {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitStartsMediaSession");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element should be treated as static text.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitStaticText",  "UIKit")]
		public static long TraitStaticText {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitStaticText");
			}
		}
		/// <summary>Gets a trait that provides summary information when an application starts.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitSummaryElement",  "UIKit")]
		public static long TraitSummaryElement {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitSummaryElement");
			}
		}
		/// <summary>Represents the value associated with the constant 'UIAccessibilityTraitTabBar'.</summary>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitTabBar",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static long TraitTabBar {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitTabBar");
			}
		}
		/// <summary>Gets a trait that indicates that <c>this</c> <see cref="T:UIKit.IUIAccessibilityIdentification" /> element updates its <see cref="UIKit.UIImage.AccessibilityLabel" /> or <see cref="UIKit.UIImage.AccessibilityValue" />.</summary><value>The value to be set for the trait.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'UIAccessibilityTraits' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("UIAccessibilityTraitUpdatesFrequently",  "UIKit")]
		public static long TraitUpdatesFrequently {
			get {
				return Dlfcn.GetInt64 (Libraries.UIKit.Handle, "UIAccessibilityTraitUpdatesFrequently");
			}
		}
		/// <summary>Represents the value associated with the constant UILayoutFittingCompressedSize</summary><value></value><remarks>Indicates that <see cref="M:UIKit.UIView.SystemLayoutSizeFittingSize(CoreGraphics.CGSize,System.Single,System.Single)" /> should calculate the smallest possible size.</remarks><altmember cref="M:UIKit.UIView.SystemLayoutSizeFittingSize(CoreGraphics.CGSize)" />
		[Field ("UILayoutFittingCompressedSize",  "UIKit")]
		public static CGSize UILayoutFittingCompressedSize {
			get {
				return Dlfcn.GetCGSize (Libraries.UIKit.Handle, "UILayoutFittingCompressedSize");
			}
		}
		/// <summary>Represents the value associated with the constant UILayoutFittingExpandedSize</summary><value></value><remarks>Indicates that <see cref="M:UIKit.UIView.SystemLayoutSizeFittingSize(CoreGraphics.CGSize,System.Single,System.Single)" /> should calculate the largest possible size.</remarks><altmember cref="M:UIKit.UIView.SystemLayoutSizeFittingSize(CoreGraphics.CGSize)" />
		[Field ("UILayoutFittingExpandedSize",  "UIKit")]
		public static CGSize UILayoutFittingExpandedSize {
			get {
				return Dlfcn.GetCGSize (Libraries.UIKit.Handle, "UILayoutFittingExpandedSize");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnfocusedElementKey;
		/// <summary>Notification constant for UnfocusedElementKey</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUnfocusedElementKey(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUnfocusedElementKey(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveUnfocusedElementKey ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveUnfocusedElementKey (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.UnfocusedElementKeyNotification, (notification) => { Console.WriteLine ("Received the notification UnfocusedElementKey", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UnfocusedElementKey", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.UnfocusedElementKeyNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityUnfocusedElementKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveUnfocusedElementKey helper method instead.")]
		public static NSString UnfocusedElementKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UnfocusedElementKey is null)
					_UnfocusedElementKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityUnfocusedElementKey")!;
				return _UnfocusedElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VideoAutoplayStatusDidChangeNotification;
		/// <summary>Notification constant for VideoAutoplayStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveVideoAutoplayStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveVideoAutoplayStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveVideoAutoplayStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveVideoAutoplayStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.VideoAutoplayStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification VideoAutoplayStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification VideoAutoplayStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.VideoAutoplayStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityVideoAutoplayStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use UIView.Notifications.ObserveVideoAutoplayStatusDidChange helper method instead.")]
		public static NSString VideoAutoplayStatusDidChangeNotification {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_VideoAutoplayStatusDidChangeNotification is null)
					_VideoAutoplayStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityVideoAutoplayStatusDidChangeNotification")!;
				return _VideoAutoplayStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VoiceOverStatusChanged;
		/// <summary>Developers should not use this deprecated property. Developers should use 'VoiceOverStatusDidChangeNotification' instead.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIAccessibilityVoiceOverStatusChanged",  "UIKit")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString VoiceOverStatusChanged {
			[ObsoletedOSPlatform ("ios11.0", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
			[ObsoletedOSPlatform ("tvos11.0", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'VoiceOverStatusDidChangeNotification' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_VoiceOverStatusChanged is null)
					_VoiceOverStatusChanged = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityVoiceOverStatusChanged")!;
				return _VoiceOverStatusChanged;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VoiceOverStatusDidChangeNotification;
		/// <summary>Notification constant for VoiceOverStatusDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveVoiceOverStatusDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveVoiceOverStatusDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UIView.Notifications.ObserveVoiceOverStatusDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UIView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIView.Notifications.ObserveVoiceOverStatusDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UIView.VoiceOverStatusDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification VoiceOverStatusDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification VoiceOverStatusDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIView.VoiceOverStatusDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIAccessibilityVoiceOverStatusDidChangeNotification",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use UIView.Notifications.ObserveVoiceOverStatusDidChange helper method instead.")]
		public static NSString VoiceOverStatusDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VoiceOverStatusDidChangeNotification is null)
					_VoiceOverStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIAccessibilityVoiceOverStatusDidChangeNotification")!;
				return _VoiceOverStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentFocusEnvironment_var = null;
				__mt_PreferredFocusedView_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UIView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UIView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UIView.Appearance" /> property or by calling <see cref="global::UIKit.UIView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UIViewAppearance : UIAppearance {
			protected internal UIViewAppearance (IntPtr handle) : base (handle) {}
			/// <summary>The color used for the background.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIColor? BackgroundColor {
				[Export ("backgroundColor", ArgumentSemantic.Retain)]
				get {
					global::UIKit.UIApplication.EnsureUIThread ();
					UIColor? ret;
					if (IsDirectBinding) {
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("backgroundColor")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
				[Export ("setBackgroundColor:", ArgumentSemantic.Retain)]
				set {
					global::UIKit.UIApplication.EnsureUIThread ();
					var value__handle__ = value.GetHandle ();
					if (IsDirectBinding) {
						global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value__handle__);
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setBackgroundColor:"), value__handle__);
							GC.KeepAlive (this);
						}
					}
					GC.KeepAlive (value);
				}
			}
			/// <summary>The color used for tinting.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIColor? TintColor {
				[Export ("tintColor")]
				get {
					global::UIKit.UIApplication.EnsureUIThread ();
					UIColor? ret;
					if (IsDirectBinding) {
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tintColor")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintColor")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
				[Export ("setTintColor:")]
				set {
					global::UIKit.UIApplication.EnsureUIThread ();
					var value__handle__ = value.GetHandle ();
					if (IsDirectBinding) {
						global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTintColor:"), value__handle__);
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTintColor:"), value__handle__);
							GC.KeepAlive (this);
						}
					}
					GC.KeepAlive (value);
				}
			}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UIView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIView" />, they should use the <see cref="global::UIKit.UIView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static UIViewAppearance Appearance {
			get { return new UIViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIView.UIViewAppearance" /> for the subclass of <see cref="global::UIKit.UIView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIView.Appearance" /> property, or the <see cref="global::UIKit.UIView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UIView.GetAppearance<MyUIViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance GetAppearance<T> () where T: UIView {
			return new UIViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UIView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIView" />, they should use the <see cref="global::UIKit.UIView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UIViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIView.UIViewAppearance" /> for <see cref="global::UIKit.UIView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIView" />, they should use the <see cref="global::UIKit.UIView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance GetAppearance (UITraitCollection traits) {
			return new UIViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIView.UIViewAppearance" /> for <see cref="global::UIKit.UIView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIView" />, they should use the <see cref="global::UIKit.UIView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UIViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIView.UIViewAppearance" /> for the subclass of <see cref="global::UIKit.UIView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIView.Appearance" /> property, or the <see cref="global::UIKit.UIView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIView.GetAppearance<MyUIViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance GetAppearance<T> (UITraitCollection traits) where T: UIView {
			return new UIViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIView.UIViewAppearance" /> for the subclass of <see cref="global::UIKit.UIView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIView.Appearance" /> property, or the <see cref="global::UIKit.UIView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIView.GetAppearance<MyUIViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static UIViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UIView{
			return new UIViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UIView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AnnouncementDidFinishNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AnnouncementDidFinishNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveAnnouncementDidFinish ((notification) => {
			///   Console.WriteLine ("Observed AnnouncementDidFinishNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnouncementDidFinish (EventHandler<UIKit.UIAccessibilityAnnouncementFinishedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementDidFinishNotification, notification => handler (null, new UIKit.UIAccessibilityAnnouncementFinishedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AnnouncementDidFinishNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AnnouncementDidFinishNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveAnnouncementDidFinish (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AnnouncementDidFinishNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnouncementDidFinish (NSObject objectToObserve, EventHandler<UIKit.UIAccessibilityAnnouncementFinishedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementDidFinishNotification, notification => handler (null, new UIKit.UIAccessibilityAnnouncementFinishedEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AssistiveTechnologyKey" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AssistiveTechnologyKey" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveAssistiveTechnologyKey ((notification) => {
			///   Console.WriteLine ("Observed AssistiveTechnologyKeyNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAssistiveTechnologyKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTechnologyKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AssistiveTechnologyKey" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AssistiveTechnologyKey" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveAssistiveTechnologyKey (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AssistiveTechnologyKeyNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAssistiveTechnologyKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTechnologyKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AssistiveTouchStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AssistiveTouchStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveAssistiveTouchStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed AssistiveTouchStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAssistiveTouchStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTouchStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.AssistiveTouchStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.AssistiveTouchStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveAssistiveTouchStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AssistiveTouchStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAssistiveTouchStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTouchStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.BoldTextStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.BoldTextStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveBoldTextStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed BoldTextStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveBoldTextStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BoldTextStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.BoldTextStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.BoldTextStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveBoldTextStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed BoldTextStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveBoldTextStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BoldTextStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ButtonShapesEnabledStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ButtonShapesEnabledStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveButtonShapesEnabledStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed ButtonShapesEnabledStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveButtonShapesEnabledStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ButtonShapesEnabledStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ButtonShapesEnabledStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ButtonShapesEnabledStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveButtonShapesEnabledStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ButtonShapesEnabledStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveButtonShapesEnabledStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ButtonShapesEnabledStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ClosedCaptioningStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ClosedCaptioningStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveClosedCaptioningStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed ClosedCaptioningStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveClosedCaptioningStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ClosedCaptioningStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ClosedCaptioningStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ClosedCaptioningStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveClosedCaptioningStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ClosedCaptioningStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveClosedCaptioningStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ClosedCaptioningStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.DarkerSystemColorsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.DarkerSystemColorsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveDarkerSystemColorsStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed DarkerSystemColorsStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDarkerSystemColorsStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DarkerSystemColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.DarkerSystemColorsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.DarkerSystemColorsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveDarkerSystemColorsStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DarkerSystemColorsStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDarkerSystemColorsStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DarkerSystemColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ElementFocusedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ElementFocusedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveElementFocused ((notification) => {
			///   Console.WriteLine ("Observed ElementFocusedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveElementFocused (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ElementFocusedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ElementFocusedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ElementFocusedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveElementFocused (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ElementFocusedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveElementFocused (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ElementFocusedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.FocusedElementKey" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.FocusedElementKey" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveFocusedElementKey ((notification) => {
			///   Console.WriteLine ("Observed FocusedElementKeyNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFocusedElementKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.FocusedElementKey" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.FocusedElementKey" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveFocusedElementKey (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed FocusedElementKeyNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFocusedElementKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.GrayscaleStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.GrayscaleStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveGrayscaleStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed GrayscaleStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrayscaleStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrayscaleStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.GrayscaleStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.GrayscaleStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveGrayscaleStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed GrayscaleStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrayscaleStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrayscaleStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.GuidedAccessStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.GuidedAccessStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveGuidedAccessStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed GuidedAccessStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGuidedAccessStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GuidedAccessStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.GuidedAccessStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.GuidedAccessStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveGuidedAccessStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed GuidedAccessStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGuidedAccessStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GuidedAccessStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.InvertColorsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.InvertColorsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveInvertColorsStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed InvertColorsStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInvertColorsStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InvertColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.InvertColorsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.InvertColorsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveInvertColorsStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed InvertColorsStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInvertColorsStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InvertColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.MonoAudioStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.MonoAudioStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveMonoAudioStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed MonoAudioStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMonoAudioStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MonoAudioStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.MonoAudioStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.MonoAudioStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveMonoAudioStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MonoAudioStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMonoAudioStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MonoAudioStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.OnOffSwitchLabelsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.OnOffSwitchLabelsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveOnOffSwitchLabelsDidChange ((notification) => {
			///   Console.WriteLine ("Observed OnOffSwitchLabelsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveOnOffSwitchLabelsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (OnOffSwitchLabelsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.OnOffSwitchLabelsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.OnOffSwitchLabelsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveOnOffSwitchLabelsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed OnOffSwitchLabelsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveOnOffSwitchLabelsDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (OnOffSwitchLabelsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed PrefersCrossFadeTransitionsStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePrefersCrossFadeTransitionsStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PrefersCrossFadeTransitionsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.PrefersCrossFadeTransitionsStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObservePrefersCrossFadeTransitionsStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PrefersCrossFadeTransitionsStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePrefersCrossFadeTransitionsStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PrefersCrossFadeTransitionsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ReduceMotionStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ReduceMotionStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveReduceMotionStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed ReduceMotionStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveReduceMotionStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceMotionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ReduceMotionStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ReduceMotionStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveReduceMotionStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ReduceMotionStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveReduceMotionStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceMotionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ReduceTransparencyStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ReduceTransparencyStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveReduceTransparencyStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed ReduceTransparencyStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveReduceTransparencyStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceTransparencyStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ReduceTransparencyStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ReduceTransparencyStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveReduceTransparencyStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ReduceTransparencyStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveReduceTransparencyStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceTransparencyStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ShakeToUndoDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ShakeToUndoDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveShakeToUndoDidChange ((notification) => {
			///   Console.WriteLine ("Observed ShakeToUndoDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShakeToUndoDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShakeToUndoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ShakeToUndoDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ShakeToUndoDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveShakeToUndoDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ShakeToUndoDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShakeToUndoDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShakeToUndoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ShouldDifferentiateWithoutColorDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ShouldDifferentiateWithoutColorDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveShouldDifferentiateWithoutColorDidChange ((notification) => {
			///   Console.WriteLine ("Observed ShouldDifferentiateWithoutColorDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShouldDifferentiateWithoutColorDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShouldDifferentiateWithoutColorDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.ShouldDifferentiateWithoutColorDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.ShouldDifferentiateWithoutColorDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveShouldDifferentiateWithoutColorDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ShouldDifferentiateWithoutColorDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveShouldDifferentiateWithoutColorDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShouldDifferentiateWithoutColorDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SpeakScreenStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SpeakScreenStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveSpeakScreenStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed SpeakScreenStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSpeakScreenStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakScreenStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SpeakScreenStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SpeakScreenStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveSpeakScreenStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SpeakScreenStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSpeakScreenStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakScreenStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SpeakSelectionStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SpeakSelectionStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveSpeakSelectionStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed SpeakSelectionStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSpeakSelectionStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakSelectionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SpeakSelectionStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SpeakSelectionStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveSpeakSelectionStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SpeakSelectionStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSpeakSelectionStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakSelectionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SwitchControlStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SwitchControlStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveSwitchControlStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed SwitchControlStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSwitchControlStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SwitchControlStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.SwitchControlStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.SwitchControlStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveSwitchControlStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SwitchControlStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSwitchControlStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SwitchControlStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.UnfocusedElementKey" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.UnfocusedElementKey" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveUnfocusedElementKey ((notification) => {
			///   Console.WriteLine ("Observed UnfocusedElementKeyNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUnfocusedElementKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnfocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.UnfocusedElementKey" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.UnfocusedElementKey" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveUnfocusedElementKey (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UnfocusedElementKeyNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUnfocusedElementKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnfocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.VideoAutoplayStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.VideoAutoplayStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveVideoAutoplayStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed VideoAutoplayStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVideoAutoplayStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VideoAutoplayStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.VideoAutoplayStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.VideoAutoplayStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveVideoAutoplayStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed VideoAutoplayStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVideoAutoplayStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VideoAutoplayStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.VoiceOverStatusDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.VoiceOverStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIView.Notifications.ObserveVoiceOverStatusDidChange ((notification) => {
			///   Console.WriteLine ("Observed VoiceOverStatusDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVoiceOverStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VoiceOverStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIView.VoiceOverStatusDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIView.VoiceOverStatusDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIView.Notifications.ObserveVoiceOverStatusDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed VoiceOverStatusDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVoiceOverStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VoiceOverStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UIView */
}
