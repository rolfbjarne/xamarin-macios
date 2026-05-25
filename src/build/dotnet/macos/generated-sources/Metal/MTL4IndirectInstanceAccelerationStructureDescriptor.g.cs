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
namespace Metal {
	[Register("MTL4IndirectInstanceAccelerationStructureDescriptor", true)]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	public unsafe partial class MTL4IndirectInstanceAccelerationStructureDescriptor : MTL4AccelerationStructureDescriptor {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceCountBufferX = "instanceCountBuffer";
		static readonly NativeHandle selInstanceCountBufferXHandle = Selector.GetHandle ("instanceCountBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceDescriptorBufferX = "instanceDescriptorBuffer";
		static readonly NativeHandle selInstanceDescriptorBufferXHandle = Selector.GetHandle ("instanceDescriptorBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceDescriptorStrideX = "instanceDescriptorStride";
		static readonly NativeHandle selInstanceDescriptorStrideXHandle = Selector.GetHandle ("instanceDescriptorStride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceDescriptorTypeX = "instanceDescriptorType";
		static readonly NativeHandle selInstanceDescriptorTypeXHandle = Selector.GetHandle ("instanceDescriptorType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceTransformationMatrixLayoutX = "instanceTransformationMatrixLayout";
		static readonly NativeHandle selInstanceTransformationMatrixLayoutXHandle = Selector.GetHandle ("instanceTransformationMatrixLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxInstanceCountX = "maxInstanceCount";
		static readonly NativeHandle selMaxInstanceCountXHandle = Selector.GetHandle ("maxInstanceCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxMotionTransformCountX = "maxMotionTransformCount";
		static readonly NativeHandle selMaxMotionTransformCountXHandle = Selector.GetHandle ("maxMotionTransformCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMotionTransformBufferX = "motionTransformBuffer";
		static readonly NativeHandle selMotionTransformBufferXHandle = Selector.GetHandle ("motionTransformBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMotionTransformCountBufferX = "motionTransformCountBuffer";
		static readonly NativeHandle selMotionTransformCountBufferXHandle = Selector.GetHandle ("motionTransformCountBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMotionTransformStrideX = "motionTransformStride";
		static readonly NativeHandle selMotionTransformStrideXHandle = Selector.GetHandle ("motionTransformStride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMotionTransformTypeX = "motionTransformType";
		static readonly NativeHandle selMotionTransformTypeXHandle = Selector.GetHandle ("motionTransformType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstanceCountBuffer_X = "setInstanceCountBuffer:";
		static readonly NativeHandle selSetInstanceCountBuffer_XHandle = Selector.GetHandle ("setInstanceCountBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstanceDescriptorBuffer_X = "setInstanceDescriptorBuffer:";
		static readonly NativeHandle selSetInstanceDescriptorBuffer_XHandle = Selector.GetHandle ("setInstanceDescriptorBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstanceDescriptorStride_X = "setInstanceDescriptorStride:";
		static readonly NativeHandle selSetInstanceDescriptorStride_XHandle = Selector.GetHandle ("setInstanceDescriptorStride:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstanceDescriptorType_X = "setInstanceDescriptorType:";
		static readonly NativeHandle selSetInstanceDescriptorType_XHandle = Selector.GetHandle ("setInstanceDescriptorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstanceTransformationMatrixLayout_X = "setInstanceTransformationMatrixLayout:";
		static readonly NativeHandle selSetInstanceTransformationMatrixLayout_XHandle = Selector.GetHandle ("setInstanceTransformationMatrixLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxInstanceCount_X = "setMaxInstanceCount:";
		static readonly NativeHandle selSetMaxInstanceCount_XHandle = Selector.GetHandle ("setMaxInstanceCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxMotionTransformCount_X = "setMaxMotionTransformCount:";
		static readonly NativeHandle selSetMaxMotionTransformCount_XHandle = Selector.GetHandle ("setMaxMotionTransformCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMotionTransformBuffer_X = "setMotionTransformBuffer:";
		static readonly NativeHandle selSetMotionTransformBuffer_XHandle = Selector.GetHandle ("setMotionTransformBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMotionTransformCountBuffer_X = "setMotionTransformCountBuffer:";
		static readonly NativeHandle selSetMotionTransformCountBuffer_XHandle = Selector.GetHandle ("setMotionTransformCountBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMotionTransformStride_X = "setMotionTransformStride:";
		static readonly NativeHandle selSetMotionTransformStride_XHandle = Selector.GetHandle ("setMotionTransformStride:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMotionTransformType_X = "setMotionTransformType:";
		static readonly NativeHandle selSetMotionTransformType_XHandle = Selector.GetHandle ("setMotionTransformType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTL4IndirectInstanceAccelerationStructureDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MTL4IndirectInstanceAccelerationStructureDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MTL4IndirectInstanceAccelerationStructureDescriptor () : base (NSObjectFlag.Empty)
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
		protected MTL4IndirectInstanceAccelerationStructureDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MTL4IndirectInstanceAccelerationStructureDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4BufferRange InstanceCountBuffer {
			[Export ("instanceCountBuffer", ArgumentSemantic.Assign)]
			get {
				MTL4BufferRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSend (this.Handle, selInstanceCountBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSendSuper (&__objc_super__, selInstanceCountBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInstanceCountBuffer:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTL4BufferRange (this.Handle, selSetInstanceCountBuffer_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTL4BufferRange (&__objc_super__, selSetInstanceCountBuffer_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4BufferRange InstanceDescriptorBuffer {
			[Export ("instanceDescriptorBuffer", ArgumentSemantic.Assign)]
			get {
				MTL4BufferRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSend (this.Handle, selInstanceDescriptorBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSendSuper (&__objc_super__, selInstanceDescriptorBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInstanceDescriptorBuffer:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTL4BufferRange (this.Handle, selSetInstanceDescriptorBuffer_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTL4BufferRange (&__objc_super__, selSetInstanceDescriptorBuffer_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint InstanceDescriptorStride {
			[Export ("instanceDescriptorStride")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInstanceDescriptorStrideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInstanceDescriptorStrideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInstanceDescriptorStride:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetInstanceDescriptorStride_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetInstanceDescriptorStride_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLAccelerationStructureInstanceDescriptorType InstanceDescriptorType {
			[Export ("instanceDescriptorType", ArgumentSemantic.Assign)]
			get {
				MTLAccelerationStructureInstanceDescriptorType ret;
				if (IsDirectBinding) {
					ret = (MTLAccelerationStructureInstanceDescriptorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInstanceDescriptorTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLAccelerationStructureInstanceDescriptorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInstanceDescriptorTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInstanceDescriptorType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetInstanceDescriptorType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetInstanceDescriptorType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLMatrixLayout InstanceTransformationMatrixLayout {
			[Export ("instanceTransformationMatrixLayout", ArgumentSemantic.Assign)]
			get {
				MTLMatrixLayout ret;
				if (IsDirectBinding) {
					ret = (MTLMatrixLayout) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInstanceTransformationMatrixLayoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLMatrixLayout) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInstanceTransformationMatrixLayoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInstanceTransformationMatrixLayout:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInstanceTransformationMatrixLayout_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetInstanceTransformationMatrixLayout_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxInstanceCount {
			[Export ("maxInstanceCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxInstanceCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxInstanceCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxInstanceCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxInstanceCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxInstanceCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxMotionTransformCount {
			[Export ("maxMotionTransformCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxMotionTransformCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxMotionTransformCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxMotionTransformCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxMotionTransformCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxMotionTransformCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4BufferRange MotionTransformBuffer {
			[Export ("motionTransformBuffer", ArgumentSemantic.Assign)]
			get {
				MTL4BufferRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSend (this.Handle, selMotionTransformBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSendSuper (&__objc_super__, selMotionTransformBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMotionTransformBuffer:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTL4BufferRange (this.Handle, selSetMotionTransformBuffer_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTL4BufferRange (&__objc_super__, selSetMotionTransformBuffer_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4BufferRange MotionTransformCountBuffer {
			[Export ("motionTransformCountBuffer", ArgumentSemantic.Assign)]
			get {
				MTL4BufferRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSend (this.Handle, selMotionTransformCountBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MTL4BufferRange_objc_msgSendSuper (&__objc_super__, selMotionTransformCountBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMotionTransformCountBuffer:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTL4BufferRange (this.Handle, selSetMotionTransformCountBuffer_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTL4BufferRange (&__objc_super__, selSetMotionTransformCountBuffer_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MotionTransformStride {
			[Export ("motionTransformStride")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMotionTransformStrideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMotionTransformStrideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMotionTransformStride:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMotionTransformStride_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMotionTransformStride_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLTransformType MotionTransformType {
			[Export ("motionTransformType", ArgumentSemantic.Assign)]
			get {
				MTLTransformType ret;
				if (IsDirectBinding) {
					ret = (MTLTransformType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMotionTransformTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLTransformType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMotionTransformTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMotionTransformType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMotionTransformType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMotionTransformType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MTL4IndirectInstanceAccelerationStructureDescriptor */
}
