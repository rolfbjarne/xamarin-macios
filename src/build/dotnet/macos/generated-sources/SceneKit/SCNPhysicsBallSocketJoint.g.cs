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
	/// <summary>An SCNPhysicsBehavior that allows two SCNPhysicsBody objects to pivot around each other.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNPhysicsBallSocketJoint_Class/index.html">Apple documentation for <c>SCNPhysicsBallSocketJoint</c></related>
	[Register("SCNPhysicsBallSocketJoint", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNPhysicsBallSocketJoint : SCNPhysicsBehavior {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorAX = "anchorA";
		static readonly NativeHandle selAnchorAXHandle = Selector.GetHandle ("anchorA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorBX = "anchorB";
		static readonly NativeHandle selAnchorBXHandle = Selector.GetHandle ("anchorB");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyAX = "bodyA";
		static readonly NativeHandle selBodyAXHandle = Selector.GetHandle ("bodyA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyBX = "bodyB";
		static readonly NativeHandle selBodyBXHandle = Selector.GetHandle ("bodyB");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJointWithBody_Anchor_X = "jointWithBody:anchor:";
		static readonly NativeHandle selJointWithBody_Anchor_XHandle = Selector.GetHandle ("jointWithBody:anchor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJointWithBodyA_AnchorA_BodyB_AnchorB_X = "jointWithBodyA:anchorA:bodyB:anchorB:";
		static readonly NativeHandle selJointWithBodyA_AnchorA_BodyB_AnchorB_XHandle = Selector.GetHandle ("jointWithBodyA:anchorA:bodyB:anchorB:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnchorA_X = "setAnchorA:";
		static readonly NativeHandle selSetAnchorA_XHandle = Selector.GetHandle ("setAnchorA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnchorB_X = "setAnchorB:";
		static readonly NativeHandle selSetAnchorB_XHandle = Selector.GetHandle ("setAnchorB:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNPhysicsBallSocketJoint");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public SCNPhysicsBallSocketJoint (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected SCNPhysicsBallSocketJoint (NSObjectFlag t) : base (t)
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
		protected internal SCNPhysicsBallSocketJoint (NativeHandle handle) : base (handle)
		{
		}

		[Export ("jointWithBodyA:anchorA:bodyB:anchorB:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNPhysicsBallSocketJoint Create (SCNPhysicsBody bodyA, SCNVector3 anchorA, SCNPhysicsBody bodyB, SCNVector3 anchorB)
		{
			var bodyA__handle__ = bodyA!.GetNonNullHandle (nameof (bodyA));
			var bodyB__handle__ = bodyB!.GetNonNullHandle (nameof (bodyB));
			SCNPhysicsBallSocketJoint? ret;
			ret =  Runtime.GetNSObject<SCNPhysicsBallSocketJoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_SCNVector3_NativeHandle_SCNVector3 (class_ptr, selJointWithBodyA_AnchorA_BodyB_AnchorB_XHandle, bodyA__handle__, anchorA, bodyB__handle__, anchorB), false)!;
			GC.KeepAlive (bodyA);
			GC.KeepAlive (bodyB);
			return ret!;
		}
		[Export ("jointWithBody:anchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNPhysicsBallSocketJoint Create (SCNPhysicsBody body, SCNVector3 anchor)
		{
			var body__handle__ = body!.GetNonNullHandle (nameof (body));
			SCNPhysicsBallSocketJoint? ret;
			ret =  Runtime.GetNSObject<SCNPhysicsBallSocketJoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_SCNVector3 (class_ptr, selJointWithBody_Anchor_XHandle, body__handle__, anchor), false)!;
			GC.KeepAlive (body);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 AnchorA {
			[Export ("anchorA")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, selAnchorAXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret (this.Handle, selAnchorAXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, selAnchorAXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret (&__objc_super__, selAnchorAXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setAnchorA:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, selSetAnchorA_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, selSetAnchorA_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 AnchorB {
			[Export ("anchorB")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, selAnchorBXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret (this.Handle, selAnchorBXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, selAnchorBXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret (&__objc_super__, selAnchorBXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setAnchorB:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, selSetAnchorB_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, selSetAnchorB_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsBody BodyA {
			[Export ("bodyA")]
			get {
				SCNPhysicsBody? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBodyAXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBodyAXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsBody? BodyB {
			[Export ("bodyB")]
			get {
				SCNPhysicsBody? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBodyBXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBodyBXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SCNPhysicsBallSocketJoint */
}
