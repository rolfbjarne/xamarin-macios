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
namespace GLKit {
	/// <summary>A class that holds properties that configure the coordinate transforms to be applied when rendering an effect.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyTransform_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyTransform</c></related>
	[Register("GLKEffectPropertyTransform", true)]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GLKEffectPropertyTransform : GLKEffectProperty {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModelviewMatrixX = "modelviewMatrix";
		static readonly NativeHandle selModelviewMatrixXHandle = Selector.GetHandle ("modelviewMatrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalMatrixX = "normalMatrix";
		static readonly NativeHandle selNormalMatrixXHandle = Selector.GetHandle ("normalMatrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProjectionMatrixX = "projectionMatrix";
		static readonly NativeHandle selProjectionMatrixXHandle = Selector.GetHandle ("projectionMatrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetModelviewMatrix_X = "setModelviewMatrix:";
		static readonly NativeHandle selSetModelviewMatrix_XHandle = Selector.GetHandle ("setModelviewMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProjectionMatrix_X = "setProjectionMatrix:";
		static readonly NativeHandle selSetProjectionMatrix_XHandle = Selector.GetHandle ("setProjectionMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GLKEffectPropertyTransform");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GLKEffectPropertyTransform" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GLKEffectPropertyTransform () : base (NSObjectFlag.Empty)
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
		protected GLKEffectPropertyTransform (NSObjectFlag t) : base (t)
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
		protected internal GLKEffectPropertyTransform (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Matrix4x4 ModelViewMatrix {
			[Export ("modelviewMatrix", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Matrix4x4 ret = default(global::System.Numerics.Matrix4x4);
				IntPtr ret_alloced = Marshal.AllocHGlobal (Marshal.SizeOf<global::System.Numerics.Matrix4x4> () + 16);
				IntPtr aligned_ret = new IntPtr (((nint) (ret_alloced + 15) >> 4) << 4);
				bool aligned_assigned = false;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.Matrix4x4_objc_msgSend (this.Handle, selModelviewMatrixXHandle);
					} else {
						global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_stret ((IntPtr*) aligned_ret, this.Handle, selModelviewMatrixXHandle);
						aligned_assigned = true;
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.Matrix4x4_objc_msgSendSuper (&__objc_super__, selModelviewMatrixXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_stret ((IntPtr*) aligned_ret, &__objc_super__, selModelviewMatrixXHandle);
							aligned_assigned = true;
							GC.KeepAlive (this);
						}
					}
				}
				if (aligned_assigned)
					unsafe { ret = *(global::System.Numerics.Matrix4x4 *) aligned_ret; }
				Marshal.FreeHGlobal (ret_alloced);
				return ret;
			}
			[Export ("setModelviewMatrix:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Matrix4x4 (this.Handle, selSetModelviewMatrix_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Matrix4x4 (&__objc_super__, selSetModelviewMatrix_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual RMatrix3 NormalMatrix {
			[Export ("normalMatrix")]
			get {
				RMatrix3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.RMatrix3_objc_msgSend (this.Handle, selNormalMatrixXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.RMatrix3_objc_msgSend_stret (this.Handle, selNormalMatrixXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.RMatrix3_objc_msgSendSuper (&__objc_super__, selNormalMatrixXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.RMatrix3_objc_msgSendSuper_stret (&__objc_super__, selNormalMatrixXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Matrix4x4 ProjectionMatrix {
			[Export ("projectionMatrix", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Matrix4x4 ret = default(global::System.Numerics.Matrix4x4);
				IntPtr ret_alloced = Marshal.AllocHGlobal (Marshal.SizeOf<global::System.Numerics.Matrix4x4> () + 16);
				IntPtr aligned_ret = new IntPtr (((nint) (ret_alloced + 15) >> 4) << 4);
				bool aligned_assigned = false;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.Matrix4x4_objc_msgSend (this.Handle, selProjectionMatrixXHandle);
					} else {
						global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_stret ((IntPtr*) aligned_ret, this.Handle, selProjectionMatrixXHandle);
						aligned_assigned = true;
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.Matrix4x4_objc_msgSendSuper (&__objc_super__, selProjectionMatrixXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_stret ((IntPtr*) aligned_ret, &__objc_super__, selProjectionMatrixXHandle);
							aligned_assigned = true;
							GC.KeepAlive (this);
						}
					}
				}
				if (aligned_assigned)
					unsafe { ret = *(global::System.Numerics.Matrix4x4 *) aligned_ret; }
				Marshal.FreeHGlobal (ret_alloced);
				return ret;
			}
			[Export ("setProjectionMatrix:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Matrix4x4 (this.Handle, selSetProjectionMatrix_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Matrix4x4 (&__objc_super__, selSetProjectionMatrix_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class GLKEffectPropertyTransform */
}
