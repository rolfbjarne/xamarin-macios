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
namespace SceneKit {
	[Register("SCNCameraController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNCameraController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticTargetX = "automaticTarget";
		static readonly NativeHandle selAutomaticTargetXHandle = Selector.GetHandle ("automaticTarget");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginInteraction_WithViewport_X = "beginInteraction:withViewport:";
		static readonly NativeHandle selBeginInteraction_WithViewport_XHandle = Selector.GetHandle ("beginInteraction:withViewport:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearRollX = "clearRoll";
		static readonly NativeHandle selClearRollXHandle = Selector.GetHandle ("clearRoll");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueInteraction_WithViewport_Sensitivity_X = "continueInteraction:withViewport:sensitivity:";
		static readonly NativeHandle selContinueInteraction_WithViewport_Sensitivity_XHandle = Selector.GetHandle ("continueInteraction:withViewport:sensitivity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDollyBy_OnScreenPoint_Viewport_X = "dollyBy:onScreenPoint:viewport:";
		static readonly NativeHandle selDollyBy_OnScreenPoint_Viewport_XHandle = Selector.GetHandle ("dollyBy:onScreenPoint:viewport:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDollyToTarget_X = "dollyToTarget:";
		static readonly NativeHandle selDollyToTarget_XHandle = Selector.GetHandle ("dollyToTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndInteraction_WithViewport_Velocity_X = "endInteraction:withViewport:velocity:";
		static readonly NativeHandle selEndInteraction_WithViewport_Velocity_XHandle = Selector.GetHandle ("endInteraction:withViewport:velocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameNodes_X = "frameNodes:";
		static readonly NativeHandle selFrameNodes_XHandle = Selector.GetHandle ("frameNodes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInertiaEnabledX = "inertiaEnabled";
		static readonly NativeHandle selInertiaEnabledXHandle = Selector.GetHandle ("inertiaEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInertiaFrictionX = "inertiaFriction";
		static readonly NativeHandle selInertiaFrictionXHandle = Selector.GetHandle ("inertiaFriction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInteractionModeX = "interactionMode";
		static readonly NativeHandle selInteractionModeXHandle = Selector.GetHandle ("interactionMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInertiaRunningX = "isInertiaRunning";
		static readonly NativeHandle selIsInertiaRunningXHandle = Selector.GetHandle ("isInertiaRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumHorizontalAngleX = "maximumHorizontalAngle";
		static readonly NativeHandle selMaximumHorizontalAngleXHandle = Selector.GetHandle ("maximumHorizontalAngle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumVerticalAngleX = "maximumVerticalAngle";
		static readonly NativeHandle selMaximumVerticalAngleXHandle = Selector.GetHandle ("maximumVerticalAngle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumHorizontalAngleX = "minimumHorizontalAngle";
		static readonly NativeHandle selMinimumHorizontalAngleXHandle = Selector.GetHandle ("minimumHorizontalAngle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumVerticalAngleX = "minimumVerticalAngle";
		static readonly NativeHandle selMinimumVerticalAngleXHandle = Selector.GetHandle ("minimumVerticalAngle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointOfViewX = "pointOfView";
		static readonly NativeHandle selPointOfViewXHandle = Selector.GetHandle ("pointOfView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRollAroundTarget_X = "rollAroundTarget:";
		static readonly NativeHandle selRollAroundTarget_XHandle = Selector.GetHandle ("rollAroundTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRollBy_AroundScreenPoint_Viewport_X = "rollBy:aroundScreenPoint:viewport:";
		static readonly NativeHandle selRollBy_AroundScreenPoint_Viewport_XHandle = Selector.GetHandle ("rollBy:aroundScreenPoint:viewport:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateByX_Y_X = "rotateByX:Y:";
		static readonly NativeHandle selRotateByX_Y_XHandle = Selector.GetHandle ("rotateByX:Y:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticTarget_X = "setAutomaticTarget:";
		static readonly NativeHandle selSetAutomaticTarget_XHandle = Selector.GetHandle ("setAutomaticTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInertiaEnabled_X = "setInertiaEnabled:";
		static readonly NativeHandle selSetInertiaEnabled_XHandle = Selector.GetHandle ("setInertiaEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInertiaFriction_X = "setInertiaFriction:";
		static readonly NativeHandle selSetInertiaFriction_XHandle = Selector.GetHandle ("setInertiaFriction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInteractionMode_X = "setInteractionMode:";
		static readonly NativeHandle selSetInteractionMode_XHandle = Selector.GetHandle ("setInteractionMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumHorizontalAngle_X = "setMaximumHorizontalAngle:";
		static readonly NativeHandle selSetMaximumHorizontalAngle_XHandle = Selector.GetHandle ("setMaximumHorizontalAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumVerticalAngle_X = "setMaximumVerticalAngle:";
		static readonly NativeHandle selSetMaximumVerticalAngle_XHandle = Selector.GetHandle ("setMaximumVerticalAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumHorizontalAngle_X = "setMinimumHorizontalAngle:";
		static readonly NativeHandle selSetMinimumHorizontalAngle_XHandle = Selector.GetHandle ("setMinimumHorizontalAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumVerticalAngle_X = "setMinimumVerticalAngle:";
		static readonly NativeHandle selSetMinimumVerticalAngle_XHandle = Selector.GetHandle ("setMinimumVerticalAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPointOfView_X = "setPointOfView:";
		static readonly NativeHandle selSetPointOfView_XHandle = Selector.GetHandle ("setPointOfView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTarget_X = "setTarget:";
		static readonly NativeHandle selSetTarget_XHandle = Selector.GetHandle ("setTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWorldUp_X = "setWorldUp:";
		static readonly NativeHandle selSetWorldUp_XHandle = Selector.GetHandle ("setWorldUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopInertiaX = "stopInertia";
		static readonly NativeHandle selStopInertiaXHandle = Selector.GetHandle ("stopInertia");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetX = "target";
		static readonly NativeHandle selTargetXHandle = Selector.GetHandle ("target");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTranslateInCameraSpaceByX_Y_Z_X = "translateInCameraSpaceByX:Y:Z:";
		static readonly NativeHandle selTranslateInCameraSpaceByX_Y_Z_XHandle = Selector.GetHandle ("translateInCameraSpaceByX:Y:Z:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorldUpX = "worldUp";
		static readonly NativeHandle selWorldUpXHandle = Selector.GetHandle ("worldUp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNCameraController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCNCameraController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNCameraController () : base (NSObjectFlag.Empty)
		{
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
		protected SCNCameraController (NSObjectFlag t) : base (t)
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
		protected internal SCNCameraController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("beginInteraction:withViewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginInteraction (CGPoint location, CGSize viewport)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGSize (this.Handle, selBeginInteraction_WithViewport_XHandle, location, viewport);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGSize (&__objc_super__, selBeginInteraction_WithViewport_XHandle, location, viewport);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("clearRoll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearRoll ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearRollXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClearRollXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="location">To be added.</param><param name="viewport">To be added.</param><param name="sensitivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("continueInteraction:withViewport:sensitivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueInteraction (CGPoint location, CGSize viewport, nfloat sensitivity)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGSize_nfloat (this.Handle, selContinueInteraction_WithViewport_Sensitivity_XHandle, location, viewport, sensitivity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGSize_nfloat (&__objc_super__, selContinueInteraction_WithViewport_Sensitivity_XHandle, location, viewport, sensitivity);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dollyBy:onScreenPoint:viewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dolly (float delta, CGPoint screenPoint, CGSize viewport)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_CGPoint_CGSize (this.Handle, selDollyBy_OnScreenPoint_Viewport_XHandle, delta, screenPoint, viewport);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_CGPoint_CGSize (&__objc_super__, selDollyBy_OnScreenPoint_Viewport_XHandle, delta, screenPoint, viewport);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dollyToTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DollyToTarget (float delta)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selDollyToTarget_XHandle, delta);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selDollyToTarget_XHandle, delta);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("endInteraction:withViewport:velocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInteraction (CGPoint location, CGSize viewport, CGPoint velocity)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGSize_CGPoint (this.Handle, selEndInteraction_WithViewport_Velocity_XHandle, location, viewport, velocity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGSize_CGPoint (&__objc_super__, selEndInteraction_WithViewport_Velocity_XHandle, location, viewport, velocity);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("frameNodes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FrameNodes (SCNNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFrameNodes_XHandle, nsa_nodes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFrameNodes_XHandle, nsa_nodes.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rollBy:aroundScreenPoint:viewport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Roll (float delta, CGPoint screenPoint, CGSize viewport)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_CGPoint_CGSize (this.Handle, selRollBy_AroundScreenPoint_Viewport_XHandle, delta, screenPoint, viewport);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_CGPoint_CGSize (&__objc_super__, selRollBy_AroundScreenPoint_Viewport_XHandle, delta, screenPoint, viewport);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rollAroundTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RollAroundTarget (float delta)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selRollAroundTarget_XHandle, delta);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selRollAroundTarget_XHandle, delta);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rotateByX:Y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rotate (float deltaX, float deltaY)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_float (this.Handle, selRotateByX_Y_XHandle, deltaX, deltaY);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_float (&__objc_super__, selRotateByX_Y_XHandle, deltaX, deltaY);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopInertia")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopInertia ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopInertiaXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopInertiaXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("translateInCameraSpaceByX:Y:Z:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TranslateInCameraSpace (float deltaX, float deltaY, float deltaZ)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_float_float (this.Handle, selTranslateInCameraSpaceByX_Y_Z_XHandle, deltaX, deltaY, deltaZ);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_float_float (&__objc_super__, selTranslateInCameraSpaceByX_Y_Z_XHandle, deltaX, deltaY, deltaZ);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticTarget {
			[Export ("automaticTarget")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutomaticTargetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutomaticTargetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticTarget:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticTarget_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticTarget_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISCNCameraControllerDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				ISCNCameraControllerDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISCNCameraControllerDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<ISCNCameraControllerDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
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
				__mt_Delegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InertiaEnabled {
			[Export ("inertiaEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selInertiaEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selInertiaEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInertiaEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetInertiaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetInertiaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float InertiaFriction {
			[Export ("inertiaFriction")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selInertiaFrictionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selInertiaFrictionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInertiaFriction:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetInertiaFriction_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetInertiaFriction_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InertiaRunning {
			[Export ("isInertiaRunning")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInertiaRunningXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInertiaRunningXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNInteractionMode InteractionMode {
			[Export ("interactionMode", ArgumentSemantic.Assign)]
			get {
				SCNInteractionMode ret;
				if (IsDirectBinding) {
					ret = (SCNInteractionMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInteractionModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNInteractionMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInteractionModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractionMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInteractionMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetInteractionMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumHorizontalAngle {
			[Export ("maximumHorizontalAngle")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumHorizontalAngleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaximumHorizontalAngleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumHorizontalAngle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumHorizontalAngle_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMaximumHorizontalAngle_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumVerticalAngle {
			[Export ("maximumVerticalAngle")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumVerticalAngleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaximumVerticalAngleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumVerticalAngle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumVerticalAngle_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMaximumVerticalAngle_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinimumHorizontalAngle {
			[Export ("minimumHorizontalAngle")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumHorizontalAngleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinimumHorizontalAngleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumHorizontalAngle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumHorizontalAngle_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMinimumHorizontalAngle_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinimumVerticalAngle {
			[Export ("minimumVerticalAngle")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumVerticalAngleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinimumVerticalAngleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumVerticalAngle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumVerticalAngle_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMinimumVerticalAngle_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode? PointOfView {
			[Export ("pointOfView", ArgumentSemantic.Retain)]
			get {
				SCNNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPointOfViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPointOfViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPointOfView:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPointOfView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPointOfView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 Target {
			[Export ("target", ArgumentSemantic.Assign)]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, selTargetXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret (this.Handle, selTargetXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, selTargetXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret (&__objc_super__, selTargetXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, selSetTarget_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, selSetTarget_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 WorldUp {
			[Export ("worldUp", ArgumentSemantic.Assign)]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, selWorldUpXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret (this.Handle, selWorldUpXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, selWorldUpXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret (&__objc_super__, selWorldUpXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setWorldUp:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, selSetWorldUp_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, selSetWorldUp_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class SCNCameraController */
}
