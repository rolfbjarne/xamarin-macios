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
	[Register("MTLAccelerationStructureMotionCurveGeometryDescriptor", true)]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class MTLAccelerationStructureMotionCurveGeometryDescriptor : MTLAccelerationStructureGeometryDescriptor {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlPointBuffersX = "controlPointBuffers";
		static readonly NativeHandle selControlPointBuffersXHandle = Selector.GetHandle ("controlPointBuffers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlPointCountX = "controlPointCount";
		static readonly NativeHandle selControlPointCountXHandle = Selector.GetHandle ("controlPointCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlPointFormatX = "controlPointFormat";
		static readonly NativeHandle selControlPointFormatXHandle = Selector.GetHandle ("controlPointFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlPointStrideX = "controlPointStride";
		static readonly NativeHandle selControlPointStrideXHandle = Selector.GetHandle ("controlPointStride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurveBasisX = "curveBasis";
		static readonly NativeHandle selCurveBasisXHandle = Selector.GetHandle ("curveBasis");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurveEndCapsX = "curveEndCaps";
		static readonly NativeHandle selCurveEndCapsXHandle = Selector.GetHandle ("curveEndCaps");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurveTypeX = "curveType";
		static readonly NativeHandle selCurveTypeXHandle = Selector.GetHandle ("curveType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorX = "descriptor";
		static readonly NativeHandle selDescriptorXHandle = Selector.GetHandle ("descriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexBufferX = "indexBuffer";
		static readonly NativeHandle selIndexBufferXHandle = Selector.GetHandle ("indexBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexBufferOffsetX = "indexBufferOffset";
		static readonly NativeHandle selIndexBufferOffsetXHandle = Selector.GetHandle ("indexBufferOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexTypeX = "indexType";
		static readonly NativeHandle selIndexTypeXHandle = Selector.GetHandle ("indexType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRadiusBuffersX = "radiusBuffers";
		static readonly NativeHandle selRadiusBuffersXHandle = Selector.GetHandle ("radiusBuffers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRadiusFormatX = "radiusFormat";
		static readonly NativeHandle selRadiusFormatXHandle = Selector.GetHandle ("radiusFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRadiusStrideX = "radiusStride";
		static readonly NativeHandle selRadiusStrideXHandle = Selector.GetHandle ("radiusStride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentControlPointCountX = "segmentControlPointCount";
		static readonly NativeHandle selSegmentControlPointCountXHandle = Selector.GetHandle ("segmentControlPointCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentCountX = "segmentCount";
		static readonly NativeHandle selSegmentCountXHandle = Selector.GetHandle ("segmentCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlPointBuffers_X = "setControlPointBuffers:";
		static readonly NativeHandle selSetControlPointBuffers_XHandle = Selector.GetHandle ("setControlPointBuffers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlPointCount_X = "setControlPointCount:";
		static readonly NativeHandle selSetControlPointCount_XHandle = Selector.GetHandle ("setControlPointCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlPointFormat_X = "setControlPointFormat:";
		static readonly NativeHandle selSetControlPointFormat_XHandle = Selector.GetHandle ("setControlPointFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlPointStride_X = "setControlPointStride:";
		static readonly NativeHandle selSetControlPointStride_XHandle = Selector.GetHandle ("setControlPointStride:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurveBasis_X = "setCurveBasis:";
		static readonly NativeHandle selSetCurveBasis_XHandle = Selector.GetHandle ("setCurveBasis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurveEndCaps_X = "setCurveEndCaps:";
		static readonly NativeHandle selSetCurveEndCaps_XHandle = Selector.GetHandle ("setCurveEndCaps:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurveType_X = "setCurveType:";
		static readonly NativeHandle selSetCurveType_XHandle = Selector.GetHandle ("setCurveType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndexBuffer_X = "setIndexBuffer:";
		static readonly NativeHandle selSetIndexBuffer_XHandle = Selector.GetHandle ("setIndexBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndexBufferOffset_X = "setIndexBufferOffset:";
		static readonly NativeHandle selSetIndexBufferOffset_XHandle = Selector.GetHandle ("setIndexBufferOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndexType_X = "setIndexType:";
		static readonly NativeHandle selSetIndexType_XHandle = Selector.GetHandle ("setIndexType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRadiusBuffers_X = "setRadiusBuffers:";
		static readonly NativeHandle selSetRadiusBuffers_XHandle = Selector.GetHandle ("setRadiusBuffers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRadiusFormat_X = "setRadiusFormat:";
		static readonly NativeHandle selSetRadiusFormat_XHandle = Selector.GetHandle ("setRadiusFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRadiusStride_X = "setRadiusStride:";
		static readonly NativeHandle selSetRadiusStride_XHandle = Selector.GetHandle ("setRadiusStride:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSegmentControlPointCount_X = "setSegmentControlPointCount:";
		static readonly NativeHandle selSetSegmentControlPointCount_XHandle = Selector.GetHandle ("setSegmentControlPointCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSegmentCount_X = "setSegmentCount:";
		static readonly NativeHandle selSetSegmentCount_XHandle = Selector.GetHandle ("setSegmentCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTLAccelerationStructureMotionCurveGeometryDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MTLAccelerationStructureMotionCurveGeometryDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MTLAccelerationStructureMotionCurveGeometryDescriptor () : base (NSObjectFlag.Empty)
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
		protected MTLAccelerationStructureMotionCurveGeometryDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MTLAccelerationStructureMotionCurveGeometryDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("descriptor")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLAccelerationStructureMotionCurveGeometryDescriptor GetDescriptor ()
		{
			MTLAccelerationStructureMotionCurveGeometryDescriptor ret;
			ret =  Runtime.GetNSObject<MTLAccelerationStructureMotionCurveGeometryDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDescriptorXHandle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLMotionKeyframeData[] ControlPointBuffers {
			[Export ("controlPointBuffers", ArgumentSemantic.Copy)]
			get {
				MTLMotionKeyframeData[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MTLMotionKeyframeData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControlPointBuffersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MTLMotionKeyframeData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControlPointBuffersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlPointBuffers:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetControlPointBuffers_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetControlPointBuffers_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ControlPointCount {
			[Export ("controlPointCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlPointCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlPointCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setControlPointCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlPointCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlPointCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLAttributeFormat ControlPointFormat {
			[Export ("controlPointFormat", ArgumentSemantic.Assign)]
			get {
				MTLAttributeFormat ret;
				if (IsDirectBinding) {
					ret = (MTLAttributeFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlPointFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLAttributeFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlPointFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlPointFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlPointFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlPointFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ControlPointStride {
			[Export ("controlPointStride")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlPointStrideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlPointStrideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setControlPointStride:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlPointStride_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlPointStride_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLCurveBasis CurveBasis {
			[Export ("curveBasis", ArgumentSemantic.Assign)]
			get {
				MTLCurveBasis ret;
				if (IsDirectBinding) {
					ret = (MTLCurveBasis) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurveBasisXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLCurveBasis) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCurveBasisXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCurveBasis:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCurveBasis_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCurveBasis_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLCurveEndCaps CurveEndCaps {
			[Export ("curveEndCaps", ArgumentSemantic.Assign)]
			get {
				MTLCurveEndCaps ret;
				if (IsDirectBinding) {
					ret = (MTLCurveEndCaps) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurveEndCapsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLCurveEndCaps) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCurveEndCapsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCurveEndCaps:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCurveEndCaps_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCurveEndCaps_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLCurveType CurveType {
			[Export ("curveType", ArgumentSemantic.Assign)]
			get {
				MTLCurveType ret;
				if (IsDirectBinding) {
					ret = (MTLCurveType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurveTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLCurveType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCurveTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCurveType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCurveType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCurveType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLBuffer? IndexBuffer {
			[Export ("indexBuffer", ArgumentSemantic.Retain)]
			get {
				IMTLBuffer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIndexBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMTLBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIndexBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setIndexBuffer:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetIndexBuffer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetIndexBuffer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint IndexBufferOffset {
			[Export ("indexBufferOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selIndexBufferOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selIndexBufferOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIndexBufferOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetIndexBufferOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetIndexBufferOffset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLIndexType IndexType {
			[Export ("indexType", ArgumentSemantic.Assign)]
			get {
				MTLIndexType ret;
				if (IsDirectBinding) {
					ret = (MTLIndexType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selIndexTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLIndexType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selIndexTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setIndexType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetIndexType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetIndexType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLMotionKeyframeData[] RadiusBuffers {
			[Export ("radiusBuffers", ArgumentSemantic.Copy)]
			get {
				MTLMotionKeyframeData[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MTLMotionKeyframeData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRadiusBuffersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MTLMotionKeyframeData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRadiusBuffersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRadiusBuffers:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRadiusBuffers_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRadiusBuffers_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLAttributeFormat RadiusFormat {
			[Export ("radiusFormat", ArgumentSemantic.Assign)]
			get {
				MTLAttributeFormat ret;
				if (IsDirectBinding) {
					ret = (MTLAttributeFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRadiusFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLAttributeFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRadiusFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRadiusFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRadiusFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRadiusFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint RadiusStride {
			[Export ("radiusStride")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRadiusStrideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRadiusStrideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRadiusStride:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRadiusStride_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRadiusStride_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SegmentControlPointCount {
			[Export ("segmentControlPointCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSegmentControlPointCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSegmentControlPointCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSegmentControlPointCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSegmentControlPointCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSegmentControlPointCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SegmentCount {
			[Export ("segmentCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSegmentCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSegmentCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSegmentCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSegmentCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSegmentCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MTLAccelerationStructureMotionCurveGeometryDescriptor */
}
