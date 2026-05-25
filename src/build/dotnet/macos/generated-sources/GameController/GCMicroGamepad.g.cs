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
	/// <summary>A logical mapping of hardware controller controls to a set of in-game elements.</summary><remarks><para>This type is implemented by the Apple TV remote. It maps an <c>A</c> button, an <c>X</c> button, and an analog D-pad as a touchpad.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/GameController/GCMicroGamepad">Apple documentation for <c>GCMicroGamepad</c></related>
	[Register("GCMicroGamepad", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GCMicroGamepad : GCPhysicalInputProfile {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsRotationX = "allowsRotation";
		static readonly NativeHandle selAllowsRotationXHandle = Selector.GetHandle ("allowsRotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonAX = "buttonA";
		static readonly NativeHandle selButtonAXHandle = Selector.GetHandle ("buttonA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonMenuX = "buttonMenu";
		static readonly NativeHandle selButtonMenuXHandle = Selector.GetHandle ("buttonMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonXX = "buttonX";
		static readonly NativeHandle selButtonXXHandle = Selector.GetHandle ("buttonX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControllerX = "controller";
		static readonly NativeHandle selControllerXHandle = Selector.GetHandle ("controller");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDpadX = "dpad";
		static readonly NativeHandle selDpadXHandle = Selector.GetHandle ("dpad");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReportsAbsoluteDpadValuesX = "reportsAbsoluteDpadValues";
		static readonly NativeHandle selReportsAbsoluteDpadValuesXHandle = Selector.GetHandle ("reportsAbsoluteDpadValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveSnapshotX = "saveSnapshot";
		static readonly NativeHandle selSaveSnapshotXHandle = Selector.GetHandle ("saveSnapshot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsRotation_X = "setAllowsRotation:";
		static readonly NativeHandle selSetAllowsRotation_XHandle = Selector.GetHandle ("setAllowsRotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReportsAbsoluteDpadValues_X = "setReportsAbsoluteDpadValues:";
		static readonly NativeHandle selSetReportsAbsoluteDpadValues_XHandle = Selector.GetHandle ("setReportsAbsoluteDpadValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStateFromMicroGamepad_X = "setStateFromMicroGamepad:";
		static readonly NativeHandle selSetStateFromMicroGamepad_XHandle = Selector.GetHandle ("setStateFromMicroGamepad:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValueChangedHandler_X = "setValueChangedHandler:";
		static readonly NativeHandle selSetValueChangedHandler_XHandle = Selector.GetHandle ("setValueChangedHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueChangedHandlerX = "valueChangedHandler";
		static readonly NativeHandle selValueChangedHandlerXHandle = Selector.GetHandle ("valueChangedHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GCMicroGamepad");
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
		protected GCMicroGamepad (NSObjectFlag t) : base (t)
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
		protected internal GCMicroGamepad (NativeHandle handle) : base (handle)
		{
		}

		[Export ("setStateFromMicroGamepad:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetState (GCMicroGamepad microGamepad)
		{
			var microGamepad__handle__ = microGamepad!.GetNonNullHandle (nameof (microGamepad));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStateFromMicroGamepad_XHandle, microGamepad__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStateFromMicroGamepad_XHandle, microGamepad__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (microGamepad);
		}
		/// <summary>Gets or sets a value that controls whether the D-pad changes between portrait and landscape mode on the controller as its orientation changes.</summary><value><see langword="true" /> if the D-pad matches the device's orientation. Otherwise, <see langword="false" />. The default is <see langword="false" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsRotation {
			[Export ("allowsRotation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsRotation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsRotation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the <c>A</c> button.</summary><value>The <c>A</c> button.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonA {
			[Export ("buttonA", ArgumentSemantic.Retain)]
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
		/// <summary>Gets the <c>X</c> button.</summary><value>The <c>X</c> button.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerButtonInput ButtonX {
			[Export ("buttonX", ArgumentSemantic.Retain)]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Controller_var;
		/// <summary>Gets the controller for this profile.</summary><value>The controller for this profile.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets the D-pad.</summary><value>The D-pad.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerDirectionPad Dpad {
			[Export ("dpad", ArgumentSemantic.Retain)]
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
		/// <summary>Gets or sets a value that controls whether D-pad values are measured from the physical center of the touchpad or from the point that the user first touches. </summary><value>A value that controls whether D-pad values are measured from the physical center of the touchpad or from the point that the user first touches. The default is <see langword="false" />, to indicate that inputs are measured from the place that the user first touches.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReportsAbsoluteDpadValues {
			[Export ("reportsAbsoluteDpadValues")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReportsAbsoluteDpadValuesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReportsAbsoluteDpadValuesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setReportsAbsoluteDpadValues:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetReportsAbsoluteDpadValues_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetReportsAbsoluteDpadValues_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gest the current state of the controller.</summary><value>The current state of the controller.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GCController.Capture()' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GCController.Capture()' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GCMicroGamepadSnapshot SaveSnapshot {
			[Export ("saveSnapshot")]
			get {
				GCMicroGamepadSnapshot? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GCMicroGamepadSnapshot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSaveSnapshotXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GCMicroGamepadSnapshot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSaveSnapshotXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a handler that is called whenever the state of any controller element changes</summary><value><para>A handler that is called whenever any immediate child element changes.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para>This handler is called once for each element change. It is only called for directly attached elements.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual GCMicroGamepadValueChangedHandler? ValueChangedHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGCMicroGamepadValueChangedHandler))]
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
				return global::ObjCRuntime.Trampolines.NIDGCMicroGamepadValueChangedHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGCMicroGamepadValueChangedHandler))]
			[Export ("setValueChangedHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDGCMicroGamepadValueChangedHandler.CreateNullableBlock (value);
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
	} /* class GCMicroGamepad */
}
