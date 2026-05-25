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
	[Register("NSViewAnimation", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSViewAnimation : NSAnimation {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationForKey_X = "animationForKey:";
		static readonly NativeHandle selAnimationForKey_XHandle = Selector.GetHandle ("animationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationsX = "animations";
		static readonly NativeHandle selAnimationsXHandle = Selector.GetHandle ("animations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimatorX = "animator";
		static readonly NativeHandle selAnimatorXHandle = Selector.GetHandle ("animator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultAnimationForKey_X = "defaultAnimationForKey:";
		static readonly NativeHandle selDefaultAnimationForKey_XHandle = Selector.GetHandle ("defaultAnimationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDuration_AnimationCurve_X = "initWithDuration:animationCurve:";
		static readonly NativeHandle selInitWithDuration_AnimationCurve_XHandle = Selector.GetHandle ("initWithDuration:animationCurve:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithViewAnimations_X = "initWithViewAnimations:";
		static readonly NativeHandle selInitWithViewAnimations_XHandle = Selector.GetHandle ("initWithViewAnimations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimations_X = "setAnimations:";
		static readonly NativeHandle selSetAnimations_XHandle = Selector.GetHandle ("setAnimations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetViewAnimations_X = "setViewAnimations:";
		static readonly NativeHandle selSetViewAnimations_XHandle = Selector.GetHandle ("setViewAnimations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewAnimationsX = "viewAnimations";
		static readonly NativeHandle selViewAnimationsXHandle = Selector.GetHandle ("viewAnimations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSViewAnimation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSViewAnimation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSViewAnimation () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		public NSViewAnimation (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected NSViewAnimation (NSObjectFlag t) : base (t)
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
		protected internal NSViewAnimation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithViewAnimations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSViewAnimation (NSDictionary[] viewAnimations)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (viewAnimations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (viewAnimations));
			using var nsa_viewAnimations = NSArray.FromNSObjects (viewAnimations);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithViewAnimations_XHandle, nsa_viewAnimations.Handle), "initWithViewAnimations:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithViewAnimations_XHandle, nsa_viewAnimations.Handle), "initWithViewAnimations:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithDuration:animationCurve:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSViewAnimation (double duration, NSAnimationCurve animationCurve)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_UIntPtr (this.Handle, selInitWithDuration_AnimationCurve_XHandle, duration, (UIntPtr) (ulong) animationCurve), "initWithDuration:animationCurve:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double_UIntPtr (&__objc_super__, selInitWithDuration_AnimationCurve_XHandle, duration, (UIntPtr) (ulong) animationCurve), "initWithDuration:animationCurve:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("animationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject AnimationForKey (string key)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAnimationForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("defaultAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject DefaultAnimationForKey (string key)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDefaultAnimationForKey_XHandle, nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Animations {
			[Export ("animations")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAnimations:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAnimations_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAnimations_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Animator {
			[Export ("animator")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				ret.IsDirectBinding = true;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary[] ViewAnimations {
			[Export ("viewAnimations", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewAnimationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewAnimationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setViewAnimations:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetViewAnimations_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetViewAnimations_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EffectKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationEffectKey",  "AppKit")]
		public static NSString EffectKey {
			get {
				if (_EffectKey is null)
					_EffectKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationEffectKey")!;
				return _EffectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EndFrameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationEndFrameKey",  "AppKit")]
		public static NSString EndFrameKey {
			get {
				if (_EndFrameKey is null)
					_EndFrameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationEndFrameKey")!;
				return _EndFrameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FadeInEffect;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationFadeInEffect",  "AppKit")]
		public static NSString FadeInEffect {
			get {
				if (_FadeInEffect is null)
					_FadeInEffect = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationFadeInEffect")!;
				return _FadeInEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FadeOutEffect;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationFadeOutEffect",  "AppKit")]
		public static NSString FadeOutEffect {
			get {
				if (_FadeOutEffect is null)
					_FadeOutEffect = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationFadeOutEffect")!;
				return _FadeOutEffect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StartFrameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationStartFrameKey",  "AppKit")]
		public static NSString StartFrameKey {
			get {
				if (_StartFrameKey is null)
					_StartFrameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationStartFrameKey")!;
				return _StartFrameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSViewAnimationTargetKey",  "AppKit")]
		public static NSString TargetKey {
			get {
				if (_TargetKey is null)
					_TargetKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSViewAnimationTargetKey")!;
				return _TargetKey;
			}
		}
	} /* class NSViewAnimation */
}
