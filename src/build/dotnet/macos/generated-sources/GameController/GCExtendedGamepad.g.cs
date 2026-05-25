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
namespace GameController {
	/// <summary>A gamepad with two shoulder buttons, two triggers, two thumbsticks, a D-Pad, and a directional button array.</summary><remarks><para>Application developers should not instantiate this class. Rather, they should use the instance read from the <see cref="P:GameController.GCController.ExtendedGamepad" /> property.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameController/Reference/GCExtendedGamePad_Ref/index.html">Apple documentation for <c>GCExtendedGamepad</c></related>
	[Register("GCExtendedGamepad", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GCExtendedGamepad : GCPhysicalInputProfile {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonAX = "buttonA";
		static readonly NativeHandle selButtonAXHandle = Selector.GetHandle ("buttonA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonBX = "buttonB";
		static readonly NativeHandle selButtonBXHandle = Selector.GetHandle ("buttonB");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonHomeX = "buttonHome";
		static readonly NativeHandle selButtonHomeXHandle = Selector.GetHandle ("buttonHome");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonMenuX = "buttonMenu";
		static readonly NativeHandle selButtonMenuXHandle = Selector.GetHandle ("buttonMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonOptionsX = "buttonOptions";
		static readonly NativeHandle selButtonOptionsXHandle = Selector.GetHandle ("buttonOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonXX = "buttonX";
		static readonly NativeHandle selButtonXXHandle = Selector.GetHandle ("buttonX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonYX = "buttonY";
		static readonly NativeHandle selButtonYXHandle = Selector.GetHandle ("buttonY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControllerX = "controller";
		static readonly NativeHandle selControllerXHandle = Selector.GetHandle ("controller");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDpadX = "dpad";
		static readonly NativeHandle selDpadXHandle = Selector.GetHandle ("dpad");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftShoulderX = "leftShoulder";
		static readonly NativeHandle selLeftShoulderXHandle = Selector.GetHandle ("leftShoulder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftThumbstickX = "leftThumbstick";
		static readonly NativeHandle selLeftThumbstickXHandle = Selector.GetHandle ("leftThumbstick");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftThumbstickButtonX = "leftThumbstickButton";
		static readonly NativeHandle selLeftThumbstickButtonXHandle = Selector.GetHandle ("leftThumbstickButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftTriggerX = "leftTrigger";
		static readonly NativeHandle selLeftTriggerXHandle = Selector.GetHandle ("leftTrigger");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightShoulderX = "rightShoulder";
		static readonly NativeHandle selRightShoulderXHandle = Selector.GetHandle ("rightShoulder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightThumbstickX = "rightThumbstick";
		static readonly NativeHandle selRightThumbstickXHandle = Selector.GetHandle ("rightThumbstick");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightThumbstickButtonX = "rightThumbstickButton";
		static readonly NativeHandle selRightThumbstickButtonXHandle = Selector.GetHandle ("rightThumbstickButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightTriggerX = "rightTrigger";
		static readonly NativeHandle selRightTriggerXHandle = Selector.GetHandle ("rightTrigger");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveSnapshotX = "saveSnapshot";
		static readonly NativeHandle selSaveSnapshotXHandle = Selector.GetHandle ("saveSnapshot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStateFromExtendedGamepad_X = "setStateFromExtendedGamepad:";
		static readonly NativeHandle selSetStateFromExtendedGamepad_XHandle = Selector.GetHandle ("setStateFromExtendedGamepad:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValueChangedHandler_X = "setValueChangedHandler:";
		static readonly NativeHandle selSetValueChangedHandler_XHandle = Selector.GetHandle ("setValueChangedHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueChangedHandlerX = "valueChangedHandler";
		static readonly NativeHandle selValueChangedHandlerXHandle = Selector.GetHandle ("valueChangedHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GCExtendedGamepad");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected GCExtendedGamepad (NSObjectFlag t) : base (t)
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
		protected internal GCExtendedGamepad (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("saveSnapshot")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GCController.Capture()' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCExtendedGamepadSnapshot SaveSnapshot ()
		{
			GCExtendedGamepadSnapshot ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GCExtendedGamepadSnapshot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSaveSnapshotXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GCExtendedGamepadSnapshot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSaveSnapshotXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setStateFromExtendedGamepad:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetState (GCExtendedGamepad extendedGamepad)
		{
			var extendedGamepad__handle__ = extendedGamepad!.GetNonNullHandle (nameof (extendedGamepad));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStateFromExtendedGamepad_XHandle, extendedGamepad__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStateFromExtendedGamepad_XHandle, extendedGamepad__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (extendedGamepad);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonA {
			[Export ("buttonA")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonAXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonAXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonB {
			[Export ("buttonB")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonBXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonBXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual GCControllerButtonInput? ButtonHome {
			[Export ("buttonHome")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonHomeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonHomeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual GCControllerButtonInput ButtonMenu {
			[Export ("buttonMenu")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual GCControllerButtonInput? ButtonOptions {
			[Export ("buttonOptions")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonOptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonOptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonX {
			[Export ("buttonX")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonXXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonXXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonY {
			[Export ("buttonY")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonYXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonYXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Controller_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCController? Controller {
			[Export ("controller", ArgumentSemantic.Assign)]
			get {
				GCController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControllerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControllerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Controller_var = ret;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerDirectionPad DPad {
			[Export ("dpad")]
			get {
				GCControllerDirectionPad? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDpadXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDpadXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput LeftShoulder {
			[Export ("leftShoulder")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftShoulderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftShoulderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerDirectionPad LeftThumbstick {
			[Export ("leftThumbstick")]
			get {
				GCControllerDirectionPad? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftThumbstickXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftThumbstickXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GCControllerButtonInput? LeftThumbstickButton {
			[Export ("leftThumbstickButton")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftThumbstickButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftThumbstickButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput LeftTrigger {
			[Export ("leftTrigger")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftTriggerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftTriggerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput RightShoulder {
			[Export ("rightShoulder")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightShoulderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightShoulderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerDirectionPad RightThumbstick {
			[Export ("rightThumbstick")]
			get {
				GCControllerDirectionPad? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightThumbstickXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerDirectionPad> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightThumbstickXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GCControllerButtonInput? RightThumbstickButton {
			[Export ("rightThumbstickButton")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightThumbstickButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightThumbstickButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput RightTrigger {
			[Export ("rightTrigger")]
			get {
				GCControllerButtonInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightTriggerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCControllerButtonInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightTriggerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual GCExtendedGamepadValueChangedHandler? ValueChangedHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGCExtendedGamepadValueChangedHandler))]
			[Export ("valueChangedHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueChangedHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueChangedHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDGCExtendedGamepadValueChangedHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGCExtendedGamepadValueChangedHandler))]
			[Export ("setValueChangedHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDGCExtendedGamepadValueChangedHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetValueChangedHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetValueChangedHandler_XHandle, (IntPtr) block_ptr_value);
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
				__mt_Controller_var = null;
			}
		}
	} /* class GCExtendedGamepad */
}
