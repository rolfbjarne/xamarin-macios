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
	[Register("NSGestureRecognizer", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSGestureRecognizer : NSObject, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionX = "action";
		static readonly NativeHandle selActionXHandle = Selector.GetHandle ("action");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanBePreventedByGestureRecognizer_X = "canBePreventedByGestureRecognizer:";
		static readonly NativeHandle selCanBePreventedByGestureRecognizer_XHandle = Selector.GetHandle ("canBePreventedByGestureRecognizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPreventGestureRecognizer_X = "canPreventGestureRecognizer:";
		static readonly NativeHandle selCanPreventGestureRecognizer_XHandle = Selector.GetHandle ("canPreventGestureRecognizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysKeyEventsX = "delaysKeyEvents";
		static readonly NativeHandle selDelaysKeyEventsXHandle = Selector.GetHandle ("delaysKeyEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysMagnificationEventsX = "delaysMagnificationEvents";
		static readonly NativeHandle selDelaysMagnificationEventsXHandle = Selector.GetHandle ("delaysMagnificationEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysOtherMouseButtonEventsX = "delaysOtherMouseButtonEvents";
		static readonly NativeHandle selDelaysOtherMouseButtonEventsXHandle = Selector.GetHandle ("delaysOtherMouseButtonEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysPrimaryMouseButtonEventsX = "delaysPrimaryMouseButtonEvents";
		static readonly NativeHandle selDelaysPrimaryMouseButtonEventsXHandle = Selector.GetHandle ("delaysPrimaryMouseButtonEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysRotationEventsX = "delaysRotationEvents";
		static readonly NativeHandle selDelaysRotationEventsXHandle = Selector.GetHandle ("delaysRotationEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelaysSecondaryMouseButtonEventsX = "delaysSecondaryMouseButtonEvents";
		static readonly NativeHandle selDelaysSecondaryMouseButtonEventsXHandle = Selector.GetHandle ("delaysSecondaryMouseButtonEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlagsChanged_X = "flagsChanged:";
		static readonly NativeHandle selFlagsChanged_XHandle = Selector.GetHandle ("flagsChanged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTarget_Action_X = "initWithTarget:action:";
		static readonly NativeHandle selInitWithTarget_Action_XHandle = Selector.GetHandle ("initWithTarget:action:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyDown_X = "keyDown:";
		static readonly NativeHandle selKeyDown_XHandle = Selector.GetHandle ("keyDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyUp_X = "keyUp:";
		static readonly NativeHandle selKeyUp_XHandle = Selector.GetHandle ("keyUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationInView_X = "locationInView:";
		static readonly NativeHandle selLocationInView_XHandle = Selector.GetHandle ("locationInView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagnifyWithEvent_X = "magnifyWithEvent:";
		static readonly NativeHandle selMagnifyWithEvent_XHandle = Selector.GetHandle ("magnifyWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModifierFlagsX = "modifierFlags";
		static readonly NativeHandle selModifierFlagsXHandle = Selector.GetHandle ("modifierFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseCancelled_X = "mouseCancelled:";
		static readonly NativeHandle selMouseCancelled_XHandle = Selector.GetHandle ("mouseCancelled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseDown_X = "mouseDown:";
		static readonly NativeHandle selMouseDown_XHandle = Selector.GetHandle ("mouseDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseDragged_X = "mouseDragged:";
		static readonly NativeHandle selMouseDragged_XHandle = Selector.GetHandle ("mouseDragged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseUp_X = "mouseUp:";
		static readonly NativeHandle selMouseUp_XHandle = Selector.GetHandle ("mouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOtherMouseDown_X = "otherMouseDown:";
		static readonly NativeHandle selOtherMouseDown_XHandle = Selector.GetHandle ("otherMouseDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOtherMouseDragged_X = "otherMouseDragged:";
		static readonly NativeHandle selOtherMouseDragged_XHandle = Selector.GetHandle ("otherMouseDragged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOtherMouseUp_X = "otherMouseUp:";
		static readonly NativeHandle selOtherMouseUp_XHandle = Selector.GetHandle ("otherMouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPressureChangeWithEvent_X = "pressureChangeWithEvent:";
		static readonly NativeHandle selPressureChangeWithEvent_XHandle = Selector.GetHandle ("pressureChangeWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPressureConfigurationX = "pressureConfiguration";
		static readonly NativeHandle selPressureConfigurationXHandle = Selector.GetHandle ("pressureConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetX = "reset";
		static readonly NativeHandle selResetXHandle = Selector.GetHandle ("reset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightMouseDown_X = "rightMouseDown:";
		static readonly NativeHandle selRightMouseDown_XHandle = Selector.GetHandle ("rightMouseDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightMouseDragged_X = "rightMouseDragged:";
		static readonly NativeHandle selRightMouseDragged_XHandle = Selector.GetHandle ("rightMouseDragged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightMouseUp_X = "rightMouseUp:";
		static readonly NativeHandle selRightMouseUp_XHandle = Selector.GetHandle ("rightMouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateWithEvent_X = "rotateWithEvent:";
		static readonly NativeHandle selRotateWithEvent_XHandle = Selector.GetHandle ("rotateWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAction_X = "setAction:";
		static readonly NativeHandle selSetAction_XHandle = Selector.GetHandle ("setAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysKeyEvents_X = "setDelaysKeyEvents:";
		static readonly NativeHandle selSetDelaysKeyEvents_XHandle = Selector.GetHandle ("setDelaysKeyEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysMagnificationEvents_X = "setDelaysMagnificationEvents:";
		static readonly NativeHandle selSetDelaysMagnificationEvents_XHandle = Selector.GetHandle ("setDelaysMagnificationEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysOtherMouseButtonEvents_X = "setDelaysOtherMouseButtonEvents:";
		static readonly NativeHandle selSetDelaysOtherMouseButtonEvents_XHandle = Selector.GetHandle ("setDelaysOtherMouseButtonEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysPrimaryMouseButtonEvents_X = "setDelaysPrimaryMouseButtonEvents:";
		static readonly NativeHandle selSetDelaysPrimaryMouseButtonEvents_XHandle = Selector.GetHandle ("setDelaysPrimaryMouseButtonEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysRotationEvents_X = "setDelaysRotationEvents:";
		static readonly NativeHandle selSetDelaysRotationEvents_XHandle = Selector.GetHandle ("setDelaysRotationEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelaysSecondaryMouseButtonEvents_X = "setDelaysSecondaryMouseButtonEvents:";
		static readonly NativeHandle selSetDelaysSecondaryMouseButtonEvents_XHandle = Selector.GetHandle ("setDelaysSecondaryMouseButtonEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPressureConfiguration_X = "setPressureConfiguration:";
		static readonly NativeHandle selSetPressureConfiguration_XHandle = Selector.GetHandle ("setPressureConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetState_X = "setState:";
		static readonly NativeHandle selSetState_XHandle = Selector.GetHandle ("setState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTarget_X = "setTarget:";
		static readonly NativeHandle selSetTarget_XHandle = Selector.GetHandle ("setTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldBeRequiredToFailByGestureRecognizer_X = "shouldBeRequiredToFailByGestureRecognizer:";
		static readonly NativeHandle selShouldBeRequiredToFailByGestureRecognizer_XHandle = Selector.GetHandle ("shouldBeRequiredToFailByGestureRecognizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldRequireFailureOfGestureRecognizer_X = "shouldRequireFailureOfGestureRecognizer:";
		static readonly NativeHandle selShouldRequireFailureOfGestureRecognizer_XHandle = Selector.GetHandle ("shouldRequireFailureOfGestureRecognizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateX = "state";
		static readonly NativeHandle selStateXHandle = Selector.GetHandle ("state");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabletPoint_X = "tabletPoint:";
		static readonly NativeHandle selTabletPoint_XHandle = Selector.GetHandle ("tabletPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetX = "target";
		static readonly NativeHandle selTargetXHandle = Selector.GetHandle ("target");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesBeganWithEvent_X = "touchesBeganWithEvent:";
		static readonly NativeHandle selTouchesBeganWithEvent_XHandle = Selector.GetHandle ("touchesBeganWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesCancelledWithEvent_X = "touchesCancelledWithEvent:";
		static readonly NativeHandle selTouchesCancelledWithEvent_XHandle = Selector.GetHandle ("touchesCancelledWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesEndedWithEvent_X = "touchesEndedWithEvent:";
		static readonly NativeHandle selTouchesEndedWithEvent_XHandle = Selector.GetHandle ("touchesEndedWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesMovedWithEvent_X = "touchesMovedWithEvent:";
		static readonly NativeHandle selTouchesMovedWithEvent_XHandle = Selector.GetHandle ("touchesMovedWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewX = "view";
		static readonly NativeHandle selViewXHandle = Selector.GetHandle ("view");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSGestureRecognizer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSGestureRecognizer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSGestureRecognizer () : base (NSObjectFlag.Empty)
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
		public NSGestureRecognizer (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSGestureRecognizer (NSObjectFlag t) : base (t)
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
		protected internal NSGestureRecognizer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTarget:action:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSGestureRecognizer (NSObject? target, Selector? action)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTarget_Action_XHandle, target__handle__, action__handle__), "initWithTarget:action:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTarget_Action_XHandle, target__handle__, action__handle__), "initWithTarget:action:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (action);
		}
		[Export ("canBePreventedByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanBePrevented (NSGestureRecognizer preventingGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var preventingGestureRecognizer__handle__ = preventingGestureRecognizer!.GetNonNullHandle (nameof (preventingGestureRecognizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanBePreventedByGestureRecognizer_XHandle, preventingGestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanBePreventedByGestureRecognizer_XHandle, preventingGestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preventingGestureRecognizer);
			return ret != 0;
		}
		[Export ("canPreventGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPrevent (NSGestureRecognizer preventedGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var preventedGestureRecognizer__handle__ = preventedGestureRecognizer!.GetNonNullHandle (nameof (preventedGestureRecognizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanPreventGestureRecognizer_XHandle, preventedGestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanPreventGestureRecognizer_XHandle, preventedGestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preventedGestureRecognizer);
			return ret != 0;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("flagsChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlagsChanged (NSEvent flagEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var flagEvent__handle__ = flagEvent!.GetNonNullHandle (nameof (flagEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFlagsChanged_XHandle, flagEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFlagsChanged_XHandle, flagEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flagEvent);
		}
		[Export ("keyDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void KeyDown (NSEvent keyEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var keyEvent__handle__ = keyEvent!.GetNonNullHandle (nameof (keyEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selKeyDown_XHandle, keyEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selKeyDown_XHandle, keyEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyEvent);
		}
		[Export ("keyUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void KeyUp (NSEvent keyEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var keyEvent__handle__ = keyEvent!.GetNonNullHandle (nameof (keyEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selKeyUp_XHandle, keyEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selKeyUp_XHandle, keyEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyEvent);
		}
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint LocationInView (NSView? view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (this.Handle, selLocationInView_XHandle, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocationInView_XHandle, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("magnifyWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Magnify (NSEvent magnifyEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var magnifyEvent__handle__ = magnifyEvent!.GetNonNullHandle (nameof (magnifyEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMagnifyWithEvent_XHandle, magnifyEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMagnifyWithEvent_XHandle, magnifyEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (magnifyEvent);
		}
		[Export ("mouseCancelled:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseCancelled (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseCancelled_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseCancelled_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("mouseDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDown (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseDown_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseDown_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("mouseDragged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDragged (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseDragged_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseDragged_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("mouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseUp (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseUp_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseUp_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("otherMouseDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OtherMouseDown (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOtherMouseDown_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOtherMouseDown_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("otherMouseDragged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OtherMouseDragged (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOtherMouseDragged_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOtherMouseDragged_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("otherMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OtherMouseUp (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOtherMouseUp_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOtherMouseUp_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("pressureChangeWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PressureChange (NSEvent pressureChangeEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pressureChangeEvent__handle__ = pressureChangeEvent!.GetNonNullHandle (nameof (pressureChangeEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPressureChangeWithEvent_XHandle, pressureChangeEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPressureChangeWithEvent_XHandle, pressureChangeEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pressureChangeEvent);
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rightMouseDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RightMouseDown (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRightMouseDown_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRightMouseDown_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("rightMouseDragged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RightMouseDragged (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRightMouseDragged_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRightMouseDragged_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("rightMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RightMouseUp (NSEvent mouseEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRightMouseUp_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRightMouseUp_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
		}
		[Export ("rotateWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rotate (NSEvent rotateEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var rotateEvent__handle__ = rotateEvent!.GetNonNullHandle (nameof (rotateEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRotateWithEvent_XHandle, rotateEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRotateWithEvent_XHandle, rotateEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rotateEvent);
		}
		[Export ("shouldBeRequiredToFailByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeRequiredToFailByGestureRecognizer (NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selShouldBeRequiredToFailByGestureRecognizer_XHandle, otherGestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selShouldBeRequiredToFailByGestureRecognizer_XHandle, otherGestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		[Export ("shouldRequireFailureOfGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRequireFailureOfGestureRecognizer (NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selShouldRequireFailureOfGestureRecognizer_XHandle, otherGestureRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selShouldRequireFailureOfGestureRecognizer_XHandle, otherGestureRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		[Export ("tabletPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TabletPoint (NSEvent tabletEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabletEvent__handle__ = tabletEvent!.GetNonNullHandle (nameof (tabletEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTabletPoint_XHandle, tabletEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTabletPoint_XHandle, tabletEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabletEvent);
		}
		[Export ("touchesBeganWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TouchesBegan (NSEvent touchEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touchEvent__handle__ = touchEvent!.GetNonNullHandle (nameof (touchEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTouchesBeganWithEvent_XHandle, touchEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTouchesBeganWithEvent_XHandle, touchEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touchEvent);
		}
		[Export ("touchesCancelledWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TouchesCancelled (NSEvent touchEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touchEvent__handle__ = touchEvent!.GetNonNullHandle (nameof (touchEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTouchesCancelledWithEvent_XHandle, touchEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTouchesCancelledWithEvent_XHandle, touchEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touchEvent);
		}
		[Export ("touchesEndedWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TouchesEnded (NSEvent touchEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touchEvent__handle__ = touchEvent!.GetNonNullHandle (nameof (touchEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTouchesEndedWithEvent_XHandle, touchEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTouchesEndedWithEvent_XHandle, touchEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touchEvent);
		}
		[Export ("touchesMovedWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TouchesMoved (NSEvent touchEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touchEvent__handle__ = touchEvent!.GetNonNullHandle (nameof (touchEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTouchesMovedWithEvent_XHandle, touchEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTouchesMovedWithEvent_XHandle, touchEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touchEvent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? Action {
			[Export ("action")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAction:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAction_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAction_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysKeyEvents {
			[Export ("delaysKeyEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysKeyEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysKeyEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysKeyEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysKeyEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysKeyEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysMagnificationEvents {
			[Export ("delaysMagnificationEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysMagnificationEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysMagnificationEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysMagnificationEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysMagnificationEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysMagnificationEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysOtherMouseButtonEvents {
			[Export ("delaysOtherMouseButtonEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysOtherMouseButtonEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysOtherMouseButtonEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysOtherMouseButtonEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysOtherMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysOtherMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysPrimaryMouseButtonEvents {
			[Export ("delaysPrimaryMouseButtonEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysPrimaryMouseButtonEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysPrimaryMouseButtonEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysPrimaryMouseButtonEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysPrimaryMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysPrimaryMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysRotationEvents {
			[Export ("delaysRotationEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysRotationEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysRotationEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysRotationEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysRotationEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysRotationEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysSecondaryMouseButtonEvents {
			[Export ("delaysSecondaryMouseButtonEvents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelaysSecondaryMouseButtonEventsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDelaysSecondaryMouseButtonEventsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysSecondaryMouseButtonEvents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelaysSecondaryMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDelaysSecondaryMouseButtonEvents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSGestureRecognizerDelegate Delegate {
			get {
				return (WeakDelegate as INSGestureRecognizerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSEventModifierMask ModifierFlags {
			[Export ("modifierFlags")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventModifierMask ret;
				if (IsDirectBinding) {
					ret = (NSEventModifierMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selModifierFlagsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventModifierMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selModifierFlagsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? Name {
			[Export ("name")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPressureConfiguration PressureConfiguration {
			[Export ("pressureConfiguration", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPressureConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPressureConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPressureConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPressureConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPressureConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPressureConfiguration:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPressureConfiguration_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPressureConfiguration_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGestureRecognizerState State {
			[Export ("state")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGestureRecognizerState ret;
				if (IsDirectBinding) {
					ret = (NSGestureRecognizerState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSGestureRecognizerState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setState:")]
			[Advice (@"Only subclasses of 'NSGestureRecognizer' can set this property.")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Target_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Target {
			[Export ("target", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTargetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTargetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTarget_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTarget_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Target_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView View {
			[Export ("view")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSGestureRecognizerDelegate); }
		}
		internal virtual _NSGestureRecognizerDelegate CreateInternalEventDelegateType ()
		{
			return (_NSGestureRecognizerDelegate)(new _NSGestureRecognizerDelegate());
		}
		internal _NSGestureRecognizerDelegate EnsureNSGestureRecognizerDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSGestureRecognizerDelegate;
			if (del is null){
				del = (_NSGestureRecognizerDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSGestureRecognizerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSGestureRecognizerDelegate : NSObject, INSGestureRecognizerDelegate { 
			public _NSGestureRecognizerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSGestureRecognizerDelegate))]
			static _NSGestureRecognizerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal NSGestureEvent? shouldAttemptToRecognize;
			[Export ("gestureRecognizer:shouldAttemptToRecognizeWithEvent:")]
			public bool ShouldAttemptToRecognize (NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
			{
				var handler = shouldAttemptToRecognize;
				if (handler is not null)
					return handler (gestureRecognizer, theEvent);
				return true!;
			}
			internal NSGesturesProbe? shouldBeRequiredToFail;
			[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
			public bool ShouldBeRequiredToFail (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
			{
				var handler = shouldBeRequiredToFail;
				if (handler is not null)
					return handler (gestureRecognizer, otherGestureRecognizer);
				return false!;
			}
			internal NSGestureProbe? shouldBegin;
			[Export ("gestureRecognizerShouldBegin:")]
			public bool ShouldBegin (NSGestureRecognizer gestureRecognizer)
			{
				var handler = shouldBegin;
				if (handler is not null)
					return handler (gestureRecognizer);
				return true!;
			}
			internal NSTouchEvent? shouldReceiveTouch;
			[Export ("gestureRecognizer:shouldReceiveTouch:")]
			public bool ShouldReceiveTouch (NSGestureRecognizer gestureRecognizer, NSTouch touch)
			{
				var handler = shouldReceiveTouch;
				if (handler is not null)
					return handler (gestureRecognizer, touch);
				return true!;
			}
			internal NSGesturesProbe? shouldRecognizeSimultaneously;
			[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
			public bool ShouldRecognizeSimultaneously (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
			{
				var handler = shouldRecognizeSimultaneously;
				if (handler is not null)
					return handler (gestureRecognizer, otherGestureRecognizer);
				return false!;
			}
			internal NSGesturesProbe? shouldRequireFailure;
			[Export ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
			public bool ShouldRequireFailure (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
			{
				var handler = shouldRequireFailure;
				if (handler is not null)
					return handler (gestureRecognizer, otherGestureRecognizer);
				return false!;
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSGestureEvent? ShouldAttemptToRecognize {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldAttemptToRecognize; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldAttemptToRecognize = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSGesturesProbe? ShouldBeRequiredToFail {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldBeRequiredToFail; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldBeRequiredToFail = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSGestureProbe? ShouldBegin {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldBegin; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldBegin = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTouchEvent? ShouldReceiveTouch {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldReceiveTouch; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldReceiveTouch = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSGesturesProbe? ShouldRecognizeSimultaneously {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldRecognizeSimultaneously; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldRecognizeSimultaneously = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSGesturesProbe? ShouldRequireFailure {
			get { return EnsureNSGestureRecognizerDelegate ()!.shouldRequireFailure; }
			set { EnsureNSGestureRecognizerDelegate ()!.shouldRequireFailure = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Target_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSGestureRecognizer */
}
